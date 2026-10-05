using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200544F RID: 21583
	[Token(Token = "0x200544F")]
	public class RoguelikeSingleTopicResHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601FC1B RID: 130075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FC1B")]
		[Address(RVA = "0x196EFA0", Offset = "0x196DBA0", VA = "0x18196EFA0")]
		public RoguelikeMapBossIconHolder GetBossIconHolder()
		{
			return null;
		}

		// Token: 0x0601FC1C RID: 130076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FC1C")]
		[Address(RVA = "0x196F000", Offset = "0x196DC00", VA = "0x18196F000")]
		public RoguelikeMenu GetMenuPrefab()
		{
			return null;
		}

		// Token: 0x0601FC1D RID: 130077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FC1D")]
		[Address(RVA = "0x196F060", Offset = "0x196DC60", VA = "0x18196F060")]
		public RoguelikeSingleTopicResHolder()
		{
		}

		// Token: 0x0402ACA4 RID: 175268
		[Token(Token = "0x402ACA4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RoguelikeMapBossIconHolder _mapBossIconHolder;

		// Token: 0x0402ACA5 RID: 175269
		[Token(Token = "0x402ACA5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RoguelikeMenu _menuPrefab;

		// Token: 0x0402ACA6 RID: 175270
		[Token(Token = "0x402ACA6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetBossIconHolder;

		// Token: 0x0402ACA7 RID: 175271
		[Token(Token = "0x402ACA7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetMenuPrefab;

		// Token: 0x0402ACA8 RID: 175272
		[Token(Token = "0x402ACA8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
