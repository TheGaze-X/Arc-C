using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x02004516 RID: 17686
	[Token(Token = "0x2004516")]
	public class RoguelikeCommonOuterBuffSummaryView : DataBinder<RoguelikeCommonOuterBuffSummaryProperty>
	{
		// Token: 0x0601AF99 RID: 110489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF99")]
		[Address(RVA = "0x14240A0", Offset = "0x1422CA0", VA = "0x1814240A0")]
		public void Reset()
		{
		}

		// Token: 0x0601AF9A RID: 110490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF9A")]
		[Address(RVA = "0x1423DE0", Offset = "0x14229E0", VA = "0x181423DE0", Slot = "7")]
		public override void OnValueChanged(RoguelikeCommonOuterBuffSummaryProperty property)
		{
		}

		// Token: 0x0601AF9B RID: 110491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF9B")]
		[Address(RVA = "0x1423D70", Offset = "0x1422970", VA = "0x181423D70")]
		public void OnBackClick()
		{
		}

		// Token: 0x0601AF9C RID: 110492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF9C")]
		[Address(RVA = "0x1424190", Offset = "0x1422D90", VA = "0x181424190")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601AF9D RID: 110493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF9D")]
		[Address(RVA = "0x14242A0", Offset = "0x1422EA0", VA = "0x1814242A0")]
		public RoguelikeCommonOuterBuffSummaryView()
		{
		}

		// Token: 0x04022A1A RID: 141850
		[Token(Token = "0x4022A1A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _activeCountText;

		// Token: 0x04022A1B RID: 141851
		[Token(Token = "0x4022A1B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _allCountText;

		// Token: 0x04022A1C RID: 141852
		[Token(Token = "0x4022A1C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x04022A1D RID: 141853
		[Token(Token = "0x4022A1D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RoguelikeCommonOuterBuffSummaryMergeView _mergeView;

		// Token: 0x04022A1E RID: 141854
		[Token(Token = "0x4022A1E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RoguelikeCommonOuterBuffSummaryRawTextView _rawTextView;

		// Token: 0x04022A1F RID: 141855
		[Token(Token = "0x4022A1F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RoguelikeCommonOuterBuffSummaryDifficultyView _difficultyView;

		// Token: 0x04022A20 RID: 141856
		[Token(Token = "0x4022A20")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _backBtnRect;

		// Token: 0x04022A21 RID: 141857
		[Token(Token = "0x4022A21")]
		[FieldOffset(Offset = "0x58")]
		[NonSerialized]
		public Action onBackClick;

		// Token: 0x04022A22 RID: 141858
		[Token(Token = "0x4022A22")]
		[FieldOffset(Offset = "0x60")]
		private bool m_isInited;

		// Token: 0x04022A23 RID: 141859
		[Token(Token = "0x4022A23")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04022A24 RID: 141860
		[Token(Token = "0x4022A24")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04022A25 RID: 141861
		[Token(Token = "0x4022A25")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnBackClick;

		// Token: 0x04022A26 RID: 141862
		[Token(Token = "0x4022A26")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04022A27 RID: 141863
		[Token(Token = "0x4022A27")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
