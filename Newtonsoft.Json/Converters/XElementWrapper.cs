using System;
using System.Collections.Generic;
using System.Xml.Linq;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x0200011C RID: 284
	[Token(Token = "0x200011C")]
	internal class XElementWrapper : XContainerWrapper, IXmlElement, IXmlNode
	{
		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000B08 RID: 2824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000223")]
		private XElement Element
		{
			[Token(Token = "0x6000B08")]
			[Address(RVA = "0x4DF44F0", Offset = "0x4DF30F0", VA = "0x184DF44F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B09")]
		[Address(RVA = "0x4DF2930", Offset = "0x4DF1530", VA = "0x184DF2930")]
		public XElementWrapper(XElement element)
		{
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B0A")]
		[Address(RVA = "0x4DF3D30", Offset = "0x4DF2930", VA = "0x184DF3D30", Slot = "23")]
		public void SetAttributeNode(IXmlNode attribute)
		{
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000B0B RID: 2827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000224")]
		public override List<IXmlNode> Attributes
		{
			[Token(Token = "0x6000B0B")]
			[Address(RVA = "0x4DF3E20", Offset = "0x4DF2A20", VA = "0x184DF3E20", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B0C")]
		[Address(RVA = "0x4DF3C30", Offset = "0x4DF2830", VA = "0x184DF3C30", Slot = "21")]
		public override IXmlNode AppendChild(IXmlNode newChild)
		{
			return null;
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000B0D RID: 2829 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000B0E RID: 2830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000225")]
		public override string Value
		{
			[Token(Token = "0x6000B0D")]
			[Address(RVA = "0x4DF4630", Offset = "0x4DF3230", VA = "0x184DF4630", Slot = "19")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B0E")]
			[Address(RVA = "0x4DF4660", Offset = "0x4DF3260", VA = "0x184DF4660", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000B0F RID: 2831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000226")]
		public override string LocalName
		{
			[Token(Token = "0x6000B0F")]
			[Address(RVA = "0x4DF45D0", Offset = "0x4DF31D0", VA = "0x184DF45D0", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000B10 RID: 2832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000227")]
		public override string NamespaceUri
		{
			[Token(Token = "0x6000B10")]
			[Address(RVA = "0x4DF4600", Offset = "0x4DF3200", VA = "0x184DF4600", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000B11 RID: 2833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B11")]
		[Address(RVA = "0x4DF3CE0", Offset = "0x4DF28E0", VA = "0x184DF3CE0", Slot = "24")]
		public string GetPrefixOfNamespace(string namespaceUri)
		{
			return null;
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000B12 RID: 2834 RVA: 0x00005FD0 File Offset: 0x000041D0
		[Token(Token = "0x17000228")]
		public bool IsEmpty
		{
			[Token(Token = "0x6000B12")]
			[Address(RVA = "0x4DF45A0", Offset = "0x4DF31A0", VA = "0x184DF45A0", Slot = "25")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x04000419 RID: 1049
		[Token(Token = "0x4000419")]
		[FieldOffset(Offset = "0x20")]
		private List<IXmlNode> _attributes;
	}
}
