using System;
using Il2CppDummyDll;
using Torappu.UI.Stage;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020076BA RID: 30394
	[Token(Token = "0x20076BA")]
	public class Act1VHalfIdlePageRoutePolicy : ActivityStageRoutePolicy
	{
		// Token: 0x0602ABFD RID: 175101 RVA: 0x000D9C50 File Offset: 0x000D7E50
		[Token(Token = "0x602ABFD")]
		[Address(RVA = "0x268A780", Offset = "0x2689380", VA = "0x18268A780", Slot = "9")]
		protected override ActivityStageRoutePolicy.ActivityStageRoutePath GenerateRoutePathFromStage(ActivityStageRoutePolicy.ActRouteTarget param)
		{
			return default(ActivityStageRoutePolicy.ActivityStageRoutePath);
		}

		// Token: 0x0602ABFE RID: 175102 RVA: 0x000D9C68 File Offset: 0x000D7E68
		[Token(Token = "0x602ABFE")]
		[Address(RVA = "0x268A4E0", Offset = "0x26890E0", VA = "0x18268A4E0", Slot = "10")]
		protected override ActivityStageRoutePolicy.ActivityStageRoutePath GenerateRoutePathFromDataBundle(RoutePolicy.BattleOutRouteInput param)
		{
			return default(ActivityStageRoutePolicy.ActivityStageRoutePath);
		}

		// Token: 0x0602ABFF RID: 175103 RVA: 0x000D9C80 File Offset: 0x000D7E80
		[Token(Token = "0x602ABFF")]
		[Address(RVA = "0x268A8A0", Offset = "0x26894A0", VA = "0x18268A8A0", Slot = "12")]
		protected override ActivityType GetActType()
		{
			return ActivityType.DEFAULT;
		}

		// Token: 0x0602AC00 RID: 175104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AC00")]
		[Address(RVA = "0x268A900", Offset = "0x2689500", VA = "0x18268A900")]
		public Act1VHalfIdlePageRoutePolicy()
		{
		}

		// Token: 0x0403D980 RID: 252288
		[Token(Token = "0x403D980")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GenerateRoutePathFromStage;

		// Token: 0x0403D981 RID: 252289
		[Token(Token = "0x403D981")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GenerateRoutePathFromDataBundle;

		// Token: 0x0403D982 RID: 252290
		[Token(Token = "0x403D982")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetActType;

		// Token: 0x0403D983 RID: 252291
		[Token(Token = "0x403D983")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
