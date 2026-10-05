using System;
using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;
using UnityEngine;

namespace DG.Tweening.Plugins
{
	// Token: 0x0200007F RID: 127
	[Token(Token = "0x200007F")]
	public class RectPlugin : ABSTweenPlugin<Rect, Rect, RectOptions>
	{
		// Token: 0x06000325 RID: 805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000325")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "4")]
		public override void Reset(TweenerCore<Rect, Rect, RectOptions> t)
		{
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000326")]
		[Address(RVA = "0x3753BB0", Offset = "0x37527B0", VA = "0x183753BB0", Slot = "5")]
		public override void SetFrom(TweenerCore<Rect, Rect, RectOptions> t, bool isRelative)
		{
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000327")]
		[Address(RVA = "0x3753E00", Offset = "0x3752A00", VA = "0x183753E00", Slot = "6")]
		public override void SetFrom(TweenerCore<Rect, Rect, RectOptions> t, Rect fromValue, bool setImmediately, bool isRelative)
		{
		}

		// Token: 0x06000328 RID: 808 RVA: 0x000035E8 File Offset: 0x000017E8
		[Token(Token = "0x6000328")]
		[Address(RVA = "0x3745E40", Offset = "0x3744A40", VA = "0x183745E40", Slot = "7")]
		public override Rect ConvertToStartValue(TweenerCore<Rect, Rect, RectOptions> t, Rect value)
		{
			return default(Rect);
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000329")]
		[Address(RVA = "0x3754120", Offset = "0x3752D20", VA = "0x183754120", Slot = "8")]
		public override void SetRelativeEndValue(TweenerCore<Rect, Rect, RectOptions> t)
		{
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600032A")]
		[Address(RVA = "0x3753A40", Offset = "0x3752640", VA = "0x183753A40", Slot = "9")]
		public override void SetChangeValue(TweenerCore<Rect, Rect, RectOptions> t)
		{
		}

		// Token: 0x0600032B RID: 811 RVA: 0x00003600 File Offset: 0x00001800
		[Token(Token = "0x600032B")]
		[Address(RVA = "0x3753980", Offset = "0x3752580", VA = "0x183753980", Slot = "10")]
		public override float GetSpeedBasedDuration(RectOptions options, float unitsXSecond, Rect changeValue)
		{
			return 0f;
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600032C")]
		[Address(RVA = "0x3753510", Offset = "0x3752110", VA = "0x183753510", Slot = "11")]
		public override void EvaluateAndApply(RectOptions options, Tween t, bool isRelative, DOGetter<Rect> getter, DOSetter<Rect> setter, float elapsed, Rect startValue, Rect changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice)
		{
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600032D")]
		[Address(RVA = "0x3754210", Offset = "0x3752E10", VA = "0x183754210")]
		public RectPlugin()
		{
		}
	}
}
