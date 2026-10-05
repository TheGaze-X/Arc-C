using System;
using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;

namespace DG.Tweening.Plugins
{
	// Token: 0x0200007C RID: 124
	[Token(Token = "0x200007C")]
	public class IntPlugin : ABSTweenPlugin<int, int, NoOptions>
	{
		// Token: 0x06000307 RID: 775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000307")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "4")]
		public override void Reset(TweenerCore<int, int, NoOptions> t)
		{
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000308")]
		[Address(RVA = "0x374AB00", Offset = "0x3749700", VA = "0x18374AB00", Slot = "5")]
		public override void SetFrom(TweenerCore<int, int, NoOptions> t, bool isRelative)
		{
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000309")]
		[Address(RVA = "0x374AA70", Offset = "0x3749670", VA = "0x18374AA70", Slot = "6")]
		public override void SetFrom(TweenerCore<int, int, NoOptions> t, int fromValue, bool setImmediately, bool isRelative)
		{
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00003540 File Offset: 0x00001740
		[Token(Token = "0x600030A")]
		[Address(RVA = "0x374A890", Offset = "0x3749490", VA = "0x18374A890", Slot = "7")]
		public override int ConvertToStartValue(TweenerCore<int, int, NoOptions> t, int value)
		{
			return 0;
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030B")]
		[Address(RVA = "0x374AB80", Offset = "0x3749780", VA = "0x18374AB80", Slot = "8")]
		public override void SetRelativeEndValue(TweenerCore<int, int, NoOptions> t)
		{
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030C")]
		[Address(RVA = "0x374AA40", Offset = "0x3749640", VA = "0x18374AA40", Slot = "9")]
		public override void SetChangeValue(TweenerCore<int, int, NoOptions> t)
		{
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00003558 File Offset: 0x00001758
		[Token(Token = "0x600030D")]
		[Address(RVA = "0x374AA20", Offset = "0x3749620", VA = "0x18374AA20", Slot = "10")]
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, int changeValue)
		{
			return 0f;
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030E")]
		[Address(RVA = "0x374A8A0", Offset = "0x37494A0", VA = "0x18374A8A0", Slot = "11")]
		public override void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<int> getter, DOSetter<int> setter, float elapsed, int startValue, int changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice)
		{
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030F")]
		[Address(RVA = "0x374ABA0", Offset = "0x37497A0", VA = "0x18374ABA0")]
		public IntPlugin()
		{
		}
	}
}
