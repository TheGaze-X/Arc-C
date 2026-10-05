using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005351 RID: 21329
	[Token(Token = "0x2005351")]
	public class RoguelikeMenuSquadViewModel : RoguelikeMenuCompViewModel
	{
		// Token: 0x0601F72B RID: 128811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F72B")]
		[Address(RVA = "0x192A550", Offset = "0x1929150", VA = "0x18192A550", Slot = "4")]
		public override void LoadData(string topicId)
		{
		}

		// Token: 0x0601F72C RID: 128812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F72C")]
		[Address(RVA = "0x192A830", Offset = "0x1929430", VA = "0x18192A830")]
		public RoguelikeMenuSquadViewModel()
		{
		}

		// Token: 0x0601F72D RID: 128813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F72D")]
		[Address(RVA = "0x1927C30", Offset = "0x1926830", VA = "0x181927C30")]
		private void <>xLuaBaseProxy_LoadData(string P0)
		{
		}

		// Token: 0x0402A4EF RID: 173295
		[Token(Token = "0x402A4EF")]
		[FieldOffset(Offset = "0x18")]
		public List<RoguelikeMenuSquadSlotViewModel> squadSlots;

		// Token: 0x0402A4F0 RID: 173296
		[Token(Token = "0x402A4F0")]
		[FieldOffset(Offset = "0x20")]
		public bool initProcessing;

		// Token: 0x0402A4F1 RID: 173297
		[Token(Token = "0x402A4F1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402A4F2 RID: 173298
		[Token(Token = "0x402A4F2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
