using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.BossRush
{
	// Token: 0x020061C5 RID: 25029
	[Token(Token = "0x20061C5")]
	public class BossRushTeamModel : IHotfixable
	{
		// Token: 0x1700553A RID: 21818
		// (get) Token: 0x060241EA RID: 147946 RVA: 0x000C32A0 File Offset: 0x000C14A0
		[Token(Token = "0x1700553A")]
		public int freeCharNum
		{
			[Token(Token = "0x60241EA")]
			[Address(RVA = "0x1EE2DD0", Offset = "0x1EE19D0", VA = "0x181EE2DD0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060241EB RID: 147947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60241EB")]
		[Address(RVA = "0x1EE2D70", Offset = "0x1EE1970", VA = "0x181EE2D70")]
		public BossRushTeamModel()
		{
		}

		// Token: 0x04032367 RID: 205671
		[Token(Token = "0x4032367")]
		[FieldOffset(Offset = "0x10")]
		public string teamId;

		// Token: 0x04032368 RID: 205672
		[Token(Token = "0x4032368")]
		[FieldOffset(Offset = "0x18")]
		public List<string> teamCharIdList;

		// Token: 0x04032369 RID: 205673
		[Token(Token = "0x4032369")]
		[FieldOffset(Offset = "0x20")]
		public Sprite buffIcon;

		// Token: 0x0403236A RID: 205674
		[Token(Token = "0x403236A")]
		[FieldOffset(Offset = "0x28")]
		public string buffId;

		// Token: 0x0403236B RID: 205675
		[Token(Token = "0x403236B")]
		[FieldOffset(Offset = "0x30")]
		public string buffDesc;

		// Token: 0x0403236C RID: 205676
		[Token(Token = "0x403236C")]
		[FieldOffset(Offset = "0x38")]
		public string buffName;

		// Token: 0x0403236D RID: 205677
		[Token(Token = "0x403236D")]
		[FieldOffset(Offset = "0x40")]
		public string teamName;

		// Token: 0x0403236E RID: 205678
		[Token(Token = "0x403236E")]
		[FieldOffset(Offset = "0x48")]
		public int maxCharNum;

		// Token: 0x0403236F RID: 205679
		[Token(Token = "0x403236F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_freeCharNum;

		// Token: 0x04032370 RID: 205680
		[Token(Token = "0x4032370")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
