using System;
using System.IO;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x0200038E RID: 910
	[Token(Token = "0x200038E")]
	public abstract class Asn1Generator
	{
		// Token: 0x06001F23 RID: 7971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F23")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		protected Asn1Generator(Stream outStream)
		{
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06001F24 RID: 7972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000418")]
		protected Stream Out
		{
			[Token(Token = "0x6001F24")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001F25 RID: 7973
		[Token(Token = "0x6001F25")]
		public abstract void AddObject(Asn1Encodable obj);

		// Token: 0x06001F26 RID: 7974
		[Token(Token = "0x6001F26")]
		public abstract Stream GetRawOutputStream();

		// Token: 0x06001F27 RID: 7975
		[Token(Token = "0x6001F27")]
		public abstract void Close();

		// Token: 0x040010E0 RID: 4320
		[Token(Token = "0x40010E0")]
		[FieldOffset(Offset = "0x10")]
		private Stream _out;
	}
}
