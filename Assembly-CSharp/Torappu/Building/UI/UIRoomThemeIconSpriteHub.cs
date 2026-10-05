using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.UI
{
	// Token: 0x02001B6B RID: 7019
	[Token(Token = "0x2001B6B")]
	public class UIRoomThemeIconSpriteHub : MonoBehaviour
	{
		// Token: 0x0600B002 RID: 45058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B002")]
		[Address(RVA = "0x32BA5C0", Offset = "0x32B91C0", VA = "0x1832BA5C0")]
		public Sprite GetThemeIconImage(string themeId)
		{
			return null;
		}

		// Token: 0x0600B003 RID: 45059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B003")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public UIRoomThemeIconSpriteHub()
		{
		}

		// Token: 0x0400AA4E RID: 43598
		[Token(Token = "0x400AA4E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<UIRoomThemeIconSpriteHub.Item> _items;

		// Token: 0x0400AA4F RID: 43599
		[Token(Token = "0x400AA4F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite _defaultImage;

		// Token: 0x02001B6C RID: 7020
		[Token(Token = "0x2001B6C")]
		[Serializable]
		public class Item
		{
			// Token: 0x0600B004 RID: 45060 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B004")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Item()
			{
			}

			// Token: 0x0400AA50 RID: 43600
			[Token(Token = "0x400AA50")]
			[FieldOffset(Offset = "0x10")]
			public string themeId;

			// Token: 0x0400AA51 RID: 43601
			[Token(Token = "0x400AA51")]
			[FieldOffset(Offset = "0x18")]
			public Sprite iconImage;
		}
	}
}
