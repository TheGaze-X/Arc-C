using System;
using System.Text;
using Il2CppDummyDll;

namespace Mono.Security.X509
{
	// Token: 0x02000016 RID: 22
	[Token(Token = "0x2000016")]
	public class X509Extension
	{
		// Token: 0x060000C5 RID: 197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x4A8E0E0", Offset = "0x4A8CCE0", VA = "0x184A8E0E0")]
		public X509Extension(ASN1 asn1)
		{
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x4A8E450", Offset = "0x4A8D050", VA = "0x184A8E450")]
		public X509Extension(X509Extension extension)
		{
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "4")]
		protected virtual void Decode()
		{
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
		protected virtual void Encode()
		{
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003E")]
		public string Oid
		{
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000CA RID: 202 RVA: 0x000024A8 File Offset: 0x000006A8
		[Token(Token = "0x1700003F")]
		public bool Critical
		{
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x4F4E70", Offset = "0x4F3A70", VA = "0x1804F4E70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000040")]
		public ASN1 Value
		{
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x4A8E5F0", Offset = "0x4A8D1F0", VA = "0x184A8E5F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000024C0 File Offset: 0x000006C0
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x4A8DC20", Offset = "0x4A8C820", VA = "0x184A8DC20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x000024D8 File Offset: 0x000006D8
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x2824310", Offset = "0x2822F10", VA = "0x182824310", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x4A8DED0", Offset = "0x4A8CAD0", VA = "0x184A8DED0")]
		private void WriteLine(StringBuilder sb, int n, int pos)
		{
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x4A8DDA0", Offset = "0x4A8C9A0", VA = "0x184A8DDA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0400006F RID: 111
		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x10")]
		protected string extnOid;

		// Token: 0x04000070 RID: 112
		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x18")]
		protected bool extnCritical;

		// Token: 0x04000071 RID: 113
		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x20")]
		protected ASN1 extnValue;
	}
}
