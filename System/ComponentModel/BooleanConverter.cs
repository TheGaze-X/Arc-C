using System;
using System.Globalization;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x0200017A RID: 378
	[Token(Token = "0x200017A")]
	public class BooleanConverter : TypeConverter
	{
		// Token: 0x060009BD RID: 2493 RVA: 0x00005BC8 File Offset: 0x00003DC8
		[Token(Token = "0x60009BD")]
		[Address(RVA = "0x513A400", Offset = "0x5139000", VA = "0x18513A400", Slot = "4")]
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return default(bool);
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009BE")]
		[Address(RVA = "0x513A4B0", Offset = "0x51390B0", VA = "0x18513A4B0", Slot = "6")]
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			return null;
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009BF")]
		[Address(RVA = "0x513A630", Offset = "0x5139230", VA = "0x18513A630", Slot = "12")]
		public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			return null;
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x00005BE0 File Offset: 0x00003DE0
		[Token(Token = "0x60009C0")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "13")]
		public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
		{
			return default(bool);
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x00005BF8 File Offset: 0x00003DF8
		[Token(Token = "0x60009C1")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "14")]
		public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			return default(bool);
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009C2")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public BooleanConverter()
		{
		}

		// Token: 0x04000662 RID: 1634
		[Token(Token = "0x4000662")]
		[FieldOffset(Offset = "0x0")]
		private static TypeConverter.StandardValuesCollection s_values;
	}
}
