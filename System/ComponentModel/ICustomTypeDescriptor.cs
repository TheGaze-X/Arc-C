using System;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x020001A7 RID: 423
	[Token(Token = "0x20001A7")]
	public interface ICustomTypeDescriptor
	{
		// Token: 0x06000AFB RID: 2811
		[Token(Token = "0x6000AFB")]
		AttributeCollection GetAttributes();

		// Token: 0x06000AFC RID: 2812
		[Token(Token = "0x6000AFC")]
		string GetClassName();

		// Token: 0x06000AFD RID: 2813
		[Token(Token = "0x6000AFD")]
		string GetComponentName();

		// Token: 0x06000AFE RID: 2814
		[Token(Token = "0x6000AFE")]
		TypeConverter GetConverter();

		// Token: 0x06000AFF RID: 2815
		[Token(Token = "0x6000AFF")]
		EventDescriptor GetDefaultEvent();

		// Token: 0x06000B00 RID: 2816
		[Token(Token = "0x6000B00")]
		PropertyDescriptor GetDefaultProperty();

		// Token: 0x06000B01 RID: 2817
		[Token(Token = "0x6000B01")]
		object GetEditor(Type editorBaseType);

		// Token: 0x06000B02 RID: 2818
		[Token(Token = "0x6000B02")]
		EventDescriptorCollection GetEvents();

		// Token: 0x06000B03 RID: 2819
		[Token(Token = "0x6000B03")]
		EventDescriptorCollection GetEvents(Attribute[] attributes);

		// Token: 0x06000B04 RID: 2820
		[Token(Token = "0x6000B04")]
		PropertyDescriptorCollection GetProperties();

		// Token: 0x06000B05 RID: 2821
		[Token(Token = "0x6000B05")]
		PropertyDescriptorCollection GetProperties(Attribute[] attributes);

		// Token: 0x06000B06 RID: 2822
		[Token(Token = "0x6000B06")]
		object GetPropertyOwner(PropertyDescriptor pd);
	}
}
