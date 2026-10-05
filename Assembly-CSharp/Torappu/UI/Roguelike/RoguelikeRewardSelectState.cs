using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020053CB RID: 21451
	[Token(Token = "0x20053CB")]
	public class RoguelikeRewardSelectState : PopupFloatState
	{
		// Token: 0x0601F912 RID: 129298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F912")]
		[Address(RVA = "0x1941C60", Offset = "0x1940860", VA = "0x181941C60")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601F913 RID: 129299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F913")]
		[Address(RVA = "0x1941600", Offset = "0x1940200", VA = "0x181941600", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601F914 RID: 129300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F914")]
		[Address(RVA = "0x19417B0", Offset = "0x19403B0", VA = "0x1819417B0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601F915 RID: 129301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F915")]
		[Address(RVA = "0x1941660", Offset = "0x1940260", VA = "0x181941660")]
		public void OnClick(int index)
		{
		}

		// Token: 0x0601F916 RID: 129302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F916")]
		[Address(RVA = "0x19419D0", Offset = "0x19405D0", VA = "0x1819419D0")]
		private void _HandleOnReceive(RoguelikeRewardItemViewModel model, int subIndex)
		{
		}

		// Token: 0x0601F917 RID: 129303 RVA: 0x000B2458 File Offset: 0x000B0658
		[Token(Token = "0x601F917")]
		[Address(RVA = "0x19421A0", Offset = "0x1940DA0", VA = "0x1819421A0")]
		private bool _ProcessCapsuleReceive(RoguelikeItemBundle itemBundle)
		{
			return default(bool);
		}

		// Token: 0x0601F918 RID: 129304 RVA: 0x000B2470 File Offset: 0x000B0670
		[Token(Token = "0x601F918")]
		[Address(RVA = "0x1942670", Offset = "0x1941270", VA = "0x181942670")]
		private bool _ProcessChestReceive(RoguelikeDungeonController controller, int subIndex, RoguelikeItemBundle itemBundle)
		{
			return default(bool);
		}

		// Token: 0x0601F919 RID: 129305 RVA: 0x000B2488 File Offset: 0x000B0688
		[Token(Token = "0x601F919")]
		[Address(RVA = "0x19427E0", Offset = "0x19413E0", VA = "0x1819427E0")]
		private bool _ProcessRecruitReceive(RoguelikeDungeonController controller)
		{
			return default(bool);
		}

		// Token: 0x0601F91A RID: 129306 RVA: 0x000B24A0 File Offset: 0x000B06A0
		[Token(Token = "0x601F91A")]
		[Address(RVA = "0x19422A0", Offset = "0x1940EA0", VA = "0x1819422A0")]
		private bool _ProcessChangeCopperReceive(RoguelikeItemBundle itemBundle)
		{
			return default(bool);
		}

		// Token: 0x0601F91B RID: 129307 RVA: 0x000B24B8 File Offset: 0x000B06B8
		[Token(Token = "0x601F91B")]
		[Address(RVA = "0x1941F20", Offset = "0x1940B20", VA = "0x181941F20")]
		private bool _IsReceiveChest(RoguelikeItemBundle itemBundle)
		{
			return default(bool);
		}

		// Token: 0x0601F91C RID: 129308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F91C")]
		[Address(RVA = "0x1942470", Offset = "0x1941070", VA = "0x181942470")]
		private void _ProcessChestEvent(string topicId, int subIndex)
		{
		}

		// Token: 0x0601F91D RID: 129309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F91D")]
		[Address(RVA = "0x19428F0", Offset = "0x19414F0", VA = "0x1819428F0")]
		private void _UseDiceToUnlockChest(string topicId)
		{
		}

		// Token: 0x0601F91E RID: 129310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F91E")]
		[Address(RVA = "0x1942120", Offset = "0x1940D20", VA = "0x181942120")]
		private void _LeaveChestDirectly()
		{
		}

		// Token: 0x0601F91F RID: 129311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F91F")]
		[Address(RVA = "0x19429B0", Offset = "0x19415B0", VA = "0x1819429B0")]
		private void _UseKeyToUnlockChest()
		{
		}

		// Token: 0x0601F920 RID: 129312 RVA: 0x000B24D0 File Offset: 0x000B06D0
		[Token(Token = "0x601F920")]
		[Address(RVA = "0x1941FA0", Offset = "0x1940BA0", VA = "0x181941FA0")]
		private bool _IsReceiveCopper(RoguelikeItemBundle itemBundle)
		{
			return default(bool);
		}

		// Token: 0x0601F921 RID: 129313 RVA: 0x000B24E8 File Offset: 0x000B06E8
		[Token(Token = "0x601F921")]
		[Address(RVA = "0x1941EA0", Offset = "0x1940AA0", VA = "0x181941EA0")]
		private bool _IsReceiveCapsule(RoguelikeItemBundle itemBundle)
		{
			return default(bool);
		}

		// Token: 0x0601F922 RID: 129314 RVA: 0x000B2500 File Offset: 0x000B0700
		[Token(Token = "0x601F922")]
		[Address(RVA = "0x1942020", Offset = "0x1940C20", VA = "0x181942020")]
		private bool _IsReceiveItem(RoguelikeItemBundle itemBundle, RoguelikeGameItemType gameItemType)
		{
			return default(bool);
		}

		// Token: 0x0601F923 RID: 129315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F923")]
		[Address(RVA = "0x1942A40", Offset = "0x1941640", VA = "0x181942A40")]
		public RoguelikeRewardSelectState()
		{
		}

		// Token: 0x0601F925 RID: 129317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F925")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0402A7FF RID: 174079
		[Token(Token = "0x402A7FF")]
		[FieldOffset(Offset = "0x70")]
		private RoguelikeRewardSelectStateBean m_stateBean;

		// Token: 0x0402A800 RID: 174080
		[Token(Token = "0x402A800")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RoguelikeRewardSelectView _view;

		// Token: 0x0402A801 RID: 174081
		[Token(Token = "0x402A801")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _panelTopMenu;

		// Token: 0x0402A802 RID: 174082
		[Token(Token = "0x402A802")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIStyleProvider _styleProvider;

		// Token: 0x0402A803 RID: 174083
		[Token(Token = "0x402A803")]
		[FieldOffset(Offset = "0x90")]
		private RoguelikeCommonTopMenu m_topMenu;

		// Token: 0x0402A804 RID: 174084
		[Token(Token = "0x402A804")]
		[FieldOffset(Offset = "0x98")]
		private RoguelikeRewardSelectState.MenuAdapter m_menuAdapter;

		// Token: 0x0402A805 RID: 174085
		[Token(Token = "0x402A805")]
		[FieldOffset(Offset = "0xA0")]
		private RoguelikeRewardStyle m_style;

		// Token: 0x0402A806 RID: 174086
		[Token(Token = "0x402A806")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_inited;

		// Token: 0x0402A807 RID: 174087
		[Token(Token = "0x402A807")]
		[FieldOffset(Offset = "0xB0")]
		private string m_topicId;

		// Token: 0x0402A808 RID: 174088
		[Token(Token = "0x402A808")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402A809 RID: 174089
		[Token(Token = "0x402A809")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402A80A RID: 174090
		[Token(Token = "0x402A80A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402A80B RID: 174091
		[Token(Token = "0x402A80B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402A80C RID: 174092
		[Token(Token = "0x402A80C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__HandleOnReceive;

		// Token: 0x0402A80D RID: 174093
		[Token(Token = "0x402A80D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ProcessCapsuleReceive;

		// Token: 0x0402A80E RID: 174094
		[Token(Token = "0x402A80E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ProcessChestReceive;

		// Token: 0x0402A80F RID: 174095
		[Token(Token = "0x402A80F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ProcessRecruitReceive;

		// Token: 0x0402A810 RID: 174096
		[Token(Token = "0x402A810")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ProcessChangeCopperReceive;

		// Token: 0x0402A811 RID: 174097
		[Token(Token = "0x402A811")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__IsReceiveChest;

		// Token: 0x0402A812 RID: 174098
		[Token(Token = "0x402A812")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ProcessChestEvent;

		// Token: 0x0402A813 RID: 174099
		[Token(Token = "0x402A813")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__UseDiceToUnlockChest;

		// Token: 0x0402A814 RID: 174100
		[Token(Token = "0x402A814")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__LeaveChestDirectly;

		// Token: 0x0402A815 RID: 174101
		[Token(Token = "0x402A815")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__UseKeyToUnlockChest;

		// Token: 0x0402A816 RID: 174102
		[Token(Token = "0x402A816")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__IsReceiveCopper;

		// Token: 0x0402A817 RID: 174103
		[Token(Token = "0x402A817")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__IsReceiveCapsule;

		// Token: 0x0402A818 RID: 174104
		[Token(Token = "0x402A818")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__IsReceiveItem;

		// Token: 0x0402A819 RID: 174105
		[Token(Token = "0x402A819")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020053CC RID: 21452
		[Token(Token = "0x20053CC")]
		private class MenuAdapter : RoguelikeMenuAdapter
		{
			// Token: 0x170049F1 RID: 18929
			// (get) Token: 0x0601F926 RID: 129318 RVA: 0x000B2518 File Offset: 0x000B0718
			[Token(Token = "0x170049F1")]
			public override bool showStatusBar
			{
				[Token(Token = "0x601F926")]
				[Address(RVA = "0x1937EF0", Offset = "0x1936AF0", VA = "0x181937EF0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170049F2 RID: 18930
			// (get) Token: 0x0601F927 RID: 129319 RVA: 0x000B2530 File Offset: 0x000B0730
			[Token(Token = "0x170049F2")]
			public override bool showBottomBar
			{
				[Token(Token = "0x601F927")]
				[Address(RVA = "0x1937E30", Offset = "0x1936A30", VA = "0x181937E30", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0601F928 RID: 129320 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F928")]
			[Address(RVA = "0x1937D70", Offset = "0x1936970", VA = "0x181937D70")]
			public MenuAdapter()
			{
			}

			// Token: 0x0601F929 RID: 129321 RVA: 0x000B2548 File Offset: 0x000B0748
			[Token(Token = "0x601F929")]
			[Address(RVA = "0x189EFF0", Offset = "0x189DBF0", VA = "0x18189EFF0")]
			private bool <>xLuaBaseProxy_get_showStatusBar()
			{
				return default(bool);
			}

			// Token: 0x0601F92A RID: 129322 RVA: 0x000B2560 File Offset: 0x000B0760
			[Token(Token = "0x601F92A")]
			[Address(RVA = "0x189EFE0", Offset = "0x189DBE0", VA = "0x18189EFE0")]
			private bool <>xLuaBaseProxy_get_showBottomBar()
			{
				return default(bool);
			}

			// Token: 0x0402A81A RID: 174106
			[Token(Token = "0x402A81A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_showStatusBar;

			// Token: 0x0402A81B RID: 174107
			[Token(Token = "0x402A81B")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_showBottomBar;

			// Token: 0x0402A81C RID: 174108
			[Token(Token = "0x402A81C")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
