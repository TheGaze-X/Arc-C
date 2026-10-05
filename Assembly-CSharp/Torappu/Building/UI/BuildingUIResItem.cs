using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Building.UI
{
	// Token: 0x02001B29 RID: 6953
	[Token(Token = "0x2001B29")]
	public class BuildingUIResItem : MonoBehaviour
	{
		// Token: 0x170014BE RID: 5310
		// (get) Token: 0x0600AF15 RID: 44821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014BE")]
		protected CanvasGroup alphaHandler
		{
			[Token(Token = "0x600AF15")]
			[Address(RVA = "0x32978F0", Offset = "0x32964F0", VA = "0x1832978F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170014BF RID: 5311
		// (get) Token: 0x0600AF16 RID: 44822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014BF")]
		public RectTransform rippleIconTrans
		{
			[Token(Token = "0x600AF16")]
			[Address(RVA = "0x3297A20", Offset = "0x3296620", VA = "0x183297A20")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600AF17 RID: 44823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF17")]
		[Address(RVA = "0x3297390", Offset = "0x3295F90", VA = "0x183297390")]
		private void Start()
		{
		}

		// Token: 0x0600AF18 RID: 44824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF18")]
		[Address(RVA = "0x3296F10", Offset = "0x3295B10", VA = "0x183296F10")]
		public void Render(long count, long maxCount = 0L)
		{
		}

		// Token: 0x0600AF19 RID: 44825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF19")]
		[Address(RVA = "0x32970A0", Offset = "0x3295CA0", VA = "0x1832970A0")]
		public void StartRippleEffect()
		{
		}

		// Token: 0x0600AF1A RID: 44826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF1A")]
		[Address(RVA = "0x32965A0", Offset = "0x32951A0", VA = "0x1832965A0")]
		public void RenderWithEffect(BuildingUIResItem.EffectOptions options)
		{
		}

		// Token: 0x0600AF1B RID: 44827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF1B")]
		[Address(RVA = "0x32977C0", Offset = "0x32963C0", VA = "0x1832977C0")]
		private void _TweenRippleSetter(float val)
		{
		}

		// Token: 0x0600AF1C RID: 44828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF1C")]
		[Address(RVA = "0x3297700", Offset = "0x3296300", VA = "0x183297700")]
		private void _TweenCountSetter(float val)
		{
		}

		// Token: 0x0600AF1D RID: 44829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF1D")]
		[Address(RVA = "0x32975A0", Offset = "0x32961A0", VA = "0x1832975A0")]
		private void _KillPreviousTweens()
		{
		}

		// Token: 0x0600AF1E RID: 44830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF1E")]
		[Address(RVA = "0x3297670", Offset = "0x3296270", VA = "0x183297670")]
		private void _ShowIconUp()
		{
		}

		// Token: 0x0600AF1F RID: 44831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF1F")]
		[Address(RVA = "0x3297510", Offset = "0x3296110", VA = "0x183297510")]
		private void _HideIconUp()
		{
		}

		// Token: 0x0600AF20 RID: 44832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF20")]
		[Address(RVA = "0x3297860", Offset = "0x3296460", VA = "0x183297860")]
		public BuildingUIResItem()
		{
		}

		// Token: 0x0400A868 RID: 43112
		[Token(Token = "0x400A868")]
		private const float ANIM_TEXT_DELAY = 0.8f;

		// Token: 0x0400A869 RID: 43113
		[Token(Token = "0x400A869")]
		private const float ANIM_TEXT_DURATION = 0.6f;

		// Token: 0x0400A86A RID: 43114
		[Token(Token = "0x400A86A")]
		private const float ANIM_RIPPLE_DURATION = 0.3f;

		// Token: 0x0400A86B RID: 43115
		[Token(Token = "0x400A86B")]
		private const float ANIM_FADE_DURATION = 0.23f;

		// Token: 0x0400A86C RID: 43116
		[Token(Token = "0x400A86C")]
		private const float AUTO_SHOW_TIME = 2.8f;

		// Token: 0x0400A86D RID: 43117
		[Token(Token = "0x400A86D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textCount;

		// Token: 0x0400A86E RID: 43118
		[Token(Token = "0x400A86E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("Nullable")]
		private Text _textLimit;

		// Token: 0x0400A86F RID: 43119
		[Token(Token = "0x400A86F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _icon;

		// Token: 0x0400A870 RID: 43120
		[Token(Token = "0x400A870")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _iconRipple;

		// Token: 0x0400A871 RID: 43121
		[Token(Token = "0x400A871")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Tooltip("Items with true would auto hide when they are not needed")]
		private bool _autoHide;

		// Token: 0x0400A872 RID: 43122
		[Token(Token = "0x400A872")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Tooltip("Nullable")]
		private RectTransform _autoLayout;

		// Token: 0x0400A873 RID: 43123
		[Token(Token = "0x400A873")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Tooltip("Nullable")]
		private GameObject _iconUp;

		// Token: 0x0400A874 RID: 43124
		[Token(Token = "0x400A874")]
		[FieldOffset(Offset = "0x50")]
		private BuildingUIResItem.EffectOptions m_effectOptionsCache;

		// Token: 0x0400A875 RID: 43125
		[Token(Token = "0x400A875")]
		[FieldOffset(Offset = "0x68")]
		private List<Tween> m_activeTweens;

		// Token: 0x0400A876 RID: 43126
		[Token(Token = "0x400A876")]
		[FieldOffset(Offset = "0x70")]
		private Tween m_iconRippleTween;

		// Token: 0x0400A877 RID: 43127
		[Token(Token = "0x400A877")]
		[FieldOffset(Offset = "0x78")]
		private CanvasGroup m_alphaHandler;

		// Token: 0x0400A878 RID: 43128
		[Token(Token = "0x400A878")]
		[FieldOffset(Offset = "0x80")]
		private RectTransform m_rippleTransCache;

		// Token: 0x02001B2A RID: 6954
		[Token(Token = "0x2001B2A")]
		public struct EffectOptions
		{
			// Token: 0x0400A879 RID: 43129
			[Token(Token = "0x400A879")]
			[FieldOffset(Offset = "0x0")]
			public bool disableTextDelay;

			// Token: 0x0400A87A RID: 43130
			[Token(Token = "0x400A87A")]
			[FieldOffset(Offset = "0x8")]
			public long startCount;

			// Token: 0x0400A87B RID: 43131
			[Token(Token = "0x400A87B")]
			[FieldOffset(Offset = "0x10")]
			public long targetCount;
		}
	}
}
