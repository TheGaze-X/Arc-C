using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200231B RID: 8987
	[Token(Token = "0x200231B")]
	public class EmitGameEventManager : GlobalEnvSystem.EnvManager
	{
		// Token: 0x17001C7A RID: 7290
		// (get) Token: 0x0600E2F9 RID: 58105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001C7A")]
		public override IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> eventGroups
		{
			[Token(Token = "0x600E2F9")]
			[Address(RVA = "0x56B9B0", Offset = "0x56A5B0", VA = "0x18056B9B0", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600E2FA RID: 58106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E2FA")]
		[Address(RVA = "0x56B820", Offset = "0x56A420", VA = "0x18056B820")]
		private void _OnGameStart(object arg)
		{
		}

		// Token: 0x0600E2FB RID: 58107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E2FB")]
		[Address(RVA = "0x56B950", Offset = "0x56A550", VA = "0x18056B950")]
		public EmitGameEventManager()
		{
		}

		// Token: 0x0600E2FC RID: 58108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E2FC")]
		[Address(RVA = "0x550C20", Offset = "0x54F820", VA = "0x180550C20")]
		private IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> <>xLuaBaseProxy_get_eventGroups()
		{
			return null;
		}

		// Token: 0x0400F8FA RID: 63738
		[Token(Token = "0x400F8FA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<EmitGameEventManager.EventBinding> _eventBindings;

		// Token: 0x0400F8FB RID: 63739
		[Token(Token = "0x400F8FB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_eventGroups;

		// Token: 0x0400F8FC RID: 63740
		[Token(Token = "0x400F8FC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnGameStart;

		// Token: 0x0400F8FD RID: 63741
		[Token(Token = "0x400F8FD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200231C RID: 8988
		[Token(Token = "0x200231C")]
		[Serializable]
		private struct EventBinding
		{
			// Token: 0x0400F8FE RID: 63742
			[Token(Token = "0x400F8FE")]
			[FieldOffset(Offset = "0x0")]
			public BattleEvent battleEvent;

			// Token: 0x0400F8FF RID: 63743
			[Token(Token = "0x400F8FF")]
			[FieldOffset(Offset = "0x8")]
			public string envEvent;
		}
	}
}
