using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Serialization;

namespace Spine.Unity
{
	// Token: 0x0200008A RID: 138
	[Token(Token = "0x200008A")]
	[ExecuteAlways]
	[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
	[DisallowMultipleComponent]
	[HelpURL("http://esotericsoftware.com/spine-unity#SkeletonRenderer-Component")]
	public class SkeletonRenderer : MonoBehaviour, ISkeletonComponent, IHasSkeletonDataAsset
	{
		// Token: 0x060005E2 RID: 1506 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x4E872C0", Offset = "0x4E85EC0", VA = "0x184E872C0")]
		protected void TORAPPU_cacheFixedBoundsCenter(bool isInit = false)
		{
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x060005E3 RID: 1507 RVA: 0x0000446C File Offset: 0x0000266C
		// (set) Token: 0x060005E4 RID: 1508 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170001A9")]
		public UpdateMode UpdateMode
		{
			[Token(Token = "0x60005E3")]
			[Address(RVA = "0x926F80", Offset = "0x925B80", VA = "0x180926F80")]
			get
			{
				return UpdateMode.Nothing;
			}
			[Token(Token = "0x60005E4")]
			[Address(RVA = "0x927050", Offset = "0x925C50", VA = "0x180927050")]
			set
			{
			}
		}

		// Token: 0x14000027 RID: 39
		// (add) Token: 0x060005E5 RID: 1509 RVA: 0x0000207E File Offset: 0x0000027E
		// (remove) Token: 0x060005E6 RID: 1510 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x14000027")]
		private event SkeletonRenderer.InstructionDelegate generateMeshOverride
		{
			[Token(Token = "0x60005E5")]
			[Address(RVA = "0x4E87CA0", Offset = "0x4E868A0", VA = "0x184E87CA0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60005E6")]
			[Address(RVA = "0x4E880B0", Offset = "0x4E86CB0", VA = "0x184E880B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000028 RID: 40
		// (add) Token: 0x060005E7 RID: 1511 RVA: 0x0000207E File Offset: 0x0000027E
		// (remove) Token: 0x060005E8 RID: 1512 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x14000028")]
		public event SkeletonRenderer.InstructionDelegate GenerateMeshOverride
		{
			[Token(Token = "0x60005E7")]
			[Address(RVA = "0x4E87970", Offset = "0x4E86570", VA = "0x184E87970")]
			add
			{
			}
			[Token(Token = "0x60005E8")]
			[Address(RVA = "0x4E87D80", Offset = "0x4E86980", VA = "0x184E87D80")]
			remove
			{
			}
		}

		// Token: 0x14000029 RID: 41
		// (add) Token: 0x060005E9 RID: 1513 RVA: 0x0000207E File Offset: 0x0000027E
		// (remove) Token: 0x060005EA RID: 1514 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x14000029")]
		public event MeshGeneratorDelegate OnPostProcessVertices
		{
			[Token(Token = "0x60005E9")]
			[Address(RVA = "0x4E87B60", Offset = "0x4E86760", VA = "0x184E87B60")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60005EA")]
			[Address(RVA = "0x4E87F70", Offset = "0x4E86B70", VA = "0x184E87F70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x060005EB RID: 1515 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x170001AA")]
		public Dictionary<Material, Material> CustomMaterialOverride
		{
			[Token(Token = "0x60005EB")]
			[Address(RVA = "0x789270", Offset = "0x787E70", VA = "0x180789270")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x060005EC RID: 1516 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x170001AB")]
		public Dictionary<Slot, Material> CustomSlotMaterials
		{
			[Token(Token = "0x60005EC")]
			[Address(RVA = "0xF93800", Offset = "0xF92400", VA = "0x180F93800")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x060005ED RID: 1517 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x170001AC")]
		public Skeleton Skeleton
		{
			[Token(Token = "0x60005ED")]
			[Address(RVA = "0x4E87D40", Offset = "0x4E86940", VA = "0x184E87D40", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x1400002A RID: 42
		// (add) Token: 0x060005EE RID: 1518 RVA: 0x0000207E File Offset: 0x0000027E
		// (remove) Token: 0x060005EF RID: 1519 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1400002A")]
		public event SkeletonRenderer.SkeletonRendererDelegate OnRebuild
		{
			[Token(Token = "0x60005EE")]
			[Address(RVA = "0x4E87C00", Offset = "0x4E86800", VA = "0x184E87C00")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60005EF")]
			[Address(RVA = "0x4E88010", Offset = "0x4E86C10", VA = "0x184E88010")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400002B RID: 43
		// (add) Token: 0x060005F0 RID: 1520 RVA: 0x0000207E File Offset: 0x0000027E
		// (remove) Token: 0x060005F1 RID: 1521 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1400002B")]
		public event SkeletonRenderer.SkeletonRendererDelegate OnMeshAndMaterialsUpdated
		{
			[Token(Token = "0x60005F0")]
			[Address(RVA = "0x4E87AC0", Offset = "0x4E866C0", VA = "0x184E87AC0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60005F1")]
			[Address(RVA = "0x4E87ED0", Offset = "0x4E86AD0", VA = "0x184E87ED0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x060005F2 RID: 1522 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x170001AD")]
		public SkeletonDataAsset SkeletonDataAsset
		{
			[Token(Token = "0x60005F2")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60005F3")]
		public static T NewSpineGameObject<T>(SkeletonDataAsset skeletonDataAsset, bool quiet = false) where T : SkeletonRenderer
		{
			return null;
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60005F4")]
		public static T AddSpineComponent<T>(GameObject gameObject, SkeletonDataAsset skeletonDataAsset, bool quiet = false) where T : SkeletonRenderer
		{
			return null;
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x4E87270", Offset = "0x4E85E70", VA = "0x184E87270")]
		public void SetMeshSettings(MeshGenerator.Settings settings)
		{
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x4E85BA0", Offset = "0x4E847A0", VA = "0x184E85BA0", Slot = "7")]
		public virtual void Awake()
		{
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x4E86EE0", Offset = "0x4E85AE0", VA = "0x184E86EE0")]
		private void OnDisable()
		{
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x4E86EB0", Offset = "0x4E85AB0", VA = "0x184E86EB0")]
		private void OnDestroy()
		{
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x4E85BE0", Offset = "0x4E847E0", VA = "0x184E85BE0", Slot = "8")]
		public virtual void ClearState()
		{
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x4E85CA0", Offset = "0x4E848A0", VA = "0x184E85CA0")]
		public void EnsureMeshGeneratorCapacity(int minimumVertexCount)
		{
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x4E863C0", Offset = "0x4E84FC0", VA = "0x184E863C0", Slot = "9")]
		public virtual void Initialize(bool overwrite, bool quiet = false)
		{
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x4E86750", Offset = "0x4E85350", VA = "0x184E86750", Slot = "10")]
		public virtual void LateUpdate()
		{
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x4E86E60", Offset = "0x4E85A60", VA = "0x184E86E60")]
		public void OnBecameVisible()
		{
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x4E86E50", Offset = "0x4E85A50", VA = "0x184E86E50")]
		public void OnBecameInvisible()
		{
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x00004484 File Offset: 0x00002684
		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x4E87440", Offset = "0x4E86040", VA = "0x184E87440")]
		public bool Torappu_GetEnable()
		{
			return default(bool);
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000600")]
		[Address(RVA = "0x4E87590", Offset = "0x4E86190", VA = "0x184E87590")]
		public void Torappu_OnBecameVisible()
		{
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000601")]
		[Address(RVA = "0x4E874D0", Offset = "0x4E860D0", VA = "0x184E874D0")]
		public void Torappu_OnBecameInvisible()
		{
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000602")]
		[Address(RVA = "0x4E860D0", Offset = "0x4E84CD0", VA = "0x184E860D0")]
		public void FindAndApplySeparatorSlots(string startsWith, bool clearExistingSeparators = true, bool updateStringArray = false)
		{
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000603")]
		[Address(RVA = "0x4E85CE0", Offset = "0x4E848E0", VA = "0x184E85CE0")]
		public void FindAndApplySeparatorSlots(Func<string, bool> slotNamePredicate, bool clearExistingSeparators = true, bool updateStringArray = false)
		{
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000604")]
		[Address(RVA = "0x4E86F30", Offset = "0x4E85B30", VA = "0x184E86F30")]
		public void ReapplySeparatorSlotNames()
		{
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000605")]
		[Address(RVA = "0x4E85920", Offset = "0x4E84520", VA = "0x184E85920")]
		private void AssignSpriteMaskMaterials()
		{
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x0000449C File Offset: 0x0000269C
		[Token(Token = "0x6000606")]
		[Address(RVA = "0x4E86360", Offset = "0x4E84F60", VA = "0x184E86360")]
		private bool InitSpriteMaskMaterialsInsideMask()
		{
			return default(bool);
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x000044B4 File Offset: 0x000026B4
		[Token(Token = "0x6000607")]
		[Address(RVA = "0x4E86390", Offset = "0x4E84F90", VA = "0x184E86390")]
		private bool InitSpriteMaskMaterialsOutsideMask()
		{
			return default(bool);
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x000044CC File Offset: 0x000026CC
		[Token(Token = "0x6000608")]
		[Address(RVA = "0x4E861D0", Offset = "0x4E84DD0", VA = "0x184E861D0")]
		private bool InitSpriteMaskMaterialsForMaskType(CompareFunction maskFunction, ref Material[] materialsToFill)
		{
			return default(bool);
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000609")]
		[Address(RVA = "0x4E87020", Offset = "0x4E85C20", VA = "0x184E87020")]
		private void SetMaterialSettingsToFixDrawOrder()
		{
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600060A")]
		[Address(RVA = "0x4E87700", Offset = "0x4E86300", VA = "0x184E87700")]
		public SkeletonRenderer()
		{
		}

		// Token: 0x04000389 RID: 905
		[Token(Token = "0x4000389")]
		[FieldOffset(Offset = "0x18")]
		public Vector3? fixedBoundsCenter;

		// Token: 0x0400038A RID: 906
		[Token(Token = "0x400038A")]
		[FieldOffset(Offset = "0x28")]
		public SkeletonDataAsset skeletonDataAsset;

		// Token: 0x0400038B RID: 907
		[Token(Token = "0x400038B")]
		[FieldOffset(Offset = "0x30")]
		[SpineSkin("", "", true, false, true)]
		public string initialSkinName;

		// Token: 0x0400038C RID: 908
		[Token(Token = "0x400038C")]
		[FieldOffset(Offset = "0x38")]
		public bool initialFlipX;

		// Token: 0x0400038D RID: 909
		[Token(Token = "0x400038D")]
		[FieldOffset(Offset = "0x39")]
		public bool initialFlipY;

		// Token: 0x0400038E RID: 910
		[Token(Token = "0x400038E")]
		[FieldOffset(Offset = "0x3C")]
		protected UpdateMode updateMode;

		// Token: 0x0400038F RID: 911
		[Token(Token = "0x400038F")]
		[FieldOffset(Offset = "0x40")]
		public UpdateMode updateWhenInvisible;

		// Token: 0x04000390 RID: 912
		[Token(Token = "0x4000390")]
		[FieldOffset(Offset = "0x48")]
		[SpineSlot("", "", false, true, false)]
		[SerializeField]
		[FormerlySerializedAs("submeshSeparators")]
		protected string[] separatorSlotNames;

		// Token: 0x04000391 RID: 913
		[Token(Token = "0x4000391")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		public readonly List<Slot> separatorSlots;

		// Token: 0x04000392 RID: 914
		[Token(Token = "0x4000392")]
		[FieldOffset(Offset = "0x58")]
		[Range(-0.1f, 0f)]
		public float zSpacing;

		// Token: 0x04000393 RID: 915
		[Token(Token = "0x4000393")]
		[FieldOffset(Offset = "0x5C")]
		public bool useClipping;

		// Token: 0x04000394 RID: 916
		[Token(Token = "0x4000394")]
		[FieldOffset(Offset = "0x5D")]
		public bool immutableTriangles;

		// Token: 0x04000395 RID: 917
		[Token(Token = "0x4000395")]
		[FieldOffset(Offset = "0x5E")]
		public bool pmaVertexColors;

		// Token: 0x04000396 RID: 918
		[Token(Token = "0x4000396")]
		[FieldOffset(Offset = "0x5F")]
		public bool clearStateOnDisable;

		// Token: 0x04000397 RID: 919
		[Token(Token = "0x4000397")]
		[FieldOffset(Offset = "0x60")]
		public bool tintBlack;

		// Token: 0x04000398 RID: 920
		[Token(Token = "0x4000398")]
		[FieldOffset(Offset = "0x61")]
		public bool singleSubmesh;

		// Token: 0x04000399 RID: 921
		[Token(Token = "0x4000399")]
		[FieldOffset(Offset = "0x62")]
		public bool fixDrawOrder;

		// Token: 0x0400039A RID: 922
		[Token(Token = "0x400039A")]
		[FieldOffset(Offset = "0x63")]
		[FormerlySerializedAs("calculateNormals")]
		public bool addNormals;

		// Token: 0x0400039B RID: 923
		[Token(Token = "0x400039B")]
		[FieldOffset(Offset = "0x64")]
		public bool calculateTangents;

		// Token: 0x0400039C RID: 924
		[Token(Token = "0x400039C")]
		[FieldOffset(Offset = "0x68")]
		public SpriteMaskInteraction maskInteraction;

		// Token: 0x0400039D RID: 925
		[Token(Token = "0x400039D")]
		[FieldOffset(Offset = "0x70")]
		public SkeletonRenderer.SpriteMaskInteractionMaterials maskMaterials;

		// Token: 0x0400039E RID: 926
		[Token(Token = "0x400039E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int STENCIL_COMP_PARAM_ID;

		// Token: 0x0400039F RID: 927
		[Token(Token = "0x400039F")]
		public const CompareFunction STENCIL_COMP_MASKINTERACTION_NONE = CompareFunction.Always;

		// Token: 0x040003A0 RID: 928
		[Token(Token = "0x40003A0")]
		public const CompareFunction STENCIL_COMP_MASKINTERACTION_VISIBLE_INSIDE = CompareFunction.LessEqual;

		// Token: 0x040003A1 RID: 929
		[Token(Token = "0x40003A1")]
		public const CompareFunction STENCIL_COMP_MASKINTERACTION_VISIBLE_OUTSIDE = CompareFunction.Greater;

		// Token: 0x040003A2 RID: 930
		[Token(Token = "0x40003A2")]
		[FieldOffset(Offset = "0x78")]
		public bool disableRenderingOnOverride;

		// Token: 0x040003A5 RID: 933
		[Token(Token = "0x40003A5")]
		[FieldOffset(Offset = "0x90")]
		[NonSerialized]
		private readonly Dictionary<Material, Material> customMaterialOverride;

		// Token: 0x040003A6 RID: 934
		[Token(Token = "0x40003A6")]
		[FieldOffset(Offset = "0x98")]
		[NonSerialized]
		private readonly Dictionary<Slot, Material> customSlotMaterials;

		// Token: 0x040003A7 RID: 935
		[Token(Token = "0x40003A7")]
		[FieldOffset(Offset = "0xA0")]
		[NonSerialized]
		private readonly SkeletonRendererInstruction currentInstructions;

		// Token: 0x040003A8 RID: 936
		[Token(Token = "0x40003A8")]
		[FieldOffset(Offset = "0xA8")]
		private readonly MeshGenerator meshGenerator;

		// Token: 0x040003A9 RID: 937
		[Token(Token = "0x40003A9")]
		[FieldOffset(Offset = "0xB0")]
		[NonSerialized]
		private readonly MeshRendererBuffers rendererBuffers;

		// Token: 0x040003AA RID: 938
		[Token(Token = "0x40003AA")]
		[FieldOffset(Offset = "0xB8")]
		private MeshRenderer meshRenderer;

		// Token: 0x040003AB RID: 939
		[Token(Token = "0x40003AB")]
		[FieldOffset(Offset = "0xC0")]
		private MeshFilter meshFilter;

		// Token: 0x040003AC RID: 940
		[Token(Token = "0x40003AC")]
		[FieldOffset(Offset = "0xC8")]
		[NonSerialized]
		public bool valid;

		// Token: 0x040003AD RID: 941
		[Token(Token = "0x40003AD")]
		[FieldOffset(Offset = "0xD0")]
		[NonSerialized]
		public Skeleton skeleton;

		// Token: 0x040003B0 RID: 944
		[Token(Token = "0x40003B0")]
		[FieldOffset(Offset = "0xE8")]
		private MaterialPropertyBlock reusedPropertyBlock;

		// Token: 0x040003B1 RID: 945
		[Token(Token = "0x40003B1")]
		[FieldOffset(Offset = "0x4")]
		public static readonly int SUBMESH_DUMMY_PARAM_ID;

		// Token: 0x0200008B RID: 139
		[Token(Token = "0x200008B")]
		[Serializable]
		public class SpriteMaskInteractionMaterials
		{
			// Token: 0x170001AE RID: 430
			// (get) Token: 0x0600060C RID: 1548 RVA: 0x000044E4 File Offset: 0x000026E4
			[Token(Token = "0x170001AE")]
			public bool AnyMaterialCreated
			{
				[Token(Token = "0x600060C")]
				[Address(RVA = "0x4E9EE60", Offset = "0x4E9DA60", VA = "0x184E9EE60")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600060D RID: 1549 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x600060D")]
			[Address(RVA = "0x4E9EDD0", Offset = "0x4E9D9D0", VA = "0x184E9EDD0")]
			public SpriteMaskInteractionMaterials()
			{
			}

			// Token: 0x040003B2 RID: 946
			[Token(Token = "0x40003B2")]
			[FieldOffset(Offset = "0x10")]
			public Material[] materialsMaskDisabled;

			// Token: 0x040003B3 RID: 947
			[Token(Token = "0x40003B3")]
			[FieldOffset(Offset = "0x18")]
			public Material[] materialsInsideMask;

			// Token: 0x040003B4 RID: 948
			[Token(Token = "0x40003B4")]
			[FieldOffset(Offset = "0x20")]
			public Material[] materialsOutsideMask;
		}

		// Token: 0x0200008C RID: 140
		// (Invoke) Token: 0x0600060F RID: 1551
		[Token(Token = "0x200008C")]
		public delegate void InstructionDelegate(SkeletonRendererInstruction instruction);

		// Token: 0x0200008D RID: 141
		// (Invoke) Token: 0x06000613 RID: 1555
		[Token(Token = "0x200008D")]
		public delegate void SkeletonRendererDelegate(SkeletonRenderer skeletonRenderer);
	}
}
