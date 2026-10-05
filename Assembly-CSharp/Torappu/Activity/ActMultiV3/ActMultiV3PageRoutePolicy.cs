using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Stage;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006EB5 RID: 28341
	[Token(Token = "0x2006EB5")]
	public class ActMultiV3PageRoutePolicy : ActivityPageRoutePolicy
	{
		// Token: 0x06028519 RID: 165145 RVA: 0x000D16E8 File Offset: 0x000CF8E8
		[Token(Token = "0x6028519")]
		[Address(RVA = "0x238C9E0", Offset = "0x238B5E0", VA = "0x18238C9E0", Slot = "11")]
		protected override ActivityPageRoutePolicy.ActivityPageRoutePath GenerateEntryPageRoutePath(RoutePolicy.CommonEntryRouteInput param)
		{
			return default(ActivityPageRoutePolicy.ActivityPageRoutePath);
		}

		// Token: 0x0602851A RID: 165146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602851A")]
		[Address(RVA = "0x238CB40", Offset = "0x238B740", VA = "0x18238CB40", Slot = "10")]
		protected override List<ActivityPageRoutePolicy.ActivityPageRoutePath> GenerateRoutePathsFromDataBundle(RoutePolicy.BattleOutRouteInput param)
		{
			return null;
		}

		// Token: 0x0602851B RID: 165147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602851B")]
		[Address(RVA = "0x238CD00", Offset = "0x238B900", VA = "0x18238CD00", Slot = "9")]
		protected override List<ActivityPageRoutePolicy.ActivityPageRoutePath> GenerateRoutePathsFromStage(RoutePolicy.CommonStageRouteInput param)
		{
			return null;
		}

		// Token: 0x0602851C RID: 165148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602851C")]
		[Address(RVA = "0x238CE60", Offset = "0x238BA60", VA = "0x18238CE60")]
		private List<ActivityPageRoutePolicy.ActivityPageRoutePath> _RouteToEntryHome(string actId)
		{
			return null;
		}

		// Token: 0x0602851D RID: 165149 RVA: 0x000D1700 File Offset: 0x000CF900
		[Token(Token = "0x602851D")]
		[Address(RVA = "0x238CE00", Offset = "0x238BA00", VA = "0x18238CE00", Slot = "13")]
		protected override ActivityType GetActType()
		{
			return ActivityType.DEFAULT;
		}

		// Token: 0x0602851E RID: 165150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602851E")]
		[Address(RVA = "0x238D030", Offset = "0x238BC30", VA = "0x18238D030")]
		public ActMultiV3PageRoutePolicy()
		{
		}

		// Token: 0x040394C7 RID: 234695
		[Token(Token = "0x40394C7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GenerateEntryPageRoutePath;

		// Token: 0x040394C8 RID: 234696
		[Token(Token = "0x40394C8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GenerateRoutePathsFromDataBundle;

		// Token: 0x040394C9 RID: 234697
		[Token(Token = "0x40394C9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GenerateRoutePathsFromStage;

		// Token: 0x040394CA RID: 234698
		[Token(Token = "0x40394CA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RouteToEntryHome;

		// Token: 0x040394CB RID: 234699
		[Token(Token = "0x40394CB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetActType;

		// Token: 0x040394CC RID: 234700
		[Token(Token = "0x40394CC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
