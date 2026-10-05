using System;
using System.IO;
using Il2CppDummyDll;

namespace Torappu.DB
{
	// Token: 0x02001681 RID: 5761
	[Token(Token = "0x2001681")]
	public class BsonNetConverter_WithSign : BsonNetConverter
	{
		// Token: 0x0600921E RID: 37406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600921E")]
		[Address(RVA = "0x2B27BC0", Offset = "0x2B267C0", VA = "0x182B27BC0")]
		public BsonNetConverter_WithSign()
		{
		}

		// Token: 0x0600921F RID: 37407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600921F")]
		[Address(RVA = "0x2B27B60", Offset = "0x2B26760", VA = "0x182B27B60", Slot = "17")]
		protected override void ProcessStreamAfterSerialize(Stream inStream, Stream outStream)
		{
		}

		// Token: 0x06009220 RID: 37408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009220")]
		protected override T DeserializeInternal<T>(Stream stream)
		{
			return null;
		}

		// Token: 0x04008801 RID: 34817
		[Token(Token = "0x4008801")]
		private const int SIGN_HEADER_LENGTH = 128;

		// Token: 0x04008802 RID: 34818
		[Token(Token = "0x4008802")]
		[FieldOffset(Offset = "0x28")]
		private string m_signPubKey;
	}
}
