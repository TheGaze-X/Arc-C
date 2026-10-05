using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Il2CppDummyDll;

namespace LitJson
{
	// Token: 0x02000484 RID: 1156
	[Token(Token = "0x2000484")]
	public class JsonMapper
	{
		// Token: 0x06002523 RID: 9507 RVA: 0x00010038 File Offset: 0x0000E238
		[Token(Token = "0x6002523")]
		[Address(RVA = "0x53918A0", Offset = "0x53904A0", VA = "0x1853918A0")]
		private static bool HasInterface(Type type, string name)
		{
			return default(bool);
		}

		// Token: 0x06002524 RID: 9508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002524")]
		[Address(RVA = "0x5391880", Offset = "0x5390480", VA = "0x185391880")]
		public static PropertyInfo[] GetPublicInstanceProperties(Type type)
		{
			return null;
		}

		// Token: 0x06002525 RID: 9509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002525")]
		[Address(RVA = "0x5390220", Offset = "0x538EE20", VA = "0x185390220")]
		private static void AddArrayMetadata(Type type)
		{
		}

		// Token: 0x06002526 RID: 9510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002526")]
		[Address(RVA = "0x53906C0", Offset = "0x538F2C0", VA = "0x1853906C0")]
		private static void AddObjectMetadata(Type type)
		{
		}

		// Token: 0x06002527 RID: 9511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002527")]
		[Address(RVA = "0x5390E20", Offset = "0x538FA20", VA = "0x185390E20")]
		private static void AddTypeProperties(Type type)
		{
		}

		// Token: 0x06002528 RID: 9512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002528")]
		[Address(RVA = "0x53912A0", Offset = "0x538FEA0", VA = "0x1853912A0")]
		private static MethodInfo GetConvOp(Type t1, Type t2)
		{
			return null;
		}

		// Token: 0x06002529 RID: 9513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002529")]
		[Address(RVA = "0x5392090", Offset = "0x5390C90", VA = "0x185392090")]
		private static object ReadValue(Type inst_type, JsonReader reader)
		{
			return null;
		}

		// Token: 0x0600252A RID: 9514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600252A")]
		[Address(RVA = "0x5391AA0", Offset = "0x53906A0", VA = "0x185391AA0")]
		private static IJsonWrapper ReadValue(WrapperFactory factory, JsonReader reader)
		{
			return null;
		}

		// Token: 0x0600252B RID: 9515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600252B")]
		[Address(RVA = "0x5391940", Offset = "0x5390540", VA = "0x185391940")]
		private static void ReadSkip(JsonReader reader)
		{
		}

		// Token: 0x0600252C RID: 9516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600252C")]
		[Address(RVA = "0x5393380", Offset = "0x5391F80", VA = "0x185393380")]
		private static void RegisterBaseExporters()
		{
		}

		// Token: 0x0600252D RID: 9517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600252D")]
		[Address(RVA = "0x5393F00", Offset = "0x5392B00", VA = "0x185393F00")]
		private static void RegisterBaseImporters()
		{
		}

		// Token: 0x0600252E RID: 9518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600252E")]
		[Address(RVA = "0x5394E10", Offset = "0x5393A10", VA = "0x185394E10")]
		private static void RegisterImporter(IDictionary<Type, IDictionary<Type, ImporterFunc>> table, Type json_type, Type value_type, ImporterFunc importer)
		{
		}

		// Token: 0x0600252F RID: 9519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600252F")]
		[Address(RVA = "0x5395B80", Offset = "0x5394780", VA = "0x185395B80")]
		private static void WriteValue(object obj, JsonWriter writer, bool writer_is_private, int depth)
		{
		}

		// Token: 0x06002530 RID: 9520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002530")]
		[Address(RVA = "0x5394FB0", Offset = "0x5393BB0", VA = "0x185394FB0")]
		public static string ToJson(object obj)
		{
			return null;
		}

		// Token: 0x06002531 RID: 9521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002531")]
		[Address(RVA = "0x5395240", Offset = "0x5393E40", VA = "0x185395240")]
		public static void ToJson(object obj, JsonWriter writer)
		{
		}

		// Token: 0x06002532 RID: 9522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002532")]
		[Address(RVA = "0x53952B0", Offset = "0x5393EB0", VA = "0x1853952B0")]
		public static JsonData ToObject(JsonReader reader)
		{
			return null;
		}

		// Token: 0x06002533 RID: 9523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002533")]
		[Address(RVA = "0x53954A0", Offset = "0x53940A0", VA = "0x1853954A0")]
		public static JsonData ToObject(TextReader reader)
		{
			return null;
		}

		// Token: 0x06002534 RID: 9524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002534")]
		[Address(RVA = "0x53956D0", Offset = "0x53942D0", VA = "0x1853956D0")]
		public static JsonData ToObject(string json)
		{
			return null;
		}

		// Token: 0x06002535 RID: 9525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002535")]
		public static T ToObject<T>(JsonReader reader)
		{
			return null;
		}

		// Token: 0x06002536 RID: 9526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002536")]
		public static T ToObject<T>(TextReader reader)
		{
			return null;
		}

		// Token: 0x06002537 RID: 9527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002537")]
		public static T ToObject<T>(string json)
		{
			return null;
		}

		// Token: 0x06002538 RID: 9528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002538")]
		[Address(RVA = "0x5395A20", Offset = "0x5394620", VA = "0x185395A20")]
		public static IJsonWrapper ToWrapper(WrapperFactory factory, JsonReader reader)
		{
			return null;
		}

		// Token: 0x06002539 RID: 9529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002539")]
		[Address(RVA = "0x5395930", Offset = "0x5394530", VA = "0x185395930")]
		public static IJsonWrapper ToWrapper(WrapperFactory factory, string json)
		{
			return null;
		}

		// Token: 0x0600253A RID: 9530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600253A")]
		public static void RegisterExporter<T>(ExporterFunc<T> exporter)
		{
		}

		// Token: 0x0600253B RID: 9531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600253B")]
		public static void RegisterImporter<TJson, TValue>(ImporterFunc<TJson, TValue> importer)
		{
		}

		// Token: 0x0600253C RID: 9532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600253C")]
		[Address(RVA = "0x5395A80", Offset = "0x5394680", VA = "0x185395A80")]
		public static void UnregisterExporters()
		{
		}

		// Token: 0x0600253D RID: 9533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600253D")]
		[Address(RVA = "0x5395B00", Offset = "0x5394700", VA = "0x185395B00")]
		public static void UnregisterImporters()
		{
		}

		// Token: 0x0600253E RID: 9534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600253E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public JsonMapper()
		{
		}

		// Token: 0x040014B0 RID: 5296
		[Token(Token = "0x40014B0")]
		[FieldOffset(Offset = "0x0")]
		private static int max_nesting_depth;

		// Token: 0x040014B1 RID: 5297
		[Token(Token = "0x40014B1")]
		[FieldOffset(Offset = "0x8")]
		private static IFormatProvider datetime_format;

		// Token: 0x040014B2 RID: 5298
		[Token(Token = "0x40014B2")]
		[FieldOffset(Offset = "0x10")]
		private static IDictionary<Type, ExporterFunc> base_exporters_table;

		// Token: 0x040014B3 RID: 5299
		[Token(Token = "0x40014B3")]
		[FieldOffset(Offset = "0x18")]
		private static IDictionary<Type, ExporterFunc> custom_exporters_table;

		// Token: 0x040014B4 RID: 5300
		[Token(Token = "0x40014B4")]
		[FieldOffset(Offset = "0x20")]
		private static IDictionary<Type, IDictionary<Type, ImporterFunc>> base_importers_table;

		// Token: 0x040014B5 RID: 5301
		[Token(Token = "0x40014B5")]
		[FieldOffset(Offset = "0x28")]
		private static IDictionary<Type, IDictionary<Type, ImporterFunc>> custom_importers_table;

		// Token: 0x040014B6 RID: 5302
		[Token(Token = "0x40014B6")]
		[FieldOffset(Offset = "0x30")]
		private static IDictionary<Type, ArrayMetadata> array_metadata;

		// Token: 0x040014B7 RID: 5303
		[Token(Token = "0x40014B7")]
		[FieldOffset(Offset = "0x38")]
		private static readonly object array_metadata_lock;

		// Token: 0x040014B8 RID: 5304
		[Token(Token = "0x40014B8")]
		[FieldOffset(Offset = "0x40")]
		private static IDictionary<Type, IDictionary<Type, MethodInfo>> conv_ops;

		// Token: 0x040014B9 RID: 5305
		[Token(Token = "0x40014B9")]
		[FieldOffset(Offset = "0x48")]
		private static readonly object conv_ops_lock;

		// Token: 0x040014BA RID: 5306
		[Token(Token = "0x40014BA")]
		[FieldOffset(Offset = "0x50")]
		private static IDictionary<Type, ObjectMetadata> object_metadata;

		// Token: 0x040014BB RID: 5307
		[Token(Token = "0x40014BB")]
		[FieldOffset(Offset = "0x58")]
		private static readonly object object_metadata_lock;

		// Token: 0x040014BC RID: 5308
		[Token(Token = "0x40014BC")]
		[FieldOffset(Offset = "0x60")]
		private static IDictionary<Type, IList<PropertyMetadata>> type_properties;

		// Token: 0x040014BD RID: 5309
		[Token(Token = "0x40014BD")]
		[FieldOffset(Offset = "0x68")]
		private static readonly object type_properties_lock;

		// Token: 0x040014BE RID: 5310
		[Token(Token = "0x40014BE")]
		[FieldOffset(Offset = "0x70")]
		private static JsonWriter static_writer;

		// Token: 0x040014BF RID: 5311
		[Token(Token = "0x40014BF")]
		[FieldOffset(Offset = "0x78")]
		private static readonly object static_writer_lock;
	}
}
