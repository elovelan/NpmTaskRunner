namespace NpmTaskRunner
{
    using System;
    
    /// <summary>
    /// Helper class that exposes all GUIDs used across VS Package.
    /// </summary>
    internal sealed partial class PackageGuids
    {
        public const string guidVSPackageString = "68f5ee87-8633-4f4c-8849-fdb6e22ef84a";
        public const string guidVSPackageCmdSetString = "b13c1717-1c31-4be2-9798-7d734b9fd445";
        public const string guidTaskRunnerExplorerCmdSetString = "9e78b319-2142-4381-873c-6ec83f092915";
        public static Guid guidVSPackage = new Guid(guidVSPackageString);
        public static Guid guidVSPackageCmdSet = new Guid(guidVSPackageCmdSetString);
        public static Guid guidTaskRunnerExplorerCmdSet = new Guid(guidTaskRunnerExplorerCmdSetString);
    }
    /// <summary>
    /// Helper class that encapsulates all CommandIDs uses across VS Package.
    /// </summary>
    internal sealed partial class PackageIds
    {
        public const int cmdVerbose = 0x0100;
        public const int IDG_TASKRUNNER_TOOLBAR_CUSTOM_COMMANDS = 0x2002;
    }
}
