using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200437C RID: 17276
	[Token(Token = "0x200437C")]
	public class SandboxV2RacerTempInventoryStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0601A875 RID: 108661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A875")]
		[Address(RVA = "0x13AD470", Offset = "0x13AC070", VA = "0x1813AD470")]
		public void LoadData()
		{
		}

		// Token: 0x0601A876 RID: 108662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A876")]
		[Address(RVA = "0x13AD620", Offset = "0x13AC220", VA = "0x1813AD620")]
		public SandboxV2RacerTempInventoryStateBean()
		{
		}

		// Token: 0x04021C2E RID: 138286
		[Token(Token = "0x4021C2E")]
		[FieldOffset(Offset = "0x10")]
		public SandboxV2RacerTempInventoryProperty property;

		// Token: 0x04021C2F RID: 138287
		[Token(Token = "0x4021C2F")]
		[FieldOffset(Offset = "0x18")]
		public string topicId;

		// Token: 0x04021C30 RID: 138288
		[Token(Token = "0x4021C30")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04021C31 RID: 138289
		[Token(Token = "0x4021C31")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
