using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x02000160 RID: 352
	[Token(Token = "0x2000160")]
	internal class XmlDateTimeConverter : XmlBaseConverter
	{
		// Token: 0x06000BFB RID: 3067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BFB")]
		[Address(RVA = "0x50173E0", Offset = "0x5015FE0", VA = "0x1850173E0")]
		protected XmlDateTimeConverter(XmlSchemaType schemaType)
		{
		}

		// Token: 0x06000BFC RID: 3068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BFC")]
		[Address(RVA = "0x5015B20", Offset = "0x5014720", VA = "0x185015B20")]
		public static XmlValueConverter Create(XmlSchemaType schemaType)
		{
			return null;
		}

		// Token: 0x06000BFD RID: 3069 RVA: 0x000061E0 File Offset: 0x000043E0
		[Token(Token = "0x6000BFD")]
		[Address(RVA = "0x5016310", Offset = "0x5014F10", VA = "0x185016310", Slot = "37")]
		public override DateTime ToDateTime(DateTimeOffset value)
		{
			return default(DateTime);
		}

		// Token: 0x06000BFE RID: 3070 RVA: 0x000061F8 File Offset: 0x000043F8
		[Token(Token = "0x6000BFE")]
		[Address(RVA = "0x50163A0", Offset = "0x5014FA0", VA = "0x1850163A0", Slot = "38")]
		public override DateTime ToDateTime(string value)
		{
			return default(DateTime);
		}

		// Token: 0x06000BFF RID: 3071 RVA: 0x00006210 File Offset: 0x00004410
		[Token(Token = "0x6000BFF")]
		[Address(RVA = "0x50166A0", Offset = "0x50152A0", VA = "0x1850166A0", Slot = "39")]
		public override DateTime ToDateTime(object value)
		{
			return default(DateTime);
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x00006228 File Offset: 0x00004428
		[Token(Token = "0x6000C00")]
		[Address(RVA = "0x5015FD0", Offset = "0x5014BD0", VA = "0x185015FD0", Slot = "40")]
		public override DateTimeOffset ToDateTimeOffset(DateTime value)
		{
			return default(DateTimeOffset);
		}

		// Token: 0x06000C01 RID: 3073 RVA: 0x00006240 File Offset: 0x00004440
		[Token(Token = "0x6000C01")]
		[Address(RVA = "0x5016000", Offset = "0x5014C00", VA = "0x185016000", Slot = "41")]
		public override DateTimeOffset ToDateTimeOffset(string value)
		{
			return default(DateTimeOffset);
		}

		// Token: 0x06000C02 RID: 3074 RVA: 0x00006258 File Offset: 0x00004458
		[Token(Token = "0x6000C02")]
		[Address(RVA = "0x5015BB0", Offset = "0x50147B0", VA = "0x185015BB0", Slot = "42")]
		public override DateTimeOffset ToDateTimeOffset(object value)
		{
			return default(DateTimeOffset);
		}

		// Token: 0x06000C03 RID: 3075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C03")]
		[Address(RVA = "0x5016D50", Offset = "0x5015950", VA = "0x185016D50", Slot = "49")]
		public override string ToString(DateTime value)
		{
			return null;
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C04")]
		[Address(RVA = "0x5016A70", Offset = "0x5015670", VA = "0x185016A70", Slot = "50")]
		public override string ToString(DateTimeOffset value)
		{
			return null;
		}

		// Token: 0x06000C05 RID: 3077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C05")]
		[Address(RVA = "0x5016FF0", Offset = "0x5015BF0", VA = "0x185016FF0", Slot = "52")]
		public override string ToString(object value, IXmlNamespaceResolver nsResolver)
		{
			return null;
		}

		// Token: 0x06000C06 RID: 3078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C06")]
		[Address(RVA = "0x5015650", Offset = "0x5014250", VA = "0x185015650", Slot = "58")]
		public override object ChangeType(DateTime value, Type destinationType)
		{
			return null;
		}

		// Token: 0x06000C07 RID: 3079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C07")]
		[Address(RVA = "0x50144C0", Offset = "0x50130C0", VA = "0x1850144C0", Slot = "59")]
		public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			return null;
		}

		// Token: 0x06000C08 RID: 3080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C08")]
		[Address(RVA = "0x50149D0", Offset = "0x50135D0", VA = "0x1850149D0", Slot = "61")]
		public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			return null;
		}
	}
}
