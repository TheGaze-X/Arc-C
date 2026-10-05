using System;
using Il2CppDummyDll;

namespace System.Xml.Linq
{
	// Token: 0x02000011 RID: 17
	[Token(Token = "0x2000011")]
	internal struct ElementWriter
	{
		// Token: 0x0600007E RID: 126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x4F85370", Offset = "0x4F83F70", VA = "0x184F85370")]
		public ElementWriter(XmlWriter writer)
		{
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x4F84BE0", Offset = "0x4F837E0", VA = "0x184F84BE0")]
		public void WriteElement(XElement e)
		{
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x4F84700", Offset = "0x4F83300", VA = "0x184F84700")]
		private string GetPrefixOfNamespace(XNamespace ns, bool allowDefaultNamespace)
		{
			return null;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x4F847F0", Offset = "0x4F833F0", VA = "0x184F847F0")]
		private void PushAncestors(XElement e)
		{
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x4F84A30", Offset = "0x4F83630", VA = "0x184F84A30")]
		private void PushElement(XElement e)
		{
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x4F84F70", Offset = "0x4F83B70", VA = "0x184F84F70")]
		private void WriteEndElement()
		{
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x4F84FD0", Offset = "0x4F83BD0", VA = "0x184F84FD0")]
		private void WriteFullEndElement()
		{
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x4F85030", Offset = "0x4F83C30", VA = "0x184F85030")]
		private void WriteStartElement(XElement e)
		{
		}

		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x0")]
		private XmlWriter _writer;

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x8")]
		private NamespaceResolver _resolver;
	}
}
