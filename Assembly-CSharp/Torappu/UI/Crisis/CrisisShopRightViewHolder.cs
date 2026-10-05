using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.Crisis
{
	// Token: 0x02005A11 RID: 23057
	[Token(Token = "0x2005A11")]
	public class CrisisShopRightViewHolder : MonoBehaviour
	{
		// Token: 0x06021976 RID: 137590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021976")]
		[Address(RVA = "0x1C0A0A0", Offset = "0x1C08CA0", VA = "0x181C0A0A0")]
		private ShopDetailInfo _GetBuyItemInfoAndSetPrice(CrisisShopWrapped shopViewModel)
		{
			return null;
		}

		// Token: 0x06021977 RID: 137591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021977")]
		[Address(RVA = "0x1C09D20", Offset = "0x1C08920", VA = "0x181C09D20")]
		public void Render(CrisisShopWrapped shopViewModel)
		{
		}

		// Token: 0x06021978 RID: 137592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021978")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public CrisisShopRightViewHolder()
		{
		}

		// Token: 0x0402DE9C RID: 188060
		[Token(Token = "0x402DE9C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CrisisShopCharRightView _charView;

		// Token: 0x0402DE9D RID: 188061
		[Token(Token = "0x402DE9D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CrisisShopComplexRightView _complexView;

		// Token: 0x0402DE9E RID: 188062
		[Token(Token = "0x402DE9E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CrisisShopSingleRightView _singleView;

		// Token: 0x0402DE9F RID: 188063
		[Token(Token = "0x402DE9F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<Image> _iconList;

		// Token: 0x0402DEA0 RID: 188064
		[Token(Token = "0x402DEA0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Sprite _crisisV1Icon;

		// Token: 0x0402DEA1 RID: 188065
		[Token(Token = "0x402DEA1")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Sprite _crisisV2Icon;
	}
}
