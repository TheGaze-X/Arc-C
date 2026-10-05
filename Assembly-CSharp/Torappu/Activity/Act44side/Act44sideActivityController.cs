using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using Torappu.UI.TemplateMission;
using XLua;

namespace Torappu.Activity.Act44side
{
	// Token: 0x020072E9 RID: 29417
	[Token(Token = "0x20072E9")]
	public class Act44sideActivityController : TemplateActivityController, IHotfixable
	{
		// Token: 0x060299FA RID: 170490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60299FA")]
		[Address(RVA = "0x24ED200", Offset = "0x24EBE00", VA = "0x1824ED200", Slot = "32")]
		public override void InitModelDict(string actId)
		{
		}

		// Token: 0x060299FB RID: 170491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60299FB")]
		[Address(RVA = "0x24ED8A0", Offset = "0x24EC4A0", VA = "0x1824ED8A0", Slot = "17")]
		protected override void OnStagePageResumed(UIPageTransContext context)
		{
		}

		// Token: 0x060299FC RID: 170492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60299FC")]
		[Address(RVA = "0x24ED830", Offset = "0x24EC430", VA = "0x1824ED830", Slot = "14")]
		protected override void OnRewardTimeout()
		{
		}

		// Token: 0x060299FD RID: 170493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60299FD")]
		[Address(RVA = "0x24ED940", Offset = "0x24EC540", VA = "0x1824ED940", Slot = "13")]
		protected override void OnStageTimeout()
		{
		}

		// Token: 0x060299FE RID: 170494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60299FE")]
		[Address(RVA = "0x24EE300", Offset = "0x24ECF00", VA = "0x1824EE300")]
		private Act44SideData _GetData()
		{
			return null;
		}

		// Token: 0x060299FF RID: 170495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60299FF")]
		[Address(RVA = "0x24EE490", Offset = "0x24ED090", VA = "0x1824EE490")]
		private PlayerActivity.PlayerAct44SideActivity _GetPlayerData()
		{
			return null;
		}

		// Token: 0x06029A00 RID: 170496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029A00")]
		[Address(RVA = "0x24EDD50", Offset = "0x24EC950", VA = "0x1824EDD50")]
		private TemplateActivityLifeCycleViewModel _GenLifeCycle()
		{
			return null;
		}

		// Token: 0x06029A01 RID: 170497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029A01")]
		[Address(RVA = "0x24EDF40", Offset = "0x24ECB40", VA = "0x1824EDF40")]
		private TemplateActivityZoneGroupViewModel _GenZoneViewModel()
		{
			return null;
		}

		// Token: 0x06029A02 RID: 170498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029A02")]
		[Address(RVA = "0x24EDE80", Offset = "0x24ECA80", VA = "0x1824EDE80")]
		private TemplateActivityMissionViewModel _GenTemplateMissionViewModel()
		{
			return null;
		}

		// Token: 0x06029A03 RID: 170499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029A03")]
		[Address(RVA = "0x24ED9B0", Offset = "0x24EC5B0", VA = "0x1824ED9B0")]
		private TemplateActivityCoinViewModel _GenCoinViewModel()
		{
			return null;
		}

		// Token: 0x06029A04 RID: 170500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029A04")]
		[Address(RVA = "0x24EDAD0", Offset = "0x24EC6D0", VA = "0x1824EDAD0")]
		private TemplateActivityFavorViewModel _GenFavorViewModel()
		{
			return null;
		}

		// Token: 0x06029A05 RID: 170501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029A05")]
		[Address(RVA = "0x24EDBE0", Offset = "0x24EC7E0", VA = "0x1824EDBE0")]
		private Act44SideEntryInformantViewModel _GenInformantViewModel()
		{
			return null;
		}

		// Token: 0x06029A06 RID: 170502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A06")]
		[Address(RVA = "0x24EE630", Offset = "0x24ED230", VA = "0x1824EE630")]
		private void _UpdateViewModel()
		{
		}

		// Token: 0x06029A07 RID: 170503 RVA: 0x000D6110 File Offset: 0x000D4310
		[Token(Token = "0x6029A07")]
		[Address(RVA = "0x24EE290", Offset = "0x24ECE90", VA = "0x1824EE290")]
		private int _GetCoinCount()
		{
			return 0;
		}

		// Token: 0x06029A08 RID: 170504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A08")]
		[Address(RVA = "0x24EE730", Offset = "0x24ED330", VA = "0x1824EE730")]
		public Act44sideActivityController()
		{
		}

		// Token: 0x06029A09 RID: 170505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A09")]
		[Address(RVA = "0x246D2E0", Offset = "0x246BEE0", VA = "0x18246D2E0")]
		private void <>xLuaBaseProxy_OnStagePageResumed(UIPageTransContext P0)
		{
		}

		// Token: 0x06029A0A RID: 170506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A0A")]
		[Address(RVA = "0x247CFA0", Offset = "0x247BBA0", VA = "0x18247CFA0")]
		private void <>xLuaBaseProxy_OnRewardTimeout()
		{
		}

		// Token: 0x06029A0B RID: 170507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A0B")]
		[Address(RVA = "0x246D320", Offset = "0x246BF20", VA = "0x18246D320")]
		private void <>xLuaBaseProxy_OnStageTimeout()
		{
		}

		// Token: 0x0403B89E RID: 243870
		[Token(Token = "0x403B89E")]
		private const string INFORMANT_PARAM = "informant";

		// Token: 0x0403B89F RID: 243871
		[Token(Token = "0x403B89F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitModelDict;

		// Token: 0x0403B8A0 RID: 243872
		[Token(Token = "0x403B8A0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnStagePageResumed;

		// Token: 0x0403B8A1 RID: 243873
		[Token(Token = "0x403B8A1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRewardTimeout;

		// Token: 0x0403B8A2 RID: 243874
		[Token(Token = "0x403B8A2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnStageTimeout;

		// Token: 0x0403B8A3 RID: 243875
		[Token(Token = "0x403B8A3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetData;

		// Token: 0x0403B8A4 RID: 243876
		[Token(Token = "0x403B8A4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetPlayerData;

		// Token: 0x0403B8A5 RID: 243877
		[Token(Token = "0x403B8A5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GenLifeCycle;

		// Token: 0x0403B8A6 RID: 243878
		[Token(Token = "0x403B8A6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GenZoneViewModel;

		// Token: 0x0403B8A7 RID: 243879
		[Token(Token = "0x403B8A7")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GenTemplateMissionViewModel;

		// Token: 0x0403B8A8 RID: 243880
		[Token(Token = "0x403B8A8")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__GenCoinViewModel;

		// Token: 0x0403B8A9 RID: 243881
		[Token(Token = "0x403B8A9")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__GenFavorViewModel;

		// Token: 0x0403B8AA RID: 243882
		[Token(Token = "0x403B8AA")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__GenInformantViewModel;

		// Token: 0x0403B8AB RID: 243883
		[Token(Token = "0x403B8AB")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__UpdateViewModel;

		// Token: 0x0403B8AC RID: 243884
		[Token(Token = "0x403B8AC")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__GetCoinCount;

		// Token: 0x0403B8AD RID: 243885
		[Token(Token = "0x403B8AD")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
