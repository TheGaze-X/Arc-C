using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200554E RID: 21838
	[Token(Token = "0x200554E")]
	public class RoguelikeTaskCompleteState : PopupFadeState
	{
		// Token: 0x060201D6 RID: 131542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60201D6")]
		[Address(RVA = "0x1A43E80", Offset = "0x1A42A80", VA = "0x181A43E80", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060201D7 RID: 131543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60201D7")]
		[Address(RVA = "0x1A43F60", Offset = "0x1A42B60", VA = "0x181A43F60", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060201D8 RID: 131544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60201D8")]
		[Address(RVA = "0x1A44340", Offset = "0x1A42F40", VA = "0x181A44340")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060201D9 RID: 131545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60201D9")]
		[Address(RVA = "0x1A44630", Offset = "0x1A43230", VA = "0x181A44630")]
		private void _OnGetTaskReward()
		{
		}

		// Token: 0x060201DA RID: 131546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60201DA")]
		[Address(RVA = "0x1A43EE0", Offset = "0x1A42AE0", VA = "0x181A43EE0")]
		public void OnBtnQuit()
		{
		}

		// Token: 0x060201DB RID: 131547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60201DB")]
		[Address(RVA = "0x1A448C0", Offset = "0x1A434C0", VA = "0x181A448C0")]
		public RoguelikeTaskCompleteState()
		{
		}

		// Token: 0x060201DC RID: 131548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60201DC")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0402B620 RID: 177696
		[Token(Token = "0x402B620")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _viewContainer;

		// Token: 0x0402B621 RID: 177697
		[Token(Token = "0x402B621")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _backRt;

		// Token: 0x0402B622 RID: 177698
		[Token(Token = "0x402B622")]
		[FieldOffset(Offset = "0x80")]
		private bool m_hasInited;

		// Token: 0x0402B623 RID: 177699
		[Token(Token = "0x402B623")]
		[FieldOffset(Offset = "0x88")]
		private RoguelikeDungeonPage m_page;

		// Token: 0x0402B624 RID: 177700
		[Token(Token = "0x402B624")]
		[FieldOffset(Offset = "0x90")]
		private string m_topicId;

		// Token: 0x0402B625 RID: 177701
		[Token(Token = "0x402B625")]
		[FieldOffset(Offset = "0x98")]
		private RoguelikeTaskCompleteState.MenuAdapter m_adapter;

		// Token: 0x0402B626 RID: 177702
		[Token(Token = "0x402B626")]
		[FieldOffset(Offset = "0xA0")]
		private RoguelikeTaskCompleteView m_completeView;

		// Token: 0x0402B627 RID: 177703
		[Token(Token = "0x402B627")]
		[FieldOffset(Offset = "0xA8")]
		private RoguelikeTaskCompleteStateBean m_stateBean;

		// Token: 0x0402B628 RID: 177704
		[Token(Token = "0x402B628")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402B629 RID: 177705
		[Token(Token = "0x402B629")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402B62A RID: 177706
		[Token(Token = "0x402B62A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402B62B RID: 177707
		[Token(Token = "0x402B62B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnGetTaskReward;

		// Token: 0x0402B62C RID: 177708
		[Token(Token = "0x402B62C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnBtnQuit;

		// Token: 0x0402B62D RID: 177709
		[Token(Token = "0x402B62D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200554F RID: 21839
		[Token(Token = "0x200554F")]
		private class MenuAdapter : RoguelikeMenuAdapter
		{
			// Token: 0x17004B5D RID: 19293
			// (get) Token: 0x060201DD RID: 131549 RVA: 0x000B4A50 File Offset: 0x000B2C50
			[Token(Token = "0x17004B5D")]
			public override bool showBottomBar
			{
				[Token(Token = "0x60201DD")]
				[Address(RVA = "0x1A311E0", Offset = "0x1A2FDE0", VA = "0x181A311E0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17004B5E RID: 19294
			// (get) Token: 0x060201DE RID: 131550 RVA: 0x000B4A68 File Offset: 0x000B2C68
			[Token(Token = "0x17004B5E")]
			public override bool showStatusBar
			{
				[Token(Token = "0x60201DE")]
				[Address(RVA = "0x1A312A0", Offset = "0x1A2FEA0", VA = "0x181A312A0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x060201DF RID: 131551 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60201DF")]
			[Address(RVA = "0x1A30FA0", Offset = "0x1A2FBA0", VA = "0x181A30FA0")]
			public MenuAdapter()
			{
			}

			// Token: 0x060201E0 RID: 131552 RVA: 0x000B4A80 File Offset: 0x000B2C80
			[Token(Token = "0x60201E0")]
			[Address(RVA = "0x189EFE0", Offset = "0x189DBE0", VA = "0x18189EFE0")]
			private bool <>xLuaBaseProxy_get_showBottomBar()
			{
				return default(bool);
			}

			// Token: 0x060201E1 RID: 131553 RVA: 0x000B4A98 File Offset: 0x000B2C98
			[Token(Token = "0x60201E1")]
			[Address(RVA = "0x189EFF0", Offset = "0x189DBF0", VA = "0x18189EFF0")]
			private bool <>xLuaBaseProxy_get_showStatusBar()
			{
				return default(bool);
			}

			// Token: 0x0402B62E RID: 177710
			[Token(Token = "0x402B62E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_showBottomBar;

			// Token: 0x0402B62F RID: 177711
			[Token(Token = "0x402B62F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_showStatusBar;

			// Token: 0x0402B630 RID: 177712
			[Token(Token = "0x402B630")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
