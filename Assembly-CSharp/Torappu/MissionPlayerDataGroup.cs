using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A8B RID: 2699
	[Token(Token = "0x2000A8B")]
	public class MissionPlayerDataGroup : Dictionary<string, Dictionary<string, MissionPlayerState>>
	{
		// Token: 0x17000CE7 RID: 3303
		// (get) Token: 0x06006745 RID: 26437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CE7")]
		public Dictionary<string, MissionPlayerState> Main
		{
			[Token(Token = "0x6006745")]
			[Address(RVA = "0x1EEBCC0", Offset = "0x1EEA8C0", VA = "0x181EEBCC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CE8 RID: 3304
		// (get) Token: 0x06006746 RID: 26438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CE8")]
		public Dictionary<string, MissionPlayerState> Sub
		{
			[Token(Token = "0x6006746")]
			[Address(RVA = "0x1EEBDE0", Offset = "0x1EEA9E0", VA = "0x181EEBDE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CE9 RID: 3305
		// (get) Token: 0x06006747 RID: 26439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CE9")]
		public Dictionary<string, MissionPlayerState> Guide
		{
			[Token(Token = "0x6006747")]
			[Address(RVA = "0x1EEBC30", Offset = "0x1EEA830", VA = "0x181EEBC30")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CEA RID: 3306
		// (get) Token: 0x06006748 RID: 26440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CEA")]
		public Dictionary<string, MissionPlayerState> Activity
		{
			[Token(Token = "0x6006748")]
			[Address(RVA = "0x1EEBB10", Offset = "0x1EEA710", VA = "0x181EEBB10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CEB RID: 3307
		// (get) Token: 0x06006749 RID: 26441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CEB")]
		public Dictionary<string, MissionPlayerState> Daily
		{
			[Token(Token = "0x6006749")]
			[Address(RVA = "0x1EEBBA0", Offset = "0x1EEA7A0", VA = "0x181EEBBA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CEC RID: 3308
		// (get) Token: 0x0600674A RID: 26442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CEC")]
		public Dictionary<string, MissionPlayerState> Weekly
		{
			[Token(Token = "0x600674A")]
			[Address(RVA = "0x1EEBE70", Offset = "0x1EEAA70", VA = "0x181EEBE70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CED RID: 3309
		// (get) Token: 0x0600674B RID: 26443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CED")]
		public Dictionary<string, MissionPlayerState> OpenServer
		{
			[Token(Token = "0x600674B")]
			[Address(RVA = "0x1EEBD50", Offset = "0x1EEA950", VA = "0x181EEBD50")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CEE RID: 3310
		// (get) Token: 0x0600674C RID: 26444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CEE")]
		public Dictionary<string, MissionPlayerState> retro
		{
			[Token(Token = "0x600674C")]
			[Address(RVA = "0x1EEBF00", Offset = "0x1EEAB00", VA = "0x181EEBF00")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CEF RID: 3311
		// (get) Token: 0x0600674D RID: 26445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CEF")]
		public Dictionary<string, MissionPlayerState> specialOperator
		{
			[Token(Token = "0x600674D")]
			[Address(RVA = "0x1EEC020", Offset = "0x1EEAC20", VA = "0x181EEC020")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CF0 RID: 3312
		// (get) Token: 0x0600674E RID: 26446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CF0")]
		public Dictionary<string, MissionPlayerState> specialOperatorWeekly
		{
			[Token(Token = "0x600674E")]
			[Address(RVA = "0x1EEBF90", Offset = "0x1EEAB90", VA = "0x181EEBF90")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600674F RID: 26447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600674F")]
		[Address(RVA = "0x1EEBA60", Offset = "0x1EEA660", VA = "0x181EEBA60")]
		public Dictionary<string, MissionPlayerState> GetMissionByType(string missionType)
		{
			return null;
		}

		// Token: 0x06006750 RID: 26448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006750")]
		[Address(RVA = "0x1EEBAD0", Offset = "0x1EEA6D0", VA = "0x181EEBAD0")]
		public MissionPlayerDataGroup()
		{
		}

		// Token: 0x02000A8C RID: 2700
		[Token(Token = "0x2000A8C")]
		public class MissionTypeString
		{
			// Token: 0x06006751 RID: 26449 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006751")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public MissionTypeString()
			{
			}

			// Token: 0x04003924 RID: 14628
			[Token(Token = "0x4003924")]
			public const string DAILY = "DAILY";

			// Token: 0x04003925 RID: 14629
			[Token(Token = "0x4003925")]
			public const string WEEKLY = "WEEKLY";

			// Token: 0x04003926 RID: 14630
			[Token(Token = "0x4003926")]
			public const string ACTIVITY = "ACTIVITY";

			// Token: 0x04003927 RID: 14631
			[Token(Token = "0x4003927")]
			public const string MAIN = "MAIN";

			// Token: 0x04003928 RID: 14632
			[Token(Token = "0x4003928")]
			public const string SUB = "SUB";

			// Token: 0x04003929 RID: 14633
			[Token(Token = "0x4003929")]
			public const string GUIDE = "GUIDE";

			// Token: 0x0400392A RID: 14634
			[Token(Token = "0x400392A")]
			public const string OPENSERVER = "OPENSERVER";

			// Token: 0x0400392B RID: 14635
			[Token(Token = "0x400392B")]
			public const string RETRO = "RETRO";

			// Token: 0x0400392C RID: 14636
			[Token(Token = "0x400392C")]
			public const string SPECIAL_OPERATOR = "SPECIAL_OPERATOR";

			// Token: 0x0400392D RID: 14637
			[Token(Token = "0x400392D")]
			public const string SPECIAL_OPERATOR_WEEKLY = "SPECIAL_OPERATOR_WEEKLY";
		}
	}
}
