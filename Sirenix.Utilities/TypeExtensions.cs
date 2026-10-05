using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sirenix.Utilities
{
	// Token: 0x0200002E RID: 46
	[Token(Token = "0x200002E")]
	public static class TypeExtensions
	{
		// Token: 0x06000198 RID: 408 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000198")]
		[Address(RVA = "0x4E2E220", Offset = "0x4E2CE20", VA = "0x184E2E220")]
		private static string GetCachedNiceName(Type type)
		{
			return null;
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000199")]
		[Address(RVA = "0x4E2C340", Offset = "0x4E2AF40", VA = "0x184E2C340")]
		private static string CreateNiceName(Type type)
		{
			return null;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00002CB4 File Offset: 0x00000EB4
		[Token(Token = "0x600019A")]
		[Address(RVA = "0x4E31A60", Offset = "0x4E30660", VA = "0x184E31A60")]
		private static bool HasCastDefined(this Type from, Type to, bool requireImplicitCast)
		{
			return default(bool);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00002CCC File Offset: 0x00000ECC
		[Token(Token = "0x600019B")]
		[Address(RVA = "0x4E32D40", Offset = "0x4E31940", VA = "0x184E32D40")]
		public static bool IsValidIdentifier(string identifier)
		{
			return default(bool);
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00002CE4 File Offset: 0x00000EE4
		[Token(Token = "0x600019C")]
		[Address(RVA = "0x4E32CD0", Offset = "0x4E318D0", VA = "0x184E32CD0")]
		private static bool IsValidIdentifierStartCharacter(char c)
		{
			return default(bool);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00002CFC File Offset: 0x00000EFC
		[Token(Token = "0x600019D")]
		[Address(RVA = "0x4E32C50", Offset = "0x4E31850", VA = "0x184E32C50")]
		private static bool IsValidIdentifierPartCharacter(char c)
		{
			return default(bool);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00002D14 File Offset: 0x00000F14
		[Token(Token = "0x600019E")]
		[Address(RVA = "0x4E327D0", Offset = "0x4E313D0", VA = "0x184E327D0")]
		public static bool IsCastableTo(this Type from, Type to, bool requireImplicitCast = false)
		{
			return default(bool);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600019F")]
		[Address(RVA = "0x4E2E3C0", Offset = "0x4E2CFC0", VA = "0x184E2E3C0")]
		public static Func<object, object> GetCastMethodDelegate(this Type from, Type to, bool requireImplicitCast = false)
		{
			return null;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001A0")]
		public static Func<TFrom, TTo> GetCastMethodDelegate<TFrom, TTo>(bool requireImplicitCast = false)
		{
			return null;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x4E2E650", Offset = "0x4E2D250", VA = "0x184E2E650")]
		public static MethodInfo GetCastMethod(this Type from, Type to, bool requireImplicitCast = false)
		{
			return null;
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00002D2C File Offset: 0x00000F2C
		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x4E2C8E0", Offset = "0x4E2B4E0", VA = "0x184E2C8E0")]
		private static bool FloatEqualityComparer(float a, float b)
		{
			return default(bool);
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00002D44 File Offset: 0x00000F44
		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x4E2C7F0", Offset = "0x4E2B3F0", VA = "0x184E2C7F0")]
		private static bool DoubleEqualityComparer(double a, double b)
		{
			return default(bool);
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00002D5C File Offset: 0x00000F5C
		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x4E32FB0", Offset = "0x4E31BB0", VA = "0x184E32FB0")]
		private static bool QuaternionEqualityComparer(Quaternion a, Quaternion b)
		{
			return default(bool);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001A5")]
		public static Func<T, T, bool> GetEqualityComparerDelegate<T>()
		{
			return null;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001A6")]
		public static T GetAttribute<T>(this Type type, bool inherit) where T : Attribute
		{
			return null;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00002D74 File Offset: 0x00000F74
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x4E32500", Offset = "0x4E31100", VA = "0x184E32500")]
		public static bool ImplementsOrInherits(this Type type, Type to)
		{
			return default(bool);
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00002D8C File Offset: 0x00000F8C
		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x4E32460", Offset = "0x4E31060", VA = "0x184E32460")]
		public static bool ImplementsOpenGenericType(this Type candidateType, Type openGenericType)
		{
			return default(bool);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00002DA4 File Offset: 0x00000FA4
		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x4E322D0", Offset = "0x4E30ED0", VA = "0x184E322D0")]
		public static bool ImplementsOpenGenericInterface(this Type candidateType, Type openGenericInterfaceType)
		{
			return default(bool);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00002DBC File Offset: 0x00000FBC
		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x4E32170", Offset = "0x4E30D70", VA = "0x184E32170")]
		public static bool ImplementsOpenGenericClass(this Type candidateType, Type openGenericType)
		{
			return default(bool);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x4E2DF40", Offset = "0x4E2CB40", VA = "0x184E2DF40")]
		public static Type[] GetArgumentsOfInheritedOpenGenericType(this Type candidateType, Type openGenericType)
		{
			return null;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x4E2DA50", Offset = "0x4E2C650", VA = "0x184E2DA50")]
		public static Type[] GetArgumentsOfInheritedOpenGenericClass(this Type candidateType, Type openGenericType)
		{
			return null;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x4E2DBE0", Offset = "0x4E2C7E0", VA = "0x184E2DBE0")]
		public static Type[] GetArgumentsOfInheritedOpenGenericInterface(this Type candidateType, Type openGenericInterfaceType)
		{
			return null;
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x4E307F0", Offset = "0x4E2F3F0", VA = "0x184E307F0")]
		public static MethodInfo GetOperatorMethod(this Type type, Operator op, Type leftOperand, Type rightOperand)
		{
			return null;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x4E30EF0", Offset = "0x4E2FAF0", VA = "0x184E30EF0")]
		public static MethodInfo GetOperatorMethod(this Type type, Operator op)
		{
			return null;
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x4E31360", Offset = "0x4E2FF60", VA = "0x184E31360")]
		public static MethodInfo[] GetOperatorMethods(this Type type, Operator op)
		{
			return null;
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x4E2D9C0", Offset = "0x4E2C5C0", VA = "0x184E2D9C0")]
		public static IEnumerable<MemberInfo> GetAllMembers(this Type type, BindingFlags flags = BindingFlags.Default)
		{
			return null;
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x4E2D910", Offset = "0x4E2C510", VA = "0x184E2D910")]
		public static IEnumerable<MemberInfo> GetAllMembers(this Type type, string name, BindingFlags flags = BindingFlags.Default)
		{
			return null;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001B3")]
		public static IEnumerable<T> GetAllMembers<T>(this Type type, BindingFlags flags = BindingFlags.Default) where T : MemberInfo
		{
			return null;
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x4E2EE20", Offset = "0x4E2DA20", VA = "0x184E2EE20")]
		public static Type GetGenericBaseType(this Type type, Type baseType)
		{
			return null;
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x4E2EE90", Offset = "0x4E2DA90", VA = "0x184E2EE90")]
		public static Type GetGenericBaseType(this Type type, Type baseType, out int depthCount)
		{
			return null;
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x4E2E070", Offset = "0x4E2CC70", VA = "0x184E2E070")]
		public static IEnumerable<Type> GetBaseTypes(this Type type, bool includeSelf = false)
		{
			return null;
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x4E2DFE0", Offset = "0x4E2CBE0", VA = "0x184E2DFE0")]
		public static IEnumerable<Type> GetBaseClasses(this Type type, bool includeSelf = false)
		{
			return null;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x4E30100", Offset = "0x4E2ED00", VA = "0x184E30100")]
		private static string GetMaybeSimplifiedTypeName(this Type type)
		{
			return null;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x4E306D0", Offset = "0x4E2F2D0", VA = "0x184E306D0")]
		public static string GetNiceName(this Type type)
		{
			return null;
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x4E30530", Offset = "0x4E2F130", VA = "0x184E30530")]
		public static string GetNiceFullName(this Type type)
		{
			return null;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x4E2EC10", Offset = "0x4E2D810", VA = "0x184E2EC10")]
		public static string GetCompilableNiceName(this Type type)
		{
			return null;
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x4E2EB70", Offset = "0x4E2D770", VA = "0x184E2EB70")]
		public static string GetCompilableNiceFullName(this Type type)
		{
			return null;
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001BD")]
		public static T GetCustomAttribute<T>(this Type type, bool inherit) where T : Attribute
		{
			return null;
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001BE")]
		public static T GetCustomAttribute<T>(this Type type) where T : Attribute
		{
			return null;
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001BF")]
		public static IEnumerable<T> GetCustomAttributes<T>(this Type type) where T : Attribute
		{
			return null;
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001C0")]
		public static IEnumerable<T> GetCustomAttributes<T>(this Type type, bool inherit) where T : Attribute
		{
			return null;
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00002DD4 File Offset: 0x00000FD4
		[Token(Token = "0x60001C1")]
		public static bool IsDefined<T>(this Type type) where T : Attribute
		{
			return default(bool);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00002DEC File Offset: 0x00000FEC
		[Token(Token = "0x60001C2")]
		public static bool IsDefined<T>(this Type type, bool inherit) where T : Attribute
		{
			return default(bool);
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00002E04 File Offset: 0x00001004
		[Token(Token = "0x60001C3")]
		public static bool InheritsFrom<TBase>(this Type type)
		{
			return default(bool);
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00002E1C File Offset: 0x0000101C
		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x4E32550", Offset = "0x4E31150", VA = "0x184E32550")]
		public static bool InheritsFrom(this Type type, Type baseType)
		{
			return default(bool);
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00002E34 File Offset: 0x00001034
		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x4E2FC30", Offset = "0x4E2E830", VA = "0x184E2FC30")]
		public static int GetInheritanceDistance(this Type type, Type baseType)
		{
			return 0;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00002E4C File Offset: 0x0000104C
		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x4E31FA0", Offset = "0x4E30BA0", VA = "0x184E31FA0")]
		public static bool HasParamaters(this MethodInfo methodInfo, IList<Type> paramTypes, bool inherit = true)
		{
			return default(bool);
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x4E317F0", Offset = "0x4E303F0", VA = "0x184E317F0")]
		public static Type GetReturnType(this MemberInfo memberInfo)
		{
			return null;
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x4E301D0", Offset = "0x4E2EDD0", VA = "0x184E301D0")]
		public static object GetMemberValue(this MemberInfo member, object obj)
		{
			return null;
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x4E33160", Offset = "0x4E31D60", VA = "0x184E33160")]
		public static void SetMemberValue(this MemberInfo member, object obj, object value)
		{
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00002E64 File Offset: 0x00001064
		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x4E335D0", Offset = "0x4E321D0", VA = "0x184E335D0")]
		public static bool TryInferGenericParameters(this Type genericTypeDefinition, out Type[] inferredParams, params Type[] knownParameters)
		{
			return default(bool);
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00002E7C File Offset: 0x0000107C
		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x4E2BFA0", Offset = "0x4E2ABA0", VA = "0x184E2BFA0")]
		public static bool AreGenericConstraintsSatisfiedBy(this Type genericType, params Type[] parameters)
		{
			return default(bool);
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00002E94 File Offset: 0x00001094
		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x4E2C180", Offset = "0x4E2AD80", VA = "0x184E2C180")]
		public static bool AreGenericConstraintsSatisfiedBy(this MethodBase genericMethod, params Type[] parameters)
		{
			return default(bool);
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00002EAC File Offset: 0x000010AC
		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x4E2BD70", Offset = "0x4E2A970", VA = "0x184E2BD70")]
		public static bool AreGenericConstraintsSatisfiedBy(Type[] definitions, Type[] parameters)
		{
			return default(bool);
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00002EC4 File Offset: 0x000010C4
		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x4E2D7A0", Offset = "0x4E2C3A0", VA = "0x184E2D7A0")]
		public static bool GenericParameterIsFulfilledBy(this Type genericParameterDefinition, Type parameterType)
		{
			return default(bool);
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00002EDC File Offset: 0x000010DC
		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x4E2CE90", Offset = "0x4E2BA90", VA = "0x184E2CE90")]
		private static bool GenericParameterIsFulfilledBy(this Type genericParameterDefinition, Type parameterType, Dictionary<Type, Type> resolvedMap, [Optional] HashSet<Type> processedParams)
		{
			return default(bool);
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x4E2F440", Offset = "0x4E2E040", VA = "0x184E2F440")]
		public static string GetGenericConstraintsString(this Type type, bool useFullTypeNames = false)
		{
			return null;
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x4E2F710", Offset = "0x4E2E310", VA = "0x184E2F710")]
		public static string GetGenericParameterConstraintsString(this Type type, bool useFullTypeNames = false)
		{
			return null;
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00002EF4 File Offset: 0x000010F4
		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x4E2C9C0", Offset = "0x4E2B5C0", VA = "0x184E2C9C0")]
		public static bool GenericArgumentsContainsTypes(this Type type, params Type[] types)
		{
			return default(bool);
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00002F0C File Offset: 0x0000110C
		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x4E329A0", Offset = "0x4E315A0", VA = "0x184E329A0")]
		public static bool IsFullyConstructedGenericType(this Type type)
		{
			return default(bool);
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00002F24 File Offset: 0x00001124
		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x4E32BE0", Offset = "0x4E317E0", VA = "0x184E32BE0")]
		public static bool IsNullableType(this Type type)
		{
			return default(bool);
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00002F3C File Offset: 0x0000113C
		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x4E2ECB0", Offset = "0x4E2D8B0", VA = "0x184E2ECB0")]
		public static ulong GetEnumBitmask(object value, Type enumType)
		{
			return 0UL;
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00002F54 File Offset: 0x00001154
		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x4E32750", Offset = "0x4E31350", VA = "0x184E32750")]
		public static bool IsCSharpKeyword(string identifier)
		{
			return default(bool);
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x4E33070", Offset = "0x4E31C70", VA = "0x184E33070")]
		public static Type[] SafeGetTypes(this Assembly assembly)
		{
			return null;
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00002F6C File Offset: 0x0000116C
		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x4E330F0", Offset = "0x4E31CF0", VA = "0x184E330F0")]
		public static bool SafeIsDefined(this Assembly assembly, Type attribute, bool inherit)
		{
			return default(bool);
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x4E32FF0", Offset = "0x4E31BF0", VA = "0x184E32FF0")]
		public static object[] SafeGetCustomAttributes(this Assembly assembly, Type type, bool inherit)
		{
			return null;
		}

		// Token: 0x04000109 RID: 265
		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Func<float, float, bool> FloatEqualityComparerFunc;

		// Token: 0x0400010A RID: 266
		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Func<double, double, bool> DoubleEqualityComparerFunc;

		// Token: 0x0400010B RID: 267
		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly Func<Quaternion, Quaternion, bool> QuaternionEqualityComparerFunc;

		// Token: 0x0400010C RID: 268
		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly object GenericConstraintsSatisfaction_LOCK;

		// Token: 0x0400010D RID: 269
		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly Dictionary<Type, Type> GenericConstraintsSatisfactionInferredParameters;

		// Token: 0x0400010E RID: 270
		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static readonly Dictionary<Type, Type> GenericConstraintsSatisfactionResolvedMap;

		// Token: 0x0400010F RID: 271
		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static readonly HashSet<Type> GenericConstraintsSatisfactionProcessedParams;

		// Token: 0x04000110 RID: 272
		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static readonly HashSet<Type> GenericConstraintsSatisfactionTypesToCheck;

		// Token: 0x04000111 RID: 273
		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static readonly List<Type> GenericConstraintsSatisfactionTypesToCheck_ToAdd;

		// Token: 0x04000112 RID: 274
		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static readonly Type GenericListInterface;

		// Token: 0x04000113 RID: 275
		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static readonly Type GenericCollectionInterface;

		// Token: 0x04000114 RID: 276
		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static readonly object WeaklyTypedTypeCastDelegates_LOCK;

		// Token: 0x04000115 RID: 277
		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static readonly object StronglyTypedTypeCastDelegates_LOCK;

		// Token: 0x04000116 RID: 278
		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static readonly DoubleLookupDictionary<Type, Type, Func<object, object>> WeaklyTypedTypeCastDelegates;

		// Token: 0x04000117 RID: 279
		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static readonly DoubleLookupDictionary<Type, Type, Delegate> StronglyTypedTypeCastDelegates;

		// Token: 0x04000118 RID: 280
		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static readonly Type[] TwoLengthTypeArray_Cached;

		// Token: 0x04000119 RID: 281
		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static readonly Stack<Type> GenericArgumentsContainsTypes_ArgsToCheckCached;

		// Token: 0x0400011A RID: 282
		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static HashSet<string> ReservedCSharpKeywords;

		// Token: 0x0400011B RID: 283
		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public static readonly Dictionary<Type, string> TypeNameAlternatives;

		// Token: 0x0400011C RID: 284
		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static readonly object CachedNiceNames_LOCK;

		// Token: 0x0400011D RID: 285
		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static readonly Dictionary<Type, string> CachedNiceNames;

		// Token: 0x0400011E RID: 286
		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static readonly Type VoidPointerType;

		// Token: 0x0400011F RID: 287
		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static readonly Dictionary<Type, HashSet<Type>> PrimitiveImplicitCasts;

		// Token: 0x04000120 RID: 288
		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static readonly HashSet<Type> ExplicitCastIntegrals;
	}
}
