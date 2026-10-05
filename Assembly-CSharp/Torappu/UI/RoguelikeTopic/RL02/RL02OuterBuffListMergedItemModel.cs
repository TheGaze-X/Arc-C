using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL02
{
	// Token: 0x0200462C RID: 17964
	[Token(Token = "0x200462C")]
	public class RL02OuterBuffListMergedItemModel : IHotfixable
	{
		// Token: 0x1700410D RID: 16653
		// (get) Token: 0x0601B4AE RID: 111790 RVA: 0x000A4D30 File Offset: 0x000A2F30
		[Token(Token = "0x1700410D")]
		public bool isLocked
		{
			[Token(Token = "0x601B4AE")]
			[Address(RVA = "0x149D8B0", Offset = "0x149C4B0", VA = "0x18149D8B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601B4AF RID: 111791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B4AF")]
		[Address(RVA = "0x149D7C0", Offset = "0x149C3C0", VA = "0x18149D7C0")]
		public string GetId()
		{
			return null;
		}

		// Token: 0x0601B4B0 RID: 111792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B4B0")]
		[Address(RVA = "0x149D850", Offset = "0x149C450", VA = "0x18149D850")]
		public RL02OuterBuffListMergedItemModel()
		{
		}

		// Token: 0x040233D2 RID: 144338
		[Token(Token = "0x40233D2")]
		[FieldOffset(Offset = "0x10")]
		public int viewIndex;

		// Token: 0x040233D3 RID: 144339
		[Token(Token = "0x40233D3")]
		[FieldOffset(Offset = "0x18")]
		public RoguelikeTopicDisplayItem displayItem;

		// Token: 0x040233D4 RID: 144340
		[Token(Token = "0x40233D4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isLocked;

		// Token: 0x040233D5 RID: 144341
		[Token(Token = "0x40233D5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetId;

		// Token: 0x040233D6 RID: 144342
		[Token(Token = "0x40233D6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
