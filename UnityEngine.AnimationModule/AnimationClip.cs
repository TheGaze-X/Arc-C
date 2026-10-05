using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x0200000E RID: 14
	[Token(Token = "0x200000E")]
	[NativeType("Modules/Animation/AnimationClip.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationClip.bindings.h")]
	public sealed class AnimationClip : Motion
	{
		// Token: 0x06000066 RID: 102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x5911490", Offset = "0x5910090", VA = "0x185911490")]
		public AnimationClip()
		{
		}

		// Token: 0x06000067 RID: 103
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x5911290", Offset = "0x590FE90", VA = "0x185911290")]
		[FreeFunction("AnimationClipBindings::Internal_CreateAnimationClip")]
		[MethodImpl(4096)]
		private static extern void Internal_CreateAnimationClip([Writable] AnimationClip self);

		// Token: 0x06000068 RID: 104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x5911340", Offset = "0x590FF40", VA = "0x185911340")]
		public void SampleAnimation(GameObject go, float time)
		{
		}

		// Token: 0x06000069 RID: 105
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x59112D0", Offset = "0x590FED0", VA = "0x1859112D0")]
		[NativeHeader("Modules/Animation/AnimationUtility.h")]
		[FreeFunction]
		[MethodImpl(4096)]
		internal static extern void SampleAnimation([NotNull("ArgumentNullException")] GameObject go, [NotNull("ArgumentNullException")] AnimationClip clip, float inTime, WrapMode wrapMode);

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600006A RID: 106
		[Token(Token = "0x17000019")]
		[NativeProperty("Length", false, TargetType.Function)]
		public extern float length { [Token(Token = "0x600006A")] [Address(RVA = "0x59117D0", Offset = "0x59103D0", VA = "0x1859117D0")] [MethodImpl(4096)] get; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600006B RID: 107
		[Token(Token = "0x1700001A")]
		[NativeProperty("StartTime", false, TargetType.Function)]
		internal extern float startTime { [Token(Token = "0x600006B")] [Address(RVA = "0x59118C0", Offset = "0x59104C0", VA = "0x1859118C0")] [MethodImpl(4096)] get; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600006C RID: 108
		[Token(Token = "0x1700001B")]
		[NativeProperty("StopTime", false, TargetType.Function)]
		internal extern float stopTime { [Token(Token = "0x600006C")] [Address(RVA = "0x5911900", Offset = "0x5910500", VA = "0x185911900")] [MethodImpl(4096)] get; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600006D RID: 109
		// (set) Token: 0x0600006E RID: 110
		[Token(Token = "0x1700001C")]
		[NativeProperty("SampleRate", false, TargetType.Function)]
		public extern float frameRate { [Token(Token = "0x600006D")] [Address(RVA = "0x59115D0", Offset = "0x59101D0", VA = "0x1859115D0")] [MethodImpl(4096)] get; [Token(Token = "0x600006E")] [Address(RVA = "0x5911980", Offset = "0x5910580", VA = "0x185911980")] [MethodImpl(4096)] set; }

		// Token: 0x0600006F RID: 111
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x59113D0", Offset = "0x590FFD0", VA = "0x1859113D0")]
		[FreeFunction("AnimationClipBindings::Internal_SetCurve", HasExplicitThis = true)]
		[MethodImpl(4096)]
		public extern void SetCurve([NotNull("ArgumentNullException")] string relativePath, [NotNull("ArgumentNullException")] Type type, [NotNull("ArgumentNullException")] string propertyName, AnimationCurve curve);

		// Token: 0x06000070 RID: 112
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x5911210", Offset = "0x590FE10", VA = "0x185911210")]
		[MethodImpl(4096)]
		public extern void EnsureQuaternionContinuity();

		// Token: 0x06000071 RID: 113
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x59111D0", Offset = "0x590FDD0", VA = "0x1859111D0")]
		[MethodImpl(4096)]
		public extern void ClearCurves();

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000072 RID: 114
		// (set) Token: 0x06000073 RID: 115
		[Token(Token = "0x1700001D")]
		[NativeProperty("WrapMode", false, TargetType.Function)]
		public extern WrapMode wrapMode { [Token(Token = "0x6000072")] [Address(RVA = "0x5911940", Offset = "0x5910540", VA = "0x185911940")] [MethodImpl(4096)] get; [Token(Token = "0x6000073")] [Address(RVA = "0x5911AC0", Offset = "0x59106C0", VA = "0x185911AC0")] [MethodImpl(4096)] set; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00002160 File Offset: 0x00000360
		// (set) Token: 0x06000075 RID: 117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001E")]
		[NativeProperty("Bounds", false, TargetType.Function)]
		public Bounds localBounds
		{
			[Token(Token = "0x6000074")]
			[Address(RVA = "0x5911860", Offset = "0x5910460", VA = "0x185911860")]
			get
			{
				return default(Bounds);
			}
			[Token(Token = "0x6000075")]
			[Address(RVA = "0x5911A70", Offset = "0x5910670", VA = "0x185911A70")]
			set
			{
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000076 RID: 118
		// (set) Token: 0x06000077 RID: 119
		[Token(Token = "0x1700001F")]
		public extern bool legacy { [Token(Token = "0x6000076")] [Address(RVA = "0x5911790", Offset = "0x5910390", VA = "0x185911790")] [NativeMethod("IsLegacy")] [MethodImpl(4096)] get; [Token(Token = "0x6000077")] [Address(RVA = "0x59119D0", Offset = "0x59105D0", VA = "0x1859119D0")] [NativeMethod("SetLegacy")] [MethodImpl(4096)] set; }

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000078 RID: 120
		[Token(Token = "0x17000020")]
		public extern bool humanMotion { [Token(Token = "0x6000078")] [Address(RVA = "0x5911750", Offset = "0x5910350", VA = "0x185911750")] [NativeMethod("IsHumanMotion")] [MethodImpl(4096)] get; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000079 RID: 121
		[Token(Token = "0x17000021")]
		public extern bool empty { [Token(Token = "0x6000079")] [Address(RVA = "0x5911500", Offset = "0x5910100", VA = "0x185911500")] [NativeMethod("IsEmpty")] [MethodImpl(4096)] get; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600007A RID: 122
		[Token(Token = "0x17000022")]
		public extern bool hasGenericRootTransform { [Token(Token = "0x600007A")] [Address(RVA = "0x5911610", Offset = "0x5910210", VA = "0x185911610")] [NativeMethod("HasGenericRootTransform")] [MethodImpl(4096)] get; }

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600007B RID: 123
		[Token(Token = "0x17000023")]
		public extern bool hasMotionFloatCurves { [Token(Token = "0x600007B")] [Address(RVA = "0x5911690", Offset = "0x5910290", VA = "0x185911690")] [NativeMethod("HasMotionFloatCurves")] [MethodImpl(4096)] get; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600007C RID: 124
		[Token(Token = "0x17000024")]
		public extern bool hasMotionCurves { [Token(Token = "0x600007C")] [Address(RVA = "0x5911650", Offset = "0x5910250", VA = "0x185911650")] [NativeMethod("HasMotionCurves")] [MethodImpl(4096)] get; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600007D RID: 125
		[Token(Token = "0x17000025")]
		public extern bool hasRootCurves { [Token(Token = "0x600007D")] [Address(RVA = "0x59116D0", Offset = "0x59102D0", VA = "0x1859116D0")] [NativeMethod("HasRootCurves")] [MethodImpl(4096)] get; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600007E RID: 126
		[Token(Token = "0x17000026")]
		internal extern bool hasRootMotion { [Token(Token = "0x600007E")] [Address(RVA = "0x5911710", Offset = "0x5910310", VA = "0x185911710")] [FreeFunction(Name = "AnimationClipBindings::Internal_GetHasRootMotion", HasExplicitThis = true)] [MethodImpl(4096)] get; }

		// Token: 0x0600007F RID: 127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x5911130", Offset = "0x590FD30", VA = "0x185911130")]
		public void AddEvent(AnimationEvent evt)
		{
		}

		// Token: 0x06000080 RID: 128
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x59110E0", Offset = "0x590FCE0", VA = "0x1859110E0")]
		[FreeFunction(Name = "AnimationClipBindings::AddEventInternal", HasExplicitThis = true)]
		[MethodImpl(4096)]
		private extern void AddEventInternal(object evt);

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000081 RID: 129 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000082 RID: 130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000027")]
		public AnimationEvent[] events
		{
			[Token(Token = "0x6000081")]
			[Address(RVA = "0x5911540", Offset = "0x5910140", VA = "0x185911540")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000082")]
			[Address(RVA = "0x5911440", Offset = "0x5910040", VA = "0x185911440")]
			set
			{
			}
		}

		// Token: 0x06000083 RID: 131
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x5911440", Offset = "0x5910040", VA = "0x185911440")]
		[FreeFunction(Name = "AnimationClipBindings::SetEventsInternal", HasExplicitThis = true, ThrowsException = true)]
		[MethodImpl(4096)]
		private extern void SetEventsInternal(Array value);

		// Token: 0x06000084 RID: 132
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x5911250", Offset = "0x590FE50", VA = "0x185911250")]
		[FreeFunction(Name = "AnimationClipBindings::GetEventsInternal", HasExplicitThis = true)]
		[MethodImpl(4096)]
		private extern Array GetEventsInternal();

		// Token: 0x06000085 RID: 133
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x5911810", Offset = "0x5910410", VA = "0x185911810")]
		[MethodImpl(4096)]
		private extern void get_localBounds_Injected(out Bounds ret);

		// Token: 0x06000086 RID: 134
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x5911A20", Offset = "0x5910620", VA = "0x185911A20")]
		[MethodImpl(4096)]
		private extern void set_localBounds_Injected(ref Bounds value);
	}
}
