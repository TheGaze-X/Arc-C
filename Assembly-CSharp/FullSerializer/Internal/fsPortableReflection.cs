using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;

namespace FullSerializer.Internal
{
	// Token: 0x02007B97 RID: 31639
	[Token(Token = "0x2007B97")]
	public static class fsPortableReflection
	{
		// Token: 0x0602C4A4 RID: 181412 RVA: 0x000DF578 File Offset: 0x000DD778
		[Token(Token = "0x602C4A4")]
		[Address(RVA = "0x2833770", Offset = "0x2832370", VA = "0x182833770")]
		public static bool HasAttribute(MemberInfo element, Type attributeType)
		{
			return default(bool);
		}

		// Token: 0x0602C4A5 RID: 181413 RVA: 0x000DF590 File Offset: 0x000DD790
		[Token(Token = "0x602C4A5")]
		public static bool HasAttribute<TAttribute>(MemberInfo element)
		{
			return default(bool);
		}

		// Token: 0x0602C4A6 RID: 181414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C4A6")]
		[Address(RVA = "0x2832510", Offset = "0x2831110", VA = "0x182832510")]
		public static Attribute GetAttribute(MemberInfo element, Type attributeType, bool shouldCache)
		{
			return null;
		}

		// Token: 0x0602C4A7 RID: 181415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C4A7")]
		public static TAttribute GetAttribute<TAttribute>(MemberInfo element, bool shouldCache) where TAttribute : Attribute
		{
			return null;
		}

		// Token: 0x0602C4A8 RID: 181416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C4A8")]
		public static TAttribute GetAttribute<TAttribute>(MemberInfo element) where TAttribute : Attribute
		{
			return null;
		}

		// Token: 0x170067AF RID: 26543
		// (get) Token: 0x0602C4A9 RID: 181417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170067AF")]
		private static IDictionary<fsPortableReflection.AttributeQuery, Attribute> _cachedAttributeQueries
		{
			[Token(Token = "0x602C4A9")]
			[Address(RVA = "0x2833920", Offset = "0x2832520", VA = "0x182833920")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602C4AA RID: 181418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C4AA")]
		[Address(RVA = "0x2833000", Offset = "0x2831C00", VA = "0x182833000")]
		public static PropertyInfo GetDeclaredProperty(this Type type, string propertyName)
		{
			return null;
		}

		// Token: 0x0602C4AB RID: 181419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C4AB")]
		[Address(RVA = "0x2832D60", Offset = "0x2831960", VA = "0x182832D60")]
		public static MethodInfo GetDeclaredMethod(this Type type, string methodName)
		{
			return null;
		}

		// Token: 0x0602C4AC RID: 181420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C4AC")]
		[Address(RVA = "0x2832840", Offset = "0x2831440", VA = "0x182832840")]
		public static ConstructorInfo GetDeclaredConstructor(this Type type, Type[] parameters)
		{
			return null;
		}

		// Token: 0x0602C4AD RID: 181421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C4AD")]
		[Address(RVA = "0x2832A20", Offset = "0x2831620", VA = "0x182832A20")]
		public static ConstructorInfo[] GetDeclaredConstructors(this Type type)
		{
			return null;
		}

		// Token: 0x0602C4AE RID: 181422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C4AE")]
		[Address(RVA = "0x2833160", Offset = "0x2831D60", VA = "0x182833160")]
		public static MemberInfo[] GetFlattenedMember(this Type type, string memberName)
		{
			return null;
		}

		// Token: 0x0602C4AF RID: 181423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C4AF")]
		[Address(RVA = "0x2833380", Offset = "0x2831F80", VA = "0x182833380")]
		public static MethodInfo GetFlattenedMethod(this Type type, string methodName)
		{
			return null;
		}

		// Token: 0x0602C4B0 RID: 181424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C4B0")]
		[Address(RVA = "0x2833530", Offset = "0x2832130", VA = "0x182833530")]
		public static IEnumerable<MethodInfo> GetFlattenedMethods(this Type type, string methodName)
		{
			return null;
		}

		// Token: 0x0602C4B1 RID: 181425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C4B1")]
		[Address(RVA = "0x28335C0", Offset = "0x28321C0", VA = "0x1828335C0")]
		public static PropertyInfo GetFlattenedProperty(this Type type, string propertyName)
		{
			return null;
		}

		// Token: 0x0602C4B2 RID: 181426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C4B2")]
		[Address(RVA = "0x2832B60", Offset = "0x2831760", VA = "0x182832B60")]
		public static MemberInfo GetDeclaredMember(this Type type, string memberName)
		{
			return null;
		}

		// Token: 0x0602C4B3 RID: 181427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C4B3")]
		[Address(RVA = "0x2832EC0", Offset = "0x2831AC0", VA = "0x182832EC0")]
		public static MethodInfo[] GetDeclaredMethods(this Type type)
		{
			return null;
		}

		// Token: 0x0602C4B4 RID: 181428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C4B4")]
		[Address(RVA = "0x2832F60", Offset = "0x2831B60", VA = "0x182832F60")]
		public static PropertyInfo[] GetDeclaredProperties(this Type type)
		{
			return null;
		}

		// Token: 0x0602C4B5 RID: 181429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C4B5")]
		[Address(RVA = "0x2832AC0", Offset = "0x28316C0", VA = "0x182832AC0")]
		public static FieldInfo[] GetDeclaredFields(this Type type)
		{
			return null;
		}

		// Token: 0x0602C4B6 RID: 181430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C4B6")]
		[Address(RVA = "0x2832CC0", Offset = "0x28318C0", VA = "0x182832CC0")]
		public static MemberInfo[] GetDeclaredMembers(this Type type)
		{
			return null;
		}

		// Token: 0x0602C4B7 RID: 181431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C4B7")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		public static MemberInfo AsMemberInfo(Type type)
		{
			return null;
		}

		// Token: 0x0602C4B8 RID: 181432 RVA: 0x000DF5A8 File Offset: 0x000DD7A8
		[Token(Token = "0x602C4B8")]
		[Address(RVA = "0x28337E0", Offset = "0x28323E0", VA = "0x1828337E0")]
		public static bool IsType(MemberInfo member)
		{
			return default(bool);
		}

		// Token: 0x0602C4B9 RID: 181433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C4B9")]
		[Address(RVA = "0x2832460", Offset = "0x2831060", VA = "0x182832460")]
		public static Type AsType(MemberInfo member)
		{
			return null;
		}

		// Token: 0x0602C4BA RID: 181434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C4BA")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		public static Type Resolve(this Type type)
		{
			return null;
		}

		// Token: 0x040401E0 RID: 262624
		[Token(Token = "0x40401E0")]
		[FieldOffset(Offset = "0x0")]
		public static Type[] EmptyTypes;

		// Token: 0x040401E1 RID: 262625
		[Token(Token = "0x40401E1")]
		[ThreadStatic]
		private static IDictionary<fsPortableReflection.AttributeQuery, Attribute> _cachedAttributeQueriesImpl;

		// Token: 0x040401E2 RID: 262626
		[Token(Token = "0x40401E2")]
		[FieldOffset(Offset = "0x8")]
		private static BindingFlags DeclaredFlags;

		// Token: 0x02007B98 RID: 31640
		[Token(Token = "0x2007B98")]
		private struct AttributeQuery
		{
			// Token: 0x040401E3 RID: 262627
			[Token(Token = "0x40401E3")]
			[FieldOffset(Offset = "0x0")]
			public MemberInfo MemberInfo;

			// Token: 0x040401E4 RID: 262628
			[Token(Token = "0x40401E4")]
			[FieldOffset(Offset = "0x8")]
			public Type AttributeType;
		}

		// Token: 0x02007B99 RID: 31641
		[Token(Token = "0x2007B99")]
		private class AttributeQueryComparator : IEqualityComparer<fsPortableReflection.AttributeQuery>
		{
			// Token: 0x0602C4BC RID: 181436 RVA: 0x000DF5C0 File Offset: 0x000DD7C0
			[Token(Token = "0x602C4BC")]
			[Address(RVA = "0x2853BF0", Offset = "0x28527F0", VA = "0x182853BF0", Slot = "4")]
			public bool Equals(fsPortableReflection.AttributeQuery x, fsPortableReflection.AttributeQuery y)
			{
				return default(bool);
			}

			// Token: 0x0602C4BD RID: 181437 RVA: 0x000DF5D8 File Offset: 0x000DD7D8
			[Token(Token = "0x602C4BD")]
			[Address(RVA = "0x21FEE50", Offset = "0x21FDA50", VA = "0x1821FEE50", Slot = "5")]
			public int GetHashCode(fsPortableReflection.AttributeQuery obj)
			{
				return 0;
			}

			// Token: 0x0602C4BE RID: 181438 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C4BE")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AttributeQueryComparator()
			{
			}
		}
	}
}
