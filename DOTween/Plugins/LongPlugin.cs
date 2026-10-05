using System;
using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;

namespace DG.Tweening.Plugins
{
	// Token: 0x02000077 RID: 119
	[Token(Token = "0x2000077")]
	public class LongPlugin : ABSTweenPlugin<long, long, NoOptions>
	{
		// Token: 0x060002D6 RID: 726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "4")]
		public override void Reset(TweenerCore<long, long, NoOptions> t)
		{
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x374B2F0", Offset = "0x3749EF0", VA = "0x18374B2F0", Slot = "5")]
		public override void SetFrom(TweenerCore<long, long, NoOptions> t, bool isRelative)
		{
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x374B380", Offset = "0x3749F80", VA = "0x18374B380", Slot = "6")]
		public override void SetFrom(TweenerCore<long, long, NoOptions> t, long fromValue, bool setImmediately, bool isRelative)
		{
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00003450 File Offset: 0x00001650
		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x2832290", Offset = "0x2830E90", VA = "0x182832290", Slot = "7")]
		public override long ConvertToStartValue(TweenerCore<long, long, NoOptions> t, long value)
		{
			return 0L;
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x374B410", Offset = "0x374A010", VA = "0x18374B410", Slot = "8")]
		public override void SetRelativeEndValue(TweenerCore<long, long, NoOptions> t)
		{
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x374B2C0", Offset = "0x3749EC0", VA = "0x18374B2C0", Slot = "9")]
		public override void SetChangeValue(TweenerCore<long, long, NoOptions> t)
		{
		}

		// Token: 0x060002DC RID: 732 RVA: 0x00003468 File Offset: 0x00001668
		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x374B2A0", Offset = "0x3749EA0", VA = "0x18374B2A0", Slot = "10")]
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, long changeValue)
		{
			return 0f;
		}

		// Token: 0x060002DD RID: 733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x374B110", Offset = "0x3749D10", VA = "0x18374B110", Slot = "11")]
		public override void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<long> getter, DOSetter<long> setter, float elapsed, long startValue, long changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice)
		{
		}

		// Token: 0x060002DE RID: 734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x374B440", Offset = "0x374A040", VA = "0x18374B440")]
		public LongPlugin()
		{
		}
	}
}
