using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x020060CE RID: 24782
	[Token(Token = "0x20060CE")]
	public class CampaignBriefTrainingGroupView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06023D1F RID: 146719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023D1F")]
		[Address(RVA = "0x1E6DE70", Offset = "0x1E6CA70", VA = "0x181E6DE70")]
		public void Render(CampaignBriefTrainingViewModel viewModel)
		{
		}

		// Token: 0x06023D20 RID: 146720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023D20")]
		[Address(RVA = "0x1E6E220", Offset = "0x1E6CE20", VA = "0x181E6E220")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06023D21 RID: 146721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023D21")]
		[Address(RVA = "0x1E6E2A0", Offset = "0x1E6CEA0", VA = "0x181E6E2A0")]
		public CampaignBriefTrainingGroupView()
		{
		}

		// Token: 0x04031AD4 RID: 203476
		[Token(Token = "0x4031AD4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imageDashLine;

		// Token: 0x04031AD5 RID: 203477
		[Token(Token = "0x4031AD5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imageDashLineAllOpen;

		// Token: 0x04031AD6 RID: 203478
		[Token(Token = "0x4031AD6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _panelCurrent;

		// Token: 0x04031AD7 RID: 203479
		[Token(Token = "0x4031AD7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _panelCurrentAllOpen;

		// Token: 0x04031AD8 RID: 203480
		[Token(Token = "0x4031AD8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelTextReturnAllOpen;

		// Token: 0x04031AD9 RID: 203481
		[Token(Token = "0x4031AD9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelTextNormalAllOpen;

		// Token: 0x04031ADA RID: 203482
		[Token(Token = "0x4031ADA")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _panelNext;

		// Token: 0x04031ADB RID: 203483
		[Token(Token = "0x4031ADB")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _panelNextAllOpen;

		// Token: 0x04031ADC RID: 203484
		[Token(Token = "0x4031ADC")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textRemainTime;

		// Token: 0x04031ADD RID: 203485
		[Token(Token = "0x4031ADD")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private SimpleLayoutContent _stageInfoContent;

		// Token: 0x04031ADE RID: 203486
		[Token(Token = "0x4031ADE")]
		[FieldOffset(Offset = "0x68")]
		private bool m_inited;

		// Token: 0x04031ADF RID: 203487
		[Token(Token = "0x4031ADF")]
		[FieldOffset(Offset = "0x70")]
		private CampaignBriefTrainingGroupView.StageInfoAdapter m_stageInfoAdapter;

		// Token: 0x04031AE0 RID: 203488
		[Token(Token = "0x4031AE0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04031AE1 RID: 203489
		[Token(Token = "0x4031AE1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04031AE2 RID: 203490
		[Token(Token = "0x4031AE2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020060CF RID: 24783
		[Token(Token = "0x20060CF")]
		public class StageInfoAdapter : SimpleLayoutAdapter
		{
			// Token: 0x1700549B RID: 21659
			// (get) Token: 0x06023D22 RID: 146722 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06023D23 RID: 146723 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700549B")]
			public List<CampaignBriefTrainingViewModel.StageInfoViewModel> dataSet
			{
				[Token(Token = "0x6023D22")]
				[Address(RVA = "0x1E811A0", Offset = "0x1E7FDA0", VA = "0x181E811A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6023D23")]
				[Address(RVA = "0x1E81200", Offset = "0x1E7FE00", VA = "0x181E81200")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700549C RID: 21660
			// (get) Token: 0x06023D24 RID: 146724 RVA: 0x000C2268 File Offset: 0x000C0468
			[Token(Token = "0x1700549C")]
			public override int count
			{
				[Token(Token = "0x6023D24")]
				[Address(RVA = "0x1E810E0", Offset = "0x1E7FCE0", VA = "0x181E810E0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06023D25 RID: 146725 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6023D25")]
			[Address(RVA = "0x1E80DD0", Offset = "0x1E7F9D0", VA = "0x181E80DD0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06023D26 RID: 146726 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023D26")]
			[Address(RVA = "0x1E81080", Offset = "0x1E7FC80", VA = "0x181E81080")]
			public StageInfoAdapter()
			{
			}

			// Token: 0x04031AE4 RID: 203492
			[Token(Token = "0x4031AE4")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_dataSet;

			// Token: 0x04031AE5 RID: 203493
			[Token(Token = "0x4031AE5")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_dataSet;

			// Token: 0x04031AE6 RID: 203494
			[Token(Token = "0x4031AE6")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04031AE7 RID: 203495
			[Token(Token = "0x4031AE7")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04031AE8 RID: 203496
			[Token(Token = "0x4031AE8")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
