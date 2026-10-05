using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.Fragment;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x020056C6 RID: 22214
	[Token(Token = "0x20056C6")]
	public class RL04FragmentDetailViewModel : IHotfixable
	{
		// Token: 0x06020950 RID: 133456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020950")]
		[Address(RVA = "0x1AAD3C0", Offset = "0x1AABFC0", VA = "0x181AAD3C0")]
		public void LoadData(RL04FragmentDetailDialog.Options input)
		{
		}

		// Token: 0x06020951 RID: 133457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020951")]
		[Address(RVA = "0x1AAD610", Offset = "0x1AAC210", VA = "0x181AAD610")]
		public void SelectNextItem()
		{
		}

		// Token: 0x06020952 RID: 133458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020952")]
		[Address(RVA = "0x1AAD680", Offset = "0x1AAC280", VA = "0x181AAD680")]
		public void SelectPrevItem()
		{
		}

		// Token: 0x06020953 RID: 133459 RVA: 0x000B6700 File Offset: 0x000B4900
		[Token(Token = "0x6020953")]
		[Address(RVA = "0x1AAD310", Offset = "0x1AABF10", VA = "0x181AAD310")]
		public int GetFocusItemIndex(bool isRemoved = false)
		{
			return 0;
		}

		// Token: 0x06020954 RID: 133460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020954")]
		[Address(RVA = "0x1AAD6F0", Offset = "0x1AAC2F0", VA = "0x181AAD6F0")]
		private void _RefreshStatus()
		{
		}

		// Token: 0x06020955 RID: 133461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020955")]
		[Address(RVA = "0x1AAD8A0", Offset = "0x1AAC4A0", VA = "0x181AAD8A0")]
		public RL04FragmentDetailViewModel()
		{
		}

		// Token: 0x0402C280 RID: 180864
		[Token(Token = "0x402C280")]
		[FieldOffset(Offset = "0x10")]
		public List<RL04FragmentItemViewModel> fragmentList;

		// Token: 0x0402C281 RID: 180865
		[Token(Token = "0x402C281")]
		[FieldOffset(Offset = "0x18")]
		public int selectIndex;

		// Token: 0x0402C282 RID: 180866
		[Token(Token = "0x402C282")]
		[FieldOffset(Offset = "0x1C")]
		public bool isFirst;

		// Token: 0x0402C283 RID: 180867
		[Token(Token = "0x402C283")]
		[FieldOffset(Offset = "0x1D")]
		public bool isLast;

		// Token: 0x0402C284 RID: 180868
		[Token(Token = "0x402C284")]
		[FieldOffset(Offset = "0x1E")]
		public bool isEnter;

		// Token: 0x0402C285 RID: 180869
		[Token(Token = "0x402C285")]
		[FieldOffset(Offset = "0x1F")]
		public bool hasCurrInspiration;

		// Token: 0x0402C286 RID: 180870
		[Token(Token = "0x402C286")]
		[FieldOffset(Offset = "0x20")]
		public RL04FragmentDetailWeightViewModel weightModel;

		// Token: 0x0402C287 RID: 180871
		[Token(Token = "0x402C287")]
		[FieldOffset(Offset = "0x28")]
		public RoguelikeFragmentDialogMode mode;

		// Token: 0x0402C288 RID: 180872
		[Token(Token = "0x402C288")]
		[FieldOffset(Offset = "0x2C")]
		private int m_entrySelectIndex;

		// Token: 0x0402C289 RID: 180873
		[Token(Token = "0x402C289")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402C28A RID: 180874
		[Token(Token = "0x402C28A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SelectNextItem;

		// Token: 0x0402C28B RID: 180875
		[Token(Token = "0x402C28B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SelectPrevItem;

		// Token: 0x0402C28C RID: 180876
		[Token(Token = "0x402C28C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetFocusItemIndex;

		// Token: 0x0402C28D RID: 180877
		[Token(Token = "0x402C28D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RefreshStatus;

		// Token: 0x0402C28E RID: 180878
		[Token(Token = "0x402C28E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
