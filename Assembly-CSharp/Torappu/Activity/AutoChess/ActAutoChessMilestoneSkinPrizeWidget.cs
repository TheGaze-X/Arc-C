using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x0200712B RID: 28971
	[Token(Token = "0x200712B")]
	public class ActAutoChessMilestoneSkinPrizeWidget : ActAutoChessMilestoneDynPrizeWidgetBase
	{
		// Token: 0x1700616A RID: 24938
		// (get) Token: 0x06029245 RID: 168517 RVA: 0x000D4970 File Offset: 0x000D2B70
		[Token(Token = "0x1700616A")]
		protected override ActAutoChessMilestoneDynPrizeWidgetBase.PrizeType prizeType
		{
			[Token(Token = "0x6029245")]
			[Address(RVA = "0x248B8F0", Offset = "0x248A4F0", VA = "0x18248B8F0", Slot = "5")]
			get
			{
				return ActAutoChessMilestoneDynPrizeWidgetBase.PrizeType.AVATAR;
			}
		}

		// Token: 0x06029246 RID: 168518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029246")]
		[Address(RVA = "0x248B6D0", Offset = "0x248A2D0", VA = "0x18248B6D0", Slot = "6")]
		protected override void Render(TemplateActivityMileStoneItemModel prize)
		{
		}

		// Token: 0x06029247 RID: 168519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029247")]
		[Address(RVA = "0x248B850", Offset = "0x248A450", VA = "0x18248B850")]
		public ActAutoChessMilestoneSkinPrizeWidget()
		{
		}

		// Token: 0x0403AC13 RID: 240659
		[Token(Token = "0x403AC13")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _charNameText;

		// Token: 0x0403AC14 RID: 240660
		[Token(Token = "0x403AC14")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _skinNameText;

		// Token: 0x0403AC15 RID: 240661
		[Token(Token = "0x403AC15")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_prizeType;

		// Token: 0x0403AC16 RID: 240662
		[Token(Token = "0x403AC16")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403AC17 RID: 240663
		[Token(Token = "0x403AC17")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
