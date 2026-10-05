using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Il2CppDummyDll;

namespace YoStar.SDK.LitJson
{
	// Token: 0x020002F0 RID: 752
	[Token(Token = "0x20002F0")]
	public class JsonMapper
	{
		// Token: 0x0600111B RID: 4379 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600111B")]
		[Address(RVA = "0x5CD6D50", Offset = "0x5CD5950", VA = "0x185CD6D50")]
		private static void AddArrayMetadata(Type type)
		{
		}

		// Token: 0x0600111C RID: 4380 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600111C")]
		[Address(RVA = "0x5CD7180", Offset = "0x5CD5D80", VA = "0x185CD7180")]
		private static void AddObjectMetadata(Type type)
		{
		}

		// Token: 0x0600111D RID: 4381 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600111D")]
		[Address(RVA = "0x5CD7870", Offset = "0x5CD6470", VA = "0x185CD7870")]
		private static void AddTypeProperties(Type type)
		{
		}

		// Token: 0x0600111E RID: 4382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600111E")]
		[Address(RVA = "0x5CD7CE0", Offset = "0x5CD68E0", VA = "0x185CD7CE0")]
		private static MethodInfo GetConvOp(Type t1, Type t2)
		{
			return null;
		}

		// Token: 0x0600111F RID: 4383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600111F")]
		[Address(RVA = "0x5CD8410", Offset = "0x5CD7010", VA = "0x185CD8410")]
		private static object ReadValue(Type inst_type, JsonReader reader)
		{
			return null;
		}

		// Token: 0x06001120 RID: 4384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001120")]
		[Address(RVA = "0x5CD9560", Offset = "0x5CD8160", VA = "0x185CD9560")]
		private static IJsonWrapper ReadValue(WrapperFactory factory, JsonReader reader)
		{
			return null;
		}

		// Token: 0x06001121 RID: 4385 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001121")]
		[Address(RVA = "0x5CD82B0", Offset = "0x5CD6EB0", VA = "0x185CD82B0")]
		private static void ReadSkip(JsonReader reader)
		{
		}

		// Token: 0x06001122 RID: 4386 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001122")]
		[Address(RVA = "0x5CD9AD0", Offset = "0x5CD86D0", VA = "0x185CD9AD0")]
		private static void RegisterBaseExporters()
		{
		}

		// Token: 0x06001123 RID: 4387 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001123")]
		[Address(RVA = "0x5CDA650", Offset = "0x5CD9250", VA = "0x185CDA650")]
		private static void RegisterBaseImporters()
		{
		}

		// Token: 0x06001124 RID: 4388 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001124")]
		[Address(RVA = "0x5CDB7C0", Offset = "0x5CDA3C0", VA = "0x185CDB7C0")]
		private static void RegisterImporter(IDictionary<Type, IDictionary<Type, ImporterFunc>> table, Type json_type, Type value_type, ImporterFunc importer)
		{
		}

		// Token: 0x06001125 RID: 4389 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001125")]
		[Address(RVA = "0x5CDC470", Offset = "0x5CDB070", VA = "0x185CDC470")]
		private static void WriteValue(object obj, JsonWriter writer, bool writer_is_private, int depth)
		{
		}

		// Token: 0x06001126 RID: 4390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001126")]
		[Address(RVA = "0x5CDB9D0", Offset = "0x5CDA5D0", VA = "0x185CDB9D0")]
		public static string ToJson(object obj)
		{
			return null;
		}

		// Token: 0x06001127 RID: 4391 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001127")]
		[Address(RVA = "0x5CDB960", Offset = "0x5CDA560", VA = "0x185CDB960")]
		public static void ToJson(object obj, JsonWriter writer)
		{
		}

		// Token: 0x06001128 RID: 4392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001128")]
		[Address(RVA = "0x5CDBE50", Offset = "0x5CDAA50", VA = "0x185CDBE50")]
		public static JsonData ToObject(JsonReader reader)
		{
			return null;
		}

		// Token: 0x06001129 RID: 4393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001129")]
		[Address(RVA = "0x5CDC040", Offset = "0x5CDAC40", VA = "0x185CDC040")]
		public static JsonData ToObject(TextReader reader)
		{
			return null;
		}

		// Token: 0x0600112A RID: 4394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600112A")]
		[Address(RVA = "0x5CDBB80", Offset = "0x5CDA780", VA = "0x185CDBB80")]
		public static JsonData ToObject(string json)
		{
			return null;
		}

		// Token: 0x0600112B RID: 4395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600112B")]
		public static T ToObject<T>(JsonReader reader)
		{
			return null;
		}

		// Token: 0x0600112C RID: 4396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600112C")]
		public static T ToObject<T>(TextReader reader)
		{
			return null;
		}

		// Token: 0x0600112D RID: 4397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600112D")]
		public static T ToObject<T>(string json)
		{
			return null;
		}

		// Token: 0x0600112E RID: 4398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600112E")]
		[Address(RVA = "0x5CDBDB0", Offset = "0x5CDA9B0", VA = "0x185CDBDB0")]
		public static object ToObject(string json, Type ConvertType)
		{
			return null;
		}

		// Token: 0x0600112F RID: 4399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600112F")]
		[Address(RVA = "0x5CDC270", Offset = "0x5CDAE70", VA = "0x185CDC270")]
		public static IJsonWrapper ToWrapper(WrapperFactory factory, JsonReader reader)
		{
			return null;
		}

		// Token: 0x06001130 RID: 4400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001130")]
		[Address(RVA = "0x5CDC2D0", Offset = "0x5CDAED0", VA = "0x185CDC2D0")]
		public static IJsonWrapper ToWrapper(WrapperFactory factory, string json)
		{
			return null;
		}

		// Token: 0x06001131 RID: 4401 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001131")]
		public static void RegisterExporter<T>(ExporterFunc<T> exporter)
		{
		}

		// Token: 0x06001132 RID: 4402 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001132")]
		public static void RegisterImporter<TJson, TValue>(ImporterFunc<TJson, TValue> importer)
		{
		}

		// Token: 0x06001133 RID: 4403 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001133")]
		[Address(RVA = "0x5CDC370", Offset = "0x5CDAF70", VA = "0x185CDC370")]
		public static void UnregisterExporters()
		{
		}

		// Token: 0x06001134 RID: 4404 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001134")]
		[Address(RVA = "0x5CDC3F0", Offset = "0x5CDAFF0", VA = "0x185CDC3F0")]
		public static void UnregisterImporters()
		{
		}

		// Token: 0x06001135 RID: 4405 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001135")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public JsonMapper()
		{
		}

		// Token: 0x04000DEB RID: 3563
		[Token(Token = "0x4000DEB")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int max_nesting_depth;

		// Token: 0x04000DEC RID: 3564
		[Token(Token = "0x4000DEC")]
		[FieldOffset(Offset = "0x8")]
		private static readonly IFormatProvider datetime_format;

		// Token: 0x04000DED RID: 3565
		[Token(Token = "0x4000DED")]
		[FieldOffset(Offset = "0x10")]
		private static readonly IDictionary<Type, ExporterFunc> base_exporters_table;

		// Token: 0x04000DEE RID: 3566
		[Token(Token = "0x4000DEE")]
		[FieldOffset(Offset = "0x18")]
		private static readonly IDictionary<Type, ExporterFunc> custom_exporters_table;

		// Token: 0x04000DEF RID: 3567
		[Token(Token = "0x4000DEF")]
		[FieldOffset(Offset = "0x20")]
		private static readonly IDictionary<Type, IDictionary<Type, ImporterFunc>> base_importers_table;

		// Token: 0x04000DF0 RID: 3568
		[Token(Token = "0x4000DF0")]
		[FieldOffset(Offset = "0x28")]
		private static readonly IDictionary<Type, IDictionary<Type, ImporterFunc>> custom_importers_table;

		// Token: 0x04000DF1 RID: 3569
		[Token(Token = "0x4000DF1")]
		[FieldOffset(Offset = "0x30")]
		private static readonly IDictionary<Type, ArrayMetadata> array_metadata;

		// Token: 0x04000DF2 RID: 3570
		[Token(Token = "0x4000DF2")]
		[FieldOffset(Offset = "0x38")]
		private static readonly object array_metadata_lock;

		// Token: 0x04000DF3 RID: 3571
		[Token(Token = "0x4000DF3")]
		[FieldOffset(Offset = "0x40")]
		private static readonly IDictionary<Type, IDictionary<Type, MethodInfo>> conv_ops;

		// Token: 0x04000DF4 RID: 3572
		[Token(Token = "0x4000DF4")]
		[FieldOffset(Offset = "0x48")]
		private static readonly object conv_ops_lock;

		// Token: 0x04000DF5 RID: 3573
		[Token(Token = "0x4000DF5")]
		[FieldOffset(Offset = "0x50")]
		private static readonly IDictionary<Type, ObjectMetadata> object_metadata;

		// Token: 0x04000DF6 RID: 3574
		[Token(Token = "0x4000DF6")]
		[FieldOffset(Offset = "0x58")]
		private static readonly object object_metadata_lock;

		// Token: 0x04000DF7 RID: 3575
		[Token(Token = "0x4000DF7")]
		[FieldOffset(Offset = "0x60")]
		private static readonly IDictionary<Type, IList<PropertyMetadata>> type_properties;

		// Token: 0x04000DF8 RID: 3576
		[Token(Token = "0x4000DF8")]
		[FieldOffset(Offset = "0x68")]
		private static readonly object type_properties_lock;

		// Token: 0x04000DF9 RID: 3577
		[Token(Token = "0x4000DF9")]
		[FieldOffset(Offset = "0x70")]
		private static readonly JsonWriter static_writer;

		// Token: 0x04000DFA RID: 3578
		[Token(Token = "0x4000DFA")]
		[FieldOffset(Offset = "0x78")]
		private static readonly object static_writer_lock;
	}
}
