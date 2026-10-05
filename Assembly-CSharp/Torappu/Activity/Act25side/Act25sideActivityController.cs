using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x020074BE RID: 29886
	[Token(Token = "0x20074BE")]
	public class Act25sideActivityController : TemplateActivityController
	{
		// Token: 0x0602A25A RID: 172634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A25A")]
		[Address(RVA = "0x25C42E0", Offset = "0x25C2EE0", VA = "0x1825C42E0", Slot = "32")]
		public override void InitModelDict(string actId)
		{
		}

		// Token: 0x0602A25B RID: 172635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A25B")]
		[Address(RVA = "0x25C5290", Offset = "0x25C3E90", VA = "0x1825C5290", Slot = "22")]
		public override ActivityStageController.OnStageFogUnlock OverrideStageFogUnlock()
		{
			return null;
		}

		// Token: 0x0602A25C RID: 172636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A25C")]
		[Address(RVA = "0x25C6170", Offset = "0x25C4D70", VA = "0x1825C6170")]
		private void _OnStageFogUnlock(StageData stageData, StageFogInfo stageFogInfo, Action onConfirmed)
		{
		}

		// Token: 0x0602A25D RID: 172637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A25D")]
		[Address(RVA = "0x25C4FF0", Offset = "0x25C3BF0", VA = "0x1825C4FF0", Slot = "17")]
		protected override void OnStagePageResumed(UIPageTransContext context)
		{
		}

		// Token: 0x0602A25E RID: 172638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A25E")]
		[Address(RVA = "0x25C6040", Offset = "0x25C4C40", VA = "0x1825C6040")]
		private PlayerActivity.PlayerAct25SideActivity _GetPlayerData()
		{
			return null;
		}

		// Token: 0x0602A25F RID: 172639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A25F")]
		[Address(RVA = "0x25C59A0", Offset = "0x25C45A0", VA = "0x1825C59A0")]
		private TemplateActivityLifeCycleViewModel _GenLifeCycle()
		{
			return null;
		}

		// Token: 0x0602A260 RID: 172640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A260")]
		[Address(RVA = "0x25C5890", Offset = "0x25C4490", VA = "0x1825C5890")]
		private TemplateActivityFavorViewModel _GenFavorStateViewModel()
		{
			return null;
		}

		// Token: 0x0602A261 RID: 172641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A261")]
		[Address(RVA = "0x25C5C70", Offset = "0x25C4870", VA = "0x1825C5C70")]
		private TemplateActivityZoneGroupViewModel _GenZoneViewModel()
		{
			return null;
		}

		// Token: 0x0602A262 RID: 172642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A262")]
		[Address(RVA = "0x25C5770", Offset = "0x25C4370", VA = "0x1825C5770")]
		private TemplateActivityCoinViewModel _GenCoinStateViewModel()
		{
			return null;
		}

		// Token: 0x0602A263 RID: 172643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A263")]
		[Address(RVA = "0x25C54F0", Offset = "0x25C40F0", VA = "0x1825C54F0")]
		private TemplateActivityMissionGroupViewModel _GenActivityMissionViewModel()
		{
			return null;
		}

		// Token: 0x0602A264 RID: 172644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A264")]
		[Address(RVA = "0x25C5B90", Offset = "0x25C4790", VA = "0x1825C5B90")]
		private Act25sideEntryResearchViewModel _GenResearchViewModel()
		{
			return null;
		}

		// Token: 0x0602A265 RID: 172645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A265")]
		[Address(RVA = "0x25C5690", Offset = "0x25C4290", VA = "0x1825C5690")]
		private Act25sideEntryArchiveViewModel _GenArchiveViewModel()
		{
			return null;
		}

		// Token: 0x0602A266 RID: 172646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A266")]
		[Address(RVA = "0x25C5AB0", Offset = "0x25C46B0", VA = "0x1825C5AB0")]
		private Act25sideMapDecorMissionGroupViewModel _GenResearchMissionViewModel()
		{
			return null;
		}

		// Token: 0x0602A267 RID: 172647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A267")]
		[Address(RVA = "0x25C6350", Offset = "0x25C4F50", VA = "0x1825C6350")]
		private IEnumerator _OpenResearchPage(Act25sideDailyRefreshResponse response)
		{
			return null;
		}

		// Token: 0x0602A268 RID: 172648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A268")]
		[Address(RVA = "0x25C4C90", Offset = "0x25C3890", VA = "0x1825C4C90")]
		public void OnButtonResearchClicked()
		{
		}

		// Token: 0x0602A269 RID: 172649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A269")]
		[Address(RVA = "0x25C4AE0", Offset = "0x25C36E0", VA = "0x1825C4AE0")]
		public void OnButtonArchiveClicked()
		{
		}

		// Token: 0x0602A26A RID: 172650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A26A")]
		[Address(RVA = "0x25C6420", Offset = "0x25C5020", VA = "0x1825C6420")]
		public Act25sideActivityController()
		{
		}

		// Token: 0x0602A26D RID: 172653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A26D")]
		[Address(RVA = "0x25C54C0", Offset = "0x25C40C0", VA = "0x1825C54C0")]
		private ActivityStageController.OnStageFogUnlock <>xLuaBaseProxy_OverrideStageFogUnlock()
		{
			return null;
		}

		// Token: 0x0602A26E RID: 172654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A26E")]
		[Address(RVA = "0x246D2E0", Offset = "0x246BEE0", VA = "0x18246D2E0")]
		private void <>xLuaBaseProxy_OnStagePageResumed(UIPageTransContext P0)
		{
		}

		// Token: 0x0403C8C4 RID: 248004
		[Token(Token = "0x403C8C4")]
		[NonSerialized]
		public const string RESEARCH_PARAM = "research";

		// Token: 0x0403C8C5 RID: 248005
		[Token(Token = "0x403C8C5")]
		[NonSerialized]
		public const string ARCHIVE_PARAM = "archive";

		// Token: 0x0403C8C6 RID: 248006
		[Token(Token = "0x403C8C6")]
		[NonSerialized]
		public const string RESEARCH_MISSION_PARAM = "research_mission";

		// Token: 0x0403C8C7 RID: 248007
		[Token(Token = "0x403C8C7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitModelDict;

		// Token: 0x0403C8C8 RID: 248008
		[Token(Token = "0x403C8C8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OverrideStageFogUnlock;

		// Token: 0x0403C8C9 RID: 248009
		[Token(Token = "0x403C8C9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnStageFogUnlock;

		// Token: 0x0403C8CA RID: 248010
		[Token(Token = "0x403C8CA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnStagePageResumed;

		// Token: 0x0403C8CB RID: 248011
		[Token(Token = "0x403C8CB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetPlayerData;

		// Token: 0x0403C8CC RID: 248012
		[Token(Token = "0x403C8CC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GenLifeCycle;

		// Token: 0x0403C8CD RID: 248013
		[Token(Token = "0x403C8CD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GenFavorStateViewModel;

		// Token: 0x0403C8CE RID: 248014
		[Token(Token = "0x403C8CE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GenZoneViewModel;

		// Token: 0x0403C8CF RID: 248015
		[Token(Token = "0x403C8CF")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GenCoinStateViewModel;

		// Token: 0x0403C8D0 RID: 248016
		[Token(Token = "0x403C8D0")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__GenActivityMissionViewModel;

		// Token: 0x0403C8D1 RID: 248017
		[Token(Token = "0x403C8D1")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__GenResearchViewModel;

		// Token: 0x0403C8D2 RID: 248018
		[Token(Token = "0x403C8D2")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__GenArchiveViewModel;

		// Token: 0x0403C8D3 RID: 248019
		[Token(Token = "0x403C8D3")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__GenResearchMissionViewModel;

		// Token: 0x0403C8D4 RID: 248020
		[Token(Token = "0x403C8D4")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OpenResearchPage;

		// Token: 0x0403C8D5 RID: 248021
		[Token(Token = "0x403C8D5")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnButtonResearchClicked;

		// Token: 0x0403C8D6 RID: 248022
		[Token(Token = "0x403C8D6")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnButtonArchiveClicked;

		// Token: 0x0403C8D7 RID: 248023
		[Token(Token = "0x403C8D7")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
