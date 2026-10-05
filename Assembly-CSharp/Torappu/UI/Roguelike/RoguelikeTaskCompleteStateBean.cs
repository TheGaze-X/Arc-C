using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005551 RID: 21841
	[Token(Token = "0x2005551")]
	public class RoguelikeTaskCompleteStateBean : IStateBean, IHotfixable
	{
		// Token: 0x060201E4 RID: 131556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60201E4")]
		[Address(RVA = "0x1A43BD0", Offset = "0x1A427D0", VA = "0x181A43BD0")]
		public void LoadData(string topicId)
		{
		}

		// Token: 0x060201E5 RID: 131557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60201E5")]
		[Address(RVA = "0x1A43D90", Offset = "0x1A42990", VA = "0x181A43D90")]
		public RoguelikeTaskCompleteStateBean()
		{
		}

		// Token: 0x0402B632 RID: 177714
		[Token(Token = "0x402B632")]
		[FieldOffset(Offset = "0x10")]
		public RoguelikeTaskCompleteModel model;

		// Token: 0x0402B633 RID: 177715
		[Token(Token = "0x402B633")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402B634 RID: 177716
		[Token(Token = "0x402B634")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
