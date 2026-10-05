using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x0200058E RID: 1422
	[Token(Token = "0x200058E")]
	public class TopMenuDynamicPrefabInstHolder : DynamicPrefabInstHolder
	{
		// Token: 0x06005C13 RID: 23571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C13")]
		[Address(RVA = "0x1CFC110", Offset = "0x1CFAD10", VA = "0x181CFC110", Slot = "4")]
		public override GameObject GetPrefab()
		{
			return null;
		}

		// Token: 0x06005C14 RID: 23572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C14")]
		[Address(RVA = "0x1CFC1A0", Offset = "0x1CFADA0", VA = "0x181CFC1A0")]
		public TopMenuDynamicPrefabInstHolder()
		{
		}

		// Token: 0x040021C2 RID: 8642
		[Token(Token = "0x40021C2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetPrefab;

		// Token: 0x040021C3 RID: 8643
		[Token(Token = "0x40021C3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
