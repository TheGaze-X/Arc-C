using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.ActivityPage;
using Torappu.UI.Stage;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006DD7 RID: 28119
	[Token(Token = "0x2006DD7")]
	public class ActVecBreakV2PageRoutePolicy : ActivityEntryPageRoutePolicy
	{
		// Token: 0x06028091 RID: 163985 RVA: 0x000D0758 File Offset: 0x000CE958
		[Token(Token = "0x6028091")]
		[Address(RVA = "0x2354AD0", Offset = "0x23536D0", VA = "0x182354AD0", Slot = "11")]
		protected override ActivityPageRoutePolicy.ActivityPageRoutePath GenerateEntryPageRoutePath(RoutePolicy.CommonEntryRouteInput param)
		{
			return default(ActivityPageRoutePolicy.ActivityPageRoutePath);
		}

		// Token: 0x06028092 RID: 163986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028092")]
		[Address(RVA = "0x2354C30", Offset = "0x2353830", VA = "0x182354C30", Slot = "14")]
		protected override List<ActivityPageRoutePolicy.ActivityPageRoutePath> GenerateRoutePathsOverEntry(string actId, RoutePolicy.BattleOutRouteInput param)
		{
			return null;
		}

		// Token: 0x06028093 RID: 163987 RVA: 0x000D0770 File Offset: 0x000CE970
		[Token(Token = "0x6028093")]
		[Address(RVA = "0x2354FC0", Offset = "0x2353BC0", VA = "0x182354FC0", Slot = "13")]
		protected override ActivityType GetActType()
		{
			return ActivityType.DEFAULT;
		}

		// Token: 0x06028094 RID: 163988 RVA: 0x000D0788 File Offset: 0x000CE988
		[Token(Token = "0x6028094")]
		[Address(RVA = "0x2355020", Offset = "0x2353C20", VA = "0x182355020")]
		private ActVecBreakV2PageRoutePolicy.RouteType _CalcRouteType(string actId, string stageId)
		{
			return ActVecBreakV2PageRoutePolicy.RouteType.NONE;
		}

		// Token: 0x06028095 RID: 163989 RVA: 0x000D07A0 File Offset: 0x000CE9A0
		[Token(Token = "0x6028095")]
		[Address(RVA = "0x2355380", Offset = "0x2353F80", VA = "0x182355380")]
		private ActivityPageRoutePolicy.ActivityPageRoutePath _GenerateOffensePageRoutePath(DataBundle bundleToJumpBack)
		{
			return default(ActivityPageRoutePolicy.ActivityPageRoutePath);
		}

		// Token: 0x06028096 RID: 163990 RVA: 0x000D07B8 File Offset: 0x000CE9B8
		[Token(Token = "0x6028096")]
		[Address(RVA = "0x2355270", Offset = "0x2353E70", VA = "0x182355270")]
		private ActivityPageRoutePolicy.ActivityPageRoutePath _GenerateDefensePageRoutePath(DataBundle bundleToJumpBack)
		{
			return default(ActivityPageRoutePolicy.ActivityPageRoutePath);
		}

		// Token: 0x06028097 RID: 163991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028097")]
		[Address(RVA = "0x2355490", Offset = "0x2354090", VA = "0x182355490")]
		public ActVecBreakV2PageRoutePolicy()
		{
		}

		// Token: 0x06028098 RID: 163992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028098")]
		[Address(RVA = "0x18078E0", Offset = "0x18064E0", VA = "0x1818078E0")]
		private List<ActivityPageRoutePolicy.ActivityPageRoutePath> <>xLuaBaseProxy_GenerateRoutePathsOverEntry(string P0, RoutePolicy.BattleOutRouteInput P1)
		{
			return null;
		}

		// Token: 0x04038C61 RID: 232545
		[Token(Token = "0x4038C61")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GenerateEntryPageRoutePath;

		// Token: 0x04038C62 RID: 232546
		[Token(Token = "0x4038C62")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GenerateRoutePathsOverEntry;

		// Token: 0x04038C63 RID: 232547
		[Token(Token = "0x4038C63")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetActType;

		// Token: 0x04038C64 RID: 232548
		[Token(Token = "0x4038C64")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CalcRouteType;

		// Token: 0x04038C65 RID: 232549
		[Token(Token = "0x4038C65")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GenerateOffensePageRoutePath;

		// Token: 0x04038C66 RID: 232550
		[Token(Token = "0x4038C66")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GenerateDefensePageRoutePath;

		// Token: 0x04038C67 RID: 232551
		[Token(Token = "0x4038C67")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006DD8 RID: 28120
		[Token(Token = "0x2006DD8")]
		private enum RouteType
		{
			// Token: 0x04038C69 RID: 232553
			[Token(Token = "0x4038C69")]
			NONE,
			// Token: 0x04038C6A RID: 232554
			[Token(Token = "0x4038C6A")]
			OFFENSE,
			// Token: 0x04038C6B RID: 232555
			[Token(Token = "0x4038C6B")]
			DEFENSE,
			// Token: 0x04038C6C RID: 232556
			[Token(Token = "0x4038C6C")]
			HARD
		}
	}
}
