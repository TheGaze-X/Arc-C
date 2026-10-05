using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x02000025 RID: 37
	[Token(Token = "0x2000025")]
	internal class QueryOutputWriter : XmlRawWriter
	{
		// Token: 0x060000B7 RID: 183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x4F79A00", Offset = "0x4F78600", VA = "0x184F79A00")]
		public QueryOutputWriter(XmlRawWriter writer, XmlWriterSettings settings)
		{
		}

		// Token: 0x17000033 RID: 51
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000033")]
		internal override IXmlNamespaceResolver NamespaceResolver
		{
			[Token(Token = "0x60000B8")]
			[Address(RVA = "0x4F79D20", Offset = "0x4F78920", VA = "0x184F79D20", Slot = "33")]
			set
			{
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x4F79960", Offset = "0x4F78560", VA = "0x184F79960", Slot = "34")]
		internal override void WriteXmlDeclaration(XmlStandalone standalone)
		{
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x4F799B0", Offset = "0x4F785B0", VA = "0x184F799B0", Slot = "35")]
		internal override void WriteXmlDeclaration(string xmldecl)
		{
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x4F78F00", Offset = "0x4F77B00", VA = "0x184F78F00", Slot = "8")]
		public override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x4F79500", Offset = "0x4F78100", VA = "0x184F79500", Slot = "9")]
		public override void WriteStartElement(string prefix, string localName, string ns)
		{
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x4F78FA0", Offset = "0x4F77BA0", VA = "0x184F78FA0", Slot = "38")]
		internal override void WriteEndElement(string prefix, string localName, string ns)
		{
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x4F79120", Offset = "0x4F77D20", VA = "0x184F79120", Slot = "39")]
		internal override void WriteFullEndElement(string prefix, string localName, string ns)
		{
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x4F78CC0", Offset = "0x4F778C0", VA = "0x184F78CC0", Slot = "36")]
		internal override void StartElementContent()
		{
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x4F79480", Offset = "0x4F78080", VA = "0x184F79480", Slot = "12")]
		public override void WriteStartAttribute(string prefix, string localName, string ns)
		{
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x4F78F50", Offset = "0x4F77B50", VA = "0x184F78F50", Slot = "13")]
		public override void WriteEndAttribute()
		{
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x4F79200", Offset = "0x4F77E00", VA = "0x184F79200", Slot = "40")]
		internal override void WriteNamespaceDeclaration(string prefix, string ns)
		{
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x00002208 File Offset: 0x00000408
		[Token(Token = "0x17000034")]
		internal override bool SupportsNamespaceDeclarationInChunks
		{
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0x4F79CD0", Offset = "0x4F788D0", VA = "0x184F79CD0", Slot = "41")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x4F79720", Offset = "0x4F78320", VA = "0x184F79720", Slot = "42")]
		internal override void WriteStartNamespaceDeclaration(string prefix)
		{
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x4F79080", Offset = "0x4F77C80", VA = "0x184F79080", Slot = "43")]
		internal override void WriteEndNamespaceDeclaration()
		{
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x4F78D00", Offset = "0x4F77900", VA = "0x184F78D00", Slot = "14")]
		public override void WriteCData(string text)
		{
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x4F78EA0", Offset = "0x4F77AA0", VA = "0x184F78EA0", Slot = "15")]
		public override void WriteComment(string text)
		{
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x4F79260", Offset = "0x4F77E60", VA = "0x184F79260", Slot = "16")]
		public override void WriteProcessingInstruction(string name, string text)
		{
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x4F798A0", Offset = "0x4F784A0", VA = "0x184F798A0", Slot = "19")]
		public override void WriteWhitespace(string ws)
		{
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x4F79770", Offset = "0x4F78370", VA = "0x184F79770", Slot = "20")]
		public override void WriteString(string text)
		{
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x4F78DB0", Offset = "0x4F779B0", VA = "0x184F78DB0", Slot = "22")]
		public override void WriteChars(char[] buffer, int index, int count)
		{
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x4F790C0", Offset = "0x4F77CC0", VA = "0x184F790C0", Slot = "17")]
		public override void WriteEntityRef(string name)
		{
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x4F78D50", Offset = "0x4F77950", VA = "0x184F78D50", Slot = "18")]
		public override void WriteCharEntity(char ch)
		{
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x4F79830", Offset = "0x4F78430", VA = "0x184F79830", Slot = "21")]
		public override void WriteSurrogateCharEntity(char lowChar, char highChar)
		{
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x4F792D0", Offset = "0x4F77ED0", VA = "0x184F792D0", Slot = "23")]
		public override void WriteRaw(char[] buffer, int index, int count)
		{
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x4F793C0", Offset = "0x4F77FC0", VA = "0x184F793C0", Slot = "24")]
		public override void WriteRaw(string data)
		{
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x4F78B70", Offset = "0x4F77770", VA = "0x184F78B70", Slot = "28")]
		public override void Close()
		{
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x4F78C40", Offset = "0x4F77840", VA = "0x184F78C40", Slot = "29")]
		public override void Flush()
		{
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00002220 File Offset: 0x00000420
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x4F78C80", Offset = "0x4F77880", VA = "0x184F78C80")]
		private bool StartCDataSection()
		{
			return default(bool);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x4ADC600", Offset = "0x4ADB200", VA = "0x184ADC600")]
		private void EndCDataSection()
		{
		}

		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x20")]
		private XmlRawWriter wrapped;

		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x28")]
		private bool inCDataSection;

		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<XmlQualifiedName, int> lookupCDataElems;

		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x38")]
		private BitStack bitsCData;

		// Token: 0x04000055 RID: 85
		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x40")]
		private XmlQualifiedName qnameCData;

		// Token: 0x04000056 RID: 86
		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x48")]
		private bool outputDocType;

		// Token: 0x04000057 RID: 87
		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x49")]
		private bool checkWellFormedDoc;

		// Token: 0x04000058 RID: 88
		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x4A")]
		private bool hasDocElem;

		// Token: 0x04000059 RID: 89
		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x4B")]
		private bool inAttr;

		// Token: 0x0400005A RID: 90
		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x50")]
		private string systemId;

		// Token: 0x0400005B RID: 91
		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x58")]
		private string publicId;

		// Token: 0x0400005C RID: 92
		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x60")]
		private int depth;
	}
}
