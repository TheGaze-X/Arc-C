using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004360 RID: 17248
	[Token(Token = "0x2004360")]
	public class SandboxV2RacerInventoryStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0601A78F RID: 108431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A78F")]
		[Address(RVA = "0x13903E0", Offset = "0x138EFE0", VA = "0x1813903E0")]
		public void LoadData(SandboxV2RacerInventoryViewModel.Input input)
		{
		}

		// Token: 0x0601A790 RID: 108432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A790")]
		[Address(RVA = "0x1390690", Offset = "0x138F290", VA = "0x181390690")]
		public SandboxV2RacerInventoryStateBean()
		{
		}

		// Token: 0x04021AE9 RID: 137961
		[Token(Token = "0x4021AE9")]
		[FieldOffset(Offset = "0x10")]
		public SandboxV2RacerInventoryProperty property;

		// Token: 0x04021AEA RID: 137962
		[Token(Token = "0x4021AEA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04021AEB RID: 137963
		[Token(Token = "0x4021AEB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
