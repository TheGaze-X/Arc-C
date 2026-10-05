using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.DeepSeaRP
{
	// Token: 0x02005113 RID: 20755
	[Token(Token = "0x2005113")]
	public class DeepSeaRPBattlePreviewInfoPanel : DeepSeaRPBattlePreviewInfoBasicPanel
	{
		// Token: 0x0601EA62 RID: 125538 RVA: 0x000AF290 File Offset: 0x000AD490
		[Token(Token = "0x601EA62")]
		[Address(RVA = "0x1850FF0", Offset = "0x184FBF0", VA = "0x181850FF0", Slot = "8")]
		protected override bool OnBattleNodeChanged(DeepSeaRPBattleNodeDetailViewModel viewModel)
		{
			return default(bool);
		}

		// Token: 0x0601EA63 RID: 125539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA63")]
		[Address(RVA = "0x1851080", Offset = "0x184FC80", VA = "0x181851080", Slot = "9")]
		protected override void UpdateSwitchTween(DeepSeaRPBattleNodeDetailViewModel viewModel)
		{
		}

		// Token: 0x0601EA64 RID: 125540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA64")]
		[Address(RVA = "0x1851130", Offset = "0x184FD30", VA = "0x181851130")]
		public DeepSeaRPBattlePreviewInfoPanel()
		{
		}

		// Token: 0x0601EA65 RID: 125541 RVA: 0x000AF2A8 File Offset: 0x000AD4A8
		[Token(Token = "0x601EA65")]
		[Address(RVA = "0x1851070", Offset = "0x184FC70", VA = "0x181851070")]
		private bool <>xLuaBaseProxy_OnBattleNodeChanged(DeepSeaRPBattleNodeDetailViewModel P0)
		{
			return default(bool);
		}

		// Token: 0x0402919E RID: 168350
		[Token(Token = "0x402919E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnBattleNodeChanged;

		// Token: 0x0402919F RID: 168351
		[Token(Token = "0x402919F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateSwitchTween;

		// Token: 0x040291A0 RID: 168352
		[Token(Token = "0x40291A0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
