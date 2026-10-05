using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Diagnostics
{
	// Token: 0x020005A7 RID: 1447
	[Token(Token = "0x20005A7")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.AttributeUsage(System.AttributeTargets.Assembly | System.AttributeTargets.Class | System.AttributeTargets.Struct | System.AttributeTargets.Enum | System.AttributeTargets.Property | System.AttributeTargets.Field | System.AttributeTargets.Delegate, AllowMultiple = true)]
	public sealed class DebuggerDisplayAttribute : System.Attribute
	{
		// Token: 0x06002B44 RID: 11076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B44")]
		[Address(RVA = "0x4C5D0D0", Offset = "0x4C5BCD0", VA = "0x184C5D0D0")]
		public DebuggerDisplayAttribute(string value)
		{
		}

		// Token: 0x04001932 RID: 6450
		[Token(Token = "0x4001932")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string name;

		// Token: 0x04001933 RID: 6451
		[Token(Token = "0x4001933")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string value;

		// Token: 0x04001934 RID: 6452
		[Token(Token = "0x4001934")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string type;
	}
}
