using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005FB3 RID: 24499
	[Token(Token = "0x2005FB3")]
	public class CharacterInfoSkillGroup : DataBinder<SkillGroupViewProperty>
	{
		// Token: 0x06023705 RID: 145157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023705")]
		[Address(RVA = "0x1E1FA00", Offset = "0x1E1E600", VA = "0x181E1FA00", Slot = "7")]
		public override void OnValueChanged(SkillGroupViewProperty property)
		{
		}

		// Token: 0x06023706 RID: 145158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023706")]
		[Address(RVA = "0x1E1FC90", Offset = "0x1E1E890", VA = "0x181E1FC90")]
		public CharacterInfoSkillGroup()
		{
		}

		// Token: 0x04030FD5 RID: 200661
		[Token(Token = "0x4030FD5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CharacterInfoSkillIconView[] _iconViews;

		// Token: 0x04030FD6 RID: 200662
		[Token(Token = "0x4030FD6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _skillAllLevel;

		// Token: 0x04030FD7 RID: 200663
		[Token(Token = "0x4030FD7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04030FD8 RID: 200664
		[Token(Token = "0x4030FD8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
