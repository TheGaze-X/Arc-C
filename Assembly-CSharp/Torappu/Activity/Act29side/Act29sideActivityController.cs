using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using Torappu.UI.TemplateMission;
using XLua;

namespace Torappu.Activity.Act29side
{
	// Token: 0x020074A8 RID: 29864
	[Token(Token = "0x20074A8")]
	public class Act29sideActivityController : TemplateActivityController, IHotfixable
	{
		// Token: 0x0602A1E7 RID: 172519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A1E7")]
		[Address(RVA = "0x25AC9C0", Offset = "0x25AB5C0", VA = "0x1825AC9C0", Slot = "32")]
		public override void InitModelDict(string actId)
		{
		}

		// Token: 0x0602A1E8 RID: 172520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A1E8")]
		[Address(RVA = "0x25AD230", Offset = "0x25ABE30", VA = "0x1825AD230", Slot = "13")]
		protected override void OnStageTimeout()
		{
		}

		// Token: 0x0602A1E9 RID: 172521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A1E9")]
		[Address(RVA = "0x25AD190", Offset = "0x25ABD90", VA = "0x1825AD190", Slot = "17")]
		protected override void OnStagePageResumed(UIPageTransContext context)
		{
		}

		// Token: 0x0602A1EA RID: 172522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A1EA")]
		[Address(RVA = "0x25ADDB0", Offset = "0x25AC9B0", VA = "0x1825ADDB0")]
		private Act29SideData _GetData()
		{
			return null;
		}

		// Token: 0x0602A1EB RID: 172523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A1EB")]
		[Address(RVA = "0x25ADF30", Offset = "0x25ACB30", VA = "0x1825ADF30")]
		private PlayerActivity.PlayerAct29SideActivity _GetPlayerData()
		{
			return null;
		}

		// Token: 0x0602A1EC RID: 172524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A1EC")]
		[Address(RVA = "0x25AD660", Offset = "0x25AC260", VA = "0x1825AD660")]
		private TemplateActivityLifeCycleViewModel _GenLifeCycle()
		{
			return null;
		}

		// Token: 0x0602A1ED RID: 172525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A1ED")]
		[Address(RVA = "0x25AD9D0", Offset = "0x25AC5D0", VA = "0x1825AD9D0")]
		private TemplateActivityZoneGroupViewModel _GenZoneViewModel()
		{
			return null;
		}

		// Token: 0x0602A1EE RID: 172526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A1EE")]
		[Address(RVA = "0x25AD770", Offset = "0x25AC370", VA = "0x1825AD770")]
		private TemplateActivityMissionGroupViewModel _GenMissionViewModel()
		{
			return null;
		}

		// Token: 0x0602A1EF RID: 172527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A1EF")]
		[Address(RVA = "0x25AD910", Offset = "0x25AC510", VA = "0x1825AD910")]
		private TemplateActivityMissionViewModel _GenTemplateMissionViewModel()
		{
			return null;
		}

		// Token: 0x0602A1F0 RID: 172528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A1F0")]
		[Address(RVA = "0x25AD2C0", Offset = "0x25ABEC0", VA = "0x1825AD2C0")]
		private TemplateActivityCoinViewModel _GenCoinViewModel()
		{
			return null;
		}

		// Token: 0x0602A1F1 RID: 172529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A1F1")]
		[Address(RVA = "0x25AD3E0", Offset = "0x25ABFE0", VA = "0x1825AD3E0")]
		private TemplateActivityFavorViewModel _GenFavorViewModel()
		{
			return null;
		}

		// Token: 0x0602A1F2 RID: 172530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A1F2")]
		[Address(RVA = "0x25AD4F0", Offset = "0x25AC0F0", VA = "0x1825AD4F0")]
		private Act29sideEntryTuningViewModel _GenGroceryViewModel()
		{
			return null;
		}

		// Token: 0x0602A1F3 RID: 172531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A1F3")]
		[Address(RVA = "0x25AE0C0", Offset = "0x25ACCC0", VA = "0x1825AE0C0")]
		private void _UpdateViewModel()
		{
		}

		// Token: 0x0602A1F4 RID: 172532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A1F4")]
		[Address(RVA = "0x25AC8B0", Offset = "0x25AB4B0", VA = "0x1825AC8B0", Slot = "35")]
		public override TemplateMissionInputParam CreateTemplateMissionInputParam()
		{
			return null;
		}

		// Token: 0x0602A1F5 RID: 172533 RVA: 0x000D77A8 File Offset: 0x000D59A8
		[Token(Token = "0x602A1F5")]
		[Address(RVA = "0x25ADD40", Offset = "0x25AC940", VA = "0x1825ADD40")]
		private int _GetCoinCount()
		{
			return 0;
		}

		// Token: 0x0602A1F6 RID: 172534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A1F6")]
		[Address(RVA = "0x25AE1C0", Offset = "0x25ACDC0", VA = "0x1825AE1C0")]
		public Act29sideActivityController()
		{
		}

		// Token: 0x0602A1F8 RID: 172536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A1F8")]
		[Address(RVA = "0x246D320", Offset = "0x246BF20", VA = "0x18246D320")]
		private void <>xLuaBaseProxy_OnStageTimeout()
		{
		}

		// Token: 0x0602A1F9 RID: 172537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A1F9")]
		[Address(RVA = "0x246D2E0", Offset = "0x246BEE0", VA = "0x18246D2E0")]
		private void <>xLuaBaseProxy_OnStagePageResumed(UIPageTransContext P0)
		{
		}

		// Token: 0x0602A1FA RID: 172538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A1FA")]
		[Address(RVA = "0x2470A90", Offset = "0x246F690", VA = "0x182470A90")]
		private TemplateMissionInputParam <>xLuaBaseProxy_CreateTemplateMissionInputParam()
		{
			return null;
		}

		// Token: 0x0403C7C7 RID: 247751
		[Token(Token = "0x403C7C7")]
		private const string TUNING_VIEWMODEL = "tuning";

		// Token: 0x0403C7C8 RID: 247752
		[Token(Token = "0x403C7C8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitModelDict;

		// Token: 0x0403C7C9 RID: 247753
		[Token(Token = "0x403C7C9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnStageTimeout;

		// Token: 0x0403C7CA RID: 247754
		[Token(Token = "0x403C7CA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnStagePageResumed;

		// Token: 0x0403C7CB RID: 247755
		[Token(Token = "0x403C7CB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetData;

		// Token: 0x0403C7CC RID: 247756
		[Token(Token = "0x403C7CC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetPlayerData;

		// Token: 0x0403C7CD RID: 247757
		[Token(Token = "0x403C7CD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GenLifeCycle;

		// Token: 0x0403C7CE RID: 247758
		[Token(Token = "0x403C7CE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GenZoneViewModel;

		// Token: 0x0403C7CF RID: 247759
		[Token(Token = "0x403C7CF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GenMissionViewModel;

		// Token: 0x0403C7D0 RID: 247760
		[Token(Token = "0x403C7D0")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GenTemplateMissionViewModel;

		// Token: 0x0403C7D1 RID: 247761
		[Token(Token = "0x403C7D1")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__GenCoinViewModel;

		// Token: 0x0403C7D2 RID: 247762
		[Token(Token = "0x403C7D2")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__GenFavorViewModel;

		// Token: 0x0403C7D3 RID: 247763
		[Token(Token = "0x403C7D3")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__GenGroceryViewModel;

		// Token: 0x0403C7D4 RID: 247764
		[Token(Token = "0x403C7D4")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__UpdateViewModel;

		// Token: 0x0403C7D5 RID: 247765
		[Token(Token = "0x403C7D5")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_CreateTemplateMissionInputParam;

		// Token: 0x0403C7D6 RID: 247766
		[Token(Token = "0x403C7D6")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__GetCoinCount;

		// Token: 0x0403C7D7 RID: 247767
		[Token(Token = "0x403C7D7")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
