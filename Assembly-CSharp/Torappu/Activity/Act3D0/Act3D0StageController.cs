using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using Torappu.UI.ActivityStage.Extern;
using Torappu.UI.Stage;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act3D0
{
	// Token: 0x020073DB RID: 29659
	[Token(Token = "0x20073DB")]
	public class Act3D0StageController : ActivityStageController
	{
		// Token: 0x170062F9 RID: 25337
		// (get) Token: 0x06029E3C RID: 171580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170062F9")]
		public EventPool<Act3D0Event> eventPool
		{
			[Token(Token = "0x6029E3C")]
			[Address(RVA = "0x256A4B0", Offset = "0x25690B0", VA = "0x18256A4B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170062FA RID: 25338
		// (get) Token: 0x06029E3D RID: 171581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170062FA")]
		public static string staticActivityId
		{
			[Token(Token = "0x6029E3D")]
			[Address(RVA = "0x256A510", Offset = "0x2569110", VA = "0x18256A510")]
			get
			{
				return null;
			}
		}

		// Token: 0x06029E3E RID: 171582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029E3E")]
		[Address(RVA = "0x2569610", Offset = "0x2568210", VA = "0x182569610", Slot = "5")]
		protected override ActivityStageBridge CreateBridge()
		{
			return null;
		}

		// Token: 0x06029E3F RID: 171583 RVA: 0x000D6EA8 File Offset: 0x000D50A8
		[Token(Token = "0x6029E3F")]
		[Address(RVA = "0x25693F0", Offset = "0x2567FF0", VA = "0x1825693F0")]
		public static bool CheckIfCampSelected()
		{
			return default(bool);
		}

		// Token: 0x06029E40 RID: 171584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029E40")]
		[Address(RVA = "0x25699D0", Offset = "0x25685D0", VA = "0x1825699D0", Slot = "10")]
		protected override void OnLoaded()
		{
		}

		// Token: 0x06029E41 RID: 171585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029E41")]
		[Address(RVA = "0x256A050", Offset = "0x2568C50", VA = "0x18256A050")]
		private void _OnCampConfirmed(object _)
		{
		}

		// Token: 0x06029E42 RID: 171586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029E42")]
		[Address(RVA = "0x256A300", Offset = "0x2568F00", VA = "0x18256A300")]
		private static IEnumerator _TryShowCampSelectState()
		{
			return null;
		}

		// Token: 0x06029E43 RID: 171587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029E43")]
		[Address(RVA = "0x2569DC0", Offset = "0x25689C0", VA = "0x182569DC0", Slot = "13")]
		protected override void OnStageTimeout()
		{
		}

		// Token: 0x06029E44 RID: 171588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029E44")]
		[Address(RVA = "0x2569C80", Offset = "0x2568880", VA = "0x182569C80", Slot = "14")]
		protected override void OnRewardTimeout()
		{
		}

		// Token: 0x06029E45 RID: 171589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029E45")]
		[Address(RVA = "0x25698C0", Offset = "0x25684C0", VA = "0x1825698C0", Slot = "7")]
		protected override string GetBGMSignal()
		{
			return null;
		}

		// Token: 0x06029E46 RID: 171590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029E46")]
		[Address(RVA = "0x2569FB0", Offset = "0x2568BB0", VA = "0x182569FB0")]
		public void TriggerBGMForCampManually(string fakeCampId)
		{
		}

		// Token: 0x06029E47 RID: 171591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029E47")]
		[Address(RVA = "0x256A1E0", Offset = "0x2568DE0", VA = "0x18256A1E0")]
		private void _TriggerCampConfirmedAudioSignal()
		{
		}

		// Token: 0x06029E48 RID: 171592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029E48")]
		[Address(RVA = "0x2569780", Offset = "0x2568380", VA = "0x182569780")]
		public static PlayerActivity.PlayerAct3D0Activity GetAct3D0PlayerInfo(string actId)
		{
			return null;
		}

		// Token: 0x06029E49 RID: 171593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029E49")]
		[Address(RVA = "0x25696B0", Offset = "0x25682B0", VA = "0x1825696B0")]
		public static PlayerActivity.PlayerAct3D0Activity GetAct3D0PlayerInfoFromPlayerData(string actId, PlayerDataModel playerModel)
		{
			return null;
		}

		// Token: 0x06029E4A RID: 171594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029E4A")]
		[Address(RVA = "0x256A390", Offset = "0x2568F90", VA = "0x18256A390")]
		public Act3D0StageController()
		{
		}

		// Token: 0x06029E4B RID: 171595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029E4B")]
		[Address(RVA = "0x22DB660", Offset = "0x22DA260", VA = "0x1822DB660")]
		private void <>xLuaBaseProxy_OnLoaded()
		{
		}

		// Token: 0x06029E4C RID: 171596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029E4C")]
		[Address(RVA = "0x22DB6C0", Offset = "0x22DA2C0", VA = "0x1822DB6C0")]
		private void <>xLuaBaseProxy_OnStageTimeout()
		{
		}

		// Token: 0x06029E4D RID: 171597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029E4D")]
		[Address(RVA = "0x247CFA0", Offset = "0x247BBA0", VA = "0x18247CFA0")]
		private void <>xLuaBaseProxy_OnRewardTimeout()
		{
		}

		// Token: 0x06029E4E RID: 171598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029E4E")]
		[Address(RVA = "0x256A040", Offset = "0x2568C40", VA = "0x18256A040")]
		private string <>xLuaBaseProxy_GetBGMSignal()
		{
			return null;
		}

		// Token: 0x0403C09A RID: 245914
		[Token(Token = "0x403C09A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Act3D0EntryZoneGroupBinder _entryZoneBinder;

		// Token: 0x0403C09B RID: 245915
		[Token(Token = "0x403C09B")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Act3D0MapZoneGroupBinder _mapZoneBinder;

		// Token: 0x0403C09C RID: 245916
		[Token(Token = "0x403C09C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private bool _useFloat;

		// Token: 0x0403C09D RID: 245917
		[Token(Token = "0x403C09D")]
		[FieldOffset(Offset = "0x78")]
		private Act3D0ZoneDescGroupViewProperty m_zoneDescGroupProperty;

		// Token: 0x0403C09E RID: 245918
		[Token(Token = "0x403C09E")]
		[FieldOffset(Offset = "0x80")]
		private string m_fakeCampForBGM;

		// Token: 0x0403C09F RID: 245919
		[Token(Token = "0x403C09F")]
		[FieldOffset(Offset = "0x88")]
		private EventPool<Act3D0Event> m_eventPool;

		// Token: 0x0403C0A0 RID: 245920
		[Token(Token = "0x403C0A0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_eventPool;

		// Token: 0x0403C0A1 RID: 245921
		[Token(Token = "0x403C0A1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_staticActivityId;

		// Token: 0x0403C0A2 RID: 245922
		[Token(Token = "0x403C0A2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CreateBridge;

		// Token: 0x0403C0A3 RID: 245923
		[Token(Token = "0x403C0A3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CheckIfCampSelected;

		// Token: 0x0403C0A4 RID: 245924
		[Token(Token = "0x403C0A4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnLoaded;

		// Token: 0x0403C0A5 RID: 245925
		[Token(Token = "0x403C0A5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnCampConfirmed;

		// Token: 0x0403C0A6 RID: 245926
		[Token(Token = "0x403C0A6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__TryShowCampSelectState;

		// Token: 0x0403C0A7 RID: 245927
		[Token(Token = "0x403C0A7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnStageTimeout;

		// Token: 0x0403C0A8 RID: 245928
		[Token(Token = "0x403C0A8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnRewardTimeout;

		// Token: 0x0403C0A9 RID: 245929
		[Token(Token = "0x403C0A9")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetBGMSignal;

		// Token: 0x0403C0AA RID: 245930
		[Token(Token = "0x403C0AA")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_TriggerBGMForCampManually;

		// Token: 0x0403C0AB RID: 245931
		[Token(Token = "0x403C0AB")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__TriggerCampConfirmedAudioSignal;

		// Token: 0x0403C0AC RID: 245932
		[Token(Token = "0x403C0AC")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetAct3D0PlayerInfo;

		// Token: 0x0403C0AD RID: 245933
		[Token(Token = "0x403C0AD")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetAct3D0PlayerInfoFromPlayerData;

		// Token: 0x0403C0AE RID: 245934
		[Token(Token = "0x403C0AE")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020073DC RID: 29660
		[Token(Token = "0x20073DC")]
		private class Bridge : ActivityStageBridge
		{
			// Token: 0x06029E4F RID: 171599 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029E4F")]
			[Address(RVA = "0x24BE8D0", Offset = "0x24BD4D0", VA = "0x1824BE8D0")]
			public Bridge(Act3D0StageController controller)
			{
			}

			// Token: 0x06029E50 RID: 171600 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029E50")]
			[Address(RVA = "0x25803C0", Offset = "0x257EFC0", VA = "0x1825803C0", Slot = "5")]
			protected override void OnZoneSelected(string selectedZoneId)
			{
			}

			// Token: 0x06029E51 RID: 171601 RVA: 0x000D6EC0 File Offset: 0x000D50C0
			[Token(Token = "0x6029E51")]
			[Address(RVA = "0x25803B0", Offset = "0x257EFB0", VA = "0x1825803B0", Slot = "4")]
			public override bool CheckBeforeStartBattle(StageViewModel stageModel)
			{
				return default(bool);
			}

			// Token: 0x0403C0AF RID: 245935
			[Token(Token = "0x403C0AF")]
			[FieldOffset(Offset = "0x18")]
			private Act3D0StageController m_controller;
		}
	}
}
