using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.CharSelect;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.TemplateCharSelect.Common
{
	// Token: 0x02005C0D RID: 23565
	[Token(Token = "0x2005C0D")]
	public class CommonCharSelectDetailPlugin : TemplateCharSelectDetailPluginBase<CommonCharSelectDetailDefaultViewModel>
	{
		// Token: 0x17005019 RID: 20505
		// (get) Token: 0x06022299 RID: 139929 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602229A RID: 139930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005019")]
		public override Action<CommonCharSelectDetailDefaultViewModel> OnClickDetail
		{
			[Token(Token = "0x6022299")]
			[Address(RVA = "0x1CAC8F0", Offset = "0x1CAB4F0", VA = "0x181CAC8F0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602229A")]
			[Address(RVA = "0x1CACA10", Offset = "0x1CAB610", VA = "0x181CACA10", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700501A RID: 20506
		// (get) Token: 0x0602229B RID: 139931 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602229C RID: 139932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700501A")]
		public override Action<int, ValueBundle> OnSetCharAttribute
		{
			[Token(Token = "0x602229B")]
			[Address(RVA = "0x1CAC950", Offset = "0x1CAB550", VA = "0x181CAC950", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602229C")]
			[Address(RVA = "0x1CACA90", Offset = "0x1CAB690", VA = "0x181CACA90", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700501B RID: 20507
		// (get) Token: 0x0602229D RID: 139933 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602229E RID: 139934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700501B")]
		protected virtual TemplateCharSelectMainViewModel mainModel
		{
			[Token(Token = "0x602229D")]
			[Address(RVA = "0x1CAC9B0", Offset = "0x1CAB5B0", VA = "0x181CAC9B0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602229E")]
			[Address(RVA = "0x1CACB10", Offset = "0x1CAB710", VA = "0x181CACB10", Slot = "12")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602229F RID: 139935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602229F")]
		[Address(RVA = "0x1CAB530", Offset = "0x1CAA130", VA = "0x181CAB530", Slot = "4")]
		public override void OnRender(TemplateCharSelectMainViewModel mainModel, TemplateCharSelectDetailPlugin.RenderType renderType)
		{
		}

		// Token: 0x060222A0 RID: 139936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60222A0")]
		[Address(RVA = "0x1CAC0F0", Offset = "0x1CAACF0", VA = "0x181CAC0F0", Slot = "13")]
		protected virtual void RenderEmpty()
		{
		}

		// Token: 0x060222A1 RID: 139937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60222A1")]
		[Address(RVA = "0x1CAB940", Offset = "0x1CAA540", VA = "0x181CAB940", Slot = "14")]
		protected virtual void RenderCharDetail()
		{
		}

		// Token: 0x060222A2 RID: 139938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60222A2")]
		[Address(RVA = "0x1CAC160", Offset = "0x1CAAD60", VA = "0x181CAC160", Slot = "10")]
		protected override void RenderPanels(CommonCharSelectDetailDefaultViewModel viewModel)
		{
		}

		// Token: 0x060222A3 RID: 139939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60222A3")]
		[Address(RVA = "0x1CAC790", Offset = "0x1CAB390", VA = "0x181CAC790")]
		private void _SetAttrSprite(Image imgIcon, CharacterSortType sortType)
		{
		}

		// Token: 0x060222A4 RID: 139940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60222A4")]
		[Address(RVA = "0x1CAC360", Offset = "0x1CAAF60", VA = "0x181CAC360")]
		private void _RenderGroup(CommonCharSelectDetailDefaultViewModel detailViewModel)
		{
		}

		// Token: 0x060222A5 RID: 139941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60222A5")]
		[Address(RVA = "0x1CAC650", Offset = "0x1CAB250", VA = "0x181CAC650")]
		private void _RenderUniqEquip(CharSelectBranchGroupViewModel branch)
		{
		}

		// Token: 0x060222A6 RID: 139942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60222A6")]
		[Address(RVA = "0x1CAB3D0", Offset = "0x1CA9FD0", VA = "0x181CAB3D0")]
		public void OnFetchDetail()
		{
		}

		// Token: 0x060222A7 RID: 139943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60222A7")]
		[Address(RVA = "0x1CAB840", Offset = "0x1CAA440", VA = "0x181CAB840")]
		public void OnSelectSkill(string skillId)
		{
		}

		// Token: 0x060222A8 RID: 139944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60222A8")]
		[Address(RVA = "0x1CAB6C0", Offset = "0x1CAA2C0", VA = "0x181CAB6C0")]
		public void OnSelectEquip(string equipId)
		{
		}

		// Token: 0x060222A9 RID: 139945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60222A9")]
		[Address(RVA = "0x1CAB7C0", Offset = "0x1CAA3C0", VA = "0x181CAB7C0")]
		public void OnSelectSkillBar()
		{
		}

		// Token: 0x060222AA RID: 139946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60222AA")]
		[Address(RVA = "0x1CAB640", Offset = "0x1CAA240", VA = "0x181CAB640")]
		public void OnSelectBranchBar()
		{
		}

		// Token: 0x060222AB RID: 139947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60222AB")]
		[Address(RVA = "0x1CAB280", Offset = "0x1CA9E80", VA = "0x181CAB280", Slot = "5")]
		public override void OnChangeState(TemplateCharSelectDetailPlugin.ButtonType btnType)
		{
		}

		// Token: 0x060222AC RID: 139948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60222AC")]
		[Address(RVA = "0x1CAC880", Offset = "0x1CAB480", VA = "0x181CAC880")]
		public CommonCharSelectDetailPlugin()
		{
		}

		// Token: 0x0402ED7E RID: 191870
		[Token(Token = "0x402ED7E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _name;

		// Token: 0x0402ED7F RID: 191871
		[Token(Token = "0x402ED7F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _codeName;

		// Token: 0x0402ED80 RID: 191872
		[Token(Token = "0x402ED80")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _currentLevel;

		// Token: 0x0402ED81 RID: 191873
		[Token(Token = "0x402ED81")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _maxLevel;

		// Token: 0x0402ED82 RID: 191874
		[Token(Token = "0x402ED82")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _maxHp;

		// Token: 0x0402ED83 RID: 191875
		[Token(Token = "0x402ED83")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _atk;

		// Token: 0x0402ED84 RID: 191876
		[Token(Token = "0x402ED84")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _def;

		// Token: 0x0402ED85 RID: 191877
		[Token(Token = "0x402ED85")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _res;

		// Token: 0x0402ED86 RID: 191878
		[Token(Token = "0x402ED86")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _reviveTimeDesc;

		// Token: 0x0402ED87 RID: 191879
		[Token(Token = "0x402ED87")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _cost;

		// Token: 0x0402ED88 RID: 191880
		[Token(Token = "0x402ED88")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _blockNum;

		// Token: 0x0402ED89 RID: 191881
		[Token(Token = "0x402ED89")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _attackSpeedDesc;

		// Token: 0x0402ED8A RID: 191882
		[Token(Token = "0x402ED8A")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image _iconMaxHp;

		// Token: 0x0402ED8B RID: 191883
		[Token(Token = "0x402ED8B")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Image _iconAtk;

		// Token: 0x0402ED8C RID: 191884
		[Token(Token = "0x402ED8C")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Image _iconDef;

		// Token: 0x0402ED8D RID: 191885
		[Token(Token = "0x402ED8D")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Image _iconRes;

		// Token: 0x0402ED8E RID: 191886
		[Token(Token = "0x402ED8E")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Image _iconReviveTime;

		// Token: 0x0402ED8F RID: 191887
		[Token(Token = "0x402ED8F")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Image _iconCost;

		// Token: 0x0402ED90 RID: 191888
		[Token(Token = "0x402ED90")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Image _iconBlockNum;

		// Token: 0x0402ED91 RID: 191889
		[Token(Token = "0x402ED91")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Image _iconAtkSpeed;

		// Token: 0x0402ED92 RID: 191890
		[Token(Token = "0x402ED92")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private UICharacterAttackRangeWidget _attackRange;

		// Token: 0x0402ED93 RID: 191891
		[Token(Token = "0x402ED93")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private CharSelectSkillGroup _skillGroup;

		// Token: 0x0402ED94 RID: 191892
		[Token(Token = "0x402ED94")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private CharSelectBranchGroup _branchGroup;

		// Token: 0x0402ED95 RID: 191893
		[Token(Token = "0x402ED95")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Tooltip("panel to show when no attrs visible")]
		private GameObject _panelEmptyInfo;

		// Token: 0x0402ED96 RID: 191894
		[Token(Token = "0x402ED96")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Tooltip("panel to show when no attrs visible")]
		private GameObject _panelHaveInfo;

		// Token: 0x0402ED97 RID: 191895
		[Token(Token = "0x402ED97")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private GameObject _noUniEquip;

		// Token: 0x0402ED98 RID: 191896
		[Token(Token = "0x402ED98")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private GameObject _lockedUniEquip;

		// Token: 0x0402ED99 RID: 191897
		[Token(Token = "0x402ED99")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private GameObject _haveUniEquip;

		// Token: 0x0402ED9A RID: 191898
		[Token(Token = "0x402ED9A")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private Image _uniqEquipIcon;

		// Token: 0x0402ED9B RID: 191899
		[Token(Token = "0x402ED9B")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private Image _subProfessionIcon;

		// Token: 0x0402ED9C RID: 191900
		[Token(Token = "0x402ED9C")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private List<CommonCharSelectDetailPlugin.TypeBranchButton> _buttonList;

		// Token: 0x0402ED9D RID: 191901
		[Token(Token = "0x402ED9D")]
		[FieldOffset(Offset = "0x110")]
		private TemplateCharSelectDetailPlugin.ButtonType m_selectType;

		// Token: 0x0402ED9E RID: 191902
		[Token(Token = "0x402ED9E")]
		[FieldOffset(Offset = "0x118")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402EDA2 RID: 191906
		[Token(Token = "0x402EDA2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_OnClickDetail;

		// Token: 0x0402EDA3 RID: 191907
		[Token(Token = "0x402EDA3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_OnClickDetail;

		// Token: 0x0402EDA4 RID: 191908
		[Token(Token = "0x402EDA4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_OnSetCharAttribute;

		// Token: 0x0402EDA5 RID: 191909
		[Token(Token = "0x402EDA5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_OnSetCharAttribute;

		// Token: 0x0402EDA6 RID: 191910
		[Token(Token = "0x402EDA6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_mainModel;

		// Token: 0x0402EDA7 RID: 191911
		[Token(Token = "0x402EDA7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_mainModel;

		// Token: 0x0402EDA8 RID: 191912
		[Token(Token = "0x402EDA8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0402EDA9 RID: 191913
		[Token(Token = "0x402EDA9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_RenderEmpty;

		// Token: 0x0402EDAA RID: 191914
		[Token(Token = "0x402EDAA")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_RenderCharDetail;

		// Token: 0x0402EDAB RID: 191915
		[Token(Token = "0x402EDAB")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_RenderPanels;

		// Token: 0x0402EDAC RID: 191916
		[Token(Token = "0x402EDAC")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__SetAttrSprite;

		// Token: 0x0402EDAD RID: 191917
		[Token(Token = "0x402EDAD")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__RenderGroup;

		// Token: 0x0402EDAE RID: 191918
		[Token(Token = "0x402EDAE")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__RenderUniqEquip;

		// Token: 0x0402EDAF RID: 191919
		[Token(Token = "0x402EDAF")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnFetchDetail;

		// Token: 0x0402EDB0 RID: 191920
		[Token(Token = "0x402EDB0")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnSelectSkill;

		// Token: 0x0402EDB1 RID: 191921
		[Token(Token = "0x402EDB1")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnSelectEquip;

		// Token: 0x0402EDB2 RID: 191922
		[Token(Token = "0x402EDB2")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnSelectSkillBar;

		// Token: 0x0402EDB3 RID: 191923
		[Token(Token = "0x402EDB3")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OnSelectBranchBar;

		// Token: 0x0402EDB4 RID: 191924
		[Token(Token = "0x402EDB4")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnChangeState;

		// Token: 0x0402EDB5 RID: 191925
		[Token(Token = "0x402EDB5")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005C0E RID: 23566
		[Token(Token = "0x2005C0E")]
		[Serializable]
		public class TypeBranchButton
		{
			// Token: 0x060222AD RID: 139949 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60222AD")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public TypeBranchButton()
			{
			}

			// Token: 0x0402EDB6 RID: 191926
			[Token(Token = "0x402EDB6")]
			[FieldOffset(Offset = "0x10")]
			public TemplateCharSelectDetailPlugin.ButtonType buttonType;

			// Token: 0x0402EDB7 RID: 191927
			[Token(Token = "0x402EDB7")]
			[FieldOffset(Offset = "0x18")]
			public TwoStateToggle twoStateToggle;
		}
	}
}
