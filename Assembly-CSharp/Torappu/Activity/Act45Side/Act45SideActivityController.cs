using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using Torappu.UI.TemplateMission;
using XLua;

namespace Torappu.Activity.Act45Side
{
	// Token: 0x020072B1 RID: 29361
	[Token(Token = "0x20072B1")]
	public class Act45SideActivityController : TemplateActivityController, IHotfixable
	{
		// Token: 0x06029905 RID: 170245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029905")]
		[Address(RVA = "0x24F03B0", Offset = "0x24EEFB0", VA = "0x1824F03B0", Slot = "32")]
		public override void InitModelDict(string actId)
		{
		}

		// Token: 0x06029906 RID: 170246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029906")]
		[Address(RVA = "0x24F0930", Offset = "0x24EF530", VA = "0x1824F0930", Slot = "17")]
		protected override void OnStagePageResumed(UIPageTransContext context)
		{
		}

		// Token: 0x06029907 RID: 170247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029907")]
		[Address(RVA = "0x24F02A0", Offset = "0x24EEEA0", VA = "0x1824F02A0", Slot = "35")]
		public override TemplateMissionInputParam CreateTemplateMissionInputParam()
		{
			return null;
		}

		// Token: 0x06029908 RID: 170248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029908")]
		[Address(RVA = "0x24F13B0", Offset = "0x24EFFB0", VA = "0x1824F13B0")]
		private Act45SideData _GetData()
		{
			return null;
		}

		// Token: 0x06029909 RID: 170249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029909")]
		[Address(RVA = "0x24F1530", Offset = "0x24F0130", VA = "0x1824F1530")]
		private PlayerActivity.PlayerAct45SideActivity _GetPlayerData()
		{
			return null;
		}

		// Token: 0x0602990A RID: 170250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602990A")]
		[Address(RVA = "0x24F0C00", Offset = "0x24EF800", VA = "0x1824F0C00")]
		private TemplateActivityLifeCycleViewModel _GenLifeCycle()
		{
			return null;
		}

		// Token: 0x0602990B RID: 170251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602990B")]
		[Address(RVA = "0x24F0EB0", Offset = "0x24EFAB0", VA = "0x1824F0EB0")]
		private TemplateActivityZoneGroupViewModel _GenZoneViewModel()
		{
			return null;
		}

		// Token: 0x0602990C RID: 170252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602990C")]
		[Address(RVA = "0x24F0DF0", Offset = "0x24EF9F0", VA = "0x1824F0DF0")]
		private TemplateActivityMissionViewModel _GenTemplateMissionViewModel()
		{
			return null;
		}

		// Token: 0x0602990D RID: 170253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602990D")]
		[Address(RVA = "0x24F09D0", Offset = "0x24EF5D0", VA = "0x1824F09D0")]
		private TemplateActivityCoinViewModel _GenCoinViewModel()
		{
			return null;
		}

		// Token: 0x0602990E RID: 170254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602990E")]
		[Address(RVA = "0x24F0AF0", Offset = "0x24EF6F0", VA = "0x1824F0AF0")]
		private TemplateActivityFavorViewModel _GenFavorViewModel()
		{
			return null;
		}

		// Token: 0x0602990F RID: 170255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602990F")]
		[Address(RVA = "0x24F0D10", Offset = "0x24EF910", VA = "0x1824F0D10")]
		private Act45SideEntryLivePageViewModel _GenLivePageViewModel()
		{
			return null;
		}

		// Token: 0x06029910 RID: 170256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029910")]
		[Address(RVA = "0x24F16C0", Offset = "0x24F02C0", VA = "0x1824F16C0")]
		private void _UpdateViewModel()
		{
		}

		// Token: 0x06029911 RID: 170257 RVA: 0x000D5F18 File Offset: 0x000D4118
		[Token(Token = "0x6029911")]
		[Address(RVA = "0x24F1340", Offset = "0x24EFF40", VA = "0x1824F1340")]
		private int _GetCoinCount()
		{
			return 0;
		}

		// Token: 0x06029912 RID: 170258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029912")]
		[Address(RVA = "0x24F17C0", Offset = "0x24F03C0", VA = "0x1824F17C0")]
		public Act45SideActivityController()
		{
		}

		// Token: 0x06029913 RID: 170259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029913")]
		[Address(RVA = "0x246D2E0", Offset = "0x246BEE0", VA = "0x18246D2E0")]
		private void <>xLuaBaseProxy_OnStagePageResumed(UIPageTransContext P0)
		{
		}

		// Token: 0x06029914 RID: 170260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029914")]
		[Address(RVA = "0x2470A90", Offset = "0x246F690", VA = "0x182470A90")]
		private TemplateMissionInputParam <>xLuaBaseProxy_CreateTemplateMissionInputParam()
		{
			return null;
		}

		// Token: 0x0403B6EE RID: 243438
		[Token(Token = "0x403B6EE")]
		private const string LIVE_PAGE_VIEWMODEL = "live_page";

		// Token: 0x0403B6EF RID: 243439
		[Token(Token = "0x403B6EF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitModelDict;

		// Token: 0x0403B6F0 RID: 243440
		[Token(Token = "0x403B6F0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnStagePageResumed;

		// Token: 0x0403B6F1 RID: 243441
		[Token(Token = "0x403B6F1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CreateTemplateMissionInputParam;

		// Token: 0x0403B6F2 RID: 243442
		[Token(Token = "0x403B6F2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetData;

		// Token: 0x0403B6F3 RID: 243443
		[Token(Token = "0x403B6F3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetPlayerData;

		// Token: 0x0403B6F4 RID: 243444
		[Token(Token = "0x403B6F4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GenLifeCycle;

		// Token: 0x0403B6F5 RID: 243445
		[Token(Token = "0x403B6F5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GenZoneViewModel;

		// Token: 0x0403B6F6 RID: 243446
		[Token(Token = "0x403B6F6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GenTemplateMissionViewModel;

		// Token: 0x0403B6F7 RID: 243447
		[Token(Token = "0x403B6F7")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GenCoinViewModel;

		// Token: 0x0403B6F8 RID: 243448
		[Token(Token = "0x403B6F8")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__GenFavorViewModel;

		// Token: 0x0403B6F9 RID: 243449
		[Token(Token = "0x403B6F9")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__GenLivePageViewModel;

		// Token: 0x0403B6FA RID: 243450
		[Token(Token = "0x403B6FA")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__UpdateViewModel;

		// Token: 0x0403B6FB RID: 243451
		[Token(Token = "0x403B6FB")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__GetCoinCount;

		// Token: 0x0403B6FC RID: 243452
		[Token(Token = "0x403B6FC")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
