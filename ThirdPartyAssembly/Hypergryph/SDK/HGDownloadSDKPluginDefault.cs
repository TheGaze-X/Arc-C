using System;
using Il2CppDummyDll;

namespace Hypergryph.SDK
{
	// Token: 0x02000106 RID: 262
	[Token(Token = "0x2000106")]
	public class HGDownloadSDKPluginDefault : IHGDownloadSDK
	{
		// Token: 0x060004B4 RID: 1204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HGDownloadSDKPluginDefault()
		{
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x00003C18 File Offset: 0x00001E18
		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x5449230", Offset = "0x5447E30", VA = "0x185449230", Slot = "4")]
		public int init(string config)
		{
			return 0;
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x00003C30 File Offset: 0x00001E30
		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x5449150", Offset = "0x5447D50", VA = "0x185449150", Slot = "5")]
		public long download(string versionId, string downloadFiles, string decompressPath, bool useMobileData, bool needCompress, bool usePatch, string rootPath)
		{
			return 0L;
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00003C48 File Offset: 0x00001E48
		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x5449160", Offset = "0x5447D60", VA = "0x185449160", Slot = "8")]
		public int enableMobileData(long taskId)
		{
			return 0;
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00003C60 File Offset: 0x00001E60
		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x5449240", Offset = "0x5447E40", VA = "0x185449240", Slot = "9")]
		public int pause(long taskId)
		{
			return 0;
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00003C78 File Offset: 0x00001E78
		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x5449250", Offset = "0x5447E50", VA = "0x185449250", Slot = "10")]
		public int resume(long taskId)
		{
			return 0;
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00003C90 File Offset: 0x00001E90
		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x5449110", Offset = "0x5447D10", VA = "0x185449110", Slot = "11")]
		public int cancel(long taskId)
		{
			return 0;
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00003CA8 File Offset: 0x00001EA8
		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x5449100", Offset = "0x5447D00", VA = "0x185449100", Slot = "12")]
		public int cancelAndClear(long taskId)
		{
			return 0;
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00003CC0 File Offset: 0x00001EC0
		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x5449120", Offset = "0x5447D20", VA = "0x185449120", Slot = "13")]
		public int clearAllTasks()
		{
			return 0;
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00003CD8 File Offset: 0x00001ED8
		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x5449170", Offset = "0x5447D70", VA = "0x185449170", Slot = "14")]
		public int finish(long taskId)
		{
			return 0;
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00003CF0 File Offset: 0x00001EF0
		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x54491D0", Offset = "0x5447DD0", VA = "0x1854491D0", Slot = "15")]
		public int getSDKState()
		{
			return 0;
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00003D08 File Offset: 0x00001F08
		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x5449210", Offset = "0x5447E10", VA = "0x185449210", Slot = "16")]
		public int getTaskState(long taskId)
		{
			return 0;
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x54491E0", Offset = "0x5447DE0", VA = "0x1854491E0", Slot = "17")]
		public string getTaskInfo(long taskId)
		{
			return null;
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x00003D20 File Offset: 0x00001F20
		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x5449190", Offset = "0x5447D90", VA = "0x185449190", Slot = "18")]
		public long getDownloadSpeed(long taskId)
		{
			return 0L;
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00003D38 File Offset: 0x00001F38
		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x54491A0", Offset = "0x5447DA0", VA = "0x1854491A0", Slot = "19")]
		public long getDownloadedSize(long taskId)
		{
			return 0L;
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00003D50 File Offset: 0x00001F50
		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x5449220", Offset = "0x5447E20", VA = "0x185449220", Slot = "20")]
		public long getTotalDownloadSize(long taskId)
		{
			return 0L;
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00003D68 File Offset: 0x00001F68
		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x5449180", Offset = "0x5447D80", VA = "0x185449180", Slot = "21")]
		public int getDecompressedProgress(long taskId)
		{
			return 0;
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00003D80 File Offset: 0x00001F80
		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x5449270", Offset = "0x5447E70", VA = "0x185449270", Slot = "22")]
		public int setLanguageType(int type)
		{
			return 0;
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x00003D98 File Offset: 0x00001F98
		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x5449280", Offset = "0x5447E80", VA = "0x185449280", Slot = "23")]
		public int setNotificationTitle(string title)
		{
			return 0;
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00003DB0 File Offset: 0x00001FB0
		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x54491C0", Offset = "0x5447DC0", VA = "0x1854491C0", Slot = "24")]
		public long getEstimatedDownloadSize(string versionId, string downloadFiles)
		{
			return 0L;
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00003DC8 File Offset: 0x00001FC8
		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x5449130", Offset = "0x5447D30", VA = "0x185449130", Slot = "7")]
		public int clearUselessFiles(string rootPath, string allFiles)
		{
			return 0;
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00003DE0 File Offset: 0x00001FE0
		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x54491B0", Offset = "0x5447DB0", VA = "0x1854491B0", Slot = "25")]
		public long getEstimatedDownloadFolderSize(string versionId, string downloadFolders)
		{
			return 0L;
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00003DF8 File Offset: 0x00001FF8
		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x5449140", Offset = "0x5447D40", VA = "0x185449140", Slot = "6")]
		public long downloadFolder(string versionId, string rootPath, string downloadFolders, bool useMobileData)
		{
			return 0L;
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00003E10 File Offset: 0x00002010
		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x5449260", Offset = "0x5447E60", VA = "0x185449260", Slot = "26")]
		public long setDownloadPath(string downloadPath)
		{
			return 0L;
		}
	}
}
