using System;
using System.Reflection;
using Il2CppDummyDll;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000044 RID: 68
	[Token(Token = "0x2000044")]
	[Preserve]
	internal abstract class ReflectionDelegateFactory
	{
		// Token: 0x060002C7 RID: 711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C7")]
		public Func<T, object> CreateGet<T>(MemberInfo memberInfo)
		{
			return null;
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C8")]
		public Action<T, object> CreateSet<T>(MemberInfo memberInfo)
		{
			return null;
		}

		// Token: 0x060002C9 RID: 713
		[Token(Token = "0x60002C9")]
		public abstract MethodCall<T, object> CreateMethodCall<T>(MethodBase method);

		// Token: 0x060002CA RID: 714
		[Token(Token = "0x60002CA")]
		public abstract ObjectConstructor<object> CreateParameterizedConstructor(MethodBase method);

		// Token: 0x060002CB RID: 715
		[Token(Token = "0x60002CB")]
		public abstract Func<T> CreateDefaultConstructor<T>(Type type);

		// Token: 0x060002CC RID: 716
		[Token(Token = "0x60002CC")]
		public abstract Func<T, object> CreateGet<T>(PropertyInfo propertyInfo);

		// Token: 0x060002CD RID: 717
		[Token(Token = "0x60002CD")]
		public abstract Func<T, object> CreateGet<T>(FieldInfo fieldInfo);

		// Token: 0x060002CE RID: 718
		[Token(Token = "0x60002CE")]
		public abstract Action<T, object> CreateSet<T>(FieldInfo fieldInfo);

		// Token: 0x060002CF RID: 719
		[Token(Token = "0x60002CF")]
		public abstract Action<T, object> CreateSet<T>(PropertyInfo propertyInfo);

		// Token: 0x060002D0 RID: 720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected ReflectionDelegateFactory()
		{
		}
	}
}
