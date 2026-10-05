using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024E7 RID: 9447
	[Token(Token = "0x20024E7")]
	public class AdvancedSelectorWithElementBreak : AdvancedSelector
	{
		// Token: 0x0600F36E RID: 62318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F36E")]
		[Address(RVA = "0x69C160", Offset = "0x69AD60", VA = "0x18069C160", Slot = "37")]
		protected override void OnPostFilter(List<Entity> candidates)
		{
		}

		// Token: 0x0600F36F RID: 62319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F36F")]
		[Address(RVA = "0x69C260", Offset = "0x69AE60", VA = "0x18069C260")]
		public AdvancedSelectorWithElementBreak()
		{
		}

		// Token: 0x0600F370 RID: 62320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F370")]
		[Address(RVA = "0x69A940", Offset = "0x699540", VA = "0x18069A940")]
		private void <>xLuaBaseProxy_OnPostFilter(List<Entity> P0)
		{
		}

		// Token: 0x04010D5E RID: 68958
		[Token(Token = "0x4010D5E")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private bool _CheckNotInElementBreak;

		// Token: 0x04010D5F RID: 68959
		[Token(Token = "0x4010D5F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPostFilter;

		// Token: 0x04010D60 RID: 68960
		[Token(Token = "0x4010D60")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
