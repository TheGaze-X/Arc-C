using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x0200578D RID: 22413
	[Token(Token = "0x200578D")]
	public class RL02StatusBarSanEffect : RoguelikeMenuEffect
	{
		// Token: 0x06020CA1 RID: 134305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020CA1")]
		[Address(RVA = "0x1B27780", Offset = "0x1B26380", VA = "0x181B27780")]
		public void RenderSanEffectRank(SanEffectRank rank)
		{
		}

		// Token: 0x06020CA2 RID: 134306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020CA2")]
		[Address(RVA = "0x1B27840", Offset = "0x1B26440", VA = "0x181B27840")]
		public RL02StatusBarSanEffect()
		{
		}

		// Token: 0x0402C8AF RID: 182447
		[Token(Token = "0x402C8AF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RL02StatusBarSanEffect.SanEffectConfig[] _sanEffectConfigs;

		// Token: 0x0402C8B0 RID: 182448
		[Token(Token = "0x402C8B0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderSanEffectRank;

		// Token: 0x0402C8B1 RID: 182449
		[Token(Token = "0x402C8B1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200578E RID: 22414
		[Token(Token = "0x200578E")]
		[Serializable]
		private class SanEffectConfig
		{
			// Token: 0x06020CA3 RID: 134307 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020CA3")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SanEffectConfig()
			{
			}

			// Token: 0x0402C8B2 RID: 182450
			[Token(Token = "0x402C8B2")]
			[FieldOffset(Offset = "0x10")]
			public SanEffectRank effectRank;

			// Token: 0x0402C8B3 RID: 182451
			[Token(Token = "0x402C8B3")]
			[FieldOffset(Offset = "0x18")]
			public GameObject effectGameObject;
		}
	}
}
