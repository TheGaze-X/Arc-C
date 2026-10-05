using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044D3 RID: 17619
	[Token(Token = "0x20044D3")]
	public class RoguelikeTopicDifficultyItemColors : UIColorSwitcher<RoguelikeTopicDifficultyItemStatus>
	{
		// Token: 0x0601AE75 RID: 110197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE75")]
		[Address(RVA = "0x1409A80", Offset = "0x1408680", VA = "0x181409A80", Slot = "4")]
		protected override void OnInitDefines(Action<RoguelikeTopicDifficultyItemStatus, Color> addCase)
		{
		}

		// Token: 0x0601AE76 RID: 110198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE76")]
		[Address(RVA = "0x1409BB0", Offset = "0x14087B0", VA = "0x181409BB0")]
		public RoguelikeTopicDifficultyItemColors()
		{
		}

		// Token: 0x0402279A RID: 141210
		[Token(Token = "0x402279A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RoguelikeTopicDifficultyItemColors.Case[] _defineCases;

		// Token: 0x0402279B RID: 141211
		[Token(Token = "0x402279B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInitDefines;

		// Token: 0x0402279C RID: 141212
		[Token(Token = "0x402279C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020044D4 RID: 17620
		[Token(Token = "0x20044D4")]
		[Serializable]
		public struct Case
		{
			// Token: 0x0402279D RID: 141213
			[Token(Token = "0x402279D")]
			[FieldOffset(Offset = "0x0")]
			public RoguelikeTopicDifficultyItemStatus type;

			// Token: 0x0402279E RID: 141214
			[Token(Token = "0x402279E")]
			[FieldOffset(Offset = "0x4")]
			public Color color;
		}
	}
}
