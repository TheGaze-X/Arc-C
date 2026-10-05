using System;
using System.Collections.Generic;
using System.Xml;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x0200010D RID: 269
	[Token(Token = "0x200010D")]
	internal class XmlNodeWrapper : IXmlNode
	{
		// Token: 0x06000A91 RID: 2705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A91")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		public XmlNodeWrapper(XmlNode node)
		{
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000A92 RID: 2706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001E4")]
		public object WrappedNode
		{
			[Token(Token = "0x6000A92")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000A93 RID: 2707 RVA: 0x00005F88 File Offset: 0x00004188
		[Token(Token = "0x170001E5")]
		public XmlNodeType NodeType
		{
			[Token(Token = "0x6000A93")]
			[Address(RVA = "0x4BAB620", Offset = "0x4BAA220", VA = "0x184BAB620", Slot = "4")]
			get
			{
				return XmlNodeType.None;
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000A94 RID: 2708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001E6")]
		public virtual string LocalName
		{
			[Token(Token = "0x6000A94")]
			[Address(RVA = "0x4ADF130", Offset = "0x4ADDD30", VA = "0x184ADF130", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000A95 RID: 2709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001E7")]
		public List<IXmlNode> ChildNodes
		{
			[Token(Token = "0x6000A95")]
			[Address(RVA = "0x4DFC240", Offset = "0x4DFAE40", VA = "0x184DFC240", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A96")]
		[Address(RVA = "0x4DFB910", Offset = "0x4DFA510", VA = "0x184DFB910")]
		internal static IXmlNode WrapNode(XmlNode node)
		{
			return null;
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000A97 RID: 2711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001E8")]
		public List<IXmlNode> Attributes
		{
			[Token(Token = "0x6000A97")]
			[Address(RVA = "0x4DFBBA0", Offset = "0x4DFA7A0", VA = "0x184DFBBA0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000A98 RID: 2712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001E9")]
		public IXmlNode ParentNode
		{
			[Token(Token = "0x6000A98")]
			[Address(RVA = "0x4DFC8A0", Offset = "0x4DFB4A0", VA = "0x184DFC8A0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000A99 RID: 2713 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000A9A RID: 2714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001EA")]
		public string Value
		{
			[Token(Token = "0x6000A99")]
			[Address(RVA = "0x4DFCA90", Offset = "0x4DFB690", VA = "0x184DFCA90", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A9A")]
			[Address(RVA = "0x4DFCAE0", Offset = "0x4DFB6E0", VA = "0x184DFCAE0", Slot = "10")]
			set
			{
			}
		}

		// Token: 0x06000A9B RID: 2715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A9B")]
		[Address(RVA = "0x4DFB7F0", Offset = "0x4DFA3F0", VA = "0x184DFB7F0", Slot = "11")]
		public IXmlNode AppendChild(IXmlNode newChild)
		{
			return null;
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000A9C RID: 2716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001EB")]
		public string NamespaceUri
		{
			[Token(Token = "0x6000A9C")]
			[Address(RVA = "0x4C679C0", Offset = "0x4C665C0", VA = "0x184C679C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000411 RID: 1041
		[Token(Token = "0x4000411")]
		[FieldOffset(Offset = "0x10")]
		private readonly XmlNode _node;

		// Token: 0x04000412 RID: 1042
		[Token(Token = "0x4000412")]
		[FieldOffset(Offset = "0x18")]
		private List<IXmlNode> _childNodes;

		// Token: 0x04000413 RID: 1043
		[Token(Token = "0x4000413")]
		[FieldOffset(Offset = "0x20")]
		private List<IXmlNode> _attributes;
	}
}
