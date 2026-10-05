using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Stage;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x02007915 RID: 30997
	[Token(Token = "0x2007915")]
	public class Act1ArcadePageRoutePolicy : ActivityPageRoutePolicy
	{
		// Token: 0x0602B7CA RID: 178122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B7CA")]
		[Address(RVA = "0x2777F50", Offset = "0x2776B50", VA = "0x182777F50", Slot = "9")]
		protected override List<ActivityPageRoutePolicy.ActivityPageRoutePath> GenerateRoutePathsFromStage(RoutePolicy.CommonStageRouteInput param)
		{
			return null;
		}

		// Token: 0x0602B7CB RID: 178123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B7CB")]
		[Address(RVA = "0x2777E50", Offset = "0x2776A50", VA = "0x182777E50", Slot = "10")]
		protected override List<ActivityPageRoutePolicy.ActivityPageRoutePath> GenerateRoutePathsFromDataBundle(RoutePolicy.BattleOutRouteInput param)
		{
			return null;
		}

		// Token: 0x0602B7CC RID: 178124 RVA: 0x000DC2F0 File Offset: 0x000DA4F0
		[Token(Token = "0x602B7CC")]
		[Address(RVA = "0x2777D10", Offset = "0x2776910", VA = "0x182777D10", Slot = "11")]
		protected override ActivityPageRoutePolicy.ActivityPageRoutePath GenerateEntryPageRoutePath(RoutePolicy.CommonEntryRouteInput param)
		{
			return default(ActivityPageRoutePolicy.ActivityPageRoutePath);
		}

		// Token: 0x0602B7CD RID: 178125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B7CD")]
		[Address(RVA = "0x27782E0", Offset = "0x2776EE0", VA = "0x1827782E0")]
		private List<ActivityPageRoutePolicy.ActivityPageRoutePath> _RouteToEntryHome(string actId)
		{
			return null;
		}

		// Token: 0x0602B7CE RID: 178126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B7CE")]
		[Address(RVA = "0x27780C0", Offset = "0x2776CC0", VA = "0x1827780C0")]
		private List<ActivityPageRoutePolicy.ActivityPageRoutePath> _RouteToEntryHomeBattleOut(string actId, string prefStageId)
		{
			return null;
		}

		// Token: 0x0602B7CF RID: 178127 RVA: 0x000DC308 File Offset: 0x000DA508
		[Token(Token = "0x602B7CF")]
		[Address(RVA = "0x2778060", Offset = "0x2776C60", VA = "0x182778060", Slot = "13")]
		protected override ActivityType GetActType()
		{
			return ActivityType.DEFAULT;
		}

		// Token: 0x0602B7D0 RID: 178128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B7D0")]
		[Address(RVA = "0x27784B0", Offset = "0x27770B0", VA = "0x1827784B0")]
		public Act1ArcadePageRoutePolicy()
		{
		}

		// Token: 0x0403EE02 RID: 257538
		[Token(Token = "0x403EE02")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GenerateRoutePathsFromStage;

		// Token: 0x0403EE03 RID: 257539
		[Token(Token = "0x403EE03")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GenerateRoutePathsFromDataBundle;

		// Token: 0x0403EE04 RID: 257540
		[Token(Token = "0x403EE04")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GenerateEntryPageRoutePath;

		// Token: 0x0403EE05 RID: 257541
		[Token(Token = "0x403EE05")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RouteToEntryHome;

		// Token: 0x0403EE06 RID: 257542
		[Token(Token = "0x403EE06")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RouteToEntryHomeBattleOut;

		// Token: 0x0403EE07 RID: 257543
		[Token(Token = "0x403EE07")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetActType;

		// Token: 0x0403EE08 RID: 257544
		[Token(Token = "0x403EE08")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
