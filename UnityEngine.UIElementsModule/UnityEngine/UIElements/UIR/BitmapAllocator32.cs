using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x020002C1 RID: 705
	[Token(Token = "0x20002C1")]
	internal struct BitmapAllocator32
	{
		// Token: 0x0600131E RID: 4894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600131E")]
		[Address(RVA = "0x5A52EF0", Offset = "0x5A51AF0", VA = "0x185A52EF0")]
		public void Construct(int pageHeight, int entryWidth = 1, int entryHeight = 1)
		{
		}

		// Token: 0x0600131F RID: 4895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600131F")]
		[Address(RVA = "0x5A530B0", Offset = "0x5A51CB0", VA = "0x185A530B0")]
		public void ForceFirstAlloc(ushort firstPageX, ushort firstPageY)
		{
		}

		// Token: 0x06001320 RID: 4896 RVA: 0x00009FF0 File Offset: 0x000081F0
		[Token(Token = "0x6001320")]
		[Address(RVA = "0x5A52B00", Offset = "0x5A51700", VA = "0x185A52B00")]
		public BMPAlloc Allocate(BaseShaderInfoStorage storage)
		{
			return default(BMPAlloc);
		}

		// Token: 0x06001321 RID: 4897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001321")]
		[Address(RVA = "0x5A53260", Offset = "0x5A51E60", VA = "0x185A53260")]
		public void Free(BMPAlloc alloc)
		{
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06001322 RID: 4898 RVA: 0x0000A008 File Offset: 0x00008208
		[Token(Token = "0x170004AD")]
		public int entryWidth
		{
			[Token(Token = "0x6001322")]
			[Address(RVA = "0x428FB90", Offset = "0x428E790", VA = "0x18428FB90")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06001323 RID: 4899 RVA: 0x0000A020 File Offset: 0x00008220
		[Token(Token = "0x170004AE")]
		public int entryHeight
		{
			[Token(Token = "0x6001323")]
			[Address(RVA = "0x3E76340", Offset = "0x3E74F40", VA = "0x183E76340")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001324 RID: 4900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001324")]
		[Address(RVA = "0x5A533A0", Offset = "0x5A51FA0", VA = "0x185A533A0")]
		internal void GetAllocPageAtlasLocation(int page, out ushort x, out ushort y)
		{
		}

		// Token: 0x06001325 RID: 4901 RVA: 0x0000A038 File Offset: 0x00008238
		[Token(Token = "0x6001325")]
		[Address(RVA = "0x5A53020", Offset = "0x5A51C20", VA = "0x185A53020")]
		private static byte CountTrailingZeroes(uint val)
		{
			return 0;
		}

		// Token: 0x04000AAD RID: 2733
		[Token(Token = "0x4000AAD")]
		[FieldOffset(Offset = "0x0")]
		private int m_PageHeight;

		// Token: 0x04000AAE RID: 2734
		[Token(Token = "0x4000AAE")]
		[FieldOffset(Offset = "0x8")]
		private List<BitmapAllocator32.Page> m_Pages;

		// Token: 0x04000AAF RID: 2735
		[Token(Token = "0x4000AAF")]
		[FieldOffset(Offset = "0x10")]
		private List<uint> m_AllocMap;

		// Token: 0x04000AB0 RID: 2736
		[Token(Token = "0x4000AB0")]
		[FieldOffset(Offset = "0x18")]
		private int m_EntryWidth;

		// Token: 0x04000AB1 RID: 2737
		[Token(Token = "0x4000AB1")]
		[FieldOffset(Offset = "0x1C")]
		private int m_EntryHeight;

		// Token: 0x020002C2 RID: 706
		[Token(Token = "0x20002C2")]
		private struct Page
		{
			// Token: 0x04000AB2 RID: 2738
			[Token(Token = "0x4000AB2")]
			[FieldOffset(Offset = "0x0")]
			public ushort x;

			// Token: 0x04000AB3 RID: 2739
			[Token(Token = "0x4000AB3")]
			[FieldOffset(Offset = "0x2")]
			public ushort y;

			// Token: 0x04000AB4 RID: 2740
			[Token(Token = "0x4000AB4")]
			[FieldOffset(Offset = "0x4")]
			public int freeSlots;
		}
	}
}
