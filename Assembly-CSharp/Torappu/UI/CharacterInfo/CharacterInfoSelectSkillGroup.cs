using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005FB0 RID: 24496
	[Token(Token = "0x2005FB0")]
	public class CharacterInfoSelectSkillGroup : DataBinder<SkillGroupViewProperty>
	{
		// Token: 0x060236FB RID: 145147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236FB")]
		[Address(RVA = "0x1E1F2D0", Offset = "0x1E1DED0", VA = "0x181E1F2D0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060236FC RID: 145148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236FC")]
		[Address(RVA = "0x1E1EF40", Offset = "0x1E1DB40", VA = "0x181E1EF40", Slot = "7")]
		public override void OnValueChanged(SkillGroupViewProperty property)
		{
		}

		// Token: 0x060236FD RID: 145149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236FD")]
		[Address(RVA = "0x1E1F3F0", Offset = "0x1E1DFF0", VA = "0x181E1F3F0")]
		private void _OnSkillToggleClick(int skillIndex)
		{
		}

		// Token: 0x060236FE RID: 145150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236FE")]
		[Address(RVA = "0x1E1F480", Offset = "0x1E1E080", VA = "0x181E1F480")]
		public CharacterInfoSelectSkillGroup()
		{
		}

		// Token: 0x04030FB3 RID: 200627
		[Token(Token = "0x4030FB3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CharacterInfoSelectSkillView[] _skillViews;

		// Token: 0x04030FB4 RID: 200628
		[Token(Token = "0x4030FB4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIIntEvent _eventSkillToggleClick;

		// Token: 0x04030FB5 RID: 200629
		[Token(Token = "0x4030FB5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _skillLevelSolid;

		// Token: 0x04030FB6 RID: 200630
		[Token(Token = "0x4030FB6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _skillLevelImage;

		// Token: 0x04030FB7 RID: 200631
		[Token(Token = "0x4030FB7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _pageLvlUpBtn;

		// Token: 0x04030FB8 RID: 200632
		[Token(Token = "0x4030FB8")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isInited;

		// Token: 0x04030FB9 RID: 200633
		[Token(Token = "0x4030FB9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04030FBA RID: 200634
		[Token(Token = "0x4030FBA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04030FBB RID: 200635
		[Token(Token = "0x4030FBB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnSkillToggleClick;

		// Token: 0x04030FBC RID: 200636
		[Token(Token = "0x4030FBC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
