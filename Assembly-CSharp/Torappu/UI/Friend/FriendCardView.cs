using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.UI.CharacterInfo;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DA8 RID: 19880
	[Token(Token = "0x2004DA8")]
	public class FriendCardView : MonoBehaviour
	{
		// Token: 0x0601DBB7 RID: 121783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DBB7")]
		[Address(RVA = "0x173F7C0", Offset = "0x173E3C0", VA = "0x18173F7C0")]
		private void Start()
		{
		}

		// Token: 0x0601DBB8 RID: 121784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DBB8")]
		[Address(RVA = "0x173F4B0", Offset = "0x173E0B0", VA = "0x18173F4B0")]
		public void ApplyData(SharedCharData assistFriend, CharacterCardViewModel cardViewModel)
		{
		}

		// Token: 0x0601DBB9 RID: 121785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DBB9")]
		[Address(RVA = "0x173F850", Offset = "0x173E450", VA = "0x18173F850")]
		private IEnumerator UpdateLayout(RectTransform rect)
		{
			return null;
		}

		// Token: 0x0601DBBA RID: 121786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DBBA")]
		[Address(RVA = "0x173F8D0", Offset = "0x173E4D0", VA = "0x18173F8D0")]
		private UICharacterCardPanel _EnsureCharCard()
		{
			return null;
		}

		// Token: 0x0601DBBB RID: 121787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DBBB")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public FriendCardView()
		{
		}

		// Token: 0x0402751B RID: 161051
		[Token(Token = "0x402751B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UICharacterCardPanel _charCardPrefab;

		// Token: 0x0402751C RID: 161052
		[Token(Token = "0x402751C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _charCardContainer;

		// Token: 0x0402751D RID: 161053
		[Token(Token = "0x402751D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _charCardScale;

		// Token: 0x0402751E RID: 161054
		[Token(Token = "0x402751E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _potentialIcon;

		// Token: 0x0402751F RID: 161055
		[Token(Token = "0x402751F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CharacterInfoSelectSkillItemView _skillItem;

		// Token: 0x04027520 RID: 161056
		[Token(Token = "0x4027520")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _charEnable;

		// Token: 0x04027521 RID: 161057
		[Token(Token = "0x4027521")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _charUnable;

		// Token: 0x04027522 RID: 161058
		[Token(Token = "0x4027522")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _skillEnable;

		// Token: 0x04027523 RID: 161059
		[Token(Token = "0x4027523")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _skillUnable;

		// Token: 0x04027524 RID: 161060
		[Token(Token = "0x4027524")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RectTransform _layout;

		// Token: 0x04027525 RID: 161061
		[Token(Token = "0x4027525")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private int _index;

		// Token: 0x04027526 RID: 161062
		[Token(Token = "0x4027526")]
		[FieldOffset(Offset = "0x70")]
		private UICharacterCardPanel m_charCardInst;
	}
}
