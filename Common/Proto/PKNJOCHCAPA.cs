// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PKNJOCHCAPA.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from PKNJOCHCAPA.proto</summary>
  public static partial class PKNJOCHCAPAReflection {

    #region Descriptor
    /// <summary>File descriptor for PKNJOCHCAPA.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PKNJOCHCAPAReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFQS05KT0NIQ0FQQS5wcm90byrKAQoLUEtOSk9DSENBUEESGgoWQ0hFU1Nf",
            "Uk9HVUVfTEVWRUxfSURMRRAAEiAKHENIRVNTX1JPR1VFX0xFVkVMX1BST0NF",
            "U1NJTkcQARIdChlDSEVTU19ST0dVRV9MRVZFTF9QRU5ESU5HEAISHAoYQ0hF",
            "U1NfUk9HVUVfTEVWRUxfRklOSVNIEAMSHAoYQ0hFU1NfUk9HVUVfTEVWRUxf",
            "RkFJTEVEEAQSIgoeQ0hFU1NfUk9HVUVfTEVWRUxfRk9SQ0VfRklOSVNIEAVC",
            "HqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::EggLink.DanhengServer.Proto.PKNJOCHCAPA), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum PKNJOCHCAPA {
    [pbr::OriginalName("CHESS_ROGUE_LEVEL_IDLE")] ChessRogueLevelIdle = 0,
    [pbr::OriginalName("CHESS_ROGUE_LEVEL_PROCESSING")] ChessRogueLevelProcessing = 1,
    [pbr::OriginalName("CHESS_ROGUE_LEVEL_PENDING")] ChessRogueLevelPending = 2,
    [pbr::OriginalName("CHESS_ROGUE_LEVEL_FINISH")] ChessRogueLevelFinish = 3,
    [pbr::OriginalName("CHESS_ROGUE_LEVEL_FAILED")] ChessRogueLevelFailed = 4,
    [pbr::OriginalName("CHESS_ROGUE_LEVEL_FORCE_FINISH")] ChessRogueLevelForceFinish = 5,
  }

  #endregion

}

#endregion Designer generated code