using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200234C RID: 9036
	[Token(Token = "0x200234C")]
	public class Rogue4DLC2LastDeployManager : GlobalEnvSystem.EnvManager, IHotfixable
	{
		// Token: 0x17001C9C RID: 7324
		// (get) Token: 0x0600E4A8 RID: 58536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001C9C")]
		public override IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> eventGroups
		{
			[Token(Token = "0x600E4A8")]
			[Address(RVA = "0x5AA9C0", Offset = "0x5A95C0", VA = "0x1805AA9C0", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600E4A9 RID: 58537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E4A9")]
		[Address(RVA = "0x5AA6C0", Offset = "0x5A92C0", VA = "0x1805AA6C0")]
		private void _OnGameOver(object arg)
		{
		}

		// Token: 0x0600E4AA RID: 58538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E4AA")]
		[Address(RVA = "0x5AA960", Offset = "0x5A9560", VA = "0x1805AA960")]
		public Rogue4DLC2LastDeployManager()
		{
		}

		// Token: 0x0600E4AB RID: 58539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E4AB")]
		[Address(RVA = "0x550C20", Offset = "0x54F820", VA = "0x180550C20")]
		private IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> <>xLuaBaseProxy_get_eventGroups()
		{
			return null;
		}

		// Token: 0x0400FC02 RID: 64514
		[Token(Token = "0x400FC02")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_eventGroups;

		// Token: 0x0400FC03 RID: 64515
		[Token(Token = "0x400FC03")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnGameOver;

		// Token: 0x0400FC04 RID: 64516
		[Token(Token = "0x400FC04")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
