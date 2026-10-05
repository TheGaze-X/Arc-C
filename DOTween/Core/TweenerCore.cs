using System;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;

namespace DG.Tweening.Core
{
	// Token: 0x020000B9 RID: 185
	[Token(Token = "0x20000B9")]
	public class TweenerCore<T1, T2, TPlugOptions> : Tweener where TPlugOptions : struct, IPlugOptions
	{
		// Token: 0x06000460 RID: 1120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000460")]
		internal TweenerCore()
		{
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000461")]
		public override Tweener ChangeStartValue(object newStartValue, float newDuration = -1f)
		{
			return null;
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000462")]
		public override Tweener ChangeEndValue(object newEndValue, bool snapStartValue)
		{
			return null;
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000463")]
		public override Tweener ChangeEndValue(object newEndValue, float newDuration = -1f, bool snapStartValue = false)
		{
			return null;
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000464")]
		public override Tweener ChangeValues(object newStartValue, object newEndValue, float newDuration = -1f)
		{
			return null;
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000465")]
		public TweenerCore<T1, T2, TPlugOptions> ChangeStartValue(T2 newStartValue, float newDuration = -1f)
		{
			return null;
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000466")]
		public TweenerCore<T1, T2, TPlugOptions> ChangeEndValue(T2 newEndValue, bool snapStartValue)
		{
			return null;
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000467")]
		public TweenerCore<T1, T2, TPlugOptions> ChangeEndValue(T2 newEndValue, float newDuration = -1f, bool snapStartValue = false)
		{
			return null;
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000468")]
		public TweenerCore<T1, T2, TPlugOptions> ChangeValues(T2 newStartValue, T2 newEndValue, float newDuration = -1f)
		{
			return null;
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000469")]
		internal override Tweener SetFrom(bool relative)
		{
			return null;
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600046A")]
		internal Tweener SetFrom(T2 fromValue, bool setImmediately, bool relative)
		{
			return null;
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600046B")]
		internal sealed override void Reset()
		{
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x00003C48 File Offset: 0x00001E48
		[Token(Token = "0x600046C")]
		internal override bool Validate()
		{
			return default(bool);
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00003C60 File Offset: 0x00001E60
		[Token(Token = "0x600046D")]
		private bool ValidateChangeValueType(Type newType, out bool isColor32ToColor)
		{
			return default(bool);
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00003C78 File Offset: 0x00001E78
		[Token(Token = "0x600046E")]
		internal override float UpdateDelay(float elapsed)
		{
			return 0f;
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x00003C90 File Offset: 0x00001E90
		[Token(Token = "0x600046F")]
		internal override bool Startup()
		{
			return default(bool);
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x00003CA8 File Offset: 0x00001EA8
		[Token(Token = "0x6000470")]
		internal override bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode, UpdateNotice updateNotice)
		{
			return default(bool);
		}

		// Token: 0x0400024E RID: 590
		[Token(Token = "0x400024E")]
		[FieldOffset(Offset = "0x0")]
		public T2 startValue;

		// Token: 0x0400024F RID: 591
		[Token(Token = "0x400024F")]
		[FieldOffset(Offset = "0x0")]
		public T2 endValue;

		// Token: 0x04000250 RID: 592
		[Token(Token = "0x4000250")]
		[FieldOffset(Offset = "0x0")]
		public T2 changeValue;

		// Token: 0x04000251 RID: 593
		[Token(Token = "0x4000251")]
		[FieldOffset(Offset = "0x0")]
		public TPlugOptions plugOptions;

		// Token: 0x04000252 RID: 594
		[Token(Token = "0x4000252")]
		[FieldOffset(Offset = "0x0")]
		public DOGetter<T1> getter;

		// Token: 0x04000253 RID: 595
		[Token(Token = "0x4000253")]
		[FieldOffset(Offset = "0x0")]
		public DOSetter<T1> setter;

		// Token: 0x04000254 RID: 596
		[Token(Token = "0x4000254")]
		[FieldOffset(Offset = "0x0")]
		internal ABSTweenPlugin<T1, T2, TPlugOptions> tweenPlugin;

		// Token: 0x04000255 RID: 597
		[Token(Token = "0x4000255")]
		private const string _TxtCantChangeSequencedValues = "You cannot change the values of a tween contained inside a Sequence";

		// Token: 0x04000256 RID: 598
		[Token(Token = "0x4000256")]
		[FieldOffset(Offset = "0x0")]
		private Type _colorType;

		// Token: 0x04000257 RID: 599
		[Token(Token = "0x4000257")]
		[FieldOffset(Offset = "0x0")]
		private Type _color32Type;
	}
}
