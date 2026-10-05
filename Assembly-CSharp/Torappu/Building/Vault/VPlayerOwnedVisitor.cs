using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Building.Vault
{
	// Token: 0x02001A13 RID: 6675
	[Token(Token = "0x2001A13")]
	public class VPlayerOwnedVisitor : IBuildingBindTools, IHotfixable, IDisposable
	{
		// Token: 0x0600A756 RID: 42838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A756")]
		[Address(RVA = "0x3230740", Offset = "0x322F340", VA = "0x183230740", Slot = "9")]
		public void Dispose()
		{
		}

		// Token: 0x0600A757 RID: 42839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A757")]
		[Address(RVA = "0x32308F0", Offset = "0x322F4F0", VA = "0x1832308F0")]
		private void _BindEvents()
		{
		}

		// Token: 0x0600A758 RID: 42840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A758")]
		[Address(RVA = "0x3231170", Offset = "0x322FD70", VA = "0x183231170")]
		private void _UnbindEvents()
		{
		}

		// Token: 0x0600A759 RID: 42841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A759")]
		[Address(RVA = "0x3230C00", Offset = "0x322F800", VA = "0x183230C00")]
		private void _OnRoomObjectCreated(object arg)
		{
		}

		// Token: 0x0600A75A RID: 42842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A75A")]
		[Address(RVA = "0x3230F50", Offset = "0x322FB50", VA = "0x183230F50")]
		private void _TryToStartCharYieldInst(VCharacter vChar)
		{
		}

		// Token: 0x0600A75B RID: 42843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A75B")]
		[Address(RVA = "0x3230A90", Offset = "0x322F690", VA = "0x183230A90")]
		private Func<float, bool> _CreateYieldWaitForValid(VCharacter vCharacter)
		{
			return null;
		}

		// Token: 0x0600A75C RID: 42844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A75C")]
		[Address(RVA = "0x3230B80", Offset = "0x322F780", VA = "0x183230B80")]
		private void _OnMeetingRoomFocusedBySceneParam(object _)
		{
		}

		// Token: 0x0600A75D RID: 42845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A75D")]
		[Address(RVA = "0x3230EA0", Offset = "0x322FAA0", VA = "0x183230EA0")]
		private void _Release()
		{
		}

		// Token: 0x0600A75E RID: 42846 RVA: 0x00040C50 File Offset: 0x0003EE50
		[Token(Token = "0x600A75E")]
		[Address(RVA = "0x32307B0", Offset = "0x322F3B0", VA = "0x1832307B0", Slot = "4")]
		public bool IsActive()
		{
			return default(bool);
		}

		// Token: 0x0600A75F RID: 42847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A75F")]
		[Address(RVA = "0x3230430", Offset = "0x322F030", VA = "0x183230430", Slot = "5")]
		public void BindController(BuildingController controller)
		{
		}

		// Token: 0x0600A760 RID: 42848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A760")]
		[Address(RVA = "0x3230810", Offset = "0x322F410", VA = "0x183230810", Slot = "6")]
		public void Tick(float ts)
		{
		}

		// Token: 0x0600A761 RID: 42849 RVA: 0x00040C68 File Offset: 0x0003EE68
		[Token(Token = "0x600A761")]
		[Address(RVA = "0x3230670", Offset = "0x322F270", VA = "0x183230670", Slot = "7")]
		public bool CheckNeedActiveWithoutController()
		{
			return default(bool);
		}

		// Token: 0x0600A762 RID: 42850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A762")]
		[Address(RVA = "0x32306D0", Offset = "0x322F2D0", VA = "0x1832306D0", Slot = "8")]
		public void Clear()
		{
		}

		// Token: 0x0600A763 RID: 42851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A763")]
		[Address(RVA = "0x3231310", Offset = "0x322FF10", VA = "0x183231310")]
		public VPlayerOwnedVisitor()
		{
		}

		// Token: 0x04009F7B RID: 40827
		[Token(Token = "0x4009F7B")]
		[FieldOffset(Offset = "0x10")]
		private BuildingController m_controller;

		// Token: 0x04009F7C RID: 40828
		[Token(Token = "0x4009F7C")]
		[FieldOffset(Offset = "0x18")]
		private LatchUtils.InvokeWhenUnlock m_invokeWhenVCharCreated;

		// Token: 0x04009F7D RID: 40829
		[Token(Token = "0x4009F7D")]
		[FieldOffset(Offset = "0x20")]
		private TickFunction m_tickFunction;

		// Token: 0x04009F7E RID: 40830
		[Token(Token = "0x4009F7E")]
		[FieldOffset(Offset = "0x28")]
		private VCharacter m_targetChar;

		// Token: 0x04009F7F RID: 40831
		[Token(Token = "0x4009F7F")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isActived;

		// Token: 0x04009F80 RID: 40832
		[Token(Token = "0x4009F80")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Dispose;

		// Token: 0x04009F81 RID: 40833
		[Token(Token = "0x4009F81")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__BindEvents;

		// Token: 0x04009F82 RID: 40834
		[Token(Token = "0x4009F82")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UnbindEvents;

		// Token: 0x04009F83 RID: 40835
		[Token(Token = "0x4009F83")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnRoomObjectCreated;

		// Token: 0x04009F84 RID: 40836
		[Token(Token = "0x4009F84")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TryToStartCharYieldInst;

		// Token: 0x04009F85 RID: 40837
		[Token(Token = "0x4009F85")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CreateYieldWaitForValid;

		// Token: 0x04009F86 RID: 40838
		[Token(Token = "0x4009F86")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnMeetingRoomFocusedBySceneParam;

		// Token: 0x04009F87 RID: 40839
		[Token(Token = "0x4009F87")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__Release;

		// Token: 0x04009F88 RID: 40840
		[Token(Token = "0x4009F88")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_IsActive;

		// Token: 0x04009F89 RID: 40841
		[Token(Token = "0x4009F89")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_BindController;

		// Token: 0x04009F8A RID: 40842
		[Token(Token = "0x4009F8A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_Tick;

		// Token: 0x04009F8B RID: 40843
		[Token(Token = "0x4009F8B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_CheckNeedActiveWithoutController;

		// Token: 0x04009F8C RID: 40844
		[Token(Token = "0x4009F8C")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_Clear;

		// Token: 0x04009F8D RID: 40845
		[Token(Token = "0x4009F8D")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
