// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: s2clientprotocol/error.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace SC2APIProtocol {

  /// <summary>Holder for reflection information generated from s2clientprotocol/error.proto</summary>
  public static partial class ErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for s2clientprotocol/error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxzMmNsaWVudHByb3RvY29sL2Vycm9yLnByb3RvEg5TQzJBUElQcm90b2Nv",
            "bCrALQoMQWN0aW9uUmVzdWx0EhYKEkFjdGlvblJlc3VsdF9VTlNFVBAAEgsK",
            "B1N1Y2Nlc3MQARIQCgxOb3RTdXBwb3J0ZWQQAhIJCgVFcnJvchADEhYKEkNh",
            "bnRRdWV1ZVRoYXRPcmRlchAEEgkKBVJldHJ5EAUSDAoIQ29vbGRvd24QBhIP",
            "CgtRdWV1ZUlzRnVsbBAHEhQKEFJhbGx5UXVldWVJc0Z1bGwQCBIVChFOb3RF",
            "bm91Z2hNaW5lcmFscxAJEhQKEE5vdEVub3VnaFZlc3BlbmUQChIWChJOb3RF",
            "bm91Z2hUZXJyYXppbmUQCxITCg9Ob3RFbm91Z2hDdXN0b20QDBIRCg1Ob3RF",
            "bm91Z2hGb29kEA0SFwoTRm9vZFVzYWdlSW1wb3NzaWJsZRAOEhEKDU5vdEVu",
            "b3VnaExpZmUQDxIUChBOb3RFbm91Z2hTaGllbGRzEBASEwoPTm90RW5vdWdo",
            "RW5lcmd5EBESEgoOTGlmZVN1cHByZXNzZWQQEhIVChFTaGllbGRzU3VwcHJl",
            "c3NlZBATEhQKEEVuZXJneVN1cHByZXNzZWQQFBIUChBOb3RFbm91Z2hDaGFy",
            "Z2VzEBUSFgoSQ2FudEFkZE1vcmVDaGFyZ2VzEBYSEwoPVG9vTXVjaE1pbmVy",
            "YWxzEBcSEgoOVG9vTXVjaFZlc3BlbmUQGBIUChBUb29NdWNoVGVycmF6aW5l",
            "EBkSEQoNVG9vTXVjaEN1c3RvbRAaEg8KC1Rvb011Y2hGb29kEBsSDwoLVG9v",
            "TXVjaExpZmUQHBISCg5Ub29NdWNoU2hpZWxkcxAdEhEKDVRvb011Y2hFbmVy",
            "Z3kQHhIaChZNdXN0VGFyZ2V0VW5pdFdpdGhMaWZlEB8SHQoZTXVzdFRhcmdl",
            "dFVuaXRXaXRoU2hpZWxkcxAgEhwKGE11c3RUYXJnZXRVbml0V2l0aEVuZXJn",
            "eRAhEg0KCUNhbnRUcmFkZRAiEg0KCUNhbnRTcGVuZBAjEhYKEkNhbnRUYXJn",
            "ZXRUaGF0VW5pdBAkEhcKE0NvdWxkbnRBbGxvY2F0ZVVuaXQQJRIQCgxVbml0",
            "Q2FudE1vdmUQJhIeChpUcmFuc3BvcnRJc0hvbGRpbmdQb3NpdGlvbhAnEh8K",
            "G0J1aWxkVGVjaFJlcXVpcmVtZW50c05vdE1ldBAoEh0KGUNhbnRGaW5kUGxh",
            "Y2VtZW50TG9jYXRpb24QKRITCg9DYW50QnVpbGRPblRoYXQQKhIeChpDYW50",
            "QnVpbGRUb29DbG9zZVRvRHJvcE9mZhArEhwKGENhbnRCdWlsZExvY2F0aW9u",
            "SW52YWxpZBAsEhgKFENhbnRTZWVCdWlsZExvY2F0aW9uEC0SIgoeQ2FudEJ1",
            "aWxkVG9vQ2xvc2VUb0NyZWVwU291cmNlEC4SIAocQ2FudEJ1aWxkVG9vQ2xv",
            "c2VUb1Jlc291cmNlcxAvEhwKGENhbnRCdWlsZFRvb0ZhckZyb21XYXRlchAw",
            "EiIKHkNhbnRCdWlsZFRvb0ZhckZyb21DcmVlcFNvdXJjZRAxEicKI0NhbnRC",
            "dWlsZFRvb0ZhckZyb21CdWlsZFBvd2VyU291cmNlEDISGwoXQ2FudEJ1aWxk",
            "T25EZW5zZVRlcnJhaW4QMxInCiNDYW50VHJhaW5Ub29GYXJGcm9tVHJhaW5Q",
            "b3dlclNvdXJjZRA0EhsKF0NhbnRMYW5kTG9jYXRpb25JbnZhbGlkEDUSFwoT",
            "Q2FudFNlZUxhbmRMb2NhdGlvbhA2EiEKHUNhbnRMYW5kVG9vQ2xvc2VUb0Ny",
            "ZWVwU291cmNlEDcSHwobQ2FudExhbmRUb29DbG9zZVRvUmVzb3VyY2VzEDgS",
            "GwoXQ2FudExhbmRUb29GYXJGcm9tV2F0ZXIQORIhCh1DYW50TGFuZFRvb0Zh",
            "ckZyb21DcmVlcFNvdXJjZRA6EiYKIkNhbnRMYW5kVG9vRmFyRnJvbUJ1aWxk",
            "UG93ZXJTb3VyY2UQOxImCiJDYW50TGFuZFRvb0ZhckZyb21UcmFpblBvd2Vy",
            "U291cmNlEDwSGgoWQ2FudExhbmRPbkRlbnNlVGVycmFpbhA9EhsKF0FkZE9u",
            "VG9vRmFyRnJvbUJ1aWxkaW5nED4SGgoWTXVzdEJ1aWxkUmVmaW5lcnlGaXJz",
            "dBA/Eh8KG0J1aWxkaW5nSXNVbmRlckNvbnN0cnVjdGlvbhBAEhMKD0NhbnRG",
            "aW5kRHJvcE9mZhBBEh0KGUNhbnRMb2FkT3RoZXJQbGF5ZXJzVW5pdHMQQhIb",
            "ChdOb3RFbm91Z2hSb29tVG9Mb2FkVW5pdBBDEhgKFENhbnRVbmxvYWRVbml0",
            "c1RoZXJlEEQSGAoUQ2FudFdhcnBJblVuaXRzVGhlcmUQRRIZChVDYW50TG9h",
            "ZEltbW9iaWxlVW5pdHMQRhIdChlDYW50UmVjaGFyZ2VJbW1vYmlsZVVuaXRz",
            "EEcSJgoiQ2FudFJlY2hhcmdlVW5kZXJDb25zdHJ1Y3Rpb25Vbml0cxBIEhQK",
            "EENhbnRMb2FkVGhhdFVuaXQQSRITCg9Ob0NhcmdvVG9VbmxvYWQQShIZChVM",
            "b2FkQWxsTm9UYXJnZXRzRm91bmQQSxIUChBOb3RXaGlsZU9jY3VwaWVkEEwS",
            "GQoVQ2FudEF0dGFja1dpdGhvdXRBbW1vEE0SFwoTQ2FudEhvbGRBbnlNb3Jl",
            "QW1tbxBOEhoKFlRlY2hSZXF1aXJlbWVudHNOb3RNZXQQTxIZChVNdXN0TG9j",
            "a2Rvd25Vbml0Rmlyc3QQUBISCg5NdXN0VGFyZ2V0VW5pdBBREhcKE011c3RU",
            "YXJnZXRJbnZlbnRvcnkQUhIZChVNdXN0VGFyZ2V0VmlzaWJsZVVuaXQQUxId",
            "ChlNdXN0VGFyZ2V0VmlzaWJsZUxvY2F0aW9uEFQSHgoaTXVzdFRhcmdldFdh",
            "bGthYmxlTG9jYXRpb24QVRIaChZNdXN0VGFyZ2V0UGF3bmFibGVVbml0EFYS",
            "GgoWWW91Q2FudENvbnRyb2xUaGF0VW5pdBBXEiIKHllvdUNhbnRJc3N1ZUNv",
            "bW1hbmRzVG9UaGF0VW5pdBBYEhcKE011c3RUYXJnZXRSZXNvdXJjZXMQWRIW",
            "ChJSZXF1aXJlc0hlYWxUYXJnZXQQWhIYChRSZXF1aXJlc1JlcGFpclRhcmdl",
            "dBBbEhEKDU5vSXRlbXNUb0Ryb3AQXBIYChRDYW50SG9sZEFueU1vcmVJdGVt",
            "cxBdEhAKDENhbnRIb2xkVGhhdBBeEhgKFFRhcmdldEhhc05vSW52ZW50b3J5",
            "EF8SFAoQQ2FudERyb3BUaGlzSXRlbRBgEhQKEENhbnRNb3ZlVGhpc0l0ZW0Q",
            "YRIUChBDYW50UGF3blRoaXNVbml0EGISFAoQTXVzdFRhcmdldENhc3RlchBj",
            "EhQKEENhbnRUYXJnZXRDYXN0ZXIQZBITCg9NdXN0VGFyZ2V0T3V0ZXIQZRIT",
            "Cg9DYW50VGFyZ2V0T3V0ZXIQZhIaChZNdXN0VGFyZ2V0WW91ck93blVuaXRz",
            "EGcSGgoWQ2FudFRhcmdldFlvdXJPd25Vbml0cxBoEhsKF011c3RUYXJnZXRG",
            "cmllbmRseVVuaXRzEGkSGwoXQ2FudFRhcmdldEZyaWVuZGx5VW5pdHMQahIa",
            "ChZNdXN0VGFyZ2V0TmV1dHJhbFVuaXRzEGsSGgoWQ2FudFRhcmdldE5ldXRy",
            "YWxVbml0cxBsEhgKFE11c3RUYXJnZXRFbmVteVVuaXRzEG0SGAoUQ2FudFRh",
            "cmdldEVuZW15VW5pdHMQbhIWChJNdXN0VGFyZ2V0QWlyVW5pdHMQbxIWChJD",
            "YW50VGFyZ2V0QWlyVW5pdHMQcBIZChVNdXN0VGFyZ2V0R3JvdW5kVW5pdHMQ",
            "cRIZChVDYW50VGFyZ2V0R3JvdW5kVW5pdHMQchIYChRNdXN0VGFyZ2V0U3Ry",
            "dWN0dXJlcxBzEhgKFENhbnRUYXJnZXRTdHJ1Y3R1cmVzEHQSGAoUTXVzdFRh",
            "cmdldExpZ2h0VW5pdHMQdRIYChRDYW50VGFyZ2V0TGlnaHRVbml0cxB2EhoK",
            "Fk11c3RUYXJnZXRBcm1vcmVkVW5pdHMQdxIaChZDYW50VGFyZ2V0QXJtb3Jl",
            "ZFVuaXRzEHgSHQoZTXVzdFRhcmdldEJpb2xvZ2ljYWxVbml0cxB5Eh0KGUNh",
            "bnRUYXJnZXRCaW9sb2dpY2FsVW5pdHMQehIZChVNdXN0VGFyZ2V0SGVyb2lj",
            "VW5pdHMQexIZChVDYW50VGFyZ2V0SGVyb2ljVW5pdHMQfBIaChZNdXN0VGFy",
            "Z2V0Um9ib3RpY1VuaXRzEH0SGgoWQ2FudFRhcmdldFJvYm90aWNVbml0cxB+",
            "Eh0KGU11c3RUYXJnZXRNZWNoYW5pY2FsVW5pdHMQfxIeChlDYW50VGFyZ2V0",
            "TWVjaGFuaWNhbFVuaXRzEIABEhsKFk11c3RUYXJnZXRQc2lvbmljVW5pdHMQ",
            "gQESGwoWQ2FudFRhcmdldFBzaW9uaWNVbml0cxCCARIbChZNdXN0VGFyZ2V0",
            "TWFzc2l2ZVVuaXRzEIMBEhsKFkNhbnRUYXJnZXRNYXNzaXZlVW5pdHMQhAES",
            "FgoRTXVzdFRhcmdldE1pc3NpbGUQhQESFgoRQ2FudFRhcmdldE1pc3NpbGUQ",
            "hgESGgoVTXVzdFRhcmdldFdvcmtlclVuaXRzEIcBEhoKFUNhbnRUYXJnZXRX",
            "b3JrZXJVbml0cxCIARIhChxNdXN0VGFyZ2V0RW5lcmd5Q2FwYWJsZVVuaXRz",
            "EIkBEiEKHENhbnRUYXJnZXRFbmVyZ3lDYXBhYmxlVW5pdHMQigESIQocTXVz",
            "dFRhcmdldFNoaWVsZENhcGFibGVVbml0cxCLARIhChxDYW50VGFyZ2V0U2hp",
            "ZWxkQ2FwYWJsZVVuaXRzEIwBEhUKEE11c3RUYXJnZXRGbHllcnMQjQESFQoQ",
            "Q2FudFRhcmdldEZseWVycxCOARIaChVNdXN0VGFyZ2V0QnVyaWVkVW5pdHMQ",
            "jwESGgoVQ2FudFRhcmdldEJ1cmllZFVuaXRzEJABEhsKFk11c3RUYXJnZXRD",
            "bG9ha2VkVW5pdHMQkQESGwoWQ2FudFRhcmdldENsb2FrZWRVbml0cxCSARIi",
            "Ch1NdXN0VGFyZ2V0VW5pdHNJbkFTdGFzaXNGaWVsZBCTARIiCh1DYW50VGFy",
            "Z2V0VW5pdHNJbkFTdGFzaXNGaWVsZBCUARIlCiBNdXN0VGFyZ2V0VW5kZXJD",
            "b25zdHJ1Y3Rpb25Vbml0cxCVARIlCiBDYW50VGFyZ2V0VW5kZXJDb25zdHJ1",
            "Y3Rpb25Vbml0cxCWARIYChNNdXN0VGFyZ2V0RGVhZFVuaXRzEJcBEhgKE0Nh",
            "bnRUYXJnZXREZWFkVW5pdHMQmAESHQoYTXVzdFRhcmdldFJldml2YWJsZVVu",
            "aXRzEJkBEh0KGENhbnRUYXJnZXRSZXZpdmFibGVVbml0cxCaARIaChVNdXN0",
            "VGFyZ2V0SGlkZGVuVW5pdHMQmwESGgoVQ2FudFRhcmdldEhpZGRlblVuaXRz",
            "EJwBEiIKHUNhbnRSZWNoYXJnZU90aGVyUGxheWVyc1VuaXRzEJ0BEh0KGE11",
            "c3RUYXJnZXRIYWxsdWNpbmF0aW9ucxCeARIdChhDYW50VGFyZ2V0SGFsbHVj",
            "aW5hdGlvbnMQnwESIAobTXVzdFRhcmdldEludnVsbmVyYWJsZVVuaXRzEKAB",
            "EiAKG0NhbnRUYXJnZXRJbnZ1bG5lcmFibGVVbml0cxChARIcChdNdXN0VGFy",
            "Z2V0RGV0ZWN0ZWRVbml0cxCiARIcChdDYW50VGFyZ2V0RGV0ZWN0ZWRVbml0",
            "cxCjARIdChhDYW50VGFyZ2V0VW5pdFdpdGhFbmVyZ3kQpAESHgoZQ2FudFRh",
            "cmdldFVuaXRXaXRoU2hpZWxkcxClARIhChxNdXN0VGFyZ2V0VW5jb21tYW5k",
            "YWJsZVVuaXRzEKYBEiEKHENhbnRUYXJnZXRVbmNvbW1hbmRhYmxlVW5pdHMQ",
            "pwESIQocTXVzdFRhcmdldFByZXZlbnREZWZlYXRVbml0cxCoARIhChxDYW50",
            "VGFyZ2V0UHJldmVudERlZmVhdFVuaXRzEKkBEiEKHE11c3RUYXJnZXRQcmV2",
            "ZW50UmV2ZWFsVW5pdHMQqgESIQocQ2FudFRhcmdldFByZXZlbnRSZXZlYWxV",
            "bml0cxCrARIbChZNdXN0VGFyZ2V0UGFzc2l2ZVVuaXRzEKwBEhsKFkNhbnRU",
            "YXJnZXRQYXNzaXZlVW5pdHMQrQESGwoWTXVzdFRhcmdldFN0dW5uZWRVbml0",
            "cxCuARIbChZDYW50VGFyZ2V0U3R1bm5lZFVuaXRzEK8BEhwKF011c3RUYXJn",
            "ZXRTdW1tb25lZFVuaXRzELABEhwKF0NhbnRUYXJnZXRTdW1tb25lZFVuaXRz",
            "ELEBEhQKD011c3RUYXJnZXRVc2VyMRCyARIUCg9DYW50VGFyZ2V0VXNlcjEQ",
            "swESHwoaTXVzdFRhcmdldFVuc3RvcHBhYmxlVW5pdHMQtAESHwoaQ2FudFRh",
            "cmdldFVuc3RvcHBhYmxlVW5pdHMQtQESHQoYTXVzdFRhcmdldFJlc2lzdGFu",
            "dFVuaXRzELYBEh0KGENhbnRUYXJnZXRSZXNpc3RhbnRVbml0cxC3ARIZChRN",
            "dXN0VGFyZ2V0RGF6ZWRVbml0cxC4ARIZChRDYW50VGFyZ2V0RGF6ZWRVbml0",
            "cxC5ARIRCgxDYW50TG9ja2Rvd24QugESFAoPQ2FudE1pbmRDb250cm9sELsB",
            "EhwKF011c3RUYXJnZXREZXN0cnVjdGlibGVzELwBEhwKF0NhbnRUYXJnZXRE",
            "ZXN0cnVjdGlibGVzEL0BEhQKD011c3RUYXJnZXRJdGVtcxC+ARIUCg9DYW50",
            "VGFyZ2V0SXRlbXMQvwESGAoTTm9DYWxsZG93bkF2YWlsYWJsZRDAARIVChBX",
            "YXlwb2ludExpc3RGdWxsEMEBEhMKDk11c3RUYXJnZXRSYWNlEMIBEhMKDkNh",
            "bnRUYXJnZXRSYWNlEMMBEhsKFk11c3RUYXJnZXRTaW1pbGFyVW5pdHMQxAES",
            "GwoWQ2FudFRhcmdldFNpbWlsYXJVbml0cxDFARIaChVDYW50RmluZEVub3Vn",
            "aFRhcmdldHMQxgESGQoUQWxyZWFkeVNwYXduaW5nTGFydmEQxwESIQocQ2Fu",
            "dFRhcmdldEV4aGF1c3RlZFJlc291cmNlcxDIARITCg5DYW50VXNlTWluaW1h",
            "cBDJARIVChBDYW50VXNlSW5mb1BhbmVsEMoBEhUKEE9yZGVyUXVldWVJc0Z1",
            "bGwQywESHAoXQ2FudEhhcnZlc3RUaGF0UmVzb3VyY2UQzAESGgoVSGFydmVz",
            "dGVyc05vdFJlcXVpcmVkEM0BEhQKD0FscmVhZHlUYXJnZXRlZBDOARIeChlD",
            "YW50QXR0YWNrV2VhcG9uc0Rpc2FibGVkEM8BEhcKEkNvdWxkbnRSZWFjaFRh",
            "cmdldBDQARIXChJUYXJnZXRJc091dE9mUmFuZ2UQ0QESFQoQVGFyZ2V0SXNU",
            "b29DbG9zZRDSARIVChBUYXJnZXRJc091dE9mQXJjENMBEh0KGENhbnRGaW5k",
            "VGVsZXBvcnRMb2NhdGlvbhDUARIVChBJbnZhbGlkSXRlbUNsYXNzENUBEhgK",
            "E0NhbnRGaW5kQ2FuY2VsT3JkZXIQ1gFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::SC2APIProtocol.ActionResult), }, null));
    }
    #endregion

  }
  #region Enums
  public enum ActionResult {
    [pbr::OriginalName("ActionResult_UNSET")] Unset = 0,
    [pbr::OriginalName("Success")] Success = 1,
    [pbr::OriginalName("NotSupported")] NotSupported = 2,
    [pbr::OriginalName("Error")] Error = 3,
    [pbr::OriginalName("CantQueueThatOrder")] CantQueueThatOrder = 4,
    [pbr::OriginalName("Retry")] Retry = 5,
    [pbr::OriginalName("Cooldown")] Cooldown = 6,
    [pbr::OriginalName("QueueIsFull")] QueueIsFull = 7,
    [pbr::OriginalName("RallyQueueIsFull")] RallyQueueIsFull = 8,
    [pbr::OriginalName("NotEnoughMinerals")] NotEnoughMinerals = 9,
    [pbr::OriginalName("NotEnoughVespene")] NotEnoughVespene = 10,
    [pbr::OriginalName("NotEnoughTerrazine")] NotEnoughTerrazine = 11,
    [pbr::OriginalName("NotEnoughCustom")] NotEnoughCustom = 12,
    [pbr::OriginalName("NotEnoughFood")] NotEnoughFood = 13,
    [pbr::OriginalName("FoodUsageImpossible")] FoodUsageImpossible = 14,
    [pbr::OriginalName("NotEnoughLife")] NotEnoughLife = 15,
    [pbr::OriginalName("NotEnoughShields")] NotEnoughShields = 16,
    [pbr::OriginalName("NotEnoughEnergy")] NotEnoughEnergy = 17,
    [pbr::OriginalName("LifeSuppressed")] LifeSuppressed = 18,
    [pbr::OriginalName("ShieldsSuppressed")] ShieldsSuppressed = 19,
    [pbr::OriginalName("EnergySuppressed")] EnergySuppressed = 20,
    [pbr::OriginalName("NotEnoughCharges")] NotEnoughCharges = 21,
    [pbr::OriginalName("CantAddMoreCharges")] CantAddMoreCharges = 22,
    [pbr::OriginalName("TooMuchMinerals")] TooMuchMinerals = 23,
    [pbr::OriginalName("TooMuchVespene")] TooMuchVespene = 24,
    [pbr::OriginalName("TooMuchTerrazine")] TooMuchTerrazine = 25,
    [pbr::OriginalName("TooMuchCustom")] TooMuchCustom = 26,
    [pbr::OriginalName("TooMuchFood")] TooMuchFood = 27,
    [pbr::OriginalName("TooMuchLife")] TooMuchLife = 28,
    [pbr::OriginalName("TooMuchShields")] TooMuchShields = 29,
    [pbr::OriginalName("TooMuchEnergy")] TooMuchEnergy = 30,
    [pbr::OriginalName("MustTargetUnitWithLife")] MustTargetUnitWithLife = 31,
    [pbr::OriginalName("MustTargetUnitWithShields")] MustTargetUnitWithShields = 32,
    [pbr::OriginalName("MustTargetUnitWithEnergy")] MustTargetUnitWithEnergy = 33,
    [pbr::OriginalName("CantTrade")] CantTrade = 34,
    [pbr::OriginalName("CantSpend")] CantSpend = 35,
    [pbr::OriginalName("CantTargetThatUnit")] CantTargetThatUnit = 36,
    [pbr::OriginalName("CouldntAllocateUnit")] CouldntAllocateUnit = 37,
    [pbr::OriginalName("UnitCantMove")] UnitCantMove = 38,
    [pbr::OriginalName("TransportIsHoldingPosition")] TransportIsHoldingPosition = 39,
    [pbr::OriginalName("BuildTechRequirementsNotMet")] BuildTechRequirementsNotMet = 40,
    [pbr::OriginalName("CantFindPlacementLocation")] CantFindPlacementLocation = 41,
    [pbr::OriginalName("CantBuildOnThat")] CantBuildOnThat = 42,
    [pbr::OriginalName("CantBuildTooCloseToDropOff")] CantBuildTooCloseToDropOff = 43,
    [pbr::OriginalName("CantBuildLocationInvalid")] CantBuildLocationInvalid = 44,
    [pbr::OriginalName("CantSeeBuildLocation")] CantSeeBuildLocation = 45,
    [pbr::OriginalName("CantBuildTooCloseToCreepSource")] CantBuildTooCloseToCreepSource = 46,
    [pbr::OriginalName("CantBuildTooCloseToResources")] CantBuildTooCloseToResources = 47,
    [pbr::OriginalName("CantBuildTooFarFromWater")] CantBuildTooFarFromWater = 48,
    [pbr::OriginalName("CantBuildTooFarFromCreepSource")] CantBuildTooFarFromCreepSource = 49,
    [pbr::OriginalName("CantBuildTooFarFromBuildPowerSource")] CantBuildTooFarFromBuildPowerSource = 50,
    [pbr::OriginalName("CantBuildOnDenseTerrain")] CantBuildOnDenseTerrain = 51,
    [pbr::OriginalName("CantTrainTooFarFromTrainPowerSource")] CantTrainTooFarFromTrainPowerSource = 52,
    [pbr::OriginalName("CantLandLocationInvalid")] CantLandLocationInvalid = 53,
    [pbr::OriginalName("CantSeeLandLocation")] CantSeeLandLocation = 54,
    [pbr::OriginalName("CantLandTooCloseToCreepSource")] CantLandTooCloseToCreepSource = 55,
    [pbr::OriginalName("CantLandTooCloseToResources")] CantLandTooCloseToResources = 56,
    [pbr::OriginalName("CantLandTooFarFromWater")] CantLandTooFarFromWater = 57,
    [pbr::OriginalName("CantLandTooFarFromCreepSource")] CantLandTooFarFromCreepSource = 58,
    [pbr::OriginalName("CantLandTooFarFromBuildPowerSource")] CantLandTooFarFromBuildPowerSource = 59,
    [pbr::OriginalName("CantLandTooFarFromTrainPowerSource")] CantLandTooFarFromTrainPowerSource = 60,
    [pbr::OriginalName("CantLandOnDenseTerrain")] CantLandOnDenseTerrain = 61,
    [pbr::OriginalName("AddOnTooFarFromBuilding")] AddOnTooFarFromBuilding = 62,
    [pbr::OriginalName("MustBuildRefineryFirst")] MustBuildRefineryFirst = 63,
    [pbr::OriginalName("BuildingIsUnderConstruction")] BuildingIsUnderConstruction = 64,
    [pbr::OriginalName("CantFindDropOff")] CantFindDropOff = 65,
    [pbr::OriginalName("CantLoadOtherPlayersUnits")] CantLoadOtherPlayersUnits = 66,
    [pbr::OriginalName("NotEnoughRoomToLoadUnit")] NotEnoughRoomToLoadUnit = 67,
    [pbr::OriginalName("CantUnloadUnitsThere")] CantUnloadUnitsThere = 68,
    [pbr::OriginalName("CantWarpInUnitsThere")] CantWarpInUnitsThere = 69,
    [pbr::OriginalName("CantLoadImmobileUnits")] CantLoadImmobileUnits = 70,
    [pbr::OriginalName("CantRechargeImmobileUnits")] CantRechargeImmobileUnits = 71,
    [pbr::OriginalName("CantRechargeUnderConstructionUnits")] CantRechargeUnderConstructionUnits = 72,
    [pbr::OriginalName("CantLoadThatUnit")] CantLoadThatUnit = 73,
    [pbr::OriginalName("NoCargoToUnload")] NoCargoToUnload = 74,
    [pbr::OriginalName("LoadAllNoTargetsFound")] LoadAllNoTargetsFound = 75,
    [pbr::OriginalName("NotWhileOccupied")] NotWhileOccupied = 76,
    [pbr::OriginalName("CantAttackWithoutAmmo")] CantAttackWithoutAmmo = 77,
    [pbr::OriginalName("CantHoldAnyMoreAmmo")] CantHoldAnyMoreAmmo = 78,
    [pbr::OriginalName("TechRequirementsNotMet")] TechRequirementsNotMet = 79,
    [pbr::OriginalName("MustLockdownUnitFirst")] MustLockdownUnitFirst = 80,
    [pbr::OriginalName("MustTargetUnit")] MustTargetUnit = 81,
    [pbr::OriginalName("MustTargetInventory")] MustTargetInventory = 82,
    [pbr::OriginalName("MustTargetVisibleUnit")] MustTargetVisibleUnit = 83,
    [pbr::OriginalName("MustTargetVisibleLocation")] MustTargetVisibleLocation = 84,
    [pbr::OriginalName("MustTargetWalkableLocation")] MustTargetWalkableLocation = 85,
    [pbr::OriginalName("MustTargetPawnableUnit")] MustTargetPawnableUnit = 86,
    [pbr::OriginalName("YouCantControlThatUnit")] YouCantControlThatUnit = 87,
    [pbr::OriginalName("YouCantIssueCommandsToThatUnit")] YouCantIssueCommandsToThatUnit = 88,
    [pbr::OriginalName("MustTargetResources")] MustTargetResources = 89,
    [pbr::OriginalName("RequiresHealTarget")] RequiresHealTarget = 90,
    [pbr::OriginalName("RequiresRepairTarget")] RequiresRepairTarget = 91,
    [pbr::OriginalName("NoItemsToDrop")] NoItemsToDrop = 92,
    [pbr::OriginalName("CantHoldAnyMoreItems")] CantHoldAnyMoreItems = 93,
    [pbr::OriginalName("CantHoldThat")] CantHoldThat = 94,
    [pbr::OriginalName("TargetHasNoInventory")] TargetHasNoInventory = 95,
    [pbr::OriginalName("CantDropThisItem")] CantDropThisItem = 96,
    [pbr::OriginalName("CantMoveThisItem")] CantMoveThisItem = 97,
    [pbr::OriginalName("CantPawnThisUnit")] CantPawnThisUnit = 98,
    [pbr::OriginalName("MustTargetCaster")] MustTargetCaster = 99,
    [pbr::OriginalName("CantTargetCaster")] CantTargetCaster = 100,
    [pbr::OriginalName("MustTargetOuter")] MustTargetOuter = 101,
    [pbr::OriginalName("CantTargetOuter")] CantTargetOuter = 102,
    [pbr::OriginalName("MustTargetYourOwnUnits")] MustTargetYourOwnUnits = 103,
    [pbr::OriginalName("CantTargetYourOwnUnits")] CantTargetYourOwnUnits = 104,
    [pbr::OriginalName("MustTargetFriendlyUnits")] MustTargetFriendlyUnits = 105,
    [pbr::OriginalName("CantTargetFriendlyUnits")] CantTargetFriendlyUnits = 106,
    [pbr::OriginalName("MustTargetNeutralUnits")] MustTargetNeutralUnits = 107,
    [pbr::OriginalName("CantTargetNeutralUnits")] CantTargetNeutralUnits = 108,
    [pbr::OriginalName("MustTargetEnemyUnits")] MustTargetEnemyUnits = 109,
    [pbr::OriginalName("CantTargetEnemyUnits")] CantTargetEnemyUnits = 110,
    [pbr::OriginalName("MustTargetAirUnits")] MustTargetAirUnits = 111,
    [pbr::OriginalName("CantTargetAirUnits")] CantTargetAirUnits = 112,
    [pbr::OriginalName("MustTargetGroundUnits")] MustTargetGroundUnits = 113,
    [pbr::OriginalName("CantTargetGroundUnits")] CantTargetGroundUnits = 114,
    [pbr::OriginalName("MustTargetStructures")] MustTargetStructures = 115,
    [pbr::OriginalName("CantTargetStructures")] CantTargetStructures = 116,
    [pbr::OriginalName("MustTargetLightUnits")] MustTargetLightUnits = 117,
    [pbr::OriginalName("CantTargetLightUnits")] CantTargetLightUnits = 118,
    [pbr::OriginalName("MustTargetArmoredUnits")] MustTargetArmoredUnits = 119,
    [pbr::OriginalName("CantTargetArmoredUnits")] CantTargetArmoredUnits = 120,
    [pbr::OriginalName("MustTargetBiologicalUnits")] MustTargetBiologicalUnits = 121,
    [pbr::OriginalName("CantTargetBiologicalUnits")] CantTargetBiologicalUnits = 122,
    [pbr::OriginalName("MustTargetHeroicUnits")] MustTargetHeroicUnits = 123,
    [pbr::OriginalName("CantTargetHeroicUnits")] CantTargetHeroicUnits = 124,
    [pbr::OriginalName("MustTargetRoboticUnits")] MustTargetRoboticUnits = 125,
    [pbr::OriginalName("CantTargetRoboticUnits")] CantTargetRoboticUnits = 126,
    [pbr::OriginalName("MustTargetMechanicalUnits")] MustTargetMechanicalUnits = 127,
    [pbr::OriginalName("CantTargetMechanicalUnits")] CantTargetMechanicalUnits = 128,
    [pbr::OriginalName("MustTargetPsionicUnits")] MustTargetPsionicUnits = 129,
    [pbr::OriginalName("CantTargetPsionicUnits")] CantTargetPsionicUnits = 130,
    [pbr::OriginalName("MustTargetMassiveUnits")] MustTargetMassiveUnits = 131,
    [pbr::OriginalName("CantTargetMassiveUnits")] CantTargetMassiveUnits = 132,
    [pbr::OriginalName("MustTargetMissile")] MustTargetMissile = 133,
    [pbr::OriginalName("CantTargetMissile")] CantTargetMissile = 134,
    [pbr::OriginalName("MustTargetWorkerUnits")] MustTargetWorkerUnits = 135,
    [pbr::OriginalName("CantTargetWorkerUnits")] CantTargetWorkerUnits = 136,
    [pbr::OriginalName("MustTargetEnergyCapableUnits")] MustTargetEnergyCapableUnits = 137,
    [pbr::OriginalName("CantTargetEnergyCapableUnits")] CantTargetEnergyCapableUnits = 138,
    [pbr::OriginalName("MustTargetShieldCapableUnits")] MustTargetShieldCapableUnits = 139,
    [pbr::OriginalName("CantTargetShieldCapableUnits")] CantTargetShieldCapableUnits = 140,
    [pbr::OriginalName("MustTargetFlyers")] MustTargetFlyers = 141,
    [pbr::OriginalName("CantTargetFlyers")] CantTargetFlyers = 142,
    [pbr::OriginalName("MustTargetBuriedUnits")] MustTargetBuriedUnits = 143,
    [pbr::OriginalName("CantTargetBuriedUnits")] CantTargetBuriedUnits = 144,
    [pbr::OriginalName("MustTargetCloakedUnits")] MustTargetCloakedUnits = 145,
    [pbr::OriginalName("CantTargetCloakedUnits")] CantTargetCloakedUnits = 146,
    [pbr::OriginalName("MustTargetUnitsInAStasisField")] MustTargetUnitsInAstasisField = 147,
    [pbr::OriginalName("CantTargetUnitsInAStasisField")] CantTargetUnitsInAstasisField = 148,
    [pbr::OriginalName("MustTargetUnderConstructionUnits")] MustTargetUnderConstructionUnits = 149,
    [pbr::OriginalName("CantTargetUnderConstructionUnits")] CantTargetUnderConstructionUnits = 150,
    [pbr::OriginalName("MustTargetDeadUnits")] MustTargetDeadUnits = 151,
    [pbr::OriginalName("CantTargetDeadUnits")] CantTargetDeadUnits = 152,
    [pbr::OriginalName("MustTargetRevivableUnits")] MustTargetRevivableUnits = 153,
    [pbr::OriginalName("CantTargetRevivableUnits")] CantTargetRevivableUnits = 154,
    [pbr::OriginalName("MustTargetHiddenUnits")] MustTargetHiddenUnits = 155,
    [pbr::OriginalName("CantTargetHiddenUnits")] CantTargetHiddenUnits = 156,
    [pbr::OriginalName("CantRechargeOtherPlayersUnits")] CantRechargeOtherPlayersUnits = 157,
    [pbr::OriginalName("MustTargetHallucinations")] MustTargetHallucinations = 158,
    [pbr::OriginalName("CantTargetHallucinations")] CantTargetHallucinations = 159,
    [pbr::OriginalName("MustTargetInvulnerableUnits")] MustTargetInvulnerableUnits = 160,
    [pbr::OriginalName("CantTargetInvulnerableUnits")] CantTargetInvulnerableUnits = 161,
    [pbr::OriginalName("MustTargetDetectedUnits")] MustTargetDetectedUnits = 162,
    [pbr::OriginalName("CantTargetDetectedUnits")] CantTargetDetectedUnits = 163,
    [pbr::OriginalName("CantTargetUnitWithEnergy")] CantTargetUnitWithEnergy = 164,
    [pbr::OriginalName("CantTargetUnitWithShields")] CantTargetUnitWithShields = 165,
    [pbr::OriginalName("MustTargetUncommandableUnits")] MustTargetUncommandableUnits = 166,
    [pbr::OriginalName("CantTargetUncommandableUnits")] CantTargetUncommandableUnits = 167,
    [pbr::OriginalName("MustTargetPreventDefeatUnits")] MustTargetPreventDefeatUnits = 168,
    [pbr::OriginalName("CantTargetPreventDefeatUnits")] CantTargetPreventDefeatUnits = 169,
    [pbr::OriginalName("MustTargetPreventRevealUnits")] MustTargetPreventRevealUnits = 170,
    [pbr::OriginalName("CantTargetPreventRevealUnits")] CantTargetPreventRevealUnits = 171,
    [pbr::OriginalName("MustTargetPassiveUnits")] MustTargetPassiveUnits = 172,
    [pbr::OriginalName("CantTargetPassiveUnits")] CantTargetPassiveUnits = 173,
    [pbr::OriginalName("MustTargetStunnedUnits")] MustTargetStunnedUnits = 174,
    [pbr::OriginalName("CantTargetStunnedUnits")] CantTargetStunnedUnits = 175,
    [pbr::OriginalName("MustTargetSummonedUnits")] MustTargetSummonedUnits = 176,
    [pbr::OriginalName("CantTargetSummonedUnits")] CantTargetSummonedUnits = 177,
    [pbr::OriginalName("MustTargetUser1")] MustTargetUser1 = 178,
    [pbr::OriginalName("CantTargetUser1")] CantTargetUser1 = 179,
    [pbr::OriginalName("MustTargetUnstoppableUnits")] MustTargetUnstoppableUnits = 180,
    [pbr::OriginalName("CantTargetUnstoppableUnits")] CantTargetUnstoppableUnits = 181,
    [pbr::OriginalName("MustTargetResistantUnits")] MustTargetResistantUnits = 182,
    [pbr::OriginalName("CantTargetResistantUnits")] CantTargetResistantUnits = 183,
    [pbr::OriginalName("MustTargetDazedUnits")] MustTargetDazedUnits = 184,
    [pbr::OriginalName("CantTargetDazedUnits")] CantTargetDazedUnits = 185,
    [pbr::OriginalName("CantLockdown")] CantLockdown = 186,
    [pbr::OriginalName("CantMindControl")] CantMindControl = 187,
    [pbr::OriginalName("MustTargetDestructibles")] MustTargetDestructibles = 188,
    [pbr::OriginalName("CantTargetDestructibles")] CantTargetDestructibles = 189,
    [pbr::OriginalName("MustTargetItems")] MustTargetItems = 190,
    [pbr::OriginalName("CantTargetItems")] CantTargetItems = 191,
    [pbr::OriginalName("NoCalldownAvailable")] NoCalldownAvailable = 192,
    [pbr::OriginalName("WaypointListFull")] WaypointListFull = 193,
    [pbr::OriginalName("MustTargetRace")] MustTargetRace = 194,
    [pbr::OriginalName("CantTargetRace")] CantTargetRace = 195,
    [pbr::OriginalName("MustTargetSimilarUnits")] MustTargetSimilarUnits = 196,
    [pbr::OriginalName("CantTargetSimilarUnits")] CantTargetSimilarUnits = 197,
    [pbr::OriginalName("CantFindEnoughTargets")] CantFindEnoughTargets = 198,
    [pbr::OriginalName("AlreadySpawningLarva")] AlreadySpawningLarva = 199,
    [pbr::OriginalName("CantTargetExhaustedResources")] CantTargetExhaustedResources = 200,
    [pbr::OriginalName("CantUseMinimap")] CantUseMinimap = 201,
    [pbr::OriginalName("CantUseInfoPanel")] CantUseInfoPanel = 202,
    [pbr::OriginalName("OrderQueueIsFull")] OrderQueueIsFull = 203,
    [pbr::OriginalName("CantHarvestThatResource")] CantHarvestThatResource = 204,
    [pbr::OriginalName("HarvestersNotRequired")] HarvestersNotRequired = 205,
    [pbr::OriginalName("AlreadyTargeted")] AlreadyTargeted = 206,
    [pbr::OriginalName("CantAttackWeaponsDisabled")] CantAttackWeaponsDisabled = 207,
    [pbr::OriginalName("CouldntReachTarget")] CouldntReachTarget = 208,
    [pbr::OriginalName("TargetIsOutOfRange")] TargetIsOutOfRange = 209,
    [pbr::OriginalName("TargetIsTooClose")] TargetIsTooClose = 210,
    [pbr::OriginalName("TargetIsOutOfArc")] TargetIsOutOfArc = 211,
    [pbr::OriginalName("CantFindTeleportLocation")] CantFindTeleportLocation = 212,
    [pbr::OriginalName("InvalidItemClass")] InvalidItemClass = 213,
    [pbr::OriginalName("CantFindCancelOrder")] CantFindCancelOrder = 214,
  }

  #endregion

}

#endregion Designer generated code
