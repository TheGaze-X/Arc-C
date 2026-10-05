using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x0200003D RID: 61
	[Token(Token = "0x200003D")]
	internal class XmlTextReaderImpl : XmlReader, IXmlNamespaceResolver
	{
		// Token: 0x0600024E RID: 590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600024E")]
		[Address(RVA = "0x4FA1430", Offset = "0x4FA0030", VA = "0x184FA1430")]
		internal XmlTextReaderImpl(XmlNameTable nt)
		{
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600024F")]
		[Address(RVA = "0x4FA11D0", Offset = "0x4F9FDD0", VA = "0x184FA11D0")]
		internal XmlTextReaderImpl(TextReader input, XmlNameTable nt)
		{
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000250")]
		[Address(RVA = "0x4FA1310", Offset = "0x4F9FF10", VA = "0x184FA1310")]
		internal XmlTextReaderImpl(string url, TextReader input, XmlNameTable nt)
		{
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000251")]
		[Address(RVA = "0x4FA1090", Offset = "0x4F9FC90", VA = "0x184FA1090")]
		internal XmlTextReaderImpl(string xmlFragment, XmlNodeType fragType, XmlParserContext context)
		{
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000252")]
		[Address(RVA = "0x4FA1910", Offset = "0x4FA0510", VA = "0x184FA1910")]
		internal XmlTextReaderImpl(string xmlFragment, XmlParserContext context)
		{
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000253")]
		[Address(RVA = "0x4F91670", Offset = "0x4F90270", VA = "0x184F91670")]
		private void FinishInitUriString()
		{
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000254")]
		[Address(RVA = "0x4F914E0", Offset = "0x4F900E0", VA = "0x184F914E0")]
		private void FinishInitStream()
		{
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000255")]
		[Address(RVA = "0x4F915C0", Offset = "0x4F901C0", VA = "0x184F915C0")]
		private void FinishInitTextReader()
		{
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000256 RID: 598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007E")]
		public override XmlReaderSettings Settings
		{
			[Token(Token = "0x6000256")]
			[Address(RVA = "0x4FA1D00", Offset = "0x4FA0900", VA = "0x184FA1D00", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000257 RID: 599 RVA: 0x00002550 File Offset: 0x00000750
		[Token(Token = "0x1700007F")]
		public override XmlNodeType NodeType
		{
			[Token(Token = "0x6000257")]
			[Address(RVA = "0x4FA1CB0", Offset = "0x4FA08B0", VA = "0x184FA1CB0", Slot = "6")]
			get
			{
				return XmlNodeType.None;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000258 RID: 600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000080")]
		public override string Name
		{
			[Token(Token = "0x6000258")]
			[Address(RVA = "0x4FA1C60", Offset = "0x4FA0860", VA = "0x184FA1C60", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000259 RID: 601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000081")]
		public override string LocalName
		{
			[Token(Token = "0x6000259")]
			[Address(RVA = "0x4FA1C40", Offset = "0x4FA0840", VA = "0x184FA1C40", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600025A RID: 602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000082")]
		public override string NamespaceURI
		{
			[Token(Token = "0x600025A")]
			[Address(RVA = "0x4FA1C90", Offset = "0x4FA0890", VA = "0x184FA1C90", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600025B RID: 603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000083")]
		public override string Prefix
		{
			[Token(Token = "0x600025B")]
			[Address(RVA = "0x4FA1CD0", Offset = "0x4FA08D0", VA = "0x184FA1CD0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600025C RID: 604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000084")]
		public override string Value
		{
			[Token(Token = "0x600025C")]
			[Address(RVA = "0x4FA1E70", Offset = "0x4FA0A70", VA = "0x184FA1E70", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600025D RID: 605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000085")]
		public override string BaseURI
		{
			[Token(Token = "0x600025D")]
			[Address(RVA = "0x4FA1A60", Offset = "0x4FA0660", VA = "0x184FA1A60", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600025E RID: 606 RVA: 0x00002568 File Offset: 0x00000768
		[Token(Token = "0x17000086")]
		public override bool IsEmptyElement
		{
			[Token(Token = "0x600025E")]
			[Address(RVA = "0x4FA1BD0", Offset = "0x4FA07D0", VA = "0x184FA1BD0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600025F RID: 607 RVA: 0x00002580 File Offset: 0x00000780
		[Token(Token = "0x17000087")]
		public override bool IsDefault
		{
			[Token(Token = "0x600025F")]
			[Address(RVA = "0x4FA1BA0", Offset = "0x4FA07A0", VA = "0x184FA1BA0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000260 RID: 608 RVA: 0x00002598 File Offset: 0x00000798
		[Token(Token = "0x17000088")]
		public override ReadState ReadState
		{
			[Token(Token = "0x6000260")]
			[Address(RVA = "0x4FA1CF0", Offset = "0x4FA08F0", VA = "0x184FA1CF0", Slot = "23")]
			get
			{
				return ReadState.Initial;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000261 RID: 609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000089")]
		public override XmlNameTable NameTable
		{
			[Token(Token = "0x6000261")]
			[Address(RVA = "0x2569110", Offset = "0x2567D10", VA = "0x182569110", Slot = "24")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000262 RID: 610 RVA: 0x000025B0 File Offset: 0x000007B0
		[Token(Token = "0x1700008A")]
		public override bool CanResolveEntity
		{
			[Token(Token = "0x6000262")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000263 RID: 611 RVA: 0x000025C8 File Offset: 0x000007C8
		[Token(Token = "0x6000263")]
		[Address(RVA = "0x4F94570", Offset = "0x4F93170", VA = "0x184F94570", Slot = "16")]
		public override bool MoveToAttribute(string name)
		{
			return default(bool);
		}

		// Token: 0x06000264 RID: 612 RVA: 0x000025E0 File Offset: 0x000007E0
		[Token(Token = "0x6000264")]
		[Address(RVA = "0x4F94880", Offset = "0x4F93480", VA = "0x184F94880", Slot = "17")]
		public override bool MoveToFirstAttribute()
		{
			return default(bool);
		}

		// Token: 0x06000265 RID: 613 RVA: 0x000025F8 File Offset: 0x000007F8
		[Token(Token = "0x6000265")]
		[Address(RVA = "0x4F94900", Offset = "0x4F93500", VA = "0x184F94900", Slot = "18")]
		public override bool MoveToNextAttribute()
		{
			return default(bool);
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00002610 File Offset: 0x00000810
		[Token(Token = "0x6000266")]
		[Address(RVA = "0x4F947F0", Offset = "0x4F933F0", VA = "0x184F947F0", Slot = "19")]
		public override bool MoveToElement()
		{
			return default(bool);
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000267")]
		[Address(RVA = "0x4F91A40", Offset = "0x4F90640", VA = "0x184F91A40")]
		private void FinishInit()
		{
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00002628 File Offset: 0x00000828
		[Token(Token = "0x6000268")]
		[Address(RVA = "0x4F9DE60", Offset = "0x4F9CA60", VA = "0x184F9DE60", Slot = "21")]
		public override bool Read()
		{
			return default(bool);
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000269")]
		[Address(RVA = "0x4F902C0", Offset = "0x4F8EEC0", VA = "0x184F902C0", Slot = "22")]
		public override void Close()
		{
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600026A")]
		[Address(RVA = "0x4F943A0", Offset = "0x4F92FA0", VA = "0x184F943A0", Slot = "25")]
		public override string LookupNamespace(string prefix)
		{
			return null;
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00002640 File Offset: 0x00000840
		[Token(Token = "0x600026B")]
		[Address(RVA = "0x4F9D610", Offset = "0x4F9C210", VA = "0x184F9D610", Slot = "20")]
		public override bool ReadAttributeValue()
		{
			return default(bool);
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600026C")]
		[Address(RVA = "0x4F9E8F0", Offset = "0x4F9D4F0", VA = "0x184F9E8F0", Slot = "27")]
		public override void ResolveEntity()
		{
		}

		// Token: 0x1700008B RID: 139
		// (set) Token: 0x0600026D RID: 621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700008B")]
		internal XmlReader OuterReader
		{
			[Token(Token = "0x600026D")]
			[Address(RVA = "0x4FA2340", Offset = "0x4FA0F40", VA = "0x184FA2340")]
			set
			{
			}
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600026E")]
		[Address(RVA = "0x43F8310", Offset = "0x43F6F10", VA = "0x1843F8310", Slot = "30")]
		private string LookupNamespace(string prefix)
		{
			return null;
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600026F")]
		[Address(RVA = "0x4F94510", Offset = "0x4F93110", VA = "0x184F94510", Slot = "31")]
		private string LookupPrefix(string namespaceName)
		{
			return null;
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000270")]
		[Address(RVA = "0x4F94510", Offset = "0x4F93110", VA = "0x184F94510")]
		internal string LookupPrefix(string namespaceName)
		{
			return null;
		}

		// Token: 0x1700008C RID: 140
		// (set) Token: 0x06000271 RID: 625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700008C")]
		internal bool Namespaces
		{
			[Token(Token = "0x6000271")]
			[Address(RVA = "0x4FA2090", Offset = "0x4FA0C90", VA = "0x184FA2090")]
			set
			{
			}
		}

		// Token: 0x1700008D RID: 141
		// (set) Token: 0x06000272 RID: 626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700008D")]
		internal EntityHandling EntityHandling
		{
			[Token(Token = "0x6000272")]
			[Address(RVA = "0x4FA1FF0", Offset = "0x4FA0BF0", VA = "0x184FA1FF0")]
			set
			{
			}
		}

		// Token: 0x1700008E RID: 142
		// (set) Token: 0x06000273 RID: 627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700008E")]
		internal XmlResolver XmlResolver
		{
			[Token(Token = "0x6000273")]
			[Address(RVA = "0x4FA2350", Offset = "0x4FA0F50", VA = "0x184FA2350")]
			set
			{
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000274 RID: 628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700008F")]
		internal XmlNameTable DtdParserProxy_NameTable
		{
			[Token(Token = "0x6000274")]
			[Address(RVA = "0x2569110", Offset = "0x2567D10", VA = "0x182569110")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000275 RID: 629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000090")]
		internal IXmlNamespaceResolver DtdParserProxy_NamespaceResolver
		{
			[Token(Token = "0x6000275")]
			[Address(RVA = "0x4FA1B40", Offset = "0x4FA0740", VA = "0x184FA1B40")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000276 RID: 630 RVA: 0x00002658 File Offset: 0x00000858
		[Token(Token = "0x17000091")]
		internal bool DtdParserProxy_DtdValidation
		{
			[Token(Token = "0x6000276")]
			[Address(RVA = "0x4FA1B20", Offset = "0x4FA0720", VA = "0x184FA1B20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000277 RID: 631 RVA: 0x00002670 File Offset: 0x00000870
		[Token(Token = "0x17000092")]
		internal bool DtdParserProxy_Normalization
		{
			[Token(Token = "0x6000277")]
			[Address(RVA = "0x2213A10", Offset = "0x2212610", VA = "0x182213A10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000278 RID: 632 RVA: 0x00002688 File Offset: 0x00000888
		[Token(Token = "0x17000093")]
		internal bool DtdParserProxy_Namespaces
		{
			[Token(Token = "0x6000278")]
			[Address(RVA = "0x2213A30", Offset = "0x2212630", VA = "0x182213A30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000279 RID: 633 RVA: 0x000026A0 File Offset: 0x000008A0
		[Token(Token = "0x17000094")]
		internal bool DtdParserProxy_V1CompatibilityMode
		{
			[Token(Token = "0x6000279")]
			[Address(RVA = "0x4FA1B50", Offset = "0x4FA0750", VA = "0x184FA1B50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600027A RID: 634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000095")]
		internal Uri DtdParserProxy_BaseUri
		{
			[Token(Token = "0x600027A")]
			[Address(RVA = "0x4FA1A70", Offset = "0x4FA0670", VA = "0x184FA1A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600027B RID: 635 RVA: 0x000026B8 File Offset: 0x000008B8
		[Token(Token = "0x17000096")]
		internal bool DtdParserProxy_IsEof
		{
			[Token(Token = "0x600027B")]
			[Address(RVA = "0x1B5F4F0", Offset = "0x1B5E0F0", VA = "0x181B5F4F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600027C RID: 636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000097")]
		internal char[] DtdParserProxy_ParsingBuffer
		{
			[Token(Token = "0x600027C")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600027D RID: 637 RVA: 0x000026D0 File Offset: 0x000008D0
		[Token(Token = "0x17000098")]
		internal int DtdParserProxy_ParsingBufferLength
		{
			[Token(Token = "0x600027D")]
			[Address(RVA = "0x4FD4B0", Offset = "0x4FC0B0", VA = "0x1804FD4B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600027E RID: 638 RVA: 0x000026E8 File Offset: 0x000008E8
		// (set) Token: 0x0600027F RID: 639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000099")]
		internal int DtdParserProxy_CurrentPosition
		{
			[Token(Token = "0x600027E")]
			[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600027F")]
			[Address(RVA = "0x4EF630", Offset = "0x4EE230", VA = "0x1804EF630")]
			set
			{
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000280 RID: 640 RVA: 0x00002700 File Offset: 0x00000900
		[Token(Token = "0x1700009A")]
		internal int DtdParserProxy_EntityStackLength
		{
			[Token(Token = "0x6000280")]
			[Address(RVA = "0x4FA1B30", Offset = "0x4FA0730", VA = "0x184FA1B30")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000281 RID: 641 RVA: 0x00002718 File Offset: 0x00000918
		[Token(Token = "0x1700009B")]
		internal bool DtdParserProxy_IsEntityEolNormalized
		{
			[Token(Token = "0x6000281")]
			[Address(RVA = "0xF0A860", Offset = "0xF09460", VA = "0x180F0A860")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000282 RID: 642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700009C")]
		internal IValidationEventHandling DtdParserProxy_ValidationEventHandling
		{
			[Token(Token = "0x6000282")]
			[Address(RVA = "0x4FA1B60", Offset = "0x4FA0760", VA = "0x184FA1B60")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000283")]
		[Address(RVA = "0x4F905C0", Offset = "0x4F8F1C0", VA = "0x184F905C0")]
		internal void DtdParserProxy_OnNewLine(int pos)
		{
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000284 RID: 644 RVA: 0x00002730 File Offset: 0x00000930
		[Token(Token = "0x1700009D")]
		internal int DtdParserProxy_LineNo
		{
			[Token(Token = "0x6000284")]
			[Address(RVA = "0x4A559F0", Offset = "0x4A545F0", VA = "0x184A559F0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000285 RID: 645 RVA: 0x00002748 File Offset: 0x00000948
		[Token(Token = "0x1700009E")]
		internal int DtdParserProxy_LineStartPosition
		{
			[Token(Token = "0x6000285")]
			[Address(RVA = "0x4A55A00", Offset = "0x4A54600", VA = "0x184A55A00")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00002760 File Offset: 0x00000960
		[Token(Token = "0x6000286")]
		[Address(RVA = "0x4F91000", Offset = "0x4F8FC00", VA = "0x184F91000")]
		internal int DtdParserProxy_ReadData()
		{
			return 0;
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00002778 File Offset: 0x00000978
		[Token(Token = "0x6000287")]
		[Address(RVA = "0x4F90BA0", Offset = "0x4F8F7A0", VA = "0x184F90BA0")]
		internal int DtdParserProxy_ParseNumericCharRef(StringBuilder internalSubsetBuilder)
		{
			return 0;
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00002790 File Offset: 0x00000990
		[Token(Token = "0x6000288")]
		[Address(RVA = "0x4F90B90", Offset = "0x4F8F790", VA = "0x184F90B90")]
		internal int DtdParserProxy_ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder)
		{
			return 0;
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000289")]
		[Address(RVA = "0x4F90C50", Offset = "0x4F8F850", VA = "0x184F90C50")]
		internal void DtdParserProxy_ParsePI(StringBuilder sb)
		{
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600028A")]
		[Address(RVA = "0x4F907D0", Offset = "0x4F8F3D0", VA = "0x184F907D0")]
		internal void DtdParserProxy_ParseComment(StringBuilder sb)
		{
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600028B RID: 651 RVA: 0x000027A8 File Offset: 0x000009A8
		[Token(Token = "0x1700009F")]
		private bool IsResolverNull
		{
			[Token(Token = "0x600028B")]
			[Address(RVA = "0x4FA1C00", Offset = "0x4FA0800", VA = "0x184FA1C00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028C")]
		[Address(RVA = "0x4F92490", Offset = "0x4F91090", VA = "0x184F92490")]
		private XmlResolver GetTempResolver()
		{
			return null;
		}

		// Token: 0x0600028D RID: 653 RVA: 0x000027C0 File Offset: 0x000009C0
		[Token(Token = "0x600028D")]
		[Address(RVA = "0x4F90D20", Offset = "0x4F8F920", VA = "0x184F90D20")]
		internal bool DtdParserProxy_PushEntity(IDtdEntityInfo entity, out int entityId)
		{
			return default(bool);
		}

		// Token: 0x0600028E RID: 654 RVA: 0x000027D8 File Offset: 0x000009D8
		[Token(Token = "0x600028E")]
		[Address(RVA = "0x4F90CA0", Offset = "0x4F8F8A0", VA = "0x184F90CA0")]
		internal bool DtdParserProxy_PopEntity(out IDtdEntityInfo oldEntity, out int newEntityId)
		{
			return default(bool);
		}

		// Token: 0x0600028F RID: 655 RVA: 0x000027F0 File Offset: 0x000009F0
		[Token(Token = "0x600028F")]
		[Address(RVA = "0x4F90DF0", Offset = "0x4F8F9F0", VA = "0x184F90DF0")]
		internal bool DtdParserProxy_PushExternalSubset(string systemId, string publicId)
		{
			return default(bool);
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000290")]
		[Address(RVA = "0x4F90F60", Offset = "0x4F8FB60", VA = "0x184F90F60")]
		internal void DtdParserProxy_PushInternalDtd(string baseUri, string internalDtd)
		{
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000291")]
		[Address(RVA = "0x4F91010", Offset = "0x4F8FC10", VA = "0x184F91010")]
		internal void DtdParserProxy_Throw(Exception e)
		{
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000292")]
		[Address(RVA = "0x4F906D0", Offset = "0x4F8F2D0", VA = "0x184F906D0")]
		internal void DtdParserProxy_OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo)
		{
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000293")]
		[Address(RVA = "0x4F905D0", Offset = "0x4F8F1D0", VA = "0x184F905D0")]
		internal void DtdParserProxy_OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo)
		{
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000294")]
		[Address(RVA = "0x4FA0D00", Offset = "0x4F9F900", VA = "0x184FA0D00")]
		private void Throw(int pos, string res, string arg)
		{
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000295")]
		[Address(RVA = "0x4FA0E10", Offset = "0x4F9FA10", VA = "0x184FA0E10")]
		private void Throw(int pos, string res, string[] args)
		{
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000296")]
		[Address(RVA = "0x4FA0B40", Offset = "0x4F9F740", VA = "0x184FA0B40")]
		private void Throw(int pos, string res)
		{
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000297")]
		[Address(RVA = "0x4FA0D20", Offset = "0x4F9F920", VA = "0x184FA0D20")]
		private void Throw(string res)
		{
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000298")]
		[Address(RVA = "0x4FA0A90", Offset = "0x4F9F690", VA = "0x184FA0A90")]
		private void Throw(string res, int lineNo, int linePos)
		{
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000299")]
		[Address(RVA = "0x4FA0BA0", Offset = "0x4F9F7A0", VA = "0x184FA0BA0")]
		private void Throw(string res, string arg)
		{
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600029A")]
		[Address(RVA = "0x4FA0D70", Offset = "0x4F9F970", VA = "0x184FA0D70")]
		private void Throw(string res, string arg, int lineNo, int linePos)
		{
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600029B")]
		[Address(RVA = "0x4FA09E0", Offset = "0x4F9F5E0", VA = "0x184FA09E0")]
		private void Throw(string res, string[] args)
		{
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600029C")]
		[Address(RVA = "0x4FA0940", Offset = "0x4F9F540", VA = "0x184FA0940")]
		private void Throw(string res, string arg, Exception innerException)
		{
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600029D")]
		[Address(RVA = "0x4FA0E30", Offset = "0x4F9FA30", VA = "0x184FA0E30")]
		private void Throw(string res, string[] args, Exception innerException)
		{
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600029E")]
		[Address(RVA = "0x4FA0C50", Offset = "0x4F9F850", VA = "0x184FA0C50")]
		private void Throw(Exception e)
		{
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600029F")]
		[Address(RVA = "0x4F9D560", Offset = "0x4F9C160", VA = "0x184F9D560")]
		private void ReThrow(Exception e, int lineNo, int linePos)
		{
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x4FA08A0", Offset = "0x4F9F4A0", VA = "0x184FA08A0")]
		private void ThrowWithoutLineInfo(string res)
		{
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x4FA0780", Offset = "0x4F9F380", VA = "0x184FA0780")]
		private void ThrowWithoutLineInfo(string res, string arg)
		{
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x4FA0810", Offset = "0x4F9F410", VA = "0x184FA0810")]
		private void ThrowWithoutLineInfo(string res, string[] args, Exception innerException)
		{
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x4FA0160", Offset = "0x4F9ED60", VA = "0x184FA0160")]
		private void ThrowInvalidChar(char[] data, int length, int invCharPos)
		{
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x4F9EEC0", Offset = "0x4F9DAC0", VA = "0x184F9EEC0")]
		private void SetErrorState()
		{
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x4F9ECA0", Offset = "0x4F9D8A0", VA = "0x184F9ECA0")]
		private void SendValidationEvent(XmlSeverityType severity, string code, string arg, int lineNo, int linePos)
		{
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x4F9EBB0", Offset = "0x4F9D7B0", VA = "0x184F9EBB0")]
		private void SendValidationEvent(XmlSeverityType severity, XmlSchemaException exception)
		{
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060002A7 RID: 679 RVA: 0x00002808 File Offset: 0x00000A08
		[Token(Token = "0x170000A0")]
		private bool InAttributeValueIterator
		{
			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x4FA1B70", Offset = "0x4FA0770", VA = "0x184FA1B70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x4F912D0", Offset = "0x4F8FED0", VA = "0x184F912D0")]
		private void FinishAttributeValueIterator()
		{
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060002A9 RID: 681 RVA: 0x00002820 File Offset: 0x00000A20
		[Token(Token = "0x170000A1")]
		private bool DtdValidation
		{
			[Token(Token = "0x60002A9")]
			[Address(RVA = "0x4FA1B20", Offset = "0x4FA0720", VA = "0x184FA1B20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x4F93F30", Offset = "0x4F92B30", VA = "0x184F93F30")]
		private void InitStreamInput(Uri baseUri, Stream stream, Encoding encoding)
		{
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x4F93FC0", Offset = "0x4F92BC0", VA = "0x184F93FC0")]
		private void InitStreamInput(Uri baseUri, string baseUriStr, Stream stream, Encoding encoding)
		{
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x4F93C60", Offset = "0x4F92860", VA = "0x184F93C60")]
		private void InitStreamInput(Uri baseUri, string baseUriStr, Stream stream, byte[] bytes, int byteCount, Encoding encoding)
		{
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x4F94100", Offset = "0x4F92D00", VA = "0x184F94100")]
		private void InitTextReaderInput(string baseUriStr, TextReader input)
		{
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x4F94120", Offset = "0x4F92D20", VA = "0x184F94120")]
		private void InitTextReaderInput(string baseUriStr, Uri baseUri, TextReader input)
		{
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x4F93FF0", Offset = "0x4F92BF0", VA = "0x184F93FF0")]
		private void InitStringInput(string baseUriStr, Encoding originalEncoding, string str)
		{
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x4F93980", Offset = "0x4F92580", VA = "0x184F93980")]
		private void InitFragmentReader(XmlNodeType fragmentType, XmlParserContext parserContext, bool allowXmlDeclFragment)
		{
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x4F9CBD0", Offset = "0x4F9B7D0", VA = "0x184F9CBD0")]
		private void ProcessDtdFromParserContext(XmlParserContext context)
		{
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x4F955B0", Offset = "0x4F941B0", VA = "0x184F955B0")]
		private void OpenUrl()
		{
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x4F953B0", Offset = "0x4F93FB0", VA = "0x184F953B0")]
		private void OpenUrlDelegate(object xmlResolver)
		{
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x4F903C0", Offset = "0x4F8EFC0", VA = "0x184F903C0")]
		private Encoding DetectEncoding()
		{
			return null;
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x4F9EEE0", Offset = "0x4F9DAE0", VA = "0x184F9EEE0")]
		private void SetupEncoding(Encoding encoding)
		{
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x4F9FED0", Offset = "0x4F9EAD0", VA = "0x184F9FED0")]
		private void SwitchEncoding(Encoding newEncoding)
		{
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x4F8FE50", Offset = "0x4F8EA50", VA = "0x184F8FE50")]
		private Encoding CheckEncoding(string newEncodingName)
		{
			return null;
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x4FA0EE0", Offset = "0x4F9FAE0", VA = "0x184FA0EE0")]
		private void UnDecodeChars()
		{
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x4F9FE60", Offset = "0x4F9EA60", VA = "0x184F9FE60")]
		private void SwitchEncodingToUTF8()
		{
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00002838 File Offset: 0x00000A38
		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x4F9D990", Offset = "0x4F9C590", VA = "0x184F9D990")]
		private int ReadData()
		{
			return 0;
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00002850 File Offset: 0x00000A50
		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x4F92140", Offset = "0x4F90D40", VA = "0x184F92140")]
		private int GetChars(int maxCharsCount)
		{
			return 0;
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x4F94210", Offset = "0x4F92E10", VA = "0x184F94210")]
		private void InvalidCharRecovery(ref int bytesCount, out int charsCount)
		{
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x4F901C0", Offset = "0x4F8EDC0", VA = "0x184F901C0")]
		internal void Close(bool closeInput)
		{
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x4F9F240", Offset = "0x4F9DE40", VA = "0x184F9F240")]
		private void ShiftBuffer(int sourcePos, int destPos, int count)
		{
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00002868 File Offset: 0x00000A68
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x4F9B860", Offset = "0x4F9A460", VA = "0x184F9B860")]
		private bool ParseXmlDeclaration(bool isTextDecl)
		{
			return default(bool);
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00002880 File Offset: 0x00000A80
		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x4F97970", Offset = "0x4F96570", VA = "0x184F97970")]
		private bool ParseDocumentContent()
		{
			return default(bool);
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00002898 File Offset: 0x00000A98
		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x4F983E0", Offset = "0x4F96FE0", VA = "0x184F983E0")]
		private bool ParseElementContent()
		{
			return default(bool);
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x4FA03D0", Offset = "0x4F9EFD0", VA = "0x184FA03D0")]
		private void ThrowUnclosedElements()
		{
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x4F98770", Offset = "0x4F97370", VA = "0x184F98770")]
		private void ParseElement()
		{
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x4F8EDF0", Offset = "0x4F8D9F0", VA = "0x184F8EDF0")]
		private void AddDefaultAttributesAndNormalize()
		{
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x4F98D40", Offset = "0x4F97940", VA = "0x184F98D40")]
		private void ParseEndElement()
		{
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x4FA01D0", Offset = "0x4F9EDD0", VA = "0x184FA01D0")]
		private void ThrowTagMismatch(XmlTextReaderImpl.NodeData startTag)
		{
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x4F967F0", Offset = "0x4F953F0", VA = "0x184F967F0")]
		private void ParseAttributes()
		{
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x4F91260", Offset = "0x4F8FE60", VA = "0x184F91260")]
		private void ElementNamespaceLookup()
		{
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x4F8FD90", Offset = "0x4F8E990", VA = "0x184F8FD90")]
		private void AttributeNamespaceLookup()
		{
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x4F8F9A0", Offset = "0x4F8E5A0", VA = "0x184F8F9A0")]
		private void AttributeDuplCheck()
		{
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x4F94AD0", Offset = "0x4F936D0", VA = "0x184F94AD0")]
		private void OnDefaultNamespaceDecl(XmlTextReaderImpl.NodeData attr)
		{
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x4F94D20", Offset = "0x4F93920", VA = "0x184F94D20")]
		private void OnNamespaceDecl(XmlTextReaderImpl.NodeData attr)
		{
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x4F94E30", Offset = "0x4F93A30", VA = "0x184F94E30")]
		private void OnXmlReservedAttribute(XmlTextReaderImpl.NodeData attr)
		{
		}

		// Token: 0x060002CE RID: 718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x4F95D60", Offset = "0x4F94960", VA = "0x184F95D60")]
		private void ParseAttributeValueSlow(int curPos, char quoteChar, XmlTextReaderImpl.NodeData attr)
		{
		}

		// Token: 0x060002CF RID: 719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x4F8E150", Offset = "0x4F8CD50", VA = "0x184F8E150")]
		private void AddAttributeChunkToList(XmlTextReaderImpl.NodeData attr, XmlTextReaderImpl.NodeData chunk, ref XmlTextReaderImpl.NodeData lastChunk)
		{
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x000028B0 File Offset: 0x00000AB0
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x4F9AB80", Offset = "0x4F99780", VA = "0x184F9AB80")]
		private bool ParseText()
		{
			return default(bool);
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x000028C8 File Offset: 0x00000AC8
		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x4F9AFE0", Offset = "0x4F99BE0", VA = "0x184F9AFE0")]
		private bool ParseText(out int startPos, out int endPos, ref int outOrChars)
		{
			return default(bool);
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x4F91CB0", Offset = "0x4F908B0", VA = "0x184F91CB0")]
		private void FinishPartialValue()
		{
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x4F91B70", Offset = "0x4F90770", VA = "0x184F91B70")]
		private void FinishOtherValueIterator()
		{
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x4F9F610", Offset = "0x4F9E210", VA = "0x184F9F610")]
		[MethodImpl(8)]
		private void SkipPartialTextValue()
		{
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x4F92060", Offset = "0x4F90C60", VA = "0x184F92060")]
		private void FinishReadValueChunk()
		{
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x4F91E00", Offset = "0x4F90A00", VA = "0x184F91E00")]
		private void FinishReadContentAsBinary()
		{
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x4F91F80", Offset = "0x4F90B80", VA = "0x184F91F80")]
		private void FinishReadElementContentAsBinary()
		{
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x000028E0 File Offset: 0x00000AE0
		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x4F9A8D0", Offset = "0x4F994D0", VA = "0x184F9A8D0")]
		private bool ParseRootLevelWhitespace()
		{
			return default(bool);
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x4F99230", Offset = "0x4F97E30", VA = "0x184F99230")]
		private void ParseEntityReference()
		{
		}

		// Token: 0x060002DA RID: 730 RVA: 0x000028F8 File Offset: 0x00000AF8
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x4F92730", Offset = "0x4F91330", VA = "0x184F92730")]
		private XmlTextReaderImpl.EntityType HandleEntityReference(bool isInAttributeValue, XmlTextReaderImpl.EntityExpandType expandType, out int charRefEndPos)
		{
			return XmlTextReaderImpl.EntityType.CharacterDec;
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00002910 File Offset: 0x00000B10
		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x4F929C0", Offset = "0x4F915C0", VA = "0x184F929C0")]
		private XmlTextReaderImpl.EntityType HandleGeneralEntityReference(string name, bool isInAttributeValue, bool pushFakeEntityIfNullResolver, int entityStartLinePos)
		{
			return XmlTextReaderImpl.EntityType.CharacterDec;
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060002DC RID: 732 RVA: 0x00002928 File Offset: 0x00000B28
		[Token(Token = "0x170000A2")]
		private bool InEntity
		{
			[Token(Token = "0x60002DC")]
			[Address(RVA = "0x4FA1B90", Offset = "0x4FA0790", VA = "0x184FA1B90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060002DD RID: 733 RVA: 0x00002940 File Offset: 0x00000B40
		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x4F925A0", Offset = "0x4F911A0", VA = "0x184F925A0")]
		private bool HandleEntityEnd(bool checkEntityNesting)
		{
			return default(bool);
		}

		// Token: 0x060002DE RID: 734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x4F9F110", Offset = "0x4F9DD10", VA = "0x184F9F110")]
		private void SetupEndEntityNodeInContent()
		{
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x4F9F090", Offset = "0x4F9DC90", VA = "0x184F9F090")]
		private void SetupEndEntityNodeInAttribute()
		{
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00002958 File Offset: 0x00000B58
		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x4F9A600", Offset = "0x4F99200", VA = "0x184F9A600")]
		private bool ParsePI()
		{
			return default(bool);
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00002970 File Offset: 0x00000B70
		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x4F9A1B0", Offset = "0x4F98DB0", VA = "0x184F9A1B0")]
		private bool ParsePI(StringBuilder piInDtdStringBuilder)
		{
			return default(bool);
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00002988 File Offset: 0x00000B88
		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x4F99E50", Offset = "0x4F98A50", VA = "0x184F99E50")]
		private bool ParsePIValue(out int outStartPos, out int outEndPos)
		{
			return default(bool);
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x000029A0 File Offset: 0x00000BA0
		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x4F97460", Offset = "0x4F96060", VA = "0x184F97460")]
		private bool ParseComment()
		{
			return default(bool);
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x4F973D0", Offset = "0x4F95FD0", VA = "0x184F973D0")]
		private void ParseCData()
		{
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x4F971E0", Offset = "0x4F95DE0", VA = "0x184F971E0")]
		private void ParseCDataOrComment(XmlNodeType type)
		{
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x000029B8 File Offset: 0x00000BB8
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x4F96DE0", Offset = "0x4F959E0", VA = "0x184F96DE0")]
		private bool ParseCDataOrComment(XmlNodeType type, out int outStartPos, out int outEndPos)
		{
			return default(bool);
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x000029D0 File Offset: 0x00000BD0
		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x4F976A0", Offset = "0x4F962A0", VA = "0x184F976A0")]
		private bool ParseDoctypeDecl()
		{
			return default(bool);
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x4F980F0", Offset = "0x4F96CF0", VA = "0x184F980F0")]
		private void ParseDtd()
		{
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x4F9F270", Offset = "0x4F9DE70", VA = "0x184F9F270")]
		private void SkipDtd()
		{
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x4F9F670", Offset = "0x4F9E270", VA = "0x184F9F670")]
		private void SkipPublicOrSystemIdLiteral()
		{
		}

		// Token: 0x060002EB RID: 747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x4F9F700", Offset = "0x4F9E300", VA = "0x184F9F700")]
		private void SkipUntil(char stopChar, bool recognizeLiterals)
		{
		}

		// Token: 0x060002EC RID: 748 RVA: 0x000029E8 File Offset: 0x00000BE8
		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x4F91020", Offset = "0x4F8FC20", VA = "0x184F91020")]
		private int EatWhitespaces(StringBuilder sb)
		{
			return 0;
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00002A00 File Offset: 0x00000C00
		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x4F973E0", Offset = "0x4F95FE0", VA = "0x184F973E0")]
		private int ParseCharRefInline(int startPos, out int charCount, out XmlTextReaderImpl.EntityType entityType)
		{
			return 0;
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00002A18 File Offset: 0x00000C18
		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x4F99D80", Offset = "0x4F98980", VA = "0x184F99D80")]
		private int ParseNumericCharRef(bool expand, StringBuilder internalSubsetBuilder, out XmlTextReaderImpl.EntityType entityType)
		{
			return 0;
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00002A30 File Offset: 0x00000C30
		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x4F996D0", Offset = "0x4F982D0", VA = "0x184F996D0")]
		private int ParseNumericCharRefInline(int startPos, bool expand, StringBuilder internalSubsetBuilder, out int charCount, out XmlTextReaderImpl.EntityType entityType)
		{
			return 0;
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00002A48 File Offset: 0x00000C48
		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x4F99650", Offset = "0x4F98250", VA = "0x184F99650")]
		private int ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder)
		{
			return 0;
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00002A60 File Offset: 0x00000C60
		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x4F99390", Offset = "0x4F97F90", VA = "0x184F99390")]
		private int ParseNamedCharRefInline(int startPos, bool expand, StringBuilder internalSubsetBuilder)
		{
			return 0;
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00002A78 File Offset: 0x00000C78
		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x4F99360", Offset = "0x4F97F60", VA = "0x184F99360")]
		private int ParseName()
		{
			return 0;
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00002A90 File Offset: 0x00000C90
		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x4F9A8B0", Offset = "0x4F994B0", VA = "0x184F9A8B0")]
		private int ParseQName(out int colonPos)
		{
			return 0;
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00002AA8 File Offset: 0x00000CA8
		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x4F9A610", Offset = "0x4F99210", VA = "0x184F9A610")]
		private int ParseQName(bool isQName, int startOffset, out int colonPos)
		{
			return 0;
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00002AC0 File Offset: 0x00000CC0
		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x4F9D940", Offset = "0x4F9C540", VA = "0x184F9D940")]
		private bool ReadDataInName(ref int pos)
		{
			return default(bool);
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x4F99150", Offset = "0x4F97D50", VA = "0x184F99150")]
		private string ParseEntityName()
		{
			return null;
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x4F8F6A0", Offset = "0x4F8E2A0", VA = "0x184F8F6A0")]
		private XmlTextReaderImpl.NodeData AddNode(int nodeIndex, int nodeDepth)
		{
			return null;
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x4F8F830", Offset = "0x4F8E430", VA = "0x184F8F830")]
		private XmlTextReaderImpl.NodeData AllocNode(int nodeIndex, int nodeDepth)
		{
			return null;
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x4F8E1C0", Offset = "0x4F8CDC0", VA = "0x184F8E1C0")]
		private XmlTextReaderImpl.NodeData AddAttributeNoChecks(string name, int attrDepth)
		{
			return null;
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x4F8E270", Offset = "0x4F8CE70", VA = "0x184F8E270")]
		private XmlTextReaderImpl.NodeData AddAttribute(int endNamePos, int colonPos)
		{
			return null;
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x4F8E490", Offset = "0x4F8D090", VA = "0x184F8E490")]
		private XmlTextReaderImpl.NodeData AddAttribute(string localName, string prefix, string nameWPrefix)
		{
			return null;
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x4F9C980", Offset = "0x4F9B580", VA = "0x184F9C980")]
		private void PopElementContext()
		{
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x4F905C0", Offset = "0x4F8F1C0", VA = "0x184F905C0")]
		private void OnNewLine(int pos)
		{
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x4F94C50", Offset = "0x4F93850", VA = "0x184F94C50")]
		private void OnEof()
		{
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x4F94410", Offset = "0x4F93010", VA = "0x184F94410")]
		private string LookupNamespace(XmlTextReaderImpl.NodeData node)
		{
			return null;
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000300")]
		[Address(RVA = "0x4F8F420", Offset = "0x4F8E020", VA = "0x184F8F420")]
		private void AddNamespace(string prefix, string uri, XmlTextReaderImpl.NodeData attr)
		{
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000301")]
		[Address(RVA = "0x4F9E820", Offset = "0x4F9D420", VA = "0x184F9E820")]
		private void ResetAttributes()
		{
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000302")]
		[Address(RVA = "0x4F920A0", Offset = "0x4F90CA0", VA = "0x184F920A0")]
		private void FullAttributeCleanup()
		{
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000303")]
		[Address(RVA = "0x4F9D4C0", Offset = "0x4F9C0C0", VA = "0x184F9D4C0")]
		private void PushXmlContext()
		{
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000304")]
		[Address(RVA = "0x4F9CB90", Offset = "0x4F9B790", VA = "0x184F9CB90")]
		private void PopXmlContext()
		{
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00002AD8 File Offset: 0x00000CD8
		[Token(Token = "0x6000305")]
		[Address(RVA = "0x4F92550", Offset = "0x4F91150", VA = "0x184F92550")]
		private XmlNodeType GetWhitespaceType()
		{
			return XmlNodeType.None;
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00002AF0 File Offset: 0x00000CF0
		[Token(Token = "0x6000306")]
		[Address(RVA = "0x4F924F0", Offset = "0x4F910F0", VA = "0x184F924F0")]
		private XmlNodeType GetTextNodeType(int orChars)
		{
			return XmlNodeType.None;
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000307")]
		[Address(RVA = "0x4F9CC40", Offset = "0x4F9B840", VA = "0x184F9CC40")]
		private void PushExternalEntityOrSubset(string publicId, string systemId, Uri baseUri, string entityName)
		{
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00002B08 File Offset: 0x00000D08
		[Token(Token = "0x6000308")]
		[Address(RVA = "0x4F95050", Offset = "0x4F93C50", VA = "0x184F95050")]
		private bool OpenAndPush(Uri uri)
		{
			return default(bool);
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00002B20 File Offset: 0x00000D20
		[Token(Token = "0x6000309")]
		[Address(RVA = "0x4F9CFE0", Offset = "0x4F9BBE0", VA = "0x184F9CFE0")]
		private bool PushExternalEntity(IDtdEntityInfo entity)
		{
			return default(bool);
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600030A")]
		[Address(RVA = "0x4F9D200", Offset = "0x4F9BE00", VA = "0x184F9D200")]
		private void PushInternalEntity(IDtdEntityInfo entity)
		{
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600030B")]
		[Address(RVA = "0x4F9CA10", Offset = "0x4F9B610", VA = "0x184F9CA10")]
		private void PopEntity()
		{
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600030C")]
		[Address(RVA = "0x4F9E600", Offset = "0x4F9D200", VA = "0x184F9E600")]
		private void RegisterEntity(IDtdEntityInfo entity)
		{
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600030D")]
		[Address(RVA = "0x4FA0FC0", Offset = "0x4F9FBC0", VA = "0x184FA0FC0")]
		private void UnregisterEntity()
		{
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600030E")]
		[Address(RVA = "0x4F9D370", Offset = "0x4F9BF70", VA = "0x184F9D370")]
		private void PushParsingState()
		{
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600030F")]
		[Address(RVA = "0x4F9CAC0", Offset = "0x4F9B6C0", VA = "0x184F9CAC0")]
		private void PopParsingState()
		{
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00002B38 File Offset: 0x00000D38
		[Token(Token = "0x6000310")]
		[Address(RVA = "0x4F92E60", Offset = "0x4F91A60", VA = "0x184F92E60")]
		private int IncrementalRead()
		{
			return 0;
		}

		// Token: 0x06000311 RID: 785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000311")]
		[Address(RVA = "0x4F91440", Offset = "0x4F90040", VA = "0x184F91440")]
		private void FinishIncrementalRead()
		{
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00002B50 File Offset: 0x00000D50
		[Token(Token = "0x6000312")]
		[Address(RVA = "0x4F992B0", Offset = "0x4F97EB0", VA = "0x184F992B0")]
		private bool ParseFragmentAttribute()
		{
			return default(bool);
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00002B68 File Offset: 0x00000D68
		[Token(Token = "0x6000313")]
		[Address(RVA = "0x4F957A0", Offset = "0x4F943A0", VA = "0x184F957A0")]
		private bool ParseAttributeValueChunk()
		{
			return default(bool);
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000314")]
		[Address(RVA = "0x4F9B7D0", Offset = "0x4F9A3D0", VA = "0x184F9B7D0")]
		private void ParseXmlDeclarationFragment()
		{
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000315")]
		[Address(RVA = "0x4FA05D0", Offset = "0x4F9F1D0", VA = "0x184FA05D0")]
		private void ThrowUnexpectedToken(int pos, string expectedToken)
		{
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000316")]
		[Address(RVA = "0x4FA05C0", Offset = "0x4F9F1C0", VA = "0x184FA05C0")]
		private void ThrowUnexpectedToken(string expectedToken1)
		{
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000317")]
		[Address(RVA = "0x4FA05A0", Offset = "0x4F9F1A0", VA = "0x184FA05A0")]
		private void ThrowUnexpectedToken(int pos, string expectedToken1, string expectedToken2)
		{
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000318")]
		[Address(RVA = "0x4FA05F0", Offset = "0x4F9F1F0", VA = "0x184FA05F0")]
		private void ThrowUnexpectedToken(string expectedToken1, string expectedToken2)
		{
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000319")]
		[Address(RVA = "0x4F9B6E0", Offset = "0x4F9A2E0", VA = "0x184F9B6E0")]
		private string ParseUnexpectedToken(int pos)
		{
			return null;
		}

		// Token: 0x0600031A RID: 794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031A")]
		[Address(RVA = "0x4F9B6F0", Offset = "0x4F9A2F0", VA = "0x184F9B6F0")]
		private string ParseUnexpectedToken()
		{
			return null;
		}

		// Token: 0x0600031B RID: 795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600031B")]
		[Address(RVA = "0x4FA00E0", Offset = "0x4F9ECE0", VA = "0x184FA00E0")]
		private void ThrowExpectingWhitespace(int pos)
		{
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00002B80 File Offset: 0x00000D80
		[Token(Token = "0x600031C")]
		[Address(RVA = "0x4F92360", Offset = "0x4F90F60", VA = "0x184F92360")]
		private int GetIndexOfAttributeWithoutPrefix(string name)
		{
			return 0;
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00002B98 File Offset: 0x00000D98
		[Token(Token = "0x600031D")]
		[Address(RVA = "0x4F92260", Offset = "0x4F90E60", VA = "0x184F92260")]
		private int GetIndexOfAttributeWithPrefix(string name)
		{
			return 0;
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00002BB0 File Offset: 0x00000DB0
		[Token(Token = "0x600031E")]
		[Address(RVA = "0x4FA1020", Offset = "0x4F9FC20", VA = "0x184FA1020")]
		private bool ZeroEndingStream(int pos)
		{
			return default(bool);
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600031F")]
		[Address(RVA = "0x4F97EC0", Offset = "0x4F96AC0", VA = "0x184F97EC0")]
		private void ParseDtdFromParserContext()
		{
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00002BC8 File Offset: 0x00000DC8
		[Token(Token = "0x6000320")]
		[Address(RVA = "0x4F94990", Offset = "0x4F93590", VA = "0x184F94990")]
		private bool MoveToNextContentNode(bool moveIfOnContentNode)
		{
			return default(bool);
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000321 RID: 801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A3")]
		internal override IDtdInfo DtdInfo
		{
			[Token(Token = "0x6000321")]
			[Address(RVA = "0x4E84350", Offset = "0x4E82F50", VA = "0x184E84350", Slot = "29")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000322")]
		[Address(RVA = "0x4F9EE00", Offset = "0x4F9DA00", VA = "0x184F9EE00")]
		internal void SetDtdInfo(IDtdInfo newDtdInfo)
		{
		}

		// Token: 0x170000A4 RID: 164
		// (set) Token: 0x06000323 RID: 803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000A4")]
		internal bool XmlValidatingReaderCompatibilityMode
		{
			[Token(Token = "0x6000323")]
			[Address(RVA = "0x4FA23F0", Offset = "0x4FA0FF0", VA = "0x184FA23F0")]
			set
			{
			}
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00002BE0 File Offset: 0x00000DE0
		[Token(Token = "0x6000324")]
		[Address(RVA = "0x4F8E5F0", Offset = "0x4F8D1F0", VA = "0x184F8E5F0")]
		private bool AddDefaultAttributeDtd(IDtdDefaultAttributeInfo defAttrInfo, bool definedInDtd, XmlTextReaderImpl.NodeData[] nameSortedNodeData)
		{
			return default(bool);
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000325")]
		[Address(RVA = "0x4F8EB40", Offset = "0x4F8D740", VA = "0x184F8EB40")]
		private XmlTextReaderImpl.NodeData AddDefaultAttributeInternal(string localName, string ns, string prefix, string value, int lineNo, int linePos, int valueLineNo, int valueLinePos, bool isXmlAttribute)
		{
			return null;
		}

		// Token: 0x170000A5 RID: 165
		// (set) Token: 0x06000326 RID: 806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000A5")]
		internal bool DisableUndeclaredEntityCheck
		{
			[Token(Token = "0x6000326")]
			[Address(RVA = "0x4FA1FE0", Offset = "0x4FA0BE0", VA = "0x184FA1FE0")]
			set
			{
			}
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000327")]
		[Address(RVA = "0x4F9E4D0", Offset = "0x4F9D0D0", VA = "0x184F9E4D0")]
		private void RegisterConsumedCharacters(long characters, bool inEntityReference)
		{
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000328")]
		[Address(RVA = "0x4F9FB50", Offset = "0x4F9E750", VA = "0x184F9FB50")]
		internal static string StripSpaces(string value)
		{
			return null;
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000329")]
		[Address(RVA = "0x4F9FD40", Offset = "0x4F9E940", VA = "0x184F9FD40")]
		internal static void StripSpaces(char[] value, int index, ref int len)
		{
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600032A")]
		[Address(RVA = "0x4D712F0", Offset = "0x4D6FEF0", VA = "0x184D712F0")]
		internal static void BlockCopyChars(char[] src, int srcOffset, char[] dst, int dstOffset, int count)
		{
		}

		// Token: 0x0600032B RID: 811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600032B")]
		[Address(RVA = "0x4F8FE40", Offset = "0x4F8EA40", VA = "0x184F8FE40")]
		internal static void BlockCopy(byte[] src, int srcOffset, byte[] dst, int dstOffset, int count)
		{
		}

		// Token: 0x040000FB RID: 251
		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x10")]
		private XmlTextReaderImpl.LaterInitParam laterInitParam;

		// Token: 0x040000FC RID: 252
		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x18")]
		private XmlCharType xmlCharType;

		// Token: 0x040000FD RID: 253
		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0x20")]
		private XmlTextReaderImpl.ParsingState ps;

		// Token: 0x040000FE RID: 254
		[Token(Token = "0x40000FE")]
		[FieldOffset(Offset = "0x98")]
		private XmlTextReaderImpl.ParsingFunction parsingFunction;

		// Token: 0x040000FF RID: 255
		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0x9C")]
		private XmlTextReaderImpl.ParsingFunction nextParsingFunction;

		// Token: 0x04000100 RID: 256
		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0xA0")]
		private XmlTextReaderImpl.ParsingFunction nextNextParsingFunction;

		// Token: 0x04000101 RID: 257
		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0xA8")]
		private XmlTextReaderImpl.NodeData[] nodes;

		// Token: 0x04000102 RID: 258
		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0xB0")]
		private XmlTextReaderImpl.NodeData curNode;

		// Token: 0x04000103 RID: 259
		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0xB8")]
		private int index;

		// Token: 0x04000104 RID: 260
		[Token(Token = "0x4000104")]
		[FieldOffset(Offset = "0xBC")]
		private int curAttrIndex;

		// Token: 0x04000105 RID: 261
		[Token(Token = "0x4000105")]
		[FieldOffset(Offset = "0xC0")]
		private int attrCount;

		// Token: 0x04000106 RID: 262
		[Token(Token = "0x4000106")]
		[FieldOffset(Offset = "0xC4")]
		private int attrHashtable;

		// Token: 0x04000107 RID: 263
		[Token(Token = "0x4000107")]
		[FieldOffset(Offset = "0xC8")]
		private int attrDuplWalkCount;

		// Token: 0x04000108 RID: 264
		[Token(Token = "0x4000108")]
		[FieldOffset(Offset = "0xCC")]
		private bool attrNeedNamespaceLookup;

		// Token: 0x04000109 RID: 265
		[Token(Token = "0x4000109")]
		[FieldOffset(Offset = "0xCD")]
		private bool fullAttrCleanup;

		// Token: 0x0400010A RID: 266
		[Token(Token = "0x400010A")]
		[FieldOffset(Offset = "0xD0")]
		private XmlTextReaderImpl.NodeData[] attrDuplSortingArray;

		// Token: 0x0400010B RID: 267
		[Token(Token = "0x400010B")]
		[FieldOffset(Offset = "0xD8")]
		private XmlNameTable nameTable;

		// Token: 0x0400010C RID: 268
		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0xE0")]
		private bool nameTableFromSettings;

		// Token: 0x0400010D RID: 269
		[Token(Token = "0x400010D")]
		[FieldOffset(Offset = "0xE8")]
		private XmlResolver xmlResolver;

		// Token: 0x0400010E RID: 270
		[Token(Token = "0x400010E")]
		[FieldOffset(Offset = "0xF0")]
		private string url;

		// Token: 0x0400010F RID: 271
		[Token(Token = "0x400010F")]
		[FieldOffset(Offset = "0xF8")]
		private bool normalize;

		// Token: 0x04000110 RID: 272
		[Token(Token = "0x4000110")]
		[FieldOffset(Offset = "0xF9")]
		private bool supportNamespaces;

		// Token: 0x04000111 RID: 273
		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0xFC")]
		private WhitespaceHandling whitespaceHandling;

		// Token: 0x04000112 RID: 274
		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x100")]
		private DtdProcessing dtdProcessing;

		// Token: 0x04000113 RID: 275
		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0x104")]
		private EntityHandling entityHandling;

		// Token: 0x04000114 RID: 276
		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0x108")]
		private bool ignorePIs;

		// Token: 0x04000115 RID: 277
		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x109")]
		private bool ignoreComments;

		// Token: 0x04000116 RID: 278
		[Token(Token = "0x4000116")]
		[FieldOffset(Offset = "0x10A")]
		private bool checkCharacters;

		// Token: 0x04000117 RID: 279
		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0x10C")]
		private int lineNumberOffset;

		// Token: 0x04000118 RID: 280
		[Token(Token = "0x4000118")]
		[FieldOffset(Offset = "0x110")]
		private int linePositionOffset;

		// Token: 0x04000119 RID: 281
		[Token(Token = "0x4000119")]
		[FieldOffset(Offset = "0x114")]
		private bool closeInput;

		// Token: 0x0400011A RID: 282
		[Token(Token = "0x400011A")]
		[FieldOffset(Offset = "0x118")]
		private long maxCharactersInDocument;

		// Token: 0x0400011B RID: 283
		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0x120")]
		private long maxCharactersFromEntities;

		// Token: 0x0400011C RID: 284
		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x128")]
		private bool v1Compat;

		// Token: 0x0400011D RID: 285
		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x130")]
		private XmlNamespaceManager namespaceManager;

		// Token: 0x0400011E RID: 286
		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x138")]
		private string lastPrefix;

		// Token: 0x0400011F RID: 287
		[Token(Token = "0x400011F")]
		[FieldOffset(Offset = "0x140")]
		private XmlTextReaderImpl.XmlContext xmlContext;

		// Token: 0x04000120 RID: 288
		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0x148")]
		private XmlTextReaderImpl.ParsingState[] parsingStatesStack;

		// Token: 0x04000121 RID: 289
		[Token(Token = "0x4000121")]
		[FieldOffset(Offset = "0x150")]
		private int parsingStatesStackTop;

		// Token: 0x04000122 RID: 290
		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0x158")]
		private string reportedBaseUri;

		// Token: 0x04000123 RID: 291
		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x160")]
		private Encoding reportedEncoding;

		// Token: 0x04000124 RID: 292
		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x168")]
		private IDtdInfo dtdInfo;

		// Token: 0x04000125 RID: 293
		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x170")]
		private XmlNodeType fragmentType;

		// Token: 0x04000126 RID: 294
		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0x178")]
		private XmlParserContext fragmentParserContext;

		// Token: 0x04000127 RID: 295
		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0x180")]
		private bool fragment;

		// Token: 0x04000128 RID: 296
		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x188")]
		private IncrementalReadDecoder incReadDecoder;

		// Token: 0x04000129 RID: 297
		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0x190")]
		private XmlTextReaderImpl.IncrementalReadState incReadState;

		// Token: 0x0400012A RID: 298
		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x194")]
		private LineInfo incReadLineInfo;

		// Token: 0x0400012B RID: 299
		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0x19C")]
		private int incReadDepth;

		// Token: 0x0400012C RID: 300
		[Token(Token = "0x400012C")]
		[FieldOffset(Offset = "0x1A0")]
		private int incReadLeftStartPos;

		// Token: 0x0400012D RID: 301
		[Token(Token = "0x400012D")]
		[FieldOffset(Offset = "0x1A4")]
		private int incReadLeftEndPos;

		// Token: 0x0400012E RID: 302
		[Token(Token = "0x400012E")]
		[FieldOffset(Offset = "0x1A8")]
		private int attributeValueBaseEntityId;

		// Token: 0x0400012F RID: 303
		[Token(Token = "0x400012F")]
		[FieldOffset(Offset = "0x1AC")]
		private bool emptyEntityInAttributeResolved;

		// Token: 0x04000130 RID: 304
		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0x1B0")]
		private IValidationEventHandling validationEventHandling;

		// Token: 0x04000131 RID: 305
		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0x1B8")]
		private XmlTextReaderImpl.OnDefaultAttributeUseDelegate onDefaultAttributeUse;

		// Token: 0x04000132 RID: 306
		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0x1C0")]
		private bool validatingReaderCompatFlag;

		// Token: 0x04000133 RID: 307
		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0x1C1")]
		private bool addDefaultAttributesAndNormalize;

		// Token: 0x04000134 RID: 308
		[Token(Token = "0x4000134")]
		[FieldOffset(Offset = "0x1C8")]
		private StringBuilder stringBuilder;

		// Token: 0x04000135 RID: 309
		[Token(Token = "0x4000135")]
		[FieldOffset(Offset = "0x1D0")]
		private bool rootElementParsed;

		// Token: 0x04000136 RID: 310
		[Token(Token = "0x4000136")]
		[FieldOffset(Offset = "0x1D1")]
		private bool standalone;

		// Token: 0x04000137 RID: 311
		[Token(Token = "0x4000137")]
		[FieldOffset(Offset = "0x1D4")]
		private int nextEntityId;

		// Token: 0x04000138 RID: 312
		[Token(Token = "0x4000138")]
		[FieldOffset(Offset = "0x1D8")]
		private XmlTextReaderImpl.ParsingMode parsingMode;

		// Token: 0x04000139 RID: 313
		[Token(Token = "0x4000139")]
		[FieldOffset(Offset = "0x1DC")]
		private ReadState readState;

		// Token: 0x0400013A RID: 314
		[Token(Token = "0x400013A")]
		[FieldOffset(Offset = "0x1E0")]
		private IDtdEntityInfo lastEntity;

		// Token: 0x0400013B RID: 315
		[Token(Token = "0x400013B")]
		[FieldOffset(Offset = "0x1E8")]
		private bool afterResetState;

		// Token: 0x0400013C RID: 316
		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0x1EC")]
		private int documentStartBytePos;

		// Token: 0x0400013D RID: 317
		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0x1F0")]
		private int readValueOffset;

		// Token: 0x0400013E RID: 318
		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0x1F8")]
		private long charactersInDocument;

		// Token: 0x0400013F RID: 319
		[Token(Token = "0x400013F")]
		[FieldOffset(Offset = "0x200")]
		private long charactersFromEntities;

		// Token: 0x04000140 RID: 320
		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0x208")]
		private Dictionary<IDtdEntityInfo, IDtdEntityInfo> currentEntities;

		// Token: 0x04000141 RID: 321
		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0x210")]
		private bool disableUndeclaredEntityCheck;

		// Token: 0x04000142 RID: 322
		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0x218")]
		private XmlReader outerReader;

		// Token: 0x04000143 RID: 323
		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0x220")]
		private bool xmlResolverIsSet;

		// Token: 0x04000144 RID: 324
		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0x228")]
		private string Xml;

		// Token: 0x04000145 RID: 325
		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0x230")]
		private string XmlNs;

		// Token: 0x04000146 RID: 326
		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0x238")]
		private Task<Tuple<int, int, int, bool>> parseText_dummyTask;

		// Token: 0x0200003E RID: 62
		[Token(Token = "0x200003E")]
		private enum ParsingFunction
		{
			// Token: 0x04000148 RID: 328
			[Token(Token = "0x4000148")]
			ElementContent,
			// Token: 0x04000149 RID: 329
			[Token(Token = "0x4000149")]
			NoData,
			// Token: 0x0400014A RID: 330
			[Token(Token = "0x400014A")]
			OpenUrl,
			// Token: 0x0400014B RID: 331
			[Token(Token = "0x400014B")]
			SwitchToInteractive,
			// Token: 0x0400014C RID: 332
			[Token(Token = "0x400014C")]
			SwitchToInteractiveXmlDecl,
			// Token: 0x0400014D RID: 333
			[Token(Token = "0x400014D")]
			DocumentContent,
			// Token: 0x0400014E RID: 334
			[Token(Token = "0x400014E")]
			MoveToElementContent,
			// Token: 0x0400014F RID: 335
			[Token(Token = "0x400014F")]
			PopElementContext,
			// Token: 0x04000150 RID: 336
			[Token(Token = "0x4000150")]
			PopEmptyElementContext,
			// Token: 0x04000151 RID: 337
			[Token(Token = "0x4000151")]
			ResetAttributesRootLevel,
			// Token: 0x04000152 RID: 338
			[Token(Token = "0x4000152")]
			Error,
			// Token: 0x04000153 RID: 339
			[Token(Token = "0x4000153")]
			Eof,
			// Token: 0x04000154 RID: 340
			[Token(Token = "0x4000154")]
			ReaderClosed,
			// Token: 0x04000155 RID: 341
			[Token(Token = "0x4000155")]
			EntityReference,
			// Token: 0x04000156 RID: 342
			[Token(Token = "0x4000156")]
			InIncrementalRead,
			// Token: 0x04000157 RID: 343
			[Token(Token = "0x4000157")]
			FragmentAttribute,
			// Token: 0x04000158 RID: 344
			[Token(Token = "0x4000158")]
			ReportEndEntity,
			// Token: 0x04000159 RID: 345
			[Token(Token = "0x4000159")]
			AfterResolveEntityInContent,
			// Token: 0x0400015A RID: 346
			[Token(Token = "0x400015A")]
			AfterResolveEmptyEntityInContent,
			// Token: 0x0400015B RID: 347
			[Token(Token = "0x400015B")]
			XmlDeclarationFragment,
			// Token: 0x0400015C RID: 348
			[Token(Token = "0x400015C")]
			GoToEof,
			// Token: 0x0400015D RID: 349
			[Token(Token = "0x400015D")]
			PartialTextValue,
			// Token: 0x0400015E RID: 350
			[Token(Token = "0x400015E")]
			InReadAttributeValue,
			// Token: 0x0400015F RID: 351
			[Token(Token = "0x400015F")]
			InReadValueChunk,
			// Token: 0x04000160 RID: 352
			[Token(Token = "0x4000160")]
			InReadContentAsBinary,
			// Token: 0x04000161 RID: 353
			[Token(Token = "0x4000161")]
			InReadElementContentAsBinary
		}

		// Token: 0x0200003F RID: 63
		[Token(Token = "0x200003F")]
		private enum ParsingMode
		{
			// Token: 0x04000163 RID: 355
			[Token(Token = "0x4000163")]
			Full,
			// Token: 0x04000164 RID: 356
			[Token(Token = "0x4000164")]
			SkipNode,
			// Token: 0x04000165 RID: 357
			[Token(Token = "0x4000165")]
			SkipContent
		}

		// Token: 0x02000040 RID: 64
		[Token(Token = "0x2000040")]
		private enum EntityType
		{
			// Token: 0x04000167 RID: 359
			[Token(Token = "0x4000167")]
			CharacterDec,
			// Token: 0x04000168 RID: 360
			[Token(Token = "0x4000168")]
			CharacterHex,
			// Token: 0x04000169 RID: 361
			[Token(Token = "0x4000169")]
			CharacterNamed,
			// Token: 0x0400016A RID: 362
			[Token(Token = "0x400016A")]
			Expanded,
			// Token: 0x0400016B RID: 363
			[Token(Token = "0x400016B")]
			Skipped,
			// Token: 0x0400016C RID: 364
			[Token(Token = "0x400016C")]
			FakeExpanded,
			// Token: 0x0400016D RID: 365
			[Token(Token = "0x400016D")]
			Unexpanded,
			// Token: 0x0400016E RID: 366
			[Token(Token = "0x400016E")]
			ExpandedInAttribute
		}

		// Token: 0x02000041 RID: 65
		[Token(Token = "0x2000041")]
		private enum EntityExpandType
		{
			// Token: 0x04000170 RID: 368
			[Token(Token = "0x4000170")]
			All,
			// Token: 0x04000171 RID: 369
			[Token(Token = "0x4000171")]
			OnlyGeneral,
			// Token: 0x04000172 RID: 370
			[Token(Token = "0x4000172")]
			OnlyCharacter
		}

		// Token: 0x02000042 RID: 66
		[Token(Token = "0x2000042")]
		private enum IncrementalReadState
		{
			// Token: 0x04000174 RID: 372
			[Token(Token = "0x4000174")]
			Text,
			// Token: 0x04000175 RID: 373
			[Token(Token = "0x4000175")]
			StartTag,
			// Token: 0x04000176 RID: 374
			[Token(Token = "0x4000176")]
			PI,
			// Token: 0x04000177 RID: 375
			[Token(Token = "0x4000177")]
			CDATA,
			// Token: 0x04000178 RID: 376
			[Token(Token = "0x4000178")]
			Comment,
			// Token: 0x04000179 RID: 377
			[Token(Token = "0x4000179")]
			Attributes,
			// Token: 0x0400017A RID: 378
			[Token(Token = "0x400017A")]
			AttributeValue,
			// Token: 0x0400017B RID: 379
			[Token(Token = "0x400017B")]
			ReadData,
			// Token: 0x0400017C RID: 380
			[Token(Token = "0x400017C")]
			EndElement,
			// Token: 0x0400017D RID: 381
			[Token(Token = "0x400017D")]
			End,
			// Token: 0x0400017E RID: 382
			[Token(Token = "0x400017E")]
			ReadValueChunk_OnCachedValue,
			// Token: 0x0400017F RID: 383
			[Token(Token = "0x400017F")]
			ReadValueChunk_OnPartialValue,
			// Token: 0x04000180 RID: 384
			[Token(Token = "0x4000180")]
			ReadContentAsBinary_OnCachedValue,
			// Token: 0x04000181 RID: 385
			[Token(Token = "0x4000181")]
			ReadContentAsBinary_OnPartialValue,
			// Token: 0x04000182 RID: 386
			[Token(Token = "0x4000182")]
			ReadContentAsBinary_End
		}

		// Token: 0x02000043 RID: 67
		[Token(Token = "0x2000043")]
		private class LaterInitParam
		{
			// Token: 0x04000183 RID: 387
			[Token(Token = "0x4000183")]
			[FieldOffset(Offset = "0x10")]
			public bool useAsync;

			// Token: 0x04000184 RID: 388
			[Token(Token = "0x4000184")]
			[FieldOffset(Offset = "0x18")]
			public Stream inputStream;

			// Token: 0x04000185 RID: 389
			[Token(Token = "0x4000185")]
			[FieldOffset(Offset = "0x20")]
			public byte[] inputBytes;

			// Token: 0x04000186 RID: 390
			[Token(Token = "0x4000186")]
			[FieldOffset(Offset = "0x28")]
			public int inputByteCount;

			// Token: 0x04000187 RID: 391
			[Token(Token = "0x4000187")]
			[FieldOffset(Offset = "0x30")]
			public Uri inputbaseUri;

			// Token: 0x04000188 RID: 392
			[Token(Token = "0x4000188")]
			[FieldOffset(Offset = "0x38")]
			public string inputUriStr;

			// Token: 0x04000189 RID: 393
			[Token(Token = "0x4000189")]
			[FieldOffset(Offset = "0x40")]
			public XmlResolver inputUriResolver;

			// Token: 0x0400018A RID: 394
			[Token(Token = "0x400018A")]
			[FieldOffset(Offset = "0x48")]
			public XmlParserContext inputContext;

			// Token: 0x0400018B RID: 395
			[Token(Token = "0x400018B")]
			[FieldOffset(Offset = "0x50")]
			public TextReader inputTextReader;

			// Token: 0x0400018C RID: 396
			[Token(Token = "0x400018C")]
			[FieldOffset(Offset = "0x58")]
			public XmlTextReaderImpl.InitInputType initType;
		}

		// Token: 0x02000044 RID: 68
		[Token(Token = "0x2000044")]
		private enum InitInputType
		{
			// Token: 0x0400018E RID: 398
			[Token(Token = "0x400018E")]
			UriString,
			// Token: 0x0400018F RID: 399
			[Token(Token = "0x400018F")]
			Stream,
			// Token: 0x04000190 RID: 400
			[Token(Token = "0x4000190")]
			TextReader,
			// Token: 0x04000191 RID: 401
			[Token(Token = "0x4000191")]
			Invalid
		}

		// Token: 0x02000045 RID: 69
		[Token(Token = "0x2000045")]
		private struct ParsingState
		{
			// Token: 0x0600032C RID: 812 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600032C")]
			[Address(RVA = "0x4FA5BC0", Offset = "0x4FA47C0", VA = "0x184FA5BC0")]
			internal void Clear()
			{
			}

			// Token: 0x0600032D RID: 813 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600032D")]
			[Address(RVA = "0x4FA5CA0", Offset = "0x4FA48A0", VA = "0x184FA5CA0")]
			internal void Close(bool closeInput)
			{
			}

			// Token: 0x170000A6 RID: 166
			// (get) Token: 0x0600032E RID: 814 RVA: 0x00002BF8 File Offset: 0x00000DF8
			[Token(Token = "0x170000A6")]
			internal int LineNo
			{
				[Token(Token = "0x600032E")]
				[Address(RVA = "0x14DAA90", Offset = "0x14D9690", VA = "0x1814DAA90")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170000A7 RID: 167
			// (get) Token: 0x0600032F RID: 815 RVA: 0x00002C10 File Offset: 0x00000E10
			[Token(Token = "0x170000A7")]
			internal int LinePos
			{
				[Token(Token = "0x600032F")]
				[Address(RVA = "0x4FA5D30", Offset = "0x4FA4930", VA = "0x184FA5D30")]
				get
				{
					return 0;
				}
			}

			// Token: 0x04000192 RID: 402
			[Token(Token = "0x4000192")]
			[FieldOffset(Offset = "0x0")]
			internal char[] chars;

			// Token: 0x04000193 RID: 403
			[Token(Token = "0x4000193")]
			[FieldOffset(Offset = "0x8")]
			internal int charPos;

			// Token: 0x04000194 RID: 404
			[Token(Token = "0x4000194")]
			[FieldOffset(Offset = "0xC")]
			internal int charsUsed;

			// Token: 0x04000195 RID: 405
			[Token(Token = "0x4000195")]
			[FieldOffset(Offset = "0x10")]
			internal Encoding encoding;

			// Token: 0x04000196 RID: 406
			[Token(Token = "0x4000196")]
			[FieldOffset(Offset = "0x18")]
			internal bool appendMode;

			// Token: 0x04000197 RID: 407
			[Token(Token = "0x4000197")]
			[FieldOffset(Offset = "0x20")]
			internal Stream stream;

			// Token: 0x04000198 RID: 408
			[Token(Token = "0x4000198")]
			[FieldOffset(Offset = "0x28")]
			internal Decoder decoder;

			// Token: 0x04000199 RID: 409
			[Token(Token = "0x4000199")]
			[FieldOffset(Offset = "0x30")]
			internal byte[] bytes;

			// Token: 0x0400019A RID: 410
			[Token(Token = "0x400019A")]
			[FieldOffset(Offset = "0x38")]
			internal int bytePos;

			// Token: 0x0400019B RID: 411
			[Token(Token = "0x400019B")]
			[FieldOffset(Offset = "0x3C")]
			internal int bytesUsed;

			// Token: 0x0400019C RID: 412
			[Token(Token = "0x400019C")]
			[FieldOffset(Offset = "0x40")]
			internal TextReader textReader;

			// Token: 0x0400019D RID: 413
			[Token(Token = "0x400019D")]
			[FieldOffset(Offset = "0x48")]
			internal int lineNo;

			// Token: 0x0400019E RID: 414
			[Token(Token = "0x400019E")]
			[FieldOffset(Offset = "0x4C")]
			internal int lineStartPos;

			// Token: 0x0400019F RID: 415
			[Token(Token = "0x400019F")]
			[FieldOffset(Offset = "0x50")]
			internal string baseUriStr;

			// Token: 0x040001A0 RID: 416
			[Token(Token = "0x40001A0")]
			[FieldOffset(Offset = "0x58")]
			internal Uri baseUri;

			// Token: 0x040001A1 RID: 417
			[Token(Token = "0x40001A1")]
			[FieldOffset(Offset = "0x60")]
			internal bool isEof;

			// Token: 0x040001A2 RID: 418
			[Token(Token = "0x40001A2")]
			[FieldOffset(Offset = "0x61")]
			internal bool isStreamEof;

			// Token: 0x040001A3 RID: 419
			[Token(Token = "0x40001A3")]
			[FieldOffset(Offset = "0x68")]
			internal IDtdEntityInfo entity;

			// Token: 0x040001A4 RID: 420
			[Token(Token = "0x40001A4")]
			[FieldOffset(Offset = "0x70")]
			internal int entityId;

			// Token: 0x040001A5 RID: 421
			[Token(Token = "0x40001A5")]
			[FieldOffset(Offset = "0x74")]
			internal bool eolNormalized;

			// Token: 0x040001A6 RID: 422
			[Token(Token = "0x40001A6")]
			[FieldOffset(Offset = "0x75")]
			internal bool entityResolvedManually;
		}

		// Token: 0x02000046 RID: 70
		[Token(Token = "0x2000046")]
		private class XmlContext
		{
			// Token: 0x06000330 RID: 816 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000330")]
			[Address(RVA = "0x4FA8D90", Offset = "0x4FA7990", VA = "0x184FA8D90")]
			internal XmlContext()
			{
			}

			// Token: 0x06000331 RID: 817 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000331")]
			[Address(RVA = "0x4FA8E20", Offset = "0x4FA7A20", VA = "0x184FA8E20")]
			internal XmlContext(XmlTextReaderImpl.XmlContext previousContext)
			{
			}

			// Token: 0x040001A7 RID: 423
			[Token(Token = "0x40001A7")]
			[FieldOffset(Offset = "0x10")]
			internal XmlSpace xmlSpace;

			// Token: 0x040001A8 RID: 424
			[Token(Token = "0x40001A8")]
			[FieldOffset(Offset = "0x18")]
			internal string xmlLang;

			// Token: 0x040001A9 RID: 425
			[Token(Token = "0x40001A9")]
			[FieldOffset(Offset = "0x20")]
			internal string defaultNamespace;

			// Token: 0x040001AA RID: 426
			[Token(Token = "0x40001AA")]
			[FieldOffset(Offset = "0x28")]
			internal XmlTextReaderImpl.XmlContext previousContext;
		}

		// Token: 0x02000047 RID: 71
		[Token(Token = "0x2000047")]
		private class NoNamespaceManager : XmlNamespaceManager
		{
			// Token: 0x06000332 RID: 818 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000332")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public NoNamespaceManager()
			{
			}

			// Token: 0x170000A8 RID: 168
			// (get) Token: 0x06000333 RID: 819 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000A8")]
			public override string DefaultNamespace
			{
				[Token(Token = "0x6000333")]
				[Address(RVA = "0x4FA5090", Offset = "0x4FA3C90", VA = "0x184FA5090", Slot = "8")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000334 RID: 820 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000334")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "9")]
			public override void PushScope()
			{
			}

			// Token: 0x06000335 RID: 821 RVA: 0x00002C28 File Offset: 0x00000E28
			[Token(Token = "0x6000335")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "10")]
			public override bool PopScope()
			{
				return default(bool);
			}

			// Token: 0x06000336 RID: 822 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000336")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "11")]
			public override void AddNamespace(string prefix, string uri)
			{
			}

			// Token: 0x06000337 RID: 823 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000337")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "12")]
			public override void RemoveNamespace(string prefix, string uri)
			{
			}

			// Token: 0x06000338 RID: 824 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000338")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "13")]
			public override IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x06000339 RID: 825 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000339")]
			[Address(RVA = "0x4FA5050", Offset = "0x4FA3C50", VA = "0x184FA5050", Slot = "14")]
			public override string LookupNamespace(string prefix)
			{
				return null;
			}

			// Token: 0x0600033A RID: 826 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600033A")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "15")]
			public override string LookupPrefix(string uri)
			{
				return null;
			}
		}

		// Token: 0x02000048 RID: 72
		[Token(Token = "0x2000048")]
		internal class DtdParserProxy : IDtdParserAdapterV1, IDtdParserAdapterWithValidation, IDtdParserAdapter
		{
			// Token: 0x0600033B RID: 827 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600033B")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			internal DtdParserProxy(XmlTextReaderImpl reader)
			{
			}

			// Token: 0x170000A9 RID: 169
			// (get) Token: 0x0600033C RID: 828 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000A9")]
			private XmlNameTable NameTable
			{
				[Token(Token = "0x600033C")]
				[Address(RVA = "0x4FA4C20", Offset = "0x4FA3820", VA = "0x184FA4C20", Slot = "9")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000AA RID: 170
			// (get) Token: 0x0600033D RID: 829 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000AA")]
			private IXmlNamespaceResolver NamespaceResolver
			{
				[Token(Token = "0x600033D")]
				[Address(RVA = "0x4FA4C40", Offset = "0x4FA3840", VA = "0x184FA4C40", Slot = "10")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000AB RID: 171
			// (get) Token: 0x0600033E RID: 830 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000AB")]
			private Uri BaseUri
			{
				[Token(Token = "0x600033E")]
				[Address(RVA = "0x4FA4B40", Offset = "0x4FA3740", VA = "0x184FA4B40", Slot = "11")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000AC RID: 172
			// (get) Token: 0x0600033F RID: 831 RVA: 0x00002C40 File Offset: 0x00000E40
			[Token(Token = "0x170000AC")]
			private bool IsEof
			{
				[Token(Token = "0x600033F")]
				[Address(RVA = "0x4FA4BC0", Offset = "0x4FA37C0", VA = "0x184FA4BC0", Slot = "18")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170000AD RID: 173
			// (get) Token: 0x06000340 RID: 832 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000AD")]
			private char[] ParsingBuffer
			{
				[Token(Token = "0x6000340")]
				[Address(RVA = "0x4FA4C80", Offset = "0x4FA3880", VA = "0x184FA4C80", Slot = "12")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000AE RID: 174
			// (get) Token: 0x06000341 RID: 833 RVA: 0x00002C58 File Offset: 0x00000E58
			[Token(Token = "0x170000AE")]
			private int ParsingBufferLength
			{
				[Token(Token = "0x6000341")]
				[Address(RVA = "0x4FA4C60", Offset = "0x4FA3860", VA = "0x184FA4C60", Slot = "13")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170000AF RID: 175
			// (get) Token: 0x06000342 RID: 834 RVA: 0x00002C70 File Offset: 0x00000E70
			// (set) Token: 0x06000343 RID: 835 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170000AF")]
			private int CurrentPosition
			{
				[Token(Token = "0x6000342")]
				[Address(RVA = "0x4FA4B60", Offset = "0x4FA3760", VA = "0x184FA4B60", Slot = "14")]
				get
				{
					return 0;
				}
				[Token(Token = "0x6000343")]
				[Address(RVA = "0x4FA4CA0", Offset = "0x4FA38A0", VA = "0x184FA4CA0", Slot = "15")]
				set
				{
				}
			}

			// Token: 0x170000B0 RID: 176
			// (get) Token: 0x06000344 RID: 836 RVA: 0x00002C88 File Offset: 0x00000E88
			[Token(Token = "0x170000B0")]
			private int EntityStackLength
			{
				[Token(Token = "0x6000344")]
				[Address(RVA = "0x4FA4B80", Offset = "0x4FA3780", VA = "0x184FA4B80", Slot = "19")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170000B1 RID: 177
			// (get) Token: 0x06000345 RID: 837 RVA: 0x00002CA0 File Offset: 0x00000EA0
			[Token(Token = "0x170000B1")]
			private bool IsEntityEolNormalized
			{
				[Token(Token = "0x6000345")]
				[Address(RVA = "0x4FA4BA0", Offset = "0x4FA37A0", VA = "0x184FA4BA0", Slot = "20")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06000346 RID: 838 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000346")]
			[Address(RVA = "0x4FA4980", Offset = "0x4FA3580", VA = "0x184FA4980", Slot = "22")]
			private void OnNewLine(int pos)
			{
			}

			// Token: 0x170000B2 RID: 178
			// (get) Token: 0x06000347 RID: 839 RVA: 0x00002CB8 File Offset: 0x00000EB8
			[Token(Token = "0x170000B2")]
			private int LineNo
			{
				[Token(Token = "0x6000347")]
				[Address(RVA = "0x4FA4BE0", Offset = "0x4FA37E0", VA = "0x184FA4BE0", Slot = "16")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170000B3 RID: 179
			// (get) Token: 0x06000348 RID: 840 RVA: 0x00002CD0 File Offset: 0x00000ED0
			[Token(Token = "0x170000B3")]
			private int LineStartPosition
			{
				[Token(Token = "0x6000348")]
				[Address(RVA = "0x4FA4C00", Offset = "0x4FA3800", VA = "0x184FA4C00", Slot = "17")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06000349 RID: 841 RVA: 0x00002CE8 File Offset: 0x00000EE8
			[Token(Token = "0x6000349")]
			[Address(RVA = "0x4FA4B00", Offset = "0x4FA3700", VA = "0x184FA4B00", Slot = "21")]
			private int ReadData()
			{
				return 0;
			}

			// Token: 0x0600034A RID: 842 RVA: 0x00002D00 File Offset: 0x00000F00
			[Token(Token = "0x600034A")]
			[Address(RVA = "0x4FA4A40", Offset = "0x4FA3640", VA = "0x184FA4A40", Slot = "23")]
			private int ParseNumericCharRef(StringBuilder internalSubsetBuilder)
			{
				return 0;
			}

			// Token: 0x0600034B RID: 843 RVA: 0x00002D18 File Offset: 0x00000F18
			[Token(Token = "0x600034B")]
			[Address(RVA = "0x4FA4A20", Offset = "0x4FA3620", VA = "0x184FA4A20", Slot = "24")]
			private int ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder)
			{
				return 0;
			}

			// Token: 0x0600034C RID: 844 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600034C")]
			[Address(RVA = "0x4FA4A60", Offset = "0x4FA3660", VA = "0x184FA4A60", Slot = "25")]
			private void ParsePI(StringBuilder sb)
			{
			}

			// Token: 0x0600034D RID: 845 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600034D")]
			[Address(RVA = "0x4FA4A00", Offset = "0x4FA3600", VA = "0x184FA4A00", Slot = "26")]
			private void ParseComment(StringBuilder sb)
			{
			}

			// Token: 0x0600034E RID: 846 RVA: 0x00002D30 File Offset: 0x00000F30
			[Token(Token = "0x600034E")]
			[Address(RVA = "0x4FA4AA0", Offset = "0x4FA36A0", VA = "0x184FA4AA0", Slot = "27")]
			private bool PushEntity(IDtdEntityInfo entity, out int entityId)
			{
				return default(bool);
			}

			// Token: 0x0600034F RID: 847 RVA: 0x00002D48 File Offset: 0x00000F48
			[Token(Token = "0x600034F")]
			[Address(RVA = "0x4FA4A80", Offset = "0x4FA3680", VA = "0x184FA4A80", Slot = "28")]
			private bool PopEntity(out IDtdEntityInfo oldEntity, out int newEntityId)
			{
				return default(bool);
			}

			// Token: 0x06000350 RID: 848 RVA: 0x00002D60 File Offset: 0x00000F60
			[Token(Token = "0x6000350")]
			[Address(RVA = "0x4FA4AC0", Offset = "0x4FA36C0", VA = "0x184FA4AC0", Slot = "29")]
			private bool PushExternalSubset(string systemId, string publicId)
			{
				return default(bool);
			}

			// Token: 0x06000351 RID: 849 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000351")]
			[Address(RVA = "0x4FA4AE0", Offset = "0x4FA36E0", VA = "0x184FA4AE0", Slot = "30")]
			private void PushInternalDtd(string baseUri, string internalDtd)
			{
			}

			// Token: 0x06000352 RID: 850 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000352")]
			[Address(RVA = "0x4FA4B20", Offset = "0x4FA3720", VA = "0x184FA4B20", Slot = "33")]
			private void Throw(Exception e)
			{
			}

			// Token: 0x06000353 RID: 851 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000353")]
			[Address(RVA = "0x4FA49D0", Offset = "0x4FA35D0", VA = "0x184FA49D0", Slot = "31")]
			private void OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo)
			{
			}

			// Token: 0x06000354 RID: 852 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000354")]
			[Address(RVA = "0x4FA49A0", Offset = "0x4FA35A0", VA = "0x184FA49A0", Slot = "32")]
			private void OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo)
			{
			}

			// Token: 0x170000B4 RID: 180
			// (get) Token: 0x06000355 RID: 853 RVA: 0x00002D78 File Offset: 0x00000F78
			[Token(Token = "0x170000B4")]
			private bool DtdValidation
			{
				[Token(Token = "0x6000355")]
				[Address(RVA = "0x4FA4940", Offset = "0x4FA3540", VA = "0x184FA4940", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170000B5 RID: 181
			// (get) Token: 0x06000356 RID: 854 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000B5")]
			private IValidationEventHandling ValidationEventHandling
			{
				[Token(Token = "0x6000356")]
				[Address(RVA = "0x4FA4960", Offset = "0x4FA3560", VA = "0x184FA4960", Slot = "8")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000B6 RID: 182
			// (get) Token: 0x06000357 RID: 855 RVA: 0x00002D90 File Offset: 0x00000F90
			[Token(Token = "0x170000B6")]
			private bool Normalization
			{
				[Token(Token = "0x6000357")]
				[Address(RVA = "0x4FA4900", Offset = "0x4FA3500", VA = "0x184FA4900", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170000B7 RID: 183
			// (get) Token: 0x06000358 RID: 856 RVA: 0x00002DA8 File Offset: 0x00000FA8
			[Token(Token = "0x170000B7")]
			private bool Namespaces
			{
				[Token(Token = "0x6000358")]
				[Address(RVA = "0x4FA48E0", Offset = "0x4FA34E0", VA = "0x184FA48E0", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170000B8 RID: 184
			// (get) Token: 0x06000359 RID: 857 RVA: 0x00002DC0 File Offset: 0x00000FC0
			[Token(Token = "0x170000B8")]
			private bool V1CompatibilityMode
			{
				[Token(Token = "0x6000359")]
				[Address(RVA = "0x4FA4920", Offset = "0x4FA3520", VA = "0x184FA4920", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x040001AB RID: 427
			[Token(Token = "0x40001AB")]
			[FieldOffset(Offset = "0x10")]
			private XmlTextReaderImpl reader;
		}

		// Token: 0x02000049 RID: 73
		[Token(Token = "0x2000049")]
		private class NodeData : IComparable
		{
			// Token: 0x170000B9 RID: 185
			// (get) Token: 0x0600035A RID: 858 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000B9")]
			internal static XmlTextReaderImpl.NodeData None
			{
				[Token(Token = "0x600035A")]
				[Address(RVA = "0x4FA5A10", Offset = "0x4FA4610", VA = "0x184FA5A10")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600035B RID: 859 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600035B")]
			[Address(RVA = "0x4FA5920", Offset = "0x4FA4520", VA = "0x184FA5920")]
			internal NodeData()
			{
			}

			// Token: 0x170000BA RID: 186
			// (get) Token: 0x0600035C RID: 860 RVA: 0x00002DD8 File Offset: 0x00000FD8
			[Token(Token = "0x170000BA")]
			internal int LineNo
			{
				[Token(Token = "0x600035C")]
				[Address(RVA = "0x509F60", Offset = "0x508B60", VA = "0x180509F60")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170000BB RID: 187
			// (get) Token: 0x0600035D RID: 861 RVA: 0x00002DF0 File Offset: 0x00000FF0
			[Token(Token = "0x170000BB")]
			internal int LinePos
			{
				[Token(Token = "0x600035D")]
				[Address(RVA = "0x4FA5A00", Offset = "0x4FA4600", VA = "0x184FA5A00")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170000BC RID: 188
			// (get) Token: 0x0600035E RID: 862 RVA: 0x00002E08 File Offset: 0x00001008
			// (set) Token: 0x0600035F RID: 863 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170000BC")]
			internal bool IsEmptyElement
			{
				[Token(Token = "0x600035E")]
				[Address(RVA = "0x4FA59F0", Offset = "0x4FA45F0", VA = "0x184FA59F0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600035F")]
				[Address(RVA = "0x4BA2FE0", Offset = "0x4BA1BE0", VA = "0x184BA2FE0")]
				set
				{
				}
			}

			// Token: 0x170000BD RID: 189
			// (get) Token: 0x06000360 RID: 864 RVA: 0x00002E20 File Offset: 0x00001020
			// (set) Token: 0x06000361 RID: 865 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170000BD")]
			internal bool IsDefaultAttribute
			{
				[Token(Token = "0x6000360")]
				[Address(RVA = "0x4FA59E0", Offset = "0x4FA45E0", VA = "0x184FA59E0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000361")]
				[Address(RVA = "0x4BA2FE0", Offset = "0x4BA1BE0", VA = "0x184BA2FE0")]
				set
				{
				}
			}

			// Token: 0x170000BE RID: 190
			// (get) Token: 0x06000362 RID: 866 RVA: 0x00002E38 File Offset: 0x00001038
			[Token(Token = "0x170000BE")]
			internal bool ValueBuffered
			{
				[Token(Token = "0x6000362")]
				[Address(RVA = "0x4FA5BB0", Offset = "0x4FA47B0", VA = "0x184FA5BB0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170000BF RID: 191
			// (get) Token: 0x06000363 RID: 867 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000BF")]
			internal string StringValue
			{
				[Token(Token = "0x6000363")]
				[Address(RVA = "0x4FA5B60", Offset = "0x4FA4760", VA = "0x184FA5B60")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000364 RID: 868 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000364")]
			[Address(RVA = "0x4FA58D0", Offset = "0x4FA44D0", VA = "0x184FA58D0")]
			internal void TrimSpacesInValue()
			{
			}

			// Token: 0x06000365 RID: 869 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000365")]
			[Address(RVA = "0x4FA5170", Offset = "0x4FA3D70", VA = "0x184FA5170")]
			internal void Clear(XmlNodeType type)
			{
			}

			// Token: 0x06000366 RID: 870 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000366")]
			[Address(RVA = "0x4FA50D0", Offset = "0x4FA3CD0", VA = "0x184FA50D0")]
			internal void ClearName()
			{
			}

			// Token: 0x06000367 RID: 871 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000367")]
			[Address(RVA = "0x4FA54C0", Offset = "0x4FA40C0", VA = "0x184FA54C0")]
			internal void SetLineInfo(int lineNo, int linePos)
			{
			}

			// Token: 0x06000368 RID: 872 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000368")]
			[Address(RVA = "0x4FA54B0", Offset = "0x4FA40B0", VA = "0x184FA54B0")]
			internal void SetLineInfo2(int lineNo, int linePos)
			{
			}

			// Token: 0x06000369 RID: 873 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000369")]
			[Address(RVA = "0x4FA5690", Offset = "0x4FA4290", VA = "0x184FA5690")]
			internal void SetValueNode(XmlNodeType type, string value)
			{
			}

			// Token: 0x0600036A RID: 874 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600036A")]
			[Address(RVA = "0x4FA56D0", Offset = "0x4FA42D0", VA = "0x184FA56D0")]
			internal void SetValueNode(XmlNodeType type, char[] chars, int startPos, int len)
			{
			}

			// Token: 0x0600036B RID: 875 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600036B")]
			[Address(RVA = "0x4FA54D0", Offset = "0x4FA40D0", VA = "0x184FA54D0")]
			internal void SetNamedNode(XmlNodeType type, string localName)
			{
			}

			// Token: 0x0600036C RID: 876 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600036C")]
			[Address(RVA = "0x4FA55C0", Offset = "0x4FA41C0", VA = "0x184FA55C0")]
			internal void SetNamedNode(XmlNodeType type, string localName, string prefix, string nameWPrefix)
			{
			}

			// Token: 0x0600036D RID: 877 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600036D")]
			[Address(RVA = "0x4FA5730", Offset = "0x4FA4330", VA = "0x184FA5730")]
			internal void SetValue(string value)
			{
			}

			// Token: 0x0600036E RID: 878 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600036E")]
			[Address(RVA = "0x4FA5750", Offset = "0x4FA4350", VA = "0x184FA5750")]
			internal void SetValue(char[] chars, int startPos, int len)
			{
			}

			// Token: 0x0600036F RID: 879 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600036F")]
			[Address(RVA = "0x4FA5440", Offset = "0x4FA4040", VA = "0x184FA5440")]
			internal void OnBufferInvalidated()
			{
			}

			// Token: 0x06000370 RID: 880 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000370")]
			[Address(RVA = "0x4FA5220", Offset = "0x4FA3E20", VA = "0x184FA5220")]
			internal void CopyTo(int valueOffset, StringBuilder sb)
			{
			}

			// Token: 0x06000371 RID: 881 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000371")]
			[Address(RVA = "0x4FA5370", Offset = "0x4FA3F70", VA = "0x184FA5370")]
			internal string GetNameWPrefix(XmlNameTable nt)
			{
				return null;
			}

			// Token: 0x06000372 RID: 882 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000372")]
			[Address(RVA = "0x4FA52B0", Offset = "0x4FA3EB0", VA = "0x184FA52B0")]
			internal string CreateNameWPrefix(XmlNameTable nt)
			{
				return null;
			}

			// Token: 0x06000373 RID: 883 RVA: 0x00002E50 File Offset: 0x00001050
			[Token(Token = "0x6000373")]
			[Address(RVA = "0x4FA57B0", Offset = "0x4FA43B0", VA = "0x184FA57B0", Slot = "4")]
			private int CompareTo(object obj)
			{
				return 0;
			}

			// Token: 0x040001AC RID: 428
			[Token(Token = "0x40001AC")]
			[FieldOffset(Offset = "0x0")]
			private static XmlTextReaderImpl.NodeData s_None;

			// Token: 0x040001AD RID: 429
			[Token(Token = "0x40001AD")]
			[FieldOffset(Offset = "0x10")]
			internal XmlNodeType type;

			// Token: 0x040001AE RID: 430
			[Token(Token = "0x40001AE")]
			[FieldOffset(Offset = "0x18")]
			internal string localName;

			// Token: 0x040001AF RID: 431
			[Token(Token = "0x40001AF")]
			[FieldOffset(Offset = "0x20")]
			internal string prefix;

			// Token: 0x040001B0 RID: 432
			[Token(Token = "0x40001B0")]
			[FieldOffset(Offset = "0x28")]
			internal string ns;

			// Token: 0x040001B1 RID: 433
			[Token(Token = "0x40001B1")]
			[FieldOffset(Offset = "0x30")]
			internal string nameWPrefix;

			// Token: 0x040001B2 RID: 434
			[Token(Token = "0x40001B2")]
			[FieldOffset(Offset = "0x38")]
			private string value;

			// Token: 0x040001B3 RID: 435
			[Token(Token = "0x40001B3")]
			[FieldOffset(Offset = "0x40")]
			private char[] chars;

			// Token: 0x040001B4 RID: 436
			[Token(Token = "0x40001B4")]
			[FieldOffset(Offset = "0x48")]
			private int valueStartPos;

			// Token: 0x040001B5 RID: 437
			[Token(Token = "0x40001B5")]
			[FieldOffset(Offset = "0x4C")]
			private int valueLength;

			// Token: 0x040001B6 RID: 438
			[Token(Token = "0x40001B6")]
			[FieldOffset(Offset = "0x50")]
			internal LineInfo lineInfo;

			// Token: 0x040001B7 RID: 439
			[Token(Token = "0x40001B7")]
			[FieldOffset(Offset = "0x58")]
			internal LineInfo lineInfo2;

			// Token: 0x040001B8 RID: 440
			[Token(Token = "0x40001B8")]
			[FieldOffset(Offset = "0x60")]
			internal char quoteChar;

			// Token: 0x040001B9 RID: 441
			[Token(Token = "0x40001B9")]
			[FieldOffset(Offset = "0x64")]
			internal int depth;

			// Token: 0x040001BA RID: 442
			[Token(Token = "0x40001BA")]
			[FieldOffset(Offset = "0x68")]
			private bool isEmptyOrDefault;

			// Token: 0x040001BB RID: 443
			[Token(Token = "0x40001BB")]
			[FieldOffset(Offset = "0x6C")]
			internal int entityId;

			// Token: 0x040001BC RID: 444
			[Token(Token = "0x40001BC")]
			[FieldOffset(Offset = "0x70")]
			internal bool xmlContextPushed;

			// Token: 0x040001BD RID: 445
			[Token(Token = "0x40001BD")]
			[FieldOffset(Offset = "0x78")]
			internal XmlTextReaderImpl.NodeData nextAttrValueChunk;

			// Token: 0x040001BE RID: 446
			[Token(Token = "0x40001BE")]
			[FieldOffset(Offset = "0x80")]
			internal object schemaType;

			// Token: 0x040001BF RID: 447
			[Token(Token = "0x40001BF")]
			[FieldOffset(Offset = "0x88")]
			internal object typedValue;
		}

		// Token: 0x0200004A RID: 74
		[Token(Token = "0x200004A")]
		private class DtdDefaultAttributeInfoToNodeDataComparer : IComparer<object>
		{
			// Token: 0x170000C0 RID: 192
			// (get) Token: 0x06000374 RID: 884 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000C0")]
			internal static IComparer<object> Instance
			{
				[Token(Token = "0x6000374")]
				[Address(RVA = "0x4FA4890", Offset = "0x4FA3490", VA = "0x184FA4890")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000375 RID: 885 RVA: 0x00002E68 File Offset: 0x00001068
			[Token(Token = "0x6000375")]
			[Address(RVA = "0x4FA4540", Offset = "0x4FA3140", VA = "0x184FA4540", Slot = "4")]
			public int Compare(object x, object y)
			{
				return 0;
			}

			// Token: 0x06000376 RID: 886 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000376")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DtdDefaultAttributeInfoToNodeDataComparer()
			{
			}

			// Token: 0x040001C0 RID: 448
			[Token(Token = "0x40001C0")]
			[FieldOffset(Offset = "0x0")]
			private static IComparer<object> s_instance;
		}

		// Token: 0x0200004B RID: 75
		// (Invoke) Token: 0x06000379 RID: 889
		[Token(Token = "0x200004B")]
		internal delegate void OnDefaultAttributeUseDelegate(IDtdDefaultAttributeInfo defaultAttribute, XmlTextReaderImpl coreReader);
	}
}
