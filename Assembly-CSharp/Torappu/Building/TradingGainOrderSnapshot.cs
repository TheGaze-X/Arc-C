using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Building
{
	// Token: 0x0200181B RID: 6171
	[Token(Token = "0x200181B")]
	public struct TradingGainOrderSnapshot : IHotfixable
	{
		// Token: 0x06009C18 RID: 39960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C18")]
		[Address(RVA = "0x3188E00", Offset = "0x3187A00", VA = "0x183188E00")]
		private void _LoadData(PlayerBuildingTrading playerTrading)
		{
		}

		// Token: 0x06009C19 RID: 39961 RVA: 0x0003CD38 File Offset: 0x0003AF38
		[Token(Token = "0x6009C19")]
		[Address(RVA = "0x3188D70", Offset = "0x3187970", VA = "0x183188D70")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x06009C1A RID: 39962 RVA: 0x0003CD50 File Offset: 0x0003AF50
		[Token(Token = "0x6009C1A")]
		[Address(RVA = "0x3188B70", Offset = "0x3187770", VA = "0x183188B70")]
		public long GetRemainTime()
		{
			return 0L;
		}

		// Token: 0x06009C1B RID: 39963 RVA: 0x0003CD68 File Offset: 0x0003AF68
		[Token(Token = "0x6009C1B")]
		[Address(RVA = "0x3188990", Offset = "0x3187590", VA = "0x183188990")]
		public float GetProgress()
		{
			return 0f;
		}

		// Token: 0x06009C1C RID: 39964 RVA: 0x0003CD80 File Offset: 0x0003AF80
		[Token(Token = "0x6009C1C")]
		[Address(RVA = "0x3188720", Offset = "0x3187320", VA = "0x183188720")]
		public static TradingGainOrderSnapshot CreateSnapshot(string slotId)
		{
			return default(TradingGainOrderSnapshot);
		}

		// Token: 0x040092FB RID: 37627
		[Token(Token = "0x40092FB")]
		[FieldOffset(Offset = "0x0")]
		public static readonly TradingGainOrderSnapshot EMPTY;

		// Token: 0x040092FC RID: 37628
		[Token(Token = "0x40092FC")]
		[FieldOffset(Offset = "0x0")]
		private bool m_isEmpty;

		// Token: 0x040092FD RID: 37629
		[Token(Token = "0x40092FD")]
		[FieldOffset(Offset = "0x8")]
		public DateTime lastUpdateTime;

		// Token: 0x040092FE RID: 37630
		[Token(Token = "0x40092FE")]
		[FieldOffset(Offset = "0x10")]
		public double processPoint;

		// Token: 0x040092FF RID: 37631
		[Token(Token = "0x40092FF")]
		[FieldOffset(Offset = "0x18")]
		public double speed;

		// Token: 0x04009300 RID: 37632
		[Token(Token = "0x4009300")]
		[FieldOffset(Offset = "0x20")]
		public int totalPoint;

		// Token: 0x04009301 RID: 37633
		[Token(Token = "0x4009301")]
		[FieldOffset(Offset = "0x24")]
		public bool isWorking;

		// Token: 0x04009302 RID: 37634
		[Token(Token = "0x4009302")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__LoadData;

		// Token: 0x04009303 RID: 37635
		[Token(Token = "0x4009303")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_IsEmpty;

		// Token: 0x04009304 RID: 37636
		[Token(Token = "0x4009304")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetRemainTime;

		// Token: 0x04009305 RID: 37637
		[Token(Token = "0x4009305")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetProgress;

		// Token: 0x04009306 RID: 37638
		[Token(Token = "0x4009306")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CreateSnapshot;
	}
}
