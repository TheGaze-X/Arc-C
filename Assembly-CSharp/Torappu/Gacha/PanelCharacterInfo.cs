using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Gacha
{
	// Token: 0x02001662 RID: 5730
	[Token(Token = "0x2001662")]
	public class PanelCharacterInfo : MonoBehaviour
	{
		// Token: 0x06008207 RID: 33287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008207")]
		[Address(RVA = "0x2B09EA0", Offset = "0x2B08AA0", VA = "0x182B09EA0")]
		public void SetData(CharacterData character, EvolvePhase evolvePhase, ItemBundle[] itemList, bool isNew, ProfessionSpriteHub professionHub)
		{
		}

		// Token: 0x06008208 RID: 33288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008208")]
		[Address(RVA = "0x2B0A240", Offset = "0x2B08E40", VA = "0x182B0A240")]
		private Sprite _GetProfessionSprite(ProfessionCategory profession, ProfessionSpriteHub professionHub)
		{
			return null;
		}

		// Token: 0x06008209 RID: 33289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008209")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public PanelCharacterInfo()
		{
		}

		// Token: 0x04008415 RID: 33813
		[Token(Token = "0x4008415")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _nameCn;

		// Token: 0x04008416 RID: 33814
		[Token(Token = "0x4008416")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _nameEn;

		// Token: 0x04008417 RID: 33815
		[Token(Token = "0x4008417")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _newImage;

		// Token: 0x04008418 RID: 33816
		[Token(Token = "0x4008418")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _professionImage;

		// Token: 0x04008419 RID: 33817
		[Token(Token = "0x4008419")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private PanelItemInfo _itemInfo;

		// Token: 0x0400841A RID: 33818
		[Token(Token = "0x400841A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _gridContainer;

		// Token: 0x02001663 RID: 5731
		[Token(Token = "0x2001663")]
		[Serializable]
		public struct ProfessionSpritePair
		{
			// Token: 0x0400841B RID: 33819
			[Token(Token = "0x400841B")]
			[FieldOffset(Offset = "0x0")]
			public ProfessionCategory profession;

			// Token: 0x0400841C RID: 33820
			[Token(Token = "0x400841C")]
			[FieldOffset(Offset = "0x8")]
			public Sprite sprite;
		}
	}
}
