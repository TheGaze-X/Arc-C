using System;
using Il2CppDummyDll;

namespace BestHTTP.Decompression.Zlib
{
	// Token: 0x020004F0 RID: 1264
	[Token(Token = "0x20004F0")]
	internal sealed class InflateCodes
	{
		// Token: 0x060029D2 RID: 10706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029D2")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		internal InflateCodes()
		{
		}

		// Token: 0x060029D3 RID: 10707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029D3")]
		[Address(RVA = "0x53C3110", Offset = "0x53C1D10", VA = "0x1853C3110")]
		internal void Init(int bl, int bd, int[] tl, int tl_index, int[] td, int td_index)
		{
		}

		// Token: 0x060029D4 RID: 10708 RVA: 0x00011BB0 File Offset: 0x0000FDB0
		[Token(Token = "0x60029D4")]
		[Address(RVA = "0x53C3170", Offset = "0x53C1D70", VA = "0x1853C3170")]
		internal int Process(InflateBlocks blocks, int r)
		{
			return 0;
		}

		// Token: 0x060029D5 RID: 10709 RVA: 0x00011BC8 File Offset: 0x0000FDC8
		[Token(Token = "0x60029D5")]
		[Address(RVA = "0x53C27E0", Offset = "0x53C13E0", VA = "0x1853C27E0")]
		internal int InflateFast(int bl, int bd, int[] tl, int tl_index, int[] td, int td_index, InflateBlocks s, ZlibCodec z)
		{
			return 0;
		}

		// Token: 0x04001755 RID: 5973
		[Token(Token = "0x4001755")]
		private const int START = 0;

		// Token: 0x04001756 RID: 5974
		[Token(Token = "0x4001756")]
		private const int LEN = 1;

		// Token: 0x04001757 RID: 5975
		[Token(Token = "0x4001757")]
		private const int LENEXT = 2;

		// Token: 0x04001758 RID: 5976
		[Token(Token = "0x4001758")]
		private const int DIST = 3;

		// Token: 0x04001759 RID: 5977
		[Token(Token = "0x4001759")]
		private const int DISTEXT = 4;

		// Token: 0x0400175A RID: 5978
		[Token(Token = "0x400175A")]
		private const int COPY = 5;

		// Token: 0x0400175B RID: 5979
		[Token(Token = "0x400175B")]
		private const int LIT = 6;

		// Token: 0x0400175C RID: 5980
		[Token(Token = "0x400175C")]
		private const int WASH = 7;

		// Token: 0x0400175D RID: 5981
		[Token(Token = "0x400175D")]
		private const int END = 8;

		// Token: 0x0400175E RID: 5982
		[Token(Token = "0x400175E")]
		private const int BADCODE = 9;

		// Token: 0x0400175F RID: 5983
		[Token(Token = "0x400175F")]
		[FieldOffset(Offset = "0x10")]
		internal int mode;

		// Token: 0x04001760 RID: 5984
		[Token(Token = "0x4001760")]
		[FieldOffset(Offset = "0x14")]
		internal int len;

		// Token: 0x04001761 RID: 5985
		[Token(Token = "0x4001761")]
		[FieldOffset(Offset = "0x18")]
		internal int[] tree;

		// Token: 0x04001762 RID: 5986
		[Token(Token = "0x4001762")]
		[FieldOffset(Offset = "0x20")]
		internal int tree_index;

		// Token: 0x04001763 RID: 5987
		[Token(Token = "0x4001763")]
		[FieldOffset(Offset = "0x24")]
		internal int need;

		// Token: 0x04001764 RID: 5988
		[Token(Token = "0x4001764")]
		[FieldOffset(Offset = "0x28")]
		internal int lit;

		// Token: 0x04001765 RID: 5989
		[Token(Token = "0x4001765")]
		[FieldOffset(Offset = "0x2C")]
		internal int bitsToGet;

		// Token: 0x04001766 RID: 5990
		[Token(Token = "0x4001766")]
		[FieldOffset(Offset = "0x30")]
		internal int dist;

		// Token: 0x04001767 RID: 5991
		[Token(Token = "0x4001767")]
		[FieldOffset(Offset = "0x34")]
		internal byte lbits;

		// Token: 0x04001768 RID: 5992
		[Token(Token = "0x4001768")]
		[FieldOffset(Offset = "0x35")]
		internal byte dbits;

		// Token: 0x04001769 RID: 5993
		[Token(Token = "0x4001769")]
		[FieldOffset(Offset = "0x38")]
		internal int[] ltree;

		// Token: 0x0400176A RID: 5994
		[Token(Token = "0x400176A")]
		[FieldOffset(Offset = "0x40")]
		internal int ltree_index;

		// Token: 0x0400176B RID: 5995
		[Token(Token = "0x400176B")]
		[FieldOffset(Offset = "0x48")]
		internal int[] dtree;

		// Token: 0x0400176C RID: 5996
		[Token(Token = "0x400176C")]
		[FieldOffset(Offset = "0x50")]
		internal int dtree_index;
	}
}
