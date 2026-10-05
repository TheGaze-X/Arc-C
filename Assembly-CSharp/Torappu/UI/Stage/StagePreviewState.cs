using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200688C RID: 26764
	[Token(Token = "0x200688C")]
	public class StagePreviewState : StageBaseState, ICompDialogCallBack, IValueMsgReceiver
	{
		// Token: 0x06026589 RID: 157065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026589")]
		[Address(RVA = "0x2169200", Offset = "0x2167E00", VA = "0x182169200", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602658A RID: 157066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602658A")]
		[Address(RVA = "0x216C190", Offset = "0x216AD90", VA = "0x18216C190")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602658B RID: 157067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602658B")]
		[Address(RVA = "0x216D400", Offset = "0x216C000", VA = "0x18216D400")]
		private void _OnJumpToEnemyHandBook(IStateBean stateBean)
		{
		}

		// Token: 0x0602658C RID: 157068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602658C")]
		[Address(RVA = "0x216D620", Offset = "0x216C220", VA = "0x18216D620")]
		private void _OnJumpToRewardDetailView(IStateBean stateBean)
		{
		}

		// Token: 0x0602658D RID: 157069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602658D")]
		[Address(RVA = "0x2169CF0", Offset = "0x21688F0", VA = "0x182169CF0", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x0602658E RID: 157070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602658E")]
		[Address(RVA = "0x2169B90", Offset = "0x2168790", VA = "0x182169B90", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x17005A88 RID: 23176
		// (get) Token: 0x0602658F RID: 157071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005A88")]
		public override IStateCacheHandler cacheHandler
		{
			[Token(Token = "0x602658F")]
			[Address(RVA = "0x216E340", Offset = "0x216CF40", VA = "0x18216E340", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x06026590 RID: 157072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026590")]
		[Address(RVA = "0x216AB10", Offset = "0x2169710", VA = "0x18216AB10", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06026591 RID: 157073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026591")]
		[Address(RVA = "0x216AE70", Offset = "0x2169A70", VA = "0x18216AE70", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06026592 RID: 157074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026592")]
		[Address(RVA = "0x2169260", Offset = "0x2167E60", VA = "0x182169260", Slot = "23")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x06026593 RID: 157075 RVA: 0x000CAAE8 File Offset: 0x000C8CE8
		[Token(Token = "0x6026593")]
		[Address(RVA = "0x216E040", Offset = "0x216CC40", VA = "0x18216E040")]
		private StagePreviewState.StateRuntime _SaveToRuntime()
		{
			return default(StagePreviewState.StateRuntime);
		}

		// Token: 0x06026594 RID: 157076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026594")]
		[Address(RVA = "0x216C810", Offset = "0x216B410", VA = "0x18216C810")]
		private void _LoadFromRuntime(StagePreviewState.StateRuntime runtime)
		{
		}

		// Token: 0x06026595 RID: 157077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026595")]
		[Address(RVA = "0x216AB80", Offset = "0x2169780", VA = "0x18216AB80")]
		public void OnStartBattleClick()
		{
		}

		// Token: 0x06026596 RID: 157078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026596")]
		[Address(RVA = "0x216A4E0", Offset = "0x21690E0", VA = "0x18216A4E0")]
		public void OnOpenEnemyClick()
		{
		}

		// Token: 0x06026597 RID: 157079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026597")]
		[Address(RVA = "0x216A440", Offset = "0x2169040", VA = "0x18216A440")]
		public void OnOpenCampaginRules()
		{
		}

		// Token: 0x06026598 RID: 157080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026598")]
		[Address(RVA = "0x216A630", Offset = "0x2169230", VA = "0x18216A630")]
		public void OnOpenRewardClick()
		{
		}

		// Token: 0x06026599 RID: 157081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026599")]
		[Address(RVA = "0x2169920", Offset = "0x2168520", VA = "0x182169920")]
		public void OnBeSpecial()
		{
		}

		// Token: 0x0602659A RID: 157082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602659A")]
		[Address(RVA = "0x2169870", Offset = "0x2168470", VA = "0x182169870")]
		public void OnBeNormal()
		{
		}

		// Token: 0x0602659B RID: 157083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602659B")]
		[Address(RVA = "0x216A6D0", Offset = "0x21692D0", VA = "0x18216A6D0")]
		public void OnOpenRewardHolder()
		{
		}

		// Token: 0x0602659C RID: 157084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602659C")]
		[Address(RVA = "0x216A090", Offset = "0x2168C90", VA = "0x18216A090")]
		public void OnMultipleBattleClick()
		{
		}

		// Token: 0x0602659D RID: 157085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602659D")]
		[Address(RVA = "0x216D810", Offset = "0x216C410", VA = "0x18216D810")]
		private void _OnSelectedMultipleBattleTimes(int times)
		{
		}

		// Token: 0x0602659E RID: 157086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602659E")]
		[Address(RVA = "0x216AC10", Offset = "0x2169810", VA = "0x18216AC10")]
		public void OnStartPractiseClick()
		{
		}

		// Token: 0x0602659F RID: 157087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602659F")]
		[Address(RVA = "0x216ACF0", Offset = "0x21698F0", VA = "0x18216ACF0")]
		public void OnZoneMapEmptyAreaClicked()
		{
		}

		// Token: 0x060265A0 RID: 157088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60265A0")]
		[Address(RVA = "0x2169800", Offset = "0x2168400", VA = "0x182169800")]
		public void OnAutoBattleSwitchClick()
		{
		}

		// Token: 0x060265A1 RID: 157089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60265A1")]
		[Address(RVA = "0x216A820", Offset = "0x2169420", VA = "0x18216A820")]
		public void OnReplayStoryOpenClick()
		{
		}

		// Token: 0x060265A2 RID: 157090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60265A2")]
		[Address(RVA = "0x216A900", Offset = "0x2169500", VA = "0x18216A900")]
		public void OnReplayStoryTrigClick(int index)
		{
		}

		// Token: 0x060265A3 RID: 157091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60265A3")]
		[Address(RVA = "0x2169590", Offset = "0x2168190", VA = "0x182169590")]
		public void OnAddedRecieveReward()
		{
		}

		// Token: 0x060265A4 RID: 157092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60265A4")]
		[Address(RVA = "0x2169DC0", Offset = "0x21689C0", VA = "0x182169DC0")]
		public void OnLockedHardBattleClick()
		{
		}

		// Token: 0x060265A5 RID: 157093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60265A5")]
		[Address(RVA = "0x2169A60", Offset = "0x2168660", VA = "0x182169A60")]
		public void OnClosePreview()
		{
		}

		// Token: 0x060265A6 RID: 157094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60265A6")]
		[Address(RVA = "0x216C9C0", Offset = "0x216B5C0", VA = "0x18216C9C0")]
		private void _OnGoToSquad(bool isPractice)
		{
		}

		// Token: 0x060265A7 RID: 157095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60265A7")]
		[Address(RVA = "0x216B9B0", Offset = "0x216A5B0", VA = "0x18216B9B0")]
		private StageViewModel _GetCurrentSelectedStageViewModel()
		{
			return null;
		}

		// Token: 0x060265A8 RID: 157096 RVA: 0x000CAB00 File Offset: 0x000C8D00
		[Token(Token = "0x60265A8")]
		[Address(RVA = "0x216B480", Offset = "0x216A080", VA = "0x18216B480")]
		private bool _CheckCostBeforeStartBattle()
		{
			return default(bool);
		}

		// Token: 0x060265A9 RID: 157097 RVA: 0x000CAB18 File Offset: 0x000C8D18
		[Token(Token = "0x60265A9")]
		[Address(RVA = "0x216B7F0", Offset = "0x216A3F0", VA = "0x18216B7F0")]
		private bool _CheckIsGroupBattle()
		{
			return default(bool);
		}

		// Token: 0x060265AA RID: 157098 RVA: 0x000CAB30 File Offset: 0x000C8D30
		[Token(Token = "0x60265AA")]
		[Address(RVA = "0x216B350", Offset = "0x2169F50", VA = "0x18216B350")]
		private bool _CheckApBeforeStartBattle(int apCost)
		{
			return default(bool);
		}

		// Token: 0x060265AB RID: 157099 RVA: 0x000CAB48 File Offset: 0x000C8D48
		[Token(Token = "0x60265AB")]
		[Address(RVA = "0x216B6C0", Offset = "0x216A2C0", VA = "0x18216B6C0")]
		private bool _CheckEtBeforeStartBattle(string etItemId, int etCost)
		{
			return default(bool);
		}

		// Token: 0x060265AC RID: 157100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60265AC")]
		[Address(RVA = "0x216BAC0", Offset = "0x216A6C0", VA = "0x18216BAC0")]
		private void _GoToSquad(bool isPractice)
		{
		}

		// Token: 0x060265AD RID: 157101 RVA: 0x000CAB60 File Offset: 0x000C8D60
		[Token(Token = "0x60265AD")]
		[Address(RVA = "0x216B870", Offset = "0x216A470", VA = "0x18216B870")]
		private bool _CheckNeedToLoadBattleLog(out bool allowNoBattleLog)
		{
			return default(bool);
		}

		// Token: 0x060265AE RID: 157102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60265AE")]
		[Address(RVA = "0x216DDE0", Offset = "0x216C9E0", VA = "0x18216DDE0")]
		private void _OnSixStarRuneSelectUpdate()
		{
		}

		// Token: 0x060265AF RID: 157103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60265AF")]
		[Address(RVA = "0x216B1A0", Offset = "0x2169DA0", VA = "0x18216B1A0")]
		private void _CheckAndTryTriggerSixStarAvg(string normalStageId)
		{
		}

		// Token: 0x060265B0 RID: 157104 RVA: 0x000CAB78 File Offset: 0x000C8D78
		[Token(Token = "0x60265B0")]
		[Address(RVA = "0x216E180", Offset = "0x216CD80", VA = "0x18216E180")]
		private bool _TryToTriggerSixStarAvg(string operationKey)
		{
			return default(bool);
		}

		// Token: 0x060265B1 RID: 157105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60265B1")]
		[Address(RVA = "0x2169EA0", Offset = "0x2168AA0", VA = "0x182169EA0", Slot = "25")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x060265B2 RID: 157106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60265B2")]
		[Address(RVA = "0x216DF30", Offset = "0x216CB30", VA = "0x18216DF30")]
		private void _OnSwitchSixStarTagClick(SixStarStagePreviewView.StageSixStarRuneStatus newStatus)
		{
		}

		// Token: 0x060265B3 RID: 157107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60265B3")]
		[Address(RVA = "0x216DB20", Offset = "0x216C720", VA = "0x18216DB20")]
		private void _OnSixStarRuneSelectBtnClick()
		{
		}

		// Token: 0x060265B4 RID: 157108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60265B4")]
		[Address(RVA = "0x216D930", Offset = "0x216C530", VA = "0x18216D930")]
		private void _OnSixStarRewardGroupInfoBtnClick()
		{
		}

		// Token: 0x060265B5 RID: 157109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60265B5")]
		[Address(RVA = "0x216E290", Offset = "0x216CE90", VA = "0x18216E290")]
		public StagePreviewState()
		{
		}

		// Token: 0x060265B8 RID: 157112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60265B8")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x060265B9 RID: 157113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60265B9")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x060265BA RID: 157114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60265BA")]
		[Address(RVA = "0x12DC030", Offset = "0x12DAC30", VA = "0x1812DC030")]
		private IStateCacheHandler <>xLuaBaseProxy_get_cacheHandler()
		{
			return null;
		}

		// Token: 0x060265BB RID: 157115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60265BB")]
		[Address(RVA = "0x216B190", Offset = "0x2169D90", VA = "0x18216B190")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x060265BC RID: 157116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60265BC")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0403601B RID: 221211
		[Token(Token = "0x403601B")]
		[NonSerialized]
		public const int MSG_SWITCH_SIX_STAR_RUNE_TAG = 0;

		// Token: 0x0403601C RID: 221212
		[Token(Token = "0x403601C")]
		[NonSerialized]
		public const int MSG_SIX_STAR_RUNE_SELECT_BTN_CLICK = 1;

		// Token: 0x0403601D RID: 221213
		[Token(Token = "0x403601D")]
		[NonSerialized]
		public const int MSG_SIX_STAR_REWARD_GROUP_BTN_CLICK = 2;

		// Token: 0x0403601E RID: 221214
		[Token(Token = "0x403601E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private StageStateBean _stateBean;

		// Token: 0x0403601F RID: 221215
		[Token(Token = "0x403601F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private StagePreviewReplayView _replayView;

		// Token: 0x04036020 RID: 221216
		[Token(Token = "0x4036020")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private StagePreviewInfoNormalPanelHolder _dynNormalHolder;

		// Token: 0x04036021 RID: 221217
		[Token(Token = "0x4036021")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private StagePreviewInfoHardPanelHolder _dynHardHolder;

		// Token: 0x04036022 RID: 221218
		[Token(Token = "0x4036022")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private StagePreviewInfoSixStarPanelHolder _dynSixStarHolder;

		// Token: 0x04036023 RID: 221219
		[Token(Token = "0x4036023")]
		[FieldOffset(Offset = "0x80")]
		private StateCacheHandler<StagePreviewState.StateRuntime> m_runtimeHandler;

		// Token: 0x04036024 RID: 221220
		[Token(Token = "0x4036024")]
		[FieldOffset(Offset = "0x88")]
		private bool m_isInited;

		// Token: 0x04036025 RID: 221221
		[Token(Token = "0x4036025")]
		[FieldOffset(Offset = "0x8C")]
		private int m_multipleBattleDialogInstId;

		// Token: 0x04036026 RID: 221222
		[Token(Token = "0x4036026")]
		[FieldOffset(Offset = "0x90")]
		private int m_sixStarRuneSelectDialogInstId;

		// Token: 0x04036027 RID: 221223
		[Token(Token = "0x4036027")]
		[FieldOffset(Offset = "0x98")]
		private UIPageFinder m_uiPageFinder;

		// Token: 0x04036028 RID: 221224
		[Token(Token = "0x4036028")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04036029 RID: 221225
		[Token(Token = "0x4036029")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403602A RID: 221226
		[Token(Token = "0x403602A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnJumpToEnemyHandBook;

		// Token: 0x0403602B RID: 221227
		[Token(Token = "0x403602B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnJumpToRewardDetailView;

		// Token: 0x0403602C RID: 221228
		[Token(Token = "0x403602C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0403602D RID: 221229
		[Token(Token = "0x403602D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403602E RID: 221230
		[Token(Token = "0x403602E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_cacheHandler;

		// Token: 0x0403602F RID: 221231
		[Token(Token = "0x403602F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04036030 RID: 221232
		[Token(Token = "0x4036030")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x04036031 RID: 221233
		[Token(Token = "0x4036031")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x04036032 RID: 221234
		[Token(Token = "0x4036032")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__SaveToRuntime;

		// Token: 0x04036033 RID: 221235
		[Token(Token = "0x4036033")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__LoadFromRuntime;

		// Token: 0x04036034 RID: 221236
		[Token(Token = "0x4036034")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnStartBattleClick;

		// Token: 0x04036035 RID: 221237
		[Token(Token = "0x4036035")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnOpenEnemyClick;

		// Token: 0x04036036 RID: 221238
		[Token(Token = "0x4036036")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnOpenCampaginRules;

		// Token: 0x04036037 RID: 221239
		[Token(Token = "0x4036037")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnOpenRewardClick;

		// Token: 0x04036038 RID: 221240
		[Token(Token = "0x4036038")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnBeSpecial;

		// Token: 0x04036039 RID: 221241
		[Token(Token = "0x4036039")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OnBeNormal;

		// Token: 0x0403603A RID: 221242
		[Token(Token = "0x403603A")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnOpenRewardHolder;

		// Token: 0x0403603B RID: 221243
		[Token(Token = "0x403603B")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_OnMultipleBattleClick;

		// Token: 0x0403603C RID: 221244
		[Token(Token = "0x403603C")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__OnSelectedMultipleBattleTimes;

		// Token: 0x0403603D RID: 221245
		[Token(Token = "0x403603D")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_OnStartPractiseClick;

		// Token: 0x0403603E RID: 221246
		[Token(Token = "0x403603E")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_OnZoneMapEmptyAreaClicked;

		// Token: 0x0403603F RID: 221247
		[Token(Token = "0x403603F")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_OnAutoBattleSwitchClick;

		// Token: 0x04036040 RID: 221248
		[Token(Token = "0x4036040")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_OnReplayStoryOpenClick;

		// Token: 0x04036041 RID: 221249
		[Token(Token = "0x4036041")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_OnReplayStoryTrigClick;

		// Token: 0x04036042 RID: 221250
		[Token(Token = "0x4036042")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_OnAddedRecieveReward;

		// Token: 0x04036043 RID: 221251
		[Token(Token = "0x4036043")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_OnLockedHardBattleClick;

		// Token: 0x04036044 RID: 221252
		[Token(Token = "0x4036044")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_OnClosePreview;

		// Token: 0x04036045 RID: 221253
		[Token(Token = "0x4036045")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__OnGoToSquad;

		// Token: 0x04036046 RID: 221254
		[Token(Token = "0x4036046")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__GetCurrentSelectedStageViewModel;

		// Token: 0x04036047 RID: 221255
		[Token(Token = "0x4036047")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__CheckCostBeforeStartBattle;

		// Token: 0x04036048 RID: 221256
		[Token(Token = "0x4036048")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__CheckIsGroupBattle;

		// Token: 0x04036049 RID: 221257
		[Token(Token = "0x4036049")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__CheckApBeforeStartBattle;

		// Token: 0x0403604A RID: 221258
		[Token(Token = "0x403604A")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__CheckEtBeforeStartBattle;

		// Token: 0x0403604B RID: 221259
		[Token(Token = "0x403604B")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__GoToSquad;

		// Token: 0x0403604C RID: 221260
		[Token(Token = "0x403604C")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__CheckNeedToLoadBattleLog;

		// Token: 0x0403604D RID: 221261
		[Token(Token = "0x403604D")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__OnSixStarRuneSelectUpdate;

		// Token: 0x0403604E RID: 221262
		[Token(Token = "0x403604E")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__CheckAndTryTriggerSixStarAvg;

		// Token: 0x0403604F RID: 221263
		[Token(Token = "0x403604F")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0__TryToTriggerSixStarAvg;

		// Token: 0x04036050 RID: 221264
		[Token(Token = "0x4036050")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04036051 RID: 221265
		[Token(Token = "0x4036051")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0__OnSwitchSixStarTagClick;

		// Token: 0x04036052 RID: 221266
		[Token(Token = "0x4036052")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0__OnSixStarRuneSelectBtnClick;

		// Token: 0x04036053 RID: 221267
		[Token(Token = "0x4036053")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0__OnSixStarRewardGroupInfoBtnClick;

		// Token: 0x04036054 RID: 221268
		[Token(Token = "0x4036054")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200688D RID: 26765
		[Token(Token = "0x200688D")]
		public struct StateRuntime
		{
			// Token: 0x04036055 RID: 221269
			[Token(Token = "0x4036055")]
			[FieldOffset(Offset = "0x0")]
			public StageId selectedStage;

			// Token: 0x04036056 RID: 221270
			[Token(Token = "0x4036056")]
			[FieldOffset(Offset = "0x18")]
			public string focusStageId;

			// Token: 0x04036057 RID: 221271
			[Token(Token = "0x4036057")]
			[FieldOffset(Offset = "0x20")]
			public bool overrideSelectStageDefaultStatus;
		}
	}
}
