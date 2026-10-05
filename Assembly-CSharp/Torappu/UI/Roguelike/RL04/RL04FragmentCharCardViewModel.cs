using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x020056D7 RID: 22231
	[Token(Token = "0x20056D7")]
	public class RL04FragmentCharCardViewModel : IHotfixable
	{
		// Token: 0x17004C65 RID: 19557
		// (get) Token: 0x060209A7 RID: 133543 RVA: 0x000B6748 File Offset: 0x000B4948
		[Token(Token = "0x17004C65")]
		public bool isEmpty
		{
			[Token(Token = "0x60209A7")]
			[Address(RVA = "0x1ABB130", Offset = "0x1AB9D30", VA = "0x181ABB130")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060209A8 RID: 133544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60209A8")]
		[Address(RVA = "0x1ABB0D0", Offset = "0x1AB9CD0", VA = "0x181ABB0D0")]
		public RL04FragmentCharCardViewModel()
		{
		}

		// Token: 0x0402C32D RID: 181037
		[Token(Token = "0x402C32D")]
		[FieldOffset(Offset = "0x10")]
		public string charId;

		// Token: 0x0402C32E RID: 181038
		[Token(Token = "0x402C32E")]
		[FieldOffset(Offset = "0x18")]
		public string avatarId;

		// Token: 0x0402C32F RID: 181039
		[Token(Token = "0x402C32F")]
		[FieldOffset(Offset = "0x20")]
		public EvolvePhase evolvePhase;

		// Token: 0x0402C330 RID: 181040
		[Token(Token = "0x402C330")]
		[FieldOffset(Offset = "0x24")]
		public int weight;

		// Token: 0x0402C331 RID: 181041
		[Token(Token = "0x402C331")]
		[FieldOffset(Offset = "0x28")]
		public int instId;

		// Token: 0x0402C332 RID: 181042
		[Token(Token = "0x402C332")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isEmpty;

		// Token: 0x0402C333 RID: 181043
		[Token(Token = "0x402C333")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
