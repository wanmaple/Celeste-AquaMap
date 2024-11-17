using System;

namespace Celeste.Mod.AquaMap;

public class AquaMapModule : EverestModule {
    public static AquaMapModule Instance { get; private set; }

    public override Type SettingsType => typeof(AquaMapModuleSettings);
    public static AquaMapModuleSettings Settings => (AquaMapModuleSettings) Instance._Settings;

    public override Type SessionType => typeof(AquaMapModuleSession);
    public static AquaMapModuleSession Session => (AquaMapModuleSession) Instance._Session;

    public override Type SaveDataType => typeof(AquaMapModuleSaveData);
    public static AquaMapModuleSaveData SaveData => (AquaMapModuleSaveData) Instance._SaveData;

    public AquaMapModule() {
        Instance = this;
#if DEBUG
        // debug builds use verbose logging
        Logger.SetLogLevel(nameof(AquaMapModule), LogLevel.Verbose);
#else
        // release builds use info logging to reduce spam in log files
        Logger.SetLogLevel(nameof(AquaMapModule), LogLevel.Info);
#endif
    }

    public override void Load() {
        // TODO: apply any hooks that should always be active
    }

    public override void Unload() {
        // TODO: unapply any hooks applied in Load()
    }
}