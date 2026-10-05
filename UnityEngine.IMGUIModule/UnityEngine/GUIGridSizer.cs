using System;
using Il2CppDummyDll;

namespace UnityEngine
{
	// Token: 0x02000023 RID: 35
	[Token(Token = "0x2000023")]
	internal sealed class GUIGridSizer : GUILayoutEntry
	{
		// Token: 0x0600022A RID: 554 RVA: 0x00002B08 File Offset: 0x00000D08
		[Token(Token = "0x600022A")]
		[Address(RVA = "0x59A7BC0", Offset = "0x59A67C0", VA = "0x1859A7BC0")]
		public static Rect GetRect(GUIContent[] contents, int xCount, GUIStyle style, GUILayoutOption[] options)
		{
			return default(Rect);
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022B")]
		[Address(RVA = "0x59A7E30", Offset = "0x59A6A30", VA = "0x1859A7E30")]
		private GUIGridSizer(GUIContent[] contents, int xCount, GUIStyle buttonStyle, GUILayoutOption[] options)
		{
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600022C RID: 556 RVA: 0x00002B20 File Offset: 0x00000D20
		[Token(Token = "0x17000082")]
		private int rows
		{
			[Token(Token = "0x600022C")]
			[Address(RVA = "0x59A8340", Offset = "0x59A6F40", VA = "0x1859A8340")]
			get
			{
				return 0;
			}
		}

		// Token: 0x040000D1 RID: 209
		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0x48")]
		private readonly int m_Count;

		// Token: 0x040000D2 RID: 210
		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0x4C")]
		private readonly int m_XCount;

		// Token: 0x040000D3 RID: 211
		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0x50")]
		private readonly float m_MinButtonWidth;

		// Token: 0x040000D4 RID: 212
		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0x54")]
		private readonly float m_MaxButtonWidth;

		// Token: 0x040000D5 RID: 213
		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0x58")]
		private readonly float m_MinButtonHeight;

		// Token: 0x040000D6 RID: 214
		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0x5C")]
		private readonly float m_MaxButtonHeight;
	}
}
