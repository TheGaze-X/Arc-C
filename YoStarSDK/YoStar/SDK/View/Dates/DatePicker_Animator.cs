using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YoStar.SDK.View.Dates
{
	// Token: 0x0200010F RID: 271
	[Token(Token = "0x200010F")]
	[RequireComponent(typeof(RectTransform))]
	[RequireComponent(typeof(CanvasGroup))]
	public class DatePicker_Animator : MonoBehaviour
	{
		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600074B RID: 1867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000082")]
		protected CanvasGroup canvasGroup
		{
			[Token(Token = "0x600074B")]
			[Address(RVA = "0x5C48100", Offset = "0x5C46D00", VA = "0x185C48100")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600074C RID: 1868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000083")]
		protected RectTransform rectTransform
		{
			[Token(Token = "0x600074C")]
			[Address(RVA = "0x5C481A0", Offset = "0x5C46DA0", VA = "0x185C481A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600074D")]
		[Address(RVA = "0x5C47890", Offset = "0x5C46490", VA = "0x185C47890")]
		public void PlayAnimation(Animation animation, AnimationType animationType, [Optional] Action onComplete)
		{
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600074E")]
		[Address(RVA = "0x5C475B0", Offset = "0x5C461B0", VA = "0x185C475B0")]
		public void Animate(DatePicker_Animator.DatePicker_Animation_Property property, float desiredValue, float duration, [Optional] Action onComplete)
		{
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600074F")]
		[Address(RVA = "0x5C47C00", Offset = "0x5C46800", VA = "0x185C47C00")]
		private void Update()
		{
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x000033BC File Offset: 0x000015BC
		[Token(Token = "0x6000750")]
		[Address(RVA = "0x5C47800", Offset = "0x5C46400", VA = "0x185C47800")]
		private float GetPropertyValue(DatePicker_Animator.DatePicker_Animation_Property property)
		{
			return 0f;
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000751")]
		[Address(RVA = "0x5C47A40", Offset = "0x5C46640", VA = "0x185C47A40")]
		private void SetPropertyValue(DatePicker_Animator.DatePicker_Animation_Property property, float newValue)
		{
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000752")]
		[Address(RVA = "0x5C48070", Offset = "0x5C46C70", VA = "0x185C48070")]
		public DatePicker_Animator()
		{
		}

		// Token: 0x0400040B RID: 1035
		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected List<DatePicker_Animator.DatePicker_Animation> animations;

		// Token: 0x0400040C RID: 1036
		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CanvasGroup m_canvasGroup;

		// Token: 0x0400040D RID: 1037
		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RectTransform m_rectTransform;

		// Token: 0x0400040E RID: 1038
		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool ResetWhenAnimationComplete;

		// Token: 0x0400040F RID: 1039
		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float AnimationDuration;

		// Token: 0x04000410 RID: 1040
		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private AnimationType animationType;

		// Token: 0x02000110 RID: 272
		[Token(Token = "0x2000110")]
		protected class DatePicker_Animation
		{
			// Token: 0x17000084 RID: 132
			// (get) Token: 0x06000753 RID: 1875 RVA: 0x000033D4 File Offset: 0x000015D4
			[Token(Token = "0x17000084")]
			public float currentValue
			{
				[Token(Token = "0x6000753")]
				[Address(RVA = "0x5C47560", Offset = "0x5C46160", VA = "0x185C47560")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06000754 RID: 1876 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x6000754")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DatePicker_Animation()
			{
			}

			// Token: 0x04000411 RID: 1041
			[Token(Token = "0x4000411")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DatePicker_Animator.DatePicker_Animation_Property property;

			// Token: 0x04000412 RID: 1042
			[Token(Token = "0x4000412")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float initialValue;

			// Token: 0x04000413 RID: 1043
			[Token(Token = "0x4000413")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float desiredValue;

			// Token: 0x04000414 RID: 1044
			[Token(Token = "0x4000414")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float startTime;

			// Token: 0x04000415 RID: 1045
			[Token(Token = "0x4000415")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float percentageComplete;

			// Token: 0x04000416 RID: 1046
			[Token(Token = "0x4000416")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float duration;

			// Token: 0x04000417 RID: 1047
			[Token(Token = "0x4000417")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action onComplete;
		}

		// Token: 0x02000111 RID: 273
		[Token(Token = "0x2000111")]
		public enum DatePicker_Animation_Property
		{
			// Token: 0x04000419 RID: 1049
			[Token(Token = "0x4000419")]
			Alpha,
			// Token: 0x0400041A RID: 1050
			[Token(Token = "0x400041A")]
			ScaleX,
			// Token: 0x0400041B RID: 1051
			[Token(Token = "0x400041B")]
			ScaleY
		}
	}
}
