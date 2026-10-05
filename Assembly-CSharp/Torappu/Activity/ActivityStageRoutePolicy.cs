using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.Stage;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D56 RID: 27990
	[Token(Token = "0x2006D56")]
	public abstract class ActivityStageRoutePolicy : RoutePolicy
	{
		// Token: 0x06027E4F RID: 163407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027E4F")]
		[Address(RVA = "0x233DB30", Offset = "0x233C730", VA = "0x18233DB30")]
		public static string GetPolicyTypeStr(ActivityType activityType)
		{
			return null;
		}

		// Token: 0x06027E50 RID: 163408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027E50")]
		[Address(RVA = "0x233DBE0", Offset = "0x233C7E0", VA = "0x18233DBE0", Slot = "4")]
		protected sealed override string GetPolicyType()
		{
			return null;
		}

		// Token: 0x06027E51 RID: 163409 RVA: 0x000CFD08 File Offset: 0x000CDF08
		[Token(Token = "0x6027E51")]
		[Address(RVA = "0x233E090", Offset = "0x233CC90", VA = "0x18233E090", Slot = "5")]
		protected sealed override bool UsePolicy(RoutePolicy.Condition condition)
		{
			return default(bool);
		}

		// Token: 0x06027E52 RID: 163410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027E52")]
		[Address(RVA = "0x233DE60", Offset = "0x233CA60", VA = "0x18233DE60", Slot = "6")]
		public sealed override List<UIPageStackParam.StackElement> GetStageRouteStack(RoutePolicy.CommonStageRouteInput routeInput)
		{
			return null;
		}

		// Token: 0x06027E53 RID: 163411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027E53")]
		[Address(RVA = "0x233DD30", Offset = "0x233C930", VA = "0x18233DD30", Slot = "7")]
		public sealed override List<UIPageStackParam.StackElement> GetStageRouteStack(RoutePolicy.BattleOutRouteInput routeInput)
		{
			return null;
		}

		// Token: 0x06027E54 RID: 163412 RVA: 0x000CFD20 File Offset: 0x000CDF20
		[Token(Token = "0x6027E54")]
		[Address(RVA = "0x233D8A0", Offset = "0x233C4A0", VA = "0x18233D8A0", Slot = "8")]
		public override UIPageStackParam.StackElement GetEntryPageParam(RoutePolicy.CommonEntryRouteInput param)
		{
			return default(UIPageStackParam.StackElement);
		}

		// Token: 0x06027E55 RID: 163413
		[Token(Token = "0x6027E55")]
		protected abstract ActivityStageRoutePolicy.ActivityStageRoutePath GenerateRoutePathFromStage(ActivityStageRoutePolicy.ActRouteTarget param);

		// Token: 0x06027E56 RID: 163414
		[Token(Token = "0x6027E56")]
		protected abstract ActivityStageRoutePolicy.ActivityStageRoutePath GenerateRoutePathFromDataBundle(RoutePolicy.BattleOutRouteInput param);

		// Token: 0x06027E57 RID: 163415 RVA: 0x000CFD38 File Offset: 0x000CDF38
		[Token(Token = "0x6027E57")]
		[Address(RVA = "0x233E010", Offset = "0x233CC10", VA = "0x18233E010", Slot = "11")]
		protected virtual bool UseActPolicy(RoutePolicy.Condition condition)
		{
			return default(bool);
		}

		// Token: 0x06027E58 RID: 163416
		[Token(Token = "0x6027E58")]
		protected abstract ActivityType GetActType();

		// Token: 0x06027E59 RID: 163417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027E59")]
		[Address(RVA = "0x233D960", Offset = "0x233C560", VA = "0x18233D960")]
		protected string GetGroupIdForAct(string zoneId, bool isRetro)
		{
			return null;
		}

		// Token: 0x06027E5A RID: 163418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027E5A")]
		[Address(RVA = "0x233E150", Offset = "0x233CD50", VA = "0x18233E150")]
		private List<UIPageStackParam.StackElement> _GeneratePageStackByRoutePath(DataBundle stageBundle, ActivityStageRoutePolicy.ActivityStageRoutePath path)
		{
			return null;
		}

		// Token: 0x06027E5B RID: 163419 RVA: 0x000CFD50 File Offset: 0x000CDF50
		[Token(Token = "0x6027E5B")]
		[Address(RVA = "0x233E580", Offset = "0x233D180", VA = "0x18233E580")]
		private ActivityStageRoutePolicy.ActRouteTarget _GetActStageRouteTarget(RoutePolicy.CommonStageRouteInput routeInput)
		{
			return default(ActivityStageRoutePolicy.ActRouteTarget);
		}

		// Token: 0x06027E5C RID: 163420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027E5C")]
		[Address(RVA = "0x233E830", Offset = "0x233D430", VA = "0x18233E830")]
		protected ActivityStageRoutePolicy()
		{
		}

		// Token: 0x040388BF RID: 231615
		[Token(Token = "0x40388BF")]
		[FieldOffset(Offset = "0x10")]
		private string m_policyType;

		// Token: 0x040388C0 RID: 231616
		[Token(Token = "0x40388C0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetPolicyTypeStr;

		// Token: 0x040388C1 RID: 231617
		[Token(Token = "0x40388C1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetPolicyType;

		// Token: 0x040388C2 RID: 231618
		[Token(Token = "0x40388C2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UsePolicy;

		// Token: 0x040388C3 RID: 231619
		[Token(Token = "0x40388C3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetStageRouteStack;

		// Token: 0x040388C4 RID: 231620
		[Token(Token = "0x40388C4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix1_GetStageRouteStack;

		// Token: 0x040388C5 RID: 231621
		[Token(Token = "0x40388C5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetEntryPageParam;

		// Token: 0x040388C6 RID: 231622
		[Token(Token = "0x40388C6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_UseActPolicy;

		// Token: 0x040388C7 RID: 231623
		[Token(Token = "0x40388C7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetGroupIdForAct;

		// Token: 0x040388C8 RID: 231624
		[Token(Token = "0x40388C8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GeneratePageStackByRoutePath;

		// Token: 0x040388C9 RID: 231625
		[Token(Token = "0x40388C9")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__GetActStageRouteTarget;

		// Token: 0x040388CA RID: 231626
		[Token(Token = "0x40388CA")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006D57 RID: 27991
		[Token(Token = "0x2006D57")]
		protected struct ActRouteTarget : IHotfixable
		{
			// Token: 0x06027E5D RID: 163421 RVA: 0x000CFD68 File Offset: 0x000CDF68
			[Token(Token = "0x6027E5D")]
			[Address(RVA = "0x23336E0", Offset = "0x23322E0", VA = "0x1823336E0")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x040388CB RID: 231627
			[Token(Token = "0x40388CB")]
			[FieldOffset(Offset = "0x0")]
			public string zoneId;

			// Token: 0x040388CC RID: 231628
			[Token(Token = "0x40388CC")]
			[FieldOffset(Offset = "0x8")]
			public string stageId;

			// Token: 0x040388CD RID: 231629
			[Token(Token = "0x40388CD")]
			[FieldOffset(Offset = "0x10")]
			public bool isRetro;

			// Token: 0x040388CE RID: 231630
			[Token(Token = "0x40388CE")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_IsEmpty;
		}

		// Token: 0x02006D58 RID: 27992
		[Token(Token = "0x2006D58")]
		protected struct ActivityStageRoutePath : IHotfixable
		{
			// Token: 0x06027E5E RID: 163422 RVA: 0x000CFD80 File Offset: 0x000CDF80
			[Token(Token = "0x6027E5E")]
			[Address(RVA = "0x233D7D0", Offset = "0x233C3D0", VA = "0x18233D7D0")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x040388CF RID: 231631
			[Token(Token = "0x40388CF")]
			[FieldOffset(Offset = "0x0")]
			public string pageName;

			// Token: 0x040388D0 RID: 231632
			[Token(Token = "0x40388D0")]
			[FieldOffset(Offset = "0x8")]
			public object param;

			// Token: 0x040388D1 RID: 231633
			[Token(Token = "0x40388D1")]
			[FieldOffset(Offset = "0x10")]
			public string overrideZoneId;

			// Token: 0x040388D2 RID: 231634
			[Token(Token = "0x40388D2")]
			[FieldOffset(Offset = "0x18")]
			public string overrideStageId;

			// Token: 0x040388D3 RID: 231635
			[Token(Token = "0x40388D3")]
			[FieldOffset(Offset = "0x20")]
			public string overrideActId;

			// Token: 0x040388D4 RID: 231636
			[Token(Token = "0x40388D4")]
			[FieldOffset(Offset = "0x28")]
			public string overrideStageActMeta;

			// Token: 0x040388D5 RID: 231637
			[Token(Token = "0x40388D5")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_IsEmpty;
		}
	}
}
