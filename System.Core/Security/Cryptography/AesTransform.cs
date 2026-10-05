using System;
using Il2CppDummyDll;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	internal class AesTransform : SymmetricTransform
	{
		// Token: 0x0600002D RID: 45 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x4F21470", Offset = "0x4F20070", VA = "0x184F21470")]
		public AesTransform(Aes algo, bool encryption, byte[] key, byte[] iv)
		{
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x4F1E7A0", Offset = "0x4F1D3A0", VA = "0x184F1E7A0", Slot = "17")]
		protected override void ECB(byte[] input, byte[] output)
		{
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002118 File Offset: 0x00000318
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x4F20F50", Offset = "0x4F1FB50", VA = "0x184F20F50")]
		private uint SubByte(uint a)
		{
			return 0U;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x4F1E7D0", Offset = "0x4F1D3D0", VA = "0x184F1E7D0")]
		private void Encrypt128(byte[] indata, byte[] outdata, uint[] ekey)
		{
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x4F1C070", Offset = "0x4F1AC70", VA = "0x184F1C070")]
		private void Decrypt128(byte[] indata, byte[] outdata, uint[] ekey)
		{
		}

		// Token: 0x04000002 RID: 2
		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x58")]
		private uint[] expandedKey;

		// Token: 0x04000003 RID: 3
		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x60")]
		private int Nk;

		// Token: 0x04000004 RID: 4
		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x64")]
		private int Nr;

		// Token: 0x04000005 RID: 5
		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x0")]
		private static readonly uint[] Rcon;

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x8")]
		private static readonly byte[] SBox;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x10")]
		private static readonly byte[] iSBox;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x18")]
		private static readonly uint[] T0;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x20")]
		private static readonly uint[] T1;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x28")]
		private static readonly uint[] T2;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x30")]
		private static readonly uint[] T3;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x38")]
		private static readonly uint[] iT0;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x40")]
		private static readonly uint[] iT1;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x48")]
		private static readonly uint[] iT2;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x50")]
		private static readonly uint[] iT3;
	}
}
