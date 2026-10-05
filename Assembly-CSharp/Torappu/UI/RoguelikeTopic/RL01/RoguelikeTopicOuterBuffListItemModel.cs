using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL01
{
	// Token: 0x02004661 RID: 18017
	[Token(Token = "0x2004661")]
	public class RoguelikeTopicOuterBuffListItemModel : IHotfixable
	{
		// Token: 0x0601B5CE RID: 112078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B5CE")]
		[Address(RVA = "0x14BE6C0", Offset = "0x14BD2C0", VA = "0x1814BE6C0")]
		public string GetId()
		{
			return null;
		}

		// Token: 0x0601B5CF RID: 112079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B5CF")]
		[Address(RVA = "0x14BE730", Offset = "0x14BD330", VA = "0x1814BE730")]
		public RoguelikeTopicOuterBuffListItemModel()
		{
		}

		// Token: 0x040235B3 RID: 144819
		[Token(Token = "0x40235B3")]
		[FieldOffset(Offset = "0x10")]
		public int viewIndex;

		// Token: 0x040235B4 RID: 144820
		[Token(Token = "0x40235B4")]
		[FieldOffset(Offset = "0x18")]
		public RoguelikeTopicDisplayItem displayItem;

		// Token: 0x040235B5 RID: 144821
		[Token(Token = "0x40235B5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetId;

		// Token: 0x040235B6 RID: 144822
		[Token(Token = "0x40235B6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
