using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Hypergryph.SDK;
using Il2CppDummyDll;
using Torappu.SDK;
using UnityEngine;
using XLua;

namespace Torappu.UI.HotUpdate
{
	// Token: 0x02004AA5 RID: 19109
	[Token(Token = "0x2004AA5")]
	public class GameUpdateSDK : IHotfixable, IGameUpdate
	{
		// Token: 0x0601CB43 RID: 117571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CB43")]
		[Address(RVA = "0x16223D0", Offset = "0x1620FD0", VA = "0x1816223D0")]
		public GameUpdateSDK(GameUpdateOptions options)
		{
		}

		// Token: 0x0601CB44 RID: 117572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CB44")]
		[Address(RVA = "0x16219F0", Offset = "0x16205F0", VA = "0x1816219F0", Slot = "4")]
		public IEnumerator DoUpdate(GameUpdateResult result)
		{
			return null;
		}

		// Token: 0x0601CB45 RID: 117573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CB45")]
		[Address(RVA = "0x1622180", Offset = "0x1620D80", VA = "0x181622180")]
		private IEnumerator _UpdateGame(GameUpdateContext context)
		{
			return null;
		}

		// Token: 0x0601CB46 RID: 117574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CB46")]
		[Address(RVA = "0x1621B90", Offset = "0x1620790", VA = "0x181621B90")]
		private IEnumerator _LoopAlertAndTriggerStoreRedirect(GameUpdateContext context, HGLatestGameInfo gameInfo)
		{
			return null;
		}

		// Token: 0x0601CB47 RID: 117575 RVA: 0x000A9260 File Offset: 0x000A7460
		[Token(Token = "0x601CB47")]
		[Address(RVA = "0x1621E30", Offset = "0x1620A30", VA = "0x181621E30")]
		private long _StartUpdateAndCheckResult(GameUpdateContext context, HGLatestGameInfo gameInfo, bool enableMobileData)
		{
			return 0L;
		}

		// Token: 0x0601CB48 RID: 117576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CB48")]
		[Address(RVA = "0x1622080", Offset = "0x1620C80", VA = "0x181622080")]
		private IEnumerator _TryTaskUpdating(GameUpdateContext context, HGLatestGameInfo gameInfo)
		{
			return null;
		}

		// Token: 0x0601CB49 RID: 117577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CB49")]
		[Address(RVA = "0x1621AC0", Offset = "0x16206C0", VA = "0x181621AC0")]
		private IEnumerator _DoTaskUpdating(GameUpdateContext context)
		{
			return null;
		}

		// Token: 0x0601CB4A RID: 117578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CB4A")]
		[Address(RVA = "0x1622310", Offset = "0x1620F10", VA = "0x181622310")]
		private IEnumerator _YieldCheckNetUsagePolicy(long downloadSize)
		{
			return null;
		}

		// Token: 0x0601CB4B RID: 117579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CB4B")]
		[Address(RVA = "0x1622250", Offset = "0x1620E50", VA = "0x181622250")]
		private IEnumerator _WaitForTaskCancel(long taskId)
		{
			return null;
		}

		// Token: 0x0601CB4C RID: 117580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CB4C")]
		[Address(RVA = "0x1621C90", Offset = "0x1620890", VA = "0x181621C90")]
		private void _SetTitleNotification(string titleWork, string titlePause)
		{
		}

		// Token: 0x04025B06 RID: 154374
		[Token(Token = "0x4025B06")]
		private const float COOLDOWN_INSTALL = 1f;

		// Token: 0x04025B07 RID: 154375
		[Token(Token = "0x4025B07")]
		private const int ERROR_CODE_NETWORK = 1103;

		// Token: 0x04025B08 RID: 154376
		[Token(Token = "0x4025B08")]
		[FieldOffset(Offset = "0x10")]
		private GameUpdateOptions m_options;

		// Token: 0x04025B09 RID: 154377
		[Token(Token = "0x4025B09")]
		[FieldOffset(Offset = "0x40")]
		private IGameUpdateInterface m_sdkImpl;

		// Token: 0x04025B0A RID: 154378
		[Token(Token = "0x4025B0A")]
		[FieldOffset(Offset = "0x48")]
		private bool m_hasUpdateAlerted;

		// Token: 0x04025B0B RID: 154379
		[Token(Token = "0x4025B0B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04025B0C RID: 154380
		[Token(Token = "0x4025B0C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoUpdate;

		// Token: 0x04025B0D RID: 154381
		[Token(Token = "0x4025B0D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateGame;

		// Token: 0x04025B0E RID: 154382
		[Token(Token = "0x4025B0E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LoopAlertAndTriggerStoreRedirect;

		// Token: 0x04025B0F RID: 154383
		[Token(Token = "0x4025B0F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__StartUpdateAndCheckResult;

		// Token: 0x04025B10 RID: 154384
		[Token(Token = "0x4025B10")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TryTaskUpdating;

		// Token: 0x04025B11 RID: 154385
		[Token(Token = "0x4025B11")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__DoTaskUpdating;

		// Token: 0x04025B12 RID: 154386
		[Token(Token = "0x4025B12")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__YieldCheckNetUsagePolicy;

		// Token: 0x04025B13 RID: 154387
		[Token(Token = "0x4025B13")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__WaitForTaskCancel;

		// Token: 0x04025B14 RID: 154388
		[Token(Token = "0x4025B14")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__SetTitleNotification;

		// Token: 0x02004AA6 RID: 19110
		[Token(Token = "0x2004AA6")]
		private class Callback : CustomYieldInstruction, IHGGameUpdateSDKCallback
		{
			// Token: 0x0601CB4D RID: 117581 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CB4D")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private Callback()
			{
			}

			// Token: 0x0601CB4E RID: 117582 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CB4E")]
			[Address(RVA = "0x1620660", Offset = "0x161F260", VA = "0x181620660")]
			public void Clear()
			{
			}

			// Token: 0x170043B2 RID: 17330
			// (get) Token: 0x0601CB4F RID: 117583 RVA: 0x000A9278 File Offset: 0x000A7478
			[Token(Token = "0x170043B2")]
			public override bool keepWaiting
			{
				[Token(Token = "0x601CB4F")]
				[Address(RVA = "0x160BEE0", Offset = "0x160AAE0", VA = "0x18160BEE0", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170043B3 RID: 17331
			// (get) Token: 0x0601CB50 RID: 117584 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601CB51 RID: 117585 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170043B3")]
			public string data
			{
				[Token(Token = "0x601CB50")]
				[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601CB51")]
				[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0601CB52 RID: 117586 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CB52")]
			[Address(RVA = "0x1620700", Offset = "0x161F300", VA = "0x181620700", Slot = "9")]
			public void onLatestGame(string pData)
			{
			}

			// Token: 0x04025B15 RID: 154389
			[Token(Token = "0x4025B15")]
			[FieldOffset(Offset = "0x10")]
			private bool m_complete;

			// Token: 0x04025B16 RID: 154390
			[Token(Token = "0x4025B16")]
			[FieldOffset(Offset = "0x0")]
			public static GameUpdateSDK.Callback instance;
		}
	}
}
