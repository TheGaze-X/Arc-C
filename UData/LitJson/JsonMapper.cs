using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Il2CppDummyDll;

namespace UDatasdk.LitJson
{
	// Token: 0x0200001F RID: 31
	[Token(Token = "0x200001F")]
	public class JsonMapper
	{
		// Token: 0x060000E7 RID: 231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x55B5BB0", Offset = "0x55B47B0", VA = "0x1855B5BB0")]
		private static void AddArrayMetadata(Type type)
		{
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x55B5FE0", Offset = "0x55B4BE0", VA = "0x1855B5FE0")]
		private static void AddObjectMetadata(Type type)
		{
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x55B66D0", Offset = "0x55B52D0", VA = "0x1855B66D0")]
		private static void AddTypeProperties(Type type)
		{
		}

		// Token: 0x060000EA RID: 234 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x55B6B40", Offset = "0x55B5740", VA = "0x1855B6B40")]
		private static MethodInfo GetConvOp(Type t1, Type t2)
		{
			return null;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x55B7280", Offset = "0x55B5E80", VA = "0x1855B7280")]
		private static object ReadValue(Type inst_type, JsonReader reader)
		{
			return null;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x55B83D0", Offset = "0x55B6FD0", VA = "0x1855B83D0")]
		private static IJsonWrapper ReadValue(WrapperFactory factory, JsonReader reader)
		{
			return null;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x55B7120", Offset = "0x55B5D20", VA = "0x1855B7120")]
		private static void ReadSkip(JsonReader reader)
		{
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x55B8940", Offset = "0x55B7540", VA = "0x1855B8940")]
		private static void RegisterBaseExporters()
		{
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x55B94C0", Offset = "0x55B80C0", VA = "0x1855B94C0")]
		private static void RegisterBaseImporters()
		{
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x55BA630", Offset = "0x55B9230", VA = "0x1855BA630")]
		private static void RegisterImporter(IDictionary<Type, IDictionary<Type, ImporterFunc>> table, Type json_type, Type value_type, ImporterFunc importer)
		{
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x55BB3C0", Offset = "0x55B9FC0", VA = "0x1855BB3C0")]
		private static void WriteValue(object obj, JsonWriter writer, bool writer_is_private, int depth)
		{
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x55BA840", Offset = "0x55B9440", VA = "0x1855BA840")]
		public static string ToJson(object obj)
		{
			return null;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x55BA7D0", Offset = "0x55B93D0", VA = "0x1855BA7D0")]
		public static void ToJson(object obj, JsonWriter writer)
		{
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x55BADA0", Offset = "0x55B99A0", VA = "0x1855BADA0")]
		public static JsonData ToObject(JsonReader reader)
		{
			return null;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x55BAF90", Offset = "0x55B9B90", VA = "0x1855BAF90")]
		public static JsonData ToObject(TextReader reader)
		{
			return null;
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x55BAAD0", Offset = "0x55B96D0", VA = "0x1855BAAD0")]
		public static JsonData ToObject(string json)
		{
			return null;
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60000F7")]
		public static T ToObject<T>(JsonReader reader)
		{
			return null;
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60000F8")]
		public static T ToObject<T>(TextReader reader)
		{
			return null;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60000F9")]
		public static T ToObject<T>(string json)
		{
			return null;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x55BAD00", Offset = "0x55B9900", VA = "0x1855BAD00")]
		public static object ToObject(string json, Type ConvertType)
		{
			return null;
		}

		// Token: 0x060000FB RID: 251 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x55BB260", Offset = "0x55B9E60", VA = "0x1855BB260")]
		public static IJsonWrapper ToWrapper(WrapperFactory factory, JsonReader reader)
		{
			return null;
		}

		// Token: 0x060000FC RID: 252 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x55BB1C0", Offset = "0x55B9DC0", VA = "0x1855BB1C0")]
		public static IJsonWrapper ToWrapper(WrapperFactory factory, string json)
		{
			return null;
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FD")]
		public static void RegisterExporter<T>(ExporterFunc<T> exporter)
		{
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FE")]
		public static void RegisterImporter<TJson, TValue>(ImporterFunc<TJson, TValue> importer)
		{
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x55BB2C0", Offset = "0x55B9EC0", VA = "0x1855BB2C0")]
		public static void UnregisterExporters()
		{
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x55BB340", Offset = "0x55B9F40", VA = "0x1855BB340")]
		public static void UnregisterImporters()
		{
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public JsonMapper()
		{
		}

		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int max_nesting_depth;

		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x8")]
		private static readonly IFormatProvider datetime_format;

		// Token: 0x04000055 RID: 85
		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x10")]
		private static readonly IDictionary<Type, ExporterFunc> base_exporters_table;

		// Token: 0x04000056 RID: 86
		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x18")]
		private static readonly IDictionary<Type, ExporterFunc> custom_exporters_table;

		// Token: 0x04000057 RID: 87
		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x20")]
		private static readonly IDictionary<Type, IDictionary<Type, ImporterFunc>> base_importers_table;

		// Token: 0x04000058 RID: 88
		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x28")]
		private static readonly IDictionary<Type, IDictionary<Type, ImporterFunc>> custom_importers_table;

		// Token: 0x04000059 RID: 89
		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x30")]
		private static readonly IDictionary<Type, ArrayMetadata> array_metadata;

		// Token: 0x0400005A RID: 90
		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x38")]
		private static readonly object array_metadata_lock;

		// Token: 0x0400005B RID: 91
		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x40")]
		private static readonly IDictionary<Type, IDictionary<Type, MethodInfo>> conv_ops;

		// Token: 0x0400005C RID: 92
		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x48")]
		private static readonly object conv_ops_lock;

		// Token: 0x0400005D RID: 93
		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x50")]
		private static readonly IDictionary<Type, ObjectMetadata> object_metadata;

		// Token: 0x0400005E RID: 94
		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x58")]
		private static readonly object object_metadata_lock;

		// Token: 0x0400005F RID: 95
		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x60")]
		private static readonly IDictionary<Type, IList<PropertyMetadata>> type_properties;

		// Token: 0x04000060 RID: 96
		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x68")]
		private static readonly object type_properties_lock;

		// Token: 0x04000061 RID: 97
		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x70")]
		private static readonly JsonWriter static_writer;

		// Token: 0x04000062 RID: 98
		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x78")]
		private static readonly object static_writer_lock;
	}
}
