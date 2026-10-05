using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.Crisis
{
	// Token: 0x02005A18 RID: 23064
	[Token(Token = "0x2005A18")]
	public class CrisisShopComplexRightView : MonoBehaviour
	{
		// Token: 0x0602198F RID: 137615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602198F")]
		[Address(RVA = "0x1C04FA0", Offset = "0x1C03BA0", VA = "0x181C04FA0")]
		public void Render(CrisisShopWrapped shopInfo)
		{
		}

		// Token: 0x06021990 RID: 137616 RVA: 0x000BAD98 File Offset: 0x000B8F98
		[Token(Token = "0x6021990")]
		[Address(RVA = "0x1C04F20", Offset = "0x1C03B20", VA = "0x181C04F20")]
		public int RefreshNum(int currCount)
		{
			return 0;
		}

		// Token: 0x06021991 RID: 137617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021991")]
		[Address(RVA = "0x1C05430", Offset = "0x1C04030", VA = "0x181C05430")]
		private void _RefreshClick()
		{
		}

		// Token: 0x06021992 RID: 137618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021992")]
		[Address(RVA = "0x1C04B50", Offset = "0x1C03750", VA = "0x181C04B50")]
		public void AddOne()
		{
		}

		// Token: 0x06021993 RID: 137619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021993")]
		[Address(RVA = "0x1C04DB0", Offset = "0x1C039B0", VA = "0x181C04DB0")]
		public void MinusOne()
		{
		}

		// Token: 0x06021994 RID: 137620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021994")]
		[Address(RVA = "0x1C04B80", Offset = "0x1C03780", VA = "0x181C04B80")]
		public void AddToMax()
		{
		}

		// Token: 0x06021995 RID: 137621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021995")]
		[Address(RVA = "0x1C04E50", Offset = "0x1C03A50", VA = "0x181C04E50")]
		public void MinusToOne()
		{
		}

		// Token: 0x06021996 RID: 137622 RVA: 0x000BADB0 File Offset: 0x000B8FB0
		[Token(Token = "0x6021996")]
		[Address(RVA = "0x1C04C00", Offset = "0x1C03800", VA = "0x181C04C00")]
		public int GetMaxPrice(int price, int maxCount)
		{
			return 0;
		}

		// Token: 0x06021997 RID: 137623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021997")]
		[Address(RVA = "0x1C04ED0", Offset = "0x1C03AD0", VA = "0x181C04ED0")]
		public void OnClick()
		{
		}

		// Token: 0x06021998 RID: 137624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021998")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public CrisisShopComplexRightView()
		{
		}

		// Token: 0x0402DEDC RID: 188124
		[Token(Token = "0x402DEDC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _shopBuyCount;

		// Token: 0x0402DEDD RID: 188125
		[Token(Token = "0x402DEDD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _shopItemName;

		// Token: 0x0402DEDE RID: 188126
		[Token(Token = "0x402DEDE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _shopPerCount;

		// Token: 0x0402DEDF RID: 188127
		[Token(Token = "0x402DEDF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _shopAvailCount;

		// Token: 0x0402DEE0 RID: 188128
		[Token(Token = "0x402DEE0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _totalPrice;

		// Token: 0x0402DEE1 RID: 188129
		[Token(Token = "0x402DEE1")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _alreadyHaveCount;

		// Token: 0x0402DEE2 RID: 188130
		[Token(Token = "0x402DEE2")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _singlePrice;

		// Token: 0x0402DEE3 RID: 188131
		[Token(Token = "0x402DEE3")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIIntEvent _buyEvent;

		// Token: 0x0402DEE4 RID: 188132
		[Token(Token = "0x402DEE4")]
		[FieldOffset(Offset = "0x58")]
		private int m_shopBuyCount;

		// Token: 0x0402DEE5 RID: 188133
		[Token(Token = "0x402DEE5")]
		[FieldOffset(Offset = "0x60")]
		private CrisisShopWrapped m_cacheViewModel;
	}
}
