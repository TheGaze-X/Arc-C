using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020003DC RID: 988
	[Token(Token = "0x20003DC")]
	public class OidTokenizer
	{
		// Token: 0x0600212B RID: 8491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600212B")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		public OidTokenizer(string oid)
		{
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x0600212C RID: 8492 RVA: 0x0000F720 File Offset: 0x0000D920
		[Token(Token = "0x1700043D")]
		public bool HasMoreTokens
		{
			[Token(Token = "0x600212C")]
			[Address(RVA = "0x5340DA0", Offset = "0x533F9A0", VA = "0x185340DA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600212D RID: 8493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600212D")]
		[Address(RVA = "0x5340D10", Offset = "0x533F910", VA = "0x185340D10")]
		public string NextToken()
		{
			return null;
		}

		// Token: 0x04001158 RID: 4440
		[Token(Token = "0x4001158")]
		[FieldOffset(Offset = "0x10")]
		private string oid;

		// Token: 0x04001159 RID: 4441
		[Token(Token = "0x4001159")]
		[FieldOffset(Offset = "0x18")]
		private int index;
	}
}
