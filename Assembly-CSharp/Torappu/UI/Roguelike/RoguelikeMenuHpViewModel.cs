using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005349 RID: 21321
	[Token(Token = "0x2005349")]
	public class RoguelikeMenuHpViewModel : RoguelikeMenuCompViewModel
	{
		// Token: 0x0601F70C RID: 128780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F70C")]
		[Address(RVA = "0x1928360", Offset = "0x1926F60", VA = "0x181928360", Slot = "4")]
		public override void LoadData(string topicId)
		{
		}

		// Token: 0x0601F70D RID: 128781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F70D")]
		[Address(RVA = "0x1928460", Offset = "0x1927060", VA = "0x181928460")]
		public RoguelikeMenuHpViewModel()
		{
		}

		// Token: 0x0601F70E RID: 128782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F70E")]
		[Address(RVA = "0x1927C30", Offset = "0x1926830", VA = "0x181927C30")]
		private void <>xLuaBaseProxy_LoadData(string P0)
		{
		}

		// Token: 0x0402A4BE RID: 173246
		[Token(Token = "0x402A4BE")]
		[FieldOffset(Offset = "0x18")]
		public int currHp;

		// Token: 0x0402A4BF RID: 173247
		[Token(Token = "0x402A4BF")]
		[FieldOffset(Offset = "0x1C")]
		public int currShieldHp;

		// Token: 0x0402A4C0 RID: 173248
		[Token(Token = "0x402A4C0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402A4C1 RID: 173249
		[Token(Token = "0x402A4C1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
