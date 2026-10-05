using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;

namespace YoStar.SDK.UIWidgets
{
	// Token: 0x020000ED RID: 237
	[Token(Token = "0x20000ED")]
	public static class Utility
	{
		// Token: 0x06000664 RID: 1636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000664")]
		[Address(RVA = "0x5C39530", Offset = "0x5C38130", VA = "0x185C39530")]
		public static Type GetType(string typeName)
		{
			return null;
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000665")]
		[Address(RVA = "0x5C392B0", Offset = "0x5C37EB0", VA = "0x185C392B0")]
		public static Type GetElementType(Type type)
		{
			return null;
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000666")]
		[Address(RVA = "0x5C38F90", Offset = "0x5C37B90", VA = "0x185C38F90")]
		public static MethodInfo[] GetAllMethods(this Type type)
		{
			return null;
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000667")]
		[Address(RVA = "0x5C38E50", Offset = "0x5C37A50", VA = "0x185C38E50")]
		public static IEnumerable<Type> BaseTypesAndSelf(this Type type)
		{
			return null;
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000668")]
		[Address(RVA = "0x5C38ED0", Offset = "0x5C37AD0", VA = "0x185C38ED0")]
		public static IEnumerable<Type> BaseTypes(this Type type)
		{
			return null;
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000669")]
		[Address(RVA = "0x5C39180", Offset = "0x5C37D80", VA = "0x185C39180")]
		public static object[] GetCustomAttributes(MemberInfo memberInfo, bool inherit)
		{
			return null;
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600066A")]
		public static T[] GetCustomAttributes<T>(this MemberInfo memberInfo)
		{
			return null;
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600066B")]
		public static T GetCustomAttribute<T>(this MemberInfo memberInfo)
		{
			return null;
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x000031AC File Offset: 0x000013AC
		[Token(Token = "0x600066C")]
		public static bool HasAttribute<T>(this MemberInfo memberInfo)
		{
			return default(bool);
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x000031C4 File Offset: 0x000013C4
		[Token(Token = "0x600066D")]
		[Address(RVA = "0x5C39960", Offset = "0x5C38560", VA = "0x185C39960")]
		public static bool HasAttribute(this MemberInfo memberInfo, Type attributeType)
		{
			return default(bool);
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x000031DC File Offset: 0x000013DC
		[Token(Token = "0x600066E")]
		[Address(RVA = "0x5C38F50", Offset = "0x5C37B50", VA = "0x185C38F50")]
		public static bool Contains(this LayerMask mask, int layer)
		{
			return default(bool);
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600066F")]
		[Address(RVA = "0x5C39500", Offset = "0x5C38100", VA = "0x185C39500")]
		private static Assembly[] GetLoadedAssemblies()
		{
			return null;
		}

		// Token: 0x0400037F RID: 895
		[Token(Token = "0x400037F")]
		[FieldOffset(Offset = "0x0")]
		private static Assembly[] m_AssembliesLookup;

		// Token: 0x04000380 RID: 896
		[Token(Token = "0x4000380")]
		[FieldOffset(Offset = "0x8")]
		private static Dictionary<string, Type> m_TypeLookup;

		// Token: 0x04000381 RID: 897
		[Token(Token = "0x4000381")]
		[FieldOffset(Offset = "0x10")]
		private static Dictionary<Type, FieldInfo[]> m_SerializedFieldInfoLookup;

		// Token: 0x04000382 RID: 898
		[Token(Token = "0x4000382")]
		[FieldOffset(Offset = "0x18")]
		private static readonly Dictionary<Type, MethodInfo[]> m_MethodInfoLookup;

		// Token: 0x04000383 RID: 899
		[Token(Token = "0x4000383")]
		[FieldOffset(Offset = "0x20")]
		private static readonly Dictionary<MemberInfo, object[]> m_MemberAttributeLookup;
	}
}
