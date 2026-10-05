using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200231A RID: 8986
	[Token(Token = "0x200231A")]
	public class DummyBornFinishManager : GlobalEnvSystem.EnvManager
	{
		// Token: 0x17001C79 RID: 7289
		// (get) Token: 0x0600E2F5 RID: 58101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001C79")]
		public override IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> eventGroups
		{
			[Token(Token = "0x600E2F5")]
			[Address(RVA = "0x56B6B0", Offset = "0x56A2B0", VA = "0x18056B6B0", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600E2F6 RID: 58102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E2F6")]
		[Address(RVA = "0x56B260", Offset = "0x569E60", VA = "0x18056B260")]
		private void _OnDummyLocateTile(object arg)
		{
		}

		// Token: 0x0600E2F7 RID: 58103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E2F7")]
		[Address(RVA = "0x56B600", Offset = "0x56A200", VA = "0x18056B600")]
		public DummyBornFinishManager()
		{
		}

		// Token: 0x0600E2F8 RID: 58104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E2F8")]
		[Address(RVA = "0x550C20", Offset = "0x54F820", VA = "0x180550C20")]
		private IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> <>xLuaBaseProxy_get_eventGroups()
		{
			return null;
		}

		// Token: 0x0400F8F4 RID: 63732
		[Token(Token = "0x400F8F4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _bornEvent;

		// Token: 0x0400F8F5 RID: 63733
		[Token(Token = "0x400F8F5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _finishEvent;

		// Token: 0x0400F8F6 RID: 63734
		[Token(Token = "0x400F8F6")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<ObjectPtr<Character>, Tile> m_dummyTileMap;

		// Token: 0x0400F8F7 RID: 63735
		[Token(Token = "0x400F8F7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_eventGroups;

		// Token: 0x0400F8F8 RID: 63736
		[Token(Token = "0x400F8F8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnDummyLocateTile;

		// Token: 0x0400F8F9 RID: 63737
		[Token(Token = "0x400F8F9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
