using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Spine.Unity
{
	// Token: 0x02000083 RID: 131
	[Token(Token = "0x2000083")]
	[RequireComponent(typeof(Animator))]
	[HelpURL("http://esotericsoftware.com/spine-unity#SkeletonMecanim-Component")]
	public class SkeletonMecanim : SkeletonRenderer, ISkeletonAnimation
	{
		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x060005A8 RID: 1448 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x170001A5")]
		public SkeletonMecanim.MecanimTranslator Translator
		{
			[Token(Token = "0x60005A8")]
			[Address(RVA = "0x4D6C780", Offset = "0x4D6B380", VA = "0x184D6C780")]
			get
			{
				return null;
			}
		}

		// Token: 0x1400001D RID: 29
		// (add) Token: 0x060005A9 RID: 1449 RVA: 0x0000207E File Offset: 0x0000027E
		// (remove) Token: 0x060005AA RID: 1450 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1400001D")]
		protected event UpdateBonesDelegate _BeforeApply
		{
			[Token(Token = "0x60005A9")]
			[Address(RVA = "0x4E85420", Offset = "0x4E84020", VA = "0x184E85420")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60005AA")]
			[Address(RVA = "0x4E856A0", Offset = "0x4E842A0", VA = "0x184E856A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400001E RID: 30
		// (add) Token: 0x060005AB RID: 1451 RVA: 0x0000207E File Offset: 0x0000027E
		// (remove) Token: 0x060005AC RID: 1452 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1400001E")]
		protected event UpdateBonesDelegate _UpdateLocal
		{
			[Token(Token = "0x60005AB")]
			[Address(RVA = "0x4E85560", Offset = "0x4E84160", VA = "0x184E85560")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60005AC")]
			[Address(RVA = "0x4E857E0", Offset = "0x4E843E0", VA = "0x184E857E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400001F RID: 31
		// (add) Token: 0x060005AD RID: 1453 RVA: 0x0000207E File Offset: 0x0000027E
		// (remove) Token: 0x060005AE RID: 1454 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1400001F")]
		protected event UpdateBonesDelegate _UpdateWorld
		{
			[Token(Token = "0x60005AD")]
			[Address(RVA = "0x4E85600", Offset = "0x4E84200", VA = "0x184E85600")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60005AE")]
			[Address(RVA = "0x4E85880", Offset = "0x4E84480", VA = "0x184E85880")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000020 RID: 32
		// (add) Token: 0x060005AF RID: 1455 RVA: 0x0000207E File Offset: 0x0000027E
		// (remove) Token: 0x060005B0 RID: 1456 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x14000020")]
		protected event UpdateBonesDelegate _UpdateComplete
		{
			[Token(Token = "0x60005AF")]
			[Address(RVA = "0x4E854C0", Offset = "0x4E840C0", VA = "0x184E854C0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60005B0")]
			[Address(RVA = "0x4E85740", Offset = "0x4E84340", VA = "0x184E85740")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000021 RID: 33
		// (add) Token: 0x060005B1 RID: 1457 RVA: 0x0000207E File Offset: 0x0000027E
		// (remove) Token: 0x060005B2 RID: 1458 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x14000021")]
		public event UpdateBonesDelegate BeforeApply
		{
			[Token(Token = "0x60005B1")]
			[Address(RVA = "0x4E85420", Offset = "0x4E84020", VA = "0x184E85420")]
			add
			{
			}
			[Token(Token = "0x60005B2")]
			[Address(RVA = "0x4E856A0", Offset = "0x4E842A0", VA = "0x184E856A0")]
			remove
			{
			}
		}

		// Token: 0x14000022 RID: 34
		// (add) Token: 0x060005B3 RID: 1459 RVA: 0x0000207E File Offset: 0x0000027E
		// (remove) Token: 0x060005B4 RID: 1460 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x14000022")]
		public event UpdateBonesDelegate UpdateLocal
		{
			[Token(Token = "0x60005B3")]
			[Address(RVA = "0x4E85560", Offset = "0x4E84160", VA = "0x184E85560", Slot = "11")]
			add
			{
			}
			[Token(Token = "0x60005B4")]
			[Address(RVA = "0x4E857E0", Offset = "0x4E843E0", VA = "0x184E857E0", Slot = "12")]
			remove
			{
			}
		}

		// Token: 0x14000023 RID: 35
		// (add) Token: 0x060005B5 RID: 1461 RVA: 0x0000207E File Offset: 0x0000027E
		// (remove) Token: 0x060005B6 RID: 1462 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x14000023")]
		public event UpdateBonesDelegate UpdateWorld
		{
			[Token(Token = "0x60005B5")]
			[Address(RVA = "0x4E85600", Offset = "0x4E84200", VA = "0x184E85600", Slot = "13")]
			add
			{
			}
			[Token(Token = "0x60005B6")]
			[Address(RVA = "0x4E85880", Offset = "0x4E84480", VA = "0x184E85880", Slot = "14")]
			remove
			{
			}
		}

		// Token: 0x14000024 RID: 36
		// (add) Token: 0x060005B7 RID: 1463 RVA: 0x0000207E File Offset: 0x0000027E
		// (remove) Token: 0x060005B8 RID: 1464 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x14000024")]
		public event UpdateBonesDelegate UpdateComplete
		{
			[Token(Token = "0x60005B7")]
			[Address(RVA = "0x4E854C0", Offset = "0x4E840C0", VA = "0x184E854C0", Slot = "15")]
			add
			{
			}
			[Token(Token = "0x60005B8")]
			[Address(RVA = "0x4E85740", Offset = "0x4E84340", VA = "0x184E85740", Slot = "16")]
			remove
			{
			}
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x4E850E0", Offset = "0x4E83CE0", VA = "0x184E850E0", Slot = "9")]
		public override void Initialize(bool overwrite, bool quiet = false)
		{
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x4E852E0", Offset = "0x4E83EE0", VA = "0x184E852E0")]
		public void Update()
		{
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x4E85010", Offset = "0x4E83C10", VA = "0x184E85010")]
		protected void ApplyAnimation()
		{
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x4E851E0", Offset = "0x4E83DE0", VA = "0x184E851E0", Slot = "10")]
		public override void LateUpdate()
		{
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x4E853D0", Offset = "0x4E83FD0", VA = "0x184E853D0")]
		public SkeletonMecanim()
		{
		}

		// Token: 0x04000366 RID: 870
		[Token(Token = "0x4000366")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		protected SkeletonMecanim.MecanimTranslator translator;

		// Token: 0x04000367 RID: 871
		[Token(Token = "0x4000367")]
		[FieldOffset(Offset = "0xF8")]
		private bool wasUpdatedAfterInit;

		// Token: 0x02000084 RID: 132
		[Token(Token = "0x2000084")]
		[Serializable]
		public class MecanimTranslator
		{
			// Token: 0x14000025 RID: 37
			// (add) Token: 0x060005BE RID: 1470 RVA: 0x0000207E File Offset: 0x0000027E
			// (remove) Token: 0x060005BF RID: 1471 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x14000025")]
			protected event SkeletonMecanim.MecanimTranslator.OnClipAppliedDelegate _OnClipApplied
			{
				[Token(Token = "0x60005BE")]
				[Address(RVA = "0x4E7CD40", Offset = "0x4E7B940", VA = "0x184E7CD40")]
				[CompilerGenerated]
				add
				{
				}
				[Token(Token = "0x60005BF")]
				[Address(RVA = "0x4E7CFC0", Offset = "0x4E7BBC0", VA = "0x184E7CFC0")]
				[CompilerGenerated]
				remove
				{
				}
			}

			// Token: 0x14000026 RID: 38
			// (add) Token: 0x060005C0 RID: 1472 RVA: 0x0000207E File Offset: 0x0000027E
			// (remove) Token: 0x060005C1 RID: 1473 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x14000026")]
			public event SkeletonMecanim.MecanimTranslator.OnClipAppliedDelegate OnClipApplied
			{
				[Token(Token = "0x60005C0")]
				[Address(RVA = "0x4E7CD40", Offset = "0x4E7B940", VA = "0x184E7CD40")]
				add
				{
				}
				[Token(Token = "0x60005C1")]
				[Address(RVA = "0x4E7CFC0", Offset = "0x4E7BBC0", VA = "0x184E7CFC0")]
				remove
				{
				}
			}

			// Token: 0x170001A6 RID: 422
			// (get) Token: 0x060005C2 RID: 1474 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x170001A6")]
			public Animator Animator
			{
				[Token(Token = "0x60005C2")]
				[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460")]
				get
				{
					return null;
				}
			}

			// Token: 0x170001A7 RID: 423
			// (get) Token: 0x060005C3 RID: 1475 RVA: 0x00004364 File Offset: 0x00002564
			[Token(Token = "0x170001A7")]
			public int MecanimLayerCount
			{
				[Token(Token = "0x60005C3")]
				[Address(RVA = "0x4E7CDE0", Offset = "0x4E7B9E0", VA = "0x184E7CDE0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170001A8 RID: 424
			// (get) Token: 0x060005C4 RID: 1476 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x170001A8")]
			public string[] MecanimLayerNames
			{
				[Token(Token = "0x60005C4")]
				[Address(RVA = "0x4E7CE60", Offset = "0x4E7BA60", VA = "0x184E7CE60")]
				get
				{
					return null;
				}
			}

			// Token: 0x060005C5 RID: 1477 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x60005C5")]
			[Address(RVA = "0x4E7C790", Offset = "0x4E7B390", VA = "0x184E7C790")]
			public void Initialize(Animator animator, SkeletonDataAsset skeletonDataAsset)
			{
			}

			// Token: 0x060005C6 RID: 1478 RVA: 0x0000437C File Offset: 0x0000257C
			[Token(Token = "0x60005C6")]
			[Address(RVA = "0x4E7A8D0", Offset = "0x4E794D0", VA = "0x184E7A8D0")]
			private bool ApplyAnimation(Skeleton skeleton, AnimatorClipInfo info, AnimatorStateInfo stateInfo, int layerIndex, float layerWeight, MixBlend layerBlendMode, bool useClipWeight1 = false)
			{
				return default(bool);
			}

			// Token: 0x060005C7 RID: 1479 RVA: 0x00004394 File Offset: 0x00002594
			[Token(Token = "0x60005C7")]
			[Address(RVA = "0x4E7AB30", Offset = "0x4E79730", VA = "0x184E7AB30")]
			private bool ApplyInterruptionAnimation(Skeleton skeleton, bool interpolateWeightTo1, AnimatorClipInfo info, AnimatorStateInfo stateInfo, int layerIndex, float layerWeight, MixBlend layerBlendMode, float interruptingClipTimeAddition, bool useClipWeight1 = false)
			{
				return default(bool);
			}

			// Token: 0x060005C8 RID: 1480 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x60005C8")]
			[Address(RVA = "0x4E7C9E0", Offset = "0x4E7B5E0", VA = "0x184E7C9E0")]
			private void OnClipAppliedCallback(Animation clip, AnimatorStateInfo stateInfo, int layerIndex, float time, bool isLooping, float weight)
			{
			}

			// Token: 0x060005C9 RID: 1481 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x60005C9")]
			[Address(RVA = "0x4E7ADC0", Offset = "0x4E799C0", VA = "0x184E7ADC0")]
			public void Apply(Skeleton skeleton)
			{
			}

			// Token: 0x060005CA RID: 1482 RVA: 0x000043AC File Offset: 0x000025AC
			[Token(Token = "0x60005CA")]
			[Address(RVA = "0x4E7BE10", Offset = "0x4E7AA10", VA = "0x184E7BE10")]
			public KeyValuePair<Animation, float> GetActiveAnimationAndTime(int layer)
			{
				return default(KeyValuePair<Animation, float>);
			}

			// Token: 0x060005CB RID: 1483 RVA: 0x000043C4 File Offset: 0x000025C4
			[Token(Token = "0x60005CB")]
			[Address(RVA = "0x4E7A840", Offset = "0x4E79440", VA = "0x184E7A840")]
			private static float AnimationTime(float normalizedTime, float clipLength, bool loop, bool reversed)
			{
				return 0f;
			}

			// Token: 0x060005CC RID: 1484 RVA: 0x000043DC File Offset: 0x000025DC
			[Token(Token = "0x60005CC")]
			[Address(RVA = "0x4E7A7E0", Offset = "0x4E793E0", VA = "0x184E7A7E0")]
			private static float AnimationTime(float normalizedTime, float clipLength, bool reversed)
			{
				return 0f;
			}

			// Token: 0x060005CD RID: 1485 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x60005CD")]
			[Address(RVA = "0x4E7C630", Offset = "0x4E7B230", VA = "0x184E7C630")]
			private void InitClipInfosForLayers()
			{
			}

			// Token: 0x060005CE RID: 1486 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x60005CE")]
			[Address(RVA = "0x4E7BC10", Offset = "0x4E7A810", VA = "0x184E7BC10")]
			private void ClearClipInfosForLayers()
			{
			}

			// Token: 0x060005CF RID: 1487 RVA: 0x000043F4 File Offset: 0x000025F4
			[Token(Token = "0x60005CF")]
			[Address(RVA = "0x4E7C2B0", Offset = "0x4E7AEB0", VA = "0x184E7C2B0")]
			private SkeletonMecanim.MecanimTranslator.MixMode GetMixMode(int layer, MixBlend layerBlendMode)
			{
				return SkeletonMecanim.MecanimTranslator.MixMode.AlwaysMix;
			}

			// Token: 0x060005D0 RID: 1488 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x60005D0")]
			[Address(RVA = "0x4E7C310", Offset = "0x4E7AF10", VA = "0x184E7C310")]
			private void GetStateUpdatesFromAnimator(int layer)
			{
			}

			// Token: 0x060005D1 RID: 1489 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x60005D1")]
			[Address(RVA = "0x4E7C140", Offset = "0x4E7AD40", VA = "0x184E7C140")]
			private void GetAnimatorClipInfos(int layer, out bool isInterruptionActive, out int clipInfoCount, out int nextClipInfoCount, out int interruptingClipInfoCount, out IList<AnimatorClipInfo> clipInfo, out IList<AnimatorClipInfo> nextClipInfo, out IList<AnimatorClipInfo> interruptingClipInfo, out bool shallInterpolateWeightTo1)
			{
			}

			// Token: 0x060005D2 RID: 1490 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x60005D2")]
			[Address(RVA = "0x4E7C1F0", Offset = "0x4E7ADF0", VA = "0x184E7C1F0")]
			private void GetAnimatorStateInfos(int layer, out bool isInterruptionActive, out AnimatorStateInfo stateInfo, out AnimatorStateInfo nextStateInfo, out AnimatorStateInfo interruptingStateInfo, out float interruptingClipTimeAddition)
			{
			}

			// Token: 0x060005D3 RID: 1491 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x60005D3")]
			[Address(RVA = "0x4E7C020", Offset = "0x4E7AC20", VA = "0x184E7C020")]
			private Animation GetAnimation(AnimationClip clip)
			{
				return null;
			}

			// Token: 0x060005D4 RID: 1492 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x60005D4")]
			[Address(RVA = "0x4E7CB20", Offset = "0x4E7B720", VA = "0x184E7CB20")]
			public MecanimTranslator()
			{
			}

			// Token: 0x0400036C RID: 876
			[Token(Token = "0x400036C")]
			private const float WeightEpsilon = 0.0001f;

			// Token: 0x0400036D RID: 877
			[Token(Token = "0x400036D")]
			[FieldOffset(Offset = "0x10")]
			public bool autoReset;

			// Token: 0x0400036E RID: 878
			[Token(Token = "0x400036E")]
			[FieldOffset(Offset = "0x11")]
			public bool useCustomMixMode;

			// Token: 0x0400036F RID: 879
			[Token(Token = "0x400036F")]
			[FieldOffset(Offset = "0x18")]
			public SkeletonMecanim.MecanimTranslator.MixMode[] layerMixModes;

			// Token: 0x04000370 RID: 880
			[Token(Token = "0x4000370")]
			[FieldOffset(Offset = "0x20")]
			public MixBlend[] layerBlendModes;

			// Token: 0x04000372 RID: 882
			[Token(Token = "0x4000372")]
			[FieldOffset(Offset = "0x30")]
			private readonly Dictionary<int, Animation> animationTable;

			// Token: 0x04000373 RID: 883
			[Token(Token = "0x4000373")]
			[FieldOffset(Offset = "0x38")]
			private readonly Dictionary<AnimationClip, int> clipNameHashCodeTable;

			// Token: 0x04000374 RID: 884
			[Token(Token = "0x4000374")]
			[FieldOffset(Offset = "0x40")]
			private readonly List<Animation> previousAnimations;

			// Token: 0x04000375 RID: 885
			[Token(Token = "0x4000375")]
			[FieldOffset(Offset = "0x48")]
			protected SkeletonMecanim.MecanimTranslator.ClipInfos[] layerClipInfos;

			// Token: 0x04000376 RID: 886
			[Token(Token = "0x4000376")]
			[FieldOffset(Offset = "0x50")]
			private Animator animator;

			// Token: 0x02000085 RID: 133
			// (Invoke) Token: 0x060005D6 RID: 1494
			[Token(Token = "0x2000085")]
			public delegate void OnClipAppliedDelegate(Animation clip, int layerIndex, float weight, float time, float lastTime, bool playsBackward);

			// Token: 0x02000086 RID: 134
			[Token(Token = "0x2000086")]
			public enum MixMode
			{
				// Token: 0x04000378 RID: 888
				[Token(Token = "0x4000378")]
				AlwaysMix,
				// Token: 0x04000379 RID: 889
				[Token(Token = "0x4000379")]
				MixNext,
				// Token: 0x0400037A RID: 890
				[Token(Token = "0x400037A")]
				Hard
			}

			// Token: 0x02000087 RID: 135
			[Token(Token = "0x2000087")]
			protected class ClipInfos
			{
				// Token: 0x060005D9 RID: 1497 RVA: 0x0000207E File Offset: 0x0000027E
				[Token(Token = "0x60005D9")]
				[Address(RVA = "0x4E79D90", Offset = "0x4E78990", VA = "0x184E79D90")]
				public ClipInfos()
				{
				}

				// Token: 0x0400037B RID: 891
				[Token(Token = "0x400037B")]
				[FieldOffset(Offset = "0x10")]
				public bool isInterruptionActive;

				// Token: 0x0400037C RID: 892
				[Token(Token = "0x400037C")]
				[FieldOffset(Offset = "0x11")]
				public bool isLastFrameOfInterruption;

				// Token: 0x0400037D RID: 893
				[Token(Token = "0x400037D")]
				[FieldOffset(Offset = "0x14")]
				public int clipInfoCount;

				// Token: 0x0400037E RID: 894
				[Token(Token = "0x400037E")]
				[FieldOffset(Offset = "0x18")]
				public int nextClipInfoCount;

				// Token: 0x0400037F RID: 895
				[Token(Token = "0x400037F")]
				[FieldOffset(Offset = "0x1C")]
				public int interruptingClipInfoCount;

				// Token: 0x04000380 RID: 896
				[Token(Token = "0x4000380")]
				[FieldOffset(Offset = "0x20")]
				public readonly List<AnimatorClipInfo> clipInfos;

				// Token: 0x04000381 RID: 897
				[Token(Token = "0x4000381")]
				[FieldOffset(Offset = "0x28")]
				public readonly List<AnimatorClipInfo> nextClipInfos;

				// Token: 0x04000382 RID: 898
				[Token(Token = "0x4000382")]
				[FieldOffset(Offset = "0x30")]
				public readonly List<AnimatorClipInfo> interruptingClipInfos;

				// Token: 0x04000383 RID: 899
				[Token(Token = "0x4000383")]
				[FieldOffset(Offset = "0x38")]
				public AnimatorStateInfo stateInfo;

				// Token: 0x04000384 RID: 900
				[Token(Token = "0x4000384")]
				[FieldOffset(Offset = "0x5C")]
				public AnimatorStateInfo nextStateInfo;

				// Token: 0x04000385 RID: 901
				[Token(Token = "0x4000385")]
				[FieldOffset(Offset = "0x80")]
				public AnimatorStateInfo interruptingStateInfo;

				// Token: 0x04000386 RID: 902
				[Token(Token = "0x4000386")]
				[FieldOffset(Offset = "0xA4")]
				public float interruptingClipTimeAddition;
			}

			// Token: 0x02000088 RID: 136
			[Token(Token = "0x2000088")]
			private class AnimationClipEqualityComparer : IEqualityComparer<AnimationClip>
			{
				// Token: 0x060005DA RID: 1498 RVA: 0x0000440C File Offset: 0x0000260C
				[Token(Token = "0x60005DA")]
				[Address(RVA = "0x4E75320", Offset = "0x4E73F20", VA = "0x184E75320", Slot = "4")]
				public bool Equals(AnimationClip x, AnimationClip y)
				{
					return default(bool);
				}

				// Token: 0x060005DB RID: 1499 RVA: 0x00004424 File Offset: 0x00002624
				[Token(Token = "0x60005DB")]
				[Address(RVA = "0x1AFAA70", Offset = "0x1AF9670", VA = "0x181AFAA70", Slot = "5")]
				public int GetHashCode(AnimationClip o)
				{
					return 0;
				}

				// Token: 0x060005DC RID: 1500 RVA: 0x0000207E File Offset: 0x0000027E
				[Token(Token = "0x60005DC")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public AnimationClipEqualityComparer()
				{
				}

				// Token: 0x04000387 RID: 903
				[Token(Token = "0x4000387")]
				[FieldOffset(Offset = "0x0")]
				internal static readonly IEqualityComparer<AnimationClip> Instance;
			}

			// Token: 0x02000089 RID: 137
			[Token(Token = "0x2000089")]
			private class IntEqualityComparer : IEqualityComparer<int>
			{
				// Token: 0x060005DE RID: 1502 RVA: 0x0000443C File Offset: 0x0000263C
				[Token(Token = "0x60005DE")]
				[Address(RVA = "0x4E7A460", Offset = "0x4E79060", VA = "0x184E7A460", Slot = "4")]
				public bool Equals(int x, int y)
				{
					return default(bool);
				}

				// Token: 0x060005DF RID: 1503 RVA: 0x00004454 File Offset: 0x00002654
				[Token(Token = "0x60005DF")]
				[Address(RVA = "0x21DABC0", Offset = "0x21D97C0", VA = "0x1821DABC0", Slot = "5")]
				public int GetHashCode(int o)
				{
					return 0;
				}

				// Token: 0x060005E0 RID: 1504 RVA: 0x0000207E File Offset: 0x0000027E
				[Token(Token = "0x60005E0")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public IntEqualityComparer()
				{
				}

				// Token: 0x04000388 RID: 904
				[Token(Token = "0x4000388")]
				[FieldOffset(Offset = "0x0")]
				internal static readonly IEqualityComparer<int> Instance;
			}
		}
	}
}
