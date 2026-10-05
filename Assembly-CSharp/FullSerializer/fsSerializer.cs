using System;
using System.Collections.Generic;
using FullSerializer.Internal;
using Il2CppDummyDll;

namespace FullSerializer
{
	// Token: 0x02007B7C RID: 31612
	[Token(Token = "0x2007B7C")]
	public class fsSerializer
	{
		// Token: 0x0602C3ED RID: 181229 RVA: 0x000DEBB8 File Offset: 0x000DCDB8
		[Token(Token = "0x602C3ED")]
		[Address(RVA = "0x283A360", Offset = "0x2838F60", VA = "0x18283A360")]
		public static bool IsReservedKeyword(string key)
		{
			return default(bool);
		}

		// Token: 0x0602C3EE RID: 181230 RVA: 0x000DEBD0 File Offset: 0x000DCDD0
		[Token(Token = "0x602C3EE")]
		[Address(RVA = "0x283A2C0", Offset = "0x2838EC0", VA = "0x18283A2C0")]
		private static bool IsObjectReference(fsData data)
		{
			return default(bool);
		}

		// Token: 0x0602C3EF RID: 181231 RVA: 0x000DEBE8 File Offset: 0x000DCDE8
		[Token(Token = "0x602C3EF")]
		[Address(RVA = "0x283A220", Offset = "0x2838E20", VA = "0x18283A220")]
		private static bool IsObjectDefinition(fsData data)
		{
			return default(bool);
		}

		// Token: 0x0602C3F0 RID: 181232 RVA: 0x000DEC00 File Offset: 0x000DCE00
		[Token(Token = "0x602C3F0")]
		[Address(RVA = "0x283A480", Offset = "0x2839080", VA = "0x18283A480")]
		private static bool IsVersioned(fsData data)
		{
			return default(bool);
		}

		// Token: 0x0602C3F1 RID: 181233 RVA: 0x000DEC18 File Offset: 0x000DCE18
		[Token(Token = "0x602C3F1")]
		[Address(RVA = "0x283A3E0", Offset = "0x2838FE0", VA = "0x18283A3E0")]
		private static bool IsTypeSpecified(fsData data)
		{
			return default(bool);
		}

		// Token: 0x0602C3F2 RID: 181234 RVA: 0x000DEC30 File Offset: 0x000DCE30
		[Token(Token = "0x602C3F2")]
		[Address(RVA = "0x283A520", Offset = "0x2839120", VA = "0x18283A520")]
		private static bool IsWrappedData(fsData data)
		{
			return default(bool);
		}

		// Token: 0x0602C3F3 RID: 181235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C3F3")]
		[Address(RVA = "0x283A5C0", Offset = "0x28391C0", VA = "0x18283A5C0")]
		public static void StripDeserializationMetadata(ref fsData data)
		{
		}

		// Token: 0x0602C3F4 RID: 181236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C3F4")]
		[Address(RVA = "0x2836D20", Offset = "0x2835920", VA = "0x182836D20")]
		private static void ConvertLegacyData(ref fsData data)
		{
		}

		// Token: 0x0602C3F5 RID: 181237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C3F5")]
		[Address(RVA = "0x283A150", Offset = "0x2838D50", VA = "0x18283A150")]
		private static void Invoke_OnBeforeSerialize(List<fsObjectProcessor> processors, Type storageType, object instance)
		{
		}

		// Token: 0x0602C3F6 RID: 181238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C3F6")]
		[Address(RVA = "0x2839EE0", Offset = "0x2838AE0", VA = "0x182839EE0")]
		private static void Invoke_OnAfterSerialize(List<fsObjectProcessor> processors, Type storageType, object instance, ref fsData data)
		{
		}

		// Token: 0x0602C3F7 RID: 181239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C3F7")]
		[Address(RVA = "0x283A080", Offset = "0x2838C80", VA = "0x18283A080")]
		private static void Invoke_OnBeforeDeserialize(List<fsObjectProcessor> processors, Type storageType, ref fsData data)
		{
		}

		// Token: 0x0602C3F8 RID: 181240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C3F8")]
		[Address(RVA = "0x2839FB0", Offset = "0x2838BB0", VA = "0x182839FB0")]
		private static void Invoke_OnBeforeDeserializeAfterInstanceCreation(List<fsObjectProcessor> processors, Type storageType, object instance, ref fsData data)
		{
		}

		// Token: 0x0602C3F9 RID: 181241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C3F9")]
		[Address(RVA = "0x2839E10", Offset = "0x2838A10", VA = "0x182839E10")]
		private static void Invoke_OnAfterDeserialize(List<fsObjectProcessor> processors, Type storageType, object instance)
		{
		}

		// Token: 0x0602C3FA RID: 181242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C3FA")]
		[Address(RVA = "0x2837110", Offset = "0x2835D10", VA = "0x182837110")]
		private static void EnsureDictionary(fsData data)
		{
		}

		// Token: 0x0602C3FB RID: 181243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C3FB")]
		[Address(RVA = "0x283AF40", Offset = "0x2839B40", VA = "0x18283AF40")]
		public fsSerializer()
		{
		}

		// Token: 0x0602C3FC RID: 181244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C3FC")]
		[Address(RVA = "0x2836C80", Offset = "0x2835880", VA = "0x182836C80")]
		public void AddProcessor(fsObjectProcessor processor)
		{
		}

		// Token: 0x0602C3FD RID: 181245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C3FD")]
		public void RemoveProcessor<TProcessor>()
		{
		}

		// Token: 0x0602C3FE RID: 181246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C3FE")]
		[Address(RVA = "0x28377B0", Offset = "0x28363B0", VA = "0x1828377B0")]
		private List<fsObjectProcessor> GetProcessors(Type type)
		{
			return null;
		}

		// Token: 0x0602C3FF RID: 181247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C3FF")]
		[Address(RVA = "0x28368F0", Offset = "0x28354F0", VA = "0x1828368F0")]
		public void AddConverter(fsBaseConverter converter)
		{
		}

		// Token: 0x0602C400 RID: 181248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C400")]
		[Address(RVA = "0x2837290", Offset = "0x2835E90", VA = "0x182837290")]
		private fsBaseConverter GetConverter(Type type, Type overrideConverterType)
		{
			return null;
		}

		// Token: 0x0602C401 RID: 181249 RVA: 0x000DEC48 File Offset: 0x000DCE48
		[Token(Token = "0x602C401")]
		public fsResult TrySerialize<T>(T instance, out fsData data)
		{
			return default(fsResult);
		}

		// Token: 0x0602C402 RID: 181250 RVA: 0x000DEC60 File Offset: 0x000DCE60
		[Token(Token = "0x602C402")]
		public fsResult TryDeserialize<T>(fsData data, ref T instance)
		{
			return default(fsResult);
		}

		// Token: 0x0602C403 RID: 181251 RVA: 0x000DEC78 File Offset: 0x000DCE78
		[Token(Token = "0x602C403")]
		[Address(RVA = "0x283ADB0", Offset = "0x28399B0", VA = "0x18283ADB0")]
		public fsResult TrySerialize(Type storageType, object instance, out fsData data)
		{
			return default(fsResult);
		}

		// Token: 0x0602C404 RID: 181252 RVA: 0x000DEC90 File Offset: 0x000DCE90
		[Token(Token = "0x602C404")]
		[Address(RVA = "0x283AB30", Offset = "0x2839730", VA = "0x18283AB30")]
		public fsResult TrySerialize(Type storageType, Type overrideConverterType, object instance, out fsData data)
		{
			return default(fsResult);
		}

		// Token: 0x0602C405 RID: 181253 RVA: 0x000DECA8 File Offset: 0x000DCEA8
		[Token(Token = "0x602C405")]
		[Address(RVA = "0x2839190", Offset = "0x2837D90", VA = "0x182839190")]
		private fsResult InternalSerialize_1_ProcessCycles(Type storageType, Type overrideConverterType, object instance, out fsData data)
		{
			return default(fsResult);
		}

		// Token: 0x0602C406 RID: 181254 RVA: 0x000DECC0 File Offset: 0x000DCEC0
		[Token(Token = "0x602C406")]
		[Address(RVA = "0x28397F0", Offset = "0x28383F0", VA = "0x1828397F0")]
		private fsResult InternalSerialize_2_Inheritance(Type storageType, Type overrideConverterType, object instance, out fsData data)
		{
			return default(fsResult);
		}

		// Token: 0x0602C407 RID: 181255 RVA: 0x000DECD8 File Offset: 0x000DCED8
		[Token(Token = "0x602C407")]
		[Address(RVA = "0x2839A50", Offset = "0x2838650", VA = "0x182839A50")]
		private fsResult InternalSerialize_3_ProcessVersioning(Type overrideConverterType, object instance, out fsData data)
		{
			return default(fsResult);
		}

		// Token: 0x0602C408 RID: 181256 RVA: 0x000DECF0 File Offset: 0x000DCEF0
		[Token(Token = "0x602C408")]
		[Address(RVA = "0x2839D50", Offset = "0x2838950", VA = "0x182839D50")]
		private fsResult InternalSerialize_4_Converter(Type overrideConverterType, object instance, out fsData data)
		{
			return default(fsResult);
		}

		// Token: 0x0602C409 RID: 181257 RVA: 0x000DED08 File Offset: 0x000DCF08
		[Token(Token = "0x602C409")]
		[Address(RVA = "0x283A7E0", Offset = "0x28393E0", VA = "0x18283A7E0")]
		public fsResult TryDeserialize(fsData data, Type storageType, ref object result)
		{
			return default(fsResult);
		}

		// Token: 0x0602C40A RID: 181258 RVA: 0x000DED20 File Offset: 0x000DCF20
		[Token(Token = "0x602C40A")]
		[Address(RVA = "0x283A820", Offset = "0x2839420", VA = "0x18283A820")]
		public fsResult TryDeserialize(fsData data, Type storageType, Type overrideConverterType, ref object result)
		{
			return default(fsResult);
		}

		// Token: 0x0602C40B RID: 181259 RVA: 0x000DED38 File Offset: 0x000DCF38
		[Token(Token = "0x602C40B")]
		[Address(RVA = "0x2837AF0", Offset = "0x28366F0", VA = "0x182837AF0")]
		private fsResult InternalDeserialize_1_CycleReference(Type overrideConverterType, fsData data, Type storageType, ref object result, out List<fsObjectProcessor> processors)
		{
			return default(fsResult);
		}

		// Token: 0x0602C40C RID: 181260 RVA: 0x000DED50 File Offset: 0x000DCF50
		[Token(Token = "0x602C40C")]
		[Address(RVA = "0x2837E70", Offset = "0x2836A70", VA = "0x182837E70")]
		private fsResult InternalDeserialize_2_Version(Type overrideConverterType, fsData data, Type storageType, ref object result, out List<fsObjectProcessor> processors)
		{
			return default(fsResult);
		}

		// Token: 0x0602C40D RID: 181261 RVA: 0x000DED68 File Offset: 0x000DCF68
		[Token(Token = "0x602C40D")]
		[Address(RVA = "0x2838510", Offset = "0x2837110", VA = "0x182838510")]
		private fsResult InternalDeserialize_3_Inheritance(Type overrideConverterType, fsData data, Type storageType, ref object result, out List<fsObjectProcessor> processors)
		{
			return default(fsResult);
		}

		// Token: 0x0602C40E RID: 181262 RVA: 0x000DED80 File Offset: 0x000DCF80
		[Token(Token = "0x602C40E")]
		[Address(RVA = "0x2838C10", Offset = "0x2837810", VA = "0x182838C10")]
		private fsResult InternalDeserialize_4_Cycles(Type overrideConverterType, fsData data, Type resultType, ref object result)
		{
			return default(fsResult);
		}

		// Token: 0x0602C40F RID: 181263 RVA: 0x000DED98 File Offset: 0x000DCF98
		[Token(Token = "0x602C40F")]
		[Address(RVA = "0x2838FB0", Offset = "0x2837BB0", VA = "0x182838FB0")]
		private fsResult InternalDeserialize_5_Converter(Type overrideConverterType, fsData data, Type resultType, ref object result)
		{
			return default(fsResult);
		}

		// Token: 0x040401B9 RID: 262585
		[Token(Token = "0x40401B9")]
		[FieldOffset(Offset = "0x0")]
		private static HashSet<string> _reservedKeywords;

		// Token: 0x040401BA RID: 262586
		[Token(Token = "0x40401BA")]
		private const string Key_ObjectReference = "$ref";

		// Token: 0x040401BB RID: 262587
		[Token(Token = "0x40401BB")]
		private const string Key_ObjectDefinition = "$id";

		// Token: 0x040401BC RID: 262588
		[Token(Token = "0x40401BC")]
		private const string Key_InstanceType = "$type";

		// Token: 0x040401BD RID: 262589
		[Token(Token = "0x40401BD")]
		private const string Key_Version = "$version";

		// Token: 0x040401BE RID: 262590
		[Token(Token = "0x40401BE")]
		private const string Key_Content = "$content";

		// Token: 0x040401BF RID: 262591
		[Token(Token = "0x40401BF")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<Type, fsBaseConverter> _cachedConverterTypeInstances;

		// Token: 0x040401C0 RID: 262592
		[Token(Token = "0x40401C0")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<Type, fsBaseConverter> _cachedConverters;

		// Token: 0x040401C1 RID: 262593
		[Token(Token = "0x40401C1")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<Type, List<fsObjectProcessor>> _cachedProcessors;

		// Token: 0x040401C2 RID: 262594
		[Token(Token = "0x40401C2")]
		[FieldOffset(Offset = "0x28")]
		private readonly List<fsConverter> _availableConverters;

		// Token: 0x040401C3 RID: 262595
		[Token(Token = "0x40401C3")]
		[FieldOffset(Offset = "0x30")]
		private readonly Dictionary<Type, fsDirectConverter> _availableDirectConverters;

		// Token: 0x040401C4 RID: 262596
		[Token(Token = "0x40401C4")]
		[FieldOffset(Offset = "0x38")]
		private readonly List<fsObjectProcessor> _processors;

		// Token: 0x040401C5 RID: 262597
		[Token(Token = "0x40401C5")]
		[FieldOffset(Offset = "0x40")]
		private readonly fsCyclicReferenceManager _references;

		// Token: 0x040401C6 RID: 262598
		[Token(Token = "0x40401C6")]
		[FieldOffset(Offset = "0x48")]
		private readonly fsSerializer.fsLazyCycleDefinitionWriter _lazyReferenceWriter;

		// Token: 0x040401C7 RID: 262599
		[Token(Token = "0x40401C7")]
		[FieldOffset(Offset = "0x50")]
		public fsContext Context;

		// Token: 0x040401C8 RID: 262600
		[Token(Token = "0x40401C8")]
		[FieldOffset(Offset = "0x58")]
		public fsConfig Config;

		// Token: 0x02007B7D RID: 31613
		[Token(Token = "0x2007B7D")]
		internal class fsLazyCycleDefinitionWriter
		{
			// Token: 0x0602C410 RID: 181264 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C410")]
			[Address(RVA = "0x282FF20", Offset = "0x282EB20", VA = "0x18282FF20")]
			public void WriteDefinition(int id, fsData data)
			{
			}

			// Token: 0x0602C411 RID: 181265 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C411")]
			[Address(RVA = "0x28300B0", Offset = "0x282ECB0", VA = "0x1828300B0")]
			public void WriteReference(int id, Dictionary<string, fsData> dict)
			{
			}

			// Token: 0x0602C412 RID: 181266 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C412")]
			[Address(RVA = "0x282FEB0", Offset = "0x282EAB0", VA = "0x18282FEB0")]
			public void Clear()
			{
			}

			// Token: 0x0602C413 RID: 181267 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C413")]
			[Address(RVA = "0x2830300", Offset = "0x282EF00", VA = "0x182830300")]
			public fsLazyCycleDefinitionWriter()
			{
			}

			// Token: 0x040401C9 RID: 262601
			[Token(Token = "0x40401C9")]
			[FieldOffset(Offset = "0x10")]
			private Dictionary<int, fsData> _pendingDefinitions;

			// Token: 0x040401CA RID: 262602
			[Token(Token = "0x40401CA")]
			[FieldOffset(Offset = "0x18")]
			private HashSet<int> _references;
		}
	}
}
