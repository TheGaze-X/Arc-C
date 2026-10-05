using System;
using Hypergryph.SDK;
using Il2CppDummyDll;

namespace Torappu.SDK
{
	// Token: 0x0200019E RID: 414
	[Token(Token = "0x200019E")]
	public interface IGameUpdateInterface
	{
		// Token: 0x060009D1 RID: 2513
		[Token(Token = "0x60009D1")]
		int Init(string config, IHGGameUpdateSDKCallback callback);

		// Token: 0x060009D2 RID: 2514
		[Token(Token = "0x60009D2")]
		void GetLatestGame();

		// Token: 0x060009D3 RID: 2515
		[Token(Token = "0x60009D3")]
		long Update(int updateType, bool useMobileData);

		// Token: 0x060009D4 RID: 2516
		[Token(Token = "0x60009D4")]
		int EnableMobileData(long taskId);

		// Token: 0x060009D5 RID: 2517
		[Token(Token = "0x60009D5")]
		int GetTaskState(long taskId);

		// Token: 0x060009D6 RID: 2518
		[Token(Token = "0x60009D6")]
		int Pause(long taskId);

		// Token: 0x060009D7 RID: 2519
		[Token(Token = "0x60009D7")]
		int Resume(long taskId);

		// Token: 0x060009D8 RID: 2520
		[Token(Token = "0x60009D8")]
		int CancelAndClear(long taskId);

		// Token: 0x060009D9 RID: 2521
		[Token(Token = "0x60009D9")]
		int Cancel(long taskId);

		// Token: 0x060009DA RID: 2522
		[Token(Token = "0x60009DA")]
		int Install(long taskId);

		// Token: 0x060009DB RID: 2523
		[Token(Token = "0x60009DB")]
		int ClearAllTask();

		// Token: 0x060009DC RID: 2524
		[Token(Token = "0x60009DC")]
		long GetDownloadSpeed(long taskId);

		// Token: 0x060009DD RID: 2525
		[Token(Token = "0x60009DD")]
		long GetDownloadedSize(long taskId);

		// Token: 0x060009DE RID: 2526
		[Token(Token = "0x60009DE")]
		long GetTotalDownloadSize(long taskId);

		// Token: 0x060009DF RID: 2527
		[Token(Token = "0x60009DF")]
		long GetEstimatedDownloadSize(int updateType);

		// Token: 0x060009E0 RID: 2528
		[Token(Token = "0x60009E0")]
		int SetNotificationTitle(string titleConfig);
	}
}
