using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F8E RID: 24462
	[Token(Token = "0x2005F8E")]
	public class CharacterInfoPotentialLevelUpItem : MonoBehaviour
	{
		// Token: 0x1700539A RID: 21402
		// (get) Token: 0x0602363B RID: 144955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700539A")]
		public string itemName
		{
			[Token(Token = "0x602363B")]
			[Address(RVA = "0x1E01A30", Offset = "0x1E00630", VA = "0x181E01A30")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602363C RID: 144956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602363C")]
		[Address(RVA = "0x1E014F0", Offset = "0x1E000F0", VA = "0x181E014F0")]
		public void Render(CharacterInfoPotentialViewModel.PotentialItemViewModel model)
		{
		}

		// Token: 0x0602363D RID: 144957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602363D")]
		[Address(RVA = "0x1E01710", Offset = "0x1E00310", VA = "0x181E01710")]
		public void SetIndex(int index)
		{
		}

		// Token: 0x0602363E RID: 144958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602363E")]
		[Address(RVA = "0x1E014A0", Offset = "0x1E000A0", VA = "0x181E014A0")]
		public void OnClick()
		{
		}

		// Token: 0x0602363F RID: 144959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602363F")]
		[Address(RVA = "0x1E01750", Offset = "0x1E00350", VA = "0x181E01750")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06023640 RID: 144960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023640")]
		[Address(RVA = "0x1E01980", Offset = "0x1E00580", VA = "0x181E01980")]
		private void _OnItemCardClicked(int index)
		{
		}

		// Token: 0x06023641 RID: 144961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023641")]
		[Address(RVA = "0x156D000", Offset = "0x156BC00", VA = "0x18156D000")]
		public CharacterInfoPotentialLevelUpItem()
		{
		}

		// Token: 0x04030E30 RID: 200240
		[Token(Token = "0x4030E30")]
		private const string ITEM_COUNT_FORMAT = "{0}/{1}";

		// Token: 0x04030E31 RID: 200241
		[Token(Token = "0x4030E31")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _itemCardContainer;

		// Token: 0x04030E32 RID: 200242
		[Token(Token = "0x4030E32")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _itemCardScale;

		// Token: 0x04030E33 RID: 200243
		[Token(Token = "0x4030E33")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _selected;

		// Token: 0x04030E34 RID: 200244
		[Token(Token = "0x4030E34")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _itemName;

		// Token: 0x04030E35 RID: 200245
		[Token(Token = "0x4030E35")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textCount;

		// Token: 0x04030E36 RID: 200246
		[Token(Token = "0x4030E36")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIIntEvent _onClick;

		// Token: 0x04030E37 RID: 200247
		[Token(Token = "0x4030E37")]
		[FieldOffset(Offset = "0x48")]
		private int m_index;

		// Token: 0x04030E38 RID: 200248
		[Token(Token = "0x4030E38")]
		[FieldOffset(Offset = "0x4C")]
		private bool m_isInited;

		// Token: 0x04030E39 RID: 200249
		[Token(Token = "0x4030E39")]
		[FieldOffset(Offset = "0x50")]
		private UIItemCard m_itemCard;

		// Token: 0x04030E3A RID: 200250
		[Token(Token = "0x4030E3A")]
		[FieldOffset(Offset = "0x58")]
		[NonSerialized]
		public UIItemViewModel itemViewModel;

		// Token: 0x04030E3B RID: 200251
		[Token(Token = "0x4030E3B")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		public RequireViewModel requireItem;
	}
}
