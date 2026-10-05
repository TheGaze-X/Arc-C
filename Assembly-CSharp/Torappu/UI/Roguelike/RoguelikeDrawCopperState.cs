using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020051DB RID: 20955
	[Token(Token = "0x20051DB")]
	public class RoguelikeDrawCopperState : PopupFadeState
	{
		// Token: 0x0601EF30 RID: 126768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EF30")]
		[Address(RVA = "0x18B5520", Offset = "0x18B4120", VA = "0x1818B5520", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601EF31 RID: 126769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EF31")]
		[Address(RVA = "0x18B5580", Offset = "0x18B4180", VA = "0x1818B5580", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601EF32 RID: 126770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EF32")]
		[Address(RVA = "0x18B58C0", Offset = "0x18B44C0", VA = "0x1818B58C0")]
		private void _ConfirmDrawPending()
		{
		}

		// Token: 0x0601EF33 RID: 126771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EF33")]
		[Address(RVA = "0x18B5AD0", Offset = "0x18B46D0", VA = "0x1818B5AD0")]
		public RoguelikeDrawCopperState()
		{
		}

		// Token: 0x0601EF35 RID: 126773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EF35")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0402988C RID: 170124
		[Token(Token = "0x402988C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _drawViewContent;

		// Token: 0x0402988D RID: 170125
		[Token(Token = "0x402988D")]
		[FieldOffset(Offset = "0x78")]
		private RoguelikeDrawCopperStateBean m_stateBean;

		// Token: 0x0402988E RID: 170126
		[Token(Token = "0x402988E")]
		[FieldOffset(Offset = "0x80")]
		private AbstractRoguelikeDrawCopperView m_drawCopperView;

		// Token: 0x0402988F RID: 170127
		[Token(Token = "0x402988F")]
		[FieldOffset(Offset = "0x88")]
		private RoguelikeDrawCopperState.MenuAdapter m_menuAdapter;

		// Token: 0x04029890 RID: 170128
		[Token(Token = "0x4029890")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04029891 RID: 170129
		[Token(Token = "0x4029891")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04029892 RID: 170130
		[Token(Token = "0x4029892")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ConfirmDrawPending;

		// Token: 0x04029893 RID: 170131
		[Token(Token = "0x4029893")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020051DC RID: 20956
		[Token(Token = "0x20051DC")]
		private class MenuAdapter : RoguelikeMenuAdapter
		{
			// Token: 0x17004845 RID: 18501
			// (get) Token: 0x0601EF36 RID: 126774 RVA: 0x000B03B8 File Offset: 0x000AE5B8
			[Token(Token = "0x17004845")]
			public override bool showStatusBar
			{
				[Token(Token = "0x601EF36")]
				[Address(RVA = "0x18AF1B0", Offset = "0x18ADDB0", VA = "0x1818AF1B0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17004846 RID: 18502
			// (get) Token: 0x0601EF37 RID: 126775 RVA: 0x000B03D0 File Offset: 0x000AE5D0
			[Token(Token = "0x17004846")]
			public override bool showBottomBar
			{
				[Token(Token = "0x601EF37")]
				[Address(RVA = "0x18AF0C0", Offset = "0x18ADCC0", VA = "0x1818AF0C0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0601EF38 RID: 126776 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601EF38")]
			[Address(RVA = "0x18AED70", Offset = "0x18AD970", VA = "0x1818AED70")]
			public MenuAdapter()
			{
			}

			// Token: 0x0601EF39 RID: 126777 RVA: 0x000B03E8 File Offset: 0x000AE5E8
			[Token(Token = "0x601EF39")]
			[Address(RVA = "0x189EFF0", Offset = "0x189DBF0", VA = "0x18189EFF0")]
			private bool <>xLuaBaseProxy_get_showStatusBar()
			{
				return default(bool);
			}

			// Token: 0x0601EF3A RID: 126778 RVA: 0x000B0400 File Offset: 0x000AE600
			[Token(Token = "0x601EF3A")]
			[Address(RVA = "0x189EFE0", Offset = "0x189DBE0", VA = "0x18189EFE0")]
			private bool <>xLuaBaseProxy_get_showBottomBar()
			{
				return default(bool);
			}

			// Token: 0x04029894 RID: 170132
			[Token(Token = "0x4029894")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_showStatusBar;

			// Token: 0x04029895 RID: 170133
			[Token(Token = "0x4029895")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_showBottomBar;

			// Token: 0x04029896 RID: 170134
			[Token(Token = "0x4029896")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
