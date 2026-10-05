using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020051BC RID: 20924
	[Token(Token = "0x20051BC")]
	public class RoguelikeChoiceState : PopupFadeState, IHotfixable
	{
		// Token: 0x0601EE6C RID: 126572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EE6C")]
		[Address(RVA = "0x18A5160", Offset = "0x18A3D60", VA = "0x1818A5160", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601EE6D RID: 126573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EE6D")]
		[Address(RVA = "0x18A53D0", Offset = "0x18A3FD0", VA = "0x1818A53D0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601EE6E RID: 126574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EE6E")]
		[Address(RVA = "0x18A5360", Offset = "0x18A3F60", VA = "0x1818A5360", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x0601EE6F RID: 126575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EE6F")]
		[Address(RVA = "0x18A50A0", Offset = "0x18A3CA0", VA = "0x1818A50A0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601EE70 RID: 126576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EE70")]
		[Address(RVA = "0x18A5100", Offset = "0x18A3D00", VA = "0x1818A5100")]
		private void OnDestroy()
		{
		}

		// Token: 0x0601EE71 RID: 126577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EE71")]
		[Address(RVA = "0x18A55C0", Offset = "0x18A41C0", VA = "0x1818A55C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601EE72 RID: 126578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EE72")]
		[Address(RVA = "0x18A6110", Offset = "0x18A4D10", VA = "0x1818A6110")]
		private void _SetEffectVisible(bool isVisible)
		{
		}

		// Token: 0x0601EE73 RID: 126579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EE73")]
		[Address(RVA = "0x18A5C10", Offset = "0x18A4810", VA = "0x1818A5C10")]
		private void _QuitChoiceScene()
		{
		}

		// Token: 0x0601EE74 RID: 126580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EE74")]
		[Address(RVA = "0x18A63D0", Offset = "0x18A4FD0", VA = "0x1818A63D0")]
		private void _TriggerBGMSignal()
		{
		}

		// Token: 0x0601EE75 RID: 126581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EE75")]
		[Address(RVA = "0x18A5520", Offset = "0x18A4120", VA = "0x1818A5520")]
		private void _ClearBGM()
		{
		}

		// Token: 0x0601EE76 RID: 126582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EE76")]
		[Address(RVA = "0x18A62E0", Offset = "0x18A4EE0", VA = "0x1818A62E0")]
		private void _ShowRoguelikeMenu(bool isShow)
		{
		}

		// Token: 0x0601EE77 RID: 126583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EE77")]
		[Address(RVA = "0x18A5EC0", Offset = "0x18A4AC0", VA = "0x1818A5EC0")]
		private void _SendSelectChoiceRequest(string choiceId, Action onComplete)
		{
		}

		// Token: 0x0601EE78 RID: 126584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EE78")]
		[Address(RVA = "0x18A6690", Offset = "0x18A5290", VA = "0x1818A6690")]
		private void _UpdateDataAndRender(bool needFade)
		{
		}

		// Token: 0x0601EE79 RID: 126585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EE79")]
		[Address(RVA = "0x18A5D70", Offset = "0x18A4970", VA = "0x1818A5D70")]
		private void _SelectChoice(string choiceId)
		{
		}

		// Token: 0x0601EE7A RID: 126586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EE7A")]
		[Address(RVA = "0x18A6BB0", Offset = "0x18A57B0", VA = "0x1818A6BB0")]
		public RoguelikeChoiceState()
		{
		}

		// Token: 0x0601EE7C RID: 126588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EE7C")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601EE7D RID: 126589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EE7D")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0601EE7E RID: 126590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EE7E")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x04029756 RID: 169814
		[Token(Token = "0x4029756")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _choiceViewContainer;

		// Token: 0x04029757 RID: 169815
		[Token(Token = "0x4029757")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x04029758 RID: 169816
		[Token(Token = "0x4029758")]
		[FieldOffset(Offset = "0x80")]
		private bool m_hasInited;

		// Token: 0x04029759 RID: 169817
		[Token(Token = "0x4029759")]
		[FieldOffset(Offset = "0x88")]
		private RoguelikeChoiceStateBean m_stateBean;

		// Token: 0x0402975A RID: 169818
		[Token(Token = "0x402975A")]
		[FieldOffset(Offset = "0x90")]
		private RoguelikeDungeonPage m_page;

		// Token: 0x0402975B RID: 169819
		[Token(Token = "0x402975B")]
		[FieldOffset(Offset = "0x98")]
		private RoguelikeDungeonController m_controller;

		// Token: 0x0402975C RID: 169820
		[Token(Token = "0x402975C")]
		[FieldOffset(Offset = "0xA0")]
		private string m_topicId;

		// Token: 0x0402975D RID: 169821
		[Token(Token = "0x402975D")]
		[FieldOffset(Offset = "0xA8")]
		private RoguelikeChoiceView m_choiceView;

		// Token: 0x0402975E RID: 169822
		[Token(Token = "0x402975E")]
		[FieldOffset(Offset = "0xB0")]
		private RoguelikeChoiceState.MenuAdapter m_menuAdapter;

		// Token: 0x0402975F RID: 169823
		[Token(Token = "0x402975F")]
		[FieldOffset(Offset = "0xB8")]
		private RoguelikeChoiceEffectBase m_effectInst;

		// Token: 0x04029760 RID: 169824
		[Token(Token = "0x4029760")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04029761 RID: 169825
		[Token(Token = "0x4029761")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04029762 RID: 169826
		[Token(Token = "0x4029762")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04029763 RID: 169827
		[Token(Token = "0x4029763")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04029764 RID: 169828
		[Token(Token = "0x4029764")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04029765 RID: 169829
		[Token(Token = "0x4029765")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04029766 RID: 169830
		[Token(Token = "0x4029766")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SetEffectVisible;

		// Token: 0x04029767 RID: 169831
		[Token(Token = "0x4029767")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__QuitChoiceScene;

		// Token: 0x04029768 RID: 169832
		[Token(Token = "0x4029768")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__TriggerBGMSignal;

		// Token: 0x04029769 RID: 169833
		[Token(Token = "0x4029769")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ClearBGM;

		// Token: 0x0402976A RID: 169834
		[Token(Token = "0x402976A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ShowRoguelikeMenu;

		// Token: 0x0402976B RID: 169835
		[Token(Token = "0x402976B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__SendSelectChoiceRequest;

		// Token: 0x0402976C RID: 169836
		[Token(Token = "0x402976C")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__UpdateDataAndRender;

		// Token: 0x0402976D RID: 169837
		[Token(Token = "0x402976D")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__SelectChoice;

		// Token: 0x0402976E RID: 169838
		[Token(Token = "0x402976E")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020051BD RID: 20925
		[Token(Token = "0x20051BD")]
		private class MenuAdapter : RoguelikeMenuAdapter
		{
			// Token: 0x17004812 RID: 18450
			// (set) Token: 0x0601EE7F RID: 126591 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004812")]
			public bool showMenu
			{
				[Token(Token = "0x601EE7F")]
				[Address(RVA = "0x189F2E0", Offset = "0x189DEE0", VA = "0x18189F2E0")]
				set
				{
				}
			}

			// Token: 0x17004813 RID: 18451
			// (get) Token: 0x0601EE80 RID: 126592 RVA: 0x000B0148 File Offset: 0x000AE348
			[Token(Token = "0x17004813")]
			public override bool showStatusBar
			{
				[Token(Token = "0x601EE80")]
				[Address(RVA = "0x189F280", Offset = "0x189DE80", VA = "0x18189F280", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17004814 RID: 18452
			// (get) Token: 0x0601EE81 RID: 126593 RVA: 0x000B0160 File Offset: 0x000AE360
			[Token(Token = "0x17004814")]
			public override bool showBottomBar
			{
				[Token(Token = "0x601EE81")]
				[Address(RVA = "0x189F0E0", Offset = "0x189DCE0", VA = "0x18189F0E0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0601EE82 RID: 126594 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601EE82")]
			[Address(RVA = "0x189F000", Offset = "0x189DC00", VA = "0x18189F000")]
			public MenuAdapter()
			{
			}

			// Token: 0x0601EE83 RID: 126595 RVA: 0x000B0178 File Offset: 0x000AE378
			[Token(Token = "0x601EE83")]
			[Address(RVA = "0x189EFF0", Offset = "0x189DBF0", VA = "0x18189EFF0")]
			private bool <>xLuaBaseProxy_get_showStatusBar()
			{
				return default(bool);
			}

			// Token: 0x0601EE84 RID: 126596 RVA: 0x000B0190 File Offset: 0x000AE390
			[Token(Token = "0x601EE84")]
			[Address(RVA = "0x189EFE0", Offset = "0x189DBE0", VA = "0x18189EFE0")]
			private bool <>xLuaBaseProxy_get_showBottomBar()
			{
				return default(bool);
			}

			// Token: 0x0402976F RID: 169839
			[Token(Token = "0x402976F")]
			[FieldOffset(Offset = "0x20")]
			private bool m_showMenu;

			// Token: 0x04029770 RID: 169840
			[Token(Token = "0x4029770")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_set_showMenu;

			// Token: 0x04029771 RID: 169841
			[Token(Token = "0x4029771")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_showStatusBar;

			// Token: 0x04029772 RID: 169842
			[Token(Token = "0x4029772")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_showBottomBar;

			// Token: 0x04029773 RID: 169843
			[Token(Token = "0x4029773")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
