using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002145 RID: 8517
	[Token(Token = "0x2002145")]
	public abstract class ToggleableHookerChecker : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600D16D RID: 53613
		[Token(Token = "0x600D16D")]
		public abstract bool CheckValidity();

		// Token: 0x0600D16E RID: 53614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D16E")]
		[Address(RVA = "0x353B620", Offset = "0x353A220", VA = "0x18353B620")]
		protected ToggleableHookerChecker()
		{
		}

		// Token: 0x0400DFDC RID: 57308
		[Token(Token = "0x400DFDC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
