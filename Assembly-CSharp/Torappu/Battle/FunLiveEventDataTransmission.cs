using System;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200226E RID: 8814
	[Token(Token = "0x200226E")]
	public class FunLiveEventDataTransmission : GlobalBuff, IHotfixable
	{
		// Token: 0x0600DDB3 RID: 56755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDB3")]
		[Address(RVA = "0x3635830", Offset = "0x3634430", VA = "0x183635830", Slot = "11")]
		public override void OnInit(LevelData.GlobalBuffData data)
		{
		}

		// Token: 0x0600DDB4 RID: 56756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDB4")]
		[Address(RVA = "0x36356C0", Offset = "0x36342C0", VA = "0x1836356C0")]
		private void GetRareEventFromBlackboard()
		{
		}

		// Token: 0x0600DDB5 RID: 56757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDB5")]
		[Address(RVA = "0x3635A00", Offset = "0x3634600", VA = "0x183635A00")]
		public FunLiveEventDataTransmission()
		{
		}

		// Token: 0x0600DDB6 RID: 56758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDB6")]
		[Address(RVA = "0x362AB00", Offset = "0x3629700", VA = "0x18362AB00")]
		private void <>xLuaBaseProxy_OnInit(LevelData.GlobalBuffData P0)
		{
		}

		// Token: 0x0400F04D RID: 61517
		[Token(Token = "0x400F04D")]
		[FieldOffset(Offset = "0x148")]
		private GameModeFactory.FunLiveGameMode m_gameMode;

		// Token: 0x0400F04E RID: 61518
		[Token(Token = "0x400F04E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400F04F RID: 61519
		[Token(Token = "0x400F04F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetRareEventFromBlackboard;

		// Token: 0x0400F050 RID: 61520
		[Token(Token = "0x400F050")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
