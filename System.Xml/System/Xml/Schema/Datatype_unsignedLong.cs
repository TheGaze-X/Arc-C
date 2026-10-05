using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x02000111 RID: 273
	[Token(Token = "0x2000111")]
	internal class Datatype_unsignedLong : Datatype_nonNegativeInteger
	{
		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000986 RID: 2438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000294")]
		internal override FacetsChecker FacetsChecker
		{
			[Token(Token = "0x6000986")]
			[Address(RVA = "0x5002990", Offset = "0x5001590", VA = "0x185002990", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000987 RID: 2439 RVA: 0x00005268 File Offset: 0x00003468
		[Token(Token = "0x17000295")]
		public override XmlTypeCode TypeCode
		{
			[Token(Token = "0x6000987")]
			[Address(RVA = "0x3D287C0", Offset = "0x3D273C0", VA = "0x183D287C0", Slot = "8")]
			get
			{
				return XmlTypeCode.None;
			}
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x00005280 File Offset: 0x00003480
		[Token(Token = "0x6000988")]
		[Address(RVA = "0x50024E0", Offset = "0x50010E0", VA = "0x1850024E0", Slot = "11")]
		internal override int Compare(object value1, object value2)
		{
			return 0;
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000989 RID: 2441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000296")]
		public override Type ValueType
		{
			[Token(Token = "0x6000989")]
			[Address(RVA = "0x5002A30", Offset = "0x5001630", VA = "0x185002A30", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x0600098A RID: 2442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000297")]
		internal override Type ListValueType
		{
			[Token(Token = "0x600098A")]
			[Address(RVA = "0x50029E0", Offset = "0x50015E0", VA = "0x1850029E0", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600098B")]
		[Address(RVA = "0x5002560", Offset = "0x5001160", VA = "0x185002560", Slot = "12")]
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			return null;
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600098C")]
		[Address(RVA = "0x5002910", Offset = "0x5001510", VA = "0x185002910")]
		public Datatype_unsignedLong()
		{
		}

		// Token: 0x040004FA RID: 1274
		[Token(Token = "0x40004FA")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Type atomicValueType;

		// Token: 0x040004FB RID: 1275
		[Token(Token = "0x40004FB")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Type listValueType;

		// Token: 0x040004FC RID: 1276
		[Token(Token = "0x40004FC")]
		[FieldOffset(Offset = "0x10")]
		private static readonly FacetsChecker numeric10FacetsChecker;
	}
}
