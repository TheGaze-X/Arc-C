using System;
using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;
using UnityEngine;

namespace DG.Tweening.Plugins
{
	// Token: 0x02000086 RID: 134
	[Token(Token = "0x2000086")]
	public class Vector3Plugin : ABSTweenPlugin<Vector3, Vector3, VectorOptions>
	{
		// Token: 0x06000361 RID: 865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000361")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "4")]
		public override void Reset(TweenerCore<Vector3, Vector3, VectorOptions> t)
		{
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000362")]
		[Address(RVA = "0x3758810", Offset = "0x3757410", VA = "0x183758810", Slot = "5")]
		public override void SetFrom(TweenerCore<Vector3, Vector3, VectorOptions> t, bool isRelative)
		{
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000363")]
		[Address(RVA = "0x3758A10", Offset = "0x3757610", VA = "0x183758A10", Slot = "6")]
		public override void SetFrom(TweenerCore<Vector3, Vector3, VectorOptions> t, Vector3 fromValue, bool setImmediately, bool isRelative)
		{
		}

		// Token: 0x06000364 RID: 868 RVA: 0x000036F0 File Offset: 0x000018F0
		[Token(Token = "0x6000364")]
		[Address(RVA = "0x37581E0", Offset = "0x3756DE0", VA = "0x1837581E0", Slot = "7")]
		public override Vector3 ConvertToStartValue(TweenerCore<Vector3, Vector3, VectorOptions> t, Vector3 value)
		{
			return default(Vector3);
		}

		// Token: 0x06000365 RID: 869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000365")]
		[Address(RVA = "0x3752440", Offset = "0x3751040", VA = "0x183752440", Slot = "8")]
		public override void SetRelativeEndValue(TweenerCore<Vector3, Vector3, VectorOptions> t)
		{
		}

		// Token: 0x06000366 RID: 870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000366")]
		[Address(RVA = "0x3758700", Offset = "0x3757300", VA = "0x183758700", Slot = "9")]
		public override void SetChangeValue(TweenerCore<Vector3, Vector3, VectorOptions> t)
		{
		}

		// Token: 0x06000367 RID: 871 RVA: 0x00003708 File Offset: 0x00001908
		[Token(Token = "0x6000367")]
		[Address(RVA = "0x3751610", Offset = "0x3750210", VA = "0x183751610", Slot = "10")]
		public override float GetSpeedBasedDuration(VectorOptions options, float unitsXSecond, Vector3 changeValue)
		{
			return 0f;
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000368")]
		[Address(RVA = "0x3758200", Offset = "0x3756E00", VA = "0x183758200", Slot = "11")]
		public override void EvaluateAndApply(VectorOptions options, Tween t, bool isRelative, DOGetter<Vector3> getter, DOSetter<Vector3> setter, float elapsed, Vector3 startValue, Vector3 changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice)
		{
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000369")]
		[Address(RVA = "0x3758D60", Offset = "0x3757960", VA = "0x183758D60")]
		public Vector3Plugin()
		{
		}
	}
}
