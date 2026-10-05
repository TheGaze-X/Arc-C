using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020054A2 RID: 21666
	[Token(Token = "0x20054A2")]
	public class RoguelikeCharSelectSkillView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004ABB RID: 19131
		// (get) Token: 0x0601FE11 RID: 130577 RVA: 0x000B3A90 File Offset: 0x000B1C90
		// (set) Token: 0x0601FE12 RID: 130578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004ABB")]
		public bool showDefaultSkillTag
		{
			[Token(Token = "0x601FE11")]
			[Address(RVA = "0x1A01B60", Offset = "0x1A00760", VA = "0x181A01B60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601FE12")]
			[Address(RVA = "0x1A01C50", Offset = "0x1A00850", VA = "0x181A01C50")]
			set
			{
			}
		}

		// Token: 0x17004ABC RID: 19132
		// (set) Token: 0x0601FE13 RID: 130579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004ABC")]
		public Action<string> onSkillClicked
		{
			[Token(Token = "0x601FE13")]
			[Address(RVA = "0x1A01BD0", Offset = "0x1A007D0", VA = "0x181A01BD0")]
			set
			{
			}
		}

		// Token: 0x0601FE14 RID: 130580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE14")]
		[Address(RVA = "0x1A01110", Offset = "0x19FFD10", VA = "0x181A01110")]
		public void Render(RoguelikeCharSelectSkillItemViewModel viewModel, bool isSelected)
		{
		}

		// Token: 0x0601FE15 RID: 130581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE15")]
		[Address(RVA = "0x1A01090", Offset = "0x19FFC90", VA = "0x181A01090")]
		public void OnSkillClicked()
		{
		}

		// Token: 0x0601FE16 RID: 130582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE16")]
		[Address(RVA = "0x1A017D0", Offset = "0x1A003D0", VA = "0x181A017D0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601FE17 RID: 130583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE17")]
		[Address(RVA = "0x1A01A70", Offset = "0x1A00670", VA = "0x181A01A70")]
		private void _SetUnlockState(bool isUnlock)
		{
		}

		// Token: 0x0601FE18 RID: 130584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE18")]
		[Address(RVA = "0x1A01920", Offset = "0x1A00520", VA = "0x181A01920")]
		private void _SetSelectedStatus(bool isSelected)
		{
		}

		// Token: 0x0601FE19 RID: 130585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE19")]
		[Address(RVA = "0x1A01AF0", Offset = "0x1A006F0", VA = "0x181A01AF0")]
		public RoguelikeCharSelectSkillView()
		{
		}

		// Token: 0x0402AF9B RID: 176027
		[Token(Token = "0x402AF9B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _skillIcon;

		// Token: 0x0402AF9C RID: 176028
		[Token(Token = "0x402AF9C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _skillName;

		// Token: 0x0402AF9D RID: 176029
		[Token(Token = "0x402AF9D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _defaultSkillTag;

		// Token: 0x0402AF9E RID: 176030
		[Token(Token = "0x402AF9E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _skillTagLayout;

		// Token: 0x0402AF9F RID: 176031
		[Token(Token = "0x402AF9F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UISkillTagGroup _skillTagGroup;

		// Token: 0x0402AFA0 RID: 176032
		[Token(Token = "0x402AFA0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _spCost;

		// Token: 0x0402AFA1 RID: 176033
		[Token(Token = "0x402AFA1")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _skillDesc;

		// Token: 0x0402AFA2 RID: 176034
		[Token(Token = "0x402AFA2")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool _darkColorDescComment;

		// Token: 0x0402AFA3 RID: 176035
		[Token(Token = "0x402AFA3")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textDisable;

		// Token: 0x0402AFA4 RID: 176036
		[Token(Token = "0x402AFA4")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Tooltip("Nullable")]
		private CanvasGroup _selectedAlpha;

		// Token: 0x0402AFA5 RID: 176037
		[Token(Token = "0x402AFA5")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _panelInitCost;

		// Token: 0x0402AFA6 RID: 176038
		[Token(Token = "0x402AFA6")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _textInitCost;

		// Token: 0x0402AFA7 RID: 176039
		[Token(Token = "0x402AFA7")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Spec Skill Level")]
		private Sprite[] _skillLevelImages;

		// Token: 0x0402AFA8 RID: 176040
		[Token(Token = "0x402AFA8")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Spec Skill Level")]
		private Image _skillLevelIcon;

		// Token: 0x0402AFA9 RID: 176041
		[Token(Token = "0x402AFA9")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _activePart;

		// Token: 0x0402AFAA RID: 176042
		[Token(Token = "0x402AFAA")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _unActivePart;

		// Token: 0x0402AFAB RID: 176043
		[Token(Token = "0x402AFAB")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _disablePart;

		// Token: 0x0402AFAC RID: 176044
		[Token(Token = "0x402AFAC")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Skill Unlock")]
		private GameObject _panelLock;

		// Token: 0x0402AFAD RID: 176045
		[Token(Token = "0x402AFAD")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Skill Unlock")]
		private Text _lockText;

		// Token: 0x0402AFAE RID: 176046
		[Token(Token = "0x402AFAE")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Skill Unlock")]
		private Image _unlockIcon;

		// Token: 0x0402AFAF RID: 176047
		[Token(Token = "0x402AFAF")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Skill Unlock")]
		private Sprite[] _unlcokSprites;

		// Token: 0x0402AFB0 RID: 176048
		[Token(Token = "0x402AFB0")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Skill Level")]
		private GameObject _panelSkillLevel;

		// Token: 0x0402AFB1 RID: 176049
		[Token(Token = "0x402AFB1")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Skill Level")]
		private Text _textSkillLevel;

		// Token: 0x0402AFB2 RID: 176050
		[Token(Token = "0x402AFB2")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private GameObject _panelRange;

		// Token: 0x0402AFB3 RID: 176051
		[Token(Token = "0x402AFB3")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private RectTransform _rangeContainer;

		// Token: 0x0402AFB4 RID: 176052
		[Token(Token = "0x402AFB4")]
		[FieldOffset(Offset = "0xE0")]
		private bool m_isUnlockedCache;

		// Token: 0x0402AFB5 RID: 176053
		[Token(Token = "0x402AFB5")]
		[FieldOffset(Offset = "0xE1")]
		private bool m_isInited;

		// Token: 0x0402AFB6 RID: 176054
		[Token(Token = "0x402AFB6")]
		[FieldOffset(Offset = "0xE8")]
		private string m_skillId;

		// Token: 0x0402AFB7 RID: 176055
		[Token(Token = "0x402AFB7")]
		[FieldOffset(Offset = "0xF0")]
		private Action<string> m_onSkillClicked;

		// Token: 0x0402AFB8 RID: 176056
		[Token(Token = "0x402AFB8")]
		[FieldOffset(Offset = "0xF8")]
		private SkillTagViewModel[] m_tagCache;

		// Token: 0x0402AFB9 RID: 176057
		[Token(Token = "0x402AFB9")]
		[FieldOffset(Offset = "0x100")]
		private UICommentedText m_commentSkillDesc;

		// Token: 0x0402AFBA RID: 176058
		[Token(Token = "0x402AFBA")]
		[FieldOffset(Offset = "0x108")]
		private bool m_isSelected;

		// Token: 0x0402AFBB RID: 176059
		[Token(Token = "0x402AFBB")]
		[FieldOffset(Offset = "0x110")]
		private FadeSwitchTween m_selectedSwitch;

		// Token: 0x0402AFBC RID: 176060
		[Token(Token = "0x402AFBC")]
		[FieldOffset(Offset = "0x118")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402AFBD RID: 176061
		[Token(Token = "0x402AFBD")]
		[FieldOffset(Offset = "0x128")]
		private CommonSkillRangeButtonView m_skillRangeButton;

		// Token: 0x0402AFBE RID: 176062
		[Token(Token = "0x402AFBE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_showDefaultSkillTag;

		// Token: 0x0402AFBF RID: 176063
		[Token(Token = "0x402AFBF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_showDefaultSkillTag;

		// Token: 0x0402AFC0 RID: 176064
		[Token(Token = "0x402AFC0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_onSkillClicked;

		// Token: 0x0402AFC1 RID: 176065
		[Token(Token = "0x402AFC1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402AFC2 RID: 176066
		[Token(Token = "0x402AFC2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnSkillClicked;

		// Token: 0x0402AFC3 RID: 176067
		[Token(Token = "0x402AFC3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402AFC4 RID: 176068
		[Token(Token = "0x402AFC4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SetUnlockState;

		// Token: 0x0402AFC5 RID: 176069
		[Token(Token = "0x402AFC5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__SetSelectedStatus;

		// Token: 0x0402AFC6 RID: 176070
		[Token(Token = "0x402AFC6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
