using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YoStar.SDK.Help
{
	// Token: 0x02000222 RID: 546
	[Token(Token = "0x2000222")]
	public static class YoCursorHelper
	{
		// Token: 0x06000DFB RID: 3579 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000DFB")]
		[Address(RVA = "0x5CB6440", Offset = "0x5CB5040", VA = "0x185CB6440")]
		public static void SetCursorType(CursorType cursorType)
		{
		}

		// Token: 0x0400096F RID: 2415
		[Token(Token = "0x400096F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly string Pointer;

		// Token: 0x04000970 RID: 2416
		[Token(Token = "0x4000970")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly string Text;

		// Token: 0x04000971 RID: 2417
		[Token(Token = "0x4000971")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly string Cursor_sdk;

		// Token: 0x04000972 RID: 2418
		[Token(Token = "0x4000972")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static Dictionary<string, YoCursorHelper.CursorInfo> _supportedCursors;

		// Token: 0x02000223 RID: 547
		[Token(Token = "0x2000223")]
		private class CursorInfo
		{
			// Token: 0x06000DFD RID: 3581 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x6000DFD")]
			[Address(RVA = "0x4A76120", Offset = "0x4A74D20", VA = "0x184A76120")]
			public CursorInfo(bool centered = false, [Optional] Texture2D texture)
			{
			}

			// Token: 0x04000973 RID: 2419
			[Token(Token = "0x4000973")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool Centered;

			// Token: 0x04000974 RID: 2420
			[Token(Token = "0x4000974")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Texture2D Texture;
		}
	}
}
