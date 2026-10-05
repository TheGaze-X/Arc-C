using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.Shop
{
	// Token: 0x02005AC1 RID: 23233
	[Token(Token = "0x2005AC1")]
	public class ShopFurnitureItemView : MonoBehaviour
	{
		// Token: 0x06021C61 RID: 138337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C61")]
		[Address(RVA = "0x1C40F50", Offset = "0x1C3FB50", VA = "0x181C40F50")]
		public void OnClick()
		{
		}

		// Token: 0x06021C62 RID: 138338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C62")]
		[Address(RVA = "0x1C40F50", Offset = "0x1C3FB50", VA = "0x181C40F50")]
		public void OpenItemDetail()
		{
		}

		// Token: 0x06021C63 RID: 138339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C63")]
		[Address(RVA = "0x1C409D0", Offset = "0x1C3F5D0", VA = "0x181C409D0")]
		public void LoadData(FurnGroupViewModel groupViewModel)
		{
		}

		// Token: 0x06021C64 RID: 138340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C64")]
		[Address(RVA = "0x1C40300", Offset = "0x1C3EF00", VA = "0x181C40300")]
		public void LoadData(FurnGoodViewModel furnGoodViewModel)
		{
		}

		// Token: 0x06021C65 RID: 138341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C65")]
		[Address(RVA = "0x1C40F60", Offset = "0x1C3FB60", VA = "0x181C40F60")]
		private void _OpenItemDetail()
		{
		}

		// Token: 0x06021C66 RID: 138342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C66")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public ShopFurnitureItemView()
		{
		}

		// Token: 0x0402E383 RID: 189315
		[Token(Token = "0x402E383")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _furnPart;

		// Token: 0x0402E384 RID: 189316
		[Token(Token = "0x402E384")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _bothPart;

		// Token: 0x0402E385 RID: 189317
		[Token(Token = "0x402E385")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _diamPart;

		// Token: 0x0402E386 RID: 189318
		[Token(Token = "0x402E386")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _diamondOnlyPrice;

		// Token: 0x0402E387 RID: 189319
		[Token(Token = "0x402E387")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _furniOnlyPrice;

		// Token: 0x0402E388 RID: 189320
		[Token(Token = "0x402E388")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _diamondBothPrice;

		// Token: 0x0402E389 RID: 189321
		[Token(Token = "0x402E389")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _furniBothPrice;

		// Token: 0x0402E38A RID: 189322
		[Token(Token = "0x402E38A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		protected Text _offsetPercent;

		// Token: 0x0402E38B RID: 189323
		[Token(Token = "0x402E38B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		protected GameObject _offsetPart;

		// Token: 0x0402E38C RID: 189324
		[Token(Token = "0x402E38C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _soldOutPart;

		// Token: 0x0402E38D RID: 189325
		[Token(Token = "0x402E38D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _alreadyHavePart;

		// Token: 0x0402E38E RID: 189326
		[Token(Token = "0x402E38E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image _furnImage;

		// Token: 0x0402E38F RID: 189327
		[Token(Token = "0x402E38F")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _remainCount;

		// Token: 0x0402E390 RID: 189328
		[Token(Token = "0x402E390")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _remainCountPart;

		// Token: 0x0402E391 RID: 189329
		[Token(Token = "0x402E391")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _displayName;

		// Token: 0x0402E392 RID: 189330
		[Token(Token = "0x402E392")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _addAtmosText;

		// Token: 0x0402E393 RID: 189331
		[Token(Token = "0x402E393")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private CanvasGroup _soldOutGroup;

		// Token: 0x0402E394 RID: 189332
		[Token(Token = "0x402E394")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject _endTimePart;

		// Token: 0x0402E395 RID: 189333
		[Token(Token = "0x402E395")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Text _endTimeText;

		// Token: 0x0402E396 RID: 189334
		[Token(Token = "0x402E396")]
		[FieldOffset(Offset = "0xB0")]
		private bool isGoodFlag;

		// Token: 0x0402E397 RID: 189335
		[Token(Token = "0x402E397")]
		[FieldOffset(Offset = "0xB8")]
		private FurnGoodViewModel m_cacheGoodViewModel;

		// Token: 0x0402E398 RID: 189336
		[Token(Token = "0x402E398")]
		[FieldOffset(Offset = "0xC0")]
		private FurnGroupViewModel m_cacheGroupViewModel;
	}
}
