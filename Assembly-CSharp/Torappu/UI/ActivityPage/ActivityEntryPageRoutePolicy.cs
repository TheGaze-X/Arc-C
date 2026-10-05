using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Activity;
using Torappu.UI.Stage;
using XLua;

namespace Torappu.UI.ActivityPage
{
	// Token: 0x0200677E RID: 26494
	[Token(Token = "0x200677E")]
	public abstract class ActivityEntryPageRoutePolicy : ActivityPageRoutePolicy
	{
		// Token: 0x06026028 RID: 155688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026028")]
		[Address(RVA = "0x20EC740", Offset = "0x20EB340", VA = "0x1820EC740", Slot = "9")]
		protected sealed override List<ActivityPageRoutePolicy.ActivityPageRoutePath> GenerateRoutePathsFromStage(RoutePolicy.CommonStageRouteInput param)
		{
			return null;
		}

		// Token: 0x06026029 RID: 155689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026029")]
		[Address(RVA = "0x20EC640", Offset = "0x20EB240", VA = "0x1820EC640", Slot = "10")]
		protected sealed override List<ActivityPageRoutePolicy.ActivityPageRoutePath> GenerateRoutePathsFromDataBundle(RoutePolicy.BattleOutRouteInput param)
		{
			return null;
		}

		// Token: 0x0602602A RID: 155690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602602A")]
		[Address(RVA = "0x20ECC60", Offset = "0x20EB860", VA = "0x1820ECC60")]
		private List<ActivityPageRoutePolicy.ActivityPageRoutePath> _RouteToEntryHome(string actId)
		{
			return null;
		}

		// Token: 0x0602602B RID: 155691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602602B")]
		[Address(RVA = "0x20EC8F0", Offset = "0x20EB4F0", VA = "0x1820EC8F0")]
		private List<ActivityPageRoutePolicy.ActivityPageRoutePath> _RouteToEntryHomeBattleOut(string actId, RoutePolicy.BattleOutRouteInput param)
		{
			return null;
		}

		// Token: 0x0602602C RID: 155692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602602C")]
		[Address(RVA = "0x20EC850", Offset = "0x20EB450", VA = "0x1820EC850", Slot = "14")]
		protected virtual List<ActivityPageRoutePolicy.ActivityPageRoutePath> GenerateRoutePathsOverEntry(string actId, RoutePolicy.BattleOutRouteInput param)
		{
			return null;
		}

		// Token: 0x0602602D RID: 155693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602602D")]
		[Address(RVA = "0x20ECE30", Offset = "0x20EBA30", VA = "0x1820ECE30")]
		protected ActivityEntryPageRoutePolicy()
		{
		}

		// Token: 0x04035784 RID: 219012
		[Token(Token = "0x4035784")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GenerateRoutePathsFromStage;

		// Token: 0x04035785 RID: 219013
		[Token(Token = "0x4035785")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GenerateRoutePathsFromDataBundle;

		// Token: 0x04035786 RID: 219014
		[Token(Token = "0x4035786")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RouteToEntryHome;

		// Token: 0x04035787 RID: 219015
		[Token(Token = "0x4035787")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RouteToEntryHomeBattleOut;

		// Token: 0x04035788 RID: 219016
		[Token(Token = "0x4035788")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GenerateRoutePathsOverEntry;

		// Token: 0x04035789 RID: 219017
		[Token(Token = "0x4035789")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
