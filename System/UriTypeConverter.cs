using System;
using System.ComponentModel;
using System.Globalization;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000D6 RID: 214
	[Token(Token = "0x20000D6")]
	public class UriTypeConverter : TypeConverter
	{
		// Token: 0x06000461 RID: 1121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000461")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public UriTypeConverter()
		{
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x00003990 File Offset: 0x00001B90
		[Token(Token = "0x6000462")]
		[Address(RVA = "0x5104780", Offset = "0x5103380", VA = "0x185104780")]
		private bool CanConvert(Type type)
		{
			return default(bool);
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x000039A8 File Offset: 0x00001BA8
		[Token(Token = "0x6000463")]
		[Address(RVA = "0x5104640", Offset = "0x5103240", VA = "0x185104640", Slot = "4")]
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return default(bool);
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x000039C0 File Offset: 0x00001BC0
		[Token(Token = "0x6000464")]
		[Address(RVA = "0x5104700", Offset = "0x5103300", VA = "0x185104700", Slot = "5")]
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return default(bool);
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000465")]
		[Address(RVA = "0x5104850", Offset = "0x5103450", VA = "0x185104850", Slot = "6")]
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			return null;
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000466")]
		[Address(RVA = "0x5104AA0", Offset = "0x51036A0", VA = "0x185104AA0", Slot = "7")]
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			return null;
		}
	}
}
