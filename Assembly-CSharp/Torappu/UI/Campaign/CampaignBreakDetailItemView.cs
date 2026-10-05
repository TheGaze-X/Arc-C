using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x02006126 RID: 24870
	[Token(Token = "0x2006126")]
	public class CampaignBreakDetailItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06023EB7 RID: 147127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023EB7")]
		[Address(RVA = "0x1E851E0", Offset = "0x1E83DE0", VA = "0x181E851E0")]
		public void Render(CampaignBreakDetailItemViewModel breakModel)
		{
		}

		// Token: 0x06023EB8 RID: 147128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023EB8")]
		[Address(RVA = "0x1E85100", Offset = "0x1E83D00", VA = "0x181E85100")]
		public void EventOnConfirmButtonClicked()
		{
		}

		// Token: 0x06023EB9 RID: 147129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023EB9")]
		[Address(RVA = "0x1E85690", Offset = "0x1E84290", VA = "0x181E85690")]
		private void _RenderRewards(IList<UIItemViewModel> items, bool hasCampFeeUp)
		{
		}

		// Token: 0x06023EBA RID: 147130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023EBA")]
		[Address(RVA = "0x1E85870", Offset = "0x1E84470", VA = "0x181E85870")]
		public CampaignBreakDetailItemView()
		{
		}

		// Token: 0x04031DA3 RID: 204195
		[Token(Token = "0x4031DA3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _itemCardScale;

		// Token: 0x04031DA4 RID: 204196
		[Token(Token = "0x4031DA4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _killCntText;

		// Token: 0x04031DA5 RID: 204197
		[Token(Token = "0x4031DA5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _descriptionText;

		// Token: 0x04031DA6 RID: 204198
		[Token(Token = "0x4031DA6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _progressText;

		// Token: 0x04031DA7 RID: 204199
		[Token(Token = "0x4031DA7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Slider _progressSlider;

		// Token: 0x04031DA8 RID: 204200
		[Token(Token = "0x4031DA8")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SimpleLayoutContent _rewardContainer;

		// Token: 0x04031DA9 RID: 204201
		[Token(Token = "0x4031DA9")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _lastFeeUpReward;

		// Token: 0x04031DAA RID: 204202
		[Token(Token = "0x4031DAA")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Collection(typeof(CampaignBreakDetailItemViewModel.State))]
		private RectTransform[] _states;

		// Token: 0x04031DAB RID: 204203
		[Token(Token = "0x4031DAB")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button _ableToClick;

		// Token: 0x04031DAC RID: 204204
		[Token(Token = "0x4031DAC")]
		[FieldOffset(Offset = "0x60")]
		private CampaignBreakDetailItemView.RewardAdapter m_rewardAdapter;

		// Token: 0x04031DAD RID: 204205
		[Token(Token = "0x4031DAD")]
		[FieldOffset(Offset = "0x68")]
		private int m_cachedIndex;

		// Token: 0x04031DAE RID: 204206
		[Token(Token = "0x4031DAE")]
		[FieldOffset(Offset = "0x70")]
		private UICompDialogFinder m_dialogFinder;

		// Token: 0x04031DAF RID: 204207
		[Token(Token = "0x4031DAF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04031DB0 RID: 204208
		[Token(Token = "0x4031DB0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnConfirmButtonClicked;

		// Token: 0x04031DB1 RID: 204209
		[Token(Token = "0x4031DB1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderRewards;

		// Token: 0x04031DB2 RID: 204210
		[Token(Token = "0x4031DB2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006127 RID: 24871
		[Token(Token = "0x2006127")]
		private class RewardAdapter : SimpleLayoutAdapter
		{
			// Token: 0x170054D0 RID: 21712
			// (get) Token: 0x06023EBB RID: 147131 RVA: 0x000C2628 File Offset: 0x000C0828
			[Token(Token = "0x170054D0")]
			public override int count
			{
				[Token(Token = "0x6023EBB")]
				[Address(RVA = "0x1E9B960", Offset = "0x1E9A560", VA = "0x181E9B960", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06023EBC RID: 147132 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023EBC")]
			[Address(RVA = "0x1E9B8F0", Offset = "0x1E9A4F0", VA = "0x181E9B8F0")]
			public RewardAdapter(float itemCardScale)
			{
			}

			// Token: 0x06023EBD RID: 147133 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6023EBD")]
			[Address(RVA = "0x1E9B5E0", Offset = "0x1E9A1E0", VA = "0x181E9B5E0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04031DB3 RID: 204211
			[Token(Token = "0x4031DB3")]
			[FieldOffset(Offset = "0x20")]
			public IList<UIItemViewModel> itemModels;

			// Token: 0x04031DB4 RID: 204212
			[Token(Token = "0x4031DB4")]
			[FieldOffset(Offset = "0x28")]
			private float m_itemCardScale;

			// Token: 0x04031DB5 RID: 204213
			[Token(Token = "0x4031DB5")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04031DB6 RID: 204214
			[Token(Token = "0x4031DB6")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04031DB7 RID: 204215
			[Token(Token = "0x4031DB7")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
