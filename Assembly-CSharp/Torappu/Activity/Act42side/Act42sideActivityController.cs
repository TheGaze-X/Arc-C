using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using Torappu.UI.TemplateMission;
using XLua;

namespace Torappu.Activity.Act42side
{
	// Token: 0x020072F1 RID: 29425
	[Token(Token = "0x20072F1")]
	public class Act42sideActivityController : TemplateActivityController, IHotfixable
	{
		// Token: 0x06029A31 RID: 170545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A31")]
		[Address(RVA = "0x2514DB0", Offset = "0x25139B0", VA = "0x182514DB0", Slot = "32")]
		public override void InitModelDict(string actId)
		{
		}

		// Token: 0x06029A32 RID: 170546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A32")]
		[Address(RVA = "0x2515320", Offset = "0x2513F20", VA = "0x182515320", Slot = "13")]
		protected override void OnStageTimeout()
		{
		}

		// Token: 0x06029A33 RID: 170547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A33")]
		[Address(RVA = "0x2515280", Offset = "0x2513E80", VA = "0x182515280", Slot = "17")]
		protected override void OnStagePageResumed(UIPageTransContext context)
		{
		}

		// Token: 0x06029A34 RID: 170548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029A34")]
		[Address(RVA = "0x2514CA0", Offset = "0x25138A0", VA = "0x182514CA0", Slot = "35")]
		public override TemplateMissionInputParam CreateTemplateMissionInputParam()
		{
			return null;
		}

		// Token: 0x06029A35 RID: 170549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A35")]
		[Address(RVA = "0x2515D60", Offset = "0x2514960", VA = "0x182515D60")]
		private void _UpdateViewModel()
		{
		}

		// Token: 0x06029A36 RID: 170550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029A36")]
		[Address(RVA = "0x25157A0", Offset = "0x25143A0", VA = "0x1825157A0")]
		private TemplateActivityLifeCycleViewModel _GenLifeCycle()
		{
			return null;
		}

		// Token: 0x06029A37 RID: 170551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029A37")]
		[Address(RVA = "0x25155C0", Offset = "0x25141C0", VA = "0x1825155C0")]
		private Act42SideEntryGunTaskViewModel _GenGunTaskViewModel()
		{
			return null;
		}

		// Token: 0x06029A38 RID: 170552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029A38")]
		[Address(RVA = "0x2515390", Offset = "0x2513F90", VA = "0x182515390")]
		private TemplateActivityCoinViewModel _GenCoinViewModel()
		{
			return null;
		}

		// Token: 0x06029A39 RID: 170553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029A39")]
		[Address(RVA = "0x25154B0", Offset = "0x25140B0", VA = "0x1825154B0")]
		private TemplateActivityFavorViewModel _GenFavorViewModel()
		{
			return null;
		}

		// Token: 0x06029A3A RID: 170554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029A3A")]
		[Address(RVA = "0x2515970", Offset = "0x2514570", VA = "0x182515970")]
		private TemplateActivityZoneGroupViewModel _GenZoneViewModel()
		{
			return null;
		}

		// Token: 0x06029A3B RID: 170555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029A3B")]
		[Address(RVA = "0x25158B0", Offset = "0x25144B0", VA = "0x1825158B0")]
		private TemplateActivityMissionViewModel _GenTemplateMissionViewModel()
		{
			return null;
		}

		// Token: 0x06029A3C RID: 170556 RVA: 0x000D61E8 File Offset: 0x000D43E8
		[Token(Token = "0x6029A3C")]
		[Address(RVA = "0x2515CE0", Offset = "0x25148E0", VA = "0x182515CE0")]
		private int _GetCoinCount()
		{
			return 0;
		}

		// Token: 0x06029A3D RID: 170557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A3D")]
		[Address(RVA = "0x2515E60", Offset = "0x2514A60", VA = "0x182515E60")]
		public Act42sideActivityController()
		{
		}

		// Token: 0x06029A3E RID: 170558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A3E")]
		[Address(RVA = "0x246D320", Offset = "0x246BF20", VA = "0x18246D320")]
		private void <>xLuaBaseProxy_OnStageTimeout()
		{
		}

		// Token: 0x06029A3F RID: 170559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A3F")]
		[Address(RVA = "0x246D2E0", Offset = "0x246BEE0", VA = "0x18246D2E0")]
		private void <>xLuaBaseProxy_OnStagePageResumed(UIPageTransContext P0)
		{
		}

		// Token: 0x06029A40 RID: 170560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029A40")]
		[Address(RVA = "0x2470A90", Offset = "0x246F690", VA = "0x182470A90")]
		private TemplateMissionInputParam <>xLuaBaseProxy_CreateTemplateMissionInputParam()
		{
			return null;
		}

		// Token: 0x0403B8FD RID: 243965
		[Token(Token = "0x403B8FD")]
		private const string GUN_TASK_VIEWMODEL = "gun_task";

		// Token: 0x0403B8FE RID: 243966
		[Token(Token = "0x403B8FE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitModelDict;

		// Token: 0x0403B8FF RID: 243967
		[Token(Token = "0x403B8FF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnStageTimeout;

		// Token: 0x0403B900 RID: 243968
		[Token(Token = "0x403B900")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnStagePageResumed;

		// Token: 0x0403B901 RID: 243969
		[Token(Token = "0x403B901")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CreateTemplateMissionInputParam;

		// Token: 0x0403B902 RID: 243970
		[Token(Token = "0x403B902")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateViewModel;

		// Token: 0x0403B903 RID: 243971
		[Token(Token = "0x403B903")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GenLifeCycle;

		// Token: 0x0403B904 RID: 243972
		[Token(Token = "0x403B904")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GenGunTaskViewModel;

		// Token: 0x0403B905 RID: 243973
		[Token(Token = "0x403B905")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GenCoinViewModel;

		// Token: 0x0403B906 RID: 243974
		[Token(Token = "0x403B906")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GenFavorViewModel;

		// Token: 0x0403B907 RID: 243975
		[Token(Token = "0x403B907")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__GenZoneViewModel;

		// Token: 0x0403B908 RID: 243976
		[Token(Token = "0x403B908")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__GenTemplateMissionViewModel;

		// Token: 0x0403B909 RID: 243977
		[Token(Token = "0x403B909")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__GetCoinCount;

		// Token: 0x0403B90A RID: 243978
		[Token(Token = "0x403B90A")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
