using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004156 RID: 16726
	[Token(Token = "0x2004156")]
	public class SandboxV2BasementUpgradeConditionViewModel : IHotfixable
	{
		// Token: 0x06019D3F RID: 105791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D3F")]
		[Address(RVA = "0x12A32D0", Offset = "0x12A1ED0", VA = "0x1812A32D0")]
		public SandboxV2BasementUpgradeConditionViewModel()
		{
		}

		// Token: 0x040206EA RID: 132842
		[Token(Token = "0x40206EA")]
		[FieldOffset(Offset = "0x10")]
		public string conditionDesc;

		// Token: 0x040206EB RID: 132843
		[Token(Token = "0x40206EB")]
		[FieldOffset(Offset = "0x18")]
		public string total;

		// Token: 0x040206EC RID: 132844
		[Token(Token = "0x40206EC")]
		[FieldOffset(Offset = "0x20")]
		public int progress;

		// Token: 0x040206ED RID: 132845
		[Token(Token = "0x40206ED")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
