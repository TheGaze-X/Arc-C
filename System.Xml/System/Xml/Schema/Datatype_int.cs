using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x0200010D RID: 269
	[Token(Token = "0x200010D")]
	internal class Datatype_int : Datatype_long
	{
		// Token: 0x17000286 RID: 646
		// (get) Token: 0x0600096A RID: 2410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000286")]
		internal override FacetsChecker FacetsChecker
		{
			[Token(Token = "0x600096A")]
			[Address(RVA = "0x5000060", Offset = "0x4FFEC60", VA = "0x185000060", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x0600096B RID: 2411 RVA: 0x000051C0 File Offset: 0x000033C0
		[Token(Token = "0x17000287")]
		public override XmlTypeCode TypeCode
		{
			[Token(Token = "0x600096B")]
			[Address(RVA = "0x5000100", Offset = "0x4FFED00", VA = "0x185000100", Slot = "8")]
			get
			{
				return XmlTypeCode.None;
			}
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x000051D8 File Offset: 0x000033D8
		[Token(Token = "0x600096C")]
		[Address(RVA = "0x4FFFC40", Offset = "0x4FFE840", VA = "0x184FFFC40", Slot = "11")]
		internal override int Compare(object value1, object value2)
		{
			return 0;
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x0600096D RID: 2413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000288")]
		public override Type ValueType
		{
			[Token(Token = "0x600096D")]
			[Address(RVA = "0x5000110", Offset = "0x4FFED10", VA = "0x185000110", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x0600096E RID: 2414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000289")]
		internal override Type ListValueType
		{
			[Token(Token = "0x600096E")]
			[Address(RVA = "0x50000B0", Offset = "0x4FFECB0", VA = "0x1850000B0", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600096F")]
		[Address(RVA = "0x4FFFCC0", Offset = "0x4FFE8C0", VA = "0x184FFFCC0", Slot = "12")]
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			return null;
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000970")]
		[Address(RVA = "0x4FFFFE0", Offset = "0x4FFEBE0", VA = "0x184FFFFE0")]
		public Datatype_int()
		{
		}

		// Token: 0x040004F0 RID: 1264
		[Token(Token = "0x40004F0")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Type atomicValueType;

		// Token: 0x040004F1 RID: 1265
		[Token(Token = "0x40004F1")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Type listValueType;

		// Token: 0x040004F2 RID: 1266
		[Token(Token = "0x40004F2")]
		[FieldOffset(Offset = "0x10")]
		private static readonly FacetsChecker numeric10FacetsChecker;
	}
}
