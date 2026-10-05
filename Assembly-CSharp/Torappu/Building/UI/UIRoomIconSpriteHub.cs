using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.UI
{
	// Token: 0x02001B66 RID: 7014
	[Token(Token = "0x2001B66")]
	public class UIRoomIconSpriteHub : MonoBehaviour
	{
		// Token: 0x0600AFF7 RID: 45047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AFF7")]
		[Address(RVA = "0x32BA3E0", Offset = "0x32B8FE0", VA = "0x1832BA3E0")]
		public Sprite GetIconByRoomType(BuildingData.RoomType roomType)
		{
			return null;
		}

		// Token: 0x0600AFF8 RID: 45048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AFF8")]
		[Address(RVA = "0x32BA2F0", Offset = "0x32B8EF0", VA = "0x1832BA2F0")]
		public Sprite GetBGByRoomType(BuildingData.RoomType roomType)
		{
			return null;
		}

		// Token: 0x0600AFF9 RID: 45049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AFF9")]
		[Address(RVA = "0x32BA4D0", Offset = "0x32B90D0", VA = "0x1832BA4D0")]
		public Sprite GetLevelupBGByRoomType(BuildingData.RoomType roomType)
		{
			return null;
		}

		// Token: 0x0600AFFA RID: 45050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFFA")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public UIRoomIconSpriteHub()
		{
		}

		// Token: 0x0400AA46 RID: 43590
		[Token(Token = "0x400AA46")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<UIRoomIconSpriteHub.UIRoomIconSpriteConfig> _configs;

		// Token: 0x02001B67 RID: 7015
		[Token(Token = "0x2001B67")]
		[Serializable]
		public class UIRoomIconSpriteConfig
		{
			// Token: 0x0600AFFB RID: 45051 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AFFB")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public UIRoomIconSpriteConfig()
			{
			}

			// Token: 0x0400AA47 RID: 43591
			[Token(Token = "0x400AA47")]
			[FieldOffset(Offset = "0x10")]
			public BuildingData.RoomType roomType;

			// Token: 0x0400AA48 RID: 43592
			[Token(Token = "0x400AA48")]
			[FieldOffset(Offset = "0x18")]
			public Sprite iconSprite;

			// Token: 0x0400AA49 RID: 43593
			[Token(Token = "0x400AA49")]
			[FieldOffset(Offset = "0x20")]
			public Sprite bgSprite;

			// Token: 0x0400AA4A RID: 43594
			[Token(Token = "0x400AA4A")]
			[FieldOffset(Offset = "0x28")]
			public Sprite levelupBgSprite;
		}
	}
}
