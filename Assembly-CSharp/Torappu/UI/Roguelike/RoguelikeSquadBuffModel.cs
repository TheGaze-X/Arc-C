using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005354 RID: 21332
	[Token(Token = "0x2005354")]
	public struct RoguelikeSquadBuffModel : IHotfixable
	{
		// Token: 0x0601F734 RID: 128820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F734")]
		[Address(RVA = "0x1934A20", Offset = "0x1933620", VA = "0x181934A20")]
		public void LoadData(string topicId, string squadBuffId)
		{
		}

		// Token: 0x0402A505 RID: 173317
		[Token(Token = "0x402A505")]
		[FieldOffset(Offset = "0x0")]
		public string id;

		// Token: 0x0402A506 RID: 173318
		[Token(Token = "0x402A506")]
		[FieldOffset(Offset = "0x8")]
		public string outerName;

		// Token: 0x0402A507 RID: 173319
		[Token(Token = "0x402A507")]
		[FieldOffset(Offset = "0x10")]
		public string innerName;

		// Token: 0x0402A508 RID: 173320
		[Token(Token = "0x402A508")]
		[FieldOffset(Offset = "0x18")]
		public string effect;

		// Token: 0x0402A509 RID: 173321
		[Token(Token = "0x402A509")]
		[FieldOffset(Offset = "0x20")]
		public string desc;

		// Token: 0x0402A50A RID: 173322
		[Token(Token = "0x402A50A")]
		[FieldOffset(Offset = "0x28")]
		public string icon;

		// Token: 0x0402A50B RID: 173323
		[Token(Token = "0x402A50B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;
	}
}
