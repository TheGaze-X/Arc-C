using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1Lock.UI
{
	// Token: 0x02007885 RID: 30853
	[Token(Token = "0x2007885")]
	public class Act1LockMapState : State, IHotfixable
	{
		// Token: 0x0602B3D9 RID: 177113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B3D9")]
		[Address(RVA = "0x2709780", Offset = "0x2708380", VA = "0x182709780", Slot = "19")]
		protected override IEnumerator OnPreload()
		{
			return null;
		}

		// Token: 0x0602B3DA RID: 177114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B3DA")]
		[Address(RVA = "0x2709720", Offset = "0x2708320", VA = "0x182709720", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602B3DB RID: 177115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B3DB")]
		[Address(RVA = "0x2709900", Offset = "0x2708500", VA = "0x182709900", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x1700652F RID: 25903
		// (get) Token: 0x0602B3DC RID: 177116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700652F")]
		public override IStateCacheHandler cacheHandler
		{
			[Token(Token = "0x602B3DC")]
			[Address(RVA = "0x270BC80", Offset = "0x270A880", VA = "0x18270BC80", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602B3DD RID: 177117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B3DD")]
		[Address(RVA = "0x27096C0", Offset = "0x27082C0", VA = "0x1827096C0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602B3DE RID: 177118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B3DE")]
		[Address(RVA = "0x2709830", Offset = "0x2708430", VA = "0x182709830")]
		public void OnStageEventClick(string stageId)
		{
		}

		// Token: 0x0602B3DF RID: 177119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B3DF")]
		[Address(RVA = "0x2709650", Offset = "0x2708250", VA = "0x182709650")]
		public void CloseDetailView()
		{
		}

		// Token: 0x0602B3E0 RID: 177120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B3E0")]
		[Address(RVA = "0x27095E0", Offset = "0x27081E0", VA = "0x1827095E0")]
		public void AVGOnly_CloseDetailView()
		{
		}

		// Token: 0x0602B3E1 RID: 177121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B3E1")]
		[Address(RVA = "0x270AAD0", Offset = "0x27096D0", VA = "0x18270AAD0")]
		private void _OnEnemyHandBookOpen()
		{
		}

		// Token: 0x0602B3E2 RID: 177122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B3E2")]
		[Address(RVA = "0x270B4C0", Offset = "0x270A0C0", VA = "0x18270B4C0")]
		private void _OnOpenRewardClick()
		{
		}

		// Token: 0x0602B3E3 RID: 177123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B3E3")]
		[Address(RVA = "0x270A840", Offset = "0x2709440", VA = "0x18270A840")]
		private void _JumpToStageDetailView(string stageId)
		{
		}

		// Token: 0x0602B3E4 RID: 177124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B3E4")]
		[Address(RVA = "0x270A750", Offset = "0x2709350", VA = "0x18270A750")]
		private void _JumpToFinalDetailView()
		{
		}

		// Token: 0x0602B3E5 RID: 177125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B3E5")]
		[Address(RVA = "0x270BAE0", Offset = "0x270A6E0", VA = "0x18270BAE0")]
		private void _UpdateAutoBattleStatus(string stageId)
		{
		}

		// Token: 0x0602B3E6 RID: 177126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B3E6")]
		[Address(RVA = "0x270B550", Offset = "0x270A150", VA = "0x18270B550")]
		private void _OnStartBattle()
		{
		}

		// Token: 0x0602B3E7 RID: 177127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B3E7")]
		[Address(RVA = "0x270B710", Offset = "0x270A310", VA = "0x18270B710")]
		private void _OnStartPractice()
		{
		}

		// Token: 0x0602B3E8 RID: 177128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B3E8")]
		[Address(RVA = "0x270BA20", Offset = "0x270A620", VA = "0x18270BA20")]
		private void _ToggleAutoBattle()
		{
		}

		// Token: 0x0602B3E9 RID: 177129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B3E9")]
		[Address(RVA = "0x270B980", Offset = "0x270A580", VA = "0x18270B980")]
		private void _SetTopMenuActive(bool isActive)
		{
		}

		// Token: 0x0602B3EA RID: 177130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B3EA")]
		[Address(RVA = "0x2709CE0", Offset = "0x27088E0", VA = "0x182709CE0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602B3EB RID: 177131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B3EB")]
		[Address(RVA = "0x270A990", Offset = "0x2709590", VA = "0x18270A990")]
		private void _OnBackAction()
		{
		}

		// Token: 0x0602B3EC RID: 177132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B3EC")]
		[Address(RVA = "0x270AC60", Offset = "0x2709860", VA = "0x18270AC60")]
		private void _OnJumpToEnemyHandBook(IStateBean stateBean)
		{
		}

		// Token: 0x0602B3ED RID: 177133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B3ED")]
		[Address(RVA = "0x270B330", Offset = "0x2709F30", VA = "0x18270B330")]
		private void _OnJumpToRewardDetailView(IStateBean stateBean)
		{
		}

		// Token: 0x0602B3EE RID: 177134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B3EE")]
		[Address(RVA = "0x270AB60", Offset = "0x2709760", VA = "0x18270AB60")]
		private void _OnInterlockDefendUpdate()
		{
		}

		// Token: 0x0602B3EF RID: 177135 RVA: 0x000DB3F0 File Offset: 0x000D95F0
		[Token(Token = "0x602B3EF")]
		[Address(RVA = "0x2709C00", Offset = "0x2708800", VA = "0x182709C00")]
		private bool _CheckCostBeforeStartBattle()
		{
			return default(bool);
		}

		// Token: 0x0602B3F0 RID: 177136 RVA: 0x000DB408 File Offset: 0x000D9608
		[Token(Token = "0x602B3F0")]
		[Address(RVA = "0x2709AD0", Offset = "0x27086D0", VA = "0x182709AD0")]
		private bool _CheckApBeforeStartBattle(int apCost)
		{
			return default(bool);
		}

		// Token: 0x0602B3F1 RID: 177137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B3F1")]
		[Address(RVA = "0x270A8E0", Offset = "0x27094E0", VA = "0x18270A8E0")]
		private void _LoadFromRuntime(Act1LockMapState.StateRuntime runtime)
		{
		}

		// Token: 0x0602B3F2 RID: 177138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B3F2")]
		[Address(RVA = "0x270B870", Offset = "0x270A470", VA = "0x18270B870")]
		private Act1LockMapState.StateRuntime _SaveToRuntime()
		{
			return null;
		}

		// Token: 0x0602B3F3 RID: 177139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B3F3")]
		[Address(RVA = "0x270BC20", Offset = "0x270A820", VA = "0x18270BC20")]
		public Act1LockMapState()
		{
		}

		// Token: 0x0602B3F5 RID: 177141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B3F5")]
		[Address(RVA = "0x15A0840", Offset = "0x159F440", VA = "0x1815A0840")]
		private IEnumerator <>xLuaBaseProxy_OnPreload()
		{
			return null;
		}

		// Token: 0x0602B3F6 RID: 177142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B3F6")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0602B3F7 RID: 177143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B3F7")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0602B3F8 RID: 177144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B3F8")]
		[Address(RVA = "0x12DC030", Offset = "0x12DAC30", VA = "0x1812DC030")]
		private IStateCacheHandler <>xLuaBaseProxy_get_cacheHandler()
		{
			return null;
		}

		// Token: 0x0403E80D RID: 256013
		[Token(Token = "0x403E80D")]
		[FieldOffset(Offset = "0x50")]
		private bool m_hasInited;

		// Token: 0x0403E80E RID: 256014
		[Token(Token = "0x403E80E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Act1LockZoneMapStateBean _stateBean;

		// Token: 0x0403E80F RID: 256015
		[Token(Token = "0x403E80F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Act1LockMapView _view;

		// Token: 0x0403E810 RID: 256016
		[Token(Token = "0x403E810")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Act1LockMapAdapter _mapAdapter;

		// Token: 0x0403E811 RID: 256017
		[Token(Token = "0x403E811")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform _detailViewContainer;

		// Token: 0x0403E812 RID: 256018
		[Token(Token = "0x403E812")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Act1LockNormalDetailView _normalViewPrefab;

		// Token: 0x0403E813 RID: 256019
		[Token(Token = "0x403E813")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Act1LockInterlockDetailView _interlockViewPrefab;

		// Token: 0x0403E814 RID: 256020
		[Token(Token = "0x403E814")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Act1LockFinalDetailView _finalViewPrefab;

		// Token: 0x0403E815 RID: 256021
		[Token(Token = "0x403E815")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x0403E816 RID: 256022
		[Token(Token = "0x403E816")]
		[FieldOffset(Offset = "0x98")]
		private Act1LockNormalDetailView m_normalView;

		// Token: 0x0403E817 RID: 256023
		[Token(Token = "0x403E817")]
		[FieldOffset(Offset = "0xA0")]
		private Act1LockInterlockDetailView m_interlockView;

		// Token: 0x0403E818 RID: 256024
		[Token(Token = "0x403E818")]
		[FieldOffset(Offset = "0xA8")]
		private Act1LockFinalDetailView m_finalView;

		// Token: 0x0403E819 RID: 256025
		[Token(Token = "0x403E819")]
		[FieldOffset(Offset = "0xB0")]
		private StateCacheHandler<Act1LockMapState.StateRuntime> m_runtimeHandler;

		// Token: 0x0403E81A RID: 256026
		[Token(Token = "0x403E81A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPreload;

		// Token: 0x0403E81B RID: 256027
		[Token(Token = "0x403E81B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403E81C RID: 256028
		[Token(Token = "0x403E81C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0403E81D RID: 256029
		[Token(Token = "0x403E81D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_cacheHandler;

		// Token: 0x0403E81E RID: 256030
		[Token(Token = "0x403E81E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403E81F RID: 256031
		[Token(Token = "0x403E81F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnStageEventClick;

		// Token: 0x0403E820 RID: 256032
		[Token(Token = "0x403E820")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CloseDetailView;

		// Token: 0x0403E821 RID: 256033
		[Token(Token = "0x403E821")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_AVGOnly_CloseDetailView;

		// Token: 0x0403E822 RID: 256034
		[Token(Token = "0x403E822")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnEnemyHandBookOpen;

		// Token: 0x0403E823 RID: 256035
		[Token(Token = "0x403E823")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnOpenRewardClick;

		// Token: 0x0403E824 RID: 256036
		[Token(Token = "0x403E824")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__JumpToStageDetailView;

		// Token: 0x0403E825 RID: 256037
		[Token(Token = "0x403E825")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__JumpToFinalDetailView;

		// Token: 0x0403E826 RID: 256038
		[Token(Token = "0x403E826")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__UpdateAutoBattleStatus;

		// Token: 0x0403E827 RID: 256039
		[Token(Token = "0x403E827")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnStartBattle;

		// Token: 0x0403E828 RID: 256040
		[Token(Token = "0x403E828")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnStartPractice;

		// Token: 0x0403E829 RID: 256041
		[Token(Token = "0x403E829")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__ToggleAutoBattle;

		// Token: 0x0403E82A RID: 256042
		[Token(Token = "0x403E82A")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__SetTopMenuActive;

		// Token: 0x0403E82B RID: 256043
		[Token(Token = "0x403E82B")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403E82C RID: 256044
		[Token(Token = "0x403E82C")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__OnBackAction;

		// Token: 0x0403E82D RID: 256045
		[Token(Token = "0x403E82D")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__OnJumpToEnemyHandBook;

		// Token: 0x0403E82E RID: 256046
		[Token(Token = "0x403E82E")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__OnJumpToRewardDetailView;

		// Token: 0x0403E82F RID: 256047
		[Token(Token = "0x403E82F")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__OnInterlockDefendUpdate;

		// Token: 0x0403E830 RID: 256048
		[Token(Token = "0x403E830")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__CheckCostBeforeStartBattle;

		// Token: 0x0403E831 RID: 256049
		[Token(Token = "0x403E831")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__CheckApBeforeStartBattle;

		// Token: 0x0403E832 RID: 256050
		[Token(Token = "0x403E832")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__LoadFromRuntime;

		// Token: 0x0403E833 RID: 256051
		[Token(Token = "0x403E833")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__SaveToRuntime;

		// Token: 0x0403E834 RID: 256052
		[Token(Token = "0x403E834")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007886 RID: 30854
		[Token(Token = "0x2007886")]
		public class StateRuntime
		{
			// Token: 0x0602B3F9 RID: 177145 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B3F9")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public StateRuntime()
			{
			}

			// Token: 0x0403E835 RID: 256053
			[Token(Token = "0x403E835")]
			[FieldOffset(Offset = "0x10")]
			public string selectedStageId;
		}
	}
}
