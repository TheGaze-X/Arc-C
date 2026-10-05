using System;
using System.Reflection;
using Il2CppDummyDll;

namespace Sirenix.Utilities
{
	// Token: 0x02000050 RID: 80
	[Token(Token = "0x2000050")]
	public static class EmitUtilities
	{
		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000265 RID: 613 RVA: 0x000030EC File Offset: 0x000012EC
		[Token(Token = "0x17000040")]
		public static bool CanEmit
		{
			[Token(Token = "0x6000265")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00003104 File Offset: 0x00001304
		[Token(Token = "0x6000266")]
		[Address(RVA = "0x4E22100", Offset = "0x4E20D00", VA = "0x184E22100")]
		private static bool EmitIsIllegalForMember(MemberInfo member)
		{
			return default(bool);
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000267")]
		public static Func<FieldType> CreateStaticFieldGetter<FieldType>(FieldInfo fieldInfo)
		{
			return null;
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000268")]
		[Address(RVA = "0x4E21CC0", Offset = "0x4E208C0", VA = "0x184E21CC0")]
		public static Func<object> CreateWeakStaticFieldGetter(FieldInfo fieldInfo)
		{
			return null;
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000269")]
		public static Action<FieldType> CreateStaticFieldSetter<FieldType>(FieldInfo fieldInfo)
		{
			return null;
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600026A")]
		[Address(RVA = "0x4E21EE0", Offset = "0x4E20AE0", VA = "0x184E21EE0")]
		public static Action<object> CreateWeakStaticFieldSetter(FieldInfo fieldInfo)
		{
			return null;
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600026B")]
		public static ValueGetter<InstanceType, FieldType> CreateInstanceFieldGetter<InstanceType, FieldType>(FieldInfo fieldInfo)
		{
			return null;
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600026C")]
		public static WeakValueGetter<FieldType> CreateWeakInstanceFieldGetter<FieldType>(Type instanceType, FieldInfo fieldInfo)
		{
			return null;
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600026D")]
		[Address(RVA = "0x4E20D40", Offset = "0x4E1F940", VA = "0x184E20D40")]
		public static WeakValueGetter CreateWeakInstanceFieldGetter(Type instanceType, FieldInfo fieldInfo)
		{
			return null;
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600026E")]
		public static ValueSetter<InstanceType, FieldType> CreateInstanceFieldSetter<InstanceType, FieldType>(FieldInfo fieldInfo)
		{
			return null;
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600026F")]
		public static WeakValueSetter<FieldType> CreateWeakInstanceFieldSetter<FieldType>(Type instanceType, FieldInfo fieldInfo)
		{
			return null;
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000270")]
		[Address(RVA = "0x4E20FF0", Offset = "0x4E1FBF0", VA = "0x184E20FF0")]
		public static WeakValueSetter CreateWeakInstanceFieldSetter(Type instanceType, FieldInfo fieldInfo)
		{
			return null;
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000271")]
		[Address(RVA = "0x4E215B0", Offset = "0x4E201B0", VA = "0x184E215B0")]
		public static WeakValueGetter CreateWeakInstancePropertyGetter(Type instanceType, PropertyInfo propertyInfo)
		{
			return null;
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000272")]
		[Address(RVA = "0x4E21970", Offset = "0x4E20570", VA = "0x184E21970")]
		public static WeakValueSetter CreateWeakInstancePropertySetter(Type instanceType, PropertyInfo propertyInfo)
		{
			return null;
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000273")]
		public static Action<PropType> CreateStaticPropertySetter<PropType>(PropertyInfo propertyInfo)
		{
			return null;
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000274")]
		public static Func<PropType> CreateStaticPropertyGetter<PropType>(PropertyInfo propertyInfo)
		{
			return null;
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000275")]
		public static ValueSetter<InstanceType, PropType> CreateInstancePropertySetter<InstanceType, PropType>(PropertyInfo propertyInfo)
		{
			return null;
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000276")]
		public static ValueGetter<InstanceType, PropType> CreateInstancePropertyGetter<InstanceType, PropType>(PropertyInfo propertyInfo)
		{
			return null;
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000277")]
		public static Func<InstanceType, ReturnType> CreateMethodReturner<InstanceType, ReturnType>(MethodInfo methodInfo)
		{
			return null;
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000278")]
		[Address(RVA = "0x4E20A70", Offset = "0x4E1F670", VA = "0x184E20A70")]
		public static Action CreateStaticMethodCaller(MethodInfo methodInfo)
		{
			return null;
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000279")]
		public static Action<object, TArg1> CreateWeakInstanceMethodCaller<TArg1>(MethodInfo methodInfo)
		{
			return null;
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600027A")]
		[Address(RVA = "0x4E212A0", Offset = "0x4E1FEA0", VA = "0x184E212A0")]
		public static Action<object> CreateWeakInstanceMethodCaller(MethodInfo methodInfo)
		{
			return null;
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600027B")]
		public static Func<object, TArg1, TResult> CreateWeakInstanceMethodCaller<TResult, TArg1>(MethodInfo methodInfo)
		{
			return null;
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600027C")]
		public static Func<object, TResult> CreateWeakInstanceMethodCallerFunc<TResult>(MethodInfo methodInfo)
		{
			return null;
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600027D")]
		public static Func<object, TArg, TResult> CreateWeakInstanceMethodCallerFunc<TArg, TResult>(MethodInfo methodInfo)
		{
			return null;
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600027E")]
		public static Action<InstanceType> CreateInstanceMethodCaller<InstanceType>(MethodInfo methodInfo)
		{
			return null;
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600027F")]
		public static Action<InstanceType, Arg1> CreateInstanceMethodCaller<InstanceType, Arg1>(MethodInfo methodInfo)
		{
			return null;
		}

		// Token: 0x04000174 RID: 372
		[Token(Token = "0x4000174")]
		[FieldOffset(Offset = "0x0")]
		private static Assembly EngineAssembly;
	}
}
