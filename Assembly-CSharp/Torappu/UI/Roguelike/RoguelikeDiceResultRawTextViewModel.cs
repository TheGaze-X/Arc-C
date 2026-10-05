using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020051EA RID: 20970
	[Token(Token = "0x20051EA")]
	public class RoguelikeDiceResultRawTextViewModel : RoguelikeDiceResultViewModel
	{
		// Token: 0x1700484D RID: 18509
		// (get) Token: 0x0601EF72 RID: 126834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700484D")]
		public override Type viewType
		{
			[Token(Token = "0x601EF72")]
			[Address(RVA = "0x18B2B00", Offset = "0x18B1700", VA = "0x1818B2B00", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601EF73 RID: 126835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EF73")]
		[Address(RVA = "0x18B29B0", Offset = "0x18B15B0", VA = "0x1818B29B0", Slot = "5")]
		public override void LoadFromPlayerData(string topicId, PlayerRoguelikePendingEvent.Dice.Result result, RoguelikeDiceRuleData data)
		{
		}

		// Token: 0x0601EF74 RID: 126836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EF74")]
		[Address(RVA = "0x18B2A60", Offset = "0x18B1660", VA = "0x1818B2A60")]
		public RoguelikeDiceResultRawTextViewModel()
		{
		}

		// Token: 0x040298E8 RID: 170216
		[Token(Token = "0x40298E8")]
		[FieldOffset(Offset = "0x10")]
		public string resultDesc;

		// Token: 0x040298E9 RID: 170217
		[Token(Token = "0x40298E9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_viewType;

		// Token: 0x040298EA RID: 170218
		[Token(Token = "0x40298EA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadFromPlayerData;

		// Token: 0x040298EB RID: 170219
		[Token(Token = "0x40298EB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
