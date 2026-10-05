using System;
using System.Collections;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x0200012B RID: 299
	[Token(Token = "0x200012B")]
	internal class NamespaceList
	{
		// Token: 0x06000A17 RID: 2583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A17")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public NamespaceList()
		{
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A18")]
		[Address(RVA = "0x5005970", Offset = "0x5004570", VA = "0x185005970")]
		public NamespaceList(string namespaces, string targetNamespace)
		{
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000A19 RID: 2585 RVA: 0x00005550 File Offset: 0x00003750
		[Token(Token = "0x170002B6")]
		public NamespaceList.ListType Type
		{
			[Token(Token = "0x6000A19")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return NamespaceList.ListType.Any;
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000A1A RID: 2586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002B7")]
		public string Excluded
		{
			[Token(Token = "0x6000A1A")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000A1B RID: 2587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002B8")]
		public ICollection Enumerate
		{
			[Token(Token = "0x6000A1B")]
			[Address(RVA = "0x5005BF0", Offset = "0x50047F0", VA = "0x185005BF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x00005568 File Offset: 0x00003768
		[Token(Token = "0x6000A1C")]
		[Address(RVA = "0x5005430", Offset = "0x5004030", VA = "0x185005430", Slot = "4")]
		public virtual bool Allows(string ns)
		{
			return default(bool);
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x00005580 File Offset: 0x00003780
		[Token(Token = "0x6000A1D")]
		[Address(RVA = "0x50054E0", Offset = "0x50040E0", VA = "0x1850054E0")]
		public bool Allows(XmlQualifiedName qname)
		{
			return default(bool);
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A1E")]
		[Address(RVA = "0x5005540", Offset = "0x5004140", VA = "0x185005540", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000512 RID: 1298
		[Token(Token = "0x4000512")]
		[FieldOffset(Offset = "0x10")]
		private NamespaceList.ListType type;

		// Token: 0x04000513 RID: 1299
		[Token(Token = "0x4000513")]
		[FieldOffset(Offset = "0x18")]
		private Hashtable set;

		// Token: 0x04000514 RID: 1300
		[Token(Token = "0x4000514")]
		[FieldOffset(Offset = "0x20")]
		private string targetNamespace;

		// Token: 0x0200012C RID: 300
		[Token(Token = "0x200012C")]
		public enum ListType
		{
			// Token: 0x04000516 RID: 1302
			[Token(Token = "0x4000516")]
			Any,
			// Token: 0x04000517 RID: 1303
			[Token(Token = "0x4000517")]
			Other,
			// Token: 0x04000518 RID: 1304
			[Token(Token = "0x4000518")]
			Set
		}
	}
}
