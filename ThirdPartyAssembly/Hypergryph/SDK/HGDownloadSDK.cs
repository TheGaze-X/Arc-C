using System;
using Il2CppDummyDll;

namespace Hypergryph.SDK
{
	// Token: 0x02000105 RID: 261
	[Token(Token = "0x2000105")]
	public static class HGDownloadSDK
	{
		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600049C RID: 1180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700008E")]
		private static IHGDownloadSDK downloadSDK
		{
			[Token(Token = "0x600049C")]
			[Address(RVA = "0x544B870", Offset = "0x544A470", VA = "0x18544B870")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x00003A08 File Offset: 0x00001C08
		[Token(Token = "0x600049D")]
		[Address(RVA = "0x544B520", Offset = "0x544A120", VA = "0x18544B520")]
		public static int Init(string config)
		{
			return 0;
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x00003A20 File Offset: 0x00001C20
		[Token(Token = "0x600049E")]
		[Address(RVA = "0x544AF10", Offset = "0x5449B10", VA = "0x18544AF10")]
		public static long Download(string versionId, string downloadFiles, bool useMobileData, string decompressPath, bool needCompress, bool usePatch, string rootPath)
		{
			return 0L;
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x00003A38 File Offset: 0x00001C38
		[Token(Token = "0x600049F")]
		[Address(RVA = "0x544ADF0", Offset = "0x54499F0", VA = "0x18544ADF0")]
		public static long DownloadFolder(string versionId, string rootPath, string downloadFolders, bool useMobileData)
		{
			return 0L;
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x00003A50 File Offset: 0x00001C50
		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x544ACF0", Offset = "0x54498F0", VA = "0x18544ACF0")]
		public static int ClearUselessFiles(string rootPath, string allFiles)
		{
			return 0;
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x00003A68 File Offset: 0x00001C68
		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x544B060", Offset = "0x5449C60", VA = "0x18544B060")]
		public static int EnableMobileData(long taskId)
		{
			return 0;
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x00003A80 File Offset: 0x00001C80
		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x544B570", Offset = "0x544A170", VA = "0x18544B570")]
		public static int Pause(long taskId)
		{
			return 0;
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00003A98 File Offset: 0x00001C98
		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x544B5D0", Offset = "0x544A1D0", VA = "0x18544B5D0")]
		public static int Resume(long taskId)
		{
			return 0;
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x00003AB0 File Offset: 0x00001CB0
		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x544AC40", Offset = "0x5449840", VA = "0x18544AC40")]
		public static int Cancel(long taskId)
		{
			return 0;
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x00003AC8 File Offset: 0x00001CC8
		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x544ABE0", Offset = "0x54497E0", VA = "0x18544ABE0")]
		public static int CancelAndClear(long taskId)
		{
			return 0;
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x00003AE0 File Offset: 0x00001CE0
		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x544ACA0", Offset = "0x54498A0", VA = "0x18544ACA0")]
		public static int ClearAllTasks()
		{
			return 0;
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x00003AF8 File Offset: 0x00001CF8
		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x544B0C0", Offset = "0x5449CC0", VA = "0x18544B0C0")]
		public static int Finish(long taskId)
		{
			return 0;
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x00003B10 File Offset: 0x00001D10
		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x544B320", Offset = "0x5449F20", VA = "0x18544B320")]
		public static int GetSDKState()
		{
			return 0;
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x00003B28 File Offset: 0x00001D28
		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x544B460", Offset = "0x544A060", VA = "0x18544B460")]
		public static int GetTaskState(long taskId)
		{
			return 0;
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x544B370", Offset = "0x5449F70", VA = "0x18544B370")]
		public static string GetTaskInfo(long taskId)
		{
			return null;
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00003B40 File Offset: 0x00001D40
		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x544B180", Offset = "0x5449D80", VA = "0x18544B180")]
		public static long GetDownloadSpeed(long taskId)
		{
			return 0L;
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00003B58 File Offset: 0x00001D58
		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x544B1E0", Offset = "0x5449DE0", VA = "0x18544B1E0")]
		public static long GetDownloadedSize(long taskId)
		{
			return 0L;
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00003B70 File Offset: 0x00001D70
		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x544B4C0", Offset = "0x544A0C0", VA = "0x18544B4C0")]
		public static long GetTotalDownloadSize(long taskId)
		{
			return 0L;
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x00003B88 File Offset: 0x00001D88
		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x544B120", Offset = "0x5449D20", VA = "0x18544B120")]
		public static int GetDecompressedProgress(long taskId)
		{
			return 0;
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x00003BA0 File Offset: 0x00001DA0
		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x544B720", Offset = "0x544A320", VA = "0x18544B720")]
		public static int SetLanguageType(int type)
		{
			return 0;
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x00003BB8 File Offset: 0x00001DB8
		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x544B810", Offset = "0x544A410", VA = "0x18544B810")]
		public static int SetNotificationTitle(string title)
		{
			return 0;
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x00003BD0 File Offset: 0x00001DD0
		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x544B2B0", Offset = "0x5449EB0", VA = "0x18544B2B0")]
		public static long GetEstimatedDownloadSize(string versionId, string downloadFiles)
		{
			return 0L;
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x00003BE8 File Offset: 0x00001DE8
		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x544B240", Offset = "0x5449E40", VA = "0x18544B240")]
		public static long GetEstimatedDownloadFolderSize(string versionId, string downloadFolders)
		{
			return 0L;
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x00003C00 File Offset: 0x00001E00
		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x544B630", Offset = "0x544A230", VA = "0x18544B630")]
		public static long SetDownloadPath(string downloadPath)
		{
			return 0L;
		}

		// Token: 0x040005E4 RID: 1508
		[Token(Token = "0x40005E4")]
		[FieldOffset(Offset = "0x0")]
		private static IHGDownloadSDK s_dl;
	}
}
