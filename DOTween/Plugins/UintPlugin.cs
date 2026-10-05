using System;
using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;

namespace DG.Tweening.Plugins
{
	// Token: 0x02000080 RID: 128
	[Token(Token = "0x2000080")]
	public class UintPlugin : ABSTweenPlugin<uint, uint, UintOptions>
	{
		// Token: 0x0600032E RID: 814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600032E")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "4")]
		public override void Reset(TweenerCore<uint, uint, UintOptions> t)
		{
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600032F")]
		[Address(RVA = "0x374AB00", Offset = "0x3749700", VA = "0x18374AB00", Slot = "5")]
		public override void SetFrom(TweenerCore<uint, uint, UintOptions> t, bool isRelative)
		{
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000330")]
		[Address(RVA = "0x374AA70", Offset = "0x3749670", VA = "0x18374AA70", Slot = "6")]
		public override void SetFrom(TweenerCore<uint, uint, UintOptions> t, uint fromValue, bool setImmediately, bool isRelative)
		{
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00003618 File Offset: 0x00001818
		[Token(Token = "0x6000331")]
		[Address(RVA = "0x374A890", Offset = "0x3749490", VA = "0x18374A890", Slot = "7")]
		public override uint ConvertToStartValue(TweenerCore<uint, uint, UintOptions> t, uint value)
		{
			return 0U;
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000332")]
		[Address(RVA = "0x374AB80", Offset = "0x3749780", VA = "0x18374AB80", Slot = "8")]
		public override void SetRelativeEndValue(TweenerCore<uint, uint, UintOptions> t)
		{
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000333")]
		[Address(RVA = "0x3756950", Offset = "0x3755550", VA = "0x183756950", Slot = "9")]
		public override void SetChangeValue(TweenerCore<uint, uint, UintOptions> t)
		{
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00003630 File Offset: 0x00001830
		[Token(Token = "0x6000334")]
		[Address(RVA = "0x3756920", Offset = "0x3755520", VA = "0x183756920", Slot = "10")]
		public override float GetSpeedBasedDuration(UintOptions options, float unitsXSecond, uint changeValue)
		{
			return 0f;
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000335")]
		[Address(RVA = "0x3756750", Offset = "0x3755350", VA = "0x183756750", Slot = "11")]
		public override void EvaluateAndApply(UintOptions options, Tween t, bool isRelative, DOGetter<uint> getter, DOSetter<uint> setter, float elapsed, uint startValue, uint changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice)
		{
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000336")]
		[Address(RVA = "0x37569A0", Offset = "0x37555A0", VA = "0x1837569A0")]
		public UintPlugin()
		{
		}
	}
}
