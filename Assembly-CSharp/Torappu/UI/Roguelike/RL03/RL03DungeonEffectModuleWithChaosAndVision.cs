using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x02005828 RID: 22568
	[Token(Token = "0x2005828")]
	public class RL03DungeonEffectModuleWithChaosAndVision : RoguelikeDungeonModule
	{
		// Token: 0x06020F99 RID: 135065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F99")]
		[Address(RVA = "0x1B47F60", Offset = "0x1B46B60", VA = "0x181B47F60", Slot = "4")]
		protected override void OnCreate()
		{
		}

		// Token: 0x06020F9A RID: 135066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F9A")]
		[Address(RVA = "0x1B47FC0", Offset = "0x1B46BC0", VA = "0x181B47FC0", Slot = "5")]
		protected override void OnReloadDungeon()
		{
		}

		// Token: 0x06020F9B RID: 135067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F9B")]
		[Address(RVA = "0x1B48020", Offset = "0x1B46C20", VA = "0x181B48020", Slot = "7")]
		protected override void OnStateChanged()
		{
		}

		// Token: 0x06020F9C RID: 135068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F9C")]
		[Address(RVA = "0x1B480F0", Offset = "0x1B46CF0", VA = "0x181B480F0")]
		private void _RefreshEffect()
		{
		}

		// Token: 0x06020F9D RID: 135069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F9D")]
		[Address(RVA = "0x1B48580", Offset = "0x1B47180", VA = "0x181B48580")]
		public RL03DungeonEffectModuleWithChaosAndVision()
		{
		}

		// Token: 0x06020F9E RID: 135070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F9E")]
		[Address(RVA = "0x1A4A420", Offset = "0x1A49020", VA = "0x181A4A420")]
		private void <>xLuaBaseProxy_OnCreate()
		{
		}

		// Token: 0x06020F9F RID: 135071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F9F")]
		[Address(RVA = "0x1AA71A0", Offset = "0x1AA5DA0", VA = "0x181AA71A0")]
		private void <>xLuaBaseProxy_OnReloadDungeon()
		{
		}

		// Token: 0x06020FA0 RID: 135072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020FA0")]
		[Address(RVA = "0x1AA71B0", Offset = "0x1AA5DB0", VA = "0x181AA71B0")]
		private void <>xLuaBaseProxy_OnStateChanged()
		{
		}

		// Token: 0x0402CD80 RID: 183680
		[Token(Token = "0x402CD80")]
		private const int DEFAULT_VISION_NUM = -1;

		// Token: 0x0402CD81 RID: 183681
		[Token(Token = "0x402CD81")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RL03DungeonChaosAndVisionEffect _chaosAndVisionEffect;

		// Token: 0x0402CD82 RID: 183682
		[Token(Token = "0x402CD82")]
		[FieldOffset(Offset = "0x30")]
		private RL03DungeonChaosAndVisionEffect m_chaosAndVisionEffect;

		// Token: 0x0402CD83 RID: 183683
		[Token(Token = "0x402CD83")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0402CD84 RID: 183684
		[Token(Token = "0x402CD84")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnReloadDungeon;

		// Token: 0x0402CD85 RID: 183685
		[Token(Token = "0x402CD85")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnStateChanged;

		// Token: 0x0402CD86 RID: 183686
		[Token(Token = "0x402CD86")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RefreshEffect;

		// Token: 0x0402CD87 RID: 183687
		[Token(Token = "0x402CD87")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
