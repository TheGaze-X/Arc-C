using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using Torappu.UI.TemplateMission;
using XLua;

namespace Torappu.Activity.Act46Side
{
	// Token: 0x020072A0 RID: 29344
	[Token(Token = "0x20072A0")]
	public class Act46SideActivityController : TemplateActivityController
	{
		// Token: 0x060298BD RID: 170173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60298BD")]
		[Address(RVA = "0x24D7420", Offset = "0x24D6020", VA = "0x1824D7420", Slot = "32")]
		public override void InitModelDict(string actId)
		{
		}

		// Token: 0x060298BE RID: 170174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60298BE")]
		[Address(RVA = "0x24D7C00", Offset = "0x24D6800", VA = "0x1824D7C00", Slot = "17")]
		protected override void OnStagePageResumed(UIPageTransContext context)
		{
		}

		// Token: 0x060298BF RID: 170175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60298BF")]
		[Address(RVA = "0x24D7B90", Offset = "0x24D6790", VA = "0x1824D7B90", Slot = "14")]
		protected override void OnRewardTimeout()
		{
		}

		// Token: 0x060298C0 RID: 170176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60298C0")]
		[Address(RVA = "0x24D7CA0", Offset = "0x24D68A0", VA = "0x1824D7CA0", Slot = "13")]
		protected override void OnStageTimeout()
		{
		}

		// Token: 0x060298C1 RID: 170177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60298C1")]
		[Address(RVA = "0x24D7310", Offset = "0x24D5F10", VA = "0x1824D7310", Slot = "35")]
		public override TemplateMissionInputParam CreateTemplateMissionInputParam()
		{
			return null;
		}

		// Token: 0x060298C2 RID: 170178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60298C2")]
		[Address(RVA = "0x24D87F0", Offset = "0x24D73F0", VA = "0x1824D87F0")]
		private Act46SideData _GetData()
		{
			return null;
		}

		// Token: 0x060298C3 RID: 170179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60298C3")]
		[Address(RVA = "0x24D8980", Offset = "0x24D7580", VA = "0x1824D8980")]
		private PlayerActivity.PlayerAct46SideActivity _GetPlayerData()
		{
			return null;
		}

		// Token: 0x060298C4 RID: 170180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60298C4")]
		[Address(RVA = "0x24D7F40", Offset = "0x24D6B40", VA = "0x1824D7F40")]
		private TemplateActivityLifeCycleViewModel _GenLifeCycle()
		{
			return null;
		}

		// Token: 0x060298C5 RID: 170181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60298C5")]
		[Address(RVA = "0x24D8430", Offset = "0x24D7030", VA = "0x1824D8430")]
		private TemplateActivityZoneGroupViewModel _GenZoneViewModel()
		{
			return null;
		}

		// Token: 0x060298C6 RID: 170182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60298C6")]
		[Address(RVA = "0x24D81F0", Offset = "0x24D6DF0", VA = "0x1824D81F0")]
		private TemplateActivityMissionViewModel _GenTemplateMissionViewModel()
		{
			return null;
		}

		// Token: 0x060298C7 RID: 170183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60298C7")]
		[Address(RVA = "0x24D7D10", Offset = "0x24D6910", VA = "0x1824D7D10")]
		private TemplateActivityCoinViewModel _GenCoinViewModel()
		{
			return null;
		}

		// Token: 0x060298C8 RID: 170184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60298C8")]
		[Address(RVA = "0x24D7E30", Offset = "0x24D6A30", VA = "0x1824D7E30")]
		private TemplateActivityFavorViewModel _GenFavorViewModel()
		{
			return null;
		}

		// Token: 0x060298C9 RID: 170185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60298C9")]
		[Address(RVA = "0x24D8070", Offset = "0x24D6C70", VA = "0x1824D8070")]
		private Act46SideEntryMonopolyViewModel _GenMonopolyViewModel()
		{
			return null;
		}

		// Token: 0x060298CA RID: 170186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60298CA")]
		[Address(RVA = "0x24D82B0", Offset = "0x24D6EB0", VA = "0x1824D82B0")]
		private Act46SideMapDecorTrapViewModel _GenTrapViewModel()
		{
			return null;
		}

		// Token: 0x060298CB RID: 170187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60298CB")]
		[Address(RVA = "0x24D8B20", Offset = "0x24D7720", VA = "0x1824D8B20")]
		private void _UpdateViewModel()
		{
		}

		// Token: 0x060298CC RID: 170188 RVA: 0x000D5E70 File Offset: 0x000D4070
		[Token(Token = "0x60298CC")]
		[Address(RVA = "0x24D8780", Offset = "0x24D7380", VA = "0x1824D8780")]
		private int _GetCoinCount()
		{
			return 0;
		}

		// Token: 0x060298CD RID: 170189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60298CD")]
		[Address(RVA = "0x24D8CE0", Offset = "0x24D78E0", VA = "0x1824D8CE0")]
		public Act46SideActivityController()
		{
		}

		// Token: 0x060298CE RID: 170190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60298CE")]
		[Address(RVA = "0x246D2E0", Offset = "0x246BEE0", VA = "0x18246D2E0")]
		private void <>xLuaBaseProxy_OnStagePageResumed(UIPageTransContext P0)
		{
		}

		// Token: 0x060298CF RID: 170191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60298CF")]
		[Address(RVA = "0x247CFA0", Offset = "0x247BBA0", VA = "0x18247CFA0")]
		private void <>xLuaBaseProxy_OnRewardTimeout()
		{
		}

		// Token: 0x060298D0 RID: 170192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60298D0")]
		[Address(RVA = "0x246D320", Offset = "0x246BF20", VA = "0x18246D320")]
		private void <>xLuaBaseProxy_OnStageTimeout()
		{
		}

		// Token: 0x060298D1 RID: 170193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60298D1")]
		[Address(RVA = "0x2470A90", Offset = "0x246F690", VA = "0x182470A90")]
		private TemplateMissionInputParam <>xLuaBaseProxy_CreateTemplateMissionInputParam()
		{
			return null;
		}

		// Token: 0x0403B650 RID: 243280
		[Token(Token = "0x403B650")]
		private const string MONOPOLY_PARAM = "monopoly";

		// Token: 0x0403B651 RID: 243281
		[Token(Token = "0x403B651")]
		private const string TRAP_PARAM = "trap";

		// Token: 0x0403B652 RID: 243282
		[Token(Token = "0x403B652")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitModelDict;

		// Token: 0x0403B653 RID: 243283
		[Token(Token = "0x403B653")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnStagePageResumed;

		// Token: 0x0403B654 RID: 243284
		[Token(Token = "0x403B654")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRewardTimeout;

		// Token: 0x0403B655 RID: 243285
		[Token(Token = "0x403B655")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnStageTimeout;

		// Token: 0x0403B656 RID: 243286
		[Token(Token = "0x403B656")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CreateTemplateMissionInputParam;

		// Token: 0x0403B657 RID: 243287
		[Token(Token = "0x403B657")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetData;

		// Token: 0x0403B658 RID: 243288
		[Token(Token = "0x403B658")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GetPlayerData;

		// Token: 0x0403B659 RID: 243289
		[Token(Token = "0x403B659")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GenLifeCycle;

		// Token: 0x0403B65A RID: 243290
		[Token(Token = "0x403B65A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GenZoneViewModel;

		// Token: 0x0403B65B RID: 243291
		[Token(Token = "0x403B65B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__GenTemplateMissionViewModel;

		// Token: 0x0403B65C RID: 243292
		[Token(Token = "0x403B65C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__GenCoinViewModel;

		// Token: 0x0403B65D RID: 243293
		[Token(Token = "0x403B65D")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__GenFavorViewModel;

		// Token: 0x0403B65E RID: 243294
		[Token(Token = "0x403B65E")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__GenMonopolyViewModel;

		// Token: 0x0403B65F RID: 243295
		[Token(Token = "0x403B65F")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__GenTrapViewModel;

		// Token: 0x0403B660 RID: 243296
		[Token(Token = "0x403B660")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__UpdateViewModel;

		// Token: 0x0403B661 RID: 243297
		[Token(Token = "0x403B661")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__GetCoinCount;

		// Token: 0x0403B662 RID: 243298
		[Token(Token = "0x403B662")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
