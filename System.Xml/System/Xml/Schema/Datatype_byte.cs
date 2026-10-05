using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x0200010F RID: 271
	[Token(Token = "0x200010F")]
	internal class Datatype_byte : Datatype_short
	{
		// Token: 0x1700028E RID: 654
		// (get) Token: 0x0600097A RID: 2426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700028E")]
		internal override FacetsChecker FacetsChecker
		{
			[Token(Token = "0x600097A")]
			[Address(RVA = "0x4FFC6B0", Offset = "0x4FFB2B0", VA = "0x184FFC6B0", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x0600097B RID: 2427 RVA: 0x00005220 File Offset: 0x00003420
		[Token(Token = "0x1700028F")]
		public override XmlTypeCode TypeCode
		{
			[Token(Token = "0x600097B")]
			[Address(RVA = "0x4F21C40", Offset = "0x4F20840", VA = "0x184F21C40", Slot = "8")]
			get
			{
				return XmlTypeCode.None;
			}
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x00005238 File Offset: 0x00003438
		[Token(Token = "0x600097C")]
		[Address(RVA = "0x4FFC230", Offset = "0x4FFAE30", VA = "0x184FFC230", Slot = "11")]
		internal override int Compare(object value1, object value2)
		{
			return 0;
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x0600097D RID: 2429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000290")]
		public override Type ValueType
		{
			[Token(Token = "0x600097D")]
			[Address(RVA = "0x4FFC750", Offset = "0x4FFB350", VA = "0x184FFC750", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x0600097E RID: 2430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000291")]
		internal override Type ListValueType
		{
			[Token(Token = "0x600097E")]
			[Address(RVA = "0x4FFC700", Offset = "0x4FFB300", VA = "0x184FFC700", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600097F")]
		[Address(RVA = "0x4FFC2B0", Offset = "0x4FFAEB0", VA = "0x184FFC2B0", Slot = "12")]
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			return null;
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000980")]
		[Address(RVA = "0x4FFC5D0", Offset = "0x4FFB1D0", VA = "0x184FFC5D0")]
		public Datatype_byte()
		{
		}

		// Token: 0x040004F6 RID: 1270
		[Token(Token = "0x40004F6")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Type atomicValueType;

		// Token: 0x040004F7 RID: 1271
		[Token(Token = "0x40004F7")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Type listValueType;

		// Token: 0x040004F8 RID: 1272
		[Token(Token = "0x40004F8")]
		[FieldOffset(Offset = "0x10")]
		private static readonly FacetsChecker numeric10FacetsChecker;
	}
}
