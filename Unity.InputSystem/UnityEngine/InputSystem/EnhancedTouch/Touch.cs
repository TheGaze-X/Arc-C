using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.EnhancedTouch
{
	// Token: 0x02000148 RID: 328
	[Token(Token = "0x2000148")]
	public struct Touch : IEquatable<Touch>
	{
		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06000E58 RID: 3672 RVA: 0x000071B8 File Offset: 0x000053B8
		[Token(Token = "0x170003CC")]
		public bool valid
		{
			[Token(Token = "0x6000E58")]
			[Address(RVA = "0x56E3C60", Offset = "0x56E2860", VA = "0x1856E3C60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06000E59 RID: 3673 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003CD")]
		public Finger finger
		{
			[Token(Token = "0x6000E59")]
			[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06000E5A RID: 3674 RVA: 0x000071D0 File Offset: 0x000053D0
		[Token(Token = "0x170003CE")]
		public TouchPhase phase
		{
			[Token(Token = "0x6000E5A")]
			[Address(RVA = "0x56E3650", Offset = "0x56E2250", VA = "0x1856E3650")]
			get
			{
				return TouchPhase.None;
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06000E5B RID: 3675 RVA: 0x000071E8 File Offset: 0x000053E8
		[Token(Token = "0x170003CF")]
		public bool began
		{
			[Token(Token = "0x6000E5B")]
			[Address(RVA = "0x56E30B0", Offset = "0x56E1CB0", VA = "0x1856E30B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06000E5C RID: 3676 RVA: 0x00007200 File Offset: 0x00005400
		[Token(Token = "0x170003D0")]
		public bool inProgress
		{
			[Token(Token = "0x6000E5C")]
			[Address(RVA = "0x56E3470", Offset = "0x56E2070", VA = "0x1856E3470")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06000E5D RID: 3677 RVA: 0x00007218 File Offset: 0x00005418
		[Token(Token = "0x170003D1")]
		public bool ended
		{
			[Token(Token = "0x6000E5D")]
			[Address(RVA = "0x56E31F0", Offset = "0x56E1DF0", VA = "0x1856E31F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06000E5E RID: 3678 RVA: 0x00007230 File Offset: 0x00005430
		[Token(Token = "0x170003D2")]
		public int touchId
		{
			[Token(Token = "0x6000E5E")]
			[Address(RVA = "0x56E3B10", Offset = "0x56E2710", VA = "0x1856E3B10")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06000E5F RID: 3679 RVA: 0x00007248 File Offset: 0x00005448
		[Token(Token = "0x170003D3")]
		public float pressure
		{
			[Token(Token = "0x6000E5F")]
			[Address(RVA = "0x56E36C0", Offset = "0x56E22C0", VA = "0x1856E36C0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06000E60 RID: 3680 RVA: 0x00007260 File Offset: 0x00005460
		[Token(Token = "0x170003D4")]
		public Vector2 radius
		{
			[Token(Token = "0x6000E60")]
			[Address(RVA = "0x56E3740", Offset = "0x56E2340", VA = "0x1856E3740")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06000E61 RID: 3681 RVA: 0x00007278 File Offset: 0x00005478
		[Token(Token = "0x170003D5")]
		public double startTime
		{
			[Token(Token = "0x6000E61")]
			[Address(RVA = "0x56E39A0", Offset = "0x56E25A0", VA = "0x1856E39A0")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06000E62 RID: 3682 RVA: 0x00007290 File Offset: 0x00005490
		[Token(Token = "0x170003D6")]
		public double time
		{
			[Token(Token = "0x6000E62")]
			[Address(RVA = "0x56E3AD0", Offset = "0x56E26D0", VA = "0x1856E3AD0")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06000E63 RID: 3683 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003D7")]
		public Touchscreen screen
		{
			[Token(Token = "0x6000E63")]
			[Address(RVA = "0x56E3840", Offset = "0x56E2440", VA = "0x1856E3840")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06000E64 RID: 3684 RVA: 0x000072A8 File Offset: 0x000054A8
		[Token(Token = "0x170003D8")]
		public Vector2 screenPosition
		{
			[Token(Token = "0x6000E64")]
			[Address(RVA = "0x56E37C0", Offset = "0x56E23C0", VA = "0x1856E37C0")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06000E65 RID: 3685 RVA: 0x000072C0 File Offset: 0x000054C0
		[Token(Token = "0x170003D9")]
		public Vector2 startScreenPosition
		{
			[Token(Token = "0x6000E65")]
			[Address(RVA = "0x56E3920", Offset = "0x56E2520", VA = "0x1856E3920")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06000E66 RID: 3686 RVA: 0x000072D8 File Offset: 0x000054D8
		[Token(Token = "0x170003DA")]
		public Vector2 delta
		{
			[Token(Token = "0x6000E66")]
			[Address(RVA = "0x56E3100", Offset = "0x56E1D00", VA = "0x1856E3100")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06000E67 RID: 3687 RVA: 0x000072F0 File Offset: 0x000054F0
		[Token(Token = "0x170003DB")]
		public int tapCount
		{
			[Token(Token = "0x6000E67")]
			[Address(RVA = "0x56E3A60", Offset = "0x56E2660", VA = "0x1856E3A60")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06000E68 RID: 3688 RVA: 0x00007308 File Offset: 0x00005508
		[Token(Token = "0x170003DC")]
		public bool isTap
		{
			[Token(Token = "0x6000E68")]
			[Address(RVA = "0x56E3580", Offset = "0x56E2180", VA = "0x1856E3580")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06000E69 RID: 3689 RVA: 0x00007320 File Offset: 0x00005520
		[Token(Token = "0x170003DD")]
		public int displayIndex
		{
			[Token(Token = "0x6000E69")]
			[Address(RVA = "0x56E3180", Offset = "0x56E1D80", VA = "0x1856E3180")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06000E6A RID: 3690 RVA: 0x00007338 File Offset: 0x00005538
		[Token(Token = "0x170003DE")]
		public bool isInProgress
		{
			[Token(Token = "0x6000E6A")]
			[Address(RVA = "0x56E3510", Offset = "0x56E2110", VA = "0x1856E3510")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06000E6B RID: 3691 RVA: 0x00007350 File Offset: 0x00005550
		[Token(Token = "0x170003DF")]
		internal uint updateStepCount
		{
			[Token(Token = "0x6000E6B")]
			[Address(RVA = "0x56E3BF0", Offset = "0x56E27F0", VA = "0x1856E3BF0")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06000E6C RID: 3692 RVA: 0x00007368 File Offset: 0x00005568
		[Token(Token = "0x170003E0")]
		internal uint uniqueId
		{
			[Token(Token = "0x6000E6C")]
			[Address(RVA = "0x56E3B80", Offset = "0x56E2780", VA = "0x1856E3B80")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06000E6D RID: 3693 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003E1")]
		private ref TouchState state
		{
			[Token(Token = "0x6000E6D")]
			[Address(RVA = "0x56E3A20", Offset = "0x56E2620", VA = "0x1856E3A20")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06000E6E RID: 3694 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003E2")]
		private ref Touch.ExtraDataPerTouchState extraData
		{
			[Token(Token = "0x6000E6E")]
			[Address(RVA = "0x56E3270", Offset = "0x56E1E70", VA = "0x1856E3270")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06000E6F RID: 3695 RVA: 0x00007380 File Offset: 0x00005580
		[Token(Token = "0x170003E3")]
		public TouchHistory history
		{
			[Token(Token = "0x6000E6F")]
			[Address(RVA = "0x56E3340", Offset = "0x56E1F40", VA = "0x1856E3340")]
			get
			{
				return default(TouchHistory);
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06000E70 RID: 3696 RVA: 0x00007398 File Offset: 0x00005598
		[Token(Token = "0x170003E4")]
		public static ReadOnlyArray<Touch> activeTouches
		{
			[Token(Token = "0x6000E70")]
			[Address(RVA = "0x56E3000", Offset = "0x56E1C00", VA = "0x1856E3000")]
			get
			{
				return default(ReadOnlyArray<Touch>);
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06000E71 RID: 3697 RVA: 0x000073B0 File Offset: 0x000055B0
		[Token(Token = "0x170003E5")]
		public static ReadOnlyArray<Finger> fingers
		{
			[Token(Token = "0x6000E71")]
			[Address(RVA = "0x56E32B0", Offset = "0x56E1EB0", VA = "0x1856E32B0")]
			get
			{
				return default(ReadOnlyArray<Finger>);
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06000E72 RID: 3698 RVA: 0x000073C8 File Offset: 0x000055C8
		[Token(Token = "0x170003E6")]
		public static ReadOnlyArray<Finger> activeFingers
		{
			[Token(Token = "0x6000E72")]
			[Address(RVA = "0x56E2F50", Offset = "0x56E1B50", VA = "0x1856E2F50")]
			get
			{
				return default(ReadOnlyArray<Finger>);
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06000E73 RID: 3699 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003E7")]
		public static IEnumerable<Touchscreen> screens
		{
			[Token(Token = "0x6000E73")]
			[Address(RVA = "0x56E38A0", Offset = "0x56E24A0", VA = "0x1856E38A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000021 RID: 33
		// (add) Token: 0x06000E74 RID: 3700 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000E75 RID: 3701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000021")]
		public static event Action<Finger> onFingerDown
		{
			[Token(Token = "0x6000E74")]
			[Address(RVA = "0x56E2CE0", Offset = "0x56E18E0", VA = "0x1856E2CE0")]
			add
			{
			}
			[Token(Token = "0x6000E75")]
			[Address(RVA = "0x56E3CA0", Offset = "0x56E28A0", VA = "0x1856E3CA0")]
			remove
			{
			}
		}

		// Token: 0x14000022 RID: 34
		// (add) Token: 0x06000E76 RID: 3702 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000E77 RID: 3703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000022")]
		public static event Action<Finger> onFingerUp
		{
			[Token(Token = "0x6000E76")]
			[Address(RVA = "0x56E2E80", Offset = "0x56E1A80", VA = "0x1856E2E80")]
			add
			{
			}
			[Token(Token = "0x6000E77")]
			[Address(RVA = "0x56E3E40", Offset = "0x56E2A40", VA = "0x1856E3E40")]
			remove
			{
			}
		}

		// Token: 0x14000023 RID: 35
		// (add) Token: 0x06000E78 RID: 3704 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000E79 RID: 3705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000023")]
		public static event Action<Finger> onFingerMove
		{
			[Token(Token = "0x6000E78")]
			[Address(RVA = "0x56E2DB0", Offset = "0x56E19B0", VA = "0x1856E2DB0")]
			add
			{
			}
			[Token(Token = "0x6000E79")]
			[Address(RVA = "0x56E3D70", Offset = "0x56E2970", VA = "0x1856E3D70")]
			remove
			{
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06000E7A RID: 3706 RVA: 0x000073E0 File Offset: 0x000055E0
		[Token(Token = "0x170003E8")]
		public static int maxHistoryLengthPerFinger
		{
			[Token(Token = "0x6000E7A")]
			[Address(RVA = "0x56E3600", Offset = "0x56E2200", VA = "0x1856E3600")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000E7B RID: 3707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E7B")]
		[Address(RVA = "0x40068E0", Offset = "0x40054E0", VA = "0x1840068E0")]
		internal Touch(Finger finger, InputStateHistory<TouchState>.Record touchRecord)
		{
		}

		// Token: 0x06000E7C RID: 3708 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000E7C")]
		[Address(RVA = "0x56E2800", Offset = "0x56E1400", VA = "0x1856E2800", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000E7D RID: 3709 RVA: 0x000073F8 File Offset: 0x000055F8
		[Token(Token = "0x6000E7D")]
		[Address(RVA = "0x56E21D0", Offset = "0x56E0DD0", VA = "0x1856E21D0", Slot = "4")]
		public bool Equals(Touch other)
		{
			return default(bool);
		}

		// Token: 0x06000E7E RID: 3710 RVA: 0x00007410 File Offset: 0x00005610
		[Token(Token = "0x6000E7E")]
		[Address(RVA = "0x56E2270", Offset = "0x56E0E70", VA = "0x1856E2270", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000E7F RID: 3711 RVA: 0x00007428 File Offset: 0x00005628
		[Token(Token = "0x6000E7F")]
		[Address(RVA = "0x56E2370", Offset = "0x56E0F70", VA = "0x1856E2370", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000E80 RID: 3712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E80")]
		[Address(RVA = "0x56E2090", Offset = "0x56E0C90", VA = "0x1856E2090")]
		internal static void AddTouchscreen(Touchscreen screen)
		{
		}

		// Token: 0x06000E81 RID: 3713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E81")]
		[Address(RVA = "0x56E23F0", Offset = "0x56E0FF0", VA = "0x1856E23F0")]
		internal static void RemoveTouchscreen(Touchscreen screen)
		{
		}

		// Token: 0x06000E82 RID: 3714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E82")]
		[Address(RVA = "0x56E2120", Offset = "0x56E0D20", VA = "0x1856E2120")]
		internal static void BeginUpdate()
		{
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x00007440 File Offset: 0x00005640
		[Token(Token = "0x6000E83")]
		[Address(RVA = "0x56E21A0", Offset = "0x56E0DA0", VA = "0x1856E21A0")]
		private static Touch.GlobalState CreateGlobalState()
		{
			return default(Touch.GlobalState);
		}

		// Token: 0x06000E84 RID: 3716 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000E84")]
		[Address(RVA = "0x56E24C0", Offset = "0x56E10C0", VA = "0x1856E24C0")]
		internal static ISavedState SaveAndResetState()
		{
			return null;
		}

		// Token: 0x0400081E RID: 2078
		[Token(Token = "0x400081E")]
		[FieldOffset(Offset = "0x0")]
		private readonly Finger m_Finger;

		// Token: 0x0400081F RID: 2079
		[Token(Token = "0x400081F")]
		[FieldOffset(Offset = "0x8")]
		internal InputStateHistory<TouchState>.Record m_TouchRecord;

		// Token: 0x04000820 RID: 2080
		[Token(Token = "0x4000820")]
		[FieldOffset(Offset = "0x0")]
		internal static Touch.GlobalState s_GlobalState;

		// Token: 0x02000149 RID: 329
		[Token(Token = "0x2000149")]
		internal struct GlobalState
		{
			// Token: 0x04000821 RID: 2081
			[Token(Token = "0x4000821")]
			[FieldOffset(Offset = "0x0")]
			internal InlinedArray<Touchscreen> touchscreens;

			// Token: 0x04000822 RID: 2082
			[Token(Token = "0x4000822")]
			[FieldOffset(Offset = "0x18")]
			internal int historyLengthPerFinger;

			// Token: 0x04000823 RID: 2083
			[Token(Token = "0x4000823")]
			[FieldOffset(Offset = "0x20")]
			internal CallbackArray<Action<Finger>> onFingerDown;

			// Token: 0x04000824 RID: 2084
			[Token(Token = "0x4000824")]
			[FieldOffset(Offset = "0x70")]
			internal CallbackArray<Action<Finger>> onFingerMove;

			// Token: 0x04000825 RID: 2085
			[Token(Token = "0x4000825")]
			[FieldOffset(Offset = "0xC0")]
			internal CallbackArray<Action<Finger>> onFingerUp;

			// Token: 0x04000826 RID: 2086
			[Token(Token = "0x4000826")]
			[FieldOffset(Offset = "0x110")]
			internal Touch.FingerAndTouchState playerState;
		}

		// Token: 0x0200014A RID: 330
		[Token(Token = "0x200014A")]
		internal struct FingerAndTouchState
		{
			// Token: 0x06000E86 RID: 3718 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E86")]
			[Address(RVA = "0x56D41B0", Offset = "0x56D2DB0", VA = "0x1856D41B0")]
			public void AddFingers(Touchscreen screen)
			{
			}

			// Token: 0x06000E87 RID: 3719 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E87")]
			[Address(RVA = "0x56D4380", Offset = "0x56D2F80", VA = "0x1856D4380")]
			public void RemoveFingers(Touchscreen screen)
			{
			}

			// Token: 0x06000E88 RID: 3720 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E88")]
			[Address(RVA = "0x56D4300", Offset = "0x56D2F00", VA = "0x1856D4300")]
			public void Destroy()
			{
			}

			// Token: 0x06000E89 RID: 3721 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E89")]
			[Address(RVA = "0x56D44C0", Offset = "0x56D30C0", VA = "0x1856D44C0")]
			public void UpdateActiveFingers()
			{
			}

			// Token: 0x06000E8A RID: 3722 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E8A")]
			[Address(RVA = "0x56D4610", Offset = "0x56D3210", VA = "0x1856D4610")]
			public void UpdateActiveTouches()
			{
			}

			// Token: 0x04000827 RID: 2087
			[Token(Token = "0x4000827")]
			[FieldOffset(Offset = "0x0")]
			public InputUpdateType updateMask;

			// Token: 0x04000828 RID: 2088
			[Token(Token = "0x4000828")]
			[FieldOffset(Offset = "0x8")]
			public Finger[] fingers;

			// Token: 0x04000829 RID: 2089
			[Token(Token = "0x4000829")]
			[FieldOffset(Offset = "0x10")]
			public Finger[] activeFingers;

			// Token: 0x0400082A RID: 2090
			[Token(Token = "0x400082A")]
			[FieldOffset(Offset = "0x18")]
			public Touch[] activeTouches;

			// Token: 0x0400082B RID: 2091
			[Token(Token = "0x400082B")]
			[FieldOffset(Offset = "0x20")]
			public int activeFingerCount;

			// Token: 0x0400082C RID: 2092
			[Token(Token = "0x400082C")]
			[FieldOffset(Offset = "0x24")]
			public int activeTouchCount;

			// Token: 0x0400082D RID: 2093
			[Token(Token = "0x400082D")]
			[FieldOffset(Offset = "0x28")]
			public int totalFingerCount;

			// Token: 0x0400082E RID: 2094
			[Token(Token = "0x400082E")]
			[FieldOffset(Offset = "0x2C")]
			public uint lastId;

			// Token: 0x0400082F RID: 2095
			[Token(Token = "0x400082F")]
			[FieldOffset(Offset = "0x30")]
			public bool haveBuiltActiveTouches;

			// Token: 0x04000830 RID: 2096
			[Token(Token = "0x4000830")]
			[FieldOffset(Offset = "0x31")]
			public bool haveActiveTouchesNeedingRefreshNextUpdate;

			// Token: 0x04000831 RID: 2097
			[Token(Token = "0x4000831")]
			[FieldOffset(Offset = "0x38")]
			public InputStateHistory<TouchState> activeTouchState;
		}

		// Token: 0x0200014B RID: 331
		[Token(Token = "0x200014B")]
		internal struct ExtraDataPerTouchState
		{
			// Token: 0x04000832 RID: 2098
			[Token(Token = "0x4000832")]
			[FieldOffset(Offset = "0x0")]
			public Vector2 accumulatedDelta;

			// Token: 0x04000833 RID: 2099
			[Token(Token = "0x4000833")]
			[FieldOffset(Offset = "0x8")]
			public uint uniqueId;
		}
	}
}
