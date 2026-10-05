using System;
using System.Collections.Generic;
using System.Xml.Linq;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x02000119 RID: 281
	[Token(Token = "0x2000119")]
	internal class XContainerWrapper : XObjectWrapper
	{
		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000AEF RID: 2799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000213")]
		private XContainer Container
		{
			[Token(Token = "0x6000AEF")]
			[Address(RVA = "0x4DF2C30", Offset = "0x4DF1830", VA = "0x184DF2C30")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AF0")]
		[Address(RVA = "0x4DF2930", Offset = "0x4DF1530", VA = "0x184DF2930")]
		public XContainerWrapper(XContainer container)
		{
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000AF1 RID: 2801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000214")]
		public override List<IXmlNode> ChildNodes
		{
			[Token(Token = "0x6000AF1")]
			[Address(RVA = "0x4DF29A0", Offset = "0x4DF15A0", VA = "0x184DF29A0", Slot = "16")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000AF2 RID: 2802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000215")]
		public override IXmlNode ParentNode
		{
			[Token(Token = "0x6000AF2")]
			[Address(RVA = "0x4DF2CE0", Offset = "0x4DF18E0", VA = "0x184DF2CE0", Slot = "18")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000AF3 RID: 2803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AF3")]
		[Address(RVA = "0x4DF2390", Offset = "0x4DF0F90", VA = "0x184DF2390")]
		internal static IXmlNode WrapNode(XObject node)
		{
			return null;
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AF4")]
		[Address(RVA = "0x4DF22F0", Offset = "0x4DF0EF0", VA = "0x184DF22F0", Slot = "21")]
		public override IXmlNode AppendChild(IXmlNode newChild)
		{
			return null;
		}

		// Token: 0x04000416 RID: 1046
		[Token(Token = "0x4000416")]
		[FieldOffset(Offset = "0x18")]
		private List<IXmlNode> _childNodes;
	}
}
