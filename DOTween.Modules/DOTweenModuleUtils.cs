using System;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Scripting;

namespace DG.Tweening
{
	// Token: 0x02000041 RID: 65
	[Token(Token = "0x2000041")]
	public static class DOTweenModuleUtils
	{
		// Token: 0x060000E6 RID: 230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x3742060", Offset = "0x3740C60", VA = "0x183742060")]
		[Preserve]
		public static void Init()
		{
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x3742100", Offset = "0x3740D00", VA = "0x183742100")]
		[Preserve]
		private static void Preserver()
		{
		}

		// Token: 0x0400005F RID: 95
		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x0")]
		private static bool _initialized;

		// Token: 0x02000042 RID: 66
		[Token(Token = "0x2000042")]
		public static class Physics
		{
			// Token: 0x060000E8 RID: 232 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0x3742210", Offset = "0x3740E10", VA = "0x183742210")]
			public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
			{
			}

			// Token: 0x060000E9 RID: 233 RVA: 0x00002550 File Offset: 0x00000750
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40")]
			public static bool HasRigidbody2D(Component target)
			{
				return default(bool);
			}

			// Token: 0x060000EA RID: 234 RVA: 0x00002568 File Offset: 0x00000768
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40")]
			[Preserve]
			public static bool HasRigidbody(Component target)
			{
				return default(bool);
			}

			// Token: 0x060000EB RID: 235 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0x37421A0", Offset = "0x3740DA0", VA = "0x1837421A0")]
			[Preserve]
			public static TweenerCore<Vector3, Path, PathOptions> CreateDOTweenPathTween(MonoBehaviour target, bool tweenRigidbody, bool isLocal, Path path, float duration, PathMode pathMode)
			{
				return null;
			}
		}
	}
}
