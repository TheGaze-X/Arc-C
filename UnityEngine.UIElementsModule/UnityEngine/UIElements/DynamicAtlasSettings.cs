using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020001F7 RID: 503
	[Token(Token = "0x20001F7")]
	[Serializable]
	public class DynamicAtlasSettings
	{
		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000D24 RID: 3364 RVA: 0x000068B8 File Offset: 0x00004AB8
		// (set) Token: 0x06000D25 RID: 3365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002FC")]
		public int minAtlasSize
		{
			[Token(Token = "0x6000D24")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000D25")]
			[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
			set
			{
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000D26 RID: 3366 RVA: 0x000068D0 File Offset: 0x00004AD0
		// (set) Token: 0x06000D27 RID: 3367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002FD")]
		public int maxAtlasSize
		{
			[Token(Token = "0x6000D26")]
			[Address(RVA = "0x4EEB30", Offset = "0x4ED730", VA = "0x1804EEB30")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000D27")]
			[Address(RVA = "0x4EEB40", Offset = "0x4ED740", VA = "0x1804EEB40")]
			set
			{
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000D28 RID: 3368 RVA: 0x000068E8 File Offset: 0x00004AE8
		// (set) Token: 0x06000D29 RID: 3369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002FE")]
		public int maxSubTextureSize
		{
			[Token(Token = "0x6000D28")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000D29")]
			[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0")]
			set
			{
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000D2A RID: 3370 RVA: 0x00006900 File Offset: 0x00004B00
		// (set) Token: 0x06000D2B RID: 3371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002FF")]
		public DynamicAtlasFilters activeFilters
		{
			[Token(Token = "0x6000D2A")]
			[Address(RVA = "0x4EA880", Offset = "0x4E9480", VA = "0x1804EA880")]
			get
			{
				return DynamicAtlasFilters.None;
			}
			[Token(Token = "0x6000D2B")]
			[Address(RVA = "0x4EAC10", Offset = "0x4E9810", VA = "0x1804EAC10")]
			set
			{
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000D2C RID: 3372 RVA: 0x00006918 File Offset: 0x00004B18
		[Token(Token = "0x17000300")]
		public static DynamicAtlasFilters defaultFilters
		{
			[Token(Token = "0x6000D2C")]
			[Address(RVA = "0x5B06AF0", Offset = "0x5B056F0", VA = "0x185B06AF0")]
			get
			{
				return DynamicAtlasFilters.None;
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000D2D RID: 3373 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06000D2E RID: 3374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000301")]
		public DynamicAtlasCustomFilter customFilter
		{
			[Token(Token = "0x6000D2D")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D2E")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			set
			{
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000D2F RID: 3375 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000302")]
		public static DynamicAtlasSettings defaults
		{
			[Token(Token = "0x6000D2F")]
			[Address(RVA = "0x5B06B00", Offset = "0x5B05700", VA = "0x185B06B00")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000D30 RID: 3376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D30")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public DynamicAtlasSettings()
		{
		}

		// Token: 0x040006BE RID: 1726
		[Token(Token = "0x40006BE")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[HideInInspector]
		private int m_MinAtlasSize;

		// Token: 0x040006BF RID: 1727
		[Token(Token = "0x40006BF")]
		[FieldOffset(Offset = "0x14")]
		[HideInInspector]
		[SerializeField]
		private int m_MaxAtlasSize;

		// Token: 0x040006C0 RID: 1728
		[Token(Token = "0x40006C0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[HideInInspector]
		private int m_MaxSubTextureSize;

		// Token: 0x040006C1 RID: 1729
		[Token(Token = "0x40006C1")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[HideInInspector]
		private DynamicAtlasFiltersInternal m_ActiveFilters;

		// Token: 0x040006C2 RID: 1730
		[Token(Token = "0x40006C2")]
		[FieldOffset(Offset = "0x20")]
		private DynamicAtlasCustomFilter m_CustomFilter;
	}
}
