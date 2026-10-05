using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x0200010C RID: 268
	[Token(Token = "0x200010C")]
	internal class Datatype_long : Datatype_integer
	{
		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000962 RID: 2402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000282")]
		internal override FacetsChecker FacetsChecker
		{
			[Token(Token = "0x6000962")]
			[Address(RVA = "0x5000740", Offset = "0x4FFF340", VA = "0x185000740", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000963 RID: 2403 RVA: 0x00005190 File Offset: 0x00003390
		[Token(Token = "0x17000283")]
		public override XmlTypeCode TypeCode
		{
			[Token(Token = "0x6000963")]
			[Address(RVA = "0x50007E0", Offset = "0x4FFF3E0", VA = "0x1850007E0", Slot = "8")]
			get
			{
				return XmlTypeCode.None;
			}
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x000051A8 File Offset: 0x000033A8
		[Token(Token = "0x6000964")]
		[Address(RVA = "0x5000390", Offset = "0x4FFEF90", VA = "0x185000390", Slot = "11")]
		internal override int Compare(object value1, object value2)
		{
			return 0;
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000965 RID: 2405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000284")]
		public override Type ValueType
		{
			[Token(Token = "0x6000965")]
			[Address(RVA = "0x50007F0", Offset = "0x4FFF3F0", VA = "0x1850007F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000966 RID: 2406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000285")]
		internal override Type ListValueType
		{
			[Token(Token = "0x6000966")]
			[Address(RVA = "0x5000790", Offset = "0x4FFF390", VA = "0x185000790", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000967")]
		[Address(RVA = "0x5000410", Offset = "0x4FFF010", VA = "0x185000410", Slot = "12")]
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			return null;
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000968")]
		[Address(RVA = "0x5000320", Offset = "0x4FFEF20", VA = "0x185000320")]
		public Datatype_long()
		{
		}

		// Token: 0x040004ED RID: 1261
		[Token(Token = "0x40004ED")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Type atomicValueType;

		// Token: 0x040004EE RID: 1262
		[Token(Token = "0x40004EE")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Type listValueType;

		// Token: 0x040004EF RID: 1263
		[Token(Token = "0x40004EF")]
		[FieldOffset(Offset = "0x10")]
		private static readonly FacetsChecker numeric10FacetsChecker;
	}
}
