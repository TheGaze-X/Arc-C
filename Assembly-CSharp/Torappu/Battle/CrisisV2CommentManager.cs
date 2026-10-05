using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002319 RID: 8985
	[Token(Token = "0x2002319")]
	public class CrisisV2CommentManager : GlobalEnvSystem.EnvManager
	{
		// Token: 0x17001C78 RID: 7288
		// (get) Token: 0x0600E2EF RID: 58095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001C78")]
		public override IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> eventGroups
		{
			[Token(Token = "0x600E2EF")]
			[Address(RVA = "0x56AF90", Offset = "0x569B90", VA = "0x18056AF90", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600E2F0 RID: 58096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E2F0")]
		[Address(RVA = "0x56ABD0", Offset = "0x5697D0", VA = "0x18056ABD0")]
		private void _OnUnitBorn(object args)
		{
		}

		// Token: 0x0600E2F1 RID: 58097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E2F1")]
		[Address(RVA = "0x56A700", Offset = "0x569300", VA = "0x18056A700")]
		private void _OnEnemyReachedExit(object args)
		{
		}

		// Token: 0x0600E2F2 RID: 58098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E2F2")]
		[Address(RVA = "0x56AA60", Offset = "0x569660", VA = "0x18056AA60")]
		private void _OnGameOver(object args)
		{
		}

		// Token: 0x0600E2F3 RID: 58099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E2F3")]
		[Address(RVA = "0x56AF30", Offset = "0x569B30", VA = "0x18056AF30")]
		public CrisisV2CommentManager()
		{
		}

		// Token: 0x0600E2F4 RID: 58100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E2F4")]
		[Address(RVA = "0x550C20", Offset = "0x54F820", VA = "0x180550C20")]
		private IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> <>xLuaBaseProxy_get_eventGroups()
		{
			return null;
		}

		// Token: 0x0400F8EF RID: 63727
		[Token(Token = "0x400F8EF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_eventGroups;

		// Token: 0x0400F8F0 RID: 63728
		[Token(Token = "0x400F8F0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnUnitBorn;

		// Token: 0x0400F8F1 RID: 63729
		[Token(Token = "0x400F8F1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnEnemyReachedExit;

		// Token: 0x0400F8F2 RID: 63730
		[Token(Token = "0x400F8F2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnGameOver;

		// Token: 0x0400F8F3 RID: 63731
		[Token(Token = "0x400F8F3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
