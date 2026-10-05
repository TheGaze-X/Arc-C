using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x0200001B RID: 27
	[Token(Token = "0x200001B")]
	[ExcludeFromPreset]
	[Serializable]
	public class TimelineAsset : PlayableAsset, ISerializationCallbackReceiver, ITimelineClipAsset, IPropertyPreview
	{
		// Token: 0x06000108 RID: 264 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private void UpgradeToLatestVersion()
		{
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000109 RID: 265 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x17000060")]
		public TimelineAsset.EditorSettings editorSettings
		{
			[Token(Token = "0x6000109")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600010A RID: 266 RVA: 0x00002AA4 File Offset: 0x00000CA4
		[Token(Token = "0x17000061")]
		public override double duration
		{
			[Token(Token = "0x600010A")]
			[Address(RVA = "0x58EFC10", Offset = "0x58EE810", VA = "0x1858EFC10", Slot = "7")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600010B RID: 267 RVA: 0x00002ABC File Offset: 0x00000CBC
		// (set) Token: 0x0600010C RID: 268 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000062")]
		public double fixedDuration
		{
			[Token(Token = "0x600010B")]
			[Address(RVA = "0x58EFCE0", Offset = "0x58EE8E0", VA = "0x1858EFCE0")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x600010C")]
			[Address(RVA = "0x58F0070", Offset = "0x58EEC70", VA = "0x1858F0070")]
			set
			{
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600010D RID: 269 RVA: 0x00002AD4 File Offset: 0x00000CD4
		// (set) Token: 0x0600010E RID: 270 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000063")]
		public TimelineAsset.DurationMode durationMode
		{
			[Token(Token = "0x600010D")]
			[Address(RVA = "0x509F60", Offset = "0x508B60", VA = "0x180509F60")]
			get
			{
				return TimelineAsset.DurationMode.BasedOnClips;
			}
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x509F70", Offset = "0x508B70", VA = "0x180509F70")]
			set
			{
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600010F RID: 271 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x17000064")]
		public override IEnumerable<PlayableBinding> outputs
		{
			[Token(Token = "0x600010F")]
			[Address(RVA = "0x58EFFA0", Offset = "0x58EEBA0", VA = "0x1858EFFA0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000110 RID: 272 RVA: 0x00002AEC File Offset: 0x00000CEC
		[Token(Token = "0x17000065")]
		public ClipCaps clipCaps
		{
			[Token(Token = "0x6000110")]
			[Address(RVA = "0x58EFA60", Offset = "0x58EE660", VA = "0x1858EFA60", Slot = "11")]
			get
			{
				return ClipCaps.None;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000111 RID: 273 RVA: 0x00002B04 File Offset: 0x00000D04
		[Token(Token = "0x17000066")]
		public int outputTrackCount
		{
			[Token(Token = "0x6000111")]
			[Address(RVA = "0x58EFF70", Offset = "0x58EEB70", VA = "0x1858EFF70")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000112 RID: 274 RVA: 0x00002B1C File Offset: 0x00000D1C
		[Token(Token = "0x17000067")]
		public int rootTrackCount
		{
			[Token(Token = "0x6000112")]
			[Address(RVA = "0x58F0020", Offset = "0x58EEC20", VA = "0x1858F0020")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000113 RID: 275 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000113")]
		[Address(RVA = "0x58EF000", Offset = "0x58EDC00", VA = "0x1858EF000")]
		private void OnValidate()
		{
		}

		// Token: 0x06000114 RID: 276 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x58EEC80", Offset = "0x58ED880", VA = "0x1858EEC80")]
		public TrackAsset GetRootTrack(int index)
		{
			return null;
		}

		// Token: 0x06000115 RID: 277 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x58EECE0", Offset = "0x58ED8E0", VA = "0x1858EECE0")]
		public IEnumerable<TrackAsset> GetRootTracks()
		{
			return null;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x58EEC10", Offset = "0x58ED810", VA = "0x1858EEC10")]
		public TrackAsset GetOutputTrack(int index)
		{
			return null;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x6000117")]
		[Address(RVA = "0x58EEC60", Offset = "0x58ED860", VA = "0x1858EEC60")]
		public IEnumerable<TrackAsset> GetOutputTracks()
		{
			return null;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00002B34 File Offset: 0x00000D34
		[Token(Token = "0x6000118")]
		[Address(RVA = "0x58EED00", Offset = "0x58ED900", VA = "0x1858EED00")]
		private static double GetValidFrameRate(double frameRate)
		{
			return 0.0;
		}

		// Token: 0x06000119 RID: 281 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000119")]
		[Address(RVA = "0x58EF4C0", Offset = "0x58EE0C0", VA = "0x1858EF4C0")]
		private void UpdateRootTrackCache()
		{
		}

		// Token: 0x0600011A RID: 282 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600011A")]
		[Address(RVA = "0x58EF2D0", Offset = "0x58EDED0", VA = "0x1858EF2D0")]
		private void UpdateOutputTrackCache()
		{
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600011B RID: 283 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x17000068")]
		internal TrackAsset[] flattenedTracks
		{
			[Token(Token = "0x600011B")]
			[Address(RVA = "0x58EFDF0", Offset = "0x58EE9F0", VA = "0x1858EFDF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600011C RID: 284 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x17000069")]
		public MarkerTrack markerTrack
		{
			[Token(Token = "0x600011C")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600011D RID: 285 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x1700006A")]
		internal List<ScriptableObject> trackObjects
		{
			[Token(Token = "0x600011D")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600011E RID: 286 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x58ED0A0", Offset = "0x58EBCA0", VA = "0x1858ED0A0")]
		internal void AddTrackInternal(TrackAsset track)
		{
		}

		// Token: 0x0600011F RID: 287 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600011F")]
		[Address(RVA = "0x58EF040", Offset = "0x58EDC40", VA = "0x1858EF040")]
		internal void RemoveTrack(TrackAsset track)
		{
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00002B4C File Offset: 0x00000D4C
		[Token(Token = "0x6000120")]
		[Address(RVA = "0x58ED930", Offset = "0x58EC530", VA = "0x1858ED930", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
		{
			return default(Playable);
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000121")]
		[Address(RVA = "0x1FC1100", Offset = "0x1FBFD00", VA = "0x181FC1100", Slot = "9")]
		private void OnBeforeSerialize()
		{
		}

		// Token: 0x06000122 RID: 290 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000122")]
		[Address(RVA = "0x58EF1E0", Offset = "0x58EDDE0", VA = "0x1858EF1E0", Slot = "10")]
		private void OnAfterDeserialize()
		{
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000123")]
		[Address(RVA = "0x58EF7F0", Offset = "0x58EE3F0", VA = "0x1858EF7F0")]
		private void __internalAwake()
		{
		}

		// Token: 0x06000124 RID: 292 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000124")]
		[Address(RVA = "0x58EEA00", Offset = "0x58ED600", VA = "0x1858EEA00", Slot = "12")]
		public void GatherProperties(PlayableDirector director, IPropertyCollector driver)
		{
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000125")]
		[Address(RVA = "0x58ED810", Offset = "0x58EC410", VA = "0x1858ED810")]
		public void CreateMarkerTrack()
		{
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000126")]
		[Address(RVA = "0x58EEDB0", Offset = "0x58ED9B0", VA = "0x1858EEDB0")]
		internal void Invalidate()
		{
		}

		// Token: 0x06000127 RID: 295 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000127")]
		[Address(RVA = "0x58EF230", Offset = "0x58EDE30", VA = "0x1858EF230")]
		internal void UpdateFixedDurationWithItemsDuration()
		{
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00002B64 File Offset: 0x00000D64
		[Token(Token = "0x6000128")]
		[Address(RVA = "0x58ED5D0", Offset = "0x58EC1D0", VA = "0x1858ED5D0")]
		private DiscreteTime CalculateItemsDuration()
		{
			return default(DiscreteTime);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000129")]
		[Address(RVA = "0x58ECE50", Offset = "0x58EBA50", VA = "0x1858ECE50")]
		private static void AddSubTracksRecursive(TrackAsset track, ref List<TrackAsset> allTracks)
		{
		}

		// Token: 0x0600012A RID: 298 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x600012A")]
		[Address(RVA = "0x58EDB30", Offset = "0x58EC730", VA = "0x1858EDB30")]
		public TrackAsset CreateTrack(Type type, TrackAsset parent, string name)
		{
			return null;
		}

		// Token: 0x0600012B RID: 299 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x600012B")]
		public T CreateTrack<T>(TrackAsset parent, string trackName) where T : TrackAsset, new()
		{
			return null;
		}

		// Token: 0x0600012C RID: 300 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x600012C")]
		public T CreateTrack<T>(string trackName) where T : TrackAsset, new()
		{
			return null;
		}

		// Token: 0x0600012D RID: 301 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x600012D")]
		public T CreateTrack<T>() where T : TrackAsset, new()
		{
			return null;
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00002B7C File Offset: 0x00000D7C
		[Token(Token = "0x600012E")]
		[Address(RVA = "0x58EDEC0", Offset = "0x58ECAC0", VA = "0x1858EDEC0")]
		public bool DeleteClip(TimelineClip clip)
		{
			return default(bool);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00002B94 File Offset: 0x00000D94
		[Token(Token = "0x600012F")]
		[Address(RVA = "0x58EE4B0", Offset = "0x58ED0B0", VA = "0x1858EE4B0")]
		public bool DeleteTrack(TrackAsset track)
		{
			return default(bool);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000130")]
		[Address(RVA = "0x58EEE00", Offset = "0x58EDA00", VA = "0x1858EEE00")]
		internal void MoveLastTrackBefore(TrackAsset asset)
		{
		}

		// Token: 0x06000131 RID: 305 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x6000131")]
		[Address(RVA = "0x58ED140", Offset = "0x58EBD40", VA = "0x1858ED140")]
		private TrackAsset AllocateTrack(TrackAsset trackAssetParent, string trackName, Type trackType)
		{
			return null;
		}

		// Token: 0x06000132 RID: 306 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000132")]
		[Address(RVA = "0x58EE1E0", Offset = "0x58ECDE0", VA = "0x1858EE1E0")]
		private void DeleteRecordedAnimation(TrackAsset track)
		{
		}

		// Token: 0x06000133 RID: 307 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000133")]
		[Address(RVA = "0x58EE340", Offset = "0x58ECF40", VA = "0x1858EE340")]
		private void DeleteRecordedAnimation(TimelineClip clip)
		{
		}

		// Token: 0x06000134 RID: 308 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000134")]
		[Address(RVA = "0x58EF9A0", Offset = "0x58EE5A0", VA = "0x1858EF9A0")]
		public TimelineAsset()
		{
		}

		// Token: 0x04000086 RID: 134
		[Token(Token = "0x4000086")]
		private const int k_LatestVersion = 0;

		// Token: 0x04000087 RID: 135
		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[HideInInspector]
		private int m_Version;

		// Token: 0x04000088 RID: 136
		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x20")]
		[HideInInspector]
		[SerializeField]
		private List<ScriptableObject> m_Tracks;

		// Token: 0x04000089 RID: 137
		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x28")]
		[HideInInspector]
		[SerializeField]
		private double m_FixedDuration;

		// Token: 0x0400008A RID: 138
		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x30")]
		[HideInInspector]
		[NonSerialized]
		private TrackAsset[] m_CacheOutputTracks;

		// Token: 0x0400008B RID: 139
		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x38")]
		[HideInInspector]
		[NonSerialized]
		private List<TrackAsset> m_CacheRootTracks;

		// Token: 0x0400008C RID: 140
		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x40")]
		[HideInInspector]
		[NonSerialized]
		private TrackAsset[] m_CacheFlattenedTracks;

		// Token: 0x0400008D RID: 141
		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[HideInInspector]
		private TimelineAsset.EditorSettings m_EditorSettings;

		// Token: 0x0400008E RID: 142
		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TimelineAsset.DurationMode m_DurationMode;

		// Token: 0x0400008F RID: 143
		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x58")]
		[HideInInspector]
		[SerializeField]
		private MarkerTrack m_MarkerTrack;

		// Token: 0x0200001C RID: 28
		[Token(Token = "0x200001C")]
		private enum Versions
		{
			// Token: 0x04000091 RID: 145
			[Token(Token = "0x4000091")]
			Initial
		}

		// Token: 0x0200001D RID: 29
		[Token(Token = "0x200001D")]
		private static class TimelineAssetUpgrade
		{
		}

		// Token: 0x0200001E RID: 30
		[Token(Token = "0x200001E")]
		[Obsolete("MediaType has been deprecated. It is no longer required, and will be removed in a future release.", false)]
		public enum MediaType
		{
			// Token: 0x04000093 RID: 147
			[Token(Token = "0x4000093")]
			Animation,
			// Token: 0x04000094 RID: 148
			[Token(Token = "0x4000094")]
			Audio,
			// Token: 0x04000095 RID: 149
			[Token(Token = "0x4000095")]
			Texture,
			// Token: 0x04000096 RID: 150
			[Token(Token = "0x4000096")]
			[Obsolete("Use Texture MediaType instead. (UnityUpgradable) -> UnityEngine.Timeline.TimelineAsset/MediaType.Texture", false)]
			Video = 2,
			// Token: 0x04000097 RID: 151
			[Token(Token = "0x4000097")]
			Script,
			// Token: 0x04000098 RID: 152
			[Token(Token = "0x4000098")]
			Hybrid,
			// Token: 0x04000099 RID: 153
			[Token(Token = "0x4000099")]
			Group
		}

		// Token: 0x0200001F RID: 31
		[Token(Token = "0x200001F")]
		public enum DurationMode
		{
			// Token: 0x0400009B RID: 155
			[Token(Token = "0x400009B")]
			BasedOnClips,
			// Token: 0x0400009C RID: 156
			[Token(Token = "0x400009C")]
			FixedLength
		}

		// Token: 0x02000020 RID: 32
		[Token(Token = "0x2000020")]
		[Serializable]
		public class EditorSettings
		{
			// Token: 0x1700006B RID: 107
			// (get) Token: 0x06000135 RID: 309 RVA: 0x00002BAC File Offset: 0x00000DAC
			// (set) Token: 0x06000136 RID: 310 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x1700006B")]
			[Obsolete("EditorSettings.fps has been deprecated. Use editorSettings.frameRate instead.", false)]
			public float fps
			{
				[Token(Token = "0x6000135")]
				[Address(RVA = "0x58E9500", Offset = "0x58E8100", VA = "0x1858E9500")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x6000136")]
				[Address(RVA = "0x58E9510", Offset = "0x58E8110", VA = "0x1858E9510")]
				set
				{
				}
			}

			// Token: 0x1700006C RID: 108
			// (get) Token: 0x06000137 RID: 311 RVA: 0x00002BC4 File Offset: 0x00000DC4
			// (set) Token: 0x06000138 RID: 312 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x1700006C")]
			public double frameRate
			{
				[Token(Token = "0x6000137")]
				[Address(RVA = "0x28614A0", Offset = "0x28600A0", VA = "0x1828614A0")]
				get
				{
					return 0.0;
				}
				[Token(Token = "0x6000138")]
				[Address(RVA = "0x58E95C0", Offset = "0x58E81C0", VA = "0x1858E95C0")]
				set
				{
				}
			}

			// Token: 0x06000139 RID: 313 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x6000139")]
			[Address(RVA = "0x58E9290", Offset = "0x58E7E90", VA = "0x1858E9290")]
			public void SetStandardFrameRate(StandardFrameRates enumValue)
			{
			}

			// Token: 0x1700006D RID: 109
			// (get) Token: 0x0600013A RID: 314 RVA: 0x00002BDC File Offset: 0x00000DDC
			// (set) Token: 0x0600013B RID: 315 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x1700006D")]
			public bool scenePreview
			{
				[Token(Token = "0x600013A")]
				[Address(RVA = "0x4F4E70", Offset = "0x4F3A70", VA = "0x1804F4E70")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600013B")]
				[Address(RVA = "0x4F4E80", Offset = "0x4F3A80", VA = "0x1804F4E80")]
				set
				{
				}
			}

			// Token: 0x0600013C RID: 316 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x600013C")]
			[Address(RVA = "0x58E9490", Offset = "0x58E8090", VA = "0x1858E9490")]
			public EditorSettings()
			{
			}

			// Token: 0x0400009D RID: 157
			[Token(Token = "0x400009D")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly double kMinFrameRate;

			// Token: 0x0400009E RID: 158
			[Token(Token = "0x400009E")]
			[FieldOffset(Offset = "0x8")]
			internal static readonly double kMaxFrameRate;

			// Token: 0x0400009F RID: 159
			[Token(Token = "0x400009F")]
			[FieldOffset(Offset = "0x10")]
			internal static readonly double kDefaultFrameRate;

			// Token: 0x040000A0 RID: 160
			[Token(Token = "0x40000A0")]
			[FieldOffset(Offset = "0x10")]
			[FrameRateField]
			[HideInInspector]
			[SerializeField]
			private double m_Framerate;

			// Token: 0x040000A1 RID: 161
			[Token(Token = "0x40000A1")]
			[FieldOffset(Offset = "0x18")]
			[HideInInspector]
			[SerializeField]
			private bool m_ScenePreview;
		}
	}
}
