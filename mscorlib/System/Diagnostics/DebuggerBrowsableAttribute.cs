using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Diagnostics
{
	// Token: 0x020005A5 RID: 1445
	[Token(Token = "0x20005A5")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.AttributeUsage(System.AttributeTargets.Property | System.AttributeTargets.Field, AllowMultiple = false)]
	public sealed class DebuggerBrowsableAttribute : System.Attribute
	{
		// Token: 0x06002B42 RID: 11074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B42")]
		[Address(RVA = "0x4C5D050", Offset = "0x4C5BC50", VA = "0x184C5D050")]
		public DebuggerBrowsableAttribute(DebuggerBrowsableState state)
		{
		}

		// Token: 0x04001930 RID: 6448
		[Token(Token = "0x4001930")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private DebuggerBrowsableState state;
	}
}
