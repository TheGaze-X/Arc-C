using System;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x02000129 RID: 297
	[Token(Token = "0x2000129")]
	public class AsnEncodedData
	{
		// Token: 0x06000741 RID: 1857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000741")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected AsnEncodedData()
		{
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000742")]
		[Address(RVA = "0x511E040", Offset = "0x511CC40", VA = "0x18511E040")]
		public AsnEncodedData(string oid, byte[] rawData)
		{
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000743")]
		[Address(RVA = "0x511DFF0", Offset = "0x511CBF0", VA = "0x18511DFF0")]
		public AsnEncodedData(Oid oid, byte[] rawData)
		{
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000744")]
		[Address(RVA = "0x511E0E0", Offset = "0x511CCE0", VA = "0x18511E0E0")]
		public AsnEncodedData(AsnEncodedData asnEncodedData)
		{
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000745 RID: 1861 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000746 RID: 1862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000145")]
		public Oid Oid
		{
			[Token(Token = "0x6000745")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000746")]
			[Address(RVA = "0x511E210", Offset = "0x511CE10", VA = "0x18511E210")]
			set
			{
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000747 RID: 1863 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000748 RID: 1864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000146")]
		public byte[] RawData
		{
			[Token(Token = "0x6000747")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000748")]
			[Address(RVA = "0x511E2D0", Offset = "0x511CED0", VA = "0x18511E2D0")]
			set
			{
			}
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000749")]
		[Address(RVA = "0x511D030", Offset = "0x511BC30", VA = "0x18511D030", Slot = "4")]
		public virtual void CopyFrom(AsnEncodedData asnEncodedData)
		{
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600074A")]
		[Address(RVA = "0x511D450", Offset = "0x511C050", VA = "0x18511D450", Slot = "5")]
		public virtual string Format(bool multiLine)
		{
			return null;
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600074B")]
		[Address(RVA = "0x511DE20", Offset = "0x511CA20", VA = "0x18511DE20", Slot = "6")]
		internal virtual string ToString(bool multiLine)
		{
			return null;
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600074C")]
		[Address(RVA = "0x511D180", Offset = "0x511BD80", VA = "0x18511D180")]
		internal string Default(bool multiLine)
		{
			return null;
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600074D")]
		[Address(RVA = "0x511CEA0", Offset = "0x511BAA0", VA = "0x18511CEA0")]
		internal string BasicConstraintsExtension(bool multiLine)
		{
			return null;
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600074E")]
		[Address(RVA = "0x511D2C0", Offset = "0x511BEC0", VA = "0x18511D2C0")]
		internal string EnhancedKeyUsageExtension(bool multiLine)
		{
			return null;
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600074F")]
		[Address(RVA = "0x511D4E0", Offset = "0x511C0E0", VA = "0x18511D4E0")]
		internal string KeyUsageExtension(bool multiLine)
		{
			return null;
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000750")]
		[Address(RVA = "0x511DC90", Offset = "0x511C890", VA = "0x18511DC90")]
		internal string SubjectKeyIdentifierExtension(bool multiLine)
		{
			return null;
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000751")]
		[Address(RVA = "0x511D9D0", Offset = "0x511C5D0", VA = "0x18511D9D0")]
		internal string SubjectAltName(bool multiLine)
		{
			return null;
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000752")]
		[Address(RVA = "0x511D670", Offset = "0x511C270", VA = "0x18511D670")]
		internal string NetscapeCertType(bool multiLine)
		{
			return null;
		}

		// Token: 0x0400052B RID: 1323
		[Token(Token = "0x400052B")]
		[FieldOffset(Offset = "0x10")]
		internal Oid _oid;

		// Token: 0x0400052C RID: 1324
		[Token(Token = "0x400052C")]
		[FieldOffset(Offset = "0x18")]
		internal byte[] _raw;
	}
}
