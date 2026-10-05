using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Unity.Profiling.LowLevel.Unsafe
{
	// Token: 0x0200000E RID: 14
	[Token(Token = "0x200000E")]
	[StructLayout(2)]
	public readonly struct ProfilerCategoryDescription
	{
		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public readonly ushort Id;

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public readonly ushort Flags;

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public readonly Color32 Color;

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private readonly int reserved0;

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public readonly int NameUtf8Len;

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public unsafe readonly byte* NameUtf8;
	}
}
