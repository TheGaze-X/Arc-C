using System;
using Il2CppDummyDll;

namespace Hypergryph.SDK
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	public interface IHGGameUpdateSDK
	{
		// Token: 0x0600000A RID: 10
		[Token(Token = "0x600000A")]
		int Init(string config);

		// Token: 0x0600000B RID: 11
		[Token(Token = "0x600000B")]
		void GetLatestGame(Action<string> onResult);

		// Token: 0x0600000C RID: 12
		[Token(Token = "0x600000C")]
		long Update(int updateType, bool useMobileData);

		// Token: 0x0600000D RID: 13
		[Token(Token = "0x600000D")]
		int EnableMobileData(long taskId);

		// Token: 0x0600000E RID: 14
		[Token(Token = "0x600000E")]
		int GetTaskState(long taskId);

		// Token: 0x0600000F RID: 15
		[Token(Token = "0x600000F")]
		int Pause(long taskId);

		// Token: 0x06000010 RID: 16
		[Token(Token = "0x6000010")]
		int Resume(long taskId);

		// Token: 0x06000011 RID: 17
		[Token(Token = "0x6000011")]
		int CancelAndClear(long taskId);

		// Token: 0x06000012 RID: 18
		[Token(Token = "0x6000012")]
		int Cancel(long taskId);

		// Token: 0x06000013 RID: 19
		[Token(Token = "0x6000013")]
		int Install(long taskId);

		// Token: 0x06000014 RID: 20
		[Token(Token = "0x6000014")]
		int ClearAllTask();

		// Token: 0x06000015 RID: 21
		[Token(Token = "0x6000015")]
		long GetDownloadSpeed(long taskId);

		// Token: 0x06000016 RID: 22
		[Token(Token = "0x6000016")]
		long GetDownloadedSize(long taskId);

		// Token: 0x06000017 RID: 23
		[Token(Token = "0x6000017")]
		long GetTotalDownloadSize(long taskId);

		// Token: 0x06000018 RID: 24
		[Token(Token = "0x6000018")]
		long GetEstimatedDownloadSize(int updateType);

		// Token: 0x06000019 RID: 25
		[Token(Token = "0x6000019")]
		int SetNotificationTitle(string titleConfig);

		// Token: 0x0600001A RID: 26
		[Token(Token = "0x600001A")]
		int SetEnv(string env);

		// Token: 0x0600001B RID: 27
		[Token(Token = "0x600001B")]
		string GetEnv();
	}
}
