using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x020019BF RID: 6591
	[Token(Token = "0x20019BF")]
	public class DIYBottomMenuState : DIYBottomMenuPopupState
	{
		// Token: 0x0600A591 RID: 42385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A591")]
		[Address(RVA = "0x31EC400", Offset = "0x31EB000", VA = "0x1831EC400", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0600A592 RID: 42386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A592")]
		[Address(RVA = "0x31EC460", Offset = "0x31EB060", VA = "0x1831EC460", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0600A593 RID: 42387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A593")]
		[Address(RVA = "0x31ECD90", Offset = "0x31EB990", VA = "0x1831ECD90")]
		private void _SwitchToTab(DIYBottomMenuState.MenuState menuState, bool fastMode = false)
		{
		}

		// Token: 0x0600A594 RID: 42388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A594")]
		[Address(RVA = "0x31ECC90", Offset = "0x31EB890", VA = "0x1831ECC90")]
		private IEnumerator _SwitchCoroutine(DIYBottomMenuState.DIYBottomMenuTabState srcMenuState, DIYBottomMenuState.DIYBottomMenuTabState dstMenuState)
		{
			return null;
		}

		// Token: 0x0600A595 RID: 42389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A595")]
		[Address(RVA = "0x31ECC20", Offset = "0x31EB820", VA = "0x1831ECC20")]
		public void ResetTab()
		{
		}

		// Token: 0x0600A596 RID: 42390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A596")]
		[Address(RVA = "0x31EC600", Offset = "0x31EB200", VA = "0x1831EC600")]
		public void OnOverviewTabPressed()
		{
		}

		// Token: 0x0600A597 RID: 42391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A597")]
		[Address(RVA = "0x31EC850", Offset = "0x31EB450", VA = "0x1831EC850")]
		public void OnRecentTabPressed()
		{
		}

		// Token: 0x0600A598 RID: 42392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A598")]
		[Address(RVA = "0x31EC9E0", Offset = "0x31EB5E0", VA = "0x1831EC9E0")]
		public void OnSinglePressed()
		{
		}

		// Token: 0x0600A599 RID: 42393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A599")]
		[Address(RVA = "0x31ECB00", Offset = "0x31EB700", VA = "0x1831ECB00")]
		public void OnThemePressed()
		{
		}

		// Token: 0x0600A59A RID: 42394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A59A")]
		[Address(RVA = "0x31EC670", Offset = "0x31EB270", VA = "0x1831EC670")]
		public void OnPresetPressed()
		{
		}

		// Token: 0x0600A59B RID: 42395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A59B")]
		[Address(RVA = "0x31EC8C0", Offset = "0x31EB4C0", VA = "0x1831EC8C0")]
		public void OnRecentThemePressed()
		{
		}

		// Token: 0x0600A59C RID: 42396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A59C")]
		[Address(RVA = "0x31EC730", Offset = "0x31EB330", VA = "0x1831EC730")]
		public void OnRecentSinglePressed()
		{
		}

		// Token: 0x0600A59D RID: 42397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A59D")]
		[Address(RVA = "0x31ED030", Offset = "0x31EBC30", VA = "0x1831ED030")]
		public DIYBottomMenuState()
		{
		}

		// Token: 0x0600A59E RID: 42398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A59E")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x04009D53 RID: 40275
		[Token(Token = "0x4009D53")]
		private const float CURSOR_MOVE_DURATION = 0.25f;

		// Token: 0x04009D54 RID: 40276
		[Token(Token = "0x4009D54")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		protected DIYListViewStateBean _stateBean;

		// Token: 0x04009D55 RID: 40277
		[Token(Token = "0x4009D55")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private DIYBottomMenuState.DIYBottomMenuTabState[] _tabStates;

		// Token: 0x04009D56 RID: 40278
		[Token(Token = "0x4009D56")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _cursor;

		// Token: 0x04009D57 RID: 40279
		[Token(Token = "0x4009D57")]
		[FieldOffset(Offset = "0x80")]
		private DIYBottomMenuState.MenuState m_currState;

		// Token: 0x04009D58 RID: 40280
		[Token(Token = "0x4009D58")]
		[FieldOffset(Offset = "0x88")]
		private Dictionary<DIYBottomMenuState.MenuState, DIYBottomMenuState.DIYBottomMenuTabState> m_menuStates;

		// Token: 0x04009D59 RID: 40281
		[Token(Token = "0x4009D59")]
		[FieldOffset(Offset = "0x90")]
		private bool m_isSwitching;

		// Token: 0x04009D5A RID: 40282
		[Token(Token = "0x4009D5A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04009D5B RID: 40283
		[Token(Token = "0x4009D5B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04009D5C RID: 40284
		[Token(Token = "0x4009D5C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SwitchToTab;

		// Token: 0x04009D5D RID: 40285
		[Token(Token = "0x4009D5D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SwitchCoroutine;

		// Token: 0x04009D5E RID: 40286
		[Token(Token = "0x4009D5E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ResetTab;

		// Token: 0x04009D5F RID: 40287
		[Token(Token = "0x4009D5F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnOverviewTabPressed;

		// Token: 0x04009D60 RID: 40288
		[Token(Token = "0x4009D60")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnRecentTabPressed;

		// Token: 0x04009D61 RID: 40289
		[Token(Token = "0x4009D61")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnSinglePressed;

		// Token: 0x04009D62 RID: 40290
		[Token(Token = "0x4009D62")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnThemePressed;

		// Token: 0x04009D63 RID: 40291
		[Token(Token = "0x4009D63")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnPresetPressed;

		// Token: 0x04009D64 RID: 40292
		[Token(Token = "0x4009D64")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnRecentThemePressed;

		// Token: 0x04009D65 RID: 40293
		[Token(Token = "0x4009D65")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnRecentSinglePressed;

		// Token: 0x04009D66 RID: 40294
		[Token(Token = "0x4009D66")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020019C0 RID: 6592
		[Token(Token = "0x20019C0")]
		public enum MenuState
		{
			// Token: 0x04009D68 RID: 40296
			[Token(Token = "0x4009D68")]
			OVERVIEW,
			// Token: 0x04009D69 RID: 40297
			[Token(Token = "0x4009D69")]
			RECENT,
			// Token: 0x04009D6A RID: 40298
			[Token(Token = "0x4009D6A")]
			NONE = 99
		}

		// Token: 0x020019C1 RID: 6593
		[Token(Token = "0x20019C1")]
		[Serializable]
		public class DIYBottomMenuTabState
		{
			// Token: 0x0600A59F RID: 42399 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A59F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DIYBottomMenuTabState()
			{
			}

			// Token: 0x04009D6B RID: 40299
			[Token(Token = "0x4009D6B")]
			[FieldOffset(Offset = "0x10")]
			public DIYBottomMenuState.MenuState menuState;

			// Token: 0x04009D6C RID: 40300
			[Token(Token = "0x4009D6C")]
			[FieldOffset(Offset = "0x18")]
			public DIYBottomMenuTabStateView tabStateView;

			// Token: 0x04009D6D RID: 40301
			[Token(Token = "0x4009D6D")]
			[FieldOffset(Offset = "0x20")]
			public int cursorPosX;
		}
	}
}
