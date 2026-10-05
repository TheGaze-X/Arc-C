using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.UI
{
	// Token: 0x02001B6E RID: 7022
	[Token(Token = "0x2001B6E")]
	public class UIRoomThemeSpriteHub : MonoBehaviour
	{
		// Token: 0x0600B007 RID: 45063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B007")]
		[Address(RVA = "0x32BA6C0", Offset = "0x32B92C0", VA = "0x1832BA6C0")]
		public Sprite GetThemeBGImage(string themeId, int level)
		{
			return null;
		}

		// Token: 0x0600B008 RID: 45064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B008")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public UIRoomThemeSpriteHub()
		{
		}

		// Token: 0x0400AA53 RID: 43603
		[Token(Token = "0x400AA53")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<UIRoomThemeSpriteHub.Item> _items;

		// Token: 0x0400AA54 RID: 43604
		[Token(Token = "0x400AA54")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite _defaultImage;

		// Token: 0x02001B6F RID: 7023
		[Token(Token = "0x2001B6F")]
		[Serializable]
		public class Item
		{
			// Token: 0x0600B009 RID: 45065 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B009")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Item()
			{
			}

			// Token: 0x0400AA55 RID: 43605
			[Token(Token = "0x400AA55")]
			[FieldOffset(Offset = "0x10")]
			public string themeId;

			// Token: 0x0400AA56 RID: 43606
			[Token(Token = "0x400AA56")]
			[FieldOffset(Offset = "0x18")]
			public int level;

			// Token: 0x0400AA57 RID: 43607
			[Token(Token = "0x400AA57")]
			[FieldOffset(Offset = "0x20")]
			public Sprite bgImage;
		}
	}
}
