using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020040D5 RID: 16597
	[Token(Token = "0x20040D5")]
	public class SandboxV2AdminMainScienceTypeItemData
	{
		// Token: 0x06019ACE RID: 105166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019ACE")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2AdminMainScienceTypeItemData()
		{
		}

		// Token: 0x040201A5 RID: 131493
		[Token(Token = "0x40201A5")]
		[FieldOffset(Offset = "0x10")]
		public SandboxV2AdminMainScienceType type;

		// Token: 0x040201A6 RID: 131494
		[Token(Token = "0x40201A6")]
		[FieldOffset(Offset = "0x18")]
		public Sprite icon;

		// Token: 0x040201A7 RID: 131495
		[Token(Token = "0x40201A7")]
		[FieldOffset(Offset = "0x20")]
		public Sprite selectedIcon;

		// Token: 0x040201A8 RID: 131496
		[Token(Token = "0x40201A8")]
		[FieldOffset(Offset = "0x28")]
		public Sprite progressBarImg;

		// Token: 0x040201A9 RID: 131497
		[Token(Token = "0x40201A9")]
		[FieldOffset(Offset = "0x30")]
		public Sprite progressBarSelectedImg;

		// Token: 0x040201AA RID: 131498
		[Token(Token = "0x40201AA")]
		[FieldOffset(Offset = "0x38")]
		public float progress;

		// Token: 0x040201AB RID: 131499
		[Token(Token = "0x40201AB")]
		[FieldOffset(Offset = "0x3C")]
		public bool isLocked;

		// Token: 0x040201AC RID: 131500
		[Token(Token = "0x40201AC")]
		[FieldOffset(Offset = "0x3D")]
		public bool isLast;
	}
}
