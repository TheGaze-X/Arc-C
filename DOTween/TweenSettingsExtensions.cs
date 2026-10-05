using System;
using System.Runtime.InteropServices;
using DG.Tweening.Core;
using DG.Tweening.Plugins;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;
using UnityEngine;

namespace DG.Tweening
{
	// Token: 0x0200006D RID: 109
	[Token(Token = "0x200006D")]
	public static class TweenSettingsExtensions
	{
		// Token: 0x06000244 RID: 580 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000244")]
		public static T SetAutoKill<T>(this T t) where T : Tween
		{
			return null;
		}

		// Token: 0x06000245 RID: 581 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000245")]
		public static T SetAutoKill<T>(this T t, bool autoKillOnCompletion) where T : Tween
		{
			return null;
		}

		// Token: 0x06000246 RID: 582 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000246")]
		public static T SetId<T>(this T t, object objectId) where T : Tween
		{
			return null;
		}

		// Token: 0x06000247 RID: 583 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000247")]
		public static T SetId<T>(this T t, string stringId) where T : Tween
		{
			return null;
		}

		// Token: 0x06000248 RID: 584 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000248")]
		public static T SetId<T>(this T t, int intId) where T : Tween
		{
			return null;
		}

		// Token: 0x06000249 RID: 585 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000249")]
		public static T SetLink<T>(this T t, GameObject gameObject) where T : Tween
		{
			return null;
		}

		// Token: 0x0600024A RID: 586 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600024A")]
		public static T SetLink<T>(this T t, GameObject gameObject, LinkBehaviour behaviour) where T : Tween
		{
			return null;
		}

		// Token: 0x0600024B RID: 587 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600024B")]
		public static T SetTarget<T>(this T t, object target) where T : Tween
		{
			return null;
		}

		// Token: 0x0600024C RID: 588 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600024C")]
		public static T SetLoops<T>(this T t, int loops) where T : Tween
		{
			return null;
		}

		// Token: 0x0600024D RID: 589 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600024D")]
		public static T SetLoops<T>(this T t, int loops, LoopType loopType) where T : Tween
		{
			return null;
		}

		// Token: 0x0600024E RID: 590 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600024E")]
		public static T SetEase<T>(this T t, Ease ease) where T : Tween
		{
			return null;
		}

		// Token: 0x0600024F RID: 591 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600024F")]
		public static T SetEase<T>(this T t, Ease ease, float overshoot) where T : Tween
		{
			return null;
		}

		// Token: 0x06000250 RID: 592 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000250")]
		public static T SetEase<T>(this T t, Ease ease, float amplitude, float period) where T : Tween
		{
			return null;
		}

		// Token: 0x06000251 RID: 593 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000251")]
		public static T SetEase<T>(this T t, AnimationCurve animCurve) where T : Tween
		{
			return null;
		}

		// Token: 0x06000252 RID: 594 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000252")]
		public static T SetEase<T>(this T t, EaseFunction customEase) where T : Tween
		{
			return null;
		}

		// Token: 0x06000253 RID: 595 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000253")]
		public static T SetRecyclable<T>(this T t) where T : Tween
		{
			return null;
		}

		// Token: 0x06000254 RID: 596 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000254")]
		public static T SetRecyclable<T>(this T t, bool recyclable) where T : Tween
		{
			return null;
		}

		// Token: 0x06000255 RID: 597 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000255")]
		public static T SetUpdate<T>(this T t, bool isIndependentUpdate) where T : Tween
		{
			return null;
		}

		// Token: 0x06000256 RID: 598 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000256")]
		public static T SetUpdate<T>(this T t, UpdateType updateType) where T : Tween
		{
			return null;
		}

		// Token: 0x06000257 RID: 599 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000257")]
		public static T SetUpdate<T>(this T t, UpdateType updateType, bool isIndependentUpdate) where T : Tween
		{
			return null;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000258")]
		public static T SetInverted<T>(this T t) where T : Tween
		{
			return null;
		}

		// Token: 0x06000259 RID: 601 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000259")]
		public static T SetInverted<T>(this T t, bool inverted) where T : Tween
		{
			return null;
		}

		// Token: 0x0600025A RID: 602 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600025A")]
		public static T OnStart<T>(this T t, TweenCallback action) where T : Tween
		{
			return null;
		}

		// Token: 0x0600025B RID: 603 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600025B")]
		public static T OnPlay<T>(this T t, TweenCallback action) where T : Tween
		{
			return null;
		}

		// Token: 0x0600025C RID: 604 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600025C")]
		public static T OnPause<T>(this T t, TweenCallback action) where T : Tween
		{
			return null;
		}

		// Token: 0x0600025D RID: 605 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600025D")]
		public static T OnRewind<T>(this T t, TweenCallback action) where T : Tween
		{
			return null;
		}

		// Token: 0x0600025E RID: 606 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600025E")]
		public static T OnUpdate<T>(this T t, TweenCallback action) where T : Tween
		{
			return null;
		}

		// Token: 0x0600025F RID: 607 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600025F")]
		public static T OnStepComplete<T>(this T t, TweenCallback action) where T : Tween
		{
			return null;
		}

		// Token: 0x06000260 RID: 608 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000260")]
		public static T OnComplete<T>(this T t, TweenCallback action) where T : Tween
		{
			return null;
		}

		// Token: 0x06000261 RID: 609 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000261")]
		public static T OnKill<T>(this T t, TweenCallback action) where T : Tween
		{
			return null;
		}

		// Token: 0x06000262 RID: 610 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000262")]
		public static T OnWaypointChange<T>(this T t, TweenCallback<int> action) where T : Tween
		{
			return null;
		}

		// Token: 0x06000263 RID: 611 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000263")]
		public static T SetAs<T>(this T t, Tween asTween) where T : Tween
		{
			return null;
		}

		// Token: 0x06000264 RID: 612 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000264")]
		public static T SetAs<T>(this T t, TweenParams tweenParams) where T : Tween
		{
			return null;
		}

		// Token: 0x06000265 RID: 613 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000265")]
		[Address(RVA = "0x37373B0", Offset = "0x3735FB0", VA = "0x1837373B0")]
		public static Sequence Append(this Sequence s, Tween t)
		{
			return null;
		}

		// Token: 0x06000266 RID: 614 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000266")]
		[Address(RVA = "0x3737A90", Offset = "0x3736690", VA = "0x183737A90")]
		public static Sequence Prepend(this Sequence s, Tween t)
		{
			return null;
		}

		// Token: 0x06000267 RID: 615 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000267")]
		[Address(RVA = "0x3737840", Offset = "0x3736440", VA = "0x183737840")]
		public static Sequence Join(this Sequence s, Tween t)
		{
			return null;
		}

		// Token: 0x06000268 RID: 616 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000268")]
		[Address(RVA = "0x3737710", Offset = "0x3736310", VA = "0x183737710")]
		public static Sequence Insert(this Sequence s, float atPosition, Tween t)
		{
			return null;
		}

		// Token: 0x06000269 RID: 617 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000269")]
		[Address(RVA = "0x3737330", Offset = "0x3735F30", VA = "0x183737330")]
		public static Sequence AppendInterval(this Sequence s, float interval)
		{
			return null;
		}

		// Token: 0x0600026A RID: 618 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600026A")]
		[Address(RVA = "0x3737970", Offset = "0x3736570", VA = "0x183737970")]
		public static Sequence PrependInterval(this Sequence s, float interval)
		{
			return null;
		}

		// Token: 0x0600026B RID: 619 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600026B")]
		[Address(RVA = "0x37372C0", Offset = "0x3735EC0", VA = "0x1837372C0")]
		public static Sequence AppendCallback(this Sequence s, TweenCallback callback)
		{
			return null;
		}

		// Token: 0x0600026C RID: 620 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600026C")]
		[Address(RVA = "0x3737900", Offset = "0x3736500", VA = "0x183737900")]
		public static Sequence PrependCallback(this Sequence s, TweenCallback callback)
		{
			return null;
		}

		// Token: 0x0600026D RID: 621 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600026D")]
		[Address(RVA = "0x37377D0", Offset = "0x37363D0", VA = "0x1837377D0")]
		public static Sequence JoinCallback(this Sequence s, TweenCallback callback)
		{
			return null;
		}

		// Token: 0x0600026E RID: 622 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600026E")]
		[Address(RVA = "0x37376A0", Offset = "0x37362A0", VA = "0x1837376A0")]
		public static Sequence InsertCallback(this Sequence s, float atPosition, TweenCallback callback)
		{
			return null;
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00003240 File Offset: 0x00001440
		[Token(Token = "0x600026F")]
		[Address(RVA = "0x3738810", Offset = "0x3737410", VA = "0x183738810")]
		private static bool ValidateAddToSequence(Sequence s, Tween t, bool ignoreTween = false)
		{
			return default(bool);
		}

		// Token: 0x06000270 RID: 624 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000270")]
		public static T From<T>(this T t) where T : Tweener
		{
			return null;
		}

		// Token: 0x06000271 RID: 625 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000271")]
		public static T From<T>(this T t, bool isRelative) where T : Tweener
		{
			return null;
		}

		// Token: 0x06000272 RID: 626 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000272")]
		public static T From<T>(this T t, bool setImmediately, bool isRelative) where T : Tweener
		{
			return null;
		}

		// Token: 0x06000273 RID: 627 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000273")]
		public static TweenerCore<T1, T2, TPlugOptions> From<T1, T2, TPlugOptions>(this TweenerCore<T1, T2, TPlugOptions> t, T2 fromValue, bool setImmediately = true, bool isRelative = false) where TPlugOptions : struct, IPlugOptions
		{
			return null;
		}

		// Token: 0x06000274 RID: 628 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000274")]
		[Address(RVA = "0x3737470", Offset = "0x3736070", VA = "0x183737470")]
		public static TweenerCore<Color, Color, ColorOptions> From(this TweenerCore<Color, Color, ColorOptions> t, float fromAlphaValue, bool setImmediately = true, bool isRelative = false)
		{
			return null;
		}

		// Token: 0x06000275 RID: 629 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000275")]
		[Address(RVA = "0x3737530", Offset = "0x3736130", VA = "0x183737530")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> From(this TweenerCore<Vector3, Vector3, VectorOptions> t, float fromValue, bool setImmediately = true, bool isRelative = false)
		{
			return null;
		}

		// Token: 0x06000276 RID: 630 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000276")]
		[Address(RVA = "0x37375F0", Offset = "0x37361F0", VA = "0x1837375F0")]
		public static TweenerCore<Vector2, Vector2, CircleOptions> From(this TweenerCore<Vector2, Vector2, CircleOptions> t, float fromValueDegrees, bool setImmediately = true, bool isRelative = false)
		{
			return null;
		}

		// Token: 0x06000277 RID: 631 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000277")]
		public static T SetDelay<T>(this T t, float delay) where T : Tween
		{
			return null;
		}

		// Token: 0x06000278 RID: 632 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000278")]
		public static T SetDelay<T>(this T t, float delay, bool asPrependedIntervalIfSequence) where T : Tween
		{
			return null;
		}

		// Token: 0x06000279 RID: 633 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000279")]
		public static T SetRelative<T>(this T t) where T : Tween
		{
			return null;
		}

		// Token: 0x0600027A RID: 634 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600027A")]
		public static T SetRelative<T>(this T t, bool isRelative) where T : Tween
		{
			return null;
		}

		// Token: 0x0600027B RID: 635 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600027B")]
		public static T SetSpeedBased<T>(this T t) where T : Tween
		{
			return null;
		}

		// Token: 0x0600027C RID: 636 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600027C")]
		public static T SetSpeedBased<T>(this T t, bool isSpeedBased) where T : Tween
		{
			return null;
		}

		// Token: 0x0600027D RID: 637 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600027D")]
		[Address(RVA = "0x3738400", Offset = "0x3737000", VA = "0x183738400")]
		public static Tweener SetOptions(this TweenerCore<float, float, FloatOptions> t, bool snapping)
		{
			return null;
		}

		// Token: 0x0600027E RID: 638 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600027E")]
		[Address(RVA = "0x3738220", Offset = "0x3736E20", VA = "0x183738220")]
		public static Tweener SetOptions(this TweenerCore<Vector2, Vector2, VectorOptions> t, bool snapping)
		{
			return null;
		}

		// Token: 0x0600027F RID: 639 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600027F")]
		[Address(RVA = "0x3738450", Offset = "0x3737050", VA = "0x183738450")]
		public static Tweener SetOptions(this TweenerCore<Vector2, Vector2, VectorOptions> t, AxisConstraint axisConstraint, bool snapping = false)
		{
			return null;
		}

		// Token: 0x06000280 RID: 640 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000280")]
		[Address(RVA = "0x37383C0", Offset = "0x3736FC0", VA = "0x1837383C0")]
		public static Tweener SetOptions(this TweenerCore<Vector3, Vector3, VectorOptions> t, bool snapping)
		{
			return null;
		}

		// Token: 0x06000281 RID: 641 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000281")]
		[Address(RVA = "0x37383E0", Offset = "0x3736FE0", VA = "0x1837383E0")]
		public static Tweener SetOptions(this TweenerCore<Vector3, Vector3, VectorOptions> t, AxisConstraint axisConstraint, bool snapping = false)
		{
			return null;
		}

		// Token: 0x06000282 RID: 642 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000282")]
		[Address(RVA = "0x37381E0", Offset = "0x3736DE0", VA = "0x1837381E0")]
		public static Tweener SetOptions(this TweenerCore<Vector4, Vector4, VectorOptions> t, bool snapping)
		{
			return null;
		}

		// Token: 0x06000283 RID: 643 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000283")]
		[Address(RVA = "0x37381C0", Offset = "0x3736DC0", VA = "0x1837381C0")]
		public static Tweener SetOptions(this TweenerCore<Vector4, Vector4, VectorOptions> t, AxisConstraint axisConstraint, bool snapping = false)
		{
			return null;
		}

		// Token: 0x06000284 RID: 644 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000284")]
		[Address(RVA = "0x3738240", Offset = "0x3736E40", VA = "0x183738240")]
		public static Tweener SetOptions(this TweenerCore<Quaternion, Vector3, QuaternionOptions> t, bool useShortest360Route = true)
		{
			return null;
		}

		// Token: 0x06000285 RID: 645 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000285")]
		[Address(RVA = "0x3738200", Offset = "0x3736E00", VA = "0x183738200")]
		public static Tweener SetOptions(this TweenerCore<Color, Color, ColorOptions> t, bool alphaOnly)
		{
			return null;
		}

		// Token: 0x06000286 RID: 646 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000286")]
		[Address(RVA = "0x3738200", Offset = "0x3736E00", VA = "0x183738200")]
		public static Tweener SetOptions(this TweenerCore<Rect, Rect, RectOptions> t, bool snapping)
		{
			return null;
		}

		// Token: 0x06000287 RID: 647 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000287")]
		[Address(RVA = "0x3738260", Offset = "0x3736E60", VA = "0x183738260")]
		public static Tweener SetOptions(this TweenerCore<string, string, StringOptions> t, bool richTextEnabled, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
		{
			return null;
		}

		// Token: 0x06000288 RID: 648 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000288")]
		[Address(RVA = "0x3738220", Offset = "0x3736E20", VA = "0x183738220")]
		public static Tweener SetOptions(this TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t, bool snapping)
		{
			return null;
		}

		// Token: 0x06000289 RID: 649 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000289")]
		[Address(RVA = "0x3738450", Offset = "0x3737050", VA = "0x183738450")]
		public static Tweener SetOptions(this TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t, AxisConstraint axisConstraint, bool snapping = false)
		{
			return null;
		}

		// Token: 0x0600028A RID: 650 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600028A")]
		[Address(RVA = "0x3738390", Offset = "0x3736F90", VA = "0x183738390")]
		public static Tweener SetOptions(this TweenerCore<Vector2, Vector2, CircleOptions> t, float endValueDegrees, bool relativeCenter = true, bool snapping = false)
		{
			return null;
		}

		// Token: 0x0600028B RID: 651 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600028B")]
		[Address(RVA = "0x3738420", Offset = "0x3737020", VA = "0x183738420")]
		public static TweenerCore<Vector3, Path, PathOptions> SetOptions(this TweenerCore<Vector3, Path, PathOptions> t, AxisConstraint lockPosition, AxisConstraint lockRotation = AxisConstraint.None)
		{
			return null;
		}

		// Token: 0x0600028C RID: 652 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600028C")]
		[Address(RVA = "0x3738360", Offset = "0x3736F60", VA = "0x183738360")]
		public static TweenerCore<Vector3, Path, PathOptions> SetOptions(this TweenerCore<Vector3, Path, PathOptions> t, bool closePath, AxisConstraint lockPosition = AxisConstraint.None, AxisConstraint lockRotation = AxisConstraint.None)
		{
			return null;
		}

		// Token: 0x0600028D RID: 653 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600028D")]
		[Address(RVA = "0x3737E50", Offset = "0x3736A50", VA = "0x183737E50")]
		public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(this TweenerCore<Vector3, Path, PathOptions> t, Vector3 lookAtPosition, [Optional] Vector3? forwardDirection, [Optional] Vector3? up)
		{
			return null;
		}

		// Token: 0x0600028E RID: 654 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600028E")]
		[Address(RVA = "0x3737F90", Offset = "0x3736B90", VA = "0x183737F90")]
		public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(this TweenerCore<Vector3, Path, PathOptions> t, Vector3 lookAtPosition, bool stableZRotation)
		{
			return null;
		}

		// Token: 0x0600028F RID: 655 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600028F")]
		[Address(RVA = "0x3737D70", Offset = "0x3736970", VA = "0x183737D70")]
		public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(this TweenerCore<Vector3, Path, PathOptions> t, Transform lookAtTransform, [Optional] Vector3? forwardDirection, [Optional] Vector3? up)
		{
			return null;
		}

		// Token: 0x06000290 RID: 656 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000290")]
		[Address(RVA = "0x3738000", Offset = "0x3736C00", VA = "0x183738000")]
		public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(this TweenerCore<Vector3, Path, PathOptions> t, Transform lookAtTransform, bool stableZRotation)
		{
			return null;
		}

		// Token: 0x06000291 RID: 657 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000291")]
		[Address(RVA = "0x3737EC0", Offset = "0x3736AC0", VA = "0x183737EC0")]
		public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(this TweenerCore<Vector3, Path, PathOptions> t, float lookAhead, [Optional] Vector3? forwardDirection, [Optional] Vector3? up)
		{
			return null;
		}

		// Token: 0x06000292 RID: 658 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000292")]
		[Address(RVA = "0x3737CA0", Offset = "0x37368A0", VA = "0x183737CA0")]
		public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(this TweenerCore<Vector3, Path, PathOptions> t, float lookAhead, bool stableZRotation)
		{
			return null;
		}

		// Token: 0x06000293 RID: 659 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000293")]
		[Address(RVA = "0x37380F0", Offset = "0x3736CF0", VA = "0x1837380F0")]
		private static TweenerCore<Vector3, Path, PathOptions> SetLookAt(this TweenerCore<Vector3, Path, PathOptions> t, OrientType orientType, Vector3 lookAtPosition, Transform lookAtTransform, float lookAhead, [Optional] Vector3? forwardDirection, [Optional] Vector3? up, bool stableZRotation = false)
		{
			return null;
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000294")]
		[Address(RVA = "0x3738470", Offset = "0x3737070", VA = "0x183738470")]
		private static void SetPathForwardDirection(this TweenerCore<Vector3, Path, PathOptions> t, [Optional] Vector3? forwardDirection, [Optional] Vector3? up)
		{
		}
	}
}
