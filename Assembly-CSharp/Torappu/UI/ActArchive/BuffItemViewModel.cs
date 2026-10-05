using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B18 RID: 27416
	[Token(Token = "0x2006B18")]
	public struct BuffItemViewModel
	{
		// Token: 0x04037745 RID: 227141
		[Token(Token = "0x4037745")]
		[FieldOffset(Offset = "0x0")]
		public string buffId;

		// Token: 0x04037746 RID: 227142
		[Token(Token = "0x4037746")]
		[FieldOffset(Offset = "0x8")]
		public Sprite icon;

		// Token: 0x04037747 RID: 227143
		[Token(Token = "0x4037747")]
		[FieldOffset(Offset = "0x10")]
		public bool selected;

		// Token: 0x04037748 RID: 227144
		[Token(Token = "0x4037748")]
		[FieldOffset(Offset = "0x11")]
		public bool isNew;

		// Token: 0x04037749 RID: 227145
		[Token(Token = "0x4037749")]
		[FieldOffset(Offset = "0x12")]
		public bool locked;

		// Token: 0x0403774A RID: 227146
		[Token(Token = "0x403774A")]
		[FieldOffset(Offset = "0x18")]
		public string lockedToast;
	}
}
