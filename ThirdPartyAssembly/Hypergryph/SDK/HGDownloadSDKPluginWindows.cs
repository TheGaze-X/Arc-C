using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Hypergryph.SDK
{
	// Token: 0x02000107 RID: 263
	[Token(Token = "0x2000107")]
	public class HGDownloadSDKPluginWindows : IHGDownloadSDK
	{
		// Token: 0x060004CC RID: 1228
		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x5449DA0", Offset = "0x54489A0", VA = "0x185449DA0")]
		[PreserveSig]
		public static extern int HGDLSDKInit(string config);

		// Token: 0x060004CD RID: 1229
		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x54496C0", Offset = "0x54482C0", VA = "0x1854496C0")]
		[PreserveSig]
		public static extern long HGDLSDKDownload(string version_id, string download_files, string decompress_path, bool need_decompress);

		// Token: 0x060004CE RID: 1230
		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x54495A0", Offset = "0x54481A0", VA = "0x1854495A0")]
		[PreserveSig]
		public static extern long HGDLSDKDownloadWithPatch(string version_id, string download_files, string decompress_path, bool need_decompress, bool use_patch, string root_path);

		// Token: 0x060004CF RID: 1231
		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x54494C0", Offset = "0x54480C0", VA = "0x1854494C0")]
		[PreserveSig]
		public static extern long HGDLSDKDownloadWithFolderPatch(string version_id, string root_path, string download_folders);

		// Token: 0x060004D0 RID: 1232
		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x5449390", Offset = "0x5447F90", VA = "0x185449390")]
		[PreserveSig]
		public static extern int HGDLSDKClearAllTasks();

		// Token: 0x060004D1 RID: 1233
		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x5449BB0", Offset = "0x54487B0", VA = "0x185449BB0")]
		[PreserveSig]
		public static extern int HGDLSDKGetSDKState();

		// Token: 0x060004D2 RID: 1234
		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x5449CA0", Offset = "0x54488A0", VA = "0x185449CA0")]
		[PreserveSig]
		public static extern int HGDLSDKGetTaskState(long task_id);

		// Token: 0x060004D3 RID: 1235
		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x5449E40", Offset = "0x5448A40", VA = "0x185449E40")]
		[PreserveSig]
		public static extern int HGDLSDKPause(long task_id);

		// Token: 0x060004D4 RID: 1236
		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x5449EC0", Offset = "0x5448AC0", VA = "0x185449EC0")]
		[PreserveSig]
		public static extern int HGDLSDKResume(long task_id);

		// Token: 0x060004D5 RID: 1237
		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x5449290", Offset = "0x5447E90", VA = "0x185449290")]
		[PreserveSig]
		public static extern int HGDLSDKCancelAndClear(long task_id);

		// Token: 0x060004D6 RID: 1238
		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x5449310", Offset = "0x5447F10", VA = "0x185449310")]
		[PreserveSig]
		public static extern int HGDLSDKCancel(long task_id);

		// Token: 0x060004D7 RID: 1239
		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x54497B0", Offset = "0x54483B0", VA = "0x1854497B0")]
		[PreserveSig]
		public static extern int HGDLSDKFinish(long task_id);

		// Token: 0x060004D8 RID: 1240
		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x5449C20", Offset = "0x5448820", VA = "0x185449C20")]
		[PreserveSig]
		public static extern IntPtr HGDLSDKGetTaskInfo(long task_id);

		// Token: 0x060004D9 RID: 1241
		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x5449930", Offset = "0x5448530", VA = "0x185449930")]
		[PreserveSig]
		public static extern long HGDLSDKGetDownloadSpeed(long task_id);

		// Token: 0x060004DA RID: 1242
		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x54499B0", Offset = "0x54485B0", VA = "0x1854499B0")]
		[PreserveSig]
		public static extern long HGDLSDKGetDownloadedSize(long task_id);

		// Token: 0x060004DB RID: 1243
		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x5449D20", Offset = "0x5448920", VA = "0x185449D20")]
		[PreserveSig]
		public static extern long HGDLSDKGetTotalDownloadSize(long task_id);

		// Token: 0x060004DC RID: 1244
		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x54498B0", Offset = "0x54484B0", VA = "0x1854498B0")]
		[PreserveSig]
		public static extern int HGDLSDKGetDecompressedProgress(long task_id);

		// Token: 0x060004DD RID: 1245
		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x5449AF0", Offset = "0x54486F0", VA = "0x185449AF0")]
		[PreserveSig]
		public static extern long HGDLSDKGetEstimatedDownloadSize(string version_id, string download_files);

		// Token: 0x060004DE RID: 1246
		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x5449830", Offset = "0x5448430", VA = "0x185449830")]
		[PreserveSig]
		public static extern void HGDLSDKFree(IntPtr pointer);

		// Token: 0x060004DF RID: 1247
		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x5449400", Offset = "0x5448000", VA = "0x185449400")]
		[PreserveSig]
		public static extern int HGDLSDKClearUselessFiles(string root_path, string all_files);

		// Token: 0x060004E0 RID: 1248
		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x5449A30", Offset = "0x5448630", VA = "0x185449A30")]
		[PreserveSig]
		public static extern long HGDLSDKGetEstimatedDownloadFolderSize(string version_id, string download_folders);

		// Token: 0x060004E1 RID: 1249
		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x5449F40", Offset = "0x5448B40", VA = "0x185449F40")]
		[PreserveSig]
		public static extern long HGDLSDKSetDownloadPath(string download_path);

		// Token: 0x060004E2 RID: 1250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HGDownloadSDKPluginWindows()
		{
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00003E28 File Offset: 0x00002028
		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x544A9A0", Offset = "0x54495A0", VA = "0x18544A9A0", Slot = "4")]
		public int init(string config)
		{
			return 0;
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x00003E40 File Offset: 0x00002040
		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x544A280", Offset = "0x5448E80", VA = "0x18544A280", Slot = "5")]
		public long download(string versionId, string downloadFiles, string decompressPath, bool useMobileData, bool needCompress, bool usePatch, string rootPath)
		{
			return 0L;
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x00003E58 File Offset: 0x00002058
		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x544A1A0", Offset = "0x5448DA0", VA = "0x18544A1A0", Slot = "6")]
		public long downloadFolder(string versionId, string rootPath, string downloadFolders, bool useMobileData)
		{
			return 0L;
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x00003E70 File Offset: 0x00002070
		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "8")]
		public int enableMobileData(long taskId)
		{
			return 0;
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x00003E88 File Offset: 0x00002088
		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x544AA40", Offset = "0x5449640", VA = "0x18544AA40", Slot = "9")]
		public int pause(long taskId)
		{
			return 0;
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x00003EA0 File Offset: 0x000020A0
		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x544AAC0", Offset = "0x54496C0", VA = "0x18544AAC0", Slot = "10")]
		public int resume(long taskId)
		{
			return 0;
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x00003EB8 File Offset: 0x000020B8
		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x544A060", Offset = "0x5448C60", VA = "0x18544A060", Slot = "11")]
		public int cancel(long taskId)
		{
			return 0;
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x00003ED0 File Offset: 0x000020D0
		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x5449FE0", Offset = "0x5448BE0", VA = "0x185449FE0", Slot = "12")]
		public int cancelAndClear(long taskId)
		{
			return 0;
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x00003EE8 File Offset: 0x000020E8
		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x5449390", Offset = "0x5447F90", VA = "0x185449390", Slot = "13")]
		public int clearAllTasks()
		{
			return 0;
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x00003F00 File Offset: 0x00002100
		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x544A3A0", Offset = "0x5448FA0", VA = "0x18544A3A0", Slot = "14")]
		public int finish(long taskId)
		{
			return 0;
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x00003F18 File Offset: 0x00002118
		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x5449BB0", Offset = "0x54487B0", VA = "0x185449BB0", Slot = "15")]
		public int getSDKState()
		{
			return 0;
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x00003F30 File Offset: 0x00002130
		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x544A8A0", Offset = "0x54494A0", VA = "0x18544A8A0", Slot = "16")]
		public int getTaskState(long taskId)
		{
			return 0;
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x544A720", Offset = "0x5449320", VA = "0x18544A720", Slot = "17")]
		public string getTaskInfo(long taskId)
		{
			return null;
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x00003F48 File Offset: 0x00002148
		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x544A4A0", Offset = "0x54490A0", VA = "0x18544A4A0", Slot = "18")]
		public long getDownloadSpeed(long taskId)
		{
			return 0L;
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x00003F60 File Offset: 0x00002160
		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x544A520", Offset = "0x5449120", VA = "0x18544A520", Slot = "19")]
		public long getDownloadedSize(long taskId)
		{
			return 0L;
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x00003F78 File Offset: 0x00002178
		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x544A920", Offset = "0x5449520", VA = "0x18544A920", Slot = "20")]
		public long getTotalDownloadSize(long taskId)
		{
			return 0L;
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x00003F90 File Offset: 0x00002190
		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x544A420", Offset = "0x5449020", VA = "0x18544A420", Slot = "21")]
		public int getDecompressedProgress(long taskId)
		{
			return 0;
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x00003FA8 File Offset: 0x000021A8
		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "22")]
		public int setLanguageType(int type)
		{
			return 0;
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x00003FC0 File Offset: 0x000021C0
		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "23")]
		public int setNotificationTitle(string title)
		{
			return 0;
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x00003FD8 File Offset: 0x000021D8
		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x544A660", Offset = "0x5449260", VA = "0x18544A660", Slot = "24")]
		public long getEstimatedDownloadSize(string versionId, string downloadFiles)
		{
			return 0L;
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x00003FF0 File Offset: 0x000021F0
		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x544A0E0", Offset = "0x5448CE0", VA = "0x18544A0E0", Slot = "7")]
		public int clearUselessFiles(string rootPath, string allFiles)
		{
			return 0;
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x00004008 File Offset: 0x00002208
		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x544A5A0", Offset = "0x54491A0", VA = "0x18544A5A0", Slot = "25")]
		public long getEstimatedDownloadFolderSize(string versionId, string downloadFolders)
		{
			return 0L;
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x00004020 File Offset: 0x00002220
		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x544AB40", Offset = "0x5449740", VA = "0x18544AB40", Slot = "26")]
		public long setDownloadPath(string downloadPath)
		{
			return 0L;
		}
	}
}
