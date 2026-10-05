using System;
using System.Collections;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020003D9 RID: 985
	[Token(Token = "0x20003D9")]
	internal class LazyDerSequence : DerSequence
	{
		// Token: 0x0600211C RID: 8476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600211C")]
		[Address(RVA = "0x5340700", Offset = "0x533F300", VA = "0x185340700")]
		internal LazyDerSequence(byte[] encoded)
		{
		}

		// Token: 0x0600211D RID: 8477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600211D")]
		[Address(RVA = "0x53405D0", Offset = "0x533F1D0", VA = "0x1853405D0")]
		private void Parse()
		{
		}

		// Token: 0x17000439 RID: 1081
		[Token(Token = "0x17000439")]
		public override Asn1Encodable this[int index]
		{
			[Token(Token = "0x600211E")]
			[Address(RVA = "0x5340790", Offset = "0x533F390", VA = "0x185340790", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600211F RID: 8479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600211F")]
		[Address(RVA = "0x53405B0", Offset = "0x533F1B0", VA = "0x1853405B0", Slot = "10")]
		public override IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06002120 RID: 8480 RVA: 0x0000F6D8 File Offset: 0x0000D8D8
		[Token(Token = "0x1700043A")]
		public override int Count
		{
			[Token(Token = "0x6002120")]
			[Address(RVA = "0x5340770", Offset = "0x533F370", VA = "0x185340770", Slot = "13")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06002121 RID: 8481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002121")]
		[Address(RVA = "0x5340470", Offset = "0x533F070", VA = "0x185340470", Slot = "6")]
		internal override void Encode(DerOutputStream derOut)
		{
		}

		// Token: 0x04001154 RID: 4436
		[Token(Token = "0x4001154")]
		[FieldOffset(Offset = "0x18")]
		private byte[] encoded;
	}
}
