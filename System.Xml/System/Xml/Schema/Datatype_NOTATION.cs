using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x02000108 RID: 264
	[Token(Token = "0x2000108")]
	internal class Datatype_NOTATION : Datatype_anySimpleType
	{
		// Token: 0x0600094D RID: 2381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600094D")]
		[Address(RVA = "0x4FFA120", Offset = "0x4FF8D20", VA = "0x184FFA120", Slot = "16")]
		internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
		{
			return null;
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x0600094E RID: 2382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000277")]
		internal override FacetsChecker FacetsChecker
		{
			[Token(Token = "0x600094E")]
			[Address(RVA = "0x4FFA490", Offset = "0x4FF9090", VA = "0x184FFA490", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x0600094F RID: 2383 RVA: 0x00005100 File Offset: 0x00003300
		[Token(Token = "0x17000278")]
		public override XmlTypeCode TypeCode
		{
			[Token(Token = "0x600094F")]
			[Address(RVA = "0x4FFA540", Offset = "0x4FF9140", VA = "0x184FFA540", Slot = "8")]
			get
			{
				return XmlTypeCode.None;
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000950 RID: 2384 RVA: 0x00005118 File Offset: 0x00003318
		[Token(Token = "0x17000279")]
		public override XmlTokenizedType TokenizedType
		{
			[Token(Token = "0x6000950")]
			[Address(RVA = "0x5586F0", Offset = "0x5572F0", VA = "0x1805586F0", Slot = "5")]
			get
			{
				return XmlTokenizedType.CDATA;
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000951 RID: 2385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700027A")]
		public override Type ValueType
		{
			[Token(Token = "0x6000951")]
			[Address(RVA = "0x4FFA550", Offset = "0x4FF9150", VA = "0x184FFA550", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000952 RID: 2386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700027B")]
		internal override Type ListValueType
		{
			[Token(Token = "0x6000952")]
			[Address(RVA = "0x4FFA4F0", Offset = "0x4FF90F0", VA = "0x184FFA4F0", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000953 RID: 2387 RVA: 0x00005130 File Offset: 0x00003330
		[Token(Token = "0x1700027C")]
		internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			[Token(Token = "0x6000953")]
			[Address(RVA = "0x54B0E0", Offset = "0x549CE0", VA = "0x18054B0E0", Slot = "14")]
			get
			{
				return XmlSchemaWhiteSpace.Preserve;
			}
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000954")]
		[Address(RVA = "0x4FFA130", Offset = "0x4FF8D30", VA = "0x184FFA130", Slot = "12")]
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			return null;
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000955")]
		[Address(RVA = "0x4FFA410", Offset = "0x4FF9010", VA = "0x184FFA410")]
		public Datatype_NOTATION()
		{
		}

		// Token: 0x040004E9 RID: 1257
		[Token(Token = "0x40004E9")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Type atomicValueType;

		// Token: 0x040004EA RID: 1258
		[Token(Token = "0x40004EA")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Type listValueType;
	}
}
