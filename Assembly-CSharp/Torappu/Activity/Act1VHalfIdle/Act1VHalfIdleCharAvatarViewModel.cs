using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x0200772B RID: 30507
	[Token(Token = "0x200772B")]
	public class Act1VHalfIdleCharAvatarViewModel : IHotfixable
	{
		// Token: 0x0602ADC9 RID: 175561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ADC9")]
		[Address(RVA = "0x2695DD0", Offset = "0x26949D0", VA = "0x182695DD0")]
		public Act1VHalfIdleCharAvatarViewModel()
		{
		}

		// Token: 0x0403DCAB RID: 253099
		[Token(Token = "0x403DCAB")]
		[FieldOffset(Offset = "0x10")]
		public string charId;

		// Token: 0x0403DCAC RID: 253100
		[Token(Token = "0x403DCAC")]
		[FieldOffset(Offset = "0x18")]
		public ProfessionCategory charProfession;

		// Token: 0x0403DCAD RID: 253101
		[Token(Token = "0x403DCAD")]
		[FieldOffset(Offset = "0x1C")]
		public RarityRank charRarity;

		// Token: 0x0403DCAE RID: 253102
		[Token(Token = "0x403DCAE")]
		[FieldOffset(Offset = "0x20")]
		public bool isOriginalAcquired;

		// Token: 0x0403DCAF RID: 253103
		[Token(Token = "0x403DCAF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
