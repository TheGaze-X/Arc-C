using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020001B3 RID: 435
	[Token(Token = "0x20001B3")]
	[StructLayout(0)]
	internal class MonoAsyncCall
	{
		// Token: 0x06000FFC RID: 4092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FFC")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public MonoAsyncCall()
		{
		}

		// Token: 0x0400076B RID: 1899
		[Token(Token = "0x400076B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private object msg;

		// Token: 0x0400076C RID: 1900
		[Token(Token = "0x400076C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private System.IntPtr cb_method;

		// Token: 0x0400076D RID: 1901
		[Token(Token = "0x400076D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private object cb_target;

		// Token: 0x0400076E RID: 1902
		[Token(Token = "0x400076E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private object state;

		// Token: 0x0400076F RID: 1903
		[Token(Token = "0x400076F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private object res;

		// Token: 0x04000770 RID: 1904
		[Token(Token = "0x4000770")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private object out_args;
	}
}
