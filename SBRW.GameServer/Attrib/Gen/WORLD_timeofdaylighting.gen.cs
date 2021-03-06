using VaultLib.CodeGen;
using VaultLib.Core.Data;

// Generated by VaultLib.CodeGen @ November 30, 2019 4:47:29 AM for game WORLD
namespace SBRW.GameServer.Attrib.Gen
{
    public class WORLD_timeofdaylighting : CollectionWrapperBase {
        #region Field Names
        public const string Name_FogInLightScatter = "FogInLightScatter";
        public const string Name_FogHazeColourScale = "FogHazeColourScale";
        public const string Name_0x0B20053B = "0x0B20053B";
        public const string Name_ChristmasLights = "ChristmasLights";
        public const string Name_0x13208780 = "0x13208780";
        public const string Name_FogSkyColour = "FogSkyColour";
        public const string Name_DebugMode = "DebugMode";
        public const string Name_FogSunFalloff = "FogSunFalloff";
        public const string Name_0x36C9AF8D = "0x36C9AF8D";
        public const string Name_0x4454FC3B = "0x4454FC3B";
        public const string Name_0x507AFAFC = "0x507AFAFC";
        public const string Name_AmbientColour = "AmbientColour";
        public const string Name_0x552FD5D6 = "0x552FD5D6";
        public const string Name_SpecularColour = "SpecularColour";
        public const string Name_0x707F1B6C = "0x707F1B6C";
        public const string Name_FogDistanceScale = "FogDistanceScale";
        public const string Name_EnvSkyBrightness = "EnvSkyBrightness";
        public const string Name_DiffuseColour = "DiffuseColour";
        public const string Name_0x76E6BE76 = "0x76E6BE76";
        public const string Name_0x8A7D072A = "0x8A7D072A";
        public const string Name_BloomThreshold = "BloomThreshold";
        public const string Name_FogSkyColourScale = "FogSkyColourScale";
        public const string Name_0x96B75CBF = "0x96B75CBF";
        public const string Name_0x97A4DE50 = "0x97A4DE50";
        public const string Name_0x98E9A723 = "0x98E9A723";
        public const string Name_BloomPower = "BloomPower";
        public const string Name_CarSpecScale = "CarSpecScale";
        public const string Name_0xB916AF2D = "0xB916AF2D";
        public const string Name_0xC8D8567A = "0xC8D8567A";
        public const string Name_FogHazeColour = "FogHazeColour";
        public const string Name_0xCCF24433 = "0xCCF24433";
        public const string Name_0xD266654D = "0xD266654D";
        public const string Name_SpecularColour2 = "SpecularColour2";
        public const string Name_SpecularPower2 = "SpecularPower2";
        public const string Name_0xDD4C2632 = "0xDD4C2632";
        public const string Name_0xEA3CA6E3 = "0xEA3CA6E3";
        public const string Name_SunAndSky = "SunAndSky";
        public const string Name_ShadowStrength = "ShadowStrength";
        public const string Name_SpecularPower = "SpecularPower";
        public const string Name_0xF9C84DF5 = "0xF9C84DF5";
        #endregion

        public WORLD_timeofdaylighting(VLTCollection collection) : base(collection) {}

        #region Getters
        public VaultLib.Core.Types.Attrib.Types.Vector4 AmbientColour() {
            return GetValue<VaultLib.Core.Types.Attrib.Types.Vector4>("AmbientColour");
        }
        public VaultLib.Core.Types.Attrib.Types.Vector3 BloomPower() {
            return GetValue<VaultLib.Core.Types.Attrib.Types.Vector3>("BloomPower");
        }
        public VaultLib.Core.Types.Attrib.Types.Vector4 BloomThreshold() {
            return GetValue<VaultLib.Core.Types.Attrib.Types.Vector4>("BloomThreshold");
        }
        public System.Single CarSpecScale() {
            return GetValue<System.Single>("CarSpecScale");
        }
        public System.Single ChristmasLights() {
            return GetValue<System.Single>("ChristmasLights");
        }
        public System.Boolean DebugMode() {
            return GetValue<System.Boolean>("DebugMode");
        }
        public VaultLib.Core.Types.Attrib.Types.Vector4 DiffuseColour() {
            return GetValue<VaultLib.Core.Types.Attrib.Types.Vector4>("DiffuseColour");
        }
        public System.Single EnvSkyBrightness() {
            return GetValue<System.Single>("EnvSkyBrightness");
        }
        public System.Single field_0x0B20053B() {
            return GetValue<System.Single>("0x0B20053B");
        }
        public System.Single field_0x13208780() {
            return GetValue<System.Single>("0x13208780");
        }
        public System.Single field_0x36C9AF8D() {
            return GetValue<System.Single>("0x36C9AF8D");
        }
        public System.Single field_0x4454FC3B() {
            return GetValue<System.Single>("0x4454FC3B");
        }
        public System.Single field_0x507AFAFC() {
            return GetValue<System.Single>("0x507AFAFC");
        }
        public VaultLib.Core.Types.Attrib.Types.Vector4 field_0x552FD5D6() {
            return GetValue<VaultLib.Core.Types.Attrib.Types.Vector4>("0x552FD5D6");
        }
        public VaultLib.Core.Types.Attrib.Types.Vector4 field_0x707F1B6C() {
            return GetValue<VaultLib.Core.Types.Attrib.Types.Vector4>("0x707F1B6C");
        }
        public System.Single field_0x76E6BE76() {
            return GetValue<System.Single>("0x76E6BE76");
        }
        public VaultLib.Core.Types.Attrib.Types.Vector4 field_0x8A7D072A() {
            return GetValue<VaultLib.Core.Types.Attrib.Types.Vector4>("0x8A7D072A");
        }
        public System.Single field_0x96B75CBF() {
            return GetValue<System.Single>("0x96B75CBF");
        }
        public VaultLib.CodeGen.RefSpecWrapper field_0x97A4DE50() {
            return GetValue<VaultLib.CodeGen.RefSpecWrapper>("0x97A4DE50");
        }
        public System.Single field_0x98E9A723() {
            return GetValue<System.Single>("0x98E9A723");
        }
        public VaultLib.CodeGen.RefSpecWrapper field_0xB916AF2D() {
            return GetValue<VaultLib.CodeGen.RefSpecWrapper>("0xB916AF2D");
        }
        public System.Single field_0xC8D8567A() {
            return GetValue<System.Single>("0xC8D8567A");
        }
        public System.Single field_0xCCF24433() {
            return GetValue<System.Single>("0xCCF24433");
        }
        public System.Single field_0xD266654D() {
            return GetValue<System.Single>("0xD266654D");
        }
        public System.Single field_0xDD4C2632() {
            return GetValue<System.Single>("0xDD4C2632");
        }
        public VaultLib.Core.Types.Attrib.Types.Vector4 field_0xEA3CA6E3() {
            return GetValue<VaultLib.Core.Types.Attrib.Types.Vector4>("0xEA3CA6E3");
        }
        public System.UInt32 field_0xF9C84DF5() {
            return GetValue<System.UInt32>("0xF9C84DF5");
        }
        public System.Single FogDistanceScale() {
            return GetValue<System.Single>("FogDistanceScale");
        }
        public VaultLib.Core.Types.Attrib.Types.Vector4 FogHazeColour() {
            return GetValue<VaultLib.Core.Types.Attrib.Types.Vector4>("FogHazeColour");
        }
        public System.Single FogHazeColourScale() {
            return GetValue<System.Single>("FogHazeColourScale");
        }
        public System.Single FogInLightScatter() {
            return GetValue<System.Single>("FogInLightScatter");
        }
        public VaultLib.Core.Types.Attrib.Types.Vector4 FogSkyColour() {
            return GetValue<VaultLib.Core.Types.Attrib.Types.Vector4>("FogSkyColour");
        }
        public System.Single FogSkyColourScale() {
            return GetValue<System.Single>("FogSkyColourScale");
        }
        public System.Single FogSunFalloff() {
            return GetValue<System.Single>("FogSunFalloff");
        }
        public System.Single ShadowStrength() {
            return GetValue<System.Single>("ShadowStrength");
        }
        public VaultLib.Core.Types.Attrib.Types.Vector4 SpecularColour() {
            return GetValue<VaultLib.Core.Types.Attrib.Types.Vector4>("SpecularColour");
        }
        public VaultLib.Core.Types.Attrib.Types.Vector4 SpecularColour2() {
            return GetValue<VaultLib.Core.Types.Attrib.Types.Vector4>("SpecularColour2");
        }
        public System.Single SpecularPower() {
            return GetValue<System.Single>("SpecularPower");
        }
        public System.Single SpecularPower2() {
            return GetValue<System.Single>("SpecularPower2");
        }
        public VaultLib.CodeGen.RefSpecWrapper SunAndSky() {
            return GetValue<VaultLib.CodeGen.RefSpecWrapper>("SunAndSky");
        }
        #endregion

    }
}
