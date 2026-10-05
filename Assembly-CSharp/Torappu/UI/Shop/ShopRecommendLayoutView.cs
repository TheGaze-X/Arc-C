using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B27 RID: 23335
	[Token(Token = "0x2005B27")]
	public class ShopRecommendLayoutView : MonoBehaviour
	{
		// Token: 0x06021E1F RID: 138783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E1F")]
		[Address(RVA = "0x1C65380", Offset = "0x1C63F80", VA = "0x181C65380")]
		public void OnClick(int index)
		{
		}

		// Token: 0x06021E20 RID: 138784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E20")]
		[Address(RVA = "0x1C654B0", Offset = "0x1C640B0", VA = "0x181C654B0")]
		public void Render(string tagId, List<ShopRecommendData> viewModel, ShopRecommendTemplateViewModelBase templateModel)
		{
		}

		// Token: 0x06021E21 RID: 138785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E21")]
		[Address(RVA = "0x1C657F0", Offset = "0x1C643F0", VA = "0x181C657F0")]
		public ShopRecommendLayoutView()
		{
		}

		// Token: 0x0402E6C7 RID: 190151
		[Token(Token = "0x402E6C7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ShopRecommendItemView[] _itemList;

		// Token: 0x0402E6C8 RID: 190152
		[Token(Token = "0x402E6C8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ShopRecommendTemplateViewBase _templateView;

		// Token: 0x0402E6C9 RID: 190153
		[Token(Token = "0x402E6C9")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public ShopRecommendLayoutView.UIRecommendEvent onClickEvent;

		// Token: 0x0402E6CA RID: 190154
		[Token(Token = "0x402E6CA")]
		[FieldOffset(Offset = "0x30")]
		private List<ShopRecommendData> m_dataList;

		// Token: 0x02005B28 RID: 23336
		[Token(Token = "0x2005B28")]
		[Serializable]
		public class UIRecommendEvent : UnityEvent<ShopRecommendData>
		{
			// Token: 0x06021E22 RID: 138786 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021E22")]
			[Address(RVA = "0x1C6E5E0", Offset = "0x1C6D1E0", VA = "0x181C6E5E0")]
			public UIRecommendEvent()
			{
			}
		}
	}
}
