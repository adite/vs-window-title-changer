using System;

namespace VSWindowTitleChanger
{
    static class GuidList
    {
#if VS2010_AND_LATER
        public const string guidVSWindowTitleChangerPkgString = "1e0c061a-af97-43bb-930d-7e3629676249";
        public const string guidVSWindowTitleChangerCmdSetString = "15ae04f3-70b2-4f36-a188-48782d195223";
#else
        public const string guidVSWindowTitleChangerPkgString = "a266559f-adb6-4af0-b92a-81733e922397";
        public const string guidVSWindowTitleChangerCmdSetString = "3602a290-8f85-4a03-95bd-69514372a6dd";
#endif

        public static readonly Guid guidVSWindowTitleChangerCmdSet = new Guid(guidVSWindowTitleChangerCmdSetString);
    };
}