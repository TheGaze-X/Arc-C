using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200679A RID: 26522
	[Token(Token = "0x200679A")]
	public class StageZoneWeeklyRecordView : DataBinder<StageZoneWeeklyRewardProperty>
	{
		// Token: 0x060260A3 RID: 155811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60260A3")]
		[Address(RVA = "0x2126310", Offset = "0x2124F10", VA = "0x182126310", Slot = "7")]
		public override void OnValueChanged(StageZoneWeeklyRewardProperty property)
		{
		}

		// Token: 0x060260A4 RID: 155812 RVA: 0x000C9BE8 File Offset: 0x000C7DE8
		[Token(Token = "0x60260A4")]
		[Address(RVA = "0x2126590", Offset = "0x2125190", VA = "0x182126590")]
		private bool _TryRenderCampaignView(StageZoneCampaignViewModel viewModel)
		{
			return default(bool);
		}

		// Token: 0x060260A5 RID: 155813 RVA: 0x000C9C00 File Offset: 0x000C7E00
		[Token(Token = "0x60260A5")]
		[Address(RVA = "0x2126720", Offset = "0x2125320", VA = "0x182126720")]
		private bool _TryRenderTowerView(StageZoneClimbTowerViewModel viewModel)
		{
			return default(bool);
		}

		// Token: 0x060260A6 RID: 155814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60260A6")]
		[Address(RVA = "0x21269B0", Offset = "0x21255B0", VA = "0x1821269B0")]
		public StageZoneWeeklyRecordView()
		{
		}

		// Token: 0x0403585A RID: 219226
		[Token(Token = "0x403585A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _rewardProgressFormat;

		// Token: 0x0403585B RID: 219227
		[Token(Token = "0x403585B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Diamond")]
		private Text _textDiamondProgress;

		// Token: 0x0403585C RID: 219228
		[Token(Token = "0x403585C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Diamond")]
		private Text _textDiamondCountDown;

		// Token: 0x0403585D RID: 219229
		[Token(Token = "0x403585D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Diamond")]
		private Slider _sliderDiamondProgress;

		// Token: 0x0403585E RID: 219230
		[Token(Token = "0x403585E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Diamond")]
		private CanvasGroup _diamondCanvasGroup;

		// Token: 0x0403585F RID: 219231
		[Token(Token = "0x403585F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Tower")]
		private Text _textTowerLowerItemProgress;

		// Token: 0x04035860 RID: 219232
		[Token(Token = "0x4035860")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Tower")]
		private Slider _sliderTowerLowerItemProgress;

		// Token: 0x04035861 RID: 219233
		[Token(Token = "0x4035861")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Tower")]
		private Text _textTowerHigherItemProgress;

		// Token: 0x04035862 RID: 219234
		[Token(Token = "0x4035862")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Tower")]
		private Slider _sliderTowerHigherItemProgress;

		// Token: 0x04035863 RID: 219235
		[Token(Token = "0x4035863")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Tower")]
		private Text _textTowerItemCountDown;

		// Token: 0x04035864 RID: 219236
		[Token(Token = "0x4035864")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Tower")]
		private CanvasGroup _towerCanvasGroup;

		// Token: 0x04035865 RID: 219237
		[Token(Token = "0x4035865")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Tower")]
		private Text _textItemGroupName;

		// Token: 0x04035866 RID: 219238
		[Token(Token = "0x4035866")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Tower")]
		private GameObject _panelTower;

		// Token: 0x04035867 RID: 219239
		[Token(Token = "0x4035867")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04035868 RID: 219240
		[Token(Token = "0x4035868")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__TryRenderCampaignView;

		// Token: 0x04035869 RID: 219241
		[Token(Token = "0x4035869")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__TryRenderTowerView;

		// Token: 0x0403586A RID: 219242
		[Token(Token = "0x403586A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
