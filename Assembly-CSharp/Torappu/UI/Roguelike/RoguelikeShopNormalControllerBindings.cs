using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200550E RID: 21774
	[Token(Token = "0x200550E")]
	public class RoguelikeShopNormalControllerBindings : IHotfixable
	{
		// Token: 0x06020065 RID: 131173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020065")]
		[Address(RVA = "0x1A24A90", Offset = "0x1A23690", VA = "0x181A24A90")]
		public void OnLeaveShopClicked()
		{
		}

		// Token: 0x06020066 RID: 131174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020066")]
		[Address(RVA = "0x1A24A20", Offset = "0x1A23620", VA = "0x181A24A20")]
		public void OnDealerClick()
		{
		}

		// Token: 0x06020067 RID: 131175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020067")]
		[Address(RVA = "0x1A24B00", Offset = "0x1A23700", VA = "0x181A24B00")]
		public void OnSwitchClick()
		{
		}

		// Token: 0x06020068 RID: 131176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020068")]
		[Address(RVA = "0x1A24B70", Offset = "0x1A23770", VA = "0x181A24B70")]
		public RoguelikeShopNormalControllerBindings()
		{
		}

		// Token: 0x0402B3DB RID: 177115
		[Token(Token = "0x402B3DB")]
		[FieldOffset(Offset = "0x10")]
		private Action m_onLeaveShop;

		// Token: 0x0402B3DC RID: 177116
		[Token(Token = "0x402B3DC")]
		[FieldOffset(Offset = "0x18")]
		private Action m_onDealerClick;

		// Token: 0x0402B3DD RID: 177117
		[Token(Token = "0x402B3DD")]
		[FieldOffset(Offset = "0x20")]
		private Action m_onSwitchClick;

		// Token: 0x0402B3DE RID: 177118
		[Token(Token = "0x402B3DE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnLeaveShopClicked;

		// Token: 0x0402B3DF RID: 177119
		[Token(Token = "0x402B3DF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDealerClick;

		// Token: 0x0402B3E0 RID: 177120
		[Token(Token = "0x402B3E0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnSwitchClick;

		// Token: 0x0402B3E1 RID: 177121
		[Token(Token = "0x402B3E1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200550F RID: 21775
		[Token(Token = "0x200550F")]
		public struct Builder
		{
			// Token: 0x06020069 RID: 131177 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6020069")]
			[Address(RVA = "0x1A165C0", Offset = "0x1A151C0", VA = "0x181A165C0")]
			public RoguelikeShopNormalControllerBindings Build()
			{
				return null;
			}

			// Token: 0x0402B3E2 RID: 177122
			[Token(Token = "0x402B3E2")]
			[FieldOffset(Offset = "0x0")]
			public Action onDealerClick;

			// Token: 0x0402B3E3 RID: 177123
			[Token(Token = "0x402B3E3")]
			[FieldOffset(Offset = "0x8")]
			public Action onLeaveShop;

			// Token: 0x0402B3E4 RID: 177124
			[Token(Token = "0x402B3E4")]
			[FieldOffset(Offset = "0x10")]
			public Action onSwitchClick;
		}
	}
}
