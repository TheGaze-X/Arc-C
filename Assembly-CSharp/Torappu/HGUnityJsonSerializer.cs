using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Torappu
{
	// Token: 0x020013E4 RID: 5092
	[Token(Token = "0x20013E4")]
	public static class HGUnityJsonSerializer
	{
		// Token: 0x17000E32 RID: 3634
		// (get) Token: 0x06007438 RID: 29752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E32")]
		public static JsonSerializerSettings serializerSettings
		{
			[Token(Token = "0x6007438")]
			[Address(RVA = "0x22063C0", Offset = "0x2204FC0", VA = "0x1822063C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E33 RID: 3635
		// (get) Token: 0x06007439 RID: 29753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E33")]
		public static JsonSerializer serializer
		{
			[Token(Token = "0x6007439")]
			[Address(RVA = "0x2206410", Offset = "0x2205010", VA = "0x182206410")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600743A RID: 29754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600743A")]
		[Address(RVA = "0x2206150", Offset = "0x2204D50", VA = "0x182206150")]
		public static string SerializeToJson(object obj, Type declaredType)
		{
			return null;
		}

		// Token: 0x0600743B RID: 29755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600743B")]
		public static T DeserializeFromJson<T>(string json)
		{
			return null;
		}

		// Token: 0x0600743C RID: 29756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600743C")]
		public static string SerializeUsingFI<T>(T value)
		{
			return null;
		}

		// Token: 0x0600743D RID: 29757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600743D")]
		public static T DeserializeUsingFI<T>(string json)
		{
			return null;
		}

		// Token: 0x040071C0 RID: 29120
		[Token(Token = "0x40071C0")]
		[FieldOffset(Offset = "0x0")]
		private static readonly JsonSerializerSettings s_settings;

		// Token: 0x040071C1 RID: 29121
		[Token(Token = "0x40071C1")]
		[FieldOffset(Offset = "0x8")]
		private static JsonSerializer s_serializer;

		// Token: 0x020013E5 RID: 5093
		[Token(Token = "0x20013E5")]
		public class UnityLikeShouldSerializeContractResolver : DefaultContractResolver
		{
			// Token: 0x0600743F RID: 29759 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600743F")]
			[Address(RVA = "0x2216240", Offset = "0x2214E40", VA = "0x182216240", Slot = "20")]
			protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
			{
				return null;
			}

			// Token: 0x06007440 RID: 29760 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007440")]
			[Address(RVA = "0x2216800", Offset = "0x2215400", VA = "0x182216800", Slot = "6")]
			protected override List<MemberInfo> GetSerializableMembers(Type type)
			{
				return null;
			}

			// Token: 0x06007441 RID: 29761 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007441")]
			[Address(RVA = "0x2216590", Offset = "0x2215190", VA = "0x182216590")]
			private static void GetDeclaredMembers(Type declaredType, List<MemberInfo> membersToFill)
			{
			}

			// Token: 0x06007442 RID: 29762 RVA: 0x00033B58 File Offset: 0x00031D58
			[Token(Token = "0x6007442")]
			[Address(RVA = "0x22168A0", Offset = "0x22154A0", VA = "0x1822168A0")]
			private static bool HasAttribute(MemberInfo element, Type attributeType)
			{
				return default(bool);
			}

			// Token: 0x06007443 RID: 29763 RVA: 0x00033B70 File Offset: 0x00031D70
			[Token(Token = "0x6007443")]
			private static bool HasAttribute<TAttribute>(MemberInfo element)
			{
				return default(bool);
			}

			// Token: 0x06007444 RID: 29764 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007444")]
			[Address(RVA = "0x2216250", Offset = "0x2214E50", VA = "0x182216250")]
			public static Attribute GetAttribute(MemberInfo element, Type attributeType, bool shouldCache)
			{
				return null;
			}

			// Token: 0x06007445 RID: 29765 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007445")]
			[Address(RVA = "0x2216230", Offset = "0x2214E30", VA = "0x182216230", Slot = "12")]
			protected override JsonArrayContract CreateArrayContract(Type objectType)
			{
				return null;
			}

			// Token: 0x06007446 RID: 29766 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007446")]
			[Address(RVA = "0x22169F0", Offset = "0x22155F0", VA = "0x1822169F0")]
			public UnityLikeShouldSerializeContractResolver()
			{
			}

			// Token: 0x040071C2 RID: 29122
			[Token(Token = "0x40071C2")]
			[FieldOffset(Offset = "0x0")]
			private static BindingFlags s_bindingFlags;

			// Token: 0x040071C3 RID: 29123
			[Token(Token = "0x40071C3")]
			[FieldOffset(Offset = "0x8")]
			private static IDictionary<HGUnityJsonSerializer.UnityLikeShouldSerializeContractResolver.AttributeQuery, Attribute> s_cachedAttributeQueries;

			// Token: 0x020013E6 RID: 5094
			[Token(Token = "0x20013E6")]
			private struct AttributeQuery
			{
				// Token: 0x040071C4 RID: 29124
				[Token(Token = "0x40071C4")]
				[FieldOffset(Offset = "0x0")]
				public MemberInfo MemberInfo;

				// Token: 0x040071C5 RID: 29125
				[Token(Token = "0x40071C5")]
				[FieldOffset(Offset = "0x8")]
				public Type AttributeType;
			}

			// Token: 0x020013E7 RID: 5095
			[Token(Token = "0x20013E7")]
			private class AttributeQueryComparator : IEqualityComparer<HGUnityJsonSerializer.UnityLikeShouldSerializeContractResolver.AttributeQuery>
			{
				// Token: 0x06007448 RID: 29768 RVA: 0x00033B88 File Offset: 0x00031D88
				[Token(Token = "0x6007448")]
				[Address(RVA = "0x21FEDD0", Offset = "0x21FD9D0", VA = "0x1821FEDD0", Slot = "4")]
				public bool Equals(HGUnityJsonSerializer.UnityLikeShouldSerializeContractResolver.AttributeQuery x, HGUnityJsonSerializer.UnityLikeShouldSerializeContractResolver.AttributeQuery y)
				{
					return default(bool);
				}

				// Token: 0x06007449 RID: 29769 RVA: 0x00033BA0 File Offset: 0x00031DA0
				[Token(Token = "0x6007449")]
				[Address(RVA = "0x21FEE50", Offset = "0x21FDA50", VA = "0x1821FEE50", Slot = "5")]
				public int GetHashCode(HGUnityJsonSerializer.UnityLikeShouldSerializeContractResolver.AttributeQuery obj)
				{
					return 0;
				}

				// Token: 0x0600744A RID: 29770 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600744A")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public AttributeQueryComparator()
				{
				}
			}
		}
	}
}
