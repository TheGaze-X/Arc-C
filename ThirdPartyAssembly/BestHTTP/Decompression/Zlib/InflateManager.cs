using System;
using Il2CppDummyDll;

namespace BestHTTP.Decompression.Zlib
{
	// Token: 0x020004F1 RID: 1265
	[Token(Token = "0x20004F1")]
	internal sealed class InflateManager
	{
		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x060029D6 RID: 10710 RVA: 0x00011BE0 File Offset: 0x0000FDE0
		// (set) Token: 0x060029D7 RID: 10711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700060B")]
		internal bool HandleRfc1950HeaderBytes
		{
			[Token(Token = "0x60029D6")]
			[Address(RVA = "0xAE5EF0", Offset = "0xAE4AF0", VA = "0x180AE5EF0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60029D7")]
			[Address(RVA = "0x17F30F0", Offset = "0x17F1CF0", VA = "0x1817F30F0")]
			set
			{
			}
		}

		// Token: 0x060029D8 RID: 10712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029D8")]
		[Address(RVA = "0x1D66F70", Offset = "0x1D65B70", VA = "0x181D66F70")]
		public InflateManager()
		{
		}

		// Token: 0x060029D9 RID: 10713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029D9")]
		[Address(RVA = "0x53C4E10", Offset = "0x53C3A10", VA = "0x1853C4E10")]
		public InflateManager(bool expectRfc1950HeaderBytes)
		{
		}

		// Token: 0x060029DA RID: 10714 RVA: 0x00011BF8 File Offset: 0x0000FDF8
		[Token(Token = "0x60029DA")]
		[Address(RVA = "0x53C4900", Offset = "0x53C3500", VA = "0x1853C4900")]
		internal int Reset()
		{
			return 0;
		}

		// Token: 0x060029DB RID: 10715 RVA: 0x00011C10 File Offset: 0x0000FE10
		[Token(Token = "0x60029DB")]
		[Address(RVA = "0x53C3CA0", Offset = "0x53C28A0", VA = "0x1853C3CA0")]
		internal int End()
		{
			return 0;
		}

		// Token: 0x060029DC RID: 10716 RVA: 0x00011C28 File Offset: 0x0000FE28
		[Token(Token = "0x60029DC")]
		[Address(RVA = "0x53C4600", Offset = "0x53C3200", VA = "0x1853C4600")]
		internal int Initialize(ZlibCodec codec, int w)
		{
			return 0;
		}

		// Token: 0x060029DD RID: 10717 RVA: 0x00011C40 File Offset: 0x0000FE40
		[Token(Token = "0x60029DD")]
		[Address(RVA = "0x53C3D10", Offset = "0x53C2910", VA = "0x1853C3D10")]
		internal int Inflate(FlushType flush)
		{
			return 0;
		}

		// Token: 0x060029DE RID: 10718 RVA: 0x00011C58 File Offset: 0x0000FE58
		[Token(Token = "0x60029DE")]
		[Address(RVA = "0x53C4970", Offset = "0x53C3570", VA = "0x1853C4970")]
		internal int SetDictionary(byte[] dictionary)
		{
			return 0;
		}

		// Token: 0x060029DF RID: 10719 RVA: 0x00011C70 File Offset: 0x0000FE70
		[Token(Token = "0x60029DF")]
		[Address(RVA = "0x53C4B40", Offset = "0x53C3740", VA = "0x1853C4B40")]
		internal int Sync()
		{
			return 0;
		}

		// Token: 0x060029E0 RID: 10720 RVA: 0x00011C88 File Offset: 0x0000FE88
		[Token(Token = "0x60029E0")]
		[Address(RVA = "0x53C4B10", Offset = "0x53C3710", VA = "0x1853C4B10")]
		internal int SyncPoint(ZlibCodec z)
		{
			return 0;
		}

		// Token: 0x0400176D RID: 5997
		[Token(Token = "0x400176D")]
		private const int PRESET_DICT = 32;

		// Token: 0x0400176E RID: 5998
		[Token(Token = "0x400176E")]
		private const int Z_DEFLATED = 8;

		// Token: 0x0400176F RID: 5999
		[Token(Token = "0x400176F")]
		[FieldOffset(Offset = "0x10")]
		private InflateManager.InflateManagerMode mode;

		// Token: 0x04001770 RID: 6000
		[Token(Token = "0x4001770")]
		[FieldOffset(Offset = "0x18")]
		internal ZlibCodec _codec;

		// Token: 0x04001771 RID: 6001
		[Token(Token = "0x4001771")]
		[FieldOffset(Offset = "0x20")]
		internal int method;

		// Token: 0x04001772 RID: 6002
		[Token(Token = "0x4001772")]
		[FieldOffset(Offset = "0x24")]
		internal uint computedCheck;

		// Token: 0x04001773 RID: 6003
		[Token(Token = "0x4001773")]
		[FieldOffset(Offset = "0x28")]
		internal uint expectedCheck;

		// Token: 0x04001774 RID: 6004
		[Token(Token = "0x4001774")]
		[FieldOffset(Offset = "0x2C")]
		internal int marker;

		// Token: 0x04001775 RID: 6005
		[Token(Token = "0x4001775")]
		[FieldOffset(Offset = "0x30")]
		private bool _handleRfc1950HeaderBytes;

		// Token: 0x04001776 RID: 6006
		[Token(Token = "0x4001776")]
		[FieldOffset(Offset = "0x34")]
		internal int wbits;

		// Token: 0x04001777 RID: 6007
		[Token(Token = "0x4001777")]
		[FieldOffset(Offset = "0x38")]
		internal InflateBlocks blocks;

		// Token: 0x04001778 RID: 6008
		[Token(Token = "0x4001778")]
		[FieldOffset(Offset = "0x0")]
		private static readonly byte[] mark;

		// Token: 0x020004F2 RID: 1266
		[Token(Token = "0x20004F2")]
		private enum InflateManagerMode
		{
			// Token: 0x0400177A RID: 6010
			[Token(Token = "0x400177A")]
			METHOD,
			// Token: 0x0400177B RID: 6011
			[Token(Token = "0x400177B")]
			FLAG,
			// Token: 0x0400177C RID: 6012
			[Token(Token = "0x400177C")]
			DICT4,
			// Token: 0x0400177D RID: 6013
			[Token(Token = "0x400177D")]
			DICT3,
			// Token: 0x0400177E RID: 6014
			[Token(Token = "0x400177E")]
			DICT2,
			// Token: 0x0400177F RID: 6015
			[Token(Token = "0x400177F")]
			DICT1,
			// Token: 0x04001780 RID: 6016
			[Token(Token = "0x4001780")]
			DICT0,
			// Token: 0x04001781 RID: 6017
			[Token(Token = "0x4001781")]
			BLOCKS,
			// Token: 0x04001782 RID: 6018
			[Token(Token = "0x4001782")]
			CHECK4,
			// Token: 0x04001783 RID: 6019
			[Token(Token = "0x4001783")]
			CHECK3,
			// Token: 0x04001784 RID: 6020
			[Token(Token = "0x4001784")]
			CHECK2,
			// Token: 0x04001785 RID: 6021
			[Token(Token = "0x4001785")]
			CHECK1,
			// Token: 0x04001786 RID: 6022
			[Token(Token = "0x4001786")]
			DONE,
			// Token: 0x04001787 RID: 6023
			[Token(Token = "0x4001787")]
			BAD
		}
	}
}
