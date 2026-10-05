using System;
using Il2CppDummyDll;
using Torappu.UI.Stage;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x0200733D RID: 29501
	[Token(Token = "0x200733D")]
	public class Act42D0NormalRoutePolicy : CustomActivityStageRoutePolicy<Act42D0MapPage.Param>
	{
		// Token: 0x17006284 RID: 25220
		// (get) Token: 0x06029BA5 RID: 170917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006284")]
		protected override string pageName
		{
			[Token(Token = "0x6029BA5")]
			[Address(RVA = "0x2561C50", Offset = "0x2560850", VA = "0x182561C50", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x06029BA6 RID: 170918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029BA6")]
		[Address(RVA = "0x25617A0", Offset = "0x25603A0", VA = "0x1825617A0", Slot = "15")]
		protected override Act42D0MapPage.Param CreateParamFromDataBundle(RoutePolicy.BattleOutRouteInput input)
		{
			return null;
		}

		// Token: 0x06029BA7 RID: 170919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029BA7")]
		[Address(RVA = "0x25619B0", Offset = "0x25605B0", VA = "0x1825619B0", Slot = "18")]
		protected override void GetOverrideActivityIdFromDataBundle(RoutePolicy.BattleOutRouteInput input, out string actId)
		{
		}

		// Token: 0x06029BA8 RID: 170920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029BA8")]
		[Address(RVA = "0x2561860", Offset = "0x2560460", VA = "0x182561860", Slot = "14")]
		protected override Act42D0MapPage.Param CreateParamFromStage(ActivityStageRoutePolicy.ActRouteTarget input)
		{
			return null;
		}

		// Token: 0x06029BA9 RID: 170921 RVA: 0x000D64E8 File Offset: 0x000D46E8
		[Token(Token = "0x6029BA9")]
		[Address(RVA = "0x2561950", Offset = "0x2560550", VA = "0x182561950", Slot = "12")]
		protected override ActivityType GetActType()
		{
			return ActivityType.DEFAULT;
		}

		// Token: 0x06029BAA RID: 170922 RVA: 0x000D6500 File Offset: 0x000D4700
		[Token(Token = "0x6029BAA")]
		[Address(RVA = "0x2561A70", Offset = "0x2560670", VA = "0x182561A70", Slot = "11")]
		protected override bool UseActPolicy(RoutePolicy.Condition condition)
		{
			return default(bool);
		}

		// Token: 0x06029BAB RID: 170923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029BAB")]
		[Address(RVA = "0x2561BE0", Offset = "0x25607E0", VA = "0x182561BE0")]
		public Act42D0NormalRoutePolicy()
		{
		}

		// Token: 0x06029BAC RID: 170924 RVA: 0x000D6518 File Offset: 0x000D4718
		[Token(Token = "0x6029BAC")]
		[Address(RVA = "0x2505B10", Offset = "0x2504710", VA = "0x182505B10")]
		private bool <>xLuaBaseProxy_UseActPolicy(RoutePolicy.Condition P0)
		{
			return default(bool);
		}

		// Token: 0x0403BBA4 RID: 244644
		[Token(Token = "0x403BBA4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_pageName;

		// Token: 0x0403BBA5 RID: 244645
		[Token(Token = "0x403BBA5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CreateParamFromDataBundle;

		// Token: 0x0403BBA6 RID: 244646
		[Token(Token = "0x403BBA6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetOverrideActivityIdFromDataBundle;

		// Token: 0x0403BBA7 RID: 244647
		[Token(Token = "0x403BBA7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CreateParamFromStage;

		// Token: 0x0403BBA8 RID: 244648
		[Token(Token = "0x403BBA8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetActType;

		// Token: 0x0403BBA9 RID: 244649
		[Token(Token = "0x403BBA9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_UseActPolicy;

		// Token: 0x0403BBAA RID: 244650
		[Token(Token = "0x403BBAA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
