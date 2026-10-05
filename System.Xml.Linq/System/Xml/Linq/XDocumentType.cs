using System;
using Il2CppDummyDll;

namespace System.Xml.Linq
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	public class XDocumentType : XNode
	{
		// Token: 0x0600004E RID: 78 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x4F89F90", Offset = "0x4F88B90", VA = "0x184F89F90")]
		public XDocumentType(string name, string publicId, string systemId, string internalSubset)
		{
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x4F89ED0", Offset = "0x4F88AD0", VA = "0x184F89ED0")]
		public XDocumentType(XDocumentType other)
		{
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000011")]
		public string InternalSubset
		{
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000012")]
		public string Name
		{
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00002100 File Offset: 0x00000300
		[Token(Token = "0x17000013")]
		public override XmlNodeType NodeType
		{
			[Token(Token = "0x6000052")]
			[Address(RVA = "0x2114980", Offset = "0x2113580", VA = "0x182114980", Slot = "4")]
			get
			{
				return XmlNodeType.None;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000014")]
		public string PublicId
		{
			[Token(Token = "0x6000053")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000015")]
		public string SystemId
		{
			[Token(Token = "0x6000054")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x4F89DF0", Offset = "0x4F889F0", VA = "0x184F89DF0", Slot = "5")]
		public override void WriteTo(XmlWriter writer)
		{
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x4F89CF0", Offset = "0x4F888F0", VA = "0x184F89CF0", Slot = "7")]
		internal override XNode CloneNode()
		{
			return null;
		}

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x28")]
		private string _name;

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x30")]
		private string _publicId;

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x38")]
		private string _systemId;

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x40")]
		private string _internalSubset;
	}
}
