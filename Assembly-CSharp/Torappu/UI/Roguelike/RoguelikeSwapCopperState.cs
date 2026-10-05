using System;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.Copper;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020051E2 RID: 20962
	[Token(Token = "0x20051E2")]
	public class RoguelikeSwapCopperState : PopupFadeState, IValueMsgReceiver, ICompDialogCallBack
	{
		// Token: 0x0601EF48 RID: 126792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EF48")]
		[Address(RVA = "0x18C19B0", Offset = "0x18C05B0", VA = "0x1818C19B0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601EF49 RID: 126793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EF49")]
		[Address(RVA = "0x18C1AD0", Offset = "0x18C06D0", VA = "0x1818C1AD0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601EF4A RID: 126794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EF4A")]
		[Address(RVA = "0x18C2300", Offset = "0x18C0F00", VA = "0x1818C2300", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601EF4B RID: 126795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EF4B")]
		[Address(RVA = "0x18C2170", Offset = "0x18C0D70", VA = "0x1818C2170", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601EF4C RID: 126796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EF4C")]
		[Address(RVA = "0x18C2B30", Offset = "0x18C1730", VA = "0x1818C2B30")]
		private void _SelectCopper(string copperIndex)
		{
		}

		// Token: 0x0601EF4D RID: 126797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EF4D")]
		[Address(RVA = "0x18C2420", Offset = "0x18C1020", VA = "0x1818C2420")]
		private void _CancelSwapCopper()
		{
		}

		// Token: 0x0601EF4E RID: 126798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EF4E")]
		[Address(RVA = "0x18C2570", Offset = "0x18C1170", VA = "0x1818C2570")]
		private void _ConfirmSwapCopper()
		{
		}

		// Token: 0x0601EF4F RID: 126799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EF4F")]
		[Address(RVA = "0x18C2E30", Offset = "0x18C1A30", VA = "0x1818C2E30")]
		private void _SendConfirmSwapCopperRequest(string index)
		{
		}

		// Token: 0x0601EF50 RID: 126800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EF50")]
		[Address(RVA = "0x18C2C10", Offset = "0x18C1810", VA = "0x1818C2C10")]
		private void _SendCancelSwapCopperRequest()
		{
		}

		// Token: 0x0601EF51 RID: 126801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EF51")]
		[Address(RVA = "0x18C2840", Offset = "0x18C1440", VA = "0x1818C2840")]
		private void _OpenSwapResultDialog()
		{
		}

		// Token: 0x0601EF52 RID: 126802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EF52")]
		[Address(RVA = "0x18C1A10", Offset = "0x18C0610", VA = "0x1818C1A10", Slot = "32")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x0601EF53 RID: 126803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EF53")]
		[Address(RVA = "0x18C3050", Offset = "0x18C1C50", VA = "0x1818C3050")]
		public RoguelikeSwapCopperState()
		{
		}

		// Token: 0x0601EF57 RID: 126807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EF57")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601EF58 RID: 126808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EF58")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x040298B6 RID: 170166
		[Token(Token = "0x40298B6")]
		private const string GUIDE_BOOK_SUB_SIGNAL = "{0}_copper";

		// Token: 0x040298B7 RID: 170167
		[Token(Token = "0x40298B7")]
		public const int SELECT_COPPER = 0;

		// Token: 0x040298B8 RID: 170168
		[Token(Token = "0x40298B8")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _viewContainer;

		// Token: 0x040298B9 RID: 170169
		[Token(Token = "0x40298B9")]
		[FieldOffset(Offset = "0x78")]
		private AbstractRoguelikeSwapCopperView m_view;

		// Token: 0x040298BA RID: 170170
		[Token(Token = "0x40298BA")]
		[FieldOffset(Offset = "0x80")]
		private RoguelikeSwapCopperStateBean m_stateBean;

		// Token: 0x040298BB RID: 170171
		[Token(Token = "0x40298BB")]
		[FieldOffset(Offset = "0x88")]
		private string m_topicId;

		// Token: 0x040298BC RID: 170172
		[Token(Token = "0x40298BC")]
		[FieldOffset(Offset = "0x90")]
		private int m_swapResultDialog;

		// Token: 0x040298BD RID: 170173
		[Token(Token = "0x40298BD")]
		[FieldOffset(Offset = "0x98")]
		private RoguelikeCommonTopMenu m_commonTopMenu;

		// Token: 0x040298BE RID: 170174
		[Token(Token = "0x40298BE")]
		[FieldOffset(Offset = "0xA0")]
		private UIGuidebookTrigger m_guideBookTrigger;

		// Token: 0x040298BF RID: 170175
		[Token(Token = "0x40298BF")]
		[FieldOffset(Offset = "0xA8")]
		private RoguelikeSwapCopperState.MenuAdapter m_menuAdapter;

		// Token: 0x040298C0 RID: 170176
		[Token(Token = "0x40298C0")]
		[FieldOffset(Offset = "0xB0")]
		private RoguelikeMenuButtonPluginBase m_buttonPlugin;

		// Token: 0x040298C1 RID: 170177
		[Token(Token = "0x40298C1")]
		[FieldOffset(Offset = "0xB8")]
		private RoguelikeMenuButtonPluginBase.Input m_menuPluginInput;

		// Token: 0x040298C2 RID: 170178
		[Token(Token = "0x40298C2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040298C3 RID: 170179
		[Token(Token = "0x40298C3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040298C4 RID: 170180
		[Token(Token = "0x40298C4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x040298C5 RID: 170181
		[Token(Token = "0x40298C5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x040298C6 RID: 170182
		[Token(Token = "0x40298C6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SelectCopper;

		// Token: 0x040298C7 RID: 170183
		[Token(Token = "0x40298C7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CancelSwapCopper;

		// Token: 0x040298C8 RID: 170184
		[Token(Token = "0x40298C8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ConfirmSwapCopper;

		// Token: 0x040298C9 RID: 170185
		[Token(Token = "0x40298C9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__SendConfirmSwapCopperRequest;

		// Token: 0x040298CA RID: 170186
		[Token(Token = "0x40298CA")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__SendCancelSwapCopperRequest;

		// Token: 0x040298CB RID: 170187
		[Token(Token = "0x40298CB")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OpenSwapResultDialog;

		// Token: 0x040298CC RID: 170188
		[Token(Token = "0x40298CC")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x040298CD RID: 170189
		[Token(Token = "0x40298CD")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020051E3 RID: 20963
		[Token(Token = "0x20051E3")]
		private class MenuAdapter : RoguelikeMenuAdapter
		{
			// Token: 0x0601EF59 RID: 126809 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601EF59")]
			[Address(RVA = "0x18AEDD0", Offset = "0x18AD9D0", VA = "0x1818AEDD0")]
			public MenuAdapter(RoguelikeSwapCopperState closure)
			{
			}

			// Token: 0x17004848 RID: 18504
			// (get) Token: 0x0601EF5A RID: 126810 RVA: 0x000B0430 File Offset: 0x000AE630
			[Token(Token = "0x17004848")]
			public override bool showStatusBar
			{
				[Token(Token = "0x601EF5A")]
				[Address(RVA = "0x18AF210", Offset = "0x18ADE10", VA = "0x1818AF210", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17004849 RID: 18505
			// (get) Token: 0x0601EF5B RID: 126811 RVA: 0x000B0448 File Offset: 0x000AE648
			[Token(Token = "0x17004849")]
			public override bool showBottomBar
			{
				[Token(Token = "0x601EF5B")]
				[Address(RVA = "0x18AF060", Offset = "0x18ADC60", VA = "0x1818AF060", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700484A RID: 18506
			// (get) Token: 0x0601EF5C RID: 126812 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700484A")]
			public override RoguelikeMenuButtonPluginBase buttonPrefab
			{
				[Token(Token = "0x601EF5C")]
				[Address(RVA = "0x18AEF60", Offset = "0x18ADB60", VA = "0x1818AEF60", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700484B RID: 18507
			// (get) Token: 0x0601EF5D RID: 126813 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700484B")]
			public override RoguelikeMenuButtonPluginBase.Input buttonInput
			{
				[Token(Token = "0x601EF5D")]
				[Address(RVA = "0x18AEEF0", Offset = "0x18ADAF0", VA = "0x1818AEEF0", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x0601EF5E RID: 126814 RVA: 0x000B0460 File Offset: 0x000AE660
			[Token(Token = "0x601EF5E")]
			[Address(RVA = "0x189EFF0", Offset = "0x189DBF0", VA = "0x18189EFF0")]
			private bool <>xLuaBaseProxy_get_showStatusBar()
			{
				return default(bool);
			}

			// Token: 0x0601EF5F RID: 126815 RVA: 0x000B0478 File Offset: 0x000AE678
			[Token(Token = "0x601EF5F")]
			[Address(RVA = "0x189EFE0", Offset = "0x189DBE0", VA = "0x18189EFE0")]
			private bool <>xLuaBaseProxy_get_showBottomBar()
			{
				return default(bool);
			}

			// Token: 0x0601EF60 RID: 126816 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601EF60")]
			[Address(RVA = "0x18AED60", Offset = "0x18AD960", VA = "0x1818AED60")]
			private RoguelikeMenuButtonPluginBase <>xLuaBaseProxy_get_buttonPrefab()
			{
				return null;
			}

			// Token: 0x0601EF61 RID: 126817 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601EF61")]
			[Address(RVA = "0x18AED50", Offset = "0x18AD950", VA = "0x1818AED50")]
			private RoguelikeMenuButtonPluginBase.Input <>xLuaBaseProxy_get_buttonInput()
			{
				return null;
			}

			// Token: 0x040298CE RID: 170190
			[Token(Token = "0x40298CE")]
			[FieldOffset(Offset = "0x20")]
			private RoguelikeSwapCopperState m_closure;

			// Token: 0x040298CF RID: 170191
			[Token(Token = "0x40298CF")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040298D0 RID: 170192
			[Token(Token = "0x40298D0")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_showStatusBar;

			// Token: 0x040298D1 RID: 170193
			[Token(Token = "0x40298D1")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_showBottomBar;

			// Token: 0x040298D2 RID: 170194
			[Token(Token = "0x40298D2")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_buttonPrefab;

			// Token: 0x040298D3 RID: 170195
			[Token(Token = "0x40298D3")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_buttonInput;
		}
	}
}
