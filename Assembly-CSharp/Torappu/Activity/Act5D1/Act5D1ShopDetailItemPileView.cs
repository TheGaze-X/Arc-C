using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act5D1
{
	// Token: 0x02007256 RID: 29270
	[Token(Token = "0x2007256")]
	public class Act5D1ShopDetailItemPileView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060297BD RID: 169917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60297BD")]
		[Address(RVA = "0x24E9590", Offset = "0x24E8190", VA = "0x1824E9590")]
		public void PileItem(int count, string itemId, ItemType itemType = ItemType.NONE)
		{
		}

		// Token: 0x060297BE RID: 169918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60297BE")]
		[Address(RVA = "0x24E91F0", Offset = "0x24E7DF0", VA = "0x1824E91F0")]
		public void PileItem(int count, Sprite itemSprite)
		{
		}

		// Token: 0x060297BF RID: 169919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60297BF")]
		[Address(RVA = "0x24E9BB0", Offset = "0x24E87B0", VA = "0x1824E9BB0")]
		public Act5D1ShopDetailItemPileView()
		{
		}

		// Token: 0x0403B457 RID: 242775
		[Token(Token = "0x403B457")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image[] _imageList;

		// Token: 0x0403B458 RID: 242776
		[Token(Token = "0x403B458")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _pileBoxPart;

		// Token: 0x0403B459 RID: 242777
		[Token(Token = "0x403B459")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _pileBoxImage;

		// Token: 0x0403B45A RID: 242778
		[Token(Token = "0x403B45A")]
		private const int MAX_COUNT = 6;

		// Token: 0x0403B45B RID: 242779
		[Token(Token = "0x403B45B")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Vector2 DEFAULT_SIZE;

		// Token: 0x0403B45C RID: 242780
		[Token(Token = "0x403B45C")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Vector2 LITTLE_SIZE;

		// Token: 0x0403B45D RID: 242781
		[Token(Token = "0x403B45D")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Vector2[][] CONSTPOSLIST;

		// Token: 0x0403B45E RID: 242782
		[Token(Token = "0x403B45E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PileItem;

		// Token: 0x0403B45F RID: 242783
		[Token(Token = "0x403B45F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix1_PileItem;

		// Token: 0x0403B460 RID: 242784
		[Token(Token = "0x403B460")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
