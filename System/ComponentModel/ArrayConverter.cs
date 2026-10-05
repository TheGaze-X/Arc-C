using System;
using System.Globalization;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x0200016F RID: 367
	[Token(Token = "0x200016F")]
	public class ArrayConverter : CollectionConverter
	{
		// Token: 0x0600094C RID: 2380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600094C")]
		[Address(RVA = "0x511C660", Offset = "0x511B260", VA = "0x18511C660", Slot = "7")]
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			return null;
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600094D")]
		[Address(RVA = "0x511C850", Offset = "0x511B450", VA = "0x18511C850", Slot = "10")]
		public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
		{
			return null;
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x00005820 File Offset: 0x00003A20
		[Token(Token = "0x600094E")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "11")]
		public override bool GetPropertiesSupported(ITypeDescriptorContext context)
		{
			return default(bool);
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600094F")]
		[Address(RVA = "0x286AC00", Offset = "0x2869800", VA = "0x18286AC00")]
		public ArrayConverter()
		{
		}

		// Token: 0x02000170 RID: 368
		[Token(Token = "0x2000170")]
		private class ArrayPropertyDescriptor : TypeConverter.SimplePropertyDescriptor
		{
			// Token: 0x06000950 RID: 2384 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000950")]
			[Address(RVA = "0x511CDF0", Offset = "0x511B9F0", VA = "0x18511CDF0")]
			public ArrayPropertyDescriptor(Type arrayType, Type elementType, int index)
			{
			}

			// Token: 0x06000951 RID: 2385 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000951")]
			[Address(RVA = "0x511CB70", Offset = "0x511B770", VA = "0x18511CB70", Slot = "26")]
			public override object GetValue(object instance)
			{
				return null;
			}

			// Token: 0x06000952 RID: 2386 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000952")]
			[Address(RVA = "0x511CC40", Offset = "0x511B840", VA = "0x18511CC40", Slot = "30")]
			public override void SetValue(object instance, object value)
			{
			}

			// Token: 0x0400063D RID: 1597
			[Token(Token = "0x400063D")]
			[FieldOffset(Offset = "0x98")]
			private readonly int _index;
		}
	}
}
