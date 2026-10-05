using System;
using Il2CppDummyDll;

namespace Spine
{
	// Token: 0x0200003A RID: 58
	[Token(Token = "0x200003A")]
	public abstract class VertexAttachment : Attachment
	{
		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060001EF RID: 495 RVA: 0x00002BAC File Offset: 0x00000DAC
		[Token(Token = "0x17000094")]
		public int Id
		{
			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x00002096 File Offset: 0x00000296
		// (set) Token: 0x060001F1 RID: 497 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000095")]
		public int[] Bones
		{
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			set
			{
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x00002096 File Offset: 0x00000296
		// (set) Token: 0x060001F3 RID: 499 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000096")]
		public float[] Vertices
		{
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
			set
			{
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x00002BC4 File Offset: 0x00000DC4
		// (set) Token: 0x060001F5 RID: 501 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000097")]
		public int WorldVerticesLength
		{
			[Token(Token = "0x60001F4")]
			[Address(RVA = "0xC91700", Offset = "0xC90300", VA = "0x180C91700")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60001F5")]
			[Address(RVA = "0xF82EE0", Offset = "0xF81AE0", VA = "0x180F82EE0")]
			set
			{
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x00002096 File Offset: 0x00000296
		// (set) Token: 0x060001F7 RID: 503 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000098")]
		public VertexAttachment DeformAttachment
		{
			[Token(Token = "0x60001F6")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x4EA990", Offset = "0x4E9590", VA = "0x1804EA990")]
			set
			{
			}
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x4E5E890", Offset = "0x4E5D490", VA = "0x184E5E890")]
		public VertexAttachment(string name)
		{
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x4E5E680", Offset = "0x4E5D280", VA = "0x184E5E680")]
		public void ComputeWorldVertices(Slot slot, float[] worldVertices)
		{
		}

		// Token: 0x060001FA RID: 506 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x4E5E190", Offset = "0x4E5CD90", VA = "0x184E5E190")]
		public void ComputeWorldVertices(Slot slot, int start, int count, float[] worldVertices, int offset, int stride = 2)
		{
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x4E5E6B0", Offset = "0x4E5D2B0", VA = "0x184E5E6B0")]
		internal void CopyTo(VertexAttachment attachment)
		{
		}

		// Token: 0x04000168 RID: 360
		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0x0")]
		private static int nextID;

		// Token: 0x04000169 RID: 361
		[Token(Token = "0x4000169")]
		[FieldOffset(Offset = "0x8")]
		private static readonly object nextIdLock;

		// Token: 0x0400016A RID: 362
		[Token(Token = "0x400016A")]
		[FieldOffset(Offset = "0x18")]
		internal readonly int id;

		// Token: 0x0400016B RID: 363
		[Token(Token = "0x400016B")]
		[FieldOffset(Offset = "0x20")]
		internal int[] bones;

		// Token: 0x0400016C RID: 364
		[Token(Token = "0x400016C")]
		[FieldOffset(Offset = "0x28")]
		internal float[] vertices;

		// Token: 0x0400016D RID: 365
		[Token(Token = "0x400016D")]
		[FieldOffset(Offset = "0x30")]
		internal int worldVerticesLength;

		// Token: 0x0400016E RID: 366
		[Token(Token = "0x400016E")]
		[FieldOffset(Offset = "0x38")]
		internal VertexAttachment deformAttachment;
	}
}
