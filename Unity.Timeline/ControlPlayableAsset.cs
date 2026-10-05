using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x02000032 RID: 50
	[Token(Token = "0x2000032")]
	[NotKeyable]
	[Serializable]
	public class ControlPlayableAsset : PlayableAsset, IPropertyPreview, ITimelineClipAsset
	{
		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x000031AC File Offset: 0x000013AC
		// (set) Token: 0x060001EA RID: 490 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000095")]
		internal bool controllingDirectors
		{
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0x150B0B0", Offset = "0x1509CB0", VA = "0x18150B0B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0x150B0F0", Offset = "0x1509CF0", VA = "0x18150B0F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060001EB RID: 491 RVA: 0x000031C4 File Offset: 0x000013C4
		// (set) Token: 0x060001EC RID: 492 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000096")]
		internal bool controllingParticles
		{
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0x50B11D0", Offset = "0x50AFDD0", VA = "0x1850B11D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0x58E7570", Offset = "0x58E6170", VA = "0x1858E7570")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x58E56E0", Offset = "0x58E42E0", VA = "0x1858E56E0")]
		public void OnEnable()
		{
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060001EE RID: 494 RVA: 0x000031DC File Offset: 0x000013DC
		[Token(Token = "0x17000097")]
		public override double duration
		{
			[Token(Token = "0x60001EE")]
			[Address(RVA = "0x58E7560", Offset = "0x58E6160", VA = "0x1858E7560", Slot = "7")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060001EF RID: 495 RVA: 0x000031F4 File Offset: 0x000013F4
		[Token(Token = "0x17000098")]
		public ClipCaps clipCaps
		{
			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x58E7550", Offset = "0x58E6150", VA = "0x1858E7550", Slot = "10")]
			get
			{
				return ClipCaps.None;
			}
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x0000320C File Offset: 0x0000140C
		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x58E42F0", Offset = "0x58E2EF0", VA = "0x1858E42F0", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
		{
			return default(Playable);
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00003224 File Offset: 0x00001424
		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x58E3E70", Offset = "0x58E2A70", VA = "0x1858E3E70")]
		private static Playable ConnectPlayablesToMixer(PlayableGraph graph, List<Playable> playables)
		{
			return default(Playable);
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x58E4080", Offset = "0x58E2C80", VA = "0x1858E4080")]
		private void CreateActivationPlayable(GameObject root, PlayableGraph graph, List<Playable> outplayables)
		{
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x58E68D0", Offset = "0x58E54D0", VA = "0x1858E68D0")]
		private void SearchHierarchyAndConnectParticleSystem(IEnumerable<ParticleSystem> particleSystems, PlayableGraph graph, List<Playable> outplayables)
		{
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x58E6590", Offset = "0x58E5190", VA = "0x1858E6590")]
		private void SearchHierarchyAndConnectDirector(IEnumerable<PlayableDirector> directors, PlayableGraph graph, List<Playable> outplayables, bool disableSelfReferences)
		{
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x58E6270", Offset = "0x58E4E70", VA = "0x1858E6270")]
		private static void SearchHierarchyAndConnectControlableScripts(IEnumerable<MonoBehaviour> controlableScripts, PlayableGraph graph, List<Playable> outplayables)
		{
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x58E3DB0", Offset = "0x58E29B0", VA = "0x1858E3DB0")]
		private static void ConnectMixerAndPlayable(PlayableGraph graph, Playable mixer, Playable playable, int portIndex)
		{
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x60001F7")]
		internal IList<T> GetComponent<T>(GameObject gameObject)
		{
			return null;
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x58E5220", Offset = "0x58E3E20", VA = "0x1858E5220")]
		internal static IEnumerable<MonoBehaviour> GetControlableScripts(GameObject root)
		{
			return null;
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x58E6BA0", Offset = "0x58E57A0", VA = "0x1858E6BA0")]
		internal void UpdateDurationAndLoopFlag(IList<PlayableDirector> directors, IList<ParticleSystem> particleSystems)
		{
		}

		// Token: 0x060001FA RID: 506 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x58E52A0", Offset = "0x58E3EA0", VA = "0x1858E52A0")]
		private IList<ParticleSystem> GetControllableParticleSystems(GameObject go)
		{
			return null;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x58E5410", Offset = "0x58E4010", VA = "0x1858E5410")]
		private static void GetControllableParticleSystems(Transform t, ICollection<ParticleSystem> roots, HashSet<ParticleSystem> subEmitters)
		{
		}

		// Token: 0x060001FC RID: 508 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x58E3CC0", Offset = "0x58E28C0", VA = "0x1858E3CC0")]
		private static void CacheSubEmitters(ParticleSystem ps, HashSet<ParticleSystem> subEmitters)
		{
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x58E4EE0", Offset = "0x58E3AE0", VA = "0x1858E4EE0", Slot = "9")]
		public void GatherProperties(PlayableDirector director, IPropertyCollector driver)
		{
		}

		// Token: 0x060001FE RID: 510 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x58E5C40", Offset = "0x58E4840", VA = "0x1858E5C40")]
		internal static void PreviewParticles(IPropertyCollector driver, IEnumerable<ParticleSystem> particles)
		{
		}

		// Token: 0x060001FF RID: 511 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x58E5710", Offset = "0x58E4310", VA = "0x1858E5710")]
		internal static void PreviewActivation(IPropertyCollector driver, IEnumerable<GameObject> objects)
		{
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000200")]
		[Address(RVA = "0x58E6010", Offset = "0x58E4C10", VA = "0x1858E6010")]
		internal static void PreviewTimeControl(IPropertyCollector driver, PlayableDirector director, IEnumerable<MonoBehaviour> scripts)
		{
		}

		// Token: 0x06000201 RID: 513 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000201")]
		[Address(RVA = "0x58E59B0", Offset = "0x58E45B0", VA = "0x1858E59B0")]
		internal static void PreviewDirectors(IPropertyCollector driver, IEnumerable<PlayableDirector> directors)
		{
		}

		// Token: 0x06000202 RID: 514 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000202")]
		[Address(RVA = "0x58E74D0", Offset = "0x58E60D0", VA = "0x1858E74D0")]
		public ControlPlayableAsset()
		{
		}

		// Token: 0x040000E9 RID: 233
		[Token(Token = "0x40000E9")]
		private const int k_MaxRandInt = 10000;

		// Token: 0x040000EA RID: 234
		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<PlayableDirector> k_EmptyDirectorsList;

		// Token: 0x040000EB RID: 235
		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x8")]
		private static readonly List<ParticleSystem> k_EmptyParticlesList;

		// Token: 0x040000EC RID: 236
		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x10")]
		private static readonly HashSet<ParticleSystem> s_SubEmitterCollector;

		// Token: 0x040000ED RID: 237
		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public ExposedReference<GameObject> sourceGameObject;

		// Token: 0x040000EE RID: 238
		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		public GameObject prefabGameObject;

		// Token: 0x040000EF RID: 239
		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		public bool updateParticle;

		// Token: 0x040000F0 RID: 240
		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		public uint particleRandomSeed;

		// Token: 0x040000F1 RID: 241
		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		public bool updateDirector;

		// Token: 0x040000F2 RID: 242
		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x39")]
		[SerializeField]
		public bool updateITimeControl;

		// Token: 0x040000F3 RID: 243
		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x3A")]
		[SerializeField]
		public bool searchHierarchy;

		// Token: 0x040000F4 RID: 244
		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x3B")]
		[SerializeField]
		public bool active;

		// Token: 0x040000F5 RID: 245
		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		public ActivationControlPlayable.PostPlaybackState postPlayback;

		// Token: 0x040000F6 RID: 246
		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x40")]
		private PlayableAsset m_ControlDirectorAsset;

		// Token: 0x040000F7 RID: 247
		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x48")]
		private double m_Duration;

		// Token: 0x040000F8 RID: 248
		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x50")]
		private bool m_SupportLoop;

		// Token: 0x040000F9 RID: 249
		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x18")]
		private static HashSet<PlayableDirector> s_ProcessedDirectors;

		// Token: 0x040000FA RID: 250
		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x20")]
		private static HashSet<GameObject> s_CreatedPrefabs;
	}
}
