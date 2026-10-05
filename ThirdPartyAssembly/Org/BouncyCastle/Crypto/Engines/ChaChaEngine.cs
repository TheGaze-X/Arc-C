using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x0200032F RID: 815
	[Token(Token = "0x200032F")]
	public class ChaChaEngine : Salsa20Engine
	{
		// Token: 0x06001B6A RID: 7018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B6A")]
		[Address(RVA = "0x52B9DB0", Offset = "0x52B89B0", VA = "0x1852B9DB0")]
		public ChaChaEngine()
		{
		}

		// Token: 0x06001B6B RID: 7019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B6B")]
		[Address(RVA = "0x52B9E00", Offset = "0x52B8A00", VA = "0x1852B9E00")]
		public ChaChaEngine(int rounds)
		{
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06001B6C RID: 7020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003CD")]
		public override string AlgorithmName
		{
			[Token(Token = "0x6001B6C")]
			[Address(RVA = "0x52B9E60", Offset = "0x52B8A60", VA = "0x1852B9E60", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001B6D RID: 7021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B6D")]
		[Address(RVA = "0x52B9460", Offset = "0x52B8060", VA = "0x1852B9460", Slot = "13")]
		protected override void AdvanceCounter()
		{
		}

		// Token: 0x06001B6E RID: 7022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B6E")]
		[Address(RVA = "0x52B9C40", Offset = "0x52B8840", VA = "0x1852B9C40", Slot = "16")]
		protected override void ResetCounter()
		{
		}

		// Token: 0x06001B6F RID: 7023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B6F")]
		[Address(RVA = "0x52B9C80", Offset = "0x52B8880", VA = "0x1852B9C80", Slot = "17")]
		protected override void SetKey(byte[] keyBytes, byte[] ivBytes)
		{
		}

		// Token: 0x06001B70 RID: 7024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B70")]
		[Address(RVA = "0x52B9240", Offset = "0x52B7E40", VA = "0x1852B9240", Slot = "18")]
		protected override void GenerateKeyStream(byte[] output)
		{
		}

		// Token: 0x06001B71 RID: 7025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B71")]
		[Address(RVA = "0x52B94A0", Offset = "0x52B80A0", VA = "0x1852B94A0")]
		internal static void ChachaCore(int rounds, uint[] input, uint[] x)
		{
		}
	}
}
