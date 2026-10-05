using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace ACE
{
	// Token: 0x0200059D RID: 1437
	[Token(Token = "0x200059D")]
	public static class Tp2Sdk
	{
		// Token: 0x06003129 RID: 12585 RVA: 0x000155B8 File Offset: 0x000137B8
		[Token(Token = "0x6003129")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40")]
		public static bool IsEnabled()
		{
			return default(bool);
		}

		// Token: 0x0600312A RID: 12586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600312A")]
		[Address(RVA = "0x54369A0", Offset = "0x54355A0", VA = "0x1854369A0")]
		public static void Tp2RegistTssInfoReceiver(TssInfoReceiver receiver)
		{
		}

		// Token: 0x0600312B RID: 12587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600312B")]
		[Address(RVA = "0x5436350", Offset = "0x5434F50", VA = "0x185436350")]
		public static string Tp2DecTssInfo(string info)
		{
			return null;
		}

		// Token: 0x0600312C RID: 12588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600312C")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public static void Tp2SdkInitEx(int gameId, string appKey)
		{
		}

		// Token: 0x0600312D RID: 12589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600312D")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public static void Tp2UserLogin(int accountType, int worldId, string openId, string roleId)
		{
		}

		// Token: 0x0600312E RID: 12590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600312E")]
		[Address(RVA = "0x3CF2790", Offset = "0x3CF1390", VA = "0x183CF2790")]
		public static void Tp2SetGamestatus(Tp2GameStatus status)
		{
		}

		// Token: 0x0600312F RID: 12591 RVA: 0x000155D0 File Offset: 0x000137D0
		[Token(Token = "0x600312F")]
		[Address(RVA = "0x5436A00", Offset = "0x5435600", VA = "0x185436A00")]
		public static int Tp2SetLocale(int locale_id)
		{
			return 0;
		}

		// Token: 0x06003130 RID: 12592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003130")]
		[Address(RVA = "0x5436070", Offset = "0x5434C70", VA = "0x185436070")]
		public static void EnableGameReport()
		{
		}

		// Token: 0x06003131 RID: 12593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003131")]
		[Address(RVA = "0x54360C0", Offset = "0x5434CC0", VA = "0x1854360C0")]
		public static string Ioctl(int request, string cmd)
		{
			return null;
		}

		// Token: 0x06003132 RID: 12594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003132")]
		[Address(RVA = "0x5436830", Offset = "0x5435430", VA = "0x185436830")]
		public static string Tp2Ioctl(string cmd)
		{
			return null;
		}

		// Token: 0x06003133 RID: 12595 RVA: 0x000155E8 File Offset: 0x000137E8
		[Token(Token = "0x6003133")]
		[Address(RVA = "0x5436250", Offset = "0x5434E50", VA = "0x185436250")]
		private static bool Is64bit()
		{
			return default(bool);
		}

		// Token: 0x06003134 RID: 12596 RVA: 0x00015600 File Offset: 0x00013800
		[Token(Token = "0x6003134")]
		[Address(RVA = "0x5436230", Offset = "0x5434E30", VA = "0x185436230")]
		private static bool Is32bit()
		{
			return default(bool);
		}

		// Token: 0x06003135 RID: 12597 RVA: 0x00015618 File Offset: 0x00013818
		[Token(Token = "0x6003135")]
		[Address(RVA = "0x5436270", Offset = "0x5434E70", VA = "0x185436270")]
		private static IntPtr ReadIntPtr(IntPtr addr, int off)
		{
			return 0;
		}

		// Token: 0x06003136 RID: 12598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003136")]
		[Address(RVA = "0x54366E0", Offset = "0x54352E0", VA = "0x1854366E0")]
		public static byte[] Tp2GetReportData()
		{
			return null;
		}

		// Token: 0x06003137 RID: 12599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003137")]
		[Address(RVA = "0x54363A0", Offset = "0x5434FA0", VA = "0x1854363A0")]
		public static byte[] Tp2GetReportData2()
		{
			return null;
		}

		// Token: 0x06003138 RID: 12600 RVA: 0x00015630 File Offset: 0x00013830
		[Token(Token = "0x6003138")]
		[Address(RVA = "0x54364F0", Offset = "0x54350F0", VA = "0x1854364F0")]
		public static int Tp2GetReportData4Status(uint token)
		{
			return 0;
		}

		// Token: 0x06003139 RID: 12601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003139")]
		[Address(RVA = "0x5436590", Offset = "0x5435190", VA = "0x185436590")]
		public static byte[] Tp2GetReportData4(uint token)
		{
			return null;
		}

		// Token: 0x0600313A RID: 12602 RVA: 0x00015648 File Offset: 0x00013848
		[Token(Token = "0x600313A")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780")]
		public static int Tp2RecvSecSignature(string name, byte[] buf, uint buf_len, uint crc)
		{
			return 0;
		}

		// Token: 0x0600313B RID: 12603 RVA: 0x00015660 File Offset: 0x00013860
		[Token(Token = "0x600313B")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780")]
		private static int tp2_sdk_init_ex(int gameId, string appKey)
		{
			return 0;
		}

		// Token: 0x0600313C RID: 12604 RVA: 0x00015678 File Offset: 0x00013878
		[Token(Token = "0x600313C")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780")]
		private static int tp2_setuserinfo(int accountType, int worldId, string openId, string roleId)
		{
			return 0;
		}

		// Token: 0x0600313D RID: 12605 RVA: 0x00015690 File Offset: 0x00013890
		[Token(Token = "0x600313D")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780")]
		private static int tp2_setoptions(int options)
		{
			return 0;
		}

		// Token: 0x0600313E RID: 12606 RVA: 0x000156A8 File Offset: 0x000138A8
		[Token(Token = "0x600313E")]
		[Address(RVA = "0x5436A80", Offset = "0x5435680", VA = "0x185436A80")]
		private static IntPtr tp2_sdk_ioctl(int request, string param)
		{
			return 0;
		}

		// Token: 0x0600313F RID: 12607 RVA: 0x000156C0 File Offset: 0x000138C0
		[Token(Token = "0x600313F")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780")]
		private static int tp2_free_anti_data(IntPtr info)
		{
			return 0;
		}

		// Token: 0x06003140 RID: 12608 RVA: 0x000156D8 File Offset: 0x000138D8
		[Token(Token = "0x6003140")]
		[Address(RVA = "0x5436B40", Offset = "0x5435740", VA = "0x185436B40")]
		private static IntPtr tss_get_report_data()
		{
			return 0;
		}

		// Token: 0x06003141 RID: 12609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003141")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public static void tss_del_report_data(IntPtr info)
		{
		}

		// Token: 0x06003142 RID: 12610 RVA: 0x000156F0 File Offset: 0x000138F0
		[Token(Token = "0x6003142")]
		[Address(RVA = "0x5436AC0", Offset = "0x54356C0", VA = "0x185436AC0")]
		private static IntPtr tss_get_report_data2()
		{
			return 0;
		}

		// Token: 0x06003143 RID: 12611 RVA: 0x00015708 File Offset: 0x00013908
		[Token(Token = "0x6003143")]
		[Address(RVA = "0x5436B00", Offset = "0x5435700", VA = "0x185436B00")]
		private static IntPtr tss_get_report_data4(uint token)
		{
			return 0;
		}

		// Token: 0x06003144 RID: 12612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003144")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private static void tss_del_report_data4(IntPtr info)
		{
		}

		// Token: 0x06003145 RID: 12613 RVA: 0x00015720 File Offset: 0x00013920
		[Token(Token = "0x6003145")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780")]
		public static int tss_recv_sec_signature(string name, byte[] data, uint data_len, uint crc)
		{
			return 0;
		}

		// Token: 0x04001B26 RID: 6950
		[Token(Token = "0x4001B26")]
		public const int TssSDKCmd_IsEmulator = 10;

		// Token: 0x04001B27 RID: 6951
		[Token(Token = "0x4001B27")]
		private const int TssSDKCmd_CommQuery = 18;

		// Token: 0x0200059E RID: 1438
		[Token(Token = "0x200059E")]
		[StructLayout(0)]
		private class AntiDataInfo
		{
			// Token: 0x06003146 RID: 12614 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003146")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AntiDataInfo()
			{
			}

			// Token: 0x04001B28 RID: 6952
			[Token(Token = "0x4001B28")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ushort anti_data_len;

			// Token: 0x04001B29 RID: 6953
			[Token(Token = "0x4001B29")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public IntPtr anti_data;
		}

		// Token: 0x0200059F RID: 1439
		[Token(Token = "0x200059F")]
		[StructLayout(0)]
		private class SecScanInfo
		{
			// Token: 0x06003147 RID: 12615 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003147")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SecScanInfo()
			{
			}

			// Token: 0x04001B2A RID: 6954
			[Token(Token = "0x4001B2A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int sec_scan_status;

			// Token: 0x04001B2B RID: 6955
			[Token(Token = "0x4001B2B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public ushort scan_data_len;

			// Token: 0x04001B2C RID: 6956
			[Token(Token = "0x4001B2C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public IntPtr scan_data;
		}
	}
}
