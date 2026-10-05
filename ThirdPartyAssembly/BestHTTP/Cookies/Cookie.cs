using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using BestHTTP.Extensions;
using Il2CppDummyDll;

namespace BestHTTP.Cookies
{
	// Token: 0x02000504 RID: 1284
	[Token(Token = "0x2000504")]
	public sealed class Cookie : IComparable<Cookie>, IEquatable<Cookie>
	{
		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06002A41 RID: 10817 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002A42 RID: 10818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000618")]
		public string Name
		{
			[Token(Token = "0x6002A41")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002A42")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06002A43 RID: 10819 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002A44 RID: 10820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000619")]
		public string Value
		{
			[Token(Token = "0x6002A43")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002A44")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06002A45 RID: 10821 RVA: 0x00012108 File Offset: 0x00010308
		// (set) Token: 0x06002A46 RID: 10822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700061A")]
		public DateTime Date
		{
			[Token(Token = "0x6002A45")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x6002A46")]
			[Address(RVA = "0xEFAAF0", Offset = "0xEF96F0", VA = "0x180EFAAF0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06002A47 RID: 10823 RVA: 0x00012120 File Offset: 0x00010320
		// (set) Token: 0x06002A48 RID: 10824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700061B")]
		public DateTime LastAccess
		{
			[Token(Token = "0x6002A47")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x6002A48")]
			[Address(RVA = "0x20339E0", Offset = "0x20325E0", VA = "0x1820339E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x06002A49 RID: 10825 RVA: 0x00012138 File Offset: 0x00010338
		// (set) Token: 0x06002A4A RID: 10826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700061C")]
		public DateTime Expires
		{
			[Token(Token = "0x6002A49")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x6002A4A")]
			[Address(RVA = "0x53810F0", Offset = "0x537FCF0", VA = "0x1853810F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06002A4B RID: 10827 RVA: 0x00012150 File Offset: 0x00010350
		// (set) Token: 0x06002A4C RID: 10828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700061D")]
		public long MaxAge
		{
			[Token(Token = "0x6002A4B")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6002A4C")]
			[Address(RVA = "0x1796DB0", Offset = "0x17959B0", VA = "0x181796DB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x06002A4D RID: 10829 RVA: 0x00012168 File Offset: 0x00010368
		// (set) Token: 0x06002A4E RID: 10830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700061E")]
		public bool IsSession
		{
			[Token(Token = "0x6002A4D")]
			[Address(RVA = "0xD36A60", Offset = "0xD35660", VA = "0x180D36A60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002A4E")]
			[Address(RVA = "0x2860DE0", Offset = "0x285F9E0", VA = "0x182860DE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x06002A4F RID: 10831 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002A50 RID: 10832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700061F")]
		public string Domain
		{
			[Token(Token = "0x6002A4F")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002A50")]
			[Address(RVA = "0x4EEA30", Offset = "0x4ED630", VA = "0x1804EEA30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x06002A51 RID: 10833 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002A52 RID: 10834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000620")]
		public string Path
		{
			[Token(Token = "0x6002A51")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002A52")]
			[Address(RVA = "0x5EC4C0", Offset = "0x5EB0C0", VA = "0x1805EC4C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06002A53 RID: 10835 RVA: 0x00012180 File Offset: 0x00010380
		// (set) Token: 0x06002A54 RID: 10836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000621")]
		public bool IsSecure
		{
			[Token(Token = "0x6002A53")]
			[Address(RVA = "0x6DF210", Offset = "0x6DDE10", VA = "0x1806DF210")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002A54")]
			[Address(RVA = "0xC97C20", Offset = "0xC96820", VA = "0x180C97C20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06002A55 RID: 10837 RVA: 0x00012198 File Offset: 0x00010398
		// (set) Token: 0x06002A56 RID: 10838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000622")]
		public bool IsHttpOnly
		{
			[Token(Token = "0x6002A55")]
			[Address(RVA = "0x2419850", Offset = "0x2418450", VA = "0x182419850")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002A56")]
			[Address(RVA = "0x2419880", Offset = "0x2418480", VA = "0x182419880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002A57 RID: 10839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A57")]
		[Address(RVA = "0x53CB000", Offset = "0x53C9C00", VA = "0x1853CB000")]
		public Cookie(string name, string value)
		{
		}

		// Token: 0x06002A58 RID: 10840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A58")]
		[Address(RVA = "0x53CB170", Offset = "0x53C9D70", VA = "0x1853CB170")]
		public Cookie(string name, string value, string path)
		{
		}

		// Token: 0x06002A59 RID: 10841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A59")]
		[Address(RVA = "0x53CAF30", Offset = "0x53C9B30", VA = "0x1853CAF30")]
		public Cookie(string name, string value, string path, string domain)
		{
		}

		// Token: 0x06002A5A RID: 10842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A5A")]
		[Address(RVA = "0x53CADE0", Offset = "0x53C99E0", VA = "0x1853CADE0")]
		public Cookie(Uri uri, string name, string value, DateTime expires, bool isSession = true)
		{
		}

		// Token: 0x06002A5B RID: 10843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A5B")]
		[Address(RVA = "0x53CB090", Offset = "0x53C9C90", VA = "0x1853CB090")]
		public Cookie(Uri uri, string name, string value, long maxAge = -1L, bool isSession = true)
		{
		}

		// Token: 0x06002A5C RID: 10844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A5C")]
		[Address(RVA = "0x53CAEC0", Offset = "0x53C9AC0", VA = "0x1853CAEC0")]
		internal Cookie()
		{
		}

		// Token: 0x06002A5D RID: 10845 RVA: 0x000121B0 File Offset: 0x000103B0
		[Token(Token = "0x6002A5D")]
		[Address(RVA = "0x53CACC0", Offset = "0x53C98C0", VA = "0x1853CACC0")]
		public bool WillExpireInTheFuture()
		{
			return default(bool);
		}

		// Token: 0x06002A5E RID: 10846 RVA: 0x000121C8 File Offset: 0x000103C8
		[Token(Token = "0x6002A5E")]
		[Address(RVA = "0x53C9E00", Offset = "0x53C8A00", VA = "0x1853C9E00")]
		public uint GuessSize()
		{
			return 0U;
		}

		// Token: 0x06002A5F RID: 10847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A5F")]
		[Address(RVA = "0x53CA380", Offset = "0x53C8F80", VA = "0x1853CA380")]
		public static Cookie Parse(string header, Uri defaultDomain)
		{
			return null;
		}

		// Token: 0x06002A60 RID: 10848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A60")]
		[Address(RVA = "0x53CA960", Offset = "0x53C9560", VA = "0x1853CA960")]
		internal void SaveTo(BinaryWriter stream)
		{
		}

		// Token: 0x06002A61 RID: 10849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A61")]
		[Address(RVA = "0x53C9E60", Offset = "0x53C8A60", VA = "0x1853C9E60")]
		internal void LoadFrom(BinaryReader stream)
		{
		}

		// Token: 0x06002A62 RID: 10850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A62")]
		[Address(RVA = "0x53CAC70", Offset = "0x53C9870", VA = "0x1853CAC70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002A63 RID: 10851 RVA: 0x000121E0 File Offset: 0x000103E0
		[Token(Token = "0x6002A63")]
		[Address(RVA = "0x53C9C60", Offset = "0x53C8860", VA = "0x1853C9C60", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06002A64 RID: 10852 RVA: 0x000121F8 File Offset: 0x000103F8
		[Token(Token = "0x6002A64")]
		[Address(RVA = "0x53C9CD0", Offset = "0x53C88D0", VA = "0x1853C9CD0", Slot = "5")]
		public bool Equals(Cookie cookie)
		{
			return default(bool);
		}

		// Token: 0x06002A65 RID: 10853 RVA: 0x00012210 File Offset: 0x00010410
		[Token(Token = "0x6002A65")]
		[Address(RVA = "0x53C9D90", Offset = "0x53C8990", VA = "0x1853C9D90", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002A66 RID: 10854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A66")]
		[Address(RVA = "0x53CA8F0", Offset = "0x53C94F0", VA = "0x1853CA8F0")]
		private static string ReadValue(string str, ref int pos)
		{
			return null;
		}

		// Token: 0x06002A67 RID: 10855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A67")]
		[Address(RVA = "0x53CA110", Offset = "0x53C8D10", VA = "0x1853CA110")]
		private static List<HeaderValue> ParseCookieHeader(string str)
		{
			return null;
		}

		// Token: 0x06002A68 RID: 10856 RVA: 0x00012228 File Offset: 0x00010428
		[Token(Token = "0x6002A68")]
		[Address(RVA = "0x53C9BE0", Offset = "0x53C87E0", VA = "0x1853C9BE0", Slot = "4")]
		public int CompareTo(Cookie other)
		{
			return 0;
		}

		// Token: 0x0400181A RID: 6170
		[Token(Token = "0x400181A")]
		private const int Version = 1;
	}
}
