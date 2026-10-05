using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using EaseFunctions;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02000171 RID: 369
	[Token(Token = "0x2000171")]
	public class TweenUtils : IHotfixable
	{
		// Token: 0x060008EA RID: 2282 RVA: 0x00007244 File Offset: 0x00005444
		[Token(Token = "0x60008EA")]
		[Address(RVA = "0x5536DC0", Offset = "0x55359C0", VA = "0x185536DC0")]
		public static bool TickAsCountDown(ref float countDown, float timeDelta)
		{
			return default(bool);
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008EB")]
		[Address(RVA = "0x5536EC0", Offset = "0x5535AC0", VA = "0x185536EC0")]
		public static Tween TweenNumStr(TweenUtils.NumStrOptions options)
		{
			return null;
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60008EC")]
		[Address(RVA = "0x5537100", Offset = "0x5535D00", VA = "0x185537100")]
		public TweenUtils()
		{
		}

		// Token: 0x04000838 RID: 2104
		[Token(Token = "0x4000838")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate188 __Hotfix0_TickAsCountDown;

		// Token: 0x04000839 RID: 2105
		[Token(Token = "0x4000839")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate189 __Hotfix0_TweenNumStr;

		// Token: 0x0400083A RID: 2106
		[Token(Token = "0x400083A")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;

		// Token: 0x02000172 RID: 370
		[Token(Token = "0x2000172")]
		public struct SmoothStep
		{
			// Token: 0x170000E0 RID: 224
			// (get) Token: 0x060008ED RID: 2285 RVA: 0x0000725C File Offset: 0x0000545C
			// (set) Token: 0x060008EE RID: 2286 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x170000E0")]
			public bool isEmpty
			{
				[Token(Token = "0x60008ED")]
				[Address(RVA = "0xDF9A30", Offset = "0xDF8630", VA = "0x180DF9A30")]
				[CompilerGenerated]
				readonly get
				{
					return default(bool);
				}
				[Token(Token = "0x60008EE")]
				[Address(RVA = "0xFEDED0", Offset = "0xFECAD0", VA = "0x180FEDED0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x060008EF RID: 2287 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x60008EF")]
			[Address(RVA = "0x5534BF0", Offset = "0x55337F0", VA = "0x185534BF0")]
			public void StartWithEasingFunction(Interpolator.EaseType easeType)
			{
			}

			// Token: 0x060008F0 RID: 2288 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x60008F0")]
			[Address(RVA = "0x5534C30", Offset = "0x5533830", VA = "0x185534C30")]
			public void Start()
			{
			}

			// Token: 0x060008F1 RID: 2289 RVA: 0x00007274 File Offset: 0x00005474
			[Token(Token = "0x60008F1")]
			[Address(RVA = "0x55349E0", Offset = "0x55335E0", VA = "0x1855349E0")]
			public float GetValue(out bool isTweenFinished)
			{
				return 0f;
			}

			// Token: 0x0400083B RID: 2107
			[Token(Token = "0x400083B")]
			[FieldOffset(Offset = "0x0")]
			public static TweenUtils.SmoothStep EMPTY;

			// Token: 0x0400083D RID: 2109
			[Token(Token = "0x400083D")]
			[FieldOffset(Offset = "0x8")]
			private ScaledStopwatch m_timer;

			// Token: 0x0400083E RID: 2110
			[Token(Token = "0x400083E")]
			[FieldOffset(Offset = "0x18")]
			public bool ignoreTimeScale;

			// Token: 0x0400083F RID: 2111
			[Token(Token = "0x400083F")]
			[FieldOffset(Offset = "0x1C")]
			public float startValue;

			// Token: 0x04000840 RID: 2112
			[Token(Token = "0x4000840")]
			[FieldOffset(Offset = "0x20")]
			public float endValue;

			// Token: 0x04000841 RID: 2113
			[Token(Token = "0x4000841")]
			[FieldOffset(Offset = "0x24")]
			public float duration;

			// Token: 0x04000842 RID: 2114
			[Token(Token = "0x4000842")]
			[FieldOffset(Offset = "0x28")]
			public float delay;

			// Token: 0x04000843 RID: 2115
			[Token(Token = "0x4000843")]
			[FieldOffset(Offset = "0x30")]
			private Interpolator.EasingFunction m_easingFunction;
		}

		// Token: 0x02000173 RID: 371
		[Token(Token = "0x2000173")]
		public class FadeoutOptimizer : IHotfixable
		{
			// Token: 0x060008F3 RID: 2291 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60008F3")]
			[Address(RVA = "0x5531490", Offset = "0x5530090", VA = "0x185531490")]
			public static Tween FadeoutPanel(CanvasGroup canvas, float defaultDuration, out float realDuration)
			{
				return null;
			}

			// Token: 0x060008F4 RID: 2292 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60008F4")]
			[Address(RVA = "0x55316F0", Offset = "0x55302F0", VA = "0x1855316F0")]
			public static EaseFunction LinearThenAccel(float threshold, float ratio)
			{
				return null;
			}

			// Token: 0x060008F5 RID: 2293 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x60008F5")]
			[Address(RVA = "0x5531830", Offset = "0x5530430", VA = "0x185531830")]
			public FadeoutOptimizer()
			{
			}

			// Token: 0x04000844 RID: 2116
			[Token(Token = "0x4000844")]
			private const float LINEAR_RATIO = 0.5f;

			// Token: 0x04000845 RID: 2117
			[Token(Token = "0x4000845")]
			private const float ALPHA_RATIO = 0.2f;

			// Token: 0x04000846 RID: 2118
			[Token(Token = "0x4000846")]
			private const float ACCEL_RATIO = 4f;

			// Token: 0x04000847 RID: 2119
			[Token(Token = "0x4000847")]
			[FieldOffset(Offset = "0x0")]
			private static EaseFunction s_linearThenAccel;

			// Token: 0x04000848 RID: 2120
			[Token(Token = "0x4000848")]
			[FieldOffset(Offset = "0x8")]
			private static __XLua_Gen_Delegate186 __Hotfix0_FadeoutPanel;

			// Token: 0x04000849 RID: 2121
			[Token(Token = "0x4000849")]
			[FieldOffset(Offset = "0x10")]
			private static __XLua_Gen_Delegate187 __Hotfix0_LinearThenAccel;

			// Token: 0x0400084A RID: 2122
			[Token(Token = "0x400084A")]
			[FieldOffset(Offset = "0x18")]
			private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;
		}

		// Token: 0x02000175 RID: 373
		[Token(Token = "0x2000175")]
		public struct NumStrOptions
		{
			// Token: 0x0400084D RID: 2125
			[Token(Token = "0x400084D")]
			[FieldOffset(Offset = "0x0")]
			public Text textNum;

			// Token: 0x0400084E RID: 2126
			[Token(Token = "0x400084E")]
			[FieldOffset(Offset = "0x8")]
			public int srcVal;

			// Token: 0x0400084F RID: 2127
			[Token(Token = "0x400084F")]
			[FieldOffset(Offset = "0xC")]
			public int dstVal;

			// Token: 0x04000850 RID: 2128
			[Token(Token = "0x4000850")]
			[FieldOffset(Offset = "0x10")]
			public float duration;

			// Token: 0x04000851 RID: 2129
			[Token(Token = "0x4000851")]
			[FieldOffset(Offset = "0x14")]
			public Ease easeType;

			// Token: 0x04000852 RID: 2130
			[Token(Token = "0x4000852")]
			[FieldOffset(Offset = "0x18")]
			public string fmtStr;
		}
	}
}
