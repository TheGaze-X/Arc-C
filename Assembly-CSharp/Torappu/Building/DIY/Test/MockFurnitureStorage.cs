using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.DIY.Test
{
	// Token: 0x0200192F RID: 6447
	[Token(Token = "0x200192F")]
	public class MockFurnitureStorage : MonoBehaviour, IFurnitureStorage
	{
		// Token: 0x0600A24F RID: 41551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A24F")]
		[Address(RVA = "0x31D16C0", Offset = "0x31D02C0", VA = "0x1831D16C0", Slot = "4")]
		public void QueryDatas(Predicate<FurnitureStorageItem> filter, Action<FurnitureStorageItem> action)
		{
		}

		// Token: 0x0600A250 RID: 41552 RVA: 0x0003F3A8 File Offset: 0x0003D5A8
		[Token(Token = "0x600A250")]
		[Address(RVA = "0x31D1580", Offset = "0x31D0180", VA = "0x1831D1580", Slot = "5")]
		public FurnitureStorageItem QueryData(string furnitureId)
		{
			return default(FurnitureStorageItem);
		}

		// Token: 0x0600A251 RID: 41553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A251")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public MockFurnitureStorage()
		{
		}

		// Token: 0x04009895 RID: 39061
		[Token(Token = "0x4009895")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public MockFurnitureStorage.Item[] _items;

		// Token: 0x04009896 RID: 39062
		[Token(Token = "0x4009896")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		public bool _each99;

		// Token: 0x02001930 RID: 6448
		[Token(Token = "0x2001930")]
		[Serializable]
		public class Item
		{
			// Token: 0x0600A252 RID: 41554 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A252")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Item()
			{
			}

			// Token: 0x04009897 RID: 39063
			[Token(Token = "0x4009897")]
			[FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x04009898 RID: 39064
			[Token(Token = "0x4009898")]
			[FieldOffset(Offset = "0x18")]
			public int count;
		}
	}
}
