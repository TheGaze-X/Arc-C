using System;
using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using Il2CppDummyDll;
using UnityEngine;

namespace DG.Tweening.Plugins
{
	// Token: 0x02000074 RID: 116
	[Token(Token = "0x2000074")]
	public class CirclePlugin : ABSTweenPlugin<Vector2, Vector2, CircleOptions>
	{
		// Token: 0x060002B9 RID: 697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "4")]
		public override void Reset(TweenerCore<Vector2, Vector2, CircleOptions> t)
		{
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x371F510", Offset = "0x371E110", VA = "0x18371F510", Slot = "5")]
		public override void SetFrom(TweenerCore<Vector2, Vector2, CircleOptions> t, bool isRelative)
		{
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x371F3A0", Offset = "0x371DFA0", VA = "0x18371F3A0", Slot = "6")]
		public override void SetFrom(TweenerCore<Vector2, Vector2, CircleOptions> t, Vector2 fromValue, bool setImmediately, bool isRelative)
		{
		}

		// Token: 0x060002BC RID: 700 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x371F2E0", Offset = "0x371DEE0", VA = "0x18371F2E0")]
		public static ABSTweenPlugin<Vector2, Vector2, CircleOptions> Get()
		{
			return null;
		}

		// Token: 0x060002BD RID: 701 RVA: 0x000033A8 File Offset: 0x000015A8
		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x2832290", Offset = "0x2830E90", VA = "0x182832290", Slot = "7")]
		public override Vector2 ConvertToStartValue(TweenerCore<Vector2, Vector2, CircleOptions> t, Vector2 value)
		{
			return default(Vector2);
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x371F670", Offset = "0x371E270", VA = "0x18371F670", Slot = "8")]
		public override void SetRelativeEndValue(TweenerCore<Vector2, Vector2, CircleOptions> t)
		{
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x371F310", Offset = "0x371DF10", VA = "0x18371F310", Slot = "9")]
		public override void SetChangeValue(TweenerCore<Vector2, Vector2, CircleOptions> t)
		{
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x000033C0 File Offset: 0x000015C0
		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x371F2C0", Offset = "0x371DEC0", VA = "0x18371F2C0", Slot = "10")]
		public override float GetSpeedBasedDuration(CircleOptions options, float unitsXSecond, Vector2 changeValue)
		{
			return 0f;
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x371F030", Offset = "0x371DC30", VA = "0x18371F030", Slot = "11")]
		public override void EvaluateAndApply(CircleOptions options, Tween t, bool isRelative, DOGetter<Vector2> getter, DOSetter<Vector2> setter, float elapsed, Vector2 startValue, Vector2 changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice)
		{
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x000033D8 File Offset: 0x000015D8
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x371F1E0", Offset = "0x371DDE0", VA = "0x18371F1E0")]
		public Vector2 GetPositionOnCircle(CircleOptions options, float degrees)
		{
			return default(Vector2);
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x371F6F0", Offset = "0x371E2F0", VA = "0x18371F6F0")]
		public CirclePlugin()
		{
		}
	}
}
