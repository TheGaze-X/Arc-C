using System;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x020000AD RID: 173
	[Token(Token = "0x20000AD")]
	[Serializable]
	public class XmlQualifiedName
	{
		// Token: 0x060007A2 RID: 1954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x4FF8A30", Offset = "0x4FF7630", VA = "0x184FF8A30")]
		public XmlQualifiedName()
		{
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x4FF88B0", Offset = "0x4FF74B0", VA = "0x184FF88B0")]
		public XmlQualifiedName(string name)
		{
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x4FF8980", Offset = "0x4FF7580", VA = "0x184FF8980")]
		public XmlQualifiedName(string name, string ns)
		{
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x060007A5 RID: 1957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001CE")]
		public string Namespace
		{
			[Token(Token = "0x60007A5")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x060007A6 RID: 1958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001CF")]
		public string Name
		{
			[Token(Token = "0x60007A6")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x000044B8 File Offset: 0x000026B8
		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x4FF8340", Offset = "0x4FF6F40", VA = "0x184FF8340", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x060007A8 RID: 1960 RVA: 0x000044D0 File Offset: 0x000026D0
		[Token(Token = "0x170001D0")]
		public bool IsEmpty
		{
			[Token(Token = "0x60007A8")]
			[Address(RVA = "0x4FF8B00", Offset = "0x4FF7700", VA = "0x184FF8B00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x4FF86E0", Offset = "0x4FF72E0", VA = "0x184FF86E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x000044E8 File Offset: 0x000026E8
		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x4FF7FD0", Offset = "0x4FF6BD0", VA = "0x184FF7FD0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x00004500 File Offset: 0x00002700
		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x4FF8B40", Offset = "0x4FF7740", VA = "0x184FF8B40")]
		public static bool operator ==(XmlQualifiedName a, XmlQualifiedName b)
		{
			return default(bool);
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x00004518 File Offset: 0x00002718
		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x4FF8BB0", Offset = "0x4FF77B0", VA = "0x184FF8BB0")]
		public static bool operator !=(XmlQualifiedName a, XmlQualifiedName b)
		{
			return default(bool);
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x4FF8100", Offset = "0x4FF6D00", VA = "0x184FF8100")]
		private static XmlQualifiedName.HashCodeOfStringDelegate GetHashCodeDelegate()
		{
			return null;
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x00004530 File Offset: 0x00002730
		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40")]
		private static bool IsRandomizedHashingDisabled()
		{
			return default(bool);
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x00004548 File Offset: 0x00002748
		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x4440300", Offset = "0x443EF00", VA = "0x184440300")]
		private static int GetHashCodeOfString(string s, int length, long additionalEntropy)
		{
			return 0;
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x4FF8440", Offset = "0x4FF7040", VA = "0x184FF8440")]
		internal void Init(string name, string ns)
		{
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x4FF8480", Offset = "0x4FF7080", VA = "0x184FF8480")]
		internal static XmlQualifiedName Parse(string s, IXmlNamespaceResolver nsmgr, out string prefix)
		{
			return null;
		}

		// Token: 0x040003E1 RID: 993
		[Token(Token = "0x40003E1")]
		[FieldOffset(Offset = "0x0")]
		private static XmlQualifiedName.HashCodeOfStringDelegate hashCodeDelegate;

		// Token: 0x040003E2 RID: 994
		[Token(Token = "0x40003E2")]
		[FieldOffset(Offset = "0x10")]
		private string name;

		// Token: 0x040003E3 RID: 995
		[Token(Token = "0x40003E3")]
		[FieldOffset(Offset = "0x18")]
		private string ns;

		// Token: 0x040003E4 RID: 996
		[Token(Token = "0x40003E4")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		private int hash;

		// Token: 0x040003E5 RID: 997
		[Token(Token = "0x40003E5")]
		[FieldOffset(Offset = "0x8")]
		public static readonly XmlQualifiedName Empty;

		// Token: 0x020000AE RID: 174
		// (Invoke) Token: 0x060007B4 RID: 1972
		[Token(Token = "0x20000AE")]
		private delegate int HashCodeOfStringDelegate(string s, int sLen, long additionalEntropy);
	}
}
