using System;
using DG.Tweening;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Network
{
	// Token: 0x0200151F RID: 5407
	[Token(Token = "0x200151F")]
	public class IdelPeriodGameServerProbe : Singleton<IdelPeriodGameServerProbe>, IDisposable
	{
		// Token: 0x06007C26 RID: 31782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C26")]
		[Address(RVA = "0x273CA00", Offset = "0x273B600", VA = "0x18273CA00")]
		private IdelPeriodGameServerProbe()
		{
		}

		// Token: 0x06007C27 RID: 31783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C27")]
		[Address(RVA = "0x273C260", Offset = "0x273AE60", VA = "0x18273C260")]
		public void OnBeforeRequest()
		{
		}

		// Token: 0x06007C28 RID: 31784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C28")]
		[Address(RVA = "0x273C2D0", Offset = "0x273AED0", VA = "0x18273C2D0")]
		public void OnHandleResponse()
		{
		}

		// Token: 0x06007C29 RID: 31785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C29")]
		[Address(RVA = "0x273C190", Offset = "0x273AD90", VA = "0x18273C190", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06007C2A RID: 31786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C2A")]
		[Address(RVA = "0x273C520", Offset = "0x273B120", VA = "0x18273C520")]
		private void _OnIdelIntervalEnd()
		{
		}

		// Token: 0x06007C2B RID: 31787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C2B")]
		[Address(RVA = "0x273C890", Offset = "0x273B490", VA = "0x18273C890")]
		private void _OnPingServiceResponse(IdelPeriodGameServerProbe.PingResponse response)
		{
		}

		// Token: 0x06007C2C RID: 31788 RVA: 0x00037410 File Offset: 0x00035610
		[Token(Token = "0x6007C2C")]
		[Address(RVA = "0x273C7A0", Offset = "0x273B3A0", VA = "0x18273C7A0")]
		private bool _OnPingServiceFail(ResponseError respError)
		{
			return default(bool);
		}

		// Token: 0x06007C2D RID: 31789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C2D")]
		[Address(RVA = "0x273C4C0", Offset = "0x273B0C0", VA = "0x18273C4C0")]
		private void _OnEnterGame()
		{
		}

		// Token: 0x06007C2E RID: 31790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C2E")]
		[Address(RVA = "0x273C990", Offset = "0x273B590", VA = "0x18273C990")]
		private void _OnStopGame()
		{
		}

		// Token: 0x06007C2F RID: 31791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C2F")]
		[Address(RVA = "0x273C350", Offset = "0x273AF50", VA = "0x18273C350")]
		private void _BeforeSceneTransition(string prev, string target)
		{
		}

		// Token: 0x04007C07 RID: 31751
		[Token(Token = "0x4007C07")]
		public const long IDEL_SECS_DEFAULT = 60L;

		// Token: 0x04007C08 RID: 31752
		[Token(Token = "0x4007C08")]
		public const long IDEL_SECS_MIN = 10L;

		// Token: 0x04007C09 RID: 31753
		[Token(Token = "0x4007C09")]
		[FieldOffset(Offset = "0x10")]
		private IdelPeriodGameServerProbe.Timer m_timer;

		// Token: 0x04007C0A RID: 31754
		[Token(Token = "0x4007C0A")]
		[FieldOffset(Offset = "0x18")]
		private bool m_isActive;

		// Token: 0x04007C0B RID: 31755
		[Token(Token = "0x4007C0B")]
		[FieldOffset(Offset = "0x1C")]
		private float m_idelSecs;

		// Token: 0x04007C0C RID: 31756
		[Token(Token = "0x4007C0C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04007C0D RID: 31757
		[Token(Token = "0x4007C0D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnBeforeRequest;

		// Token: 0x04007C0E RID: 31758
		[Token(Token = "0x4007C0E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnHandleResponse;

		// Token: 0x04007C0F RID: 31759
		[Token(Token = "0x4007C0F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Dispose;

		// Token: 0x04007C10 RID: 31760
		[Token(Token = "0x4007C10")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnIdelIntervalEnd;

		// Token: 0x04007C11 RID: 31761
		[Token(Token = "0x4007C11")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnPingServiceResponse;

		// Token: 0x04007C12 RID: 31762
		[Token(Token = "0x4007C12")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnPingServiceFail;

		// Token: 0x04007C13 RID: 31763
		[Token(Token = "0x4007C13")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnEnterGame;

		// Token: 0x04007C14 RID: 31764
		[Token(Token = "0x4007C14")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnStopGame;

		// Token: 0x04007C15 RID: 31765
		[Token(Token = "0x4007C15")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__BeforeSceneTransition;

		// Token: 0x02001520 RID: 5408
		[Token(Token = "0x2001520")]
		private class PingRequest
		{
			// Token: 0x06007C30 RID: 31792 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C30")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PingRequest()
			{
			}
		}

		// Token: 0x02001521 RID: 5409
		[Token(Token = "0x2001521")]
		private class PingResponse : PlayerDeltaResponse
		{
			// Token: 0x06007C31 RID: 31793 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C31")]
			[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
			public PingResponse()
			{
			}

			// Token: 0x04007C16 RID: 31766
			[Token(Token = "0x4007C16")]
			[FieldOffset(Offset = "0x28")]
			public long now;

			// Token: 0x04007C17 RID: 31767
			[Token(Token = "0x4007C17")]
			[FieldOffset(Offset = "0x30")]
			public long next;
		}

		// Token: 0x02001522 RID: 5410
		[Token(Token = "0x2001522")]
		private class Timer : IHotfixable
		{
			// Token: 0x06007C32 RID: 31794 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007C32")]
			[Address(RVA = "0x2748210", Offset = "0x2746E10", VA = "0x182748210")]
			private Tween _EnsureTween()
			{
				return null;
			}

			// Token: 0x06007C33 RID: 31795 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C33")]
			[Address(RVA = "0x2748110", Offset = "0x2746D10", VA = "0x182748110")]
			public void Stop()
			{
			}

			// Token: 0x06007C34 RID: 31796 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C34")]
			[Address(RVA = "0x2748010", Offset = "0x2746C10", VA = "0x182748010")]
			public void Restart(float intervalSecs)
			{
			}

			// Token: 0x06007C35 RID: 31797 RVA: 0x00037428 File Offset: 0x00035628
			[Token(Token = "0x6007C35")]
			[Address(RVA = "0x2748580", Offset = "0x2747180", VA = "0x182748580")]
			private bool _ResuseTween()
			{
				return default(bool);
			}

			// Token: 0x06007C36 RID: 31798 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C36")]
			[Address(RVA = "0x27485E0", Offset = "0x27471E0", VA = "0x1827485E0")]
			public Timer()
			{
			}

			// Token: 0x04007C18 RID: 31768
			[Token(Token = "0x4007C18")]
			[FieldOffset(Offset = "0x10")]
			private Tween m_nullableTween;

			// Token: 0x04007C19 RID: 31769
			[Token(Token = "0x4007C19")]
			[FieldOffset(Offset = "0x18")]
			public Action onTimeout;

			// Token: 0x04007C1A RID: 31770
			[Token(Token = "0x4007C1A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0__EnsureTween;

			// Token: 0x04007C1B RID: 31771
			[Token(Token = "0x4007C1B")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Stop;

			// Token: 0x04007C1C RID: 31772
			[Token(Token = "0x4007C1C")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_Restart;

			// Token: 0x04007C1D RID: 31773
			[Token(Token = "0x4007C1D")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__ResuseTween;

			// Token: 0x04007C1E RID: 31774
			[Token(Token = "0x4007C1E")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
