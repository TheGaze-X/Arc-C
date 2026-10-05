using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004355 RID: 17237
	[Token(Token = "0x2004355")]
	public class SandboxV2RacerInventoryTalentView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601A760 RID: 108384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A760")]
		[Address(RVA = "0x1393A60", Offset = "0x1392660", VA = "0x181393A60")]
		public void Render(SandboxV2RacerTalentModel model, bool showRefreshBtn, int animSequenceNum)
		{
		}

		// Token: 0x0601A761 RID: 108385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A761")]
		[Address(RVA = "0x13939D0", Offset = "0x13925D0", VA = "0x1813939D0")]
		public void EventOnRefreshTalentClicked()
		{
		}

		// Token: 0x0601A762 RID: 108386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A762")]
		[Address(RVA = "0x1393DA0", Offset = "0x13929A0", VA = "0x181393DA0")]
		public SandboxV2RacerInventoryTalentView()
		{
		}

		// Token: 0x04021A81 RID: 137857
		[Token(Token = "0x4021A81")]
		private const float ALPHA_EMPTY = 0.6f;

		// Token: 0x04021A82 RID: 137858
		[Token(Token = "0x4021A82")]
		private const float ALPHA_NORMAL = 1f;

		// Token: 0x04021A83 RID: 137859
		[Token(Token = "0x4021A83")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x04021A84 RID: 137860
		[Token(Token = "0x4021A84")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgIcon;

		// Token: 0x04021A85 RID: 137861
		[Token(Token = "0x4021A85")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x04021A86 RID: 137862
		[Token(Token = "0x4021A86")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textTitle;

		// Token: 0x04021A87 RID: 137863
		[Token(Token = "0x4021A87")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelRefreshBtn;

		// Token: 0x04021A88 RID: 137864
		[Token(Token = "0x4021A88")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAnimationLocation _learnedAnim;

		// Token: 0x04021A89 RID: 137865
		[Token(Token = "0x4021A89")]
		[FieldOffset(Offset = "0x50")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04021A8A RID: 137866
		[Token(Token = "0x4021A8A")]
		[FieldOffset(Offset = "0x60")]
		private int m_cachedLearnTalentSequence;

		// Token: 0x04021A8B RID: 137867
		[Token(Token = "0x4021A8B")]
		[FieldOffset(Offset = "0x68")]
		private Tween m_cachedLearnTween;

		// Token: 0x04021A8C RID: 137868
		[Token(Token = "0x4021A8C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04021A8D RID: 137869
		[Token(Token = "0x4021A8D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnRefreshTalentClicked;

		// Token: 0x04021A8E RID: 137870
		[Token(Token = "0x4021A8E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
