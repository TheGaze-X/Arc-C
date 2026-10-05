using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x02000330 RID: 816
	[Token(Token = "0x2000330")]
	public class DesEdeEngine : DesEngine
	{
		// Token: 0x06001B72 RID: 7026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B72")]
		[Address(RVA = "0x52B9EB0", Offset = "0x52B8AB0", VA = "0x1852B9EB0", Slot = "11")]
		public override void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06001B73 RID: 7027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003CE")]
		public override string AlgorithmName
		{
			[Token(Token = "0x6001B73")]
			[Address(RVA = "0x52BA500", Offset = "0x52B9100", VA = "0x1852BA500", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001B74 RID: 7028 RVA: 0x0000D3E0 File Offset: 0x0000B5E0
		[Token(Token = "0x6001B74")]
		[Address(RVA = "0x5586F0", Offset = "0x5572F0", VA = "0x1805586F0", Slot = "14")]
		public override int GetBlockSize()
		{
			return 0;
		}

		// Token: 0x06001B75 RID: 7029 RVA: 0x0000D3F8 File Offset: 0x0000B5F8
		[Token(Token = "0x6001B75")]
		[Address(RVA = "0x52BA2B0", Offset = "0x52B8EB0", VA = "0x1852BA2B0", Slot = "15")]
		public override int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x06001B76 RID: 7030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B76")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "16")]
		public override void Reset()
		{
		}

		// Token: 0x06001B77 RID: 7031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B77")]
		[Address(RVA = "0x52BA4B0", Offset = "0x52B90B0", VA = "0x1852BA4B0")]
		public DesEdeEngine()
		{
		}

		// Token: 0x04000EB2 RID: 3762
		[Token(Token = "0x4000EB2")]
		[FieldOffset(Offset = "0x18")]
		private int[] workingKey1;

		// Token: 0x04000EB3 RID: 3763
		[Token(Token = "0x4000EB3")]
		[FieldOffset(Offset = "0x20")]
		private int[] workingKey2;

		// Token: 0x04000EB4 RID: 3764
		[Token(Token = "0x4000EB4")]
		[FieldOffset(Offset = "0x28")]
		private int[] workingKey3;

		// Token: 0x04000EB5 RID: 3765
		[Token(Token = "0x4000EB5")]
		[FieldOffset(Offset = "0x30")]
		private bool forEncryption;
	}
}
