using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B77 RID: 23415
	[Token(Token = "0x2005B77")]
	public class SocialUnlockItem : MonoBehaviour
	{
		// Token: 0x06021FDA RID: 139226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021FDA")]
		[Address(RVA = "0x1C82A20", Offset = "0x1C81620", VA = "0x181C82A20")]
		public void RenderView(CreditGroupObjViewModel viewModel)
		{
		}

		// Token: 0x06021FDB RID: 139227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021FDB")]
		[Address(RVA = "0x1C82DB0", Offset = "0x1C819B0", VA = "0x181C82DB0")]
		public SocialUnlockItem()
		{
		}

		// Token: 0x0402E973 RID: 190835
		[Token(Token = "0x402E973")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform[] _itemContainerList;

		// Token: 0x0402E974 RID: 190836
		[Token(Token = "0x402E974")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SocialUnlockUIItemView _itemView;

		// Token: 0x0402E975 RID: 190837
		[Token(Token = "0x402E975")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIItemCard _itemCard;

		// Token: 0x0402E976 RID: 190838
		[Token(Token = "0x402E976")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _itemScale;

		// Token: 0x0402E977 RID: 190839
		[Token(Token = "0x402E977")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _sortPart;

		// Token: 0x0402E978 RID: 190840
		[Token(Token = "0x402E978")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _sortText;

		// Token: 0x0402E979 RID: 190841
		[Token(Token = "0x402E979")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0402E97A RID: 190842
		[Token(Token = "0x402E97A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _soldOutPart;

		// Token: 0x0402E97B RID: 190843
		[Token(Token = "0x402E97B")]
		[FieldOffset(Offset = "0x58")]
		private List<SocialUnlockUIItemView> m_itemCardList;
	}
}
