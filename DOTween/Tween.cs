using System;
using System.Runtime.CompilerServices;
using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using Il2CppDummyDll;

namespace DG.Tweening
{
	// Token: 0x0200006F RID: 111
	[Token(Token = "0x200006F")]
	public abstract class Tween : ABSSequentiable
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000295 RID: 661 RVA: 0x00003258 File Offset: 0x00001458
		// (set) Token: 0x06000296 RID: 662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000004")]
		public bool isRelative
		{
			[Token(Token = "0x6000295")]
			[Address(RVA = "0x51CBE0", Offset = "0x51B7E0", VA = "0x18051CBE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000296")]
			[Address(RVA = "0x32FC4E0", Offset = "0x32FB0E0", VA = "0x1832FC4E0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000297 RID: 663 RVA: 0x00003270 File Offset: 0x00001470
		// (set) Token: 0x06000298 RID: 664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000005")]
		public bool active
		{
			[Token(Token = "0x6000297")]
			[Address(RVA = "0x3739000", Offset = "0x3737C00", VA = "0x183739000")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000298")]
			[Address(RVA = "0x37390F0", Offset = "0x3737CF0", VA = "0x1837390F0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000299 RID: 665 RVA: 0x00003288 File Offset: 0x00001488
		// (set) Token: 0x0600029A RID: 666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000006")]
		public float fullPosition
		{
			[Token(Token = "0x6000299")]
			[Address(RVA = "0x3739010", Offset = "0x3737C10", VA = "0x183739010")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600029A")]
			[Address(RVA = "0x3739100", Offset = "0x3737D00", VA = "0x183739100")]
			set
			{
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600029B RID: 667 RVA: 0x000032A0 File Offset: 0x000014A0
		[Token(Token = "0x17000007")]
		public bool hasLoops
		{
			[Token(Token = "0x600029B")]
			[Address(RVA = "0x37390B0", Offset = "0x3737CB0", VA = "0x1837390B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600029C RID: 668 RVA: 0x000032B8 File Offset: 0x000014B8
		// (set) Token: 0x0600029D RID: 669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000008")]
		public bool playedOnce
		{
			[Token(Token = "0x600029C")]
			[Address(RVA = "0x37390D0", Offset = "0x3737CD0", VA = "0x1837390D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600029D")]
			[Address(RVA = "0x3739130", Offset = "0x3737D30", VA = "0x183739130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600029E RID: 670 RVA: 0x000032D0 File Offset: 0x000014D0
		// (set) Token: 0x0600029F RID: 671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000009")]
		public float position
		{
			[Token(Token = "0x600029E")]
			[Address(RVA = "0x37390E0", Offset = "0x3737CE0", VA = "0x1837390E0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600029F")]
			[Address(RVA = "0x3739140", Offset = "0x3737D40", VA = "0x183739140")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x3738E50", Offset = "0x3737A50", VA = "0x183738E50", Slot = "4")]
		internal virtual void Reset()
		{
		}

		// Token: 0x060002A1 RID: 673
		[Token(Token = "0x60002A1")]
		internal abstract bool Validate();

		// Token: 0x060002A2 RID: 674 RVA: 0x000032E8 File Offset: 0x000014E8
		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x738E20", Offset = "0x737A20", VA = "0x180738E20", Slot = "6")]
		internal virtual float UpdateDelay(float elapsed)
		{
			return 0f;
		}

		// Token: 0x060002A3 RID: 675
		[Token(Token = "0x60002A3")]
		internal abstract bool Startup();

		// Token: 0x060002A4 RID: 676
		[Token(Token = "0x60002A4")]
		internal abstract bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode, UpdateNotice updateNotice);

		// Token: 0x060002A5 RID: 677 RVA: 0x00003300 File Offset: 0x00001500
		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x37388B0", Offset = "0x37374B0", VA = "0x1837388B0")]
		internal static bool DoGoto(Tween t, float toPosition, int toCompletedLoops, UpdateMode updateMode)
		{
			return default(bool);
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00003318 File Offset: 0x00001518
		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x3738CC0", Offset = "0x37378C0", VA = "0x183738CC0")]
		internal static bool OnTweenCallback(TweenCallback callback, Tween t)
		{
			return default(bool);
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00003330 File Offset: 0x00001530
		[Token(Token = "0x60002A7")]
		internal static bool OnTweenCallback<T>(TweenCallback<T> callback, Tween t, T param)
		{
			return default(bool);
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x3738FD0", Offset = "0x3737BD0", VA = "0x183738FD0")]
		protected Tween()
		{
		}

		// Token: 0x0400011B RID: 283
		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0x28")]
		public float timeScale;

		// Token: 0x0400011C RID: 284
		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x2C")]
		public bool isBackwards;

		// Token: 0x0400011D RID: 285
		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x2D")]
		internal bool isInverted;

		// Token: 0x0400011E RID: 286
		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x30")]
		public object id;

		// Token: 0x0400011F RID: 287
		[Token(Token = "0x400011F")]
		[FieldOffset(Offset = "0x38")]
		public string stringId;

		// Token: 0x04000120 RID: 288
		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0x40")]
		public int intId;

		// Token: 0x04000121 RID: 289
		[Token(Token = "0x4000121")]
		[FieldOffset(Offset = "0x48")]
		public object target;

		// Token: 0x04000122 RID: 290
		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0x50")]
		internal UpdateType updateType;

		// Token: 0x04000123 RID: 291
		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x54")]
		internal bool isIndependentUpdate;

		// Token: 0x04000124 RID: 292
		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x58")]
		public TweenCallback onPlay;

		// Token: 0x04000125 RID: 293
		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x60")]
		public TweenCallback onPause;

		// Token: 0x04000126 RID: 294
		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0x68")]
		public TweenCallback onRewind;

		// Token: 0x04000127 RID: 295
		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0x70")]
		public TweenCallback onUpdate;

		// Token: 0x04000128 RID: 296
		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x78")]
		public TweenCallback onStepComplete;

		// Token: 0x04000129 RID: 297
		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0x80")]
		public TweenCallback onComplete;

		// Token: 0x0400012A RID: 298
		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x88")]
		public TweenCallback onKill;

		// Token: 0x0400012B RID: 299
		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0x90")]
		public TweenCallback<int> onWaypointChange;

		// Token: 0x0400012C RID: 300
		[Token(Token = "0x400012C")]
		[FieldOffset(Offset = "0x98")]
		internal bool isFrom;

		// Token: 0x0400012D RID: 301
		[Token(Token = "0x400012D")]
		[FieldOffset(Offset = "0x99")]
		internal bool isBlendable;

		// Token: 0x0400012E RID: 302
		[Token(Token = "0x400012E")]
		[FieldOffset(Offset = "0x9A")]
		internal bool isRecyclable;

		// Token: 0x0400012F RID: 303
		[Token(Token = "0x400012F")]
		[FieldOffset(Offset = "0x9B")]
		internal bool isSpeedBased;

		// Token: 0x04000130 RID: 304
		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0x9C")]
		internal bool autoKill;

		// Token: 0x04000131 RID: 305
		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0xA0")]
		internal float duration;

		// Token: 0x04000132 RID: 306
		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0xA4")]
		internal int loops;

		// Token: 0x04000133 RID: 307
		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0xA8")]
		internal LoopType loopType;

		// Token: 0x04000134 RID: 308
		[Token(Token = "0x4000134")]
		[FieldOffset(Offset = "0xAC")]
		internal float delay;

		// Token: 0x04000136 RID: 310
		[Token(Token = "0x4000136")]
		[FieldOffset(Offset = "0xB4")]
		internal Ease easeType;

		// Token: 0x04000137 RID: 311
		[Token(Token = "0x4000137")]
		[FieldOffset(Offset = "0xB8")]
		internal EaseFunction customEase;

		// Token: 0x04000138 RID: 312
		[Token(Token = "0x4000138")]
		[FieldOffset(Offset = "0xC0")]
		public float easeOvershootOrAmplitude;

		// Token: 0x04000139 RID: 313
		[Token(Token = "0x4000139")]
		[FieldOffset(Offset = "0xC4")]
		public float easePeriod;

		// Token: 0x0400013A RID: 314
		[Token(Token = "0x400013A")]
		[FieldOffset(Offset = "0xC8")]
		public string debugTargetId;

		// Token: 0x0400013B RID: 315
		[Token(Token = "0x400013B")]
		[FieldOffset(Offset = "0xD0")]
		internal Type typeofT1;

		// Token: 0x0400013C RID: 316
		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0xD8")]
		internal Type typeofT2;

		// Token: 0x0400013D RID: 317
		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0xE0")]
		internal Type typeofTPlugOptions;

		// Token: 0x0400013F RID: 319
		[Token(Token = "0x400013F")]
		[FieldOffset(Offset = "0xE9")]
		internal bool isSequenced;

		// Token: 0x04000140 RID: 320
		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0xF0")]
		internal Sequence sequenceParent;

		// Token: 0x04000141 RID: 321
		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0xF8")]
		internal int activeId;

		// Token: 0x04000142 RID: 322
		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0xFC")]
		internal SpecialStartupMode specialStartupMode;

		// Token: 0x04000143 RID: 323
		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0x100")]
		internal bool creationLocked;

		// Token: 0x04000144 RID: 324
		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0x101")]
		internal bool startupDone;

		// Token: 0x04000147 RID: 327
		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0x108")]
		internal float fullDuration;

		// Token: 0x04000148 RID: 328
		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0x10C")]
		internal int completedLoops;

		// Token: 0x04000149 RID: 329
		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0x110")]
		internal bool isPlaying;

		// Token: 0x0400014A RID: 330
		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0x111")]
		internal bool isComplete;

		// Token: 0x0400014B RID: 331
		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0x114")]
		internal float elapsedDelay;

		// Token: 0x0400014C RID: 332
		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0x118")]
		internal bool delayComplete;

		// Token: 0x0400014D RID: 333
		[Token(Token = "0x400014D")]
		[FieldOffset(Offset = "0x11C")]
		internal int miscInt;
	}
}
