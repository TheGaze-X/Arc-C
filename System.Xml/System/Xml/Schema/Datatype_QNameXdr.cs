using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x02000118 RID: 280
	[Token(Token = "0x2000118")]
	internal class Datatype_QNameXdr : Datatype_anySimpleType
	{
		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x060009AE RID: 2478 RVA: 0x00005340 File Offset: 0x00003540
		[Token(Token = "0x170002A6")]
		public override XmlTokenizedType TokenizedType
		{
			[Token(Token = "0x60009AE")]
			[Address(RVA = "0x2114980", Offset = "0x2113580", VA = "0x182114980", Slot = "5")]
			get
			{
				return XmlTokenizedType.CDATA;
			}
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009AF")]
		[Address(RVA = "0x4FFA5B0", Offset = "0x4FF91B0", VA = "0x184FFA5B0", Slot = "6")]
		public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr)
		{
			return null;
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x060009B0 RID: 2480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002A7")]
		public override Type ValueType
		{
			[Token(Token = "0x60009B0")]
			[Address(RVA = "0x4FFA990", Offset = "0x4FF9590", VA = "0x184FFA990", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x060009B1 RID: 2481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002A8")]
		internal override Type ListValueType
		{
			[Token(Token = "0x60009B1")]
			[Address(RVA = "0x4FFA940", Offset = "0x4FF9540", VA = "0x184FFA940", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009B2")]
		[Address(RVA = "0x4FFA8C0", Offset = "0x4FF94C0", VA = "0x184FFA8C0")]
		public Datatype_QNameXdr()
		{
		}

		// Token: 0x04000507 RID: 1287
		[Token(Token = "0x4000507")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Type atomicValueType;

		// Token: 0x04000508 RID: 1288
		[Token(Token = "0x4000508")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Type listValueType;
	}
}
