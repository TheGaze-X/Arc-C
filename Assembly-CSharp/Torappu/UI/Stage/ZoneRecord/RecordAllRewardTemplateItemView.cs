using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage.ZoneRecord
{
	// Token: 0x02006A01 RID: 27137
	[Token(Token = "0x2006A01")]
	public abstract class RecordAllRewardTemplateItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06026CCE RID: 158926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026CCE")]
		[Address(RVA = "0x21D6100", Offset = "0x21D4D00", VA = "0x1821D6100", Slot = "4")]
		public virtual void Render(ZoneRecordViewModel viewModel, int idx)
		{
		}

		// Token: 0x06026CCF RID: 158927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026CCF")]
		[Address(RVA = "0x21D6410", Offset = "0x21D5010", VA = "0x1821D6410")]
		private void _ClearAllRewardContent()
		{
		}

		// Token: 0x06026CD0 RID: 158928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026CD0")]
		[Address(RVA = "0x21D67B0", Offset = "0x21D53B0", VA = "0x1821D67B0")]
		private void _RenderCommonReward(ZoneRecordRewardViewModel rewardViewModel)
		{
		}

		// Token: 0x06026CD1 RID: 158929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026CD1")]
		[Address(RVA = "0x21D6C60", Offset = "0x21D5860", VA = "0x1821D6C60")]
		private void _RenderPredefinedReward(List<ZoneRecordRewardViewModel> viewModel)
		{
		}

		// Token: 0x06026CD2 RID: 158930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026CD2")]
		[Address(RVA = "0x21D65A0", Offset = "0x21D51A0", VA = "0x1821D65A0")]
		private List<UIItemViewModel> _GenRewardViewModel(ItemBundle[] items)
		{
			return null;
		}

		// Token: 0x06026CD3 RID: 158931 RVA: 0x000CC6A8 File Offset: 0x000CA8A8
		[Token(Token = "0x6026CD3")]
		[Address(RVA = "0x21D6730", Offset = "0x21D5330", VA = "0x1821D6730")]
		private float _GetRewardsCanvasAlpha(bool isComplete)
		{
			return 0f;
		}

		// Token: 0x06026CD4 RID: 158932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026CD4")]
		[Address(RVA = "0x21D69E0", Offset = "0x21D55E0", VA = "0x1821D69E0")]
		private void _RenderMissionPart(List<ZoneRecordRewardViewModel> rewardModels)
		{
		}

		// Token: 0x06026CD5 RID: 158933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026CD5")]
		[Address(RVA = "0x21D6F20", Offset = "0x21D5B20", VA = "0x1821D6F20")]
		protected RecordAllRewardTemplateItemView()
		{
		}

		// Token: 0x04036CFC RID: 224508
		[Token(Token = "0x4036CFC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TwoStateToggle _lightBgToggle;

		// Token: 0x04036CFD RID: 224509
		[Token(Token = "0x4036CFD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _recordName;

		// Token: 0x04036CFE RID: 224510
		[Token(Token = "0x4036CFE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TwoStateToggle _predefinedToggle;

		// Token: 0x04036CFF RID: 224511
		[Token(Token = "0x4036CFF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _itemCardScaler;

		// Token: 0x04036D00 RID: 224512
		[Token(Token = "0x4036D00")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SimpleLayoutContent _easyRewards;

		// Token: 0x04036D01 RID: 224513
		[Token(Token = "0x4036D01")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SimpleLayoutContent _normalRewards;

		// Token: 0x04036D02 RID: 224514
		[Token(Token = "0x4036D02")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SimpleLayoutContent _toughRewards;

		// Token: 0x04036D03 RID: 224515
		[Token(Token = "0x4036D03")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SimpleLayoutContent _predefinedRewards;

		// Token: 0x04036D04 RID: 224516
		[Token(Token = "0x4036D04")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _easyComplete;

		// Token: 0x04036D05 RID: 224517
		[Token(Token = "0x4036D05")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _normalComplete;

		// Token: 0x04036D06 RID: 224518
		[Token(Token = "0x4036D06")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _toughComplete;

		// Token: 0x04036D07 RID: 224519
		[Token(Token = "0x4036D07")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _predefinedComplete;

		// Token: 0x04036D08 RID: 224520
		[Token(Token = "0x4036D08")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private CanvasGroup _canvasGroupEasy;

		// Token: 0x04036D09 RID: 224521
		[Token(Token = "0x4036D09")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private CanvasGroup _canvasGroupNormal;

		// Token: 0x04036D0A RID: 224522
		[Token(Token = "0x4036D0A")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private CanvasGroup _canvasGroupTough;

		// Token: 0x04036D0B RID: 224523
		[Token(Token = "0x4036D0B")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private CanvasGroup _canvasGroupPredefined;

		// Token: 0x04036D0C RID: 224524
		[Token(Token = "0x4036D0C")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Color _completeItemColor;

		// Token: 0x04036D0D RID: 224525
		[Token(Token = "0x4036D0D")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private RecordAllRewardTemplateItemView.StageDiff[] _diffList;

		// Token: 0x04036D0E RID: 224526
		[Token(Token = "0x4036D0E")]
		private const float COMPLETE__CANVAS_ALPHA = 0.3f;

		// Token: 0x04036D0F RID: 224527
		[Token(Token = "0x4036D0F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04036D10 RID: 224528
		[Token(Token = "0x4036D10")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__ClearAllRewardContent;

		// Token: 0x04036D11 RID: 224529
		[Token(Token = "0x4036D11")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderCommonReward;

		// Token: 0x04036D12 RID: 224530
		[Token(Token = "0x4036D12")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderPredefinedReward;

		// Token: 0x04036D13 RID: 224531
		[Token(Token = "0x4036D13")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GenRewardViewModel;

		// Token: 0x04036D14 RID: 224532
		[Token(Token = "0x4036D14")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetRewardsCanvasAlpha;

		// Token: 0x04036D15 RID: 224533
		[Token(Token = "0x4036D15")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderMissionPart;

		// Token: 0x04036D16 RID: 224534
		[Token(Token = "0x4036D16")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006A02 RID: 27138
		[Token(Token = "0x2006A02")]
		[Serializable]
		private struct StageDiff
		{
			// Token: 0x04036D17 RID: 224535
			[Token(Token = "0x4036D17")]
			[FieldOffset(Offset = "0x0")]
			public RecordRewardStageDiff diff;

			// Token: 0x04036D18 RID: 224536
			[Token(Token = "0x4036D18")]
			[FieldOffset(Offset = "0x8")]
			public GameObject missionBg;
		}
	}
}
