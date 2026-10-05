using System;
using Il2CppDummyDll;

namespace System.Xml.Linq
{
	// Token: 0x02000012 RID: 18
	[Token(Token = "0x2000012")]
	internal struct NamespaceResolver
	{
		// Token: 0x06000086 RID: 134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x4F85730", Offset = "0x4F84330", VA = "0x184F85730")]
		public void PushScope()
		{
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x4F85690", Offset = "0x4F84290", VA = "0x184F85690")]
		public void PopScope()
		{
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x4F854A0", Offset = "0x4F840A0", VA = "0x184F854A0")]
		public void Add(string prefix, XNamespace ns)
		{
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x4F853A0", Offset = "0x4F83FA0", VA = "0x184F853A0")]
		public void AddFirst(string prefix, XNamespace ns)
		{
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x4F85590", Offset = "0x4F84190", VA = "0x184F85590")]
		public string GetPrefixOfNamespace(XNamespace ns, bool allowDefaultNamespace)
		{
			return null;
		}

		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x0")]
		private int _scope;

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x8")]
		private NamespaceResolver.NamespaceDeclaration _declaration;

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x10")]
		private NamespaceResolver.NamespaceDeclaration _rover;

		// Token: 0x02000013 RID: 19
		[Token(Token = "0x2000013")]
		private class NamespaceDeclaration
		{
			// Token: 0x0600008B RID: 139 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600008B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public NamespaceDeclaration()
			{
			}

			// Token: 0x04000029 RID: 41
			[Token(Token = "0x4000029")]
			[FieldOffset(Offset = "0x10")]
			public string prefix;

			// Token: 0x0400002A RID: 42
			[Token(Token = "0x400002A")]
			[FieldOffset(Offset = "0x18")]
			public XNamespace ns;

			// Token: 0x0400002B RID: 43
			[Token(Token = "0x400002B")]
			[FieldOffset(Offset = "0x20")]
			public int scope;

			// Token: 0x0400002C RID: 44
			[Token(Token = "0x400002C")]
			[FieldOffset(Offset = "0x28")]
			public NamespaceResolver.NamespaceDeclaration prev;
		}
	}
}
