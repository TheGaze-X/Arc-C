using System;
using Il2CppDummyDll;
using Torappu.UI.Stage;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x02007336 RID: 29494
	[Token(Token = "0x2007336")]
	public class Act42D0ChallengeRoutePolicy : CustomActivityStageRoutePolicy<Act42D0ChallengePage.Param>
	{
		// Token: 0x06029B5E RID: 170846 RVA: 0x000D6458 File Offset: 0x000D4658
		[Token(Token = "0x6029B5E")]
		[Address(RVA = "0x2505B40", Offset = "0x2504740", VA = "0x182505B40", Slot = "11")]
		protected override bool UseActPolicy(RoutePolicy.Condition condition)
		{
			return default(bool);
		}

		// Token: 0x06029B5F RID: 170847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B5F")]
		[Address(RVA = "0x2505A50", Offset = "0x2504650", VA = "0x182505A50", Slot = "18")]
		protected override void GetOverrideActivityIdFromDataBundle(RoutePolicy.BattleOutRouteInput input, out string actId)
		{
		}

		// Token: 0x17006280 RID: 25216
		// (get) Token: 0x06029B60 RID: 170848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006280")]
		protected override string pageName
		{
			[Token(Token = "0x6029B60")]
			[Address(RVA = "0x2505D20", Offset = "0x2504920", VA = "0x182505D20", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x06029B61 RID: 170849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029B61")]
		[Address(RVA = "0x2505840", Offset = "0x2504440", VA = "0x182505840", Slot = "15")]
		protected override Act42D0ChallengePage.Param CreateParamFromDataBundle(RoutePolicy.BattleOutRouteInput input)
		{
			return null;
		}

		// Token: 0x06029B62 RID: 170850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029B62")]
		[Address(RVA = "0x2505900", Offset = "0x2504500", VA = "0x182505900", Slot = "14")]
		protected override Act42D0ChallengePage.Param CreateParamFromStage(ActivityStageRoutePolicy.ActRouteTarget input)
		{
			return null;
		}

		// Token: 0x06029B63 RID: 170851 RVA: 0x000D6470 File Offset: 0x000D4670
		[Token(Token = "0x6029B63")]
		[Address(RVA = "0x25059F0", Offset = "0x25045F0", VA = "0x1825059F0", Slot = "12")]
		protected override ActivityType GetActType()
		{
			return ActivityType.DEFAULT;
		}

		// Token: 0x06029B64 RID: 170852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B64")]
		[Address(RVA = "0x2505CB0", Offset = "0x25048B0", VA = "0x182505CB0")]
		public Act42D0ChallengeRoutePolicy()
		{
		}

		// Token: 0x06029B65 RID: 170853 RVA: 0x000D6488 File Offset: 0x000D4688
		[Token(Token = "0x6029B65")]
		[Address(RVA = "0x2505B10", Offset = "0x2504710", VA = "0x182505B10")]
		private bool <>xLuaBaseProxy_UseActPolicy(RoutePolicy.Condition P0)
		{
			return default(bool);
		}

		// Token: 0x0403BB38 RID: 244536
		[Token(Token = "0x403BB38")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UseActPolicy;

		// Token: 0x0403BB39 RID: 244537
		[Token(Token = "0x403BB39")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetOverrideActivityIdFromDataBundle;

		// Token: 0x0403BB3A RID: 244538
		[Token(Token = "0x403BB3A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_pageName;

		// Token: 0x0403BB3B RID: 244539
		[Token(Token = "0x403BB3B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CreateParamFromDataBundle;

		// Token: 0x0403BB3C RID: 244540
		[Token(Token = "0x403BB3C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CreateParamFromStage;

		// Token: 0x0403BB3D RID: 244541
		[Token(Token = "0x403BB3D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetActType;

		// Token: 0x0403BB3E RID: 244542
		[Token(Token = "0x403BB3E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
