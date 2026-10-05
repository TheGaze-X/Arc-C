using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004BC4 RID: 19396
	[Token(Token = "0x2004BC4")]
	public class ActivityViewEntryProvider : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601D270 RID: 119408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D270")]
		[Address(RVA = "0x16B5950", Offset = "0x16B4550", VA = "0x1816B5950", Slot = "4")]
		public virtual IEnumerable<ActivityViewEntry> EnumAllActivityViewEntry()
		{
			return null;
		}

		// Token: 0x0601D271 RID: 119409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D271")]
		[Address(RVA = "0x16B59F0", Offset = "0x16B45F0", VA = "0x1816B59F0")]
		public ActivityViewEntryProvider()
		{
		}

		// Token: 0x0402644A RID: 156746
		[Token(Token = "0x402644A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_EnumAllActivityViewEntry;

		// Token: 0x0402644B RID: 156747
		[Token(Token = "0x402644B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
