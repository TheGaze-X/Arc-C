using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B7E RID: 23422
	[Token(Token = "0x2005B7E")]
	public class SocialUnlockView : MonoBehaviour
	{
		// Token: 0x06021FEA RID: 139242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021FEA")]
		[Address(RVA = "0x1C83AE0", Offset = "0x1C826E0", VA = "0x181C83AE0")]
		public void RenderView(int costCredit, string groupId, int currentPercent, float maxPercent, Dictionary<int, CreditGroupObjViewModel> viewModelList)
		{
		}

		// Token: 0x06021FEB RID: 139243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021FEB")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public SocialUnlockView()
		{
		}

		// Token: 0x0402E99D RID: 190877
		[Token(Token = "0x402E99D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _itemContainer;

		// Token: 0x0402E99E RID: 190878
		[Token(Token = "0x402E99E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SocialUnlockItem _unlockItem;

		// Token: 0x0402E99F RID: 190879
		[Token(Token = "0x402E99F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _groupIdText;

		// Token: 0x0402E9A0 RID: 190880
		[Token(Token = "0x402E9A0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _barLine;

		// Token: 0x0402E9A1 RID: 190881
		[Token(Token = "0x402E9A1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _creditNum;

		// Token: 0x0402E9A2 RID: 190882
		[Token(Token = "0x402E9A2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _length;

		// Token: 0x0402E9A3 RID: 190883
		[Token(Token = "0x402E9A3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _imgSocialPt;
	}
}
