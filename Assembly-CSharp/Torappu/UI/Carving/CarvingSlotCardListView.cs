using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EaseFunctions;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x02006043 RID: 24643
	[Token(Token = "0x2006043")]
	public class CarvingSlotCardListView : UICustomAdapterLayout<KeyValuePair<string, CarvingMainCardViewModel>, CarvingSlotCardViewHolder>
	{
		// Token: 0x17005420 RID: 21536
		// (get) Token: 0x06023A25 RID: 145957 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06023A26 RID: 145958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005420")]
		public TouchHandler touchHandler
		{
			[Token(Token = "0x6023A25")]
			[Address(RVA = "0x1E4ED90", Offset = "0x1E4D990", VA = "0x181E4ED90")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6023A26")]
			[Address(RVA = "0x1E4EDF0", Offset = "0x1E4D9F0", VA = "0x181E4EDF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06023A27 RID: 145959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023A27")]
		[Address(RVA = "0x1E4E9D0", Offset = "0x1E4D5D0", VA = "0x181E4E9D0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06023A28 RID: 145960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023A28")]
		[Address(RVA = "0x1E4E8C0", Offset = "0x1E4D4C0", VA = "0x181E4E8C0")]
		public void Render(CarvingMainViewModel model)
		{
		}

		// Token: 0x06023A29 RID: 145961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023A29")]
		[Address(RVA = "0x1E4ECF0", Offset = "0x1E4D8F0", VA = "0x181E4ECF0")]
		public CarvingSlotCardListView()
		{
		}

		// Token: 0x0403158D RID: 202125
		[Token(Token = "0x403158D")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private CarvingSlotCardViewHolder _slotCardViewPrefab;

		// Token: 0x0403158E RID: 202126
		[Token(Token = "0x403158E")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAnimationLocation _sampleCurve;

		// Token: 0x0403158F RID: 202127
		[Token(Token = "0x403158F")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private float[] _samplePosList;

		// Token: 0x04031590 RID: 202128
		[Token(Token = "0x4031590")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private float _alignDuration;

		// Token: 0x04031591 RID: 202129
		[Token(Token = "0x4031591")]
		[FieldOffset(Offset = "0x9C")]
		[SerializeField]
		private Interpolator.EaseType _alignEase;

		// Token: 0x04031592 RID: 202130
		[Token(Token = "0x4031592")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private float _showDuration;

		// Token: 0x04031593 RID: 202131
		[Token(Token = "0x4031593")]
		[FieldOffset(Offset = "0xA4")]
		[SerializeField]
		private Interpolator.EaseType _showEase;

		// Token: 0x04031594 RID: 202132
		[Token(Token = "0x4031594")]
		[FieldOffset(Offset = "0xA8")]
		private CarvingCardListViewModel m_cachedCardListViewModel;

		// Token: 0x04031595 RID: 202133
		[Token(Token = "0x4031595")]
		[FieldOffset(Offset = "0xB0")]
		private CarvingSlotCardListView.InnerLayouter m_layouter;

		// Token: 0x04031596 RID: 202134
		[Token(Token = "0x4031596")]
		[FieldOffset(Offset = "0xB8")]
		private CarvingSlotCardListView.InnerAdapter m_adapter;

		// Token: 0x04031597 RID: 202135
		[Token(Token = "0x4031597")]
		[FieldOffset(Offset = "0xC0")]
		private string m_cachedProcessCardId;

		// Token: 0x04031598 RID: 202136
		[Token(Token = "0x4031598")]
		[FieldOffset(Offset = "0xC8")]
		private bool m_inited;

		// Token: 0x0403159A RID: 202138
		[Token(Token = "0x403159A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_touchHandler;

		// Token: 0x0403159B RID: 202139
		[Token(Token = "0x403159B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_touchHandler;

		// Token: 0x0403159C RID: 202140
		[Token(Token = "0x403159C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403159D RID: 202141
		[Token(Token = "0x403159D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403159E RID: 202142
		[Token(Token = "0x403159E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006044 RID: 24644
		[Token(Token = "0x2006044")]
		private class InnerAdapter : UICustomAdapterLayout<KeyValuePair<string, CarvingMainCardViewModel>, CarvingSlotCardViewHolder>.Adapter
		{
			// Token: 0x06023A2A RID: 145962 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023A2A")]
			[Address(RVA = "0x1E525D0", Offset = "0x1E511D0", VA = "0x181E525D0")]
			public InnerAdapter(CarvingSlotCardListView closure)
			{
			}

			// Token: 0x06023A2B RID: 145963 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6023A2B")]
			[Address(RVA = "0x1E51B40", Offset = "0x1E50740", VA = "0x181E51B40", Slot = "6")]
			public override CarvingSlotCardViewHolder CreateInst(KeyValuePair<string, CarvingMainCardViewModel> data, RectTransform parent)
			{
				return null;
			}

			// Token: 0x06023A2C RID: 145964 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023A2C")]
			[Address(RVA = "0x1E52170", Offset = "0x1E50D70", VA = "0x181E52170", Slot = "7")]
			public override void UpdateView(CarvingSlotCardViewHolder view, KeyValuePair<string, CarvingMainCardViewModel> data)
			{
			}

			// Token: 0x06023A2D RID: 145965 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6023A2D")]
			[Address(RVA = "0x1E520D0", Offset = "0x1E50CD0", VA = "0x181E520D0", Slot = "5")]
			public override string GetId(KeyValuePair<string, CarvingMainCardViewModel> data)
			{
				return null;
			}

			// Token: 0x06023A2E RID: 145966 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6023A2E")]
			[Address(RVA = "0x1E51FB0", Offset = "0x1E50BB0", VA = "0x181E51FB0", Slot = "4")]
			public override IList<KeyValuePair<string, CarvingMainCardViewModel>> GetData()
			{
				return null;
			}

			// Token: 0x0403159F RID: 202143
			[Token(Token = "0x403159F")]
			[FieldOffset(Offset = "0x20")]
			private CarvingSlotCardListView m_closure;

			// Token: 0x040315A0 RID: 202144
			[Token(Token = "0x40315A0")]
			[FieldOffset(Offset = "0x28")]
			private List<CarvingSlotCardViewHolder> m_views;

			// Token: 0x040315A1 RID: 202145
			[Token(Token = "0x40315A1")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040315A2 RID: 202146
			[Token(Token = "0x40315A2")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_CreateInst;

			// Token: 0x040315A3 RID: 202147
			[Token(Token = "0x40315A3")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_UpdateView;

			// Token: 0x040315A4 RID: 202148
			[Token(Token = "0x40315A4")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetId;

			// Token: 0x040315A5 RID: 202149
			[Token(Token = "0x40315A5")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetData;
		}

		// Token: 0x02006045 RID: 24645
		[Token(Token = "0x2006045")]
		public class InnerLayouter : UICustomAnimDrivenLayouter<KeyValuePair<string, CarvingMainCardViewModel>, CarvingSlotCardViewHolder>
		{
			// Token: 0x06023A2F RID: 145967 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023A2F")]
			[Address(RVA = "0x1E53980", Offset = "0x1E52580", VA = "0x181E53980")]
			public InnerLayouter(CarvingSlotCardListView closure)
			{
			}

			// Token: 0x06023A30 RID: 145968 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6023A30")]
			[Address(RVA = "0x1E526B0", Offset = "0x1E512B0", VA = "0x181E526B0", Slot = "6")]
			protected override Dictionary<string, float> GetElementSamplePosDict()
			{
				return null;
			}

			// Token: 0x06023A31 RID: 145969 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023A31")]
			[Address(RVA = "0x1E52BD0", Offset = "0x1E517D0", VA = "0x181E52BD0", Slot = "7")]
			protected override void TransitionNewlyAddedInternal(UICustomAdapterLayout<KeyValuePair<string, CarvingMainCardViewModel>, CarvingSlotCardViewHolder>.Layouter.LayoutElement ele, UICustomAnimDrivenLayouter<KeyValuePair<string, CarvingMainCardViewModel>, CarvingSlotCardViewHolder>.LayoutMeta meta)
			{
			}

			// Token: 0x06023A32 RID: 145970 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023A32")]
			[Address(RVA = "0x1E53190", Offset = "0x1E51D90", VA = "0x181E53190", Slot = "8")]
			protected override void TransitionRemovedInternal(UICustomAdapterLayout<KeyValuePair<string, CarvingMainCardViewModel>, CarvingSlotCardViewHolder>.Layouter.LayoutElement ele)
			{
			}

			// Token: 0x040315A6 RID: 202150
			[Token(Token = "0x40315A6")]
			[FieldOffset(Offset = "0x68")]
			private CarvingSlotCardListView m_closure;

			// Token: 0x040315A7 RID: 202151
			[Token(Token = "0x40315A7")]
			[FieldOffset(Offset = "0x70")]
			private CarvingCardListViewModel m_cachedCardListViewModel;

			// Token: 0x040315A8 RID: 202152
			[Token(Token = "0x40315A8")]
			[FieldOffset(Offset = "0x78")]
			private Dictionary<string, float> m_samplePosDict;

			// Token: 0x040315A9 RID: 202153
			[Token(Token = "0x40315A9")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040315AA RID: 202154
			[Token(Token = "0x40315AA")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetElementSamplePosDict;

			// Token: 0x040315AB RID: 202155
			[Token(Token = "0x40315AB")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_TransitionNewlyAddedInternal;

			// Token: 0x040315AC RID: 202156
			[Token(Token = "0x40315AC")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_TransitionRemovedInternal;
		}
	}
}
