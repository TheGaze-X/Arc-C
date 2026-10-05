using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x020000AA RID: 170
	[Token(Token = "0x20000AA")]
	public class XmlNamespaceManager : IXmlNamespaceResolver, IEnumerable
	{
		// Token: 0x06000795 RID: 1941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000795")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		internal XmlNamespaceManager()
		{
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000796")]
		[Address(RVA = "0x4FF7C50", Offset = "0x4FF6850", VA = "0x184FF7C50")]
		public XmlNamespaceManager(XmlNameTable nameTable)
		{
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000797 RID: 1943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001CC")]
		public virtual XmlNameTable NameTable
		{
			[Token(Token = "0x6000797")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000798 RID: 1944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001CD")]
		public virtual string DefaultNamespace
		{
			[Token(Token = "0x6000798")]
			[Address(RVA = "0x4FF7F40", Offset = "0x4FF6B40", VA = "0x184FF7F40", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000799")]
		[Address(RVA = "0x7CDBF0", Offset = "0x7CC7F0", VA = "0x1807CDBF0", Slot = "9")]
		public virtual void PushScope()
		{
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x00004488 File Offset: 0x00002688
		[Token(Token = "0x600079A")]
		[Address(RVA = "0x4FF79D0", Offset = "0x4FF65D0", VA = "0x184FF79D0", Slot = "10")]
		public virtual bool PopScope()
		{
			return default(bool);
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600079B")]
		[Address(RVA = "0x4FF70F0", Offset = "0x4FF5CF0", VA = "0x184FF70F0", Slot = "11")]
		public virtual void AddNamespace(string prefix, string uri)
		{
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600079C")]
		[Address(RVA = "0x4FF7AA0", Offset = "0x4FF66A0", VA = "0x184FF7AA0", Slot = "12")]
		public virtual void RemoveNamespace(string prefix, string uri)
		{
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600079D")]
		[Address(RVA = "0x4FF75E0", Offset = "0x4FF61E0", VA = "0x184FF75E0", Slot = "13")]
		public virtual IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600079E")]
		[Address(RVA = "0x4FF78C0", Offset = "0x4FF64C0", VA = "0x184FF78C0", Slot = "14")]
		public virtual string LookupNamespace(string prefix)
		{
			return null;
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x000044A0 File Offset: 0x000026A0
		[Token(Token = "0x600079F")]
		[Address(RVA = "0x4FF7740", Offset = "0x4FF6340", VA = "0x184FF7740")]
		private int LookupNamespaceDecl(string prefix)
		{
			return 0;
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x4FF7910", Offset = "0x4FF6510", VA = "0x184FF7910", Slot = "15")]
		public virtual string LookupPrefix(string uri)
		{
			return null;
		}

		// Token: 0x040003C2 RID: 962
		[Token(Token = "0x40003C2")]
		[FieldOffset(Offset = "0x10")]
		private XmlNamespaceManager.NamespaceDeclaration[] nsdecls;

		// Token: 0x040003C3 RID: 963
		[Token(Token = "0x40003C3")]
		[FieldOffset(Offset = "0x18")]
		private int lastDecl;

		// Token: 0x040003C4 RID: 964
		[Token(Token = "0x40003C4")]
		[FieldOffset(Offset = "0x20")]
		private XmlNameTable nameTable;

		// Token: 0x040003C5 RID: 965
		[Token(Token = "0x40003C5")]
		[FieldOffset(Offset = "0x28")]
		private int scopeId;

		// Token: 0x040003C6 RID: 966
		[Token(Token = "0x40003C6")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<string, int> hashTable;

		// Token: 0x040003C7 RID: 967
		[Token(Token = "0x40003C7")]
		[FieldOffset(Offset = "0x38")]
		private bool useHashtable;

		// Token: 0x040003C8 RID: 968
		[Token(Token = "0x40003C8")]
		[FieldOffset(Offset = "0x40")]
		private string xml;

		// Token: 0x040003C9 RID: 969
		[Token(Token = "0x40003C9")]
		[FieldOffset(Offset = "0x48")]
		private string xmlNs;

		// Token: 0x020000AB RID: 171
		[Token(Token = "0x20000AB")]
		private struct NamespaceDeclaration
		{
			// Token: 0x060007A1 RID: 1953 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60007A1")]
			[Address(RVA = "0x4FE1950", Offset = "0x4FE0550", VA = "0x184FE1950")]
			public void Set(string prefix, string uri, int scopeId, int previousNsIndex)
			{
			}

			// Token: 0x040003CA RID: 970
			[Token(Token = "0x40003CA")]
			[FieldOffset(Offset = "0x0")]
			public string prefix;

			// Token: 0x040003CB RID: 971
			[Token(Token = "0x40003CB")]
			[FieldOffset(Offset = "0x8")]
			public string uri;

			// Token: 0x040003CC RID: 972
			[Token(Token = "0x40003CC")]
			[FieldOffset(Offset = "0x10")]
			public int scopeId;

			// Token: 0x040003CD RID: 973
			[Token(Token = "0x40003CD")]
			[FieldOffset(Offset = "0x14")]
			public int previousNsIndex;
		}
	}
}
