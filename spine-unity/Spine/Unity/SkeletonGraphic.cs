using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Spine.Unity
{
	// Token: 0x02000081 RID: 129
	[Token(Token = "0x2000081")]
	[HelpURL("http://esotericsoftware.com/spine-unity#SkeletonGraphic-Component")]
	[AddComponentMenu("Spine/SkeletonGraphic (Unity UI Canvas)")]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	[RequireComponent(typeof(CanvasRenderer), typeof(RectTransform))]
	public class SkeletonGraphic : MaskableGraphic, ISkeletonComponent, IAnimationStateComponent, ISkeletonAnimation, IHasSkeletonDataAsset
	{
		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000561 RID: 1377 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x17000198")]
		public SkeletonDataAsset SkeletonDataAsset
		{
			[Token(Token = "0x6000561")]
			[Address(RVA = "0x4D6C490", Offset = "0x4D6B090", VA = "0x184D6C490", Slot = "77")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000562 RID: 1378 RVA: 0x000042D4 File Offset: 0x000024D4
		// (set) Token: 0x06000563 RID: 1379 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000199")]
		public UpdateMode UpdateMode
		{
			[Token(Token = "0x6000562")]
			[Address(RVA = "0x4E843D0", Offset = "0x4E82FD0", VA = "0x184E843D0")]
			get
			{
				return UpdateMode.Nothing;
			}
			[Token(Token = "0x6000563")]
			[Address(RVA = "0x4E84960", Offset = "0x4E83560", VA = "0x184E84960")]
			set
			{
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000564 RID: 1380 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x1700019A")]
		public List<Transform> SeparatorParts
		{
			[Token(Token = "0x6000564")]
			[Address(RVA = "0x4E84380", Offset = "0x4E82F80", VA = "0x184E84380")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000565")]
		[Address(RVA = "0x4E81DA0", Offset = "0x4E809A0", VA = "0x184E81DA0")]
		public static SkeletonGraphic NewSkeletonGraphicGameObject(SkeletonDataAsset skeletonDataAsset, Transform parent, Material material)
		{
			return null;
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000566")]
		[Address(RVA = "0x4E802F0", Offset = "0x4E7EEF0", VA = "0x184E802F0")]
		public static SkeletonGraphic AddSkeletonGraphicComponent(GameObject gameObject, SkeletonDataAsset skeletonDataAsset, Material material)
		{
			return null;
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000567 RID: 1383 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x1700019B")]
		public Dictionary<Texture, Texture> CustomTextureOverride
		{
			[Token(Token = "0x6000567")]
			[Address(RVA = "0x4E84350", Offset = "0x4E82F50", VA = "0x184E84350")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000568 RID: 1384 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x1700019C")]
		public Dictionary<Texture, Material> CustomMaterialOverride
		{
			[Token(Token = "0x6000568")]
			[Address(RVA = "0x4E84340", Offset = "0x4E82F40", VA = "0x184E84340")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000569 RID: 1385 RVA: 0x00002096 File Offset: 0x00000296
		// (set) Token: 0x0600056A RID: 1386 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700019D")]
		public Texture OverrideTexture
		{
			[Token(Token = "0x6000569")]
			[Address(RVA = "0x16925E0", Offset = "0x16911E0", VA = "0x1816925E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600056A")]
			[Address(RVA = "0x4E848C0", Offset = "0x4E834C0", VA = "0x184E848C0")]
			set
			{
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x0600056B RID: 1387 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x1700019E")]
		public override Texture mainTexture
		{
			[Token(Token = "0x600056B")]
			[Address(RVA = "0x4E843E0", Offset = "0x4E82FE0", VA = "0x184E843E0", Slot = "37")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600056C")]
		[Address(RVA = "0x4E804D0", Offset = "0x4E7F0D0", VA = "0x184E804D0", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600056D")]
		[Address(RVA = "0x4E81F80", Offset = "0x4E80B80", VA = "0x184E81F80", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600056E")]
		[Address(RVA = "0x4E821F0", Offset = "0x4E80DF0", VA = "0x184E821F0", Slot = "39")]
		public override void Rebuild(CanvasUpdate update)
		{
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600056F")]
		[Address(RVA = "0x4E81FA0", Offset = "0x4E80BA0", VA = "0x184E81FA0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000570")]
		[Address(RVA = "0x4E839B0", Offset = "0x4E825B0", VA = "0x184E839B0", Slot = "78")]
		public virtual void Update()
		{
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000571")]
		[Address(RVA = "0x4E83A20", Offset = "0x4E82620", VA = "0x184E83A20", Slot = "79")]
		public virtual void Update(float deltaTime)
		{
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000572")]
		[Address(RVA = "0x4E82390", Offset = "0x4E80F90", VA = "0x184E82390")]
		protected void SyncRawImagesWithCanvasRenderers()
		{
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000573")]
		[Address(RVA = "0x4E82840", Offset = "0x4E81440", VA = "0x184E82840")]
		protected void UpdateAnimationStatus(float deltaTime)
		{
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000574")]
		[Address(RVA = "0x4E803E0", Offset = "0x4E7EFE0", VA = "0x184E803E0")]
		protected void ApplyAnimation()
		{
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000575")]
		[Address(RVA = "0x4E817B0", Offset = "0x4E803B0", VA = "0x184E817B0")]
		public void LateUpdate()
		{
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000576")]
		[Address(RVA = "0x4E81F60", Offset = "0x4E80B60", VA = "0x184E81F60")]
		protected void OnCullStateChanged(bool culled)
		{
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000577")]
		[Address(RVA = "0x4E81F50", Offset = "0x4E80B50", VA = "0x184E81F50")]
		public void OnBecameVisible()
		{
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000578")]
		[Address(RVA = "0x4E81F40", Offset = "0x4E80B40", VA = "0x184E81F40")]
		public void OnBecameInvisible()
		{
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000579")]
		[Address(RVA = "0x4E820B0", Offset = "0x4E80CB0", VA = "0x184E820B0")]
		public void ReapplySeparatorSlotNames()
		{
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x0600057A RID: 1402 RVA: 0x00002096 File Offset: 0x00000296
		// (set) Token: 0x0600057B RID: 1403 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700019F")]
		public Skeleton Skeleton
		{
			[Token(Token = "0x600057A")]
			[Address(RVA = "0x4E843B0", Offset = "0x4E82FB0", VA = "0x184E843B0", Slot = "76")]
			get
			{
				return null;
			}
			[Token(Token = "0x600057B")]
			[Address(RVA = "0x4E84950", Offset = "0x4E83550", VA = "0x184E84950")]
			set
			{
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x0600057C RID: 1404 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x170001A0")]
		public SkeletonData SkeletonData
		{
			[Token(Token = "0x600057C")]
			[Address(RVA = "0x4E84390", Offset = "0x4E82F90", VA = "0x184E84390")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x0600057D RID: 1405 RVA: 0x000042EC File Offset: 0x000024EC
		[Token(Token = "0x170001A1")]
		public bool IsValid
		{
			[Token(Token = "0x600057D")]
			[Address(RVA = "0x4E84360", Offset = "0x4E82F60", VA = "0x184E84360")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x0600057E RID: 1406 RVA: 0x0000207E File Offset: 0x0000027E
		// (remove) Token: 0x0600057F RID: 1407 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x14000016")]
		public event SkeletonGraphic.SkeletonRendererDelegate OnRebuild
		{
			[Token(Token = "0x600057E")]
			[Address(RVA = "0x4E840A0", Offset = "0x4E82CA0", VA = "0x184E840A0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600057F")]
			[Address(RVA = "0x4E84640", Offset = "0x4E83240", VA = "0x184E84640")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000017 RID: 23
		// (add) Token: 0x06000580 RID: 1408 RVA: 0x0000207E File Offset: 0x0000027E
		// (remove) Token: 0x06000581 RID: 1409 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x14000017")]
		public event SkeletonGraphic.SkeletonRendererDelegate OnMeshAndMaterialsUpdated
		{
			[Token(Token = "0x6000580")]
			[Address(RVA = "0x4E83F60", Offset = "0x4E82B60", VA = "0x184E83F60")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000581")]
			[Address(RVA = "0x4E84500", Offset = "0x4E83100", VA = "0x184E84500")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000582 RID: 1410 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x170001A2")]
		public AnimationState AnimationState
		{
			[Token(Token = "0x6000582")]
			[Address(RVA = "0x4E84320", Offset = "0x4E82F20", VA = "0x184E84320", Slot = "69")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000583 RID: 1411 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x170001A3")]
		public MeshGenerator MeshGenerator
		{
			[Token(Token = "0x6000583")]
			[Address(RVA = "0x4E84370", Offset = "0x4E82F70", VA = "0x184E84370")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001A4 RID: 420
		// (set) Token: 0x06000584 RID: 1412 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170001A4")]
		public bool ReverseMesh
		{
			[Token(Token = "0x6000584")]
			[Address(RVA = "0x4E84940", Offset = "0x4E83540", VA = "0x184E84940")]
			set
			{
			}
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000585")]
		[Address(RVA = "0x4E810E0", Offset = "0x4E7FCE0", VA = "0x184E810E0")]
		public Mesh GetLastMesh()
		{
			return null;
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x00004304 File Offset: 0x00002504
		[Token(Token = "0x6000586")]
		[Address(RVA = "0x4E81C10", Offset = "0x4E80810", VA = "0x184E81C10")]
		public bool MatchRectTransformWithBounds()
		{
			return default(bool);
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x0000431C File Offset: 0x0000251C
		[Token(Token = "0x6000587")]
		[Address(RVA = "0x4E81AA0", Offset = "0x4E806A0", VA = "0x184E81AA0")]
		protected bool MatchRectTransformSingleRenderer()
		{
			return default(bool);
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x00004334 File Offset: 0x00002534
		[Token(Token = "0x6000588")]
		[Address(RVA = "0x4E81820", Offset = "0x4E80420", VA = "0x184E81820")]
		protected bool MatchRectTransformMultipleRenderers()
		{
			return default(bool);
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000589")]
		[Address(RVA = "0x4E82270", Offset = "0x4E80E70", VA = "0x184E82270")]
		private void SetRectTransformBounds(Bounds combinedBounds)
		{
		}

		// Token: 0x14000018 RID: 24
		// (add) Token: 0x0600058A RID: 1418 RVA: 0x0000207E File Offset: 0x0000027E
		// (remove) Token: 0x0600058B RID: 1419 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x14000018")]
		public event UpdateBonesDelegate BeforeApply
		{
			[Token(Token = "0x600058A")]
			[Address(RVA = "0x4E83EC0", Offset = "0x4E82AC0", VA = "0x184E83EC0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600058B")]
			[Address(RVA = "0x4E84460", Offset = "0x4E83060", VA = "0x184E84460")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000019 RID: 25
		// (add) Token: 0x0600058C RID: 1420 RVA: 0x0000207E File Offset: 0x0000027E
		// (remove) Token: 0x0600058D RID: 1421 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x14000019")]
		public event UpdateBonesDelegate UpdateLocal
		{
			[Token(Token = "0x600058C")]
			[Address(RVA = "0x4E841E0", Offset = "0x4E82DE0", VA = "0x184E841E0", Slot = "70")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600058D")]
			[Address(RVA = "0x4E84780", Offset = "0x4E83380", VA = "0x184E84780", Slot = "71")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x0600058E RID: 1422 RVA: 0x0000207E File Offset: 0x0000027E
		// (remove) Token: 0x0600058F RID: 1423 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1400001A")]
		public event UpdateBonesDelegate UpdateWorld
		{
			[Token(Token = "0x600058E")]
			[Address(RVA = "0x4E84280", Offset = "0x4E82E80", VA = "0x184E84280", Slot = "72")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600058F")]
			[Address(RVA = "0x4E84820", Offset = "0x4E83420", VA = "0x184E84820", Slot = "73")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400001B RID: 27
		// (add) Token: 0x06000590 RID: 1424 RVA: 0x0000207E File Offset: 0x0000027E
		// (remove) Token: 0x06000591 RID: 1425 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1400001B")]
		public event UpdateBonesDelegate UpdateComplete
		{
			[Token(Token = "0x6000590")]
			[Address(RVA = "0x4E84140", Offset = "0x4E82D40", VA = "0x184E84140", Slot = "74")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000591")]
			[Address(RVA = "0x4E846E0", Offset = "0x4E832E0", VA = "0x184E846E0", Slot = "75")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400001C RID: 28
		// (add) Token: 0x06000592 RID: 1426 RVA: 0x0000207E File Offset: 0x0000027E
		// (remove) Token: 0x06000593 RID: 1427 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1400001C")]
		public event MeshGeneratorDelegate OnPostProcessVertices
		{
			[Token(Token = "0x6000592")]
			[Address(RVA = "0x4E84000", Offset = "0x4E82C00", VA = "0x184E84000")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000593")]
			[Address(RVA = "0x4E845A0", Offset = "0x4E831A0", VA = "0x184E845A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000594")]
		[Address(RVA = "0x4E805D0", Offset = "0x4E7F1D0", VA = "0x184E805D0")]
		public void Clear()
		{
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000595")]
		[Address(RVA = "0x4E825E0", Offset = "0x4E811E0", VA = "0x184E825E0")]
		public void TrimRenderers()
		{
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000596")]
		[Address(RVA = "0x4E81290", Offset = "0x4E7FE90", VA = "0x184E81290")]
		public void Initialize(bool overwrite)
		{
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000597")]
		[Address(RVA = "0x4E83680", Offset = "0x4E82280", VA = "0x184E83680")]
		public void UpdateMesh(bool keepRendererCount = false)
		{
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x0000434C File Offset: 0x0000254C
		[Token(Token = "0x6000598")]
		[Address(RVA = "0x4E81140", Offset = "0x4E7FD40", VA = "0x184E81140")]
		public bool HasMultipleSubmeshInstructions()
		{
			return default(bool);
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000599")]
		[Address(RVA = "0x4E811A0", Offset = "0x4E7FDA0", VA = "0x184E811A0")]
		protected void InitMeshBuffers()
		{
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600059A")]
		[Address(RVA = "0x4E80990", Offset = "0x4E7F590", VA = "0x184E80990")]
		protected void DisposeMeshBuffers()
		{
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600059B")]
		[Address(RVA = "0x4E831A0", Offset = "0x4E81DA0", VA = "0x184E831A0")]
		protected void UpdateMeshSingleCanvasRenderer()
		{
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600059C")]
		[Address(RVA = "0x4E828A0", Offset = "0x4E814A0", VA = "0x184E828A0")]
		protected void UpdateMeshMultipleCanvasRenderers(SkeletonRendererInstruction currentInstructions, bool keepRendererCount)
		{
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600059D")]
		[Address(RVA = "0x4E80A30", Offset = "0x4E7F630", VA = "0x184E80A30")]
		protected void EnsureCanvasRendererCount(int targetCount)
		{
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600059E")]
		[Address(RVA = "0x4E808B0", Offset = "0x4E7F4B0", VA = "0x184E808B0")]
		protected void DisableUnusedCanvasRenderers(int usedCount)
		{
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600059F")]
		[Address(RVA = "0x4E80D60", Offset = "0x4E7F960", VA = "0x184E80D60")]
		protected void EnsureMeshesCount(int targetCount)
		{
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x4E80740", Offset = "0x4E7F340", VA = "0x184E80740")]
		protected void DestroyMeshes()
		{
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x4E80E10", Offset = "0x4E7FA10", VA = "0x184E80E10")]
		protected void EnsureSeparatorPartCount()
		{
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x4E83740", Offset = "0x4E82340", VA = "0x184E83740")]
		protected void UpdateSeparatorPartParents()
		{
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x4E83B80", Offset = "0x4E82780", VA = "0x184E83B80")]
		public SkeletonGraphic()
		{
		}

		// Token: 0x0400033E RID: 830
		[Token(Token = "0x400033E")]
		[FieldOffset(Offset = "0xE8")]
		public SkeletonDataAsset skeletonDataAsset;

		// Token: 0x0400033F RID: 831
		[Token(Token = "0x400033F")]
		[FieldOffset(Offset = "0xF0")]
		[SpineSkin("", "skeletonDataAsset", true, false, true)]
		public string initialSkinName;

		// Token: 0x04000340 RID: 832
		[Token(Token = "0x4000340")]
		[FieldOffset(Offset = "0xF8")]
		public bool initialFlipX;

		// Token: 0x04000341 RID: 833
		[Token(Token = "0x4000341")]
		[FieldOffset(Offset = "0xF9")]
		public bool initialFlipY;

		// Token: 0x04000342 RID: 834
		[Token(Token = "0x4000342")]
		[FieldOffset(Offset = "0x100")]
		[SpineAnimation("", "skeletonDataAsset", true, false)]
		public string startingAnimation;

		// Token: 0x04000343 RID: 835
		[Token(Token = "0x4000343")]
		[FieldOffset(Offset = "0x108")]
		public bool startingLoop;

		// Token: 0x04000344 RID: 836
		[Token(Token = "0x4000344")]
		[FieldOffset(Offset = "0x10C")]
		public float timeScale;

		// Token: 0x04000345 RID: 837
		[Token(Token = "0x4000345")]
		[FieldOffset(Offset = "0x110")]
		public bool freeze;

		// Token: 0x04000346 RID: 838
		[Token(Token = "0x4000346")]
		[FieldOffset(Offset = "0x114")]
		protected UpdateMode updateMode;

		// Token: 0x04000347 RID: 839
		[Token(Token = "0x4000347")]
		[FieldOffset(Offset = "0x118")]
		public UpdateMode updateWhenInvisible;

		// Token: 0x04000348 RID: 840
		[Token(Token = "0x4000348")]
		[FieldOffset(Offset = "0x11C")]
		public bool unscaledTime;

		// Token: 0x04000349 RID: 841
		[Token(Token = "0x4000349")]
		[FieldOffset(Offset = "0x11D")]
		public bool allowMultipleCanvasRenderers;

		// Token: 0x0400034A RID: 842
		[Token(Token = "0x400034A")]
		[FieldOffset(Offset = "0x120")]
		public List<CanvasRenderer> canvasRenderers;

		// Token: 0x0400034B RID: 843
		[Token(Token = "0x400034B")]
		[FieldOffset(Offset = "0x128")]
		protected List<RawImage> rawImages;

		// Token: 0x0400034C RID: 844
		[Token(Token = "0x400034C")]
		[FieldOffset(Offset = "0x130")]
		protected int usedRenderersCount;

		// Token: 0x0400034D RID: 845
		[Token(Token = "0x400034D")]
		public const string SeparatorPartGameObjectName = "Part";

		// Token: 0x0400034E RID: 846
		[Token(Token = "0x400034E")]
		[FieldOffset(Offset = "0x138")]
		[SpineSlot("", "", false, true, false)]
		[SerializeField]
		protected string[] separatorSlotNames;

		// Token: 0x0400034F RID: 847
		[Token(Token = "0x400034F")]
		[FieldOffset(Offset = "0x140")]
		[NonSerialized]
		public readonly List<Slot> separatorSlots;

		// Token: 0x04000350 RID: 848
		[Token(Token = "0x4000350")]
		[FieldOffset(Offset = "0x148")]
		public bool enableSeparatorSlots;

		// Token: 0x04000351 RID: 849
		[Token(Token = "0x4000351")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		protected List<Transform> separatorParts;

		// Token: 0x04000352 RID: 850
		[Token(Token = "0x4000352")]
		[FieldOffset(Offset = "0x158")]
		public bool updateSeparatorPartLocation;

		// Token: 0x04000353 RID: 851
		[Token(Token = "0x4000353")]
		[FieldOffset(Offset = "0x159")]
		private bool wasUpdatedAfterInit;

		// Token: 0x04000354 RID: 852
		[Token(Token = "0x4000354")]
		[FieldOffset(Offset = "0x160")]
		private Texture baseTexture;

		// Token: 0x04000355 RID: 853
		[Token(Token = "0x4000355")]
		[FieldOffset(Offset = "0x168")]
		[NonSerialized]
		private readonly Dictionary<Texture, Texture> customTextureOverride;

		// Token: 0x04000356 RID: 854
		[Token(Token = "0x4000356")]
		[FieldOffset(Offset = "0x170")]
		[NonSerialized]
		private readonly Dictionary<Texture, Material> customMaterialOverride;

		// Token: 0x04000357 RID: 855
		[Token(Token = "0x4000357")]
		[FieldOffset(Offset = "0x178")]
		private Texture overrideTexture;

		// Token: 0x04000358 RID: 856
		[Token(Token = "0x4000358")]
		[FieldOffset(Offset = "0x180")]
		protected Skeleton skeleton;

		// Token: 0x0400035B RID: 859
		[Token(Token = "0x400035B")]
		[FieldOffset(Offset = "0x198")]
		protected AnimationState state;

		// Token: 0x0400035C RID: 860
		[Token(Token = "0x400035C")]
		[FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		protected MeshGenerator meshGenerator;

		// Token: 0x0400035D RID: 861
		[Token(Token = "0x400035D")]
		[FieldOffset(Offset = "0x1A8")]
		private DoubleBuffered<MeshRendererBuffers.SmartMesh> meshBuffers;

		// Token: 0x0400035E RID: 862
		[Token(Token = "0x400035E")]
		[FieldOffset(Offset = "0x1B0")]
		private SkeletonRendererInstruction currentInstructions;

		// Token: 0x0400035F RID: 863
		[Token(Token = "0x400035F")]
		[FieldOffset(Offset = "0x1B8")]
		private readonly ExposedList<Mesh> meshes;

		// Token: 0x04000360 RID: 864
		[Token(Token = "0x4000360")]
		[FieldOffset(Offset = "0x1C0")]
		private bool reverseMesh;

		// Token: 0x02000082 RID: 130
		// (Invoke) Token: 0x060005A5 RID: 1445
		[Token(Token = "0x2000082")]
		public delegate void SkeletonRendererDelegate(SkeletonGraphic skeletonGraphic);
	}
}
