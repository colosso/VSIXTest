using System;
using System.Runtime.InteropServices;
using Lugia_Integration_Tools;
using Microsoft.VisualStudio.OLE.Interop;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Flavor;

[Guid(Lugia_Integration_ToolsPackage.FactoryGuidString)]
internal class LugiaUIProjectFactory : FlavoredProjectFactoryBase
{

    public LugiaUIProjectFactory()
    {
    }

    protected override object PreCreateForOuter(System.IntPtr outerProjectIUnknown)
    {
        return new LugiaUIProject();
    }

    //protected override void CreateProject(string fileName, string location, string name, uint flags, ref System.Guid projectGuid, out System.IntPtr project, out int canceled)
    //{
    //    project = IntPtr.Zero;
    //    canceled = 0;
    //}


}