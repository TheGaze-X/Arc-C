using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020067E9 RID: 26601
	[Token(Token = "0x20067E9")]
	public class StageZoneHomeClimbTowerToDoItem : StageZoneHomeToDoItemPlugin
	{
		// Token: 0x0602620F RID: 156175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602620F")]
		[Address(RVA = "0x213E640", Offset = "0x213D240", VA = "0x18213E640", Slot = "5")]
		protected override void OnDataUpdated()
		{
		}

		// Token: 0x06026210 RID: 156176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026210")]
		[Address(RVA = "0x213E5E0", Offset = "0x213D1E0", VA = "0x18213E5E0", Slot = "6")]
		protected override Sprite LoadMainSprite()
		{
			return null;
		}

		// Token: 0x06026211 RID: 156177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026211")]
		[Address(RVA = "0x213E820", Offset = "0x213D420", VA = "0x18213E820")]
		private void _RenderCurrentView(ZoneHomeClimbTowerToDoModel.ClimbTowerModel towerModel)
		{
		}

		// Token: 0x06026212 RID: 156178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026212")]
		[Address(RVA = "0x213E8F0", Offset = "0x213D4F0", VA = "0x18213E8F0")]
		private void _RenderOfferView(ZoneHomeClimbTowerToDoModel.ClimbTowerModel towerModel)
		{
		}

		// Token: 0x06026213 RID: 156179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026213")]
		[Address(RVA = "0x213EBE0", Offset = "0x213D7E0", VA = "0x18213EBE0")]
		public StageZoneHomeClimbTowerToDoItem()
		{
		}

		// Token: 0x04035B22 RID: 219938
		[Token(Token = "0x4035B22")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Offer")]
		private Text _textOfferLowerItemName;

		// Token: 0x04035B23 RID: 219939
		[Token(Token = "0x4035B23")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Offer")]
		private Text _textOfferHigherItemName;

		// Token: 0x04035B24 RID: 219940
		[Token(Token = "0x4035B24")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Offer")]
		private Text _textOfferLowerItemProgress;

		// Token: 0x04035B25 RID: 219941
		[Token(Token = "0x4035B25")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Offer")]
		private Text _textOfferHigherItemProgress;

		// Token: 0x04035B26 RID: 219942
		[Token(Token = "0x4035B26")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Offer")]
		private Slider _sliderOfferLowerItemProgress;

		// Token: 0x04035B27 RID: 219943
		[Token(Token = "0x4035B27")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Offer")]
		private Slider _sliderOfferHigherItemProgress;

		// Token: 0x04035B28 RID: 219944
		[Token(Token = "0x4035B28")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Current")]
		private Text _textTowerName;

		// Token: 0x04035B29 RID: 219945
		[Token(Token = "0x4035B29")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Current")]
		private TwoStateToggle _toggleInBatlleImg;

		// Token: 0x04035B2A RID: 219946
		[Token(Token = "0x4035B2A")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Sprite _mainBg;

		// Token: 0x04035B2B RID: 219947
		[Token(Token = "0x4035B2B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		public string _feeProgressFormat;

		// Token: 0x04035B2C RID: 219948
		[Token(Token = "0x4035B2C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private TwoStateToggle _toggleInBattle;

		// Token: 0x04035B2D RID: 219949
		[Token(Token = "0x4035B2D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnDataUpdated;

		// Token: 0x04035B2E RID: 219950
		[Token(Token = "0x4035B2E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadMainSprite;

		// Token: 0x04035B2F RID: 219951
		[Token(Token = "0x4035B2F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderCurrentView;

		// Token: 0x04035B30 RID: 219952
		[Token(Token = "0x4035B30")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderOfferView;

		// Token: 0x04035B31 RID: 219953
		[Token(Token = "0x4035B31")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
