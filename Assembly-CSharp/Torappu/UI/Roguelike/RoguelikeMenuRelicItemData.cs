using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005300 RID: 21248
	[Token(Token = "0x2005300")]
	public class RoguelikeMenuRelicItemData : IHotfixable
	{
		// Token: 0x0601F588 RID: 128392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F588")]
		[Address(RVA = "0x1912C60", Offset = "0x1911860", VA = "0x181912C60")]
		public string GetId()
		{
			return null;
		}

		// Token: 0x0601F589 RID: 128393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F589")]
		[Address(RVA = "0x1912CC0", Offset = "0x19118C0", VA = "0x181912CC0")]
		public RoguelikeMenuRelicItemData()
		{
		}

		// Token: 0x0402A1E3 RID: 172515
		[Token(Token = "0x402A1E3")]
		public const string INDEX_ID_FORMAT = "{0}_{1}";

		// Token: 0x0402A1E4 RID: 172516
		[Token(Token = "0x402A1E4")]
		[FieldOffset(Offset = "0x10")]
		public IRoguelikeRelicViewModel relicViewModel;

		// Token: 0x0402A1E5 RID: 172517
		[Token(Token = "0x402A1E5")]
		[FieldOffset(Offset = "0x18")]
		public int viewIndex;

		// Token: 0x0402A1E6 RID: 172518
		[Token(Token = "0x402A1E6")]
		[FieldOffset(Offset = "0x1C")]
		public bool showFullIcon;

		// Token: 0x0402A1E7 RID: 172519
		[Token(Token = "0x402A1E7")]
		[FieldOffset(Offset = "0x20")]
		public string indexId;

		// Token: 0x0402A1E8 RID: 172520
		[Token(Token = "0x402A1E8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetId;

		// Token: 0x0402A1E9 RID: 172521
		[Token(Token = "0x402A1E9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
