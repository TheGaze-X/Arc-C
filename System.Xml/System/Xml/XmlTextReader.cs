using System;
using System.ComponentModel;
using System.IO;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x0200003C RID: 60
	[Token(Token = "0x200003C")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class XmlTextReader : XmlReader, IXmlNamespaceResolver
	{
		// Token: 0x06000231 RID: 561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000231")]
		[Address(RVA = "0x4FAE850", Offset = "0x4FAD450", VA = "0x184FAE850")]
		public XmlTextReader(TextReader input, XmlNameTable nt)
		{
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000232 RID: 562 RVA: 0x00002448 File Offset: 0x00000648
		[Token(Token = "0x1700006D")]
		public override XmlNodeType NodeType
		{
			[Token(Token = "0x6000232")]
			[Address(RVA = "0x4FAEA60", Offset = "0x4FAD660", VA = "0x184FAEA60", Slot = "6")]
			get
			{
				return XmlNodeType.None;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000233 RID: 563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006E")]
		public override string Name
		{
			[Token(Token = "0x6000233")]
			[Address(RVA = "0x4DFCA90", Offset = "0x4DFB690", VA = "0x184DFCA90", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000234 RID: 564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006F")]
		public override string LocalName
		{
			[Token(Token = "0x6000234")]
			[Address(RVA = "0x4FAEA10", Offset = "0x4FAD610", VA = "0x184FAEA10", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000235 RID: 565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000070")]
		public override string NamespaceURI
		{
			[Token(Token = "0x6000235")]
			[Address(RVA = "0x4BAB620", Offset = "0x4BAA220", VA = "0x184BAB620", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000236 RID: 566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000071")]
		public override string Prefix
		{
			[Token(Token = "0x6000236")]
			[Address(RVA = "0x4BAB7B0", Offset = "0x4BAA3B0", VA = "0x184BAB7B0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000237 RID: 567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000072")]
		public override string Value
		{
			[Token(Token = "0x6000237")]
			[Address(RVA = "0x4BAB760", Offset = "0x4BAA360", VA = "0x184BAB760", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000238 RID: 568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000073")]
		public override string BaseURI
		{
			[Token(Token = "0x6000238")]
			[Address(RVA = "0x4FAE920", Offset = "0x4FAD520", VA = "0x184FAE920", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000239 RID: 569 RVA: 0x00002460 File Offset: 0x00000660
		[Token(Token = "0x17000074")]
		public override bool IsEmptyElement
		{
			[Token(Token = "0x6000239")]
			[Address(RVA = "0x4FAE9C0", Offset = "0x4FAD5C0", VA = "0x184FAE9C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600023A RID: 570 RVA: 0x00002478 File Offset: 0x00000678
		[Token(Token = "0x17000075")]
		public override bool IsDefault
		{
			[Token(Token = "0x600023A")]
			[Address(RVA = "0x4FAE970", Offset = "0x4FAD570", VA = "0x184FAE970", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00002490 File Offset: 0x00000690
		[Token(Token = "0x600023B")]
		[Address(RVA = "0x4FAE740", Offset = "0x4FAD340", VA = "0x184FAE740", Slot = "16")]
		public override bool MoveToAttribute(string name)
		{
			return default(bool);
		}

		// Token: 0x0600023C RID: 572 RVA: 0x000024A8 File Offset: 0x000006A8
		[Token(Token = "0x600023C")]
		[Address(RVA = "0x4BAB6C0", Offset = "0x4BAA2C0", VA = "0x184BAB6C0", Slot = "17")]
		public override bool MoveToFirstAttribute()
		{
			return default(bool);
		}

		// Token: 0x0600023D RID: 573 RVA: 0x000024C0 File Offset: 0x000006C0
		[Token(Token = "0x600023D")]
		[Address(RVA = "0x4E385D0", Offset = "0x4E371D0", VA = "0x184E385D0", Slot = "18")]
		public override bool MoveToNextAttribute()
		{
			return default(bool);
		}

		// Token: 0x0600023E RID: 574 RVA: 0x000024D8 File Offset: 0x000006D8
		[Token(Token = "0x600023E")]
		[Address(RVA = "0x4E38AA0", Offset = "0x4E376A0", VA = "0x184E38AA0", Slot = "19")]
		public override bool MoveToElement()
		{
			return default(bool);
		}

		// Token: 0x0600023F RID: 575 RVA: 0x000024F0 File Offset: 0x000006F0
		[Token(Token = "0x600023F")]
		[Address(RVA = "0x4E38AF0", Offset = "0x4E376F0", VA = "0x184E38AF0", Slot = "20")]
		public override bool ReadAttributeValue()
		{
			return default(bool);
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00002508 File Offset: 0x00000708
		[Token(Token = "0x6000240")]
		[Address(RVA = "0x4FAE7A0", Offset = "0x4FAD3A0", VA = "0x184FAE7A0", Slot = "21")]
		public override bool Read()
		{
			return default(bool);
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000241")]
		[Address(RVA = "0x187A750", Offset = "0x1879350", VA = "0x18187A750", Slot = "22")]
		public override void Close()
		{
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000242 RID: 578 RVA: 0x00002520 File Offset: 0x00000720
		[Token(Token = "0x17000076")]
		public override ReadState ReadState
		{
			[Token(Token = "0x6000242")]
			[Address(RVA = "0x4C5C060", Offset = "0x4C5AC60", VA = "0x184C5C060", Slot = "23")]
			get
			{
				return ReadState.Initial;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000243 RID: 579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000077")]
		public override XmlNameTable NameTable
		{
			[Token(Token = "0x6000243")]
			[Address(RVA = "0x4BAB670", Offset = "0x4BAA270", VA = "0x184BAB670", Slot = "24")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000244")]
		[Address(RVA = "0x4FAE6E0", Offset = "0x4FAD2E0", VA = "0x184FAE6E0", Slot = "25")]
		public override string LookupNamespace(string prefix)
		{
			return null;
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000245 RID: 581 RVA: 0x00002538 File Offset: 0x00000738
		[Token(Token = "0x17000078")]
		public override bool CanResolveEntity
		{
			[Token(Token = "0x6000245")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000246")]
		[Address(RVA = "0x4FAE7F0", Offset = "0x4FAD3F0", VA = "0x184FAE7F0", Slot = "27")]
		public override void ResolveEntity()
		{
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000247")]
		[Address(RVA = "0x3DD3E40", Offset = "0x3DD2A40", VA = "0x183DD3E40", Slot = "30")]
		private string LookupNamespace(string prefix)
		{
			return null;
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000248")]
		[Address(RVA = "0x4FAE830", Offset = "0x4FAD430", VA = "0x184FAE830", Slot = "31")]
		private string LookupPrefix(string namespaceName)
		{
			return null;
		}

		// Token: 0x17000079 RID: 121
		// (set) Token: 0x06000249 RID: 585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000079")]
		public EntityHandling EntityHandling
		{
			[Token(Token = "0x6000249")]
			[Address(RVA = "0x4FAEAB0", Offset = "0x4FAD6B0", VA = "0x184FAEAB0")]
			set
			{
			}
		}

		// Token: 0x1700007A RID: 122
		// (set) Token: 0x0600024A RID: 586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700007A")]
		public XmlResolver XmlResolver
		{
			[Token(Token = "0x600024A")]
			[Address(RVA = "0x4FAEAD0", Offset = "0x4FAD6D0", VA = "0x184FAEAD0")]
			set
			{
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600024B RID: 587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007B")]
		internal XmlTextReaderImpl Impl
		{
			[Token(Token = "0x600024B")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700007C RID: 124
		// (set) Token: 0x0600024C RID: 588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700007C")]
		internal bool XmlValidatingReaderCompatibilityMode
		{
			[Token(Token = "0x600024C")]
			[Address(RVA = "0x4FAEAF0", Offset = "0x4FAD6F0", VA = "0x184FAEAF0")]
			set
			{
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600024D RID: 589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007D")]
		internal override IDtdInfo DtdInfo
		{
			[Token(Token = "0x600024D")]
			[Address(RVA = "0x4C679C0", Offset = "0x4C665C0", VA = "0x184C679C0", Slot = "29")]
			get
			{
				return null;
			}
		}

		// Token: 0x040000FA RID: 250
		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x10")]
		private XmlTextReaderImpl impl;
	}
}
