using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x0200143D RID: 5181
	[Token(Token = "0x200143D")]
	public struct ShopCashInfo : IHotfixable
	{
		// Token: 0x060077D5 RID: 30677 RVA: 0x00035C40 File Offset: 0x00033E40
		[Token(Token = "0x60077D5")]
		[Address(RVA = "0x253AAF0", Offset = "0x25396F0", VA = "0x18253AAF0")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x060077D6 RID: 30678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077D6")]
		[Address(RVA = "0x253AB70", Offset = "0x2539770", VA = "0x18253AB70")]
		public string ToDisplayStr()
		{
			return null;
		}

		// Token: 0x0400756A RID: 30058
		[Token(Token = "0x400756A")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ShopCashInfo EMPTY;

		// Token: 0x0400756B RID: 30059
		[Token(Token = "0x400756B")]
		[FieldOffset(Offset = "0x0")]
		public string currency;

		// Token: 0x0400756C RID: 30060
		[Token(Token = "0x400756C")]
		[FieldOffset(Offset = "0x8")]
		public string price;

		// Token: 0x0400756D RID: 30061
		[Token(Token = "0x400756D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_IsEmpty;

		// Token: 0x0400756E RID: 30062
		[Token(Token = "0x400756E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ToDisplayStr;
	}
}
