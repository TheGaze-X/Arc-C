using System;
using Il2CppDummyDll;
using Torappu.UI.CharacterCommon;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005FA9 RID: 24489
	[Token(Token = "0x2005FA9")]
	public class CharacterInfoRightProfTalentView : CharacterInfoRightProfObj
	{
		// Token: 0x060236D8 RID: 145112 RVA: 0x000C0DF8 File Offset: 0x000BEFF8
		[Token(Token = "0x60236D8")]
		[Address(RVA = "0x1E07770", Offset = "0x1E06370", VA = "0x181E07770", Slot = "4")]
		public override float GetAndApplyHeight()
		{
			return 0f;
		}

		// Token: 0x060236D9 RID: 145113 RVA: 0x000C0E10 File Offset: 0x000BF010
		[Token(Token = "0x60236D9")]
		[Address(RVA = "0x1E07700", Offset = "0x1E06300", VA = "0x181E07700")]
		public float CalcHeight()
		{
			return 0f;
		}

		// Token: 0x060236DA RID: 145114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236DA")]
		[Address(RVA = "0x1E078E0", Offset = "0x1E064E0", VA = "0x181E078E0")]
		public void Render(CharacterTalentViewModel viewModel)
		{
		}

		// Token: 0x060236DB RID: 145115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236DB")]
		[Address(RVA = "0x1E07B10", Offset = "0x1E06710", VA = "0x181E07B10")]
		public CharacterInfoRightProfTalentView()
		{
		}

		// Token: 0x04030F4B RID: 200523
		[Token(Token = "0x4030F4B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _talentName;

		// Token: 0x04030F4C RID: 200524
		[Token(Token = "0x4030F4C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textContent;

		// Token: 0x04030F4D RID: 200525
		[Token(Token = "0x4030F4D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CharacterInfoTalentUnlockView _unlockView;

		// Token: 0x04030F4E RID: 200526
		[Token(Token = "0x4030F4E")]
		[FieldOffset(Offset = "0x38")]
		public float cacheHeight;

		// Token: 0x04030F4F RID: 200527
		[Token(Token = "0x4030F4F")]
		[FieldOffset(Offset = "0x40")]
		private TextGenerator m_textGenerate;

		// Token: 0x04030F50 RID: 200528
		[Token(Token = "0x4030F50")]
		[FieldOffset(Offset = "0x48")]
		private CharacterTalentViewModel m_viewModel;

		// Token: 0x04030F51 RID: 200529
		[Token(Token = "0x4030F51")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetAndApplyHeight;

		// Token: 0x04030F52 RID: 200530
		[Token(Token = "0x4030F52")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CalcHeight;

		// Token: 0x04030F53 RID: 200531
		[Token(Token = "0x4030F53")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04030F54 RID: 200532
		[Token(Token = "0x4030F54")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
