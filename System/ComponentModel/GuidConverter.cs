using System;
using System.Globalization;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x020001A0 RID: 416
	[Token(Token = "0x20001A0")]
	public class GuidConverter : TypeConverter
	{
		// Token: 0x06000AC8 RID: 2760 RVA: 0x000062B8 File Offset: 0x000044B8
		[Token(Token = "0x6000AC8")]
		[Address(RVA = "0x51466F0", Offset = "0x51452F0", VA = "0x1851466F0", Slot = "4")]
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return default(bool);
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x000062D0 File Offset: 0x000044D0
		[Token(Token = "0x6000AC9")]
		[Address(RVA = "0x51467A0", Offset = "0x51453A0", VA = "0x1851467A0", Slot = "5")]
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return default(bool);
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ACA")]
		[Address(RVA = "0x5146850", Offset = "0x5145450", VA = "0x185146850", Slot = "6")]
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			return null;
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ACB")]
		[Address(RVA = "0x5146920", Offset = "0x5145520", VA = "0x185146920", Slot = "7")]
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			return null;
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000ACC")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public GuidConverter()
		{
		}
	}
}
