using System;
using Il2CppDummyDll;

namespace Hypergryph.SDK
{
	// Token: 0x02000104 RID: 260
	[Token(Token = "0x2000104")]
	public interface IHGDownloadSDK
	{
		// Token: 0x06000485 RID: 1157
		[Token(Token = "0x6000485")]
		int init(string config);

		// Token: 0x06000486 RID: 1158
		[Token(Token = "0x6000486")]
		long download(string versionId, string downloadFiles, string decompressPath, bool useMobileData, bool needCompress, bool usePatch, string rootPath);

		// Token: 0x06000487 RID: 1159
		[Token(Token = "0x6000487")]
		long downloadFolder(string versionId, string rootPath, string downloadFolders, bool useMobileData);

		// Token: 0x06000488 RID: 1160
		[Token(Token = "0x6000488")]
		int clearUselessFiles(string rootPath, string allFiles);

		// Token: 0x06000489 RID: 1161
		[Token(Token = "0x6000489")]
		int enableMobileData(long taskId);

		// Token: 0x0600048A RID: 1162
		[Token(Token = "0x600048A")]
		int pause(long taskId);

		// Token: 0x0600048B RID: 1163
		[Token(Token = "0x600048B")]
		int resume(long taskId);

		// Token: 0x0600048C RID: 1164
		[Token(Token = "0x600048C")]
		int cancel(long taskId);

		// Token: 0x0600048D RID: 1165
		[Token(Token = "0x600048D")]
		int cancelAndClear(long taskId);

		// Token: 0x0600048E RID: 1166
		[Token(Token = "0x600048E")]
		int clearAllTasks();

		// Token: 0x0600048F RID: 1167
		[Token(Token = "0x600048F")]
		int finish(long taskId);

		// Token: 0x06000490 RID: 1168
		[Token(Token = "0x6000490")]
		int getSDKState();

		// Token: 0x06000491 RID: 1169
		[Token(Token = "0x6000491")]
		int getTaskState(long taskId);

		// Token: 0x06000492 RID: 1170
		[Token(Token = "0x6000492")]
		string getTaskInfo(long taskId);

		// Token: 0x06000493 RID: 1171
		[Token(Token = "0x6000493")]
		long getDownloadSpeed(long taskId);

		// Token: 0x06000494 RID: 1172
		[Token(Token = "0x6000494")]
		long getDownloadedSize(long taskId);

		// Token: 0x06000495 RID: 1173
		[Token(Token = "0x6000495")]
		long getTotalDownloadSize(long taskId);

		// Token: 0x06000496 RID: 1174
		[Token(Token = "0x6000496")]
		int getDecompressedProgress(long taskId);

		// Token: 0x06000497 RID: 1175
		[Token(Token = "0x6000497")]
		int setLanguageType(int type);

		// Token: 0x06000498 RID: 1176
		[Token(Token = "0x6000498")]
		int setNotificationTitle(string title);

		// Token: 0x06000499 RID: 1177
		[Token(Token = "0x6000499")]
		long getEstimatedDownloadSize(string versionId, string downloadFiles);

		// Token: 0x0600049A RID: 1178
		[Token(Token = "0x600049A")]
		long getEstimatedDownloadFolderSize(string versionId, string downloadFolders);

		// Token: 0x0600049B RID: 1179
		[Token(Token = "0x600049B")]
		long setDownloadPath(string downloadPath);
	}
}
