using System;
using Il2CppDummyDll;

namespace System.Xml.Linq
{
	// Token: 0x02000003 RID: 3
	[Token(Token = "0x2000003")]
	public class XAttribute : XObject
	{
		// Token: 0x06000002 RID: 2 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x4F867A0", Offset = "0x4F853A0", VA = "0x184F867A0")]
		public XAttribute(XName name, object value)
		{
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x4F868C0", Offset = "0x4F854C0", VA = "0x184F868C0")]
		public XAttribute(XAttribute other)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00002058 File Offset: 0x00000258
		[Token(Token = "0x17000001")]
		public bool IsNamespaceDeclaration
		{
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x4F86960", Offset = "0x4F85560", VA = "0x184F86960")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000002")]
		public XName Name
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002070 File Offset: 0x00000270
		[Token(Token = "0x17000003")]
		public override XmlNodeType NodeType
		{
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x54B0E0", Offset = "0x549CE0", VA = "0x18054B0E0", Slot = "4")]
			get
			{
				return XmlNodeType.None;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000008 RID: 8 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000004")]
		public string Value
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x4F869E0", Offset = "0x4F855E0", VA = "0x184F869E0")]
			set
			{
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x4F86100", Offset = "0x4F84D00", VA = "0x184F86100", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x4F85F00", Offset = "0x4F84B00", VA = "0x184F85F00")]
		internal string GetPrefixOfNamespace(XNamespace ns)
		{
			return null;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x4F863C0", Offset = "0x4F84FC0", VA = "0x184F863C0")]
		private static void ValidateAttribute(XName name, string value)
		{
		}

		// Token: 0x04000001 RID: 1
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x20")]
		internal XAttribute next;

		// Token: 0x04000002 RID: 2
		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x28")]
		internal XName name;

		// Token: 0x04000003 RID: 3
		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x30")]
		internal string value;
	}
}
