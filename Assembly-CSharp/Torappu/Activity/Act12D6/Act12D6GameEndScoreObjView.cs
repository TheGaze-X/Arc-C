using System;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act12D6
{
	// Token: 0x02007AE5 RID: 31461
	[Token(Token = "0x2007AE5")]
	public class Act12D6GameEndScoreObjView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602C101 RID: 180481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C101")]
		[Address(RVA = "0x27EE360", Offset = "0x27ECF60", VA = "0x1827EE360")]
		public void Render(int count, int score)
		{
		}

		// Token: 0x0602C102 RID: 180482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C102")]
		[Address(RVA = "0x27EE2B0", Offset = "0x27ECEB0", VA = "0x1827EE2B0")]
		public void PlayAnim()
		{
		}

		// Token: 0x0602C103 RID: 180483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C103")]
		[Address(RVA = "0x27EE580", Offset = "0x27ED180", VA = "0x1827EE580")]
		public void ResetAnim()
		{
		}

		// Token: 0x0602C104 RID: 180484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C104")]
		[Address(RVA = "0x27EE610", Offset = "0x27ED210", VA = "0x1827EE610")]
		public void SkipAnim()
		{
		}

		// Token: 0x0602C105 RID: 180485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C105")]
		[Address(RVA = "0x27EE6C0", Offset = "0x27ED2C0", VA = "0x1827EE6C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602C106 RID: 180486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C106")]
		[Address(RVA = "0x27EE9D0", Offset = "0x27ED5D0", VA = "0x1827EE9D0")]
		public Act12D6GameEndScoreObjView()
		{
		}

		// Token: 0x0403FD7A RID: 261498
		[Token(Token = "0x403FD7A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AnimationWrapper _animationWrapper;

		// Token: 0x0403FD7B RID: 261499
		[Token(Token = "0x403FD7B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("Nullable")]
		private Text _textCount;

		// Token: 0x0403FD7C RID: 261500
		[Token(Token = "0x403FD7C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textScore;

		// Token: 0x0403FD7D RID: 261501
		[Token(Token = "0x403FD7D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _scoreTweenDuration;

		// Token: 0x0403FD7E RID: 261502
		[Token(Token = "0x403FD7E")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _scoreTweenDelay;

		// Token: 0x0403FD7F RID: 261503
		[Token(Token = "0x403FD7F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("ColorSettings")]
		private Color _countNormalColor;

		// Token: 0x0403FD80 RID: 261504
		[Token(Token = "0x403FD80")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("ColorSettings")]
		private Color _countZeroColor;

		// Token: 0x0403FD81 RID: 261505
		[Token(Token = "0x403FD81")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("ColorSettings")]
		private Color _scoreNormalColor;

		// Token: 0x0403FD82 RID: 261506
		[Token(Token = "0x403FD82")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("ColorSettings")]
		private Color _scoreZeroColor;

		// Token: 0x0403FD83 RID: 261507
		[Token(Token = "0x403FD83")]
		[FieldOffset(Offset = "0x78")]
		private bool m_inited;

		// Token: 0x0403FD84 RID: 261508
		[Token(Token = "0x403FD84")]
		[FieldOffset(Offset = "0x7C")]
		private int m_cacheCount;

		// Token: 0x0403FD85 RID: 261509
		[Token(Token = "0x403FD85")]
		[FieldOffset(Offset = "0x80")]
		private int m_cacheScore;

		// Token: 0x0403FD86 RID: 261510
		[Token(Token = "0x403FD86")]
		[FieldOffset(Offset = "0x88")]
		private Act12D6GameEndScoreObjView.TextTweener m_scoreTweener;

		// Token: 0x0403FD87 RID: 261511
		[Token(Token = "0x403FD87")]
		[FieldOffset(Offset = "0x90")]
		private string m_animName;

		// Token: 0x0403FD88 RID: 261512
		[Token(Token = "0x403FD88")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403FD89 RID: 261513
		[Token(Token = "0x403FD89")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_PlayAnim;

		// Token: 0x0403FD8A RID: 261514
		[Token(Token = "0x403FD8A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ResetAnim;

		// Token: 0x0403FD8B RID: 261515
		[Token(Token = "0x403FD8B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SkipAnim;

		// Token: 0x0403FD8C RID: 261516
		[Token(Token = "0x403FD8C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403FD8D RID: 261517
		[Token(Token = "0x403FD8D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007AE6 RID: 31462
		[Token(Token = "0x2007AE6")]
		private class TextTweener
		{
			// Token: 0x0602C107 RID: 180487 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C107")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			public TextTweener(Text text)
			{
			}

			// Token: 0x0602C108 RID: 180488 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C108")]
			[Address(RVA = "0x2801EB0", Offset = "0x2800AB0", VA = "0x182801EB0")]
			public void Play(int beginCnt, int endCnt, float duration = 0.5f, float delay = 0f)
			{
			}

			// Token: 0x0602C109 RID: 180489 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C109")]
			[Address(RVA = "0x18EF020", Offset = "0x18EDC20", VA = "0x1818EF020")]
			public void ResetTo(int cnt)
			{
			}

			// Token: 0x0403FD8E RID: 261518
			[Token(Token = "0x403FD8E")]
			private const float TWEEN_DURATION = 0.5f;

			// Token: 0x0403FD8F RID: 261519
			[Token(Token = "0x403FD8F")]
			private const float TWEEN_DELAY = 0f;

			// Token: 0x0403FD90 RID: 261520
			[Token(Token = "0x403FD90")]
			[FieldOffset(Offset = "0x10")]
			private Text m_text;

			// Token: 0x0403FD91 RID: 261521
			[Token(Token = "0x403FD91")]
			[FieldOffset(Offset = "0x18")]
			private Tween m_tweener;

			// Token: 0x0403FD92 RID: 261522
			[Token(Token = "0x403FD92")]
			[FieldOffset(Offset = "0x20")]
			private int m_count;
		}
	}
}
