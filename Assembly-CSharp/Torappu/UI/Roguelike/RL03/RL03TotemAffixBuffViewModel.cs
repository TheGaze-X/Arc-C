using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x02005821 RID: 22561
	[Token(Token = "0x2005821")]
	public class RL03TotemAffixBuffViewModel : IHotfixable
	{
		// Token: 0x06020F79 RID: 135033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020F79")]
		[Address(RVA = "0x1B54560", Offset = "0x1B53160", VA = "0x181B54560")]
		public static RL03TotemAffixBuffViewModel Create(string topicId, string id)
		{
			return null;
		}

		// Token: 0x06020F7A RID: 135034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F7A")]
		[Address(RVA = "0x1B54780", Offset = "0x1B53380", VA = "0x181B54780")]
		public void LoadData(string topicId, string id)
		{
		}

		// Token: 0x06020F7B RID: 135035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F7B")]
		[Address(RVA = "0x1B54920", Offset = "0x1B53520", VA = "0x181B54920")]
		public RL03TotemAffixBuffViewModel()
		{
		}

		// Token: 0x0402CD40 RID: 183616
		[Token(Token = "0x402CD40")]
		[FieldOffset(Offset = "0x10")]
		public string affixId;

		// Token: 0x0402CD41 RID: 183617
		[Token(Token = "0x402CD41")]
		[FieldOffset(Offset = "0x18")]
		public string affixName;

		// Token: 0x0402CD42 RID: 183618
		[Token(Token = "0x402CD42")]
		[FieldOffset(Offset = "0x20")]
		public string affixDesc;

		// Token: 0x0402CD43 RID: 183619
		[Token(Token = "0x402CD43")]
		[FieldOffset(Offset = "0x28")]
		public string affixCombinedDesc;

		// Token: 0x0402CD44 RID: 183620
		[Token(Token = "0x402CD44")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Create;

		// Token: 0x0402CD45 RID: 183621
		[Token(Token = "0x402CD45")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402CD46 RID: 183622
		[Token(Token = "0x402CD46")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
