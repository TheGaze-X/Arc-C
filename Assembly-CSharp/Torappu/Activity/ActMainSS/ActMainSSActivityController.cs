using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using Torappu.UI.TemplateMission;
using XLua;

namespace Torappu.Activity.ActMainSS
{
	// Token: 0x020070A5 RID: 28837
	[Token(Token = "0x20070A5")]
	public class ActMainSSActivityController : TemplateActivityController, IHotfixable
	{
		// Token: 0x06028FF4 RID: 167924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028FF4")]
		[Address(RVA = "0x2470400", Offset = "0x246F000", VA = "0x182470400", Slot = "32")]
		public override void InitModelDict(string actId)
		{
		}

		// Token: 0x06028FF5 RID: 167925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028FF5")]
		[Address(RVA = "0x24709A0", Offset = "0x246F5A0", VA = "0x1824709A0", Slot = "13")]
		protected override void OnStageTimeout()
		{
		}

		// Token: 0x06028FF6 RID: 167926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028FF6")]
		[Address(RVA = "0x2471330", Offset = "0x246FF30", VA = "0x182471330")]
		private ActMainSSData _GetData()
		{
			return null;
		}

		// Token: 0x06028FF7 RID: 167927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028FF7")]
		[Address(RVA = "0x24714B0", Offset = "0x24700B0", VA = "0x1824714B0")]
		private PlayerActivity.PlayerActMainSSActivity _GetPlayerData()
		{
			return null;
		}

		// Token: 0x06028FF8 RID: 167928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028FF8")]
		[Address(RVA = "0x2470FB0", Offset = "0x246FBB0", VA = "0x182470FB0")]
		private ActMainSSEntryZoneViewModel _GenZoneViewModel()
		{
			return null;
		}

		// Token: 0x06028FF9 RID: 167929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028FF9")]
		[Address(RVA = "0x2470EF0", Offset = "0x246FAF0", VA = "0x182470EF0")]
		private TemplateActivityMissionViewModel _GenTemplateMissionViewModel()
		{
			return null;
		}

		// Token: 0x06028FFA RID: 167930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028FFA")]
		[Address(RVA = "0x2470230", Offset = "0x246EE30", VA = "0x182470230", Slot = "35")]
		public override TemplateMissionInputParam CreateTemplateMissionInputParam()
		{
			return null;
		}

		// Token: 0x06028FFB RID: 167931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028FFB")]
		[Address(RVA = "0x2470AA0", Offset = "0x246F6A0", VA = "0x182470AA0")]
		private TemplateActivityCoinViewModel _GenCoinViewModel()
		{
			return null;
		}

		// Token: 0x06028FFC RID: 167932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028FFC")]
		[Address(RVA = "0x2470BC0", Offset = "0x246F7C0", VA = "0x182470BC0")]
		private TemplateActivityFavorViewModel _GenFavorViewModel()
		{
			return null;
		}

		// Token: 0x06028FFD RID: 167933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028FFD")]
		[Address(RVA = "0x2470CD0", Offset = "0x246F8D0", VA = "0x182470CD0")]
		private TemplateActivityLifeCycleViewModel _GenLifeCycle()
		{
			return null;
		}

		// Token: 0x06028FFE RID: 167934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028FFE")]
		[Address(RVA = "0x2470DE0", Offset = "0x246F9E0", VA = "0x182470DE0")]
		private TemplateActivityMedalViewModel _GenMedalViewModel()
		{
			return null;
		}

		// Token: 0x06028FFF RID: 167935 RVA: 0x000D4070 File Offset: 0x000D2270
		[Token(Token = "0x6028FFF")]
		[Address(RVA = "0x24712C0", Offset = "0x246FEC0", VA = "0x1824712C0")]
		private int _GetCoinCount()
		{
			return 0;
		}

		// Token: 0x06029000 RID: 167936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029000")]
		[Address(RVA = "0x2471640", Offset = "0x2470240", VA = "0x182471640")]
		public ActMainSSActivityController()
		{
		}

		// Token: 0x06029001 RID: 167937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029001")]
		[Address(RVA = "0x246D320", Offset = "0x246BF20", VA = "0x18246D320")]
		private void <>xLuaBaseProxy_OnStageTimeout()
		{
		}

		// Token: 0x06029002 RID: 167938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029002")]
		[Address(RVA = "0x2470A90", Offset = "0x246F690", VA = "0x182470A90")]
		private TemplateMissionInputParam <>xLuaBaseProxy_CreateTemplateMissionInputParam()
		{
			return null;
		}

		// Token: 0x0403A847 RID: 239687
		[Token(Token = "0x403A847")]
		[NonSerialized]
		public const string MAIN_SS_ZONE_PARAM = "main_ss_zone";

		// Token: 0x0403A848 RID: 239688
		[Token(Token = "0x403A848")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitModelDict;

		// Token: 0x0403A849 RID: 239689
		[Token(Token = "0x403A849")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnStageTimeout;

		// Token: 0x0403A84A RID: 239690
		[Token(Token = "0x403A84A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetData;

		// Token: 0x0403A84B RID: 239691
		[Token(Token = "0x403A84B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetPlayerData;

		// Token: 0x0403A84C RID: 239692
		[Token(Token = "0x403A84C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GenZoneViewModel;

		// Token: 0x0403A84D RID: 239693
		[Token(Token = "0x403A84D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GenTemplateMissionViewModel;

		// Token: 0x0403A84E RID: 239694
		[Token(Token = "0x403A84E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CreateTemplateMissionInputParam;

		// Token: 0x0403A84F RID: 239695
		[Token(Token = "0x403A84F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GenCoinViewModel;

		// Token: 0x0403A850 RID: 239696
		[Token(Token = "0x403A850")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GenFavorViewModel;

		// Token: 0x0403A851 RID: 239697
		[Token(Token = "0x403A851")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__GenLifeCycle;

		// Token: 0x0403A852 RID: 239698
		[Token(Token = "0x403A852")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__GenMedalViewModel;

		// Token: 0x0403A853 RID: 239699
		[Token(Token = "0x403A853")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__GetCoinCount;

		// Token: 0x0403A854 RID: 239700
		[Token(Token = "0x403A854")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
