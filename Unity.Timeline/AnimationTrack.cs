using System;
using System.Collections.Generic;
using System.ComponentModel;
using Il2CppDummyDll;
using UnityEngine.Animations;
using UnityEngine.Playables;
using UnityEngine.Serialization;

namespace UnityEngine.Timeline
{
	// Token: 0x02000012 RID: 18
	[Token(Token = "0x2000012")]
	[TrackBindingType(typeof(Animator))]
	[TrackClipType(typeof(AnimationPlayableAsset), false)]
	[ExcludeFromPreset]
	[Serializable]
	public class AnimationTrack : TrackAsset, ILayerable
	{
		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000049 RID: 73 RVA: 0x000022F4 File Offset: 0x000004F4
		// (set) Token: 0x0600004A RID: 74 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000014")]
		public Vector3 position
		{
			[Token(Token = "0x6000049")]
			[Address(RVA = "0x58E2620", Offset = "0x58E1220", VA = "0x1858E2620")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x58E2820", Offset = "0x58E1420", VA = "0x1858E2820")]
			set
			{
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600004B RID: 75 RVA: 0x0000230C File Offset: 0x0000050C
		// (set) Token: 0x0600004C RID: 76 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000015")]
		public Quaternion rotation
		{
			[Token(Token = "0x600004B")]
			[Address(RVA = "0x58E2640", Offset = "0x58E1240", VA = "0x1858E2640")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x600004C")]
			[Address(RVA = "0x58E2840", Offset = "0x58E1440", VA = "0x1858E2840")]
			set
			{
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00002324 File Offset: 0x00000524
		// (set) Token: 0x0600004E RID: 78 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000016")]
		public Vector3 eulerAngles
		{
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x58E24B0", Offset = "0x58E10B0", VA = "0x1858E24B0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x58E26E0", Offset = "0x58E12E0", VA = "0x1858E26E0")]
			set
			{
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600004F RID: 79 RVA: 0x0000233C File Offset: 0x0000053C
		// (set) Token: 0x06000050 RID: 80 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000017")]
		[Obsolete("applyOffset is deprecated. Use trackOffset instead", true)]
		public bool applyOffsets
		{
			[Token(Token = "0x600004F")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
			set
			{
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00002354 File Offset: 0x00000554
		// (set) Token: 0x06000052 RID: 82 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000018")]
		public TrackOffset trackOffset
		{
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x58E26C0", Offset = "0x58E12C0", VA = "0x1858E26C0")]
			get
			{
				return TrackOffset.ApplyTransformOffsets;
			}
			[Token(Token = "0x6000052")]
			[Address(RVA = "0x58E28E0", Offset = "0x58E14E0", VA = "0x1858E28E0")]
			set
			{
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000053 RID: 83 RVA: 0x0000236C File Offset: 0x0000056C
		// (set) Token: 0x06000054 RID: 84 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000019")]
		public MatchTargetFields matchTargetFields
		{
			[Token(Token = "0x6000053")]
			[Address(RVA = "0x24CF740", Offset = "0x24CE340", VA = "0x1824CF740")]
			get
			{
				return (MatchTargetFields)0;
			}
			[Token(Token = "0x6000054")]
			[Address(RVA = "0x58E27B0", Offset = "0x58E13B0", VA = "0x1858E27B0")]
			set
			{
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000055 RID: 85 RVA: 0x000021E6 File Offset: 0x000003E6
		// (set) Token: 0x06000056 RID: 86 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700001A")]
		public AnimationClip infiniteClip
		{
			[Token(Token = "0x6000055")]
			[Address(RVA = "0x22F8880", Offset = "0x22F7480", VA = "0x1822F8880")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000056")]
			[Address(RVA = "0x22F8A90", Offset = "0x22F7690", VA = "0x1822F8A90")]
			internal set
			{
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00002384 File Offset: 0x00000584
		// (set) Token: 0x06000058 RID: 88 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700001B")]
		internal bool infiniteClipRemoveOffset
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x371A210", Offset = "0x3718E10", VA = "0x18371A210")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000058")]
			[Address(RVA = "0x371A3B0", Offset = "0x3718FB0", VA = "0x18371A3B0")]
			set
			{
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000059 RID: 89 RVA: 0x000021E6 File Offset: 0x000003E6
		// (set) Token: 0x0600005A RID: 90 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700001C")]
		public AvatarMask avatarMask
		{
			[Token(Token = "0x6000059")]
			[Address(RVA = "0x4D6C780", Offset = "0x4D6B380", VA = "0x184D6C780")]
			get
			{
				return null;
			}
			[Token(Token = "0x600005A")]
			[Address(RVA = "0x4D6CFE0", Offset = "0x4D6BBE0", VA = "0x184D6CFE0")]
			set
			{
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600005B RID: 91 RVA: 0x0000239C File Offset: 0x0000059C
		// (set) Token: 0x0600005C RID: 92 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700001D")]
		public bool applyAvatarMask
		{
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x2213A10", Offset = "0x2212610", VA = "0x182213A10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600005C")]
			[Address(RVA = "0x58E26D0", Offset = "0x58E12D0", VA = "0x1858E26D0")]
			set
			{
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000023B4 File Offset: 0x000005B4
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x58DF250", Offset = "0x58DDE50", VA = "0x1858DF250", Slot = "33")]
		internal override bool CanCompileClips()
		{
			return default(bool);
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600005E RID: 94 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x1700001E")]
		public override IEnumerable<PlayableBinding> outputs
		{
			[Token(Token = "0x600005E")]
			[Address(RVA = "0x58E25A0", Offset = "0x58E11A0", VA = "0x1858E25A0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600005F RID: 95 RVA: 0x000023CC File Offset: 0x000005CC
		[Token(Token = "0x1700001F")]
		public bool inClipMode
		{
			[Token(Token = "0x600005F")]
			[Address(RVA = "0x58E24D0", Offset = "0x58E10D0", VA = "0x1858E24D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000060 RID: 96 RVA: 0x000023E4 File Offset: 0x000005E4
		// (set) Token: 0x06000061 RID: 97 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000020")]
		public Vector3 infiniteClipOffsetPosition
		{
			[Token(Token = "0x6000060")]
			[Address(RVA = "0x42BAD60", Offset = "0x42B9960", VA = "0x1842BAD60")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000061")]
			[Address(RVA = "0x42BB060", Offset = "0x42B9C60", VA = "0x1842BB060")]
			set
			{
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000062 RID: 98 RVA: 0x000023FC File Offset: 0x000005FC
		// (set) Token: 0x06000063 RID: 99 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000021")]
		public Quaternion infiniteClipOffsetRotation
		{
			[Token(Token = "0x6000062")]
			[Address(RVA = "0x58E2510", Offset = "0x58E1110", VA = "0x1858E2510")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000063")]
			[Address(RVA = "0x58E2700", Offset = "0x58E1300", VA = "0x1858E2700")]
			set
			{
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00002414 File Offset: 0x00000614
		// (set) Token: 0x06000065 RID: 101 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000022")]
		public Vector3 infiniteClipOffsetEulerAngles
		{
			[Token(Token = "0x6000064")]
			[Address(RVA = "0x42BAD40", Offset = "0x42B9940", VA = "0x1842BAD40")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000065")]
			[Address(RVA = "0x42BB030", Offset = "0x42B9C30", VA = "0x1842BB030")]
			set
			{
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000066 RID: 102 RVA: 0x0000242C File Offset: 0x0000062C
		// (set) Token: 0x06000067 RID: 103 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000023")]
		internal bool infiniteClipApplyFootIK
		{
			[Token(Token = "0x6000066")]
			[Address(RVA = "0x371A300", Offset = "0x3718F00", VA = "0x18371A300")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000067")]
			[Address(RVA = "0x371A420", Offset = "0x3719020", VA = "0x18371A420")]
			set
			{
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00002444 File Offset: 0x00000644
		// (set) Token: 0x06000069 RID: 105 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000024")]
		internal double infiniteClipTimeOffset
		{
			[Token(Token = "0x6000068")]
			[Address(RVA = "0x58E2590", Offset = "0x58E1190", VA = "0x1858E2590")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6000069")]
			[Address(RVA = "0x58E27A0", Offset = "0x58E13A0", VA = "0x1858E27A0")]
			set
			{
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600006A RID: 106 RVA: 0x0000245C File Offset: 0x0000065C
		// (set) Token: 0x0600006B RID: 107 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000025")]
		public TimelineClip.ClipExtrapolation infiniteClipPreExtrapolation
		{
			[Token(Token = "0x600006A")]
			[Address(RVA = "0x371A2F0", Offset = "0x3718EF0", VA = "0x18371A2F0")]
			get
			{
				return TimelineClip.ClipExtrapolation.None;
			}
			[Token(Token = "0x600006B")]
			[Address(RVA = "0xD6EF30", Offset = "0xD6DB30", VA = "0x180D6EF30")]
			set
			{
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600006C RID: 108 RVA: 0x00002474 File Offset: 0x00000674
		// (set) Token: 0x0600006D RID: 109 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000026")]
		public TimelineClip.ClipExtrapolation infiniteClipPostExtrapolation
		{
			[Token(Token = "0x600006C")]
			[Address(RVA = "0x4211E80", Offset = "0x4210A80", VA = "0x184211E80")]
			get
			{
				return TimelineClip.ClipExtrapolation.None;
			}
			[Token(Token = "0x600006D")]
			[Address(RVA = "0x4212030", Offset = "0x4210C30", VA = "0x184212030")]
			set
			{
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600006E RID: 110 RVA: 0x0000248C File Offset: 0x0000068C
		// (set) Token: 0x0600006F RID: 111 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000027")]
		internal AnimationPlayableAsset.LoopMode infiniteClipLoop
		{
			[Token(Token = "0x600006E")]
			[Address(RVA = "0x56C4B00", Offset = "0x56C3700", VA = "0x1856C4B00")]
			get
			{
				return AnimationPlayableAsset.LoopMode.UseSourceAsset;
			}
			[Token(Token = "0x600006F")]
			[Address(RVA = "0x56C5420", Offset = "0x56C4020", VA = "0x1856C5420")]
			set
			{
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x58E2110", Offset = "0x58E0D10", VA = "0x1858E2110")]
		[ContextMenu("Reset Offsets")]
		private void ResetOffsets()
		{
		}

		// Token: 0x06000071 RID: 113 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x58DF820", Offset = "0x58DE420", VA = "0x1858DF820")]
		public TimelineClip CreateClip(AnimationClip clip)
		{
			return null;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x58DF950", Offset = "0x58DE550", VA = "0x1858DF950")]
		public void CreateInfiniteClip(string infiniteClipName)
		{
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x58E0820", Offset = "0x58DF420", VA = "0x1858E0820")]
		public TimelineClip CreateRecordableClip(string animClipName)
		{
			return null;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x58E1D60", Offset = "0x58E0960", VA = "0x1858E1D60", Slot = "30")]
		protected override void OnCreateClip(TimelineClip clip)
		{
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000024A4 File Offset: 0x000006A4
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x58DF160", Offset = "0x58DDD60", VA = "0x1858DF160", Slot = "31")]
		protected internal override int CalculateItemsHash()
		{
			return 0;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		internal void UpdateClipOffsets()
		{
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000024BC File Offset: 0x000006BC
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x58DF310", Offset = "0x58DDF10", VA = "0x1858DF310")]
		private Playable CompileTrackPlayable(PlayableGraph graph, AnimationTrack track, GameObject go, IntervalTree<RuntimeElement> tree, AppliedOffsetMode mode)
		{
			return default(Playable);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000024D4 File Offset: 0x000006D4
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x58E21A0", Offset = "0x58E0DA0", VA = "0x1858E21A0", Slot = "36")]
		private Playable CreateLayerMixer(PlayableGraph graph, GameObject go, int inputCount)
		{
			return default(Playable);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000024EC File Offset: 0x000006EC
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x58DFE70", Offset = "0x58DEA70", VA = "0x1858DFE70", Slot = "26")]
		internal override Playable CreateMixerPlayableGraph(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree)
		{
			return default(Playable);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002504 File Offset: 0x00000704
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780")]
		private int GetDefaultBlendCount()
		{
			return 0;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private void AttachDefaultBlend(PlayableGraph graph, AnimationLayerMixerPlayable mixer, bool requireOffset)
		{
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000251C File Offset: 0x0000071C
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x58DF000", Offset = "0x58DDC00", VA = "0x1858DF000")]
		private Playable AttachOffsetPlayable(PlayableGraph graph, Playable playable, Vector3 pos, Quaternion rot)
		{
			return default(Playable);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002534 File Offset: 0x00000734
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x58E2000", Offset = "0x58E0C00", VA = "0x1858E2000")]
		private bool RequiresMotionXPlayable(AppliedOffsetMode mode, GameObject gameObject)
		{
			return default(bool);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000254C File Offset: 0x0000074C
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x58E2200", Offset = "0x58E0E00", VA = "0x1858E2200")]
		private static bool UsesAbsoluteMotion(AppliedOffsetMode mode)
		{
			return default(bool);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00002564 File Offset: 0x00000764
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x58E19B0", Offset = "0x58E05B0", VA = "0x1858E19B0")]
		private bool HasController(GameObject gameObject)
		{
			return default(bool);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x58E1080", Offset = "0x58DFC80", VA = "0x1858E1080")]
		internal Animator GetBinding(PlayableDirector director)
		{
			return null;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000257C File Offset: 0x0000077C
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x58DF8D0", Offset = "0x58DE4D0", VA = "0x1858DF8D0")]
		private static AnimationLayerMixerPlayable CreateGroupMixer(PlayableGraph graph, GameObject go, int inputCount)
		{
			return default(AnimationLayerMixerPlayable);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002594 File Offset: 0x00000794
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x58DFA90", Offset = "0x58DE690", VA = "0x1858DFA90")]
		private Playable CreateInfiniteTrackPlayable(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree, AppliedOffsetMode mode)
		{
			return default(Playable);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x000025AC File Offset: 0x000007AC
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x58DEB70", Offset = "0x58DD770", VA = "0x1858DEB70")]
		private Playable ApplyTrackOffset(PlayableGraph graph, Playable root, GameObject go, AppliedOffsetMode mode)
		{
			return default(Playable);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x58E1270", Offset = "0x58DFE70", VA = "0x1858E1270", Slot = "27")]
		internal override void GetEvaluationTime(out double outStart, out double outDuration)
		{
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x58E1880", Offset = "0x58E0480", VA = "0x1858E1880", Slot = "28")]
		internal override void GetSequenceTime(out double outStart, out double outDuration)
		{
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x58DED70", Offset = "0x58DD970", VA = "0x1858DED70")]
		private void AssignAnimationClip(TimelineClip clip, AnimationClip animClip)
		{
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "29")]
		public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
		{
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x58E0BF0", Offset = "0x58DF7F0", VA = "0x1858E0BF0")]
		private void GetAnimationClips(List<AnimationClip> animClips)
		{
		}

		// Token: 0x06000089 RID: 137 RVA: 0x000025C4 File Offset: 0x000007C4
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x58E16F0", Offset = "0x58E02F0", VA = "0x1858E16F0")]
		private AppliedOffsetMode GetOffsetMode(GameObject go, bool animatesRootTransform)
		{
			return AppliedOffsetMode.NoRootTransform;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x000025DC File Offset: 0x000007DC
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x58E1AC0", Offset = "0x58E06C0", VA = "0x1858E1AC0")]
		private bool IsRootTransformDisabledByMask(GameObject gameObject, Transform genericRootNode)
		{
			return default(bool);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x58E1340", Offset = "0x58DFF40", VA = "0x1858E1340")]
		private Transform GetGenericRootNode(GameObject gameObject)
		{
			return null;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x000025F4 File Offset: 0x000007F4
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x58DE890", Offset = "0x58DD490", VA = "0x1858DE890")]
		internal bool AnimatesRootTransform()
		{
			return default(bool);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x58E09F0", Offset = "0x58DF5F0", VA = "0x1858E09F0")]
		private static Transform FindInHierarchyBreadthFirst(Transform t, string name)
		{
			return null;
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600008E RID: 142 RVA: 0x0000260C File Offset: 0x0000080C
		// (set) Token: 0x0600008F RID: 143 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000028")]
		[Obsolete("openClipOffsetPosition has been deprecated. Use infiniteClipOffsetPosition instead. (UnityUpgradable) -> infiniteClipOffsetPosition", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Vector3 openClipOffsetPosition
		{
			[Token(Token = "0x600008E")]
			[Address(RVA = "0x42BAD60", Offset = "0x42B9960", VA = "0x1842BAD60")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600008F")]
			[Address(RVA = "0x42BB060", Offset = "0x42B9C60", VA = "0x1842BB060")]
			set
			{
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00002624 File Offset: 0x00000824
		// (set) Token: 0x06000091 RID: 145 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000029")]
		[Obsolete("openClipOffsetRotation has been deprecated. Use infiniteClipOffsetRotation instead. (UnityUpgradable) -> infiniteClipOffsetRotation", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Quaternion openClipOffsetRotation
		{
			[Token(Token = "0x6000090")]
			[Address(RVA = "0x58E2510", Offset = "0x58E1110", VA = "0x1858E2510")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000091")]
			[Address(RVA = "0x58E2700", Offset = "0x58E1300", VA = "0x1858E2700")]
			set
			{
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000092 RID: 146 RVA: 0x0000263C File Offset: 0x0000083C
		// (set) Token: 0x06000093 RID: 147 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700002A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("openClipOffsetEulerAngles has been deprecated. Use infiniteClipOffsetEulerAngles instead. (UnityUpgradable) -> infiniteClipOffsetEulerAngles", true)]
		public Vector3 openClipOffsetEulerAngles
		{
			[Token(Token = "0x6000092")]
			[Address(RVA = "0x42BAD40", Offset = "0x42B9940", VA = "0x1842BAD40")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000093")]
			[Address(RVA = "0x42BB030", Offset = "0x42B9C30", VA = "0x1842BB030")]
			set
			{
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000094 RID: 148 RVA: 0x00002654 File Offset: 0x00000854
		// (set) Token: 0x06000095 RID: 149 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700002B")]
		[Obsolete("openClipPreExtrapolation has been deprecated. Use infiniteClipPreExtrapolation instead. (UnityUpgradable) -> infiniteClipPreExtrapolation", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public TimelineClip.ClipExtrapolation openClipPreExtrapolation
		{
			[Token(Token = "0x6000094")]
			[Address(RVA = "0x371A2F0", Offset = "0x3718EF0", VA = "0x18371A2F0")]
			get
			{
				return TimelineClip.ClipExtrapolation.None;
			}
			[Token(Token = "0x6000095")]
			[Address(RVA = "0xD6EF30", Offset = "0xD6DB30", VA = "0x180D6EF30")]
			set
			{
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000096 RID: 150 RVA: 0x0000266C File Offset: 0x0000086C
		// (set) Token: 0x06000097 RID: 151 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700002C")]
		[Obsolete("openClipPostExtrapolation has been deprecated. Use infiniteClipPostExtrapolation instead. (UnityUpgradable) -> infiniteClipPostExtrapolation", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public TimelineClip.ClipExtrapolation openClipPostExtrapolation
		{
			[Token(Token = "0x6000096")]
			[Address(RVA = "0x4211E80", Offset = "0x4210A80", VA = "0x184211E80")]
			get
			{
				return TimelineClip.ClipExtrapolation.None;
			}
			[Token(Token = "0x6000097")]
			[Address(RVA = "0x4212030", Offset = "0x4210C30", VA = "0x184212030")]
			set
			{
			}
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x58E1DD0", Offset = "0x58E09D0", VA = "0x1858E1DD0", Slot = "22")]
		internal override void OnUpgradeFromVersion(int oldVersion)
		{
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x58E22B0", Offset = "0x58E0EB0", VA = "0x1858E22B0")]
		public AnimationTrack()
		{
		}

		// Token: 0x04000042 RID: 66
		[Token(Token = "0x4000042")]
		private const string k_DefaultInfiniteClipName = "Recorded";

		// Token: 0x04000043 RID: 67
		[Token(Token = "0x4000043")]
		private const string k_DefaultRecordableClipName = "Recorded";

		// Token: 0x04000044 RID: 68
		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0xA0")]
		[FormerlySerializedAs("m_OpenClipPreExtrapolation")]
		[SerializeField]
		private TimelineClip.ClipExtrapolation m_InfiniteClipPreExtrapolation;

		// Token: 0x04000045 RID: 69
		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0xA4")]
		[SerializeField]
		[FormerlySerializedAs("m_OpenClipPostExtrapolation")]
		private TimelineClip.ClipExtrapolation m_InfiniteClipPostExtrapolation;

		// Token: 0x04000046 RID: 70
		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[FormerlySerializedAs("m_OpenClipOffsetPosition")]
		private Vector3 m_InfiniteClipOffsetPosition;

		// Token: 0x04000047 RID: 71
		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0xB4")]
		[FormerlySerializedAs("m_OpenClipOffsetEulerAngles")]
		[SerializeField]
		private Vector3 m_InfiniteClipOffsetEulerAngles;

		// Token: 0x04000048 RID: 72
		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[FormerlySerializedAs("m_OpenClipTimeOffset")]
		private double m_InfiniteClipTimeOffset;

		// Token: 0x04000049 RID: 73
		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0xC8")]
		[FormerlySerializedAs("m_OpenClipRemoveOffset")]
		[SerializeField]
		private bool m_InfiniteClipRemoveOffset;

		// Token: 0x0400004A RID: 74
		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0xC9")]
		[SerializeField]
		private bool m_InfiniteClipApplyFootIK;

		// Token: 0x0400004B RID: 75
		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0xCC")]
		[SerializeField]
		[HideInInspector]
		private AnimationPlayableAsset.LoopMode mInfiniteClipLoop;

		// Token: 0x0400004C RID: 76
		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private MatchTargetFields m_MatchTargetFields;

		// Token: 0x0400004D RID: 77
		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0xD4")]
		[SerializeField]
		private Vector3 m_Position;

		// Token: 0x0400004E RID: 78
		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private Vector3 m_EulerAngles;

		// Token: 0x0400004F RID: 79
		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private AvatarMask m_AvatarMask;

		// Token: 0x04000050 RID: 80
		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private bool m_ApplyAvatarMask;

		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0xFC")]
		[SerializeField]
		private TrackOffset m_TrackOffset;

		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x100")]
		[HideInInspector]
		[SerializeField]
		private AnimationClip m_InfiniteClip;

		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Queue<Transform> s_CachedQueue;

		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x108")]
		[HideInInspector]
		[Obsolete("Use m_InfiniteClipOffsetEulerAngles Instead", false)]
		[SerializeField]
		private Quaternion m_OpenClipOffsetRotation;

		// Token: 0x04000055 RID: 85
		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x118")]
		[HideInInspector]
		[SerializeField]
		[Obsolete("Use m_RotationEuler Instead", false)]
		private Quaternion m_Rotation;

		// Token: 0x04000056 RID: 86
		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x128")]
		[Obsolete("Use m_RootTransformOffsetMode", false)]
		[SerializeField]
		[HideInInspector]
		private bool m_ApplyOffsets;

		// Token: 0x02000013 RID: 19
		[Token(Token = "0x2000013")]
		private static class AnimationTrackUpgrade
		{
			// Token: 0x0600009B RID: 155 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x600009B")]
			[Address(RVA = "0x58DE750", Offset = "0x58DD350", VA = "0x1858DE750")]
			public static void ConvertRotationsToEuler(AnimationTrack track)
			{
			}

			// Token: 0x0600009C RID: 156 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x600009C")]
			[Address(RVA = "0x58DE6A0", Offset = "0x58DD2A0", VA = "0x1858DE6A0")]
			public static void ConvertRootMotion(AnimationTrack track)
			{
			}

			// Token: 0x0600009D RID: 157 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x600009D")]
			[Address(RVA = "0x58DE650", Offset = "0x58DD250", VA = "0x1858DE650")]
			public static void ConvertInfiniteTrack(AnimationTrack track)
			{
			}
		}
	}
}
