using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020069E6 RID: 27110
	[Token(Token = "0x20069E6")]
	public class ZoneRecordRewardViewModel : IHotfixable
	{
		// Token: 0x06026C69 RID: 158825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C69")]
		[Address(RVA = "0x21E43E0", Offset = "0x21E2FE0", VA = "0x1821E43E0")]
		public ZoneRecordRewardViewModel()
		{
		}

		// Token: 0x04036C70 RID: 224368
		[Token(Token = "0x4036C70")]
		[FieldOffset(Offset = "0x10")]
		public RecordRewardInfo reward;

		// Token: 0x04036C71 RID: 224369
		[Token(Token = "0x4036C71")]
		[FieldOffset(Offset = "0x18")]
		public bool isAvailable;

		// Token: 0x04036C72 RID: 224370
		[Token(Token = "0x4036C72")]
		[FieldOffset(Offset = "0x19")]
		public bool isGained;

		// Token: 0x04036C73 RID: 224371
		[Token(Token = "0x4036C73")]
		[FieldOffset(Offset = "0x1A")]
		public bool haveMission;

		// Token: 0x04036C74 RID: 224372
		[Token(Token = "0x4036C74")]
		[FieldOffset(Offset = "0x20")]
		public string missionDesc;

		// Token: 0x04036C75 RID: 224373
		[Token(Token = "0x4036C75")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
