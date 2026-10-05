using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200519C RID: 20892
	[Token(Token = "0x200519C")]
	public class RoguelikeAlchemyState : PopupFadeState, IValueMsgReceiver
	{
		// Token: 0x170047EB RID: 18411
		// (get) Token: 0x0601EDCD RID: 126413 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601EDCE RID: 126414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170047EB")]
		public RoguelikeRewardStyle rewardStyle
		{
			[Token(Token = "0x601EDCD")]
			[Address(RVA = "0x189FE20", Offset = "0x189EA20", VA = "0x18189FE20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601EDCE")]
			[Address(RVA = "0x189FE80", Offset = "0x189EA80", VA = "0x18189FE80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601EDCF RID: 126415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EDCF")]
		[Address(RVA = "0x189F350", Offset = "0x189DF50", VA = "0x18189F350", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601EDD0 RID: 126416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EDD0")]
		[Address(RVA = "0x189F3B0", Offset = "0x189DFB0", VA = "0x18189F3B0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601EDD1 RID: 126417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EDD1")]
		[Address(RVA = "0x189FA00", Offset = "0x189E600", VA = "0x18189FA00", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601EDD2 RID: 126418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EDD2")]
		[Address(RVA = "0x189F8D0", Offset = "0x189E4D0", VA = "0x18189F8D0", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601EDD3 RID: 126419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EDD3")]
		[Address(RVA = "0x189FAE0", Offset = "0x189E6E0", VA = "0x18189FAE0")]
		public void ReloadDungeon()
		{
		}

		// Token: 0x0601EDD4 RID: 126420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EDD4")]
		[Address(RVA = "0x189FC50", Offset = "0x189E850", VA = "0x18189FC50")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601EDD5 RID: 126421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EDD5")]
		[Address(RVA = "0x189FDC0", Offset = "0x189E9C0", VA = "0x18189FDC0")]
		public RoguelikeAlchemyState()
		{
		}

		// Token: 0x0601EDD6 RID: 126422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EDD6")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601EDD7 RID: 126423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EDD7")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x04029676 RID: 169590
		[Token(Token = "0x4029676")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _viewContainer;

		// Token: 0x04029677 RID: 169591
		[Token(Token = "0x4029677")]
		[FieldOffset(Offset = "0x78")]
		private bool m_hasInited;

		// Token: 0x04029678 RID: 169592
		[Token(Token = "0x4029678")]
		[FieldOffset(Offset = "0x80")]
		private RoguelikeDungeonPage m_page;

		// Token: 0x04029679 RID: 169593
		[Token(Token = "0x4029679")]
		[FieldOffset(Offset = "0x88")]
		private string m_topicId;

		// Token: 0x0402967A RID: 169594
		[Token(Token = "0x402967A")]
		[FieldOffset(Offset = "0x90")]
		private AbstractRoguelikeAlchemyController m_alchemyController;

		// Token: 0x0402967B RID: 169595
		[Token(Token = "0x402967B")]
		[FieldOffset(Offset = "0x98")]
		private IRoguelikeAlchemyViewModel m_alchemyViewModel;

		// Token: 0x0402967C RID: 169596
		[Token(Token = "0x402967C")]
		[FieldOffset(Offset = "0xA0")]
		private RoguelikeAlchemyState.MenuAdapter m_menuAdapter;

		// Token: 0x0402967E RID: 169598
		[Token(Token = "0x402967E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_rewardStyle;

		// Token: 0x0402967F RID: 169599
		[Token(Token = "0x402967F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_rewardStyle;

		// Token: 0x04029680 RID: 169600
		[Token(Token = "0x4029680")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04029681 RID: 169601
		[Token(Token = "0x4029681")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04029682 RID: 169602
		[Token(Token = "0x4029682")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04029683 RID: 169603
		[Token(Token = "0x4029683")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04029684 RID: 169604
		[Token(Token = "0x4029684")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ReloadDungeon;

		// Token: 0x04029685 RID: 169605
		[Token(Token = "0x4029685")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04029686 RID: 169606
		[Token(Token = "0x4029686")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200519D RID: 20893
		[Token(Token = "0x200519D")]
		private class MenuAdapter : RoguelikeMenuAdapter
		{
			// Token: 0x0601EDD8 RID: 126424 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601EDD8")]
			[Address(RVA = "0x189F060", Offset = "0x189DC60", VA = "0x18189F060")]
			public MenuAdapter(RoguelikeAlchemyState closure)
			{
			}

			// Token: 0x170047EC RID: 18412
			// (get) Token: 0x0601EDD9 RID: 126425 RVA: 0x000AFF80 File Offset: 0x000AE180
			[Token(Token = "0x170047EC")]
			public override bool showStatusBar
			{
				[Token(Token = "0x601EDD9")]
				[Address(RVA = "0x189F1E0", Offset = "0x189DDE0", VA = "0x18189F1E0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170047ED RID: 18413
			// (get) Token: 0x0601EDDA RID: 126426 RVA: 0x000AFF98 File Offset: 0x000AE198
			[Token(Token = "0x170047ED")]
			public override bool showBottomBar
			{
				[Token(Token = "0x601EDDA")]
				[Address(RVA = "0x189F140", Offset = "0x189DD40", VA = "0x18189F140", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0601EDDB RID: 126427 RVA: 0x000AFFB0 File Offset: 0x000AE1B0
			[Token(Token = "0x601EDDB")]
			[Address(RVA = "0x189EFF0", Offset = "0x189DBF0", VA = "0x18189EFF0")]
			private bool <>xLuaBaseProxy_get_showStatusBar()
			{
				return default(bool);
			}

			// Token: 0x0601EDDC RID: 126428 RVA: 0x000AFFC8 File Offset: 0x000AE1C8
			[Token(Token = "0x601EDDC")]
			[Address(RVA = "0x189EFE0", Offset = "0x189DBE0", VA = "0x18189EFE0")]
			private bool <>xLuaBaseProxy_get_showBottomBar()
			{
				return default(bool);
			}

			// Token: 0x04029687 RID: 169607
			[Token(Token = "0x4029687")]
			[FieldOffset(Offset = "0x20")]
			private RoguelikeAlchemyState m_closure;

			// Token: 0x04029688 RID: 169608
			[Token(Token = "0x4029688")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04029689 RID: 169609
			[Token(Token = "0x4029689")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_showStatusBar;

			// Token: 0x0402968A RID: 169610
			[Token(Token = "0x402968A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_showBottomBar;
		}
	}
}
