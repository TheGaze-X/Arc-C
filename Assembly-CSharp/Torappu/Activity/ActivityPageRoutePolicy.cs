using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.Stage;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D50 RID: 27984
	[Token(Token = "0x2006D50")]
	public abstract class ActivityPageRoutePolicy : RoutePolicy
	{
		// Token: 0x06027E2C RID: 163372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027E2C")]
		[Address(RVA = "0x22F1D20", Offset = "0x22F0920", VA = "0x1822F1D20")]
		public static string GetPolicyTypeStr(ActivityType activityType)
		{
			return null;
		}

		// Token: 0x06027E2D RID: 163373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027E2D")]
		[Address(RVA = "0x22F1DB0", Offset = "0x22F09B0", VA = "0x1822F1DB0", Slot = "4")]
		protected sealed override string GetPolicyType()
		{
			return null;
		}

		// Token: 0x06027E2E RID: 163374 RVA: 0x000CFC78 File Offset: 0x000CDE78
		[Token(Token = "0x6027E2E")]
		[Address(RVA = "0x22F2110", Offset = "0x22F0D10", VA = "0x1822F2110", Slot = "5")]
		protected sealed override bool UsePolicy(RoutePolicy.Condition condition)
		{
			return default(bool);
		}

		// Token: 0x06027E2F RID: 163375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027E2F")]
		[Address(RVA = "0x22F1FC0", Offset = "0x22F0BC0", VA = "0x1822F1FC0", Slot = "6")]
		public sealed override List<UIPageStackParam.StackElement> GetStageRouteStack(RoutePolicy.CommonStageRouteInput routeInput)
		{
			return null;
		}

		// Token: 0x06027E30 RID: 163376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027E30")]
		[Address(RVA = "0x22F1EE0", Offset = "0x22F0AE0", VA = "0x1822F1EE0", Slot = "7")]
		public sealed override List<UIPageStackParam.StackElement> GetStageRouteStack(RoutePolicy.BattleOutRouteInput routeInput)
		{
			return null;
		}

		// Token: 0x06027E31 RID: 163377 RVA: 0x000CFC90 File Offset: 0x000CDE90
		[Token(Token = "0x6027E31")]
		[Address(RVA = "0x22F1BE0", Offset = "0x22F07E0", VA = "0x1822F1BE0", Slot = "8")]
		public override UIPageStackParam.StackElement GetEntryPageParam(RoutePolicy.CommonEntryRouteInput routeInput)
		{
			return default(UIPageStackParam.StackElement);
		}

		// Token: 0x06027E32 RID: 163378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027E32")]
		[Address(RVA = "0x22F21D0", Offset = "0x22F0DD0", VA = "0x1822F21D0")]
		private List<UIPageStackParam.StackElement> _GeneratePageStackByRoutePath(List<ActivityPageRoutePolicy.ActivityPageRoutePath> paths)
		{
			return null;
		}

		// Token: 0x06027E33 RID: 163379
		[Token(Token = "0x6027E33")]
		protected abstract List<ActivityPageRoutePolicy.ActivityPageRoutePath> GenerateRoutePathsFromStage(RoutePolicy.CommonStageRouteInput param);

		// Token: 0x06027E34 RID: 163380
		[Token(Token = "0x6027E34")]
		protected abstract List<ActivityPageRoutePolicy.ActivityPageRoutePath> GenerateRoutePathsFromDataBundle(RoutePolicy.BattleOutRouteInput param);

		// Token: 0x06027E35 RID: 163381
		[Token(Token = "0x6027E35")]
		protected abstract ActivityPageRoutePolicy.ActivityPageRoutePath GenerateEntryPageRoutePath(RoutePolicy.CommonEntryRouteInput param);

		// Token: 0x06027E36 RID: 163382 RVA: 0x000CFCA8 File Offset: 0x000CDEA8
		[Token(Token = "0x6027E36")]
		[Address(RVA = "0x22F2090", Offset = "0x22F0C90", VA = "0x1822F2090", Slot = "12")]
		protected virtual bool UseActPolicy(RoutePolicy.Condition condition)
		{
			return default(bool);
		}

		// Token: 0x06027E37 RID: 163383
		[Token(Token = "0x6027E37")]
		protected abstract ActivityType GetActType();

		// Token: 0x06027E38 RID: 163384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027E38")]
		[Address(RVA = "0x22F2560", Offset = "0x22F1160", VA = "0x1822F2560")]
		protected ActivityPageRoutePolicy()
		{
		}

		// Token: 0x04038894 RID: 231572
		[Token(Token = "0x4038894")]
		public const string KEY_BUNDLE_PARAM_ACT_ID = "key_actId";

		// Token: 0x04038895 RID: 231573
		[Token(Token = "0x4038895")]
		public const string KEY_BUNDLE_FROM_BATTLE = "key_from_battle";

		// Token: 0x04038896 RID: 231574
		[Token(Token = "0x4038896")]
		public const string ENTRY_PAGE = "entry_page";

		// Token: 0x04038897 RID: 231575
		[Token(Token = "0x4038897")]
		[FieldOffset(Offset = "0x10")]
		private string m_policyType;

		// Token: 0x04038898 RID: 231576
		[Token(Token = "0x4038898")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetPolicyTypeStr;

		// Token: 0x04038899 RID: 231577
		[Token(Token = "0x4038899")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetPolicyType;

		// Token: 0x0403889A RID: 231578
		[Token(Token = "0x403889A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UsePolicy;

		// Token: 0x0403889B RID: 231579
		[Token(Token = "0x403889B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetStageRouteStack;

		// Token: 0x0403889C RID: 231580
		[Token(Token = "0x403889C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix1_GetStageRouteStack;

		// Token: 0x0403889D RID: 231581
		[Token(Token = "0x403889D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetEntryPageParam;

		// Token: 0x0403889E RID: 231582
		[Token(Token = "0x403889E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GeneratePageStackByRoutePath;

		// Token: 0x0403889F RID: 231583
		[Token(Token = "0x403889F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_UseActPolicy;

		// Token: 0x040388A0 RID: 231584
		[Token(Token = "0x40388A0")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006D51 RID: 27985
		[Token(Token = "0x2006D51")]
		public struct ActivityPageRoutePath : IHotfixable
		{
			// Token: 0x06027E39 RID: 163385 RVA: 0x000CFCC0 File Offset: 0x000CDEC0
			[Token(Token = "0x6027E39")]
			[Address(RVA = "0x22F1B70", Offset = "0x22F0770", VA = "0x1822F1B70")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x040388A1 RID: 231585
			[Token(Token = "0x40388A1")]
			[FieldOffset(Offset = "0x0")]
			public string pageName;

			// Token: 0x040388A2 RID: 231586
			[Token(Token = "0x40388A2")]
			[FieldOffset(Offset = "0x8")]
			public object param;

			// Token: 0x040388A3 RID: 231587
			[Token(Token = "0x40388A3")]
			[FieldOffset(Offset = "0x10")]
			public DataBundle savedInst;

			// Token: 0x040388A4 RID: 231588
			[Token(Token = "0x40388A4")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_IsEmpty;
		}
	}
}
