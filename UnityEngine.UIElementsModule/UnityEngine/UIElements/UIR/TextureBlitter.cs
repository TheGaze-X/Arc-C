using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Profiling;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x020002B5 RID: 693
	[Token(Token = "0x20002B5")]
	internal class TextureBlitter : IDisposable
	{
		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x060012EC RID: 4844 RVA: 0x00009F48 File Offset: 0x00008148
		// (set) Token: 0x060012ED RID: 4845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004A9")]
		private protected bool disposed
		{
			[Token(Token = "0x60012EC")]
			[Address(RVA = "0x16647A0", Offset = "0x16633A0", VA = "0x1816647A0")]
			[CompilerGenerated]
			protected get
			{
				return default(bool);
			}
			[Token(Token = "0x60012ED")]
			[Address(RVA = "0x16647B0", Offset = "0x16633B0", VA = "0x1816647B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060012EE RID: 4846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012EE")]
		[Address(RVA = "0x5A5AC20", Offset = "0x5A59820", VA = "0x185A5AC20", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x060012EF RID: 4847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012EF")]
		[Address(RVA = "0x5A5AC90", Offset = "0x5A59890", VA = "0x185A5AC90", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x060012F1 RID: 4849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012F1")]
		[Address(RVA = "0x5A5B7C0", Offset = "0x5A5A3C0", VA = "0x185A5B7C0")]
		public TextureBlitter(int capacity = 512)
		{
		}

		// Token: 0x060012F2 RID: 4850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012F2")]
		[Address(RVA = "0x5A5B510", Offset = "0x5A5A110", VA = "0x185A5B510")]
		public void QueueBlit(Texture src, RectInt srcRect, Vector2Int dstPos, bool addBorder, Color tint)
		{
		}

		// Token: 0x060012F3 RID: 4851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012F3")]
		[Address(RVA = "0x5A5A980", Offset = "0x5A59580", VA = "0x185A5A980")]
		public void BlitOneNow(RenderTexture dst, Texture src, RectInt srcRect, Vector2Int dstPos, bool addBorder, Color tint)
		{
		}

		// Token: 0x060012F4 RID: 4852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012F4")]
		[Address(RVA = "0x5A5AAB0", Offset = "0x5A596B0", VA = "0x185A5AAB0")]
		public void Commit(RenderTexture dst)
		{
		}

		// Token: 0x060012F5 RID: 4853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012F5")]
		[Address(RVA = "0x5A5A700", Offset = "0x5A59300", VA = "0x185A5A700")]
		private void BeginBlit(RenderTexture dst)
		{
		}

		// Token: 0x060012F6 RID: 4854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012F6")]
		[Address(RVA = "0x5A5AD20", Offset = "0x5A59920", VA = "0x185A5AD20")]
		private void DoBlit(IList<TextureBlitter.BlitInfo> blitInfos, int startIndex)
		{
		}

		// Token: 0x060012F7 RID: 4855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012F7")]
		[Address(RVA = "0x5A5B410", Offset = "0x5A5A010", VA = "0x185A5B410")]
		private void EndBlit()
		{
		}

		// Token: 0x04000A75 RID: 2677
		[Token(Token = "0x4000A75")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int[] k_TextureIds;

		// Token: 0x04000A76 RID: 2678
		[Token(Token = "0x4000A76")]
		[FieldOffset(Offset = "0x8")]
		private static ProfilerMarker s_CommitSampler;

		// Token: 0x04000A77 RID: 2679
		[Token(Token = "0x4000A77")]
		[FieldOffset(Offset = "0x10")]
		private TextureBlitter.BlitInfo[] m_SingleBlit;

		// Token: 0x04000A78 RID: 2680
		[Token(Token = "0x4000A78")]
		[FieldOffset(Offset = "0x18")]
		private Material m_BlitMaterial;

		// Token: 0x04000A79 RID: 2681
		[Token(Token = "0x4000A79")]
		[FieldOffset(Offset = "0x20")]
		private MaterialPropertyBlock m_Properties;

		// Token: 0x04000A7A RID: 2682
		[Token(Token = "0x4000A7A")]
		[FieldOffset(Offset = "0x28")]
		private RectInt m_Viewport;

		// Token: 0x04000A7B RID: 2683
		[Token(Token = "0x4000A7B")]
		[FieldOffset(Offset = "0x38")]
		private RenderTexture m_PrevRT;

		// Token: 0x04000A7C RID: 2684
		[Token(Token = "0x4000A7C")]
		[FieldOffset(Offset = "0x40")]
		private List<TextureBlitter.BlitInfo> m_PendingBlits;

		// Token: 0x020002B6 RID: 694
		[Token(Token = "0x20002B6")]
		private struct BlitInfo
		{
			// Token: 0x04000A7E RID: 2686
			[Token(Token = "0x4000A7E")]
			[FieldOffset(Offset = "0x0")]
			public Texture src;

			// Token: 0x04000A7F RID: 2687
			[Token(Token = "0x4000A7F")]
			[FieldOffset(Offset = "0x8")]
			public RectInt srcRect;

			// Token: 0x04000A80 RID: 2688
			[Token(Token = "0x4000A80")]
			[FieldOffset(Offset = "0x18")]
			public Vector2Int dstPos;

			// Token: 0x04000A81 RID: 2689
			[Token(Token = "0x4000A81")]
			[FieldOffset(Offset = "0x20")]
			public int border;

			// Token: 0x04000A82 RID: 2690
			[Token(Token = "0x4000A82")]
			[FieldOffset(Offset = "0x24")]
			public Color tint;
		}
	}
}
