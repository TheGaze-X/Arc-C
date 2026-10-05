using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000D5 RID: 213
	[Token(Token = "0x20000D5")]
	[Preserve]
	public abstract class JToken : IJEnumerable<JToken>, IEnumerable<JToken>, IEnumerable, IJsonLineInfo, ICloneable
	{
		// Token: 0x1700018B RID: 395
		// (get) Token: 0x0600084F RID: 2127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700018B")]
		public static JTokenEqualityComparer EqualityComparer
		{
			[Token(Token = "0x600084F")]
			[Address(RVA = "0x4DCB5B0", Offset = "0x4DCA1B0", VA = "0x184DCB5B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000850 RID: 2128 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000851 RID: 2129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700018C")]
		public JContainer Parent
		{
			[Token(Token = "0x6000850")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[DebuggerStepThrough]
			get
			{
				return null;
			}
			[Token(Token = "0x6000851")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			internal set
			{
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000852 RID: 2130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700018D")]
		public JToken Root
		{
			[Token(Token = "0x6000852")]
			[Address(RVA = "0x4DCBB70", Offset = "0x4DCA770", VA = "0x184DCBB70")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000853 RID: 2131
		[Token(Token = "0x6000853")]
		internal abstract JToken CloneToken();

		// Token: 0x06000854 RID: 2132
		[Token(Token = "0x6000854")]
		internal abstract bool DeepEquals(JToken node);

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000855 RID: 2133
		[Token(Token = "0x1700018E")]
		public abstract JTokenType Type { [Token(Token = "0x6000855")] get; }

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000856 RID: 2134
		[Token(Token = "0x1700018F")]
		public abstract bool HasValues { [Token(Token = "0x6000856")] get; }

		// Token: 0x06000857 RID: 2135 RVA: 0x000051F0 File Offset: 0x000033F0
		[Token(Token = "0x6000857")]
		[Address(RVA = "0x4DC8320", Offset = "0x4DC6F20", VA = "0x184DC8320")]
		public static bool DeepEquals(JToken t1, JToken t2)
		{
			return default(bool);
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000858 RID: 2136 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000859 RID: 2137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000190")]
		public JToken Next
		{
			[Token(Token = "0x6000858")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000859")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			internal set
			{
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x0600085A RID: 2138 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600085B RID: 2139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000191")]
		public JToken Previous
		{
			[Token(Token = "0x600085A")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x600085B")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			internal set
			{
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x0600085C RID: 2140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000192")]
		public string Path
		{
			[Token(Token = "0x600085C")]
			[Address(RVA = "0x4DCB880", Offset = "0x4DCA480", VA = "0x184DCB880")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600085D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		internal JToken()
		{
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600085E")]
		[Address(RVA = "0x4DC7B20", Offset = "0x4DC6720", VA = "0x184DC7B20")]
		public void AddAfterSelf(object content)
		{
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600085F")]
		[Address(RVA = "0x4DC7EA0", Offset = "0x4DC6AA0", VA = "0x184DC7EA0")]
		public void AddBeforeSelf(object content)
		{
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000860")]
		[Address(RVA = "0x4DC7FF0", Offset = "0x4DC6BF0", VA = "0x184DC7FF0")]
		public IEnumerable<JToken> Ancestors()
		{
			return null;
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000861")]
		[Address(RVA = "0x4DC7FE0", Offset = "0x4DC6BE0", VA = "0x184DC7FE0")]
		public IEnumerable<JToken> AncestorsAndSelf()
		{
			return null;
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000862")]
		[Address(RVA = "0x4DC87D0", Offset = "0x4DC73D0", VA = "0x184DC87D0")]
		internal IEnumerable<JToken> GetAncestors(bool self)
		{
			return null;
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000863")]
		[Address(RVA = "0x4DC7F70", Offset = "0x4DC6B70", VA = "0x184DC7F70")]
		public IEnumerable<JToken> AfterSelf()
		{
			return null;
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000864")]
		[Address(RVA = "0x4DC81C0", Offset = "0x4DC6DC0", VA = "0x184DC81C0")]
		public IEnumerable<JToken> BeforeSelf()
		{
			return null;
		}

		// Token: 0x17000193 RID: 403
		[Token(Token = "0x17000193")]
		public virtual JToken this[object key]
		{
			[Token(Token = "0x6000865")]
			[Address(RVA = "0x4DCB740", Offset = "0x4DCA340", VA = "0x184DCB740", Slot = "15")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000866")]
			[Address(RVA = "0x4DD1E10", Offset = "0x4DD0A10", VA = "0x184DD1E10", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000867")]
		public virtual T Value<T>(object key)
		{
			return null;
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000868 RID: 2152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000194")]
		public virtual JToken First
		{
			[Token(Token = "0x6000868")]
			[Address(RVA = "0x4DCB6A0", Offset = "0x4DCA2A0", VA = "0x184DCB6A0", Slot = "18")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06000869 RID: 2153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000195")]
		public virtual JToken Last
		{
			[Token(Token = "0x6000869")]
			[Address(RVA = "0x4DCB7E0", Offset = "0x4DCA3E0", VA = "0x184DCB7E0", Slot = "19")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x00005208 File Offset: 0x00003408
		[Token(Token = "0x600086A")]
		[Address(RVA = "0x4DC8230", Offset = "0x4DC6E30", VA = "0x184DC8230", Slot = "20")]
		public virtual JEnumerable<JToken> Children()
		{
			return default(JEnumerable<JToken>);
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x00005220 File Offset: 0x00003420
		[Token(Token = "0x600086B")]
		public JEnumerable<T> Children<T>() where T : JToken
		{
			return default(JEnumerable<T>);
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600086C")]
		public virtual IEnumerable<T> Values<T>()
		{
			return null;
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600086D")]
		[Address(RVA = "0x4DC94A0", Offset = "0x4DC80A0", VA = "0x184DC94A0")]
		public void Remove()
		{
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600086E")]
		[Address(RVA = "0x4DC9540", Offset = "0x4DC8140", VA = "0x184DC9540")]
		public void Replace(JToken value)
		{
		}

		// Token: 0x0600086F RID: 2159
		[Token(Token = "0x600086F")]
		public abstract void WriteTo(JsonWriter writer, params JsonConverter[] converters);

		// Token: 0x06000870 RID: 2160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000870")]
		[Address(RVA = "0x4DCAC80", Offset = "0x4DC9880", VA = "0x184DCAC80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000871")]
		[Address(RVA = "0x4DCACD0", Offset = "0x4DC98D0", VA = "0x184DCACD0")]
		public string ToString(Formatting formatting, params JsonConverter[] converters)
		{
			return null;
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000872")]
		[Address(RVA = "0x4DC8350", Offset = "0x4DC6F50", VA = "0x184DC8350")]
		private static JValue EnsureValue(JToken value)
		{
			return null;
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000873")]
		[Address(RVA = "0x4DC8870", Offset = "0x4DC7470", VA = "0x184DC8870")]
		private static string GetType(JToken token)
		{
			return null;
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x00005238 File Offset: 0x00003438
		[Token(Token = "0x6000874")]
		[Address(RVA = "0x4DCAEC0", Offset = "0x4DC9AC0", VA = "0x184DCAEC0")]
		private static bool ValidateToken(JToken o, JTokenType[] validTypes, bool nullable)
		{
			return default(bool);
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x00005250 File Offset: 0x00003450
		[Token(Token = "0x6000875")]
		[Address(RVA = "0x4DCE1E0", Offset = "0x4DCCDE0", VA = "0x184DCE1E0")]
		public static explicit operator bool(JToken value)
		{
			return default(bool);
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x00005268 File Offset: 0x00003468
		[Token(Token = "0x6000876")]
		[Address(RVA = "0x4DCCE90", Offset = "0x4DCBA90", VA = "0x184DCCE90")]
		public static explicit operator DateTimeOffset(JToken value)
		{
			return default(DateTimeOffset);
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x00005280 File Offset: 0x00003480
		[Token(Token = "0x6000877")]
		[Address(RVA = "0x4DCF700", Offset = "0x4DCE300", VA = "0x184DCF700")]
		public static explicit operator bool?(JToken value)
		{
			return null;
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x00005298 File Offset: 0x00003498
		[Token(Token = "0x6000878")]
		[Address(RVA = "0x4DD00E0", Offset = "0x4DCECE0", VA = "0x184DD00E0")]
		public static explicit operator long(JToken value)
		{
			return 0L;
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x000052B0 File Offset: 0x000034B0
		[Token(Token = "0x6000879")]
		[Address(RVA = "0x4DCF230", Offset = "0x4DCDE30", VA = "0x184DCF230")]
		public static explicit operator DateTime?(JToken value)
		{
			return null;
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x000052C8 File Offset: 0x000034C8
		[Token(Token = "0x600087A")]
		[Address(RVA = "0x4DCCB00", Offset = "0x4DCB700", VA = "0x184DCCB00")]
		public static explicit operator DateTimeOffset?(JToken value)
		{
			return null;
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x000052E0 File Offset: 0x000034E0
		[Token(Token = "0x600087B")]
		[Address(RVA = "0x4DCEDF0", Offset = "0x4DCD9F0", VA = "0x184DCEDF0")]
		public static explicit operator decimal?(JToken value)
		{
			return null;
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x000052F8 File Offset: 0x000034F8
		[Token(Token = "0x600087C")]
		[Address(RVA = "0x4DD09B0", Offset = "0x4DCF5B0", VA = "0x184DD09B0")]
		public static explicit operator double?(JToken value)
		{
			return null;
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x00005310 File Offset: 0x00003510
		[Token(Token = "0x600087D")]
		[Address(RVA = "0x4DCD390", Offset = "0x4DCBF90", VA = "0x184DCD390")]
		public static explicit operator char?(JToken value)
		{
			return null;
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x00005328 File Offset: 0x00003528
		[Token(Token = "0x600087E")]
		[Address(RVA = "0x4DCDCD0", Offset = "0x4DCC8D0", VA = "0x184DCDCD0")]
		public static explicit operator int(JToken value)
		{
			return 0;
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x00005340 File Offset: 0x00003540
		[Token(Token = "0x600087F")]
		[Address(RVA = "0x4DCE610", Offset = "0x4DCD210", VA = "0x184DCE610")]
		public static explicit operator short(JToken value)
		{
			return 0;
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x00005358 File Offset: 0x00003558
		[Token(Token = "0x6000880")]
		[Address(RVA = "0x4DCF900", Offset = "0x4DCE500", VA = "0x184DCF900")]
		[CLSCompliant(false)]
		public static explicit operator ushort(JToken value)
		{
			return 0;
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x00005370 File Offset: 0x00003570
		[Token(Token = "0x6000881")]
		[Address(RVA = "0x4DCFAF0", Offset = "0x4DCE6F0", VA = "0x184DCFAF0")]
		[CLSCompliant(false)]
		public static explicit operator char(JToken value)
		{
			return '\0';
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x00005388 File Offset: 0x00003588
		[Token(Token = "0x6000882")]
		[Address(RVA = "0x4DD0BB0", Offset = "0x4DCF7B0", VA = "0x184DD0BB0")]
		public static explicit operator byte(JToken value)
		{
			return 0;
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x000053A0 File Offset: 0x000035A0
		[Token(Token = "0x6000883")]
		[Address(RVA = "0x4DCEA00", Offset = "0x4DCD600", VA = "0x184DCEA00")]
		[CLSCompliant(false)]
		public static explicit operator sbyte(JToken value)
		{
			return 0;
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x000053B8 File Offset: 0x000035B8
		[Token(Token = "0x6000884")]
		[Address(RVA = "0x4DCF030", Offset = "0x4DCDC30", VA = "0x184DCF030")]
		public static explicit operator int?(JToken value)
		{
			return null;
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x000053D0 File Offset: 0x000035D0
		[Token(Token = "0x6000885")]
		[Address(RVA = "0x4DCD8D0", Offset = "0x4DCC4D0", VA = "0x184DCD8D0")]
		public static explicit operator short?(JToken value)
		{
			return null;
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x000053E8 File Offset: 0x000035E8
		[Token(Token = "0x6000886")]
		[Address(RVA = "0x4DCFCE0", Offset = "0x4DCE8E0", VA = "0x184DCFCE0")]
		[CLSCompliant(false)]
		public static explicit operator ushort?(JToken value)
		{
			return null;
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x00005400 File Offset: 0x00003600
		[Token(Token = "0x6000887")]
		[Address(RVA = "0x4DCC390", Offset = "0x4DCAF90", VA = "0x184DCC390")]
		public static explicit operator byte?(JToken value)
		{
			return null;
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x00005418 File Offset: 0x00003618
		[Token(Token = "0x6000888")]
		[Address(RVA = "0x4DCFEE0", Offset = "0x4DCEAE0", VA = "0x184DCFEE0")]
		[CLSCompliant(false)]
		public static explicit operator sbyte?(JToken value)
		{
			return null;
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x00005430 File Offset: 0x00003630
		[Token(Token = "0x6000889")]
		[Address(RVA = "0x4DCC890", Offset = "0x4DCB490", VA = "0x184DCC890")]
		public static explicit operator DateTime(JToken value)
		{
			return default(DateTime);
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x00005448 File Offset: 0x00003648
		[Token(Token = "0x600088A")]
		[Address(RVA = "0x4DCEBF0", Offset = "0x4DCD7F0", VA = "0x184DCEBF0")]
		public static explicit operator long?(JToken value)
		{
			return null;
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x00005460 File Offset: 0x00003660
		[Token(Token = "0x600088B")]
		[Address(RVA = "0x4DCBFA0", Offset = "0x4DCABA0", VA = "0x184DCBFA0")]
		public static explicit operator float?(JToken value)
		{
			return null;
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x00005478 File Offset: 0x00003678
		[Token(Token = "0x600088C")]
		[Address(RVA = "0x4DCBD90", Offset = "0x4DCA990", VA = "0x184DCBD90")]
		public static explicit operator decimal(JToken value)
		{
			return 0m;
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x00005490 File Offset: 0x00003690
		[Token(Token = "0x600088D")]
		[Address(RVA = "0x4DCDAD0", Offset = "0x4DCC6D0", VA = "0x184DCDAD0")]
		[CLSCompliant(false)]
		public static explicit operator uint?(JToken value)
		{
			return null;
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x000054A8 File Offset: 0x000036A8
		[Token(Token = "0x600088E")]
		[Address(RVA = "0x4DCE800", Offset = "0x4DCD400", VA = "0x184DCE800")]
		[CLSCompliant(false)]
		public static explicit operator ulong?(JToken value)
		{
			return null;
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x000054C0 File Offset: 0x000036C0
		[Token(Token = "0x600088F")]
		[Address(RVA = "0x4DD0540", Offset = "0x4DCF140", VA = "0x184DD0540")]
		public static explicit operator double(JToken value)
		{
			return 0.0;
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x000054D8 File Offset: 0x000036D8
		[Token(Token = "0x6000890")]
		[Address(RVA = "0x4DCD1A0", Offset = "0x4DCBDA0", VA = "0x184DCD1A0")]
		public static explicit operator float(JToken value)
		{
			return 0f;
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000891")]
		[Address(RVA = "0x4DCF4A0", Offset = "0x4DCE0A0", VA = "0x184DCF4A0")]
		public static explicit operator string(JToken value)
		{
			return null;
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x000054F0 File Offset: 0x000036F0
		[Token(Token = "0x6000892")]
		[Address(RVA = "0x4DCC1A0", Offset = "0x4DCADA0", VA = "0x184DCC1A0")]
		[CLSCompliant(false)]
		public static explicit operator uint(JToken value)
		{
			return 0U;
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x00005508 File Offset: 0x00003708
		[Token(Token = "0x6000893")]
		[Address(RVA = "0x4DCBBA0", Offset = "0x4DCA7A0", VA = "0x184DCBBA0")]
		[CLSCompliant(false)]
		public static explicit operator ulong(JToken value)
		{
			return 0UL;
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000894")]
		[Address(RVA = "0x4DCD590", Offset = "0x4DCC190", VA = "0x184DCD590")]
		public static explicit operator byte[](JToken value)
		{
			return null;
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x00005520 File Offset: 0x00003720
		[Token(Token = "0x6000895")]
		[Address(RVA = "0x4DCC590", Offset = "0x4DCB190", VA = "0x184DCC590")]
		public static explicit operator Guid(JToken value)
		{
			return default(Guid);
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x00005538 File Offset: 0x00003738
		[Token(Token = "0x6000896")]
		[Address(RVA = "0x4DCDEC0", Offset = "0x4DCCAC0", VA = "0x184DCDEC0")]
		public static explicit operator Guid?(JToken value)
		{
			return null;
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x00005550 File Offset: 0x00003750
		[Token(Token = "0x6000897")]
		[Address(RVA = "0x4DD0730", Offset = "0x4DCF330", VA = "0x184DD0730")]
		public static explicit operator TimeSpan(JToken value)
		{
			return default(TimeSpan);
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x00005568 File Offset: 0x00003768
		[Token(Token = "0x6000898")]
		[Address(RVA = "0x4DD02D0", Offset = "0x4DCEED0", VA = "0x184DD02D0")]
		public static explicit operator TimeSpan?(JToken value)
		{
			return null;
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000899")]
		[Address(RVA = "0x4DCE3D0", Offset = "0x4DCCFD0", VA = "0x184DCE3D0")]
		public static explicit operator Uri(JToken value)
		{
			return null;
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600089A")]
		[Address(RVA = "0x4DD1690", Offset = "0x4DD0290", VA = "0x184DD1690")]
		public static implicit operator JToken(bool value)
		{
			return null;
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600089B")]
		[Address(RVA = "0x4DD0F20", Offset = "0x4DCFB20", VA = "0x184DD0F20")]
		public static implicit operator JToken(DateTimeOffset value)
		{
			return null;
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600089C")]
		[Address(RVA = "0x4DD1AC0", Offset = "0x4DD06C0", VA = "0x184DD1AC0")]
		public static implicit operator JToken(byte value)
		{
			return null;
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600089D")]
		[Address(RVA = "0x4DD1B20", Offset = "0x4DD0720", VA = "0x184DD1B20")]
		public static implicit operator JToken(byte? value)
		{
			return null;
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600089E")]
		[Address(RVA = "0x4DD10B0", Offset = "0x4DCFCB0", VA = "0x184DD10B0")]
		[CLSCompliant(false)]
		public static implicit operator JToken(sbyte value)
		{
			return null;
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600089F")]
		[Address(RVA = "0x4DD0E00", Offset = "0x4DCFA00", VA = "0x184DD0E00")]
		[CLSCompliant(false)]
		public static implicit operator JToken(sbyte? value)
		{
			return null;
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008A0")]
		[Address(RVA = "0x4DD0F90", Offset = "0x4DCFB90", VA = "0x184DD0F90")]
		public static implicit operator JToken(bool? value)
		{
			return null;
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008A1")]
		[Address(RVA = "0x4DD1630", Offset = "0x4DD0230", VA = "0x184DD1630")]
		public static implicit operator JToken(long value)
		{
			return null;
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008A2")]
		[Address(RVA = "0x4DD1480", Offset = "0x4DD0080", VA = "0x184DD1480")]
		public static implicit operator JToken(DateTime? value)
		{
			return null;
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008A3")]
		[Address(RVA = "0x4DD19C0", Offset = "0x4DD05C0", VA = "0x184DD19C0")]
		public static implicit operator JToken(DateTimeOffset? value)
		{
			return null;
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008A4")]
		[Address(RVA = "0x4DD1110", Offset = "0x4DCFD10", VA = "0x184DD1110")]
		public static implicit operator JToken(decimal? value)
		{
			return null;
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008A5")]
		[Address(RVA = "0x4DD1870", Offset = "0x4DD0470", VA = "0x184DD1870")]
		public static implicit operator JToken(double? value)
		{
			return null;
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008A6")]
		[Address(RVA = "0x4DD1810", Offset = "0x4DD0410", VA = "0x184DD1810")]
		[CLSCompliant(false)]
		public static implicit operator JToken(short value)
		{
			return null;
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008A7")]
		[Address(RVA = "0x4DD0DA0", Offset = "0x4DCF9A0", VA = "0x184DD0DA0")]
		[CLSCompliant(false)]
		public static implicit operator JToken(ushort value)
		{
			return null;
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008A8")]
		[Address(RVA = "0x4DD1A60", Offset = "0x4DD0660", VA = "0x184DD1A60")]
		public static implicit operator JToken(int value)
		{
			return null;
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008A9")]
		[Address(RVA = "0x4DD12A0", Offset = "0x4DCFEA0", VA = "0x184DD12A0")]
		public static implicit operator JToken(int? value)
		{
			return null;
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x4DD1330", Offset = "0x4DCFF30", VA = "0x184DD1330")]
		public static implicit operator JToken(DateTime value)
		{
			return null;
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x4DD1D80", Offset = "0x4DD0980", VA = "0x184DD1D80")]
		public static implicit operator JToken(long? value)
		{
			return null;
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x4DD13F0", Offset = "0x4DCFFF0", VA = "0x184DD13F0")]
		public static implicit operator JToken(float? value)
		{
			return null;
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x4DD1BB0", Offset = "0x4DD07B0", VA = "0x184DD1BB0")]
		public static implicit operator JToken(decimal value)
		{
			return null;
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x4DD1210", Offset = "0x4DCFE10", VA = "0x184DD1210")]
		[CLSCompliant(false)]
		public static implicit operator JToken(short? value)
		{
			return null;
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x4DD1020", Offset = "0x4DCFC20", VA = "0x184DD1020")]
		[CLSCompliant(false)]
		public static implicit operator JToken(ushort? value)
		{
			return null;
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008B0")]
		[Address(RVA = "0x4DD0E90", Offset = "0x4DCFA90", VA = "0x184DD0E90")]
		[CLSCompliant(false)]
		public static implicit operator JToken(uint? value)
		{
			return null;
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008B1")]
		[Address(RVA = "0x4DD15A0", Offset = "0x4DD01A0", VA = "0x184DD15A0")]
		[CLSCompliant(false)]
		public static implicit operator JToken(ulong? value)
		{
			return null;
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008B2")]
		[Address(RVA = "0x4DD1390", Offset = "0x4DCFF90", VA = "0x184DD1390")]
		public static implicit operator JToken(double value)
		{
			return null;
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008B3")]
		[Address(RVA = "0x4DD1900", Offset = "0x4DD0500", VA = "0x184DD1900")]
		public static implicit operator JToken(float value)
		{
			return null;
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x4DD17B0", Offset = "0x4DD03B0", VA = "0x184DD17B0")]
		public static implicit operator JToken(string value)
		{
			return null;
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x4DD1750", Offset = "0x4DD0350", VA = "0x184DD1750")]
		[CLSCompliant(false)]
		public static implicit operator JToken(uint value)
		{
			return null;
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x4DD1960", Offset = "0x4DD0560", VA = "0x184DD1960")]
		[CLSCompliant(false)]
		public static implicit operator JToken(ulong value)
		{
			return null;
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008B7")]
		[Address(RVA = "0x4DD11B0", Offset = "0x4DCFDB0", VA = "0x184DD11B0")]
		public static implicit operator JToken(byte[] value)
		{
			return null;
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008B8")]
		[Address(RVA = "0x4DD16F0", Offset = "0x4DD02F0", VA = "0x184DD16F0")]
		public static implicit operator JToken(Uri value)
		{
			return null;
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x4DD1D20", Offset = "0x4DD0920", VA = "0x184DD1D20")]
		public static implicit operator JToken(TimeSpan value)
		{
			return null;
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x4DD1C90", Offset = "0x4DD0890", VA = "0x184DD1C90")]
		public static implicit operator JToken(TimeSpan? value)
		{
			return null;
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008BB")]
		[Address(RVA = "0x4DD1C20", Offset = "0x4DD0820", VA = "0x184DD1C20")]
		public static implicit operator JToken(Guid value)
		{
			return null;
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008BC")]
		[Address(RVA = "0x4DD1510", Offset = "0x4DD0110", VA = "0x184DD1510")]
		public static implicit operator JToken(Guid? value)
		{
			return null;
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008BD")]
		[Address(RVA = "0x4DC9B20", Offset = "0x4DC8720", VA = "0x184DC9B20", Slot = "6")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008BE")]
		[Address(RVA = "0x4DC9A90", Offset = "0x4DC8690", VA = "0x184DC9A90", Slot = "5")]
		private IEnumerator<JToken> GetEnumerator()
		{
			return null;
		}

		// Token: 0x060008BF RID: 2239
		[Token(Token = "0x60008BF")]
		internal abstract int GetDeepHashCode();

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060008C0 RID: 2240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000196")]
		private IJEnumerable<JToken> Item
		{
			[Token(Token = "0x60008C0")]
			[Address(RVA = "0x4DC8C30", Offset = "0x4DC7830", VA = "0x184DC8C30", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008C1")]
		[Address(RVA = "0x4DC8280", Offset = "0x4DC6E80", VA = "0x184DC8280")]
		public JsonReader CreateReader()
		{
			return null;
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008C2")]
		[Address(RVA = "0x4DC8580", Offset = "0x4DC7180", VA = "0x184DC8580")]
		internal static JToken FromObjectInternal(object o, JsonSerializer jsonSerializer)
		{
			return null;
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008C3")]
		[Address(RVA = "0x4DC8710", Offset = "0x4DC7310", VA = "0x184DC8710")]
		public static JToken FromObject(object o)
		{
			return null;
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008C4")]
		[Address(RVA = "0x4DC8770", Offset = "0x4DC7370", VA = "0x184DC8770")]
		public static JToken FromObject(object o, JsonSerializer jsonSerializer)
		{
			return null;
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008C5")]
		public T ToObject<T>()
		{
			return null;
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008C6")]
		[Address(RVA = "0x4DC9CD0", Offset = "0x4DC88D0", VA = "0x184DC9CD0")]
		public object ToObject(Type objectType)
		{
			return null;
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008C7")]
		public T ToObject<T>(JsonSerializer jsonSerializer)
		{
			return null;
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008C8")]
		[Address(RVA = "0x4DC9B60", Offset = "0x4DC8760", VA = "0x184DC9B60")]
		public object ToObject(Type objectType, JsonSerializer jsonSerializer)
		{
			return null;
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008C9")]
		[Address(RVA = "0x4DC9240", Offset = "0x4DC7E40", VA = "0x184DC9240")]
		public static JToken ReadFrom(JsonReader reader)
		{
			return null;
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008CA")]
		[Address(RVA = "0x4DC8F10", Offset = "0x4DC7B10", VA = "0x184DC8F10")]
		public static JToken ReadFrom(JsonReader reader, JsonLoadSettings settings)
		{
			return null;
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008CB")]
		[Address(RVA = "0x4DC8EC0", Offset = "0x4DC7AC0", VA = "0x184DC8EC0")]
		public static JToken Parse(string json)
		{
			return null;
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x4DC8C80", Offset = "0x4DC7880", VA = "0x184DC8C80")]
		public static JToken Parse(string json, JsonLoadSettings settings)
		{
			return null;
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x4DC8AF0", Offset = "0x4DC76F0", VA = "0x184DC8AF0")]
		public static JToken Load(JsonReader reader, JsonLoadSettings settings)
		{
			return null;
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x4DC8A70", Offset = "0x4DC7670", VA = "0x184DC8A70")]
		public static JToken Load(JsonReader reader)
		{
			return null;
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008CF")]
		[Address(RVA = "0x4DC9990", Offset = "0x4DC8590", VA = "0x184DC9990")]
		internal void SetLineInfo(IJsonLineInfo lineInfo, JsonLoadSettings settings)
		{
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008D0")]
		[Address(RVA = "0x4DC9900", Offset = "0x4DC8500", VA = "0x184DC9900")]
		internal void SetLineInfo(int lineNumber, int linePosition)
		{
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x00005580 File Offset: 0x00003780
		[Token(Token = "0x60008D1")]
		[Address(RVA = "0x4DC8B50", Offset = "0x4DC7750", VA = "0x184DC8B50", Slot = "7")]
		private bool HasLineInfo()
		{
			return default(bool);
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060008D2 RID: 2258 RVA: 0x00005598 File Offset: 0x00003798
		[Token(Token = "0x17000197")]
		private int LineNumber
		{
			[Token(Token = "0x60008D2")]
			[Address(RVA = "0x4DC8B90", Offset = "0x4DC7790", VA = "0x184DC8B90", Slot = "8")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060008D3 RID: 2259 RVA: 0x000055B0 File Offset: 0x000037B0
		[Token(Token = "0x17000198")]
		private int LinePosition
		{
			[Token(Token = "0x60008D3")]
			[Address(RVA = "0x4DC8BE0", Offset = "0x4DC77E0", VA = "0x184DC8BE0", Slot = "9")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008D4")]
		[Address(RVA = "0x4DC95F0", Offset = "0x4DC81F0", VA = "0x184DC95F0")]
		public JToken SelectToken(string path)
		{
			return null;
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008D5")]
		[Address(RVA = "0x4DC9600", Offset = "0x4DC8200", VA = "0x184DC9600")]
		public JToken SelectToken(string path, bool errorWhenNoMatch)
		{
			return null;
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008D6")]
		[Address(RVA = "0x4DC97F0", Offset = "0x4DC83F0", VA = "0x184DC97F0")]
		public IEnumerable<JToken> SelectTokens(string path)
		{
			return null;
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008D7")]
		[Address(RVA = "0x4DC9870", Offset = "0x4DC8470", VA = "0x184DC9870")]
		public IEnumerable<JToken> SelectTokens(string path, bool errorWhenNoMatch)
		{
			return null;
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008D8")]
		[Address(RVA = "0x78A370", Offset = "0x788F70", VA = "0x18078A370", Slot = "10")]
		private object Clone()
		{
			return null;
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008D9")]
		[Address(RVA = "0x78A370", Offset = "0x788F70", VA = "0x18078A370")]
		public JToken DeepClone()
		{
			return null;
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008DA")]
		[Address(RVA = "0x4DC7BF0", Offset = "0x4DC67F0", VA = "0x184DC7BF0")]
		public void AddAnnotation(object annotation)
		{
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008DB")]
		public T Annotation<T>() where T : class
		{
			return null;
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x4DC8000", Offset = "0x4DC6C00", VA = "0x184DC8000")]
		public object Annotation(Type type)
		{
			return null;
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008DD")]
		public IEnumerable<T> Annotations<T>() where T : class
		{
			return null;
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008DE")]
		[Address(RVA = "0x4DC8130", Offset = "0x4DC6D30", VA = "0x184DC8130")]
		public IEnumerable<object> Annotations(Type type)
		{
			return null;
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008DF")]
		public void RemoveAnnotations<T>() where T : class
		{
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008E0")]
		[Address(RVA = "0x4DC9290", Offset = "0x4DC7E90", VA = "0x184DC9290")]
		public void RemoveAnnotations(Type type)
		{
		}

		// Token: 0x0400033C RID: 828
		[Token(Token = "0x400033C")]
		[FieldOffset(Offset = "0x0")]
		private static JTokenEqualityComparer _equalityComparer;

		// Token: 0x0400033D RID: 829
		[Token(Token = "0x400033D")]
		[FieldOffset(Offset = "0x10")]
		private JContainer _parent;

		// Token: 0x0400033E RID: 830
		[Token(Token = "0x400033E")]
		[FieldOffset(Offset = "0x18")]
		private JToken _previous;

		// Token: 0x0400033F RID: 831
		[Token(Token = "0x400033F")]
		[FieldOffset(Offset = "0x20")]
		private JToken _next;

		// Token: 0x04000340 RID: 832
		[Token(Token = "0x4000340")]
		[FieldOffset(Offset = "0x28")]
		private object _annotations;

		// Token: 0x04000341 RID: 833
		[Token(Token = "0x4000341")]
		[FieldOffset(Offset = "0x8")]
		private static readonly JTokenType[] BooleanTypes;

		// Token: 0x04000342 RID: 834
		[Token(Token = "0x4000342")]
		[FieldOffset(Offset = "0x10")]
		private static readonly JTokenType[] NumberTypes;

		// Token: 0x04000343 RID: 835
		[Token(Token = "0x4000343")]
		[FieldOffset(Offset = "0x18")]
		private static readonly JTokenType[] StringTypes;

		// Token: 0x04000344 RID: 836
		[Token(Token = "0x4000344")]
		[FieldOffset(Offset = "0x20")]
		private static readonly JTokenType[] GuidTypes;

		// Token: 0x04000345 RID: 837
		[Token(Token = "0x4000345")]
		[FieldOffset(Offset = "0x28")]
		private static readonly JTokenType[] TimeSpanTypes;

		// Token: 0x04000346 RID: 838
		[Token(Token = "0x4000346")]
		[FieldOffset(Offset = "0x30")]
		private static readonly JTokenType[] UriTypes;

		// Token: 0x04000347 RID: 839
		[Token(Token = "0x4000347")]
		[FieldOffset(Offset = "0x38")]
		private static readonly JTokenType[] CharTypes;

		// Token: 0x04000348 RID: 840
		[Token(Token = "0x4000348")]
		[FieldOffset(Offset = "0x40")]
		private static readonly JTokenType[] DateTimeTypes;

		// Token: 0x04000349 RID: 841
		[Token(Token = "0x4000349")]
		[FieldOffset(Offset = "0x48")]
		private static readonly JTokenType[] BytesTypes;

		// Token: 0x020000D6 RID: 214
		[Token(Token = "0x20000D6")]
		private class LineInfoAnnotation
		{
			// Token: 0x060008E2 RID: 2274 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60008E2")]
			[Address(RVA = "0x3629A50", Offset = "0x3628650", VA = "0x183629A50")]
			public LineInfoAnnotation(int lineNumber, int linePosition)
			{
			}

			// Token: 0x0400034A RID: 842
			[Token(Token = "0x400034A")]
			[FieldOffset(Offset = "0x10")]
			internal readonly int LineNumber;

			// Token: 0x0400034B RID: 843
			[Token(Token = "0x400034B")]
			[FieldOffset(Offset = "0x14")]
			internal readonly int LinePosition;
		}
	}
}
