using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200008A RID: 138
	[Token(Token = "0x200008A")]
	[Preserve]
	public class DefaultContractResolver : IContractResolver
	{
		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060004D4 RID: 1236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000CE")]
		internal static IContractResolver Instance
		{
			[Token(Token = "0x60004D4")]
			[Address(RVA = "0x4DA3030", Offset = "0x4DA1C30", VA = "0x184DA3030")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060004D5 RID: 1237 RVA: 0x00003FC0 File Offset: 0x000021C0
		[Token(Token = "0x170000CF")]
		public bool DynamicCodeGeneration
		{
			[Token(Token = "0x60004D5")]
			[Address(RVA = "0x4DA2FF0", Offset = "0x4DA1BF0", VA = "0x184DA2FF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060004D6 RID: 1238 RVA: 0x00003FD8 File Offset: 0x000021D8
		// (set) Token: 0x060004D7 RID: 1239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000D0")]
		[Obsolete("DefaultMembersSearchFlags is obsolete. To modify the members serialized inherit from DefaultContractResolver and override the GetSerializableMembers method instead.")]
		public BindingFlags DefaultMembersSearchFlags
		{
			[Token(Token = "0x60004D6")]
			[Address(RVA = "0x4EA880", Offset = "0x4E9480", VA = "0x1804EA880")]
			[CompilerGenerated]
			get
			{
				return BindingFlags.Default;
			}
			[Token(Token = "0x60004D7")]
			[Address(RVA = "0x4EAC10", Offset = "0x4E9810", VA = "0x1804EAC10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060004D8 RID: 1240 RVA: 0x00003FF0 File Offset: 0x000021F0
		// (set) Token: 0x060004D9 RID: 1241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000D1")]
		public bool SerializeCompilerGeneratedMembers
		{
			[Token(Token = "0x60004D8")]
			[Address(RVA = "0x4F1E20", Offset = "0x4F0A20", VA = "0x1804F1E20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004D9")]
			[Address(RVA = "0x4F1E30", Offset = "0x4F0A30", VA = "0x1804F1E30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060004DA RID: 1242 RVA: 0x00004008 File Offset: 0x00002208
		// (set) Token: 0x060004DB RID: 1243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000D2")]
		public bool IgnoreSerializableInterface
		{
			[Token(Token = "0x60004DA")]
			[Address(RVA = "0x4F61F0", Offset = "0x4F4DF0", VA = "0x1804F61F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004DB")]
			[Address(RVA = "0x4F6210", Offset = "0x4F4E10", VA = "0x1804F6210")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060004DC RID: 1244 RVA: 0x00004020 File Offset: 0x00002220
		// (set) Token: 0x060004DD RID: 1245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000D3")]
		public bool IgnoreSerializableAttribute
		{
			[Token(Token = "0x60004DC")]
			[Address(RVA = "0x1076980", Offset = "0x1075580", VA = "0x181076980")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004DD")]
			[Address(RVA = "0x1076990", Offset = "0x1075590", VA = "0x181076990")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x4DA2F70", Offset = "0x4DA1B70", VA = "0x184DA2F70")]
		public DefaultContractResolver()
		{
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x4DA2EE0", Offset = "0x4DA1AE0", VA = "0x184DA2EE0")]
		[Obsolete("DefaultContractResolver(bool) is obsolete. Use the parameterless constructor and cache instances of the contract resolver within your application for optimal performance.")]
		public DefaultContractResolver(bool shareCache)
		{
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x4DA02B0", Offset = "0x4D9EEB0", VA = "0x184DA02B0")]
		internal DefaultContractResolverState GetState()
		{
			return null;
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x4DA12F0", Offset = "0x4D9FEF0", VA = "0x184DA12F0", Slot = "5")]
		public virtual JsonContract ResolveContract(Type type)
		{
			return null;
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x4D9FB60", Offset = "0x4D9E760", VA = "0x184D9FB60", Slot = "6")]
		protected virtual List<MemberInfo> GetSerializableMembers(Type objectType)
		{
			return null;
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00004038 File Offset: 0x00002238
		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x4DA29F0", Offset = "0x4DA15F0", VA = "0x184DA29F0")]
		private bool ShouldSerializeEntityMember(MemberInfo memberInfo)
		{
			return default(bool);
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x4D9D390", Offset = "0x4D9BF90", VA = "0x184D9D390", Slot = "7")]
		protected virtual JsonObjectContract CreateObjectContract(Type objectType)
		{
			return null;
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x4D9F820", Offset = "0x4D9E420", VA = "0x184D9F820")]
		private MemberInfo GetExtensionDataMemberForType(Type type)
		{
			return null;
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x4DA15E0", Offset = "0x4DA01E0", VA = "0x184DA15E0")]
		private static void SetExtensionDataDelegates(JsonObjectContract contract, MemberInfo member)
		{
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x4D9E6A0", Offset = "0x4D9D2A0", VA = "0x184D9E6A0")]
		private ConstructorInfo GetAttributeConstructor(Type objectType)
		{
			return null;
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x4D9FA40", Offset = "0x4D9E640", VA = "0x184D9FA40")]
		private ConstructorInfo GetParameterizedConstructor(Type objectType)
		{
			return null;
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x4D9C510", Offset = "0x4D9B110", VA = "0x184D9C510", Slot = "8")]
		protected virtual IList<JsonProperty> CreateConstructorParameters(ConstructorInfo constructor, JsonPropertyCollection memberProperties)
		{
			return null;
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x4D9DDA0", Offset = "0x4D9C9A0", VA = "0x184D9DDA0", Slot = "9")]
		protected virtual JsonProperty CreatePropertyFromConstructorParameter(JsonProperty matchingMemberProperty, ParameterInfo parameterInfo)
		{
			return null;
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x4DA12A0", Offset = "0x4D9FEA0", VA = "0x184DA12A0", Slot = "10")]
		protected virtual JsonConverter ResolveContractConverter(Type objectType)
		{
			return null;
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x4D9F7B0", Offset = "0x4D9E3B0", VA = "0x184D9F7B0")]
		private Func<object> GetDefaultCreator(Type createdType)
		{
			return null;
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x4DA0320", Offset = "0x4D9EF20", VA = "0x184DA0320")]
		private void InitializeContract(JsonContract contract)
		{
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x4DA1100", Offset = "0x4D9FD00", VA = "0x184DA1100")]
		private void ResolveCallbackMethods(JsonContract contract, Type t)
		{
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x4D9EAF0", Offset = "0x4D9D6F0", VA = "0x184D9EAF0")]
		private void GetCallbackMethodsForType(Type type, out List<SerializationCallback> onSerializing, out List<SerializationCallback> onSerialized, out List<SerializationCallback> onDeserializing, out List<SerializationCallback> onDeserialized, out List<SerializationErrorCallback> onError)
		{
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x00004050 File Offset: 0x00002250
		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40")]
		private static bool ShouldSkipDeserialized(Type t)
		{
			return default(bool);
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x00004068 File Offset: 0x00002268
		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40")]
		private static bool ShouldSkipSerializing(Type t)
		{
			return default(bool);
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x4D9F490", Offset = "0x4D9E090", VA = "0x184D9F490")]
		private List<Type> GetClassHierarchyForType(Type type)
		{
			return null;
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x4D9CB80", Offset = "0x4D9B780", VA = "0x184D9CB80", Slot = "11")]
		protected virtual JsonDictionaryContract CreateDictionaryContract(Type objectType)
		{
			return null;
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x4D9C190", Offset = "0x4D9AD90", VA = "0x184D9C190", Slot = "12")]
		protected virtual JsonArrayContract CreateArrayContract(Type objectType)
		{
			return null;
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x4D9D870", Offset = "0x4D9C470", VA = "0x184D9D870", Slot = "13")]
		protected virtual JsonPrimitiveContract CreatePrimitiveContract(Type objectType)
		{
			return null;
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x4D9D2A0", Offset = "0x4D9BEA0", VA = "0x184D9D2A0", Slot = "14")]
		protected virtual JsonLinqContract CreateLinqContract(Type objectType)
		{
			return null;
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x4D9D050", Offset = "0x4D9BC50", VA = "0x184D9D050", Slot = "15")]
		protected virtual JsonISerializableContract CreateISerializableContract(Type objectType)
		{
			return null;
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x4D9E620", Offset = "0x4D9D220", VA = "0x184D9E620", Slot = "16")]
		protected virtual JsonStringContract CreateStringContract(Type objectType)
		{
			return null;
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x4D9C700", Offset = "0x4D9B300", VA = "0x184D9C700", Slot = "17")]
		protected virtual JsonContract CreateContract(Type objectType)
		{
			return null;
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x00004080 File Offset: 0x00002280
		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x4DA08D0", Offset = "0x4D9F4D0", VA = "0x184DA08D0")]
		internal static bool IsJsonPrimitiveType(Type t)
		{
			return default(bool);
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x00004098 File Offset: 0x00002298
		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x4DA0700", Offset = "0x4D9F300", VA = "0x184DA0700")]
		internal static bool IsIConvertible(Type t)
		{
			return default(bool);
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x000040B0 File Offset: 0x000022B0
		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x4D9BF10", Offset = "0x4D9AB10", VA = "0x184D9BF10")]
		internal static bool CanConvertToString(Type type)
		{
			return default(bool);
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x000040C8 File Offset: 0x000022C8
		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x4DA0930", Offset = "0x4D9F530", VA = "0x184DA0930")]
		private static bool IsValidCallback(MethodInfo method, ParameterInfo[] parameters, Type attributeType, MethodInfo currentCallback, ref Type prevAttributeType)
		{
			return default(bool);
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x4D9F5B0", Offset = "0x4D9E1B0", VA = "0x184D9F5B0")]
		internal static string GetClrTypeFullName(Type type)
		{
			return null;
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x4D9D9B0", Offset = "0x4D9C5B0", VA = "0x184D9D9B0", Slot = "18")]
		protected virtual IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
		{
			return null;
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000500")]
		[Address(RVA = "0x4D9D330", Offset = "0x4D9BF30", VA = "0x184D9D330", Slot = "19")]
		protected virtual IValueProvider CreateMemberValueProvider(MemberInfo member)
		{
			return null;
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000501")]
		[Address(RVA = "0x4D9E120", Offset = "0x4D9CD20", VA = "0x184D9E120", Slot = "20")]
		protected virtual JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
		{
			return null;
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000502")]
		[Address(RVA = "0x4DA2450", Offset = "0x4DA1050", VA = "0x184DA2450")]
		private void SetPropertySettingsFromAttributes(JsonProperty property, object attributeProvider, string name, Type declaringType, MemberSerialization memberSerialization, out bool allowNonPublicAccess)
		{
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000503")]
		[Address(RVA = "0x4D9E3C0", Offset = "0x4D9CFC0", VA = "0x184D9E3C0")]
		private Predicate<object> CreateShouldSerializeTest(MemberInfo member)
		{
			return null;
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000504")]
		[Address(RVA = "0x4DA2100", Offset = "0x4DA0D00", VA = "0x184DA2100")]
		private void SetIsSpecifiedActions(JsonProperty property, MemberInfo member, bool allowNonPublicAccess)
		{
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000505")]
		[Address(RVA = "0x5B5210", Offset = "0x5B3E10", VA = "0x1805B5210", Slot = "21")]
		protected virtual string ResolvePropertyName(string propertyName)
		{
			return null;
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000506")]
		[Address(RVA = "0x4D9FB10", Offset = "0x4D9E710", VA = "0x184D9FB10", Slot = "22")]
		protected virtual string ResolveDictionaryKey(string dictionaryKey)
		{
			return null;
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000507")]
		[Address(RVA = "0x4D9FB10", Offset = "0x4D9E710", VA = "0x184D9FB10")]
		public string GetResolvedPropertyName(string propertyName)
		{
			return null;
		}

		// Token: 0x04000227 RID: 551
		[Token(Token = "0x4000227")]
		[FieldOffset(Offset = "0x0")]
		private static readonly IContractResolver _instance;

		// Token: 0x04000228 RID: 552
		[Token(Token = "0x4000228")]
		[FieldOffset(Offset = "0x8")]
		private static readonly JsonConverter[] BuiltInConverters;

		// Token: 0x04000229 RID: 553
		[Token(Token = "0x4000229")]
		[FieldOffset(Offset = "0x10")]
		private static readonly object TypeContractCacheLock;

		// Token: 0x0400022A RID: 554
		[Token(Token = "0x400022A")]
		[FieldOffset(Offset = "0x18")]
		private static readonly DefaultContractResolverState _sharedState;

		// Token: 0x0400022B RID: 555
		[Token(Token = "0x400022B")]
		[FieldOffset(Offset = "0x10")]
		private readonly DefaultContractResolverState _instanceState;

		// Token: 0x0400022C RID: 556
		[Token(Token = "0x400022C")]
		[FieldOffset(Offset = "0x18")]
		private readonly bool _sharedCache;

		// Token: 0x0200008B RID: 139
		[Token(Token = "0x200008B")]
		internal class EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue> : IEnumerable<KeyValuePair<object, object>>, IEnumerable
		{
			// Token: 0x06000509 RID: 1289 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000509")]
			public EnumerableDictionaryWrapper(IEnumerable<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> e)
			{
			}

			// Token: 0x0600050A RID: 1290 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600050A")]
			public IEnumerator<KeyValuePair<object, object>> GetEnumerator()
			{
				return null;
			}

			// Token: 0x0600050B RID: 1291 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600050B")]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x04000231 RID: 561
			[Token(Token = "0x4000231")]
			[FieldOffset(Offset = "0x0")]
			private readonly IEnumerable<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> _e;
		}
	}
}
