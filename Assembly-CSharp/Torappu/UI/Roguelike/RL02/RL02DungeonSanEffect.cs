using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x02005743 RID: 22339
	[Token(Token = "0x2005743")]
	public class RL02DungeonSanEffect : MonoBehaviour, IHotfixable
	{
		// Token: 0x06020BC2 RID: 134082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020BC2")]
		[Address(RVA = "0x1B09250", Offset = "0x1B07E50", VA = "0x181B09250")]
		public void SetEffectShow(SanEffectRank rank)
		{
		}

		// Token: 0x06020BC3 RID: 134083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020BC3")]
		[Address(RVA = "0x1B09310", Offset = "0x1B07F10", VA = "0x181B09310")]
		public RL02DungeonSanEffect()
		{
		}

		// Token: 0x0402C704 RID: 182020
		[Token(Token = "0x402C704")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RL02DungeonSanEffect.SanEffectConfig[] _sanEffectConfigs;

		// Token: 0x0402C705 RID: 182021
		[Token(Token = "0x402C705")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetEffectShow;

		// Token: 0x0402C706 RID: 182022
		[Token(Token = "0x402C706")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005744 RID: 22340
		[Token(Token = "0x2005744")]
		[Serializable]
		private class SanEffectConfig
		{
			// Token: 0x06020BC4 RID: 134084 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020BC4")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SanEffectConfig()
			{
			}

			// Token: 0x0402C707 RID: 182023
			[Token(Token = "0x402C707")]
			[FieldOffset(Offset = "0x10")]
			public SanEffectRank effectRank;

			// Token: 0x0402C708 RID: 182024
			[Token(Token = "0x402C708")]
			[FieldOffset(Offset = "0x18")]
			public GameObject effectGameObject;
		}
	}
}
