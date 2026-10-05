using System;
using System.IO;
using Il2CppDummyDll;

namespace Torappu.DB
{
	// Token: 0x02001686 RID: 5766
	[Token(Token = "0x2001686")]
	public class CrypticConverter_A : CrypticConverter
	{
		// Token: 0x06009234 RID: 37428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009234")]
		[Address(RVA = "0x2B2E680", Offset = "0x2B2D280", VA = "0x182B2E680")]
		public CrypticConverter_A()
		{
		}

		// Token: 0x06009235 RID: 37429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009235")]
		[Address(RVA = "0x2B2E0A0", Offset = "0x2B2CCA0", VA = "0x182B2E0A0", Slot = "16")]
		protected override byte[] EncodeInternal(byte[] src)
		{
			return null;
		}

		// Token: 0x06009236 RID: 37430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009236")]
		[Address(RVA = "0x2B2DBF0", Offset = "0x2B2C7F0", VA = "0x182B2DBF0", Slot = "17")]
		protected override void DecodeInternal(Stream src, Stream dst)
		{
		}

		// Token: 0x06009237 RID: 37431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009237")]
		[Address(RVA = "0x2B2E670", Offset = "0x2B2D270", VA = "0x182B2E670", Slot = "21")]
		protected virtual byte[] ReadContentBytes(Stream src)
		{
			return null;
		}

		// Token: 0x04008813 RID: 34835
		[Token(Token = "0x4008813")]
		private const int KEY_LENGTH = 16;

		// Token: 0x04008814 RID: 34836
		[Token(Token = "0x4008814")]
		private const int IV_LENGTH = 16;

		// Token: 0x04008815 RID: 34837
		[Token(Token = "0x4008815")]
		[FieldOffset(Offset = "0x20")]
		private string m_token;
	}
}
