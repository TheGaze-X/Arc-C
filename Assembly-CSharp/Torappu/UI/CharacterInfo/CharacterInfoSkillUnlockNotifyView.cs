using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F7C RID: 24444
	[Token(Token = "0x2005F7C")]
	public class CharacterInfoSkillUnlockNotifyView : UINotifyView<CharacterInfoSkillUnlockNotifyView.Param>
	{
		// Token: 0x060235F5 RID: 144885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60235F5")]
		[Address(RVA = "0x1E0ACC0", Offset = "0x1E098C0", VA = "0x181E0ACC0", Slot = "9")]
		protected override void Render(CharacterInfoSkillUnlockNotifyView.Param param)
		{
		}

		// Token: 0x060235F6 RID: 144886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60235F6")]
		[Address(RVA = "0x1E0AF90", Offset = "0x1E09B90", VA = "0x181E0AF90")]
		private Sprite _LoadSkillIcon(SkillData skillData)
		{
			return null;
		}

		// Token: 0x060235F7 RID: 144887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60235F7")]
		[Address(RVA = "0x1E0B120", Offset = "0x1E09D20", VA = "0x181E0B120")]
		public CharacterInfoSkillUnlockNotifyView()
		{
		}

		// Token: 0x04030DB2 RID: 200114
		[Token(Token = "0x4030DB2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _skillIcon;

		// Token: 0x04030DB3 RID: 200115
		[Token(Token = "0x4030DB3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x04030DB4 RID: 200116
		[Token(Token = "0x4030DB4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textName;

		// Token: 0x04030DB5 RID: 200117
		[Token(Token = "0x4030DB5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04030DB6 RID: 200118
		[Token(Token = "0x4030DB6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadSkillIcon;

		// Token: 0x04030DB7 RID: 200119
		[Token(Token = "0x4030DB7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005F7D RID: 24445
		[Token(Token = "0x2005F7D")]
		public class Param : NotifyViewParam
		{
			// Token: 0x060235F8 RID: 144888 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60235F8")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public Param()
			{
			}

			// Token: 0x04030DB8 RID: 200120
			[Token(Token = "0x4030DB8")]
			[FieldOffset(Offset = "0x10")]
			public string skillId;
		}
	}
}
