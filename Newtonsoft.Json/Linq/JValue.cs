using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000E0 RID: 224
	[Token(Token = "0x20000E0")]
	[Preserve]
	public class JValue : JToken, IFormattable, IComparable, IConvertible
	{
		// Token: 0x06000938 RID: 2360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000938")]
		[Address(RVA = "0x4DE67F0", Offset = "0x4DE53F0", VA = "0x184DE67F0")]
		internal JValue(object value, JTokenType type)
		{
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000939")]
		[Address(RVA = "0x4DE6870", Offset = "0x4DE5470", VA = "0x184DE6870")]
		public JValue(JValue other)
		{
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600093A")]
		[Address(RVA = "0x4DE6530", Offset = "0x4DE5130", VA = "0x184DE6530")]
		public JValue(long value)
		{
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600093B")]
		[Address(RVA = "0x4DE6DC0", Offset = "0x4DE59C0", VA = "0x184DE6DC0")]
		public JValue(decimal value)
		{
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600093C")]
		[Address(RVA = "0x4DE6B30", Offset = "0x4DE5730", VA = "0x184DE6B30")]
		public JValue(char value)
		{
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600093D")]
		[Address(RVA = "0x4DE6480", Offset = "0x4DE5080", VA = "0x184DE6480")]
		[CLSCompliant(false)]
		public JValue(ulong value)
		{
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600093E")]
		[Address(RVA = "0x4DE65E0", Offset = "0x4DE51E0", VA = "0x184DE65E0")]
		public JValue(double value)
		{
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600093F")]
		[Address(RVA = "0x4DE6A80", Offset = "0x4DE5680", VA = "0x184DE6A80")]
		public JValue(float value)
		{
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000940")]
		[Address(RVA = "0x4DE6740", Offset = "0x4DE5340", VA = "0x184DE6740")]
		public JValue(DateTime value)
		{
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000941")]
		[Address(RVA = "0x4DE6E70", Offset = "0x4DE5A70", VA = "0x184DE6E70")]
		public JValue(DateTimeOffset value)
		{
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000942")]
		[Address(RVA = "0x4DE6690", Offset = "0x4DE5290", VA = "0x184DE6690")]
		public JValue(bool value)
		{
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000943")]
		[Address(RVA = "0x4DE6BE0", Offset = "0x4DE57E0", VA = "0x184DE6BE0")]
		public JValue(string value)
		{
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000944")]
		[Address(RVA = "0x4DE6D10", Offset = "0x4DE5910", VA = "0x184DE6D10")]
		public JValue(Guid value)
		{
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000945")]
		[Address(RVA = "0x4DE6C50", Offset = "0x4DE5850", VA = "0x184DE6C50")]
		public JValue(Uri value)
		{
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000946")]
		[Address(RVA = "0x4DE6950", Offset = "0x4DE5550", VA = "0x184DE6950")]
		public JValue(TimeSpan value)
		{
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000947")]
		[Address(RVA = "0x4DE6A00", Offset = "0x4DE5600", VA = "0x184DE6A00")]
		public JValue(object value)
		{
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x00005760 File Offset: 0x00003960
		[Token(Token = "0x6000948")]
		[Address(RVA = "0x4DE49B0", Offset = "0x4DE35B0", VA = "0x184DE49B0", Slot = "12")]
		internal override bool DeepEquals(JToken node)
		{
			return default(bool);
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000949 RID: 2377 RVA: 0x00005778 File Offset: 0x00003978
		[Token(Token = "0x170001AC")]
		public override bool HasValues
		{
			[Token(Token = "0x6000949")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x00005790 File Offset: 0x00003990
		[Token(Token = "0x600094A")]
		[Address(RVA = "0x4DE3C90", Offset = "0x4DE2890", VA = "0x184DE3C90")]
		internal static int Compare(JTokenType valueType, object objA, object objB)
		{
			return 0;
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x000057A8 File Offset: 0x000039A8
		[Token(Token = "0x600094B")]
		[Address(RVA = "0x4DE3B90", Offset = "0x4DE2790", VA = "0x184DE3B90")]
		private static int CompareFloat(object objA, object objB)
		{
			return 0;
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600094C")]
		[Address(RVA = "0x4DE3A70", Offset = "0x4DE2670", VA = "0x184DE3A70", Slot = "11")]
		internal override JToken CloneToken()
		{
			return null;
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600094D")]
		[Address(RVA = "0x4DE4710", Offset = "0x4DE3310", VA = "0x184DE4710")]
		public static JValue CreateComment(string value)
		{
			return null;
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600094E")]
		[Address(RVA = "0x4DE4860", Offset = "0x4DE3460", VA = "0x184DE4860")]
		public static JValue CreateString(string value)
		{
			return null;
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600094F")]
		[Address(RVA = "0x4DE47C0", Offset = "0x4DE33C0", VA = "0x184DE47C0")]
		public static JValue CreateNull()
		{
			return null;
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000950")]
		[Address(RVA = "0x4DE4910", Offset = "0x4DE3510", VA = "0x184DE4910")]
		public static JValue CreateUndefined()
		{
			return null;
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x000057C0 File Offset: 0x000039C0
		[Token(Token = "0x6000951")]
		[Address(RVA = "0x4DE4CE0", Offset = "0x4DE38E0", VA = "0x184DE4CE0")]
		private static JTokenType GetValueType(JTokenType? current, object value)
		{
			return JTokenType.None;
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x000057D8 File Offset: 0x000039D8
		[Token(Token = "0x6000952")]
		[Address(RVA = "0x4DE4C80", Offset = "0x4DE3880", VA = "0x184DE4C80")]
		private static JTokenType GetStringValueType(JTokenType? current)
		{
			return JTokenType.None;
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000953 RID: 2387 RVA: 0x000057F0 File Offset: 0x000039F0
		[Token(Token = "0x170001AD")]
		public override JTokenType Type
		{
			[Token(Token = "0x6000953")]
			[Address(RVA = "0xC91700", Offset = "0xC90300", VA = "0x180C91700", Slot = "13")]
			get
			{
				return JTokenType.None;
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000954 RID: 2388 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000955 RID: 2389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001AE")]
		public new object Value
		{
			[Token(Token = "0x6000954")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000955")]
			[Address(RVA = "0x4DE6F20", Offset = "0x4DE5B20", VA = "0x184DE6F20")]
			set
			{
			}
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000956")]
		[Address(RVA = "0x4DE5B30", Offset = "0x4DE4730", VA = "0x184DE5B30", Slot = "22")]
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x00005808 File Offset: 0x00003A08
		[Token(Token = "0x6000957")]
		[Address(RVA = "0x4DE4BD0", Offset = "0x4DE37D0", VA = "0x184DE4BD0", Slot = "23")]
		internal override int GetDeepHashCode()
		{
			return 0;
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x00005820 File Offset: 0x00003A20
		[Token(Token = "0x6000958")]
		[Address(RVA = "0x4DE5AE0", Offset = "0x4DE46E0", VA = "0x184DE5AE0")]
		private static bool ValuesEquals(JValue v1, JValue v2)
		{
			return default(bool);
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x00005838 File Offset: 0x00003A38
		[Token(Token = "0x6000959")]
		[Address(RVA = "0x4DE4B80", Offset = "0x4DE3780", VA = "0x184DE4B80")]
		public bool Equals(JValue other)
		{
			return default(bool);
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x00005850 File Offset: 0x00003A50
		[Token(Token = "0x600095A")]
		[Address(RVA = "0x4DE4A90", Offset = "0x4DE3690", VA = "0x184DE4A90", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x00005868 File Offset: 0x00003A68
		[Token(Token = "0x600095B")]
		[Address(RVA = "0x4DE4C30", Offset = "0x4DE3830", VA = "0x184DE4C30", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600095C")]
		[Address(RVA = "0x4DE5860", Offset = "0x4DE4460", VA = "0x184DE5860", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600095D")]
		[Address(RVA = "0x4DE58E0", Offset = "0x4DE44E0", VA = "0x184DE58E0")]
		public string ToString(string format)
		{
			return null;
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600095E")]
		[Address(RVA = "0x4DE5AD0", Offset = "0x4DE46D0", VA = "0x184DE5AD0", Slot = "41")]
		public string ToString(IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600095F")]
		[Address(RVA = "0x4DE5950", Offset = "0x4DE4550", VA = "0x184DE5950", Slot = "24")]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x00005880 File Offset: 0x00003A80
		[Token(Token = "0x6000960")]
		[Address(RVA = "0x4DE51B0", Offset = "0x4DE3DB0", VA = "0x184DE51B0", Slot = "25")]
		private int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x00005898 File Offset: 0x00003A98
		[Token(Token = "0x6000961")]
		[Address(RVA = "0x4DE3C70", Offset = "0x4DE2870", VA = "0x184DE3C70")]
		public int CompareTo(JValue obj)
		{
			return 0;
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x000058B0 File Offset: 0x00003AB0
		[Token(Token = "0x6000962")]
		[Address(RVA = "0x4DE5360", Offset = "0x4DE3F60", VA = "0x184DE5360", Slot = "26")]
		private TypeCode GetTypeCode()
		{
			return TypeCode.Empty;
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x000058C8 File Offset: 0x00003AC8
		[Token(Token = "0x6000963")]
		[Address(RVA = "0x4DE53D0", Offset = "0x4DE3FD0", VA = "0x184DE53D0", Slot = "27")]
		private bool ToBoolean(IFormatProvider provider)
		{
			return default(bool);
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x000058E0 File Offset: 0x00003AE0
		[Token(Token = "0x6000964")]
		[Address(RVA = "0x4DE5470", Offset = "0x4DE4070", VA = "0x184DE5470", Slot = "28")]
		private char ToChar(IFormatProvider provider)
		{
			return '\0';
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x000058F8 File Offset: 0x00003AF8
		[Token(Token = "0x6000965")]
		[Address(RVA = "0x4DE56C0", Offset = "0x4DE42C0", VA = "0x184DE56C0", Slot = "29")]
		private sbyte ToSByte(IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x00005910 File Offset: 0x00003B10
		[Token(Token = "0x6000966")]
		[Address(RVA = "0x4DE5420", Offset = "0x4DE4020", VA = "0x184DE5420", Slot = "30")]
		private byte ToByte(IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x00005928 File Offset: 0x00003B28
		[Token(Token = "0x6000967")]
		[Address(RVA = "0x4DE55D0", Offset = "0x4DE41D0", VA = "0x184DE55D0", Slot = "31")]
		private short ToInt16(IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x00005940 File Offset: 0x00003B40
		[Token(Token = "0x6000968")]
		[Address(RVA = "0x4DE5770", Offset = "0x4DE4370", VA = "0x184DE5770", Slot = "32")]
		private ushort ToUInt16(IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x00005958 File Offset: 0x00003B58
		[Token(Token = "0x6000969")]
		[Address(RVA = "0x4DE5620", Offset = "0x4DE4220", VA = "0x184DE5620", Slot = "33")]
		private int ToInt32(IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x00005970 File Offset: 0x00003B70
		[Token(Token = "0x600096A")]
		[Address(RVA = "0x4DE57C0", Offset = "0x4DE43C0", VA = "0x184DE57C0", Slot = "34")]
		private uint ToUInt32(IFormatProvider provider)
		{
			return 0U;
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x00005988 File Offset: 0x00003B88
		[Token(Token = "0x600096B")]
		[Address(RVA = "0x4DE5670", Offset = "0x4DE4270", VA = "0x184DE5670", Slot = "35")]
		private long ToInt64(IFormatProvider provider)
		{
			return 0L;
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x000059A0 File Offset: 0x00003BA0
		[Token(Token = "0x600096C")]
		[Address(RVA = "0x4DE5810", Offset = "0x4DE4410", VA = "0x184DE5810", Slot = "36")]
		private ulong ToUInt64(IFormatProvider provider)
		{
			return 0UL;
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x000059B8 File Offset: 0x00003BB8
		[Token(Token = "0x600096D")]
		[Address(RVA = "0x4DE5710", Offset = "0x4DE4310", VA = "0x184DE5710", Slot = "37")]
		private float ToSingle(IFormatProvider provider)
		{
			return 0f;
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x000059D0 File Offset: 0x00003BD0
		[Token(Token = "0x600096E")]
		[Address(RVA = "0x4DE5580", Offset = "0x4DE4180", VA = "0x184DE5580", Slot = "38")]
		private double ToDouble(IFormatProvider provider)
		{
			return 0.0;
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x000059E8 File Offset: 0x00003BE8
		[Token(Token = "0x600096F")]
		[Address(RVA = "0x4DE5510", Offset = "0x4DE4110", VA = "0x184DE5510", Slot = "39")]
		private decimal ToDecimal(IFormatProvider provider)
		{
			return 0m;
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x00005A00 File Offset: 0x00003C00
		[Token(Token = "0x6000970")]
		[Address(RVA = "0x4DE54C0", Offset = "0x4DE40C0", VA = "0x184DE54C0", Slot = "40")]
		private DateTime ToDateTime(IFormatProvider provider)
		{
			return default(DateTime);
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000971")]
		[Address(RVA = "0x4DE5760", Offset = "0x4DE4360", VA = "0x184DE5760", Slot = "42")]
		private object ToType(Type conversionType, IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x04000384 RID: 900
		[Token(Token = "0x4000384")]
		[FieldOffset(Offset = "0x30")]
		private JTokenType _valueType;

		// Token: 0x04000385 RID: 901
		[Token(Token = "0x4000385")]
		[FieldOffset(Offset = "0x38")]
		private object _value;
	}
}
