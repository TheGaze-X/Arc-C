using System;
using Il2CppDummyDll;
using Torappu.UI.RoguelikeTopic;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL01
{
	// Token: 0x020057B3 RID: 22451
	[Token(Token = "0x20057B3")]
	public class RL01ClassicEndingMonthStatsCharView : RoguelikeClassicEndingMonthStatsCharView
	{
		// Token: 0x06020D59 RID: 134489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020D59")]
		[Address(RVA = "0x1B1A540", Offset = "0x1B19140", VA = "0x181B1A540", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x06020D5A RID: 134490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020D5A")]
		[Address(RVA = "0x1B1A6F0", Offset = "0x1B192F0", VA = "0x181B1A6F0", Slot = "5")]
		public override void Render(RoguelikeEndingControllerBase endingController, RoguelikeClassicEndingMonthViewModel viewModel)
		{
		}

		// Token: 0x06020D5B RID: 134491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020D5B")]
		[Address(RVA = "0x1B1A9B0", Offset = "0x1B195B0", VA = "0x181B1A9B0")]
		public RL01ClassicEndingMonthStatsCharView()
		{
		}

		// Token: 0x06020D5C RID: 134492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020D5C")]
		[Address(RVA = "0x1A33990", Offset = "0x1A32590", VA = "0x181A33990")]
		private void <>xLuaBaseProxy_Render(RoguelikeEndingControllerBase P0, RoguelikeClassicEndingMonthViewModel P1)
		{
		}

		// Token: 0x0402C9D8 RID: 182744
		[Token(Token = "0x402C9D8")]
		private const int CHAR_PORTRAIT_COUNT = 3;

		// Token: 0x0402C9D9 RID: 182745
		[Token(Token = "0x402C9D9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _bkgName;

		// Token: 0x0402C9DA RID: 182746
		[Token(Token = "0x402C9DA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAtlasImage _monthBack;

		// Token: 0x0402C9DB RID: 182747
		[Token(Token = "0x402C9DB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RoguelikeTopicMonthSquadCharPortraitView _charPortraitPrefab;

		// Token: 0x0402C9DC RID: 182748
		[Token(Token = "0x402C9DC")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform[] _charPortraitViewHolders;

		// Token: 0x0402C9DD RID: 182749
		[Token(Token = "0x402C9DD")]
		[FieldOffset(Offset = "0x50")]
		private RoguelikeTopicMonthSquadCharPortraitView[] m_charPortraitViews;

		// Token: 0x0402C9DE RID: 182750
		[Token(Token = "0x402C9DE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402C9DF RID: 182751
		[Token(Token = "0x402C9DF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C9E0 RID: 182752
		[Token(Token = "0x402C9E0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
