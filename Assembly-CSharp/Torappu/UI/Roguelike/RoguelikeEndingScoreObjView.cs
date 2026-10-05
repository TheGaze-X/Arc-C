using System;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020052A1 RID: 21153
	[Token(Token = "0x20052A1")]
	public class RoguelikeEndingScoreObjView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601F361 RID: 127841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F361")]
		[Address(RVA = "0x18EAA70", Offset = "0x18E9670", VA = "0x1818EAA70")]
		public void Render(int count, int score)
		{
		}

		// Token: 0x0601F362 RID: 127842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F362")]
		[Address(RVA = "0x18EA9C0", Offset = "0x18E95C0", VA = "0x1818EA9C0")]
		public void PlayAnim()
		{
		}

		// Token: 0x0601F363 RID: 127843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F363")]
		[Address(RVA = "0x18EAC90", Offset = "0x18E9890", VA = "0x1818EAC90")]
		public void ResetAnim()
		{
		}

		// Token: 0x0601F364 RID: 127844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F364")]
		[Address(RVA = "0x18EAD30", Offset = "0x18E9930", VA = "0x1818EAD30")]
		public void SkipAnim()
		{
		}

		// Token: 0x0601F365 RID: 127845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F365")]
		[Address(RVA = "0x18EADE0", Offset = "0x18E99E0", VA = "0x1818EADE0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601F366 RID: 127846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F366")]
		[Address(RVA = "0x18EB0C0", Offset = "0x18E9CC0", VA = "0x1818EB0C0")]
		public RoguelikeEndingScoreObjView()
		{
		}

		// Token: 0x04029E68 RID: 171624
		[Token(Token = "0x4029E68")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AnimationWrapper _animationWrapper;

		// Token: 0x04029E69 RID: 171625
		[Token(Token = "0x4029E69")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("Nullable")]
		private Text _textCount;

		// Token: 0x04029E6A RID: 171626
		[Token(Token = "0x4029E6A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textScore;

		// Token: 0x04029E6B RID: 171627
		[Token(Token = "0x4029E6B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _scoreTweenDuration;

		// Token: 0x04029E6C RID: 171628
		[Token(Token = "0x4029E6C")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _scoreTweenDelay;

		// Token: 0x04029E6D RID: 171629
		[Token(Token = "0x4029E6D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("ColorSettings")]
		private Color _countNormalColor;

		// Token: 0x04029E6E RID: 171630
		[Token(Token = "0x4029E6E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("ColorSettings")]
		private Color _countZeroColor;

		// Token: 0x04029E6F RID: 171631
		[Token(Token = "0x4029E6F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("ColorSettings")]
		private Color _scoreNormalColor;

		// Token: 0x04029E70 RID: 171632
		[Token(Token = "0x4029E70")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("ColorSettings")]
		private Color _scoreZeroColor;

		// Token: 0x04029E71 RID: 171633
		[Token(Token = "0x4029E71")]
		[FieldOffset(Offset = "0x78")]
		private bool m_inited;

		// Token: 0x04029E72 RID: 171634
		[Token(Token = "0x4029E72")]
		[FieldOffset(Offset = "0x7C")]
		private int m_cacheCount;

		// Token: 0x04029E73 RID: 171635
		[Token(Token = "0x4029E73")]
		[FieldOffset(Offset = "0x80")]
		private int m_cacheScore;

		// Token: 0x04029E74 RID: 171636
		[Token(Token = "0x4029E74")]
		[FieldOffset(Offset = "0x88")]
		private RoguelikeEndingScoreObjView.TextTweener m_scoreTweener;

		// Token: 0x04029E75 RID: 171637
		[Token(Token = "0x4029E75")]
		[FieldOffset(Offset = "0x90")]
		private string m_animName;

		// Token: 0x04029E76 RID: 171638
		[Token(Token = "0x4029E76")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04029E77 RID: 171639
		[Token(Token = "0x4029E77")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_PlayAnim;

		// Token: 0x04029E78 RID: 171640
		[Token(Token = "0x4029E78")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ResetAnim;

		// Token: 0x04029E79 RID: 171641
		[Token(Token = "0x4029E79")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SkipAnim;

		// Token: 0x04029E7A RID: 171642
		[Token(Token = "0x4029E7A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04029E7B RID: 171643
		[Token(Token = "0x4029E7B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020052A2 RID: 21154
		[Token(Token = "0x20052A2")]
		private class TextTweener
		{
			// Token: 0x0601F367 RID: 127847 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F367")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			public TextTweener(Text text)
			{
			}

			// Token: 0x0601F368 RID: 127848 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F368")]
			[Address(RVA = "0x18EEE20", Offset = "0x18EDA20", VA = "0x1818EEE20")]
			public void Play(int beginCnt, int endCnt, float duration = 0.5f, float delay = 0f)
			{
			}

			// Token: 0x0601F369 RID: 127849 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F369")]
			[Address(RVA = "0x18EF020", Offset = "0x18EDC20", VA = "0x1818EF020")]
			public void ResetTo(int cnt)
			{
			}

			// Token: 0x04029E7C RID: 171644
			[Token(Token = "0x4029E7C")]
			private const float TWEEN_DURATION = 0.5f;

			// Token: 0x04029E7D RID: 171645
			[Token(Token = "0x4029E7D")]
			private const float TWEEN_DELAY = 0f;

			// Token: 0x04029E7E RID: 171646
			[Token(Token = "0x4029E7E")]
			[FieldOffset(Offset = "0x10")]
			private Text m_text;

			// Token: 0x04029E7F RID: 171647
			[Token(Token = "0x4029E7F")]
			[FieldOffset(Offset = "0x18")]
			private Tween m_tweener;

			// Token: 0x04029E80 RID: 171648
			[Token(Token = "0x4029E80")]
			[FieldOffset(Offset = "0x20")]
			private int m_count;
		}
	}
}
