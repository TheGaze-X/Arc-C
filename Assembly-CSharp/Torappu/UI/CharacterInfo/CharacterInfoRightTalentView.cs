using System;
using Il2CppDummyDll;
using Torappu.UI.CharacterCommon;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005FA1 RID: 24481
	[Token(Token = "0x2005FA1")]
	public class CharacterInfoRightTalentView : MonoBehaviour
	{
		// Token: 0x060236B3 RID: 145075 RVA: 0x000C0CD8 File Offset: 0x000BEED8
		[Token(Token = "0x60236B3")]
		[Address(RVA = "0x1E0AAD0", Offset = "0x1E096D0", VA = "0x181E0AAD0")]
		public float CalcHeight()
		{
			return 0f;
		}

		// Token: 0x060236B4 RID: 145076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236B4")]
		[Address(RVA = "0x1E0AAF0", Offset = "0x1E096F0", VA = "0x181E0AAF0")]
		public void Render(CharacterTalentViewModel viewModel)
		{
		}

		// Token: 0x060236B5 RID: 145077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236B5")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public CharacterInfoRightTalentView()
		{
		}

		// Token: 0x04030F01 RID: 200449
		[Token(Token = "0x4030F01")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _talentName;

		// Token: 0x04030F02 RID: 200450
		[Token(Token = "0x4030F02")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textContent;

		// Token: 0x04030F03 RID: 200451
		[Token(Token = "0x4030F03")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CharacterInfoTalentUnlockView _unlockView;

		// Token: 0x04030F04 RID: 200452
		[Token(Token = "0x4030F04")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _initHeight;

		// Token: 0x04030F05 RID: 200453
		[Token(Token = "0x4030F05")]
		[FieldOffset(Offset = "0x38")]
		private CharacterTalentViewModel m_viewModel;

		// Token: 0x04030F06 RID: 200454
		[Token(Token = "0x4030F06")]
		[FieldOffset(Offset = "0x68")]
		private TextGenerator m_textGenerate;
	}
}
