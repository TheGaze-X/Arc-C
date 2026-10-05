using System;
using Il2CppDummyDll;
using Torappu.UI.Stage;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D5A RID: 27994
	[Token(Token = "0x2006D5A")]
	public abstract class CustomActivityStageRoutePolicy<TParam> : ActivityStageRoutePolicy where TParam : ICustomPageParam
	{
		// Token: 0x06027E5F RID: 163423 RVA: 0x000CFD98 File Offset: 0x000CDF98
		[Token(Token = "0x6027E5F")]
		protected sealed override ActivityStageRoutePolicy.ActivityStageRoutePath GenerateRoutePathFromStage(ActivityStageRoutePolicy.ActRouteTarget input)
		{
			return default(ActivityStageRoutePolicy.ActivityStageRoutePath);
		}

		// Token: 0x06027E60 RID: 163424 RVA: 0x000CFDB0 File Offset: 0x000CDFB0
		[Token(Token = "0x6027E60")]
		protected sealed override ActivityStageRoutePolicy.ActivityStageRoutePath GenerateRoutePathFromDataBundle(RoutePolicy.BattleOutRouteInput input)
		{
			return default(ActivityStageRoutePolicy.ActivityStageRoutePath);
		}

		// Token: 0x17005E5C RID: 24156
		// (get) Token: 0x06027E61 RID: 163425
		[Token(Token = "0x17005E5C")]
		protected abstract string pageName { [Token(Token = "0x6027E61")] get; }

		// Token: 0x06027E62 RID: 163426
		[Token(Token = "0x6027E62")]
		protected abstract TParam CreateParamFromStage(ActivityStageRoutePolicy.ActRouteTarget input);

		// Token: 0x06027E63 RID: 163427
		[Token(Token = "0x6027E63")]
		protected abstract TParam CreateParamFromDataBundle(RoutePolicy.BattleOutRouteInput input);

		// Token: 0x06027E64 RID: 163428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027E64")]
		protected virtual void GetOverrideZoneIdAndStageIdFromDataBundle(RoutePolicy.BattleOutRouteInput input, out string zoneId, out string stageId)
		{
		}

		// Token: 0x06027E65 RID: 163429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027E65")]
		protected virtual void GetOverrideZoneIdAndStageIdFromStage(ActivityStageRoutePolicy.ActRouteTarget input, out string zoneId, out string stageId)
		{
		}

		// Token: 0x06027E66 RID: 163430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027E66")]
		protected virtual void GetOverrideActivityIdFromDataBundle(RoutePolicy.BattleOutRouteInput input, out string actId)
		{
		}

		// Token: 0x06027E67 RID: 163431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027E67")]
		protected virtual void GetOverrideStageActMetaFromDataBundle(RoutePolicy.BattleOutRouteInput input, out string stageActInitMeta)
		{
		}

		// Token: 0x06027E68 RID: 163432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027E68")]
		protected CustomActivityStageRoutePolicy()
		{
		}

		// Token: 0x040388D6 RID: 231638
		[Token(Token = "0x40388D6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GenerateRoutePathFromStage;

		// Token: 0x040388D7 RID: 231639
		[Token(Token = "0x40388D7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GenerateRoutePathFromDataBundle;

		// Token: 0x040388D8 RID: 231640
		[Token(Token = "0x40388D8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetOverrideZoneIdAndStageIdFromDataBundle;

		// Token: 0x040388D9 RID: 231641
		[Token(Token = "0x40388D9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetOverrideZoneIdAndStageIdFromStage;

		// Token: 0x040388DA RID: 231642
		[Token(Token = "0x40388DA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetOverrideActivityIdFromDataBundle;

		// Token: 0x040388DB RID: 231643
		[Token(Token = "0x40388DB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetOverrideStageActMetaFromDataBundle;

		// Token: 0x040388DC RID: 231644
		[Token(Token = "0x40388DC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
