using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200237A RID: 9082
	[Token(Token = "0x200237A")]
	public class DouququEmptyCursor : TracePositionCursor
	{
		// Token: 0x0600E65D RID: 58973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E65D")]
		[Address(RVA = "0x5BF560", Offset = "0x5BE160", VA = "0x1805BF560")]
		public DouququEmptyCursor(Route route, Scheduler.SchedulerSnapshot snapshot, Vector2 offset, BObject obj, bool ignoreAllButMoveCp = false, bool visitEveryTileCenter = false, bool visitEveryNodeCenter = false)
		{
		}

		// Token: 0x0600E65E RID: 58974 RVA: 0x00053CD0 File Offset: 0x00051ED0
		[Token(Token = "0x600E65E")]
		[Address(RVA = "0x5BF4C0", Offset = "0x5BE0C0", VA = "0x1805BF4C0", Slot = "12")]
		public override Vector2 GetNextDirection()
		{
			return default(Vector2);
		}

		// Token: 0x0600E65F RID: 58975 RVA: 0x00053CE8 File Offset: 0x00051EE8
		[Token(Token = "0x600E65F")]
		[Address(RVA = "0x5BF550", Offset = "0x5BE150", VA = "0x1805BF550")]
		private Vector2 <>xLuaBaseProxy_GetNextDirection()
		{
			return default(Vector2);
		}

		// Token: 0x0400FDDE RID: 64990
		[Token(Token = "0x400FDDE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0400FDDF RID: 64991
		[Token(Token = "0x400FDDF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetNextDirection;
	}
}
