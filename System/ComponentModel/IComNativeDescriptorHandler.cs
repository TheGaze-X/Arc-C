using System;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x020001A6 RID: 422
	[Token(Token = "0x20001A6")]
	[Obsolete("This interface has been deprecated. Add a TypeDescriptionProvider to handle type TypeDescriptor.ComObjectType instead.  https://go.microsoft.com/fwlink/?linkid=14202")]
	public interface IComNativeDescriptorHandler
	{
		// Token: 0x06000AEF RID: 2799
		[Token(Token = "0x6000AEF")]
		AttributeCollection GetAttributes(object component);

		// Token: 0x06000AF0 RID: 2800
		[Token(Token = "0x6000AF0")]
		string GetClassName(object component);

		// Token: 0x06000AF1 RID: 2801
		[Token(Token = "0x6000AF1")]
		TypeConverter GetConverter(object component);

		// Token: 0x06000AF2 RID: 2802
		[Token(Token = "0x6000AF2")]
		EventDescriptor GetDefaultEvent(object component);

		// Token: 0x06000AF3 RID: 2803
		[Token(Token = "0x6000AF3")]
		PropertyDescriptor GetDefaultProperty(object component);

		// Token: 0x06000AF4 RID: 2804
		[Token(Token = "0x6000AF4")]
		object GetEditor(object component, Type baseEditorType);

		// Token: 0x06000AF5 RID: 2805
		[Token(Token = "0x6000AF5")]
		string GetName(object component);

		// Token: 0x06000AF6 RID: 2806
		[Token(Token = "0x6000AF6")]
		EventDescriptorCollection GetEvents(object component);

		// Token: 0x06000AF7 RID: 2807
		[Token(Token = "0x6000AF7")]
		EventDescriptorCollection GetEvents(object component, Attribute[] attributes);

		// Token: 0x06000AF8 RID: 2808
		[Token(Token = "0x6000AF8")]
		PropertyDescriptorCollection GetProperties(object component, Attribute[] attributes);

		// Token: 0x06000AF9 RID: 2809
		[Token(Token = "0x6000AF9")]
		object GetPropertyValue(object component, string propertyName, ref bool success);

		// Token: 0x06000AFA RID: 2810
		[Token(Token = "0x6000AFA")]
		object GetPropertyValue(object component, int dispid, ref bool success);
	}
}
