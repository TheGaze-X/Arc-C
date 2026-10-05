using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F7E RID: 24446
	[Token(Token = "0x2005F7E")]
	public class CharacterInfoTalentUnlockNotifyView : UINotifyView<CharacterInfoTalentUnlockNotifyView.Param>
	{
		// Token: 0x060235F9 RID: 144889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60235F9")]
		[Address(RVA = "0x1E0B190", Offset = "0x1E09D90", VA = "0x181E0B190", Slot = "9")]
		protected override void Render(CharacterInfoTalentUnlockNotifyView.Param param)
		{
		}

		// Token: 0x060235FA RID: 144890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60235FA")]
		[Address(RVA = "0x1E0B2A0", Offset = "0x1E09EA0", VA = "0x181E0B2A0")]
		public CharacterInfoTalentUnlockNotifyView()
		{
		}

		// Token: 0x04030DB9 RID: 200121
		[Token(Token = "0x4030DB9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x04030DBA RID: 200122
		[Token(Token = "0x4030DBA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textTalentName;

		// Token: 0x04030DBB RID: 200123
		[Token(Token = "0x4030DBB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04030DBC RID: 200124
		[Token(Token = "0x4030DBC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005F7F RID: 24447
		[Token(Token = "0x2005F7F")]
		public class Param : NotifyViewParam
		{
			// Token: 0x060235FB RID: 144891 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60235FB")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public Param()
			{
			}

			// Token: 0x04030DBD RID: 200125
			[Token(Token = "0x4030DBD")]
			[FieldOffset(Offset = "0x10")]
			public TalentData talentData;
		}
	}
}
