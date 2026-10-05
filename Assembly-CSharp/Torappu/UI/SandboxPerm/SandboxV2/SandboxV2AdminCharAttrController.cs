using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.CharSelect;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200402C RID: 16428
	[Token(Token = "0x200402C")]
	public class SandboxV2AdminCharAttrController : MonoBehaviour, IHotfixable
	{
		// Token: 0x060196D7 RID: 104151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196D7")]
		[Address(RVA = "0x121B320", Offset = "0x1219F20", VA = "0x18121B320")]
		public void RenderCharAttr(SandboxV2CharViewModel viewModel, SandboxV2CharSelectTabEnum tabEnum)
		{
		}

		// Token: 0x060196D8 RID: 104152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196D8")]
		[Address(RVA = "0x121C280", Offset = "0x121AE80", VA = "0x18121C280")]
		private void _RenderTab(SandboxV2CharViewModel viewModel, SandboxV2CharSelectTabEnum type)
		{
		}

		// Token: 0x060196D9 RID: 104153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196D9")]
		[Address(RVA = "0x121C0E0", Offset = "0x121ACE0", VA = "0x18121C0E0")]
		private void _RenderSkillGroup(SandboxV2CharViewModel viewModel)
		{
		}

		// Token: 0x060196DA RID: 104154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196DA")]
		[Address(RVA = "0x121BCE0", Offset = "0x121A8E0", VA = "0x18121BCE0")]
		private void _RenderBranchGroup(SandboxV2CharViewModel viewModel)
		{
		}

		// Token: 0x060196DB RID: 104155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196DB")]
		[Address(RVA = "0x121BE80", Offset = "0x121AA80", VA = "0x18121BE80")]
		private void _RenderFoodGroup(SandboxV2CharViewModel viewModel)
		{
		}

		// Token: 0x060196DC RID: 104156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196DC")]
		[Address(RVA = "0x121BB90", Offset = "0x121A790", VA = "0x18121BB90")]
		private void _LoadUniqEquip(SandboxV2CharViewModel viewModel)
		{
		}

		// Token: 0x060196DD RID: 104157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196DD")]
		[Address(RVA = "0x121AE00", Offset = "0x1219A00", VA = "0x18121AE00")]
		public void InitWithPage(ILoadAsset assets)
		{
		}

		// Token: 0x060196DE RID: 104158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196DE")]
		[Address(RVA = "0x121B0E0", Offset = "0x1219CE0", VA = "0x18121B0E0")]
		public void OnCharSkillSelect(string skillId)
		{
		}

		// Token: 0x060196DF RID: 104159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196DF")]
		[Address(RVA = "0x121AFE0", Offset = "0x1219BE0", VA = "0x18121AFE0")]
		public void OnCharEquipSelect(string equipId)
		{
		}

		// Token: 0x060196E0 RID: 104160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196E0")]
		[Address(RVA = "0x121B1E0", Offset = "0x1219DE0", VA = "0x18121B1E0")]
		public void OnToCharInfoPage()
		{
		}

		// Token: 0x060196E1 RID: 104161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196E1")]
		[Address(RVA = "0x121B280", Offset = "0x1219E80", VA = "0x18121B280")]
		public void OnToEatFood()
		{
		}

		// Token: 0x060196E2 RID: 104162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196E2")]
		[Address(RVA = "0x121C760", Offset = "0x121B360", VA = "0x18121C760")]
		public SandboxV2AdminCharAttrController()
		{
		}

		// Token: 0x0401FA78 RID: 129656
		[Token(Token = "0x401FA78")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _name;

		// Token: 0x0401FA79 RID: 129657
		[Token(Token = "0x401FA79")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _codeName;

		// Token: 0x0401FA7A RID: 129658
		[Token(Token = "0x401FA7A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _currentLevel;

		// Token: 0x0401FA7B RID: 129659
		[Token(Token = "0x401FA7B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _maxLevel;

		// Token: 0x0401FA7C RID: 129660
		[Token(Token = "0x401FA7C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _maxHp;

		// Token: 0x0401FA7D RID: 129661
		[Token(Token = "0x401FA7D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _atk;

		// Token: 0x0401FA7E RID: 129662
		[Token(Token = "0x401FA7E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _def;

		// Token: 0x0401FA7F RID: 129663
		[Token(Token = "0x401FA7F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _res;

		// Token: 0x0401FA80 RID: 129664
		[Token(Token = "0x401FA80")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _reviveTimeDesc;

		// Token: 0x0401FA81 RID: 129665
		[Token(Token = "0x401FA81")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _cost;

		// Token: 0x0401FA82 RID: 129666
		[Token(Token = "0x401FA82")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _blockNum;

		// Token: 0x0401FA83 RID: 129667
		[Token(Token = "0x401FA83")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _attackSpeedDesc;

		// Token: 0x0401FA84 RID: 129668
		[Token(Token = "0x401FA84")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image _atkIcon;

		// Token: 0x0401FA85 RID: 129669
		[Token(Token = "0x401FA85")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Image _defIcon;

		// Token: 0x0401FA86 RID: 129670
		[Token(Token = "0x401FA86")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Image _maxHpIcon;

		// Token: 0x0401FA87 RID: 129671
		[Token(Token = "0x401FA87")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Image _resIcon;

		// Token: 0x0401FA88 RID: 129672
		[Token(Token = "0x401FA88")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Image _reviveIcon;

		// Token: 0x0401FA89 RID: 129673
		[Token(Token = "0x401FA89")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Image _costIcon;

		// Token: 0x0401FA8A RID: 129674
		[Token(Token = "0x401FA8A")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Image _blockIcon;

		// Token: 0x0401FA8B RID: 129675
		[Token(Token = "0x401FA8B")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Image _attackSpeedIcon;

		// Token: 0x0401FA8C RID: 129676
		[Token(Token = "0x401FA8C")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private UICharacterAttackRangeWidget _attackRange;

		// Token: 0x0401FA8D RID: 129677
		[Token(Token = "0x401FA8D")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private CharSelectSkillGroup _skillGroup;

		// Token: 0x0401FA8E RID: 129678
		[Token(Token = "0x401FA8E")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private CharSelectBranchGroup _branchGroup;

		// Token: 0x0401FA8F RID: 129679
		[Token(Token = "0x401FA8F")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private SandboxV2AdminFoodAttrPanel _foodGroup;

		// Token: 0x0401FA90 RID: 129680
		[Token(Token = "0x401FA90")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Tooltip("panel to show when no attrs visible")]
		private GameObject _panelEmptyInfo;

		// Token: 0x0401FA91 RID: 129681
		[Token(Token = "0x401FA91")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Tooltip("panel to show when no attrs visible")]
		private GameObject _panelNormal;

		// Token: 0x0401FA92 RID: 129682
		[Token(Token = "0x401FA92")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private GameObject _noUniEquip;

		// Token: 0x0401FA93 RID: 129683
		[Token(Token = "0x401FA93")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private GameObject _lockedUniEquip;

		// Token: 0x0401FA94 RID: 129684
		[Token(Token = "0x401FA94")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private GameObject _haveUniEquip;

		// Token: 0x0401FA95 RID: 129685
		[Token(Token = "0x401FA95")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private Image _uniqEquipIcon;

		// Token: 0x0401FA96 RID: 129686
		[Token(Token = "0x401FA96")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private Image _subProfessionIcon;

		// Token: 0x0401FA97 RID: 129687
		[Token(Token = "0x401FA97")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private List<SandboxV2CharSelectAttrTabItem> _attrTabItems;

		// Token: 0x0401FA98 RID: 129688
		[Token(Token = "0x401FA98")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private CanvasGroup _attrPart;

		// Token: 0x0401FA99 RID: 129689
		[Token(Token = "0x401FA99")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private GameObject _statePart;

		// Token: 0x0401FA9A RID: 129690
		[Token(Token = "0x401FA9A")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private GameObject _supplyPart;

		// Token: 0x0401FA9B RID: 129691
		[Token(Token = "0x401FA9B")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private GameObject _expedPart;

		// Token: 0x0401FA9C RID: 129692
		[Token(Token = "0x401FA9C")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private Text _expedDay;

		// Token: 0x0401FA9D RID: 129693
		[Token(Token = "0x401FA9D")]
		[FieldOffset(Offset = "0x140")]
		private int m_chrInstIdCache;

		// Token: 0x0401FA9E RID: 129694
		[Token(Token = "0x401FA9E")]
		[FieldOffset(Offset = "0x148")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401FA9F RID: 129695
		[Token(Token = "0x401FA9F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderCharAttr;

		// Token: 0x0401FAA0 RID: 129696
		[Token(Token = "0x401FAA0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderTab;

		// Token: 0x0401FAA1 RID: 129697
		[Token(Token = "0x401FAA1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderSkillGroup;

		// Token: 0x0401FAA2 RID: 129698
		[Token(Token = "0x401FAA2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderBranchGroup;

		// Token: 0x0401FAA3 RID: 129699
		[Token(Token = "0x401FAA3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderFoodGroup;

		// Token: 0x0401FAA4 RID: 129700
		[Token(Token = "0x401FAA4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__LoadUniqEquip;

		// Token: 0x0401FAA5 RID: 129701
		[Token(Token = "0x401FAA5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_InitWithPage;

		// Token: 0x0401FAA6 RID: 129702
		[Token(Token = "0x401FAA6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnCharSkillSelect;

		// Token: 0x0401FAA7 RID: 129703
		[Token(Token = "0x401FAA7")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnCharEquipSelect;

		// Token: 0x0401FAA8 RID: 129704
		[Token(Token = "0x401FAA8")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnToCharInfoPage;

		// Token: 0x0401FAA9 RID: 129705
		[Token(Token = "0x401FAA9")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnToEatFood;

		// Token: 0x0401FAAA RID: 129706
		[Token(Token = "0x401FAAA")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
