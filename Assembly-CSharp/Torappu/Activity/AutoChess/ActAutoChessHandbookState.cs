using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x020070F7 RID: 28919
	[Token(Token = "0x20070F7")]
	public class ActAutoChessHandbookState : PopupFadeState, IValueMsgReceiver, IHotfixable
	{
		// Token: 0x060291B0 RID: 168368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60291B0")]
		[Address(RVA = "0x2485CD0", Offset = "0x24848D0", VA = "0x182485CD0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060291B1 RID: 168369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60291B1")]
		[Address(RVA = "0x2485D30", Offset = "0x2484930", VA = "0x182485D30", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060291B2 RID: 168370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60291B2")]
		[Address(RVA = "0x2486240", Offset = "0x2484E40", VA = "0x182486240", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x060291B3 RID: 168371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60291B3")]
		[Address(RVA = "0x2486340", Offset = "0x2484F40", VA = "0x182486340", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x060291B4 RID: 168372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60291B4")]
		[Address(RVA = "0x24871C0", Offset = "0x2485DC0", VA = "0x1824871C0")]
		private void _OnJumpToEnemyHandbook(IStateBean bean)
		{
		}

		// Token: 0x060291B5 RID: 168373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60291B5")]
		[Address(RVA = "0x2486030", Offset = "0x2484C30", VA = "0x182486030", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x060291B6 RID: 168374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60291B6")]
		[Address(RVA = "0x2486E20", Offset = "0x2485A20", VA = "0x182486E20")]
		private void _EventOnTabItemClicked(ActAutoChessHandbookTabType tabType)
		{
		}

		// Token: 0x060291B7 RID: 168375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60291B7")]
		[Address(RVA = "0x2486A90", Offset = "0x2485690", VA = "0x182486A90")]
		private void _EventOnItemClicked(string itemId)
		{
		}

		// Token: 0x060291B8 RID: 168376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60291B8")]
		[Address(RVA = "0x2486640", Offset = "0x2485240", VA = "0x182486640")]
		private void _EventOnBondClicked(ActAutoChessHandbookViewModel model, string itemId)
		{
		}

		// Token: 0x060291B9 RID: 168377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60291B9")]
		[Address(RVA = "0x24864A0", Offset = "0x24850A0", VA = "0x1824864A0")]
		private void _EventOnBandClicked(ActAutoChessHandbookViewModel model, string itemId)
		{
		}

		// Token: 0x060291BA RID: 168378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60291BA")]
		[Address(RVA = "0x2486720", Offset = "0x2485320", VA = "0x182486720")]
		private void _EventOnEnemyClicked(ActAutoChessHandbookViewModel model, string itemId)
		{
		}

		// Token: 0x060291BB RID: 168379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60291BB")]
		[Address(RVA = "0x2486800", Offset = "0x2485400", VA = "0x182486800")]
		private void _EventOnEnemyDetailClicked(string enemyId)
		{
		}

		// Token: 0x060291BC RID: 168380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60291BC")]
		[Address(RVA = "0x2486EF0", Offset = "0x2485AF0", VA = "0x182486EF0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060291BD RID: 168381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60291BD")]
		[Address(RVA = "0x2487490", Offset = "0x2486090", VA = "0x182487490")]
		private void _TryTriggerGuidebook()
		{
		}

		// Token: 0x060291BE RID: 168382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60291BE")]
		[Address(RVA = "0x2487540", Offset = "0x2486140", VA = "0x182487540")]
		public ActAutoChessHandbookState()
		{
		}

		// Token: 0x060291BF RID: 168383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60291BF")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x060291C0 RID: 168384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60291C0")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x060291C1 RID: 168385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60291C1")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0403AAD7 RID: 240343
		[Token(Token = "0x403AAD7")]
		[NonSerialized]
		public const int ON_TAB_ITEM_CLICKED = 0;

		// Token: 0x0403AAD8 RID: 240344
		[Token(Token = "0x403AAD8")]
		[NonSerialized]
		public const int ON_ITEM_CLICKED = 1;

		// Token: 0x0403AAD9 RID: 240345
		[Token(Token = "0x403AAD9")]
		[NonSerialized]
		public const int ON_ENEMY_DETAIL_CLICKED = 2;

		// Token: 0x0403AADA RID: 240346
		[Token(Token = "0x403AADA")]
		[NonSerialized]
		public const float PANEL_FADE_DURATION = 0.2f;

		// Token: 0x0403AADB RID: 240347
		[Token(Token = "0x403AADB")]
		private const string GUIDEBOOK_SUB_SIGNAL = "handbook";

		// Token: 0x0403AADC RID: 240348
		[Token(Token = "0x403AADC")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ActAutoChessHandbookTopBarView _topBarView;

		// Token: 0x0403AADD RID: 240349
		[Token(Token = "0x403AADD")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ActAutoChessHandbookListView[] _listView;

		// Token: 0x0403AADE RID: 240350
		[Token(Token = "0x403AADE")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private ActAutoChessHandbookDetailBaseView[] _detailView;

		// Token: 0x0403AADF RID: 240351
		[Token(Token = "0x403AADF")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x0403AAE0 RID: 240352
		[Token(Token = "0x403AAE0")]
		[FieldOffset(Offset = "0x90")]
		private bool m_hasInited;

		// Token: 0x0403AAE1 RID: 240353
		[Token(Token = "0x403AAE1")]
		[FieldOffset(Offset = "0x98")]
		private ActAutoChessHandbookStateBean m_stateBean;

		// Token: 0x0403AAE2 RID: 240354
		[Token(Token = "0x403AAE2")]
		[FieldOffset(Offset = "0xA0")]
		private ActAutoChessHandbookEnemyViewModel m_cacheEnemyModel;

		// Token: 0x0403AAE3 RID: 240355
		[Token(Token = "0x403AAE3")]
		[FieldOffset(Offset = "0xA8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403AAE4 RID: 240356
		[Token(Token = "0x403AAE4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403AAE5 RID: 240357
		[Token(Token = "0x403AAE5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403AAE6 RID: 240358
		[Token(Token = "0x403AAE6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0403AAE7 RID: 240359
		[Token(Token = "0x403AAE7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0403AAE8 RID: 240360
		[Token(Token = "0x403AAE8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnJumpToEnemyHandbook;

		// Token: 0x0403AAE9 RID: 240361
		[Token(Token = "0x403AAE9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0403AAEA RID: 240362
		[Token(Token = "0x403AAEA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__EventOnTabItemClicked;

		// Token: 0x0403AAEB RID: 240363
		[Token(Token = "0x403AAEB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__EventOnItemClicked;

		// Token: 0x0403AAEC RID: 240364
		[Token(Token = "0x403AAEC")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__EventOnBondClicked;

		// Token: 0x0403AAED RID: 240365
		[Token(Token = "0x403AAED")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__EventOnBandClicked;

		// Token: 0x0403AAEE RID: 240366
		[Token(Token = "0x403AAEE")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__EventOnEnemyClicked;

		// Token: 0x0403AAEF RID: 240367
		[Token(Token = "0x403AAEF")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__EventOnEnemyDetailClicked;

		// Token: 0x0403AAF0 RID: 240368
		[Token(Token = "0x403AAF0")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403AAF1 RID: 240369
		[Token(Token = "0x403AAF1")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__TryTriggerGuidebook;

		// Token: 0x0403AAF2 RID: 240370
		[Token(Token = "0x403AAF2")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
