using System;
using Il2CppDummyDll;

namespace BestHTTP.Decompression.Zlib
{
	// Token: 0x02000502 RID: 1282
	[Token(Token = "0x2000502")]
	internal sealed class ZTree
	{
		// Token: 0x06002A27 RID: 10791 RVA: 0x00012000 File Offset: 0x00010200
		[Token(Token = "0x6002A27")]
		[Address(RVA = "0x53DD910", Offset = "0x53DC510", VA = "0x1853DD910")]
		internal static int DistanceCode(int dist)
		{
			return 0;
		}

		// Token: 0x06002A28 RID: 10792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A28")]
		[Address(RVA = "0x53DE2D0", Offset = "0x53DCED0", VA = "0x1853DE2D0")]
		internal void gen_bitlen(DeflateManager s)
		{
		}

		// Token: 0x06002A29 RID: 10793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A29")]
		[Address(RVA = "0x53DDDA0", Offset = "0x53DC9A0", VA = "0x1853DDDA0")]
		internal void build_tree(DeflateManager s)
		{
		}

		// Token: 0x06002A2A RID: 10794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A2A")]
		[Address(RVA = "0x53DE6B0", Offset = "0x53DD2B0", VA = "0x1853DE6B0")]
		internal static void gen_codes(short[] tree, int max_code, short[] bl_count)
		{
		}

		// Token: 0x06002A2B RID: 10795 RVA: 0x00012018 File Offset: 0x00010218
		[Token(Token = "0x6002A2B")]
		[Address(RVA = "0x53DDD70", Offset = "0x53DC970", VA = "0x1853DDD70")]
		internal static int bi_reverse(int code, int len)
		{
			return 0;
		}

		// Token: 0x06002A2C RID: 10796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A2C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ZTree()
		{
		}

		// Token: 0x04001807 RID: 6151
		[Token(Token = "0x4001807")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int HEAP_SIZE;

		// Token: 0x04001808 RID: 6152
		[Token(Token = "0x4001808")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly int[] ExtraLengthBits;

		// Token: 0x04001809 RID: 6153
		[Token(Token = "0x4001809")]
		[FieldOffset(Offset = "0x10")]
		internal static readonly int[] ExtraDistanceBits;

		// Token: 0x0400180A RID: 6154
		[Token(Token = "0x400180A")]
		[FieldOffset(Offset = "0x18")]
		internal static readonly int[] extra_blbits;

		// Token: 0x0400180B RID: 6155
		[Token(Token = "0x400180B")]
		[FieldOffset(Offset = "0x20")]
		internal static readonly sbyte[] bl_order;

		// Token: 0x0400180C RID: 6156
		[Token(Token = "0x400180C")]
		internal const int Buf_size = 16;

		// Token: 0x0400180D RID: 6157
		[Token(Token = "0x400180D")]
		[FieldOffset(Offset = "0x28")]
		private static readonly sbyte[] _dist_code;

		// Token: 0x0400180E RID: 6158
		[Token(Token = "0x400180E")]
		[FieldOffset(Offset = "0x30")]
		internal static readonly sbyte[] LengthCode;

		// Token: 0x0400180F RID: 6159
		[Token(Token = "0x400180F")]
		[FieldOffset(Offset = "0x38")]
		internal static readonly int[] LengthBase;

		// Token: 0x04001810 RID: 6160
		[Token(Token = "0x4001810")]
		[FieldOffset(Offset = "0x40")]
		internal static readonly int[] DistanceBase;

		// Token: 0x04001811 RID: 6161
		[Token(Token = "0x4001811")]
		[FieldOffset(Offset = "0x10")]
		internal short[] dyn_tree;

		// Token: 0x04001812 RID: 6162
		[Token(Token = "0x4001812")]
		[FieldOffset(Offset = "0x18")]
		internal int max_code;

		// Token: 0x04001813 RID: 6163
		[Token(Token = "0x4001813")]
		[FieldOffset(Offset = "0x20")]
		internal StaticTree staticTree;
	}
}
