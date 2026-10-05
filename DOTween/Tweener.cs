using System;
using System.Runtime.InteropServices;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;

namespace DG.Tweening
{
	// Token: 0x02000070 RID: 112
	[Token(Token = "0x2000070")]
	public abstract class Tweener : Tween
	{
		// Token: 0x060002A9 RID: 681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x3739150", Offset = "0x3737D50", VA = "0x183739150")]
		internal Tweener()
		{
		}

		// Token: 0x060002AA RID: 682
		[Token(Token = "0x60002AA")]
		public abstract Tweener ChangeStartValue(object newStartValue, float newDuration = -1f);

		// Token: 0x060002AB RID: 683
		[Token(Token = "0x60002AB")]
		public abstract Tweener ChangeEndValue(object newEndValue, float newDuration = -1f, bool snapStartValue = false);

		// Token: 0x060002AC RID: 684
		[Token(Token = "0x60002AC")]
		public abstract Tweener ChangeEndValue(object newEndValue, bool snapStartValue);

		// Token: 0x060002AD RID: 685
		[Token(Token = "0x60002AD")]
		public abstract Tweener ChangeValues(object newStartValue, object newEndValue, float newDuration = -1f);

		// Token: 0x060002AE RID: 686
		[Token(Token = "0x60002AE")]
		internal abstract Tweener SetFrom(bool relative);

		// Token: 0x060002AF RID: 687 RVA: 0x00003348 File Offset: 0x00001548
		[Token(Token = "0x60002AF")]
		internal static bool Setup<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, DOGetter<T1> getter, DOSetter<T1> setter, T2 endValue, float duration, [Optional] ABSTweenPlugin<T1, T2, TPlugOptions> plugin) where TPlugOptions : struct, IPlugOptions
		{
			return default(bool);
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00003360 File Offset: 0x00001560
		[Token(Token = "0x60002B0")]
		internal static float DoUpdateDelay<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, float elapsed) where TPlugOptions : struct, IPlugOptions
		{
			return 0f;
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00003378 File Offset: 0x00001578
		[Token(Token = "0x60002B1")]
		internal static bool DoStartup<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t) where TPlugOptions : struct, IPlugOptions
		{
			return default(bool);
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60002B2")]
		internal static TweenerCore<T1, T2, TPlugOptions> DoChangeStartValue<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, T2 newStartValue, float newDuration) where TPlugOptions : struct, IPlugOptions
		{
			return null;
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60002B3")]
		internal static TweenerCore<T1, T2, TPlugOptions> DoChangeEndValue<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, T2 newEndValue, float newDuration, bool snapStartValue) where TPlugOptions : struct, IPlugOptions
		{
			return null;
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60002B4")]
		internal static TweenerCore<T1, T2, TPlugOptions> DoChangeValues<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, T2 newStartValue, T2 newEndValue, float newDuration) where TPlugOptions : struct, IPlugOptions
		{
			return null;
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00003390 File Offset: 0x00001590
		[Token(Token = "0x60002B5")]
		private static bool DOStartupSpecials<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t) where TPlugOptions : struct, IPlugOptions
		{
			return default(bool);
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B6")]
		private static void DOStartupDurationBased<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t) where TPlugOptions : struct, IPlugOptions
		{
		}

		// Token: 0x0400014E RID: 334
		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		internal bool hasManuallySetStartValue;

		// Token: 0x0400014F RID: 335
		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x121")]
		internal bool isFromAllowed;
	}
}
