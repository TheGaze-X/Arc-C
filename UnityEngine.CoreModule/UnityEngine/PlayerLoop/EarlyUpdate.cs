using System;
using Il2CppDummyDll;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.PlayerLoop
{
	// Token: 0x020001B2 RID: 434
	[Token(Token = "0x20001B2")]
	[RequiredByNativeCode]
	[MovedFrom("UnityEngine.Experimental.PlayerLoop")]
	public struct EarlyUpdate
	{
		// Token: 0x020001B3 RID: 435
		[Token(Token = "0x20001B3")]
		[RequiredByNativeCode]
		public struct PollPlayerConnection
		{
		}

		// Token: 0x020001B4 RID: 436
		[Token(Token = "0x20001B4")]
		[RequiredByNativeCode]
		public struct PollHtcsPlayerConnection
		{
		}

		// Token: 0x020001B5 RID: 437
		[Token(Token = "0x20001B5")]
		[RequiredByNativeCode]
		public struct GpuTimestamp
		{
		}

		// Token: 0x020001B6 RID: 438
		[Token(Token = "0x20001B6")]
		[RequiredByNativeCode]
		public struct AnalyticsCoreStatsUpdate
		{
		}

		// Token: 0x020001B7 RID: 439
		[Token(Token = "0x20001B7")]
		[RequiredByNativeCode]
		public struct UnityWebRequestUpdate
		{
		}

		// Token: 0x020001B8 RID: 440
		[Token(Token = "0x20001B8")]
		[RequiredByNativeCode]
		public struct UpdateStreamingManager
		{
		}

		// Token: 0x020001B9 RID: 441
		[Token(Token = "0x20001B9")]
		[RequiredByNativeCode]
		public struct ExecuteMainThreadJobs
		{
		}

		// Token: 0x020001BA RID: 442
		[Token(Token = "0x20001BA")]
		[RequiredByNativeCode]
		public struct ProcessMouseInWindow
		{
		}

		// Token: 0x020001BB RID: 443
		[Token(Token = "0x20001BB")]
		[RequiredByNativeCode]
		public struct ClearIntermediateRenderers
		{
		}

		// Token: 0x020001BC RID: 444
		[Token(Token = "0x20001BC")]
		[RequiredByNativeCode]
		public struct ClearLines
		{
		}

		// Token: 0x020001BD RID: 445
		[Token(Token = "0x20001BD")]
		[RequiredByNativeCode]
		public struct PresentBeforeUpdate
		{
		}

		// Token: 0x020001BE RID: 446
		[Token(Token = "0x20001BE")]
		[RequiredByNativeCode]
		public struct ResetFrameStatsAfterPresent
		{
		}

		// Token: 0x020001BF RID: 447
		[Token(Token = "0x20001BF")]
		[RequiredByNativeCode]
		public struct UpdateAsyncReadbackManager
		{
		}

		// Token: 0x020001C0 RID: 448
		[Token(Token = "0x20001C0")]
		[RequiredByNativeCode]
		public struct UpdateTextureStreamingManager
		{
		}

		// Token: 0x020001C1 RID: 449
		[Token(Token = "0x20001C1")]
		[RequiredByNativeCode]
		public struct UpdatePreloading
		{
		}

		// Token: 0x020001C2 RID: 450
		[Token(Token = "0x20001C2")]
		[RequiredByNativeCode]
		public struct RendererNotifyInvisible
		{
		}

		// Token: 0x020001C3 RID: 451
		[Token(Token = "0x20001C3")]
		[RequiredByNativeCode]
		public struct PlayerCleanupCachedData
		{
		}

		// Token: 0x020001C4 RID: 452
		[Token(Token = "0x20001C4")]
		[RequiredByNativeCode]
		public struct UpdateMainGameViewRect
		{
		}

		// Token: 0x020001C5 RID: 453
		[Token(Token = "0x20001C5")]
		[RequiredByNativeCode]
		public struct UpdateCanvasRectTransform
		{
		}

		// Token: 0x020001C6 RID: 454
		[Token(Token = "0x20001C6")]
		[RequiredByNativeCode]
		public struct UpdateInputManager
		{
		}

		// Token: 0x020001C7 RID: 455
		[Token(Token = "0x20001C7")]
		[RequiredByNativeCode]
		public struct ProcessRemoteInput
		{
		}

		// Token: 0x020001C8 RID: 456
		[Token(Token = "0x20001C8")]
		[RequiredByNativeCode]
		public struct XRUpdate
		{
		}

		// Token: 0x020001C9 RID: 457
		[Token(Token = "0x20001C9")]
		[RequiredByNativeCode]
		public struct ScriptRunDelayedStartupFrame
		{
		}

		// Token: 0x020001CA RID: 458
		[Token(Token = "0x20001CA")]
		[RequiredByNativeCode]
		public struct UpdateKinect
		{
		}

		// Token: 0x020001CB RID: 459
		[Token(Token = "0x20001CB")]
		[RequiredByNativeCode]
		public struct DeliverIosPlatformEvents
		{
		}

		// Token: 0x020001CC RID: 460
		[Token(Token = "0x20001CC")]
		[RequiredByNativeCode]
		public struct DispatchEventQueueEvents
		{
		}

		// Token: 0x020001CD RID: 461
		[Token(Token = "0x20001CD")]
		[RequiredByNativeCode]
		public struct PhysicsResetInterpolatedTransformPosition
		{
		}

		// Token: 0x020001CE RID: 462
		[Token(Token = "0x20001CE")]
		[RequiredByNativeCode]
		public struct SpriteAtlasManagerUpdate
		{
		}

		// Token: 0x020001CF RID: 463
		[Token(Token = "0x20001CF")]
		[Obsolete("TangoUpdate has been deprecated. Use ARCoreUpdate instead (UnityUpgradable) -> UnityEngine.PlayerLoop.EarlyUpdate/ARCoreUpdate", false)]
		[RequiredByNativeCode]
		public struct TangoUpdate
		{
		}

		// Token: 0x020001D0 RID: 464
		[Token(Token = "0x20001D0")]
		[RequiredByNativeCode]
		public struct ARCoreUpdate
		{
		}

		// Token: 0x020001D1 RID: 465
		[Token(Token = "0x20001D1")]
		[RequiredByNativeCode]
		public struct PerformanceAnalyticsUpdate
		{
		}
	}
}
