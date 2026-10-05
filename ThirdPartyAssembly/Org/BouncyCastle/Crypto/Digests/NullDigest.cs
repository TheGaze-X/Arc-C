using System;
using System.IO;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Digests
{
	// Token: 0x0200037A RID: 890
	[Token(Token = "0x200037A")]
	public class NullDigest : IDigest
	{
		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06001E1A RID: 7706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000406")]
		public string AlgorithmName
		{
			[Token(Token = "0x6001E1A")]
			[Address(RVA = "0x53031F0", Offset = "0x5301DF0", VA = "0x1853031F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001E1B RID: 7707 RVA: 0x0000E550 File Offset: 0x0000C750
		[Token(Token = "0x6001E1B")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "6")]
		public int GetByteLength()
		{
			return 0;
		}

		// Token: 0x06001E1C RID: 7708 RVA: 0x0000E568 File Offset: 0x0000C768
		[Token(Token = "0x6001E1C")]
		[Address(RVA = "0x4BAB760", Offset = "0x4BAA360", VA = "0x184BAB760", Slot = "5")]
		public int GetDigestSize()
		{
			return 0;
		}

		// Token: 0x06001E1D RID: 7709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E1D")]
		[Address(RVA = "0x4C758A0", Offset = "0x4C744A0", VA = "0x184C758A0", Slot = "7")]
		public void Update(byte b)
		{
		}

		// Token: 0x06001E1E RID: 7710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E1E")]
		[Address(RVA = "0x4C760B0", Offset = "0x4C74CB0", VA = "0x184C760B0", Slot = "8")]
		public void BlockUpdate(byte[] inBytes, int inOff, int len)
		{
		}

		// Token: 0x06001E1F RID: 7711 RVA: 0x0000E580 File Offset: 0x0000C780
		[Token(Token = "0x6001E1F")]
		[Address(RVA = "0x5303060", Offset = "0x5301C60", VA = "0x185303060", Slot = "9")]
		public int DoFinal(byte[] outBytes, int outOff)
		{
			return 0;
		}

		// Token: 0x06001E20 RID: 7712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E20")]
		[Address(RVA = "0x5303130", Offset = "0x5301D30", VA = "0x185303130", Slot = "10")]
		public void Reset()
		{
		}

		// Token: 0x06001E21 RID: 7713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E21")]
		[Address(RVA = "0x5303180", Offset = "0x5301D80", VA = "0x185303180")]
		public NullDigest()
		{
		}

		// Token: 0x0400105C RID: 4188
		[Token(Token = "0x400105C")]
		[FieldOffset(Offset = "0x10")]
		private readonly MemoryStream bOut;
	}
}
