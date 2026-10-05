using System;
using System.Globalization;
using Il2CppDummyDll;

namespace System.Reflection
{
	// Token: 0x02000535 RID: 1333
	[Token(Token = "0x2000535")]
	internal abstract class RtFieldInfo : FieldInfo
	{
		// Token: 0x060026A7 RID: 9895
		[Token(Token = "0x60026A7")]
		internal abstract object UnsafeGetValue(object obj);

		// Token: 0x060026A8 RID: 9896
		[Token(Token = "0x60026A8")]
		internal abstract void UnsafeSetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, System.Globalization.CultureInfo culture);

		// Token: 0x060026A9 RID: 9897
		[Token(Token = "0x60026A9")]
		internal abstract void CheckConsistency(object target);

		// Token: 0x060026AA RID: 9898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026AA")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		protected RtFieldInfo()
		{
		}
	}
}
