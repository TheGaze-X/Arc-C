using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using Torappu.UI.ActivityStage.Extern;
using XLua;

namespace Torappu.Activity.Act17side
{
	// Token: 0x020079A5 RID: 31141
	[Token(Token = "0x20079A5")]
	public class Act17sideActivityController : TemplateActivityController
	{
		// Token: 0x0602BAF2 RID: 178930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BAF2")]
		[Address(RVA = "0x279FEC0", Offset = "0x279EAC0", VA = "0x18279FEC0", Slot = "32")]
		public override void InitModelDict(string actId)
		{
		}

		// Token: 0x0602BAF3 RID: 178931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BAF3")]
		[Address(RVA = "0x27A0590", Offset = "0x279F190", VA = "0x1827A0590")]
		public void OpenRPPage(string zoneId, [Optional] string stageId)
		{
		}

		// Token: 0x0602BAF4 RID: 178932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BAF4")]
		[Address(RVA = "0x279FBB0", Offset = "0x279E7B0", VA = "0x18279FBB0", Slot = "5")]
		protected override ActivityStageBridge CreateBridge()
		{
			return null;
		}

		// Token: 0x0602BAF5 RID: 178933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BAF5")]
		[Address(RVA = "0x27A0370", Offset = "0x279EF70", VA = "0x1827A0370", Slot = "13")]
		protected override void OnStageTimeout()
		{
		}

		// Token: 0x0602BAF6 RID: 178934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BAF6")]
		[Address(RVA = "0x279FC40", Offset = "0x279E840", VA = "0x18279FC40")]
		public Act17sideData GetData()
		{
			return null;
		}

		// Token: 0x0602BAF7 RID: 178935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BAF7")]
		[Address(RVA = "0x279FD90", Offset = "0x279E990", VA = "0x18279FD90")]
		public PlayerActivity.PlayerAct17SideActivity GetPlayerData()
		{
			return null;
		}

		// Token: 0x0602BAF8 RID: 178936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BAF8")]
		[Address(RVA = "0x27A0710", Offset = "0x279F310", VA = "0x1827A0710")]
		private Act17sideButtonViewModel _GenButtonViewModel()
		{
			return null;
		}

		// Token: 0x0602BAF9 RID: 178937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BAF9")]
		[Address(RVA = "0x27A0B30", Offset = "0x279F730", VA = "0x1827A0B30")]
		private Act17sideActivityZoneGroupViewModel _GenZoneViewModel()
		{
			return null;
		}

		// Token: 0x0602BAFA RID: 178938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BAFA")]
		[Address(RVA = "0x27A0A20", Offset = "0x279F620", VA = "0x1827A0A20")]
		private TemplateActivityLifeCycleViewModel _GenLifeCycle()
		{
			return null;
		}

		// Token: 0x0602BAFB RID: 178939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BAFB")]
		[Address(RVA = "0x27A07E0", Offset = "0x279F3E0", VA = "0x1827A07E0")]
		private TemplateActivityCoinViewModel _GenCoinStateViewModel()
		{
			return null;
		}

		// Token: 0x0602BAFC RID: 178940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BAFC")]
		[Address(RVA = "0x27A0910", Offset = "0x279F510", VA = "0x1827A0910")]
		private TemplateActivityFavorViewModel _GenFavorStateViewModel()
		{
			return null;
		}

		// Token: 0x0602BAFD RID: 178941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BAFD")]
		[Address(RVA = "0x27A0470", Offset = "0x279F070", VA = "0x1827A0470")]
		public void OnZoneSelected(string zoneId)
		{
		}

		// Token: 0x0602BAFE RID: 178942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BAFE")]
		[Address(RVA = "0x27A0DF0", Offset = "0x279F9F0", VA = "0x1827A0DF0")]
		public Act17sideActivityController()
		{
		}

		// Token: 0x0602BB00 RID: 178944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BB00")]
		[Address(RVA = "0x27955E0", Offset = "0x27941E0", VA = "0x1827955E0")]
		private ActivityStageBridge <>xLuaBaseProxy_CreateBridge()
		{
			return null;
		}

		// Token: 0x0602BB01 RID: 178945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BB01")]
		[Address(RVA = "0x246D320", Offset = "0x246BF20", VA = "0x18246D320")]
		private void <>xLuaBaseProxy_OnStageTimeout()
		{
		}

		// Token: 0x0403F343 RID: 258883
		[Token(Token = "0x403F343")]
		public const string BUTTON_STATE_VIEWMODEL = "act17side_button";

		// Token: 0x0403F344 RID: 258884
		[Token(Token = "0x403F344")]
		public const string ZONE_VIEWMODEL = "act17side_zone_viewmodel";

		// Token: 0x0403F345 RID: 258885
		[Token(Token = "0x403F345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitModelDict;

		// Token: 0x0403F346 RID: 258886
		[Token(Token = "0x403F346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OpenRPPage;

		// Token: 0x0403F347 RID: 258887
		[Token(Token = "0x403F347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CreateBridge;

		// Token: 0x0403F348 RID: 258888
		[Token(Token = "0x403F348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnStageTimeout;

		// Token: 0x0403F349 RID: 258889
		[Token(Token = "0x403F349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetData;

		// Token: 0x0403F34A RID: 258890
		[Token(Token = "0x403F34A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetPlayerData;

		// Token: 0x0403F34B RID: 258891
		[Token(Token = "0x403F34B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GenButtonViewModel;

		// Token: 0x0403F34C RID: 258892
		[Token(Token = "0x403F34C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GenZoneViewModel;

		// Token: 0x0403F34D RID: 258893
		[Token(Token = "0x403F34D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GenLifeCycle;

		// Token: 0x0403F34E RID: 258894
		[Token(Token = "0x403F34E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__GenCoinStateViewModel;

		// Token: 0x0403F34F RID: 258895
		[Token(Token = "0x403F34F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__GenFavorStateViewModel;

		// Token: 0x0403F350 RID: 258896
		[Token(Token = "0x403F350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnZoneSelected;

		// Token: 0x0403F351 RID: 258897
		[Token(Token = "0x403F351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020079A6 RID: 31142
		[Token(Token = "0x20079A6")]
		private class Bridge : ActivityStageBridge
		{
			// Token: 0x0602BB02 RID: 178946 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BB02")]
			[Address(RVA = "0x27A8DF0", Offset = "0x27A79F0", VA = "0x1827A8DF0", Slot = "5")]
			protected override void OnZoneSelected(string selectedZoneId)
			{
			}

			// Token: 0x0602BB03 RID: 178947 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BB03")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public Bridge()
			{
			}
		}
	}
}
