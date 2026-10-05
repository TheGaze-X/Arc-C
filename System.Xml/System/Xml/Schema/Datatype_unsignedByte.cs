using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x02000114 RID: 276
	[Token(Token = "0x2000114")]
	internal class Datatype_unsignedByte : Datatype_unsignedShort
	{
		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x0600099E RID: 2462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002A0")]
		internal override FacetsChecker FacetsChecker
		{
			[Token(Token = "0x600099E")]
			[Address(RVA = "0x5001E80", Offset = "0x5000A80", VA = "0x185001E80", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x0600099F RID: 2463 RVA: 0x000052F8 File Offset: 0x000034F8
		[Token(Token = "0x170002A1")]
		public override XmlTypeCode TypeCode
		{
			[Token(Token = "0x600099F")]
			[Address(RVA = "0x5001F20", Offset = "0x5000B20", VA = "0x185001F20", Slot = "8")]
			get
			{
				return XmlTypeCode.None;
			}
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x00005310 File Offset: 0x00003510
		[Token(Token = "0x60009A0")]
		[Address(RVA = "0x50019C0", Offset = "0x50005C0", VA = "0x1850019C0", Slot = "11")]
		internal override int Compare(object value1, object value2)
		{
			return 0;
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x060009A1 RID: 2465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002A2")]
		public override Type ValueType
		{
			[Token(Token = "0x60009A1")]
			[Address(RVA = "0x5001F30", Offset = "0x5000B30", VA = "0x185001F30", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x060009A2 RID: 2466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002A3")]
		internal override Type ListValueType
		{
			[Token(Token = "0x60009A2")]
			[Address(RVA = "0x5001ED0", Offset = "0x5000AD0", VA = "0x185001ED0", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009A3")]
		[Address(RVA = "0x5001A40", Offset = "0x5000640", VA = "0x185001A40", Slot = "12")]
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			return null;
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009A4")]
		[Address(RVA = "0x5001D70", Offset = "0x5000970", VA = "0x185001D70")]
		public Datatype_unsignedByte()
		{
		}

		// Token: 0x04000503 RID: 1283
		[Token(Token = "0x4000503")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Type atomicValueType;

		// Token: 0x04000504 RID: 1284
		[Token(Token = "0x4000504")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Type listValueType;

		// Token: 0x04000505 RID: 1285
		[Token(Token = "0x4000505")]
		[FieldOffset(Offset = "0x10")]
		private static readonly FacetsChecker numeric10FacetsChecker;
	}
}
