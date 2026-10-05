using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E2B RID: 28203
	[Token(Token = "0x2006E2B")]
	public class ActVecBreakV2DefenseStageOverviewStateBean : IStateBean, IHotfixable
	{
		// Token: 0x06028240 RID: 164416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028240")]
		[Address(RVA = "0x23690C0", Offset = "0x2367CC0", VA = "0x1823690C0")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x06028241 RID: 164417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028241")]
		[Address(RVA = "0x2369250", Offset = "0x2367E50", VA = "0x182369250")]
		public void RefreshData(string actId)
		{
		}

		// Token: 0x06028242 RID: 164418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028242")]
		[Address(RVA = "0x2369310", Offset = "0x2367F10", VA = "0x182369310")]
		public ActVecBreakV2DefenseStageOverviewStateBean()
		{
		}

		// Token: 0x0403900A RID: 233482
		[Token(Token = "0x403900A")]
		[FieldOffset(Offset = "0x10")]
		public ActVecBreakV2DefenseStageOverviewProperty property;

		// Token: 0x0403900B RID: 233483
		[Token(Token = "0x403900B")]
		[FieldOffset(Offset = "0x18")]
		public string focusStageIdToStageSelectState;

		// Token: 0x0403900C RID: 233484
		[Token(Token = "0x403900C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403900D RID: 233485
		[Token(Token = "0x403900D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x0403900E RID: 233486
		[Token(Token = "0x403900E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
