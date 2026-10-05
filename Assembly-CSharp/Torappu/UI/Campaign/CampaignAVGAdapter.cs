using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.AVG;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x020060D2 RID: 24786
	[Token(Token = "0x20060D2")]
	public class CampaignAVGAdapter : ExecutorComponent
	{
		// Token: 0x06023D2B RID: 146731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023D2B")]
		[Address(RVA = "0x1E6C4A0", Offset = "0x1E6B0A0", VA = "0x181E6C4A0", Slot = "8")]
		public override Dictionary<string, ExecutorComponent.Executor> GetExecutors()
		{
			return null;
		}

		// Token: 0x06023D2C RID: 146732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023D2C")]
		[Address(RVA = "0x1E6C690", Offset = "0x1E6B290", VA = "0x181E6C690", Slot = "9")]
		public override Dictionary<string, ExecutorComponent.SignalReceiver> GetSignalReceivers()
		{
			return null;
		}

		// Token: 0x06023D2D RID: 146733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023D2D")]
		[Address(RVA = "0x1E6C440", Offset = "0x1E6B040", VA = "0x181E6C440", Slot = "12")]
		protected override void ForceCommandEnd()
		{
		}

		// Token: 0x06023D2E RID: 146734 RVA: 0x000C2280 File Offset: 0x000C0480
		[Token(Token = "0x6023D2E")]
		[Address(RVA = "0x1E6C910", Offset = "0x1E6B510", VA = "0x181E6C910")]
		private bool _ExecuteFocusZone(Command command)
		{
			return default(bool);
		}

		// Token: 0x06023D2F RID: 146735 RVA: 0x000C2298 File Offset: 0x000C0498
		[Token(Token = "0x6023D2F")]
		[Address(RVA = "0x1E6CC90", Offset = "0x1E6B890", VA = "0x181E6CC90")]
		private bool _ExecuteRegisterZoneBtn(Command command)
		{
			return default(bool);
		}

		// Token: 0x06023D30 RID: 146736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023D30")]
		[Address(RVA = "0x1E6D020", Offset = "0x1E6BC20", VA = "0x181E6D020")]
		private void _ReceiveFocusZoneSignal(Command command)
		{
		}

		// Token: 0x06023D31 RID: 146737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023D31")]
		[Address(RVA = "0x1E6C860", Offset = "0x1E6B460", VA = "0x181E6C860")]
		private void Start()
		{
		}

		// Token: 0x06023D32 RID: 146738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023D32")]
		[Address(RVA = "0x1E6C7B0", Offset = "0x1E6B3B0", VA = "0x181E6C7B0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06023D33 RID: 146739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023D33")]
		[Address(RVA = "0x1E6D110", Offset = "0x1E6BD10", VA = "0x181E6D110")]
		public CampaignAVGAdapter()
		{
		}

		// Token: 0x06023D34 RID: 146740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023D34")]
		[Address(RVA = "0x1C5FCE0", Offset = "0x1C5E8E0", VA = "0x181C5FCE0")]
		private Dictionary<string, ExecutorComponent.SignalReceiver> <>xLuaBaseProxy_GetSignalReceivers()
		{
			return null;
		}

		// Token: 0x04031AF3 RID: 203507
		[Token(Token = "0x4031AF3")]
		[FieldOffset(Offset = "0x50")]
		private string m_waitForSignal;

		// Token: 0x04031AF4 RID: 203508
		[Token(Token = "0x4031AF4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetExecutors;

		// Token: 0x04031AF5 RID: 203509
		[Token(Token = "0x4031AF5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetSignalReceivers;

		// Token: 0x04031AF6 RID: 203510
		[Token(Token = "0x4031AF6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ForceCommandEnd;

		// Token: 0x04031AF7 RID: 203511
		[Token(Token = "0x4031AF7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ExecuteFocusZone;

		// Token: 0x04031AF8 RID: 203512
		[Token(Token = "0x4031AF8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ExecuteRegisterZoneBtn;

		// Token: 0x04031AF9 RID: 203513
		[Token(Token = "0x4031AF9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ReceiveFocusZoneSignal;

		// Token: 0x04031AFA RID: 203514
		[Token(Token = "0x4031AFA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x04031AFB RID: 203515
		[Token(Token = "0x4031AFB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04031AFC RID: 203516
		[Token(Token = "0x4031AFC")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
