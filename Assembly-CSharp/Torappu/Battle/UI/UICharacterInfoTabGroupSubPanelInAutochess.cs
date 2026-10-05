using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.AutoChess;
using Torappu.Battle.DataCenter;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x020032CE RID: 13006
	[Token(Token = "0x20032CE")]
	public class UICharacterInfoTabGroupSubPanelInAutochess : UICharacterInfoTabGroupSubPanel
	{
		// Token: 0x06014AD6 RID: 84694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014AD6")]
		[Address(RVA = "0xD23930", Offset = "0xD22530", VA = "0x180D23930", Slot = "4")]
		public override void OnInit(UICharacterInfoPanel parent)
		{
		}

		// Token: 0x06014AD7 RID: 84695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014AD7")]
		[Address(RVA = "0xD23A00", Offset = "0xD22600", VA = "0x180D23A00", Slot = "8")]
		public override void Reset()
		{
		}

		// Token: 0x06014AD8 RID: 84696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014AD8")]
		[Address(RVA = "0xD23BA0", Offset = "0xD227A0", VA = "0x180D23BA0", Slot = "5")]
		public override void SetData(ObjectPtr<Character> characterPtr, UICharacterInfoPanel.ModeType mode, Deck.Card card)
		{
		}

		// Token: 0x06014AD9 RID: 84697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014AD9")]
		[Address(RVA = "0xD23EF0", Offset = "0xD22AF0", VA = "0x180D23EF0")]
		private void _OnDataChanged(object arg)
		{
		}

		// Token: 0x06014ADA RID: 84698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014ADA")]
		[Address(RVA = "0xD24030", Offset = "0xD22C30", VA = "0x180D24030")]
		private void _OnGameStateChanged()
		{
		}

		// Token: 0x06014ADB RID: 84699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014ADB")]
		[Address(RVA = "0xD24090", Offset = "0xD22C90", VA = "0x180D24090")]
		private void _OnMapInfoChanged()
		{
		}

		// Token: 0x06014ADC RID: 84700 RVA: 0x00087F48 File Offset: 0x00086148
		[Token(Token = "0x6014ADC")]
		[Address(RVA = "0xD24500", Offset = "0xD23100", VA = "0x180D24500")]
		private bool _RefreshEquipData(ObjectPtr<Character> characterPtr, UICharacterInfoPanel.ModeType mode, Deck.Card card)
		{
			return default(bool);
		}

		// Token: 0x06014ADD RID: 84701 RVA: 0x00087F60 File Offset: 0x00086160
		[Token(Token = "0x6014ADD")]
		[Address(RVA = "0xD240F0", Offset = "0xD22CF0", VA = "0x180D240F0")]
		private bool _RefreshAutoChessAbilityData(ObjectPtr<Character> characterPtr, UICharacterInfoPanel.ModeType mode)
		{
			return default(bool);
		}

		// Token: 0x06014ADE RID: 84702 RVA: 0x00087F78 File Offset: 0x00086178
		[Token(Token = "0x6014ADE")]
		[Address(RVA = "0xD248A0", Offset = "0xD234A0", VA = "0x180D248A0")]
		private bool _UpdateEquip(GridPosition pos)
		{
			return default(bool);
		}

		// Token: 0x06014ADF RID: 84703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014ADF")]
		[Address(RVA = "0xD246C0", Offset = "0xD232C0", VA = "0x180D246C0")]
		private void _UpdateAutoChessAbilityWidgets(ActAutoChessData.ActAutoChessGarrisonData garrisonData)
		{
		}

		// Token: 0x06014AE0 RID: 84704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014AE0")]
		[Address(RVA = "0xD24C00", Offset = "0xD23800", VA = "0x180D24C00")]
		private void _UpdateGroupPanelLayout()
		{
		}

		// Token: 0x06014AE1 RID: 84705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014AE1")]
		[Address(RVA = "0xD23DD0", Offset = "0xD229D0", VA = "0x180D23DD0", Slot = "6")]
		public override void UpdateData(ObjectPtr<Character> characterPtr, UICharacterInfoPanel.ModeType mode, Deck.Card card)
		{
		}

		// Token: 0x06014AE2 RID: 84706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014AE2")]
		[Address(RVA = "0xD24DC0", Offset = "0xD239C0", VA = "0x180D24DC0")]
		public UICharacterInfoTabGroupSubPanelInAutochess()
		{
		}

		// Token: 0x06014AE3 RID: 84707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014AE3")]
		[Address(RVA = "0xD23D50", Offset = "0xD22950", VA = "0x180D23D50")]
		private void <>xLuaBaseProxy_OnInit(UICharacterInfoPanel P0)
		{
		}

		// Token: 0x06014AE4 RID: 84708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014AE4")]
		[Address(RVA = "0xD23D60", Offset = "0xD22960", VA = "0x180D23D60")]
		private void <>xLuaBaseProxy_Reset()
		{
		}

		// Token: 0x06014AE5 RID: 84709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014AE5")]
		[Address(RVA = "0xD23D70", Offset = "0xD22970", VA = "0x180D23D70")]
		private void <>xLuaBaseProxy_SetData(ObjectPtr<Character> P0, UICharacterInfoPanel.ModeType P1, Deck.Card P2)
		{
		}

		// Token: 0x06014AE6 RID: 84710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014AE6")]
		[Address(RVA = "0xD23DA0", Offset = "0xD229A0", VA = "0x180D23DA0")]
		private void <>xLuaBaseProxy_UpdateData(ObjectPtr<Character> P0, UICharacterInfoPanel.ModeType P1, Deck.Card P2)
		{
		}

		// Token: 0x04018868 RID: 100456
		[Token(Token = "0x4018868")]
		private const string AUTOCHESS_CHAR_GARRISON_TAB_I18NKEY = "AUTO_CHESS_CHAR_SELECT_GARRISON";

		// Token: 0x04018869 RID: 100457
		[Token(Token = "0x4018869")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Equip")]
		private UIAutochessEquipPair _equipTextPair;

		// Token: 0x0401886A RID: 100458
		[Token(Token = "0x401886A")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Equip")]
		private LayoutGroup _equipLayoutGroup;

		// Token: 0x0401886B RID: 100459
		[Token(Token = "0x401886B")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("AutoChess Ability")]
		private LayoutGroup _autoChessAbilityLayoutGroup;

		// Token: 0x0401886C RID: 100460
		[Token(Token = "0x401886C")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("AutoChess Ability")]
		private Image _iconAbilityType;

		// Token: 0x0401886D RID: 100461
		[Token(Token = "0x401886D")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("AutoChess Ability")]
		private Text _textAbilityType;

		// Token: 0x0401886E RID: 100462
		[Token(Token = "0x401886E")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("AutoChess Ability")]
		private Text _textAbilityDescription;

		// Token: 0x0401886F RID: 100463
		[Token(Token = "0x401886F")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Group("AutoChess Ability")]
		private Text _autoChessAbilityTabText;

		// Token: 0x04018870 RID: 100464
		[Token(Token = "0x4018870")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[Group("AutoChess Ability")]
		private CancelDragIfFits _abilityDescDragCtrl;

		// Token: 0x04018871 RID: 100465
		[Token(Token = "0x4018871")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[Group("AutoChess Adaptive")]
		private Vector2 _layoutWithoutShop;

		// Token: 0x04018872 RID: 100466
		[Token(Token = "0x4018872")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[Group("AutoChess Adaptive")]
		private Vector2 _layoutWithShop;

		// Token: 0x04018873 RID: 100467
		[Token(Token = "0x4018873")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		[Group("AutoChess Adaptive")]
		private RectTransform _skillPanelRef;

		// Token: 0x04018874 RID: 100468
		[Token(Token = "0x4018874")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		[Group("AutoChess Adaptive")]
		private RectTransform _traitPanelRef;

		// Token: 0x04018875 RID: 100469
		[Token(Token = "0x4018875")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		[Group("AutoChess Adaptive")]
		private RectTransform _subProfessionTraitPanelRef;

		// Token: 0x04018876 RID: 100470
		[Token(Token = "0x4018876")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		[Group("AutoChess Adaptive")]
		private RectTransform _talentPanelRef;

		// Token: 0x04018877 RID: 100471
		[Token(Token = "0x4018877")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		[Group("AutoChess Equip")]
		private RectTransform _equipGroupRef;

		// Token: 0x04018878 RID: 100472
		[Token(Token = "0x4018878")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		[Group("AutoChess Equip")]
		private float _equipGroupYOffsetWhenHasAutoChessAbility;

		// Token: 0x04018879 RID: 100473
		[Token(Token = "0x4018879")]
		[FieldOffset(Offset = "0x12C")]
		[SerializeField]
		[Group("AutoChess Equip")]
		private float _equipGroupYOffsetWhenNoneAutoChessAbility;

		// Token: 0x0401887A RID: 100474
		[Token(Token = "0x401887A")]
		private const string EQUIP_TRACKER_FORMAT = "{0}{1}";

		// Token: 0x0401887B RID: 100475
		[Token(Token = "0x401887B")]
		[FieldOffset(Offset = "0x130")]
		private bool m_isMapDirty;

		// Token: 0x0401887C RID: 100476
		[Token(Token = "0x401887C")]
		[FieldOffset(Offset = "0x131")]
		private bool m_hasGarrisonAbility;

		// Token: 0x0401887D RID: 100477
		[Token(Token = "0x401887D")]
		[FieldOffset(Offset = "0x138")]
		private List<UIAutochessEquipPair> m_equipTextPair;

		// Token: 0x0401887E RID: 100478
		[Token(Token = "0x401887E")]
		[FieldOffset(Offset = "0x140")]
		private AutoChessGameStatus.UIStateChecker m_uiStateChecker;

		// Token: 0x0401887F RID: 100479
		[Token(Token = "0x401887F")]
		[FieldOffset(Offset = "0x148")]
		private AutoChessMapInfoChecker m_mapInfoChecker;

		// Token: 0x04018880 RID: 100480
		[Token(Token = "0x4018880")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04018881 RID: 100481
		[Token(Token = "0x4018881")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04018882 RID: 100482
		[Token(Token = "0x4018882")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x04018883 RID: 100483
		[Token(Token = "0x4018883")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnDataChanged;

		// Token: 0x04018884 RID: 100484
		[Token(Token = "0x4018884")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnGameStateChanged;

		// Token: 0x04018885 RID: 100485
		[Token(Token = "0x4018885")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnMapInfoChanged;

		// Token: 0x04018886 RID: 100486
		[Token(Token = "0x4018886")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RefreshEquipData;

		// Token: 0x04018887 RID: 100487
		[Token(Token = "0x4018887")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RefreshAutoChessAbilityData;

		// Token: 0x04018888 RID: 100488
		[Token(Token = "0x4018888")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__UpdateEquip;

		// Token: 0x04018889 RID: 100489
		[Token(Token = "0x4018889")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__UpdateAutoChessAbilityWidgets;

		// Token: 0x0401888A RID: 100490
		[Token(Token = "0x401888A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__UpdateGroupPanelLayout;

		// Token: 0x0401888B RID: 100491
		[Token(Token = "0x401888B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x0401888C RID: 100492
		[Token(Token = "0x401888C")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
