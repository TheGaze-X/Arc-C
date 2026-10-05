using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Building.UI
{
	// Token: 0x02001B46 RID: 6982
	[Token(Token = "0x2001B46")]
	public class UIArchiCostItemCard : MonoBehaviour
	{
		// Token: 0x0600AF86 RID: 44934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF86")]
		[Address(RVA = "0x32B2240", Offset = "0x32B0E40", VA = "0x1832B2240")]
		public void Setup(ArchiCostItemModel model)
		{
		}

		// Token: 0x0600AF87 RID: 44935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF87")]
		[Address(RVA = "0x32B2540", Offset = "0x32B1140", VA = "0x1832B2540")]
		public UIArchiCostItemCard()
		{
		}

		// Token: 0x0400A93B RID: 43323
		[Token(Token = "0x400A93B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _itemCardProto;

		// Token: 0x0400A93C RID: 43324
		[Token(Token = "0x400A93C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _cardScale;

		// Token: 0x0400A93D RID: 43325
		[Token(Token = "0x400A93D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _container;

		// Token: 0x0400A93E RID: 43326
		[Token(Token = "0x400A93E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _costNumLabel;

		// Token: 0x0400A93F RID: 43327
		[Token(Token = "0x400A93F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string _invalidColorString;

		// Token: 0x0400A940 RID: 43328
		[Token(Token = "0x400A940")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _itemDescScaling;
	}
}
