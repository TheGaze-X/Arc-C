using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x0200010E RID: 270
	[Token(Token = "0x200010E")]
	internal class Datatype_short : Datatype_int
	{
		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000972 RID: 2418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700028A")]
		internal override FacetsChecker FacetsChecker
		{
			[Token(Token = "0x6000972")]
			[Address(RVA = "0x50013F0", Offset = "0x4FFFFF0", VA = "0x1850013F0", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000973 RID: 2419 RVA: 0x000051F0 File Offset: 0x000033F0
		[Token(Token = "0x1700028B")]
		public override XmlTypeCode TypeCode
		{
			[Token(Token = "0x6000973")]
			[Address(RVA = "0x5001490", Offset = "0x5000090", VA = "0x185001490", Slot = "8")]
			get
			{
				return XmlTypeCode.None;
			}
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x00005208 File Offset: 0x00003408
		[Token(Token = "0x6000974")]
		[Address(RVA = "0x5000FA0", Offset = "0x4FFFBA0", VA = "0x185000FA0", Slot = "11")]
		internal override int Compare(object value1, object value2)
		{
			return 0;
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000975 RID: 2421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700028C")]
		public override Type ValueType
		{
			[Token(Token = "0x6000975")]
			[Address(RVA = "0x50014A0", Offset = "0x50000A0", VA = "0x1850014A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000976 RID: 2422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700028D")]
		internal override Type ListValueType
		{
			[Token(Token = "0x6000976")]
			[Address(RVA = "0x5001440", Offset = "0x5000040", VA = "0x185001440", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000977")]
		[Address(RVA = "0x5001020", Offset = "0x4FFFC20", VA = "0x185001020", Slot = "12")]
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			return null;
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000978")]
		[Address(RVA = "0x5001340", Offset = "0x4FFFF40", VA = "0x185001340")]
		public Datatype_short()
		{
		}

		// Token: 0x040004F3 RID: 1267
		[Token(Token = "0x40004F3")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Type atomicValueType;

		// Token: 0x040004F4 RID: 1268
		[Token(Token = "0x40004F4")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Type listValueType;

		// Token: 0x040004F5 RID: 1269
		[Token(Token = "0x40004F5")]
		[FieldOffset(Offset = "0x10")]
		private static readonly FacetsChecker numeric10FacetsChecker;
	}
}
