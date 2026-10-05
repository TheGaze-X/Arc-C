using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004399 RID: 17305
	[Token(Token = "0x2004399")]
	public class SandboxV2RiftDifficultySelectStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0601A916 RID: 108822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A916")]
		[Address(RVA = "0x13B0B50", Offset = "0x13AF750", VA = "0x1813B0B50")]
		public SandboxV2RiftDifficultySelectStateBean()
		{
		}

		// Token: 0x04021D7B RID: 138619
		[Token(Token = "0x4021D7B")]
		[FieldOffset(Offset = "0x10")]
		public SandboxV2RiftDifficultySelectProperty property;

		// Token: 0x04021D7C RID: 138620
		[Token(Token = "0x4021D7C")]
		[FieldOffset(Offset = "0x18")]
		public string topicId;

		// Token: 0x04021D7D RID: 138621
		[Token(Token = "0x4021D7D")]
		[FieldOffset(Offset = "0x20")]
		public string riftId;

		// Token: 0x04021D7E RID: 138622
		[Token(Token = "0x4021D7E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
