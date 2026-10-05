using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Profiling;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x020002AB RID: 683
	[Token(Token = "0x20002AB")]
	internal abstract class BaseShaderInfoStorage : IDisposable
	{
		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x060012B2 RID: 4786
		[Token(Token = "0x170004A6")]
		public abstract Texture2D texture { [Token(Token = "0x60012B2")] get; }

		// Token: 0x060012B3 RID: 4787
		[Token(Token = "0x60012B3")]
		public abstract bool AllocateRect(int width, int height, out RectInt uvs);

		// Token: 0x060012B4 RID: 4788
		[Token(Token = "0x60012B4")]
		public abstract void SetTexel(int x, int y, Color color);

		// Token: 0x060012B5 RID: 4789
		[Token(Token = "0x60012B5")]
		public abstract void UpdateTexture();

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x060012B6 RID: 4790 RVA: 0x00009E40 File Offset: 0x00008040
		// (set) Token: 0x060012B7 RID: 4791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004A7")]
		private protected bool disposed
		{
			[Token(Token = "0x60012B6")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			[CompilerGenerated]
			protected get
			{
				return default(bool);
			}
			[Token(Token = "0x60012B7")]
			[Address(RVA = "0x4E63E0", Offset = "0x4E4FE0", VA = "0x1804E63E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060012B8 RID: 4792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012B8")]
		[Address(RVA = "0x5B33C60", Offset = "0x5B32860", VA = "0x185B33C60", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x060012B9 RID: 4793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012B9")]
		[Address(RVA = "0x4B3B3C0", Offset = "0x4B39FC0", VA = "0x184B3B3C0", Slot = "9")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x060012BA RID: 4794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012BA")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected BaseShaderInfoStorage()
		{
		}

		// Token: 0x04000A4D RID: 2637
		[Token(Token = "0x4000A4D")]
		[FieldOffset(Offset = "0x0")]
		protected static int s_TextureCounter;

		// Token: 0x04000A4E RID: 2638
		[Token(Token = "0x4000A4E")]
		[FieldOffset(Offset = "0x8")]
		internal static ProfilerMarker s_MarkerCopyTexture;

		// Token: 0x04000A4F RID: 2639
		[Token(Token = "0x4000A4F")]
		[FieldOffset(Offset = "0x10")]
		internal static ProfilerMarker s_MarkerGetTextureData;

		// Token: 0x04000A50 RID: 2640
		[Token(Token = "0x4000A50")]
		[FieldOffset(Offset = "0x18")]
		internal static ProfilerMarker s_MarkerUpdateTexture;
	}
}
