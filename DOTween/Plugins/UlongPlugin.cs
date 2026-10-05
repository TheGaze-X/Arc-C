using System;
using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;

namespace DG.Tweening.Plugins
{
	// Token: 0x02000078 RID: 120
	[Token(Token = "0x2000078")]
	public class UlongPlugin : ABSTweenPlugin<ulong, ulong, NoOptions>
	{
		// Token: 0x060002DF RID: 735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "4")]
		public override void Reset(TweenerCore<ulong, ulong, NoOptions> t)
		{
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x374B2F0", Offset = "0x3749EF0", VA = "0x18374B2F0", Slot = "5")]
		public override void SetFrom(TweenerCore<ulong, ulong, NoOptions> t, bool isRelative)
		{
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x374B380", Offset = "0x3749F80", VA = "0x18374B380", Slot = "6")]
		public override void SetFrom(TweenerCore<ulong, ulong, NoOptions> t, ulong fromValue, bool setImmediately, bool isRelative)
		{
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00003480 File Offset: 0x00001680
		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x2832290", Offset = "0x2830E90", VA = "0x182832290", Slot = "7")]
		public override ulong ConvertToStartValue(TweenerCore<ulong, ulong, NoOptions> t, ulong value)
		{
			return 0UL;
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x374B410", Offset = "0x374A010", VA = "0x18374B410", Slot = "8")]
		public override void SetRelativeEndValue(TweenerCore<ulong, ulong, NoOptions> t)
		{
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x374B2C0", Offset = "0x3749EC0", VA = "0x18374B2C0", Slot = "9")]
		public override void SetChangeValue(TweenerCore<ulong, ulong, NoOptions> t)
		{
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00003498 File Offset: 0x00001698
		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x3756C00", Offset = "0x3755800", VA = "0x183756C00", Slot = "10")]
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, ulong changeValue)
		{
			return 0f;
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x37569E0", Offset = "0x37555E0", VA = "0x1837569E0", Slot = "11")]
		public override void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<ulong> getter, DOSetter<ulong> setter, float elapsed, ulong startValue, ulong changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice)
		{
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x3756C40", Offset = "0x3755840", VA = "0x183756C40")]
		public UlongPlugin()
		{
		}
	}
}
