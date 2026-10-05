using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002379 RID: 9081
	[Token(Token = "0x2002379")]
	public class TracePositionCursor : DirectionCursor
	{
		// Token: 0x0600E651 RID: 58961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E651")]
		[Address(RVA = "0x5CBF50", Offset = "0x5CAB50", VA = "0x1805CBF50")]
		public TracePositionCursor(Route route, Scheduler.SchedulerSnapshot snapshot, Vector2 offset, BObject obj, bool ignoreAllButMoveCp = false, bool visitEveryTileCenter = false, bool visitEveryNodeCenter = false)
		{
		}

		// Token: 0x17001CF0 RID: 7408
		// (get) Token: 0x0600E652 RID: 58962 RVA: 0x00053BF8 File Offset: 0x00051DF8
		[Token(Token = "0x17001CF0")]
		public bool isMarkReached
		{
			[Token(Token = "0x600E652")]
			[Address(RVA = "0x5CC380", Offset = "0x5CAF80", VA = "0x1805CC380")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001CF1 RID: 7409
		// (get) Token: 0x0600E653 RID: 58963 RVA: 0x00053C10 File Offset: 0x00051E10
		[Token(Token = "0x17001CF1")]
		public bool isCurrentValid
		{
			[Token(Token = "0x600E653")]
			[Address(RVA = "0x5CC190", Offset = "0x5CAD90", VA = "0x1805CC190")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600E654 RID: 58964 RVA: 0x00053C28 File Offset: 0x00051E28
		[Token(Token = "0x600E654")]
		[Address(RVA = "0x5CB8F0", Offset = "0x5CA4F0", VA = "0x1805CB8F0", Slot = "10")]
		public override bool PredictReached(float stepDistance, out Vector2 direction, out Vector2 nextPos)
		{
			return default(bool);
		}

		// Token: 0x0600E655 RID: 58965 RVA: 0x00053C40 File Offset: 0x00051E40
		[Token(Token = "0x600E655")]
		[Address(RVA = "0x5CB690", Offset = "0x5CA290", VA = "0x1805CB690", Slot = "12")]
		public override Vector2 GetNextDirection()
		{
			return default(Vector2);
		}

		// Token: 0x0600E656 RID: 58966 RVA: 0x00053C58 File Offset: 0x00051E58
		[Token(Token = "0x600E656")]
		[Address(RVA = "0x5CB4D0", Offset = "0x5CA0D0", VA = "0x1805CB4D0", Slot = "9")]
		public override bool CheckReached()
		{
			return default(bool);
		}

		// Token: 0x0600E657 RID: 58967 RVA: 0x00053C70 File Offset: 0x00051E70
		[Token(Token = "0x600E657")]
		[Address(RVA = "0x5CB5D0", Offset = "0x5CA1D0", VA = "0x1805CB5D0")]
		public bool CheckReached(float dist)
		{
			return default(bool);
		}

		// Token: 0x0600E658 RID: 58968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E658")]
		[Address(RVA = "0x5CB890", Offset = "0x5CA490", VA = "0x1805CB890")]
		public void MarkReached()
		{
		}

		// Token: 0x0600E659 RID: 58969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E659")]
		[Address(RVA = "0x5CBC80", Offset = "0x5CA880", VA = "0x1805CBC80")]
		public void ResetReachedOffset(Vector2 offset, bool randomize = true)
		{
		}

		// Token: 0x0600E65A RID: 58970 RVA: 0x00053C88 File Offset: 0x00051E88
		[Token(Token = "0x600E65A")]
		[Address(RVA = "0x5CBD80", Offset = "0x5CA980", VA = "0x1805CBD80")]
		private bool <>xLuaBaseProxy_PredictReached(float P0, out Vector2 P1, out Vector2 P2)
		{
			return default(bool);
		}

		// Token: 0x0600E65B RID: 58971 RVA: 0x00053CA0 File Offset: 0x00051EA0
		[Token(Token = "0x600E65B")]
		[Address(RVA = "0x5B4CB0", Offset = "0x5B38B0", VA = "0x1805B4CB0")]
		private Vector2 <>xLuaBaseProxy_GetNextDirection()
		{
			return default(Vector2);
		}

		// Token: 0x0600E65C RID: 58972 RVA: 0x00053CB8 File Offset: 0x00051EB8
		[Token(Token = "0x600E65C")]
		[Address(RVA = "0x5B4C90", Offset = "0x5B3890", VA = "0x1805B4C90")]
		private bool <>xLuaBaseProxy_CheckReached()
		{
			return default(bool);
		}

		// Token: 0x0400FDD3 RID: 64979
		[Token(Token = "0x400FDD3")]
		[FieldOffset(Offset = "0x80")]
		private Vector2 m_reachedOffset;

		// Token: 0x0400FDD4 RID: 64980
		[Token(Token = "0x400FDD4")]
		[FieldOffset(Offset = "0x88")]
		private bool m_isMarkReached;

		// Token: 0x0400FDD5 RID: 64981
		[Token(Token = "0x400FDD5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0400FDD6 RID: 64982
		[Token(Token = "0x400FDD6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isMarkReached;

		// Token: 0x0400FDD7 RID: 64983
		[Token(Token = "0x400FDD7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isCurrentValid;

		// Token: 0x0400FDD8 RID: 64984
		[Token(Token = "0x400FDD8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PredictReached;

		// Token: 0x0400FDD9 RID: 64985
		[Token(Token = "0x400FDD9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetNextDirection;

		// Token: 0x0400FDDA RID: 64986
		[Token(Token = "0x400FDDA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CheckReached;

		// Token: 0x0400FDDB RID: 64987
		[Token(Token = "0x400FDDB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix1_CheckReached;

		// Token: 0x0400FDDC RID: 64988
		[Token(Token = "0x400FDDC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_MarkReached;

		// Token: 0x0400FDDD RID: 64989
		[Token(Token = "0x400FDDD")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ResetReachedOffset;
	}
}
