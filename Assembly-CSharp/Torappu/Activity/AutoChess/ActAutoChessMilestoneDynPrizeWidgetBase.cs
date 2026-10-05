using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x02007128 RID: 28968
	[Token(Token = "0x2007128")]
	public abstract class ActAutoChessMilestoneDynPrizeWidgetBase : TemplateActivityMilestoneDynPrizeWidget
	{
		// Token: 0x17006169 RID: 24937
		// (get) Token: 0x0602923C RID: 168508
		[Token(Token = "0x17006169")]
		protected abstract ActAutoChessMilestoneDynPrizeWidgetBase.PrizeType prizeType { [Token(Token = "0x602923C")] get; }

		// Token: 0x0602923D RID: 168509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602923D")]
		[Address(RVA = "0x248AF30", Offset = "0x2489B30", VA = "0x18248AF30", Slot = "4")]
		public override void Render(TemplateActivityMilestoneGroupViewModel model)
		{
		}

		// Token: 0x0602923E RID: 168510
		[Token(Token = "0x602923E")]
		protected abstract void Render(TemplateActivityMileStoneItemModel prize);

		// Token: 0x0602923F RID: 168511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602923F")]
		[Address(RVA = "0x248B150", Offset = "0x2489D50", VA = "0x18248B150")]
		protected ActAutoChessMilestoneDynPrizeWidgetBase()
		{
		}

		// Token: 0x0403ABFE RID: 240638
		[Token(Token = "0x403ABFE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _rootPanel;

		// Token: 0x0403ABFF RID: 240639
		[Token(Token = "0x403ABFF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _levelDescText;

		// Token: 0x0403AC00 RID: 240640
		[Token(Token = "0x403AC00")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403AC01 RID: 240641
		[Token(Token = "0x403AC01")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007129 RID: 28969
		[Token(Token = "0x2007129")]
		protected enum PrizeType
		{
			// Token: 0x0403AC03 RID: 240643
			[Token(Token = "0x403AC03")]
			AVATAR,
			// Token: 0x0403AC04 RID: 240644
			[Token(Token = "0x403AC04")]
			FURNITURE,
			// Token: 0x0403AC05 RID: 240645
			[Token(Token = "0x403AC05")]
			HOME_THEME,
			// Token: 0x0403AC06 RID: 240646
			[Token(Token = "0x403AC06")]
			NAME_CARD_SKIN,
			// Token: 0x0403AC07 RID: 240647
			[Token(Token = "0x403AC07")]
			SKIN
		}
	}
}
