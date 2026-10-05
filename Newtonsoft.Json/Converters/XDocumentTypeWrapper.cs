using System;
using System.Xml.Linq;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x02000114 RID: 276
	[Token(Token = "0x2000114")]
	internal class XDocumentTypeWrapper : XObjectWrapper, IXmlDocumentType, IXmlNode
	{
		// Token: 0x06000AC9 RID: 2761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AC9")]
		[Address(RVA = "0x4DF2E10", Offset = "0x4DF1A10", VA = "0x184DF2E10")]
		public XDocumentTypeWrapper(XDocumentType documentType)
		{
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000ACA RID: 2762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000202")]
		public string Name
		{
			[Token(Token = "0x6000ACA")]
			[Address(RVA = "0x4A52E30", Offset = "0x4A51A30", VA = "0x184A52E30", Slot = "23")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000ACB RID: 2763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000203")]
		public string System
		{
			[Token(Token = "0x6000ACB")]
			[Address(RVA = "0x4DF2EE0", Offset = "0x4DF1AE0", VA = "0x184DF2EE0", Slot = "24")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000ACC RID: 2764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000204")]
		public string Public
		{
			[Token(Token = "0x6000ACC")]
			[Address(RVA = "0x5BA120", Offset = "0x5B8D20", VA = "0x1805BA120", Slot = "25")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000ACD RID: 2765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000205")]
		public string InternalSubset
		{
			[Token(Token = "0x6000ACD")]
			[Address(RVA = "0x4DF2E90", Offset = "0x4DF1A90", VA = "0x184DF2E90", Slot = "26")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000ACE RID: 2766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000206")]
		public override string LocalName
		{
			[Token(Token = "0x6000ACE")]
			[Address(RVA = "0x4DF2EB0", Offset = "0x4DF1AB0", VA = "0x184DF2EB0", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000415 RID: 1045
		[Token(Token = "0x4000415")]
		[FieldOffset(Offset = "0x18")]
		private readonly XDocumentType _documentType;
	}
}
