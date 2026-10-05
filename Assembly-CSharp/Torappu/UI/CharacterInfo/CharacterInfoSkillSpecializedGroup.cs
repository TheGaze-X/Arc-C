using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005FB5 RID: 24501
	[Token(Token = "0x2005FB5")]
	public class CharacterInfoSkillSpecializedGroup : DataBinder<SkillGroupViewProperty>
	{
		// Token: 0x06023709 RID: 145161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023709")]
		[Address(RVA = "0x1E20AD0", Offset = "0x1E1F6D0", VA = "0x181E20AD0", Slot = "7")]
		public override void OnValueChanged(SkillGroupViewProperty property)
		{
		}

		// Token: 0x0602370A RID: 145162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602370A")]
		[Address(RVA = "0x1E20DC0", Offset = "0x1E1F9C0", VA = "0x181E20DC0")]
		private void _OnSkillToggleClick(int skillIndex)
		{
		}

		// Token: 0x0602370B RID: 145163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602370B")]
		[Address(RVA = "0x1E20E50", Offset = "0x1E1FA50", VA = "0x181E20E50")]
		public CharacterInfoSkillSpecializedGroup()
		{
		}

		// Token: 0x04030FE7 RID: 200679
		[Token(Token = "0x4030FE7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CharacterSelectSpecializedSkillView[] _skillViews;

		// Token: 0x04030FE8 RID: 200680
		[Token(Token = "0x4030FE8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIIntEvent _eventSkillToggleClick;

		// Token: 0x04030FE9 RID: 200681
		[Token(Token = "0x4030FE9")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isInited;

		// Token: 0x04030FEA RID: 200682
		[Token(Token = "0x4030FEA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04030FEB RID: 200683
		[Token(Token = "0x4030FEB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnSkillToggleClick;

		// Token: 0x04030FEC RID: 200684
		[Token(Token = "0x4030FEC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
