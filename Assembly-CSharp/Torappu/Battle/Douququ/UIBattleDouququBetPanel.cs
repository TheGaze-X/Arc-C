using System;
using System.Collections;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.AVG;
using Torappu.Battle.GameMode;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.Douququ
{
	// Token: 0x02002A3A RID: 10810
	[Token(Token = "0x2002A3A")]
	public class UIBattleDouququBetPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x06011F1E RID: 73502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F1E")]
		[Address(RVA = "0x9CE650", Offset = "0x9CD250", VA = "0x1809CE650")]
		public void Init(DouququUIPlugin plugin, GameModeFactory.DouququGameMode gameMode)
		{
		}

		// Token: 0x06011F1F RID: 73503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F1F")]
		[Address(RVA = "0x9CEE20", Offset = "0x9CDA20", VA = "0x1809CEE20")]
		public void Show()
		{
		}

		// Token: 0x06011F20 RID: 73504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F20")]
		[Address(RVA = "0x9CF230", Offset = "0x9CDE30", VA = "0x1809CF230")]
		private void _InitIfNotBeforeShow()
		{
		}

		// Token: 0x06011F21 RID: 73505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011F21")]
		[Address(RVA = "0x9D1570", Offset = "0x9D0170", VA = "0x1809D1570")]
		private IEnumerator _WaitForShow()
		{
			return null;
		}

		// Token: 0x06011F22 RID: 73506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F22")]
		[Address(RVA = "0x9CF910", Offset = "0x9CE510", VA = "0x1809CF910")]
		private void _OnBetEnd()
		{
		}

		// Token: 0x06011F23 RID: 73507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F23")]
		[Address(RVA = "0x9D0D60", Offset = "0x9CF960", VA = "0x1809D0D60")]
		private void _ResetAnimationState()
		{
		}

		// Token: 0x06011F24 RID: 73508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F24")]
		[Address(RVA = "0x9D0950", Offset = "0x9CF550", VA = "0x1809D0950")]
		private void _OnManPageOn()
		{
		}

		// Token: 0x06011F25 RID: 73509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F25")]
		[Address(RVA = "0x9D09C0", Offset = "0x9CF5C0", VA = "0x1809D09C0")]
		private void _OnVsPageOn()
		{
		}

		// Token: 0x06011F26 RID: 73510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F26")]
		[Address(RVA = "0x9CFD50", Offset = "0x9CE950", VA = "0x1809CFD50")]
		private void _OnBetPageOn()
		{
		}

		// Token: 0x06011F27 RID: 73511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F27")]
		[Address(RVA = "0x9D0360", Offset = "0x9CEF60", VA = "0x1809D0360")]
		private void _OnInfoPageOn()
		{
		}

		// Token: 0x06011F28 RID: 73512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F28")]
		[Address(RVA = "0x9D13F0", Offset = "0x9CFFF0", VA = "0x1809D13F0")]
		private void _UpdateUIVisibility()
		{
		}

		// Token: 0x06011F29 RID: 73513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F29")]
		[Address(RVA = "0x9D1310", Offset = "0x9CFF10", VA = "0x1809D1310")]
		private void _UpdateBackBtnState(bool isInteractable)
		{
		}

		// Token: 0x06011F2A RID: 73514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F2A")]
		[Address(RVA = "0x9D0F00", Offset = "0x9CFB00", VA = "0x1809D0F00")]
		private void _UpdateBackBtnIcon()
		{
		}

		// Token: 0x06011F2B RID: 73515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F2B")]
		[Address(RVA = "0x9CE780", Offset = "0x9CD380", VA = "0x1809CE780")]
		public void OnBackBtnClick()
		{
		}

		// Token: 0x06011F2C RID: 73516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F2C")]
		[Address(RVA = "0x9CEC10", Offset = "0x9CD810", VA = "0x1809CEC10")]
		public void OnTeamDetailsClick()
		{
		}

		// Token: 0x06011F2D RID: 73517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F2D")]
		[Address(RVA = "0x9CEA00", Offset = "0x9CD600", VA = "0x1809CEA00")]
		public void OnCloseTeamDetails()
		{
		}

		// Token: 0x06011F2E RID: 73518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F2E")]
		[Address(RVA = "0x9CE900", Offset = "0x9CD500", VA = "0x1809CE900")]
		public void OnChooseClick(bool isLeft)
		{
		}

		// Token: 0x06011F2F RID: 73519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F2F")]
		[Address(RVA = "0x9CE860", Offset = "0x9CD460", VA = "0x1809CE860")]
		public void OnBetClick(int selection)
		{
		}

		// Token: 0x06011F30 RID: 73520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F30")]
		[Address(RVA = "0x9CE800", Offset = "0x9CD400", VA = "0x1809CE800")]
		public void OnBattleStartClick()
		{
		}

		// Token: 0x06011F31 RID: 73521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F31")]
		[Address(RVA = "0x9D1620", Offset = "0x9D0220", VA = "0x1809D1620")]
		public UIBattleDouququBetPanel()
		{
		}

		// Token: 0x040143CD RID: 82893
		[Token(Token = "0x40143CD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Main")]
		private GameObject _baseElement;

		// Token: 0x040143CE RID: 82894
		[Token(Token = "0x40143CE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Main")]
		private Image _black;

		// Token: 0x040143CF RID: 82895
		[Token(Token = "0x40143CF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Main")]
		private GameObject _textMain;

		// Token: 0x040143D0 RID: 82896
		[Token(Token = "0x40143D0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Main")]
		private Button _buttonBack;

		// Token: 0x040143D1 RID: 82897
		[Token(Token = "0x40143D1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Main")]
		private GameObject _imgInteractable;

		// Token: 0x040143D2 RID: 82898
		[Token(Token = "0x40143D2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Main")]
		private GameObject _imgNotInteractable;

		// Token: 0x040143D3 RID: 82899
		[Token(Token = "0x40143D3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Main")]
		private GameObject _blocker;

		// Token: 0x040143D4 RID: 82900
		[Token(Token = "0x40143D4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Main")]
		private Text _mainText;

		// Token: 0x040143D5 RID: 82901
		[Token(Token = "0x40143D5")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Man")]
		private GameObject _pageMan;

		// Token: 0x040143D6 RID: 82902
		[Token(Token = "0x40143D6")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Man")]
		private AVGTypeWriterText _contentTypeWriter;

		// Token: 0x040143D7 RID: 82903
		[Token(Token = "0x40143D7")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Page VS")]
		private RectTransform _pageVs;

		// Token: 0x040143D8 RID: 82904
		[Token(Token = "0x40143D8")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Page VS")]
		private Button _buttonDetails;

		// Token: 0x040143D9 RID: 82905
		[Token(Token = "0x40143D9")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Page VS")]
		private SimpleLayoutContent _leftEnemyList;

		// Token: 0x040143DA RID: 82906
		[Token(Token = "0x40143DA")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Page VS")]
		private SimpleLayoutContent _rightEnemyList;

		// Token: 0x040143DB RID: 82907
		[Token(Token = "0x40143DB")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Page VS")]
		private SimpleLayoutContent _leftNpcList;

		// Token: 0x040143DC RID: 82908
		[Token(Token = "0x40143DC")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Page VS")]
		private SimpleLayoutContent _rightNpcList;

		// Token: 0x040143DD RID: 82909
		[Token(Token = "0x40143DD")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Page VS")]
		private GameObject _pageTxt;

		// Token: 0x040143DE RID: 82910
		[Token(Token = "0x40143DE")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Page VS")]
		private GameObject _txtBtn;

		// Token: 0x040143DF RID: 82911
		[Token(Token = "0x40143DF")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Page VS")]
		private Text _leftTeamDetails;

		// Token: 0x040143E0 RID: 82912
		[Token(Token = "0x40143E0")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Page VS")]
		private Text _rightTeamDetails;

		// Token: 0x040143E1 RID: 82913
		[Token(Token = "0x40143E1")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Page VS")]
		private Text _leftChoiceText;

		// Token: 0x040143E2 RID: 82914
		[Token(Token = "0x40143E2")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Page VS")]
		private Text _rightChoiceText;

		// Token: 0x040143E3 RID: 82915
		[Token(Token = "0x40143E3")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Page Bet")]
		private RectTransform _pageBet;

		// Token: 0x040143E4 RID: 82916
		[Token(Token = "0x40143E4")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("Page Bet")]
		private GameObject _choiceAll;

		// Token: 0x040143E5 RID: 82917
		[Token(Token = "0x40143E5")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("Page Bet")]
		private Text _balance;

		// Token: 0x040143E6 RID: 82918
		[Token(Token = "0x40143E6")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Group("Page Bet")]
		private Text _odds;

		// Token: 0x040143E7 RID: 82919
		[Token(Token = "0x40143E7")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[Group("Page Bet")]
		private GameObject _streak;

		// Token: 0x040143E8 RID: 82920
		[Token(Token = "0x40143E8")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[Group("Page Bet")]
		private Text _choiceText1;

		// Token: 0x040143E9 RID: 82921
		[Token(Token = "0x40143E9")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[Group("Page Bet")]
		private Text _choiceText2;

		// Token: 0x040143EA RID: 82922
		[Token(Token = "0x40143EA")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		[Group("Page Bet")]
		private Text _choiceText3;

		// Token: 0x040143EB RID: 82923
		[Token(Token = "0x40143EB")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		[Group("Page Bet")]
		private Text _choiceText4;

		// Token: 0x040143EC RID: 82924
		[Token(Token = "0x40143EC")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		[Group("Page Info")]
		private RectTransform _pageInfo;

		// Token: 0x040143ED RID: 82925
		[Token(Token = "0x40143ED")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		[Group("Page Info")]
		private GameObject _chooseLeft;

		// Token: 0x040143EE RID: 82926
		[Token(Token = "0x40143EE")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		[Group("Page Info")]
		private GameObject _chooseRight;

		// Token: 0x040143EF RID: 82927
		[Token(Token = "0x40143EF")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		[Group("Page Info")]
		private Text _oddsInfo;

		// Token: 0x040143F0 RID: 82928
		[Token(Token = "0x40143F0")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		[Group("Page Info")]
		private GameObject _streakInfo;

		// Token: 0x040143F1 RID: 82929
		[Token(Token = "0x40143F1")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		[Group("Page Info")]
		private Text _investment;

		// Token: 0x040143F2 RID: 82930
		[Token(Token = "0x40143F2")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		[Group("Page Info")]
		private GameObject _choose10;

		// Token: 0x040143F3 RID: 82931
		[Token(Token = "0x40143F3")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		[Group("Page Info")]
		private GameObject _choose25;

		// Token: 0x040143F4 RID: 82932
		[Token(Token = "0x40143F4")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		[Group("Page Info")]
		private GameObject _choose50;

		// Token: 0x040143F5 RID: 82933
		[Token(Token = "0x40143F5")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		[Group("Page Info")]
		private GameObject _choose100;

		// Token: 0x040143F6 RID: 82934
		[Token(Token = "0x40143F6")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		[Group("Page Info")]
		private GameObject _iconNormal;

		// Token: 0x040143F7 RID: 82935
		[Token(Token = "0x40143F7")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		[Group("Page Info")]
		private GameObject _iconAll;

		// Token: 0x040143F8 RID: 82936
		[Token(Token = "0x40143F8")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		[Group("Page Info")]
		private Text _bonus;

		// Token: 0x040143F9 RID: 82937
		[Token(Token = "0x40143F9")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		[Group("Back Btn")]
		private GameObject _chooseIconNotSelected;

		// Token: 0x040143FA RID: 82938
		[Token(Token = "0x40143FA")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		[Group("Back Btn")]
		private GameObject _chooseIconProcessing;

		// Token: 0x040143FB RID: 82939
		[Token(Token = "0x40143FB")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		[Group("Back Btn")]
		private GameObject _chooseIconDone;

		// Token: 0x040143FC RID: 82940
		[Token(Token = "0x40143FC")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		[Group("Back Btn")]
		private GameObject _moneyIconNotSelected;

		// Token: 0x040143FD RID: 82941
		[Token(Token = "0x40143FD")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		[Group("Back Btn")]
		private GameObject _moneyIconProcessing;

		// Token: 0x040143FE RID: 82942
		[Token(Token = "0x40143FE")]
		[FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		[Group("Back Btn")]
		private GameObject _moneyIconDone;

		// Token: 0x040143FF RID: 82943
		[Token(Token = "0x40143FF")]
		[FieldOffset(Offset = "0x1A8")]
		[SerializeField]
		[Group("Back Btn")]
		private Text _chooseText;

		// Token: 0x04014400 RID: 82944
		[Token(Token = "0x4014400")]
		[FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		[Group("Back Btn")]
		private Text _betText;

		// Token: 0x04014401 RID: 82945
		[Token(Token = "0x4014401")]
		[FieldOffset(Offset = "0x1B8")]
		[SerializeField]
		[Group("Back Btn")]
		private Color _notYetColor;

		// Token: 0x04014402 RID: 82946
		[Token(Token = "0x4014402")]
		[FieldOffset(Offset = "0x1C8")]
		[SerializeField]
		[Group("Back Btn")]
		private Color _ingColor;

		// Token: 0x04014403 RID: 82947
		[Token(Token = "0x4014403")]
		[FieldOffset(Offset = "0x1D8")]
		[SerializeField]
		[Group("Back Btn")]
		private Color _doneColor;

		// Token: 0x04014404 RID: 82948
		[Token(Token = "0x4014404")]
		[FieldOffset(Offset = "0x1E8")]
		[SerializeField]
		[Group("Animation Wrapper")]
		private UIAnimationLocation _mainWrapper;

		// Token: 0x04014405 RID: 82949
		[Token(Token = "0x4014405")]
		[FieldOffset(Offset = "0x1F8")]
		[SerializeField]
		[Group("Animation Wrapper")]
		private AnimationWrapper _downWrapper;

		// Token: 0x04014406 RID: 82950
		[Token(Token = "0x4014406")]
		[FieldOffset(Offset = "0x200")]
		[SerializeField]
		[Group("Animation Wrapper")]
		private UIAnimationLocation _detailsWrapper;

		// Token: 0x04014407 RID: 82951
		[Token(Token = "0x4014407")]
		[FieldOffset(Offset = "0x210")]
		[SerializeField]
		[Group("Animation Wrapper")]
		private UIAnimationLocation _txtWrapper;

		// Token: 0x04014408 RID: 82952
		[Token(Token = "0x4014408")]
		[FieldOffset(Offset = "0x220")]
		[SerializeField]
		[Group("Animation Wrapper")]
		private AnimationWrapper _btnWrapper;

		// Token: 0x04014409 RID: 82953
		[Token(Token = "0x4014409")]
		[FieldOffset(Offset = "0x228")]
		[SerializeField]
		[Group("Animation Wrapper")]
		private AnimationWrapper _btnWrapper2;

		// Token: 0x0401440A RID: 82954
		[Token(Token = "0x401440A")]
		[FieldOffset(Offset = "0x230")]
		private BetPage m_curPage;

		// Token: 0x0401440B RID: 82955
		[Token(Token = "0x401440B")]
		[FieldOffset(Offset = "0x238")]
		private GameModeFactory.DouququGameMode m_gameMode;

		// Token: 0x0401440C RID: 82956
		[Token(Token = "0x401440C")]
		[FieldOffset(Offset = "0x240")]
		private DouququUIPlugin m_plugin;

		// Token: 0x0401440D RID: 82957
		[Token(Token = "0x401440D")]
		[FieldOffset(Offset = "0x248")]
		private readonly List<Vector3> m_posList;

		// Token: 0x0401440E RID: 82958
		[Token(Token = "0x401440E")]
		[FieldOffset(Offset = "0x250")]
		private bool m_hasInitialized;

		// Token: 0x0401440F RID: 82959
		[Token(Token = "0x401440F")]
		[FieldOffset(Offset = "0x258")]
		private UIBattleDouququBetPanel.DouququNpcItemListAdapter m_leftNpcAdapter;

		// Token: 0x04014410 RID: 82960
		[Token(Token = "0x4014410")]
		[FieldOffset(Offset = "0x260")]
		private UIBattleDouququBetPanel.DouququNpcItemListAdapter m_rightNpcAdapter;

		// Token: 0x04014411 RID: 82961
		[Token(Token = "0x4014411")]
		[FieldOffset(Offset = "0x268")]
		private UIBattleDouququBetPanel.DouququEnemyItemListAdapter m_leftEnemyAdapter;

		// Token: 0x04014412 RID: 82962
		[Token(Token = "0x4014412")]
		[FieldOffset(Offset = "0x270")]
		private UIBattleDouququBetPanel.DouququEnemyItemListAdapter m_rightEnemyAdapter;

		// Token: 0x04014413 RID: 82963
		[Token(Token = "0x4014413")]
		private const string DOUQUQU_UI_ANIMATION_ENTRY = "douququ_bet_panel_move";

		// Token: 0x04014414 RID: 82964
		[Token(Token = "0x4014414")]
		private const string DOUQUQU_BET_DOWN_ENTRY = "douququ_bet_down_entry";

		// Token: 0x04014415 RID: 82965
		[Token(Token = "0x4014415")]
		private const string DOUQUQU_BET_DOWN_PAGE_SWITCH_BAT_TO_VS = "douququ_bet_down_page_switch_bat_to_vs";

		// Token: 0x04014416 RID: 82966
		[Token(Token = "0x4014416")]
		private const string DOUQUQU_BET_DOWN_PAGE_SWITCH_BET_TO_INFO = "douququ_bet_down_page_switch_bet_to_info";

		// Token: 0x04014417 RID: 82967
		[Token(Token = "0x4014417")]
		private const string DOUQUQU_BET_DOWN_PAGE_SWITCH_INFO_TO_BET = "douququ_bet_down_page_switch_info_to_bet";

		// Token: 0x04014418 RID: 82968
		[Token(Token = "0x4014418")]
		private const string DOUQUQU_BET_DOWN_PAGE_SWITCH_VS_TO_BET = "douququ_bet_down_page_switch_vs_to_bet";

		// Token: 0x04014419 RID: 82969
		[Token(Token = "0x4014419")]
		private const string DOUQUQU_BATTLE_BTN_DETAILS_ENTRY = "douququ_battle_btn_details_entry";

		// Token: 0x0401441A RID: 82970
		[Token(Token = "0x401441A")]
		private const string DOUQUQU_BATTLE_PAGE_TXT_ENTRY = "douququ_battle_page_txt_entry";

		// Token: 0x0401441B RID: 82971
		[Token(Token = "0x401441B")]
		private const string DOUQUQU_TEXT_CHOICE_ROTATION_LOOP = "douququ_text_choice_rotation_loop";

		// Token: 0x0401441C RID: 82972
		[Token(Token = "0x401441C")]
		private const int ENEMY_ITEM_COUNT = 3;

		// Token: 0x0401441D RID: 82973
		[Token(Token = "0x401441D")]
		private const int MAX_CHOICE_CNT = 4;

		// Token: 0x0401441E RID: 82974
		[Token(Token = "0x401441E")]
		private const float MAIN_PAGE_WAIT_TIME = 1f;

		// Token: 0x0401441F RID: 82975
		[Token(Token = "0x401441F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04014420 RID: 82976
		[Token(Token = "0x4014420")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x04014421 RID: 82977
		[Token(Token = "0x4014421")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNotBeforeShow;

		// Token: 0x04014422 RID: 82978
		[Token(Token = "0x4014422")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__WaitForShow;

		// Token: 0x04014423 RID: 82979
		[Token(Token = "0x4014423")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnBetEnd;

		// Token: 0x04014424 RID: 82980
		[Token(Token = "0x4014424")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ResetAnimationState;

		// Token: 0x04014425 RID: 82981
		[Token(Token = "0x4014425")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnManPageOn;

		// Token: 0x04014426 RID: 82982
		[Token(Token = "0x4014426")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnVsPageOn;

		// Token: 0x04014427 RID: 82983
		[Token(Token = "0x4014427")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnBetPageOn;

		// Token: 0x04014428 RID: 82984
		[Token(Token = "0x4014428")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnInfoPageOn;

		// Token: 0x04014429 RID: 82985
		[Token(Token = "0x4014429")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__UpdateUIVisibility;

		// Token: 0x0401442A RID: 82986
		[Token(Token = "0x401442A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__UpdateBackBtnState;

		// Token: 0x0401442B RID: 82987
		[Token(Token = "0x401442B")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__UpdateBackBtnIcon;

		// Token: 0x0401442C RID: 82988
		[Token(Token = "0x401442C")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnBackBtnClick;

		// Token: 0x0401442D RID: 82989
		[Token(Token = "0x401442D")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnTeamDetailsClick;

		// Token: 0x0401442E RID: 82990
		[Token(Token = "0x401442E")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnCloseTeamDetails;

		// Token: 0x0401442F RID: 82991
		[Token(Token = "0x401442F")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnChooseClick;

		// Token: 0x04014430 RID: 82992
		[Token(Token = "0x4014430")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OnBetClick;

		// Token: 0x04014431 RID: 82993
		[Token(Token = "0x4014431")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnBattleStartClick;

		// Token: 0x04014432 RID: 82994
		[Token(Token = "0x4014432")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002A3B RID: 10811
		[Token(Token = "0x2002A3B")]
		private class DouququNpcItemListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17002777 RID: 10103
			// (get) Token: 0x06011F3A RID: 73530 RVA: 0x0006DC38 File Offset: 0x0006BE38
			[Token(Token = "0x17002777")]
			public override int count
			{
				[Token(Token = "0x6011F3A")]
				[Address(RVA = "0x9C4490", Offset = "0x9C3090", VA = "0x1809C4490", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06011F3B RID: 73531 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6011F3B")]
			[Address(RVA = "0x9C4210", Offset = "0x9C2E10", VA = "0x1809C4210", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06011F3C RID: 73532 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011F3C")]
			[Address(RVA = "0x9C4430", Offset = "0x9C3030", VA = "0x1809C4430")]
			public DouququNpcItemListAdapter()
			{
			}

			// Token: 0x04014433 RID: 82995
			[Token(Token = "0x4014433")]
			[FieldOffset(Offset = "0x20")]
			public bool isLeft;

			// Token: 0x04014434 RID: 82996
			[Token(Token = "0x4014434")]
			[FieldOffset(Offset = "0x28")]
			public GameModeFactory.DouququGameMode gameMode;

			// Token: 0x04014435 RID: 82997
			[Token(Token = "0x4014435")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04014436 RID: 82998
			[Token(Token = "0x4014436")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04014437 RID: 82999
			[Token(Token = "0x4014437")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02002A3C RID: 10812
		[Token(Token = "0x2002A3C")]
		private class DouququEnemyItemListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17002778 RID: 10104
			// (get) Token: 0x06011F3D RID: 73533 RVA: 0x0006DC50 File Offset: 0x0006BE50
			[Token(Token = "0x17002778")]
			public override int count
			{
				[Token(Token = "0x6011F3D")]
				[Address(RVA = "0x9C30A0", Offset = "0x9C1CA0", VA = "0x1809C30A0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06011F3E RID: 73534 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6011F3E")]
			[Address(RVA = "0x9C2E90", Offset = "0x9C1A90", VA = "0x1809C2E90", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06011F3F RID: 73535 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011F3F")]
			[Address(RVA = "0x9C3040", Offset = "0x9C1C40", VA = "0x1809C3040")]
			public DouququEnemyItemListAdapter()
			{
			}

			// Token: 0x04014438 RID: 83000
			[Token(Token = "0x4014438")]
			[FieldOffset(Offset = "0x20")]
			public bool isLeft;

			// Token: 0x04014439 RID: 83001
			[Token(Token = "0x4014439")]
			[FieldOffset(Offset = "0x28")]
			public GameModeFactory.DouququGameMode gameMode;

			// Token: 0x0401443A RID: 83002
			[Token(Token = "0x401443A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401443B RID: 83003
			[Token(Token = "0x401443B")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0401443C RID: 83004
			[Token(Token = "0x401443C")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
