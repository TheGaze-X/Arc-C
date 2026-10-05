using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.CharSelect;
using Torappu.UI.Squad;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D57 RID: 23895
	[Token(Token = "0x2005D57")]
	public class ClimbTowerSquadCreateState : PopupFadeState, ISquadCharSelectContext
	{
		// Token: 0x0602299C RID: 141724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602299C")]
		[Address(RVA = "0x1D21A40", Offset = "0x1D20640", VA = "0x181D21A40", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602299D RID: 141725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602299D")]
		[Address(RVA = "0x1D23B70", Offset = "0x1D22770", VA = "0x181D23B70")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602299E RID: 141726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602299E")]
		[Address(RVA = "0x1D21FE0", Offset = "0x1D20BE0", VA = "0x181D21FE0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0602299F RID: 141727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602299F")]
		[Address(RVA = "0x1D21E00", Offset = "0x1D20A00", VA = "0x181D21E00", Slot = "17")]
		protected override void OnPause()
		{
		}

		// Token: 0x060229A0 RID: 141728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60229A0")]
		[Address(RVA = "0x1D21360", Offset = "0x1D1FF60", VA = "0x181D21360", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060229A1 RID: 141729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60229A1")]
		[Address(RVA = "0x1D22460", Offset = "0x1D21060", VA = "0x181D22460", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x060229A2 RID: 141730 RVA: 0x000BE020 File Offset: 0x000BC220
		[Token(Token = "0x60229A2")]
		[Address(RVA = "0x1D22E80", Offset = "0x1D21A80", VA = "0x181D22E80", Slot = "12")]
		public override bool UseEarlyFromDataListener(Type fromState)
		{
			return default(bool);
		}

		// Token: 0x060229A3 RID: 141731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60229A3")]
		[Address(RVA = "0x1D22290", Offset = "0x1D20E90", VA = "0x181D22290", Slot = "11")]
		public override Dictionary<Type, Action<IStateBean>> RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x060229A4 RID: 141732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60229A4")]
		[Address(RVA = "0x1D21480", Offset = "0x1D20080", VA = "0x181D21480", Slot = "31")]
		public List<int> GetTempListForExclusiveInstIds()
		{
			return null;
		}

		// Token: 0x060229A5 RID: 141733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60229A5")]
		[Address(RVA = "0x1D213C0", Offset = "0x1D1FFC0", VA = "0x181D213C0", Slot = "32")]
		public SquadGroupViewModel GetSquadGroupViewModel()
		{
			return null;
		}

		// Token: 0x060229A6 RID: 141734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60229A6")]
		[Address(RVA = "0x1D22DD0", Offset = "0x1D219D0", VA = "0x181D22DD0")]
		private void _NavToLayerState()
		{
		}

		// Token: 0x060229A7 RID: 141735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60229A7")]
		[Address(RVA = "0x1D21E70", Offset = "0x1D20A70", VA = "0x181D21E70")]
		public void OnQuickFormatClick()
		{
		}

		// Token: 0x060229A8 RID: 141736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60229A8")]
		[Address(RVA = "0x1D217B0", Offset = "0x1D203B0", VA = "0x181D217B0")]
		public void OnBtnQuit()
		{
		}

		// Token: 0x060229A9 RID: 141737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60229A9")]
		[Address(RVA = "0x1D251B0", Offset = "0x1D23DB0", VA = "0x181D251B0")]
		private void _SendSettleGameRequest()
		{
		}

		// Token: 0x060229AA RID: 141738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60229AA")]
		[Address(RVA = "0x1D214E0", Offset = "0x1D200E0", VA = "0x181D214E0")]
		public void OnBtnAssistClick()
		{
		}

		// Token: 0x060229AB RID: 141739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60229AB")]
		[Address(RVA = "0x1D22EF0", Offset = "0x1D21AF0", VA = "0x181D22EF0")]
		private void _EventOnAssistClean(int memberIndex)
		{
		}

		// Token: 0x060229AC RID: 141740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60229AC")]
		[Address(RVA = "0x1D230D0", Offset = "0x1D21CD0", VA = "0x181D230D0")]
		private void _EventOnGetAssist(int index)
		{
		}

		// Token: 0x060229AD RID: 141741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60229AD")]
		[Address(RVA = "0x1D238C0", Offset = "0x1D224C0", VA = "0x181D238C0")]
		private void _EventOnSingleFormatClick(int memberIndex)
		{
		}

		// Token: 0x060229AE RID: 141742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60229AE")]
		[Address(RVA = "0x1D23790", Offset = "0x1D22390", VA = "0x181D23790")]
		private void _EventOnMultiFormatClick()
		{
		}

		// Token: 0x060229AF RID: 141743 RVA: 0x000BE038 File Offset: 0x000BC238
		[Token(Token = "0x60229AF")]
		[Address(RVA = "0x1D245F0", Offset = "0x1D231F0", VA = "0x181D245F0")]
		private CharSelectStateBean.Input _ParseSquadSelectParam(bool isSingleMode, int memberIndex)
		{
			return default(CharSelectStateBean.Input);
		}

		// Token: 0x060229B0 RID: 141744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60229B0")]
		[Address(RVA = "0x1D23470", Offset = "0x1D22070", VA = "0x181D23470")]
		private void _EventOnMenuButtonClick()
		{
		}

		// Token: 0x060229B1 RID: 141745 RVA: 0x000BE050 File Offset: 0x000BC250
		[Token(Token = "0x60229B1")]
		[Address(RVA = "0x1D23A10", Offset = "0x1D22610", VA = "0x181D23A10")]
		private int _GetProfessionCharCount(ProfessionCategory profession)
		{
			return 0;
		}

		// Token: 0x060229B2 RID: 141746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60229B2")]
		[Address(RVA = "0x1D23F30", Offset = "0x1D22B30", VA = "0x181D23F30")]
		private void _InitSquad()
		{
		}

		// Token: 0x060229B3 RID: 141747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60229B3")]
		[Address(RVA = "0x1D22D30", Offset = "0x1D21930", VA = "0x181D22D30")]
		private void _NavToTowreLayerState()
		{
		}

		// Token: 0x060229B4 RID: 141748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60229B4")]
		[Address(RVA = "0x1D24E80", Offset = "0x1D23A80", VA = "0x181D24E80")]
		private void _SaveDataToLocalCache()
		{
		}

		// Token: 0x060229B5 RID: 141749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60229B5")]
		[Address(RVA = "0x1D25040", Offset = "0x1D23C40", VA = "0x181D25040")]
		private void _SaveTowerSelectModeToCache()
		{
		}

		// Token: 0x060229B6 RID: 141750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60229B6")]
		[Address(RVA = "0x1D25470", Offset = "0x1D24070", VA = "0x181D25470")]
		private void _TriggerTutorialCoroutine()
		{
		}

		// Token: 0x060229B7 RID: 141751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60229B7")]
		[Address(RVA = "0x1D253C0", Offset = "0x1D23FC0", VA = "0x181D253C0")]
		private void _StopTutorialCoroutine()
		{
		}

		// Token: 0x060229B8 RID: 141752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60229B8")]
		[Address(RVA = "0x1D255B0", Offset = "0x1D241B0", VA = "0x181D255B0")]
		private IEnumerator _WaitAndTrigTutorial()
		{
			return null;
		}

		// Token: 0x060229B9 RID: 141753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60229B9")]
		[Address(RVA = "0x1D25660", Offset = "0x1D24260", VA = "0x181D25660")]
		public ClimbTowerSquadCreateState()
		{
		}

		// Token: 0x060229C0 RID: 141760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60229C0")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x060229C1 RID: 141761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60229C1")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x060229C2 RID: 141762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60229C2")]
		[Address(RVA = "0xF807D0", Offset = "0xF7F3D0", VA = "0x180F807D0")]
		private void <>xLuaBaseProxy_OnPause()
		{
		}

		// Token: 0x060229C3 RID: 141763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60229C3")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x060229C4 RID: 141764 RVA: 0x000BE068 File Offset: 0x000BC268
		[Token(Token = "0x60229C4")]
		[Address(RVA = "0x11033F0", Offset = "0x1101FF0", VA = "0x1811033F0")]
		private bool <>xLuaBaseProxy_UseEarlyFromDataListener(Type P0)
		{
			return default(bool);
		}

		// Token: 0x060229C5 RID: 141765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60229C5")]
		[Address(RVA = "0xE63470", Offset = "0xE62070", VA = "0x180E63470")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x0402F8F8 RID: 194808
		[Token(Token = "0x402F8F8")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ClimbTowerSquadCreateView _view;

		// Token: 0x0402F8F9 RID: 194809
		[Token(Token = "0x402F8F9")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private SimpleLayoutContent _stepList;

		// Token: 0x0402F8FA RID: 194810
		[Token(Token = "0x402F8FA")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private SquadCharSelectMaskPlugin _charSelectMaskPluginPrefab;

		// Token: 0x0402F8FB RID: 194811
		[Token(Token = "0x402F8FB")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private ClimbTowerMenuButton _menuButtonPrefab;

		// Token: 0x0402F8FC RID: 194812
		[Token(Token = "0x402F8FC")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RectTransform _backBtnRt;

		// Token: 0x0402F8FD RID: 194813
		[Token(Token = "0x402F8FD")]
		[FieldOffset(Offset = "0x98")]
		private ClimbTowerSquadCreateStateBean m_stateBean;

		// Token: 0x0402F8FE RID: 194814
		[Token(Token = "0x402F8FE")]
		[FieldOffset(Offset = "0xA0")]
		private CharSelectStateBean.Input m_paramToSelectState;

		// Token: 0x0402F8FF RID: 194815
		[Token(Token = "0x402F8FF")]
		[FieldOffset(Offset = "0xE0")]
		private ClimbTowerInitStepListAdapter m_stepAdapter;

		// Token: 0x0402F900 RID: 194816
		[Token(Token = "0x402F900")]
		[FieldOffset(Offset = "0xE8")]
		private ClimbTowerSquadCreateState.MenuAdapter m_menuAdapter;

		// Token: 0x0402F901 RID: 194817
		[Token(Token = "0x402F901")]
		[FieldOffset(Offset = "0xF0")]
		private Coroutine m_tutorialCoroutine;

		// Token: 0x0402F902 RID: 194818
		[Token(Token = "0x402F902")]
		[FieldOffset(Offset = "0xF8")]
		private List<int> m_tempListForExclusiveInstIds;

		// Token: 0x0402F903 RID: 194819
		[Token(Token = "0x402F903")]
		[FieldOffset(Offset = "0x100")]
		private bool m_hasInited;

		// Token: 0x0402F904 RID: 194820
		[Token(Token = "0x402F904")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402F905 RID: 194821
		[Token(Token = "0x402F905")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402F906 RID: 194822
		[Token(Token = "0x402F906")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0402F907 RID: 194823
		[Token(Token = "0x402F907")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnPause;

		// Token: 0x0402F908 RID: 194824
		[Token(Token = "0x402F908")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402F909 RID: 194825
		[Token(Token = "0x402F909")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0402F90A RID: 194826
		[Token(Token = "0x402F90A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_UseEarlyFromDataListener;

		// Token: 0x0402F90B RID: 194827
		[Token(Token = "0x402F90B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_RegisterFromDataListener;

		// Token: 0x0402F90C RID: 194828
		[Token(Token = "0x402F90C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetTempListForExclusiveInstIds;

		// Token: 0x0402F90D RID: 194829
		[Token(Token = "0x402F90D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetSquadGroupViewModel;

		// Token: 0x0402F90E RID: 194830
		[Token(Token = "0x402F90E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__NavToLayerState;

		// Token: 0x0402F90F RID: 194831
		[Token(Token = "0x402F90F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnQuickFormatClick;

		// Token: 0x0402F910 RID: 194832
		[Token(Token = "0x402F910")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnBtnQuit;

		// Token: 0x0402F911 RID: 194833
		[Token(Token = "0x402F911")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__SendSettleGameRequest;

		// Token: 0x0402F912 RID: 194834
		[Token(Token = "0x402F912")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnBtnAssistClick;

		// Token: 0x0402F913 RID: 194835
		[Token(Token = "0x402F913")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__EventOnAssistClean;

		// Token: 0x0402F914 RID: 194836
		[Token(Token = "0x402F914")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__EventOnGetAssist;

		// Token: 0x0402F915 RID: 194837
		[Token(Token = "0x402F915")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__EventOnSingleFormatClick;

		// Token: 0x0402F916 RID: 194838
		[Token(Token = "0x402F916")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__EventOnMultiFormatClick;

		// Token: 0x0402F917 RID: 194839
		[Token(Token = "0x402F917")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__ParseSquadSelectParam;

		// Token: 0x0402F918 RID: 194840
		[Token(Token = "0x402F918")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__EventOnMenuButtonClick;

		// Token: 0x0402F919 RID: 194841
		[Token(Token = "0x402F919")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__GetProfessionCharCount;

		// Token: 0x0402F91A RID: 194842
		[Token(Token = "0x402F91A")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__InitSquad;

		// Token: 0x0402F91B RID: 194843
		[Token(Token = "0x402F91B")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__NavToTowreLayerState;

		// Token: 0x0402F91C RID: 194844
		[Token(Token = "0x402F91C")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__SaveDataToLocalCache;

		// Token: 0x0402F91D RID: 194845
		[Token(Token = "0x402F91D")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__SaveTowerSelectModeToCache;

		// Token: 0x0402F91E RID: 194846
		[Token(Token = "0x402F91E")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__TriggerTutorialCoroutine;

		// Token: 0x0402F91F RID: 194847
		[Token(Token = "0x402F91F")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__StopTutorialCoroutine;

		// Token: 0x0402F920 RID: 194848
		[Token(Token = "0x402F920")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__WaitAndTrigTutorial;

		// Token: 0x0402F921 RID: 194849
		[Token(Token = "0x402F921")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005D58 RID: 23896
		[Token(Token = "0x2005D58")]
		private class SquadAssistPlugin : SquadFriendAssistState.Plugin<ClimbTowerSquadCreateState>
		{
			// Token: 0x060229C6 RID: 141766 RVA: 0x000BE080 File Offset: 0x000BC280
			[Token(Token = "0x60229C6")]
			[Address(RVA = "0x1D2F010", Offset = "0x1D2DC10", VA = "0x181D2F010", Slot = "9")]
			public override bool CheckIfCharValid(CharQuery charQuery, ref SquadFriendListItem.LockedStyle lockStyleConfig)
			{
				return default(bool);
			}

			// Token: 0x060229C7 RID: 141767 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60229C7")]
			[Address(RVA = "0x1D2F2E0", Offset = "0x1D2DEE0", VA = "0x181D2F2E0")]
			public SquadAssistPlugin()
			{
			}
		}

		// Token: 0x02005D59 RID: 23897
		[Token(Token = "0x2005D59")]
		private class CharSelectPlugin : UICharacterSelectState.Plugin<ClimbTowerSquadCreateState>
		{
			// Token: 0x17005183 RID: 20867
			// (get) Token: 0x060229C8 RID: 141768 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17005183")]
			public override string overrideNoCharText
			{
				[Token(Token = "0x60229C8")]
				[Address(RVA = "0x1D17100", Offset = "0x1D15D00", VA = "0x181D17100", Slot = "28")]
				get
				{
					return null;
				}
			}

			// Token: 0x17005184 RID: 20868
			// (get) Token: 0x060229C9 RID: 141769 RVA: 0x000BE098 File Offset: 0x000BC298
			[Token(Token = "0x17005184")]
			public override bool showCharInfoEntry
			{
				[Token(Token = "0x60229C9")]
				[Address(RVA = "0x1D17170", Offset = "0x1D15D70", VA = "0x181D17170", Slot = "29")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17005185 RID: 20869
			// (get) Token: 0x060229CA RID: 141770 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17005185")]
			public override CharSelectCardMaskPlugin cardMaskPrefab
			{
				[Token(Token = "0x60229CA")]
				[Address(RVA = "0x1D17080", Offset = "0x1D15C80", VA = "0x181D17080", Slot = "32")]
				get
				{
					return null;
				}
			}

			// Token: 0x060229CB RID: 141771 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60229CB")]
			[Address(RVA = "0x1D16950", Offset = "0x1D15550", VA = "0x181D16950", Slot = "37")]
			public override void AddCharMultiSelectExcludeRule(int instId, List<int> excludeInstIds)
			{
			}

			// Token: 0x060229CC RID: 141772 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60229CC")]
			[Address(RVA = "0x1D16BA0", Offset = "0x1D157A0", VA = "0x181D16BA0", Slot = "25")]
			public override void OverrideCharSelect(int instId, Action<int> selfCharSelect)
			{
			}

			// Token: 0x060229CD RID: 141773 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60229CD")]
			[Address(RVA = "0x1D16C40", Offset = "0x1D15840", VA = "0x181D16C40", Slot = "33")]
			public override void OverrideDismiss(Action selfDismiss)
			{
			}

			// Token: 0x060229CE RID: 141774 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60229CE")]
			[Address(RVA = "0x1D16CC0", Offset = "0x1D158C0", VA = "0x181D16CC0", Slot = "27")]
			public override void OverrideSelectCanceled(Action selfCancel)
			{
			}

			// Token: 0x060229CF RID: 141775 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60229CF")]
			[Address(RVA = "0x1D16D40", Offset = "0x1D15940", VA = "0x181D16D40", Slot = "26")]
			public override void OverrideSelectConfirmed(Action selfConfirm)
			{
			}

			// Token: 0x060229D0 RID: 141776 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60229D0")]
			[Address(RVA = "0x1D16DC0", Offset = "0x1D159C0", VA = "0x181D16DC0", Slot = "30")]
			public override void OverrideSkillSelect(string skillId, Action<string> selfSkillSelect)
			{
			}

			// Token: 0x060229D1 RID: 141777 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60229D1")]
			[Address(RVA = "0x1D16B00", Offset = "0x1D15700", VA = "0x181D16B00", Slot = "31")]
			public override void OverrideBranchSelect(string equipId, Action<string> selfBranchSelect)
			{
			}

			// Token: 0x060229D2 RID: 141778 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60229D2")]
			[Address(RVA = "0x1D16E60", Offset = "0x1D15A60", VA = "0x181D16E60", Slot = "34")]
			public override string OverrideUpdateSelectedSkill(int instId, string prevSkill, Func<int, string, string> selfUpdateSelectSkill)
			{
				return null;
			}

			// Token: 0x060229D3 RID: 141779 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60229D3")]
			[Address(RVA = "0x1D17010", Offset = "0x1D15C10", VA = "0x181D17010")]
			public CharSelectPlugin()
			{
			}

			// Token: 0x0402F922 RID: 194850
			[Token(Token = "0x402F922")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_overrideNoCharText;

			// Token: 0x0402F923 RID: 194851
			[Token(Token = "0x402F923")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_showCharInfoEntry;

			// Token: 0x0402F924 RID: 194852
			[Token(Token = "0x402F924")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_cardMaskPrefab;

			// Token: 0x0402F925 RID: 194853
			[Token(Token = "0x402F925")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_AddCharMultiSelectExcludeRule;

			// Token: 0x0402F926 RID: 194854
			[Token(Token = "0x402F926")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OverrideCharSelect;

			// Token: 0x0402F927 RID: 194855
			[Token(Token = "0x402F927")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_OverrideDismiss;

			// Token: 0x0402F928 RID: 194856
			[Token(Token = "0x402F928")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_OverrideSelectCanceled;

			// Token: 0x0402F929 RID: 194857
			[Token(Token = "0x402F929")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_OverrideSelectConfirmed;

			// Token: 0x0402F92A RID: 194858
			[Token(Token = "0x402F92A")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_OverrideSkillSelect;

			// Token: 0x0402F92B RID: 194859
			[Token(Token = "0x402F92B")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_OverrideBranchSelect;

			// Token: 0x0402F92C RID: 194860
			[Token(Token = "0x402F92C")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_OverrideUpdateSelectedSkill;

			// Token: 0x0402F92D RID: 194861
			[Token(Token = "0x402F92D")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02005D5A RID: 23898
		[Token(Token = "0x2005D5A")]
		private class MenuAdapter : ClimbTowerMenuAdapter
		{
			// Token: 0x060229D4 RID: 141780 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60229D4")]
			[Address(RVA = "0x1D2E460", Offset = "0x1D2D060", VA = "0x181D2E460")]
			public MenuAdapter(ClimbTowerSquadCreateState closure)
			{
			}

			// Token: 0x17005186 RID: 20870
			// (get) Token: 0x060229D5 RID: 141781 RVA: 0x000BE0B0 File Offset: 0x000BC2B0
			[Token(Token = "0x17005186")]
			public override bool showMenu
			{
				[Token(Token = "0x60229D5")]
				[Address(RVA = "0x1D2EB60", Offset = "0x1D2D760", VA = "0x181D2EB60", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17005187 RID: 20871
			// (get) Token: 0x060229D6 RID: 141782 RVA: 0x000BE0C8 File Offset: 0x000BC2C8
			[Token(Token = "0x17005187")]
			public override bool showSquadBtn
			{
				[Token(Token = "0x60229D6")]
				[Address(RVA = "0x1D2EE00", Offset = "0x1D2DA00", VA = "0x181D2EE00", Slot = "8")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17005188 RID: 20872
			// (get) Token: 0x060229D7 RID: 141783 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17005188")]
			public override ClimbTowerMenuButton buttonPrefab
			{
				[Token(Token = "0x60229D7")]
				[Address(RVA = "0x1D2E920", Offset = "0x1D2D520", VA = "0x181D2E920", Slot = "14")]
				get
				{
					return null;
				}
			}

			// Token: 0x17005189 RID: 20873
			// (get) Token: 0x060229D8 RID: 141784 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17005189")]
			public override Action buttonCallback
			{
				[Token(Token = "0x60229D8")]
				[Address(RVA = "0x1D2E590", Offset = "0x1D2D190", VA = "0x181D2E590", Slot = "16")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700518A RID: 20874
			// (get) Token: 0x060229D9 RID: 141785 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700518A")]
			public override ClimbTowerProfessionMenuObject.GetProfessionCharCount overrideGetProfessionCharCount
			{
				[Token(Token = "0x60229D9")]
				[Address(RVA = "0x1D2EA50", Offset = "0x1D2D650", VA = "0x181D2EA50", Slot = "12")]
				get
				{
					return null;
				}
			}

			// Token: 0x060229DA RID: 141786 RVA: 0x000BE0E0 File Offset: 0x000BC2E0
			[Token(Token = "0x60229DA")]
			[Address(RVA = "0x1D118C0", Offset = "0x1D104C0", VA = "0x181D118C0")]
			private bool <>xLuaBaseProxy_get_showMenu()
			{
				return default(bool);
			}

			// Token: 0x060229DB RID: 141787 RVA: 0x000BE0F8 File Offset: 0x000BC2F8
			[Token(Token = "0x60229DB")]
			[Address(RVA = "0x1D118E0", Offset = "0x1D104E0", VA = "0x181D118E0")]
			private bool <>xLuaBaseProxy_get_showSquadBtn()
			{
				return default(bool);
			}

			// Token: 0x060229DC RID: 141788 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60229DC")]
			[Address(RVA = "0x1D11880", Offset = "0x1D10480", VA = "0x181D11880")]
			private ClimbTowerMenuButton <>xLuaBaseProxy_get_buttonPrefab()
			{
				return null;
			}

			// Token: 0x060229DD RID: 141789 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60229DD")]
			[Address(RVA = "0x1D11860", Offset = "0x1D10460", VA = "0x181D11860")]
			private Action <>xLuaBaseProxy_get_buttonCallback()
			{
				return null;
			}

			// Token: 0x060229DE RID: 141790 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60229DE")]
			[Address(RVA = "0x1D2E2E0", Offset = "0x1D2CEE0", VA = "0x181D2E2E0")]
			private ClimbTowerProfessionMenuObject.GetProfessionCharCount <>xLuaBaseProxy_get_overrideGetProfessionCharCount()
			{
				return null;
			}

			// Token: 0x0402F92E RID: 194862
			[Token(Token = "0x402F92E")]
			[FieldOffset(Offset = "0x18")]
			private ClimbTowerSquadCreateState m_closure;

			// Token: 0x0402F92F RID: 194863
			[Token(Token = "0x402F92F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402F930 RID: 194864
			[Token(Token = "0x402F930")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_showMenu;

			// Token: 0x0402F931 RID: 194865
			[Token(Token = "0x402F931")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_showSquadBtn;

			// Token: 0x0402F932 RID: 194866
			[Token(Token = "0x402F932")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_buttonPrefab;

			// Token: 0x0402F933 RID: 194867
			[Token(Token = "0x402F933")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_buttonCallback;

			// Token: 0x0402F934 RID: 194868
			[Token(Token = "0x402F934")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_overrideGetProfessionCharCount;
		}
	}
}
