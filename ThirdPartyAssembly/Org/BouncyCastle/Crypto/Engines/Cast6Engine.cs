using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x0200032D RID: 813
	[Token(Token = "0x200032D")]
	public sealed class Cast6Engine : Cast5Engine
	{
		// Token: 0x06001B5A RID: 7002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B5A")]
		[Address(RVA = "0x52B8FD0", Offset = "0x52B7BD0", VA = "0x1852B8FD0")]
		public Cast6Engine()
		{
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06001B5B RID: 7003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003CA")]
		public override string AlgorithmName
		{
			[Token(Token = "0x6001B5B")]
			[Address(RVA = "0x52B9180", Offset = "0x52B7D80", VA = "0x1852B9180", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001B5C RID: 7004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B5C")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "14")]
		public override void Reset()
		{
		}

		// Token: 0x06001B5D RID: 7005 RVA: 0x0000D380 File Offset: 0x0000B580
		[Token(Token = "0x6001B5D")]
		[Address(RVA = "0x3D286D0", Offset = "0x3D272D0", VA = "0x183D286D0", Slot = "15")]
		public override int GetBlockSize()
		{
			return 0;
		}

		// Token: 0x06001B5E RID: 7006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B5E")]
		[Address(RVA = "0x52B85B0", Offset = "0x52B71B0", VA = "0x1852B85B0", Slot = "16")]
		internal override void SetKey(byte[] key)
		{
		}

		// Token: 0x06001B5F RID: 7007 RVA: 0x0000D398 File Offset: 0x0000B598
		[Token(Token = "0x6001B5F")]
		[Address(RVA = "0x52B8440", Offset = "0x52B7040", VA = "0x1852B8440", Slot = "17")]
		internal override int EncryptBlock(byte[] src, int srcIndex, byte[] dst, int dstIndex)
		{
			return 0;
		}

		// Token: 0x06001B60 RID: 7008 RVA: 0x0000D3B0 File Offset: 0x0000B5B0
		[Token(Token = "0x6001B60")]
		[Address(RVA = "0x52B82D0", Offset = "0x52B6ED0", VA = "0x1852B82D0", Slot = "18")]
		internal override int DecryptBlock(byte[] src, int srcIndex, byte[] dst, int dstIndex)
		{
			return 0;
		}

		// Token: 0x06001B61 RID: 7009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B61")]
		[Address(RVA = "0x52B7F90", Offset = "0x52B6B90", VA = "0x1852B7F90")]
		private void CAST_Encipher(uint A, uint B, uint C, uint D, uint[] result)
		{
		}

		// Token: 0x06001B62 RID: 7010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B62")]
		[Address(RVA = "0x52B7C50", Offset = "0x52B6850", VA = "0x1852B7C50")]
		private void CAST_Decipher(uint A, uint B, uint C, uint D, uint[] result)
		{
		}

		// Token: 0x04000EAB RID: 3755
		[Token(Token = "0x4000EAB")]
		private const int ROUNDS = 12;

		// Token: 0x04000EAC RID: 3756
		[Token(Token = "0x4000EAC")]
		private const int BLOCK_SIZE = 16;

		// Token: 0x04000EAD RID: 3757
		[Token(Token = "0x4000EAD")]
		[FieldOffset(Offset = "0x38")]
		private int[] _Kr;

		// Token: 0x04000EAE RID: 3758
		[Token(Token = "0x4000EAE")]
		[FieldOffset(Offset = "0x40")]
		private uint[] _Km;

		// Token: 0x04000EAF RID: 3759
		[Token(Token = "0x4000EAF")]
		[FieldOffset(Offset = "0x48")]
		private int[] _Tr;

		// Token: 0x04000EB0 RID: 3760
		[Token(Token = "0x4000EB0")]
		[FieldOffset(Offset = "0x50")]
		private uint[] _Tm;

		// Token: 0x04000EB1 RID: 3761
		[Token(Token = "0x4000EB1")]
		[FieldOffset(Offset = "0x58")]
		private uint[] _workingKey;
	}
}
