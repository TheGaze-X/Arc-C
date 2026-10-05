using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005347 RID: 21319
	[Token(Token = "0x2005347")]
	public class RoguelikeMenuCharViewModel : RoguelikeMenuCompViewModel
	{
		// Token: 0x0601F706 RID: 128774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F706")]
		[Address(RVA = "0x1927A00", Offset = "0x1926600", VA = "0x181927A00", Slot = "4")]
		public override void LoadData(string topicId)
		{
		}

		// Token: 0x0601F707 RID: 128775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F707")]
		[Address(RVA = "0x1927C90", Offset = "0x1926890", VA = "0x181927C90")]
		public RoguelikeMenuCharViewModel()
		{
		}

		// Token: 0x0601F708 RID: 128776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F708")]
		[Address(RVA = "0x1927C30", Offset = "0x1926830", VA = "0x181927C30")]
		private void <>xLuaBaseProxy_LoadData(string P0)
		{
		}

		// Token: 0x0402A4B6 RID: 173238
		[Token(Token = "0x402A4B6")]
		[FieldOffset(Offset = "0x18")]
		public int charCount;

		// Token: 0x0402A4B7 RID: 173239
		[Token(Token = "0x402A4B7")]
		[FieldOffset(Offset = "0x1C")]
		public bool initProcessing;

		// Token: 0x0402A4B8 RID: 173240
		[Token(Token = "0x402A4B8")]
		[FieldOffset(Offset = "0x20")]
		public PlayerRoguelikePlayerEventType initPhase;

		// Token: 0x0402A4B9 RID: 173241
		[Token(Token = "0x402A4B9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402A4BA RID: 173242
		[Token(Token = "0x402A4BA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
