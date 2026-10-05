using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x0200019D RID: 413
	[Token(Token = "0x200019D")]
	[StructLayout(3)]
	public struct ArgIterator
	{
		// Token: 0x06000F88 RID: 3976 RVA: 0x0000D0C8 File Offset: 0x0000B2C8
		[Token(Token = "0x6000F88")]
		[Address(RVA = "0x4D2F220", Offset = "0x4D2DE20", VA = "0x184D2F220", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		// Token: 0x06000F89 RID: 3977 RVA: 0x0000D0E0 File Offset: 0x0000B2E0
		[Token(Token = "0x6000F89")]
		[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000737 RID: 1847
		[Token(Token = "0x4000737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private System.IntPtr sig;

		// Token: 0x04000738 RID: 1848
		[Token(Token = "0x4000738")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private System.IntPtr args;

		// Token: 0x04000739 RID: 1849
		[Token(Token = "0x4000739")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int next_arg;

		// Token: 0x0400073A RID: 1850
		[Token(Token = "0x400073A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private int num_args;
	}
}
