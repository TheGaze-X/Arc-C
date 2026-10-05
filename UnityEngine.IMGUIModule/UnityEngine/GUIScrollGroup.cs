using System;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000026 RID: 38
	[Token(Token = "0x2000026")]
	internal sealed class GUIScrollGroup : GUILayoutGroup
	{
		// Token: 0x06000240 RID: 576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000240")]
		[Address(RVA = "0x59AC430", Offset = "0x59AB030", VA = "0x1859AC430")]
		[RequiredByNativeCode]
		public GUIScrollGroup()
		{
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000241")]
		[Address(RVA = "0x59ABFD0", Offset = "0x59AABD0", VA = "0x1859ABFD0", Slot = "8")]
		public override void CalcWidth()
		{
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000242")]
		[Address(RVA = "0x59AC070", Offset = "0x59AAC70", VA = "0x1859AC070", Slot = "10")]
		public override void SetHorizontal(float x, float width)
		{
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000243")]
		[Address(RVA = "0x59ABEB0", Offset = "0x59AAAB0", VA = "0x1859ABEB0", Slot = "9")]
		public override void CalcHeight()
		{
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000244")]
		[Address(RVA = "0x59AC1C0", Offset = "0x59AADC0", VA = "0x1859AC1C0", Slot = "11")]
		public override void SetVertical(float y, float height)
		{
		}

		// Token: 0x040000EF RID: 239
		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x90")]
		public float calcMinWidth;

		// Token: 0x040000F0 RID: 240
		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x94")]
		public float calcMaxWidth;

		// Token: 0x040000F1 RID: 241
		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x98")]
		public float calcMinHeight;

		// Token: 0x040000F2 RID: 242
		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x9C")]
		public float calcMaxHeight;

		// Token: 0x040000F3 RID: 243
		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0xA0")]
		public float clientWidth;

		// Token: 0x040000F4 RID: 244
		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0xA4")]
		public float clientHeight;

		// Token: 0x040000F5 RID: 245
		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0xA8")]
		public bool allowHorizontalScroll;

		// Token: 0x040000F6 RID: 246
		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0xA9")]
		public bool allowVerticalScroll;

		// Token: 0x040000F7 RID: 247
		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0xAA")]
		public bool needsHorizontalScrollbar;

		// Token: 0x040000F8 RID: 248
		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0xAB")]
		public bool needsVerticalScrollbar;

		// Token: 0x040000F9 RID: 249
		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0xB0")]
		public GUIStyle horizontalScrollbar;

		// Token: 0x040000FA RID: 250
		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0xB8")]
		public GUIStyle verticalScrollbar;
	}
}
