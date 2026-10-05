using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002536 RID: 9526
	[Token(Token = "0x2002536")]
	public class BuffKeyInGlobalRangeOrAdvancedSelector : AdvancedSelector
	{
		// Token: 0x0600F5BF RID: 62911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F5BF")]
		[Address(RVA = "0x6D13F0", Offset = "0x6CFFF0", VA = "0x1806D13F0", Slot = "37")]
		protected override void OnPostFilter(List<Entity> candidates)
		{
		}

		// Token: 0x0600F5C0 RID: 62912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F5C0")]
		[Address(RVA = "0x6D1900", Offset = "0x6D0500", VA = "0x1806D1900")]
		public BuffKeyInGlobalRangeOrAdvancedSelector()
		{
		}

		// Token: 0x0600F5C2 RID: 62914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F5C2")]
		[Address(RVA = "0x69A940", Offset = "0x699540", VA = "0x18069A940")]
		private void <>xLuaBaseProxy_OnPostFilter(List<Entity> P0)
		{
		}

		// Token: 0x04011085 RID: 69765
		[Token(Token = "0x4011085")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[Group("Buff")]
		private string _buffKey;

		// Token: 0x04011086 RID: 69766
		[Token(Token = "0x4011086")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPostFilter;

		// Token: 0x04011087 RID: 69767
		[Token(Token = "0x4011087")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
