using System;
using Il2CppDummyDll;

namespace BestHTTP.Decompression.Zlib
{
	// Token: 0x020004FB RID: 1275
	[Token(Token = "0x20004FB")]
	internal sealed class StaticTree
	{
		// Token: 0x060029F1 RID: 10737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029F1")]
		[Address(RVA = "0x53C5600", Offset = "0x53C4200", VA = "0x1853C5600")]
		private StaticTree(short[] treeCodes, int[] extraBits, int extraBase, int elems, int maxLength)
		{
		}

		// Token: 0x040017C7 RID: 6087
		[Token(Token = "0x40017C7")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly short[] lengthAndLiteralsTreeCodes;

		// Token: 0x040017C8 RID: 6088
		[Token(Token = "0x40017C8")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly short[] distTreeCodes;

		// Token: 0x040017C9 RID: 6089
		[Token(Token = "0x40017C9")]
		[FieldOffset(Offset = "0x10")]
		internal static readonly StaticTree Literals;

		// Token: 0x040017CA RID: 6090
		[Token(Token = "0x40017CA")]
		[FieldOffset(Offset = "0x18")]
		internal static readonly StaticTree Distances;

		// Token: 0x040017CB RID: 6091
		[Token(Token = "0x40017CB")]
		[FieldOffset(Offset = "0x20")]
		internal static readonly StaticTree BitLengths;

		// Token: 0x040017CC RID: 6092
		[Token(Token = "0x40017CC")]
		[FieldOffset(Offset = "0x10")]
		internal short[] treeCodes;

		// Token: 0x040017CD RID: 6093
		[Token(Token = "0x40017CD")]
		[FieldOffset(Offset = "0x18")]
		internal int[] extraBits;

		// Token: 0x040017CE RID: 6094
		[Token(Token = "0x40017CE")]
		[FieldOffset(Offset = "0x20")]
		internal int extraBase;

		// Token: 0x040017CF RID: 6095
		[Token(Token = "0x40017CF")]
		[FieldOffset(Offset = "0x24")]
		internal int elems;

		// Token: 0x040017D0 RID: 6096
		[Token(Token = "0x40017D0")]
		[FieldOffset(Offset = "0x28")]
		internal int maxLength;
	}
}
