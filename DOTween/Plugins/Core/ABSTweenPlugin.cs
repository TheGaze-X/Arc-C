using System;
using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;

namespace DG.Tweening.Plugins.Core
{
	// Token: 0x02000097 RID: 151
	[Token(Token = "0x2000097")]
	public abstract class ABSTweenPlugin<T1, T2, TPlugOptions> : ITweenPlugin where TPlugOptions : struct, IPlugOptions
	{
		// Token: 0x0600037D RID: 893
		[Token(Token = "0x600037D")]
		public abstract void Reset(TweenerCore<T1, T2, TPlugOptions> t);

		// Token: 0x0600037E RID: 894
		[Token(Token = "0x600037E")]
		public abstract void SetFrom(TweenerCore<T1, T2, TPlugOptions> t, bool isRelative);

		// Token: 0x0600037F RID: 895
		[Token(Token = "0x600037F")]
		public abstract void SetFrom(TweenerCore<T1, T2, TPlugOptions> t, T2 fromValue, bool setImmediately, bool isRelative);

		// Token: 0x06000380 RID: 896
		[Token(Token = "0x6000380")]
		public abstract T2 ConvertToStartValue(TweenerCore<T1, T2, TPlugOptions> t, T1 value);

		// Token: 0x06000381 RID: 897
		[Token(Token = "0x6000381")]
		public abstract void SetRelativeEndValue(TweenerCore<T1, T2, TPlugOptions> t);

		// Token: 0x06000382 RID: 898
		[Token(Token = "0x6000382")]
		public abstract void SetChangeValue(TweenerCore<T1, T2, TPlugOptions> t);

		// Token: 0x06000383 RID: 899
		[Token(Token = "0x6000383")]
		public abstract float GetSpeedBasedDuration(TPlugOptions options, float unitsXSecond, T2 changeValue);

		// Token: 0x06000384 RID: 900
		[Token(Token = "0x6000384")]
		public abstract void EvaluateAndApply(TPlugOptions options, Tween t, bool isRelative, DOGetter<T1> getter, DOSetter<T1> setter, float elapsed, T2 startValue, T2 changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice);

		// Token: 0x06000385 RID: 901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000385")]
		protected ABSTweenPlugin()
		{
		}
	}
}
