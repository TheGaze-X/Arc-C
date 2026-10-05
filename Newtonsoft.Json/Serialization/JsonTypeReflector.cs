using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.Serialization;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020000B0 RID: 176
	[Token(Token = "0x20000B0")]
	[Preserve]
	internal static class JsonTypeReflector
	{
		// Token: 0x060006A4 RID: 1700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006A4")]
		public static T GetCachedAttribute<T>(object attributeProvider) where T : Attribute
		{
			return null;
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x4DDA050", Offset = "0x4DD8C50", VA = "0x184DDA050")]
		public static DataContractAttribute GetDataContractAttribute(Type type)
		{
			return null;
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x4DDA0E0", Offset = "0x4DD8CE0", VA = "0x184DDA0E0")]
		public static DataMemberAttribute GetDataMemberAttribute(MemberInfo memberInfo)
		{
			return null;
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x000049B0 File Offset: 0x00002BB0
		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x4DDA620", Offset = "0x4DD9220", VA = "0x184DDA620")]
		public static MemberSerialization GetObjectMemberSerialization(Type objectType, bool ignoreSerializableAttribute)
		{
			return MemberSerialization.OptOut;
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x4DDA550", Offset = "0x4DD9150", VA = "0x184DDA550")]
		public static JsonConverter GetJsonConverter(object attributeProvider)
		{
			return null;
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x4DD9CA0", Offset = "0x4DD88A0", VA = "0x184DD9CA0")]
		public static JsonConverter CreateJsonConverterInstance(Type converterType, object[] converterArgs)
		{
			return null;
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x4DDA3A0", Offset = "0x4DD8FA0", VA = "0x184DDA3A0")]
		private static Func<object[], JsonConverter> GetJsonConverterCreator(Type converterType)
		{
			return null;
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x4DDA7A0", Offset = "0x4DD93A0", VA = "0x184DDA7A0")]
		public static TypeConverter GetTypeConverter(Type type)
		{
			return null;
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x4DD9FD0", Offset = "0x4DD8BD0", VA = "0x184DD9FD0")]
		private static Type GetAssociatedMetadataType(Type type)
		{
			return null;
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x4DD9D40", Offset = "0x4DD8940", VA = "0x184DD9D40")]
		private static Type GetAssociateMetadataTypeFromAttribute(Type type)
		{
			return null;
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006AE")]
		private static T GetAttribute<T>(Type type) where T : Attribute
		{
			return null;
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006AF")]
		private static T GetAttribute<T>(MemberInfo memberInfo) where T : Attribute
		{
			return null;
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006B0")]
		public static T GetAttribute<T>(object provider) where T : Attribute
		{
			return null;
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060006B1 RID: 1713 RVA: 0x000049C8 File Offset: 0x00002BC8
		[Token(Token = "0x17000148")]
		public static bool DynamicCodeGeneration
		{
			[Token(Token = "0x60006B1")]
			[Address(RVA = "0x4DDA990", Offset = "0x4DD9590", VA = "0x184DDA990")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060006B2 RID: 1714 RVA: 0x000049E0 File Offset: 0x00002BE0
		[Token(Token = "0x17000149")]
		public static bool FullyTrusted
		{
			[Token(Token = "0x60006B2")]
			[Address(RVA = "0x4DDAC00", Offset = "0x4DD9800", VA = "0x184DDAC00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060006B3 RID: 1715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700014A")]
		public static ReflectionDelegateFactory ReflectionDelegateFactory
		{
			[Token(Token = "0x60006B3")]
			[Address(RVA = "0x4DDAD90", Offset = "0x4DD9990", VA = "0x184DDAD90")]
			get
			{
				return null;
			}
		}

		// Token: 0x040002D7 RID: 727
		[Token(Token = "0x40002D7")]
		[FieldOffset(Offset = "0x0")]
		private static bool? _dynamicCodeGeneration;

		// Token: 0x040002D8 RID: 728
		[Token(Token = "0x40002D8")]
		[FieldOffset(Offset = "0x2")]
		private static bool? _fullyTrusted;

		// Token: 0x040002D9 RID: 729
		[Token(Token = "0x40002D9")]
		public const string IdPropertyName = "$id";

		// Token: 0x040002DA RID: 730
		[Token(Token = "0x40002DA")]
		public const string RefPropertyName = "$ref";

		// Token: 0x040002DB RID: 731
		[Token(Token = "0x40002DB")]
		public const string TypePropertyName = "$type";

		// Token: 0x040002DC RID: 732
		[Token(Token = "0x40002DC")]
		public const string ValuePropertyName = "$value";

		// Token: 0x040002DD RID: 733
		[Token(Token = "0x40002DD")]
		public const string ArrayValuesPropertyName = "$values";

		// Token: 0x040002DE RID: 734
		[Token(Token = "0x40002DE")]
		public const string ShouldSerializePrefix = "ShouldSerialize";

		// Token: 0x040002DF RID: 735
		[Token(Token = "0x40002DF")]
		public const string SpecifiedPostfix = "Specified";

		// Token: 0x040002E0 RID: 736
		[Token(Token = "0x40002E0")]
		[FieldOffset(Offset = "0x8")]
		private static readonly ThreadSafeStore<Type, Func<object[], JsonConverter>> JsonConverterCreatorCache;

		// Token: 0x040002E1 RID: 737
		[Token(Token = "0x40002E1")]
		[FieldOffset(Offset = "0x10")]
		private static readonly ThreadSafeStore<Type, Type> AssociatedMetadataTypesCache;

		// Token: 0x040002E2 RID: 738
		[Token(Token = "0x40002E2")]
		[FieldOffset(Offset = "0x18")]
		private static ReflectionObject _metadataTypeAttributeReflectionObject;
	}
}
