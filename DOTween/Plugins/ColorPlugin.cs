using System;
using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;
using UnityEngine;

namespace DG.Tweening.Plugins
{
	// Token: 0x0200007B RID: 123
	[Token(Token = "0x200007B")]
	public class ColorPlugin : ABSTweenPlugin<Color, Color, ColorOptions>
	{
		// Token: 0x060002FE RID: 766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "4")]
		public override void Reset(TweenerCore<Color, Color, ColorOptions> t)
		{
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x37461E0", Offset = "0x3744DE0", VA = "0x1837461E0", Slot = "5")]
		public override void SetFrom(TweenerCore<Color, Color, ColorOptions> t, bool isRelative)
		{
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000300")]
		[Address(RVA = "0x3746330", Offset = "0x3744F30", VA = "0x183746330", Slot = "6")]
		public override void SetFrom(TweenerCore<Color, Color, ColorOptions> t, Color fromValue, bool setImmediately, bool isRelative)
		{
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00003510 File Offset: 0x00001710
		[Token(Token = "0x6000301")]
		[Address(RVA = "0x3745E40", Offset = "0x3744A40", VA = "0x183745E40", Slot = "7")]
		public override Color ConvertToStartValue(TweenerCore<Color, Color, ColorOptions> t, Color value)
		{
			return default(Color);
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000302")]
		[Address(RVA = "0x3746540", Offset = "0x3745140", VA = "0x183746540", Slot = "8")]
		public override void SetRelativeEndValue(TweenerCore<Color, Color, ColorOptions> t)
		{
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000303")]
		[Address(RVA = "0x3746160", Offset = "0x3744D60", VA = "0x183746160", Slot = "9")]
		public override void SetChangeValue(TweenerCore<Color, Color, ColorOptions> t)
		{
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00003528 File Offset: 0x00001728
		[Token(Token = "0x6000304")]
		[Address(RVA = "0x37458B0", Offset = "0x37444B0", VA = "0x1837458B0", Slot = "10")]
		public override float GetSpeedBasedDuration(ColorOptions options, float unitsXSecond, Color changeValue)
		{
			return 0f;
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000305")]
		[Address(RVA = "0x3745E50", Offset = "0x3744A50", VA = "0x183745E50", Slot = "11")]
		public override void EvaluateAndApply(ColorOptions options, Tween t, bool isRelative, DOGetter<Color> getter, DOSetter<Color> setter, float elapsed, Color startValue, Color changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice)
		{
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000306")]
		[Address(RVA = "0x37465C0", Offset = "0x37451C0", VA = "0x1837465C0")]
		public ColorPlugin()
		{
		}
	}
}
