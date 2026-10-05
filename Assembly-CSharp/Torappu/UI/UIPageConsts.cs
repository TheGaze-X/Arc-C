using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x02003625 RID: 13861
	[Token(Token = "0x2003625")]
	public static class UIPageConsts
	{
		// Token: 0x0401A90F RID: 108815
		[Token(Token = "0x401A90F")]
		public const int SIMPLE_PAGE_DISTANCE = 100;

		// Token: 0x0401A910 RID: 108816
		[Token(Token = "0x401A910")]
		[FieldOffset(Offset = "0x0")]
		public static readonly RangeInt CAMERA_DEPTH;

		// Token: 0x0401A911 RID: 108817
		[Token(Token = "0x401A911")]
		[FieldOffset(Offset = "0x8")]
		public static readonly HashSet<string> AVAIL_VIRTUAL_TOP_PAGES;
	}
}
