using System;
using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;
using UnityEngine;

namespace DG.Tweening.CustomPlugins
{
	// Token: 0x0200009F RID: 159
	[Token(Token = "0x200009F")]
	public class PureQuaternionPlugin : ABSTweenPlugin<Quaternion, Quaternion, NoOptions>
	{
		// Token: 0x060003B4 RID: 948 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x374FF40", Offset = "0x374EB40", VA = "0x18374FF40")]
		public static PureQuaternionPlugin Plug()
		{
			return null;
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "4")]
		public override void Reset(TweenerCore<Quaternion, Quaternion, NoOptions> t)
		{
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x3750360", Offset = "0x374EF60", VA = "0x183750360", Slot = "5")]
		public override void SetFrom(TweenerCore<Quaternion, Quaternion, NoOptions> t, bool isRelative)
		{
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x3750030", Offset = "0x374EC30", VA = "0x183750030", Slot = "6")]
		public override void SetFrom(TweenerCore<Quaternion, Quaternion, NoOptions> t, Quaternion fromValue, bool setImmediately, bool isRelative)
		{
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x000038A0 File Offset: 0x00001AA0
		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x3745E40", Offset = "0x3744A40", VA = "0x183745E40", Slot = "7")]
		public override Quaternion ConvertToStartValue(TweenerCore<Quaternion, Quaternion, NoOptions> t, Quaternion value)
		{
			return default(Quaternion);
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x3750570", Offset = "0x374F170", VA = "0x183750570", Slot = "8")]
		public override void SetRelativeEndValue(TweenerCore<Quaternion, Quaternion, NoOptions> t)
		{
		}

		// Token: 0x060003BA RID: 954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x3750000", Offset = "0x374EC00", VA = "0x183750000", Slot = "9")]
		public override void SetChangeValue(TweenerCore<Quaternion, Quaternion, NoOptions> t)
		{
		}

		// Token: 0x060003BB RID: 955 RVA: 0x000038B8 File Offset: 0x00001AB8
		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x374FE10", Offset = "0x374EA10", VA = "0x18374FE10", Slot = "10")]
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, Quaternion changeValue)
		{
			return 0f;
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x374FD40", Offset = "0x374E940", VA = "0x18374FD40", Slot = "11")]
		public override void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<Quaternion> getter, DOSetter<Quaternion> setter, float elapsed, Quaternion startValue, Quaternion changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice)
		{
		}

		// Token: 0x060003BD RID: 957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x37506F0", Offset = "0x374F2F0", VA = "0x1837506F0")]
		public PureQuaternionPlugin()
		{
		}

		// Token: 0x040001C5 RID: 453
		[Token(Token = "0x40001C5")]
		[FieldOffset(Offset = "0x0")]
		private static PureQuaternionPlugin _plug;
	}
}
