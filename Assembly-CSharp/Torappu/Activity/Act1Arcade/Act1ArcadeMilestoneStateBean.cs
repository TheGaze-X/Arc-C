using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x02007959 RID: 31065
	[Token(Token = "0x2007959")]
	public class Act1ArcadeMilestoneStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0602B962 RID: 178530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B962")]
		[Address(RVA = "0x277E060", Offset = "0x277CC60", VA = "0x18277E060")]
		public void InitViewModel(string actId)
		{
		}

		// Token: 0x0602B963 RID: 178531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B963")]
		[Address(RVA = "0x277E1A0", Offset = "0x277CDA0", VA = "0x18277E1A0")]
		public Act1ArcadeMilestoneStateBean()
		{
		}

		// Token: 0x0403F0A6 RID: 258214
		[Token(Token = "0x403F0A6")]
		[FieldOffset(Offset = "0x10")]
		public Act1ArcadeMilestoneProperty mileStoneProp;

		// Token: 0x0403F0A7 RID: 258215
		[Token(Token = "0x403F0A7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitViewModel;

		// Token: 0x0403F0A8 RID: 258216
		[Token(Token = "0x403F0A8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
