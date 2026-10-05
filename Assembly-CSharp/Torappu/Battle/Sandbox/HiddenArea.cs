using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Sandbox
{
	// Token: 0x02002A64 RID: 10852
	[Token(Token = "0x2002A64")]
	public class HiddenArea : IHotfixable
	{
		// Token: 0x060120CD RID: 73933 RVA: 0x0006E700 File Offset: 0x0006C900
		[Token(Token = "0x60120CD")]
		[Address(RVA = "0xA21F50", Offset = "0xA20B50", VA = "0x180A21F50")]
		public bool IsInArea(int row, int col)
		{
			return default(bool);
		}

		// Token: 0x060120CE RID: 73934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60120CE")]
		[Address(RVA = "0xA22060", Offset = "0xA20C60", VA = "0x180A22060")]
		public HiddenArea()
		{
		}

		// Token: 0x0401463C RID: 83516
		[Token(Token = "0x401463C")]
		[FieldOffset(Offset = "0x10")]
		public Rect rect;

		// Token: 0x0401463D RID: 83517
		[Token(Token = "0x401463D")]
		[FieldOffset(Offset = "0x20")]
		public bool isHidden;

		// Token: 0x0401463E RID: 83518
		[Token(Token = "0x401463E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsInArea;

		// Token: 0x0401463F RID: 83519
		[Token(Token = "0x401463F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
