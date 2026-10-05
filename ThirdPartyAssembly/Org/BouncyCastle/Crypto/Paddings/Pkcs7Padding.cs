using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Paddings
{
	// Token: 0x020002F4 RID: 756
	[Token(Token = "0x20002F4")]
	public class Pkcs7Padding : IBlockCipherPadding
	{
		// Token: 0x06001956 RID: 6486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001956")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "4")]
		public void Init(SecureRandom random)
		{
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06001957 RID: 6487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000395")]
		public string PaddingName
		{
			[Token(Token = "0x6001957")]
			[Address(RVA = "0x5294470", Offset = "0x5293070", VA = "0x185294470", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001958 RID: 6488 RVA: 0x0000C558 File Offset: 0x0000A758
		[Token(Token = "0x6001958")]
		[Address(RVA = "0x5294300", Offset = "0x5292F00", VA = "0x185294300", Slot = "6")]
		public int AddPadding(byte[] input, int inOff)
		{
			return 0;
		}

		// Token: 0x06001959 RID: 6489 RVA: 0x0000C570 File Offset: 0x0000A770
		[Token(Token = "0x6001959")]
		[Address(RVA = "0x5294340", Offset = "0x5292F40", VA = "0x185294340", Slot = "7")]
		public int PadCount(byte[] input)
		{
			return 0;
		}

		// Token: 0x0600195A RID: 6490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600195A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Pkcs7Padding()
		{
		}
	}
}
