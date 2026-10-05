using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020068BC RID: 26812
	[Token(Token = "0x20068BC")]
	public class VecBreakV2SchedulePartModel : IHotfixable
	{
		// Token: 0x17005AAC RID: 23212
		// (get) Token: 0x060266A4 RID: 157348 RVA: 0x000CAF20 File Offset: 0x000C9120
		// (set) Token: 0x060266A5 RID: 157349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005AAC")]
		public VecBreakV2SchedulePartModel.Status status
		{
			[Token(Token = "0x60266A4")]
			[Address(RVA = "0x218F3D0", Offset = "0x218DFD0", VA = "0x18218F3D0")]
			[CompilerGenerated]
			get
			{
				return VecBreakV2SchedulePartModel.Status.INCOMING;
			}
			[Token(Token = "0x60266A5")]
			[Address(RVA = "0x218F430", Offset = "0x218E030", VA = "0x18218F430")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005AAD RID: 23213
		// (get) Token: 0x060266A6 RID: 157350 RVA: 0x000CAF38 File Offset: 0x000C9138
		[Token(Token = "0x17005AAD")]
		public int partNum
		{
			[Token(Token = "0x60266A6")]
			[Address(RVA = "0x218F370", Offset = "0x218DF70", VA = "0x18218F370")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060266A7 RID: 157351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60266A7")]
		[Address(RVA = "0x218F240", Offset = "0x218DE40", VA = "0x18218F240")]
		public void LoadData(int index, long currTs, ActVecBreakV2ScheduleBlockData scheduleData)
		{
		}

		// Token: 0x060266A8 RID: 157352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60266A8")]
		[Address(RVA = "0x218F310", Offset = "0x218DF10", VA = "0x18218F310")]
		public VecBreakV2SchedulePartModel()
		{
		}

		// Token: 0x040361BE RID: 221630
		[Token(Token = "0x40361BE")]
		[FieldOffset(Offset = "0x10")]
		private int m_index;

		// Token: 0x040361C0 RID: 221632
		[Token(Token = "0x40361C0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_status;

		// Token: 0x040361C1 RID: 221633
		[Token(Token = "0x40361C1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_status;

		// Token: 0x040361C2 RID: 221634
		[Token(Token = "0x40361C2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_partNum;

		// Token: 0x040361C3 RID: 221635
		[Token(Token = "0x40361C3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040361C4 RID: 221636
		[Token(Token = "0x40361C4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020068BD RID: 26813
		[Token(Token = "0x20068BD")]
		public enum Status
		{
			// Token: 0x040361C6 RID: 221638
			[Token(Token = "0x40361C6")]
			INCOMING,
			// Token: 0x040361C7 RID: 221639
			[Token(Token = "0x40361C7")]
			ACTIVE,
			// Token: 0x040361C8 RID: 221640
			[Token(Token = "0x40361C8")]
			EXPIRE
		}
	}
}
