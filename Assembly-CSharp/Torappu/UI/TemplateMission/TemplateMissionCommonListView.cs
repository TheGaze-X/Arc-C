using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.TemplateMission
{
	// Token: 0x02003D96 RID: 15766
	[Token(Token = "0x2003D96")]
	public class TemplateMissionCommonListView : TemplateMissionListView
	{
		// Token: 0x0601885F RID: 100447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601885F")]
		[Address(RVA = "0x110E8D0", Offset = "0x110D4D0", VA = "0x18110E8D0", Slot = "8")]
		public override void Init(AbstractTemplateMissionViewController ctrl_, TemplateMissionCustomResHolder customResHolder_)
		{
		}

		// Token: 0x06018860 RID: 100448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018860")]
		[Address(RVA = "0x110E720", Offset = "0x110D320", VA = "0x18110E720", Slot = "10")]
		public override void BindPrefabToListView(AbstractTemplateMissionItemClaimAllView claimAllViewPrefab, AbstractTemplateMissionItemNormalView itemNormalViewPrefab, AbstractTemplateMissionRewardItemView rewardItemViewPrefab)
		{
		}

		// Token: 0x06018861 RID: 100449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018861")]
		[Address(RVA = "0x110EAD0", Offset = "0x110D6D0", VA = "0x18110EAD0", Slot = "9")]
		protected override void RenderView()
		{
		}

		// Token: 0x06018862 RID: 100450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018862")]
		[Address(RVA = "0x110EBE0", Offset = "0x110D7E0", VA = "0x18110EBE0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018863 RID: 100451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018863")]
		[Address(RVA = "0x110ED50", Offset = "0x110D950", VA = "0x18110ED50")]
		public TemplateMissionCommonListView()
		{
		}

		// Token: 0x06018864 RID: 100452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018864")]
		[Address(RVA = "0x1109AC0", Offset = "0x11086C0", VA = "0x181109AC0")]
		private void <>xLuaBaseProxy_Init(AbstractTemplateMissionViewController P0, TemplateMissionCustomResHolder P1)
		{
		}

		// Token: 0x0401E10A RID: 123146
		[Token(Token = "0x401E10A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIRecycleVerticalLayoutGroup _recycleList;

		// Token: 0x0401E10B RID: 123147
		[Token(Token = "0x401E10B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private TemplateMissionCommonEntryFadeTween _entryFadeTween;

		// Token: 0x0401E10C RID: 123148
		[Token(Token = "0x401E10C")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isInited;

		// Token: 0x0401E10D RID: 123149
		[Token(Token = "0x401E10D")]
		[FieldOffset(Offset = "0x58")]
		private TemplateMissionCommonListView.TemplateMissionCommonListAdapter m_adapter;

		// Token: 0x0401E10E RID: 123150
		[Token(Token = "0x401E10E")]
		[FieldOffset(Offset = "0x60")]
		private TemplateMissionCommonItemClaimAllView m_claimAllViewPrefab;

		// Token: 0x0401E10F RID: 123151
		[Token(Token = "0x401E10F")]
		[FieldOffset(Offset = "0x68")]
		private TemplateMissionCommonItemNormalView m_itemNormalViewPrefab;

		// Token: 0x0401E110 RID: 123152
		[Token(Token = "0x401E110")]
		[FieldOffset(Offset = "0x70")]
		private AbstractTemplateMissionRewardItemView m_rewardItemViewPrefab;

		// Token: 0x0401E111 RID: 123153
		[Token(Token = "0x401E111")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0401E112 RID: 123154
		[Token(Token = "0x401E112")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_BindPrefabToListView;

		// Token: 0x0401E113 RID: 123155
		[Token(Token = "0x401E113")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x0401E114 RID: 123156
		[Token(Token = "0x401E114")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401E115 RID: 123157
		[Token(Token = "0x401E115")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003D97 RID: 15767
		[Token(Token = "0x2003D97")]
		private class TemplateMissionCommonListAdapter : UIRecycleLayoutAdapter
		{
			// Token: 0x06018865 RID: 100453 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018865")]
			[Address(RVA = "0x110E650", Offset = "0x110D250", VA = "0x18110E650")]
			public TemplateMissionCommonListAdapter(TemplateMissionCommonListView closure)
			{
			}

			// Token: 0x06018866 RID: 100454 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6018866")]
			[Address(RVA = "0x110E0D0", Offset = "0x110CCD0", VA = "0x18110E0D0", Slot = "4")]
			public override IList<UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild()
			{
				return null;
			}

			// Token: 0x06018867 RID: 100455 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018867")]
			[Address(RVA = "0x110E200", Offset = "0x110CE00", VA = "0x18110E200")]
			public void RebuildList(TemplateMissionViewModel viewModel)
			{
			}

			// Token: 0x0401E116 RID: 123158
			[Token(Token = "0x401E116")]
			[FieldOffset(Offset = "0x18")]
			private TemplateMissionCommonListView m_closure;

			// Token: 0x0401E117 RID: 123159
			[Token(Token = "0x401E117")]
			[FieldOffset(Offset = "0x20")]
			private List<UIRecycleLayoutAdapter.IVirtualView> m_views;

			// Token: 0x0401E118 RID: 123160
			[Token(Token = "0x401E118")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401E119 RID: 123161
			[Token(Token = "0x401E119")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateViewsForRebuild;

			// Token: 0x0401E11A RID: 123162
			[Token(Token = "0x401E11A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RebuildList;
		}
	}
}
