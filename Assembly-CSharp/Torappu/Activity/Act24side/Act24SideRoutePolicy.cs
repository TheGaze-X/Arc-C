using System;
using Il2CppDummyDll;
using Torappu.UI.Stage;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x020075FF RID: 30207
	[Token(Token = "0x20075FF")]
	public class Act24SideRoutePolicy : CustomActivityStageRoutePolicy<Act24sideQuestPage.Param>
	{
		// Token: 0x0602A871 RID: 174193 RVA: 0x000D8D20 File Offset: 0x000D6F20
		[Token(Token = "0x602A871")]
		[Address(RVA = "0x261F670", Offset = "0x261E270", VA = "0x18261F670", Slot = "12")]
		protected override ActivityType GetActType()
		{
			return ActivityType.DEFAULT;
		}

		// Token: 0x17006401 RID: 25601
		// (get) Token: 0x0602A872 RID: 174194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006401")]
		protected override string pageName
		{
			[Token(Token = "0x602A872")]
			[Address(RVA = "0x261FAB0", Offset = "0x261E6B0", VA = "0x18261FAB0", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602A873 RID: 174195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A873")]
		[Address(RVA = "0x261F480", Offset = "0x261E080", VA = "0x18261F480", Slot = "14")]
		protected override Act24sideQuestPage.Param CreateParamFromStage(ActivityStageRoutePolicy.ActRouteTarget input)
		{
			return null;
		}

		// Token: 0x0602A874 RID: 174196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A874")]
		[Address(RVA = "0x261F3B0", Offset = "0x261DFB0", VA = "0x18261F3B0", Slot = "15")]
		protected override Act24sideQuestPage.Param CreateParamFromDataBundle(RoutePolicy.BattleOutRouteInput input)
		{
			return null;
		}

		// Token: 0x0602A875 RID: 174197 RVA: 0x000D8D38 File Offset: 0x000D6F38
		[Token(Token = "0x602A875")]
		[Address(RVA = "0x261F6D0", Offset = "0x261E2D0", VA = "0x18261F6D0", Slot = "11")]
		protected override bool UseActPolicy(RoutePolicy.Condition condition)
		{
			return default(bool);
		}

		// Token: 0x0602A876 RID: 174198 RVA: 0x000D8D50 File Offset: 0x000D6F50
		[Token(Token = "0x602A876")]
		[Address(RVA = "0x261F7F0", Offset = "0x261E3F0", VA = "0x18261F7F0")]
		private bool _CheckIfAct24sideQuestStage(string zoneId, string stageId)
		{
			return default(bool);
		}

		// Token: 0x0602A877 RID: 174199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A877")]
		[Address(RVA = "0x261FA40", Offset = "0x261E640", VA = "0x18261FA40")]
		public Act24SideRoutePolicy()
		{
		}

		// Token: 0x0602A878 RID: 174200 RVA: 0x000D8D68 File Offset: 0x000D6F68
		[Token(Token = "0x602A878")]
		[Address(RVA = "0x2505B10", Offset = "0x2504710", VA = "0x182505B10")]
		private bool <>xLuaBaseProxy_UseActPolicy(RoutePolicy.Condition P0)
		{
			return default(bool);
		}

		// Token: 0x0403D384 RID: 250756
		[Token(Token = "0x403D384")]
		[FieldOffset(Offset = "0x18")]
		private string m_actId;

		// Token: 0x0403D385 RID: 250757
		[Token(Token = "0x403D385")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetActType;

		// Token: 0x0403D386 RID: 250758
		[Token(Token = "0x403D386")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_pageName;

		// Token: 0x0403D387 RID: 250759
		[Token(Token = "0x403D387")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CreateParamFromStage;

		// Token: 0x0403D388 RID: 250760
		[Token(Token = "0x403D388")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CreateParamFromDataBundle;

		// Token: 0x0403D389 RID: 250761
		[Token(Token = "0x403D389")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UseActPolicy;

		// Token: 0x0403D38A RID: 250762
		[Token(Token = "0x403D38A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CheckIfAct24sideQuestStage;

		// Token: 0x0403D38B RID: 250763
		[Token(Token = "0x403D38B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
