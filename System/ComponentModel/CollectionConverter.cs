using System;
using System.Globalization;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x020001FF RID: 511
	[Token(Token = "0x20001FF")]
	public class CollectionConverter : TypeConverter
	{
		// Token: 0x06000D6F RID: 3439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D6F")]
		[Address(RVA = "0x5157E70", Offset = "0x5156A70", VA = "0x185157E70", Slot = "7")]
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			return null;
		}

		// Token: 0x06000D70 RID: 3440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D70")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "10")]
		public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
		{
			return null;
		}

		// Token: 0x06000D71 RID: 3441 RVA: 0x00007440 File Offset: 0x00005640
		[Token(Token = "0x6000D71")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "11")]
		public override bool GetPropertiesSupported(ITypeDescriptorContext context)
		{
			return default(bool);
		}

		// Token: 0x06000D72 RID: 3442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D72")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public CollectionConverter()
		{
		}
	}
}
