using System;
using Il2CppDummyDll;
using Unity.Collections;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x020002AC RID: 684
	[Token(Token = "0x20002AC")]
	internal class ShaderInfoStorage<T> : BaseShaderInfoStorage where T : struct
	{
		// Token: 0x060012BC RID: 4796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012BC")]
		public ShaderInfoStorage(TextureFormat format, Func<Color, T> convert, int initialSize = 64, int maxSize = 4096)
		{
		}

		// Token: 0x060012BD RID: 4797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012BD")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x060012BE RID: 4798 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x170004A8")]
		public override Texture2D texture
		{
			[Token(Token = "0x60012BE")]
			get
			{
				return null;
			}
		}

		// Token: 0x060012BF RID: 4799 RVA: 0x00009E58 File Offset: 0x00008058
		[Token(Token = "0x60012BF")]
		public override bool AllocateRect(int width, int height, out RectInt uvs)
		{
			return default(bool);
		}

		// Token: 0x060012C0 RID: 4800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012C0")]
		public override void SetTexel(int x, int y, Color color)
		{
		}

		// Token: 0x060012C1 RID: 4801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012C1")]
		public override void UpdateTexture()
		{
		}

		// Token: 0x060012C2 RID: 4802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012C2")]
		private void CreateOrExpandTexture()
		{
		}

		// Token: 0x060012C3 RID: 4803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012C3")]
		private static void CpuBlit(NativeArray<T> src, int srcWidth, int srcHeight, NativeArray<T> dst, int dstWidth, int dstHeight)
		{
		}

		// Token: 0x04000A52 RID: 2642
		[Token(Token = "0x4000A52")]
		[FieldOffset(Offset = "0x0")]
		private readonly int m_InitialSize;

		// Token: 0x04000A53 RID: 2643
		[Token(Token = "0x4000A53")]
		[FieldOffset(Offset = "0x0")]
		private readonly int m_MaxSize;

		// Token: 0x04000A54 RID: 2644
		[Token(Token = "0x4000A54")]
		[FieldOffset(Offset = "0x0")]
		private readonly TextureFormat m_Format;

		// Token: 0x04000A55 RID: 2645
		[Token(Token = "0x4000A55")]
		[FieldOffset(Offset = "0x0")]
		private readonly Func<Color, T> m_Convert;

		// Token: 0x04000A56 RID: 2646
		[Token(Token = "0x4000A56")]
		[FieldOffset(Offset = "0x0")]
		private UIRAtlasAllocator m_Allocator;

		// Token: 0x04000A57 RID: 2647
		[Token(Token = "0x4000A57")]
		[FieldOffset(Offset = "0x0")]
		private Texture2D m_Texture;

		// Token: 0x04000A58 RID: 2648
		[Token(Token = "0x4000A58")]
		[FieldOffset(Offset = "0x0")]
		private NativeArray<T> m_Texels;
	}
}
