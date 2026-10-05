using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.AVG;
using Torappu.UI.CharSelect;
using Torappu.UI.TemplateCharSelect.Common;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess.CharSelect
{
	// Token: 0x020063B7 RID: 25527
	[Token(Token = "0x20063B7")]
	public class AutoChessCharSelectDetailPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x170056E2 RID: 22242
		// (get) Token: 0x06024CD7 RID: 150743 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024CD8 RID: 150744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170056E2")]
		public AutoChessCharSelectDetailPanel.ICtrl ctrl
		{
			[Token(Token = "0x6024CD7")]
			[Address(RVA = "0x1F9DEE0", Offset = "0x1F9CAE0", VA = "0x181F9DEE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6024CD8")]
			[Address(RVA = "0x1F9DF40", Offset = "0x1F9CB40", VA = "0x181F9DF40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06024CD9 RID: 150745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024CD9")]
		[Address(RVA = "0x1F9C6E0", Offset = "0x1F9B2E0", VA = "0x181F9C6E0")]
		public void RenderViewModel(AutoChessCharSelectDetailViewModel subModel)
		{
		}

		// Token: 0x06024CDA RID: 150746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024CDA")]
		[Address(RVA = "0x1F9C9F0", Offset = "0x1F9B5F0", VA = "0x181F9C9F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06024CDB RID: 150747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024CDB")]
		[Address(RVA = "0x1F9C990", Offset = "0x1F9B590", VA = "0x181F9C990")]
		private AutoChessCharSelectDetailViewModel _GetCachedModel()
		{
			return null;
		}

		// Token: 0x06024CDC RID: 150748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024CDC")]
		[Address(RVA = "0x1F9D6E0", Offset = "0x1F9C2E0", VA = "0x181F9D6E0")]
		private void _RenderEmpty()
		{
		}

		// Token: 0x06024CDD RID: 150749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024CDD")]
		[Address(RVA = "0x1F9CC60", Offset = "0x1F9B860", VA = "0x181F9CC60")]
		private void _RenderCharSelect()
		{
		}

		// Token: 0x06024CDE RID: 150750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024CDE")]
		[Address(RVA = "0x1F9D750", Offset = "0x1F9C350", VA = "0x181F9D750")]
		private void _RenderGroup()
		{
		}

		// Token: 0x06024CDF RID: 150751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024CDF")]
		[Address(RVA = "0x1F9DBD0", Offset = "0x1F9C7D0", VA = "0x181F9DBD0")]
		private void _RenderUniqEquip(CharSelectBranchGroupViewModel branch)
		{
		}

		// Token: 0x06024CE0 RID: 150752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024CE0")]
		[Address(RVA = "0x1F9DD10", Offset = "0x1F9C910", VA = "0x181F9DD10")]
		private void _SwitchGold(bool isGold, bool immediately)
		{
		}

		// Token: 0x06024CE1 RID: 150753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024CE1")]
		[Address(RVA = "0x1F9C390", Offset = "0x1F9AF90", VA = "0x181F9C390")]
		public void OnSwitchGold()
		{
		}

		// Token: 0x06024CE2 RID: 150754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024CE2")]
		[Address(RVA = "0x1F9C260", Offset = "0x1F9AE60", VA = "0x181F9C260")]
		public void OnSelectSkill(string skillId)
		{
		}

		// Token: 0x06024CE3 RID: 150755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024CE3")]
		[Address(RVA = "0x1F9C0D0", Offset = "0x1F9ACD0", VA = "0x181F9C0D0")]
		public void OnSelectEquip(string equipId)
		{
		}

		// Token: 0x06024CE4 RID: 150756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024CE4")]
		[Address(RVA = "0x1F9C070", Offset = "0x1F9AC70", VA = "0x181F9C070")]
		public void OnSelectChessFeature()
		{
		}

		// Token: 0x06024CE5 RID: 150757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024CE5")]
		[Address(RVA = "0x1F9C200", Offset = "0x1F9AE00", VA = "0x181F9C200")]
		public void OnSelectSkillBar()
		{
		}

		// Token: 0x06024CE6 RID: 150758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024CE6")]
		[Address(RVA = "0x1F9C010", Offset = "0x1F9AC10", VA = "0x181F9C010")]
		public void OnSelectBranchBar()
		{
		}

		// Token: 0x06024CE7 RID: 150759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024CE7")]
		[Address(RVA = "0x1F9BF90", Offset = "0x1F9AB90", VA = "0x181F9BF90")]
		public void OnChangeState(AutoChessCharSelectDetailPanel.ButtonType btnType)
		{
		}

		// Token: 0x06024CE8 RID: 150760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024CE8")]
		[Address(RVA = "0x1F9C5A0", Offset = "0x1F9B1A0", VA = "0x181F9C5A0")]
		public void RegisterTutorialGO(AVGController avgController)
		{
		}

		// Token: 0x06024CE9 RID: 150761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024CE9")]
		[Address(RVA = "0x1F9BEB0", Offset = "0x1F9AAB0", VA = "0x181F9BEB0")]
		public Tweener FocusChessFeatureGarrison()
		{
			return null;
		}

		// Token: 0x06024CEA RID: 150762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024CEA")]
		[Address(RVA = "0x1F9BDD0", Offset = "0x1F9A9D0", VA = "0x181F9BDD0")]
		public Tweener FocusChessFeatureBond()
		{
			return null;
		}

		// Token: 0x06024CEB RID: 150763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024CEB")]
		[Address(RVA = "0x1F9DE80", Offset = "0x1F9CA80", VA = "0x181F9DE80")]
		public AutoChessCharSelectDetailPanel()
		{
		}

		// Token: 0x0403371B RID: 210715
		[Token(Token = "0x403371B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("GoldSwitch")]
		private UIAnimationLocation _goldSwitchAnim;

		// Token: 0x0403371C RID: 210716
		[Token(Token = "0x403371C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("GoldSwitch")]
		private Text _normalLevel;

		// Token: 0x0403371D RID: 210717
		[Token(Token = "0x403371D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("GoldSwitch")]
		private Image _normalIcon;

		// Token: 0x0403371E RID: 210718
		[Token(Token = "0x403371E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("GoldSwitch")]
		private Text _goldenLevel;

		// Token: 0x0403371F RID: 210719
		[Token(Token = "0x403371F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("GoldSwitch")]
		private Image _goldenIcon;

		// Token: 0x04033720 RID: 210720
		[Token(Token = "0x4033720")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("GoldSwitch")]
		private Button _tutorial_goldSwitchButton;

		// Token: 0x04033721 RID: 210721
		[Token(Token = "0x4033721")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("ChessLevel")]
		private Image _levelIcon;

		// Token: 0x04033722 RID: 210722
		[Token(Token = "0x4033722")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("ChessLevel")]
		private Text _levelText;

		// Token: 0x04033723 RID: 210723
		[Token(Token = "0x4033723")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _name;

		// Token: 0x04033724 RID: 210724
		[Token(Token = "0x4033724")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _codeName;

		// Token: 0x04033725 RID: 210725
		[Token(Token = "0x4033725")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _currentLevel;

		// Token: 0x04033726 RID: 210726
		[Token(Token = "0x4033726")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _maxLevel;

		// Token: 0x04033727 RID: 210727
		[Token(Token = "0x4033727")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Transform _attrContainer;

		// Token: 0x04033728 RID: 210728
		[Token(Token = "0x4033728")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UICharacterAttackRangeWidget _attackRange;

		// Token: 0x04033729 RID: 210729
		[Token(Token = "0x4033729")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private AutoChessCharSelectChessFeatureGroup _chessFeatureGroup;

		// Token: 0x0403372A RID: 210730
		[Token(Token = "0x403372A")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private CharSelectSkillGroup _skillGroup;

		// Token: 0x0403372B RID: 210731
		[Token(Token = "0x403372B")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private CharSelectBranchGroup _branchGroup;

		// Token: 0x0403372C RID: 210732
		[Token(Token = "0x403372C")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private List<VerticalLayoutGroup> _normalGroupPaddingLayouts;

		// Token: 0x0403372D RID: 210733
		[Token(Token = "0x403372D")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private int _largePadding;

		// Token: 0x0403372E RID: 210734
		[Token(Token = "0x403372E")]
		[FieldOffset(Offset = "0xB4")]
		[SerializeField]
		private int _smallPadding;

		// Token: 0x0403372F RID: 210735
		[Token(Token = "0x403372F")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Tooltip("panel to show when no attrs visible")]
		private GameObject _panelEmptyInfo;

		// Token: 0x04033730 RID: 210736
		[Token(Token = "0x4033730")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Tooltip("panel to show when no attrs visible")]
		private GameObject _panelHaveInfo;

		// Token: 0x04033731 RID: 210737
		[Token(Token = "0x4033731")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private GameObject _infoButton;

		// Token: 0x04033732 RID: 210738
		[Token(Token = "0x4033732")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private GameObject _disabledInfoBtn;

		// Token: 0x04033733 RID: 210739
		[Token(Token = "0x4033733")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private GameObject _predefinedBtn;

		// Token: 0x04033734 RID: 210740
		[Token(Token = "0x4033734")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private GameObject _noUniEquip;

		// Token: 0x04033735 RID: 210741
		[Token(Token = "0x4033735")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private GameObject _lockedUniEquip;

		// Token: 0x04033736 RID: 210742
		[Token(Token = "0x4033736")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private GameObject _haveUniEquip;

		// Token: 0x04033737 RID: 210743
		[Token(Token = "0x4033737")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private Image _uniqEquipIcon;

		// Token: 0x04033738 RID: 210744
		[Token(Token = "0x4033738")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private Image _subProfessionIcon;

		// Token: 0x04033739 RID: 210745
		[Token(Token = "0x4033739")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private List<AutoChessCharSelectDetailPanel.TypeBranchButton> _buttonList;

		// Token: 0x0403373A RID: 210746
		[Token(Token = "0x403373A")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		[Group("BranchTips")]
		private GameObject _branchTips;

		// Token: 0x0403373B RID: 210747
		[Token(Token = "0x403373B")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		[Group("BranchTips")]
		private HorizontalLayoutGroup _branchLayout;

		// Token: 0x0403373C RID: 210748
		[Token(Token = "0x403373C")]
		[FieldOffset(Offset = "0x120")]
		private AutoChessCharSelectDetailPanel.ButtonType m_selectType;

		// Token: 0x0403373D RID: 210749
		[Token(Token = "0x403373D")]
		[FieldOffset(Offset = "0x128")]
		private AnimationSwitchTween m_goldSwitch;

		// Token: 0x0403373E RID: 210750
		[Token(Token = "0x403373E")]
		[FieldOffset(Offset = "0x130")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403373F RID: 210751
		[Token(Token = "0x403373F")]
		[FieldOffset(Offset = "0x140")]
		private CommonCharSelectDetailAttrView m_attr;

		// Token: 0x04033740 RID: 210752
		[Token(Token = "0x4033740")]
		[FieldOffset(Offset = "0x148")]
		private AutoChessCharSelectDetailViewModel m_cacheModel;

		// Token: 0x04033741 RID: 210753
		[Token(Token = "0x4033741")]
		[FieldOffset(Offset = "0x150")]
		private int m_branchTopBlank;

		// Token: 0x04033743 RID: 210755
		[Token(Token = "0x4033743")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_ctrl;

		// Token: 0x04033744 RID: 210756
		[Token(Token = "0x4033744")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_ctrl;

		// Token: 0x04033745 RID: 210757
		[Token(Token = "0x4033745")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RenderViewModel;

		// Token: 0x04033746 RID: 210758
		[Token(Token = "0x4033746")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04033747 RID: 210759
		[Token(Token = "0x4033747")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetCachedModel;

		// Token: 0x04033748 RID: 210760
		[Token(Token = "0x4033748")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderEmpty;

		// Token: 0x04033749 RID: 210761
		[Token(Token = "0x4033749")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderCharSelect;

		// Token: 0x0403374A RID: 210762
		[Token(Token = "0x403374A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RenderGroup;

		// Token: 0x0403374B RID: 210763
		[Token(Token = "0x403374B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RenderUniqEquip;

		// Token: 0x0403374C RID: 210764
		[Token(Token = "0x403374C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__SwitchGold;

		// Token: 0x0403374D RID: 210765
		[Token(Token = "0x403374D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnSwitchGold;

		// Token: 0x0403374E RID: 210766
		[Token(Token = "0x403374E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnSelectSkill;

		// Token: 0x0403374F RID: 210767
		[Token(Token = "0x403374F")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnSelectEquip;

		// Token: 0x04033750 RID: 210768
		[Token(Token = "0x4033750")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnSelectChessFeature;

		// Token: 0x04033751 RID: 210769
		[Token(Token = "0x4033751")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnSelectSkillBar;

		// Token: 0x04033752 RID: 210770
		[Token(Token = "0x4033752")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnSelectBranchBar;

		// Token: 0x04033753 RID: 210771
		[Token(Token = "0x4033753")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnChangeState;

		// Token: 0x04033754 RID: 210772
		[Token(Token = "0x4033754")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_RegisterTutorialGO;

		// Token: 0x04033755 RID: 210773
		[Token(Token = "0x4033755")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_FocusChessFeatureGarrison;

		// Token: 0x04033756 RID: 210774
		[Token(Token = "0x4033756")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_FocusChessFeatureBond;

		// Token: 0x04033757 RID: 210775
		[Token(Token = "0x4033757")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020063B8 RID: 25528
		[Token(Token = "0x20063B8")]
		public interface ICtrl
		{
			// Token: 0x06024CEC RID: 150764
			[Token(Token = "0x6024CEC")]
			void SwitchGold(bool isGold);

			// Token: 0x06024CED RID: 150765
			[Token(Token = "0x6024CED")]
			void SelectSkill(string skillId);

			// Token: 0x06024CEE RID: 150766
			[Token(Token = "0x6024CEE")]
			void SelectEquip(string equipId);
		}

		// Token: 0x020063B9 RID: 25529
		[Token(Token = "0x20063B9")]
		[Serializable]
		public enum ButtonType
		{
			// Token: 0x04033759 RID: 210777
			[Token(Token = "0x4033759")]
			CHESS_FEATURE,
			// Token: 0x0403375A RID: 210778
			[Token(Token = "0x403375A")]
			SKILL,
			// Token: 0x0403375B RID: 210779
			[Token(Token = "0x403375B")]
			BRANCH
		}

		// Token: 0x020063BA RID: 25530
		[Token(Token = "0x20063BA")]
		[Serializable]
		private class TypeBranchButton
		{
			// Token: 0x06024CEF RID: 150767 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024CEF")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public TypeBranchButton()
			{
			}

			// Token: 0x0403375C RID: 210780
			[Token(Token = "0x403375C")]
			[FieldOffset(Offset = "0x10")]
			public AutoChessCharSelectDetailPanel.ButtonType buttonType;

			// Token: 0x0403375D RID: 210781
			[Token(Token = "0x403375D")]
			[FieldOffset(Offset = "0x18")]
			public TwoStateToggle twoStateToggle;
		}
	}
}
