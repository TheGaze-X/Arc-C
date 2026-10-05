using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Paddings
{
	// Token: 0x020002F2 RID: 754
	[Token(Token = "0x20002F2")]
	public class ISO7816d4Padding : IBlockCipherPadding
	{
		// Token: 0x06001949 RID: 6473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001949")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "4")]
		public void Init(SecureRandom random)
		{
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x0600194A RID: 6474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000394")]
		public string PaddingName
		{
			[Token(Token = "0x600194A")]
			[Address(RVA = "0x528ED50", Offset = "0x528D950", VA = "0x18528ED50", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600194B RID: 6475 RVA: 0x0000C4B0 File Offset: 0x0000A6B0
		[Token(Token = "0x600194B")]
		[Address(RVA = "0x528EC50", Offset = "0x528D850", VA = "0x18528EC50", Slot = "6")]
		public int AddPadding(byte[] input, int inOff)
		{
			return 0;
		}

		// Token: 0x0600194C RID: 6476 RVA: 0x0000C4C8 File Offset: 0x0000A6C8
		[Token(Token = "0x600194C")]
		[Address(RVA = "0x528ECA0", Offset = "0x528D8A0", VA = "0x18528ECA0", Slot = "7")]
		public int PadCount(byte[] input)
		{
			return 0;
		}

		// Token: 0x0600194D RID: 6477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600194D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ISO7816d4Padding()
		{
		}
	}
}
