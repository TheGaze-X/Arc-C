using System;
using System.Security.Util;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x0200018F RID: 399
	[Token(Token = "0x200018F")]
	internal sealed class SharedStatics
	{
		// Token: 0x06000F0E RID: 3854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F0E")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private SharedStatics()
		{
		}

		// Token: 0x06000F0F RID: 3855 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000F0F")]
		[Address(RVA = "0x4D3E7D0", Offset = "0x4D3D3D0", VA = "0x184D3E7D0")]
		public static Tokenizer.StringMaker GetSharedStringMaker()
		{
			return null;
		}

		// Token: 0x06000F10 RID: 3856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F10")]
		[Address(RVA = "0x4D3E980", Offset = "0x4D3D580", VA = "0x184D3E980")]
		public static void ReleaseSharedStringMaker(ref Tokenizer.StringMaker maker)
		{
		}

		// Token: 0x04000655 RID: 1621
		[Token(Token = "0x4000655")]
		[FieldOffset(Offset = "0x0")]
		private static readonly SharedStatics _sharedStatics;

		// Token: 0x04000656 RID: 1622
		[Token(Token = "0x4000656")]
		[FieldOffset(Offset = "0x10")]
		private Tokenizer.StringMaker _maker;
	}
}
