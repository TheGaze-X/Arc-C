using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200431C RID: 17180
	[Token(Token = "0x200431C")]
	public class SandboxV2ChallengeModeUnlockCondViewModel : IHotfixable
	{
		// Token: 0x17003E9A RID: 16026
		// (get) Token: 0x0601A653 RID: 108115 RVA: 0x000A1A90 File Offset: 0x0009FC90
		[Token(Token = "0x17003E9A")]
		public bool completed
		{
			[Token(Token = "0x601A653")]
			[Address(RVA = "0x1340590", Offset = "0x133F190", VA = "0x181340590")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601A654 RID: 108116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A654")]
		[Address(RVA = "0x1340530", Offset = "0x133F130", VA = "0x181340530")]
		public SandboxV2ChallengeModeUnlockCondViewModel()
		{
		}

		// Token: 0x0402183A RID: 137274
		[Token(Token = "0x402183A")]
		[FieldOffset(Offset = "0x10")]
		public string condId;

		// Token: 0x0402183B RID: 137275
		[Token(Token = "0x402183B")]
		[FieldOffset(Offset = "0x18")]
		public int condSortId;

		// Token: 0x0402183C RID: 137276
		[Token(Token = "0x402183C")]
		[FieldOffset(Offset = "0x20")]
		public string condDesc;

		// Token: 0x0402183D RID: 137277
		[Token(Token = "0x402183D")]
		[FieldOffset(Offset = "0x28")]
		public int currProgress;

		// Token: 0x0402183E RID: 137278
		[Token(Token = "0x402183E")]
		[FieldOffset(Offset = "0x2C")]
		public int totProgress;

		// Token: 0x0402183F RID: 137279
		[Token(Token = "0x402183F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_completed;

		// Token: 0x04021840 RID: 137280
		[Token(Token = "0x4021840")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
