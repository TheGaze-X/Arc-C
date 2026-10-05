using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x020013DC RID: 5084
	[Token(Token = "0x20013DC")]
	[LuaCallCSharp(GenFlag.No)]
	public struct SortableString : IHotfixable
	{
		// Token: 0x060073F9 RID: 29689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073F9")]
		[Address(RVA = "0x2212850", Offset = "0x2211450", VA = "0x182212850")]
		public SortableString(string str, int weight)
		{
		}

		// Token: 0x060073FA RID: 29690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073FA")]
		[Address(RVA = "0x22126F0", Offset = "0x22112F0", VA = "0x1822126F0")]
		public static void FlushToStringList(List<SortableString> src, ref List<string> dst)
		{
		}

		// Token: 0x060073FB RID: 29691 RVA: 0x000338B8 File Offset: 0x00031AB8
		[Token(Token = "0x60073FB")]
		[Address(RVA = "0x2212650", Offset = "0x2211250", VA = "0x182212650")]
		public static int Compare(SortableString lhs, SortableString rhs)
		{
			return 0;
		}

		// Token: 0x060073FC RID: 29692 RVA: 0x000338D0 File Offset: 0x00031AD0
		[Token(Token = "0x60073FC")]
		[Address(RVA = "0x22125B0", Offset = "0x22111B0", VA = "0x1822125B0")]
		public static int CompareInverse(SortableString lhs, SortableString rhs)
		{
			return 0;
		}

		// Token: 0x040070D3 RID: 28883
		[Token(Token = "0x40070D3")]
		[FieldOffset(Offset = "0x0")]
		public string str;

		// Token: 0x040070D4 RID: 28884
		[Token(Token = "0x40070D4")]
		[FieldOffset(Offset = "0x8")]
		public int weight;

		// Token: 0x040070D5 RID: 28885
		[Token(Token = "0x40070D5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040070D6 RID: 28886
		[Token(Token = "0x40070D6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_FlushToStringList;

		// Token: 0x040070D7 RID: 28887
		[Token(Token = "0x40070D7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Compare;

		// Token: 0x040070D8 RID: 28888
		[Token(Token = "0x40070D8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CompareInverse;
	}
}
