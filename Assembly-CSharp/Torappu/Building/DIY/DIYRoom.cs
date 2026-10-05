using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.Building.Vault;
using Torappu.GraphicEffect.Reflection;
using UnityEngine;
using XLua;

namespace Torappu.Building.DIY
{
	// Token: 0x02001852 RID: 6226
	[Token(Token = "0x2001852")]
	public class DIYRoom : MonoBehaviour, IHotfixable, IFurnitureProviderListener, IDIYRoomModifierProviderListener, DIYRoomModifier.IListener, Furniture.IListener, ITimeWatcher
	{
		// Token: 0x17001169 RID: 4457
		// (get) Token: 0x06009D64 RID: 40292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001169")]
		public Camera mainCamera
		{
			[Token(Token = "0x6009D64")]
			[Address(RVA = "0x3185910", Offset = "0x3184510", VA = "0x183185910")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700116A RID: 4458
		// (get) Token: 0x06009D65 RID: 40293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700116A")]
		public Camera indicatorCamera
		{
			[Token(Token = "0x6009D65")]
			[Address(RVA = "0x31858B0", Offset = "0x31844B0", VA = "0x1831858B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700116B RID: 4459
		// (get) Token: 0x06009D66 RID: 40294 RVA: 0x0003D758 File Offset: 0x0003B958
		[Token(Token = "0x1700116B")]
		public int roomWidth
		{
			[Token(Token = "0x6009D66")]
			[Address(RVA = "0x3185A90", Offset = "0x3184690", VA = "0x183185A90")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700116C RID: 4460
		// (get) Token: 0x06009D67 RID: 40295 RVA: 0x0003D770 File Offset: 0x0003B970
		[Token(Token = "0x1700116C")]
		public int roomHeight
		{
			[Token(Token = "0x6009D67")]
			[Address(RVA = "0x31859D0", Offset = "0x31845D0", VA = "0x1831859D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700116D RID: 4461
		// (get) Token: 0x06009D68 RID: 40296 RVA: 0x0003D788 File Offset: 0x0003B988
		[Token(Token = "0x1700116D")]
		public int roomDepth
		{
			[Token(Token = "0x6009D68")]
			[Address(RVA = "0x3185970", Offset = "0x3184570", VA = "0x183185970")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700116E RID: 4462
		// (get) Token: 0x06009D69 RID: 40297 RVA: 0x0003D7A0 File Offset: 0x0003B9A0
		[Token(Token = "0x1700116E")]
		public int roomIndex
		{
			[Token(Token = "0x6009D69")]
			[Address(RVA = "0x3185A30", Offset = "0x3184630", VA = "0x183185A30")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06009D6A RID: 40298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D6A")]
		[Address(RVA = "0x317D220", Offset = "0x317BE20", VA = "0x18317D220")]
		private void Awake()
		{
		}

		// Token: 0x06009D6B RID: 40299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D6B")]
		[Address(RVA = "0x317E560", Offset = "0x317D160", VA = "0x18317E560")]
		private void LateUpdate()
		{
		}

		// Token: 0x06009D6C RID: 40300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D6C")]
		[Address(RVA = "0x317F3F0", Offset = "0x317DFF0", VA = "0x18317F3F0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06009D6D RID: 40301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D6D")]
		[Address(RVA = "0x317FC80", Offset = "0x317E880", VA = "0x18317FC80")]
		public void SetCameraMarginRatioBottom(float ratio)
		{
		}

		// Token: 0x06009D6E RID: 40302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D6E")]
		[Address(RVA = "0x3183150", Offset = "0x3181D50", VA = "0x183183150")]
		private void _AwakeInit()
		{
		}

		// Token: 0x06009D6F RID: 40303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D6F")]
		[Address(RVA = "0x317DB40", Offset = "0x317C740", VA = "0x18317DB40")]
		private void ClearupGridMesh()
		{
		}

		// Token: 0x06009D70 RID: 40304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D70")]
		[Address(RVA = "0x317FE00", Offset = "0x317EA00", VA = "0x18317FE00")]
		public void SetOuterCamera(Camera camera)
		{
		}

		// Token: 0x06009D71 RID: 40305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D71")]
		[Address(RVA = "0x317FE80", Offset = "0x317EA80", VA = "0x18317FE80")]
		public void SetReflectMaterialFilter(DIYRoom.IRefectionMaterialFilter filter)
		{
		}

		// Token: 0x06009D72 RID: 40306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009D72")]
		[Address(RVA = "0x3183BF0", Offset = "0x31827F0", VA = "0x183183BF0")]
		private Mesh _GenerateGridMesh(GridLocator locator, int size0, int size1, bool clockwise = true)
		{
			return null;
		}

		// Token: 0x06009D73 RID: 40307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D73")]
		[Address(RVA = "0x317E070", Offset = "0x317CC70", VA = "0x18317E070")]
		public void GatherFloorObstacleRect(Action<BuildingData.ObstacleRect> action)
		{
		}

		// Token: 0x06009D74 RID: 40308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D74")]
		[Address(RVA = "0x317FB00", Offset = "0x317E700", VA = "0x18317FB00")]
		public void RemoveHighlightMark(GameObject mark)
		{
		}

		// Token: 0x06009D75 RID: 40309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D75")]
		[Address(RVA = "0x317D280", Offset = "0x317BE80", VA = "0x18317D280")]
		public void ClearHighlightMark()
		{
		}

		// Token: 0x06009D76 RID: 40310 RVA: 0x0003D7B8 File Offset: 0x0003B9B8
		[Token(Token = "0x6009D76")]
		[Address(RVA = "0x317E1A0", Offset = "0x317CDA0", VA = "0x18317E1A0")]
		public bool HasFurnitureIntersection()
		{
			return default(bool);
		}

		// Token: 0x06009D77 RID: 40311 RVA: 0x0003D7D0 File Offset: 0x0003B9D0
		[Token(Token = "0x6009D77")]
		[Address(RVA = "0x3183720", Offset = "0x3182320", VA = "0x183183720")]
		private bool _CheckIntersectedFurnitures(GridMachine gridMachine, int w, int h)
		{
			return default(bool);
		}

		// Token: 0x06009D78 RID: 40312 RVA: 0x0003D7E8 File Offset: 0x0003B9E8
		[Token(Token = "0x6009D78")]
		[Address(RVA = "0x3183540", Offset = "0x3182140", VA = "0x183183540")]
		private bool _CheckIntersectedFurnitures3D(GridMachine3D gridMachine3D, int w, int h, int d)
		{
			return default(bool);
		}

		// Token: 0x06009D79 RID: 40313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D79")]
		[Address(RVA = "0x31838E0", Offset = "0x31824E0", VA = "0x1831838E0")]
		private void _CheckIntersectedFurnitures(Furniture furniture)
		{
		}

		// Token: 0x06009D7A RID: 40314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D7A")]
		[Address(RVA = "0x3184080", Offset = "0x3182C80", VA = "0x183184080")]
		private void _OnFurnitureControlNodePositionSetEvent(DIYRoom.FurnitureControlNode node, int oldPos0, int oldPos1)
		{
		}

		// Token: 0x06009D7B RID: 40315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D7B")]
		[Address(RVA = "0x3184130", Offset = "0x3182D30", VA = "0x183184130")]
		private void _OnFurnitureControlNodeRoomIndexChangeEvent(DIYRoom.FurnitureControlNode node)
		{
		}

		// Token: 0x06009D7C RID: 40316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D7C")]
		[Address(RVA = "0x31841E0", Offset = "0x3182DE0", VA = "0x1831841E0")]
		private void _RegisterFurniture(Furniture furniture, bool isAsync)
		{
		}

		// Token: 0x06009D7D RID: 40317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D7D")]
		[Address(RVA = "0x31825C0", Offset = "0x31811C0", VA = "0x1831825C0")]
		public void UpdateMaterialOutlineIfNeeded(bool isReset, float progress)
		{
		}

		// Token: 0x06009D7E RID: 40318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D7E")]
		[Address(RVA = "0x3182700", Offset = "0x3181300", VA = "0x183182700")]
		public void UpdateMaterialRenderQueue(bool isReset)
		{
		}

		// Token: 0x06009D7F RID: 40319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D7F")]
		[Address(RVA = "0x3184F70", Offset = "0x3183B70", VA = "0x183184F70")]
		private void _UnregisterFurniture(Furniture furniture)
		{
		}

		// Token: 0x06009D80 RID: 40320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D80")]
		[Address(RVA = "0x3182990", Offset = "0x3181590", VA = "0x183182990")]
		private void _ApplyDIYRoomModifier(Renderer[] renderers, MeshFilter meshFilter, DIYRoomModifier modifier, Material originMat, Mesh originMesh)
		{
		}

		// Token: 0x06009D81 RID: 40321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D81")]
		[Address(RVA = "0x3182C60", Offset = "0x3181860", VA = "0x183182C60")]
		private void _ApplyFloorDIYRoomModifier(DIYRoomModifier modifier)
		{
		}

		// Token: 0x06009D82 RID: 40322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D82")]
		[Address(RVA = "0x3182DD0", Offset = "0x31819D0", VA = "0x183182DD0")]
		private void _ApplyWallDIYRoomModifier(DIYRoomModifier modifier)
		{
		}

		// Token: 0x06009D83 RID: 40323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D83")]
		[Address(RVA = "0x31852C0", Offset = "0x3183EC0", VA = "0x1831852C0")]
		private void _UpdateCamera()
		{
		}

		// Token: 0x06009D84 RID: 40324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D84")]
		[Address(RVA = "0x317FA30", Offset = "0x317E630", VA = "0x18317FA30")]
		public void RegisterListener(DIYRoom.IListener listener)
		{
		}

		// Token: 0x06009D85 RID: 40325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D85")]
		[Address(RVA = "0x31824F0", Offset = "0x31810F0", VA = "0x1831824F0")]
		public void UnregisterListener(DIYRoom.IListener listener)
		{
		}

		// Token: 0x06009D86 RID: 40326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D86")]
		[Address(RVA = "0x3181130", Offset = "0x317FD30", VA = "0x183181130")]
		public void ShowGridMesh(bool showFloor, bool showWall, bool showCeiling, bool showCeilingMask)
		{
		}

		// Token: 0x06009D87 RID: 40327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D87")]
		[Address(RVA = "0x31810B0", Offset = "0x317FCB0", VA = "0x1831810B0")]
		public void ShowFrame(bool isShow)
		{
		}

		// Token: 0x06009D88 RID: 40328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D88")]
		[Address(RVA = "0x317E3D0", Offset = "0x317CFD0", VA = "0x18317E3D0")]
		public void HideAllGridMesh()
		{
		}

		// Token: 0x06009D89 RID: 40329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D89")]
		[Address(RVA = "0x3182830", Offset = "0x3181430", VA = "0x183182830", Slot = "12")]
		public void UpdateTime(float deltaTime)
		{
		}

		// Token: 0x06009D8A RID: 40330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D8A")]
		[Address(RVA = "0x317FF40", Offset = "0x317EB40", VA = "0x18317FF40")]
		public void Setup(IFurnitureProvider furnitureProvider, IDIYRoomModifierProvider DIYRoomModifierProvider, IDIYRoomInfoProvider DIYRoomInfoProvider, int roomIndex, [Optional] GameObject leftDoorProto, [Optional] GameObject rightDoorProto, bool force = false, bool isAsync = false, [Optional] ReflectCameraHolder reflectCameraHolder, float reflectFadeHeight = 3f)
		{
		}

		// Token: 0x06009D8B RID: 40331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D8B")]
		[Address(RVA = "0x3184AF0", Offset = "0x31836F0", VA = "0x183184AF0")]
		private void _SetupByPrefabSetting(ReflectCameraHolder reflectCameraHolder, float reflectFadeHeight)
		{
		}

		// Token: 0x06009D8C RID: 40332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D8C")]
		[Address(RVA = "0x3184910", Offset = "0x3183510", VA = "0x183184910")]
		private void _SetupByDIYRoomInfo(GameObject leftDoorProto, GameObject rightDoorProto, ReflectCameraHolder reflectCameraHolder, float reflectFadeHeight)
		{
		}

		// Token: 0x06009D8D RID: 40333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D8D")]
		[Address(RVA = "0x3181310", Offset = "0x317FF10", VA = "0x183181310")]
		public void SwitchOffFurnitureDisplay(List<FurnitureLocationType> typeList)
		{
		}

		// Token: 0x06009D8E RID: 40334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D8E")]
		[Address(RVA = "0x317D490", Offset = "0x317C090", VA = "0x18317D490")]
		public void ClearUp()
		{
		}

		// Token: 0x06009D8F RID: 40335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D8F")]
		[Address(RVA = "0x317F790", Offset = "0x317E390", VA = "0x18317F790")]
		public void RefreshIntersection()
		{
		}

		// Token: 0x06009D90 RID: 40336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D90")]
		[Address(RVA = "0x317DF80", Offset = "0x317CB80", VA = "0x18317DF80")]
		public void ForEachFurnitureController(Action<DIYRoom.IFurnitureController> action)
		{
		}

		// Token: 0x06009D91 RID: 40337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D91")]
		[Address(RVA = "0x317DC90", Offset = "0x317C890", VA = "0x18317DC90")]
		public void ForEachAttachPointExporterAsync(Action<DIYRoom.IAttachPointExporter> action)
		{
		}

		// Token: 0x06009D92 RID: 40338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D92")]
		[Address(RVA = "0x317F450", Offset = "0x317E050", VA = "0x18317F450", Slot = "4")]
		public void OnFurnitureAdded(Furniture furniture)
		{
		}

		// Token: 0x06009D93 RID: 40339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D93")]
		[Address(RVA = "0x317F5A0", Offset = "0x317E1A0", VA = "0x18317F5A0", Slot = "5")]
		public void OnFurnitureRemoved(Furniture furniture)
		{
		}

		// Token: 0x06009D94 RID: 40340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D94")]
		[Address(RVA = "0x317E5C0", Offset = "0x317D1C0", VA = "0x18317E5C0", Slot = "6")]
		public void OnDIYRoomModifierAdded(DIYRoomModifier modifier)
		{
		}

		// Token: 0x06009D95 RID: 40341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D95")]
		[Address(RVA = "0x317E900", Offset = "0x317D500", VA = "0x18317E900", Slot = "7")]
		public void OnDIYRoomModifierRemoved(DIYRoomModifier modifier)
		{
		}

		// Token: 0x06009D96 RID: 40342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D96")]
		[Address(RVA = "0x317EC60", Offset = "0x317D860", VA = "0x18317EC60", Slot = "8")]
		public void OnDIYRoomModifierRoomIndexChanged(int oldIndex, DIYRoomModifier modifier)
		{
		}

		// Token: 0x06009D97 RID: 40343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D97")]
		[Address(RVA = "0x317F510", Offset = "0x317E110", VA = "0x18317F510", Slot = "9")]
		public void OnFurniturePositionChanged(int oldPos0, int oldPos1, Furniture furniture)
		{
		}

		// Token: 0x06009D98 RID: 40344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D98")]
		[Address(RVA = "0x317F710", Offset = "0x317E310", VA = "0x18317F710", Slot = "10")]
		public void OnFurnitureRotateChanged(int dir, Furniture furniture)
		{
		}

		// Token: 0x06009D99 RID: 40345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D99")]
		[Address(RVA = "0x317F650", Offset = "0x317E250", VA = "0x18317F650", Slot = "11")]
		public void OnFurnitureRoomIndexChanged(int oldIndex, Furniture furniture)
		{
		}

		// Token: 0x06009D9A RID: 40346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D9A")]
		[Address(RVA = "0x31855B0", Offset = "0x31841B0", VA = "0x1831855B0")]
		public DIYRoom()
		{
		}

		// Token: 0x04009414 RID: 37908
		[Token(Token = "0x4009414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _groundGridSize;

		// Token: 0x04009415 RID: 37909
		[Token(Token = "0x4009415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _wallGridSize;

		// Token: 0x04009416 RID: 37910
		[Token(Token = "0x4009416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int _roomWidth;

		// Token: 0x04009417 RID: 37911
		[Token(Token = "0x4009417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private int _roomHeight;

		// Token: 0x04009418 RID: 37912
		[Token(Token = "0x4009418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int _roomDepth;

		// Token: 0x04009419 RID: 37913
		[Token(Token = "0x4009419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Camera _mainCamera;

		// Token: 0x0400941A RID: 37914
		[Token(Token = "0x400941A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Camera _indicatorCamera;

		// Token: 0x0400941B RID: 37915
		[Token(Token = "0x400941B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _cameraMarginMin;

		// Token: 0x0400941C RID: 37916
		[Token(Token = "0x400941C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float _cameraMarginMax;

		// Token: 0x0400941D RID: 37917
		[Token(Token = "0x400941D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		public Vector3 _cameraOffset;

		// Token: 0x0400941E RID: 37918
		[Token(Token = "0x400941E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		public Vector3 _cameraLookOffset;

		// Token: 0x0400941F RID: 37919
		[Token(Token = "0x400941F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private bool _useDIYRoomInfo;

		// Token: 0x04009420 RID: 37920
		[Token(Token = "0x4009420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private DIYRoomPrefabSettings _overrideDIYRoomPrefabSetting;

		// Token: 0x04009421 RID: 37921
		[Token(Token = "0x4009421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Shader _markShader;

		// Token: 0x04009422 RID: 37922
		[Token(Token = "0x4009422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Texture2D _okTexture;

		// Token: 0x04009423 RID: 37923
		[Token(Token = "0x4009423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Texture2D _ngTexture;

		// Token: 0x04009424 RID: 37924
		[Token(Token = "0x4009424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Texture2D _okSelectTexture;

		// Token: 0x04009425 RID: 37925
		[Token(Token = "0x4009425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Texture2D _ngSelectTexture;

		// Token: 0x04009426 RID: 37926
		[Token(Token = "0x4009426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _indicatorProto;

		// Token: 0x04009427 RID: 37927
		[Token(Token = "0x4009427")]
		private const int VCHARACTER_HEIGHT_BOUNDING_GRID_SIZE = 5;

		// Token: 0x04009428 RID: 37928
		[Token(Token = "0x4009428")]
		public const string SHADER_PROPERTY_OUTLINE = "_OutlineWidth";

		// Token: 0x04009429 RID: 37929
		[Token(Token = "0x4009429")]
		public const int ABOVE_CEILING_RENDER_QUEUE = 2501;

		// Token: 0x0400942A RID: 37930
		[Token(Token = "0x400942A")]
		private const string UNSUPPORT_ORTHO_LEGACY_NORMAL_SHADER = "Torappu/Unlit/TextureOutline";

		// Token: 0x0400942B RID: 37931
		[Token(Token = "0x400942B")]
		private const string UNSUPPORT_ORTHO_LEGACY_ALPHA_SHADER = "Torappu/Unlit/TextureOutlineAlphaTest";

		// Token: 0x0400942C RID: 37932
		[Token(Token = "0x400942C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private GridLocator m_locatorGround;

		// Token: 0x0400942D RID: 37933
		[Token(Token = "0x400942D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private GridLocator m_locatorWall;

		// Token: 0x0400942E RID: 37934
		[Token(Token = "0x400942E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private GridLocator m_locatorCeiling;

		// Token: 0x0400942F RID: 37935
		[Token(Token = "0x400942F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private GridMachine m_gridMachineGround;

		// Token: 0x04009430 RID: 37936
		[Token(Token = "0x4009430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private GridMachine m_gridMachineCarpet;

		// Token: 0x04009431 RID: 37937
		[Token(Token = "0x4009431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private GridMachine m_gridMachinePoster;

		// Token: 0x04009432 RID: 37938
		[Token(Token = "0x4009432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private GridMachine m_gridMachineCeilingDecal;

		// Token: 0x04009433 RID: 37939
		[Token(Token = "0x4009433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private GridMachine3D m_gridMachine3D;

		// Token: 0x04009434 RID: 37940
		[Token(Token = "0x4009434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private IFurnitureProvider m_furnitureProvider;

		// Token: 0x04009435 RID: 37941
		[Token(Token = "0x4009435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private IDIYRoomModifierProvider m_DIYRoomModifierProvider;

		// Token: 0x04009436 RID: 37942
		[Token(Token = "0x4009436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private IDIYRoomInfoProvider m_DIYRoomInfoProvider;

		// Token: 0x04009437 RID: 37943
		[Token(Token = "0x4009437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private DIYRoomModifier m_wallModifier;

		// Token: 0x04009438 RID: 37944
		[Token(Token = "0x4009438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private DIYRoomModifier m_floorModifier;

		// Token: 0x04009439 RID: 37945
		[Token(Token = "0x4009439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Material m_wallOriginMaterial;

		// Token: 0x0400943A RID: 37946
		[Token(Token = "0x400943A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Material m_floorOriginMaterial;

		// Token: 0x0400943B RID: 37947
		[Token(Token = "0x400943B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Mesh m_wallOriginMesh;

		// Token: 0x0400943C RID: 37948
		[Token(Token = "0x400943C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Mesh m_floorOriginMesh;

		// Token: 0x0400943D RID: 37949
		[Token(Token = "0x400943D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private int m_currentRoomIndex;

		// Token: 0x0400943E RID: 37950
		[Token(Token = "0x400943E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private GameObject m_dormitoryGameObject;

		// Token: 0x0400943F RID: 37951
		[Token(Token = "0x400943F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Renderer m_wallRenderer;

		// Token: 0x04009440 RID: 37952
		[Token(Token = "0x4009440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Renderer m_floorRenderer;

		// Token: 0x04009441 RID: 37953
		[Token(Token = "0x4009441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private ReflectCameraHolder m_floorReflect;

		// Token: 0x04009442 RID: 37954
		[Token(Token = "0x4009442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private DIYRoom.IRefectionMaterialFilter m_floorRefectMatFilter;

		// Token: 0x04009443 RID: 37955
		[Token(Token = "0x4009443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private MeshRenderer m_floorReflectBound;

		// Token: 0x04009444 RID: 37956
		[Token(Token = "0x4009444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private float m_floorReflectFadeHeight;

		// Token: 0x04009445 RID: 37957
		[Token(Token = "0x4009445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private Renderer[] m_doorRenderers;

		// Token: 0x04009446 RID: 37958
		[Token(Token = "0x4009446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private MeshFilter m_wallMeshFilter;

		// Token: 0x04009447 RID: 37959
		[Token(Token = "0x4009447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private MeshFilter m_floorMeshFilter;

		// Token: 0x04009448 RID: 37960
		[Token(Token = "0x4009448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private List<DIYRoom.IListener> m_listeners;

		// Token: 0x04009449 RID: 37961
		[Token(Token = "0x4009449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private List<GameObject> m_highlightMarks;

		// Token: 0x0400944A RID: 37962
		[Token(Token = "0x400944A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private Mesh m_floorGridMesh;

		// Token: 0x0400944B RID: 37963
		[Token(Token = "0x400944B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private Mesh m_wallGridMesh;

		// Token: 0x0400944C RID: 37964
		[Token(Token = "0x400944C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private Mesh m_ceilingGridMesh;

		// Token: 0x0400944D RID: 37965
		[Token(Token = "0x400944D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private Mesh m_ceilingGridMaskMesh;

		// Token: 0x0400944E RID: 37966
		[Token(Token = "0x400944E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private MeshRenderer m_floorGridMeshRenderer;

		// Token: 0x0400944F RID: 37967
		[Token(Token = "0x400944F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private MeshRenderer m_wallGridMeshRenderer;

		// Token: 0x04009450 RID: 37968
		[Token(Token = "0x4009450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private MeshRenderer m_ceilingGridMeshRenderer;

		// Token: 0x04009451 RID: 37969
		[Token(Token = "0x4009451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private MeshRenderer m_ceilingGridMaskMeshRenderer;

		// Token: 0x04009452 RID: 37970
		[Token(Token = "0x4009452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private List<GameObject> m_obstacleIndicatorList;

		// Token: 0x04009453 RID: 37971
		[Token(Token = "0x4009453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private GameObject m_frame;

		// Token: 0x04009454 RID: 37972
		[Token(Token = "0x4009454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private bool m_preIntersectCarpet;

		// Token: 0x04009455 RID: 37973
		[Token(Token = "0x4009455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E1")]
		private bool m_preIntersectPoster;

		// Token: 0x04009456 RID: 37974
		[Token(Token = "0x4009456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E2")]
		private bool m_preIntersectCeilingDecal;

		// Token: 0x04009457 RID: 37975
		[Token(Token = "0x4009457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E3")]
		private bool m_preIntersect3D;

		// Token: 0x04009458 RID: 37976
		[Token(Token = "0x4009458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private List<DIYRoom.FurnitureControlNode> m_furnitureList;

		// Token: 0x04009459 RID: 37977
		[Token(Token = "0x4009459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private Dictionary<string, Material> m_furnitureMaterial;

		// Token: 0x0400945A RID: 37978
		[Token(Token = "0x400945A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private Dictionary<string, Material> m_modifiedFurnitureMaterial;

		// Token: 0x0400945B RID: 37979
		[Token(Token = "0x400945B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private bool m_awakeInited;

		// Token: 0x0400945C RID: 37980
		[Token(Token = "0x400945C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x201")]
		private bool m_alreadySetup;

		// Token: 0x0400945D RID: 37981
		[Token(Token = "0x400945D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private Camera m_outerCamera;

		// Token: 0x0400945E RID: 37982
		[Token(Token = "0x400945E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_mainCamera;

		// Token: 0x0400945F RID: 37983
		[Token(Token = "0x400945F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_indicatorCamera;

		// Token: 0x04009460 RID: 37984
		[Token(Token = "0x4009460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_roomWidth;

		// Token: 0x04009461 RID: 37985
		[Token(Token = "0x4009461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_roomHeight;

		// Token: 0x04009462 RID: 37986
		[Token(Token = "0x4009462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_roomDepth;

		// Token: 0x04009463 RID: 37987
		[Token(Token = "0x4009463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_roomIndex;

		// Token: 0x04009464 RID: 37988
		[Token(Token = "0x4009464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x04009465 RID: 37989
		[Token(Token = "0x4009465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_LateUpdate;

		// Token: 0x04009466 RID: 37990
		[Token(Token = "0x4009466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04009467 RID: 37991
		[Token(Token = "0x4009467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_SetCameraMarginRatioBottom;

		// Token: 0x04009468 RID: 37992
		[Token(Token = "0x4009468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__AwakeInit;

		// Token: 0x04009469 RID: 37993
		[Token(Token = "0x4009469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_ClearupGridMesh;

		// Token: 0x0400946A RID: 37994
		[Token(Token = "0x400946A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_SetOuterCamera;

		// Token: 0x0400946B RID: 37995
		[Token(Token = "0x400946B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_SetReflectMaterialFilter;

		// Token: 0x0400946C RID: 37996
		[Token(Token = "0x400946C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__GenerateGridMesh;

		// Token: 0x0400946D RID: 37997
		[Token(Token = "0x400946D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GatherFloorObstacleRect;

		// Token: 0x0400946E RID: 37998
		[Token(Token = "0x400946E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_RemoveHighlightMark;

		// Token: 0x0400946F RID: 37999
		[Token(Token = "0x400946F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_ClearHighlightMark;

		// Token: 0x04009470 RID: 38000
		[Token(Token = "0x4009470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_HasFurnitureIntersection;

		// Token: 0x04009471 RID: 38001
		[Token(Token = "0x4009471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__CheckIntersectedFurnitures;

		// Token: 0x04009472 RID: 38002
		[Token(Token = "0x4009472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__CheckIntersectedFurnitures3D;

		// Token: 0x04009473 RID: 38003
		[Token(Token = "0x4009473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix1__CheckIntersectedFurnitures;

		// Token: 0x04009474 RID: 38004
		[Token(Token = "0x4009474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__OnFurnitureControlNodePositionSetEvent;

		// Token: 0x04009475 RID: 38005
		[Token(Token = "0x4009475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__OnFurnitureControlNodeRoomIndexChangeEvent;

		// Token: 0x04009476 RID: 38006
		[Token(Token = "0x4009476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__RegisterFurniture;

		// Token: 0x04009477 RID: 38007
		[Token(Token = "0x4009477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_UpdateMaterialOutlineIfNeeded;

		// Token: 0x04009478 RID: 38008
		[Token(Token = "0x4009478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_UpdateMaterialRenderQueue;

		// Token: 0x04009479 RID: 38009
		[Token(Token = "0x4009479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__UnregisterFurniture;

		// Token: 0x0400947A RID: 38010
		[Token(Token = "0x400947A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__ApplyDIYRoomModifier;

		// Token: 0x0400947B RID: 38011
		[Token(Token = "0x400947B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__ApplyFloorDIYRoomModifier;

		// Token: 0x0400947C RID: 38012
		[Token(Token = "0x400947C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__ApplyWallDIYRoomModifier;

		// Token: 0x0400947D RID: 38013
		[Token(Token = "0x400947D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__UpdateCamera;

		// Token: 0x0400947E RID: 38014
		[Token(Token = "0x400947E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_RegisterListener;

		// Token: 0x0400947F RID: 38015
		[Token(Token = "0x400947F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_UnregisterListener;

		// Token: 0x04009480 RID: 38016
		[Token(Token = "0x4009480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_ShowGridMesh;

		// Token: 0x04009481 RID: 38017
		[Token(Token = "0x4009481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_ShowFrame;

		// Token: 0x04009482 RID: 38018
		[Token(Token = "0x4009482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_HideAllGridMesh;

		// Token: 0x04009483 RID: 38019
		[Token(Token = "0x4009483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_UpdateTime;

		// Token: 0x04009484 RID: 38020
		[Token(Token = "0x4009484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_Setup;

		// Token: 0x04009485 RID: 38021
		[Token(Token = "0x4009485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0__SetupByPrefabSetting;

		// Token: 0x04009486 RID: 38022
		[Token(Token = "0x4009486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0__SetupByDIYRoomInfo;

		// Token: 0x04009487 RID: 38023
		[Token(Token = "0x4009487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_SwitchOffFurnitureDisplay;

		// Token: 0x04009488 RID: 38024
		[Token(Token = "0x4009488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_ClearUp;

		// Token: 0x04009489 RID: 38025
		[Token(Token = "0x4009489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_RefreshIntersection;

		// Token: 0x0400948A RID: 38026
		[Token(Token = "0x400948A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_ForEachFurnitureController;

		// Token: 0x0400948B RID: 38027
		[Token(Token = "0x400948B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_ForEachAttachPointExporterAsync;

		// Token: 0x0400948C RID: 38028
		[Token(Token = "0x400948C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_OnFurnitureAdded;

		// Token: 0x0400948D RID: 38029
		[Token(Token = "0x400948D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0_OnFurnitureRemoved;

		// Token: 0x0400948E RID: 38030
		[Token(Token = "0x400948E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0_OnDIYRoomModifierAdded;

		// Token: 0x0400948F RID: 38031
		[Token(Token = "0x400948F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_OnDIYRoomModifierRemoved;

		// Token: 0x04009490 RID: 38032
		[Token(Token = "0x4009490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0_OnDIYRoomModifierRoomIndexChanged;

		// Token: 0x04009491 RID: 38033
		[Token(Token = "0x4009491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0_OnFurniturePositionChanged;

		// Token: 0x04009492 RID: 38034
		[Token(Token = "0x4009492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0_OnFurnitureRotateChanged;

		// Token: 0x04009493 RID: 38035
		[Token(Token = "0x4009493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0_OnFurnitureRoomIndexChanged;

		// Token: 0x04009494 RID: 38036
		[Token(Token = "0x4009494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001853 RID: 6227
		[Token(Token = "0x2001853")]
		public interface IListener
		{
			// Token: 0x06009DA3 RID: 40355
			[Token(Token = "0x6009DA3")]
			void OnSetup();

			// Token: 0x06009DA4 RID: 40356
			[Token(Token = "0x6009DA4")]
			void OnFurnitureRegistered(DIYRoom.IFurnitureController controller);

			// Token: 0x06009DA5 RID: 40357
			[Token(Token = "0x6009DA5")]
			void OnFurnitureUnregistered(DIYRoom.IFurnitureController controller);

			// Token: 0x06009DA6 RID: 40358
			[Token(Token = "0x6009DA6")]
			void OnFloorModifierChanged(DIYRoomModifier pre, DIYRoomModifier post);

			// Token: 0x06009DA7 RID: 40359
			[Token(Token = "0x6009DA7")]
			void OnWallModifierChanged(DIYRoomModifier pre, DIYRoomModifier post);

			// Token: 0x06009DA8 RID: 40360
			[Token(Token = "0x6009DA8")]
			void OnIntersectionStateChanged(bool intersect);
		}

		// Token: 0x02001854 RID: 6228
		[Token(Token = "0x2001854")]
		public interface IRefectionMaterialFilter
		{
			// Token: 0x06009DA9 RID: 40361
			[Token(Token = "0x6009DA9")]
			bool IsReflectable(Material mat);
		}

		// Token: 0x02001855 RID: 6229
		[Token(Token = "0x2001855")]
		private struct DefaultReflectFilter : DIYRoom.IRefectionMaterialFilter
		{
			// Token: 0x06009DAA RID: 40362 RVA: 0x0003D818 File Offset: 0x0003BA18
			[Token(Token = "0x6009DAA")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "4")]
			public bool IsReflectable(Material mat)
			{
				return default(bool);
			}
		}

		// Token: 0x02001856 RID: 6230
		[Token(Token = "0x2001856")]
		public interface ISpaceOccupation
		{
			// Token: 0x1700116F RID: 4463
			// (get) Token: 0x06009DAB RID: 40363
			[Token(Token = "0x1700116F")]
			int pos0 { [Token(Token = "0x6009DAB")] get; }

			// Token: 0x17001170 RID: 4464
			// (get) Token: 0x06009DAC RID: 40364
			[Token(Token = "0x17001170")]
			int pos1 { [Token(Token = "0x6009DAC")] get; }

			// Token: 0x17001171 RID: 4465
			// (get) Token: 0x06009DAD RID: 40365
			[Token(Token = "0x17001171")]
			int dir { [Token(Token = "0x6009DAD")] get; }

			// Token: 0x17001172 RID: 4466
			// (get) Token: 0x06009DAE RID: 40366
			[Token(Token = "0x17001172")]
			Bounds bounds { [Token(Token = "0x6009DAE")] get; }
		}

		// Token: 0x02001857 RID: 6231
		[Token(Token = "0x2001857")]
		public interface IFurnitureController : DIYRoom.ISpaceOccupation, IHotfixable
		{
			// Token: 0x06009DAF RID: 40367
			[Token(Token = "0x6009DAF")]
			bool TrySetPosition(int pos0, int pos1);

			// Token: 0x06009DB0 RID: 40368
			[Token(Token = "0x6009DB0")]
			bool TryRotateToNext();

			// Token: 0x06009DB1 RID: 40369
			[Token(Token = "0x6009DB1")]
			bool FurnitureEquals(Furniture furniture);

			// Token: 0x06009DB2 RID: 40370
			[Token(Token = "0x6009DB2")]
			void SetMarkState(bool ok);

			// Token: 0x06009DB3 RID: 40371
			[Token(Token = "0x6009DB3")]
			void SetSelect(bool select);

			// Token: 0x17001173 RID: 4467
			// (get) Token: 0x06009DB4 RID: 40372
			[Token(Token = "0x17001173")]
			bool isSelected { [Token(Token = "0x6009DB4")] get; }

			// Token: 0x17001174 RID: 4468
			// (get) Token: 0x06009DB5 RID: 40373
			[Token(Token = "0x17001174")]
			bool isEnableRotate { [Token(Token = "0x6009DB5")] get; }

			// Token: 0x06009DB6 RID: 40374
			[Token(Token = "0x6009DB6")]
			void SetInteractable(bool interactable);

			// Token: 0x17001175 RID: 4469
			// (get) Token: 0x06009DB7 RID: 40375
			[Token(Token = "0x17001175")]
			bool isInteractable { [Token(Token = "0x6009DB7")] get; }

			// Token: 0x06009DB8 RID: 40376
			[Token(Token = "0x6009DB8")]
			void ShowMark();

			// Token: 0x06009DB9 RID: 40377
			[Token(Token = "0x6009DB9")]
			void HideMark();

			// Token: 0x06009DBA RID: 40378
			[Token(Token = "0x6009DBA")]
			Vector3 GetLocation(int pos0, int pos1);

			// Token: 0x17001176 RID: 4470
			// (get) Token: 0x06009DBB RID: 40379
			[Token(Token = "0x17001176")]
			FurnitureLocationType locationType { [Token(Token = "0x6009DBB")] get; }

			// Token: 0x17001177 RID: 4471
			// (get) Token: 0x06009DBC RID: 40380
			[Token(Token = "0x17001177")]
			Furniture furniture { [Token(Token = "0x6009DBC")] get; }

			// Token: 0x17001178 RID: 4472
			// (get) Token: 0x06009DBD RID: 40381
			[Token(Token = "0x17001178")]
			GameObject gameObject { [Token(Token = "0x6009DBD")] get; }

			// Token: 0x06009DBE RID: 40382
			[Token(Token = "0x6009DBE")]
			int GetFurnitureCurrentWidth();

			// Token: 0x06009DBF RID: 40383
			[Token(Token = "0x6009DBF")]
			int GetFurnitureCurrentHeight();

			// Token: 0x06009DC0 RID: 40384
			[Token(Token = "0x6009DC0")]
			int GetFurnitureDimY();
		}

		// Token: 0x02001858 RID: 6232
		[Token(Token = "0x2001858")]
		public interface IAttachPoint
		{
			// Token: 0x17001179 RID: 4473
			// (get) Token: 0x06009DC1 RID: 40385
			[Token(Token = "0x17001179")]
			Transform targetPoint { [Token(Token = "0x6009DC1")] get; }

			// Token: 0x1700117A RID: 4474
			// (get) Token: 0x06009DC2 RID: 40386
			[Token(Token = "0x1700117A")]
			string animationKey { [Token(Token = "0x6009DC2")] get; }

			// Token: 0x1700117B RID: 4475
			// (get) Token: 0x06009DC3 RID: 40387
			[Token(Token = "0x1700117B")]
			SharedConsts.LeftOrRight leftOrRight { [Token(Token = "0x6009DC3")] get; }

			// Token: 0x1700117C RID: 4476
			// (get) Token: 0x06009DC4 RID: 40388
			[Token(Token = "0x1700117C")]
			bool specifyDir { [Token(Token = "0x6009DC4")] get; }

			// Token: 0x1700117D RID: 4477
			// (get) Token: 0x06009DC5 RID: 40389
			[Token(Token = "0x1700117D")]
			Vector2 interactTime { [Token(Token = "0x6009DC5")] get; }

			// Token: 0x06009DC6 RID: 40390
			[Token(Token = "0x6009DC6")]
			void QueryEntryPoints(Action<int, int> action);

			// Token: 0x1700117E RID: 4478
			// (get) Token: 0x06009DC7 RID: 40391
			[Token(Token = "0x1700117E")]
			string interactId { [Token(Token = "0x6009DC7")] get; }
		}

		// Token: 0x02001859 RID: 6233
		[Token(Token = "0x2001859")]
		public interface IAttachPointExporter
		{
			// Token: 0x1700117F RID: 4479
			// (get) Token: 0x06009DC8 RID: 40392
			[Token(Token = "0x1700117F")]
			int pos0 { [Token(Token = "0x6009DC8")] get; }

			// Token: 0x17001180 RID: 4480
			// (get) Token: 0x06009DC9 RID: 40393
			[Token(Token = "0x17001180")]
			int pos1 { [Token(Token = "0x6009DC9")] get; }

			// Token: 0x17001181 RID: 4481
			// (get) Token: 0x06009DCA RID: 40394
			[Token(Token = "0x17001181")]
			string displayName { [Token(Token = "0x6009DCA")] get; }

			// Token: 0x17001182 RID: 4482
			// (get) Token: 0x06009DCB RID: 40395
			[Token(Token = "0x17001182")]
			Vector3 center { [Token(Token = "0x6009DCB")] get; }

			// Token: 0x17001183 RID: 4483
			// (get) Token: 0x06009DCC RID: 40396
			[Token(Token = "0x17001183")]
			int sizeX { [Token(Token = "0x6009DCC")] get; }

			// Token: 0x17001184 RID: 4484
			// (get) Token: 0x06009DCD RID: 40397
			[Token(Token = "0x17001184")]
			int sizeY { [Token(Token = "0x6009DCD")] get; }

			// Token: 0x17001185 RID: 4485
			// (get) Token: 0x06009DCE RID: 40398
			[Token(Token = "0x17001185")]
			int sizeZ { [Token(Token = "0x6009DCE")] get; }

			// Token: 0x17001186 RID: 4486
			// (get) Token: 0x06009DCF RID: 40399
			[Token(Token = "0x17001186")]
			IEnumerable<DIYRoom.IAttachPoint> attachPoints { [Token(Token = "0x6009DCF")] get; }
		}

		// Token: 0x0200185A RID: 6234
		[Token(Token = "0x200185A")]
		public class FurnitureControlNode : DIYRoom.IFurnitureController, DIYRoom.ISpaceOccupation, IHotfixable, DIYRoom.IAttachPointExporter, Furniture.IListener, ILODListener
		{
			// Token: 0x17001187 RID: 4487
			// (get) Token: 0x06009DD0 RID: 40400 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06009DD1 RID: 40401 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001187")]
			public Texture2D okTexture
			{
				[Token(Token = "0x6009DD0")]
				[Address(RVA = "0x3196B20", Offset = "0x3195720", VA = "0x183196B20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6009DD1")]
				[Address(RVA = "0x3197300", Offset = "0x3195F00", VA = "0x183197300")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17001188 RID: 4488
			// (get) Token: 0x06009DD2 RID: 40402 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06009DD3 RID: 40403 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001188")]
			public Texture2D ngTexture
			{
				[Token(Token = "0x6009DD2")]
				[Address(RVA = "0x31968F0", Offset = "0x31954F0", VA = "0x1831968F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6009DD3")]
				[Address(RVA = "0x31971E0", Offset = "0x3195DE0", VA = "0x1831971E0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17001189 RID: 4489
			// (get) Token: 0x06009DD4 RID: 40404 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06009DD5 RID: 40405 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001189")]
			public Texture2D okSelectTexture
			{
				[Token(Token = "0x6009DD4")]
				[Address(RVA = "0x3196AA0", Offset = "0x31956A0", VA = "0x183196AA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6009DD5")]
				[Address(RVA = "0x3197270", Offset = "0x3195E70", VA = "0x183197270")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700118A RID: 4490
			// (get) Token: 0x06009DD6 RID: 40406 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06009DD7 RID: 40407 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700118A")]
			public Texture2D ngSelectTexture
			{
				[Token(Token = "0x6009DD6")]
				[Address(RVA = "0x3196870", Offset = "0x3195470", VA = "0x183196870")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6009DD7")]
				[Address(RVA = "0x3197150", Offset = "0x3195D50", VA = "0x183197150")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x14000039 RID: 57
			// (add) Token: 0x06009DD8 RID: 40408 RVA: 0x00002053 File Offset: 0x00000253
			// (remove) Token: 0x06009DD9 RID: 40409 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x14000039")]
			public event Action<DIYRoom.FurnitureControlNode, int, int> positionSetEvent
			{
				[Token(Token = "0x6009DD8")]
				[Address(RVA = "0x3194B10", Offset = "0x3193710", VA = "0x183194B10")]
				[CompilerGenerated]
				add
				{
				}
				[Token(Token = "0x6009DD9")]
				[Address(RVA = "0x3196F10", Offset = "0x3195B10", VA = "0x183196F10")]
				[CompilerGenerated]
				remove
				{
				}
			}

			// Token: 0x1400003A RID: 58
			// (add) Token: 0x06009DDA RID: 40410 RVA: 0x00002053 File Offset: 0x00000253
			// (remove) Token: 0x06009DDB RID: 40411 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1400003A")]
			public event Action<DIYRoom.FurnitureControlNode> roomIndexChangeEvent
			{
				[Token(Token = "0x6009DDA")]
				[Address(RVA = "0x3194C30", Offset = "0x3193830", VA = "0x183194C30")]
				[CompilerGenerated]
				add
				{
				}
				[Token(Token = "0x6009DDB")]
				[Address(RVA = "0x3197030", Offset = "0x3195C30", VA = "0x183197030")]
				[CompilerGenerated]
				remove
				{
				}
			}

			// Token: 0x1700118B RID: 4491
			// (get) Token: 0x06009DDC RID: 40412 RVA: 0x0003D830 File Offset: 0x0003BA30
			[Token(Token = "0x1700118B")]
			public int pos0
			{
				[Token(Token = "0x6009DDC")]
				[Address(RVA = "0x3196BA0", Offset = "0x31957A0", VA = "0x183196BA0", Slot = "26")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700118C RID: 4492
			// (get) Token: 0x06009DDD RID: 40413 RVA: 0x0003D848 File Offset: 0x0003BA48
			[Token(Token = "0x1700118C")]
			public int pos1
			{
				[Token(Token = "0x6009DDD")]
				[Address(RVA = "0x3196C20", Offset = "0x3195820", VA = "0x183196C20", Slot = "27")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700118D RID: 4493
			// (get) Token: 0x06009DDE RID: 40414 RVA: 0x0003D860 File Offset: 0x0003BA60
			[Token(Token = "0x1700118D")]
			public int dir
			{
				[Token(Token = "0x6009DDE")]
				[Address(RVA = "0x31954D0", Offset = "0x31940D0", VA = "0x1831954D0", Slot = "24")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700118E RID: 4494
			// (get) Token: 0x06009DDF RID: 40415 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700118E")]
			public Furniture furniture
			{
				[Token(Token = "0x6009DDF")]
				[Address(RVA = "0x3195610", Offset = "0x3194210", VA = "0x183195610", Slot = "17")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700118F RID: 4495
			// (get) Token: 0x06009DE0 RID: 40416 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700118F")]
			public GameObject gameObject
			{
				[Token(Token = "0x6009DE0")]
				[Address(RVA = "0x3195690", Offset = "0x3194290", VA = "0x183195690", Slot = "18")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001190 RID: 4496
			// (get) Token: 0x06009DE1 RID: 40417 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001190")]
			public GridMachine gridMachine
			{
				[Token(Token = "0x6009DE1")]
				[Address(RVA = "0x3195790", Offset = "0x3194390", VA = "0x183195790")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001191 RID: 4497
			// (get) Token: 0x06009DE2 RID: 40418 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001191")]
			public GridMachine3D gridMachine3D
			{
				[Token(Token = "0x6009DE2")]
				[Address(RVA = "0x3195710", Offset = "0x3194310", VA = "0x183195710")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001192 RID: 4498
			// (get) Token: 0x06009DE3 RID: 40419 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001192")]
			public static MaterialPropertyBlock normalMaterialProp
			{
				[Token(Token = "0x6009DE3")]
				[Address(RVA = "0x3196970", Offset = "0x3195570", VA = "0x183196970")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001193 RID: 4499
			// (get) Token: 0x06009DE4 RID: 40420 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001193")]
			public string displayName
			{
				[Token(Token = "0x6009DE4")]
				[Address(RVA = "0x3195550", Offset = "0x3194150", VA = "0x183195550", Slot = "28")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001194 RID: 4500
			// (get) Token: 0x06009DE5 RID: 40421 RVA: 0x0003D878 File Offset: 0x0003BA78
			[Token(Token = "0x17001194")]
			public Bounds bounds
			{
				[Token(Token = "0x6009DE5")]
				[Address(RVA = "0x3194E30", Offset = "0x3193A30", VA = "0x183194E30", Slot = "25")]
				get
				{
					return default(Bounds);
				}
			}

			// Token: 0x17001195 RID: 4501
			// (get) Token: 0x06009DE6 RID: 40422 RVA: 0x0003D890 File Offset: 0x0003BA90
			[Token(Token = "0x17001195")]
			public Vector3 center
			{
				[Token(Token = "0x6009DE6")]
				[Address(RVA = "0x3195400", Offset = "0x3194000", VA = "0x183195400", Slot = "29")]
				get
				{
					return default(Vector3);
				}
			}

			// Token: 0x17001196 RID: 4502
			// (get) Token: 0x06009DE7 RID: 40423 RVA: 0x0003D8A8 File Offset: 0x0003BAA8
			[Token(Token = "0x17001196")]
			public int sizeX
			{
				[Token(Token = "0x6009DE7")]
				[Address(RVA = "0x3196CA0", Offset = "0x31958A0", VA = "0x183196CA0", Slot = "30")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17001197 RID: 4503
			// (get) Token: 0x06009DE8 RID: 40424 RVA: 0x0003D8C0 File Offset: 0x0003BAC0
			[Token(Token = "0x17001197")]
			public int sizeY
			{
				[Token(Token = "0x6009DE8")]
				[Address(RVA = "0x3196D80", Offset = "0x3195980", VA = "0x183196D80", Slot = "31")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17001198 RID: 4504
			// (get) Token: 0x06009DE9 RID: 40425 RVA: 0x0003D8D8 File Offset: 0x0003BAD8
			[Token(Token = "0x17001198")]
			public int sizeZ
			{
				[Token(Token = "0x6009DE9")]
				[Address(RVA = "0x3196E30", Offset = "0x3195A30", VA = "0x183196E30", Slot = "32")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17001199 RID: 4505
			// (get) Token: 0x06009DEA RID: 40426 RVA: 0x0003D8F0 File Offset: 0x0003BAF0
			[Token(Token = "0x17001199")]
			public FurnitureLocationType locationType
			{
				[Token(Token = "0x6009DEA")]
				[Address(RVA = "0x31967C0", Offset = "0x31953C0", VA = "0x1831967C0", Slot = "16")]
				get
				{
					return FurnitureLocationType.GROUND;
				}
			}

			// Token: 0x1700119A RID: 4506
			// (get) Token: 0x06009DEB RID: 40427 RVA: 0x0003D908 File Offset: 0x0003BB08
			[Token(Token = "0x1700119A")]
			private bool isPrefabLoaded
			{
				[Token(Token = "0x6009DEB")]
				[Address(RVA = "0x3196620", Offset = "0x3195220", VA = "0x183196620")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700119B RID: 4507
			// (get) Token: 0x06009DEC RID: 40428 RVA: 0x0003D920 File Offset: 0x0003BB20
			[Token(Token = "0x1700119B")]
			private bool isReleased
			{
				[Token(Token = "0x6009DEC")]
				[Address(RVA = "0x31966C0", Offset = "0x31952C0", VA = "0x1831966C0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06009DED RID: 40429 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009DED")]
			[Address(RVA = "0x3190570", Offset = "0x318F170", VA = "0x183190570")]
			public void GatherMaterials(Dictionary<string, Material> matDict, Dictionary<string, Material> modifiedMatDict)
			{
			}

			// Token: 0x06009DEE RID: 40430 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009DEE")]
			[Address(RVA = "0x3192640", Offset = "0x3191240", VA = "0x183192640")]
			public void UpdateMaterials(Dictionary<string, Material> matPairs, Dictionary<string, Material> modifierMatPairs, bool isReset)
			{
			}

			// Token: 0x06009DEF RID: 40431 RVA: 0x0003D938 File Offset: 0x0003BB38
			[Token(Token = "0x6009DEF")]
			[Address(RVA = "0x3193D20", Offset = "0x3192920", VA = "0x183193D20")]
			private bool _TryFindModifiedMat(Dictionary<string, Material> matPairs, Dictionary<string, Material> modifierMatPairs, Material mat, bool revert, out Material foundMat)
			{
				return default(bool);
			}

			// Token: 0x06009DF0 RID: 40432 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009DF0")]
			[Address(RVA = "0x31927D0", Offset = "0x31913D0", VA = "0x1831927D0")]
			public void UpdatePropertyBlock(bool isReset, float progress)
			{
			}

			// Token: 0x06009DF1 RID: 40433 RVA: 0x0003D950 File Offset: 0x0003BB50
			[Token(Token = "0x6009DF1")]
			[Address(RVA = "0x3190A20", Offset = "0x318F620", VA = "0x183190A20", Slot = "15")]
			public Vector3 GetLocation(int pos0, int pos1)
			{
				return default(Vector3);
			}

			// Token: 0x1700119C RID: 4508
			// (get) Token: 0x06009DF2 RID: 40434 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700119C")]
			private GameObject gridMark
			{
				[Token(Token = "0x6009DF2")]
				[Address(RVA = "0x3195980", Offset = "0x3194580", VA = "0x183195980")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700119D RID: 4509
			// (get) Token: 0x06009DF3 RID: 40435 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700119D")]
			private Material gridMarkMat
			{
				[Token(Token = "0x6009DF3")]
				[Address(RVA = "0x3195810", Offset = "0x3194410", VA = "0x183195810")]
				get
				{
					return null;
				}
			}

			// Token: 0x06009DF4 RID: 40436 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009DF4")]
			[Address(RVA = "0x3193F40", Offset = "0x3192B40", VA = "0x183193F40")]
			private void _UpdateMarkTexture()
			{
			}

			// Token: 0x06009DF5 RID: 40437 RVA: 0x0003D968 File Offset: 0x0003BB68
			[Token(Token = "0x6009DF5")]
			[Address(RVA = "0x3192D70", Offset = "0x3191970", VA = "0x183192D70")]
			private int _GetFurnitureWidth()
			{
				return 0;
			}

			// Token: 0x06009DF6 RID: 40438 RVA: 0x0003D980 File Offset: 0x0003BB80
			[Token(Token = "0x6009DF6")]
			[Address(RVA = "0x3192C40", Offset = "0x3191840", VA = "0x183192C40")]
			private int _GetFurnitureHeight()
			{
				return 0;
			}

			// Token: 0x06009DF7 RID: 40439 RVA: 0x0003D998 File Offset: 0x0003BB98
			[Token(Token = "0x6009DF7")]
			[Address(RVA = "0x3192AC0", Offset = "0x31916C0", VA = "0x183192AC0")]
			private int _GetFurnitureCurrentWidth()
			{
				return 0;
			}

			// Token: 0x06009DF8 RID: 40440 RVA: 0x0003D9B0 File Offset: 0x0003BBB0
			[Token(Token = "0x6009DF8")]
			[Address(RVA = "0x3192960", Offset = "0x3191560", VA = "0x183192960")]
			private int _GetFurnitureCurrentHeight()
			{
				return 0;
			}

			// Token: 0x06009DF9 RID: 40441 RVA: 0x0003D9C8 File Offset: 0x0003BBC8
			[Token(Token = "0x6009DF9")]
			[Address(RVA = "0x3192B90", Offset = "0x3191790", VA = "0x183192B90")]
			private int _GetFurnitureDimY()
			{
				return 0;
			}

			// Token: 0x06009DFA RID: 40442 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009DFA")]
			[Address(RVA = "0x31938F0", Offset = "0x31924F0", VA = "0x1831938F0")]
			private void _OnFurnitureGameObjectReload()
			{
			}

			// Token: 0x06009DFB RID: 40443 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009DFB")]
			[Address(RVA = "0x3193980", Offset = "0x3192580", VA = "0x183193980")]
			private void _RegisterReflectObject()
			{
			}

			// Token: 0x06009DFC RID: 40444 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009DFC")]
			[Address(RVA = "0x3193BC0", Offset = "0x31927C0", VA = "0x183193BC0")]
			private void _ReleaseReflectObject()
			{
			}

			// Token: 0x06009DFD RID: 40445 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009DFD")]
			[Address(RVA = "0x3193860", Offset = "0x3192460", VA = "0x183193860")]
			public void _OnFurnitureGameObjectRelease()
			{
			}

			// Token: 0x06009DFE RID: 40446 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009DFE")]
			[Address(RVA = "0x3194330", Offset = "0x3192F30", VA = "0x183194330")]
			public FurnitureControlNode(Furniture furniture, Transform parent, GridLocator locator, GridMachine machine, GridMachine3D machine3D, int width, int height, int deep, int roomIndex, float xUnit, float yUnit, float zUnit, Shader markShader, ReflectCameraHolder reflectCameraHolder, DIYRoom.IRefectionMaterialFilter reflectFilter, bool isAsync)
			{
			}

			// Token: 0x06009DFF RID: 40447 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009DFF")]
			[Address(RVA = "0x3191020", Offset = "0x318FC20", VA = "0x183191020", Slot = "37")]
			public void OnLODStateChanged(LODState state)
			{
			}

			// Token: 0x06009E00 RID: 40448 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009E00")]
			[Address(RVA = "0x31923E0", Offset = "0x3190FE0", VA = "0x1831923E0")]
			public void UpdateFrame()
			{
			}

			// Token: 0x06009E01 RID: 40449 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009E01")]
			[Address(RVA = "0x3192E10", Offset = "0x3191A10", VA = "0x183192E10")]
			private void _InitFurnitureGameObject(GameObject prefab, Transform parent)
			{
			}

			// Token: 0x06009E02 RID: 40450 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009E02")]
			[Address(RVA = "0x31915C0", Offset = "0x31901C0", VA = "0x1831915C0")]
			public void ReleaseFurniture(bool recoverListener = true)
			{
			}

			// Token: 0x06009E03 RID: 40451 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009E03")]
			[Address(RVA = "0x3190CF0", Offset = "0x318F8F0", VA = "0x183190CF0", Slot = "34")]
			public void OnFurniturePositionChanged(int oldPos0, int oldPos1, Furniture furniture)
			{
			}

			// Token: 0x06009E04 RID: 40452 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009E04")]
			[Address(RVA = "0x3190EE0", Offset = "0x318FAE0", VA = "0x183190EE0", Slot = "35")]
			public void OnFurnitureRotateChanged(int dir, Furniture furniture)
			{
			}

			// Token: 0x06009E05 RID: 40453 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009E05")]
			[Address(RVA = "0x3190E20", Offset = "0x318FA20", VA = "0x183190E20", Slot = "36")]
			public void OnFurnitureRoomIndexChanged(int oldIndex, Furniture furniture)
			{
			}

			// Token: 0x06009E06 RID: 40454 RVA: 0x0003D9E0 File Offset: 0x0003BBE0
			[Token(Token = "0x6009E06")]
			[Address(RVA = "0x31908B0", Offset = "0x318F4B0", VA = "0x1831908B0", Slot = "19")]
			public int GetFurnitureCurrentWidth()
			{
				return 0;
			}

			// Token: 0x06009E07 RID: 40455 RVA: 0x0003D9F8 File Offset: 0x0003BBF8
			[Token(Token = "0x6009E07")]
			[Address(RVA = "0x3190830", Offset = "0x318F430", VA = "0x183190830", Slot = "20")]
			public int GetFurnitureCurrentHeight()
			{
				return 0;
			}

			// Token: 0x06009E08 RID: 40456 RVA: 0x0003DA10 File Offset: 0x0003BC10
			[Token(Token = "0x6009E08")]
			[Address(RVA = "0x3190930", Offset = "0x318F530", VA = "0x183190930", Slot = "21")]
			public int GetFurnitureDimY()
			{
				return 0;
			}

			// Token: 0x06009E09 RID: 40457 RVA: 0x0003DA28 File Offset: 0x0003BC28
			[Token(Token = "0x6009E09")]
			[Address(RVA = "0x3192290", Offset = "0x3190E90", VA = "0x183192290", Slot = "4")]
			public bool TrySetPosition(int pos0, int pos1)
			{
				return default(bool);
			}

			// Token: 0x06009E0A RID: 40458 RVA: 0x0003DA40 File Offset: 0x0003BC40
			[Token(Token = "0x6009E0A")]
			[Address(RVA = "0x3191DC0", Offset = "0x31909C0", VA = "0x183191DC0", Slot = "5")]
			public bool TryRotateToNext()
			{
				return default(bool);
			}

			// Token: 0x06009E0B RID: 40459 RVA: 0x0003DA58 File Offset: 0x0003BC58
			[Token(Token = "0x6009E0B")]
			[Address(RVA = "0x31904E0", Offset = "0x318F0E0", VA = "0x1831904E0", Slot = "6")]
			public bool FurnitureEquals(Furniture furniture)
			{
				return default(bool);
			}

			// Token: 0x1700119E RID: 4510
			// (get) Token: 0x06009E0C RID: 40460 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700119E")]
			public IEnumerable<DIYRoom.IAttachPoint> attachPoints
			{
				[Token(Token = "0x6009E0C")]
				[Address(RVA = "0x3194D50", Offset = "0x3193950", VA = "0x183194D50", Slot = "33")]
				get
				{
					return null;
				}
			}

			// Token: 0x06009E0D RID: 40461 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009E0D")]
			[Address(RVA = "0x3191AD0", Offset = "0x31906D0", VA = "0x183191AD0", Slot = "7")]
			public void SetMarkState(bool ok)
			{
			}

			// Token: 0x06009E0E RID: 40462 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009E0E")]
			[Address(RVA = "0x3191C30", Offset = "0x3190830", VA = "0x183191C30", Slot = "8")]
			public void SetSelect(bool select)
			{
			}

			// Token: 0x1700119F RID: 4511
			// (get) Token: 0x06009E0F RID: 40463 RVA: 0x0003DA70 File Offset: 0x0003BC70
			[Token(Token = "0x1700119F")]
			public bool isSelected
			{
				[Token(Token = "0x6009E0F")]
				[Address(RVA = "0x3196740", Offset = "0x3195340", VA = "0x183196740", Slot = "9")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170011A0 RID: 4512
			// (get) Token: 0x06009E10 RID: 40464 RVA: 0x0003DA88 File Offset: 0x0003BC88
			[Token(Token = "0x170011A0")]
			public bool isEnableRotate
			{
				[Token(Token = "0x6009E10")]
				[Address(RVA = "0x31964C0", Offset = "0x31950C0", VA = "0x1831964C0", Slot = "10")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06009E11 RID: 40465 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009E11")]
			[Address(RVA = "0x3191A40", Offset = "0x3190640", VA = "0x183191A40", Slot = "11")]
			public void SetInteractable(bool interactable)
			{
			}

			// Token: 0x170011A1 RID: 4513
			// (get) Token: 0x06009E12 RID: 40466 RVA: 0x0003DAA0 File Offset: 0x0003BCA0
			[Token(Token = "0x170011A1")]
			public bool isInteractable
			{
				[Token(Token = "0x6009E12")]
				[Address(RVA = "0x31965A0", Offset = "0x31951A0", VA = "0x1831965A0", Slot = "12")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06009E13 RID: 40467 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009E13")]
			[Address(RVA = "0x3191D00", Offset = "0x3190900", VA = "0x183191D00", Slot = "13")]
			public void ShowMark()
			{
			}

			// Token: 0x06009E14 RID: 40468 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009E14")]
			[Address(RVA = "0x3190BF0", Offset = "0x318F7F0", VA = "0x183190BF0", Slot = "14")]
			public void HideMark()
			{
			}

			// Token: 0x06009E15 RID: 40469 RVA: 0x0003DAB8 File Offset: 0x0003BCB8
			[Token(Token = "0x6009E15")]
			[Address(RVA = "0x31913C0", Offset = "0x318FFC0", VA = "0x1831913C0")]
			public bool RegisterOnGameObjectLoaded(Action<DIYRoom.FurnitureControlNode> onLoaded)
			{
				return default(bool);
			}

			// Token: 0x04009495 RID: 38037
			[Token(Token = "0x4009495")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Furniture m_furniture;

			// Token: 0x04009496 RID: 38038
			[Token(Token = "0x4009496")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Transform m_parent;

			// Token: 0x04009497 RID: 38039
			[Token(Token = "0x4009497")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private ILODHolder m_lodHolder;

			// Token: 0x04009498 RID: 38040
			[Token(Token = "0x4009498")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private IDynamicAssetHandler m_assetHandle;

			// Token: 0x04009499 RID: 38041
			[Token(Token = "0x4009499")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private IDynamicAssetWrapper m_assetWrapper;

			// Token: 0x0400949A RID: 38042
			[Token(Token = "0x400949A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private GameObject m_gameObject;

			// Token: 0x0400949B RID: 38043
			[Token(Token = "0x400949B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private GridLocator m_locator;

			// Token: 0x0400949C RID: 38044
			[Token(Token = "0x400949C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private GridMachine m_gridMachine;

			// Token: 0x0400949D RID: 38045
			[Token(Token = "0x400949D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private GridMachine3D m_gridMachine3D;

			// Token: 0x0400949E RID: 38046
			[Token(Token = "0x400949E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private GameObject m_gridMark;

			// Token: 0x0400949F RID: 38047
			[Token(Token = "0x400949F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Mesh m_gridMarkMesh;

			// Token: 0x040094A0 RID: 38048
			[Token(Token = "0x40094A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private Material m_gridMarkMat;

			// Token: 0x040094A1 RID: 38049
			[Token(Token = "0x40094A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private int m_maxPos0;

			// Token: 0x040094A2 RID: 38050
			[Token(Token = "0x40094A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private int m_maxPos1;

			// Token: 0x040094A3 RID: 38051
			[Token(Token = "0x40094A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private int m_roomIndex;

			// Token: 0x040094A4 RID: 38052
			[Token(Token = "0x40094A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			private bool m_markState;

			// Token: 0x040094A5 RID: 38053
			[Token(Token = "0x40094A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
			private bool m_markWaitingForHide;

			// Token: 0x040094A6 RID: 38054
			[Token(Token = "0x40094A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7E")]
			private bool m_select;

			// Token: 0x040094A7 RID: 38055
			[Token(Token = "0x40094A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7F")]
			private bool m_interactable;

			// Token: 0x040094A8 RID: 38056
			[Token(Token = "0x40094A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private Furniture.IListener m_originListener;

			// Token: 0x040094A9 RID: 38057
			[Token(Token = "0x40094A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private float m_xUnit;

			// Token: 0x040094AA RID: 38058
			[Token(Token = "0x40094AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			private float m_yUnit;

			// Token: 0x040094AB RID: 38059
			[Token(Token = "0x40094AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private float m_zUnit;

			// Token: 0x040094AC RID: 38060
			[Token(Token = "0x40094AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private Shader m_markShader;

			// Token: 0x040094AD RID: 38061
			[Token(Token = "0x40094AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private ReflectCameraHolder m_reflectCameraHolder;

			// Token: 0x040094AE RID: 38062
			[Token(Token = "0x40094AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private DIYRoom.IRefectionMaterialFilter m_reflectFilter;

			// Token: 0x040094AF RID: 38063
			[Token(Token = "0x40094AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private List<MeshRenderer> m_registeredRenderer;

			// Token: 0x040094B0 RID: 38064
			[Token(Token = "0x40094B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private Action<DIYRoom.FurnitureControlNode> m_onGameObjectLoaded;

			// Token: 0x040094B1 RID: 38065
			[Token(Token = "0x40094B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private List<string> m_furnitureLodAllNames;

			// Token: 0x040094B2 RID: 38066
			[Token(Token = "0x40094B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private List<KeyValuePair<Transform, FurnitureLodObjType>> m_furnitureLodTranforms;

			// Token: 0x040094B7 RID: 38071
			[Token(Token = "0x40094B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			private List<MeshRenderer> _meshRendererList;

			// Token: 0x040094B8 RID: 38072
			[Token(Token = "0x40094B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static MaterialPropertyBlock s_normalMaterialProp;

			// Token: 0x040094B9 RID: 38073
			[Token(Token = "0x40094B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static float OUTLINE_WIDTH_CEILING;

			// Token: 0x040094BA RID: 38074
			[Token(Token = "0x40094BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private static float OUTLINE_WIDTH_NORMAL;

			// Token: 0x040094BB RID: 38075
			[Token(Token = "0x40094BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static string FURNI_OBJ_PREFIX;

			// Token: 0x040094BE RID: 38078
			[Token(Token = "0x40094BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_okTexture;

			// Token: 0x040094BF RID: 38079
			[Token(Token = "0x40094BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_set_okTexture;

			// Token: 0x040094C0 RID: 38080
			[Token(Token = "0x40094C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_ngTexture;

			// Token: 0x040094C1 RID: 38081
			[Token(Token = "0x40094C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_set_ngTexture;

			// Token: 0x040094C2 RID: 38082
			[Token(Token = "0x40094C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_get_okSelectTexture;

			// Token: 0x040094C3 RID: 38083
			[Token(Token = "0x40094C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_set_okSelectTexture;

			// Token: 0x040094C4 RID: 38084
			[Token(Token = "0x40094C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_get_ngSelectTexture;

			// Token: 0x040094C5 RID: 38085
			[Token(Token = "0x40094C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_set_ngSelectTexture;

			// Token: 0x040094C6 RID: 38086
			[Token(Token = "0x40094C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_add_positionSetEvent;

			// Token: 0x040094C7 RID: 38087
			[Token(Token = "0x40094C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_remove_positionSetEvent;

			// Token: 0x040094C8 RID: 38088
			[Token(Token = "0x40094C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_add_roomIndexChangeEvent;

			// Token: 0x040094C9 RID: 38089
			[Token(Token = "0x40094C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_remove_roomIndexChangeEvent;

			// Token: 0x040094CA RID: 38090
			[Token(Token = "0x40094CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix0_get_pos0;

			// Token: 0x040094CB RID: 38091
			[Token(Token = "0x40094CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private static DelegateBridge __Hotfix0_get_pos1;

			// Token: 0x040094CC RID: 38092
			[Token(Token = "0x40094CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private static DelegateBridge __Hotfix0_get_dir;

			// Token: 0x040094CD RID: 38093
			[Token(Token = "0x40094CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private static DelegateBridge __Hotfix0_get_furniture;

			// Token: 0x040094CE RID: 38094
			[Token(Token = "0x40094CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private static DelegateBridge __Hotfix0_get_gameObject;

			// Token: 0x040094CF RID: 38095
			[Token(Token = "0x40094CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private static DelegateBridge __Hotfix0_get_gridMachine;

			// Token: 0x040094D0 RID: 38096
			[Token(Token = "0x40094D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private static DelegateBridge __Hotfix0_get_gridMachine3D;

			// Token: 0x040094D1 RID: 38097
			[Token(Token = "0x40094D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private static DelegateBridge __Hotfix0_get_normalMaterialProp;

			// Token: 0x040094D2 RID: 38098
			[Token(Token = "0x40094D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private static DelegateBridge __Hotfix0_get_displayName;

			// Token: 0x040094D3 RID: 38099
			[Token(Token = "0x40094D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private static DelegateBridge __Hotfix0_get_bounds;

			// Token: 0x040094D4 RID: 38100
			[Token(Token = "0x40094D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private static DelegateBridge __Hotfix0_get_center;

			// Token: 0x040094D5 RID: 38101
			[Token(Token = "0x40094D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			private static DelegateBridge __Hotfix0_get_sizeX;

			// Token: 0x040094D6 RID: 38102
			[Token(Token = "0x40094D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			private static DelegateBridge __Hotfix0_get_sizeY;

			// Token: 0x040094D7 RID: 38103
			[Token(Token = "0x40094D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			private static DelegateBridge __Hotfix0_get_sizeZ;

			// Token: 0x040094D8 RID: 38104
			[Token(Token = "0x40094D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private static DelegateBridge __Hotfix0_get_locationType;

			// Token: 0x040094D9 RID: 38105
			[Token(Token = "0x40094D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			private static DelegateBridge __Hotfix0_get_isPrefabLoaded;

			// Token: 0x040094DA RID: 38106
			[Token(Token = "0x40094DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private static DelegateBridge __Hotfix0_get_isReleased;

			// Token: 0x040094DB RID: 38107
			[Token(Token = "0x40094DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
			private static DelegateBridge __Hotfix0_GatherMaterials;

			// Token: 0x040094DC RID: 38108
			[Token(Token = "0x40094DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			private static DelegateBridge __Hotfix0_UpdateMaterials;

			// Token: 0x040094DD RID: 38109
			[Token(Token = "0x40094DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
			private static DelegateBridge __Hotfix0__TryFindModifiedMat;

			// Token: 0x040094DE RID: 38110
			[Token(Token = "0x40094DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			private static DelegateBridge __Hotfix0_UpdatePropertyBlock;

			// Token: 0x040094DF RID: 38111
			[Token(Token = "0x40094DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			private static DelegateBridge __Hotfix0_GetLocation;

			// Token: 0x040094E0 RID: 38112
			[Token(Token = "0x40094E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			private static DelegateBridge __Hotfix0_get_gridMark;

			// Token: 0x040094E1 RID: 38113
			[Token(Token = "0x40094E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
			private static DelegateBridge __Hotfix0_get_gridMarkMat;

			// Token: 0x040094E2 RID: 38114
			[Token(Token = "0x40094E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			private static DelegateBridge __Hotfix0__UpdateMarkTexture;

			// Token: 0x040094E3 RID: 38115
			[Token(Token = "0x40094E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			private static DelegateBridge __Hotfix0__GetFurnitureWidth;

			// Token: 0x040094E4 RID: 38116
			[Token(Token = "0x40094E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
			private static DelegateBridge __Hotfix0__GetFurnitureHeight;

			// Token: 0x040094E5 RID: 38117
			[Token(Token = "0x40094E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
			private static DelegateBridge __Hotfix0__GetFurnitureCurrentWidth;

			// Token: 0x040094E6 RID: 38118
			[Token(Token = "0x40094E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
			private static DelegateBridge __Hotfix0__GetFurnitureCurrentHeight;

			// Token: 0x040094E7 RID: 38119
			[Token(Token = "0x40094E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
			private static DelegateBridge __Hotfix0__GetFurnitureDimY;

			// Token: 0x040094E8 RID: 38120
			[Token(Token = "0x40094E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
			private static DelegateBridge __Hotfix0__OnFurnitureGameObjectReload;

			// Token: 0x040094E9 RID: 38121
			[Token(Token = "0x40094E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
			private static DelegateBridge __Hotfix0__RegisterReflectObject;

			// Token: 0x040094EA RID: 38122
			[Token(Token = "0x40094EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
			private static DelegateBridge __Hotfix0__ReleaseReflectObject;

			// Token: 0x040094EB RID: 38123
			[Token(Token = "0x40094EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
			private static DelegateBridge __Hotfix0__OnFurnitureGameObjectRelease;

			// Token: 0x040094EC RID: 38124
			[Token(Token = "0x40094EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040094ED RID: 38125
			[Token(Token = "0x40094ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
			private static DelegateBridge __Hotfix0_OnLODStateChanged;

			// Token: 0x040094EE RID: 38126
			[Token(Token = "0x40094EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
			private static DelegateBridge __Hotfix0_UpdateFrame;

			// Token: 0x040094EF RID: 38127
			[Token(Token = "0x40094EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
			private static DelegateBridge __Hotfix0__InitFurnitureGameObject;

			// Token: 0x040094F0 RID: 38128
			[Token(Token = "0x40094F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
			private static DelegateBridge __Hotfix0_ReleaseFurniture;

			// Token: 0x040094F1 RID: 38129
			[Token(Token = "0x40094F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
			private static DelegateBridge __Hotfix0_OnFurniturePositionChanged;

			// Token: 0x040094F2 RID: 38130
			[Token(Token = "0x40094F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
			private static DelegateBridge __Hotfix0_OnFurnitureRotateChanged;

			// Token: 0x040094F3 RID: 38131
			[Token(Token = "0x40094F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
			private static DelegateBridge __Hotfix0_OnFurnitureRoomIndexChanged;

			// Token: 0x040094F4 RID: 38132
			[Token(Token = "0x40094F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
			private static DelegateBridge __Hotfix0_GetFurnitureCurrentWidth;

			// Token: 0x040094F5 RID: 38133
			[Token(Token = "0x40094F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
			private static DelegateBridge __Hotfix0_GetFurnitureCurrentHeight;

			// Token: 0x040094F6 RID: 38134
			[Token(Token = "0x40094F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
			private static DelegateBridge __Hotfix0_GetFurnitureDimY;

			// Token: 0x040094F7 RID: 38135
			[Token(Token = "0x40094F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
			private static DelegateBridge __Hotfix0_TrySetPosition;

			// Token: 0x040094F8 RID: 38136
			[Token(Token = "0x40094F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
			private static DelegateBridge __Hotfix0_TryRotateToNext;

			// Token: 0x040094F9 RID: 38137
			[Token(Token = "0x40094F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
			private static DelegateBridge __Hotfix0_FurnitureEquals;

			// Token: 0x040094FA RID: 38138
			[Token(Token = "0x40094FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
			private static DelegateBridge __Hotfix0_get_attachPoints;

			// Token: 0x040094FB RID: 38139
			[Token(Token = "0x40094FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
			private static DelegateBridge __Hotfix0_SetMarkState;

			// Token: 0x040094FC RID: 38140
			[Token(Token = "0x40094FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
			private static DelegateBridge __Hotfix0_SetSelect;

			// Token: 0x040094FD RID: 38141
			[Token(Token = "0x40094FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
			private static DelegateBridge __Hotfix0_get_isSelected;

			// Token: 0x040094FE RID: 38142
			[Token(Token = "0x40094FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
			private static DelegateBridge __Hotfix0_get_isEnableRotate;

			// Token: 0x040094FF RID: 38143
			[Token(Token = "0x40094FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
			private static DelegateBridge __Hotfix0_SetInteractable;

			// Token: 0x04009500 RID: 38144
			[Token(Token = "0x4009500")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
			private static DelegateBridge __Hotfix0_get_isInteractable;

			// Token: 0x04009501 RID: 38145
			[Token(Token = "0x4009501")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
			private static DelegateBridge __Hotfix0_ShowMark;

			// Token: 0x04009502 RID: 38146
			[Token(Token = "0x4009502")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
			private static DelegateBridge __Hotfix0_HideMark;

			// Token: 0x04009503 RID: 38147
			[Token(Token = "0x4009503")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
			private static DelegateBridge __Hotfix0_RegisterOnGameObjectLoaded;
		}

		// Token: 0x0200185F RID: 6239
		[Token(Token = "0x200185F")]
		private class FurnitureGridRect : GridMachine.IGridRect
		{
			// Token: 0x06009E20 RID: 40480 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009E20")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			public FurnitureGridRect(Furniture furniture)
			{
			}

			// Token: 0x170011A2 RID: 4514
			// (get) Token: 0x06009E21 RID: 40481 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170011A2")]
			public Furniture furniture
			{
				[Token(Token = "0x6009E21")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170011A3 RID: 4515
			// (get) Token: 0x06009E22 RID: 40482 RVA: 0x0003DAD0 File Offset: 0x0003BCD0
			[Token(Token = "0x170011A3")]
			public int x
			{
				[Token(Token = "0x6009E22")]
				[Address(RVA = "0x319BD00", Offset = "0x319A900", VA = "0x18319BD00", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170011A4 RID: 4516
			// (get) Token: 0x06009E23 RID: 40483 RVA: 0x0003DAE8 File Offset: 0x0003BCE8
			[Token(Token = "0x170011A4")]
			public int y
			{
				[Token(Token = "0x6009E23")]
				[Address(RVA = "0x319C100", Offset = "0x319AD00", VA = "0x18319C100", Slot = "5")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170011A5 RID: 4517
			// (get) Token: 0x06009E24 RID: 40484 RVA: 0x0003DB00 File Offset: 0x0003BD00
			[Token(Token = "0x170011A5")]
			public int w
			{
				[Token(Token = "0x6009E24")]
				[Address(RVA = "0x319C080", Offset = "0x319AC80", VA = "0x18319C080", Slot = "6")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170011A6 RID: 4518
			// (get) Token: 0x06009E25 RID: 40485 RVA: 0x0003DB18 File Offset: 0x0003BD18
			[Token(Token = "0x170011A6")]
			public int h
			{
				[Token(Token = "0x6009E25")]
				[Address(RVA = "0x319BF70", Offset = "0x319AB70", VA = "0x18319BF70", Slot = "7")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0400950E RID: 38158
			[Token(Token = "0x400950E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Furniture m_furniture;
		}

		// Token: 0x02001860 RID: 6240
		[Token(Token = "0x2001860")]
		public class GeneralGridRect : GridMachine.IGridRect
		{
			// Token: 0x170011A7 RID: 4519
			// (get) Token: 0x06009E26 RID: 40486 RVA: 0x0003DB30 File Offset: 0x0003BD30
			// (set) Token: 0x06009E27 RID: 40487 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170011A7")]
			public int x
			{
				[Token(Token = "0x6009E26")]
				[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6009E27")]
				[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170011A8 RID: 4520
			// (get) Token: 0x06009E28 RID: 40488 RVA: 0x0003DB48 File Offset: 0x0003BD48
			// (set) Token: 0x06009E29 RID: 40489 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170011A8")]
			public int y
			{
				[Token(Token = "0x6009E28")]
				[Address(RVA = "0x4EEB30", Offset = "0x4ED730", VA = "0x1804EEB30", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6009E29")]
				[Address(RVA = "0x4EEB40", Offset = "0x4ED740", VA = "0x1804EEB40")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170011A9 RID: 4521
			// (get) Token: 0x06009E2A RID: 40490 RVA: 0x0003DB60 File Offset: 0x0003BD60
			// (set) Token: 0x06009E2B RID: 40491 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170011A9")]
			public int w
			{
				[Token(Token = "0x6009E2A")]
				[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860", Slot = "6")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6009E2B")]
				[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170011AA RID: 4522
			// (get) Token: 0x06009E2C RID: 40492 RVA: 0x0003DB78 File Offset: 0x0003BD78
			// (set) Token: 0x06009E2D RID: 40493 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170011AA")]
			public int h
			{
				[Token(Token = "0x6009E2C")]
				[Address(RVA = "0x4EA880", Offset = "0x4E9480", VA = "0x1804EA880", Slot = "7")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6009E2D")]
				[Address(RVA = "0x4EAC10", Offset = "0x4E9810", VA = "0x1804EAC10")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06009E2E RID: 40494 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009E2E")]
			[Address(RVA = "0x319E910", Offset = "0x319D510", VA = "0x18319E910")]
			public GeneralGridRect(int x, int y, int w, int h)
			{
			}
		}

		// Token: 0x02001861 RID: 6241
		[Token(Token = "0x2001861")]
		private class FurnitureGridCube : GridMachine3D.IGridCube
		{
			// Token: 0x06009E2F RID: 40495 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009E2F")]
			[Address(RVA = "0x13D53A0", Offset = "0x13D3FA0", VA = "0x1813D53A0")]
			public FurnitureGridCube(Furniture furniture, int roomHeight)
			{
			}

			// Token: 0x170011AB RID: 4523
			// (get) Token: 0x06009E30 RID: 40496 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170011AB")]
			public Furniture furniture
			{
				[Token(Token = "0x6009E30")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170011AC RID: 4524
			// (get) Token: 0x06009E31 RID: 40497 RVA: 0x0003DB90 File Offset: 0x0003BD90
			[Token(Token = "0x170011AC")]
			public int x
			{
				[Token(Token = "0x6009E31")]
				[Address(RVA = "0x319BD00", Offset = "0x319A900", VA = "0x18319BD00", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170011AD RID: 4525
			// (get) Token: 0x06009E32 RID: 40498 RVA: 0x0003DBA8 File Offset: 0x0003BDA8
			[Token(Token = "0x170011AD")]
			public int y
			{
				[Token(Token = "0x6009E32")]
				[Address(RVA = "0x319BD20", Offset = "0x319A920", VA = "0x18319BD20", Slot = "5")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170011AE RID: 4526
			// (get) Token: 0x06009E33 RID: 40499 RVA: 0x0003DBC0 File Offset: 0x0003BDC0
			[Token(Token = "0x170011AE")]
			public int z
			{
				[Token(Token = "0x6009E33")]
				[Address(RVA = "0x319BE70", Offset = "0x319AA70", VA = "0x18319BE70", Slot = "6")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170011AF RID: 4527
			// (get) Token: 0x06009E34 RID: 40500 RVA: 0x0003DBD8 File Offset: 0x0003BDD8
			[Token(Token = "0x170011AF")]
			public int w
			{
				[Token(Token = "0x6009E34")]
				[Address(RVA = "0x319BC80", Offset = "0x319A880", VA = "0x18319BC80", Slot = "7")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170011B0 RID: 4528
			// (get) Token: 0x06009E35 RID: 40501 RVA: 0x0003DBF0 File Offset: 0x0003BDF0
			[Token(Token = "0x170011B0")]
			public int h
			{
				[Token(Token = "0x6009E35")]
				[Address(RVA = "0x319BC20", Offset = "0x319A820", VA = "0x18319BC20", Slot = "8")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170011B1 RID: 4529
			// (get) Token: 0x06009E36 RID: 40502 RVA: 0x0003DC08 File Offset: 0x0003BE08
			[Token(Token = "0x170011B1")]
			public int d
			{
				[Token(Token = "0x6009E36")]
				[Address(RVA = "0x319BBA0", Offset = "0x319A7A0", VA = "0x18319BBA0", Slot = "9")]
				get
				{
					return 0;
				}
			}

			// Token: 0x04009513 RID: 38163
			[Token(Token = "0x4009513")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Furniture m_furniture;

			// Token: 0x04009514 RID: 38164
			[Token(Token = "0x4009514")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private int m_roomHeigit;
		}

		// Token: 0x02001862 RID: 6242
		[Token(Token = "0x2001862")]
		public class ObstacleGridCube : GridMachine3D.IGridCube, DIYRoom.ISpaceOccupation
		{
			// Token: 0x170011B2 RID: 4530
			// (get) Token: 0x06009E37 RID: 40503 RVA: 0x0003DC20 File Offset: 0x0003BE20
			// (set) Token: 0x06009E38 RID: 40504 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170011B2")]
			public int x
			{
				[Token(Token = "0x6009E37")]
				[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6009E38")]
				[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170011B3 RID: 4531
			// (get) Token: 0x06009E39 RID: 40505 RVA: 0x0003DC38 File Offset: 0x0003BE38
			// (set) Token: 0x06009E3A RID: 40506 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170011B3")]
			public int y
			{
				[Token(Token = "0x6009E39")]
				[Address(RVA = "0x4EEB30", Offset = "0x4ED730", VA = "0x1804EEB30", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6009E3A")]
				[Address(RVA = "0x4EEB40", Offset = "0x4ED740", VA = "0x1804EEB40")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170011B4 RID: 4532
			// (get) Token: 0x06009E3B RID: 40507 RVA: 0x0003DC50 File Offset: 0x0003BE50
			// (set) Token: 0x06009E3C RID: 40508 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170011B4")]
			public int z
			{
				[Token(Token = "0x6009E3B")]
				[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860", Slot = "6")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6009E3C")]
				[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170011B5 RID: 4533
			// (get) Token: 0x06009E3D RID: 40509 RVA: 0x0003DC68 File Offset: 0x0003BE68
			// (set) Token: 0x06009E3E RID: 40510 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170011B5")]
			public int w
			{
				[Token(Token = "0x6009E3D")]
				[Address(RVA = "0x4EA880", Offset = "0x4E9480", VA = "0x1804EA880", Slot = "7")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6009E3E")]
				[Address(RVA = "0x4EAC10", Offset = "0x4E9810", VA = "0x1804EAC10")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170011B6 RID: 4534
			// (get) Token: 0x06009E3F RID: 40511 RVA: 0x0003DC80 File Offset: 0x0003BE80
			// (set) Token: 0x06009E40 RID: 40512 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170011B6")]
			public int h
			{
				[Token(Token = "0x6009E3F")]
				[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6009E40")]
				[Address(RVA = "0x4EAC20", Offset = "0x4E9820", VA = "0x1804EAC20")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170011B7 RID: 4535
			// (get) Token: 0x06009E41 RID: 40513 RVA: 0x0003DC98 File Offset: 0x0003BE98
			// (set) Token: 0x06009E42 RID: 40514 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170011B7")]
			public int d
			{
				[Token(Token = "0x6009E41")]
				[Address(RVA = "0x4F6200", Offset = "0x4F4E00", VA = "0x1804F6200", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6009E42")]
				[Address(RVA = "0x4F6220", Offset = "0x4F4E20", VA = "0x1804F6220")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170011B8 RID: 4536
			// (get) Token: 0x06009E43 RID: 40515 RVA: 0x0003DCB0 File Offset: 0x0003BEB0
			[Token(Token = "0x170011B8")]
			public int pos0
			{
				[Token(Token = "0x6009E43")]
				[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0", Slot = "10")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170011B9 RID: 4537
			// (get) Token: 0x06009E44 RID: 40516 RVA: 0x0003DCC8 File Offset: 0x0003BEC8
			[Token(Token = "0x170011B9")]
			public int pos1
			{
				[Token(Token = "0x6009E44")]
				[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860", Slot = "11")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170011BA RID: 4538
			// (get) Token: 0x06009E45 RID: 40517 RVA: 0x0003DCE0 File Offset: 0x0003BEE0
			[Token(Token = "0x170011BA")]
			public int dir
			{
				[Token(Token = "0x6009E45")]
				[Address(RVA = "0x319EC80", Offset = "0x319D880", VA = "0x18319EC80", Slot = "12")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170011BB RID: 4539
			// (get) Token: 0x06009E46 RID: 40518 RVA: 0x0003DCF8 File Offset: 0x0003BEF8
			[Token(Token = "0x170011BB")]
			public Bounds bounds
			{
				[Token(Token = "0x6009E46")]
				[Address(RVA = "0x319EAA0", Offset = "0x319D6A0", VA = "0x18319EAA0", Slot = "13")]
				get
				{
					return default(Bounds);
				}
			}

			// Token: 0x06009E47 RID: 40519 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009E47")]
			[Address(RVA = "0x54AEC0", Offset = "0x549AC0", VA = "0x18054AEC0")]
			public void SetIndicator(DIYRoomIndicator indicator)
			{
			}

			// Token: 0x06009E48 RID: 40520 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009E48")]
			[Address(RVA = "0x319E9F0", Offset = "0x319D5F0", VA = "0x18319E9F0")]
			public ObstacleGridCube(int x, int y, int z, int w, int h, int d, float gridSizeX, float gridSizeY, float gridSizeZ, GridLocator gridLocator, Transform parent)
			{
			}

			// Token: 0x06009E49 RID: 40521 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009E49")]
			[Address(RVA = "0x319E960", Offset = "0x319D560", VA = "0x18319E960")]
			public void SetIndicatorVisible(bool visible)
			{
			}

			// Token: 0x0400951B RID: 38171
			[Token(Token = "0x400951B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float m_gridSizeX;

			// Token: 0x0400951C RID: 38172
			[Token(Token = "0x400951C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float m_gridSizeY;

			// Token: 0x0400951D RID: 38173
			[Token(Token = "0x400951D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float m_gridSizeZ;

			// Token: 0x0400951E RID: 38174
			[Token(Token = "0x400951E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Transform m_parent;

			// Token: 0x0400951F RID: 38175
			[Token(Token = "0x400951F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private DIYRoomIndicator m_indicator;

			// Token: 0x04009520 RID: 38176
			[Token(Token = "0x4009520")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private GridLocator m_gridLocator;
		}
	}
}
