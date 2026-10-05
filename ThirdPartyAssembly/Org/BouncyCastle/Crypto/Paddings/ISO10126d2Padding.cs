using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Paddings
{
	// Token: 0x020002F1 RID: 753
	[Token(Token = "0x20002F1")]
	public class ISO10126d2Padding : IBlockCipherPadding
	{
		// Token: 0x06001944 RID: 6468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001944")]
		[Address(RVA = "0x528EB10", Offset = "0x528D710", VA = "0x18528EB10", Slot = "4")]
		public void Init(SecureRandom random)
		{
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06001945 RID: 6469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000393")]
		public string PaddingName
		{
			[Token(Token = "0x6001945")]
			[Address(RVA = "0x528EC20", Offset = "0x528D820", VA = "0x18528EC20", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001946 RID: 6470 RVA: 0x0000C480 File Offset: 0x0000A680
		[Token(Token = "0x6001946")]
		[Address(RVA = "0x528EA50", Offset = "0x528D650", VA = "0x18528EA50", Slot = "6")]
		public int AddPadding(byte[] input, int inOff)
		{
			return 0;
		}

		// Token: 0x06001947 RID: 6471 RVA: 0x0000C498 File Offset: 0x0000A698
		[Token(Token = "0x6001947")]
		[Address(RVA = "0x528EB90", Offset = "0x528D790", VA = "0x18528EB90", Slot = "7")]
		public int PadCount(byte[] input)
		{
			return 0;
		}

		// Token: 0x06001948 RID: 6472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001948")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ISO10126d2Padding()
		{
		}

		// Token: 0x04000D52 RID: 3410
		[Token(Token = "0x4000D52")]
		[FieldOffset(Offset = "0x10")]
		private SecureRandom random;
	}
}
