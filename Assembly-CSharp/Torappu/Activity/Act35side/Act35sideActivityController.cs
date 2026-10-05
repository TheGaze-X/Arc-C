using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using Torappu.UI.TemplateMission;
using XLua;

namespace Torappu.Activity.Act35side
{
	// Token: 0x02007470 RID: 29808
	[Token(Token = "0x2007470")]
	public class Act35sideActivityController : TemplateActivityController, IHotfixable
	{
		// Token: 0x0602A0BE RID: 172222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A0BE")]
		[Address(RVA = "0x2595BB0", Offset = "0x25947B0", VA = "0x182595BB0", Slot = "32")]
		public override void InitModelDict(string actId)
		{
		}

		// Token: 0x0602A0BF RID: 172223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A0BF")]
		[Address(RVA = "0x2596290", Offset = "0x2594E90", VA = "0x182596290", Slot = "13")]
		protected override void OnStageTimeout()
		{
		}

		// Token: 0x0602A0C0 RID: 172224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A0C0")]
		[Address(RVA = "0x25961F0", Offset = "0x2594DF0", VA = "0x1825961F0", Slot = "17")]
		protected override void OnStagePageResumed(UIPageTransContext context)
		{
		}

		// Token: 0x0602A0C1 RID: 172225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A0C1")]
		[Address(RVA = "0x2597100", Offset = "0x2595D00", VA = "0x182597100")]
		private Act35SideData _GetData()
		{
			return null;
		}

		// Token: 0x0602A0C2 RID: 172226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A0C2")]
		[Address(RVA = "0x25967E0", Offset = "0x25953E0", VA = "0x1825967E0")]
		private TemplateActivityLifeCycleViewModel _GenLifeCycle()
		{
			return null;
		}

		// Token: 0x0602A0C3 RID: 172227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A0C3")]
		[Address(RVA = "0x2596BD0", Offset = "0x25957D0", VA = "0x182596BD0")]
		private TemplateActivityZoneGroupViewModel _GenZoneViewModel()
		{
			return null;
		}

		// Token: 0x0602A0C4 RID: 172228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A0C4")]
		[Address(RVA = "0x2596570", Offset = "0x2595170", VA = "0x182596570")]
		private TemplateActivityCoinViewModel _GenCoinViewModel()
		{
			return null;
		}

		// Token: 0x0602A0C5 RID: 172229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A0C5")]
		[Address(RVA = "0x2596690", Offset = "0x2595290", VA = "0x182596690")]
		private TemplateActivityFavorViewModel _GenFavorViewModel()
		{
			return null;
		}

		// Token: 0x0602A0C6 RID: 172230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A0C6")]
		[Address(RVA = "0x25968F0", Offset = "0x25954F0", VA = "0x1825968F0")]
		private Act35sideMilestoneGroupViewModel _GenMilestoneViewModel()
		{
			return null;
		}

		// Token: 0x0602A0C7 RID: 172231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A0C7")]
		[Address(RVA = "0x2596300", Offset = "0x2594F00", VA = "0x182596300")]
		private Act35sideEntryCarvingViewModel _GenCarvingViewModel()
		{
			return null;
		}

		// Token: 0x0602A0C8 RID: 172232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A0C8")]
		[Address(RVA = "0x2596B10", Offset = "0x2595710", VA = "0x182596B10")]
		private TemplateActivityMissionViewModel _GenTemplateMissionViewModel()
		{
			return null;
		}

		// Token: 0x0602A0C9 RID: 172233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A0C9")]
		[Address(RVA = "0x2597280", Offset = "0x2595E80", VA = "0x182597280")]
		private void _UpdateViewModel()
		{
		}

		// Token: 0x0602A0CA RID: 172234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A0CA")]
		[Address(RVA = "0x25959C0", Offset = "0x25945C0", VA = "0x1825959C0")]
		public void EventOnOpenMilestoneState()
		{
		}

		// Token: 0x0602A0CB RID: 172235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A0CB")]
		[Address(RVA = "0x2595720", Offset = "0x2594320", VA = "0x182595720", Slot = "35")]
		public override TemplateMissionInputParam CreateTemplateMissionInputParam()
		{
			return null;
		}

		// Token: 0x0602A0CC RID: 172236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A0CC")]
		[Address(RVA = "0x2596A30", Offset = "0x2595630", VA = "0x182596A30")]
		private TemplateMissionCoinViewModel _GenMissionCoinViewModel()
		{
			return null;
		}

		// Token: 0x0602A0CD RID: 172237 RVA: 0x000D74F0 File Offset: 0x000D56F0
		[Token(Token = "0x602A0CD")]
		[Address(RVA = "0x2597060", Offset = "0x2595C60", VA = "0x182597060")]
		private int _GetCoinCount()
		{
			return 0;
		}

		// Token: 0x0602A0CE RID: 172238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A0CE")]
		[Address(RVA = "0x2597580", Offset = "0x2596180", VA = "0x182597580")]
		public Act35sideActivityController()
		{
		}

		// Token: 0x0602A0CF RID: 172239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A0CF")]
		[Address(RVA = "0x246D320", Offset = "0x246BF20", VA = "0x18246D320")]
		private void <>xLuaBaseProxy_OnStageTimeout()
		{
		}

		// Token: 0x0602A0D0 RID: 172240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A0D0")]
		[Address(RVA = "0x246D2E0", Offset = "0x246BEE0", VA = "0x18246D2E0")]
		private void <>xLuaBaseProxy_OnStagePageResumed(UIPageTransContext P0)
		{
		}

		// Token: 0x0602A0D1 RID: 172241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A0D1")]
		[Address(RVA = "0x2470A90", Offset = "0x246F690", VA = "0x182470A90")]
		private TemplateMissionInputParam <>xLuaBaseProxy_CreateTemplateMissionInputParam()
		{
			return null;
		}

		// Token: 0x0403C54D RID: 247117
		[Token(Token = "0x403C54D")]
		private const string CARVING_PARAM = "carving";

		// Token: 0x0403C54E RID: 247118
		[Token(Token = "0x403C54E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitModelDict;

		// Token: 0x0403C54F RID: 247119
		[Token(Token = "0x403C54F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnStageTimeout;

		// Token: 0x0403C550 RID: 247120
		[Token(Token = "0x403C550")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnStagePageResumed;

		// Token: 0x0403C551 RID: 247121
		[Token(Token = "0x403C551")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetData;

		// Token: 0x0403C552 RID: 247122
		[Token(Token = "0x403C552")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GenLifeCycle;

		// Token: 0x0403C553 RID: 247123
		[Token(Token = "0x403C553")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GenZoneViewModel;

		// Token: 0x0403C554 RID: 247124
		[Token(Token = "0x403C554")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GenCoinViewModel;

		// Token: 0x0403C555 RID: 247125
		[Token(Token = "0x403C555")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GenFavorViewModel;

		// Token: 0x0403C556 RID: 247126
		[Token(Token = "0x403C556")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GenMilestoneViewModel;

		// Token: 0x0403C557 RID: 247127
		[Token(Token = "0x403C557")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__GenCarvingViewModel;

		// Token: 0x0403C558 RID: 247128
		[Token(Token = "0x403C558")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__GenTemplateMissionViewModel;

		// Token: 0x0403C559 RID: 247129
		[Token(Token = "0x403C559")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__UpdateViewModel;

		// Token: 0x0403C55A RID: 247130
		[Token(Token = "0x403C55A")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_EventOnOpenMilestoneState;

		// Token: 0x0403C55B RID: 247131
		[Token(Token = "0x403C55B")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_CreateTemplateMissionInputParam;

		// Token: 0x0403C55C RID: 247132
		[Token(Token = "0x403C55C")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__GenMissionCoinViewModel;

		// Token: 0x0403C55D RID: 247133
		[Token(Token = "0x403C55D")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__GetCoinCount;

		// Token: 0x0403C55E RID: 247134
		[Token(Token = "0x403C55E")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
