using System;
using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;
using UnityEngine;

namespace DG.Tweening.Plugins
{
	// Token: 0x0200007A RID: 122
	[Token(Token = "0x200007A")]
	public class PathPlugin : ABSTweenPlugin<Vector3, Path, PathOptions>
	{
		// Token: 0x060002F1 RID: 753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x374BB60", Offset = "0x374A760", VA = "0x18374BB60", Slot = "4")]
		public override void Reset(TweenerCore<Vector3, Path, PathOptions> t)
		{
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
		public override void SetFrom(TweenerCore<Vector3, Path, PathOptions> t, bool isRelative)
		{
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
		public override void SetFrom(TweenerCore<Vector3, Path, PathOptions> t, Path fromValue, bool setImmediately, bool isRelative)
		{
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x374BAF0", Offset = "0x374A6F0", VA = "0x18374BAF0")]
		public static ABSTweenPlugin<Vector3, Path, PathOptions> Get()
		{
			return null;
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x374B580", Offset = "0x374A180", VA = "0x18374B580", Slot = "7")]
		public override Path ConvertToStartValue(TweenerCore<Vector3, Path, PathOptions> t, Vector3 value)
		{
			return null;
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x374D980", Offset = "0x374C580", VA = "0x18374D980", Slot = "8")]
		public override void SetRelativeEndValue(TweenerCore<Vector3, Path, PathOptions> t)
		{
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x374BBE0", Offset = "0x374A7E0", VA = "0x18374BBE0", Slot = "9")]
		public override void SetChangeValue(TweenerCore<Vector3, Path, PathOptions> t)
		{
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x000034C8 File Offset: 0x000016C8
		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x374BAD0", Offset = "0x374A6D0", VA = "0x18374BAD0", Slot = "10")]
		public override float GetSpeedBasedDuration(PathOptions options, float unitsXSecond, Path changeValue)
		{
			return 0f;
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x374B5E0", Offset = "0x374A1E0", VA = "0x18374B5E0", Slot = "11")]
		public override void EvaluateAndApply(PathOptions options, Tween t, bool isRelative, DOGetter<Vector3> getter, DOSetter<Vector3> setter, float elapsed, Path startValue, Path changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice)
		{
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x374C330", Offset = "0x374AF30", VA = "0x18374C330")]
		public void SetOrientation(PathOptions options, Tween t, Path path, float pathPerc, Vector3 tPos, UpdateNotice updateNotice)
		{
		}

		// Token: 0x060002FB RID: 763 RVA: 0x000034E0 File Offset: 0x000016E0
		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x374B5A0", Offset = "0x374A1A0", VA = "0x18374B5A0")]
		private Vector3 DivideVectorByVector(Vector3 vector, Vector3 byVector)
		{
			return default(Vector3);
		}

		// Token: 0x060002FC RID: 764 RVA: 0x000034F8 File Offset: 0x000016F8
		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x374BB20", Offset = "0x374A720", VA = "0x18374BB20")]
		private Vector3 MultiplyVectorByVector(Vector3 vector, Vector3 byVector)
		{
			return default(Vector3);
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x374DAB0", Offset = "0x374C6B0", VA = "0x18374DAB0")]
		public PathPlugin()
		{
		}

		// Token: 0x04000160 RID: 352
		[Token(Token = "0x4000160")]
		public const float MinLookAhead = 0.0001f;
	}
}
