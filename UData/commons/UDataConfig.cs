using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UDatasdk.LitJson;

namespace UDatasdk.commons
{
	// Token: 0x02000030 RID: 48
	[Token(Token = "0x2000030")]
	internal class UDataConfig
	{
		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x000020B2 File Offset: 0x000002B2
		// (set) Token: 0x060001D4 RID: 468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000061")]
		private string eventLogsPath
		{
			[Token(Token = "0x60001D3")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001D4")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x000020B2 File Offset: 0x000002B2
		// (set) Token: 0x060001D6 RID: 470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000062")]
		private string crashLogsPath
		{
			[Token(Token = "0x60001D5")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001D6")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x55C53D0", Offset = "0x55C3FD0", VA = "0x1855C53D0")]
		private UDataConfig()
		{
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x17000063")]
		public static UDataConfig Instance
		{
			[Token(Token = "0x60001D8")]
			[Address(RVA = "0x55C54A0", Offset = "0x55C40A0", VA = "0x1855C54A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x000020B2 File Offset: 0x000002B2
		// (set) Token: 0x060001DA RID: 474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000064")]
		public JsonData EventDataInfo
		{
			[Token(Token = "0x60001D9")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001DA")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			set
			{
			}
		}

		// Token: 0x060001DB RID: 475 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x55C4DE0", Offset = "0x55C39E0", VA = "0x1855C4DE0")]
		public JsonData ReadEventDataInfo()
		{
			return null;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x55C5260", Offset = "0x55C3E60", VA = "0x1855C5260")]
		public void Save()
		{
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x55C46E0", Offset = "0x55C32E0", VA = "0x1855C46E0")]
		public void DeleteEventDataInfo()
		{
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x55C43A0", Offset = "0x55C2FA0", VA = "0x1855C43A0")]
		public void CreateEventDirectory()
		{
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x55C50C0", Offset = "0x55C3CC0", VA = "0x1855C50C0")]
		public void SavePreparedEventData(string id, string eventData)
		{
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00002B80 File Offset: 0x00000D80
		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x55C4B60", Offset = "0x55C3760", VA = "0x1855C4B60")]
		public ValueTuple<List<string>, List<string>> ReadAllEventLogs()
		{
			return default(ValueTuple<List<string>, List<string>>);
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x55C4770", Offset = "0x55C3370", VA = "0x1855C4770")]
		public void DeleteLogWithIds(List<string> ids)
		{
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x55C45B0", Offset = "0x55C31B0", VA = "0x1855C45B0")]
		public void DeleteAllEventLogs()
		{
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x55C42C0", Offset = "0x55C2EC0", VA = "0x1855C42C0")]
		private void CreateCrashDirectory()
		{
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00002B98 File Offset: 0x00000D98
		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x55C4EB0", Offset = "0x55C3AB0", VA = "0x1855C4EB0")]
		public bool SaveCrashReport(string content)
		{
			return default(bool);
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x55C49B0", Offset = "0x55C35B0", VA = "0x1855C49B0")]
		public string ReadAllCrashLogs()
		{
			return null;
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x55C4480", Offset = "0x55C3080", VA = "0x1855C4480")]
		public void DeleteAllCrashLogs()
		{
		}

		// Token: 0x040000E1 RID: 225
		[Token(Token = "0x40000E1")]
		[FieldOffset(Offset = "0x0")]
		private static UDataConfig instance;

		// Token: 0x040000E2 RID: 226
		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0x8")]
		private static readonly object lockObject;

		// Token: 0x040000E3 RID: 227
		[Token(Token = "0x40000E3")]
		public const string EventLogs = "EventLogs";

		// Token: 0x040000E4 RID: 228
		[Token(Token = "0x40000E4")]
		public const string CrashLogs = "CrashLogs";

		// Token: 0x040000E5 RID: 229
		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x20")]
		private JsonData eventDataInfo;
	}
}
