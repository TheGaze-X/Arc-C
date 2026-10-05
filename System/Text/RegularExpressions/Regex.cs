using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Text.RegularExpressions
{
	// Token: 0x020000E7 RID: 231
	[Token(Token = "0x20000E7")]
	public class Regex : ISerializable
	{
		// Token: 0x06000514 RID: 1300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000514")]
		[Address(RVA = "0x50FF2A0", Offset = "0x50FDEA0", VA = "0x1850FF2A0")]
		[MethodImpl(256)]
		private Regex.CachedCodeEntry GetCachedCode(Regex.CachedCodeEntryKey key, bool isToAdd)
		{
			return null;
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000515")]
		[Address(RVA = "0x50FEBE0", Offset = "0x50FD7E0", VA = "0x1850FEBE0")]
		private Regex.CachedCodeEntry GetCachedCodeEntryInternal(Regex.CachedCodeEntryKey key, bool isToAdd)
		{
			return null;
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000516")]
		[Address(RVA = "0x50FEAD0", Offset = "0x50FD6D0", VA = "0x1850FEAD0")]
		private void FillCacheDictionary()
		{
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x00003DF8 File Offset: 0x00001FF8
		[Token(Token = "0x6000517")]
		[Address(RVA = "0x51026F0", Offset = "0x51012F0", VA = "0x1851026F0")]
		[MethodImpl(256)]
		private static bool TryGetCacheValue(Regex.CachedCodeEntryKey key, out Regex.CachedCodeEntry entry)
		{
			return default(bool);
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x00003E10 File Offset: 0x00002010
		[Token(Token = "0x6000518")]
		[Address(RVA = "0x51025A0", Offset = "0x51011A0", VA = "0x1851025A0")]
		private static bool TryGetCacheValueSmall(Regex.CachedCodeEntryKey key, out Regex.CachedCodeEntry entry)
		{
			return default(bool);
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000519")]
		[Address(RVA = "0x50FFD60", Offset = "0x50FE960", VA = "0x1850FFD60")]
		private static Regex.CachedCodeEntry LookupCachedAndPromote(Regex.CachedCodeEntryKey key)
		{
			return null;
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x00003E28 File Offset: 0x00002028
		[Token(Token = "0x600051A")]
		[Address(RVA = "0x50FF9C0", Offset = "0x50FE5C0", VA = "0x1850FF9C0")]
		public static bool IsMatch(string input, string pattern)
		{
			return default(bool);
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x00003E40 File Offset: 0x00002040
		[Token(Token = "0x600051B")]
		[Address(RVA = "0x50FFA40", Offset = "0x50FE640", VA = "0x1850FFA40")]
		public static bool IsMatch(string input, string pattern, RegexOptions options)
		{
			return default(bool);
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x00003E58 File Offset: 0x00002058
		[Token(Token = "0x600051C")]
		[Address(RVA = "0x50FFC20", Offset = "0x50FE820", VA = "0x1850FFC20")]
		public static bool IsMatch(string input, string pattern, RegexOptions options, TimeSpan matchTimeout)
		{
			return default(bool);
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x00003E70 File Offset: 0x00002070
		[Token(Token = "0x600051D")]
		[Address(RVA = "0x50FFAD0", Offset = "0x50FE6D0", VA = "0x1850FFAD0")]
		public bool IsMatch(string input)
		{
			return default(bool);
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x00003E88 File Offset: 0x00002088
		[Token(Token = "0x600051E")]
		[Address(RVA = "0x50FFB80", Offset = "0x50FE780", VA = "0x1850FFB80")]
		public bool IsMatch(string input, int startat)
		{
			return default(bool);
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600051F")]
		[Address(RVA = "0x5100470", Offset = "0x50FF070", VA = "0x185100470")]
		public static Match Match(string input, string pattern)
		{
			return null;
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000520")]
		[Address(RVA = "0x51002B0", Offset = "0x50FEEB0", VA = "0x1851002B0")]
		public static Match Match(string input, string pattern, RegexOptions options, TimeSpan matchTimeout)
		{
			return null;
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000521")]
		[Address(RVA = "0x5100210", Offset = "0x50FEE10", VA = "0x185100210")]
		public Match Match(string input)
		{
			return null;
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000522")]
		[Address(RVA = "0x51003E0", Offset = "0x50FEFE0", VA = "0x1851003E0")]
		public Match Match(string input, int startat)
		{
			return null;
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000523")]
		[Address(RVA = "0x51005D0", Offset = "0x50FF1D0", VA = "0x1851005D0")]
		public static MatchCollection Matches(string input, string pattern)
		{
			return null;
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000524")]
		[Address(RVA = "0x51007A0", Offset = "0x50FF3A0", VA = "0x1851007A0")]
		public static MatchCollection Matches(string input, string pattern, RegexOptions options, TimeSpan matchTimeout)
		{
			return null;
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000525")]
		[Address(RVA = "0x5100710", Offset = "0x50FF310", VA = "0x185100710")]
		public MatchCollection Matches(string input)
		{
			return null;
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000526")]
		[Address(RVA = "0x51008A0", Offset = "0x50FF4A0", VA = "0x1851008A0")]
		public MatchCollection Matches(string input, int startat)
		{
			return null;
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000527")]
		[Address(RVA = "0x51012A0", Offset = "0x50FFEA0", VA = "0x1851012A0")]
		public static string Replace(string input, string pattern, string replacement)
		{
			return null;
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000528")]
		[Address(RVA = "0x5100C60", Offset = "0x50FF860", VA = "0x185100C60")]
		public static string Replace(string input, string pattern, string replacement, RegexOptions options, TimeSpan matchTimeout)
		{
			return null;
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000529")]
		[Address(RVA = "0x5101490", Offset = "0x5100090", VA = "0x185101490")]
		public string Replace(string input, string replacement)
		{
			return null;
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600052A")]
		[Address(RVA = "0x51015E0", Offset = "0x51001E0", VA = "0x1851015E0")]
		public string Replace(string input, string replacement, int count, int startat)
		{
			return null;
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600052B")]
		[Address(RVA = "0x5100A90", Offset = "0x50FF690", VA = "0x185100A90")]
		public string Replace(string input, MatchEvaluator evaluator)
		{
			return null;
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600052C")]
		[Address(RVA = "0x5100B80", Offset = "0x50FF780", VA = "0x185100B80")]
		public string Replace(string input, MatchEvaluator evaluator, int count, int startat)
		{
			return null;
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600052D")]
		[Address(RVA = "0x5100E10", Offset = "0x50FFA10", VA = "0x185100E10")]
		private static string Replace(MatchEvaluator evaluator, Regex regex, string input, int count, int startat)
		{
			return null;
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600052E")]
		[Address(RVA = "0x51022F0", Offset = "0x5100EF0", VA = "0x1851022F0")]
		public static string[] Split(string input, string pattern)
		{
			return null;
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600052F")]
		[Address(RVA = "0x5101A80", Offset = "0x5100680", VA = "0x185101A80")]
		public static string[] Split(string input, string pattern, RegexOptions options, TimeSpan matchTimeout)
		{
			return null;
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000530")]
		[Address(RVA = "0x5102210", Offset = "0x5100E10", VA = "0x185102210")]
		public string[] Split(string input)
		{
			return null;
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000531")]
		[Address(RVA = "0x5102470", Offset = "0x5101070", VA = "0x185102470")]
		public string[] Split(string input, int count, int startat)
		{
			return null;
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000532")]
		[Address(RVA = "0x5101BD0", Offset = "0x51007D0", VA = "0x185101BD0")]
		private static string[] Split(Regex regex, string input, int count, int startat)
		{
			return null;
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000534")]
		[Address(RVA = "0x5102810", Offset = "0x5101410", VA = "0x185102810")]
		protected internal static void ValidateMatchTimeout(TimeSpan matchTimeout)
		{
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x00003EA0 File Offset: 0x000020A0
		[Token(Token = "0x6000535")]
		[Address(RVA = "0x50FF670", Offset = "0x50FE270", VA = "0x1850FF670")]
		private static TimeSpan InitDefaultMatchTimeout()
		{
			return default(TimeSpan);
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000536")]
		[Address(RVA = "0x5102B00", Offset = "0x5101700", VA = "0x185102B00")]
		public Regex(string pattern)
		{
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000537")]
		[Address(RVA = "0x5103050", Offset = "0x5101C50", VA = "0x185103050")]
		public Regex(string pattern, RegexOptions options)
		{
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000538")]
		[Address(RVA = "0x5102550", Offset = "0x5101150", VA = "0x185102550", Slot = "4")]
		private void GetObjectData(SerializationInfo si, StreamingContext context)
		{
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000539")]
		[Address(RVA = "0x5102B80", Offset = "0x5101780", VA = "0x185102B80")]
		private Regex(string pattern, RegexOptions options, TimeSpan matchTimeout, bool addToCache)
		{
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x0600053A RID: 1338 RVA: 0x00003EB8 File Offset: 0x000020B8
		[Token(Token = "0x170000F1")]
		public RegexOptions Options
		{
			[Token(Token = "0x600053A")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
			get
			{
				return RegexOptions.None;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x0600053B RID: 1339 RVA: 0x00003ED0 File Offset: 0x000020D0
		[Token(Token = "0x170000F2")]
		public bool RightToLeft
		{
			[Token(Token = "0x600053B")]
			[Address(RVA = "0x5102800", Offset = "0x5101400", VA = "0x185102800")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600053C")]
		[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600053D")]
		[Address(RVA = "0x50FF410", Offset = "0x50FE010", VA = "0x1850FF410")]
		public string GroupNameFromNumber(int i)
		{
			return null;
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x00003EE8 File Offset: 0x000020E8
		[Token(Token = "0x600053E")]
		[Address(RVA = "0x50FF540", Offset = "0x50FE140", VA = "0x1850FF540")]
		public int GroupNumberFromName(string name)
		{
			return 0;
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600053F")]
		[Address(RVA = "0x50FF8A0", Offset = "0x50FE4A0", VA = "0x1850FF8A0")]
		protected void InitializeReferences()
		{
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000540")]
		[Address(RVA = "0x5101710", Offset = "0x5100310", VA = "0x185101710")]
		internal Match Run(bool quick, int prevlen, string input, int beginning, int length, int startat)
		{
			return null;
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x00003F00 File Offset: 0x00002100
		[Token(Token = "0x6000541")]
		[Address(RVA = "0x5102800", Offset = "0x5101400", VA = "0x185102800")]
		protected internal bool UseOptionR()
		{
			return default(bool);
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x00003F18 File Offset: 0x00002118
		[Token(Token = "0x6000542")]
		[Address(RVA = "0x51027F0", Offset = "0x51013F0", VA = "0x1851027F0")]
		internal bool UseOptionInvariant()
		{
			return default(bool);
		}

		// Token: 0x0400036F RID: 879
		[Token(Token = "0x400036F")]
		private const int CacheDictionarySwitchLimit = 10;

		// Token: 0x04000370 RID: 880
		[Token(Token = "0x4000370")]
		[FieldOffset(Offset = "0x0")]
		private static int s_cacheSize;

		// Token: 0x04000371 RID: 881
		[Token(Token = "0x4000371")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Dictionary<Regex.CachedCodeEntryKey, Regex.CachedCodeEntry> s_cache;

		// Token: 0x04000372 RID: 882
		[Token(Token = "0x4000372")]
		[FieldOffset(Offset = "0x10")]
		private static int s_cacheCount;

		// Token: 0x04000373 RID: 883
		[Token(Token = "0x4000373")]
		[FieldOffset(Offset = "0x18")]
		private static Regex.CachedCodeEntry s_cacheFirst;

		// Token: 0x04000374 RID: 884
		[Token(Token = "0x4000374")]
		[FieldOffset(Offset = "0x20")]
		private static Regex.CachedCodeEntry s_cacheLast;

		// Token: 0x04000375 RID: 885
		[Token(Token = "0x4000375")]
		[FieldOffset(Offset = "0x28")]
		private static readonly TimeSpan s_maximumMatchTimeout;

		// Token: 0x04000376 RID: 886
		[Token(Token = "0x4000376")]
		private const string DefaultMatchTimeout_ConfigKeyName = "REGEX_DEFAULT_MATCH_TIMEOUT";

		// Token: 0x04000377 RID: 887
		[Token(Token = "0x4000377")]
		[FieldOffset(Offset = "0x30")]
		internal static readonly TimeSpan s_defaultMatchTimeout;

		// Token: 0x04000378 RID: 888
		[Token(Token = "0x4000378")]
		[FieldOffset(Offset = "0x38")]
		public static readonly TimeSpan InfiniteMatchTimeout;

		// Token: 0x04000379 RID: 889
		[Token(Token = "0x4000379")]
		[FieldOffset(Offset = "0x10")]
		protected internal TimeSpan internalMatchTimeout;

		// Token: 0x0400037A RID: 890
		[Token(Token = "0x400037A")]
		internal const int MaxOptionShift = 10;

		// Token: 0x0400037B RID: 891
		[Token(Token = "0x400037B")]
		[FieldOffset(Offset = "0x18")]
		protected internal string pattern;

		// Token: 0x0400037C RID: 892
		[Token(Token = "0x400037C")]
		[FieldOffset(Offset = "0x20")]
		protected internal RegexOptions roptions;

		// Token: 0x0400037D RID: 893
		[Token(Token = "0x400037D")]
		[FieldOffset(Offset = "0x28")]
		protected internal RegexRunnerFactory factory;

		// Token: 0x0400037E RID: 894
		[Token(Token = "0x400037E")]
		[FieldOffset(Offset = "0x30")]
		protected internal Hashtable caps;

		// Token: 0x0400037F RID: 895
		[Token(Token = "0x400037F")]
		[FieldOffset(Offset = "0x38")]
		protected internal Hashtable capnames;

		// Token: 0x04000380 RID: 896
		[Token(Token = "0x4000380")]
		[FieldOffset(Offset = "0x40")]
		protected internal string[] capslist;

		// Token: 0x04000381 RID: 897
		[Token(Token = "0x4000381")]
		[FieldOffset(Offset = "0x48")]
		protected internal int capsize;

		// Token: 0x04000382 RID: 898
		[Token(Token = "0x4000382")]
		[FieldOffset(Offset = "0x50")]
		internal ExclusiveReference _runnerref;

		// Token: 0x04000383 RID: 899
		[Token(Token = "0x4000383")]
		[FieldOffset(Offset = "0x58")]
		internal WeakReference<RegexReplacement> _replref;

		// Token: 0x04000384 RID: 900
		[Token(Token = "0x4000384")]
		[FieldOffset(Offset = "0x60")]
		internal RegexCode _code;

		// Token: 0x04000385 RID: 901
		[Token(Token = "0x4000385")]
		[FieldOffset(Offset = "0x68")]
		internal bool _refsInitialized;

		// Token: 0x020000E8 RID: 232
		[Token(Token = "0x20000E8")]
		internal readonly struct CachedCodeEntryKey : IEquatable<Regex.CachedCodeEntryKey>
		{
			// Token: 0x06000543 RID: 1347 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000543")]
			[Address(RVA = "0x4E45200", Offset = "0x4E43E00", VA = "0x184E45200")]
			public CachedCodeEntryKey(RegexOptions options, string cultureKey, string pattern)
			{
			}

			// Token: 0x06000544 RID: 1348 RVA: 0x00003F30 File Offset: 0x00002130
			[Token(Token = "0x6000544")]
			[Address(RVA = "0x50E6770", Offset = "0x50E5370", VA = "0x1850E6770", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			// Token: 0x06000545 RID: 1349 RVA: 0x00003F48 File Offset: 0x00002148
			[Token(Token = "0x6000545")]
			[Address(RVA = "0x50E6700", Offset = "0x50E5300", VA = "0x1850E6700", Slot = "4")]
			public bool Equals(Regex.CachedCodeEntryKey other)
			{
				return default(bool);
			}

			// Token: 0x06000546 RID: 1350 RVA: 0x00003F60 File Offset: 0x00002160
			[Token(Token = "0x6000546")]
			[Address(RVA = "0x50E68E0", Offset = "0x50E54E0", VA = "0x1850E68E0")]
			public static bool operator ==(Regex.CachedCodeEntryKey left, Regex.CachedCodeEntryKey right)
			{
				return default(bool);
			}

			// Token: 0x06000547 RID: 1351 RVA: 0x00003F78 File Offset: 0x00002178
			[Token(Token = "0x6000547")]
			[Address(RVA = "0x50E6840", Offset = "0x50E5440", VA = "0x1850E6840", Slot = "2")]
			public override int GetHashCode()
			{
				return 0;
			}

			// Token: 0x04000386 RID: 902
			[Token(Token = "0x4000386")]
			[FieldOffset(Offset = "0x0")]
			private readonly RegexOptions _options;

			// Token: 0x04000387 RID: 903
			[Token(Token = "0x4000387")]
			[FieldOffset(Offset = "0x8")]
			private readonly string _cultureKey;

			// Token: 0x04000388 RID: 904
			[Token(Token = "0x4000388")]
			[FieldOffset(Offset = "0x10")]
			private readonly string _pattern;
		}

		// Token: 0x020000E9 RID: 233
		[Token(Token = "0x20000E9")]
		internal sealed class CachedCodeEntry
		{
			// Token: 0x06000548 RID: 1352 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000548")]
			[Address(RVA = "0x50E6960", Offset = "0x50E5560", VA = "0x1850E6960")]
			public CachedCodeEntry(Regex.CachedCodeEntryKey key, Hashtable capnames, string[] capslist, RegexCode code, Hashtable caps, int capsize, ExclusiveReference runner, WeakReference<RegexReplacement> replref)
			{
			}

			// Token: 0x04000389 RID: 905
			[Token(Token = "0x4000389")]
			[FieldOffset(Offset = "0x10")]
			public Regex.CachedCodeEntry Next;

			// Token: 0x0400038A RID: 906
			[Token(Token = "0x400038A")]
			[FieldOffset(Offset = "0x18")]
			public Regex.CachedCodeEntry Previous;

			// Token: 0x0400038B RID: 907
			[Token(Token = "0x400038B")]
			[FieldOffset(Offset = "0x20")]
			public readonly Regex.CachedCodeEntryKey Key;

			// Token: 0x0400038C RID: 908
			[Token(Token = "0x400038C")]
			[FieldOffset(Offset = "0x38")]
			public RegexCode Code;

			// Token: 0x0400038D RID: 909
			[Token(Token = "0x400038D")]
			[FieldOffset(Offset = "0x40")]
			public readonly Hashtable Caps;

			// Token: 0x0400038E RID: 910
			[Token(Token = "0x400038E")]
			[FieldOffset(Offset = "0x48")]
			public readonly Hashtable Capnames;

			// Token: 0x0400038F RID: 911
			[Token(Token = "0x400038F")]
			[FieldOffset(Offset = "0x50")]
			public readonly string[] Capslist;

			// Token: 0x04000390 RID: 912
			[Token(Token = "0x4000390")]
			[FieldOffset(Offset = "0x58")]
			public readonly int Capsize;

			// Token: 0x04000391 RID: 913
			[Token(Token = "0x4000391")]
			[FieldOffset(Offset = "0x60")]
			public readonly ExclusiveReference Runnerref;

			// Token: 0x04000392 RID: 914
			[Token(Token = "0x4000392")]
			[FieldOffset(Offset = "0x68")]
			public readonly WeakReference<RegexReplacement> ReplRef;
		}
	}
}
