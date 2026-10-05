using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000061 RID: 97
	[Token(Token = "0x2000061")]
	internal struct Spacing
	{
		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000259 RID: 601 RVA: 0x00002DA8 File Offset: 0x00000FA8
		[Token(Token = "0x1700008A")]
		public float horizontal
		{
			[Token(Token = "0x6000259")]
			[Address(RVA = "0x59389D0", Offset = "0x59375D0", VA = "0x1859389D0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x0600025A RID: 602 RVA: 0x00002DC0 File Offset: 0x00000FC0
		[Token(Token = "0x1700008B")]
		public float vertical
		{
			[Token(Token = "0x600025A")]
			[Address(RVA = "0x59389E0", Offset = "0x59375E0", VA = "0x1859389E0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025B")]
		[Address(RVA = "0x57C0300", Offset = "0x57BEF00", VA = "0x1857C0300")]
		public Spacing(float left, float top, float right, float bottom)
		{
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00002DD8 File Offset: 0x00000FD8
		[Token(Token = "0x600025C")]
		[Address(RVA = "0x5A3F200", Offset = "0x5A3DE00", VA = "0x185A3F200")]
		public static Rect operator -(Rect r, Spacing a)
		{
			return default(Rect);
		}

		// Token: 0x0400014F RID: 335
		[Token(Token = "0x400014F")]
		[FieldOffset(Offset = "0x0")]
		public float left;

		// Token: 0x04000150 RID: 336
		[Token(Token = "0x4000150")]
		[FieldOffset(Offset = "0x4")]
		public float top;

		// Token: 0x04000151 RID: 337
		[Token(Token = "0x4000151")]
		[FieldOffset(Offset = "0x8")]
		public float right;

		// Token: 0x04000152 RID: 338
		[Token(Token = "0x4000152")]
		[FieldOffset(Offset = "0xC")]
		public float bottom;
	}
}
