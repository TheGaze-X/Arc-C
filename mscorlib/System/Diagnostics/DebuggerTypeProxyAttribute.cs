using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Diagnostics
{
	// Token: 0x020005A6 RID: 1446
	[Token(Token = "0x20005A6")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.AttributeUsage(System.AttributeTargets.Assembly | System.AttributeTargets.Class | System.AttributeTargets.Struct, AllowMultiple = true)]
	public sealed class DebuggerTypeProxyAttribute : System.Attribute
	{
		// Token: 0x06002B43 RID: 11075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B43")]
		[Address(RVA = "0x4C5D170", Offset = "0x4C5BD70", VA = "0x184C5D170")]
		public DebuggerTypeProxyAttribute(System.Type type)
		{
		}

		// Token: 0x04001931 RID: 6449
		[Token(Token = "0x4001931")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string typeName;
	}
}
