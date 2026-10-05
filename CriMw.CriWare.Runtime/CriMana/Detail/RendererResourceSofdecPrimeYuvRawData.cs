using System;
using Il2CppDummyDll;
using UnityEngine;

namespace CriWare.CriMana.Detail
{
	// Token: 0x02000148 RID: 328
	[Token(Token = "0x2000148")]
	public class RendererResourceSofdecPrimeYuvRawData : RendererResource
	{
		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060009ED RID: 2541 RVA: 0x00004C1C File Offset: 0x00002E1C
		[Token(Token = "0x170000D1")]
		private static int NumTextureSets
		{
			[Token(Token = "0x60009ED")]
			[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009EE")]
		[Address(RVA = "0x371C450", Offset = "0x371B050", VA = "0x18371C450")]
		public RendererResourceSofdecPrimeYuvRawData(int playerId, MovieInfo movieInfo, bool additive, Shader userShader)
		{
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009EF")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "7")]
		protected override void OnDisposeManaged()
		{
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009F0")]
		[Address(RVA = "0x371B870", Offset = "0x371A470", VA = "0x18371B870", Slot = "8")]
		protected override void OnDisposeUnmanaged()
		{
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x00004C34 File Offset: 0x00002E34
		[Token(Token = "0x60009F1")]
		[Address(RVA = "0x371B6B0", Offset = "0x371A2B0", VA = "0x18371B6B0", Slot = "9")]
		public override bool IsPrepared()
		{
			return default(bool);
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x00004C4C File Offset: 0x00002E4C
		[Token(Token = "0x60009F2")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "10")]
		public override bool ContinuePreparing()
		{
			return default(bool);
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x00004C64 File Offset: 0x00002E64
		[Token(Token = "0x60009F3")]
		[Address(RVA = "0x371B6C0", Offset = "0x371A2C0", VA = "0x18371B6C0", Slot = "15")]
		public override bool IsSuitable(int playerId, MovieInfo movieInfo, bool additive, Shader userShader)
		{
			return default(bool);
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x00004C7C File Offset: 0x00002E7C
		[Token(Token = "0x60009F4")]
		[Address(RVA = "0x371BA20", Offset = "0x371A620", VA = "0x18371BA20", Slot = "18")]
		public override bool OnPlayerStopForSeek()
		{
			return default(bool);
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x00004C94 File Offset: 0x00002E94
		[Token(Token = "0x60009F5")]
		[Address(RVA = "0x371B6A0", Offset = "0x371A2A0", VA = "0x18371B6A0", Slot = "21")]
		public override bool HasRenderedNewFrame()
		{
			return default(bool);
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009F6")]
		[Address(RVA = "0x371B410", Offset = "0x371A010", VA = "0x18371B410", Slot = "11")]
		public override void AttachToPlayer(int playerId)
		{
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x00004CAC File Offset: 0x00002EAC
		[Token(Token = "0x60009F7")]
		[Address(RVA = "0x371BA40", Offset = "0x371A640", VA = "0x18371BA40", Slot = "12")]
		public override bool UpdateFrame(int playerId, FrameInfo frameInfo, ref bool frameDrop)
		{
			return default(bool);
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x00004CC4 File Offset: 0x00002EC4
		[Token(Token = "0x60009F8")]
		[Address(RVA = "0x371BB50", Offset = "0x371A750", VA = "0x18371BB50", Slot = "13")]
		public override bool UpdateMaterial(Material material)
		{
			return default(bool);
		}

		// Token: 0x060009F9 RID: 2553 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009F9")]
		[Address(RVA = "0x371BE30", Offset = "0x371AA30", VA = "0x18371BE30")]
		private void UpdateMovieTextureST(uint dispWidth, uint dispHeight)
		{
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009FA")]
		[Address(RVA = "0x371BFD0", Offset = "0x371ABD0", VA = "0x18371BFD0", Slot = "14")]
		public override void UpdateTextures()
		{
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009FB")]
		[Address(RVA = "0x371B4F0", Offset = "0x371A0F0", VA = "0x18371B4F0")]
		private static void CalculateTextureSize(ref int w, ref int h, int videoWidth, int videoHeight, CodecType type, bool isChroma)
		{
		}

		// Token: 0x0400060C RID: 1548
		[Token(Token = "0x400060C")]
		[FieldOffset(Offset = "0x30")]
		private int width;

		// Token: 0x0400060D RID: 1549
		[Token(Token = "0x400060D")]
		[FieldOffset(Offset = "0x34")]
		private int height;

		// Token: 0x0400060E RID: 1550
		[Token(Token = "0x400060E")]
		[FieldOffset(Offset = "0x38")]
		private int chromaWidth;

		// Token: 0x0400060F RID: 1551
		[Token(Token = "0x400060F")]
		[FieldOffset(Offset = "0x3C")]
		private int chromaHeight;

		// Token: 0x04000610 RID: 1552
		[Token(Token = "0x4000610")]
		[FieldOffset(Offset = "0x40")]
		private int alphaWidth;

		// Token: 0x04000611 RID: 1553
		[Token(Token = "0x4000611")]
		[FieldOffset(Offset = "0x44")]
		private int alphaHeight;

		// Token: 0x04000612 RID: 1554
		[Token(Token = "0x4000612")]
		[FieldOffset(Offset = "0x48")]
		private bool useUserShader;

		// Token: 0x04000613 RID: 1555
		[Token(Token = "0x4000613")]
		[FieldOffset(Offset = "0x4C")]
		private CodecType codecType;

		// Token: 0x04000614 RID: 1556
		[Token(Token = "0x4000614")]
		[FieldOffset(Offset = "0x50")]
		private Vector4 movieTextureST;

		// Token: 0x04000615 RID: 1557
		[Token(Token = "0x4000615")]
		[FieldOffset(Offset = "0x60")]
		private Vector4 movieChromaTextureST;

		// Token: 0x04000616 RID: 1558
		[Token(Token = "0x4000616")]
		[FieldOffset(Offset = "0x70")]
		private Vector4 movieAlphaTextureST;

		// Token: 0x04000617 RID: 1559
		[Token(Token = "0x4000617")]
		[FieldOffset(Offset = "0x80")]
		private Texture2D[][] textures;

		// Token: 0x04000618 RID: 1560
		[Token(Token = "0x4000618")]
		[FieldOffset(Offset = "0x88")]
		private int currentTextureSet;

		// Token: 0x04000619 RID: 1561
		[Token(Token = "0x4000619")]
		[FieldOffset(Offset = "0x8C")]
		private int drawTextureSet;

		// Token: 0x0400061A RID: 1562
		[Token(Token = "0x400061A")]
		[FieldOffset(Offset = "0x90")]
		private IntPtr[] nativePixels;

		// Token: 0x0400061B RID: 1563
		[Token(Token = "0x400061B")]
		[FieldOffset(Offset = "0x98")]
		private int playerID;

		// Token: 0x0400061C RID: 1564
		[Token(Token = "0x400061C")]
		[FieldOffset(Offset = "0x9C")]
		private bool hasTextureUpdated;

		// Token: 0x0400061D RID: 1565
		[Token(Token = "0x400061D")]
		[FieldOffset(Offset = "0x9D")]
		private bool hasRenderedNewFrame;

		// Token: 0x0400061E RID: 1566
		[Token(Token = "0x400061E")]
		[FieldOffset(Offset = "0x9E")]
		private bool isStoppingForSeek;
	}
}
