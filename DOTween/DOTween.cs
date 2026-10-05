using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;
using UnityEngine;

namespace DG.Tweening
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	public class DOTween
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000014 RID: 20 RVA: 0x000020B8 File Offset: 0x000002B8
		// (set) Token: 0x06000015 RID: 21 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000001")]
		public static LogBehaviour logBehaviour
		{
			[Token(Token = "0x6000014")]
			[Address(RVA = "0x3724D80", Offset = "0x3723980", VA = "0x183724D80")]
			get
			{
				return LogBehaviour.Default;
			}
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x3724EC0", Offset = "0x3723AC0", VA = "0x183724EC0")]
			set
			{
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000016 RID: 22 RVA: 0x000020D0 File Offset: 0x000002D0
		// (set) Token: 0x06000017 RID: 23 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000002")]
		public static bool debugStoreTargetId
		{
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x3724C10", Offset = "0x3723810", VA = "0x183724C10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x3724DD0", Offset = "0x37239D0", VA = "0x183724DD0")]
			set
			{
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000018 RID: 24 RVA: 0x000020E8 File Offset: 0x000002E8
		// (set) Token: 0x06000019 RID: 25 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000003")]
		internal static bool isQuitting
		{
			[Token(Token = "0x6000018")]
			[Address(RVA = "0x3724CB0", Offset = "0x37238B0", VA = "0x183724CB0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000019")]
			[Address(RVA = "0x3724E30", Offset = "0x3723A30", VA = "0x183724E30")]
			set
			{
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x37215D0", Offset = "0x37201D0", VA = "0x1837215D0")]
		public static IDOTweenInit Init([Optional] bool? recycleAllByDefault, [Optional] bool? useSafeMode, [Optional] LogBehaviour? logBehaviour)
		{
			return null;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x37201F0", Offset = "0x371EDF0", VA = "0x1837201F0")]
		private static void AutoInit()
		{
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x3720D50", Offset = "0x371F950", VA = "0x183720D50")]
		private static IDOTweenInit Init(DOTweenSettings settings, bool? recycleAllByDefault, bool? useSafeMode, LogBehaviour? logBehaviour)
		{
			return null;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x3722C30", Offset = "0x3721830", VA = "0x183722C30")]
		public static void SetTweensCapacity(int tweenersCapacity, int sequencesCapacity)
		{
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x3720650", Offset = "0x371F250", VA = "0x183720650")]
		public static void Clear(bool destroy = false)
		{
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x3720350", Offset = "0x371EF50", VA = "0x183720350")]
		internal static void Clear(bool destroy, bool isApplicationQuitting)
		{
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x3720310", Offset = "0x371EF10", VA = "0x183720310")]
		public static void ClearCachedTweens()
		{
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002100 File Offset: 0x00000300
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x3724960", Offset = "0x3723560", VA = "0x183724960")]
		public static int Validate()
		{
			return 0;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x3721C20", Offset = "0x3720820", VA = "0x183721C20")]
		public static void ManualUpdate(float deltaTime, float unscaledDeltaTime)
		{
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x3723C30", Offset = "0x3722830", VA = "0x183723C30")]
		public static TweenerCore<float, float, FloatOptions> To(DOGetter<float> getter, DOSetter<float> setter, float endValue, float duration)
		{
			return null;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x3724420", Offset = "0x3723020", VA = "0x183724420")]
		public static TweenerCore<double, double, NoOptions> To(DOGetter<double> getter, DOSetter<double> setter, double endValue, float duration)
		{
			return null;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x37242D0", Offset = "0x3722ED0", VA = "0x1837242D0")]
		public static TweenerCore<int, int, NoOptions> To(DOGetter<int> getter, DOSetter<int> setter, int endValue, float duration)
		{
			return null;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x3723D80", Offset = "0x3722980", VA = "0x183723D80")]
		public static TweenerCore<uint, uint, UintOptions> To(DOGetter<uint> getter, DOSetter<uint> setter, uint endValue, float duration)
		{
			return null;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x3723A30", Offset = "0x3722630", VA = "0x183723A30")]
		public static TweenerCore<long, long, NoOptions> To(DOGetter<long> getter, DOSetter<long> setter, long endValue, float duration)
		{
			return null;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x37240B0", Offset = "0x3722CB0", VA = "0x1837240B0")]
		public static TweenerCore<ulong, ulong, NoOptions> To(DOGetter<ulong> getter, DOSetter<ulong> setter, ulong endValue, float duration)
		{
			return null;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x3723E20", Offset = "0x3722A20", VA = "0x183723E20")]
		public static TweenerCore<string, string, StringOptions> To(DOGetter<string> getter, DOSetter<string> setter, string endValue, float duration)
		{
			return null;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x3724010", Offset = "0x3722C10", VA = "0x183724010")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> To(DOGetter<Vector2> getter, DOSetter<Vector2> setter, Vector2 endValue, float duration)
		{
			return null;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x3723AD0", Offset = "0x37226D0", VA = "0x183723AD0")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> To(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3 endValue, float duration)
		{
			return null;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x37244C0", Offset = "0x37230C0", VA = "0x1837244C0")]
		public static TweenerCore<Vector4, Vector4, VectorOptions> To(DOGetter<Vector4> getter, DOSetter<Vector4> setter, Vector4 endValue, float duration)
		{
			return null;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x3723B80", Offset = "0x3722780", VA = "0x183723B80")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> To(DOGetter<Quaternion> getter, DOSetter<Quaternion> setter, Vector3 endValue, float duration)
		{
			return null;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x3723CD0", Offset = "0x37228D0", VA = "0x183723CD0")]
		public static TweenerCore<Color, Color, ColorOptions> To(DOGetter<Color> getter, DOSetter<Color> setter, Color endValue, float duration)
		{
			return null;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x3723F60", Offset = "0x3722B60", VA = "0x183723F60")]
		public static TweenerCore<Rect, Rect, RectOptions> To(DOGetter<Rect> getter, DOSetter<Rect> setter, Rect endValue, float duration)
		{
			return null;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x3723EC0", Offset = "0x3722AC0", VA = "0x183723EC0")]
		public static Tweener To(DOGetter<RectOffset> getter, DOSetter<RectOffset> setter, RectOffset endValue, float duration)
		{
			return null;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000031")]
		public static TweenerCore<T1, T2, TPlugOptions> To<T1, T2, TPlugOptions>(ABSTweenPlugin<T1, T2, TPlugOptions> plugin, DOGetter<T1> getter, DOSetter<T1> setter, T2 endValue, float duration) where TPlugOptions : struct, IPlugOptions
		{
			return null;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x3723950", Offset = "0x3722550", VA = "0x183723950")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> ToAxis(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float endValue, float duration, AxisConstraint axisConstraint = AxisConstraint.X)
		{
			return null;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x3723670", Offset = "0x3722270", VA = "0x183723670")]
		public static TweenerCore<Color, Color, ColorOptions> ToAlpha(DOGetter<Color> getter, DOSetter<Color> setter, float endValue, float duration)
		{
			return null;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x3724150", Offset = "0x3722D50", VA = "0x183724150")]
		public static Tweener To(DOSetter<float> setter, float startValue, float endValue, float duration)
		{
			return null;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x37223A0", Offset = "0x3720FA0", VA = "0x1837223A0")]
		public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Punch(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3 direction, float duration, int vibrato = 10, float elasticity = 1f)
		{
			return null;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x3723480", Offset = "0x3722080", VA = "0x183723480")]
		public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, float strength = 3f, int vibrato = 10, float randomness = 90f, bool ignoreZAxis = true, bool fadeOut = true, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full)
		{
			return null;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x37233A0", Offset = "0x3721FA0", VA = "0x1837233A0")]
		public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, Vector3 strength, int vibrato = 10, float randomness = 90f, bool fadeOut = true, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full)
		{
			return null;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x3722C90", Offset = "0x3721890", VA = "0x183722C90")]
		private static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, Vector3 strength, int vibrato, float randomness, bool ignoreZAxis, bool vectorBased, bool fadeOut, ShakeRandomnessMode randomnessMode)
		{
			return null;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x3723740", Offset = "0x3722340", VA = "0x183723740")]
		public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> ToArray(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3[] endValues, float[] durations)
		{
			return null;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x3724370", Offset = "0x3722F70", VA = "0x183724370")]
		internal static TweenerCore<Color2, Color2, ColorOptions> To(DOGetter<Color2> getter, DOSetter<Color2> setter, Color2 endValue, float duration)
		{
			return null;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x3722A30", Offset = "0x3721630", VA = "0x183722A30")]
		public static Sequence Sequence()
		{
			return null;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x3722BC0", Offset = "0x37217C0", VA = "0x183722BC0")]
		public static Sequence Sequence(object target)
		{
			return null;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002118 File Offset: 0x00000318
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x37206A0", Offset = "0x371F2A0", VA = "0x1837206A0")]
		public static int CompleteAll(bool withCallbacks = false)
		{
			return 0;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002130 File Offset: 0x00000330
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x3720900", Offset = "0x371F500", VA = "0x183720900")]
		public static int Complete(object targetOrId, bool withCallbacks = false)
		{
			return 0;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002148 File Offset: 0x00000348
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x3720800", Offset = "0x371F400", VA = "0x183720800")]
		internal static int CompleteAndReturnKilledTot()
		{
			return 0;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002160 File Offset: 0x00000360
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x3720780", Offset = "0x371F380", VA = "0x183720780")]
		internal static int CompleteAndReturnKilledTot(object targetOrId)
		{
			return 0;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002178 File Offset: 0x00000378
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x3720870", Offset = "0x371F470", VA = "0x183720870")]
		internal static int CompleteAndReturnKilledTot(object target, object id)
		{
			return 0;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002190 File Offset: 0x00000390
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x3720710", Offset = "0x371F310", VA = "0x183720710")]
		internal static int CompleteAndReturnKilledTotExceptFor(params object[] excludeTargetsOrIds)
		{
			return 0;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000021A8 File Offset: 0x000003A8
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x3720990", Offset = "0x371F590", VA = "0x183720990")]
		public static int FlipAll()
		{
			return 0;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000021C0 File Offset: 0x000003C0
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x3720A00", Offset = "0x371F600", VA = "0x183720A00")]
		public static int Flip(object targetOrId)
		{
			return 0;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000021D8 File Offset: 0x000003D8
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x3720A80", Offset = "0x371F680", VA = "0x183720A80")]
		public static int GotoAll(float to, bool andPlay = false)
		{
			return 0;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000021F0 File Offset: 0x000003F0
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x3720B00", Offset = "0x371F700", VA = "0x183720B00")]
		public static int Goto(object targetOrId, float to, bool andPlay = false)
		{
			return 0;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002208 File Offset: 0x00000408
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x3721920", Offset = "0x3720520", VA = "0x183721920")]
		public static int KillAll(bool complete = false)
		{
			return 0;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002220 File Offset: 0x00000420
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x37217B0", Offset = "0x37203B0", VA = "0x1837217B0")]
		public static int KillAll(bool complete, params object[] idsOrTargetsToExclude)
		{
			return 0;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002238 File Offset: 0x00000438
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x3721AF0", Offset = "0x37206F0", VA = "0x183721AF0")]
		public static int Kill(object targetOrId, bool complete = false)
		{
			return 0;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002250 File Offset: 0x00000450
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x37219A0", Offset = "0x37205A0", VA = "0x1837219A0")]
		public static int Kill(object target, object id, bool complete = false)
		{
			return 0;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002268 File Offset: 0x00000468
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x3721D30", Offset = "0x3720930", VA = "0x183721D30")]
		public static int PauseAll()
		{
			return 0;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002280 File Offset: 0x00000480
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x3721DA0", Offset = "0x37209A0", VA = "0x183721DA0")]
		public static int Pause(object targetOrId)
		{
			return 0;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002298 File Offset: 0x00000498
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x3721EA0", Offset = "0x3720AA0", VA = "0x183721EA0")]
		public static int PlayAll()
		{
			return 0;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000022B0 File Offset: 0x000004B0
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x3722210", Offset = "0x3720E10", VA = "0x183722210")]
		public static int Play(object targetOrId)
		{
			return 0;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000022C8 File Offset: 0x000004C8
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x3722290", Offset = "0x3720E90", VA = "0x183722290")]
		public static int Play(object target, object id)
		{
			return 0;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000022E0 File Offset: 0x000004E0
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x3721F10", Offset = "0x3720B10", VA = "0x183721F10")]
		public static int PlayBackwardsAll()
		{
			return 0;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000022F8 File Offset: 0x000004F8
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x3721F80", Offset = "0x3720B80", VA = "0x183721F80")]
		public static int PlayBackwards(object targetOrId)
		{
			return 0;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002310 File Offset: 0x00000510
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x3722000", Offset = "0x3720C00", VA = "0x183722000")]
		public static int PlayBackwards(object target, object id)
		{
			return 0;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002328 File Offset: 0x00000528
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x3722090", Offset = "0x3720C90", VA = "0x183722090")]
		public static int PlayForwardAll()
		{
			return 0;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002340 File Offset: 0x00000540
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x3722100", Offset = "0x3720D00", VA = "0x183722100")]
		public static int PlayForward(object targetOrId)
		{
			return 0;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002358 File Offset: 0x00000558
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x3722180", Offset = "0x3720D80", VA = "0x183722180")]
		public static int PlayForward(object target, object id)
		{
			return 0;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002370 File Offset: 0x00000570
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x3722780", Offset = "0x3721380", VA = "0x183722780")]
		public static int RestartAll(bool includeDelay = true)
		{
			return 0;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002388 File Offset: 0x00000588
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x3722890", Offset = "0x3721490", VA = "0x183722890")]
		public static int Restart(object targetOrId, bool includeDelay = true, float changeDelayTo = -1f)
		{
			return 0;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000023A0 File Offset: 0x000005A0
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x37227F0", Offset = "0x37213F0", VA = "0x1837227F0")]
		public static int Restart(object target, object id, bool includeDelay = true, float changeDelayTo = -1f)
		{
			return 0;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000023B8 File Offset: 0x000005B8
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x3722930", Offset = "0x3721530", VA = "0x183722930")]
		public static int RewindAll(bool includeDelay = true)
		{
			return 0;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000023D0 File Offset: 0x000005D0
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x37229A0", Offset = "0x37215A0", VA = "0x1837229A0")]
		public static int Rewind(object targetOrId, bool includeDelay = true)
		{
			return 0;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000023E8 File Offset: 0x000005E8
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x3723580", Offset = "0x3722180", VA = "0x183723580")]
		public static int SmoothRewindAll()
		{
			return 0;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002400 File Offset: 0x00000600
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x37235F0", Offset = "0x37221F0", VA = "0x1837235F0")]
		public static int SmoothRewind(object targetOrId)
		{
			return 0;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002418 File Offset: 0x00000618
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x3724570", Offset = "0x3723170", VA = "0x183724570")]
		public static int TogglePauseAll()
		{
			return 0;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002430 File Offset: 0x00000630
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x37245E0", Offset = "0x37231E0", VA = "0x1837245E0")]
		public static int TogglePause(object targetOrId)
		{
			return 0;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002448 File Offset: 0x00000648
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x3721730", Offset = "0x3720330", VA = "0x183721730")]
		public static bool IsTweening(object targetOrId, bool alsoCheckIfIsPlaying = false)
		{
			return default(bool);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002460 File Offset: 0x00000660
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x3724700", Offset = "0x3723300", VA = "0x183724700")]
		public static int TotalActiveTweens()
		{
			return 0;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002478 File Offset: 0x00000678
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x37246B0", Offset = "0x37232B0", VA = "0x1837246B0")]
		public static int TotalActiveTweeners()
		{
			return 0;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002490 File Offset: 0x00000690
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x3724660", Offset = "0x3723260", VA = "0x183724660")]
		public static int TotalActiveSequences()
		{
			return 0;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000024A8 File Offset: 0x000006A8
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x3724750", Offset = "0x3723350", VA = "0x183724750")]
		public static int TotalPlayingTweens()
		{
			return 0;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000024C0 File Offset: 0x000006C0
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x3724790", Offset = "0x3723390", VA = "0x183724790")]
		public static int TotalTweensById(object id, bool playingOnly = false)
		{
			return 0;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x3722320", Offset = "0x3720F20", VA = "0x183722320")]
		public static List<Tween> PlayingTweens([Optional] List<Tween> fillableList)
		{
			return null;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x3721E20", Offset = "0x3720A20", VA = "0x183721E20")]
		public static List<Tween> PausedTweens([Optional] List<Tween> fillableList)
		{
			return null;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x3724800", Offset = "0x3723400", VA = "0x183724800")]
		public static List<Tween> TweensById(object id, bool playingOnly = false, [Optional] List<Tween> fillableList)
		{
			return null;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x37248C0", Offset = "0x37234C0", VA = "0x1837248C0")]
		public static List<Tween> TweensByTarget(object target, bool playingOnly = false, [Optional] List<Tween> fillableList)
		{
			return null;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x3720BA0", Offset = "0x371F7A0", VA = "0x183720BA0")]
		private static void InitCheck()
		{
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600006A")]
		private static TweenerCore<T1, T2, TPlugOptions> ApplyTo<T1, T2, TPlugOptions>(DOGetter<T1> getter, DOSetter<T1> setter, T2 endValue, float duration, [Optional] ABSTweenPlugin<T1, T2, TPlugOptions> plugin) where TPlugOptions : struct, IPlugOptions
		{
			return null;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public DOTween()
		{
		}

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly string Version;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static bool useSafeMode;

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static SafeModeLogBehaviour safeModeLogBehaviour;

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static NestedTweenFailureBehaviour nestedTweenFailureBehaviour;

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static bool showUnityEditorReport;

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static float timeScale;

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public static float unscaledTimeScale;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static bool useSmoothDeltaTime;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public static float maxSmoothUnscaledTime;

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal static RewindCallbackMode rewindCallbackMode;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private static LogBehaviour _logBehaviour;

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static Func<LogType, object, bool> onWillLog;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static bool drawGizmos;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public static bool debugMode;

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		private static bool _fooDebugStoreTargetId;

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public static UpdateType defaultUpdateType;

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static bool defaultTimeScaleIndependent;

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public static AutoPlay defaultAutoPlay;

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static bool defaultAutoKill;

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public static LoopType defaultLoopType;

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static bool defaultRecyclable;

		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public static Ease defaultEaseType;

		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static float defaultEaseOvershootOrAmplitude;

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public static float defaultEasePeriod;

		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static DOTweenComponent instance;

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static bool _foo_isQuitting;

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		internal static int maxActiveTweenersReached;

		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		internal static int maxActiveSequencesReached;

		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		internal static SafeModeReport safeModeReport;

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		internal static readonly List<TweenCallback> GizmosDelegates;

		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		internal static bool initialized;

		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private static int _isQuittingFrame;
	}
}
