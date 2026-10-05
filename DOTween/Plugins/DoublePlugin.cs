using System;
using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;

namespace DG.Tweening.Plugins
{
	// Token: 0x02000076 RID: 118
	[Token(Token = "0x2000076")]
	public class DoublePlugin : ABSTweenPlugin<double, double, NoOptions>
	{
		// Token: 0x060002CD RID: 717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "4")]
		public override void Reset(TweenerCore<double, double, NoOptions> t)
		{
		}

		// Token: 0x060002CE RID: 718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x374A290", Offset = "0x3748E90", VA = "0x18374A290", Slot = "5")]
		public override void SetFrom(TweenerCore<double, double, NoOptions> t, bool isRelative)
		{
		}

		// Token: 0x060002CF RID: 719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x374A320", Offset = "0x3748F20", VA = "0x18374A320", Slot = "6")]
		public override void SetFrom(TweenerCore<double, double, NoOptions> t, double fromValue, bool setImmediately, bool isRelative)
		{
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00003420 File Offset: 0x00001620
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x374A0E0", Offset = "0x3748CE0", VA = "0x18374A0E0", Slot = "7")]
		public override double ConvertToStartValue(TweenerCore<double, double, NoOptions> t, double value)
		{
			return 0.0;
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x374A3C0", Offset = "0x3748FC0", VA = "0x18374A3C0", Slot = "8")]
		public override void SetRelativeEndValue(TweenerCore<double, double, NoOptions> t)
		{
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x374A260", Offset = "0x3748E60", VA = "0x18374A260", Slot = "9")]
		public override void SetChangeValue(TweenerCore<double, double, NoOptions> t)
		{
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00003438 File Offset: 0x00001638
		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x374A240", Offset = "0x3748E40", VA = "0x18374A240", Slot = "10")]
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, double changeValue)
		{
			return 0f;
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x374A0F0", Offset = "0x3748CF0", VA = "0x18374A0F0", Slot = "11")]
		public override void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<double> getter, DOSetter<double> setter, float elapsed, double startValue, double changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice)
		{
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x374A3F0", Offset = "0x3748FF0", VA = "0x18374A3F0")]
		public DoublePlugin()
		{
		}
	}
}
