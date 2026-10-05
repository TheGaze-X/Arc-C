using System;
using System.Collections.Generic;
using EaseFunctions;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004FBE RID: 20414
	[Token(Token = "0x2004FBE")]
	public class EnemyDuelBetSidePlayerListView : UICustomAdapterLayout<EnemyDuelBetPlayerViewModel, EnemyDuelBetPlayerView>
	{
		// Token: 0x0601E526 RID: 124198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E526")]
		[Address(RVA = "0x17F9540", Offset = "0x17F8140", VA = "0x1817F9540")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601E527 RID: 124199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E527")]
		[Address(RVA = "0x17F9410", Offset = "0x17F8010", VA = "0x1817F9410")]
		public void Render(List<EnemyDuelBetPlayerViewModel> playerList, EnemyDuelBetViewModel viewModel, bool isInit)
		{
		}

		// Token: 0x0601E528 RID: 124200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E528")]
		[Address(RVA = "0x17F97C0", Offset = "0x17F83C0", VA = "0x1817F97C0")]
		public EnemyDuelBetSidePlayerListView()
		{
		}

		// Token: 0x04028803 RID: 165891
		[Token(Token = "0x4028803")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private EnemyDuelBetPlayerView _prefabPlayerView;

		// Token: 0x04028804 RID: 165892
		[Token(Token = "0x4028804")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Vector2 _gridSize;

		// Token: 0x04028805 RID: 165893
		[Token(Token = "0x4028805")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Vector2 _spacing;

		// Token: 0x04028806 RID: 165894
		[Token(Token = "0x4028806")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Rect _padding;

		// Token: 0x04028807 RID: 165895
		[Token(Token = "0x4028807")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private float _showDuration;

		// Token: 0x04028808 RID: 165896
		[Token(Token = "0x4028808")]
		[FieldOffset(Offset = "0xA4")]
		[SerializeField]
		private Interpolator.EaseType _showEase;

		// Token: 0x04028809 RID: 165897
		[Token(Token = "0x4028809")]
		[FieldOffset(Offset = "0xA8")]
		private List<EnemyDuelBetPlayerViewModel> m_cachedPlayerList;

		// Token: 0x0402880A RID: 165898
		[Token(Token = "0x402880A")]
		[FieldOffset(Offset = "0xB0")]
		private EnemyDuelBetViewModel m_cachedViewModel;

		// Token: 0x0402880B RID: 165899
		[Token(Token = "0x402880B")]
		[FieldOffset(Offset = "0xB8")]
		private EnemyDuelBetSidePlayerListView.InnerLayouter m_layouter;

		// Token: 0x0402880C RID: 165900
		[Token(Token = "0x402880C")]
		[FieldOffset(Offset = "0xC0")]
		private EnemyDuelBetSidePlayerListView.InnerAdapter m_adapter;

		// Token: 0x0402880D RID: 165901
		[Token(Token = "0x402880D")]
		[FieldOffset(Offset = "0xC8")]
		private bool m_inited;

		// Token: 0x0402880E RID: 165902
		[Token(Token = "0x402880E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402880F RID: 165903
		[Token(Token = "0x402880F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04028810 RID: 165904
		[Token(Token = "0x4028810")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004FBF RID: 20415
		[Token(Token = "0x2004FBF")]
		private class InnerAdapter : UICustomAdapterLayout<EnemyDuelBetPlayerViewModel, EnemyDuelBetPlayerView>.Adapter
		{
			// Token: 0x0601E529 RID: 124201 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E529")]
			[Address(RVA = "0x180B190", Offset = "0x1809D90", VA = "0x18180B190")]
			public InnerAdapter(EnemyDuelBetSidePlayerListView closure)
			{
			}

			// Token: 0x0601E52A RID: 124202 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601E52A")]
			[Address(RVA = "0x180AEC0", Offset = "0x1809AC0", VA = "0x18180AEC0", Slot = "6")]
			public override EnemyDuelBetPlayerView CreateInst(EnemyDuelBetPlayerViewModel data, RectTransform parent)
			{
				return null;
			}

			// Token: 0x0601E52B RID: 124203 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E52B")]
			[Address(RVA = "0x180B0D0", Offset = "0x1809CD0", VA = "0x18180B0D0", Slot = "7")]
			public override void UpdateView(EnemyDuelBetPlayerView view, EnemyDuelBetPlayerViewModel data)
			{
			}

			// Token: 0x0601E52C RID: 124204 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601E52C")]
			[Address(RVA = "0x180B050", Offset = "0x1809C50", VA = "0x18180B050", Slot = "5")]
			public override string GetId(EnemyDuelBetPlayerViewModel data)
			{
				return null;
			}

			// Token: 0x0601E52D RID: 124205 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601E52D")]
			[Address(RVA = "0x180AFA0", Offset = "0x1809BA0", VA = "0x18180AFA0", Slot = "4")]
			public override IList<EnemyDuelBetPlayerViewModel> GetData()
			{
				return null;
			}

			// Token: 0x04028811 RID: 165905
			[Token(Token = "0x4028811")]
			[FieldOffset(Offset = "0x20")]
			private EnemyDuelBetSidePlayerListView m_closure;

			// Token: 0x04028812 RID: 165906
			[Token(Token = "0x4028812")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04028813 RID: 165907
			[Token(Token = "0x4028813")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_CreateInst;

			// Token: 0x04028814 RID: 165908
			[Token(Token = "0x4028814")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_UpdateView;

			// Token: 0x04028815 RID: 165909
			[Token(Token = "0x4028815")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetId;

			// Token: 0x04028816 RID: 165910
			[Token(Token = "0x4028816")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetData;
		}

		// Token: 0x02004FC0 RID: 20416
		[Token(Token = "0x2004FC0")]
		private class InnerLayouter : UICustomGridLayouter<EnemyDuelBetPlayerViewModel, EnemyDuelBetPlayerView>
		{
			// Token: 0x0601E52E RID: 124206 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E52E")]
			[Address(RVA = "0x180BFA0", Offset = "0x180ABA0", VA = "0x18180BFA0")]
			public InnerLayouter(EnemyDuelBetSidePlayerListView closure)
			{
			}

			// Token: 0x0601E52F RID: 124207 RVA: 0x000AE2D0 File Offset: 0x000AC4D0
			[Token(Token = "0x601E52F")]
			[Address(RVA = "0x180B220", Offset = "0x1809E20", VA = "0x18180B220", Slot = "6")]
			protected override GridPosition DataToOffset(EnemyDuelBetPlayerViewModel data)
			{
				return default(GridPosition);
			}

			// Token: 0x0601E530 RID: 124208 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E530")]
			[Address(RVA = "0x180B9C0", Offset = "0x180A5C0", VA = "0x18180B9C0")]
			private void _TransitionNewlyAdded(UICustomAdapterLayout<EnemyDuelBetPlayerViewModel, EnemyDuelBetPlayerView>.Layouter.LayoutElement ele, UICustomGridLayouter<EnemyDuelBetPlayerViewModel, EnemyDuelBetPlayerView>.LayoutMeta meta)
			{
			}

			// Token: 0x0601E531 RID: 124209 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E531")]
			[Address(RVA = "0x180BD00", Offset = "0x180A900", VA = "0x18180BD00")]
			private void _TransitionRemoved(UICustomAdapterLayout<EnemyDuelBetPlayerViewModel, EnemyDuelBetPlayerView>.Layouter.LayoutElement ele)
			{
			}

			// Token: 0x0601E532 RID: 124210 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E532")]
			[Address(RVA = "0x180B680", Offset = "0x180A280", VA = "0x18180B680")]
			private void _TransitionMove(UICustomAdapterLayout<EnemyDuelBetPlayerViewModel, EnemyDuelBetPlayerView>.Layouter.LayoutElement ele, UICustomGridLayouter<EnemyDuelBetPlayerViewModel, EnemyDuelBetPlayerView>.LayoutMeta meta)
			{
			}

			// Token: 0x0601E533 RID: 124211 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E533")]
			[Address(RVA = "0x180B460", Offset = "0x180A060", VA = "0x18180B460", Slot = "7")]
			protected override void LayoutTransitionImpl()
			{
			}

			// Token: 0x0601E534 RID: 124212 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E534")]
			[Address(RVA = "0x180B2B0", Offset = "0x1809EB0", VA = "0x18180B2B0", Slot = "8")]
			protected override void LayoutImmediatelyImpl()
			{
			}

			// Token: 0x04028817 RID: 165911
			[Token(Token = "0x4028817")]
			[FieldOffset(Offset = "0x70")]
			private EnemyDuelBetSidePlayerListView m_closure;

			// Token: 0x04028818 RID: 165912
			[Token(Token = "0x4028818")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04028819 RID: 165913
			[Token(Token = "0x4028819")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_DataToOffset;

			// Token: 0x0402881A RID: 165914
			[Token(Token = "0x402881A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0__TransitionNewlyAdded;

			// Token: 0x0402881B RID: 165915
			[Token(Token = "0x402881B")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__TransitionRemoved;

			// Token: 0x0402881C RID: 165916
			[Token(Token = "0x402881C")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__TransitionMove;

			// Token: 0x0402881D RID: 165917
			[Token(Token = "0x402881D")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_LayoutTransitionImpl;

			// Token: 0x0402881E RID: 165918
			[Token(Token = "0x402881E")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_LayoutImmediatelyImpl;
		}
	}
}
