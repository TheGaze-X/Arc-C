using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using Torappu.UI.TemplateMission;
using XLua;

namespace Torappu.Activity.Act38side
{
	// Token: 0x0200742E RID: 29742
	[Token(Token = "0x200742E")]
	public class Act38sideActivityController : TemplateActivityController, IHotfixable
	{
		// Token: 0x06029F9F RID: 171935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F9F")]
		[Address(RVA = "0x2580E40", Offset = "0x257FA40", VA = "0x182580E40", Slot = "32")]
		public override void InitModelDict(string actId)
		{
		}

		// Token: 0x06029FA0 RID: 171936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029FA0")]
		[Address(RVA = "0x2581500", Offset = "0x2580100", VA = "0x182581500", Slot = "13")]
		protected override void OnStageTimeout()
		{
		}

		// Token: 0x06029FA1 RID: 171937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029FA1")]
		[Address(RVA = "0x2581460", Offset = "0x2580060", VA = "0x182581460", Slot = "17")]
		protected override void OnStagePageResumed(UIPageTransContext context)
		{
		}

		// Token: 0x06029FA2 RID: 171938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029FA2")]
		[Address(RVA = "0x2582010", Offset = "0x2580C10", VA = "0x182582010")]
		private Act38SideData _GetData()
		{
			return null;
		}

		// Token: 0x06029FA3 RID: 171939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029FA3")]
		[Address(RVA = "0x2582190", Offset = "0x2580D90", VA = "0x182582190")]
		private PlayerActivity.PlayerAct38SideActivity _GetPlayerData()
		{
			return null;
		}

		// Token: 0x06029FA4 RID: 171940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029FA4")]
		[Address(RVA = "0x2581920", Offset = "0x2580520", VA = "0x182581920")]
		private TemplateActivityLifeCycleViewModel _GenLifeCycle()
		{
			return null;
		}

		// Token: 0x06029FA5 RID: 171941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029FA5")]
		[Address(RVA = "0x2581AF0", Offset = "0x25806F0", VA = "0x182581AF0")]
		private TemplateActivityZoneGroupViewModel _GenZoneViewModel()
		{
			return null;
		}

		// Token: 0x06029FA6 RID: 171942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029FA6")]
		[Address(RVA = "0x2581A30", Offset = "0x2580630", VA = "0x182581A30")]
		private TemplateActivityMissionViewModel _GenTemplateMissionViewModel()
		{
			return null;
		}

		// Token: 0x06029FA7 RID: 171943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029FA7")]
		[Address(RVA = "0x2581570", Offset = "0x2580170", VA = "0x182581570")]
		private TemplateActivityCoinViewModel _GenCoinViewModel()
		{
			return null;
		}

		// Token: 0x06029FA8 RID: 171944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029FA8")]
		[Address(RVA = "0x2581690", Offset = "0x2580290", VA = "0x182581690")]
		private TemplateActivityFavorViewModel _GenFavorViewModel()
		{
			return null;
		}

		// Token: 0x06029FA9 RID: 171945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029FA9")]
		[Address(RVA = "0x2581840", Offset = "0x2580440", VA = "0x182581840")]
		private Act38sideEntryFireworkPuzzleViewModel _GenFireworkPuzzleViewModel()
		{
			return null;
		}

		// Token: 0x06029FAA RID: 171946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029FAA")]
		[Address(RVA = "0x25817A0", Offset = "0x25803A0", VA = "0x1825817A0")]
		private Act38sideMapDecorFireworkCraftViewModel _GenFireworkCraftViewModel()
		{
			return null;
		}

		// Token: 0x06029FAB RID: 171947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029FAB")]
		[Address(RVA = "0x2580D30", Offset = "0x257F930", VA = "0x182580D30", Slot = "35")]
		public override TemplateMissionInputParam CreateTemplateMissionInputParam()
		{
			return null;
		}

		// Token: 0x06029FAC RID: 171948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029FAC")]
		[Address(RVA = "0x2582320", Offset = "0x2580F20", VA = "0x182582320")]
		private void _UpdateViewModel()
		{
		}

		// Token: 0x06029FAD RID: 171949 RVA: 0x000D71D8 File Offset: 0x000D53D8
		[Token(Token = "0x6029FAD")]
		[Address(RVA = "0x2581FA0", Offset = "0x2580BA0", VA = "0x182581FA0")]
		private int _GetCoinCount()
		{
			return 0;
		}

		// Token: 0x06029FAE RID: 171950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029FAE")]
		[Address(RVA = "0x25824E0", Offset = "0x25810E0", VA = "0x1825824E0")]
		public Act38sideActivityController()
		{
		}

		// Token: 0x06029FAF RID: 171951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029FAF")]
		[Address(RVA = "0x246D320", Offset = "0x246BF20", VA = "0x18246D320")]
		private void <>xLuaBaseProxy_OnStageTimeout()
		{
		}

		// Token: 0x06029FB0 RID: 171952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029FB0")]
		[Address(RVA = "0x246D2E0", Offset = "0x246BEE0", VA = "0x18246D2E0")]
		private void <>xLuaBaseProxy_OnStagePageResumed(UIPageTransContext P0)
		{
		}

		// Token: 0x06029FB1 RID: 171953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029FB1")]
		[Address(RVA = "0x2470A90", Offset = "0x246F690", VA = "0x182470A90")]
		private TemplateMissionInputParam <>xLuaBaseProxy_CreateTemplateMissionInputParam()
		{
			return null;
		}

		// Token: 0x0403C2F0 RID: 246512
		[Token(Token = "0x403C2F0")]
		private const string FIREWORK_PUZZLE_VIEWMODEL = "firework_puzzle";

		// Token: 0x0403C2F1 RID: 246513
		[Token(Token = "0x403C2F1")]
		private const string FIREWORK_CRAFT_VIEWMODEL = "firework_craft";

		// Token: 0x0403C2F2 RID: 246514
		[Token(Token = "0x403C2F2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitModelDict;

		// Token: 0x0403C2F3 RID: 246515
		[Token(Token = "0x403C2F3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnStageTimeout;

		// Token: 0x0403C2F4 RID: 246516
		[Token(Token = "0x403C2F4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnStagePageResumed;

		// Token: 0x0403C2F5 RID: 246517
		[Token(Token = "0x403C2F5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetData;

		// Token: 0x0403C2F6 RID: 246518
		[Token(Token = "0x403C2F6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetPlayerData;

		// Token: 0x0403C2F7 RID: 246519
		[Token(Token = "0x403C2F7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GenLifeCycle;

		// Token: 0x0403C2F8 RID: 246520
		[Token(Token = "0x403C2F8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GenZoneViewModel;

		// Token: 0x0403C2F9 RID: 246521
		[Token(Token = "0x403C2F9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GenTemplateMissionViewModel;

		// Token: 0x0403C2FA RID: 246522
		[Token(Token = "0x403C2FA")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GenCoinViewModel;

		// Token: 0x0403C2FB RID: 246523
		[Token(Token = "0x403C2FB")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__GenFavorViewModel;

		// Token: 0x0403C2FC RID: 246524
		[Token(Token = "0x403C2FC")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__GenFireworkPuzzleViewModel;

		// Token: 0x0403C2FD RID: 246525
		[Token(Token = "0x403C2FD")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__GenFireworkCraftViewModel;

		// Token: 0x0403C2FE RID: 246526
		[Token(Token = "0x403C2FE")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_CreateTemplateMissionInputParam;

		// Token: 0x0403C2FF RID: 246527
		[Token(Token = "0x403C2FF")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__UpdateViewModel;

		// Token: 0x0403C300 RID: 246528
		[Token(Token = "0x403C300")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__GetCoinCount;

		// Token: 0x0403C301 RID: 246529
		[Token(Token = "0x403C301")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
