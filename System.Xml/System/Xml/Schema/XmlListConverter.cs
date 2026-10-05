using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x02000167 RID: 359
	[Token(Token = "0x2000167")]
	internal class XmlListConverter : XmlBaseConverter
	{
		// Token: 0x06000C5E RID: 3166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C5E")]
		[Address(RVA = "0x5029140", Offset = "0x5027D40", VA = "0x185029140")]
		protected XmlListConverter(XmlBaseConverter atomicConverter)
		{
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C5F")]
		[Address(RVA = "0x502B320", Offset = "0x5029F20", VA = "0x18502B320")]
		protected XmlListConverter(XmlBaseConverter atomicConverter, Type clrTypeDefault)
		{
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C60")]
		[Address(RVA = "0x502B3A0", Offset = "0x5029FA0", VA = "0x18502B3A0")]
		protected XmlListConverter(XmlSchemaType schemaType)
		{
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C61")]
		[Address(RVA = "0x502A6C0", Offset = "0x50292C0", VA = "0x18502A6C0")]
		public static XmlValueConverter Create(XmlValueConverter atomicConverter)
		{
			return null;
		}

		// Token: 0x06000C62 RID: 3170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C62")]
		[Address(RVA = "0x502A240", Offset = "0x5028E40", VA = "0x18502A240", Slot = "61")]
		public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			return null;
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C63")]
		[Address(RVA = "0x50291B0", Offset = "0x5027DB0", VA = "0x1850291B0", Slot = "62")]
		protected override object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			return null;
		}

		// Token: 0x06000C64 RID: 3172 RVA: 0x000064F8 File Offset: 0x000046F8
		[Token(Token = "0x6000C64")]
		[Address(RVA = "0x502A870", Offset = "0x5029470", VA = "0x18502A870")]
		private bool IsListType(Type type)
		{
			return default(bool);
		}

		// Token: 0x06000C65 RID: 3173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C65")]
		private T[] ToArray<T>(object list, IXmlNamespaceResolver nsResolver)
		{
			return null;
		}

		// Token: 0x06000C66 RID: 3174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C66")]
		[Address(RVA = "0x502AD90", Offset = "0x5029990", VA = "0x18502AD90")]
		private IList ToList(object list, IXmlNamespaceResolver nsResolver)
		{
			return null;
		}

		// Token: 0x06000C67 RID: 3175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C67")]
		[Address(RVA = "0x502ACF0", Offset = "0x50298F0", VA = "0x18502ACF0")]
		private List<string> StringAsList(string value)
		{
			return null;
		}

		// Token: 0x06000C68 RID: 3176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C68")]
		[Address(RVA = "0x502AA20", Offset = "0x5029620", VA = "0x18502AA20")]
		private string ListAsString(IEnumerable list, IXmlNamespaceResolver nsResolver)
		{
			return null;
		}

		// Token: 0x06000C69 RID: 3177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C69")]
		[Address(RVA = "0x502A380", Offset = "0x5028F80", VA = "0x18502A380")]
		private new Exception CreateInvalidClrMappingException(Type sourceType, Type destinationType)
		{
			return null;
		}

		// Token: 0x0400062F RID: 1583
		[Token(Token = "0x400062F")]
		[FieldOffset(Offset = "0x28")]
		protected XmlValueConverter atomicConverter;
	}
}
