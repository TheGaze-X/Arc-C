using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x0200040D RID: 1037
	[Token(Token = "0x200040D")]
	public class GeneralNames : Asn1Encodable
	{
		// Token: 0x06002236 RID: 8758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002236")]
		[Address(RVA = "0x533E1B0", Offset = "0x533CDB0", VA = "0x18533E1B0")]
		public static GeneralNames GetInstance(object obj)
		{
			return null;
		}

		// Token: 0x06002237 RID: 8759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002237")]
		[Address(RVA = "0x533E540", Offset = "0x533D140", VA = "0x18533E540")]
		public static GeneralNames GetInstance(Asn1TaggedObject obj, bool explicitly)
		{
			return null;
		}

		// Token: 0x06002238 RID: 8760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002238")]
		[Address(RVA = "0x533EA50", Offset = "0x533D650", VA = "0x18533EA50")]
		public GeneralNames(GeneralName name)
		{
		}

		// Token: 0x06002239 RID: 8761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002239")]
		[Address(RVA = "0x533E800", Offset = "0x533D400", VA = "0x18533E800")]
		public GeneralNames(GeneralName[] names)
		{
		}

		// Token: 0x0600223A RID: 8762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600223A")]
		[Address(RVA = "0x533E8D0", Offset = "0x533D4D0", VA = "0x18533E8D0")]
		private GeneralNames(Asn1Sequence seq)
		{
		}

		// Token: 0x0600223B RID: 8763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600223B")]
		[Address(RVA = "0x533E560", Offset = "0x533D160", VA = "0x18533E560")]
		public GeneralName[] GetNames()
		{
			return null;
		}

		// Token: 0x0600223C RID: 8764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600223C")]
		[Address(RVA = "0x533E5E0", Offset = "0x533D1E0", VA = "0x18533E5E0", Slot = "5")]
		public override Asn1Object ToAsn1Object()
		{
			return null;
		}

		// Token: 0x0600223D RID: 8765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600223D")]
		[Address(RVA = "0x533E680", Offset = "0x533D280", VA = "0x18533E680", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040011F9 RID: 4601
		[Token(Token = "0x40011F9")]
		[FieldOffset(Offset = "0x10")]
		private readonly GeneralName[] names;
	}
}
