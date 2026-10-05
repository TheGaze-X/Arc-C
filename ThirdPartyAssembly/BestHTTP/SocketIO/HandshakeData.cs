using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace BestHTTP.SocketIO
{
	// Token: 0x02000517 RID: 1303
	[Token(Token = "0x2000517")]
	public sealed class HandshakeData
	{
		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x06002B09 RID: 11017 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002B0A RID: 11018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000649")]
		public string Sid
		{
			[Token(Token = "0x6002B09")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002B0A")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x06002B0B RID: 11019 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002B0C RID: 11020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700064A")]
		public List<string> Upgrades
		{
			[Token(Token = "0x6002B0B")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002B0C")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x06002B0D RID: 11021 RVA: 0x00012588 File Offset: 0x00010788
		// (set) Token: 0x06002B0E RID: 11022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700064B")]
		public TimeSpan PingInterval
		{
			[Token(Token = "0x6002B0D")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return default(TimeSpan);
			}
			[Token(Token = "0x6002B0E")]
			[Address(RVA = "0xEFAAF0", Offset = "0xEF96F0", VA = "0x180EFAAF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x06002B0F RID: 11023 RVA: 0x000125A0 File Offset: 0x000107A0
		// (set) Token: 0x06002B10 RID: 11024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700064C")]
		public TimeSpan PingTimeout
		{
			[Token(Token = "0x6002B0F")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			[CompilerGenerated]
			get
			{
				return default(TimeSpan);
			}
			[Token(Token = "0x6002B10")]
			[Address(RVA = "0x20339E0", Offset = "0x20325E0", VA = "0x1820339E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002B11 RID: 11025 RVA: 0x000125B8 File Offset: 0x000107B8
		[Token(Token = "0x6002B11")]
		[Address(RVA = "0x53D3DE0", Offset = "0x53D29E0", VA = "0x1853D3DE0")]
		public bool Parse(string str)
		{
			return default(bool);
		}

		// Token: 0x06002B12 RID: 11026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B12")]
		[Address(RVA = "0x53D3D10", Offset = "0x53D2910", VA = "0x1853D3D10")]
		private static object Get(Dictionary<string, object> from, string key)
		{
			return null;
		}

		// Token: 0x06002B13 RID: 11027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B13")]
		[Address(RVA = "0x53D3CA0", Offset = "0x53D28A0", VA = "0x1853D3CA0")]
		private static string GetString(Dictionary<string, object> from, string key)
		{
			return null;
		}

		// Token: 0x06002B14 RID: 11028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B14")]
		[Address(RVA = "0x53D3AD0", Offset = "0x53D26D0", VA = "0x1853D3AD0")]
		private static List<string> GetStringList(Dictionary<string, object> from, string key)
		{
			return null;
		}

		// Token: 0x06002B15 RID: 11029 RVA: 0x000125D0 File Offset: 0x000107D0
		[Token(Token = "0x6002B15")]
		[Address(RVA = "0x53D3A50", Offset = "0x53D2650", VA = "0x1853D3A50")]
		private static int GetInt(Dictionary<string, object> from, string key)
		{
			return 0;
		}

		// Token: 0x06002B16 RID: 11030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B16")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HandshakeData()
		{
		}
	}
}
