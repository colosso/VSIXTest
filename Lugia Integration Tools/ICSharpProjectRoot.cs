using System;
using System.Runtime.InteropServices;

namespace Lugia_Integration_Tools
{
	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("C7FEDB89-B36D-4a62-93F4-DC7A95999921")]
	internal interface ICSharpProjectRoot
	{
		void SetProjectSite_Placeholder();

		[return: MarshalAs(UnmanagedType.IUnknown)]
		object GetProjectSite([In] ref Guid riid);
	}
}