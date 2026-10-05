using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;

namespace Sirenix.Utilities
{
	// Token: 0x0200003A RID: 58
	[Token(Token = "0x200003A")]
	public static class DeepReflection
	{
		// Token: 0x06000213 RID: 531 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000213")]
		[Address(RVA = "0x4E1E540", Offset = "0x4E1D140", VA = "0x184E1E540")]
		public static Func<object> CreateWeakStaticValueGetter(Type rootType, Type resultType, string path, bool allowEmit = true)
		{
			return null;
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000214")]
		[Address(RVA = "0x4E1E120", Offset = "0x4E1CD20", VA = "0x184E1E120")]
		public static Func<object, object> CreateWeakInstanceValueGetter(Type rootType, Type resultType, string path, bool allowEmit = true)
		{
			return null;
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000215")]
		[Address(RVA = "0x4E1E330", Offset = "0x4E1CF30", VA = "0x184E1E330")]
		public static Action<object, object> CreateWeakInstanceValueSetter(Type rootType, Type argType, string path, bool allowEmit = true)
		{
			return null;
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000216")]
		public static Func<object, TResult> CreateWeakInstanceValueGetter<TResult>(Type rootType, string path, bool allowEmit = true)
		{
			return null;
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000217")]
		public static Func<TResult> CreateValueGetter<TResult>(Type rootType, string path, bool allowEmit = true)
		{
			return null;
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000218")]
		public static Func<TTarget, TResult> CreateValueGetter<TTarget, TResult>(string path, bool allowEmit = true)
		{
			return null;
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000219")]
		private static Func<object, object> CreateWeakAliasForInstanceGetDelegate1<TTarget, TResult>(Func<TTarget, TResult> func)
		{
			return null;
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600021A")]
		private static Func<object, TResult> CreateWeakAliasForInstanceGetDelegate2<TTarget, TResult>(Func<TTarget, TResult> func)
		{
			return null;
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600021B")]
		private static Func<object> CreateWeakAliasForStaticGetDelegate<TResult>(Func<TResult> func)
		{
			return null;
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600021C")]
		private static Action<object, object> CreateWeakAliasForInstanceSetDelegate1<TTarget, TArg1>(Action<TTarget, TArg1> func)
		{
			return null;
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600021D")]
		private static Action<object, TArg1> CreateWeakAliasForInstanceSetDelegate2<TTarget, TArg1>(Action<TTarget, TArg1> func)
		{
			return null;
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600021E")]
		private static Action<object> CreateWeakAliasForStaticSetDelegate<TArg1>(Action<TArg1> func)
		{
			return null;
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600021F")]
		[Address(RVA = "0x4E1DEB0", Offset = "0x4E1CAB0", VA = "0x184E1DEB0")]
		private static Delegate CreateEmittedDeepValueGetterDelegate(string path, Type rootType, Type resultType, List<DeepReflection.PathStep> memberPath, bool rootIsStatic)
		{
			return null;
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000220")]
		[Address(RVA = "0x4E1E070", Offset = "0x4E1CC70", VA = "0x184E1E070")]
		private static Func<object> CreateSlowDeepStaticValueGetterDelegate(List<DeepReflection.PathStep> memberPath)
		{
			return null;
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000221")]
		[Address(RVA = "0x4E1DF10", Offset = "0x4E1CB10", VA = "0x184E1DF10")]
		private static Func<object, object> CreateSlowDeepInstanceValueGetterDelegate(List<DeepReflection.PathStep> memberPath)
		{
			return null;
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000222")]
		[Address(RVA = "0x4E1DFC0", Offset = "0x4E1CBC0", VA = "0x184E1DFC0")]
		private static Action<object, object> CreateSlowDeepInstanceValueSetterDelegate(List<DeepReflection.PathStep> memberPath)
		{
			return null;
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000223")]
		[Address(RVA = "0x4E1FBC0", Offset = "0x4E1E7C0", VA = "0x184E1FBC0")]
		private static object SlowGetMemberValue(DeepReflection.PathStep step, object instance)
		{
			return null;
		}

		// Token: 0x06000224 RID: 548 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000224")]
		[Address(RVA = "0x4E20130", Offset = "0x4E1ED30", VA = "0x184E20130")]
		private static void SlowSetMemberValue(DeepReflection.PathStep step, object instance, object value)
		{
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000225")]
		[Address(RVA = "0x4E1E750", Offset = "0x4E1D350", VA = "0x184E1E750")]
		private static List<DeepReflection.PathStep> GetMemberPath(Type rootType, ref Type resultType, string path, out bool rootIsStatic, bool isSet)
		{
			return null;
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000226")]
		[Address(RVA = "0x4E1F410", Offset = "0x4E1E010", VA = "0x184E1F410")]
		private static MemberInfo GetStepMember(Type owningType, string name, bool expectMethod)
		{
			return null;
		}

		// Token: 0x04000157 RID: 343
		[Token(Token = "0x4000157")]
		[FieldOffset(Offset = "0x0")]
		private static MethodInfo WeakListGetItem;

		// Token: 0x04000158 RID: 344
		[Token(Token = "0x4000158")]
		[FieldOffset(Offset = "0x8")]
		private static MethodInfo WeakListSetItem;

		// Token: 0x04000159 RID: 345
		[Token(Token = "0x4000159")]
		[FieldOffset(Offset = "0x10")]
		private static MethodInfo CreateWeakAliasForInstanceGetDelegate1MethodInfo;

		// Token: 0x0400015A RID: 346
		[Token(Token = "0x400015A")]
		[FieldOffset(Offset = "0x18")]
		private static MethodInfo CreateWeakAliasForInstanceGetDelegate2MethodInfo;

		// Token: 0x0400015B RID: 347
		[Token(Token = "0x400015B")]
		[FieldOffset(Offset = "0x20")]
		private static MethodInfo CreateWeakAliasForStaticGetDelegateMethodInfo;

		// Token: 0x0400015C RID: 348
		[Token(Token = "0x400015C")]
		[FieldOffset(Offset = "0x28")]
		private static MethodInfo CreateWeakAliasForInstanceSetDelegate1MethodInfo;

		// Token: 0x0200003B RID: 59
		[Token(Token = "0x200003B")]
		private enum PathStepType
		{
			// Token: 0x0400015E RID: 350
			[Token(Token = "0x400015E")]
			Member,
			// Token: 0x0400015F RID: 351
			[Token(Token = "0x400015F")]
			WeakListElement,
			// Token: 0x04000160 RID: 352
			[Token(Token = "0x4000160")]
			StrongListElement,
			// Token: 0x04000161 RID: 353
			[Token(Token = "0x4000161")]
			ArrayElement
		}

		// Token: 0x0200003C RID: 60
		[Token(Token = "0x200003C")]
		private struct PathStep
		{
			// Token: 0x06000228 RID: 552 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6000228")]
			[Address(RVA = "0x4E283A0", Offset = "0x4E26FA0", VA = "0x184E283A0")]
			public PathStep(MemberInfo member)
			{
			}

			// Token: 0x06000229 RID: 553 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6000229")]
			[Address(RVA = "0x4E283F0", Offset = "0x4E26FF0", VA = "0x184E283F0")]
			public PathStep(int elementIndex)
			{
			}

			// Token: 0x0600022A RID: 554 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x600022A")]
			[Address(RVA = "0x4E28210", Offset = "0x4E26E10", VA = "0x184E28210")]
			public PathStep(int elementIndex, Type strongListElementType, bool isArray)
			{
			}

			// Token: 0x04000162 RID: 354
			[Token(Token = "0x4000162")]
			[FieldOffset(Offset = "0x0")]
			public readonly DeepReflection.PathStepType StepType;

			// Token: 0x04000163 RID: 355
			[Token(Token = "0x4000163")]
			[FieldOffset(Offset = "0x8")]
			public readonly MemberInfo Member;

			// Token: 0x04000164 RID: 356
			[Token(Token = "0x4000164")]
			[FieldOffset(Offset = "0x10")]
			public readonly int ElementIndex;

			// Token: 0x04000165 RID: 357
			[Token(Token = "0x4000165")]
			[FieldOffset(Offset = "0x18")]
			public readonly Type ElementType;

			// Token: 0x04000166 RID: 358
			[Token(Token = "0x4000166")]
			[FieldOffset(Offset = "0x20")]
			public readonly MethodInfo StrongListGetItemMethod;
		}
	}
}
