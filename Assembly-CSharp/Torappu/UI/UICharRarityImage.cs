using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI
{
	// Token: 0x0200355E RID: 13662
	[Token(Token = "0x200355E")]
	[RequireComponent(typeof(Image))]
	public class UICharRarityImage : MonoBehaviour
	{
		// Token: 0x170033BC RID: 13244
		// (get) Token: 0x06015C54 RID: 89172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170033BC")]
		protected Image image
		{
			[Token(Token = "0x6015C54")]
			[Address(RVA = "0xE47E00", Offset = "0xE46A00", VA = "0x180E47E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x06015C55 RID: 89173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015C55")]
		[Address(RVA = "0xE47C60", Offset = "0xE46860", VA = "0x180E47C60")]
		public void Render(RarityRank rarity)
		{
		}

		// Token: 0x06015C56 RID: 89174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015C56")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public UICharRarityImage()
		{
		}

		// Token: 0x0401A2E7 RID: 107239
		[Token(Token = "0x401A2E7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UICharRarityImage.SpriteConfig[] _spriteConfigs;

		// Token: 0x0401A2E8 RID: 107240
		[Token(Token = "0x401A2E8")]
		[FieldOffset(Offset = "0x20")]
		private Image m_image;

		// Token: 0x0401A2E9 RID: 107241
		[Token(Token = "0x401A2E9")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isInited;

		// Token: 0x0401A2EA RID: 107242
		[Token(Token = "0x401A2EA")]
		[FieldOffset(Offset = "0x2C")]
		private RarityRank m_rarityCache;

		// Token: 0x0200355F RID: 13663
		[Token(Token = "0x200355F")]
		[Serializable]
		public struct SpriteConfig
		{
			// Token: 0x0401A2EB RID: 107243
			[Token(Token = "0x401A2EB")]
			[FieldOffset(Offset = "0x0")]
			public RarityRank rarity;

			// Token: 0x0401A2EC RID: 107244
			[Token(Token = "0x401A2EC")]
			[FieldOffset(Offset = "0x8")]
			public Sprite sprite;
		}
	}
}
