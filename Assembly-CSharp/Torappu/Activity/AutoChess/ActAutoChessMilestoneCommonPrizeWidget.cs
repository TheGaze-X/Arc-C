using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x02007127 RID: 28967
	[Token(Token = "0x2007127")]
	public class ActAutoChessMilestoneCommonPrizeWidget : ActAutoChessMilestoneDynPrizeWidgetBase
	{
		// Token: 0x17006168 RID: 24936
		// (get) Token: 0x06029239 RID: 168505 RVA: 0x000D4958 File Offset: 0x000D2B58
		[Token(Token = "0x17006168")]
		protected override ActAutoChessMilestoneDynPrizeWidgetBase.PrizeType prizeType
		{
			[Token(Token = "0x6029239")]
			[Address(RVA = "0x248AE80", Offset = "0x2489A80", VA = "0x18248AE80", Slot = "5")]
			get
			{
				return ActAutoChessMilestoneDynPrizeWidgetBase.PrizeType.AVATAR;
			}
		}

		// Token: 0x0602923A RID: 168506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602923A")]
		[Address(RVA = "0x248ACB0", Offset = "0x24898B0", VA = "0x18248ACB0", Slot = "6")]
		protected override void Render(TemplateActivityMileStoneItemModel prize)
		{
		}

		// Token: 0x0602923B RID: 168507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602923B")]
		[Address(RVA = "0x248ADE0", Offset = "0x24899E0", VA = "0x18248ADE0")]
		public ActAutoChessMilestoneCommonPrizeWidget()
		{
		}

		// Token: 0x0403ABF9 RID: 240633
		[Token(Token = "0x403ABF9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ActAutoChessMilestoneDynPrizeWidgetBase.PrizeType _prizeType;

		// Token: 0x0403ABFA RID: 240634
		[Token(Token = "0x403ABFA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _nameText;

		// Token: 0x0403ABFB RID: 240635
		[Token(Token = "0x403ABFB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_prizeType;

		// Token: 0x0403ABFC RID: 240636
		[Token(Token = "0x403ABFC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403ABFD RID: 240637
		[Token(Token = "0x403ABFD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
