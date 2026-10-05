using System;
using Il2CppDummyDll;
using Torappu.UI.CharacterCommon;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005FC6 RID: 24518
	[Token(Token = "0x2005FC6")]
	public class CharacterInfoTalentItemView : MonoBehaviour
	{
		// Token: 0x0602374F RID: 145231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602374F")]
		[Address(RVA = "0x1E21DA0", Offset = "0x1E209A0", VA = "0x181E21DA0")]
		public void InitText(TalentUnlockType unlockType, CharacterData.UnlockCondition unlockCondition)
		{
		}

		// Token: 0x170053AB RID: 21419
		// (get) Token: 0x06023750 RID: 145232 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06023751 RID: 145233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170053AB")]
		public string content
		{
			[Token(Token = "0x6023750")]
			[Address(RVA = "0xD23170", Offset = "0xD21D70", VA = "0x180D23170")]
			get
			{
				return null;
			}
			[Token(Token = "0x6023751")]
			[Address(RVA = "0xD231C0", Offset = "0xD21DC0", VA = "0x180D231C0")]
			set
			{
			}
		}

		// Token: 0x06023752 RID: 145234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023752")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public CharacterInfoTalentItemView()
		{
		}

		// Token: 0x040310A6 RID: 200870
		[Token(Token = "0x40310A6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textContent;

		// Token: 0x040310A7 RID: 200871
		[Token(Token = "0x40310A7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _lockIcon;

		// Token: 0x040310A8 RID: 200872
		[Token(Token = "0x40310A8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Sprite[] _unlockIcon;

		// Token: 0x040310A9 RID: 200873
		[Token(Token = "0x40310A9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _backImg;

		// Token: 0x040310AA RID: 200874
		[Token(Token = "0x40310AA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _backLockedImg;

		// Token: 0x040310AB RID: 200875
		[Token(Token = "0x40310AB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIColorGraphic _alpha;

		// Token: 0x040310AC RID: 200876
		[Token(Token = "0x40310AC")]
		private const int NEW_ONE = 0;

		// Token: 0x040310AD RID: 200877
		[Token(Token = "0x40310AD")]
		private const int NEW_TWO = 1;

		// Token: 0x040310AE RID: 200878
		[Token(Token = "0x40310AE")]
		private const int UPDATE_ONE = 2;

		// Token: 0x040310AF RID: 200879
		[Token(Token = "0x40310AF")]
		private const int UPDATE_TWO = 3;

		// Token: 0x040310B0 RID: 200880
		[Token(Token = "0x40310B0")]
		private const int LVL = 4;

		// Token: 0x040310B1 RID: 200881
		[Token(Token = "0x40310B1")]
		private const float LOCKED_ALPHA = 0.2f;
	}
}
