using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x020000E7 RID: 231
	[Token(Token = "0x20000E7")]
	internal class Datatype_double : Datatype_anySimpleType
	{
		// Token: 0x060008C7 RID: 2247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008C7")]
		[Address(RVA = "0x4FFE1E0", Offset = "0x4FFCDE0", VA = "0x184FFE1E0", Slot = "16")]
		internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
		{
			return null;
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x060008C8 RID: 2248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000234")]
		internal override FacetsChecker FacetsChecker
		{
			[Token(Token = "0x60008C8")]
			[Address(RVA = "0x4FFE4E0", Offset = "0x4FFD0E0", VA = "0x184FFE4E0", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x060008C9 RID: 2249 RVA: 0x00004C50 File Offset: 0x00002E50
		[Token(Token = "0x17000235")]
		public override XmlTypeCode TypeCode
		{
			[Token(Token = "0x60008C9")]
			[Address(RVA = "0x3D286D0", Offset = "0x3D272D0", VA = "0x183D286D0", Slot = "8")]
			get
			{
				return XmlTypeCode.None;
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x060008CA RID: 2250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000236")]
		public override Type ValueType
		{
			[Token(Token = "0x60008CA")]
			[Address(RVA = "0x4FFE580", Offset = "0x4FFD180", VA = "0x184FFE580", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x060008CB RID: 2251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000237")]
		internal override Type ListValueType
		{
			[Token(Token = "0x60008CB")]
			[Address(RVA = "0x4FFE530", Offset = "0x4FFD130", VA = "0x184FFE530", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x060008CC RID: 2252 RVA: 0x00004C68 File Offset: 0x00002E68
		[Token(Token = "0x17000238")]
		internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			[Token(Token = "0x60008CC")]
			[Address(RVA = "0x54B0E0", Offset = "0x549CE0", VA = "0x18054B0E0", Slot = "14")]
			get
			{
				return XmlSchemaWhiteSpace.Preserve;
			}
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x00004C80 File Offset: 0x00002E80
		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x4FFE160", Offset = "0x4FFCD60", VA = "0x184FFE160", Slot = "11")]
		internal override int Compare(object value1, object value2)
		{
			return 0;
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x4FFE1F0", Offset = "0x4FFCDF0", VA = "0x184FFE1F0", Slot = "12")]
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			return null;
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008CF")]
		[Address(RVA = "0x4FFE460", Offset = "0x4FFD060", VA = "0x184FFE460")]
		public Datatype_double()
		{
		}

		// Token: 0x040004D7 RID: 1239
		[Token(Token = "0x40004D7")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Type atomicValueType;

		// Token: 0x040004D8 RID: 1240
		[Token(Token = "0x40004D8")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Type listValueType;
	}
}
