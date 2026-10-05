using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.UI
{
	// Token: 0x02001B60 RID: 7008
	[Token(Token = "0x2001B60")]
	public class UIFurnitureIconSpriteHub : MonoISpriteHub
	{
		// Token: 0x0600AFED RID: 45037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AFED")]
		[Address(RVA = "0x32B9DF0", Offset = "0x32B89F0", VA = "0x1832B9DF0")]
		public Sprite GetFurnitureIconImage(string furnitureId)
		{
			return null;
		}

		// Token: 0x0600AFEE RID: 45038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFEE")]
		[Address(RVA = "0x5B5830", Offset = "0x5B4430", VA = "0x1805B5830")]
		public UIFurnitureIconSpriteHub()
		{
		}

		// Token: 0x0400AA33 RID: 43571
		[Token(Token = "0x400AA33")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<UIFurnitureIconSpriteHub.Item> _items;

		// Token: 0x0400AA34 RID: 43572
		[Token(Token = "0x400AA34")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIFurnitureIconSpriteHub _nextHub;

		// Token: 0x0400AA35 RID: 43573
		[Token(Token = "0x400AA35")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Sprite _defaultIcon;

		// Token: 0x02001B61 RID: 7009
		[Token(Token = "0x2001B61")]
		[Serializable]
		public class Item
		{
			// Token: 0x0600AFEF RID: 45039 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AFEF")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Item()
			{
			}

			// Token: 0x0400AA36 RID: 43574
			[Token(Token = "0x400AA36")]
			[FieldOffset(Offset = "0x10")]
			public string furnitureId;

			// Token: 0x0400AA37 RID: 43575
			[Token(Token = "0x400AA37")]
			[FieldOffset(Offset = "0x18")]
			public Sprite icon;
		}
	}
}
