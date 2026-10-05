using System;
using System.Globalization;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x020001E1 RID: 481
	[Token(Token = "0x20001E1")]
	public class StringConverter : TypeConverter
	{
		// Token: 0x06000CDE RID: 3294 RVA: 0x00007218 File Offset: 0x00005418
		[Token(Token = "0x6000CDE")]
		[Address(RVA = "0x5174210", Offset = "0x5172E10", VA = "0x185174210", Slot = "4")]
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return default(bool);
		}

		// Token: 0x06000CDF RID: 3295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CDF")]
		[Address(RVA = "0x51742C0", Offset = "0x5172EC0", VA = "0x1851742C0", Slot = "6")]
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			return null;
		}

		// Token: 0x06000CE0 RID: 3296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CE0")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public StringConverter()
		{
		}
	}
}
