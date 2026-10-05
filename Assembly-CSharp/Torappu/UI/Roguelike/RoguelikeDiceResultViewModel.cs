using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020051EC RID: 20972
	[Token(Token = "0x20051EC")]
	public abstract class RoguelikeDiceResultViewModel : IHotfixable
	{
		// Token: 0x1700484F RID: 18511
		// (get) Token: 0x0601EF78 RID: 126840
		[Token(Token = "0x1700484F")]
		public abstract Type viewType { [Token(Token = "0x601EF78")] get; }

		// Token: 0x0601EF79 RID: 126841
		[Token(Token = "0x601EF79")]
		public abstract void LoadFromPlayerData(string topicId, PlayerRoguelikePendingEvent.Dice.Result result, RoguelikeDiceRuleData data);

		// Token: 0x0601EF7A RID: 126842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EF7A")]
		[Address(RVA = "0x18B2D70", Offset = "0x18B1970", VA = "0x1818B2D70")]
		protected RoguelikeDiceResultViewModel()
		{
		}

		// Token: 0x040298F0 RID: 170224
		[Token(Token = "0x40298F0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
