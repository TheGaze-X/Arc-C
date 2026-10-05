using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x02000113 RID: 275
	[Token(Token = "0x2000113")]
	internal class Datatype_unsignedShort : Datatype_unsignedInt
	{
		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000996 RID: 2454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700029C")]
		internal override FacetsChecker FacetsChecker
		{
			[Token(Token = "0x6000996")]
			[Address(RVA = "0x5002F10", Offset = "0x5001B10", VA = "0x185002F10", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000997 RID: 2455 RVA: 0x000052C8 File Offset: 0x000034C8
		[Token(Token = "0x1700029D")]
		public override XmlTypeCode TypeCode
		{
			[Token(Token = "0x6000997")]
			[Address(RVA = "0x5002FB0", Offset = "0x5001BB0", VA = "0x185002FB0", Slot = "8")]
			get
			{
				return XmlTypeCode.None;
			}
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x000052E0 File Offset: 0x000034E0
		[Token(Token = "0x6000998")]
		[Address(RVA = "0x5002A80", Offset = "0x5001680", VA = "0x185002A80", Slot = "11")]
		internal override int Compare(object value1, object value2)
		{
			return 0;
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000999 RID: 2457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700029E")]
		public override Type ValueType
		{
			[Token(Token = "0x6000999")]
			[Address(RVA = "0x5002FC0", Offset = "0x5001BC0", VA = "0x185002FC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x0600099A RID: 2458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700029F")]
		internal override Type ListValueType
		{
			[Token(Token = "0x600099A")]
			[Address(RVA = "0x5002F60", Offset = "0x5001B60", VA = "0x185002F60", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600099B")]
		[Address(RVA = "0x5002B00", Offset = "0x5001700", VA = "0x185002B00", Slot = "12")]
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			return null;
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600099C")]
		[Address(RVA = "0x5002E30", Offset = "0x5001A30", VA = "0x185002E30")]
		public Datatype_unsignedShort()
		{
		}

		// Token: 0x04000500 RID: 1280
		[Token(Token = "0x4000500")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Type atomicValueType;

		// Token: 0x04000501 RID: 1281
		[Token(Token = "0x4000501")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Type listValueType;

		// Token: 0x04000502 RID: 1282
		[Token(Token = "0x4000502")]
		[FieldOffset(Offset = "0x10")]
		private static readonly FacetsChecker numeric10FacetsChecker;
	}
}
