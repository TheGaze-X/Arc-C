using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x020019D9 RID: 6617
	[Token(Token = "0x20019D9")]
	public class UIDIYFurnitureTypeIconHub : MonoISpriteHub
	{
		// Token: 0x0600A63A RID: 42554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A63A")]
		[Address(RVA = "0x3227EC0", Offset = "0x3226AC0", VA = "0x183227EC0")]
		public Sprite GetIcon(BuildingData.FurnitureType furnitureType)
		{
			return null;
		}

		// Token: 0x0600A63B RID: 42555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A63B")]
		[Address(RVA = "0x3227E50", Offset = "0x3226A50", VA = "0x183227E50")]
		public Sprite GetWhiteIcon(BuildingData.FurnitureType furnitureType)
		{
			return null;
		}

		// Token: 0x0600A63C RID: 42556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A63C")]
		[Address(RVA = "0x5B5830", Offset = "0x5B4430", VA = "0x1805B5830")]
		public UIDIYFurnitureTypeIconHub()
		{
		}

		// Token: 0x04009E29 RID: 40489
		[Token(Token = "0x4009E29")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIDIYFurnitureTypeIconHub.Entry[] _entries;

		// Token: 0x04009E2A RID: 40490
		[Token(Token = "0x4009E2A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite _defaultIcon;

		// Token: 0x020019DA RID: 6618
		[Token(Token = "0x20019DA")]
		[Serializable]
		public class Entry
		{
			// Token: 0x0600A63D RID: 42557 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A63D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Entry()
			{
			}

			// Token: 0x04009E2B RID: 40491
			[Token(Token = "0x4009E2B")]
			[FieldOffset(Offset = "0x10")]
			public BuildingData.FurnitureType furnitureType;

			// Token: 0x04009E2C RID: 40492
			[Token(Token = "0x4009E2C")]
			[FieldOffset(Offset = "0x18")]
			public Sprite icon;

			// Token: 0x04009E2D RID: 40493
			[Token(Token = "0x4009E2D")]
			[FieldOffset(Offset = "0x20")]
			public Sprite whiteIcon;
		}
	}
}
