using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x02005824 RID: 22564
	[Token(Token = "0x2005824")]
	public class RL03DungeonChaosAndVisionEffect : MonoBehaviour, IHotfixable
	{
		// Token: 0x06020F91 RID: 135057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F91")]
		[Address(RVA = "0x1B47840", Offset = "0x1B46440", VA = "0x181B47840")]
		public void SetEffectShow(ChaosEffectRank rank, int visionNum)
		{
		}

		// Token: 0x06020F92 RID: 135058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F92")]
		[Address(RVA = "0x1B479C0", Offset = "0x1B465C0", VA = "0x181B479C0")]
		public RL03DungeonChaosAndVisionEffect()
		{
		}

		// Token: 0x0402CD74 RID: 183668
		[Token(Token = "0x402CD74")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RL03DungeonChaosAndVisionEffect.ChaosEffectConfig[] _chaosEffectConfigs;

		// Token: 0x0402CD75 RID: 183669
		[Token(Token = "0x402CD75")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RL03DungeonChaosAndVisionEffect.VisionEffectConfig[] _visionEffectConfigs;

		// Token: 0x0402CD76 RID: 183670
		[Token(Token = "0x402CD76")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetEffectShow;

		// Token: 0x0402CD77 RID: 183671
		[Token(Token = "0x402CD77")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005825 RID: 22565
		[Token(Token = "0x2005825")]
		[Serializable]
		private class ChaosEffectConfig
		{
			// Token: 0x06020F93 RID: 135059 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020F93")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ChaosEffectConfig()
			{
			}

			// Token: 0x0402CD78 RID: 183672
			[Token(Token = "0x402CD78")]
			[FieldOffset(Offset = "0x10")]
			public ChaosEffectRank chaosEffectRank;

			// Token: 0x0402CD79 RID: 183673
			[Token(Token = "0x402CD79")]
			[FieldOffset(Offset = "0x18")]
			public GameObject effectGameObject;
		}

		// Token: 0x02005826 RID: 22566
		[Token(Token = "0x2005826")]
		[Serializable]
		private class VisionEffectConfig
		{
			// Token: 0x06020F94 RID: 135060 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020F94")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public VisionEffectConfig()
			{
			}

			// Token: 0x0402CD7A RID: 183674
			[Token(Token = "0x402CD7A")]
			[FieldOffset(Offset = "0x10")]
			public int visionNum;

			// Token: 0x0402CD7B RID: 183675
			[Token(Token = "0x402CD7B")]
			[FieldOffset(Offset = "0x18")]
			public GameObject effectGameObject;
		}
	}
}
