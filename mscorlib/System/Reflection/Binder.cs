using System;
using System.Globalization;
using Il2CppDummyDll;

namespace System.Reflection
{
	// Token: 0x020004F1 RID: 1265
	[Token(Token = "0x20004F1")]
	public abstract class Binder
	{
		// Token: 0x0600242F RID: 9263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600242F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected Binder()
		{
		}

		// Token: 0x06002430 RID: 9264
		[Token(Token = "0x6002430")]
		public abstract FieldInfo BindToField(BindingFlags bindingAttr, FieldInfo[] match, object value, System.Globalization.CultureInfo culture);

		// Token: 0x06002431 RID: 9265
		[Token(Token = "0x6002431")]
		public abstract MethodBase BindToMethod(BindingFlags bindingAttr, MethodBase[] match, ref object[] args, ParameterModifier[] modifiers, System.Globalization.CultureInfo culture, string[] names, out object state);

		// Token: 0x06002432 RID: 9266
		[Token(Token = "0x6002432")]
		public abstract object ChangeType(object value, System.Type type, System.Globalization.CultureInfo culture);

		// Token: 0x06002433 RID: 9267
		[Token(Token = "0x6002433")]
		public abstract void ReorderArgumentArray(ref object[] args, object state);

		// Token: 0x06002434 RID: 9268
		[Token(Token = "0x6002434")]
		public abstract MethodBase SelectMethod(BindingFlags bindingAttr, MethodBase[] match, System.Type[] types, ParameterModifier[] modifiers);

		// Token: 0x06002435 RID: 9269
		[Token(Token = "0x6002435")]
		public abstract PropertyInfo SelectProperty(BindingFlags bindingAttr, PropertyInfo[] match, System.Type returnType, System.Type[] indexes, ParameterModifier[] modifiers);
	}
}
