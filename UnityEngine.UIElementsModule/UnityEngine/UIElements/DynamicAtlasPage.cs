using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.UIElements.UIR;

namespace UnityEngine.UIElements
{
	// Token: 0x02000206 RID: 518
	[Token(Token = "0x2000206")]
	internal class DynamicAtlasPage : IDisposable
	{
		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000DC7 RID: 3527 RVA: 0x00006D08 File Offset: 0x00004F08
		// (set) Token: 0x06000DC8 RID: 3528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700032C")]
		public TextureId textureId
		{
			[Token(Token = "0x6000DC7")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			[CompilerGenerated]
			get
			{
				return default(TextureId);
			}
			[Token(Token = "0x6000DC8")]
			[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000DC9 RID: 3529 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06000DCA RID: 3530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700032D")]
		public RenderTexture atlas
		{
			[Token(Token = "0x6000DC9")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000DCA")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000DCB RID: 3531 RVA: 0x00006D20 File Offset: 0x00004F20
		[Token(Token = "0x1700032E")]
		public RenderTextureFormat format
		{
			[Token(Token = "0x6000DCB")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
			[CompilerGenerated]
			get
			{
				return RenderTextureFormat.ARGB32;
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000DCC RID: 3532 RVA: 0x00006D38 File Offset: 0x00004F38
		[Token(Token = "0x1700032F")]
		public FilterMode filterMode
		{
			[Token(Token = "0x6000DCC")]
			[Address(RVA = "0x4F6200", Offset = "0x4F4E00", VA = "0x1804F6200")]
			[CompilerGenerated]
			get
			{
				return FilterMode.Point;
			}
		}

		// Token: 0x06000DCD RID: 3533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DCD")]
		[Address(RVA = "0x5B06960", Offset = "0x5B05560", VA = "0x185B06960")]
		public DynamicAtlasPage(RenderTextureFormat format, FilterMode filterMode, Vector2Int minSize, Vector2Int maxSize)
		{
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000DCE RID: 3534 RVA: 0x00006D50 File Offset: 0x00004F50
		// (set) Token: 0x06000DCF RID: 3535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000330")]
		private protected bool disposed
		{
			[Token(Token = "0x6000DCE")]
			[Address(RVA = "0x6DF210", Offset = "0x6DDE10", VA = "0x1806DF210")]
			[CompilerGenerated]
			protected get
			{
				return default(bool);
			}
			[Token(Token = "0x6000DCF")]
			[Address(RVA = "0xC97C20", Offset = "0xC96820", VA = "0x180C97C20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000DD0 RID: 3536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DD0")]
		[Address(RVA = "0x5B05F10", Offset = "0x5B04B10", VA = "0x185B05F10", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06000DD1 RID: 3537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DD1")]
		[Address(RVA = "0x5B05D30", Offset = "0x5B04930", VA = "0x185B05D30", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x06000DD2 RID: 3538 RVA: 0x00006D68 File Offset: 0x00004F68
		[Token(Token = "0x6000DD2")]
		[Address(RVA = "0x5B06060", Offset = "0x5B04C60", VA = "0x185B06060")]
		public bool TryAdd(Texture2D image, out Allocator2D.Alloc2D alloc, out RectInt rect)
		{
			return default(bool);
		}

		// Token: 0x06000DD3 RID: 3539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DD3")]
		[Address(RVA = "0x5B06770", Offset = "0x5B05370", VA = "0x185B06770")]
		public void Update(Texture2D image, RectInt rect)
		{
		}

		// Token: 0x06000DD4 RID: 3540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DD4")]
		[Address(RVA = "0x5B05F80", Offset = "0x5B04B80", VA = "0x185B05F80")]
		public void Remove(Allocator2D.Alloc2D alloc)
		{
		}

		// Token: 0x06000DD5 RID: 3541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DD5")]
		[Address(RVA = "0x5B05BC0", Offset = "0x5B047C0", VA = "0x185B05BC0")]
		public void Commit()
		{
		}

		// Token: 0x06000DD6 RID: 3542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DD6")]
		[Address(RVA = "0x5B062D0", Offset = "0x5B04ED0", VA = "0x185B062D0")]
		private void UpdateAtlasTexture()
		{
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000DD7")]
		[Address(RVA = "0x5B05C00", Offset = "0x5B04800", VA = "0x185B05C00")]
		private RenderTexture CreateAtlasTexture()
		{
			return null;
		}

		// Token: 0x04000726 RID: 1830
		[Token(Token = "0x4000726")]
		[FieldOffset(Offset = "0x38")]
		private readonly int m_1Padding;

		// Token: 0x04000727 RID: 1831
		[Token(Token = "0x4000727")]
		[FieldOffset(Offset = "0x3C")]
		private readonly int m_2Padding;

		// Token: 0x04000728 RID: 1832
		[Token(Token = "0x4000728")]
		[FieldOffset(Offset = "0x40")]
		private Allocator2D m_Allocator;

		// Token: 0x04000729 RID: 1833
		[Token(Token = "0x4000729")]
		[FieldOffset(Offset = "0x48")]
		private TextureBlitter m_Blitter;

		// Token: 0x0400072A RID: 1834
		[Token(Token = "0x400072A")]
		[FieldOffset(Offset = "0x50")]
		private Vector2Int m_CurrentSize;

		// Token: 0x0400072B RID: 1835
		[Token(Token = "0x400072B")]
		[FieldOffset(Offset = "0x0")]
		private static int s_TextureCounter;
	}
}
