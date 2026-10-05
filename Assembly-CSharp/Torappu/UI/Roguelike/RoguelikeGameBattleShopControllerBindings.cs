using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020054DF RID: 21727
	[Token(Token = "0x20054DF")]
	public class RoguelikeGameBattleShopControllerBindings : IHotfixable
	{
		// Token: 0x0601FF4F RID: 130895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FF4F")]
		[Address(RVA = "0x1A0EE70", Offset = "0x1A0DA70", VA = "0x181A0EE70")]
		private RoguelikeGameBattleShopControllerBindings()
		{
		}

		// Token: 0x0601FF50 RID: 130896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FF50")]
		[Address(RVA = "0x1A0EE00", Offset = "0x1A0DA00", VA = "0x181A0EE00")]
		public void OnBattleConfirmClick()
		{
		}

		// Token: 0x0402B1C3 RID: 176579
		[Token(Token = "0x402B1C3")]
		[FieldOffset(Offset = "0x10")]
		private Action m_battleConfirm;

		// Token: 0x0402B1C4 RID: 176580
		[Token(Token = "0x402B1C4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0402B1C5 RID: 176581
		[Token(Token = "0x402B1C5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnBattleConfirmClick;

		// Token: 0x020054E0 RID: 21728
		[Token(Token = "0x20054E0")]
		public struct Builder
		{
			// Token: 0x0601FF51 RID: 130897 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601FF51")]
			[Address(RVA = "0x19FF310", Offset = "0x19FDF10", VA = "0x1819FF310")]
			public RoguelikeGameBattleShopControllerBindings Build()
			{
				return null;
			}

			// Token: 0x0402B1C6 RID: 176582
			[Token(Token = "0x402B1C6")]
			[FieldOffset(Offset = "0x0")]
			public Action onBattleConfirmClick;
		}
	}
}
