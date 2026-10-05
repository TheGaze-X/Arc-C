using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Profiling;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x02000295 RID: 661
	[Token(Token = "0x2000295")]
	internal class GradientSettingsAtlas : IDisposable
	{
		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06001231 RID: 4657 RVA: 0x00009C60 File Offset: 0x00007E60
		[Token(Token = "0x17000496")]
		internal int length
		{
			[Token(Token = "0x6001231")]
			[Address(RVA = "0x592C450", Offset = "0x592B050", VA = "0x18592C450")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06001232 RID: 4658 RVA: 0x00009C78 File Offset: 0x00007E78
		// (set) Token: 0x06001233 RID: 4659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000497")]
		private protected bool disposed
		{
			[Token(Token = "0x6001232")]
			[Address(RVA = "0x4FD4C0", Offset = "0x4FC0C0", VA = "0x1804FD4C0")]
			[CompilerGenerated]
			protected get
			{
				return default(bool);
			}
			[Token(Token = "0x6001233")]
			[Address(RVA = "0x14D9990", Offset = "0x14D8590", VA = "0x1814D9990")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001234 RID: 4660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001234")]
		[Address(RVA = "0x5B34670", Offset = "0x5B33270", VA = "0x185B34670", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06001235 RID: 4661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001235")]
		[Address(RVA = "0x5B346E0", Offset = "0x5B332E0", VA = "0x185B346E0", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001236")]
		[Address(RVA = "0x5B34F80", Offset = "0x5B33B80", VA = "0x185B34F80")]
		public GradientSettingsAtlas(int length = 4096)
		{
		}

		// Token: 0x06001237 RID: 4663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001237")]
		[Address(RVA = "0x5B348C0", Offset = "0x5B334C0", VA = "0x185B348C0")]
		public void Reset()
		{
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06001238 RID: 4664 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000498")]
		public Texture2D atlas
		{
			[Token(Token = "0x6001238")]
			[Address(RVA = "0x5911BE0", Offset = "0x59107E0", VA = "0x185911BE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001239 RID: 4665 RVA: 0x00009C90 File Offset: 0x00007E90
		[Token(Token = "0x6001239")]
		[Address(RVA = "0x5B34360", Offset = "0x5B32F60", VA = "0x185B34360")]
		public Alloc Add(int count)
		{
			return default(Alloc);
		}

		// Token: 0x0600123A RID: 4666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600123A")]
		[Address(RVA = "0x5B34990", Offset = "0x5B33590", VA = "0x185B34990")]
		public void Write(Alloc alloc, GradientSettings[] settings, GradientRemap remap)
		{
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x0600123B RID: 4667 RVA: 0x00009CA8 File Offset: 0x00007EA8
		// (set) Token: 0x0600123C RID: 4668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000499")]
		public bool MustCommit
		{
			[Token(Token = "0x600123B")]
			[Address(RVA = "0x4FD480", Offset = "0x4FC080", VA = "0x1804FD480")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600123C")]
			[Address(RVA = "0x3249520", Offset = "0x3248120", VA = "0x183249520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600123D RID: 4669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600123D")]
		[Address(RVA = "0x5B34440", Offset = "0x5B33040", VA = "0x185B34440")]
		public void Commit()
		{
		}

		// Token: 0x0600123E RID: 4670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600123E")]
		[Address(RVA = "0x5B34750", Offset = "0x5B33350", VA = "0x185B34750")]
		private void PrepareAtlas()
		{
		}

		// Token: 0x04000983 RID: 2435
		[Token(Token = "0x4000983")]
		[FieldOffset(Offset = "0x0")]
		private static ProfilerMarker s_MarkerWrite;

		// Token: 0x04000984 RID: 2436
		[Token(Token = "0x4000984")]
		[FieldOffset(Offset = "0x8")]
		private static ProfilerMarker s_MarkerCommit;

		// Token: 0x04000985 RID: 2437
		[Token(Token = "0x4000985")]
		[FieldOffset(Offset = "0x10")]
		private readonly int m_Length;

		// Token: 0x04000986 RID: 2438
		[Token(Token = "0x4000986")]
		[FieldOffset(Offset = "0x14")]
		private readonly int m_ElemWidth;

		// Token: 0x04000987 RID: 2439
		[Token(Token = "0x4000987")]
		[FieldOffset(Offset = "0x18")]
		private BestFitAllocator m_Allocator;

		// Token: 0x04000988 RID: 2440
		[Token(Token = "0x4000988")]
		[FieldOffset(Offset = "0x20")]
		private Texture2D m_Atlas;

		// Token: 0x04000989 RID: 2441
		[Token(Token = "0x4000989")]
		[FieldOffset(Offset = "0x28")]
		private GradientSettingsAtlas.RawTexture m_RawAtlas;

		// Token: 0x0400098A RID: 2442
		[Token(Token = "0x400098A")]
		[FieldOffset(Offset = "0x10")]
		private static int s_TextureCounter;

		// Token: 0x02000296 RID: 662
		[Token(Token = "0x2000296")]
		private struct RawTexture
		{
			// Token: 0x06001240 RID: 4672 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001240")]
			[Address(RVA = "0x5B3D0F0", Offset = "0x5B3BCF0", VA = "0x185B3D0F0")]
			public void WriteRawInt2Packed(int v0, int v1, int destX, int destY)
			{
			}

			// Token: 0x06001241 RID: 4673 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001241")]
			[Address(RVA = "0x5B3D040", Offset = "0x5B3BC40", VA = "0x185B3D040")]
			public void WriteRawFloat4Packed(float f0, float f1, float f2, float f3, int destX, int destY)
			{
			}

			// Token: 0x0400098D RID: 2445
			[Token(Token = "0x400098D")]
			[FieldOffset(Offset = "0x0")]
			public Color32[] rgba;

			// Token: 0x0400098E RID: 2446
			[Token(Token = "0x400098E")]
			[FieldOffset(Offset = "0x8")]
			public int width;

			// Token: 0x0400098F RID: 2447
			[Token(Token = "0x400098F")]
			[FieldOffset(Offset = "0xC")]
			public int height;
		}
	}
}
