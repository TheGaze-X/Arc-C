using System;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Linq;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x02000113 RID: 275
	[Token(Token = "0x2000113")]
	internal class XDeclarationWrapper : XObjectWrapper, IXmlDeclaration, IXmlNode
	{
		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000AC0 RID: 2752 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000AC1 RID: 2753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001FD")]
		internal XDeclaration Declaration
		{
			[Token(Token = "0x6000AC0")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AC1")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000AC2 RID: 2754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AC2")]
		[Address(RVA = "0x4DF2D40", Offset = "0x4DF1940", VA = "0x184DF2D40")]
		public XDeclarationWrapper(XDeclaration declaration)
		{
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000AC3 RID: 2755 RVA: 0x00005FA0 File Offset: 0x000041A0
		[Token(Token = "0x170001FE")]
		public override XmlNodeType NodeType
		{
			[Token(Token = "0x6000AC3")]
			[Address(RVA = "0x4DF2DE0", Offset = "0x4DF19E0", VA = "0x184DF2DE0", Slot = "14")]
			get
			{
				return XmlNodeType.None;
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06000AC4 RID: 2756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001FF")]
		public string Version
		{
			[Token(Token = "0x6000AC4")]
			[Address(RVA = "0x4A52E10", Offset = "0x4A51A10", VA = "0x184A52E10", Slot = "23")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000AC5 RID: 2757 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000AC6 RID: 2758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000200")]
		public string Encoding
		{
			[Token(Token = "0x6000AC5")]
			[Address(RVA = "0x4DF2DC0", Offset = "0x4DF19C0", VA = "0x184DF2DC0", Slot = "24")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AC6")]
			[Address(RVA = "0x31A1B60", Offset = "0x31A0760", VA = "0x1831A1B60", Slot = "25")]
			set
			{
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000AC7 RID: 2759 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000AC8 RID: 2760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000201")]
		public string Standalone
		{
			[Token(Token = "0x6000AC7")]
			[Address(RVA = "0x4DF2DF0", Offset = "0x4DF19F0", VA = "0x184DF2DF0", Slot = "26")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AC8")]
			[Address(RVA = "0x31BC240", Offset = "0x31BAE40", VA = "0x1831BC240", Slot = "27")]
			set
			{
			}
		}
	}
}
