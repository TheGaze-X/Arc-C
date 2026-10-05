using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	[NativeHeader("Modules/Animation/Animation.h")]
	public sealed class Animation : Behaviour, IEnumerable
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000010 RID: 16
		// (set) Token: 0x06000011 RID: 17
		[Token(Token = "0x17000001")]
		public extern AnimationClip clip { [Token(Token = "0x6000010")] [Address(RVA = "0x5916680", Offset = "0x5915280", VA = "0x185916680")] [MethodImpl(4096)] get; [Token(Token = "0x6000011")] [Address(RVA = "0x5916910", Offset = "0x5915510", VA = "0x185916910")] [MethodImpl(4096)] set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000012 RID: 18
		// (set) Token: 0x06000013 RID: 19
		[Token(Token = "0x17000002")]
		public extern bool playAutomatically { [Token(Token = "0x6000012")] [Address(RVA = "0x59167F0", Offset = "0x59153F0", VA = "0x1859167F0")] [MethodImpl(4096)] get; [Token(Token = "0x6000013")] [Address(RVA = "0x5916A40", Offset = "0x5915640", VA = "0x185916A40")] [MethodImpl(4096)] set; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000014 RID: 20
		// (set) Token: 0x06000015 RID: 21
		[Token(Token = "0x17000003")]
		public extern WrapMode wrapMode { [Token(Token = "0x6000014")] [Address(RVA = "0x5916830", Offset = "0x5915430", VA = "0x185916830")] [MethodImpl(4096)] get; [Token(Token = "0x6000015")] [Address(RVA = "0x5916A90", Offset = "0x5915690", VA = "0x185916A90")] [MethodImpl(4096)] set; }

		// Token: 0x06000016 RID: 22
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x5916570", Offset = "0x5915170", VA = "0x185916570")]
		[MethodImpl(4096)]
		public extern void Stop();

		// Token: 0x06000017 RID: 23 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x5916520", Offset = "0x5915120", VA = "0x185916520")]
		public void Stop(string name)
		{
		}

		// Token: 0x06000018 RID: 24
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x5916520", Offset = "0x5915120", VA = "0x185916520")]
		[NativeName("Stop")]
		[MethodImpl(4096)]
		private extern void StopNamed(string name);

		// Token: 0x06000019 RID: 25
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x59164A0", Offset = "0x59150A0", VA = "0x1859164A0")]
		[MethodImpl(4096)]
		public extern void Rewind();

		// Token: 0x0600001A RID: 26 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x5916450", Offset = "0x5915050", VA = "0x185916450")]
		public void Rewind(string name)
		{
		}

		// Token: 0x0600001B RID: 27
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x5916450", Offset = "0x5915050", VA = "0x185916450")]
		[NativeName("Rewind")]
		[MethodImpl(4096)]
		private extern void RewindNamed(string name);

		// Token: 0x0600001C RID: 28
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x59164E0", Offset = "0x59150E0", VA = "0x1859164E0")]
		[MethodImpl(4096)]
		public extern void Sample();

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600001D RID: 29
		[Token(Token = "0x17000004")]
		public extern bool isPlaying { [Token(Token = "0x600001D")] [Address(RVA = "0x5916700", Offset = "0x5915300", VA = "0x185916700")] [NativeName("IsPlaying")] [MethodImpl(4096)] get; }

		// Token: 0x0600001E RID: 30
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x5916110", Offset = "0x5914D10", VA = "0x185916110")]
		[MethodImpl(4096)]
		public extern bool IsPlaying(string name);

		// Token: 0x17000005 RID: 5
		[Token(Token = "0x17000005")]
		public AnimationState this[string name]
		{
			[Token(Token = "0x600001F")]
			[Address(RVA = "0x59160C0", Offset = "0x5914CC0", VA = "0x1859160C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002058 File Offset: 0x00000258
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x59162C0", Offset = "0x5914EC0", VA = "0x1859162C0")]
		[ExcludeFromDocs]
		public bool Play()
		{
			return default(bool);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002070 File Offset: 0x00000270
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x5916160", Offset = "0x5914D60", VA = "0x185916160")]
		public bool Play([DefaultValue("PlayMode.StopSameLayer")] PlayMode mode)
		{
			return default(bool);
		}

		// Token: 0x06000022 RID: 34
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x5916160", Offset = "0x5914D60", VA = "0x185916160")]
		[NativeName("Play")]
		[MethodImpl(4096)]
		private extern bool PlayDefaultAnimation(PlayMode mode);

		// Token: 0x06000023 RID: 35 RVA: 0x00002088 File Offset: 0x00000288
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x5916360", Offset = "0x5914F60", VA = "0x185916360")]
		[ExcludeFromDocs]
		public bool Play(string animation)
		{
			return default(bool);
		}

		// Token: 0x06000024 RID: 36
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x5916300", Offset = "0x5914F00", VA = "0x185916300")]
		[MethodImpl(4096)]
		public extern bool Play(string animation, [DefaultValue("PlayMode.StopSameLayer")] PlayMode mode);

		// Token: 0x06000025 RID: 37 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x5915EA0", Offset = "0x5914AA0", VA = "0x185915EA0")]
		[ExcludeFromDocs]
		public void CrossFade(string animation)
		{
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x5915DD0", Offset = "0x59149D0", VA = "0x185915DD0")]
		[ExcludeFromDocs]
		public void CrossFade(string animation, float fadeLength)
		{
		}

		// Token: 0x06000027 RID: 39
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x5915E30", Offset = "0x5914A30", VA = "0x185915E30")]
		[MethodImpl(4096)]
		public extern void CrossFade(string animation, [DefaultValue("0.3F")] float fadeLength, [DefaultValue("PlayMode.StopSameLayer")] PlayMode mode);

		// Token: 0x06000028 RID: 40 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x5915B00", Offset = "0x5914700", VA = "0x185915B00")]
		[ExcludeFromDocs]
		public void Blend(string animation)
		{
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x5915BD0", Offset = "0x59147D0", VA = "0x185915BD0")]
		[ExcludeFromDocs]
		public void Blend(string animation, float targetWeight)
		{
		}

		// Token: 0x0600002A RID: 42
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x5915B60", Offset = "0x5914760", VA = "0x185915B60")]
		[MethodImpl(4096)]
		public extern void Blend(string animation, [DefaultValue("1.0F")] float targetWeight, [DefaultValue("0.3F")] float fadeLength);

		// Token: 0x0600002B RID: 43 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x5915D00", Offset = "0x5914900", VA = "0x185915D00")]
		[ExcludeFromDocs]
		public AnimationState CrossFadeQueued(string animation)
		{
			return null;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x5915C30", Offset = "0x5914830", VA = "0x185915C30")]
		[ExcludeFromDocs]
		public AnimationState CrossFadeQueued(string animation, float fadeLength)
		{
			return null;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x5915C90", Offset = "0x5914890", VA = "0x185915C90")]
		[ExcludeFromDocs]
		public AnimationState CrossFadeQueued(string animation, float fadeLength, QueueMode queue)
		{
			return null;
		}

		// Token: 0x0600002E RID: 46
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x5915D60", Offset = "0x5914960", VA = "0x185915D60")]
		[FreeFunction("AnimationBindings::CrossFadeQueuedImpl", HasExplicitThis = true)]
		[MethodImpl(4096)]
		public extern AnimationState CrossFadeQueued(string animation, [DefaultValue("0.3F")] float fadeLength, [DefaultValue("QueueMode.CompleteOthers")] QueueMode queue, [DefaultValue("PlayMode.StopSameLayer")] PlayMode mode);

		// Token: 0x0600002F RID: 47 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x59161A0", Offset = "0x5914DA0", VA = "0x1859161A0")]
		[ExcludeFromDocs]
		public AnimationState PlayQueued(string animation)
		{
			return null;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x5916260", Offset = "0x5914E60", VA = "0x185916260")]
		[ExcludeFromDocs]
		public AnimationState PlayQueued(string animation, QueueMode queue)
		{
			return null;
		}

		// Token: 0x06000031 RID: 49
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x59161F0", Offset = "0x5914DF0", VA = "0x1859161F0")]
		[FreeFunction("AnimationBindings::PlayQueuedImpl", HasExplicitThis = true)]
		[MethodImpl(4096)]
		public extern AnimationState PlayQueued(string animation, [DefaultValue("QueueMode.CompleteOthers")] QueueMode queue, [DefaultValue("PlayMode.StopSameLayer")] PlayMode mode);

		// Token: 0x06000032 RID: 50 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x5915A20", Offset = "0x5914620", VA = "0x185915A20")]
		public void AddClip(AnimationClip clip, string newName)
		{
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x59159B0", Offset = "0x59145B0", VA = "0x1859159B0")]
		[ExcludeFromDocs]
		public void AddClip(AnimationClip clip, string newName, int firstFrame, int lastFrame)
		{
		}

		// Token: 0x06000034 RID: 52
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x5915A90", Offset = "0x5914690", VA = "0x185915A90")]
		[MethodImpl(4096)]
		public extern void AddClip([NotNull("NullExceptionObject")] AnimationClip clip, string newName, int firstFrame, int lastFrame, [DefaultValue("false")] bool addLoopFrame);

		// Token: 0x06000035 RID: 53
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x5916400", Offset = "0x5915000", VA = "0x185916400")]
		[MethodImpl(4096)]
		public extern void RemoveClip([NotNull("NullExceptionObject")] AnimationClip clip);

		// Token: 0x06000036 RID: 54 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x59163B0", Offset = "0x5914FB0", VA = "0x1859163B0")]
		public void RemoveClip(string clipName)
		{
		}

		// Token: 0x06000037 RID: 55
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x59163B0", Offset = "0x5914FB0", VA = "0x1859163B0")]
		[NativeName("RemoveClip")]
		[MethodImpl(4096)]
		private extern void RemoveClipNamed(string clipName);

		// Token: 0x06000038 RID: 56
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x5915EF0", Offset = "0x5914AF0", VA = "0x185915EF0")]
		[MethodImpl(4096)]
		public extern int GetClipCount();

		// Token: 0x06000039 RID: 57 RVA: 0x000020A0 File Offset: 0x000002A0
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x5916160", Offset = "0x5914D60", VA = "0x185916160")]
		[Obsolete("use PlayMode instead of AnimationPlayMode.")]
		public bool Play(AnimationPlayMode mode)
		{
			return default(bool);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000020B8 File Offset: 0x000002B8
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x5916300", Offset = "0x5914F00", VA = "0x185916300")]
		[Obsolete("use PlayMode instead of AnimationPlayMode.")]
		public bool Play(string animation, AnimationPlayMode mode)
		{
			return default(bool);
		}

		// Token: 0x0600003B RID: 59
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x59165B0", Offset = "0x59151B0", VA = "0x1859165B0")]
		[MethodImpl(4096)]
		public extern void SyncLayer(int layer);

		// Token: 0x0600003C RID: 60 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x5915FC0", Offset = "0x5914BC0", VA = "0x185915FC0", Slot = "4")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600003D RID: 61
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x59160C0", Offset = "0x5914CC0", VA = "0x1859160C0")]
		[FreeFunction("AnimationBindings::GetState", HasExplicitThis = true)]
		[MethodImpl(4096)]
		internal extern AnimationState GetState(string name);

		// Token: 0x0600003E RID: 62
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x5916040", Offset = "0x5914C40", VA = "0x185916040")]
		[FreeFunction("AnimationBindings::GetStateAtIndex", HasExplicitThis = true, ThrowsException = true)]
		[MethodImpl(4096)]
		internal extern AnimationState GetStateAtIndex(int index);

		// Token: 0x0600003F RID: 63
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x5916080", Offset = "0x5914C80", VA = "0x185916080")]
		[NativeName("GetAnimationStateCount")]
		[MethodImpl(4096)]
		internal extern int GetStateCount();

		// Token: 0x06000040 RID: 64 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x5915F30", Offset = "0x5914B30", VA = "0x185915F30")]
		public AnimationClip GetClip(string name)
		{
			return null;
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000041 RID: 65
		// (set) Token: 0x06000042 RID: 66
		[Token(Token = "0x17000006")]
		public extern bool animatePhysics { [Token(Token = "0x6000041")] [Address(RVA = "0x5916640", Offset = "0x5915240", VA = "0x185916640")] [MethodImpl(4096)] get; [Token(Token = "0x6000042")] [Address(RVA = "0x59168C0", Offset = "0x59154C0", VA = "0x1859168C0")] [MethodImpl(4096)] set; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000043 RID: 67
		// (set) Token: 0x06000044 RID: 68
		[Token(Token = "0x17000007")]
		[Obsolete("Use cullingType instead")]
		public extern bool animateOnlyIfVisible { [Token(Token = "0x6000043")] [Address(RVA = "0x5916600", Offset = "0x5915200", VA = "0x185916600")] [FreeFunction("AnimationBindings::GetAnimateOnlyIfVisible", HasExplicitThis = true)] [MethodImpl(4096)] get; [Token(Token = "0x6000044")] [Address(RVA = "0x5916870", Offset = "0x5915470", VA = "0x185916870")] [FreeFunction("AnimationBindings::SetAnimateOnlyIfVisible", HasExplicitThis = true)] [MethodImpl(4096)] set; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000045 RID: 69
		// (set) Token: 0x06000046 RID: 70
		[Token(Token = "0x17000008")]
		public extern AnimationCullingType cullingType { [Token(Token = "0x6000045")] [Address(RVA = "0x59166C0", Offset = "0x59152C0", VA = "0x1859166C0")] [MethodImpl(4096)] get; [Token(Token = "0x6000046")] [Address(RVA = "0x5916960", Offset = "0x5915560", VA = "0x185916960")] [MethodImpl(4096)] set; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000047 RID: 71 RVA: 0x000020D0 File Offset: 0x000002D0
		// (set) Token: 0x06000048 RID: 72 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000009")]
		public Bounds localBounds
		{
			[Token(Token = "0x6000047")]
			[Address(RVA = "0x5916790", Offset = "0x5915390", VA = "0x185916790")]
			[NativeName("GetLocalAABB")]
			get
			{
				return default(Bounds);
			}
			[Token(Token = "0x6000048")]
			[Address(RVA = "0x59169F0", Offset = "0x59155F0", VA = "0x1859169F0")]
			[NativeName("SetLocalAABB")]
			set
			{
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x59165F0", Offset = "0x59151F0", VA = "0x1859165F0")]
		public Animation()
		{
		}

		// Token: 0x0600004A RID: 74
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x5916740", Offset = "0x5915340", VA = "0x185916740")]
		[MethodImpl(4096)]
		private extern void get_localBounds_Injected(out Bounds ret);

		// Token: 0x0600004B RID: 75
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x59169A0", Offset = "0x59155A0", VA = "0x1859169A0")]
		[MethodImpl(4096)]
		private extern void set_localBounds_Injected(ref Bounds value);

		// Token: 0x0200000B RID: 11
		[Token(Token = "0x200000B")]
		private sealed class Enumerator : IEnumerator
		{
			// Token: 0x0600004C RID: 76 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600004C")]
			[Address(RVA = "0x4A5F040", Offset = "0x4A5DC40", VA = "0x184A5F040")]
			internal Enumerator(Animation outer)
			{
			}

			// Token: 0x1700000A RID: 10
			// (get) Token: 0x0600004D RID: 77 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700000A")]
			public object Current
			{
				[Token(Token = "0x600004D")]
				[Address(RVA = "0x5919A90", Offset = "0x5918690", VA = "0x185919A90", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600004E RID: 78 RVA: 0x000020E8 File Offset: 0x000002E8
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x5919A30", Offset = "0x5918630", VA = "0x185919A30", Slot = "4")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x0600004F RID: 79 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600004F")]
			[Address(RVA = "0x487E640", Offset = "0x487D240", VA = "0x18487E640", Slot = "6")]
			public void Reset()
			{
			}

			// Token: 0x04000014 RID: 20
			[Token(Token = "0x4000014")]
			[FieldOffset(Offset = "0x10")]
			private Animation m_Outer;

			// Token: 0x04000015 RID: 21
			[Token(Token = "0x4000015")]
			[FieldOffset(Offset = "0x18")]
			private int m_CurrentIndex;
		}
	}
}
