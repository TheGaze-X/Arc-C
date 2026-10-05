using System;
using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;
using UnityEngine;

namespace DG.Tweening.Plugins
{
	// Token: 0x0200007E RID: 126
	[Token(Token = "0x200007E")]
	public class RectOffsetPlugin : ABSTweenPlugin<RectOffset, RectOffset, NoOptions>
	{
		// Token: 0x0600031B RID: 795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031B")]
		[Address(RVA = "0x3752D50", Offset = "0x3751950", VA = "0x183752D50", Slot = "4")]
		public override void Reset(TweenerCore<RectOffset, RectOffset, NoOptions> t)
		{
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031C")]
		[Address(RVA = "0x3752F60", Offset = "0x3751B60", VA = "0x183752F60", Slot = "5")]
		public override void SetFrom(TweenerCore<RectOffset, RectOffset, NoOptions> t, bool isRelative)
		{
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031D")]
		[Address(RVA = "0x3753100", Offset = "0x3751D00", VA = "0x183753100", Slot = "6")]
		public override void SetFrom(TweenerCore<RectOffset, RectOffset, NoOptions> t, RectOffset fromValue, bool setImmediately, bool isRelative)
		{
		}

		// Token: 0x0600031E RID: 798 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600031E")]
		[Address(RVA = "0x3752500", Offset = "0x3751100", VA = "0x183752500", Slot = "7")]
		public override RectOffset ConvertToStartValue(TweenerCore<RectOffset, RectOffset, NoOptions> t, RectOffset value)
		{
			return null;
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031F")]
		[Address(RVA = "0x3753320", Offset = "0x3751F20", VA = "0x183753320", Slot = "8")]
		public override void SetRelativeEndValue(TweenerCore<RectOffset, RectOffset, NoOptions> t)
		{
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000320")]
		[Address(RVA = "0x3752DB0", Offset = "0x37519B0", VA = "0x183752DB0", Slot = "9")]
		public override void SetChangeValue(TweenerCore<RectOffset, RectOffset, NoOptions> t)
		{
		}

		// Token: 0x06000321 RID: 801 RVA: 0x000035D0 File Offset: 0x000017D0
		[Token(Token = "0x6000321")]
		[Address(RVA = "0x3752C50", Offset = "0x3751850", VA = "0x183752C50", Slot = "10")]
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, RectOffset changeValue)
		{
			return 0f;
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000322")]
		[Address(RVA = "0x37525D0", Offset = "0x37511D0", VA = "0x1837525D0", Slot = "11")]
		public override void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<RectOffset> getter, DOSetter<RectOffset> setter, float elapsed, RectOffset startValue, RectOffset changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice)
		{
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000323")]
		[Address(RVA = "0x37534D0", Offset = "0x37520D0", VA = "0x1837534D0")]
		public RectOffsetPlugin()
		{
		}

		// Token: 0x04000161 RID: 353
		[Token(Token = "0x4000161")]
		[FieldOffset(Offset = "0x0")]
		private static RectOffset _r;
	}
}
