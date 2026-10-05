using System;
using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;

namespace DG.Tweening.Plugins
{
	// Token: 0x02000075 RID: 117
	[Token(Token = "0x2000075")]
	internal class Color2Plugin : ABSTweenPlugin<Color2, Color2, ColorOptions>
	{
		// Token: 0x060002C4 RID: 708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "4")]
		public override void Reset(TweenerCore<Color2, Color2, ColorOptions> t)
		{
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x3745AF0", Offset = "0x37446F0", VA = "0x183745AF0", Slot = "5")]
		public override void SetFrom(TweenerCore<Color2, Color2, ColorOptions> t, bool isRelative)
		{
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x3745940", Offset = "0x3744540", VA = "0x183745940", Slot = "6")]
		public override void SetFrom(TweenerCore<Color2, Color2, ColorOptions> t, Color2 fromValue, bool setImmediately, bool isRelative)
		{
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x000033F0 File Offset: 0x000015F0
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x3745530", Offset = "0x3744130", VA = "0x183745530", Slot = "7")]
		public override Color2 ConvertToStartValue(TweenerCore<Color2, Color2, ColorOptions> t, Color2 value)
		{
			return default(Color2);
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x3745D70", Offset = "0x3744970", VA = "0x183745D70", Slot = "8")]
		public override void SetRelativeEndValue(TweenerCore<Color2, Color2, ColorOptions> t)
		{
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x37458C0", Offset = "0x37444C0", VA = "0x1837458C0", Slot = "9")]
		public override void SetChangeValue(TweenerCore<Color2, Color2, ColorOptions> t)
		{
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00003408 File Offset: 0x00001608
		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x37458B0", Offset = "0x37444B0", VA = "0x1837458B0", Slot = "10")]
		public override float GetSpeedBasedDuration(ColorOptions options, float unitsXSecond, Color2 changeValue)
		{
			return 0f;
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x3745550", Offset = "0x3744150", VA = "0x183745550", Slot = "11")]
		public override void EvaluateAndApply(ColorOptions options, Tween t, bool isRelative, DOGetter<Color2> getter, DOSetter<Color2> setter, float elapsed, Color2 startValue, Color2 changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice)
		{
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x3745DF0", Offset = "0x37449F0", VA = "0x183745DF0")]
		public Color2Plugin()
		{
		}
	}
}
