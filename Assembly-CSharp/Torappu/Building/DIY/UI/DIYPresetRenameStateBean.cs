using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x020019D1 RID: 6609
	[Token(Token = "0x20019D1")]
	public class DIYPresetRenameStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0600A602 RID: 42498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A602")]
		[Address(RVA = "0x31F43E0", Offset = "0x31F2FE0", VA = "0x1831F43E0")]
		public DIYPresetRenameStateBean()
		{
		}

		// Token: 0x04009DE1 RID: 40417
		[Token(Token = "0x4009DE1")]
		[FieldOffset(Offset = "0x10")]
		public int presetIndex;

		// Token: 0x04009DE2 RID: 40418
		[Token(Token = "0x4009DE2")]
		[FieldOffset(Offset = "0x18")]
		public string presetName;

		// Token: 0x04009DE3 RID: 40419
		[Token(Token = "0x4009DE3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
