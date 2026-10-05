using System;
using Il2CppDummyDll;
using Torappu.Battle.UI.Act6Fun;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002368 RID: 9064
	[Token(Token = "0x2002368")]
	public class Act6FunEmptyCursor : DirectionCursor
	{
		// Token: 0x17001CCC RID: 7372
		// (get) Token: 0x0600E5AE RID: 58798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001CCC")]
		private Act6FunUIPlugin uiPlugin
		{
			[Token(Token = "0x600E5AE")]
			[Address(RVA = "0x5B5060", Offset = "0x5B3C60", VA = "0x1805B5060")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001CCD RID: 7373
		// (get) Token: 0x0600E5AF RID: 58799 RVA: 0x00053280 File Offset: 0x00051480
		[Token(Token = "0x17001CCD")]
		public override float distToExit
		{
			[Token(Token = "0x600E5AF")]
			[Address(RVA = "0x5B5000", Offset = "0x5B3C00", VA = "0x1805B5000", Slot = "7")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17001CCE RID: 7374
		// (get) Token: 0x0600E5B0 RID: 58800 RVA: 0x00053298 File Offset: 0x00051498
		[Token(Token = "0x17001CCE")]
		public override float distToExitPrecise
		{
			[Token(Token = "0x600E5B0")]
			[Address(RVA = "0x5B4FA0", Offset = "0x5B3BA0", VA = "0x1805B4FA0", Slot = "8")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600E5B1 RID: 58801 RVA: 0x000532B0 File Offset: 0x000514B0
		[Token(Token = "0x600E5B1")]
		[Address(RVA = "0x5B48E0", Offset = "0x5B34E0", VA = "0x1805B48E0", Slot = "6")]
		public override Vector2 GetContDirectionAfterEnd()
		{
			return default(Vector2);
		}

		// Token: 0x0600E5B2 RID: 58802 RVA: 0x000532C8 File Offset: 0x000514C8
		[Token(Token = "0x600E5B2")]
		[Address(RVA = "0x5B47D0", Offset = "0x5B33D0", VA = "0x1805B47D0", Slot = "9")]
		public override bool CheckReached()
		{
			return default(bool);
		}

		// Token: 0x0600E5B3 RID: 58803 RVA: 0x000532E0 File Offset: 0x000514E0
		[Token(Token = "0x600E5B3")]
		[Address(RVA = "0x5B4AE0", Offset = "0x5B36E0", VA = "0x1805B4AE0", Slot = "12")]
		public override Vector2 GetNextDirection()
		{
			return default(Vector2);
		}

		// Token: 0x0600E5B4 RID: 58804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E5B4")]
		[Address(RVA = "0x5B4E60", Offset = "0x5B3A60", VA = "0x1805B4E60")]
		public Act6FunEmptyCursor(Route route, Scheduler.SchedulerSnapshot snapshot, Vector2 offset, BObject obj, bool ignoreAllButMoveCp = false, bool visitEveryTileCenter = false, bool visitEveryNodeCenter = false)
		{
		}

		// Token: 0x0600E5B5 RID: 58805 RVA: 0x000532F8 File Offset: 0x000514F8
		[Token(Token = "0x600E5B5")]
		[Address(RVA = "0x5B4CD0", Offset = "0x5B38D0", VA = "0x1805B4CD0")]
		private float <>xLuaBaseProxy_get_distToExit()
		{
			return 0f;
		}

		// Token: 0x0600E5B6 RID: 58806 RVA: 0x00053310 File Offset: 0x00051510
		[Token(Token = "0x600E5B6")]
		[Address(RVA = "0x5B4CC0", Offset = "0x5B38C0", VA = "0x1805B4CC0")]
		private float <>xLuaBaseProxy_get_distToExitPrecise()
		{
			return 0f;
		}

		// Token: 0x0600E5B7 RID: 58807 RVA: 0x00053328 File Offset: 0x00051528
		[Token(Token = "0x600E5B7")]
		[Address(RVA = "0x5B4CA0", Offset = "0x5B38A0", VA = "0x1805B4CA0")]
		private Vector2 <>xLuaBaseProxy_GetContDirectionAfterEnd()
		{
			return default(Vector2);
		}

		// Token: 0x0600E5B8 RID: 58808 RVA: 0x00053340 File Offset: 0x00051540
		[Token(Token = "0x600E5B8")]
		[Address(RVA = "0x5B4C90", Offset = "0x5B3890", VA = "0x1805B4C90")]
		private bool <>xLuaBaseProxy_CheckReached()
		{
			return default(bool);
		}

		// Token: 0x0600E5B9 RID: 58809 RVA: 0x00053358 File Offset: 0x00051558
		[Token(Token = "0x600E5B9")]
		[Address(RVA = "0x5B4CB0", Offset = "0x5B38B0", VA = "0x1805B4CB0")]
		private Vector2 <>xLuaBaseProxy_GetNextDirection()
		{
			return default(Vector2);
		}

		// Token: 0x0400FD7B RID: 64891
		[Token(Token = "0x400FD7B")]
		[FieldOffset(Offset = "0x80")]
		private Act6FunUIPlugin m_uiPlugin;

		// Token: 0x0400FD7C RID: 64892
		[Token(Token = "0x400FD7C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_uiPlugin;

		// Token: 0x0400FD7D RID: 64893
		[Token(Token = "0x400FD7D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_distToExit;

		// Token: 0x0400FD7E RID: 64894
		[Token(Token = "0x400FD7E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_distToExitPrecise;

		// Token: 0x0400FD7F RID: 64895
		[Token(Token = "0x400FD7F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetContDirectionAfterEnd;

		// Token: 0x0400FD80 RID: 64896
		[Token(Token = "0x400FD80")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CheckReached;

		// Token: 0x0400FD81 RID: 64897
		[Token(Token = "0x400FD81")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetNextDirection;

		// Token: 0x0400FD82 RID: 64898
		[Token(Token = "0x400FD82")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
