using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.ChooseChar;
using UnityEngine;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005EAB RID: 24235
	[Token(Token = "0x2005EAB")]
	public class ItemRepoSelectCharGridView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060231A2 RID: 143778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60231A2")]
		[Address(RVA = "0x1D9E740", Offset = "0x1D9D340", VA = "0x181D9E740")]
		public void Render(ItemRepoSelectCharGridView.RenderParam renderParam)
		{
		}

		// Token: 0x060231A3 RID: 143779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60231A3")]
		[Address(RVA = "0x1D9ECA0", Offset = "0x1D9D8A0", VA = "0x181D9ECA0")]
		private List<UIRecycleLayoutAdapter.IVirtualView> _GenerateVirtualViews()
		{
			return null;
		}

		// Token: 0x060231A4 RID: 143780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60231A4")]
		[Address(RVA = "0x1D9E980", Offset = "0x1D9D580", VA = "0x181D9E980")]
		private List<UIRecycleLayoutAdapter.IVirtualView> _GenerateDefaultVirtualViews(ItemRepoSelectCharGridView.RenderParam renderParam)
		{
			return null;
		}

		// Token: 0x060231A5 RID: 143781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60231A5")]
		[Address(RVA = "0x1D9ED90", Offset = "0x1D9D990", VA = "0x181D9ED90")]
		private List<UIRecycleLayoutAdapter.IVirtualView> _GenerateWithClassicVirtualViews(ItemRepoSelectCharGridView.RenderParam renderParam)
		{
			return null;
		}

		// Token: 0x060231A6 RID: 143782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60231A6")]
		[Address(RVA = "0x1D9F3B0", Offset = "0x1D9DFB0", VA = "0x181D9F3B0")]
		private void _PackRowViews(ItemRepoSelectCharGridView.PackParams packParams, List<UIRecycleLayoutAdapter.IVirtualView> virtualViews, ref bool hasOwn)
		{
		}

		// Token: 0x060231A7 RID: 143783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60231A7")]
		[Address(RVA = "0x1D9F2B0", Offset = "0x1D9DEB0", VA = "0x181D9F2B0")]
		private void _OnCardClick(string charId)
		{
		}

		// Token: 0x060231A8 RID: 143784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60231A8")]
		[Address(RVA = "0x1D9FBD0", Offset = "0x1D9E7D0", VA = "0x181D9FBD0")]
		public ItemRepoSelectCharGridView()
		{
		}

		// Token: 0x040305FB RID: 198139
		[Token(Token = "0x40305FB")]
		private const int ROW_COUNT = 6;

		// Token: 0x040305FC RID: 198140
		[Token(Token = "0x40305FC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ItemRepoSelectCharRowComp _rowComp;

		// Token: 0x040305FD RID: 198141
		[Token(Token = "0x40305FD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _viewContainer;

		// Token: 0x040305FE RID: 198142
		[Token(Token = "0x40305FE")]
		[FieldOffset(Offset = "0x28")]
		private UIStateFinder m_stateFinder;

		// Token: 0x040305FF RID: 198143
		[Token(Token = "0x40305FF")]
		[FieldOffset(Offset = "0x38")]
		private CommonSingleChooseCharGroupView m_groupView;

		// Token: 0x04030600 RID: 198144
		[Token(Token = "0x4030600")]
		[FieldOffset(Offset = "0x40")]
		private ItemRepoSelectCharGridView.RenderParam m_renderParam;

		// Token: 0x04030601 RID: 198145
		[Token(Token = "0x4030601")]
		[FieldOffset(Offset = "0x58")]
		private ItemRepoSelectCharGridView.GroupViewBuilder m_viewBuilder;

		// Token: 0x04030602 RID: 198146
		[Token(Token = "0x4030602")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04030603 RID: 198147
		[Token(Token = "0x4030603")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GenerateVirtualViews;

		// Token: 0x04030604 RID: 198148
		[Token(Token = "0x4030604")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GenerateDefaultVirtualViews;

		// Token: 0x04030605 RID: 198149
		[Token(Token = "0x4030605")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GenerateWithClassicVirtualViews;

		// Token: 0x04030606 RID: 198150
		[Token(Token = "0x4030606")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__PackRowViews;

		// Token: 0x04030607 RID: 198151
		[Token(Token = "0x4030607")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnCardClick;

		// Token: 0x04030608 RID: 198152
		[Token(Token = "0x4030608")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005EAC RID: 24236
		[Token(Token = "0x2005EAC")]
		public struct RenderParam
		{
			// Token: 0x04030609 RID: 198153
			[Token(Token = "0x4030609")]
			[FieldOffset(Offset = "0x0")]
			public ItemRepoChooseCharViewModel viewModel;

			// Token: 0x0403060A RID: 198154
			[Token(Token = "0x403060A")]
			[FieldOffset(Offset = "0x8")]
			public string titleText;

			// Token: 0x0403060B RID: 198155
			[Token(Token = "0x403060B")]
			[FieldOffset(Offset = "0x10")]
			public bool unclickable;
		}

		// Token: 0x02005EAD RID: 24237
		[Token(Token = "0x2005EAD")]
		private struct PackParams
		{
			// Token: 0x0403060C RID: 198156
			[Token(Token = "0x403060C")]
			[FieldOffset(Offset = "0x0")]
			public IEnumerable<ItemRepoChooseCharViewModel.ChooseCharItem> enumerable;

			// Token: 0x0403060D RID: 198157
			[Token(Token = "0x403060D")]
			[FieldOffset(Offset = "0x8")]
			public bool clickable;

			// Token: 0x0403060E RID: 198158
			[Token(Token = "0x403060E")]
			[FieldOffset(Offset = "0xC")]
			public ItemRepoSelectCharRowComp.OwnTag ownTag;

			// Token: 0x0403060F RID: 198159
			[Token(Token = "0x403060F")]
			[FieldOffset(Offset = "0x10")]
			public ItemRepoSelectCharRowComp.PotentialTag potentialTag;
		}

		// Token: 0x02005EAE RID: 24238
		[Token(Token = "0x2005EAE")]
		private class GroupViewBuilder : CommonSingleChooseCharGroupView.AbstractViewBuilder
		{
			// Token: 0x060231A9 RID: 143785 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60231A9")]
			[Address(RVA = "0x1D8EDC0", Offset = "0x1D8D9C0", VA = "0x181D8EDC0")]
			public void SetHostView(ItemRepoSelectCharGridView host)
			{
			}

			// Token: 0x060231AA RID: 143786 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60231AA")]
			[Address(RVA = "0x1D8EC00", Offset = "0x1D8D800", VA = "0x181D8EC00", Slot = "4")]
			public override string GetTitleText()
			{
				return null;
			}

			// Token: 0x060231AB RID: 143787 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60231AB")]
			[Address(RVA = "0x1D8EC70", Offset = "0x1D8D870", VA = "0x181D8EC70", Slot = "5")]
			public override IList<UIRecycleLayoutAdapter.IVirtualView> GetVirtualViews()
			{
				return null;
			}

			// Token: 0x060231AC RID: 143788 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60231AC")]
			[Address(RVA = "0x1D8EE40", Offset = "0x1D8DA40", VA = "0x181D8EE40")]
			public GroupViewBuilder()
			{
			}

			// Token: 0x04030610 RID: 198160
			[Token(Token = "0x4030610")]
			[FieldOffset(Offset = "0x18")]
			private ItemRepoSelectCharGridView m_host;

			// Token: 0x04030611 RID: 198161
			[Token(Token = "0x4030611")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_SetHostView;

			// Token: 0x04030612 RID: 198162
			[Token(Token = "0x4030612")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetTitleText;

			// Token: 0x04030613 RID: 198163
			[Token(Token = "0x4030613")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetVirtualViews;

			// Token: 0x04030614 RID: 198164
			[Token(Token = "0x4030614")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
