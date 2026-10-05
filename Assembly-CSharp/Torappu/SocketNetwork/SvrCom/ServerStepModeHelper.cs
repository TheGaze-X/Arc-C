using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.SocketNetwork.SvrCom
{
	// Token: 0x020014AC RID: 5292
	[Token(Token = "0x20014AC")]
	public class ServerStepModeHelper : IHotfixable
	{
		// Token: 0x06007A26 RID: 31270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A26")]
		[Address(RVA = "0x26486A0", Offset = "0x26472A0", VA = "0x1826486A0")]
		private ServerStepModeHelper()
		{
		}

		// Token: 0x06007A27 RID: 31271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A27")]
		[Address(RVA = "0x2648710", Offset = "0x2647310", VA = "0x182648710")]
		public ServerStepModeHelper(IServerStepModeHost host)
		{
		}

		// Token: 0x06007A28 RID: 31272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A28")]
		[Address(RVA = "0x2647A70", Offset = "0x2646670", VA = "0x182647A70")]
		public void AddStep(ServerStepModeHelper.IStepData stepData)
		{
		}

		// Token: 0x06007A29 RID: 31273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A29")]
		[Address(RVA = "0x2647FD0", Offset = "0x2646BD0", VA = "0x182647FD0")]
		public void Tick(bool needRefreshSpeed = true)
		{
		}

		// Token: 0x06007A2A RID: 31274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A2A")]
		[Address(RVA = "0x2648120", Offset = "0x2646D20", VA = "0x182648120")]
		private void _ApplyOneStep()
		{
		}

		// Token: 0x06007A2B RID: 31275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A2B")]
		[Address(RVA = "0x2647B10", Offset = "0x2646710", VA = "0x182647B10")]
		public void ApplyStepImmediately(int stepCnt)
		{
		}

		// Token: 0x06007A2C RID: 31276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A2C")]
		[Address(RVA = "0x2647E20", Offset = "0x2646A20", VA = "0x182647E20")]
		public void Clear()
		{
		}

		// Token: 0x06007A2D RID: 31277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A2D")]
		[Address(RVA = "0x2647BF0", Offset = "0x26467F0", VA = "0x182647BF0")]
		public void ClearAndApplyLastStep(int lastStepCnt)
		{
		}

		// Token: 0x06007A2E RID: 31278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A2E")]
		[Address(RVA = "0x26483D0", Offset = "0x2646FD0", VA = "0x1826483D0")]
		private void _RefreshPlaySpeed()
		{
		}

		// Token: 0x06007A2F RID: 31279 RVA: 0x00036BA0 File Offset: 0x00034DA0
		[Token(Token = "0x6007A2F")]
		[Address(RVA = "0x2648350", Offset = "0x2646F50", VA = "0x182648350")]
		private int _CalculateRemainFrame()
		{
			return 0;
		}

		// Token: 0x06007A30 RID: 31280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A30")]
		[Address(RVA = "0x2648290", Offset = "0x2646E90", VA = "0x182648290")]
		private void _ApplyStepSetting(ServerStepModeHelper.IStepData step)
		{
		}

		// Token: 0x04007837 RID: 30775
		[Token(Token = "0x4007837")]
		private const int INITIAL_PRESERVE_CNT = 2;

		// Token: 0x04007838 RID: 30776
		[Token(Token = "0x4007838")]
		[FieldOffset(Offset = "0x10")]
		private Queue<ServerStepModeHelper.IStepData> m_cachedSteps;

		// Token: 0x04007839 RID: 30777
		[Token(Token = "0x4007839")]
		[FieldOffset(Offset = "0x18")]
		private int m_preserveCnt;

		// Token: 0x0400783A RID: 30778
		[Token(Token = "0x400783A")]
		[FieldOffset(Offset = "0x1C")]
		private float m_playSpeed;

		// Token: 0x0400783B RID: 30779
		[Token(Token = "0x400783B")]
		[FieldOffset(Offset = "0x20")]
		private float m_playFramesOnce;

		// Token: 0x0400783C RID: 30780
		[Token(Token = "0x400783C")]
		[FieldOffset(Offset = "0x24")]
		private int m_stride;

		// Token: 0x0400783D RID: 30781
		[Token(Token = "0x400783D")]
		[FieldOffset(Offset = "0x28")]
		private int m_leftFrameInStep;

		// Token: 0x0400783E RID: 30782
		[Token(Token = "0x400783E")]
		[FieldOffset(Offset = "0x30")]
		private IServerStepModeHost m_host;

		// Token: 0x0400783F RID: 30783
		[Token(Token = "0x400783F")]
		[FieldOffset(Offset = "0x38")]
		private ServerStepModeHelper.SettingData m_setting;

		// Token: 0x04007840 RID: 30784
		[Token(Token = "0x4007840")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04007841 RID: 30785
		[Token(Token = "0x4007841")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix1_ctor;

		// Token: 0x04007842 RID: 30786
		[Token(Token = "0x4007842")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_AddStep;

		// Token: 0x04007843 RID: 30787
		[Token(Token = "0x4007843")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Tick;

		// Token: 0x04007844 RID: 30788
		[Token(Token = "0x4007844")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ApplyOneStep;

		// Token: 0x04007845 RID: 30789
		[Token(Token = "0x4007845")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ApplyStepImmediately;

		// Token: 0x04007846 RID: 30790
		[Token(Token = "0x4007846")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Clear;

		// Token: 0x04007847 RID: 30791
		[Token(Token = "0x4007847")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ClearAndApplyLastStep;

		// Token: 0x04007848 RID: 30792
		[Token(Token = "0x4007848")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RefreshPlaySpeed;

		// Token: 0x04007849 RID: 30793
		[Token(Token = "0x4007849")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CalculateRemainFrame;

		// Token: 0x0400784A RID: 30794
		[Token(Token = "0x400784A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ApplyStepSetting;

		// Token: 0x020014AD RID: 5293
		[Token(Token = "0x20014AD")]
		public interface IStepData
		{
			// Token: 0x06007A31 RID: 31281
			[Token(Token = "0x6007A31")]
			int GetSeq();

			// Token: 0x06007A32 RID: 31282
			[Token(Token = "0x6007A32")]
			int GetDuration();
		}

		// Token: 0x020014AE RID: 5294
		[Token(Token = "0x20014AE")]
		public class SettingData
		{
			// Token: 0x06007A33 RID: 31283 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A33")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SettingData()
			{
			}

			// Token: 0x0400784B RID: 30795
			[Token(Token = "0x400784B")]
			[FieldOffset(Offset = "0x10")]
			public double maxOperatorDelay;

			// Token: 0x0400784C RID: 30796
			[Token(Token = "0x400784C")]
			[FieldOffset(Offset = "0x18")]
			public float maxPlaySpeed;

			// Token: 0x0400784D RID: 30797
			[Token(Token = "0x400784D")]
			[FieldOffset(Offset = "0x1C")]
			public int maxApplyStepInReset;
		}
	}
}
