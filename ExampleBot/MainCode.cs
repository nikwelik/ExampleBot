using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using ExampleBot;
using SC2APIProtocol;

namespace SC2Sharp
{
    class Bot : SC2API_CSharp.Bot
    {
        private bool messageGLHFSent;

        private ulong BuildingProbe;

        private Unit MainPylon = null;

        public int GateWayCount = 0;

        public int PylonCount = 0;

        public Stopwatch GameTime { get; set; }
        public void OnStart(ResponseGameInfo gameInfo, ResponseData data, ResponsePing pingResponse, ResponseObservation observation, uint playerId, string opponentID)
        {
            GameTime = Stopwatch.StartNew();
        }
        public IEnumerable<Action> OnFrame(ResponseObservation observation)
        {
            List<Action> actions = new List<Action>();

            SendChat(actions);

            BuildProbes(observation, actions);

            BuildFirstPylon(observation, actions);

            BuildGateWay(observation, actions);

            BuildZealots(observation, actions);

            BuildPylon(observation, actions);

            AttackZealots(observation, actions);

            return actions;
        }
        
        public void OnEnd(ResponseObservation observation, Result result)
        { }

        public void SendChat(List<Action> actions)
        {
            if (GameTime.Elapsed.TotalSeconds > 5 && !messageGLHFSent)
            {
                var chatAction = new Action { ActionChat = new ActionChat { Message = "glhf" } };
                actions.Add(chatAction);
                messageGLHFSent = true;
            }
        }
        public void BuildProbes(ResponseObservation observation, List<Action> actions)
        {
            var probes = observation.Observation.RawData.Units.Where(d => d.UnitType == UnitTypes.PROBE && d.Alliance == Alliance.Self);

            var nexus = observation.Observation.RawData.Units.Where(d => d.UnitType == UnitTypes.NEXUS && d.Alliance == Alliance.Self).FirstOrDefault();

            if (observation.Observation.PlayerCommon.Minerals >= 50  && probes.Count() < 17 && nexus.Orders.Count() < 1)
            {
                var command = new ActionRawUnitCommand
                {
                    AbilityId = 1006//probe
                };

                command.UnitTags.Add(nexus.Tag);
                command.QueueCommand = true;

                actions.Add(new Action { ActionRaw = new ActionRaw { UnitCommand = command } });
            }
        }
        public void BuildZealots(ResponseObservation observation, List<Action> actions)
        {

            var gateways = observation.Observation.RawData.Units.Where(d => d.UnitType == UnitTypes.GATEWAY && d.Alliance == Alliance.Self).ToList();
            if (gateways.Count() == 0)
            {
                return;
            }
            foreach (var n in gateways) 
            {
                if (observation.Observation.PlayerCommon.Minerals >= 100 && n.Orders.Count() < 1)
                {
                    var command = new ActionRawUnitCommand
                    {
                        AbilityId = 916 // zealot
                    };
                    command.UnitTags.Add(n.Tag);
                    command.QueueCommand = true;

                    actions.Add(new Action { ActionRaw = new ActionRaw { UnitCommand = command } });
                }
            }
        }
        public void AttackZealots(ResponseObservation observation, List<Action> actions)
        {
            var nexus = observation.Observation.RawData.Units.Where(d => d.UnitType == UnitTypes.NEXUS && d.Alliance == Alliance.Self).FirstOrDefault();

            var zealots = observation.Observation.RawData.Units.Where(d => d.UnitType == UnitTypes.ZEALOT && d.Alliance == Alliance.Self);

            float EnemyPositionX = 160.5F;
            float EnemyPositionY = 46.5F;
            if (nexus.Pos.X == 160.5 && nexus.Pos.Y == 46.5)
            {
                EnemyPositionX = 55.5F;
                EnemyPositionY = 157.5F;
            }
            if (zealots.Count() < 5)
            {
                return;
            }

            foreach (var zealot in zealots)
            {
                var command = new ActionRawUnitCommand
                {
                    AbilityId = 23, //attack,
                    TargetWorldSpacePos = new Point2D { X = EnemyPositionX, Y = EnemyPositionY },
                };

                command.UnitTags.Add(zealot.Tag);
                command.QueueCommand = true;

                actions.Add(new Action { ActionRaw = new ActionRaw { UnitCommand = command } });
            }
        }
        public void BuildFirstPylon(ResponseObservation observation, List<Action> actions)
        {
            var pylons = observation.Observation.RawData.Units.Where(d => d.UnitType == UnitTypes.PYLON && d.Alliance == Alliance.Self).ToList();
            if (pylons.Count() >= 1)
            {
                if(MainPylon == null)
                {
                    MainPylon = pylons.FirstOrDefault();
                }

                return;
            }
            var probes = observation.Observation.RawData.Units.Where(d => d.UnitType == UnitTypes.PROBE && d.Alliance == Alliance.Self).ToList();


            var nexus = observation.Observation.RawData.Units.Where(d => d.UnitType == UnitTypes.NEXUS && d.Alliance == Alliance.Self).FirstOrDefault();

            if (observation.Observation.PlayerCommon.Minerals >= 100 && probes.Count() >= 13)
            {
                if (WeAreTop(observation))
                {
                    var command = new ActionRawUnitCommand
                    {
                        AbilityId = 881, //pylon
                        TargetWorldSpacePos = new Point2D { X = nexus.Pos.X, Y = nexus.Pos.Y - 8 },
                        QueueCommand = true
                    };

                    command.UnitTags.Add(MainBuildingProbe(probes));


                    actions.Add(new Action { ActionRaw = new ActionRaw { UnitCommand = command } });
                    PylonCount++;
                }
                else
                {
                    var command = new ActionRawUnitCommand
                    {
                        AbilityId = 881, //pylon
                        TargetWorldSpacePos = new Point2D { X = nexus.Pos.X, Y = nexus.Pos.Y + 8 },
                        QueueCommand = true
                    };

                    command.UnitTags.Add(MainBuildingProbe(probes));


                    actions.Add(new Action { ActionRaw = new ActionRaw { UnitCommand = command } });
                    PylonCount++;
                }
            }
        }
        public void BuildGateWay(ResponseObservation observation, List<Action> actions)
        {
            var probes = observation.Observation.RawData.Units.Where(d => d.UnitType == UnitTypes.PROBE && d.Alliance == Alliance.Self).ToList();

            if (probes.Count() <= 15)
                return;

            

            if (GateWayCount < 4 && observation.Observation.PlayerCommon.Minerals >= 150)
            {
                var command = new ActionRawUnitCommand
                {
                    AbilityId = 883, //gateway
                    TargetWorldSpacePos = new Point2D { X = MainPylon.Pos.X -6 + (GateWayCount * 3), Y = MainPylon.Pos.Y - 3 },
                    QueueCommand = true
                };

                command.UnitTags.Add(MainBuildingProbe(probes));


                actions.Add(new Action { ActionRaw = new ActionRaw { UnitCommand = command } });
                GateWayCount++;
            }

        }
        public bool WeAreTop(ResponseObservation observation)
        {
            var nexus = observation.Observation.RawData.Units.Where(d => d.UnitType == UnitTypes.NEXUS && d.Alliance == Alliance.Self).FirstOrDefault();

            return nexus.Pos.Y > 80;
        }

        public ulong MainBuildingProbe(List<Unit> probes)
        {
            if (BuildingProbe != 0)
            {
                return BuildingProbe;
            }
            var probe = probes.FirstOrDefault();

            BuildingProbe = probe.Tag;

            return BuildingProbe;
        }
        public void BuildPylon(ResponseObservation observation, List<Action> actions)
        {
            var probes = observation.Observation.RawData.Units.Where(d => d.UnitType == UnitTypes.PROBE && d.Alliance == Alliance.Self).ToList();

            if (observation.Observation.PlayerCommon.Minerals >= 200)
            {
                var command = new ActionRawUnitCommand
                {
                    AbilityId = 881, //pylon
                    TargetWorldSpacePos = new Point2D { X = MainPylon.Pos.X + (PylonCount * 2), Y = MainPylon.Pos.Y },
                    QueueCommand = true
                };

                command.UnitTags.Add(MainBuildingProbe(probes));


                actions.Add(new Action { ActionRaw = new ActionRaw { UnitCommand = command } });
                PylonCount++;
            }

        }
    }
}
