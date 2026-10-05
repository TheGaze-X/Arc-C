using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000070 RID: 112
	[Token(Token = "0x2000070")]
	[Preserve]
	internal static class ReflectionUtils
	{
		// Token: 0x060003EE RID: 1006 RVA: 0x000037C8 File Offset: 0x000019C8
		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x4D966F0", Offset = "0x4D952F0", VA = "0x184D966F0")]
		public static bool IsVirtual(this PropertyInfo propertyInfo)
		{
			return default(bool);
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x4D92A20", Offset = "0x4D91620", VA = "0x184D92A20")]
		public static MethodInfo GetBaseDefinition(this PropertyInfo propertyInfo)
		{
			return null;
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x000037E0 File Offset: 0x000019E0
		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x4D96670", Offset = "0x4D95270", VA = "0x184D96670")]
		public static bool IsPublic(PropertyInfo property)
		{
			return default(bool);
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x4D95080", Offset = "0x4D93C80", VA = "0x184D95080")]
		public static Type GetObjectType(object v)
		{
			return null;
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x4D953A0", Offset = "0x4D93FA0", VA = "0x184D953A0")]
		public static string GetTypeName(Type t, FormatterAssemblyStyle assemblyFormat, SerializationBinder binder)
		{
			return null;
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x4D967C0", Offset = "0x4D953C0", VA = "0x184D967C0")]
		private static string RemoveAssemblyDetails(string fullyQualifiedTypeName)
		{
			return null;
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x000037F8 File Offset: 0x000019F8
		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x4D955C0", Offset = "0x4D941C0", VA = "0x184D955C0")]
		public static bool HasDefaultConstructor(Type t, bool nonPublic)
		{
			return default(bool);
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x4D93520", Offset = "0x4D92120", VA = "0x184D93520")]
		public static ConstructorInfo GetDefaultConstructor(Type t)
		{
			return null;
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x4D933C0", Offset = "0x4D91FC0", VA = "0x184D933C0")]
		public static ConstructorInfo GetDefaultConstructor(Type t, bool nonPublic)
		{
			return null;
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00003810 File Offset: 0x00001A10
		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x4D96340", Offset = "0x4D94F40", VA = "0x184D96340")]
		public static bool IsNullable(Type t)
		{
			return default(bool);
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00003828 File Offset: 0x00001A28
		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x4D96210", Offset = "0x4D94E10", VA = "0x184D96210")]
		public static bool IsNullableType(Type t)
		{
			return default(bool);
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x4D92200", Offset = "0x4D90E00", VA = "0x184D92200")]
		public static Type EnsureNotNullableType(Type t)
		{
			return null;
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00003840 File Offset: 0x00001A40
		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x4D95E10", Offset = "0x4D94A10", VA = "0x184D95E10")]
		public static bool IsGenericDefinition(Type type, Type genericInterfaceDefinition)
		{
			return default(bool);
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00003858 File Offset: 0x00001A58
		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x4D959C0", Offset = "0x4D945C0", VA = "0x184D959C0")]
		public static bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition)
		{
			return default(bool);
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00003870 File Offset: 0x00001A70
		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x4D956B0", Offset = "0x4D942B0", VA = "0x184D956B0")]
		public static bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition, out Type implementingType)
		{
			return default(bool);
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00003888 File Offset: 0x00001A88
		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x4D95DA0", Offset = "0x4D949A0", VA = "0x184D95DA0")]
		public static bool InheritsGenericDefinition(Type type, Type genericClassDefinition)
		{
			return default(bool);
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x000038A0 File Offset: 0x00001AA0
		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x4D95BA0", Offset = "0x4D947A0", VA = "0x184D95BA0")]
		public static bool InheritsGenericDefinition(Type type, Type genericClassDefinition, out Type implementingType)
		{
			return default(bool);
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x000038B8 File Offset: 0x00001AB8
		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x4D95A30", Offset = "0x4D94630", VA = "0x184D95A30")]
		private static bool InheritsGenericDefinitionInternal(Type currentType, Type genericClassDefinition, out Type implementingType)
		{
			return default(bool);
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000400")]
		[Address(RVA = "0x4D93060", Offset = "0x4D91C60", VA = "0x184D93060")]
		public static Type GetCollectionItemType(Type type)
		{
			return null;
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000401")]
		[Address(RVA = "0x4D938C0", Offset = "0x4D924C0", VA = "0x184D938C0")]
		public static void GetDictionaryKeyValueTypes(Type dictionaryType, out Type keyType, out Type valueType)
		{
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000402")]
		[Address(RVA = "0x4D947E0", Offset = "0x4D933E0", VA = "0x184D947E0")]
		public static Type GetMemberUnderlyingType(MemberInfo member)
		{
			return null;
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x000038D0 File Offset: 0x00001AD0
		[Token(Token = "0x6000403")]
		[Address(RVA = "0x4D95F60", Offset = "0x4D94B60", VA = "0x184D95F60")]
		public static bool IsIndexedProperty(MemberInfo member)
		{
			return default(bool);
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x000038E8 File Offset: 0x00001AE8
		[Token(Token = "0x6000404")]
		[Address(RVA = "0x4D95EA0", Offset = "0x4D94AA0", VA = "0x184D95EA0")]
		public static bool IsIndexedProperty(PropertyInfo property)
		{
			return default(bool);
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000405")]
		[Address(RVA = "0x4D94BC0", Offset = "0x4D937C0", VA = "0x184D94BC0")]
		public static object GetMemberValue(MemberInfo member, object target)
		{
			return null;
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000406")]
		[Address(RVA = "0x4D96930", Offset = "0x4D95530", VA = "0x184D96930")]
		public static void SetMemberValue(MemberInfo member, object target, object value)
		{
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00003900 File Offset: 0x00001B00
		[Token(Token = "0x6000407")]
		[Address(RVA = "0x4D91E30", Offset = "0x4D90A30", VA = "0x184D91E30")]
		public static bool CanReadMemberValue(MemberInfo member, bool nonPublic)
		{
			return default(bool);
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x00003918 File Offset: 0x00001B18
		[Token(Token = "0x6000408")]
		[Address(RVA = "0x4D92000", Offset = "0x4D90C00", VA = "0x184D92000")]
		public static bool CanSetMemberValue(MemberInfo member, bool nonPublic, bool canSetReadOnly)
		{
			return default(bool);
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000409")]
		[Address(RVA = "0x4D93C40", Offset = "0x4D92840", VA = "0x184D93C40")]
		public static List<MemberInfo> GetFieldsAndProperties(Type type, BindingFlags bindingAttr)
		{
			return null;
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00003930 File Offset: 0x00001B30
		[Token(Token = "0x600040A")]
		[Address(RVA = "0x4D96410", Offset = "0x4D95010", VA = "0x184D96410")]
		private static bool IsOverridenGenericMember(MemberInfo memberInfo, BindingFlags bindingAttr)
		{
			return default(bool);
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600040B")]
		public static T GetAttribute<T>(object attributeProvider) where T : Attribute
		{
			return null;
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600040C")]
		public static T GetAttribute<T>(object attributeProvider, bool inherit) where T : Attribute
		{
			return null;
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600040D")]
		public static T[] GetAttributes<T>(object attributeProvider, bool inherit) where T : Attribute
		{
			return null;
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600040E")]
		[Address(RVA = "0x4D92330", Offset = "0x4D90F30", VA = "0x184D92330")]
		public static Attribute[] GetAttributes(object attributeProvider, Type attributeType, bool inherit)
		{
			return null;
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600040F")]
		[Address(RVA = "0x4D96D10", Offset = "0x4D95910", VA = "0x184D96D10")]
		public static void SplitFullyQualifiedTypeName(string fullyQualifiedTypeName, out string typeName, out string assemblyName)
		{
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x00003948 File Offset: 0x00001B48
		[Token(Token = "0x6000410")]
		[Address(RVA = "0x4D92260", Offset = "0x4D90E60", VA = "0x184D92260")]
		private static int? GetAssemblyDelimiterIndex(string fullyQualifiedTypeName)
		{
			return null;
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000411")]
		[Address(RVA = "0x4D94470", Offset = "0x4D93070", VA = "0x184D94470")]
		public static MemberInfo GetMemberInfoFromType(Type targetType, MemberInfo memberInfo)
		{
			return null;
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000412")]
		[Address(RVA = "0x4D94310", Offset = "0x4D92F10", VA = "0x184D94310")]
		public static IEnumerable<FieldInfo> GetFields(Type targetType, BindingFlags bindingAttr)
		{
			return null;
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000413")]
		[Address(RVA = "0x4D92B10", Offset = "0x4D91710", VA = "0x184D92B10")]
		private static void GetChildPrivateFields(IList<MemberInfo> initialFields, Type targetType, BindingFlags bindingAttr)
		{
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000414")]
		[Address(RVA = "0x4D95090", Offset = "0x4D93C90", VA = "0x184D95090")]
		public static IEnumerable<PropertyInfo> GetProperties(Type targetType, BindingFlags bindingAttr)
		{
			return null;
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x00003960 File Offset: 0x00001B60
		[Token(Token = "0x6000415")]
		[Address(RVA = "0x4D96920", Offset = "0x4D95520", VA = "0x184D96920")]
		public static BindingFlags RemoveFlag(this BindingFlags bindingAttr, BindingFlags flag)
		{
			return BindingFlags.Default;
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000416")]
		[Address(RVA = "0x4D92D30", Offset = "0x4D91930", VA = "0x184D92D30")]
		private static void GetChildPrivateProperties(IList<PropertyInfo> initialProperties, Type targetType, BindingFlags bindingAttr)
		{
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00003978 File Offset: 0x00001B78
		[Token(Token = "0x6000417")]
		[Address(RVA = "0x4D960E0", Offset = "0x4D94CE0", VA = "0x184D960E0")]
		public static bool IsMethodOverridden(Type currentType, Type methodDeclaringType, string method)
		{
			return default(bool);
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000418")]
		[Address(RVA = "0x4D93570", Offset = "0x4D92170", VA = "0x184D93570")]
		public static object GetDefaultValue(Type type)
		{
			return null;
		}

		// Token: 0x040001FA RID: 506
		[Token(Token = "0x40001FA")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Type[] EmptyTypes;
	}
}
