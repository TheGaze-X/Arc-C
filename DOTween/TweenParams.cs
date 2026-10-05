using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace DG.Tweening
{
	// Token: 0x0200006C RID: 108
	[Token(Token = "0x200006C")]
	public class TweenParams
	{
		// Token: 0x0600022A RID: 554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022A")]
		[Address(RVA = "0x37370F0", Offset = "0x3735CF0", VA = "0x1837370F0")]
		public TweenParams()
		{
		}

		// Token: 0x0600022B RID: 555 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600022B")]
		[Address(RVA = "0x3736830", Offset = "0x3735430", VA = "0x183736830")]
		public TweenParams Clear()
		{
			return null;
		}

		// Token: 0x0600022C RID: 556 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600022C")]
		[Address(RVA = "0x3736AF0", Offset = "0x37356F0", VA = "0x183736AF0")]
		public TweenParams SetAutoKill(bool autoKillOnCompletion = true)
		{
			return null;
		}

		// Token: 0x0600022D RID: 557 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600022D")]
		[Address(RVA = "0x3736D30", Offset = "0x3735930", VA = "0x183736D30")]
		public TweenParams SetId(object objectId)
		{
			return null;
		}

		// Token: 0x0600022E RID: 558 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600022E")]
		[Address(RVA = "0x17967C0", Offset = "0x17953C0", VA = "0x1817967C0")]
		public TweenParams SetId(string stringId)
		{
			return null;
		}

		// Token: 0x0600022F RID: 559 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600022F")]
		[Address(RVA = "0x3736D50", Offset = "0x3735950", VA = "0x183736D50")]
		public TweenParams SetId(int intId)
		{
			return null;
		}

		// Token: 0x06000230 RID: 560 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000230")]
		[Address(RVA = "0x3736E20", Offset = "0x3735A20", VA = "0x183736E20")]
		public TweenParams SetTarget(object target)
		{
			return null;
		}

		// Token: 0x06000231 RID: 561 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000231")]
		[Address(RVA = "0x3736D60", Offset = "0x3735960", VA = "0x183736D60")]
		public TweenParams SetLoops(int loops, [Optional] LoopType? loopType)
		{
			return null;
		}

		// Token: 0x06000232 RID: 562 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000232")]
		[Address(RVA = "0x3736BE0", Offset = "0x37357E0", VA = "0x183736BE0")]
		public TweenParams SetEase(Ease ease, [Optional] float? overshootOrAmplitude, [Optional] float? period)
		{
			return null;
		}

		// Token: 0x06000233 RID: 563 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000233")]
		[Address(RVA = "0x3736B10", Offset = "0x3735710", VA = "0x183736B10")]
		public TweenParams SetEase(AnimationCurve animCurve)
		{
			return null;
		}

		// Token: 0x06000234 RID: 564 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000234")]
		[Address(RVA = "0x3736D00", Offset = "0x3735900", VA = "0x183736D00")]
		public TweenParams SetEase(EaseFunction customEase)
		{
			return null;
		}

		// Token: 0x06000235 RID: 565 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000235")]
		[Address(RVA = "0x3736DF0", Offset = "0x37359F0", VA = "0x183736DF0")]
		public TweenParams SetRecyclable(bool recyclable = true)
		{
			return null;
		}

		// Token: 0x06000236 RID: 566 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000236")]
		[Address(RVA = "0x3736E50", Offset = "0x3735A50", VA = "0x183736E50")]
		public TweenParams SetUpdate(bool isIndependentUpdate)
		{
			return null;
		}

		// Token: 0x06000237 RID: 567 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000237")]
		[Address(RVA = "0x3736E40", Offset = "0x3735A40", VA = "0x183736E40")]
		public TweenParams SetUpdate(UpdateType updateType, bool isIndependentUpdate = false)
		{
			return null;
		}

		// Token: 0x06000238 RID: 568 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000238")]
		[Address(RVA = "0x3736A70", Offset = "0x3735670", VA = "0x183736A70")]
		public TweenParams OnStart(TweenCallback action)
		{
			return null;
		}

		// Token: 0x06000239 RID: 569 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000239")]
		[Address(RVA = "0x3736A30", Offset = "0x3735630", VA = "0x183736A30")]
		public TweenParams OnPlay(TweenCallback action)
		{
			return null;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600023A")]
		[Address(RVA = "0x3736A50", Offset = "0x3735650", VA = "0x183736A50")]
		public TweenParams OnRewind(TweenCallback action)
		{
			return null;
		}

		// Token: 0x0600023B RID: 571 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600023B")]
		[Address(RVA = "0x3736AB0", Offset = "0x37356B0", VA = "0x183736AB0")]
		public TweenParams OnUpdate(TweenCallback action)
		{
			return null;
		}

		// Token: 0x0600023C RID: 572 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600023C")]
		[Address(RVA = "0x3736A90", Offset = "0x3735690", VA = "0x183736A90")]
		public TweenParams OnStepComplete(TweenCallback action)
		{
			return null;
		}

		// Token: 0x0600023D RID: 573 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600023D")]
		[Address(RVA = "0x37369F0", Offset = "0x37355F0", VA = "0x1837369F0")]
		public TweenParams OnComplete(TweenCallback action)
		{
			return null;
		}

		// Token: 0x0600023E RID: 574 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600023E")]
		[Address(RVA = "0x3736A10", Offset = "0x3735610", VA = "0x183736A10")]
		public TweenParams OnKill(TweenCallback action)
		{
			return null;
		}

		// Token: 0x0600023F RID: 575 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600023F")]
		[Address(RVA = "0x3736AD0", Offset = "0x37356D0", VA = "0x183736AD0")]
		public TweenParams OnWaypointChange(TweenCallback<int> action)
		{
			return null;
		}

		// Token: 0x06000240 RID: 576 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000240")]
		[Address(RVA = "0x3736B00", Offset = "0x3735700", VA = "0x183736B00")]
		public TweenParams SetDelay(float delay)
		{
			return null;
		}

		// Token: 0x06000241 RID: 577 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000241")]
		[Address(RVA = "0x3736E00", Offset = "0x3735A00", VA = "0x183736E00")]
		public TweenParams SetRelative(bool isRelative = true)
		{
			return null;
		}

		// Token: 0x06000242 RID: 578 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000242")]
		[Address(RVA = "0x3736E10", Offset = "0x3735A10", VA = "0x183736E10")]
		public TweenParams SetSpeedBased(bool isSpeedBased = true)
		{
			return null;
		}

		// Token: 0x040000FD RID: 253
		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly TweenParams Params;

		// Token: 0x040000FE RID: 254
		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal object id;

		// Token: 0x040000FF RID: 255
		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal string stringId;

		// Token: 0x04000100 RID: 256
		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal int intId;

		// Token: 0x04000101 RID: 257
		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal object target;

		// Token: 0x04000102 RID: 258
		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal UpdateType updateType;

		// Token: 0x04000103 RID: 259
		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		internal bool isIndependentUpdate;

		// Token: 0x04000104 RID: 260
		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal TweenCallback onStart;

		// Token: 0x04000105 RID: 261
		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal TweenCallback onPlay;

		// Token: 0x04000106 RID: 262
		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal TweenCallback onRewind;

		// Token: 0x04000107 RID: 263
		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal TweenCallback onUpdate;

		// Token: 0x04000108 RID: 264
		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal TweenCallback onStepComplete;

		// Token: 0x04000109 RID: 265
		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		internal TweenCallback onComplete;

		// Token: 0x0400010A RID: 266
		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		internal TweenCallback onKill;

		// Token: 0x0400010B RID: 267
		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		internal TweenCallback<int> onWaypointChange;

		// Token: 0x0400010C RID: 268
		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		internal bool isRecyclable;

		// Token: 0x0400010D RID: 269
		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
		internal bool isSpeedBased;

		// Token: 0x0400010E RID: 270
		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7A")]
		internal bool autoKill;

		// Token: 0x0400010F RID: 271
		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		internal int loops;

		// Token: 0x04000110 RID: 272
		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		internal LoopType loopType;

		// Token: 0x04000111 RID: 273
		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		internal float delay;

		// Token: 0x04000112 RID: 274
		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		internal bool isRelative;

		// Token: 0x04000113 RID: 275
		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		internal Ease easeType;

		// Token: 0x04000114 RID: 276
		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		internal EaseFunction customEase;

		// Token: 0x04000115 RID: 277
		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		internal float easeOvershootOrAmplitude;

		// Token: 0x04000116 RID: 278
		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		internal float easePeriod;
	}
}
