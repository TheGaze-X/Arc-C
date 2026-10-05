using System;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x0200019D RID: 413
	[Token(Token = "0x200019D")]
	public class ExpandableObjectConverter : TypeConverter
	{
		// Token: 0x06000AAF RID: 2735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AAF")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public ExpandableObjectConverter()
		{
		}

		// Token: 0x06000AB0 RID: 2736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AB0")]
		[Address(RVA = "0x5145BF0", Offset = "0x51447F0", VA = "0x185145BF0", Slot = "10")]
		public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
		{
			return null;
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x00006210 File Offset: 0x00004410
		[Token(Token = "0x6000AB1")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "11")]
		public override bool GetPropertiesSupported(ITypeDescriptorContext context)
		{
			return default(bool);
		}
	}
}
