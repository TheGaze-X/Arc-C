using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x0200032E RID: 814
	[Token(Token = "0x200032E")]
	public class ChaCha7539Engine : Salsa20Engine
	{
		// Token: 0x06001B63 RID: 7011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B63")]
		[Address(RVA = "0x52B93C0", Offset = "0x52B7FC0", VA = "0x1852B93C0")]
		public ChaCha7539Engine()
		{
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06001B64 RID: 7012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003CB")]
		public override string AlgorithmName
		{
			[Token(Token = "0x6001B64")]
			[Address(RVA = "0x52B9410", Offset = "0x52B8010", VA = "0x1852B9410", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06001B65 RID: 7013 RVA: 0x0000D3C8 File Offset: 0x0000B5C8
		[Token(Token = "0x170003CC")]
		protected override int NonceSize
		{
			[Token(Token = "0x6001B65")]
			[Address(RVA = "0x21127B0", Offset = "0x21113B0", VA = "0x1821127B0", Slot = "10")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001B66 RID: 7014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B66")]
		[Address(RVA = "0x52B91B0", Offset = "0x52B7DB0", VA = "0x1852B91B0", Slot = "13")]
		protected override void AdvanceCounter()
		{
		}

		// Token: 0x06001B67 RID: 7015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B67")]
		[Address(RVA = "0x52B9280", Offset = "0x52B7E80", VA = "0x1852B9280", Slot = "16")]
		protected override void ResetCounter()
		{
		}

		// Token: 0x06001B68 RID: 7016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B68")]
		[Address(RVA = "0x52B92B0", Offset = "0x52B7EB0", VA = "0x1852B92B0", Slot = "17")]
		protected override void SetKey(byte[] keyBytes, byte[] ivBytes)
		{
		}

		// Token: 0x06001B69 RID: 7017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B69")]
		[Address(RVA = "0x52B9240", Offset = "0x52B7E40", VA = "0x1852B9240", Slot = "18")]
		protected override void GenerateKeyStream(byte[] output)
		{
		}
	}
}
