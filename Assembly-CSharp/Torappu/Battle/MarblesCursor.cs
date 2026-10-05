using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200237B RID: 9083
	[Token(Token = "0x200237B")]
	public class MarblesCursor : DirectionCursor
	{
		// Token: 0x0600E660 RID: 58976 RVA: 0x00053D00 File Offset: 0x00051F00
		[Token(Token = "0x600E660")]
		[Address(RVA = "0x5C4560", Offset = "0x5C3160", VA = "0x1805C4560", Slot = "11")]
		protected override Vector2 _GetNextTarget()
		{
			return default(Vector2);
		}

		// Token: 0x0600E661 RID: 58977 RVA: 0x00053D18 File Offset: 0x00051F18
		[Token(Token = "0x600E661")]
		[Address(RVA = "0x5C40C0", Offset = "0x5C2CC0", VA = "0x1805C40C0", Slot = "12")]
		public override Vector2 GetNextDirection()
		{
			return default(Vector2);
		}

		// Token: 0x0600E662 RID: 58978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E662")]
		[Address(RVA = "0x5C4A90", Offset = "0x5C3690", VA = "0x1805C4A90")]
		public MarblesCursor(Route route, Scheduler.SchedulerSnapshot snapshot, Vector2 offset, BObject obj, bool ignoreAllButMoveCp = false, bool visitEveryTileCenter = false, bool visitEveryNodeCenter = false)
		{
		}

		// Token: 0x0600E663 RID: 58979 RVA: 0x00053D30 File Offset: 0x00051F30
		[Token(Token = "0x600E663")]
		[Address(RVA = "0x5C4970", Offset = "0x5C3570", VA = "0x1805C4970")]
		private Vector2 _GetProperPointInRect(Vector2 curPos, Vector2 rectCenterPos)
		{
			return default(Vector2);
		}

		// Token: 0x0600E664 RID: 58980 RVA: 0x00053D48 File Offset: 0x00051F48
		[Token(Token = "0x600E664")]
		[Address(RVA = "0x5C4550", Offset = "0x5C3150", VA = "0x1805C4550")]
		private Vector2 <>xLuaBaseProxy__GetNextTarget()
		{
			return default(Vector2);
		}

		// Token: 0x0600E665 RID: 58981 RVA: 0x00053D60 File Offset: 0x00051F60
		[Token(Token = "0x600E665")]
		[Address(RVA = "0x5B4CB0", Offset = "0x5B38B0", VA = "0x1805B4CB0")]
		private Vector2 <>xLuaBaseProxy_GetNextDirection()
		{
			return default(Vector2);
		}

		// Token: 0x0400FDE0 RID: 64992
		[Token(Token = "0x400FDE0")]
		private const float SPECIAL_ROUTE_GOPASS_DISTANCE = 0.65f;

		// Token: 0x0400FDE1 RID: 64993
		[Token(Token = "0x400FDE1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__GetNextTarget;

		// Token: 0x0400FDE2 RID: 64994
		[Token(Token = "0x400FDE2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetNextDirection;

		// Token: 0x0400FDE3 RID: 64995
		[Token(Token = "0x400FDE3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0400FDE4 RID: 64996
		[Token(Token = "0x400FDE4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetProperPointInRect;
	}
}
