using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020067E4 RID: 26596
	[Token(Token = "0x20067E4")]
	public class StageZoneHomeCampaignWeeklyToDoItem : StageZoneHomeToDoItemPlugin
	{
		// Token: 0x06026203 RID: 156163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026203")]
		[Address(RVA = "0x213E060", Offset = "0x213CC60", VA = "0x18213E060", Slot = "6")]
		protected override Sprite LoadMainSprite()
		{
			return null;
		}

		// Token: 0x06026204 RID: 156164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026204")]
		[Address(RVA = "0x213E150", Offset = "0x213CD50", VA = "0x18213E150", Slot = "5")]
		protected override void OnDataUpdated()
		{
		}

		// Token: 0x06026205 RID: 156165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026205")]
		[Address(RVA = "0x213E540", Offset = "0x213D140", VA = "0x18213E540")]
		public StageZoneHomeCampaignWeeklyToDoItem()
		{
		}

		// Token: 0x04035B00 RID: 219904
		[Token(Token = "0x4035B00")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _feeProgressFormat;

		// Token: 0x04035B01 RID: 219905
		[Token(Token = "0x4035B01")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _breakRewardColor;

		// Token: 0x04035B02 RID: 219906
		[Token(Token = "0x4035B02")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Sprite _feeMainSprite;

		// Token: 0x04035B03 RID: 219907
		[Token(Token = "0x4035B03")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Sprite _breakRewardMainSprite;

		// Token: 0x04035B04 RID: 219908
		[Token(Token = "0x4035B04")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _panelFee;

		// Token: 0x04035B05 RID: 219909
		[Token(Token = "0x4035B05")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RectTransform _panelBreakReward;

		// Token: 0x04035B06 RID: 219910
		[Token(Token = "0x4035B06")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textFeeProgress;

		// Token: 0x04035B07 RID: 219911
		[Token(Token = "0x4035B07")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Slider _sliderFeeProgress;

		// Token: 0x04035B08 RID: 219912
		[Token(Token = "0x4035B08")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _textBreakPermStageTitle;

		// Token: 0x04035B09 RID: 219913
		[Token(Token = "0x4035B09")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _textBreakTrainStageTitle;

		// Token: 0x04035B0A RID: 219914
		[Token(Token = "0x4035B0A")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _textBreakStageName;

		// Token: 0x04035B0B RID: 219915
		[Token(Token = "0x4035B0B")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private EasyInstancePool _breakRewardStatus;

		// Token: 0x04035B0C RID: 219916
		[Token(Token = "0x4035B0C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadMainSprite;

		// Token: 0x04035B0D RID: 219917
		[Token(Token = "0x4035B0D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDataUpdated;

		// Token: 0x04035B0E RID: 219918
		[Token(Token = "0x4035B0E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
