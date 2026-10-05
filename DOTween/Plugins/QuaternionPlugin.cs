using System;
using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;
using UnityEngine;

namespace DG.Tweening.Plugins
{
	// Token: 0x0200007D RID: 125
	[Token(Token = "0x200007D")]
	public class QuaternionPlugin : ABSTweenPlugin<Quaternion, Vector3, QuaternionOptions>
	{
		// Token: 0x06000310 RID: 784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000310")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "4")]
		public override void Reset(TweenerCore<Quaternion, Vector3, QuaternionOptions> t)
		{
		}

		// Token: 0x06000311 RID: 785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000311")]
		[Address(RVA = "0x3751910", Offset = "0x3750510", VA = "0x183751910", Slot = "5")]
		public override void SetFrom(TweenerCore<Quaternion, Vector3, QuaternionOptions> t, bool isRelative)
		{
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000312")]
		[Address(RVA = "0x37521C0", Offset = "0x3750DC0", VA = "0x1837521C0", Slot = "6")]
		public override void SetFrom(TweenerCore<Quaternion, Vector3, QuaternionOptions> t, Vector3 fromValue, bool setImmediately, bool isRelative)
		{
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00003570 File Offset: 0x00001770
		[Token(Token = "0x6000313")]
		[Address(RVA = "0x37507C0", Offset = "0x374F3C0", VA = "0x1837507C0", Slot = "7")]
		public override Vector3 ConvertToStartValue(TweenerCore<Quaternion, Vector3, QuaternionOptions> t, Quaternion value)
		{
			return default(Vector3);
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000314")]
		[Address(RVA = "0x3752440", Offset = "0x3751040", VA = "0x183752440", Slot = "8")]
		public override void SetRelativeEndValue(TweenerCore<Quaternion, Vector3, QuaternionOptions> t)
		{
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000315")]
		[Address(RVA = "0x3751640", Offset = "0x3750240", VA = "0x183751640", Slot = "9")]
		public override void SetChangeValue(TweenerCore<Quaternion, Vector3, QuaternionOptions> t)
		{
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00003588 File Offset: 0x00001788
		[Token(Token = "0x6000316")]
		[Address(RVA = "0x3751610", Offset = "0x3750210", VA = "0x183751610", Slot = "10")]
		public override float GetSpeedBasedDuration(QuaternionOptions options, float unitsXSecond, Vector3 changeValue)
		{
			return 0f;
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000317")]
		[Address(RVA = "0x3750860", Offset = "0x374F460", VA = "0x183750860", Slot = "11")]
		public override void EvaluateAndApply(QuaternionOptions options, Tween t, bool isRelative, DOGetter<Quaternion> getter, DOSetter<Quaternion> setter, float elapsed, Vector3 startValue, Vector3 changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice)
		{
		}

		// Token: 0x06000318 RID: 792 RVA: 0x000035A0 File Offset: 0x000017A0
		[Token(Token = "0x6000318")]
		[Address(RVA = "0x3751380", Offset = "0x374FF80", VA = "0x183751380")]
		private Vector3 GetEulerValForCalculations(TweenerCore<Quaternion, Vector3, QuaternionOptions> t, Vector3 val, Vector3 counterVal)
		{
			return default(Vector3);
		}

		// Token: 0x06000319 RID: 793 RVA: 0x000035B8 File Offset: 0x000017B8
		[Token(Token = "0x6000319")]
		[Address(RVA = "0x3751340", Offset = "0x374FF40", VA = "0x183751340")]
		private Vector3 FlipEulerAngles(Vector3 euler)
		{
			return default(Vector3);
		}

		// Token: 0x0600031A RID: 794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031A")]
		[Address(RVA = "0x37524C0", Offset = "0x37510C0", VA = "0x1837524C0")]
		public QuaternionPlugin()
		{
		}
	}
}
