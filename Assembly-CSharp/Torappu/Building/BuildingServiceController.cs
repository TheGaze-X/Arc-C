using System;
using Il2CppDummyDll;
using Torappu.Network;
using Torappu.UI;
using XLua;

namespace Torappu.Building
{
	// Token: 0x0200180F RID: 6159
	[Token(Token = "0x200180F")]
	[Hotfix(HotfixFlag.Stateless)]
	public class BuildingServiceController
	{
		// Token: 0x06009BE2 RID: 39906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BE2")]
		[Address(RVA = "0x315E360", Offset = "0x315CF60", VA = "0x18315E360")]
		public void Tick()
		{
		}

		// Token: 0x06009BE3 RID: 39907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BE3")]
		[Address(RVA = "0x315E140", Offset = "0x315CD40", VA = "0x18315E140")]
		public void Init()
		{
		}

		// Token: 0x06009BE4 RID: 39908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BE4")]
		[Address(RVA = "0x315E1C0", Offset = "0x315CDC0", VA = "0x18315E1C0")]
		public void NotifyPlayerDataChanged()
		{
		}

		// Token: 0x06009BE5 RID: 39909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BE5")]
		[Address(RVA = "0x315E090", Offset = "0x315CC90", VA = "0x18315E090")]
		public void AddPlayerDataListener(Action<object> listener)
		{
		}

		// Token: 0x06009BE6 RID: 39910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BE6")]
		[Address(RVA = "0x315E2B0", Offset = "0x315CEB0", VA = "0x18315E2B0")]
		public void RemovePlayerDataListener(Action<object> listener)
		{
		}

		// Token: 0x06009BE7 RID: 39911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009BE7")]
		public UISender.ResultHandler<ResType> SendRequest<ResType>(Request request) where ResType : class
		{
			return null;
		}

		// Token: 0x06009BE8 RID: 39912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BE8")]
		[Address(RVA = "0x315E8B0", Offset = "0x315D4B0", VA = "0x18315E8B0")]
		private void _UpdateCountDown()
		{
		}

		// Token: 0x06009BE9 RID: 39913 RVA: 0x0003CBA0 File Offset: 0x0003ADA0
		[Token(Token = "0x6009BE9")]
		[Address(RVA = "0x315E3E0", Offset = "0x315CFE0", VA = "0x18315E3E0")]
		private DateTime _GetNextUpdateTime()
		{
			return default(DateTime);
		}

		// Token: 0x06009BEA RID: 39914 RVA: 0x0003CBB8 File Offset: 0x0003ADB8
		[Token(Token = "0x6009BEA")]
		[Address(RVA = "0x315E620", Offset = "0x315D220", VA = "0x18315E620")]
		private static DateTime _PickNextUpdateTime(DateTime curCandidate, DateTime newCandidate)
		{
			return default(DateTime);
		}

		// Token: 0x06009BEB RID: 39915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BEB")]
		[Address(RVA = "0x315E7B0", Offset = "0x315D3B0", VA = "0x18315E7B0")]
		private void _SendSyncDataRequest()
		{
		}

		// Token: 0x06009BEC RID: 39916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BEC")]
		[Address(RVA = "0x315ECE0", Offset = "0x315D8E0", VA = "0x18315ECE0")]
		public BuildingServiceController()
		{
		}

		// Token: 0x04009293 RID: 37523
		[Token(Token = "0x4009293")]
		[FieldOffset(Offset = "0x10")]
		private CountDownTask m_updateCountDown;

		// Token: 0x04009294 RID: 37524
		[Token(Token = "0x4009294")]
		[FieldOffset(Offset = "0x18")]
		private ListSet<Action<object>> m_playerDataListeners;

		// Token: 0x04009295 RID: 37525
		[Token(Token = "0x4009295")]
		[FieldOffset(Offset = "0x0")]
		private static DateTime s_beforeServiceTs;

		// Token: 0x04009296 RID: 37526
		[Token(Token = "0x4009296")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Tick;

		// Token: 0x04009297 RID: 37527
		[Token(Token = "0x4009297")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04009298 RID: 37528
		[Token(Token = "0x4009298")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_NotifyPlayerDataChanged;

		// Token: 0x04009299 RID: 37529
		[Token(Token = "0x4009299")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_AddPlayerDataListener;

		// Token: 0x0400929A RID: 37530
		[Token(Token = "0x400929A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RemovePlayerDataListener;

		// Token: 0x0400929B RID: 37531
		[Token(Token = "0x400929B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SendRequest;

		// Token: 0x0400929C RID: 37532
		[Token(Token = "0x400929C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UpdateCountDown;

		// Token: 0x0400929D RID: 37533
		[Token(Token = "0x400929D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GetNextUpdateTime;

		// Token: 0x0400929E RID: 37534
		[Token(Token = "0x400929E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__PickNextUpdateTime;

		// Token: 0x0400929F RID: 37535
		[Token(Token = "0x400929F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__SendSyncDataRequest;

		// Token: 0x040092A0 RID: 37536
		[Token(Token = "0x40092A0")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
