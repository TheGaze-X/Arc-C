using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B2F RID: 23343
	[Token(Token = "0x2005B2F")]
	public class ShopRecommendTemplateNormalFurnView : ShopRecommendTemplateView<ShopRecommendTemplateNormalFurnViewModel>
	{
		// Token: 0x06021E47 RID: 138823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E47")]
		[Address(RVA = "0x1C691B0", Offset = "0x1C67DB0", VA = "0x181C691B0", Slot = "6")]
		public override void Render(ShopRecommendTemplateNormalFurnViewModel viewModel)
		{
		}

		// Token: 0x06021E48 RID: 138824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E48")]
		[Address(RVA = "0x1C69CD0", Offset = "0x1C688D0", VA = "0x181C69CD0")]
		public ShopRecommendTemplateNormalFurnView()
		{
		}

		// Token: 0x0402E6FE RID: 190206
		[Token(Token = "0x402E6FE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelAllNew;

		// Token: 0x0402E6FF RID: 190207
		[Token(Token = "0x402E6FF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelAllRep;

		// Token: 0x0402E700 RID: 190208
		[Token(Token = "0x402E700")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelPart;

		// Token: 0x0402E701 RID: 190209
		[Token(Token = "0x402E701")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelDecoNew;

		// Token: 0x0402E702 RID: 190210
		[Token(Token = "0x402E702")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelDecoRep;

		// Token: 0x0402E703 RID: 190211
		[Token(Token = "0x402E703")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _startMonth;

		// Token: 0x0402E704 RID: 190212
		[Token(Token = "0x402E704")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _startDay;

		// Token: 0x0402E705 RID: 190213
		[Token(Token = "0x402E705")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _startTime;

		// Token: 0x0402E706 RID: 190214
		[Token(Token = "0x402E706")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _endMonth;

		// Token: 0x0402E707 RID: 190215
		[Token(Token = "0x402E707")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _endDay;

		// Token: 0x0402E708 RID: 190216
		[Token(Token = "0x402E708")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _endTime;

		// Token: 0x0402E709 RID: 190217
		[Token(Token = "0x402E709")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _name;

		// Token: 0x0402E70A RID: 190218
		[Token(Token = "0x402E70A")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _desc;

		// Token: 0x0402E70B RID: 190219
		[Token(Token = "0x402E70B")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _hint;

		// Token: 0x0402E70C RID: 190220
		[Token(Token = "0x402E70C")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _count;

		// Token: 0x0402E70D RID: 190221
		[Token(Token = "0x402E70D")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private List<Graphic> _colorGrapicBack;

		// Token: 0x0402E70E RID: 190222
		[Token(Token = "0x402E70E")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private List<Graphic> _colorGrapicText;

		// Token: 0x0402E70F RID: 190223
		[Token(Token = "0x402E70F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402E710 RID: 190224
		[Token(Token = "0x402E710")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
