using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006872 RID: 26738
	[Token(Token = "0x2006872")]
	public abstract class RoutePolicy : IHotfixable
	{
		// Token: 0x060264BE RID: 156862
		[Token(Token = "0x60264BE")]
		protected abstract string GetPolicyType();

		// Token: 0x060264BF RID: 156863
		[Token(Token = "0x60264BF")]
		protected abstract bool UsePolicy(RoutePolicy.Condition condition);

		// Token: 0x060264C0 RID: 156864
		[Token(Token = "0x60264C0")]
		public abstract List<UIPageStackParam.StackElement> GetStageRouteStack(RoutePolicy.CommonStageRouteInput param);

		// Token: 0x060264C1 RID: 156865
		[Token(Token = "0x60264C1")]
		public abstract List<UIPageStackParam.StackElement> GetStageRouteStack(RoutePolicy.BattleOutRouteInput param);

		// Token: 0x060264C2 RID: 156866
		[Token(Token = "0x60264C2")]
		public abstract UIPageStackParam.StackElement GetEntryPageParam(RoutePolicy.CommonEntryRouteInput param);

		// Token: 0x060264C3 RID: 156867 RVA: 0x000CA998 File Offset: 0x000C8B98
		[Token(Token = "0x60264C3")]
		[Address(RVA = "0x21617D0", Offset = "0x21603D0", VA = "0x1821617D0")]
		private static ActivityType _GetActivityType(string zoneId, string stageId)
		{
			return ActivityType.DEFAULT;
		}

		// Token: 0x060264C4 RID: 156868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60264C4")]
		[Address(RVA = "0x21618E0", Offset = "0x21604E0", VA = "0x1821618E0")]
		protected RoutePolicy()
		{
		}

		// Token: 0x04035F2E RID: 220974
		[Token(Token = "0x4035F2E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__GetActivityType;

		// Token: 0x04035F2F RID: 220975
		[Token(Token = "0x4035F2F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006873 RID: 26739
		[Token(Token = "0x2006873")]
		public struct Condition : IHotfixable
		{
			// Token: 0x060264C5 RID: 156869 RVA: 0x000CA9B0 File Offset: 0x000C8BB0
			[Token(Token = "0x60264C5")]
			[Address(RVA = "0x215F8D0", Offset = "0x215E4D0", VA = "0x18215F8D0")]
			public StageDataUtil.StageDataWrapper GetDataWrapper()
			{
				return default(StageDataUtil.StageDataWrapper);
			}

			// Token: 0x060264C6 RID: 156870 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60264C6")]
			[Address(RVA = "0x215FA20", Offset = "0x215E620", VA = "0x18215FA20")]
			public string GetPolicyType()
			{
				return null;
			}

			// Token: 0x060264C7 RID: 156871 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60264C7")]
			[Address(RVA = "0x215FAF0", Offset = "0x215E6F0", VA = "0x18215FAF0")]
			private string _GetPolicyTypeFromActId()
			{
				return null;
			}

			// Token: 0x060264C8 RID: 156872 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60264C8")]
			[Address(RVA = "0x215FC10", Offset = "0x215E810", VA = "0x18215FC10")]
			private string _GetPolicyTypeFromStage()
			{
				return null;
			}

			// Token: 0x04035F30 RID: 220976
			[Token(Token = "0x4035F30")]
			[FieldOffset(Offset = "0x0")]
			public string stageId;

			// Token: 0x04035F31 RID: 220977
			[Token(Token = "0x4035F31")]
			[FieldOffset(Offset = "0x8")]
			public string actId;

			// Token: 0x04035F32 RID: 220978
			[Token(Token = "0x4035F32")]
			[FieldOffset(Offset = "0x10")]
			public DataBundle stagePageSavedInst;

			// Token: 0x04035F33 RID: 220979
			[Token(Token = "0x4035F33")]
			[FieldOffset(Offset = "0x0")]
			public static readonly RoutePolicy.Condition EMPTY;

			// Token: 0x04035F34 RID: 220980
			[Token(Token = "0x4035F34")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetDataWrapper;

			// Token: 0x04035F35 RID: 220981
			[Token(Token = "0x4035F35")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetPolicyType;

			// Token: 0x04035F36 RID: 220982
			[Token(Token = "0x4035F36")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0__GetPolicyTypeFromActId;

			// Token: 0x04035F37 RID: 220983
			[Token(Token = "0x4035F37")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0__GetPolicyTypeFromStage;
		}

		// Token: 0x02006874 RID: 26740
		[Token(Token = "0x2006874")]
		public struct CommonStageRouteInput
		{
			// Token: 0x04035F38 RID: 220984
			[Token(Token = "0x4035F38")]
			[FieldOffset(Offset = "0x0")]
			public string stageId;

			// Token: 0x04035F39 RID: 220985
			[Token(Token = "0x4035F39")]
			[FieldOffset(Offset = "0x8")]
			public DataBundle stageSavedInst;

			// Token: 0x04035F3A RID: 220986
			[Token(Token = "0x4035F3A")]
			[FieldOffset(Offset = "0x10")]
			public string activityId;
		}

		// Token: 0x02006875 RID: 26741
		[Token(Token = "0x2006875")]
		public struct BattleOutRouteInput
		{
			// Token: 0x04035F3B RID: 220987
			[Token(Token = "0x4035F3B")]
			[FieldOffset(Offset = "0x0")]
			public DataBundle bundleToJumpBack;

			// Token: 0x04035F3C RID: 220988
			[Token(Token = "0x4035F3C")]
			[FieldOffset(Offset = "0x8")]
			public DataBundle stageBundle;

			// Token: 0x04035F3D RID: 220989
			[Token(Token = "0x4035F3D")]
			[FieldOffset(Offset = "0x10")]
			public string zoneId;

			// Token: 0x04035F3E RID: 220990
			[Token(Token = "0x4035F3E")]
			[FieldOffset(Offset = "0x18")]
			public bool isAutoBattle;

			// Token: 0x04035F3F RID: 220991
			[Token(Token = "0x4035F3F")]
			[FieldOffset(Offset = "0x20")]
			public string stageId;

			// Token: 0x04035F40 RID: 220992
			[Token(Token = "0x4035F40")]
			[FieldOffset(Offset = "0x28")]
			public string actId;
		}

		// Token: 0x02006876 RID: 26742
		[Token(Token = "0x2006876")]
		public struct CommonEntryRouteInput
		{
			// Token: 0x04035F41 RID: 220993
			[Token(Token = "0x4035F41")]
			[FieldOffset(Offset = "0x0")]
			public string activityId;
		}

		// Token: 0x02006877 RID: 26743
		[Token(Token = "0x2006877")]
		[Hotfix(HotfixFlag.Stateless)]
		public static class RoutePolicyInterface
		{
			// Token: 0x060264CA RID: 156874 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60264CA")]
			private static Type _GetTypeOfPolicy<TPolicy>() where TPolicy : RoutePolicy
			{
				return null;
			}

			// Token: 0x060264CB RID: 156875 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60264CB")]
			[Address(RVA = "0x2160EB0", Offset = "0x215FAB0", VA = "0x182160EB0")]
			private static Dictionary<string, List<RoutePolicy>> _EnsurePolicies()
			{
				return null;
			}

			// Token: 0x060264CC RID: 156876 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60264CC")]
			[Address(RVA = "0x2160CB0", Offset = "0x215F8B0", VA = "0x182160CB0")]
			public static RoutePolicy FindPolicy(RoutePolicy.Condition cond)
			{
				return null;
			}

			// Token: 0x04035F42 RID: 220994
			[Token(Token = "0x4035F42")]
			[FieldOffset(Offset = "0x0")]
			private static readonly Type[] s_policies;

			// Token: 0x04035F43 RID: 220995
			[Token(Token = "0x4035F43")]
			[FieldOffset(Offset = "0x8")]
			private static Dictionary<string, List<RoutePolicy>> s_policyDict;

			// Token: 0x04035F44 RID: 220996
			[Token(Token = "0x4035F44")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0__GetTypeOfPolicy;

			// Token: 0x04035F45 RID: 220997
			[Token(Token = "0x4035F45")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__EnsurePolicies;

			// Token: 0x04035F46 RID: 220998
			[Token(Token = "0x4035F46")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_FindPolicy;
		}
	}
}
