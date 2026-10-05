using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Playables;
using UnityEngine.Serialization;

namespace UnityEngine.Timeline
{
	// Token: 0x02000022 RID: 34
	[Token(Token = "0x2000022")]
	[IgnoreOnPlayableTrack]
	[Serializable]
	public abstract class TrackAsset : PlayableAsset, ISerializationCallbackReceiver, IPropertyPreview, ICurvesOwner
	{
		// Token: 0x06000148 RID: 328 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000148")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "20")]
		protected virtual void OnBeforeTrackSerialize()
		{
		}

		// Token: 0x06000149 RID: 329 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000149")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "21")]
		protected virtual void OnAfterTrackDeserialize()
		{
		}

		// Token: 0x0600014A RID: 330 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600014A")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "22")]
		internal virtual void OnUpgradeFromVersion(int oldVersion)
		{
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600014B")]
		[Address(RVA = "0x58F7FB0", Offset = "0x58F6BB0", VA = "0x1858F7FB0", Slot = "9")]
		private void OnBeforeSerialize()
		{
		}

		// Token: 0x0600014C RID: 332 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600014C")]
		[Address(RVA = "0x58F7CB0", Offset = "0x58F68B0", VA = "0x1858F7CB0", Slot = "10")]
		private void OnAfterDeserialize()
		{
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600014D")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private void UpgradeToLatestVersion()
		{
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600014E RID: 334 RVA: 0x0000207E File Offset: 0x0000027E
		// (remove) Token: 0x0600014F RID: 335 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x14000001")]
		internal static event Action<TimelineClip, GameObject, Playable> OnClipPlayableCreate
		{
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x58F8D30", Offset = "0x58F7930", VA = "0x1858F8D30")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600014F")]
			[Address(RVA = "0x58F9AE0", Offset = "0x58F86E0", VA = "0x1858F9AE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000150 RID: 336 RVA: 0x0000207E File Offset: 0x0000027E
		// (remove) Token: 0x06000151 RID: 337 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x14000002")]
		internal static event Action<TrackAsset, GameObject, Playable> OnTrackAnimationPlayableCreate
		{
			[Token(Token = "0x6000150")]
			[Address(RVA = "0x58F8E40", Offset = "0x58F7A40", VA = "0x1858F8E40")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000151")]
			[Address(RVA = "0x58F9BF0", Offset = "0x58F87F0", VA = "0x1858F9BF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000152 RID: 338 RVA: 0x00002C24 File Offset: 0x00000E24
		[Token(Token = "0x17000070")]
		public double start
		{
			[Token(Token = "0x6000152")]
			[Address(RVA = "0x58F9890", Offset = "0x58F8490", VA = "0x1858F9890")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000153 RID: 339 RVA: 0x00002C3C File Offset: 0x00000E3C
		[Token(Token = "0x17000071")]
		public double end
		{
			[Token(Token = "0x6000153")]
			[Address(RVA = "0x58F90D0", Offset = "0x58F7CD0", VA = "0x1858F90D0")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000154 RID: 340 RVA: 0x00002C54 File Offset: 0x00000E54
		[Token(Token = "0x17000072")]
		public sealed override double duration
		{
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x58F9030", Offset = "0x58F7C30", VA = "0x1858F9030", Slot = "7")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000155 RID: 341 RVA: 0x00002C6C File Offset: 0x00000E6C
		// (set) Token: 0x06000156 RID: 342 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000073")]
		public bool muted
		{
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x1636A10", Offset = "0x1635610", VA = "0x181636A10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x1636A20", Offset = "0x1635620", VA = "0x181636A20")]
			set
			{
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000157 RID: 343 RVA: 0x00002C84 File Offset: 0x00000E84
		[Token(Token = "0x17000074")]
		public bool mutedInHierarchy
		{
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x58F9610", Offset = "0x58F8210", VA = "0x1858F9610")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000158 RID: 344 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x17000075")]
		public TimelineAsset timelineAsset
		{
			[Token(Token = "0x6000158")]
			[Address(RVA = "0x58F99C0", Offset = "0x58F85C0", VA = "0x1858F99C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000159 RID: 345 RVA: 0x000021E6 File Offset: 0x000003E6
		// (set) Token: 0x0600015A RID: 346 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000076")]
		public PlayableAsset parent
		{
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			get
			{
				return null;
			}
			[Token(Token = "0x600015A")]
			[Address(RVA = "0x54AEC0", Offset = "0x549AC0", VA = "0x18054AEC0")]
			internal set
			{
			}
		}

		// Token: 0x0600015B RID: 347 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x600015B")]
		[Address(RVA = "0x58F6AC0", Offset = "0x58F56C0", VA = "0x1858F6AC0")]
		public IEnumerable<TimelineClip> GetClips()
		{
			return null;
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600015C RID: 348 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x17000077")]
		internal TimelineClip[] clips
		{
			[Token(Token = "0x600015C")]
			[Address(RVA = "0x58F8F50", Offset = "0x58F7B50", VA = "0x1858F8F50")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600015D RID: 349 RVA: 0x00002C9C File Offset: 0x00000E9C
		[Token(Token = "0x17000078")]
		public virtual bool isEmpty
		{
			[Token(Token = "0x600015D")]
			[Address(RVA = "0x58F9240", Offset = "0x58F7E40", VA = "0x1858F9240", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600015E RID: 350 RVA: 0x00002CB4 File Offset: 0x00000EB4
		[Token(Token = "0x17000079")]
		public bool hasClips
		{
			[Token(Token = "0x600015E")]
			[Address(RVA = "0x58F9160", Offset = "0x58F7D60", VA = "0x1858F9160")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600015F RID: 351 RVA: 0x00002CCC File Offset: 0x00000ECC
		[Token(Token = "0x1700007A")]
		public bool hasCurves
		{
			[Token(Token = "0x600015F")]
			[Address(RVA = "0x58F91B0", Offset = "0x58F7DB0", VA = "0x1858F91B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000160 RID: 352 RVA: 0x00002CE4 File Offset: 0x00000EE4
		[Token(Token = "0x1700007B")]
		public bool isSubTrack
		{
			[Token(Token = "0x6000160")]
			[Address(RVA = "0x58F92E0", Offset = "0x58F7EE0", VA = "0x1858F92E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000161 RID: 353 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x1700007C")]
		public override IEnumerable<PlayableBinding> outputs
		{
			[Token(Token = "0x6000161")]
			[Address(RVA = "0x58F9810", Offset = "0x58F8410", VA = "0x1858F9810", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000162 RID: 354 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x6000162")]
		[Address(RVA = "0x58F68A0", Offset = "0x58F54A0", VA = "0x1858F68A0")]
		public IEnumerable<TrackAsset> GetChildTracks()
		{
			return null;
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000163 RID: 355 RVA: 0x000021E6 File Offset: 0x000003E6
		// (set) Token: 0x06000164 RID: 356 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700007D")]
		internal string customPlayableTypename
		{
			[Token(Token = "0x6000163")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000164")]
			[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
			set
			{
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000165 RID: 357 RVA: 0x000021E6 File Offset: 0x000003E6
		// (set) Token: 0x06000166 RID: 358 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700007E")]
		public AnimationClip curves
		{
			[Token(Token = "0x6000165")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850", Slot = "12")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000166")]
			[Address(RVA = "0x4EA990", Offset = "0x4E9590", VA = "0x1804EA990")]
			internal set
			{
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000167 RID: 359 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x1700007F")]
		private string defaultCurvesName
		{
			[Token(Token = "0x6000167")]
			[Address(RVA = "0x58F8160", Offset = "0x58F6D60", VA = "0x1858F8160", Slot = "16")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000168 RID: 360 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x17000080")]
		private Object asset
		{
			[Token(Token = "0x6000168")]
			[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000169 RID: 361 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x17000081")]
		private Object assetOwner
		{
			[Token(Token = "0x6000169")]
			[Address(RVA = "0x58F8150", Offset = "0x58F6D50", VA = "0x1858F8150", Slot = "18")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600016A RID: 362 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x17000082")]
		private TrackAsset targetTrack
		{
			[Token(Token = "0x600016A")]
			[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120", Slot = "19")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600016B RID: 363 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x17000083")]
		internal List<ScriptableObject> subTracksObjects
		{
			[Token(Token = "0x600016B")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600016C RID: 364 RVA: 0x00002CFC File Offset: 0x00000EFC
		// (set) Token: 0x0600016D RID: 365 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000084")]
		public bool locked
		{
			[Token(Token = "0x600016C")]
			[Address(RVA = "0x73B8F0", Offset = "0x73A4F0", VA = "0x18073B8F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600016D")]
			[Address(RVA = "0x73B920", Offset = "0x73A520", VA = "0x18073B920")]
			set
			{
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600016E RID: 366 RVA: 0x00002D14 File Offset: 0x00000F14
		[Token(Token = "0x17000085")]
		public bool lockedInHierarchy
		{
			[Token(Token = "0x600016E")]
			[Address(RVA = "0x58F9410", Offset = "0x58F8010", VA = "0x1858F9410")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600016F RID: 367 RVA: 0x00002D2C File Offset: 0x00000F2C
		[Token(Token = "0x17000086")]
		public bool supportsNotifications
		{
			[Token(Token = "0x600016F")]
			[Address(RVA = "0x58F9920", Offset = "0x58F8520", VA = "0x1858F9920")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000170 RID: 368 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000170")]
		[Address(RVA = "0x58F8900", Offset = "0x58F7500", VA = "0x1858F8900")]
		private void __internalAwake()
		{
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000171")]
		[Address(RVA = "0x58F4200", Offset = "0x58F2E00", VA = "0x1858F4200", Slot = "15")]
		public void CreateCurves(string curvesClipName)
		{
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00002D44 File Offset: 0x00000F44
		[Token(Token = "0x6000172")]
		[Address(RVA = "0x58F5B60", Offset = "0x58F4760", VA = "0x1858F5B60", Slot = "24")]
		public virtual Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
		{
			return default(Playable);
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00002D5C File Offset: 0x00000F5C
		[Token(Token = "0x6000173")]
		[Address(RVA = "0x58F57B0", Offset = "0x58F43B0", VA = "0x1858F57B0", Slot = "6")]
		public sealed override Playable CreatePlayable(PlayableGraph graph, GameObject go)
		{
			return default(Playable);
		}

		// Token: 0x06000174 RID: 372 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x6000174")]
		[Address(RVA = "0x58F42C0", Offset = "0x58F2EC0", VA = "0x1858F42C0")]
		public TimelineClip CreateDefaultClip()
		{
			return null;
		}

		// Token: 0x06000175 RID: 373 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x6000175")]
		public TimelineClip CreateClip<T>() where T : ScriptableObject, IPlayableAsset
		{
			return null;
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00002D74 File Offset: 0x00000F74
		[Token(Token = "0x6000176")]
		[Address(RVA = "0x58F5BE0", Offset = "0x58F47E0", VA = "0x1858F5BE0")]
		public bool DeleteClip(TimelineClip clip)
		{
			return default(bool);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x6000177")]
		[Address(RVA = "0x58F45B0", Offset = "0x58F31B0", VA = "0x1858F45B0")]
		public IMarker CreateMarker(Type type, double time)
		{
			return null;
		}

		// Token: 0x06000178 RID: 376 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x6000178")]
		public T CreateMarker<T>(double time) where T : ScriptableObject, IMarker
		{
			return null;
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00002D8C File Offset: 0x00000F8C
		[Token(Token = "0x6000179")]
		[Address(RVA = "0x58F5D50", Offset = "0x58F4950", VA = "0x1858F5D50")]
		public bool DeleteMarker(IMarker marker)
		{
			return default(bool);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x600017A")]
		[Address(RVA = "0x58F6FC0", Offset = "0x58F5BC0", VA = "0x1858F6FC0")]
		public IEnumerable<IMarker> GetMarkers()
		{
			return null;
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00002DA4 File Offset: 0x00000FA4
		[Token(Token = "0x600017B")]
		[Address(RVA = "0x58F6F10", Offset = "0x58F5B10", VA = "0x1858F6F10")]
		public int GetMarkerCount()
		{
			return 0;
		}

		// Token: 0x0600017C RID: 380 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x600017C")]
		[Address(RVA = "0x58F6F60", Offset = "0x58F5B60", VA = "0x1858F6F60")]
		public IMarker GetMarker(int idx)
		{
			return null;
		}

		// Token: 0x0600017D RID: 381 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x600017D")]
		[Address(RVA = "0x58F40B0", Offset = "0x58F2CB0", VA = "0x1858F40B0")]
		internal TimelineClip CreateClip(Type requestedType)
		{
			return null;
		}

		// Token: 0x0600017E RID: 382 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x600017E")]
		[Address(RVA = "0x58F3950", Offset = "0x58F2550", VA = "0x1858F3950")]
		internal TimelineClip CreateAndAddNewClipOfType(Type requestedType)
		{
			return null;
		}

		// Token: 0x0600017F RID: 383 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x600017F")]
		[Address(RVA = "0x58F3E40", Offset = "0x58F2A40", VA = "0x1858F3E40")]
		internal TimelineClip CreateClipOfType(Type requestedType)
		{
			return null;
		}

		// Token: 0x06000180 RID: 384 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x6000180")]
		[Address(RVA = "0x58F3B90", Offset = "0x58F2790", VA = "0x1858F3B90")]
		internal TimelineClip CreateClipFromPlayableAsset(IPlayableAsset asset)
		{
			return null;
		}

		// Token: 0x06000181 RID: 385 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x6000181")]
		[Address(RVA = "0x58F3990", Offset = "0x58F2590", VA = "0x1858F3990")]
		private TimelineClip CreateClipFromAsset(ScriptableObject playableAsset)
		{
			return null;
		}

		// Token: 0x06000182 RID: 386 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x6000182")]
		[Address(RVA = "0xEB4B60", Offset = "0xEB3760", VA = "0x180EB4B60")]
		internal IEnumerable<ScriptableObject> GetMarkersRaw()
		{
			return null;
		}

		// Token: 0x06000183 RID: 387 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000183")]
		[Address(RVA = "0x58F3250", Offset = "0x58F1E50", VA = "0x1858F3250")]
		internal void ClearMarkers()
		{
		}

		// Token: 0x06000184 RID: 388 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000184")]
		[Address(RVA = "0x58F2EF0", Offset = "0x58F1AF0", VA = "0x1858F2EF0")]
		internal void AddMarker(ScriptableObject e)
		{
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00002DBC File Offset: 0x00000FBC
		[Token(Token = "0x6000185")]
		[Address(RVA = "0x58F5D10", Offset = "0x58F4910", VA = "0x1858F5D10")]
		internal bool DeleteMarkerRaw(ScriptableObject marker)
		{
			return default(bool);
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00002DD4 File Offset: 0x00000FD4
		[Token(Token = "0x6000186")]
		[Address(RVA = "0x58F71E0", Offset = "0x58F5DE0", VA = "0x1858F71E0")]
		private int GetTimeRangeHash()
		{
			return 0;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000187")]
		[Address(RVA = "0x58F2E50", Offset = "0x58F1A50", VA = "0x1858F2E50")]
		internal void AddClip(TimelineClip newClip)
		{
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00002DEC File Offset: 0x00000FEC
		[Token(Token = "0x6000188")]
		[Address(RVA = "0x58F50A0", Offset = "0x58F3CA0", VA = "0x1858F50A0")]
		private Playable CreateNotificationsPlayable(PlayableGraph graph, Playable mixerPlayable, GameObject go, Playable timelinePlayable)
		{
			return default(Playable);
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00002E04 File Offset: 0x00001004
		[Token(Token = "0x6000189")]
		[Address(RVA = "0x58F5420", Offset = "0x58F4020", VA = "0x1858F5420")]
		internal Playable CreatePlayableGraph(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree, Playable timelinePlayable)
		{
			return default(Playable);
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00002E1C File Offset: 0x0000101C
		[Token(Token = "0x600018A")]
		[Address(RVA = "0x58F3350", Offset = "0x58F1F50", VA = "0x1858F3350", Slot = "25")]
		internal virtual Playable CompileClips(PlayableGraph graph, GameObject go, IList<TimelineClip> timelineClips, IntervalTree<RuntimeElement> tree)
		{
			return default(Playable);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600018B")]
		[Address(RVA = "0x58F5D60", Offset = "0x58F4960", VA = "0x1858F5D60")]
		private void GatherCompilableTracks(IList<TrackAsset> tracks)
		{
		}

		// Token: 0x0600018C RID: 396 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600018C")]
		[Address(RVA = "0x58F5FF0", Offset = "0x58F4BF0", VA = "0x1858F5FF0")]
		private void GatherNotifications(List<IMarker> markers)
		{
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00002E34 File Offset: 0x00001034
		[Token(Token = "0x600018D")]
		[Address(RVA = "0x58F45E0", Offset = "0x58F31E0", VA = "0x1858F45E0", Slot = "26")]
		internal virtual Playable CreateMixerPlayableGraph(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree)
		{
			return default(Playable);
		}

		// Token: 0x0600018E RID: 398 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600018E")]
		[Address(RVA = "0x58F37E0", Offset = "0x58F23E0", VA = "0x1858F37E0")]
		internal void ConfigureTrackAnimation(IntervalTree<RuntimeElement> tree, GameObject go, Playable blend)
		{
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600018F")]
		[Address(RVA = "0x58F7B60", Offset = "0x58F6760", VA = "0x1858F7B60")]
		internal void SortClips()
		{
		}

		// Token: 0x06000190 RID: 400 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000190")]
		[Address(RVA = "0x58F31C0", Offset = "0x58F1DC0", VA = "0x1858F31C0")]
		internal void ClearClipsInternal()
		{
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000191")]
		[Address(RVA = "0x58F32C0", Offset = "0x58F1EC0", VA = "0x1858F32C0")]
		internal void ClearSubTracksInternal()
		{
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000192")]
		[Address(RVA = "0x524930", Offset = "0x523530", VA = "0x180524930")]
		internal void OnClipMove()
		{
		}

		// Token: 0x06000193 RID: 403 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x6000193")]
		[Address(RVA = "0x58F4D80", Offset = "0x58F3980", VA = "0x1858F4D80")]
		internal TimelineClip CreateNewClipContainerInternal()
		{
			return null;
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000194")]
		[Address(RVA = "0x58F2DA0", Offset = "0x58F19A0", VA = "0x1858F2DA0")]
		internal void AddChild(TrackAsset child)
		{
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000195")]
		[Address(RVA = "0x58F7860", Offset = "0x58F6460", VA = "0x1858F7860")]
		internal void MoveLastTrackBefore(TrackAsset asset)
		{
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00002E4C File Offset: 0x0000104C
		[Token(Token = "0x6000196")]
		[Address(RVA = "0x58F7AD0", Offset = "0x58F66D0", VA = "0x1858F7AD0")]
		internal bool RemoveSubTrack(TrackAsset child)
		{
			return default(bool);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000197")]
		[Address(RVA = "0x58F7A60", Offset = "0x58F6660", VA = "0x1858F7A60")]
		internal void RemoveClip(TimelineClip clip)
		{
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000198")]
		[Address(RVA = "0x58F6AD0", Offset = "0x58F56D0", VA = "0x1858F6AD0", Slot = "27")]
		internal virtual void GetEvaluationTime(out double outStart, out double outDuration)
		{
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000199")]
		[Address(RVA = "0x58F7180", Offset = "0x58F5D80", VA = "0x1858F7180", Slot = "28")]
		internal virtual void GetSequenceTime(out double outStart, out double outDuration)
		{
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600019A")]
		[Address(RVA = "0x58F6280", Offset = "0x58F4E80", VA = "0x1858F6280", Slot = "29")]
		public virtual void GatherProperties(PlayableDirector director, IPropertyCollector driver)
		{
		}

		// Token: 0x0600019B RID: 411 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x600019B")]
		[Address(RVA = "0x58F6D70", Offset = "0x58F5970", VA = "0x1858F6D70")]
		internal GameObject GetGameObjectBinding(PlayableDirector director)
		{
			return null;
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00002E64 File Offset: 0x00001064
		[Token(Token = "0x600019C")]
		[Address(RVA = "0x58F8580", Offset = "0x58F7180", VA = "0x1858F8580")]
		internal bool ValidateClipType(Type clipType)
		{
			return default(bool);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600019D")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "30")]
		protected virtual void OnCreateClip(TimelineClip clip)
		{
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600019E")]
		[Address(RVA = "0x58F8400", Offset = "0x58F7000", VA = "0x1858F8400")]
		private void UpdateDuration()
		{
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00002E7C File Offset: 0x0000107C
		[Token(Token = "0x600019F")]
		[Address(RVA = "0x58F2F00", Offset = "0x58F1B00", VA = "0x1858F2F00", Slot = "31")]
		protected internal virtual int CalculateItemsHash()
		{
			return 0;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00002E94 File Offset: 0x00001094
		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x58F5810", Offset = "0x58F4410", VA = "0x1858F5810", Slot = "32")]
		protected virtual Playable CreatePlayable(PlayableGraph graph, GameObject gameObject, TimelineClip clip)
		{
			return default(Playable);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x58F7500", Offset = "0x58F6100", VA = "0x1858F7500")]
		internal void Invalidate()
		{
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00002EAC File Offset: 0x000010AC
		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x58F6FF0", Offset = "0x58F5BF0", VA = "0x1858F6FF0")]
		internal double GetNotificationDuration()
		{
			return 0.0;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00002EC4 File Offset: 0x000010C4
		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x58F2F90", Offset = "0x58F1B90", VA = "0x1858F2F90", Slot = "33")]
		internal virtual bool CanCompileClips()
		{
			return default(bool);
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00002EDC File Offset: 0x000010DC
		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x4FA8250", Offset = "0x4FA6E50", VA = "0x184FA8250", Slot = "34")]
		public virtual bool CanCreateTrackMixer()
		{
			return default(bool);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00002EF4 File Offset: 0x000010F4
		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x58F75B0", Offset = "0x58F61B0", VA = "0x1858F75B0")]
		internal bool IsCompilable()
		{
			return default(bool);
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x58F8190", Offset = "0x58F6D90", VA = "0x1858F8190")]
		private void UpdateChildTrackCache()
		{
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00002F0C File Offset: 0x0000110C
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x58F7490", Offset = "0x58F6090", VA = "0x1858F7490", Slot = "35")]
		internal virtual int Hash()
		{
			return 0;
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00002F24 File Offset: 0x00001124
		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x58F68C0", Offset = "0x58F54C0", VA = "0x1858F68C0")]
		private int GetClipsHash()
		{
			return 0;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00002F3C File Offset: 0x0000113C
		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x58F67D0", Offset = "0x58F53D0", VA = "0x1858F67D0")]
		protected static int GetAnimationClipHash(AnimationClip clip)
		{
			return 0;
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00002F54 File Offset: 0x00001154
		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x58F7460", Offset = "0x58F6060", VA = "0x1858F7460")]
		private bool HasNotifications()
		{
			return default(bool);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00002F6C File Offset: 0x0000116C
		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x58F2FE0", Offset = "0x58F1BE0", VA = "0x1858F2FE0")]
		private bool CanCompileNotifications()
		{
			return default(bool);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00002F84 File Offset: 0x00001184
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x58F3020", Offset = "0x58F1C20", VA = "0x1858F3020")]
		private bool CanCreateMixerRecursive()
		{
			return default(bool);
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x58F8C40", Offset = "0x58F7840", VA = "0x1858F8C40")]
		protected TrackAsset()
		{
		}

		// Token: 0x040000A8 RID: 168
		[Token(Token = "0x40000A8")]
		private const int k_LatestVersion = 3;

		// Token: 0x040000A9 RID: 169
		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x18")]
		[HideInInspector]
		[SerializeField]
		private int m_Version;

		// Token: 0x040000AA RID: 170
		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[FormerlySerializedAs("m_animClip")]
		[HideInInspector]
		[Obsolete("Please use m_InfiniteClip (on AnimationTrack) instead.", false)]
		internal AnimationClip m_AnimClip;

		// Token: 0x040000AB RID: 171
		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x0")]
		private static TrackAsset.TransientBuildData s_BuildData;

		// Token: 0x040000AC RID: 172
		[Token(Token = "0x40000AC")]
		internal const string kDefaultCurvesName = "Track Parameters";

		// Token: 0x040000AF RID: 175
		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x28")]
		[HideInInspector]
		[SerializeField]
		private bool m_Locked;

		// Token: 0x040000B0 RID: 176
		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x29")]
		[SerializeField]
		[HideInInspector]
		private bool m_Muted;

		// Token: 0x040000B1 RID: 177
		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[HideInInspector]
		private string m_CustomPlayableFullTypename;

		// Token: 0x040000B2 RID: 178
		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x38")]
		[HideInInspector]
		[SerializeField]
		private AnimationClip m_Curves;

		// Token: 0x040000B3 RID: 179
		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		private PlayableAsset m_Parent;

		// Token: 0x040000B4 RID: 180
		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[HideInInspector]
		private List<ScriptableObject> m_Children;

		// Token: 0x040000B5 RID: 181
		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		private int m_ItemsHash;

		// Token: 0x040000B6 RID: 182
		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x58")]
		[NonSerialized]
		private TimelineClip[] m_ClipsCache;

		// Token: 0x040000B7 RID: 183
		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x60")]
		private DiscreteTime m_Start;

		// Token: 0x040000B8 RID: 184
		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x68")]
		private DiscreteTime m_End;

		// Token: 0x040000B9 RID: 185
		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x70")]
		private bool m_CacheSorted;

		// Token: 0x040000BA RID: 186
		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x71")]
		private bool? m_SupportsNotifications;

		// Token: 0x040000BB RID: 187
		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0x28")]
		private static TrackAsset[] s_EmptyCache;

		// Token: 0x040000BC RID: 188
		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x78")]
		private IEnumerable<TrackAsset> m_ChildTrackCache;

		// Token: 0x040000BD RID: 189
		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x30")]
		private static Dictionary<Type, TrackBindingTypeAttribute> s_TrackBindingTypeAttributeCache;

		// Token: 0x040000BE RID: 190
		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x80")]
		[HideInInspector]
		[SerializeField]
		protected internal List<TimelineClip> m_Clips;

		// Token: 0x040000BF RID: 191
		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x88")]
		[HideInInspector]
		[SerializeField]
		private MarkerList m_Markers;

		// Token: 0x02000023 RID: 35
		[Token(Token = "0x2000023")]
		internal enum Versions
		{
			// Token: 0x040000C1 RID: 193
			[Token(Token = "0x40000C1")]
			Initial,
			// Token: 0x040000C2 RID: 194
			[Token(Token = "0x40000C2")]
			RotationAsEuler,
			// Token: 0x040000C3 RID: 195
			[Token(Token = "0x40000C3")]
			RootMotionUpgrade,
			// Token: 0x040000C4 RID: 196
			[Token(Token = "0x40000C4")]
			AnimatedTrackProperties
		}

		// Token: 0x02000024 RID: 36
		[Token(Token = "0x2000024")]
		private static class TrackAssetUpgrade
		{
		}

		// Token: 0x02000025 RID: 37
		[Token(Token = "0x2000025")]
		private struct TransientBuildData
		{
			// Token: 0x060001AF RID: 431 RVA: 0x00002F9C File Offset: 0x0000119C
			[Token(Token = "0x60001AF")]
			[Address(RVA = "0x58F9E40", Offset = "0x58F8A40", VA = "0x1858F9E40")]
			public static TrackAsset.TransientBuildData Create()
			{
				return default(TrackAsset.TransientBuildData);
			}

			// Token: 0x060001B0 RID: 432 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x60001B0")]
			[Address(RVA = "0x58F9D70", Offset = "0x58F8970", VA = "0x1858F9D70")]
			public void Clear()
			{
			}

			// Token: 0x040000C5 RID: 197
			[Token(Token = "0x40000C5")]
			[FieldOffset(Offset = "0x0")]
			public List<TrackAsset> trackList;

			// Token: 0x040000C6 RID: 198
			[Token(Token = "0x40000C6")]
			[FieldOffset(Offset = "0x8")]
			public List<TimelineClip> clipList;

			// Token: 0x040000C7 RID: 199
			[Token(Token = "0x40000C7")]
			[FieldOffset(Offset = "0x10")]
			public List<IMarker> markerList;
		}
	}
}
