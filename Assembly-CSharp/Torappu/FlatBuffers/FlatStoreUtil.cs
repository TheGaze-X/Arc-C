using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Google.FlatBuffers;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using Torappu.DB;
using UnityEngine;

namespace Torappu.FlatBuffers
{
	// Token: 0x0200167F RID: 5759
	[Token(Token = "0x200167F")]
	public static class FlatStoreUtil
	{
		// Token: 0x060091D5 RID: 37333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60091D5")]
		[Address(RVA = "0x2B37960", Offset = "0x2B36560", VA = "0x182B37960")]
		public static JObject UnpackJObject(Table table, int offset, string defaultVal)
		{
			return null;
		}

		// Token: 0x060091D6 RID: 37334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60091D6")]
		public static T FromBsonString<T>(this string base64data)
		{
			return null;
		}

		// Token: 0x060091D7 RID: 37335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60091D7")]
		public static string ToBsonString<T>(this T value)
		{
			return null;
		}

		// Token: 0x060091D8 RID: 37336 RVA: 0x00038D90 File Offset: 0x00036F90
		[Token(Token = "0x60091D8")]
		[Address(RVA = "0x2B38EA0", Offset = "0x2B37AA0", VA = "0x182B38EA0")]
		public static Vector3 UnpackVector3(Table table, int offset)
		{
			return default(Vector3);
		}

		// Token: 0x060091D9 RID: 37337 RVA: 0x00038DA8 File Offset: 0x00036FA8
		[Token(Token = "0x60091D9")]
		[Address(RVA = "0x2B39360", Offset = "0x2B37F60", VA = "0x182B39360")]
		private static Vector3 _UnpackVector3(Table table)
		{
			return default(Vector3);
		}

		// Token: 0x060091DA RID: 37338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60091DA")]
		[Address(RVA = "0x2B38DD0", Offset = "0x2B379D0", VA = "0x182B38DD0")]
		public static List<Vector3> UnpackVector3List(Table table, int offset)
		{
			return null;
		}

		// Token: 0x060091DB RID: 37339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60091DB")]
		[Address(RVA = "0x2B38D00", Offset = "0x2B37900", VA = "0x182B38D00")]
		public static Vector3[] UnpackVector3Array(Table table, int offset)
		{
			return null;
		}

		// Token: 0x060091DC RID: 37340 RVA: 0x00038DC0 File Offset: 0x00036FC0
		[Token(Token = "0x60091DC")]
		[Address(RVA = "0x2B38AD0", Offset = "0x2B376D0", VA = "0x182B38AD0")]
		public static Vector2 UnpackVector2(Table table, int offset)
		{
			return default(Vector2);
		}

		// Token: 0x060091DD RID: 37341 RVA: 0x00038DD8 File Offset: 0x00036FD8
		[Token(Token = "0x60091DD")]
		[Address(RVA = "0x2B391E0", Offset = "0x2B37DE0", VA = "0x182B391E0")]
		private static Vector2 _UnpackVector2(Table table)
		{
			return default(Vector2);
		}

		// Token: 0x060091DE RID: 37342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60091DE")]
		[Address(RVA = "0x2B38A00", Offset = "0x2B37600", VA = "0x182B38A00")]
		public static List<Vector2> UnpackVector2List(Table table, int offset)
		{
			return null;
		}

		// Token: 0x060091DF RID: 37343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60091DF")]
		[Address(RVA = "0x2B38930", Offset = "0x2B37530", VA = "0x182B38930")]
		public static Vector2[] UnpackVector2Array(Table table, int offset)
		{
			return null;
		}

		// Token: 0x060091E0 RID: 37344 RVA: 0x00038DF0 File Offset: 0x00036FF0
		[Token(Token = "0x60091E0")]
		[Address(RVA = "0x2B372F0", Offset = "0x2B35EF0", VA = "0x182B372F0")]
		public static GridPosition UnpackGridPosition(Table table, int offset)
		{
			return default(GridPosition);
		}

		// Token: 0x060091E1 RID: 37345 RVA: 0x00038E08 File Offset: 0x00037008
		[Token(Token = "0x60091E1")]
		[Address(RVA = "0x2B39070", Offset = "0x2B37C70", VA = "0x182B39070")]
		private static GridPosition _UnpackTable2GridPosition(Table table)
		{
			return default(GridPosition);
		}

		// Token: 0x060091E2 RID: 37346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60091E2")]
		[Address(RVA = "0x2B37220", Offset = "0x2B35E20", VA = "0x182B37220")]
		public static List<GridPosition> UnpackGridPositionList(Table table, int offset)
		{
			return null;
		}

		// Token: 0x060091E3 RID: 37347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60091E3")]
		[Address(RVA = "0x2B37150", Offset = "0x2B35D50", VA = "0x182B37150")]
		public static GridPosition[] UnpackGridPositionArray(Table table, int offset)
		{
			return null;
		}

		// Token: 0x060091E4 RID: 37348 RVA: 0x00038E20 File Offset: 0x00037020
		[Token(Token = "0x60091E4")]
		[Address(RVA = "0x2B35E30", Offset = "0x2B34A30", VA = "0x182B35E30")]
		public static Table IndirectTo(ByteBuffer bb)
		{
			return default(Table);
		}

		// Token: 0x060091E5 RID: 37349 RVA: 0x00038E38 File Offset: 0x00037038
		[Token(Token = "0x60091E5")]
		[Address(RVA = "0x2B35E80", Offset = "0x2B34A80", VA = "0x182B35E80")]
		public static bool TryIndirectTo(Table table, int initOffset, out Table subTable)
		{
			return default(bool);
		}

		// Token: 0x060091E6 RID: 37350 RVA: 0x00038E50 File Offset: 0x00037050
		[Token(Token = "0x60091E6")]
		[Address(RVA = "0x2B365E0", Offset = "0x2B351E0", VA = "0x182B365E0")]
		public static bool UnpackBool(Table table, int offset, bool defaultVal)
		{
			return default(bool);
		}

		// Token: 0x060091E7 RID: 37351 RVA: 0x00038E68 File Offset: 0x00037068
		[Token(Token = "0x60091E7")]
		[Address(RVA = "0x2B366A0", Offset = "0x2B352A0", VA = "0x182B366A0")]
		public static byte UnpackByte(Table table, int offset, byte defaultVal)
		{
			return 0;
		}

		// Token: 0x060091E8 RID: 37352 RVA: 0x00038E80 File Offset: 0x00037080
		[Token(Token = "0x60091E8")]
		[Address(RVA = "0x2B378B0", Offset = "0x2B364B0", VA = "0x182B378B0")]
		public static int UnpackInt(Table table, int offset, int defaultVal)
		{
			return 0;
		}

		// Token: 0x060091E9 RID: 37353 RVA: 0x00038E98 File Offset: 0x00037098
		[Token(Token = "0x60091E9")]
		[Address(RVA = "0x2B37C60", Offset = "0x2B36860", VA = "0x182B37C60")]
		public static long UnpackLong(Table table, int offset, long defaultVal)
		{
			return 0L;
		}

		// Token: 0x060091EA RID: 37354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60091EA")]
		public static T UnpackEnum<T>(Table table, int offset, T defaultVal) where T : struct
		{
			return null;
		}

		// Token: 0x060091EB RID: 37355 RVA: 0x00038EB0 File Offset: 0x000370B0
		[Token(Token = "0x60091EB")]
		[Address(RVA = "0x2B370A0", Offset = "0x2B35CA0", VA = "0x182B370A0")]
		public static float UnpackFloat(Table table, int offset, float defaultVal)
		{
			return 0f;
		}

		// Token: 0x060091EC RID: 37356 RVA: 0x00038EC8 File Offset: 0x000370C8
		[Token(Token = "0x60091EC")]
		[Address(RVA = "0x2B36DC0", Offset = "0x2B359C0", VA = "0x182B36DC0")]
		public static double UnpackDouble(Table table, int offset, double defaultVal)
		{
			return 0.0;
		}

		// Token: 0x060091ED RID: 37357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60091ED")]
		[Address(RVA = "0x2B38880", Offset = "0x2B37480", VA = "0x182B38880")]
		public static string UnpackString(Table table, int offset, string defaultVal)
		{
			return null;
		}

		// Token: 0x060091EE RID: 37358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60091EE")]
		[Address(RVA = "0x2B37FB0", Offset = "0x2B36BB0", VA = "0x182B37FB0")]
		public static List<string> UnpackNestStringList(Table table)
		{
			return null;
		}

		// Token: 0x060091EF RID: 37359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60091EF")]
		[Address(RVA = "0x2B37D10", Offset = "0x2B36910", VA = "0x182B37D10")]
		public static int[] UnpackNestIntArray(Table table)
		{
			return null;
		}

		// Token: 0x060091F0 RID: 37360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60091F0")]
		[Address(RVA = "0x2B37DB0", Offset = "0x2B369B0", VA = "0x182B37DB0")]
		public static List<int> UnpackNestIntList(Table table)
		{
			return null;
		}

		// Token: 0x060091F1 RID: 37361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60091F1")]
		[Address(RVA = "0x2B363B0", Offset = "0x2B34FB0", VA = "0x182B363B0")]
		public static bool[] UnpackBoolArray(Table table, int offset)
		{
			return null;
		}

		// Token: 0x060091F2 RID: 37362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60091F2")]
		[Address(RVA = "0x2B36420", Offset = "0x2B35020", VA = "0x182B36420")]
		public static List<bool> UnpackBoolList(Table table, int offset)
		{
			return null;
		}

		// Token: 0x060091F3 RID: 37363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60091F3")]
		[Address(RVA = "0x2B36EE0", Offset = "0x2B35AE0", VA = "0x182B36EE0")]
		public static List<float> UnpackFloatList(Table table, int offset)
		{
			return null;
		}

		// Token: 0x060091F4 RID: 37364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60091F4")]
		[Address(RVA = "0x2B37AA0", Offset = "0x2B366A0", VA = "0x182B37AA0")]
		public static List<long> UnpackLongList(Table table, int offset)
		{
			return null;
		}

		// Token: 0x060091F5 RID: 37365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60091F5")]
		[Address(RVA = "0x2B36C00", Offset = "0x2B35800", VA = "0x182B36C00")]
		public static List<double> UnpackDoubleList(Table table, int offset)
		{
			return null;
		}

		// Token: 0x060091F6 RID: 37366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60091F6")]
		[Address(RVA = "0x2B37510", Offset = "0x2B36110", VA = "0x182B37510")]
		public static int[] UnpackIntArray(Table table, int offset)
		{
			return null;
		}

		// Token: 0x060091F7 RID: 37367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60091F7")]
		[Address(RVA = "0x2B37A30", Offset = "0x2B36630", VA = "0x182B37A30")]
		public static long[] UnpackLongArray(Table table, int offset)
		{
			return null;
		}

		// Token: 0x060091F8 RID: 37368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60091F8")]
		[Address(RVA = "0x2B36E70", Offset = "0x2B35A70", VA = "0x182B36E70")]
		public static float[] UnpackFloatArray(Table table, int offset)
		{
			return null;
		}

		// Token: 0x060091F9 RID: 37369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60091F9")]
		[Address(RVA = "0x2B36B90", Offset = "0x2B35790", VA = "0x182B36B90")]
		public static double[] UnpackDoubleArray(Table table, int offset)
		{
			return null;
		}

		// Token: 0x060091FA RID: 37370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60091FA")]
		public static T[] UnpackEnumArray<T>(Table table, int offset) where T : struct
		{
			return null;
		}

		// Token: 0x060091FB RID: 37371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60091FB")]
		[Address(RVA = "0x2B38410", Offset = "0x2B37010", VA = "0x182B38410")]
		public static string[] UnpackStringArray(Table table, int offset)
		{
			return null;
		}

		// Token: 0x060091FC RID: 37372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60091FC")]
		[Address(RVA = "0x2B38710", Offset = "0x2B37310", VA = "0x182B38710")]
		public static List<string> UnpackStringList(Table table, int offset)
		{
			return null;
		}

		// Token: 0x060091FD RID: 37373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60091FD")]
		[Address(RVA = "0x2B385A0", Offset = "0x2B371A0", VA = "0x182B385A0")]
		public static HashSet<string> UnpackStringHashSet(Table table, int offset)
		{
			return null;
		}

		// Token: 0x060091FE RID: 37374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60091FE")]
		[Address(RVA = "0x2B376F0", Offset = "0x2B362F0", VA = "0x182B376F0")]
		public static List<int> UnpackIntList(Table table, int offset)
		{
			return null;
		}

		// Token: 0x060091FF RID: 37375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60091FF")]
		[Address(RVA = "0x2B37580", Offset = "0x2B36180", VA = "0x182B37580")]
		public static HashSet<int> UnpackIntHashSet(Table table, int offset)
		{
			return null;
		}

		// Token: 0x06009200 RID: 37376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009200")]
		public static List<T> UnpackEnumList<T>(Table table, int offset) where T : struct
		{
			return null;
		}

		// Token: 0x06009201 RID: 37377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009201")]
		[Address(RVA = "0x2B38FA0", Offset = "0x2B37BA0", VA = "0x182B38FA0")]
		public static object Unpack(Type type, Table table, int offset)
		{
			return null;
		}

		// Token: 0x06009202 RID: 37378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009202")]
		[Address(RVA = "0x2B36750", Offset = "0x2B35350", VA = "0x182B36750")]
		public static object UnpackDirectly(Type type, Table table)
		{
			return null;
		}

		// Token: 0x06009203 RID: 37379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009203")]
		public static List<T> UnpackList<T>(Table table, int offset, [Optional] Func<Table, T> overrideUnpack)
		{
			return null;
		}

		// Token: 0x06009204 RID: 37380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009204")]
		public static List<T> UnpackValueTypeList<T>(Table table, int offset, Func<Table, T> unpack) where T : struct
		{
			return null;
		}

		// Token: 0x06009205 RID: 37381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009205")]
		public static T[] UnpackArray<T>(Table table, int offset)
		{
			return null;
		}

		// Token: 0x06009206 RID: 37382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009206")]
		public static T[] UnpackValueTypeArray<T>(Table table, int offset, Func<Table, T> unpack) where T : struct
		{
			return null;
		}

		// Token: 0x06009207 RID: 37383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009207")]
		[Address(RVA = "0x2B35FA0", Offset = "0x2B34BA0", VA = "0x182B35FA0")]
		public static short[,] Unpack2DShortArray(Table table, int offset, int row, int col)
		{
			return null;
		}

		// Token: 0x06009208 RID: 37384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009208")]
		[Address(RVA = "0x2B361D0", Offset = "0x2B34DD0", VA = "0x182B361D0")]
		public static short[,] Unpack2DShortArray(Table table, int offset)
		{
			return null;
		}

		// Token: 0x06009209 RID: 37385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009209")]
		public static HashSet<T> UnpackHashSet<T>(Table table, int offset)
		{
			return null;
		}

		// Token: 0x0600920A RID: 37386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600920A")]
		public static T UnpackIListBasedT<T, ItemT>(Table table, int offset) where T : IList<ItemT>, new()
		{
			return null;
		}

		// Token: 0x0600920B RID: 37387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600920B")]
		public static T UnpackDict<TKey, TValue, T>(Table table, int offset) where T : ICollection<KeyValuePair<TKey, TValue>>, new()
		{
			return null;
		}

		// Token: 0x0600920C RID: 37388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600920C")]
		[Address(RVA = "0x2B38150", Offset = "0x2B36D50", VA = "0x182B38150")]
		public static object UnpackRootDict(FlatLookupConverter.DictionaryConverter conv, Table table, int offset)
		{
			return null;
		}

		// Token: 0x040087FC RID: 34812
		[Token(Token = "0x40087FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Table DEFAULT_TABLE;

		// Token: 0x040087FD RID: 34813
		[Token(Token = "0x40087FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Obsolete]
		private static BsonNetConverter fixme_s_bsonConverter;
	}
}
