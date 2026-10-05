using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005FB1 RID: 24497
	[Token(Token = "0x2005FB1")]
	public class CharacterInfoSelectSkillItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060236FF RID: 145151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236FF")]
		[Address(RVA = "0x1E1F570", Offset = "0x1E1E170", VA = "0x181E1F570")]
		public void Render(SkillItemViewModel viewModel, int index, bool isSelected)
		{
		}

		// Token: 0x06023700 RID: 145152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023700")]
		[Address(RVA = "0x1E1F4F0", Offset = "0x1E1E0F0", VA = "0x181E1F4F0")]
		public void EventOnToggleButtonClick()
		{
		}

		// Token: 0x06023701 RID: 145153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023701")]
		[Address(RVA = "0x1E1F8A0", Offset = "0x1E1E4A0", VA = "0x181E1F8A0")]
		public CharacterInfoSelectSkillItemView()
		{
		}

		// Token: 0x04030FBD RID: 200637
		[Token(Token = "0x4030FBD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelEnable;

		// Token: 0x04030FBE RID: 200638
		[Token(Token = "0x4030FBE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x04030FBF RID: 200639
		[Token(Token = "0x4030FBF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelEmpty;

		// Token: 0x04030FC0 RID: 200640
		[Token(Token = "0x4030FC0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imageSkillIcon;

		// Token: 0x04030FC1 RID: 200641
		[Token(Token = "0x4030FC1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textCost;

		// Token: 0x04030FC2 RID: 200642
		[Token(Token = "0x4030FC2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textName;

		// Token: 0x04030FC3 RID: 200643
		[Token(Token = "0x4030FC3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UISkillTagGroup _tagGroup;

		// Token: 0x04030FC4 RID: 200644
		[Token(Token = "0x4030FC4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x04030FC5 RID: 200645
		[Token(Token = "0x4030FC5")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIFontSizeVerticalFitter _descFitter;

		// Token: 0x04030FC6 RID: 200646
		[Token(Token = "0x4030FC6")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private TwoStateToggle _selectToggle;

		// Token: 0x04030FC7 RID: 200647
		[Token(Token = "0x4030FC7")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _textUnlockCond;

		// Token: 0x04030FC8 RID: 200648
		[Token(Token = "0x4030FC8")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _skillLvl;

		// Token: 0x04030FC9 RID: 200649
		[Token(Token = "0x4030FC9")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image _skillSpeicializedImage;

		// Token: 0x04030FCA RID: 200650
		[Token(Token = "0x4030FCA")]
		[FieldOffset(Offset = "0x80")]
		private int m_indexCache;

		// Token: 0x04030FCB RID: 200651
		[Token(Token = "0x4030FCB")]
		[FieldOffset(Offset = "0x88")]
		private string m_skillIdCache;

		// Token: 0x04030FCC RID: 200652
		[Token(Token = "0x4030FCC")]
		[FieldOffset(Offset = "0x90")]
		[NonSerialized]
		public Action<int> onToggleClick;

		// Token: 0x04030FCD RID: 200653
		[Token(Token = "0x4030FCD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04030FCE RID: 200654
		[Token(Token = "0x4030FCE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnToggleButtonClick;

		// Token: 0x04030FCF RID: 200655
		[Token(Token = "0x4030FCF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
