using System;
using System.Collections;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x020000DD RID: 221
	[Token(Token = "0x20000DD")]
	internal abstract class DatatypeImplementation : XmlSchemaDatatype
	{
		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000870 RID: 2160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700020A")]
		internal static XmlSchemaSimpleType AnySimpleType
		{
			[Token(Token = "0x6000870")]
			[Address(RVA = "0x4FE0400", Offset = "0x4FDF000", VA = "0x184FE0400")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000871 RID: 2161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700020B")]
		internal static XmlSchemaSimpleType UntypedAtomicType
		{
			[Token(Token = "0x6000871")]
			[Address(RVA = "0x4FE04A0", Offset = "0x4FDF0A0", VA = "0x184FE04A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000872")]
		[Address(RVA = "0x4FDA050", Offset = "0x4FD8C50", VA = "0x184FDA050")]
		internal new static DatatypeImplementation FromXmlTokenizedType(XmlTokenizedType token)
		{
			return null;
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000873")]
		[Address(RVA = "0x4FD9F80", Offset = "0x4FD8B80", VA = "0x184FD9F80")]
		private static DatatypeImplementation FromTypeName(string name)
		{
			return null;
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000874")]
		[Address(RVA = "0x4FDA510", Offset = "0x4FD9110", VA = "0x184FDA510")]
		internal static XmlSchemaSimpleType StartBuiltinType(XmlQualifiedName qname, XmlSchemaDatatype dataType)
		{
			return null;
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000875")]
		[Address(RVA = "0x4FD9CD0", Offset = "0x4FD88D0", VA = "0x184FD9CD0")]
		internal static void FinishBuiltinType(XmlSchemaSimpleType derivedType, XmlSchemaSimpleType baseType)
		{
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000876")]
		[Address(RVA = "0x4FD8AA0", Offset = "0x4FD76A0", VA = "0x184FD8AA0")]
		internal static void CreateBuiltinTypes()
		{
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000877")]
		[Address(RVA = "0x4FDA0D0", Offset = "0x4FD8CD0", VA = "0x184FDA0D0")]
		internal static XmlSchemaSimpleType GetSimpleTypeFromTypeCode(XmlTypeCode typeCode)
		{
			return null;
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000878")]
		[Address(RVA = "0x4FD99C0", Offset = "0x4FD85C0", VA = "0x184FD99C0")]
		internal XmlSchemaDatatype DeriveByList(int minSize, XmlSchemaType schemaType)
		{
			return null;
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x00004998 File Offset: 0x00002B98
		[Token(Token = "0x6000879")]
		[Address(RVA = "0x4FDA1F0", Offset = "0x4FD8DF0", VA = "0x184FDA1F0", Slot = "15")]
		internal override bool IsEqual(object o1, object o2)
		{
			return default(bool);
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600087A")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "16")]
		internal virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
		{
			return null;
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x0600087B RID: 2171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700020C")]
		internal override FacetsChecker FacetsChecker
		{
			[Token(Token = "0x600087B")]
			[Address(RVA = "0x4FE0450", Offset = "0x4FDF050", VA = "0x184FE0450", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x0600087C RID: 2172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700020D")]
		internal override XmlValueConverter ValueConverter
		{
			[Token(Token = "0x600087C")]
			[Address(RVA = "0x4FE04F0", Offset = "0x4FDF0F0", VA = "0x184FE04F0", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x0600087D RID: 2173 RVA: 0x000049B0 File Offset: 0x00002BB0
		[Token(Token = "0x1700020E")]
		public override XmlTokenizedType TokenizedType
		{
			[Token(Token = "0x600087D")]
			[Address(RVA = "0x21127B0", Offset = "0x21113B0", VA = "0x1821127B0", Slot = "5")]
			get
			{
				return XmlTokenizedType.CDATA;
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x0600087E RID: 2174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700020F")]
		public override Type ValueType
		{
			[Token(Token = "0x600087E")]
			[Address(RVA = "0x4FE0570", Offset = "0x4FDF170", VA = "0x184FE0570", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x0600087F RID: 2175 RVA: 0x000049C8 File Offset: 0x00002BC8
		[Token(Token = "0x17000210")]
		public override XmlSchemaDatatypeVariety Variety
		{
			[Token(Token = "0x600087F")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0", Slot = "7")]
			get
			{
				return XmlSchemaDatatypeVariety.Atomic;
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000880 RID: 2176 RVA: 0x000049E0 File Offset: 0x00002BE0
		[Token(Token = "0x17000211")]
		public override XmlTypeCode TypeCode
		{
			[Token(Token = "0x6000880")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "8")]
			get
			{
				return XmlTypeCode.None;
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000881 RID: 2177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000212")]
		internal override RestrictionFacets Restriction
		{
			[Token(Token = "0x6000881")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000882 RID: 2178
		[Token(Token = "0x17000213")]
		internal abstract Type ListValueType { [Token(Token = "0x6000882")] get; }

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000883 RID: 2179 RVA: 0x000049F8 File Offset: 0x00002BF8
		[Token(Token = "0x17000214")]
		internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			[Token(Token = "0x6000883")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "14")]
			get
			{
				return XmlSchemaWhiteSpace.Preserve;
			}
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000884")]
		[Address(RVA = "0x4FDA250", Offset = "0x4FD8E50", VA = "0x184FDA250", Slot = "6")]
		public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr)
		{
			return null;
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000885")]
		[Address(RVA = "0x4FDA140", Offset = "0x4FD8D40", VA = "0x184FDA140")]
		internal string GetTypeName()
		{
			return null;
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x00004A10 File Offset: 0x00002C10
		[Token(Token = "0x6000886")]
		[Address(RVA = "0x4FD8A30", Offset = "0x4FD7630", VA = "0x184FD8A30")]
		protected int Compare(byte[] value1, byte[] value2)
		{
			return 0;
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000887")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		protected DatatypeImplementation()
		{
		}

		// Token: 0x04000470 RID: 1136
		[Token(Token = "0x4000470")]
		[FieldOffset(Offset = "0x10")]
		private XmlSchemaDatatypeVariety variety;

		// Token: 0x04000471 RID: 1137
		[Token(Token = "0x4000471")]
		[FieldOffset(Offset = "0x18")]
		private RestrictionFacets restriction;

		// Token: 0x04000472 RID: 1138
		[Token(Token = "0x4000472")]
		[FieldOffset(Offset = "0x20")]
		private DatatypeImplementation baseType;

		// Token: 0x04000473 RID: 1139
		[Token(Token = "0x4000473")]
		[FieldOffset(Offset = "0x28")]
		private XmlValueConverter valueConverter;

		// Token: 0x04000474 RID: 1140
		[Token(Token = "0x4000474")]
		[FieldOffset(Offset = "0x30")]
		private XmlSchemaType parentSchemaType;

		// Token: 0x04000475 RID: 1141
		[Token(Token = "0x4000475")]
		[FieldOffset(Offset = "0x0")]
		private static Hashtable builtinTypes;

		// Token: 0x04000476 RID: 1142
		[Token(Token = "0x4000476")]
		[FieldOffset(Offset = "0x8")]
		private static XmlSchemaSimpleType[] enumToTypeCode;

		// Token: 0x04000477 RID: 1143
		[Token(Token = "0x4000477")]
		[FieldOffset(Offset = "0x10")]
		private static XmlSchemaSimpleType anySimpleType;

		// Token: 0x04000478 RID: 1144
		[Token(Token = "0x4000478")]
		[FieldOffset(Offset = "0x18")]
		private static XmlSchemaSimpleType anyAtomicType;

		// Token: 0x04000479 RID: 1145
		[Token(Token = "0x4000479")]
		[FieldOffset(Offset = "0x20")]
		private static XmlSchemaSimpleType untypedAtomicType;

		// Token: 0x0400047A RID: 1146
		[Token(Token = "0x400047A")]
		[FieldOffset(Offset = "0x28")]
		private static XmlSchemaSimpleType yearMonthDurationType;

		// Token: 0x0400047B RID: 1147
		[Token(Token = "0x400047B")]
		[FieldOffset(Offset = "0x30")]
		private static XmlSchemaSimpleType dayTimeDurationType;

		// Token: 0x0400047C RID: 1148
		[Token(Token = "0x400047C")]
		[FieldOffset(Offset = "0x38")]
		internal static XmlQualifiedName QnAnySimpleType;

		// Token: 0x0400047D RID: 1149
		[Token(Token = "0x400047D")]
		[FieldOffset(Offset = "0x40")]
		internal static XmlQualifiedName QnAnyType;

		// Token: 0x0400047E RID: 1150
		[Token(Token = "0x400047E")]
		[FieldOffset(Offset = "0x48")]
		internal static FacetsChecker stringFacetsChecker;

		// Token: 0x0400047F RID: 1151
		[Token(Token = "0x400047F")]
		[FieldOffset(Offset = "0x50")]
		internal static FacetsChecker miscFacetsChecker;

		// Token: 0x04000480 RID: 1152
		[Token(Token = "0x4000480")]
		[FieldOffset(Offset = "0x58")]
		internal static FacetsChecker numeric2FacetsChecker;

		// Token: 0x04000481 RID: 1153
		[Token(Token = "0x4000481")]
		[FieldOffset(Offset = "0x60")]
		internal static FacetsChecker binaryFacetsChecker;

		// Token: 0x04000482 RID: 1154
		[Token(Token = "0x4000482")]
		[FieldOffset(Offset = "0x68")]
		internal static FacetsChecker dateTimeFacetsChecker;

		// Token: 0x04000483 RID: 1155
		[Token(Token = "0x4000483")]
		[FieldOffset(Offset = "0x70")]
		internal static FacetsChecker durationFacetsChecker;

		// Token: 0x04000484 RID: 1156
		[Token(Token = "0x4000484")]
		[FieldOffset(Offset = "0x78")]
		internal static FacetsChecker listFacetsChecker;

		// Token: 0x04000485 RID: 1157
		[Token(Token = "0x4000485")]
		[FieldOffset(Offset = "0x80")]
		internal static FacetsChecker qnameFacetsChecker;

		// Token: 0x04000486 RID: 1158
		[Token(Token = "0x4000486")]
		[FieldOffset(Offset = "0x88")]
		internal static FacetsChecker unionFacetsChecker;

		// Token: 0x04000487 RID: 1159
		[Token(Token = "0x4000487")]
		[FieldOffset(Offset = "0x90")]
		private static readonly DatatypeImplementation c_anySimpleType;

		// Token: 0x04000488 RID: 1160
		[Token(Token = "0x4000488")]
		[FieldOffset(Offset = "0x98")]
		private static readonly DatatypeImplementation c_anyURI;

		// Token: 0x04000489 RID: 1161
		[Token(Token = "0x4000489")]
		[FieldOffset(Offset = "0xA0")]
		private static readonly DatatypeImplementation c_base64Binary;

		// Token: 0x0400048A RID: 1162
		[Token(Token = "0x400048A")]
		[FieldOffset(Offset = "0xA8")]
		private static readonly DatatypeImplementation c_boolean;

		// Token: 0x0400048B RID: 1163
		[Token(Token = "0x400048B")]
		[FieldOffset(Offset = "0xB0")]
		private static readonly DatatypeImplementation c_byte;

		// Token: 0x0400048C RID: 1164
		[Token(Token = "0x400048C")]
		[FieldOffset(Offset = "0xB8")]
		private static readonly DatatypeImplementation c_char;

		// Token: 0x0400048D RID: 1165
		[Token(Token = "0x400048D")]
		[FieldOffset(Offset = "0xC0")]
		private static readonly DatatypeImplementation c_date;

		// Token: 0x0400048E RID: 1166
		[Token(Token = "0x400048E")]
		[FieldOffset(Offset = "0xC8")]
		private static readonly DatatypeImplementation c_dateTime;

		// Token: 0x0400048F RID: 1167
		[Token(Token = "0x400048F")]
		[FieldOffset(Offset = "0xD0")]
		private static readonly DatatypeImplementation c_dateTimeNoTz;

		// Token: 0x04000490 RID: 1168
		[Token(Token = "0x4000490")]
		[FieldOffset(Offset = "0xD8")]
		private static readonly DatatypeImplementation c_dateTimeTz;

		// Token: 0x04000491 RID: 1169
		[Token(Token = "0x4000491")]
		[FieldOffset(Offset = "0xE0")]
		private static readonly DatatypeImplementation c_day;

		// Token: 0x04000492 RID: 1170
		[Token(Token = "0x4000492")]
		[FieldOffset(Offset = "0xE8")]
		private static readonly DatatypeImplementation c_decimal;

		// Token: 0x04000493 RID: 1171
		[Token(Token = "0x4000493")]
		[FieldOffset(Offset = "0xF0")]
		private static readonly DatatypeImplementation c_double;

		// Token: 0x04000494 RID: 1172
		[Token(Token = "0x4000494")]
		[FieldOffset(Offset = "0xF8")]
		private static readonly DatatypeImplementation c_doubleXdr;

		// Token: 0x04000495 RID: 1173
		[Token(Token = "0x4000495")]
		[FieldOffset(Offset = "0x100")]
		private static readonly DatatypeImplementation c_duration;

		// Token: 0x04000496 RID: 1174
		[Token(Token = "0x4000496")]
		[FieldOffset(Offset = "0x108")]
		private static readonly DatatypeImplementation c_ENTITY;

		// Token: 0x04000497 RID: 1175
		[Token(Token = "0x4000497")]
		[FieldOffset(Offset = "0x110")]
		private static readonly DatatypeImplementation c_ENTITIES;

		// Token: 0x04000498 RID: 1176
		[Token(Token = "0x4000498")]
		[FieldOffset(Offset = "0x118")]
		private static readonly DatatypeImplementation c_ENUMERATION;

		// Token: 0x04000499 RID: 1177
		[Token(Token = "0x4000499")]
		[FieldOffset(Offset = "0x120")]
		private static readonly DatatypeImplementation c_fixed;

		// Token: 0x0400049A RID: 1178
		[Token(Token = "0x400049A")]
		[FieldOffset(Offset = "0x128")]
		private static readonly DatatypeImplementation c_float;

		// Token: 0x0400049B RID: 1179
		[Token(Token = "0x400049B")]
		[FieldOffset(Offset = "0x130")]
		private static readonly DatatypeImplementation c_floatXdr;

		// Token: 0x0400049C RID: 1180
		[Token(Token = "0x400049C")]
		[FieldOffset(Offset = "0x138")]
		private static readonly DatatypeImplementation c_hexBinary;

		// Token: 0x0400049D RID: 1181
		[Token(Token = "0x400049D")]
		[FieldOffset(Offset = "0x140")]
		private static readonly DatatypeImplementation c_ID;

		// Token: 0x0400049E RID: 1182
		[Token(Token = "0x400049E")]
		[FieldOffset(Offset = "0x148")]
		private static readonly DatatypeImplementation c_IDREF;

		// Token: 0x0400049F RID: 1183
		[Token(Token = "0x400049F")]
		[FieldOffset(Offset = "0x150")]
		private static readonly DatatypeImplementation c_IDREFS;

		// Token: 0x040004A0 RID: 1184
		[Token(Token = "0x40004A0")]
		[FieldOffset(Offset = "0x158")]
		private static readonly DatatypeImplementation c_int;

		// Token: 0x040004A1 RID: 1185
		[Token(Token = "0x40004A1")]
		[FieldOffset(Offset = "0x160")]
		private static readonly DatatypeImplementation c_integer;

		// Token: 0x040004A2 RID: 1186
		[Token(Token = "0x40004A2")]
		[FieldOffset(Offset = "0x168")]
		private static readonly DatatypeImplementation c_language;

		// Token: 0x040004A3 RID: 1187
		[Token(Token = "0x40004A3")]
		[FieldOffset(Offset = "0x170")]
		private static readonly DatatypeImplementation c_long;

		// Token: 0x040004A4 RID: 1188
		[Token(Token = "0x40004A4")]
		[FieldOffset(Offset = "0x178")]
		private static readonly DatatypeImplementation c_month;

		// Token: 0x040004A5 RID: 1189
		[Token(Token = "0x40004A5")]
		[FieldOffset(Offset = "0x180")]
		private static readonly DatatypeImplementation c_monthDay;

		// Token: 0x040004A6 RID: 1190
		[Token(Token = "0x40004A6")]
		[FieldOffset(Offset = "0x188")]
		private static readonly DatatypeImplementation c_Name;

		// Token: 0x040004A7 RID: 1191
		[Token(Token = "0x40004A7")]
		[FieldOffset(Offset = "0x190")]
		private static readonly DatatypeImplementation c_NCName;

		// Token: 0x040004A8 RID: 1192
		[Token(Token = "0x40004A8")]
		[FieldOffset(Offset = "0x198")]
		private static readonly DatatypeImplementation c_negativeInteger;

		// Token: 0x040004A9 RID: 1193
		[Token(Token = "0x40004A9")]
		[FieldOffset(Offset = "0x1A0")]
		private static readonly DatatypeImplementation c_NMTOKEN;

		// Token: 0x040004AA RID: 1194
		[Token(Token = "0x40004AA")]
		[FieldOffset(Offset = "0x1A8")]
		private static readonly DatatypeImplementation c_NMTOKENS;

		// Token: 0x040004AB RID: 1195
		[Token(Token = "0x40004AB")]
		[FieldOffset(Offset = "0x1B0")]
		private static readonly DatatypeImplementation c_nonNegativeInteger;

		// Token: 0x040004AC RID: 1196
		[Token(Token = "0x40004AC")]
		[FieldOffset(Offset = "0x1B8")]
		private static readonly DatatypeImplementation c_nonPositiveInteger;

		// Token: 0x040004AD RID: 1197
		[Token(Token = "0x40004AD")]
		[FieldOffset(Offset = "0x1C0")]
		private static readonly DatatypeImplementation c_normalizedString;

		// Token: 0x040004AE RID: 1198
		[Token(Token = "0x40004AE")]
		[FieldOffset(Offset = "0x1C8")]
		private static readonly DatatypeImplementation c_NOTATION;

		// Token: 0x040004AF RID: 1199
		[Token(Token = "0x40004AF")]
		[FieldOffset(Offset = "0x1D0")]
		private static readonly DatatypeImplementation c_positiveInteger;

		// Token: 0x040004B0 RID: 1200
		[Token(Token = "0x40004B0")]
		[FieldOffset(Offset = "0x1D8")]
		private static readonly DatatypeImplementation c_QName;

		// Token: 0x040004B1 RID: 1201
		[Token(Token = "0x40004B1")]
		[FieldOffset(Offset = "0x1E0")]
		private static readonly DatatypeImplementation c_QNameXdr;

		// Token: 0x040004B2 RID: 1202
		[Token(Token = "0x40004B2")]
		[FieldOffset(Offset = "0x1E8")]
		private static readonly DatatypeImplementation c_short;

		// Token: 0x040004B3 RID: 1203
		[Token(Token = "0x40004B3")]
		[FieldOffset(Offset = "0x1F0")]
		private static readonly DatatypeImplementation c_string;

		// Token: 0x040004B4 RID: 1204
		[Token(Token = "0x40004B4")]
		[FieldOffset(Offset = "0x1F8")]
		private static readonly DatatypeImplementation c_time;

		// Token: 0x040004B5 RID: 1205
		[Token(Token = "0x40004B5")]
		[FieldOffset(Offset = "0x200")]
		private static readonly DatatypeImplementation c_timeNoTz;

		// Token: 0x040004B6 RID: 1206
		[Token(Token = "0x40004B6")]
		[FieldOffset(Offset = "0x208")]
		private static readonly DatatypeImplementation c_timeTz;

		// Token: 0x040004B7 RID: 1207
		[Token(Token = "0x40004B7")]
		[FieldOffset(Offset = "0x210")]
		private static readonly DatatypeImplementation c_token;

		// Token: 0x040004B8 RID: 1208
		[Token(Token = "0x40004B8")]
		[FieldOffset(Offset = "0x218")]
		private static readonly DatatypeImplementation c_unsignedByte;

		// Token: 0x040004B9 RID: 1209
		[Token(Token = "0x40004B9")]
		[FieldOffset(Offset = "0x220")]
		private static readonly DatatypeImplementation c_unsignedInt;

		// Token: 0x040004BA RID: 1210
		[Token(Token = "0x40004BA")]
		[FieldOffset(Offset = "0x228")]
		private static readonly DatatypeImplementation c_unsignedLong;

		// Token: 0x040004BB RID: 1211
		[Token(Token = "0x40004BB")]
		[FieldOffset(Offset = "0x230")]
		private static readonly DatatypeImplementation c_unsignedShort;

		// Token: 0x040004BC RID: 1212
		[Token(Token = "0x40004BC")]
		[FieldOffset(Offset = "0x238")]
		private static readonly DatatypeImplementation c_uuid;

		// Token: 0x040004BD RID: 1213
		[Token(Token = "0x40004BD")]
		[FieldOffset(Offset = "0x240")]
		private static readonly DatatypeImplementation c_year;

		// Token: 0x040004BE RID: 1214
		[Token(Token = "0x40004BE")]
		[FieldOffset(Offset = "0x248")]
		private static readonly DatatypeImplementation c_yearMonth;

		// Token: 0x040004BF RID: 1215
		[Token(Token = "0x40004BF")]
		[FieldOffset(Offset = "0x250")]
		internal static readonly DatatypeImplementation c_normalizedStringV1Compat;

		// Token: 0x040004C0 RID: 1216
		[Token(Token = "0x40004C0")]
		[FieldOffset(Offset = "0x258")]
		internal static readonly DatatypeImplementation c_tokenV1Compat;

		// Token: 0x040004C1 RID: 1217
		[Token(Token = "0x40004C1")]
		[FieldOffset(Offset = "0x260")]
		private static readonly DatatypeImplementation c_anyAtomicType;

		// Token: 0x040004C2 RID: 1218
		[Token(Token = "0x40004C2")]
		[FieldOffset(Offset = "0x268")]
		private static readonly DatatypeImplementation c_dayTimeDuration;

		// Token: 0x040004C3 RID: 1219
		[Token(Token = "0x40004C3")]
		[FieldOffset(Offset = "0x270")]
		private static readonly DatatypeImplementation c_untypedAtomicType;

		// Token: 0x040004C4 RID: 1220
		[Token(Token = "0x40004C4")]
		[FieldOffset(Offset = "0x278")]
		private static readonly DatatypeImplementation c_yearMonthDuration;

		// Token: 0x040004C5 RID: 1221
		[Token(Token = "0x40004C5")]
		[FieldOffset(Offset = "0x280")]
		private static readonly DatatypeImplementation[] c_tokenizedTypes;

		// Token: 0x040004C6 RID: 1222
		[Token(Token = "0x40004C6")]
		[FieldOffset(Offset = "0x288")]
		private static readonly DatatypeImplementation[] c_tokenizedTypesXsd;

		// Token: 0x040004C7 RID: 1223
		[Token(Token = "0x40004C7")]
		[FieldOffset(Offset = "0x290")]
		private static readonly DatatypeImplementation.SchemaDatatypeMap[] c_XdrTypes;

		// Token: 0x040004C8 RID: 1224
		[Token(Token = "0x40004C8")]
		[FieldOffset(Offset = "0x298")]
		private static readonly DatatypeImplementation.SchemaDatatypeMap[] c_XsdTypes;

		// Token: 0x020000DE RID: 222
		[Token(Token = "0x20000DE")]
		private class SchemaDatatypeMap : IComparable
		{
			// Token: 0x06000888 RID: 2184 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000888")]
			[Address(RVA = "0x4ECFE0", Offset = "0x4EBBE0", VA = "0x1804ECFE0")]
			internal SchemaDatatypeMap(string name, DatatypeImplementation type)
			{
			}

			// Token: 0x06000889 RID: 2185 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000889")]
			[Address(RVA = "0x4BD7FE0", Offset = "0x4BD6BE0", VA = "0x184BD7FE0")]
			internal SchemaDatatypeMap(string name, DatatypeImplementation type, int parentIndex)
			{
			}

			// Token: 0x0600088A RID: 2186 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600088A")]
			[Address(RVA = "0x3BEA040", Offset = "0x3BE8C40", VA = "0x183BEA040")]
			public static explicit operator DatatypeImplementation(DatatypeImplementation.SchemaDatatypeMap sdm)
			{
				return null;
			}

			// Token: 0x17000215 RID: 533
			// (get) Token: 0x0600088B RID: 2187 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000215")]
			public string Name
			{
				[Token(Token = "0x600088B")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000216 RID: 534
			// (get) Token: 0x0600088C RID: 2188 RVA: 0x00004A28 File Offset: 0x00002C28
			[Token(Token = "0x17000216")]
			public int ParentIndex
			{
				[Token(Token = "0x600088C")]
				[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0600088D RID: 2189 RVA: 0x00004A40 File Offset: 0x00002C40
			[Token(Token = "0x600088D")]
			[Address(RVA = "0x4FE6080", Offset = "0x4FE4C80", VA = "0x184FE6080", Slot = "4")]
			public int CompareTo(object obj)
			{
				return 0;
			}

			// Token: 0x040004C9 RID: 1225
			[Token(Token = "0x40004C9")]
			[FieldOffset(Offset = "0x10")]
			private string name;

			// Token: 0x040004CA RID: 1226
			[Token(Token = "0x40004CA")]
			[FieldOffset(Offset = "0x18")]
			private DatatypeImplementation type;

			// Token: 0x040004CB RID: 1227
			[Token(Token = "0x40004CB")]
			[FieldOffset(Offset = "0x20")]
			private int parentIndex;
		}
	}
}
