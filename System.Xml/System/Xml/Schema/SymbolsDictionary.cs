using System;
using System.Collections;
using System.Reflection;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x020000C5 RID: 197
	[Token(Token = "0x20000C5")]
	[DefaultMember("Item")]
	internal class SymbolsDictionary
	{
		// Token: 0x06000812 RID: 2066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000812")]
		[Address(RVA = "0x4FE7D50", Offset = "0x4FE6950", VA = "0x184FE7D50")]
		public SymbolsDictionary()
		{
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000813 RID: 2067 RVA: 0x000047A0 File Offset: 0x000029A0
		[Token(Token = "0x170001F3")]
		public int Count
		{
			[Token(Token = "0x6000813")]
			[Address(RVA = "0x4FE7E00", Offset = "0x4FE6A00", VA = "0x184FE7E00")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000814 RID: 2068 RVA: 0x000047B8 File Offset: 0x000029B8
		// (set) Token: 0x06000815 RID: 2069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001F4")]
		public bool IsUpaEnforced
		{
			[Token(Token = "0x6000814")]
			[Address(RVA = "0x4FD4C0", Offset = "0x4FC0C0", VA = "0x1804FD4C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000815")]
			[Address(RVA = "0x14D9990", Offset = "0x14D8590", VA = "0x1814D9990")]
			set
			{
			}
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x000047D0 File Offset: 0x000029D0
		[Token(Token = "0x6000816")]
		[Address(RVA = "0x4FE6F00", Offset = "0x4FE5B00", VA = "0x184FE6F00")]
		public int AddName(XmlQualifiedName name, object particle)
		{
			return 0;
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000817")]
		[Address(RVA = "0x4FE70A0", Offset = "0x4FE5CA0", VA = "0x184FE70A0")]
		public void AddNamespaceList(NamespaceList list, object particle, bool allowLocal)
		{
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000818")]
		[Address(RVA = "0x4FE7370", Offset = "0x4FE5F70", VA = "0x184FE7370")]
		private void AddWildcard(string wildcard, object particle)
		{
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000819")]
		[Address(RVA = "0x4FE75A0", Offset = "0x4FE61A0", VA = "0x184FE75A0")]
		public ICollection GetNamespaceListSymbols(NamespaceList list)
		{
			return null;
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x000047E8 File Offset: 0x000029E8
		[Token(Token = "0x600081A")]
		[Address(RVA = "0x4FE7540", Offset = "0x4FE6140", VA = "0x184FE7540")]
		public bool Exists(XmlQualifiedName name)
		{
			return default(bool);
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600081B")]
		[Address(RVA = "0x4FE7CF0", Offset = "0x4FE68F0", VA = "0x184FE7CF0")]
		public object GetParticle(int symbol)
		{
			return null;
		}

		// Token: 0x0400041A RID: 1050
		[Token(Token = "0x400041A")]
		[FieldOffset(Offset = "0x10")]
		private int last;

		// Token: 0x0400041B RID: 1051
		[Token(Token = "0x400041B")]
		[FieldOffset(Offset = "0x18")]
		private Hashtable names;

		// Token: 0x0400041C RID: 1052
		[Token(Token = "0x400041C")]
		[FieldOffset(Offset = "0x20")]
		private Hashtable wildcards;

		// Token: 0x0400041D RID: 1053
		[Token(Token = "0x400041D")]
		[FieldOffset(Offset = "0x28")]
		private ArrayList particles;

		// Token: 0x0400041E RID: 1054
		[Token(Token = "0x400041E")]
		[FieldOffset(Offset = "0x30")]
		private object particleLast;

		// Token: 0x0400041F RID: 1055
		[Token(Token = "0x400041F")]
		[FieldOffset(Offset = "0x38")]
		private bool isUpaEnforced;
	}
}
