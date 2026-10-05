using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.UIElements.UIR;

namespace UnityEngine.UIElements
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	internal class DynamicAtlas : AtlasBase
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000013 RID: 19 RVA: 0x0000209C File Offset: 0x0000029C
		[Token(Token = "0x17000001")]
		internal bool isInitialized
		{
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x5A2D3F0", Offset = "0x5A2BFF0", VA = "0x185A2D3F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x5A2C820", Offset = "0x5A2B420", VA = "0x185A2C820", Slot = "7")]
		protected override void OnAssignedToPanel(IPanel panel)
		{
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x5A2C8A0", Offset = "0x5A2B4A0", VA = "0x185A2C8A0", Slot = "8")]
		protected override void OnRemovedFromPanel(IPanel panel)
		{
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x5A2C9B0", Offset = "0x5A2B5B0", VA = "0x185A2C9B0", Slot = "6")]
		public override void Reset()
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x5A2C4B0", Offset = "0x5A2B0B0", VA = "0x185A2C4B0")]
		private void InitPages()
		{
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x5A2C410", Offset = "0x5A2B010", VA = "0x185A2C410")]
		private void DestroyPages()
		{
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000020B4 File Offset: 0x000002B4
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x5A2CCF0", Offset = "0x5A2B8F0", VA = "0x185A2CCF0", Slot = "4")]
		public override bool TryGetAtlas(VisualElement ve, Texture2D src, out TextureId atlas, out RectInt atlasRect)
		{
			return default(bool);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x5A2CBA0", Offset = "0x5A2B7A0", VA = "0x185A2CBA0", Slot = "5")]
		public override void ReturnAtlas(VisualElement ve, Texture2D src, TextureId atlas)
		{
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x5A2C930", Offset = "0x5A2B530", VA = "0x185A2C930", Slot = "9")]
		protected override void OnUpdateDynamicTextures(IPanel panel)
		{
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000020CC File Offset: 0x000002CC
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x5A2C5E0", Offset = "0x5A2B1E0", VA = "0x185A2C5E0")]
		internal static bool IsTextureFormatSupported(TextureFormat format)
		{
			return default(bool);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000020E4 File Offset: 0x000002E4
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x5A2C660", Offset = "0x5A2B260", VA = "0x185A2C660", Slot = "10")]
		public virtual bool IsTextureValid(Texture2D texture, FilterMode atlasFilterMode)
		{
			return default(bool);
		}

		// Token: 0x17000002 RID: 2
		// (set) Token: 0x0600001E RID: 30 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000002")]
		public int minAtlasSize
		{
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x5A2D570", Offset = "0x5A2C170", VA = "0x185A2D570")]
			set
			{
			}
		}

		// Token: 0x17000003 RID: 3
		// (set) Token: 0x0600001F RID: 31 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000003")]
		public int maxAtlasSize
		{
			[Token(Token = "0x600001F")]
			[Address(RVA = "0x5A2D4D0", Offset = "0x5A2C0D0", VA = "0x185A2D4D0")]
			set
			{
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000020 RID: 32 RVA: 0x000020FC File Offset: 0x000002FC
		[Token(Token = "0x17000004")]
		public static DynamicAtlasFilters defaultFilters
		{
			[Token(Token = "0x6000020")]
			[Address(RVA = "0x5000DB0", Offset = "0x4FFF9B0", VA = "0x185000DB0")]
			get
			{
				return DynamicAtlasFilters.None;
			}
		}

		// Token: 0x17000005 RID: 5
		// (set) Token: 0x06000021 RID: 33 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000005")]
		public DynamicAtlasFilters activeFilters
		{
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x5A2D410", Offset = "0x5A2C010", VA = "0x185A2D410")]
			set
			{
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00002114 File Offset: 0x00000314
		// (set) Token: 0x06000023 RID: 35 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000006")]
		public int maxSubTextureSize
		{
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x59F2270", Offset = "0x59F0E70", VA = "0x1859F2270")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x5A2D520", Offset = "0x5A2C120", VA = "0x185A2D520")]
			set
			{
			}
		}

		// Token: 0x17000007 RID: 7
		// (set) Token: 0x06000024 RID: 36 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000007")]
		public DynamicAtlasCustomFilter customFilter
		{
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x5A2D460", Offset = "0x5A2C060", VA = "0x185A2D460")]
			set
			{
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x5A2D270", Offset = "0x5A2BE70", VA = "0x185A2D270")]
		public DynamicAtlas()
		{
		}

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<Texture, DynamicAtlas.TextureInfo> m_Database;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x20")]
		private DynamicAtlasPage m_PointPage;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x28")]
		private DynamicAtlasPage m_BilinearPage;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x30")]
		private ColorSpace m_ColorSpace;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x38")]
		private List<IPanel> m_Panels;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x40")]
		private int m_MinAtlasSize;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x44")]
		private int m_MaxAtlasSize;

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x48")]
		private int m_MaxSubTextureSize;

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x4C")]
		private DynamicAtlasFilters m_ActiveFilters;

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x50")]
		private DynamicAtlasCustomFilter m_CustomFilter;

		// Token: 0x02000009 RID: 9
		[Token(Token = "0x2000009")]
		private class TextureInfo : LinkedPoolItem<DynamicAtlas.TextureInfo>
		{
			// Token: 0x06000026 RID: 38 RVA: 0x0000212A File Offset: 0x0000032A
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x5A3B590", Offset = "0x5A3A190", VA = "0x185A3B590")]
			[MethodImpl(256)]
			private static DynamicAtlas.TextureInfo Create()
			{
				return null;
			}

			// Token: 0x06000027 RID: 39 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x5A3B600", Offset = "0x5A3A200", VA = "0x185A3B600")]
			[MethodImpl(256)]
			private static void Reset(DynamicAtlas.TextureInfo info)
			{
			}

			// Token: 0x06000028 RID: 40 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x5A3B790", Offset = "0x5A3A390", VA = "0x185A3B790")]
			public TextureInfo()
			{
			}

			// Token: 0x04000013 RID: 19
			[Token(Token = "0x4000013")]
			[FieldOffset(Offset = "0x18")]
			public DynamicAtlasPage page;

			// Token: 0x04000014 RID: 20
			[Token(Token = "0x4000014")]
			[FieldOffset(Offset = "0x20")]
			public int counter;

			// Token: 0x04000015 RID: 21
			[Token(Token = "0x4000015")]
			[FieldOffset(Offset = "0x28")]
			public Allocator2D.Alloc2D alloc;

			// Token: 0x04000016 RID: 22
			[Token(Token = "0x4000016")]
			[FieldOffset(Offset = "0x58")]
			public RectInt rect;

			// Token: 0x04000017 RID: 23
			[Token(Token = "0x4000017")]
			[FieldOffset(Offset = "0x0")]
			public static readonly LinkedPool<DynamicAtlas.TextureInfo> pool;
		}
	}
}
