using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Paddings
{
	// Token: 0x020002F6 RID: 758
	[Token(Token = "0x20002F6")]
	public class X923Padding : IBlockCipherPadding
	{
		// Token: 0x06001960 RID: 6496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001960")]
		[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40", Slot = "4")]
		public void Init(SecureRandom random)
		{
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06001961 RID: 6497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000397")]
		public string PaddingName
		{
			[Token(Token = "0x6001961")]
			[Address(RVA = "0x5299C40", Offset = "0x5298840", VA = "0x185299C40", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001962 RID: 6498 RVA: 0x0000C5B8 File Offset: 0x0000A7B8
		[Token(Token = "0x6001962")]
		[Address(RVA = "0x5299B00", Offset = "0x5298700", VA = "0x185299B00", Slot = "6")]
		public int AddPadding(byte[] input, int inOff)
		{
			return 0;
		}

		// Token: 0x06001963 RID: 6499 RVA: 0x0000C5D0 File Offset: 0x0000A7D0
		[Token(Token = "0x6001963")]
		[Address(RVA = "0x5299BB0", Offset = "0x52987B0", VA = "0x185299BB0", Slot = "7")]
		public int PadCount(byte[] input)
		{
			return 0;
		}

		// Token: 0x06001964 RID: 6500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001964")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public X923Padding()
		{
		}

		// Token: 0x04000D54 RID: 3412
		[Token(Token = "0x4000D54")]
		[FieldOffset(Offset = "0x10")]
		private SecureRandom random;
	}
}
