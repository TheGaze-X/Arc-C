using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using Torappu.UI.TemplateMission;
using XLua;

namespace Torappu.Activity.Act36side
{
	// Token: 0x0200743E RID: 29758
	[Token(Token = "0x200743E")]
	public class Act36sideActivityController : TemplateActivityController, IHotfixable
	{
		// Token: 0x06029FF4 RID: 172020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029FF4")]
		[Address(RVA = "0x2598ED0", Offset = "0x2597AD0", VA = "0x182598ED0", Slot = "32")]
		public override void InitModelDict(string actId)
		{
		}

		// Token: 0x06029FF5 RID: 172021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029FF5")]
		[Address(RVA = "0x2599440", Offset = "0x2598040", VA = "0x182599440", Slot = "13")]
		protected override void OnStageTimeout()
		{
		}

		// Token: 0x06029FF6 RID: 172022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029FF6")]
		[Address(RVA = "0x25993A0", Offset = "0x2597FA0", VA = "0x1825993A0", Slot = "17")]
		protected override void OnStagePageResumed(UIPageTransContext context)
		{
		}

		// Token: 0x06029FF7 RID: 172023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029FF7")]
		[Address(RVA = "0x259A0D0", Offset = "0x2598CD0", VA = "0x18259A0D0")]
		private Act36SideData _GetData()
		{
			return null;
		}

		// Token: 0x06029FF8 RID: 172024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029FF8")]
		[Address(RVA = "0x259A250", Offset = "0x2598E50", VA = "0x18259A250")]
		private PlayerActivity.PlayerAct36SideActivity _GetPlayerData()
		{
			return null;
		}

		// Token: 0x06029FF9 RID: 172025 RVA: 0x000D72C8 File Offset: 0x000D54C8
		[Token(Token = "0x6029FF9")]
		[Address(RVA = "0x259A060", Offset = "0x2598C60", VA = "0x18259A060")]
		private int _GetCoinCount()
		{
			return 0;
		}

		// Token: 0x06029FFA RID: 172026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029FFA")]
		[Address(RVA = "0x2599900", Offset = "0x2598500", VA = "0x182599900")]
		private TemplateActivityLifeCycleViewModel _GenLifeCycle()
		{
			return null;
		}

		// Token: 0x06029FFB RID: 172027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029FFB")]
		[Address(RVA = "0x2599BB0", Offset = "0x25987B0", VA = "0x182599BB0")]
		private TemplateActivityZoneGroupViewModel _GenZoneViewModel()
		{
			return null;
		}

		// Token: 0x06029FFC RID: 172028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029FFC")]
		[Address(RVA = "0x2599AF0", Offset = "0x25986F0", VA = "0x182599AF0")]
		private TemplateActivityMissionViewModel _GenTemplateMissionViewModel()
		{
			return null;
		}

		// Token: 0x06029FFD RID: 172029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029FFD")]
		[Address(RVA = "0x2598C30", Offset = "0x2597830", VA = "0x182598C30", Slot = "35")]
		public override TemplateMissionInputParam CreateTemplateMissionInputParam()
		{
			return null;
		}

		// Token: 0x06029FFE RID: 172030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029FFE")]
		[Address(RVA = "0x2599A10", Offset = "0x2598610", VA = "0x182599A10")]
		private TemplateMissionCoinViewModel _GenMissionCoinViewModel()
		{
			return null;
		}

		// Token: 0x06029FFF RID: 172031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029FFF")]
		[Address(RVA = "0x25994D0", Offset = "0x25980D0", VA = "0x1825994D0")]
		private TemplateActivityCoinViewModel _GenCoinViewModel()
		{
			return null;
		}

		// Token: 0x0602A000 RID: 172032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A000")]
		[Address(RVA = "0x25995F0", Offset = "0x25981F0", VA = "0x1825995F0")]
		private TemplateActivityFavorViewModel _GenFavorViewModel()
		{
			return null;
		}

		// Token: 0x0602A001 RID: 172033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A001")]
		[Address(RVA = "0x2599700", Offset = "0x2598300", VA = "0x182599700")]
		private Act36sideEntryFoodHandbookViewModel _GenFoodHandbookViewModel()
		{
			return null;
		}

		// Token: 0x0602A002 RID: 172034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A002")]
		[Address(RVA = "0x259A3E0", Offset = "0x2598FE0", VA = "0x18259A3E0")]
		private void _UpdateViewModel()
		{
		}

		// Token: 0x0602A003 RID: 172035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A003")]
		[Address(RVA = "0x259A4E0", Offset = "0x25990E0", VA = "0x18259A4E0")]
		public Act36sideActivityController()
		{
		}

		// Token: 0x0602A005 RID: 172037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A005")]
		[Address(RVA = "0x246D320", Offset = "0x246BF20", VA = "0x18246D320")]
		private void <>xLuaBaseProxy_OnStageTimeout()
		{
		}

		// Token: 0x0602A006 RID: 172038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A006")]
		[Address(RVA = "0x246D2E0", Offset = "0x246BEE0", VA = "0x18246D2E0")]
		private void <>xLuaBaseProxy_OnStagePageResumed(UIPageTransContext P0)
		{
		}

		// Token: 0x0602A007 RID: 172039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A007")]
		[Address(RVA = "0x2470A90", Offset = "0x246F690", VA = "0x182470A90")]
		private TemplateMissionInputParam <>xLuaBaseProxy_CreateTemplateMissionInputParam()
		{
			return null;
		}

		// Token: 0x0403C3AD RID: 246701
		[Token(Token = "0x403C3AD")]
		private const string FOOD_HANDBOOK_PARAM = "food_handbook";

		// Token: 0x0403C3AE RID: 246702
		[Token(Token = "0x403C3AE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitModelDict;

		// Token: 0x0403C3AF RID: 246703
		[Token(Token = "0x403C3AF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnStageTimeout;

		// Token: 0x0403C3B0 RID: 246704
		[Token(Token = "0x403C3B0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnStagePageResumed;

		// Token: 0x0403C3B1 RID: 246705
		[Token(Token = "0x403C3B1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetData;

		// Token: 0x0403C3B2 RID: 246706
		[Token(Token = "0x403C3B2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetPlayerData;

		// Token: 0x0403C3B3 RID: 246707
		[Token(Token = "0x403C3B3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetCoinCount;

		// Token: 0x0403C3B4 RID: 246708
		[Token(Token = "0x403C3B4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GenLifeCycle;

		// Token: 0x0403C3B5 RID: 246709
		[Token(Token = "0x403C3B5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GenZoneViewModel;

		// Token: 0x0403C3B6 RID: 246710
		[Token(Token = "0x403C3B6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GenTemplateMissionViewModel;

		// Token: 0x0403C3B7 RID: 246711
		[Token(Token = "0x403C3B7")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CreateTemplateMissionInputParam;

		// Token: 0x0403C3B8 RID: 246712
		[Token(Token = "0x403C3B8")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__GenMissionCoinViewModel;

		// Token: 0x0403C3B9 RID: 246713
		[Token(Token = "0x403C3B9")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__GenCoinViewModel;

		// Token: 0x0403C3BA RID: 246714
		[Token(Token = "0x403C3BA")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__GenFavorViewModel;

		// Token: 0x0403C3BB RID: 246715
		[Token(Token = "0x403C3BB")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__GenFoodHandbookViewModel;

		// Token: 0x0403C3BC RID: 246716
		[Token(Token = "0x403C3BC")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__UpdateViewModel;

		// Token: 0x0403C3BD RID: 246717
		[Token(Token = "0x403C3BD")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
