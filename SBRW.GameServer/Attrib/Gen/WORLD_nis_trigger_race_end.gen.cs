using VaultLib.CodeGen;
using VaultLib.Core.Data;

// Generated by VaultLib.CodeGen @ November 30, 2019 4:47:29 AM for game WORLD
namespace SBRW.GameServer.Attrib.Gen
{
    public class WORLD_nis_trigger_race_end : CollectionWrapperBase {
        #region Field Names
        public const string Name_is_canyon = "is_canyon";
        public const string Name_platform = "platform";
        public const string Name_canyon_timeout = "canyon_timeout";
        public const string Name_cliff = "cliff";
        public const string Name_canyon_midrace = "canyon_midrace";
        public const string Name_win = "win";
        public const string Name_pursuit = "pursuit";
        public const string Name_scene_name = "scene_name";
        #endregion

        public WORLD_nis_trigger_race_end(VLTCollection collection) : base(collection) {}

        #region Getters
        public System.Boolean canyon_midrace() {
            return GetValue<System.Boolean>("canyon_midrace");
        }
        public System.Boolean canyon_timeout() {
            return GetValue<System.Boolean>("canyon_timeout");
        }
        public System.Boolean cliff() {
            return GetValue<System.Boolean>("cliff");
        }
        public System.Boolean is_canyon() {
            return GetValue<System.Boolean>("is_canyon");
        }
        public VaultLib.Support.World.VLT.NIS.ePLATFORM_CLASS platform() {
            return GetValue<VaultLib.Support.World.VLT.NIS.ePLATFORM_CLASS>("platform");
        }
        public System.Boolean pursuit() {
            return GetValue<System.Boolean>("pursuit");
        }
        public System.String scene_name() {
            return GetValue<System.String>("scene_name");
        }
        public System.Boolean win() {
            return GetValue<System.Boolean>("win");
        }
        #endregion

    }
}