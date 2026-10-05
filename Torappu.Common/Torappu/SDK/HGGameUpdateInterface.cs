using System;
using Hypergryph.SDK;
using Il2CppDummyDll;
using XLua;

namespace Torappu.SDK
{
	// Token: 0x020001A1 RID: 417
	[Token(Token = "0x20001A1")]
	public class HGGameUpdateInterface : Singleton<HGGameUpdateInterface>, IGameUpdateInterface
	{
		// Token: 0x060009E3 RID: 2531 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60009E3")]
		[Address(RVA = "0x55502F0", Offset = "0x554EEF0", VA = "0x1855502F0")]
		private HGGameUpdateInterface()
		{
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x00007514 File Offset: 0x00005714
		[Token(Token = "0x60009E4")]
		[Address(RVA = "0x554FFB0", Offset = "0x554EBB0", VA = "0x18554FFB0", Slot = "4")]
		public int Init(string config, IHGGameUpdateSDKCallback callback)
		{
			return 0;
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60009E5")]
		[Address(RVA = "0x554FE50", Offset = "0x554EA50", VA = "0x18554FE50", Slot = "5")]
		public void GetLatestGame()
		{
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x0000752C File Offset: 0x0000572C
		[Token(Token = "0x60009E6")]
		[Address(RVA = "0x5550250", Offset = "0x554EE50", VA = "0x185550250", Slot = "6")]
		public long Update(int updateType, bool useMobileData)
		{
			return 0L;
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x00007544 File Offset: 0x00005744
		[Token(Token = "0x60009E7")]
		[Address(RVA = "0x554FC50", Offset = "0x554E850", VA = "0x18554FC50", Slot = "7")]
		public int EnableMobileData(long taskId)
		{
			return 0;
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x0000755C File Offset: 0x0000575C
		[Token(Token = "0x60009E8")]
		[Address(RVA = "0x554FEB0", Offset = "0x554EAB0", VA = "0x18554FEB0", Slot = "8")]
		public int GetTaskState(long taskId)
		{
			return 0;
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x00007574 File Offset: 0x00005774
		[Token(Token = "0x60009E9")]
		[Address(RVA = "0x55500D0", Offset = "0x554ECD0", VA = "0x1855500D0", Slot = "9")]
		public int Pause(long taskId)
		{
			return 0;
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x0000758C File Offset: 0x0000578C
		[Token(Token = "0x60009EA")]
		[Address(RVA = "0x5550150", Offset = "0x554ED50", VA = "0x185550150", Slot = "10")]
		public int Resume(long taskId)
		{
			return 0;
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x000075A4 File Offset: 0x000057A4
		[Token(Token = "0x60009EB")]
		[Address(RVA = "0x554FAF0", Offset = "0x554E6F0", VA = "0x18554FAF0", Slot = "11")]
		public int CancelAndClear(long taskId)
		{
			return 0;
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x000075BC File Offset: 0x000057BC
		[Token(Token = "0x60009EC")]
		[Address(RVA = "0x554FB70", Offset = "0x554E770", VA = "0x18554FB70", Slot = "12")]
		public int Cancel(long taskId)
		{
			return 0;
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x000075D4 File Offset: 0x000057D4
		[Token(Token = "0x60009ED")]
		[Address(RVA = "0x5550050", Offset = "0x554EC50", VA = "0x185550050", Slot = "13")]
		public int Install(long taskId)
		{
			return 0;
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x000075EC File Offset: 0x000057EC
		[Token(Token = "0x60009EE")]
		[Address(RVA = "0x554FBF0", Offset = "0x554E7F0", VA = "0x18554FBF0", Slot = "14")]
		public int ClearAllTask()
		{
			return 0;
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x00007604 File Offset: 0x00005804
		[Token(Token = "0x60009EF")]
		[Address(RVA = "0x554FCD0", Offset = "0x554E8D0", VA = "0x18554FCD0", Slot = "15")]
		public long GetDownloadSpeed(long taskId)
		{
			return 0L;
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x0000761C File Offset: 0x0000581C
		[Token(Token = "0x60009F0")]
		[Address(RVA = "0x554FD50", Offset = "0x554E950", VA = "0x18554FD50", Slot = "16")]
		public long GetDownloadedSize(long taskId)
		{
			return 0L;
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x00007634 File Offset: 0x00005834
		[Token(Token = "0x60009F1")]
		[Address(RVA = "0x554FF30", Offset = "0x554EB30", VA = "0x18554FF30", Slot = "17")]
		public long GetTotalDownloadSize(long taskId)
		{
			return 0L;
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x0000764C File Offset: 0x0000584C
		[Token(Token = "0x60009F2")]
		[Address(RVA = "0x554FDD0", Offset = "0x554E9D0", VA = "0x18554FDD0", Slot = "18")]
		public long GetEstimatedDownloadSize(int updateType)
		{
			return 0L;
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x00007664 File Offset: 0x00005864
		[Token(Token = "0x60009F3")]
		[Address(RVA = "0x55501D0", Offset = "0x554EDD0", VA = "0x1855501D0", Slot = "19")]
		public int SetNotificationTitle(string titleConfig)
		{
			return 0;
		}

		// Token: 0x0400093A RID: 2362
		[Token(Token = "0x400093A")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;

		// Token: 0x0400093B RID: 2363
		[Token(Token = "0x400093B")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate216 __Hotfix0_Init;

		// Token: 0x0400093C RID: 2364
		[Token(Token = "0x400093C")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate1 __Hotfix0_GetLatestGame;

		// Token: 0x0400093D RID: 2365
		[Token(Token = "0x400093D")]
		[FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate217 __Hotfix0_Update;

		// Token: 0x0400093E RID: 2366
		[Token(Token = "0x400093E")]
		[FieldOffset(Offset = "0x20")]
		private static __XLua_Gen_Delegate218 __Hotfix0_EnableMobileData;

		// Token: 0x0400093F RID: 2367
		[Token(Token = "0x400093F")]
		[FieldOffset(Offset = "0x28")]
		private static __XLua_Gen_Delegate218 __Hotfix0_GetTaskState;

		// Token: 0x04000940 RID: 2368
		[Token(Token = "0x4000940")]
		[FieldOffset(Offset = "0x30")]
		private static __XLua_Gen_Delegate218 __Hotfix0_Pause;

		// Token: 0x04000941 RID: 2369
		[Token(Token = "0x4000941")]
		[FieldOffset(Offset = "0x38")]
		private static __XLua_Gen_Delegate218 __Hotfix0_Resume;

		// Token: 0x04000942 RID: 2370
		[Token(Token = "0x4000942")]
		[FieldOffset(Offset = "0x40")]
		private static __XLua_Gen_Delegate218 __Hotfix0_CancelAndClear;

		// Token: 0x04000943 RID: 2371
		[Token(Token = "0x4000943")]
		[FieldOffset(Offset = "0x48")]
		private static __XLua_Gen_Delegate218 __Hotfix0_Cancel;

		// Token: 0x04000944 RID: 2372
		[Token(Token = "0x4000944")]
		[FieldOffset(Offset = "0x50")]
		private static __XLua_Gen_Delegate218 __Hotfix0_Install;

		// Token: 0x04000945 RID: 2373
		[Token(Token = "0x4000945")]
		[FieldOffset(Offset = "0x58")]
		private static __XLua_Gen_Delegate25 __Hotfix0_ClearAllTask;

		// Token: 0x04000946 RID: 2374
		[Token(Token = "0x4000946")]
		[FieldOffset(Offset = "0x60")]
		private static __XLua_Gen_Delegate219 __Hotfix0_GetDownloadSpeed;

		// Token: 0x04000947 RID: 2375
		[Token(Token = "0x4000947")]
		[FieldOffset(Offset = "0x68")]
		private static __XLua_Gen_Delegate219 __Hotfix0_GetDownloadedSize;

		// Token: 0x04000948 RID: 2376
		[Token(Token = "0x4000948")]
		[FieldOffset(Offset = "0x70")]
		private static __XLua_Gen_Delegate219 __Hotfix0_GetTotalDownloadSize;

		// Token: 0x04000949 RID: 2377
		[Token(Token = "0x4000949")]
		[FieldOffset(Offset = "0x78")]
		private static __XLua_Gen_Delegate220 __Hotfix0_GetEstimatedDownloadSize;

		// Token: 0x0400094A RID: 2378
		[Token(Token = "0x400094A")]
		[FieldOffset(Offset = "0x80")]
		private static __XLua_Gen_Delegate221 __Hotfix0_SetNotificationTitle;
	}
}
