using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EaseFunctions;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x02006054 RID: 24660
	[Token(Token = "0x2006054")]
	public class CarvingCardListView : UICustomAdapterLayout<KeyValuePair<string, CarvingMainCardViewModel>, CarvingCardViewHolder>
	{
		// Token: 0x1700542B RID: 21547
		// (get) Token: 0x06023A87 RID: 146055 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06023A88 RID: 146056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700542B")]
		public TouchHandler touchHandler
		{
			[Token(Token = "0x6023A87")]
			[Address(RVA = "0x1E423D0", Offset = "0x1E40FD0", VA = "0x181E423D0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6023A88")]
			[Address(RVA = "0x1E42430", Offset = "0x1E41030", VA = "0x181E42430")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06023A89 RID: 146057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023A89")]
		[Address(RVA = "0x1E42000", Offset = "0x1E40C00", VA = "0x181E42000")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06023A8A RID: 146058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023A8A")]
		[Address(RVA = "0x1E41EE0", Offset = "0x1E40AE0", VA = "0x181E41EE0")]
		public void Render(CarvingMainViewModel carvingMainViewModel)
		{
		}

		// Token: 0x06023A8B RID: 146059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023A8B")]
		[Address(RVA = "0x1E42320", Offset = "0x1E40F20", VA = "0x181E42320")]
		public CarvingCardListView()
		{
		}

		// Token: 0x0403164E RID: 202318
		[Token(Token = "0x403164E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private CarvingCardViewHolder _viewHolderPrefab;

		// Token: 0x0403164F RID: 202319
		[Token(Token = "0x403164F")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private float _fullCardCnt;

		// Token: 0x04031650 RID: 202320
		[Token(Token = "0x4031650")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private float _scaleNotSelected;

		// Token: 0x04031651 RID: 202321
		[Token(Token = "0x4031651")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIAnimationLocation _sampleCurve;

		// Token: 0x04031652 RID: 202322
		[Token(Token = "0x4031652")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private float _alignDuration;

		// Token: 0x04031653 RID: 202323
		[Token(Token = "0x4031653")]
		[FieldOffset(Offset = "0x9C")]
		[SerializeField]
		private Interpolator.EaseType _alignEase;

		// Token: 0x04031654 RID: 202324
		[Token(Token = "0x4031654")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private float _showDuration;

		// Token: 0x04031655 RID: 202325
		[Token(Token = "0x4031655")]
		[FieldOffset(Offset = "0xA4")]
		[SerializeField]
		private Interpolator.EaseType _showEase;

		// Token: 0x04031656 RID: 202326
		[Token(Token = "0x4031656")]
		[FieldOffset(Offset = "0xA8")]
		private CarvingMainViewModel m_cachedCarvingViewModel;

		// Token: 0x04031657 RID: 202327
		[Token(Token = "0x4031657")]
		[FieldOffset(Offset = "0xB0")]
		private CarvingCardListViewModel m_cachedCardListViewModel;

		// Token: 0x04031658 RID: 202328
		[Token(Token = "0x4031658")]
		[FieldOffset(Offset = "0xB8")]
		private CarvingCardListView.InnerLayouter m_layouter;

		// Token: 0x04031659 RID: 202329
		[Token(Token = "0x4031659")]
		[FieldOffset(Offset = "0xC0")]
		private CarvingCardListView.InnerAdapter m_adapter;

		// Token: 0x0403165A RID: 202330
		[Token(Token = "0x403165A")]
		[FieldOffset(Offset = "0xC8")]
		private string m_cachedProcessCardId;

		// Token: 0x0403165B RID: 202331
		[Token(Token = "0x403165B")]
		[FieldOffset(Offset = "0xD0")]
		private bool m_inited;

		// Token: 0x0403165D RID: 202333
		[Token(Token = "0x403165D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_touchHandler;

		// Token: 0x0403165E RID: 202334
		[Token(Token = "0x403165E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_touchHandler;

		// Token: 0x0403165F RID: 202335
		[Token(Token = "0x403165F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04031660 RID: 202336
		[Token(Token = "0x4031660")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04031661 RID: 202337
		[Token(Token = "0x4031661")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006055 RID: 24661
		[Token(Token = "0x2006055")]
		private class InnerAdapter : UICustomAdapterLayout<KeyValuePair<string, CarvingMainCardViewModel>, CarvingCardViewHolder>.Adapter
		{
			// Token: 0x06023A8C RID: 146060 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023A8C")]
			[Address(RVA = "0x1E524F0", Offset = "0x1E510F0", VA = "0x181E524F0")]
			public InnerAdapter(CarvingCardListView closure)
			{
			}

			// Token: 0x06023A8D RID: 146061 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6023A8D")]
			[Address(RVA = "0x1E517B0", Offset = "0x1E503B0", VA = "0x181E517B0", Slot = "6")]
			public override CarvingCardViewHolder CreateInst(KeyValuePair<string, CarvingMainCardViewModel> data, RectTransform parent)
			{
				return null;
			}

			// Token: 0x06023A8E RID: 146062 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023A8E")]
			[Address(RVA = "0x1E52340", Offset = "0x1E50F40", VA = "0x181E52340", Slot = "7")]
			public override void UpdateView(CarvingCardViewHolder view, KeyValuePair<string, CarvingMainCardViewModel> data)
			{
			}

			// Token: 0x06023A8F RID: 146063 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6023A8F")]
			[Address(RVA = "0x1E52030", Offset = "0x1E50C30", VA = "0x181E52030", Slot = "5")]
			public override string GetId(KeyValuePair<string, CarvingMainCardViewModel> data)
			{
				return null;
			}

			// Token: 0x06023A90 RID: 146064 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6023A90")]
			[Address(RVA = "0x1E51F30", Offset = "0x1E50B30", VA = "0x181E51F30", Slot = "4")]
			public override IList<KeyValuePair<string, CarvingMainCardViewModel>> GetData()
			{
				return null;
			}

			// Token: 0x04031662 RID: 202338
			[Token(Token = "0x4031662")]
			[FieldOffset(Offset = "0x20")]
			private CarvingCardListView m_closure;

			// Token: 0x04031663 RID: 202339
			[Token(Token = "0x4031663")]
			[FieldOffset(Offset = "0x28")]
			private List<CarvingCardViewHolder> m_views;

			// Token: 0x04031664 RID: 202340
			[Token(Token = "0x4031664")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04031665 RID: 202341
			[Token(Token = "0x4031665")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_CreateInst;

			// Token: 0x04031666 RID: 202342
			[Token(Token = "0x4031666")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_UpdateView;

			// Token: 0x04031667 RID: 202343
			[Token(Token = "0x4031667")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetId;

			// Token: 0x04031668 RID: 202344
			[Token(Token = "0x4031668")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetData;
		}

		// Token: 0x02006056 RID: 24662
		[Token(Token = "0x2006056")]
		public class InnerLayouter : UICustomAnimDrivenLayouter<KeyValuePair<string, CarvingMainCardViewModel>, CarvingCardViewHolder>
		{
			// Token: 0x06023A91 RID: 146065 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023A91")]
			[Address(RVA = "0x1E538A0", Offset = "0x1E524A0", VA = "0x181E538A0")]
			public InnerLayouter(CarvingCardListView closure)
			{
			}

			// Token: 0x06023A92 RID: 146066 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6023A92")]
			[Address(RVA = "0x1E52890", Offset = "0x1E51490", VA = "0x181E52890", Slot = "6")]
			protected override Dictionary<string, float> GetElementSamplePosDict()
			{
				return null;
			}

			// Token: 0x06023A93 RID: 146067 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023A93")]
			[Address(RVA = "0x1E52920", Offset = "0x1E51520", VA = "0x181E52920", Slot = "7")]
			protected override void TransitionNewlyAddedInternal(UICustomAdapterLayout<KeyValuePair<string, CarvingMainCardViewModel>, CarvingCardViewHolder>.Layouter.LayoutElement ele, UICustomAnimDrivenLayouter<KeyValuePair<string, CarvingMainCardViewModel>, CarvingCardViewHolder>.LayoutMeta meta)
			{
			}

			// Token: 0x06023A94 RID: 146068 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023A94")]
			[Address(RVA = "0x1E52E70", Offset = "0x1E51A70", VA = "0x181E52E70", Slot = "8")]
			protected override void TransitionRemovedInternal(UICustomAdapterLayout<KeyValuePair<string, CarvingMainCardViewModel>, CarvingCardViewHolder>.Layouter.LayoutElement ele)
			{
			}

			// Token: 0x06023A95 RID: 146069 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023A95")]
			[Address(RVA = "0x1E53440", Offset = "0x1E52040", VA = "0x181E53440")]
			private void _CalculateSample()
			{
			}

			// Token: 0x06023A96 RID: 146070 RVA: 0x000C17D0 File Offset: 0x000BF9D0
			[Token(Token = "0x6023A96")]
			[Address(RVA = "0x1E537A0", Offset = "0x1E523A0", VA = "0x181E537A0")]
			private float _CalculateSingleSample(int idx, int selectedCardIdx, int cardCount)
			{
				return 0f;
			}

			// Token: 0x04031669 RID: 202345
			[Token(Token = "0x4031669")]
			[FieldOffset(Offset = "0x68")]
			private CarvingCardListView m_closure;

			// Token: 0x0403166A RID: 202346
			[Token(Token = "0x403166A")]
			[FieldOffset(Offset = "0x70")]
			private CarvingCardListViewModel m_cachedCardListViewModel;

			// Token: 0x0403166B RID: 202347
			[Token(Token = "0x403166B")]
			[FieldOffset(Offset = "0x78")]
			private Dictionary<string, float> m_samplePosDict;

			// Token: 0x0403166C RID: 202348
			[Token(Token = "0x403166C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403166D RID: 202349
			[Token(Token = "0x403166D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetElementSamplePosDict;

			// Token: 0x0403166E RID: 202350
			[Token(Token = "0x403166E")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_TransitionNewlyAddedInternal;

			// Token: 0x0403166F RID: 202351
			[Token(Token = "0x403166F")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_TransitionRemovedInternal;

			// Token: 0x04031670 RID: 202352
			[Token(Token = "0x4031670")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__CalculateSample;

			// Token: 0x04031671 RID: 202353
			[Token(Token = "0x4031671")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0__CalculateSingleSample;
		}
	}
}
