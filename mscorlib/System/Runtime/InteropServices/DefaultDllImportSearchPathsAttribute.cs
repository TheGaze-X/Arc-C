using System;
using Il2CppDummyDll;

namespace System.Runtime.InteropServices
{
	// Token: 0x0200046F RID: 1135
	[Token(Token = "0x200046F")]
	[System.AttributeUsage(System.AttributeTargets.Assembly | System.AttributeTargets.Method, AllowMultiple = false)]
	[ComVisible(false)]
	public sealed class DefaultDllImportSearchPathsAttribute : System.Attribute
	{
		// Token: 0x0600222C RID: 8748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600222C")]
		[Address(RVA = "0x1FF21E0", Offset = "0x1FF0DE0", VA = "0x181FF21E0")]
		public DefaultDllImportSearchPathsAttribute(DllImportSearchPath paths)
		{
		}

		// Token: 0x04001395 RID: 5013
		[Token(Token = "0x4001395")]
		[FieldOffset(Offset = "0x10")]
		internal DllImportSearchPath _paths;
	}
}
