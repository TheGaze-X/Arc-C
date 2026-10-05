using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x02000111 RID: 273
	[Token(Token = "0x2000111")]
	public class ScrollUtil : IHotfixable
	{
		// Token: 0x060006C4 RID: 1732 RVA: 0x000064F4 File Offset: 0x000046F4
		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x5526820", Offset = "0x5525420", VA = "0x185526820")]
		public static Vector2 CalcScrollSize(bool vertical, bool horizontal, RectTransform content, Vector2 delta)
		{
			return default(Vector2);
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x0000650C File Offset: 0x0000470C
		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x5526C10", Offset = "0x5525810", VA = "0x185526C10")]
		public static bool CheckAbleToUpdateBounds(Canvas canvas)
		{
			return default(bool);
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x5526D10", Offset = "0x5525910", VA = "0x185526D10")]
		public ScrollUtil()
		{
		}

		// Token: 0x040005D6 RID: 1494
		[Token(Token = "0x40005D6")]
		private const float MIN_SIZE = 100f;

		// Token: 0x040005D7 RID: 1495
		[Token(Token = "0x40005D7")]
		private const float MAX_SIZE = 400f;

		// Token: 0x040005D8 RID: 1496
		[Token(Token = "0x40005D8")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate126 __Hotfix0_CalcScrollSize;

		// Token: 0x040005D9 RID: 1497
		[Token(Token = "0x40005D9")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate21 __Hotfix0_CheckAbleToUpdateBounds;

		// Token: 0x040005DA RID: 1498
		[Token(Token = "0x40005DA")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;
	}
}
