using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using Torappu.UI.ActivityStage.Extern;
using XLua;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x020079C3 RID: 31171
	[Token(Token = "0x20079C3")]
	public class Act13SideActivityController : TemplateActivityController
	{
		// Token: 0x1700668A RID: 26250
		// (get) Token: 0x0602BB82 RID: 179074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700668A")]
		public Act13sideZoneDescGroupViewProperty zoneDescGroupViewProperty
		{
			[Token(Token = "0x602BB82")]
			[Address(RVA = "0x2796870", Offset = "0x2795470", VA = "0x182796870")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602BB83 RID: 179075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BB83")]
		[Address(RVA = "0x2794510", Offset = "0x2793110", VA = "0x182794510", Slot = "32")]
		public override void InitModelDict(string actId)
		{
		}

		// Token: 0x0602BB84 RID: 179076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BB84")]
		[Address(RVA = "0x2794A40", Offset = "0x2793640", VA = "0x182794A40", Slot = "10")]
		protected override void OnLoaded()
		{
		}

		// Token: 0x0602BB85 RID: 179077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BB85")]
		[Address(RVA = "0x2794170", Offset = "0x2792D70", VA = "0x182794170", Slot = "5")]
		protected override ActivityStageBridge CreateBridge()
		{
			return null;
		}

		// Token: 0x0602BB86 RID: 179078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BB86")]
		[Address(RVA = "0x2796600", Offset = "0x2795200", VA = "0x182796600")]
		private void _TriggerTutorialIfNeed()
		{
		}

		// Token: 0x0602BB87 RID: 179079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BB87")]
		[Address(RVA = "0x27943E0", Offset = "0x2792FE0", VA = "0x1827943E0")]
		public PlayerActivity.PlayerAct13sideActivity GetPlayerData()
		{
			return null;
		}

		// Token: 0x0602BB88 RID: 179080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BB88")]
		[Address(RVA = "0x2794290", Offset = "0x2792E90", VA = "0x182794290")]
		public Act13SideData GetData()
		{
			return null;
		}

		// Token: 0x0602BB89 RID: 179081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BB89")]
		[Address(RVA = "0x2796090", Offset = "0x2794C90", VA = "0x182796090")]
		private TemplateActivityLifeCycleViewModel _GenLifeCycle()
		{
			return null;
		}

		// Token: 0x0602BB8A RID: 179082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BB8A")]
		[Address(RVA = "0x27961A0", Offset = "0x2794DA0", VA = "0x1827961A0")]
		private TemplateActivityZoneGroupViewModel _GenZoneViewModel()
		{
			return null;
		}

		// Token: 0x0602BB8B RID: 179083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BB8B")]
		[Address(RVA = "0x2795D40", Offset = "0x2794940", VA = "0x182795D40")]
		private Act13sideButtonViewModel _GenButtonStateViewModel(TemplateActivityLifeCycleViewModel.ActState actState)
		{
			return null;
		}

		// Token: 0x0602BB8C RID: 179084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BB8C")]
		[Address(RVA = "0x2795E50", Offset = "0x2794A50", VA = "0x182795E50")]
		private TemplateActivityCoinViewModel _GenCoinStateViewModel()
		{
			return null;
		}

		// Token: 0x0602BB8D RID: 179085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BB8D")]
		[Address(RVA = "0x2795F80", Offset = "0x2794B80", VA = "0x182795F80")]
		private TemplateActivityFavorViewModel _GenFavorStateViewModel()
		{
			return null;
		}

		// Token: 0x0602BB8E RID: 179086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BB8E")]
		[Address(RVA = "0x2795610", Offset = "0x2794210", VA = "0x182795610")]
		private TemplateActivityMissionGroupViewModel _GenActivityMissionViewModel(Act13SideData data)
		{
			return null;
		}

		// Token: 0x0602BB8F RID: 179087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BB8F")]
		[Address(RVA = "0x2794C40", Offset = "0x2793840", VA = "0x182794C40")]
		public void OnSelectMissionGroup(string missionGroupId)
		{
		}

		// Token: 0x0602BB90 RID: 179088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BB90")]
		[Address(RVA = "0x2795050", Offset = "0x2793C50", VA = "0x182795050")]
		public void SendConfirmMission(string missionId)
		{
		}

		// Token: 0x0602BB91 RID: 179089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BB91")]
		[Address(RVA = "0x2796530", Offset = "0x2795130", VA = "0x182796530")]
		private static IEnumerator _ReceiveItemsCoroutine(List<RewardItemModel> rewardList, Action onAfterItemShow)
		{
			return null;
		}

		// Token: 0x0602BB92 RID: 179090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BB92")]
		[Address(RVA = "0x2794DE0", Offset = "0x27939E0", VA = "0x182794DE0")]
		public void SendConfirmAllMission(string missionGroupId)
		{
		}

		// Token: 0x0602BB93 RID: 179091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BB93")]
		[Address(RVA = "0x2794200", Offset = "0x2792E00", VA = "0x182794200")]
		public void EventOnZoneClicked(string zoneId)
		{
		}

		// Token: 0x0602BB94 RID: 179092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BB94")]
		[Address(RVA = "0x27967C0", Offset = "0x27953C0", VA = "0x1827967C0")]
		public Act13SideActivityController()
		{
		}

		// Token: 0x0602BB97 RID: 179095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BB97")]
		[Address(RVA = "0x246D2D0", Offset = "0x246BED0", VA = "0x18246D2D0")]
		private void <>xLuaBaseProxy_OnLoaded()
		{
		}

		// Token: 0x0602BB98 RID: 179096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BB98")]
		[Address(RVA = "0x27955E0", Offset = "0x27941E0", VA = "0x1827955E0")]
		private ActivityStageBridge <>xLuaBaseProxy_CreateBridge()
		{
			return null;
		}

		// Token: 0x0403F40B RID: 259083
		[Token(Token = "0x403F40B")]
		public const string BUTTON_STATE_VIEWMODEL = "button";

		// Token: 0x0403F40C RID: 259084
		[Token(Token = "0x403F40C")]
		[FieldOffset(Offset = "0x80")]
		private Act13sideZoneDescGroupViewProperty m_zoneDescGroupViewProperty;

		// Token: 0x0403F40D RID: 259085
		[Token(Token = "0x403F40D")]
		[FieldOffset(Offset = "0x88")]
		[NonSerialized]
		public Act13sideMissionFinishViewModel missionFinishViewModel;

		// Token: 0x0403F40E RID: 259086
		[Token(Token = "0x403F40E")]
		[NonSerialized]
		public const string ORG_ID = "orgId";

		// Token: 0x0403F40F RID: 259087
		[Token(Token = "0x403F40F")]
		[NonSerialized]
		public const string MISSION_GROUP = "mission_group";

		// Token: 0x0403F410 RID: 259088
		[Token(Token = "0x403F410")]
		[NonSerialized]
		public const string PRINCIPAL_ID = "principalId";

		// Token: 0x0403F411 RID: 259089
		[Token(Token = "0x403F411")]
		[NonSerialized]
		public const string FINISH_DESC = "finishedDesc";

		// Token: 0x0403F412 RID: 259090
		[Token(Token = "0x403F412")]
		[NonSerialized]
		public const string JUMP_STAGEID = "jumpStageId";

		// Token: 0x0403F413 RID: 259091
		[Token(Token = "0x403F413")]
		[NonSerialized]
		public const string HAVE_STAGE_BTN = "haveStageBtn";

		// Token: 0x0403F414 RID: 259092
		[Token(Token = "0x403F414")]
		[NonSerialized]
		public const string MISSION_TITLE = "missionTitle";

		// Token: 0x0403F415 RID: 259093
		[Token(Token = "0x403F415")]
		[NonSerialized]
		public const string MISSION_TYPE = "missionType";

		// Token: 0x0403F416 RID: 259094
		[Token(Token = "0x403F416")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_zoneDescGroupViewProperty;

		// Token: 0x0403F417 RID: 259095
		[Token(Token = "0x403F417")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitModelDict;

		// Token: 0x0403F418 RID: 259096
		[Token(Token = "0x403F418")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnLoaded;

		// Token: 0x0403F419 RID: 259097
		[Token(Token = "0x403F419")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CreateBridge;

		// Token: 0x0403F41A RID: 259098
		[Token(Token = "0x403F41A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TriggerTutorialIfNeed;

		// Token: 0x0403F41B RID: 259099
		[Token(Token = "0x403F41B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetPlayerData;

		// Token: 0x0403F41C RID: 259100
		[Token(Token = "0x403F41C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetData;

		// Token: 0x0403F41D RID: 259101
		[Token(Token = "0x403F41D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GenLifeCycle;

		// Token: 0x0403F41E RID: 259102
		[Token(Token = "0x403F41E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GenZoneViewModel;

		// Token: 0x0403F41F RID: 259103
		[Token(Token = "0x403F41F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__GenButtonStateViewModel;

		// Token: 0x0403F420 RID: 259104
		[Token(Token = "0x403F420")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__GenCoinStateViewModel;

		// Token: 0x0403F421 RID: 259105
		[Token(Token = "0x403F421")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__GenFavorStateViewModel;

		// Token: 0x0403F422 RID: 259106
		[Token(Token = "0x403F422")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__GenActivityMissionViewModel;

		// Token: 0x0403F423 RID: 259107
		[Token(Token = "0x403F423")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnSelectMissionGroup;

		// Token: 0x0403F424 RID: 259108
		[Token(Token = "0x403F424")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_SendConfirmMission;

		// Token: 0x0403F425 RID: 259109
		[Token(Token = "0x403F425")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__ReceiveItemsCoroutine;

		// Token: 0x0403F426 RID: 259110
		[Token(Token = "0x403F426")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_SendConfirmAllMission;

		// Token: 0x0403F427 RID: 259111
		[Token(Token = "0x403F427")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_EventOnZoneClicked;

		// Token: 0x0403F428 RID: 259112
		[Token(Token = "0x403F428")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020079C4 RID: 31172
		[Token(Token = "0x20079C4")]
		private class Bridge : ActivityStageBridge
		{
			// Token: 0x0602BB99 RID: 179097 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BB99")]
			[Address(RVA = "0x27A8C00", Offset = "0x27A7800", VA = "0x1827A8C00", Slot = "5")]
			protected override void OnZoneSelected(string selectedZoneId)
			{
			}

			// Token: 0x0602BB9A RID: 179098 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BB9A")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public Bridge()
			{
			}
		}
	}
}
