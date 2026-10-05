using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x020000FB RID: 251
	[Token(Token = "0x20000FB")]
	internal class Datatype_anyURI : Datatype_anySimpleType
	{
		// Token: 0x0600091C RID: 2332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600091C")]
		[Address(RVA = "0x4FFA120", Offset = "0x4FF8D20", VA = "0x184FFA120", Slot = "16")]
		internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
		{
			return null;
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x0600091D RID: 2333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700025B")]
		internal override FacetsChecker FacetsChecker
		{
			[Token(Token = "0x600091D")]
			[Address(RVA = "0x4FFB7E0", Offset = "0x4FFA3E0", VA = "0x184FFB7E0", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x0600091E RID: 2334 RVA: 0x00004ED8 File Offset: 0x000030D8
		[Token(Token = "0x1700025C")]
		public override XmlTypeCode TypeCode
		{
			[Token(Token = "0x600091E")]
			[Address(RVA = "0x3D28720", Offset = "0x3D27320", VA = "0x183D28720", Slot = "8")]
			get
			{
				return XmlTypeCode.None;
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x0600091F RID: 2335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700025D")]
		public override Type ValueType
		{
			[Token(Token = "0x600091F")]
			[Address(RVA = "0x4FFB880", Offset = "0x4FFA480", VA = "0x184FFB880", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000920 RID: 2336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700025E")]
		internal override Type ListValueType
		{
			[Token(Token = "0x6000920")]
			[Address(RVA = "0x4FFB830", Offset = "0x4FFA430", VA = "0x184FFB830", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000921 RID: 2337 RVA: 0x00004EF0 File Offset: 0x000030F0
		[Token(Token = "0x1700025F")]
		internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			[Token(Token = "0x6000921")]
			[Address(RVA = "0x54B0E0", Offset = "0x549CE0", VA = "0x18054B0E0", Slot = "14")]
			get
			{
				return XmlSchemaWhiteSpace.Preserve;
			}
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x00004F08 File Offset: 0x00003108
		[Token(Token = "0x6000922")]
		[Address(RVA = "0x4FFB240", Offset = "0x4FF9E40", VA = "0x184FFB240", Slot = "11")]
		internal override int Compare(object value1, object value2)
		{
			return 0;
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000923")]
		[Address(RVA = "0x4FFB410", Offset = "0x4FFA010", VA = "0x184FFB410", Slot = "12")]
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			return null;
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000924")]
		[Address(RVA = "0x4FFB760", Offset = "0x4FFA360", VA = "0x184FFB760")]
		public Datatype_anyURI()
		{
		}

		// Token: 0x040004E5 RID: 1253
		[Token(Token = "0x40004E5")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Type atomicValueType;

		// Token: 0x040004E6 RID: 1254
		[Token(Token = "0x40004E6")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Type listValueType;
	}
}
