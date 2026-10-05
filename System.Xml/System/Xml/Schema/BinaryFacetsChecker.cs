using System;
using System.Collections;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x02000127 RID: 295
	[Token(Token = "0x2000127")]
	internal class BinaryFacetsChecker : FacetsChecker
	{
		// Token: 0x06000A05 RID: 2565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A05")]
		[Address(RVA = "0x4FF9A70", Offset = "0x4FF8670", VA = "0x184FF9A70", Slot = "5")]
		internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype)
		{
			return null;
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A06")]
		[Address(RVA = "0x4FF9B30", Offset = "0x4FF8730", VA = "0x184FF9B30", Slot = "14")]
		internal override Exception CheckValueFacets(byte[] value, XmlSchemaDatatype datatype)
		{
			return null;
		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x000054F0 File Offset: 0x000036F0
		[Token(Token = "0x6000A07")]
		[Address(RVA = "0x4FF9D50", Offset = "0x4FF8950", VA = "0x184FF9D50", Slot = "17")]
		internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype)
		{
			return default(bool);
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x00005508 File Offset: 0x00003708
		[Token(Token = "0x6000A08")]
		[Address(RVA = "0x4FF9E00", Offset = "0x4FF8A00", VA = "0x184FF9E00")]
		private bool MatchEnumeration(byte[] value, ArrayList enumeration, XmlSchemaDatatype datatype)
		{
			return default(bool);
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A09")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BinaryFacetsChecker()
		{
		}
	}
}
