using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Vuplex.WebView.Internal
{
	// Token: 0x02000082 RID: 130
	[Token(Token = "0x2000082")]
	public static class CursorHelper
	{
		// Token: 0x06000404 RID: 1028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000404")]
		[Address(RVA = "0x5BCB750", Offset = "0x5BCA350", VA = "0x185BCB750")]
		public static void SetCursorIcon(string cursorType)
		{
		}

		// Token: 0x040001DB RID: 475
		[Token(Token = "0x40001DB")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<string, CursorHelper.CursorInfo> _supportedCursors;

		// Token: 0x02000083 RID: 131
		[Token(Token = "0x2000083")]
		private class CursorInfo
		{
			// Token: 0x06000406 RID: 1030 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000406")]
			[Address(RVA = "0x5BCBA70", Offset = "0x5BCA670", VA = "0x185BCBA70")]
			public CursorInfo(string textureName, Vector2 hotSpot)
			{
			}

			// Token: 0x17000052 RID: 82
			// (get) Token: 0x06000407 RID: 1031 RVA: 0x000026B8 File Offset: 0x000008B8
			// (set) Token: 0x06000408 RID: 1032 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000052")]
			public Vector2 HotSpot
			{
				[Token(Token = "0x6000407")]
				[Address(RVA = "0x26FA000", Offset = "0x26F8C00", VA = "0x1826FA000")]
				[CompilerGenerated]
				get
				{
					return default(Vector2);
				}
				[Token(Token = "0x6000408")]
				[Address(RVA = "0xD980D0", Offset = "0xD96CD0", VA = "0x180D980D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000053 RID: 83
			// (get) Token: 0x06000409 RID: 1033 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000053")]
			public Texture2D Texture
			{
				[Token(Token = "0x6000409")]
				[Address(RVA = "0x5BCBAC0", Offset = "0x5BCA6C0", VA = "0x185BCBAC0")]
				get
				{
					return null;
				}
			}

			// Token: 0x040001DD RID: 477
			[Token(Token = "0x40001DD")]
			[FieldOffset(Offset = "0x18")]
			private Texture2D _texture;

			// Token: 0x040001DE RID: 478
			[Token(Token = "0x40001DE")]
			[FieldOffset(Offset = "0x20")]
			private string _textureName;
		}
	}
}
