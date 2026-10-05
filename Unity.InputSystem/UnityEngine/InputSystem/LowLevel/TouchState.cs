using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x0200019D RID: 413
	[Token(Token = "0x200019D")]
	[StructLayout(2)]
	public struct TouchState : IInputStateTypeInfo
	{
		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06000F92 RID: 3986 RVA: 0x00007FC8 File Offset: 0x000061C8
		[Token(Token = "0x17000454")]
		public static FourCC Format
		{
			[Token(Token = "0x6000F92")]
			[Address(RVA = "0x56E1E50", Offset = "0x56E0A50", VA = "0x1856E1E50")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06000F93 RID: 3987 RVA: 0x00007FE0 File Offset: 0x000061E0
		// (set) Token: 0x06000F94 RID: 3988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000455")]
		public TouchPhase phase
		{
			[Token(Token = "0x6000F93")]
			[Address(RVA = "0x4F1E20", Offset = "0x4F0A20", VA = "0x1804F1E20")]
			get
			{
				return TouchPhase.None;
			}
			[Token(Token = "0x6000F94")]
			[Address(RVA = "0x4F1E30", Offset = "0x4F0A30", VA = "0x1804F1E30")]
			set
			{
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06000F95 RID: 3989 RVA: 0x00007FF8 File Offset: 0x000061F8
		[Token(Token = "0x17000456")]
		public bool isNoneEndedOrCanceled
		{
			[Token(Token = "0x6000F95")]
			[Address(RVA = "0x56E1F10", Offset = "0x56E0B10", VA = "0x1856E1F10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06000F96 RID: 3990 RVA: 0x00008010 File Offset: 0x00006210
		[Token(Token = "0x17000457")]
		public bool isInProgress
		{
			[Token(Token = "0x6000F96")]
			[Address(RVA = "0x56E1EE0", Offset = "0x56E0AE0", VA = "0x1856E1EE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06000F97 RID: 3991 RVA: 0x00008028 File Offset: 0x00006228
		// (set) Token: 0x06000F98 RID: 3992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000458")]
		public bool isPrimaryTouch
		{
			[Token(Token = "0x6000F97")]
			[Address(RVA = "0x56E1F40", Offset = "0x56E0B40", VA = "0x1856E1F40")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000F98")]
			[Address(RVA = "0x56E2000", Offset = "0x56E0C00", VA = "0x1856E2000")]
			set
			{
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06000F99 RID: 3993 RVA: 0x00008040 File Offset: 0x00006240
		// (set) Token: 0x06000F9A RID: 3994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000459")]
		internal bool isOrphanedPrimaryTouch
		{
			[Token(Token = "0x6000F99")]
			[Address(RVA = "0x56E1F30", Offset = "0x56E0B30", VA = "0x1856E1F30")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000F9A")]
			[Address(RVA = "0x56E1FD0", Offset = "0x56E0BD0", VA = "0x1856E1FD0")]
			set
			{
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06000F9B RID: 3995 RVA: 0x00008058 File Offset: 0x00006258
		// (set) Token: 0x06000F9C RID: 3996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700045A")]
		public bool isIndirectTouch
		{
			[Token(Token = "0x6000F9B")]
			[Address(RVA = "0x56E1F00", Offset = "0x56E0B00", VA = "0x1856E1F00")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000F9C")]
			[Address(RVA = "0x56E1FA0", Offset = "0x56E0BA0", VA = "0x1856E1FA0")]
			set
			{
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06000F9D RID: 3997 RVA: 0x00008070 File Offset: 0x00006270
		// (set) Token: 0x06000F9E RID: 3998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700045B")]
		public bool isTap
		{
			[Token(Token = "0x6000F9D")]
			[Address(RVA = "0x56E1F50", Offset = "0x56E0B50", VA = "0x1856E1F50")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000F9E")]
			[Address(RVA = "0x56E2030", Offset = "0x56E0C30", VA = "0x1856E2030")]
			set
			{
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06000F9F RID: 3999 RVA: 0x00008088 File Offset: 0x00006288
		// (set) Token: 0x06000FA0 RID: 4000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700045C")]
		internal bool isTapPress
		{
			[Token(Token = "0x6000F9F")]
			[Address(RVA = "0x56E1F50", Offset = "0x56E0B50", VA = "0x1856E1F50")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000FA0")]
			[Address(RVA = "0x56E2030", Offset = "0x56E0C30", VA = "0x1856E2030")]
			set
			{
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06000FA1 RID: 4001 RVA: 0x000080A0 File Offset: 0x000062A0
		// (set) Token: 0x06000FA2 RID: 4002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700045D")]
		internal bool isTapRelease
		{
			[Token(Token = "0x6000FA1")]
			[Address(RVA = "0x56E1F60", Offset = "0x56E0B60", VA = "0x1856E1F60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000FA2")]
			[Address(RVA = "0x56E2060", Offset = "0x56E0C60", VA = "0x1856E2060")]
			set
			{
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06000FA3 RID: 4003 RVA: 0x000080B8 File Offset: 0x000062B8
		// (set) Token: 0x06000FA4 RID: 4004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700045E")]
		internal bool beganInSameFrame
		{
			[Token(Token = "0x6000FA3")]
			[Address(RVA = "0x56E1E90", Offset = "0x56E0A90", VA = "0x1856E1E90")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000FA4")]
			[Address(RVA = "0x56E1F70", Offset = "0x56E0B70", VA = "0x1856E1F70")]
			set
			{
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06000FA5 RID: 4005 RVA: 0x000080D0 File Offset: 0x000062D0
		[Token(Token = "0x1700045F")]
		public FourCC format
		{
			[Token(Token = "0x6000FA5")]
			[Address(RVA = "0x56E1EA0", Offset = "0x56E0AA0", VA = "0x1856E1EA0", Slot = "4")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x06000FA6 RID: 4006 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000FA6")]
		[Address(RVA = "0x56E1AE0", Offset = "0x56E06E0", VA = "0x1856E1AE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0400097F RID: 2431
		[Token(Token = "0x400097F")]
		internal const int kSizeInBytes = 56;

		// Token: 0x04000980 RID: 2432
		[Token(Token = "0x4000980")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[InputControl(displayName = "Touch ID", layout = "Integer", synthetic = true, dontReset = true)]
		public int touchId;

		// Token: 0x04000981 RID: 2433
		[Token(Token = "0x4000981")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[InputControl(displayName = "Position", dontReset = true)]
		public Vector2 position;

		// Token: 0x04000982 RID: 2434
		[Token(Token = "0x4000982")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[InputControl(displayName = "Delta", layout = "Delta")]
		public Vector2 delta;

		// Token: 0x04000983 RID: 2435
		[Token(Token = "0x4000983")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[InputControl(displayName = "Pressure", layout = "Axis")]
		public float pressure;

		// Token: 0x04000984 RID: 2436
		[Token(Token = "0x4000984")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[InputControl(displayName = "Radius")]
		public Vector2 radius;

		// Token: 0x04000985 RID: 2437
		[Token(Token = "0x4000985")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[InputControl(name = "press", displayName = "Touch Contact?", layout = "TouchPress", useStateFrom = "phase")]
		[InputControl(name = "phase", displayName = "Touch Phase", layout = "TouchPhase", synthetic = true)]
		public byte phaseId;

		// Token: 0x04000986 RID: 2438
		[Token(Token = "0x4000986")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[InputControl(name = "tapCount", displayName = "Tap Count", layout = "Integer")]
		public byte tapCount;

		// Token: 0x04000987 RID: 2439
		[Token(Token = "0x4000987")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		[InputControl(name = "displayIndex", displayName = "Display Index", layout = "Integer")]
		public byte displayIndex;

		// Token: 0x04000988 RID: 2440
		[Token(Token = "0x4000988")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
		[InputControl(name = "tap", displayName = "Tap", layout = "Button", bit = 4U)]
		[InputControl(name = "indirectTouch", displayName = "Indirect Touch?", layout = "Button", bit = 0U, synthetic = true)]
		public byte flags;

		// Token: 0x04000989 RID: 2441
		[Token(Token = "0x4000989")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal uint updateStepCount;

		// Token: 0x0400098A RID: 2442
		[Token(Token = "0x400098A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[InputControl(displayName = "Start Time", layout = "Double", synthetic = true)]
		public double startTime;

		// Token: 0x0400098B RID: 2443
		[Token(Token = "0x400098B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[InputControl(displayName = "Start Position", synthetic = true)]
		public Vector2 startPosition;
	}
}
