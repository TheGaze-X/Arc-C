using System;
using System.IO;
using Il2CppDummyDll;
using SharpNeatLib.Maths;

namespace Torappu.DB
{
	// Token: 0x02001687 RID: 5767
	[Token(Token = "0x2001687")]
	public class CrypticConverter_B : CrypticConverter
	{
		// Token: 0x17000F89 RID: 3977
		// (get) Token: 0x06009239 RID: 37433 RVA: 0x00038F10 File Offset: 0x00037110
		// (set) Token: 0x06009238 RID: 37432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000F89")]
		public uint seed
		{
			[Token(Token = "0x6009239")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6009238")]
			[Address(RVA = "0x2B2EF80", Offset = "0x2B2DB80", VA = "0x182B2EF80")]
			set
			{
			}
		}

		// Token: 0x0600923A RID: 37434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600923A")]
		[Address(RVA = "0x2B2EF20", Offset = "0x2B2DB20", VA = "0x182B2EF20")]
		public CrypticConverter_B()
		{
		}

		// Token: 0x0600923B RID: 37435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600923B")]
		[Address(RVA = "0x2B2EAE0", Offset = "0x2B2D6E0", VA = "0x182B2EAE0", Slot = "16")]
		protected override byte[] EncodeInternal(byte[] src)
		{
			return null;
		}

		// Token: 0x0600923C RID: 37436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600923C")]
		[Address(RVA = "0x2B2E790", Offset = "0x2B2D390", VA = "0x182B2E790", Slot = "17")]
		protected override void DecodeInternal(Stream src, Stream dst)
		{
		}

		// Token: 0x0600923D RID: 37437 RVA: 0x00038F28 File Offset: 0x00037128
		[Token(Token = "0x600923D")]
		[Address(RVA = "0x2B2EEF0", Offset = "0x2B2DAF0", VA = "0x182B2EEF0")]
		private uint _Rand()
		{
			return 0U;
		}

		// Token: 0x0600923E RID: 37438 RVA: 0x00038F40 File Offset: 0x00037140
		[Token(Token = "0x600923E")]
		[Address(RVA = "0x2B2EEB0", Offset = "0x2B2DAB0", VA = "0x182B2EEB0")]
		private uint _Crypt(uint word, uint key)
		{
			return 0U;
		}

		// Token: 0x04008816 RID: 34838
		[Token(Token = "0x4008816")]
		private const ulong MOD = 2147483647UL;

		// Token: 0x04008817 RID: 34839
		[Token(Token = "0x4008817")]
		private const string SEED_HASH_STR = "0.577215";

		// Token: 0x04008818 RID: 34840
		[Token(Token = "0x4008818")]
		[FieldOffset(Offset = "0x20")]
		private uint m_seed;

		// Token: 0x04008819 RID: 34841
		[Token(Token = "0x4008819")]
		[FieldOffset(Offset = "0x28")]
		private FastRandom random;
	}
}
