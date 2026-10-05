using System;
using Il2CppDummyDll;
using Torappu.UI.CharacterCommon;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005FC3 RID: 24515
	[Token(Token = "0x2005FC3")]
	public class CharacterInfoTalentContentItem : MonoBehaviour
	{
		// Token: 0x06023747 RID: 145223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023747")]
		[Address(RVA = "0x1E21890", Offset = "0x1E20490", VA = "0x181E21890")]
		public void Render(CharacterTalentViewModel viewModel)
		{
		}

		// Token: 0x06023748 RID: 145224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023748")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public CharacterInfoTalentContentItem()
		{
		}

		// Token: 0x04031096 RID: 200854
		[Token(Token = "0x4031096")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textName;

		// Token: 0x04031097 RID: 200855
		[Token(Token = "0x4031097")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textContent;

		// Token: 0x04031098 RID: 200856
		[Token(Token = "0x4031098")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CharacterInfoTalentUnlockView _unlockView;

		// Token: 0x04031099 RID: 200857
		[Token(Token = "0x4031099")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _useDarkCommentText;
	}
}
