using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005353 RID: 21331
	[Token(Token = "0x2005353")]
	public struct RoguelikeCharBuffModel : IHotfixable
	{
		// Token: 0x0601F733 RID: 128819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F733")]
		[Address(RVA = "0x19226E0", Offset = "0x19212E0", VA = "0x1819226E0")]
		public void LoadData(string topicId, string charBuffId)
		{
		}

		// Token: 0x0402A4FD RID: 173309
		[Token(Token = "0x402A4FD")]
		[FieldOffset(Offset = "0x0")]
		public string id;

		// Token: 0x0402A4FE RID: 173310
		[Token(Token = "0x402A4FE")]
		[FieldOffset(Offset = "0x8")]
		public RoguelikeGameCharBuffType buffType;

		// Token: 0x0402A4FF RID: 173311
		[Token(Token = "0x402A4FF")]
		[FieldOffset(Offset = "0x10")]
		public string outerName;

		// Token: 0x0402A500 RID: 173312
		[Token(Token = "0x402A500")]
		[FieldOffset(Offset = "0x18")]
		public string innerName;

		// Token: 0x0402A501 RID: 173313
		[Token(Token = "0x402A501")]
		[FieldOffset(Offset = "0x20")]
		public string effect;

		// Token: 0x0402A502 RID: 173314
		[Token(Token = "0x402A502")]
		[FieldOffset(Offset = "0x28")]
		public string desc;

		// Token: 0x0402A503 RID: 173315
		[Token(Token = "0x402A503")]
		[FieldOffset(Offset = "0x30")]
		public string icon;

		// Token: 0x0402A504 RID: 173316
		[Token(Token = "0x402A504")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;
	}
}
