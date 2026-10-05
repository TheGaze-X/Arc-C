using System;
using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;

namespace DG.Tweening.Plugins
{
	// Token: 0x02000085 RID: 133
	[Token(Token = "0x2000085")]
	public class FloatPlugin : ABSTweenPlugin<float, float, FloatOptions>
	{
		// Token: 0x06000358 RID: 856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000358")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "4")]
		public override void Reset(TweenerCore<float, float, FloatOptions> t)
		{
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000359")]
		[Address(RVA = "0x374A640", Offset = "0x3749240", VA = "0x18374A640", Slot = "5")]
		public override void SetFrom(TweenerCore<float, float, FloatOptions> t, bool isRelative)
		{
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035A")]
		[Address(RVA = "0x374A730", Offset = "0x3749330", VA = "0x18374A730", Slot = "6")]
		public override void SetFrom(TweenerCore<float, float, FloatOptions> t, float fromValue, bool setImmediately, bool isRelative)
		{
		}

		// Token: 0x0600035B RID: 859 RVA: 0x000036C0 File Offset: 0x000018C0
		[Token(Token = "0x600035B")]
		[Address(RVA = "0x374A0E0", Offset = "0x3748CE0", VA = "0x18374A0E0", Slot = "7")]
		public override float ConvertToStartValue(TweenerCore<float, float, FloatOptions> t, float value)
		{
			return 0f;
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035C")]
		[Address(RVA = "0x374A820", Offset = "0x3749420", VA = "0x18374A820", Slot = "8")]
		public override void SetRelativeEndValue(TweenerCore<float, float, FloatOptions> t)
		{
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035D")]
		[Address(RVA = "0x374A610", Offset = "0x3749210", VA = "0x18374A610", Slot = "9")]
		public override void SetChangeValue(TweenerCore<float, float, FloatOptions> t)
		{
		}

		// Token: 0x0600035E RID: 862 RVA: 0x000036D8 File Offset: 0x000018D8
		[Token(Token = "0x600035E")]
		[Address(RVA = "0x374A5F0", Offset = "0x37491F0", VA = "0x18374A5F0", Slot = "10")]
		public override float GetSpeedBasedDuration(FloatOptions options, float unitsXSecond, float changeValue)
		{
			return 0f;
		}

		// Token: 0x0600035F RID: 863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035F")]
		[Address(RVA = "0x374A430", Offset = "0x3749030", VA = "0x18374A430", Slot = "11")]
		public override void EvaluateAndApply(FloatOptions options, Tween t, bool isRelative, DOGetter<float> getter, DOSetter<float> setter, float elapsed, float startValue, float changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice)
		{
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000360")]
		[Address(RVA = "0x374A850", Offset = "0x3749450", VA = "0x18374A850")]
		public FloatPlugin()
		{
		}
	}
}
