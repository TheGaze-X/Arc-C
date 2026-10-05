using System;
using Il2CppDummyDll;
using Torappu.UI.CharacterCommon;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005FC7 RID: 24519
	[Token(Token = "0x2005FC7")]
	public class CharacterInfoTalentUnlockView : MonoBehaviour
	{
		// Token: 0x06023753 RID: 145235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023753")]
		[Address(RVA = "0x1E21F30", Offset = "0x1E20B30", VA = "0x181E21F30")]
		public void InitText(TalentUnlockType unlockType, CharacterData.UnlockCondition unlockCondition)
		{
		}

		// Token: 0x06023754 RID: 145236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023754")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public CharacterInfoTalentUnlockView()
		{
		}

		// Token: 0x040310B2 RID: 200882
		[Token(Token = "0x40310B2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _detail;

		// Token: 0x040310B3 RID: 200883
		[Token(Token = "0x40310B3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _icon;

		// Token: 0x040310B4 RID: 200884
		[Token(Token = "0x40310B4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Sprite[] _unlockIcon;

		// Token: 0x040310B5 RID: 200885
		[Token(Token = "0x40310B5")]
		private const int NEW_ONE = 0;

		// Token: 0x040310B6 RID: 200886
		[Token(Token = "0x40310B6")]
		private const int NEW_TWO = 1;

		// Token: 0x040310B7 RID: 200887
		[Token(Token = "0x40310B7")]
		private const int UPDATE_ONE = 2;

		// Token: 0x040310B8 RID: 200888
		[Token(Token = "0x40310B8")]
		private const int UPDATE_TWO = 3;

		// Token: 0x040310B9 RID: 200889
		[Token(Token = "0x40310B9")]
		private const int LVL = 4;
	}
}
