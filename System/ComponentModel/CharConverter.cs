using System;
using System.Globalization;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x0200017D RID: 381
	[Token(Token = "0x200017D")]
	public class CharConverter : TypeConverter
	{
		// Token: 0x060009CC RID: 2508 RVA: 0x00005C10 File Offset: 0x00003E10
		[Token(Token = "0x60009CC")]
		[Address(RVA = "0x513A9B0", Offset = "0x51395B0", VA = "0x18513A9B0", Slot = "4")]
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return default(bool);
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009CD")]
		[Address(RVA = "0x513ABD0", Offset = "0x51397D0", VA = "0x18513ABD0", Slot = "7")]
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			return null;
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009CE")]
		[Address(RVA = "0x513AA60", Offset = "0x5139660", VA = "0x18513AA60", Slot = "6")]
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			return null;
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009CF")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public CharConverter()
		{
		}
	}
}
