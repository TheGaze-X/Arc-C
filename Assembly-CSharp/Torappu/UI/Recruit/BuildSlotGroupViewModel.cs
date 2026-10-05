using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Recruit
{
	// Token: 0x020046FB RID: 18171
	[Token(Token = "0x20046FB")]
	public class BuildSlotGroupViewModel
	{
		// Token: 0x0601B8F6 RID: 112886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B8F6")]
		[Address(RVA = "0x14DA2C0", Offset = "0x14D8EC0", VA = "0x1814DA2C0")]
		public BuildSlotGroupViewModel()
		{
		}

		// Token: 0x04023B1D RID: 146205
		[Token(Token = "0x4023B1D")]
		[FieldOffset(Offset = "0x10")]
		public List<BuildSlotViewModel> buildSlots;
	}
}
