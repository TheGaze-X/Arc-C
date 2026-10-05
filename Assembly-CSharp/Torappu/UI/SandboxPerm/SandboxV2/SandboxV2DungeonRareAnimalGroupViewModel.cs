using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020042E8 RID: 17128
	[Token(Token = "0x20042E8")]
	public class SandboxV2DungeonRareAnimalGroupViewModel : IHotfixable
	{
		// Token: 0x0601A559 RID: 107865 RVA: 0x000A1568 File Offset: 0x0009F768
		[Token(Token = "0x601A559")]
		[Address(RVA = "0x133AE20", Offset = "0x1339A20", VA = "0x18133AE20")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x0601A55A RID: 107866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A55A")]
		[Address(RVA = "0x133AD50", Offset = "0x1339950", VA = "0x18133AD50")]
		public void Clear()
		{
		}

		// Token: 0x0601A55B RID: 107867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A55B")]
		[Address(RVA = "0x133AC20", Offset = "0x1339820", VA = "0x18133AC20")]
		public void AddRareAnimal(SandboxV2DungeonRareAnimalViewModel rareAnimal)
		{
		}

		// Token: 0x0601A55C RID: 107868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A55C")]
		[Address(RVA = "0x133AEA0", Offset = "0x1339AA0", VA = "0x18133AEA0")]
		public SandboxV2DungeonRareAnimalGroupViewModel()
		{
		}

		// Token: 0x0402165A RID: 136794
		[Token(Token = "0x402165A")]
		[FieldOffset(Offset = "0x10")]
		public List<SandboxV2DungeonRareAnimalViewModel> rareAnimalList;

		// Token: 0x0402165B RID: 136795
		[Token(Token = "0x402165B")]
		[FieldOffset(Offset = "0x18")]
		public List<SandboxV2DropDetail> rareAnimalGroupDrop;

		// Token: 0x0402165C RID: 136796
		[Token(Token = "0x402165C")]
		[FieldOffset(Offset = "0x20")]
		public bool hpRatioValid;

		// Token: 0x0402165D RID: 136797
		[Token(Token = "0x402165D")]
		[FieldOffset(Offset = "0x24")]
		public int stackCount;

		// Token: 0x0402165E RID: 136798
		[Token(Token = "0x402165E")]
		[FieldOffset(Offset = "0x28")]
		public int hpRatio;

		// Token: 0x0402165F RID: 136799
		[Token(Token = "0x402165F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsEmpty;

		// Token: 0x04021660 RID: 136800
		[Token(Token = "0x4021660")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Clear;

		// Token: 0x04021661 RID: 136801
		[Token(Token = "0x4021661")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_AddRareAnimal;

		// Token: 0x04021662 RID: 136802
		[Token(Token = "0x4021662")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
