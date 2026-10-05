using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.CharSelect;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005489 RID: 21641
	[Token(Token = "0x2005489")]
	public class RoguelikeCharInventoryState : PopupFadeState
	{
		// Token: 0x0601FD71 RID: 130417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FD71")]
		[Address(RVA = "0x19F0690", Offset = "0x19EF290", VA = "0x1819F0690")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601FD72 RID: 130418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FD72")]
		[Address(RVA = "0x19F01D0", Offset = "0x19EEDD0", VA = "0x1819F01D0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601FD73 RID: 130419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FD73")]
		[Address(RVA = "0x19EFE60", Offset = "0x19EEA60", VA = "0x1819EFE60")]
		public void DealWithCharClick(int instId)
		{
		}

		// Token: 0x0601FD74 RID: 130420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FD74")]
		[Address(RVA = "0x19F0090", Offset = "0x19EEC90", VA = "0x1819F0090")]
		public void EventOnAttrTabClick(CharAttrTabType tabType)
		{
		}

		// Token: 0x0601FD75 RID: 130421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FD75")]
		[Address(RVA = "0x19F0170", Offset = "0x19EED70", VA = "0x1819F0170", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601FD76 RID: 130422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FD76")]
		[Address(RVA = "0x19F0790", Offset = "0x19EF390", VA = "0x1819F0790")]
		public RoguelikeCharInventoryState()
		{
		}

		// Token: 0x0601FD77 RID: 130423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FD77")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0402AE4F RID: 175695
		[Token(Token = "0x402AE4F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _panelTopMenu;

		// Token: 0x0402AE50 RID: 175696
		[Token(Token = "0x402AE50")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RoguelikeCharInventoryStateBean _stateBean;

		// Token: 0x0402AE51 RID: 175697
		[Token(Token = "0x402AE51")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RoguelikeCharSelectView _view;

		// Token: 0x0402AE52 RID: 175698
		[Token(Token = "0x402AE52")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Transform _pluginContainer;

		// Token: 0x0402AE53 RID: 175699
		[Token(Token = "0x402AE53")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private LoopScrollRect _loopScrollRect;

		// Token: 0x0402AE54 RID: 175700
		[Token(Token = "0x402AE54")]
		[FieldOffset(Offset = "0x98")]
		private bool m_inited;

		// Token: 0x0402AE55 RID: 175701
		[Token(Token = "0x402AE55")]
		[FieldOffset(Offset = "0xA0")]
		private RoguelikeCharInventoryState.MenuAdapter m_menuAdapter;

		// Token: 0x0402AE56 RID: 175702
		[Token(Token = "0x402AE56")]
		[FieldOffset(Offset = "0xA8")]
		private RoguelikeCommonTopMenu m_topMenu;

		// Token: 0x0402AE57 RID: 175703
		[Token(Token = "0x402AE57")]
		[FieldOffset(Offset = "0xB0")]
		private List<IRoguelikeCharCardViewPluginContext> m_pluginContexts;

		// Token: 0x0402AE58 RID: 175704
		[Token(Token = "0x402AE58")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402AE59 RID: 175705
		[Token(Token = "0x402AE59")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402AE5A RID: 175706
		[Token(Token = "0x402AE5A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DealWithCharClick;

		// Token: 0x0402AE5B RID: 175707
		[Token(Token = "0x402AE5B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnAttrTabClick;

		// Token: 0x0402AE5C RID: 175708
		[Token(Token = "0x402AE5C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402AE5D RID: 175709
		[Token(Token = "0x402AE5D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200548A RID: 21642
		[Token(Token = "0x200548A")]
		private class MenuAdapter : RoguelikeMenuAdapter
		{
			// Token: 0x17004AAD RID: 19117
			// (get) Token: 0x0601FD78 RID: 130424 RVA: 0x000B37C0 File Offset: 0x000B19C0
			[Token(Token = "0x17004AAD")]
			public override bool showBottomBar
			{
				[Token(Token = "0x601FD78")]
				[Address(RVA = "0x19E7270", Offset = "0x19E5E70", VA = "0x1819E7270", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17004AAE RID: 19118
			// (get) Token: 0x0601FD79 RID: 130425 RVA: 0x000B37D8 File Offset: 0x000B19D8
			[Token(Token = "0x17004AAE")]
			public override RoguelikeMenuCharObjectStatus charMenuObjectStatus
			{
				[Token(Token = "0x601FD79")]
				[Address(RVA = "0x19E71A0", Offset = "0x19E5DA0", VA = "0x1819E71A0", Slot = "8")]
				get
				{
					return RoguelikeMenuCharObjectStatus.HIDE;
				}
			}

			// Token: 0x17004AAF RID: 19119
			// (get) Token: 0x0601FD7A RID: 130426 RVA: 0x000B37F0 File Offset: 0x000B19F0
			[Token(Token = "0x17004AAF")]
			public override RoguelikeMenuTotemObjectStatus totemMenuObjectStatus
			{
				[Token(Token = "0x601FD7A")]
				[Address(RVA = "0x19E73F0", Offset = "0x19E5FF0", VA = "0x1819E73F0", Slot = "10")]
				get
				{
					return RoguelikeMenuTotemObjectStatus.NORMAL;
				}
			}

			// Token: 0x0601FD7B RID: 130427 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601FD7B")]
			[Address(RVA = "0x19E7000", Offset = "0x19E5C00", VA = "0x1819E7000")]
			public MenuAdapter()
			{
			}

			// Token: 0x0601FD7C RID: 130428 RVA: 0x000B3808 File Offset: 0x000B1A08
			[Token(Token = "0x601FD7C")]
			[Address(RVA = "0x189EFE0", Offset = "0x189DBE0", VA = "0x18189EFE0")]
			private bool <>xLuaBaseProxy_get_showBottomBar()
			{
				return default(bool);
			}

			// Token: 0x0601FD7D RID: 130429 RVA: 0x000B3820 File Offset: 0x000B1A20
			[Token(Token = "0x601FD7D")]
			[Address(RVA = "0x19E6F70", Offset = "0x19E5B70", VA = "0x1819E6F70")]
			private RoguelikeMenuCharObjectStatus <>xLuaBaseProxy_get_charMenuObjectStatus()
			{
				return RoguelikeMenuCharObjectStatus.HIDE;
			}

			// Token: 0x0601FD7E RID: 130430 RVA: 0x000B3838 File Offset: 0x000B1A38
			[Token(Token = "0x601FD7E")]
			[Address(RVA = "0x18C78F0", Offset = "0x18C64F0", VA = "0x1818C78F0")]
			private RoguelikeMenuTotemObjectStatus <>xLuaBaseProxy_get_totemMenuObjectStatus()
			{
				return RoguelikeMenuTotemObjectStatus.NORMAL;
			}

			// Token: 0x0402AE5E RID: 175710
			[Token(Token = "0x402AE5E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_showBottomBar;

			// Token: 0x0402AE5F RID: 175711
			[Token(Token = "0x402AE5F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_charMenuObjectStatus;

			// Token: 0x0402AE60 RID: 175712
			[Token(Token = "0x402AE60")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_totemMenuObjectStatus;

			// Token: 0x0402AE61 RID: 175713
			[Token(Token = "0x402AE61")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
