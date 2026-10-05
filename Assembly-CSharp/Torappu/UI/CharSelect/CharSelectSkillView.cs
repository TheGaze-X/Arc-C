using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharSelect
{
	// Token: 0x02005E25 RID: 24101
	[Token(Token = "0x2005E25")]
	public class CharSelectSkillView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170052C5 RID: 21189
		// (get) Token: 0x06022EB4 RID: 143028 RVA: 0x000BF760 File Offset: 0x000BD960
		// (set) Token: 0x06022EB5 RID: 143029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170052C5")]
		public bool showDefaultSkillTag
		{
			[Token(Token = "0x6022EB4")]
			[Address(RVA = "0x1D68020", Offset = "0x1D66C20", VA = "0x181D68020")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6022EB5")]
			[Address(RVA = "0x1D68110", Offset = "0x1D66D10", VA = "0x181D68110")]
			set
			{
			}
		}

		// Token: 0x170052C6 RID: 21190
		// (set) Token: 0x06022EB6 RID: 143030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170052C6")]
		public Action<string> onSkillClicked
		{
			[Token(Token = "0x6022EB6")]
			[Address(RVA = "0x1D68090", Offset = "0x1D66C90", VA = "0x181D68090")]
			set
			{
			}
		}

		// Token: 0x06022EB7 RID: 143031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022EB7")]
		[Address(RVA = "0x1D67610", Offset = "0x1D66210", VA = "0x181D67610")]
		public void Render(CharSelectSkillItemViewModel viewModel, bool isSelected)
		{
		}

		// Token: 0x06022EB8 RID: 143032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022EB8")]
		[Address(RVA = "0x1D67590", Offset = "0x1D66190", VA = "0x181D67590")]
		public void OnSkillClicked()
		{
		}

		// Token: 0x06022EB9 RID: 143033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022EB9")]
		[Address(RVA = "0x1D67C90", Offset = "0x1D66890", VA = "0x181D67C90")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06022EBA RID: 143034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022EBA")]
		[Address(RVA = "0x1D67F30", Offset = "0x1D66B30", VA = "0x181D67F30")]
		private void _SetUnlockState(bool isUnlock)
		{
		}

		// Token: 0x06022EBB RID: 143035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022EBB")]
		[Address(RVA = "0x1D67DE0", Offset = "0x1D669E0", VA = "0x181D67DE0")]
		private void _SetSelectedStatus(bool isSelected)
		{
		}

		// Token: 0x06022EBC RID: 143036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022EBC")]
		[Address(RVA = "0x1D67FB0", Offset = "0x1D66BB0", VA = "0x181D67FB0")]
		public CharSelectSkillView()
		{
		}

		// Token: 0x0403019B RID: 197019
		[Token(Token = "0x403019B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _skillIcon;

		// Token: 0x0403019C RID: 197020
		[Token(Token = "0x403019C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _skillName;

		// Token: 0x0403019D RID: 197021
		[Token(Token = "0x403019D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _defaultSkillTag;

		// Token: 0x0403019E RID: 197022
		[Token(Token = "0x403019E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _skillTagLayout;

		// Token: 0x0403019F RID: 197023
		[Token(Token = "0x403019F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UISkillTagGroup _skillTagGroup;

		// Token: 0x040301A0 RID: 197024
		[Token(Token = "0x40301A0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _spCost;

		// Token: 0x040301A1 RID: 197025
		[Token(Token = "0x40301A1")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _skillDesc;

		// Token: 0x040301A2 RID: 197026
		[Token(Token = "0x40301A2")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool _darkColorDescComment;

		// Token: 0x040301A3 RID: 197027
		[Token(Token = "0x40301A3")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textDisable;

		// Token: 0x040301A4 RID: 197028
		[Token(Token = "0x40301A4")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Tooltip("Nullable")]
		private CanvasGroup _selectedAlpha;

		// Token: 0x040301A5 RID: 197029
		[Token(Token = "0x40301A5")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _panelInitCost;

		// Token: 0x040301A6 RID: 197030
		[Token(Token = "0x40301A6")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _textInitCost;

		// Token: 0x040301A7 RID: 197031
		[Token(Token = "0x40301A7")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Spec Skill Level")]
		private Sprite[] _skillLevelImages;

		// Token: 0x040301A8 RID: 197032
		[Token(Token = "0x40301A8")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Spec Skill Level")]
		private Image _skillLevelIcon;

		// Token: 0x040301A9 RID: 197033
		[Token(Token = "0x40301A9")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _activePart;

		// Token: 0x040301AA RID: 197034
		[Token(Token = "0x40301AA")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _unActivePart;

		// Token: 0x040301AB RID: 197035
		[Token(Token = "0x40301AB")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _disablePart;

		// Token: 0x040301AC RID: 197036
		[Token(Token = "0x40301AC")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Skill Unlock")]
		private GameObject _panelLock;

		// Token: 0x040301AD RID: 197037
		[Token(Token = "0x40301AD")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Skill Unlock")]
		private Text _lockText;

		// Token: 0x040301AE RID: 197038
		[Token(Token = "0x40301AE")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Skill Unlock")]
		private Image _unlockIcon;

		// Token: 0x040301AF RID: 197039
		[Token(Token = "0x40301AF")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Skill Unlock")]
		private Sprite[] _unlcokSprites;

		// Token: 0x040301B0 RID: 197040
		[Token(Token = "0x40301B0")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Skill Level")]
		private GameObject _panelSkillLevel;

		// Token: 0x040301B1 RID: 197041
		[Token(Token = "0x40301B1")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Skill Level")]
		private Text _textSkillLevel;

		// Token: 0x040301B2 RID: 197042
		[Token(Token = "0x40301B2")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private GameObject _panelRange;

		// Token: 0x040301B3 RID: 197043
		[Token(Token = "0x40301B3")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private RectTransform _rangeContainer;

		// Token: 0x040301B4 RID: 197044
		[Token(Token = "0x40301B4")]
		[FieldOffset(Offset = "0xE0")]
		private bool m_isUnlockedCache;

		// Token: 0x040301B5 RID: 197045
		[Token(Token = "0x40301B5")]
		[FieldOffset(Offset = "0xE1")]
		private bool m_isInited;

		// Token: 0x040301B6 RID: 197046
		[Token(Token = "0x40301B6")]
		[FieldOffset(Offset = "0xE8")]
		private string m_skillId;

		// Token: 0x040301B7 RID: 197047
		[Token(Token = "0x40301B7")]
		[FieldOffset(Offset = "0xF0")]
		private Action<string> m_onSkillClicked;

		// Token: 0x040301B8 RID: 197048
		[Token(Token = "0x40301B8")]
		[FieldOffset(Offset = "0xF8")]
		private SkillTagViewModel[] m_tagCache;

		// Token: 0x040301B9 RID: 197049
		[Token(Token = "0x40301B9")]
		[FieldOffset(Offset = "0x100")]
		private UICommentedText m_commentSkillDesc;

		// Token: 0x040301BA RID: 197050
		[Token(Token = "0x40301BA")]
		[FieldOffset(Offset = "0x108")]
		private bool m_isSelected;

		// Token: 0x040301BB RID: 197051
		[Token(Token = "0x40301BB")]
		[FieldOffset(Offset = "0x110")]
		private FadeSwitchTween m_selectedSwitch;

		// Token: 0x040301BC RID: 197052
		[Token(Token = "0x40301BC")]
		[FieldOffset(Offset = "0x118")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040301BD RID: 197053
		[Token(Token = "0x40301BD")]
		[FieldOffset(Offset = "0x128")]
		private CommonSkillRangeButtonView m_skillRangeButton;

		// Token: 0x040301BE RID: 197054
		[Token(Token = "0x40301BE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_showDefaultSkillTag;

		// Token: 0x040301BF RID: 197055
		[Token(Token = "0x40301BF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_showDefaultSkillTag;

		// Token: 0x040301C0 RID: 197056
		[Token(Token = "0x40301C0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_onSkillClicked;

		// Token: 0x040301C1 RID: 197057
		[Token(Token = "0x40301C1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040301C2 RID: 197058
		[Token(Token = "0x40301C2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnSkillClicked;

		// Token: 0x040301C3 RID: 197059
		[Token(Token = "0x40301C3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040301C4 RID: 197060
		[Token(Token = "0x40301C4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SetUnlockState;

		// Token: 0x040301C5 RID: 197061
		[Token(Token = "0x40301C5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__SetSelectedStatus;

		// Token: 0x040301C6 RID: 197062
		[Token(Token = "0x40301C6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
