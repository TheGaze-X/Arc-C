using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024B8 RID: 9400
	[Token(Token = "0x20024B8")]
	public class Svash2Skchr3CardIconPluginTalent : CardIconWithNumPluginTalent
	{
		// Token: 0x0600F1E1 RID: 61921 RVA: 0x00059220 File Offset: 0x00057420
		[Token(Token = "0x600F1E1")]
		[Address(RVA = "0x697740", Offset = "0x696340", VA = "0x180697740", Slot = "38")]
		public override int GetIconNum(Deck.Card card)
		{
			return 0;
		}

		// Token: 0x0600F1E2 RID: 61922 RVA: 0x00059238 File Offset: 0x00057438
		[Token(Token = "0x600F1E2")]
		[Address(RVA = "0x6977C0", Offset = "0x6963C0", VA = "0x1806977C0", Slot = "39")]
		public override bool NeedShow(Deck.Card card)
		{
			return default(bool);
		}

		// Token: 0x0600F1E3 RID: 61923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F1E3")]
		[Address(RVA = "0x697AB0", Offset = "0x6966B0", VA = "0x180697AB0")]
		public Svash2Skchr3CardIconPluginTalent()
		{
		}

		// Token: 0x0600F1E5 RID: 61925 RVA: 0x00059250 File Offset: 0x00057450
		[Token(Token = "0x600F1E5")]
		[Address(RVA = "0x686760", Offset = "0x685360", VA = "0x180686760")]
		private int <>xLuaBaseProxy_GetIconNum(Deck.Card P0)
		{
			return 0;
		}

		// Token: 0x0600F1E6 RID: 61926 RVA: 0x00059268 File Offset: 0x00057468
		[Token(Token = "0x600F1E6")]
		[Address(RVA = "0x697A10", Offset = "0x696610", VA = "0x180697A10")]
		private bool <>xLuaBaseProxy_NeedShow(Deck.Card P0)
		{
			return default(bool);
		}

		// Token: 0x04010BAC RID: 68524
		[Token(Token = "0x4010BAC")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private DeckSelector _deckSelectorRight;

		// Token: 0x04010BAD RID: 68525
		[Token(Token = "0x4010BAD")]
		[FieldOffset(Offset = "0x0")]
		private static ListDict<uint, int> s_sharedCostDic;

		// Token: 0x04010BAE RID: 68526
		[Token(Token = "0x4010BAE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetIconNum;

		// Token: 0x04010BAF RID: 68527
		[Token(Token = "0x4010BAF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_NeedShow;

		// Token: 0x04010BB0 RID: 68528
		[Token(Token = "0x4010BB0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
