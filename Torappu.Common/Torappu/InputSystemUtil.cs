using System;
using Il2CppDummyDll;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

namespace Torappu
{
	// Token: 0x020000FB RID: 251
	[Token(Token = "0x20000FB")]
	public static class InputSystemUtil
	{
		// Token: 0x0600063A RID: 1594 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600063A")]
		[Address(RVA = "0x5520A00", Offset = "0x551F600", VA = "0x185520A00")]
		public static ButtonControl GetButtonByKey(this Mouse mouse, InputSystemUtil.MouseKey mouseButton)
		{
			return null;
		}

		// Token: 0x04000587 RID: 1415
		[Token(Token = "0x4000587")]
		[FieldOffset(Offset = "0x0")]
		public static readonly InputSystemUtil.MouseKey[] MOUSE_ALL_KEYS;

		// Token: 0x020000FC RID: 252
		[Token(Token = "0x20000FC")]
		public enum MouseKey
		{
			// Token: 0x04000589 RID: 1417
			[Token(Token = "0x4000589")]
			Left,
			// Token: 0x0400058A RID: 1418
			[Token(Token = "0x400058A")]
			Right,
			// Token: 0x0400058B RID: 1419
			[Token(Token = "0x400058B")]
			Middle,
			// Token: 0x0400058C RID: 1420
			[Token(Token = "0x400058C")]
			Forward,
			// Token: 0x0400058D RID: 1421
			[Token(Token = "0x400058D")]
			Back
		}
	}
}
