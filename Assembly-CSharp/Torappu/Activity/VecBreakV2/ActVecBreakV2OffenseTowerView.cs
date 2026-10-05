using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E5A RID: 28250
	[Token(Token = "0x2006E5A")]
	public class ActVecBreakV2OffenseTowerView : UICustomAdapterLayout<VecBreakV2OffenseStageModel, ActVecBreakV2OffenseTowerItemView>, IHotfixable
	{
		// Token: 0x06028346 RID: 164678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028346")]
		[Address(RVA = "0x2382360", Offset = "0x2380F60", VA = "0x182382360")]
		public void Render(VecBreakV2OffenseModel model)
		{
		}

		// Token: 0x06028347 RID: 164679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028347")]
		[Address(RVA = "0x2382690", Offset = "0x2381290", VA = "0x182382690")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06028348 RID: 164680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028348")]
		[Address(RVA = "0x23828E0", Offset = "0x23814E0", VA = "0x1823828E0")]
		private void _PlayTowerTranslateTween(VecBreakV2OffenseModel model)
		{
		}

		// Token: 0x06028349 RID: 164681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028349")]
		[Address(RVA = "0x2382A50", Offset = "0x2381650", VA = "0x182382A50")]
		private void _RenderTowerItems()
		{
		}

		// Token: 0x0602834A RID: 164682 RVA: 0x000D0E18 File Offset: 0x000CF018
		[Token(Token = "0x602834A")]
		[Address(RVA = "0x2382610", Offset = "0x2381210", VA = "0x182382610")]
		private float _GetTowerPosY(int stageIdx)
		{
			return 0f;
		}

		// Token: 0x0602834B RID: 164683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602834B")]
		[Address(RVA = "0x2382B20", Offset = "0x2381720", VA = "0x182382B20")]
		public ActVecBreakV2OffenseTowerView()
		{
		}

		// Token: 0x040391F7 RID: 233975
		[Token(Token = "0x40391F7")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float _moveDuration;

		// Token: 0x040391F8 RID: 233976
		[Token(Token = "0x40391F8")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private Rect _padding;

		// Token: 0x040391F9 RID: 233977
		[Token(Token = "0x40391F9")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private float _spacing;

		// Token: 0x040391FA RID: 233978
		[Token(Token = "0x40391FA")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private ActVecBreakV2OffenseTowerItemView _itemViewPrefab;

		// Token: 0x040391FB RID: 233979
		[Token(Token = "0x40391FB")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private RectTransform _towerTransform;

		// Token: 0x040391FC RID: 233980
		[Token(Token = "0x40391FC")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private float _towerYOffset;

		// Token: 0x040391FD RID: 233981
		[Token(Token = "0x40391FD")]
		[FieldOffset(Offset = "0xA4")]
		[SerializeField]
		private float _towerYBottom;

		// Token: 0x040391FE RID: 233982
		[Token(Token = "0x40391FE")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_inited;

		// Token: 0x040391FF RID: 233983
		[Token(Token = "0x40391FF")]
		[FieldOffset(Offset = "0xAC")]
		private int m_cachedTowerSeqNum;

		// Token: 0x04039200 RID: 233984
		[Token(Token = "0x4039200")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_cachedTowerRebuild;

		// Token: 0x04039201 RID: 233985
		[Token(Token = "0x4039201")]
		[FieldOffset(Offset = "0xB4")]
		private int m_cachedDecoSeqNum;

		// Token: 0x04039202 RID: 233986
		[Token(Token = "0x4039202")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_cachedShowDeco;

		// Token: 0x04039203 RID: 233987
		[Token(Token = "0x4039203")]
		[FieldOffset(Offset = "0xC0")]
		private UICustomAdapterLayout<VecBreakV2OffenseStageModel, ActVecBreakV2OffenseTowerItemView>.Adapter m_adapter;

		// Token: 0x04039204 RID: 233988
		[Token(Token = "0x4039204")]
		[FieldOffset(Offset = "0xC8")]
		private VecBreakV2OffenseModel m_cachedModel;

		// Token: 0x04039205 RID: 233989
		[Token(Token = "0x4039205")]
		[FieldOffset(Offset = "0xD0")]
		private Tween m_translateTween;

		// Token: 0x04039206 RID: 233990
		[Token(Token = "0x4039206")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04039207 RID: 233991
		[Token(Token = "0x4039207")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04039208 RID: 233992
		[Token(Token = "0x4039208")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__PlayTowerTranslateTween;

		// Token: 0x04039209 RID: 233993
		[Token(Token = "0x4039209")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderTowerItems;

		// Token: 0x0403920A RID: 233994
		[Token(Token = "0x403920A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetTowerPosY;

		// Token: 0x0403920B RID: 233995
		[Token(Token = "0x403920B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006E5B RID: 28251
		[Token(Token = "0x2006E5B")]
		private class InnerAdapter : UICustomAdapterLayout<VecBreakV2OffenseStageModel, ActVecBreakV2OffenseTowerItemView>.Adapter
		{
			// Token: 0x0602834C RID: 164684 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602834C")]
			[Address(RVA = "0x2387000", Offset = "0x2385C00", VA = "0x182387000")]
			public InnerAdapter(ActVecBreakV2OffenseTowerView closure)
			{
			}

			// Token: 0x0602834D RID: 164685 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602834D")]
			[Address(RVA = "0x2386DE0", Offset = "0x23859E0", VA = "0x182386DE0", Slot = "4")]
			public override IList<VecBreakV2OffenseStageModel> GetData()
			{
				return null;
			}

			// Token: 0x0602834E RID: 164686 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602834E")]
			[Address(RVA = "0x2386E60", Offset = "0x2385A60", VA = "0x182386E60", Slot = "5")]
			public override string GetId(VecBreakV2OffenseStageModel model)
			{
				return null;
			}

			// Token: 0x0602834F RID: 164687 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602834F")]
			[Address(RVA = "0x2386D00", Offset = "0x2385900", VA = "0x182386D00", Slot = "6")]
			public override ActVecBreakV2OffenseTowerItemView CreateInst(VecBreakV2OffenseStageModel model, RectTransform parent)
			{
				return null;
			}

			// Token: 0x06028350 RID: 164688 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028350")]
			[Address(RVA = "0x2386EE0", Offset = "0x2385AE0", VA = "0x182386EE0", Slot = "7")]
			public override void UpdateView(ActVecBreakV2OffenseTowerItemView view, VecBreakV2OffenseStageModel model)
			{
			}

			// Token: 0x0403920C RID: 233996
			[Token(Token = "0x403920C")]
			[FieldOffset(Offset = "0x20")]
			private ActVecBreakV2OffenseTowerView m_closure;

			// Token: 0x0403920D RID: 233997
			[Token(Token = "0x403920D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403920E RID: 233998
			[Token(Token = "0x403920E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetData;

			// Token: 0x0403920F RID: 233999
			[Token(Token = "0x403920F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetId;

			// Token: 0x04039210 RID: 234000
			[Token(Token = "0x4039210")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_CreateInst;

			// Token: 0x04039211 RID: 234001
			[Token(Token = "0x4039211")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_UpdateView;
		}

		// Token: 0x02006E5C RID: 28252
		[Token(Token = "0x2006E5C")]
		private class InnerLayouter : UICustomSingleOrientationLayouter<VecBreakV2OffenseStageModel, ActVecBreakV2OffenseTowerItemView>
		{
			// Token: 0x06028351 RID: 164689 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028351")]
			[Address(RVA = "0x2387890", Offset = "0x2386490", VA = "0x182387890")]
			public InnerLayouter(ActVecBreakV2OffenseTowerView closure)
			{
			}

			// Token: 0x06028352 RID: 164690 RVA: 0x000D0E30 File Offset: 0x000CF030
			[Token(Token = "0x6028352")]
			[Address(RVA = "0x2387090", Offset = "0x2385C90", VA = "0x182387090", Slot = "6")]
			protected override int DataComparison(VecBreakV2OffenseStageModel lhs, VecBreakV2OffenseStageModel rhs)
			{
				return 0;
			}

			// Token: 0x06028353 RID: 164691 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028353")]
			[Address(RVA = "0x23873A0", Offset = "0x2385FA0", VA = "0x1823873A0", Slot = "7")]
			protected override void LayoutTransitionImpl()
			{
			}

			// Token: 0x06028354 RID: 164692 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028354")]
			[Address(RVA = "0x2387190", Offset = "0x2385D90", VA = "0x182387190", Slot = "8")]
			protected override void LayoutImmediatelyImpl()
			{
			}

			// Token: 0x06028355 RID: 164693 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028355")]
			[Address(RVA = "0x23875F0", Offset = "0x23861F0", VA = "0x1823875F0")]
			private void _TransitionMove(UICustomSingleOrientationLayouter<VecBreakV2OffenseStageModel, ActVecBreakV2OffenseTowerItemView>.LayoutMeta meta, RectTransform rectTrans)
			{
			}

			// Token: 0x04039212 RID: 234002
			[Token(Token = "0x4039212")]
			[FieldOffset(Offset = "0x70")]
			private ActVecBreakV2OffenseTowerView m_closure;

			// Token: 0x04039213 RID: 234003
			[Token(Token = "0x4039213")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04039214 RID: 234004
			[Token(Token = "0x4039214")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_DataComparison;

			// Token: 0x04039215 RID: 234005
			[Token(Token = "0x4039215")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_LayoutTransitionImpl;

			// Token: 0x04039216 RID: 234006
			[Token(Token = "0x4039216")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_LayoutImmediatelyImpl;

			// Token: 0x04039217 RID: 234007
			[Token(Token = "0x4039217")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__TransitionMove;
		}
	}
}
