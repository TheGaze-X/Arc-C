using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x02000112 RID: 274
	[Token(Token = "0x2000112")]
	internal class Datatype_unsignedInt : Datatype_unsignedLong
	{
		// Token: 0x17000298 RID: 664
		// (get) Token: 0x0600098E RID: 2446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000298")]
		internal override FacetsChecker FacetsChecker
		{
			[Token(Token = "0x600098E")]
			[Address(RVA = "0x50023E0", Offset = "0x5000FE0", VA = "0x1850023E0", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x0600098F RID: 2447 RVA: 0x00005298 File Offset: 0x00003498
		[Token(Token = "0x17000299")]
		public override XmlTypeCode TypeCode
		{
			[Token(Token = "0x600098F")]
			[Address(RVA = "0x5002480", Offset = "0x5001080", VA = "0x185002480", Slot = "8")]
			get
			{
				return XmlTypeCode.None;
			}
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x000052B0 File Offset: 0x000034B0
		[Token(Token = "0x6000990")]
		[Address(RVA = "0x5001F80", Offset = "0x5000B80", VA = "0x185001F80", Slot = "11")]
		internal override int Compare(object value1, object value2)
		{
			return 0;
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000991 RID: 2449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700029A")]
		public override Type ValueType
		{
			[Token(Token = "0x6000991")]
			[Address(RVA = "0x5002490", Offset = "0x5001090", VA = "0x185002490", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000992 RID: 2450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700029B")]
		internal override Type ListValueType
		{
			[Token(Token = "0x6000992")]
			[Address(RVA = "0x5002430", Offset = "0x5001030", VA = "0x185002430", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000993")]
		[Address(RVA = "0x5002000", Offset = "0x5000C00", VA = "0x185002000", Slot = "12")]
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			return null;
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000994")]
		[Address(RVA = "0x5002330", Offset = "0x5000F30", VA = "0x185002330")]
		public Datatype_unsignedInt()
		{
		}

		// Token: 0x040004FD RID: 1277
		[Token(Token = "0x40004FD")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Type atomicValueType;

		// Token: 0x040004FE RID: 1278
		[Token(Token = "0x40004FE")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Type listValueType;

		// Token: 0x040004FF RID: 1279
		[Token(Token = "0x40004FF")]
		[FieldOffset(Offset = "0x10")]
		private static readonly FacetsChecker numeric10FacetsChecker;
	}
}
