using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	[NotKeyable]
	[Serializable]
	public class AnimationPlayableAsset : PlayableAsset, ITimelineClipAsset, IPropertyPreview, ISerializationCallbackReceiver
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000016 RID: 22 RVA: 0x000020F8 File Offset: 0x000002F8
		// (set) Token: 0x06000017 RID: 23 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000004")]
		public Vector3 position
		{
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x58DDFE0", Offset = "0x58DCBE0", VA = "0x1858DDFE0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x58DE150", Offset = "0x58DCD50", VA = "0x1858DE150")]
			set
			{
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00002110 File Offset: 0x00000310
		// (set) Token: 0x06000019 RID: 25 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000005")]
		public Quaternion rotation
		{
			[Token(Token = "0x6000018")]
			[Address(RVA = "0x58DE000", Offset = "0x58DCC00", VA = "0x1858DE000")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000019")]
			[Address(RVA = "0x58DE160", Offset = "0x58DCD60", VA = "0x1858DE160")]
			set
			{
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00002128 File Offset: 0x00000328
		// (set) Token: 0x0600001B RID: 27 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000006")]
		public Vector3 eulerAngles
		{
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x58DDEA0", Offset = "0x58DCAA0", VA = "0x1858DDEA0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x58DE130", Offset = "0x58DCD30", VA = "0x1858DE130")]
			set
			{
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001C RID: 28 RVA: 0x00002140 File Offset: 0x00000340
		// (set) Token: 0x0600001D RID: 29 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000007")]
		public bool useTrackMatchFields
		{
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x4FD4C0", Offset = "0x4FC0C0", VA = "0x1804FD4C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600001D")]
			[Address(RVA = "0x14D9990", Offset = "0x14D8590", VA = "0x1814D9990")]
			set
			{
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00002158 File Offset: 0x00000358
		// (set) Token: 0x0600001F RID: 31 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000008")]
		public MatchTargetFields matchTargetFields
		{
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x926F80", Offset = "0x925B80", VA = "0x180926F80")]
			get
			{
				return (MatchTargetFields)0;
			}
			[Token(Token = "0x600001F")]
			[Address(RVA = "0x927050", Offset = "0x925C50", VA = "0x180927050")]
			set
			{
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00002170 File Offset: 0x00000370
		// (set) Token: 0x06000021 RID: 33 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000009")]
		public bool removeStartOffset
		{
			[Token(Token = "0x6000020")]
			[Address(RVA = "0xD36A60", Offset = "0xD35660", VA = "0x180D36A60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x2860DE0", Offset = "0x285F9E0", VA = "0x182860DE0")]
			set
			{
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00002188 File Offset: 0x00000388
		// (set) Token: 0x06000023 RID: 35 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700000A")]
		public bool applyFootIK
		{
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x1793F60", Offset = "0x1792B60", VA = "0x181793F60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x31208C0", Offset = "0x311F4C0", VA = "0x1831208C0")]
			set
			{
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000024 RID: 36 RVA: 0x000021A0 File Offset: 0x000003A0
		// (set) Token: 0x06000025 RID: 37 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700000B")]
		public AnimationPlayableAsset.LoopMode loop
		{
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x1793F50", Offset = "0x1792B50", VA = "0x181793F50")]
			get
			{
				return AnimationPlayableAsset.LoopMode.UseSourceAsset;
			}
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x58DE140", Offset = "0x58DCD40", VA = "0x1858DE140")]
			set
			{
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000026 RID: 38 RVA: 0x000021B8 File Offset: 0x000003B8
		[Token(Token = "0x1700000C")]
		internal bool hasRootTransforms
		{
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x58DDEC0", Offset = "0x58DCAC0", VA = "0x1858DDEC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000027 RID: 39 RVA: 0x000021D0 File Offset: 0x000003D0
		// (set) Token: 0x06000028 RID: 40 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700000D")]
		internal AppliedOffsetMode appliedOffsetMode
		{
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x14DAA90", Offset = "0x14D9690", VA = "0x1814DAA90")]
			[CompilerGenerated]
			get
			{
				return AppliedOffsetMode.NoRootTransform;
			}
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x14DAB10", Offset = "0x14D9710", VA = "0x1814DAB10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000029 RID: 41 RVA: 0x000021E6 File Offset: 0x000003E6
		// (set) Token: 0x0600002A RID: 42 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700000E")]
		public AnimationClip clip
		{
			[Token(Token = "0x6000029")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x600002A")]
			[Address(RVA = "0x58DE080", Offset = "0x58DCC80", VA = "0x1858DE080")]
			set
			{
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600002B RID: 43 RVA: 0x000021EC File Offset: 0x000003EC
		[Token(Token = "0x1700000F")]
		public override double duration
		{
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x58DDE30", Offset = "0x58DCA30", VA = "0x1858DDE30", Slot = "7")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600002C RID: 44 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x17000010")]
		public override IEnumerable<PlayableBinding> outputs
		{
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x58DDF60", Offset = "0x58DCB60", VA = "0x1858DDF60", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002204 File Offset: 0x00000404
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x58DD600", Offset = "0x58DC200", VA = "0x1858DD600", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
		{
			return default(Playable);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0000221C File Offset: 0x0000041C
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x58DD1B0", Offset = "0x58DBDB0", VA = "0x1858DD1B0")]
		internal static Playable CreatePlayable(PlayableGraph graph, AnimationClip clip, Vector3 positionOffset, Vector3 eulerOffset, bool removeStartOffset, AppliedOffsetMode mode, bool applyFootIK, AnimationPlayableAsset.LoopMode loop)
		{
			return default(Playable);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002234 File Offset: 0x00000434
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x58DDA10", Offset = "0x58DC610", VA = "0x1858DDA10")]
		private static bool ShouldApplyOffset(AppliedOffsetMode mode, AnimationClip clip)
		{
			return default(bool);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000224C File Offset: 0x0000044C
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x58DDA80", Offset = "0x58DC680", VA = "0x1858DDA80")]
		private static bool ShouldApplyScaleRemove(AppliedOffsetMode mode)
		{
			return default(bool);
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00002264 File Offset: 0x00000464
		[Token(Token = "0x17000011")]
		public ClipCaps clipCaps
		{
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x58DDD50", Offset = "0x58DC950", VA = "0x1858DDD50", Slot = "9")]
			get
			{
				return ClipCaps.None;
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x58DD980", Offset = "0x58DC580", VA = "0x1858DD980")]
		public void ResetOffsets()
		{
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x58DD730", Offset = "0x58DC330", VA = "0x1858DD730", Slot = "10")]
		public void GatherProperties(PlayableDirector director, IPropertyCollector driver)
		{
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0000227C File Offset: 0x0000047C
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x58DD810", Offset = "0x58DC410", VA = "0x1858DD810")]
		internal static bool HasRootTransforms(AnimationClip clip)
		{
			return default(bool);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x58DDBA0", Offset = "0x58DC7A0", VA = "0x1858DDBA0", Slot = "11")]
		private void OnBeforeSerialize()
		{
		}

		// Token: 0x06000036 RID: 54 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x58DDAA0", Offset = "0x58DC6A0", VA = "0x1858DDAA0", Slot = "12")]
		private void OnAfterDeserialize()
		{
		}

		// Token: 0x06000037 RID: 55 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x58DD8C0", Offset = "0x58DC4C0", VA = "0x1858DD8C0")]
		private void OnUpgradeFromVersion(int oldVersion)
		{
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x58DDC40", Offset = "0x58DC840", VA = "0x1858DDC40")]
		public AnimationPlayableAsset()
		{
		}

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AnimationClip m_Clip;

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector3 m_Position;

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Vector3 m_EulerAngles;

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool m_UseTrackMatchFields;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private MatchTargetFields m_MatchTargetFields;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool m_RemoveStartOffset;

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x41")]
		[SerializeField]
		private bool m_ApplyFootIK;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private AnimationPlayableAsset.LoopMode m_Loop;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int k_LatestVersion;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		[HideInInspector]
		private int m_Version;

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x50")]
		[Obsolete("Use m_RotationEuler Instead", false)]
		[SerializeField]
		[HideInInspector]
		private Quaternion m_Rotation;

		// Token: 0x02000009 RID: 9
		[Token(Token = "0x2000009")]
		public enum LoopMode
		{
			// Token: 0x0400001E RID: 30
			[Token(Token = "0x400001E")]
			[Tooltip("Use the loop time setting from the source AnimationClip.")]
			UseSourceAsset,
			// Token: 0x0400001F RID: 31
			[Token(Token = "0x400001F")]
			[Tooltip("The source AnimationClip loops during playback.")]
			On,
			// Token: 0x04000020 RID: 32
			[Token(Token = "0x4000020")]
			[Tooltip("The source AnimationClip does not loop during playback.")]
			Off
		}

		// Token: 0x0200000A RID: 10
		[Token(Token = "0x200000A")]
		private enum Versions
		{
			// Token: 0x04000022 RID: 34
			[Token(Token = "0x4000022")]
			Initial,
			// Token: 0x04000023 RID: 35
			[Token(Token = "0x4000023")]
			RotationAsEuler
		}

		// Token: 0x0200000B RID: 11
		[Token(Token = "0x200000B")]
		private static class AnimationPlayableAssetUpgrade
		{
			// Token: 0x0600003A RID: 58 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x58DD100", Offset = "0x58DBD00", VA = "0x1858DD100")]
			public static void ConvertRotationToEuler(AnimationPlayableAsset asset)
			{
			}
		}
	}
}
