using System;
using Il2CppDummyDll;

namespace BestHTTP.Decompression.Zlib
{
	// Token: 0x020004ED RID: 1261
	[Token(Token = "0x20004ED")]
	internal sealed class InflateBlocks
	{
		// Token: 0x060029C9 RID: 10697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029C9")]
		[Address(RVA = "0x53C2630", Offset = "0x53C1230", VA = "0x1853C2630")]
		internal InflateBlocks(ZlibCodec codec, object checkfn, int w)
		{
		}

		// Token: 0x060029CA RID: 10698 RVA: 0x00011B50 File Offset: 0x0000FD50
		[Token(Token = "0x60029CA")]
		[Address(RVA = "0x53C2490", Offset = "0x53C1090", VA = "0x1853C2490")]
		internal uint Reset()
		{
			return 0U;
		}

		// Token: 0x060029CB RID: 10699 RVA: 0x00011B68 File Offset: 0x0000FD68
		[Token(Token = "0x60029CB")]
		[Address(RVA = "0x53C0F30", Offset = "0x53BFB30", VA = "0x1853C0F30")]
		internal int Process(int r)
		{
			return 0;
		}

		// Token: 0x060029CC RID: 10700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029CC")]
		[Address(RVA = "0x53C0EF0", Offset = "0x53BFAF0", VA = "0x1853C0EF0")]
		internal void Free()
		{
		}

		// Token: 0x060029CD RID: 10701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029CD")]
		[Address(RVA = "0x53C2540", Offset = "0x53C1140", VA = "0x1853C2540")]
		internal void SetDictionary(byte[] d, int start, int n)
		{
		}

		// Token: 0x060029CE RID: 10702 RVA: 0x00011B80 File Offset: 0x0000FD80
		[Token(Token = "0x60029CE")]
		[Address(RVA = "0x53C2590", Offset = "0x53C1190", VA = "0x1853C2590")]
		internal int SyncPoint()
		{
			return 0;
		}

		// Token: 0x060029CF RID: 10703 RVA: 0x00011B98 File Offset: 0x0000FD98
		[Token(Token = "0x60029CF")]
		[Address(RVA = "0x53C0D60", Offset = "0x53BF960", VA = "0x1853C0D60")]
		internal int Flush(int r)
		{
			return 0;
		}

		// Token: 0x04001733 RID: 5939
		[Token(Token = "0x4001733")]
		private const int MANY = 1440;

		// Token: 0x04001734 RID: 5940
		[Token(Token = "0x4001734")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly int[] border;

		// Token: 0x04001735 RID: 5941
		[Token(Token = "0x4001735")]
		[FieldOffset(Offset = "0x10")]
		private InflateBlocks.InflateBlockMode mode;

		// Token: 0x04001736 RID: 5942
		[Token(Token = "0x4001736")]
		[FieldOffset(Offset = "0x14")]
		internal int left;

		// Token: 0x04001737 RID: 5943
		[Token(Token = "0x4001737")]
		[FieldOffset(Offset = "0x18")]
		internal int table;

		// Token: 0x04001738 RID: 5944
		[Token(Token = "0x4001738")]
		[FieldOffset(Offset = "0x1C")]
		internal int index;

		// Token: 0x04001739 RID: 5945
		[Token(Token = "0x4001739")]
		[FieldOffset(Offset = "0x20")]
		internal int[] blens;

		// Token: 0x0400173A RID: 5946
		[Token(Token = "0x400173A")]
		[FieldOffset(Offset = "0x28")]
		internal int[] bb;

		// Token: 0x0400173B RID: 5947
		[Token(Token = "0x400173B")]
		[FieldOffset(Offset = "0x30")]
		internal int[] tb;

		// Token: 0x0400173C RID: 5948
		[Token(Token = "0x400173C")]
		[FieldOffset(Offset = "0x38")]
		internal InflateCodes codes;

		// Token: 0x0400173D RID: 5949
		[Token(Token = "0x400173D")]
		[FieldOffset(Offset = "0x40")]
		internal int last;

		// Token: 0x0400173E RID: 5950
		[Token(Token = "0x400173E")]
		[FieldOffset(Offset = "0x48")]
		internal ZlibCodec _codec;

		// Token: 0x0400173F RID: 5951
		[Token(Token = "0x400173F")]
		[FieldOffset(Offset = "0x50")]
		internal int bitk;

		// Token: 0x04001740 RID: 5952
		[Token(Token = "0x4001740")]
		[FieldOffset(Offset = "0x54")]
		internal int bitb;

		// Token: 0x04001741 RID: 5953
		[Token(Token = "0x4001741")]
		[FieldOffset(Offset = "0x58")]
		internal int[] hufts;

		// Token: 0x04001742 RID: 5954
		[Token(Token = "0x4001742")]
		[FieldOffset(Offset = "0x60")]
		internal byte[] window;

		// Token: 0x04001743 RID: 5955
		[Token(Token = "0x4001743")]
		[FieldOffset(Offset = "0x68")]
		internal int end;

		// Token: 0x04001744 RID: 5956
		[Token(Token = "0x4001744")]
		[FieldOffset(Offset = "0x6C")]
		internal int readAt;

		// Token: 0x04001745 RID: 5957
		[Token(Token = "0x4001745")]
		[FieldOffset(Offset = "0x70")]
		internal int writeAt;

		// Token: 0x04001746 RID: 5958
		[Token(Token = "0x4001746")]
		[FieldOffset(Offset = "0x78")]
		internal object checkfn;

		// Token: 0x04001747 RID: 5959
		[Token(Token = "0x4001747")]
		[FieldOffset(Offset = "0x80")]
		internal uint check;

		// Token: 0x04001748 RID: 5960
		[Token(Token = "0x4001748")]
		[FieldOffset(Offset = "0x88")]
		internal InfTree inftree;

		// Token: 0x020004EE RID: 1262
		[Token(Token = "0x20004EE")]
		private enum InflateBlockMode
		{
			// Token: 0x0400174A RID: 5962
			[Token(Token = "0x400174A")]
			TYPE,
			// Token: 0x0400174B RID: 5963
			[Token(Token = "0x400174B")]
			LENS,
			// Token: 0x0400174C RID: 5964
			[Token(Token = "0x400174C")]
			STORED,
			// Token: 0x0400174D RID: 5965
			[Token(Token = "0x400174D")]
			TABLE,
			// Token: 0x0400174E RID: 5966
			[Token(Token = "0x400174E")]
			BTREE,
			// Token: 0x0400174F RID: 5967
			[Token(Token = "0x400174F")]
			DTREE,
			// Token: 0x04001750 RID: 5968
			[Token(Token = "0x4001750")]
			CODES,
			// Token: 0x04001751 RID: 5969
			[Token(Token = "0x4001751")]
			DRY,
			// Token: 0x04001752 RID: 5970
			[Token(Token = "0x4001752")]
			DONE,
			// Token: 0x04001753 RID: 5971
			[Token(Token = "0x4001753")]
			BAD
		}
	}
}
