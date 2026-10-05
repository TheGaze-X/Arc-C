using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003B5A RID: 15194
	[Token(Token = "0x2003B5A")]
	public class ShopDetailItemPileView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06017D9B RID: 97691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D9B")]
		[Address(RVA = "0x101BB90", Offset = "0x101A790", VA = "0x18101BB90")]
		public void PileItem(int count, string itemId, ItemType itemType = ItemType.NONE)
		{
		}

		// Token: 0x06017D9C RID: 97692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D9C")]
		[Address(RVA = "0x101B7F0", Offset = "0x101A3F0", VA = "0x18101B7F0")]
		public void PileItem(int count, Sprite itemSprite)
		{
		}

		// Token: 0x06017D9D RID: 97693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D9D")]
		[Address(RVA = "0x101C1B0", Offset = "0x101ADB0", VA = "0x18101C1B0")]
		public ShopDetailItemPileView()
		{
		}

		// Token: 0x0401CCFC RID: 118012
		[Token(Token = "0x401CCFC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image[] _imageList;

		// Token: 0x0401CCFD RID: 118013
		[Token(Token = "0x401CCFD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _pileBoxPart;

		// Token: 0x0401CCFE RID: 118014
		[Token(Token = "0x401CCFE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _pileBoxImage;

		// Token: 0x0401CCFF RID: 118015
		[Token(Token = "0x401CCFF")]
		private const int MAX_COUNT = 6;

		// Token: 0x0401CD00 RID: 118016
		[Token(Token = "0x401CD00")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Vector2 DEFAULT_SIZE;

		// Token: 0x0401CD01 RID: 118017
		[Token(Token = "0x401CD01")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Vector2 LITTLE_SIZE;

		// Token: 0x0401CD02 RID: 118018
		[Token(Token = "0x401CD02")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Vector2[][] CONSTPOSLIST;

		// Token: 0x0401CD03 RID: 118019
		[Token(Token = "0x401CD03")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PileItem;

		// Token: 0x0401CD04 RID: 118020
		[Token(Token = "0x401CD04")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix1_PileItem;

		// Token: 0x0401CD05 RID: 118021
		[Token(Token = "0x401CD05")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
