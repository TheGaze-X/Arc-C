using System;
using System.IO;
using Il2CppDummyDll;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020003C4 RID: 964
	[Token(Token = "0x20003C4")]
	public class DerOutputStream : FilterStream
	{
		// Token: 0x0600209F RID: 8351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600209F")]
		[Address(RVA = "0x53352A0", Offset = "0x5333EA0", VA = "0x1853352A0")]
		public DerOutputStream(Stream os)
		{
		}

		// Token: 0x060020A0 RID: 8352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020A0")]
		[Address(RVA = "0x5334B60", Offset = "0x5333760", VA = "0x185334B60")]
		private void WriteLength(int length)
		{
		}

		// Token: 0x060020A1 RID: 8353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020A1")]
		[Address(RVA = "0x5334AC0", Offset = "0x53336C0", VA = "0x185334AC0")]
		internal void WriteEncoded(int tag, byte[] bytes)
		{
		}

		// Token: 0x060020A2 RID: 8354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020A2")]
		[Address(RVA = "0x53349E0", Offset = "0x53335E0", VA = "0x1853349E0")]
		internal void WriteEncoded(int tag, byte first, byte[] bytes)
		{
		}

		// Token: 0x060020A3 RID: 8355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020A3")]
		[Address(RVA = "0x5334940", Offset = "0x5333540", VA = "0x185334940")]
		internal void WriteEncoded(int tag, byte[] bytes, int offset, int length)
		{
		}

		// Token: 0x060020A4 RID: 8356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020A4")]
		[Address(RVA = "0x5335140", Offset = "0x5333D40", VA = "0x185335140")]
		internal void WriteTag(int flags, int tagNo)
		{
		}

		// Token: 0x060020A5 RID: 8357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020A5")]
		[Address(RVA = "0x53348C0", Offset = "0x53334C0", VA = "0x1853348C0")]
		internal void WriteEncoded(int flags, int tagNo, byte[] bytes)
		{
		}

		// Token: 0x060020A6 RID: 8358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020A6")]
		[Address(RVA = "0x5334C50", Offset = "0x5333850", VA = "0x185334C50")]
		protected void WriteNull()
		{
		}

		// Token: 0x060020A7 RID: 8359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020A7")]
		[Address(RVA = "0x5334CB0", Offset = "0x53338B0", VA = "0x185334CB0", Slot = "38")]
		[Obsolete("Use version taking an Asn1Encodable arg instead")]
		public virtual void WriteObject(object obj)
		{
		}

		// Token: 0x060020A8 RID: 8360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020A8")]
		[Address(RVA = "0x5334FC0", Offset = "0x5333BC0", VA = "0x185334FC0", Slot = "39")]
		public virtual void WriteObject(Asn1Encodable obj)
		{
		}

		// Token: 0x060020A9 RID: 8361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020A9")]
		[Address(RVA = "0x53350A0", Offset = "0x5333CA0", VA = "0x1853350A0", Slot = "40")]
		public virtual void WriteObject(Asn1Object obj)
		{
		}
	}
}
