using System;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x02000202 RID: 514
	[Token(Token = "0x2000202")]
	public class ComponentConverter : ReferenceConverter
	{
		// Token: 0x06000D85 RID: 3461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D85")]
		[Address(RVA = "0x5158220", Offset = "0x5156E20", VA = "0x185158220")]
		public ComponentConverter(Type type)
		{
		}

		// Token: 0x06000D86 RID: 3462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D86")]
		[Address(RVA = "0x51581C0", Offset = "0x5156DC0", VA = "0x1851581C0", Slot = "10")]
		public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
		{
			return null;
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x000074A0 File Offset: 0x000056A0
		[Token(Token = "0x6000D87")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "11")]
		public override bool GetPropertiesSupported(ITypeDescriptorContext context)
		{
			return default(bool);
		}
	}
}
