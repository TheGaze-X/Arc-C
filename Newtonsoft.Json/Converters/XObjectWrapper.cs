using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x0200011A RID: 282
	[Token(Token = "0x200011A")]
	internal class XObjectWrapper : IXmlNode
	{
		// Token: 0x06000AF5 RID: 2805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AF5")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		public XObjectWrapper(XObject xmlObject)
		{
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000AF6 RID: 2806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000216")]
		public object WrappedNode
		{
			[Token(Token = "0x6000AF6")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000AF7 RID: 2807 RVA: 0x00005FB8 File Offset: 0x000041B8
		[Token(Token = "0x17000217")]
		public virtual XmlNodeType NodeType
		{
			[Token(Token = "0x6000AF7")]
			[Address(RVA = "0x4BDD020", Offset = "0x4BDBC20", VA = "0x184BDD020", Slot = "14")]
			get
			{
				return XmlNodeType.None;
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000AF8 RID: 2808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000218")]
		public virtual string LocalName
		{
			[Token(Token = "0x6000AF8")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000AF9 RID: 2809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000219")]
		public virtual List<IXmlNode> ChildNodes
		{
			[Token(Token = "0x6000AF9")]
			[Address(RVA = "0x4DF4770", Offset = "0x4DF3370", VA = "0x184DF4770", Slot = "16")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000AFA RID: 2810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700021A")]
		public virtual List<IXmlNode> Attributes
		{
			[Token(Token = "0x6000AFA")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000AFB RID: 2811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700021B")]
		public virtual IXmlNode ParentNode
		{
			[Token(Token = "0x6000AFB")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "18")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000AFC RID: 2812 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000AFD RID: 2813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700021C")]
		public virtual string Value
		{
			[Token(Token = "0x6000AFC")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "19")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AFD")]
			[Address(RVA = "0x4DF47C0", Offset = "0x4DF33C0", VA = "0x184DF47C0", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AFE")]
		[Address(RVA = "0x4DF4690", Offset = "0x4DF3290", VA = "0x184DF4690", Slot = "21")]
		public virtual IXmlNode AppendChild(IXmlNode newChild)
		{
			return null;
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000AFF RID: 2815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700021D")]
		public virtual string NamespaceUri
		{
			[Token(Token = "0x6000AFF")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000417 RID: 1047
		[Token(Token = "0x4000417")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<IXmlNode> EmptyChildNodes;

		// Token: 0x04000418 RID: 1048
		[Token(Token = "0x4000418")]
		[FieldOffset(Offset = "0x10")]
		private readonly XObject _xmlObject;
	}
}
