using System;
using System.Collections;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020003DA RID: 986
	[Token(Token = "0x20003DA")]
	internal class LazyDerSet : DerSet
	{
		// Token: 0x06002122 RID: 8482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002122")]
		[Address(RVA = "0x5340A50", Offset = "0x533F650", VA = "0x185340A50")]
		internal LazyDerSet(byte[] encoded)
		{
		}

		// Token: 0x06002123 RID: 8483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002123")]
		[Address(RVA = "0x5340920", Offset = "0x533F520", VA = "0x185340920")]
		private void Parse()
		{
		}

		// Token: 0x1700043B RID: 1083
		[Token(Token = "0x1700043B")]
		public override Asn1Encodable this[int index]
		{
			[Token(Token = "0x6002124")]
			[Address(RVA = "0x5340AE0", Offset = "0x533F6E0", VA = "0x185340AE0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002125 RID: 8485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002125")]
		[Address(RVA = "0x5340900", Offset = "0x533F500", VA = "0x185340900", Slot = "10")]
		public override IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06002126 RID: 8486 RVA: 0x0000F6F0 File Offset: 0x0000D8F0
		[Token(Token = "0x1700043C")]
		public override int Count
		{
			[Token(Token = "0x6002126")]
			[Address(RVA = "0x5340AC0", Offset = "0x533F6C0", VA = "0x185340AC0", Slot = "12")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06002127 RID: 8487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002127")]
		[Address(RVA = "0x53407C0", Offset = "0x533F3C0", VA = "0x1853407C0", Slot = "6")]
		internal override void Encode(DerOutputStream derOut)
		{
		}

		// Token: 0x04001155 RID: 4437
		[Token(Token = "0x4001155")]
		[FieldOffset(Offset = "0x18")]
		private byte[] encoded;
	}
}
