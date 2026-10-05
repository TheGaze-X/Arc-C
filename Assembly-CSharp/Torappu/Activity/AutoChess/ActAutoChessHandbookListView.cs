using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x020070F6 RID: 28918
	[Token(Token = "0x20070F6")]
	public class ActAutoChessHandbookListView : DataBinder<ActAutoChessHandbookProperty>, IHotfixable
	{
		// Token: 0x060291AD RID: 168365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60291AD")]
		[Address(RVA = "0x24854B0", Offset = "0x24840B0", VA = "0x1824854B0", Slot = "7")]
		public override void OnValueChanged(ActAutoChessHandbookProperty property)
		{
		}

		// Token: 0x060291AE RID: 168366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60291AE")]
		[Address(RVA = "0x24857F0", Offset = "0x24843F0", VA = "0x1824857F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060291AF RID: 168367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60291AF")]
		[Address(RVA = "0x2485960", Offset = "0x2484560", VA = "0x182485960")]
		public ActAutoChessHandbookListView()
		{
		}

		// Token: 0x0403AACB RID: 240331
		[Token(Token = "0x403AACB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ActAutoChessHandbookTabType _tabType;

		// Token: 0x0403AACC RID: 240332
		[Token(Token = "0x403AACC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UISimpleRecycleLayoutItemView[] _prefabList;

		// Token: 0x0403AACD RID: 240333
		[Token(Token = "0x403AACD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIRecycleVerticalLayoutGroup _layoutGroup;

		// Token: 0x0403AACE RID: 240334
		[Token(Token = "0x403AACE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIWrappedScrollRect _scrollRect;

		// Token: 0x0403AACF RID: 240335
		[Token(Token = "0x403AACF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0403AAD0 RID: 240336
		[Token(Token = "0x403AAD0")]
		[FieldOffset(Offset = "0x48")]
		private bool m_hasInited;

		// Token: 0x0403AAD1 RID: 240337
		[Token(Token = "0x403AAD1")]
		[FieldOffset(Offset = "0x50")]
		private UISimpleRecycleLayoutAdapter m_adapter;

		// Token: 0x0403AAD2 RID: 240338
		[Token(Token = "0x403AAD2")]
		[FieldOffset(Offset = "0x58")]
		private UISwitchTween m_switchTween;

		// Token: 0x0403AAD3 RID: 240339
		[Token(Token = "0x403AAD3")]
		[FieldOffset(Offset = "0x60")]
		private int m_cachedSequence;

		// Token: 0x0403AAD4 RID: 240340
		[Token(Token = "0x403AAD4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403AAD5 RID: 240341
		[Token(Token = "0x403AAD5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403AAD6 RID: 240342
		[Token(Token = "0x403AAD6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
