using System;
using Il2CppDummyDll;
using Torappu.Activity;
using Torappu.UI.Stage;
using XLua;

namespace Torappu.UI.DeepSeaRP
{
	// Token: 0x02005129 RID: 20777
	[Token(Token = "0x2005129")]
	public class DeepSeaRoutePolicy : CustomActivityStageRoutePolicy<DeepSeaRolePlayPage.Params>
	{
		// Token: 0x0601EAF8 RID: 125688 RVA: 0x000AF3B0 File Offset: 0x000AD5B0
		[Token(Token = "0x601EAF8")]
		[Address(RVA = "0x1860600", Offset = "0x185F200", VA = "0x181860600", Slot = "12")]
		protected override ActivityType GetActType()
		{
			return ActivityType.DEFAULT;
		}

		// Token: 0x17004782 RID: 18306
		// (get) Token: 0x0601EAF9 RID: 125689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004782")]
		protected override string pageName
		{
			[Token(Token = "0x601EAF9")]
			[Address(RVA = "0x18606D0", Offset = "0x185F2D0", VA = "0x1818606D0", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601EAFA RID: 125690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EAFA")]
		[Address(RVA = "0x1860420", Offset = "0x185F020", VA = "0x181860420", Slot = "14")]
		protected override DeepSeaRolePlayPage.Params CreateParamFromStage(ActivityStageRoutePolicy.ActRouteTarget input)
		{
			return null;
		}

		// Token: 0x0601EAFB RID: 125691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EAFB")]
		[Address(RVA = "0x1860360", Offset = "0x185EF60", VA = "0x181860360", Slot = "15")]
		protected override DeepSeaRolePlayPage.Params CreateParamFromDataBundle(RoutePolicy.BattleOutRouteInput param)
		{
			return null;
		}

		// Token: 0x0601EAFC RID: 125692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EAFC")]
		[Address(RVA = "0x1860660", Offset = "0x185F260", VA = "0x181860660")]
		public DeepSeaRoutePolicy()
		{
		}

		// Token: 0x0402924D RID: 168525
		[Token(Token = "0x402924D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetActType;

		// Token: 0x0402924E RID: 168526
		[Token(Token = "0x402924E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_pageName;

		// Token: 0x0402924F RID: 168527
		[Token(Token = "0x402924F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CreateParamFromStage;

		// Token: 0x04029250 RID: 168528
		[Token(Token = "0x4029250")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CreateParamFromDataBundle;

		// Token: 0x04029251 RID: 168529
		[Token(Token = "0x4029251")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
