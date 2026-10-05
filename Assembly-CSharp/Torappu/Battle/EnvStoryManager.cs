using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002321 RID: 8993
	[Token(Token = "0x2002321")]
	public class EnvStoryManager : GlobalEnvSystem.EnvManager
	{
		// Token: 0x17001C81 RID: 7297
		// (get) Token: 0x0600E334 RID: 58164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001C81")]
		public override IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> eventGroups
		{
			[Token(Token = "0x600E334")]
			[Address(RVA = "0x570B00", Offset = "0x56F700", VA = "0x180570B00", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600E335 RID: 58165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E335")]
		[Address(RVA = "0x5709A0", Offset = "0x56F5A0", VA = "0x1805709A0")]
		private void _OnGameStart(object arg)
		{
		}

		// Token: 0x0600E336 RID: 58166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E336")]
		[Address(RVA = "0x570AA0", Offset = "0x56F6A0", VA = "0x180570AA0")]
		public EnvStoryManager()
		{
		}

		// Token: 0x0600E337 RID: 58167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E337")]
		[Address(RVA = "0x550C20", Offset = "0x54F820", VA = "0x180550C20")]
		private IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> <>xLuaBaseProxy_get_eventGroups()
		{
			return null;
		}

		// Token: 0x0400F97B RID: 63867
		[Token(Token = "0x400F97B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_eventGroups;

		// Token: 0x0400F97C RID: 63868
		[Token(Token = "0x400F97C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnGameStart;

		// Token: 0x0400F97D RID: 63869
		[Token(Token = "0x400F97D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
