using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL03
{
	// Token: 0x020045E2 RID: 17890
	[Token(Token = "0x20045E2")]
	public class Rl03OuterBuffSummaryView : DataBinder<Rl03OuterBuffSummaryProperty>, IHotfixable
	{
		// Token: 0x0601B338 RID: 111416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B338")]
		[Address(RVA = "0x146B590", Offset = "0x146A190", VA = "0x18146B590")]
		public void Reset()
		{
		}

		// Token: 0x0601B339 RID: 111417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B339")]
		[Address(RVA = "0x146B290", Offset = "0x1469E90", VA = "0x18146B290", Slot = "7")]
		public override void OnValueChanged(Rl03OuterBuffSummaryProperty property)
		{
		}

		// Token: 0x0601B33A RID: 111418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B33A")]
		[Address(RVA = "0x146B220", Offset = "0x1469E20", VA = "0x18146B220")]
		public void OnBackClick()
		{
		}

		// Token: 0x0601B33B RID: 111419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B33B")]
		[Address(RVA = "0x146B680", Offset = "0x146A280", VA = "0x18146B680")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601B33C RID: 111420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B33C")]
		[Address(RVA = "0x146B790", Offset = "0x146A390", VA = "0x18146B790")]
		public Rl03OuterBuffSummaryView()
		{
		}

		// Token: 0x040230F5 RID: 143605
		[Token(Token = "0x40230F5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _activeCount;

		// Token: 0x040230F6 RID: 143606
		[Token(Token = "0x40230F6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x040230F7 RID: 143607
		[Token(Token = "0x40230F7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Rl03OuterBuffSummaryMergeView _mergeView;

		// Token: 0x040230F8 RID: 143608
		[Token(Token = "0x40230F8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Rl03OuterBuffSummaryRawTextView _rawTextView;

		// Token: 0x040230F9 RID: 143609
		[Token(Token = "0x40230F9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Rl03OuterBuffSummaryDifficultyView _difficultyView;

		// Token: 0x040230FA RID: 143610
		[Token(Token = "0x40230FA")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _backBtnRect;

		// Token: 0x040230FB RID: 143611
		[Token(Token = "0x40230FB")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		public Action onBackClick;

		// Token: 0x040230FC RID: 143612
		[Token(Token = "0x40230FC")]
		[NonSerialized]
		public const float INACTIVE_SUMMARY_ALPHA = 0.2f;

		// Token: 0x040230FD RID: 143613
		[Token(Token = "0x40230FD")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isInited;

		// Token: 0x040230FE RID: 143614
		[Token(Token = "0x40230FE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x040230FF RID: 143615
		[Token(Token = "0x40230FF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04023100 RID: 143616
		[Token(Token = "0x4023100")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnBackClick;

		// Token: 0x04023101 RID: 143617
		[Token(Token = "0x4023101")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04023102 RID: 143618
		[Token(Token = "0x4023102")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
