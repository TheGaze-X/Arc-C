using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F40 RID: 28480
	[Token(Token = "0x2006F40")]
	public class ActMultiV3MileStoneStateBean : IStateBean, IHotfixable
	{
		// Token: 0x17005F65 RID: 24421
		// (get) Token: 0x06028723 RID: 165667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005F65")]
		public ActMultiV3MilestoneProp mileStoneProp
		{
			[Token(Token = "0x6028723")]
			[Address(RVA = "0x23CAB20", Offset = "0x23C9720", VA = "0x1823CAB20")]
			get
			{
				return null;
			}
		}

		// Token: 0x06028724 RID: 165668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028724")]
		[Address(RVA = "0x23CA990", Offset = "0x23C9590", VA = "0x1823CA990")]
		public void InitModel(string actId)
		{
		}

		// Token: 0x06028725 RID: 165669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028725")]
		[Address(RVA = "0x23CAA30", Offset = "0x23C9630", VA = "0x1823CAA30")]
		public ActMultiV3MileStoneStateBean()
		{
		}

		// Token: 0x04039888 RID: 235656
		[Token(Token = "0x4039888")]
		[FieldOffset(Offset = "0x10")]
		private ActMultiV3MilestoneProp m_prop;

		// Token: 0x04039889 RID: 235657
		[Token(Token = "0x4039889")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_mileStoneProp;

		// Token: 0x0403988A RID: 235658
		[Token(Token = "0x403988A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitModel;

		// Token: 0x0403988B RID: 235659
		[Token(Token = "0x403988B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
