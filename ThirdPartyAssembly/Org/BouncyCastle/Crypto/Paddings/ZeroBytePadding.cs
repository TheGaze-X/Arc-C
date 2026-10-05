using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Paddings
{
	// Token: 0x020002F7 RID: 759
	[Token(Token = "0x20002F7")]
	public class ZeroBytePadding : IBlockCipherPadding
	{
		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06001965 RID: 6501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000398")]
		public string PaddingName
		{
			[Token(Token = "0x6001965")]
			[Address(RVA = "0x529A7A0", Offset = "0x52993A0", VA = "0x18529A7A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001966 RID: 6502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001966")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "4")]
		public void Init(SecureRandom random)
		{
		}

		// Token: 0x06001967 RID: 6503 RVA: 0x0000C5E8 File Offset: 0x0000A7E8
		[Token(Token = "0x6001967")]
		[Address(RVA = "0x529A710", Offset = "0x5299310", VA = "0x18529A710", Slot = "6")]
		public int AddPadding(byte[] input, int inOff)
		{
			return 0;
		}

		// Token: 0x06001968 RID: 6504 RVA: 0x0000C600 File Offset: 0x0000A800
		[Token(Token = "0x6001968")]
		[Address(RVA = "0x529A750", Offset = "0x5299350", VA = "0x18529A750", Slot = "7")]
		public int PadCount(byte[] input)
		{
			return 0;
		}

		// Token: 0x06001969 RID: 6505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001969")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ZeroBytePadding()
		{
		}
	}
}
