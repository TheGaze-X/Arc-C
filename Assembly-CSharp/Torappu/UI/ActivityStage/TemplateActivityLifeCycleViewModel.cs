using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006CE8 RID: 27880
	[Token(Token = "0x2006CE8")]
	public class TemplateActivityLifeCycleViewModel : TemplateActivityViewModel
	{
		// Token: 0x06027C13 RID: 162835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027C13")]
		[Address(RVA = "0x22FA3C0", Offset = "0x22F8FC0", VA = "0x1822FA3C0")]
		public void RefreshData()
		{
		}

		// Token: 0x06027C14 RID: 162836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027C14")]
		[Address(RVA = "0x22FA4D0", Offset = "0x22F90D0", VA = "0x1822FA4D0")]
		public TemplateActivityLifeCycleViewModel(object param)
		{
		}

		// Token: 0x0403860B RID: 230923
		[Token(Token = "0x403860B")]
		[FieldOffset(Offset = "0x20")]
		private ActivityTable.BasicData m_data;

		// Token: 0x0403860C RID: 230924
		[Token(Token = "0x403860C")]
		[FieldOffset(Offset = "0x28")]
		public TemplateActivityLifeCycleViewModel.ActState state;

		// Token: 0x0403860D RID: 230925
		[Token(Token = "0x403860D")]
		[FieldOffset(Offset = "0x30")]
		public long remainTime;

		// Token: 0x0403860E RID: 230926
		[Token(Token = "0x403860E")]
		[FieldOffset(Offset = "0x38")]
		public long endTime;

		// Token: 0x0403860F RID: 230927
		[Token(Token = "0x403860F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x04038610 RID: 230928
		[Token(Token = "0x4038610")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006CE9 RID: 27881
		[Token(Token = "0x2006CE9")]
		public enum ActState
		{
			// Token: 0x04038612 RID: 230930
			[Token(Token = "0x4038612")]
			NOT_OPEN,
			// Token: 0x04038613 RID: 230931
			[Token(Token = "0x4038613")]
			ON_ACT,
			// Token: 0x04038614 RID: 230932
			[Token(Token = "0x4038614")]
			ON_REWARD,
			// Token: 0x04038615 RID: 230933
			[Token(Token = "0x4038615")]
			ONCLOSE
		}
	}
}
