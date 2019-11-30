using System.Collections.Generic;
using VaultLib.CodeGen;
using VaultLib.Core.Data;

// Generated by VaultLib.CodeGen @ November 30, 2019 4:47:29 AM for game WORLD
namespace SBRW.GameServer.Attrib.Gen
{
    public class WORLD_speech : CollectionWrapperBase {
        #region Field Names
        public const string Name_MinPlayerSpeed = "MinPlayerSpeed";
        public const string Name_Interval = "Interval";
        public const string Name_RadioChirp = "RadioChirp";
        public const string Name_RedundancyCheckIsGlobal = "RedundancyCheckIsGlobal";
        public const string Name_RecallList = "RecallList";
        public const string Name_OnScreenOnly = "OnScreenOnly";
        public const string Name_Pan = "Pan";
        public const string Name_expiry = "expiry";
        public const string Name_MinHeat = "MinHeat";
        public const string Name_MaxHeat = "MaxHeat";
        public const string Name_DeadAir = "DeadAir";
        public const string Name_MaxPlayback = "MaxPlayback";
        public const string Name_Interruptable = "Interruptable";
        public const string Name_cache_SysInit = "cache_SysInit";
        public const string Name_BackTime = "BackTime";
        public const string Name_CollectionName = "CollectionName";
        public const string Name_DoNotDropout = "DoNotDropout";
        public const string Name_priority = "priority";
        public const string Name_interrupt = "interrupt";
        public const string Name_SpeechID = "SpeechID";
        public const string Name_cache_OnCreate = "cache_OnCreate";
        public const string Name_MaxPlayerSpeed = "MaxPlayerSpeed";
        public const string Name_CullingRange = "CullingRange";
        public const string Name_DepFollow = "DepFollow";
        public const string Name_EnforceDeadAir = "EnforceDeadAir";
        public const string Name_reqLOS = "reqLOS";
        public const string Name_Clarity = "Clarity";
        public const string Name_InitDelay = "InitDelay";
        #endregion

        public WORLD_speech(VLTCollection collection) : base(collection) {}

        #region Getters
        public System.Single BackTime() {
            return GetValue<System.Single>("BackTime");
        }
        public System.Boolean cache_OnCreate() {
            return GetValue<System.Boolean>("cache_OnCreate");
        }
        public System.Boolean cache_SysInit() {
            return GetValue<System.Boolean>("cache_SysInit");
        }
        public System.Byte Clarity() {
            return GetValue<System.Byte>("Clarity");
        }
        public System.String CollectionName() {
            return GetValue<System.String>("CollectionName");
        }
        public List<System.Single> CullingRange() {
            return GetArray<System.Single>("CullingRange");
        }
        public System.Single DeadAir() {
            return GetValue<System.Single>("DeadAir");
        }
        public List<VaultLib.CodeGen.RefSpecWrapper> DepFollow() {
            return GetArray<VaultLib.CodeGen.RefSpecWrapper>("DepFollow");
        }
        public System.Boolean DoNotDropout() {
            return GetValue<System.Boolean>("DoNotDropout");
        }
        public System.Single EnforceDeadAir() {
            return GetValue<System.Single>("EnforceDeadAir");
        }
        public System.Single expiry() {
            return GetValue<System.Single>("expiry");
        }
        public System.Single InitDelay() {
            return GetValue<System.Single>("InitDelay");
        }
        public System.Boolean interrupt() {
            return GetValue<System.Boolean>("interrupt");
        }
        public System.Boolean Interruptable() {
            return GetValue<System.Boolean>("Interruptable");
        }
        public System.Single Interval() {
            return GetValue<System.Single>("Interval");
        }
        public System.SByte MaxHeat() {
            return GetValue<System.SByte>("MaxHeat");
        }
        public System.Int32 MaxPlayback() {
            return GetValue<System.Int32>("MaxPlayback");
        }
        public System.Single MaxPlayerSpeed() {
            return GetValue<System.Single>("MaxPlayerSpeed");
        }
        public System.SByte MinHeat() {
            return GetValue<System.SByte>("MinHeat");
        }
        public System.Single MinPlayerSpeed() {
            return GetValue<System.Single>("MinPlayerSpeed");
        }
        public System.Boolean OnScreenOnly() {
            return GetValue<System.Boolean>("OnScreenOnly");
        }
        public System.Boolean Pan() {
            return GetValue<System.Boolean>("Pan");
        }
        public System.Int16 priority() {
            return GetValue<System.Int16>("priority");
        }
        public System.Boolean RadioChirp() {
            return GetValue<System.Boolean>("RadioChirp");
        }
        public List<VaultLib.CodeGen.RefSpecWrapper> RecallList() {
            return GetArray<VaultLib.CodeGen.RefSpecWrapper>("RecallList");
        }
        public System.Boolean RedundancyCheckIsGlobal() {
            return GetValue<System.Boolean>("RedundancyCheckIsGlobal");
        }
        public System.Boolean reqLOS() {
            return GetValue<System.Boolean>("reqLOS");
        }
        public VaultLib.Support.World.VLT.SPCHType_1_EventID SpeechID() {
            return GetValue<VaultLib.Support.World.VLT.SPCHType_1_EventID>("SpeechID");
        }
        #endregion

    }
}