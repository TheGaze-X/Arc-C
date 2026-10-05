using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharSelect
{
	// Token: 0x02005E13 RID: 24083
	[Token(Token = "0x2005E13")]
	public class CharSelectAttrController : DataBinder<CharAttrViewProperty>
	{
		// Token: 0x06022E79 RID: 142969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022E79")]
		[Address(RVA = "0x1D630A0", Offset = "0x1D61CA0", VA = "0x181D630A0", Slot = "7")]
		public override void OnValueChanged(CharAttrViewProperty property)
		{
		}

		// Token: 0x06022E7A RID: 142970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022E7A")]
		[Address(RVA = "0x1D63CD0", Offset = "0x1D628D0", VA = "0x181D63CD0")]
		private void _RenderTab(CharAttrViewModel viewModel)
		{
		}

		// Token: 0x06022E7B RID: 142971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022E7B")]
		[Address(RVA = "0x1D63C00", Offset = "0x1D62800", VA = "0x181D63C00")]
		private void _RenderSkillGroup(CharAttrViewModel viewModel)
		{
		}

		// Token: 0x06022E7C RID: 142972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022E7C")]
		[Address(RVA = "0x1D63B30", Offset = "0x1D62730", VA = "0x181D63B30")]
		private void _RenderBranchGroup(CharAttrViewModel viewModel)
		{
		}

		// Token: 0x06022E7D RID: 142973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022E7D")]
		[Address(RVA = "0x1D638F0", Offset = "0x1D624F0", VA = "0x181D638F0")]
		private void _LoadUniqEquip(CharAttrViewModel viewModel)
		{
		}

		// Token: 0x06022E7E RID: 142974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022E7E")]
		[Address(RVA = "0x1D62EC0", Offset = "0x1D61AC0", VA = "0x181D62EC0")]
		public void InitWithPage(UIPage page)
		{
		}

		// Token: 0x06022E7F RID: 142975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022E7F")]
		[Address(RVA = "0x1D63E90", Offset = "0x1D62A90", VA = "0x181D63E90")]
		public CharSelectAttrController()
		{
		}

		// Token: 0x040300F3 RID: 196851
		[Token(Token = "0x40300F3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _name;

		// Token: 0x040300F4 RID: 196852
		[Token(Token = "0x40300F4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _codeName;

		// Token: 0x040300F5 RID: 196853
		[Token(Token = "0x40300F5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _currentLevel;

		// Token: 0x040300F6 RID: 196854
		[Token(Token = "0x40300F6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _maxLevel;

		// Token: 0x040300F7 RID: 196855
		[Token(Token = "0x40300F7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _maxHp;

		// Token: 0x040300F8 RID: 196856
		[Token(Token = "0x40300F8")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _atk;

		// Token: 0x040300F9 RID: 196857
		[Token(Token = "0x40300F9")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _def;

		// Token: 0x040300FA RID: 196858
		[Token(Token = "0x40300FA")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _res;

		// Token: 0x040300FB RID: 196859
		[Token(Token = "0x40300FB")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _reviveTimeDesc;

		// Token: 0x040300FC RID: 196860
		[Token(Token = "0x40300FC")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _cost;

		// Token: 0x040300FD RID: 196861
		[Token(Token = "0x40300FD")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _blockNum;

		// Token: 0x040300FE RID: 196862
		[Token(Token = "0x40300FE")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _attackSpeedDesc;

		// Token: 0x040300FF RID: 196863
		[Token(Token = "0x40300FF")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Image _atkIcon;

		// Token: 0x04030100 RID: 196864
		[Token(Token = "0x4030100")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Image _defIcon;

		// Token: 0x04030101 RID: 196865
		[Token(Token = "0x4030101")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Image _maxHpIcon;

		// Token: 0x04030102 RID: 196866
		[Token(Token = "0x4030102")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Image _resIcon;

		// Token: 0x04030103 RID: 196867
		[Token(Token = "0x4030103")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Image _reviveIcon;

		// Token: 0x04030104 RID: 196868
		[Token(Token = "0x4030104")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Image _costIcon;

		// Token: 0x04030105 RID: 196869
		[Token(Token = "0x4030105")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Image _blockIcon;

		// Token: 0x04030106 RID: 196870
		[Token(Token = "0x4030106")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Image _attackSpeedIcon;

		// Token: 0x04030107 RID: 196871
		[Token(Token = "0x4030107")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private UICharacterAttackRangeWidget _attackRange;

		// Token: 0x04030108 RID: 196872
		[Token(Token = "0x4030108")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private CharSelectSkillGroup _skillGroup;

		// Token: 0x04030109 RID: 196873
		[Token(Token = "0x4030109")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private CharSelectBranchGroup _branchGroup;

		// Token: 0x0403010A RID: 196874
		[Token(Token = "0x403010A")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Tooltip("panel to show when no attrs visible")]
		private GameObject _panelEmptyInfo;

		// Token: 0x0403010B RID: 196875
		[Token(Token = "0x403010B")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private GameObject _infoButton;

		// Token: 0x0403010C RID: 196876
		[Token(Token = "0x403010C")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private GameObject _disabledInfoBtn;

		// Token: 0x0403010D RID: 196877
		[Token(Token = "0x403010D")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private GameObject _predefinedBtn;

		// Token: 0x0403010E RID: 196878
		[Token(Token = "0x403010E")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private GameObject _noUniEquip;

		// Token: 0x0403010F RID: 196879
		[Token(Token = "0x403010F")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private GameObject _lockedUniEquip;

		// Token: 0x04030110 RID: 196880
		[Token(Token = "0x4030110")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private GameObject _haveUniEquip;

		// Token: 0x04030111 RID: 196881
		[Token(Token = "0x4030111")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private Image _uniqEquipIcon;

		// Token: 0x04030112 RID: 196882
		[Token(Token = "0x4030112")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private Image _subProfessionIcon;

		// Token: 0x04030113 RID: 196883
		[Token(Token = "0x4030113")]
		[FieldOffset(Offset = "0x120")]
		[NonSerialized]
		public string uipageName;

		// Token: 0x04030114 RID: 196884
		[Token(Token = "0x4030114")]
		[FieldOffset(Offset = "0x128")]
		private int m_chrInstIdCache;

		// Token: 0x04030115 RID: 196885
		[Token(Token = "0x4030115")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04030116 RID: 196886
		[Token(Token = "0x4030116")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderTab;

		// Token: 0x04030117 RID: 196887
		[Token(Token = "0x4030117")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderSkillGroup;

		// Token: 0x04030118 RID: 196888
		[Token(Token = "0x4030118")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderBranchGroup;

		// Token: 0x04030119 RID: 196889
		[Token(Token = "0x4030119")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__LoadUniqEquip;

		// Token: 0x0403011A RID: 196890
		[Token(Token = "0x403011A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_InitWithPage;

		// Token: 0x0403011B RID: 196891
		[Token(Token = "0x403011B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
