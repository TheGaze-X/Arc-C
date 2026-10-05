using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004142 RID: 16706
	[Token(Token = "0x2004142")]
	public class SandboxV2DineStateBean : IStateBean, IHotfixable
	{
		// Token: 0x06019CCC RID: 105676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019CCC")]
		[Address(RVA = "0x12AECB0", Offset = "0x12AD8B0", VA = "0x1812AECB0")]
		public SandboxV2DineStateBean()
		{
		}

		// Token: 0x040205FF RID: 132607
		[Token(Token = "0x40205FF")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x04020600 RID: 132608
		[Token(Token = "0x4020600")]
		[FieldOffset(Offset = "0x18")]
		public int charInstId;

		// Token: 0x04020601 RID: 132609
		[Token(Token = "0x4020601")]
		[FieldOffset(Offset = "0x20")]
		public SandboxV2DineProperty dineProperty;

		// Token: 0x04020602 RID: 132610
		[Token(Token = "0x4020602")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
