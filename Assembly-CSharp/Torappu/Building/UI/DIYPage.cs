using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AdvancedInspector;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;
using Torappu.Building.DIY;
using Torappu.Building.DIY.UI;
using Torappu.GraphicEffect.Reflection;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI
{
	// Token: 0x02001AC7 RID: 6855
	[Token(Token = "0x2001AC7")]
	public class DIYPage : BuildingCommonPage, DIYRoom.IListener
	{
		// Token: 0x1700147F RID: 5247
		// (get) Token: 0x0600AD14 RID: 44308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700147F")]
		private ReflectCameraHolder reflectCameraHolder
		{
			[Token(Token = "0x600AD14")]
			[Address(RVA = "0x3287010", Offset = "0x3285C10", VA = "0x183287010")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001480 RID: 5248
		// (get) Token: 0x0600AD15 RID: 44309 RVA: 0x00042B70 File Offset: 0x00040D70
		[Token(Token = "0x17001480")]
		private float minCameraOffset
		{
			[Token(Token = "0x600AD15")]
			[Address(RVA = "0x3286F00", Offset = "0x3285B00", VA = "0x183286F00")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17001481 RID: 5249
		// (get) Token: 0x0600AD16 RID: 44310 RVA: 0x00042B88 File Offset: 0x00040D88
		[Token(Token = "0x17001481")]
		private float maxCameraOffset
		{
			[Token(Token = "0x600AD16")]
			[Address(RVA = "0x3286DF0", Offset = "0x32859F0", VA = "0x183286DF0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17001482 RID: 5250
		// (get) Token: 0x0600AD17 RID: 44311 RVA: 0x00042BA0 File Offset: 0x00040DA0
		[Token(Token = "0x17001482")]
		private float minCameraVerticleOffset
		{
			[Token(Token = "0x600AD17")]
			[Address(RVA = "0x3286FA0", Offset = "0x3285BA0", VA = "0x183286FA0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17001483 RID: 5251
		// (get) Token: 0x0600AD18 RID: 44312 RVA: 0x00042BB8 File Offset: 0x00040DB8
		[Token(Token = "0x17001483")]
		private float maxCameraVerticleOffset
		{
			[Token(Token = "0x600AD18")]
			[Address(RVA = "0x3286E90", Offset = "0x3285A90", VA = "0x183286E90")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17001484 RID: 5252
		// (get) Token: 0x0600AD19 RID: 44313 RVA: 0x00042BD0 File Offset: 0x00040DD0
		[Token(Token = "0x17001484")]
		private bool furnitureEnableRotate
		{
			[Token(Token = "0x600AD19")]
			[Address(RVA = "0x3286D60", Offset = "0x3285960", VA = "0x183286D60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001485 RID: 5253
		// (get) Token: 0x0600AD1A RID: 44314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001485")]
		public GameObject uiControllerBackButton
		{
			[Token(Token = "0x600AD1A")]
			[Address(RVA = "0x3287100", Offset = "0x3285D00", VA = "0x183287100")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600AD1B RID: 44315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD1B")]
		[Address(RVA = "0x327E950", Offset = "0x327D550", VA = "0x18327E950", Slot = "8")]
		protected override void OnCreate(DataBundle savedInstance)
		{
		}

		// Token: 0x0600AD1C RID: 44316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD1C")]
		[Address(RVA = "0x327F240", Offset = "0x327DE40", VA = "0x18327F240", Slot = "10")]
		protected override void OnStart()
		{
		}

		// Token: 0x0600AD1D RID: 44317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD1D")]
		[Address(RVA = "0x327F2F0", Offset = "0x327DEF0", VA = "0x18327F2F0", Slot = "14")]
		protected override void OnStop()
		{
		}

		// Token: 0x0600AD1E RID: 44318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD1E")]
		[Address(RVA = "0x3280340", Offset = "0x327EF40", VA = "0x183280340")]
		private void _AdjustReflectCameraIndexUsage(bool isPageEnable)
		{
		}

		// Token: 0x0600AD1F RID: 44319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD1F")]
		[Address(RVA = "0x3281610", Offset = "0x3280210", VA = "0x183281610")]
		private void _ForceRefreshFurniturePositionRecord()
		{
		}

		// Token: 0x0600AD20 RID: 44320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD20")]
		[Address(RVA = "0x3281D00", Offset = "0x3280900", VA = "0x183281D00")]
		public void _GetAddFurnitureInitialPosition(IFurnitureData furniture, out int x, out int y)
		{
		}

		// Token: 0x0600AD21 RID: 44321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD21")]
		[Address(RVA = "0x327FD00", Offset = "0x327E900", VA = "0x18327FD00")]
		private void _AddDIYItemToDIYRoom(IDIYItem diyItem)
		{
		}

		// Token: 0x0600AD22 RID: 44322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD22")]
		[Address(RVA = "0x3284700", Offset = "0x3283300", VA = "0x183284700")]
		private void _SelectSameDIYItem(IDIYItem diyItem)
		{
		}

		// Token: 0x0600AD23 RID: 44323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD23")]
		[Address(RVA = "0x32867A0", Offset = "0x32853A0", VA = "0x1832867A0")]
		private void _UnequipModifierFromRoom(DIYRoomPart roomPart)
		{
		}

		// Token: 0x0600AD24 RID: 44324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD24")]
		[Address(RVA = "0x3284B40", Offset = "0x3283740", VA = "0x183284B40")]
		private void _SetCameraState(DIYPage.CameraStateType stateType, bool force = false)
		{
		}

		// Token: 0x0600AD25 RID: 44325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD25")]
		[Address(RVA = "0x3284FF0", Offset = "0x3283BF0", VA = "0x183284FF0")]
		private void _SetupFurnitureCameraState(RoomSlotModel roomSlotModel)
		{
		}

		// Token: 0x0600AD26 RID: 44326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD26")]
		[Address(RVA = "0x3284380", Offset = "0x3282F80", VA = "0x183284380")]
		private void _ResetFurnitureCameraState(bool force)
		{
		}

		// Token: 0x0600AD27 RID: 44327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD27")]
		[Address(RVA = "0x3284400", Offset = "0x3283000", VA = "0x183284400")]
		private void _ResetFurnitureSelect()
		{
		}

		// Token: 0x0600AD28 RID: 44328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD28")]
		[Address(RVA = "0x3284E10", Offset = "0x3283A10", VA = "0x183284E10")]
		private void _SetIndicator(DIYRoom.ISpaceOccupation occupation, FurnitureLocationType locationType, bool isShow)
		{
		}

		// Token: 0x0600AD29 RID: 44329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD29")]
		[Address(RVA = "0x3283E50", Offset = "0x3282A50", VA = "0x183283E50")]
		private void _OnTweeningOffset(Vector3 currentCameraOffset, DIYPage.CameraState state, float val, bool isCeilingDir)
		{
		}

		// Token: 0x0600AD2A RID: 44330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD2A")]
		[Address(RVA = "0x3282950", Offset = "0x3281550", VA = "0x183282950")]
		private void _OnCameraStateChange(DIYPage.CameraState state)
		{
		}

		// Token: 0x0600AD2B RID: 44331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD2B")]
		[Address(RVA = "0x3284D00", Offset = "0x3283900", VA = "0x183284D00")]
		private void _SetCeilingMatRenderQueue(bool needSet)
		{
		}

		// Token: 0x0600AD2C RID: 44332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD2C")]
		[Address(RVA = "0x3280DC0", Offset = "0x327F9C0", VA = "0x183280DC0")]
		private void _CacheOrthoPersMatrix(bool curIsOrtho)
		{
		}

		// Token: 0x0600AD2D RID: 44333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD2D")]
		[Address(RVA = "0x32812C0", Offset = "0x327FEC0", VA = "0x1832812C0")]
		private void _DoCameraPerspectiveTransIfNeeded(float progress, bool isCeilingDir)
		{
		}

		// Token: 0x0600AD2E RID: 44334 RVA: 0x00042BE8 File Offset: 0x00040DE8
		[Token(Token = "0x600AD2E")]
		[Address(RVA = "0x327E380", Offset = "0x327CF80", VA = "0x18327E380")]
		private Matrix4x4 MatrixLerp(Matrix4x4 from, Matrix4x4 to, float t)
		{
			return default(Matrix4x4);
		}

		// Token: 0x0600AD2F RID: 44335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD2F")]
		[Address(RVA = "0x32837F0", Offset = "0x32823F0", VA = "0x1832837F0")]
		private void _OnFurniturePointEmpty()
		{
		}

		// Token: 0x0600AD30 RID: 44336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD30")]
		[Address(RVA = "0x3282F10", Offset = "0x3281B10", VA = "0x183282F10")]
		private void _OnDragEmpty(Vector2 vec)
		{
		}

		// Token: 0x0600AD31 RID: 44337 RVA: 0x00042C00 File Offset: 0x00040E00
		[Token(Token = "0x600AD31")]
		[Address(RVA = "0x3281060", Offset = "0x327FC60", VA = "0x183281060")]
		private bool _CanDragVerticle()
		{
			return default(bool);
		}

		// Token: 0x0600AD32 RID: 44338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD32")]
		[Address(RVA = "0x3281720", Offset = "0x3280320", VA = "0x183281720")]
		private void _FurnitureBeginDrag(DIYRoom.IFurnitureController controller, bool isFirstAdd)
		{
		}

		// Token: 0x0600AD33 RID: 44339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD33")]
		[Address(RVA = "0x3283520", Offset = "0x3282120", VA = "0x183283520")]
		private void _OnFurnitureBeginDrag(DIYRoom.IFurnitureController controller, bool isFirstAdd)
		{
		}

		// Token: 0x0600AD34 RID: 44340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD34")]
		[Address(RVA = "0x3281A80", Offset = "0x3280680", VA = "0x183281A80")]
		private void _FurnitureEndDrag(DIYRoom.IFurnitureController controller)
		{
		}

		// Token: 0x0600AD35 RID: 44341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD35")]
		[Address(RVA = "0x3283670", Offset = "0x3282270", VA = "0x183283670")]
		private void _OnFurnitureEndDrag(DIYRoom.IFurnitureController controller)
		{
		}

		// Token: 0x0600AD36 RID: 44342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD36")]
		[Address(RVA = "0x3281BC0", Offset = "0x32807C0", VA = "0x183281BC0")]
		private void _FurnitureStartDrag(DIYRoom.IFurnitureController controller)
		{
		}

		// Token: 0x0600AD37 RID: 44343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD37")]
		[Address(RVA = "0x3283860", Offset = "0x3282460", VA = "0x183283860")]
		private void _OnFurnitureStartDrag(DIYRoom.IFurnitureController controller)
		{
		}

		// Token: 0x0600AD38 RID: 44344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD38")]
		[Address(RVA = "0x32835C0", Offset = "0x32821C0", VA = "0x1832835C0")]
		private void _OnFurnitureDragged(DIYRoom.IFurnitureController controller, int pos0, int pos1)
		{
		}

		// Token: 0x0600AD39 RID: 44345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD39")]
		[Address(RVA = "0x32839E0", Offset = "0x32825E0", VA = "0x1832839E0")]
		private void _OnIndicatorButtonPressed(DIYRoomIndicatorButton button)
		{
		}

		// Token: 0x0600AD3A RID: 44346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD3A")]
		[Address(RVA = "0x3286990", Offset = "0x3285590", VA = "0x183286990")]
		private void _UpdateCameraViewport(CanvasScaler scaler)
		{
		}

		// Token: 0x0600AD3B RID: 44347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD3B")]
		[Address(RVA = "0x3285340", Offset = "0x3283F40", VA = "0x183285340")]
		private void _Setup()
		{
		}

		// Token: 0x0600AD3C RID: 44348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AD3C")]
		[Address(RVA = "0x327E2C0", Offset = "0x327CEC0", VA = "0x18327E2C0", Slot = "25")]
		protected override IEnumerator EffectsOnShow(bool isFromStack)
		{
			return null;
		}

		// Token: 0x0600AD3D RID: 44349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AD3D")]
		[Address(RVA = "0x327E1E0", Offset = "0x327CDE0", VA = "0x18327E1E0", Slot = "26")]
		protected override IEnumerator EffectsOnHide(bool isIntoStack, bool isRemoveVirtualTop)
		{
			return null;
		}

		// Token: 0x0600AD3E RID: 44350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD3E")]
		[Address(RVA = "0x327EB80", Offset = "0x327D780", VA = "0x18327EB80", Slot = "16")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0600AD3F RID: 44351 RVA: 0x00042C18 File Offset: 0x00040E18
		[Token(Token = "0x600AD3F")]
		[Address(RVA = "0x3282140", Offset = "0x3280D40", VA = "0x183282140")]
		private int _GetRoomComfortLimit()
		{
			return 0;
		}

		// Token: 0x0600AD40 RID: 44352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD40")]
		[Address(RVA = "0x3283FF0", Offset = "0x3282BF0", VA = "0x183283FF0")]
		private void _ResetAllChanges()
		{
		}

		// Token: 0x0600AD41 RID: 44353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD41")]
		[Address(RVA = "0x32810F0", Offset = "0x327FCF0", VA = "0x1832810F0")]
		private void _ClearAllFurnitures()
		{
		}

		// Token: 0x0600AD42 RID: 44354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD42")]
		[Address(RVA = "0x3282310", Offset = "0x3280F10", VA = "0x183282310")]
		private void _IndicatorMuteAction(Action action)
		{
		}

		// Token: 0x0600AD43 RID: 44355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD43")]
		[Address(RVA = "0x3284500", Offset = "0x3283100", VA = "0x183284500")]
		private void _SaveAllChanges(Action<int> resultHandler)
		{
		}

		// Token: 0x0600AD44 RID: 44356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD44")]
		[Address(RVA = "0x3285E50", Offset = "0x3284A50", VA = "0x183285E50")]
		private void _ShowOKDialog(string content, [Optional] Action okAction)
		{
		}

		// Token: 0x0600AD45 RID: 44357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD45")]
		[Address(RVA = "0x3284950", Offset = "0x3283550", VA = "0x183284950")]
		private void _SetCameraLock(bool lockCamera)
		{
		}

		// Token: 0x0600AD46 RID: 44358 RVA: 0x00042C30 File Offset: 0x00040E30
		[Token(Token = "0x600AD46")]
		[Address(RVA = "0x3285FA0", Offset = "0x3284BA0", VA = "0x183285FA0")]
		private bool _TrySaveDIY()
		{
			return default(bool);
		}

		// Token: 0x0600AD47 RID: 44359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD47")]
		[Address(RVA = "0x32861F0", Offset = "0x3284DF0", VA = "0x1832861F0")]
		private void _TrySavePreset(int index, Action<DIYPreset> resultHandler)
		{
		}

		// Token: 0x0600AD48 RID: 44360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD48")]
		[Address(RVA = "0x3286650", Offset = "0x3285250", VA = "0x183286650")]
		private void _TrySavePreset(int index, Texture2D tex, Action<DIYPreset> resultHandler)
		{
		}

		// Token: 0x0600AD49 RID: 44361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD49")]
		[Address(RVA = "0x32823B0", Offset = "0x3280FB0", VA = "0x1832823B0")]
		private void _LoadDIYPreset(int index, IDIYPreset preset)
		{
		}

		// Token: 0x0600AD4A RID: 44362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD4A")]
		[Address(RVA = "0x3286320", Offset = "0x3284F20", VA = "0x183286320")]
		private void _TrySavePreset(int index, string presetName, Texture2D tex, Action<DIYPreset> resultHandler)
		{
		}

		// Token: 0x0600AD4B RID: 44363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AD4B")]
		[Address(RVA = "0x3281F10", Offset = "0x3280B10", VA = "0x183281F10")]
		private Texture2D _GetPresetPreviewTexture()
		{
			return null;
		}

		// Token: 0x0600AD4C RID: 44364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD4C")]
		[Address(RVA = "0x3280480", Offset = "0x327F080", VA = "0x183280480")]
		private void _ApplyThemePresetToCurRoom(string themeId)
		{
		}

		// Token: 0x0600AD4D RID: 44365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD4D")]
		[Address(RVA = "0x327F1E0", Offset = "0x327DDE0", VA = "0x18327F1E0", Slot = "31")]
		public void OnSetup()
		{
		}

		// Token: 0x0600AD4E RID: 44366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD4E")]
		[Address(RVA = "0x327ED50", Offset = "0x327D950", VA = "0x18327ED50", Slot = "32")]
		public void OnFurnitureRegistered(DIYRoom.IFurnitureController controller)
		{
		}

		// Token: 0x0600AD4F RID: 44367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD4F")]
		[Address(RVA = "0x327EFD0", Offset = "0x327DBD0", VA = "0x18327EFD0", Slot = "33")]
		public void OnFurnitureUnregistered(DIYRoom.IFurnitureController controller)
		{
		}

		// Token: 0x0600AD50 RID: 44368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD50")]
		[Address(RVA = "0x327ECA0", Offset = "0x327D8A0", VA = "0x18327ECA0", Slot = "34")]
		public void OnFloorModifierChanged(DIYRoomModifier pre, DIYRoomModifier post)
		{
		}

		// Token: 0x0600AD51 RID: 44369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD51")]
		[Address(RVA = "0x327F3B0", Offset = "0x327DFB0", VA = "0x18327F3B0", Slot = "35")]
		public void OnWallModifierChanged(DIYRoomModifier pre, DIYRoomModifier post)
		{
		}

		// Token: 0x0600AD52 RID: 44370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD52")]
		[Address(RVA = "0x327F160", Offset = "0x327DD60", VA = "0x18327F160", Slot = "36")]
		public void OnIntersectionStateChanged(bool intersect)
		{
		}

		// Token: 0x0600AD53 RID: 44371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD53")]
		[Address(RVA = "0x327E8E0", Offset = "0x327D4E0", VA = "0x18327E8E0")]
		public void OnCameraLockPressed()
		{
		}

		// Token: 0x0600AD54 RID: 44372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD54")]
		[Address(RVA = "0x3286B00", Offset = "0x3285700", VA = "0x183286B00")]
		public DIYPage()
		{
		}

		// Token: 0x0600AD61 RID: 44385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD61")]
		[Address(RVA = "0x327F490", Offset = "0x327E090", VA = "0x18327F490")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x0600AD62 RID: 44386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD62")]
		[Address(RVA = "0x1071290", Offset = "0x106FE90", VA = "0x181071290")]
		private void <>xLuaBaseProxy_OnStart()
		{
		}

		// Token: 0x0600AD63 RID: 44387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD63")]
		[Address(RVA = "0x12C3F80", Offset = "0x12C2B80", VA = "0x1812C3F80")]
		private void <>xLuaBaseProxy_OnStop()
		{
		}

		// Token: 0x0600AD64 RID: 44388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AD64")]
		[Address(RVA = "0x119B2F0", Offset = "0x1199EF0", VA = "0x18119B2F0")]
		private IEnumerator <>xLuaBaseProxy_EffectsOnShow(bool P0)
		{
			return null;
		}

		// Token: 0x0600AD65 RID: 44389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AD65")]
		[Address(RVA = "0x12172E0", Offset = "0x1215EE0", VA = "0x1812172E0")]
		private IEnumerator <>xLuaBaseProxy_EffectsOnHide(bool P0, bool P1)
		{
			return null;
		}

		// Token: 0x0600AD66 RID: 44390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD66")]
		[Address(RVA = "0x327F4A0", Offset = "0x327E0A0", VA = "0x18327F4A0")]
		private void <>xLuaBaseProxy_OnDestroy()
		{
		}

		// Token: 0x0400A54E RID: 42318
		[Token(Token = "0x400A54E")]
		private const float IN_OUT_ANIM_DURATION = 0.25f;

		// Token: 0x0400A54F RID: 42319
		[Token(Token = "0x400A54F")]
		private const float FIELD_OF_VIEW_OFFSET = 5f;

		// Token: 0x0400A550 RID: 42320
		[Token(Token = "0x400A550")]
		private const int JPEG_ENCODE_QUALITY = 50;

		// Token: 0x0400A551 RID: 42321
		[Token(Token = "0x400A551")]
		private const int PRESET_THUMBNAIL_CACHE_SIZE_THRESHOLD_KB = 100;

		// Token: 0x0400A552 RID: 42322
		[Token(Token = "0x400A552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		private DIYRoom _diyRoom;

		// Token: 0x0400A553 RID: 42323
		[Token(Token = "0x400A553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[SerializeField]
		private FurnitureGenreConfig _groundFurnitureGenre;

		// Token: 0x0400A554 RID: 42324
		[Token(Token = "0x400A554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[SerializeField]
		private DIYTouchHandler _touchHandler;

		// Token: 0x0400A555 RID: 42325
		[Token(Token = "0x400A555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[SerializeField]
		[Group("CameraState")]
		private List<DIYPage.CameraStateConfigs> _cameraConfigs;

		// Token: 0x0400A556 RID: 42326
		[Token(Token = "0x400A556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[SerializeField]
		private DIYRoomIndicator _indicator;

		// Token: 0x0400A557 RID: 42327
		[Token(Token = "0x400A557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[SerializeField]
		private float _cameraDragSpeed;

		// Token: 0x0400A558 RID: 42328
		[Token(Token = "0x400A558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		[SerializeField]
		private GameObject _cameraLockIcon;

		// Token: 0x0400A559 RID: 42329
		[Token(Token = "0x400A559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		[SerializeField]
		private GameObject _cameraUnlockIcon;

		// Token: 0x0400A55A RID: 42330
		[Token(Token = "0x400A55A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		[SerializeField]
		private string _presetImagePath;

		// Token: 0x0400A55B RID: 42331
		[Token(Token = "0x400A55B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		[SerializeField]
		private int _presetThumbsnailsWidth;

		// Token: 0x0400A55C RID: 42332
		[Token(Token = "0x400A55C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		[SerializeField]
		private int _presetThumbsnailsHeight;

		// Token: 0x0400A55D RID: 42333
		[Token(Token = "0x400A55D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		[SerializeField]
		private Camera _presetShotCamera;

		// Token: 0x0400A55E RID: 42334
		[Token(Token = "0x400A55E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		[SerializeField]
		private GameObject _intersectHint;

		// Token: 0x0400A55F RID: 42335
		[Token(Token = "0x400A55F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		[SerializeField]
		private float _bottomMarginLinearWeight;

		// Token: 0x0400A560 RID: 42336
		[Token(Token = "0x400A560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		[SerializeField]
		private float _bottomMarginLinearBias;

		// Token: 0x0400A561 RID: 42337
		[Token(Token = "0x400A561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		[SerializeField]
		private ReflectCamera _reflectCamera;

		// Token: 0x0400A562 RID: 42338
		[Token(Token = "0x400A562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		[SerializeField]
		private float _reflectFadeHeight;

		// Token: 0x0400A563 RID: 42339
		[Token(Token = "0x400A563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		[SerializeField]
		private Camera _roomCamera;

		// Token: 0x0400A564 RID: 42340
		[Token(Token = "0x400A564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		[SerializeField]
		[Group("UI Layer")]
		private DIYUIController _uiControllerPrefab;

		// Token: 0x0400A565 RID: 42341
		[Token(Token = "0x400A565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		[Group("UI Layer")]
		private RectTransform _uiContainer;

		// Token: 0x0400A566 RID: 42342
		[Token(Token = "0x400A566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		[SerializeField]
		[Group("UI Layer")]
		private Sprite _unequipIcon;

		// Token: 0x0400A567 RID: 42343
		[Token(Token = "0x400A567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		private UICanvasScalerHelper _scaler;

		// Token: 0x0400A568 RID: 42344
		[Token(Token = "0x400A568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private DIYUIController m_uiController;

		// Token: 0x0400A569 RID: 42345
		[Token(Token = "0x400A569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private IFurnitureTypeDB m_furnitureTypeDB;

		// Token: 0x0400A56A RID: 42346
		[Token(Token = "0x400A56A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private FurnitureMemento m_furnitureMemento;

		// Token: 0x0400A56B RID: 42347
		[Token(Token = "0x400A56B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private DIYRoomModifierMemento m_modifierMemento;

		// Token: 0x0400A56C RID: 42348
		[Token(Token = "0x400A56C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private DIYRoom.IFurnitureController m_selectFurnitureController;

		// Token: 0x0400A56D RID: 42349
		[Token(Token = "0x400A56D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private bool m_lockCamera;

		// Token: 0x0400A56E RID: 42350
		[Token(Token = "0x400A56E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private DIYPage.CameraState m_currentCameraState;

		// Token: 0x0400A56F RID: 42351
		[Token(Token = "0x400A56F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private DIYPage.CameraStateConfigs m_currentCameraStateConfigs;

		// Token: 0x0400A570 RID: 42352
		[Token(Token = "0x400A570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private float m_cameraHorizontalOffset;

		// Token: 0x0400A571 RID: 42353
		[Token(Token = "0x400A571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
		private float m_cameraVerticleOffset;

		// Token: 0x0400A572 RID: 42354
		[Token(Token = "0x400A572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private bool m_cameraTweening;

		// Token: 0x0400A573 RID: 42355
		[Token(Token = "0x400A573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x201")]
		private bool m_processingPresetApplying;

		// Token: 0x0400A574 RID: 42356
		[Token(Token = "0x400A574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private PersistentImageProxy m_imageProxy;

		// Token: 0x0400A575 RID: 42357
		[Token(Token = "0x400A575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private Matrix4x4 m_orthoMatrix;

		// Token: 0x0400A576 RID: 42358
		[Token(Token = "0x400A576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private Matrix4x4 m_persMatrix;

		// Token: 0x0400A577 RID: 42359
		[Token(Token = "0x400A577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private bool m_cachedMatrix;

		// Token: 0x0400A578 RID: 42360
		[Token(Token = "0x400A578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		private DIYPage.DIYPageSwitchTween m_pageSwitchTween;

		// Token: 0x0400A579 RID: 42361
		[Token(Token = "0x400A579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		private TweenerCore<float, float, FloatOptions> m_tweenOffset;

		// Token: 0x0400A57A RID: 42362
		[Token(Token = "0x400A57A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		private TweenerCore<float, float, FloatOptions> m_tweenLookOffset;

		// Token: 0x0400A57B RID: 42363
		[Token(Token = "0x400A57B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		private ReflectCameraHolder m_reflectCameraHolder;

		// Token: 0x0400A57C RID: 42364
		[Token(Token = "0x400A57C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
		private bool m_isCeilingDir;

		// Token: 0x0400A57D RID: 42365
		[Token(Token = "0x400A57D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
		private DIYPage.UnequipModifierViewData m_unequipModifierViewData;

		// Token: 0x0400A57E RID: 42366
		[Token(Token = "0x400A57E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
		private List<DIYPage.FurniturePositionRecord> m_furniturePositionRecordList;

		// Token: 0x0400A57F RID: 42367
		[Token(Token = "0x400A57F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_reflectCameraHolder;

		// Token: 0x0400A580 RID: 42368
		[Token(Token = "0x400A580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_minCameraOffset;

		// Token: 0x0400A581 RID: 42369
		[Token(Token = "0x400A581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_maxCameraOffset;

		// Token: 0x0400A582 RID: 42370
		[Token(Token = "0x400A582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_minCameraVerticleOffset;

		// Token: 0x0400A583 RID: 42371
		[Token(Token = "0x400A583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_maxCameraVerticleOffset;

		// Token: 0x0400A584 RID: 42372
		[Token(Token = "0x400A584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_furnitureEnableRotate;

		// Token: 0x0400A585 RID: 42373
		[Token(Token = "0x400A585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_uiControllerBackButton;

		// Token: 0x0400A586 RID: 42374
		[Token(Token = "0x400A586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0400A587 RID: 42375
		[Token(Token = "0x400A587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnStart;

		// Token: 0x0400A588 RID: 42376
		[Token(Token = "0x400A588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnStop;

		// Token: 0x0400A589 RID: 42377
		[Token(Token = "0x400A589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__AdjustReflectCameraIndexUsage;

		// Token: 0x0400A58A RID: 42378
		[Token(Token = "0x400A58A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ForceRefreshFurniturePositionRecord;

		// Token: 0x0400A58B RID: 42379
		[Token(Token = "0x400A58B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__GetAddFurnitureInitialPosition;

		// Token: 0x0400A58C RID: 42380
		[Token(Token = "0x400A58C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__AddDIYItemToDIYRoom;

		// Token: 0x0400A58D RID: 42381
		[Token(Token = "0x400A58D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__SelectSameDIYItem;

		// Token: 0x0400A58E RID: 42382
		[Token(Token = "0x400A58E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__UnequipModifierFromRoom;

		// Token: 0x0400A58F RID: 42383
		[Token(Token = "0x400A58F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__SetCameraState;

		// Token: 0x0400A590 RID: 42384
		[Token(Token = "0x400A590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__SetupFurnitureCameraState;

		// Token: 0x0400A591 RID: 42385
		[Token(Token = "0x400A591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__ResetFurnitureCameraState;

		// Token: 0x0400A592 RID: 42386
		[Token(Token = "0x400A592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__ResetFurnitureSelect;

		// Token: 0x0400A593 RID: 42387
		[Token(Token = "0x400A593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__SetIndicator;

		// Token: 0x0400A594 RID: 42388
		[Token(Token = "0x400A594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__OnTweeningOffset;

		// Token: 0x0400A595 RID: 42389
		[Token(Token = "0x400A595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__OnCameraStateChange;

		// Token: 0x0400A596 RID: 42390
		[Token(Token = "0x400A596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__SetCeilingMatRenderQueue;

		// Token: 0x0400A597 RID: 42391
		[Token(Token = "0x400A597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__CacheOrthoPersMatrix;

		// Token: 0x0400A598 RID: 42392
		[Token(Token = "0x400A598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__DoCameraPerspectiveTransIfNeeded;

		// Token: 0x0400A599 RID: 42393
		[Token(Token = "0x400A599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_MatrixLerp;

		// Token: 0x0400A59A RID: 42394
		[Token(Token = "0x400A59A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__OnFurniturePointEmpty;

		// Token: 0x0400A59B RID: 42395
		[Token(Token = "0x400A59B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__OnDragEmpty;

		// Token: 0x0400A59C RID: 42396
		[Token(Token = "0x400A59C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__CanDragVerticle;

		// Token: 0x0400A59D RID: 42397
		[Token(Token = "0x400A59D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__FurnitureBeginDrag;

		// Token: 0x0400A59E RID: 42398
		[Token(Token = "0x400A59E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__OnFurnitureBeginDrag;

		// Token: 0x0400A59F RID: 42399
		[Token(Token = "0x400A59F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__FurnitureEndDrag;

		// Token: 0x0400A5A0 RID: 42400
		[Token(Token = "0x400A5A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__OnFurnitureEndDrag;

		// Token: 0x0400A5A1 RID: 42401
		[Token(Token = "0x400A5A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__FurnitureStartDrag;

		// Token: 0x0400A5A2 RID: 42402
		[Token(Token = "0x400A5A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__OnFurnitureStartDrag;

		// Token: 0x0400A5A3 RID: 42403
		[Token(Token = "0x400A5A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__OnFurnitureDragged;

		// Token: 0x0400A5A4 RID: 42404
		[Token(Token = "0x400A5A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__OnIndicatorButtonPressed;

		// Token: 0x0400A5A5 RID: 42405
		[Token(Token = "0x400A5A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__UpdateCameraViewport;

		// Token: 0x0400A5A6 RID: 42406
		[Token(Token = "0x400A5A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0__Setup;

		// Token: 0x0400A5A7 RID: 42407
		[Token(Token = "0x400A5A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_EffectsOnShow;

		// Token: 0x0400A5A8 RID: 42408
		[Token(Token = "0x400A5A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_EffectsOnHide;

		// Token: 0x0400A5A9 RID: 42409
		[Token(Token = "0x400A5A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400A5AA RID: 42410
		[Token(Token = "0x400A5AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0__GetRoomComfortLimit;

		// Token: 0x0400A5AB RID: 42411
		[Token(Token = "0x400A5AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0__ResetAllChanges;

		// Token: 0x0400A5AC RID: 42412
		[Token(Token = "0x400A5AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0__ClearAllFurnitures;

		// Token: 0x0400A5AD RID: 42413
		[Token(Token = "0x400A5AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0__IndicatorMuteAction;

		// Token: 0x0400A5AE RID: 42414
		[Token(Token = "0x400A5AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0__SaveAllChanges;

		// Token: 0x0400A5AF RID: 42415
		[Token(Token = "0x400A5AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0__ShowOKDialog;

		// Token: 0x0400A5B0 RID: 42416
		[Token(Token = "0x400A5B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0__SetCameraLock;

		// Token: 0x0400A5B1 RID: 42417
		[Token(Token = "0x400A5B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0__TrySaveDIY;

		// Token: 0x0400A5B2 RID: 42418
		[Token(Token = "0x400A5B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0__TrySavePreset;

		// Token: 0x0400A5B3 RID: 42419
		[Token(Token = "0x400A5B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix1__TrySavePreset;

		// Token: 0x0400A5B4 RID: 42420
		[Token(Token = "0x400A5B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0__LoadDIYPreset;

		// Token: 0x0400A5B5 RID: 42421
		[Token(Token = "0x400A5B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix2__TrySavePreset;

		// Token: 0x0400A5B6 RID: 42422
		[Token(Token = "0x400A5B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0__GetPresetPreviewTexture;

		// Token: 0x0400A5B7 RID: 42423
		[Token(Token = "0x400A5B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0__ApplyThemePresetToCurRoom;

		// Token: 0x0400A5B8 RID: 42424
		[Token(Token = "0x400A5B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0_OnSetup;

		// Token: 0x0400A5B9 RID: 42425
		[Token(Token = "0x400A5B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0_OnFurnitureRegistered;

		// Token: 0x0400A5BA RID: 42426
		[Token(Token = "0x400A5BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0_OnFurnitureUnregistered;

		// Token: 0x0400A5BB RID: 42427
		[Token(Token = "0x400A5BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0_OnFloorModifierChanged;

		// Token: 0x0400A5BC RID: 42428
		[Token(Token = "0x400A5BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0_OnWallModifierChanged;

		// Token: 0x0400A5BD RID: 42429
		[Token(Token = "0x400A5BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0_OnIntersectionStateChanged;

		// Token: 0x0400A5BE RID: 42430
		[Token(Token = "0x400A5BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix0_OnCameraLockPressed;

		// Token: 0x0400A5BF RID: 42431
		[Token(Token = "0x400A5BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001AC8 RID: 6856
		[Token(Token = "0x2001AC8")]
		public class FurnitureCategoryViewData : DIYItemViewData
		{
			// Token: 0x0600AD67 RID: 44391 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600AD67")]
			[Address(RVA = "0x329C540", Offset = "0x329B140", VA = "0x18329C540", Slot = "22")]
			public override string GetDisplayName()
			{
				return null;
			}

			// Token: 0x0600AD68 RID: 44392 RVA: 0x00042CA8 File Offset: 0x00040EA8
			[Token(Token = "0x600AD68")]
			[Address(RVA = "0x329C780", Offset = "0x329B380", VA = "0x18329C780", Slot = "10")]
			public override bool ShowCount()
			{
				return default(bool);
			}

			// Token: 0x0600AD69 RID: 44393 RVA: 0x00042CC0 File Offset: 0x00040EC0
			[Token(Token = "0x600AD69")]
			[Address(RVA = "0x329C840", Offset = "0x329B440", VA = "0x18329C840", Slot = "12")]
			public override bool ShowTotalCount()
			{
				return default(bool);
			}

			// Token: 0x0600AD6A RID: 44394 RVA: 0x00042CD8 File Offset: 0x00040ED8
			[Token(Token = "0x600AD6A")]
			[Address(RVA = "0x329C7E0", Offset = "0x329B3E0", VA = "0x18329C7E0", Slot = "11")]
			public override bool ShowCurrentCount()
			{
				return default(bool);
			}

			// Token: 0x0600AD6B RID: 44395 RVA: 0x00042CF0 File Offset: 0x00040EF0
			[Token(Token = "0x600AD6B")]
			[Address(RVA = "0x329C720", Offset = "0x329B320", VA = "0x18329C720", Slot = "16")]
			public override bool IsCountLabelAtCorner()
			{
				return default(bool);
			}

			// Token: 0x0600AD6C RID: 44396 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600AD6C")]
			[Address(RVA = "0x329C660", Offset = "0x329B260", VA = "0x18329C660", Slot = "5")]
			public override Sprite GetSmallSprite()
			{
				return null;
			}

			// Token: 0x0600AD6D RID: 44397 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AD6D")]
			[Address(RVA = "0x329C8D0", Offset = "0x329B4D0", VA = "0x18329C8D0")]
			public FurnitureCategoryViewData()
			{
			}

			// Token: 0x0600AD6E RID: 44398 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600AD6E")]
			[Address(RVA = "0x31FF300", Offset = "0x31FDF00", VA = "0x1831FF300")]
			private string <>xLuaBaseProxy_GetDisplayName()
			{
				return null;
			}

			// Token: 0x0600AD6F RID: 44399 RVA: 0x00042D08 File Offset: 0x00040F08
			[Token(Token = "0x600AD6F")]
			[Address(RVA = "0x31FF340", Offset = "0x31FDF40", VA = "0x1831FF340")]
			private bool <>xLuaBaseProxy_ShowCount()
			{
				return default(bool);
			}

			// Token: 0x0600AD70 RID: 44400 RVA: 0x00042D20 File Offset: 0x00040F20
			[Token(Token = "0x600AD70")]
			[Address(RVA = "0x329C8C0", Offset = "0x329B4C0", VA = "0x18329C8C0")]
			private bool <>xLuaBaseProxy_ShowTotalCount()
			{
				return default(bool);
			}

			// Token: 0x0600AD71 RID: 44401 RVA: 0x00042D38 File Offset: 0x00040F38
			[Token(Token = "0x600AD71")]
			[Address(RVA = "0x329C8B0", Offset = "0x329B4B0", VA = "0x18329C8B0")]
			private bool <>xLuaBaseProxy_ShowCurrentCount()
			{
				return default(bool);
			}

			// Token: 0x0600AD72 RID: 44402 RVA: 0x00042D50 File Offset: 0x00040F50
			[Token(Token = "0x600AD72")]
			[Address(RVA = "0x329C8A0", Offset = "0x329B4A0", VA = "0x18329C8A0")]
			private bool <>xLuaBaseProxy_IsCountLabelAtCorner()
			{
				return default(bool);
			}

			// Token: 0x0600AD73 RID: 44403 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600AD73")]
			[Address(RVA = "0x31FF310", Offset = "0x31FDF10", VA = "0x1831FF310")]
			private Sprite <>xLuaBaseProxy_GetSmallSprite()
			{
				return null;
			}

			// Token: 0x0400A5C0 RID: 42432
			[Token(Token = "0x400A5C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public new BuildingData.FurnitureType furnitureType;

			// Token: 0x0400A5C1 RID: 42433
			[Token(Token = "0x400A5C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public IFurnitureTypeDB furnitureTypeDB;

			// Token: 0x0400A5C2 RID: 42434
			[Token(Token = "0x400A5C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public UIDIYFurnitureTypeIconHub iconHub;

			// Token: 0x0400A5C3 RID: 42435
			[Token(Token = "0x400A5C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public bool showCurrentCount;

			// Token: 0x0400A5C4 RID: 42436
			[Token(Token = "0x400A5C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetDisplayName;

			// Token: 0x0400A5C5 RID: 42437
			[Token(Token = "0x400A5C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ShowCount;

			// Token: 0x0400A5C6 RID: 42438
			[Token(Token = "0x400A5C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_ShowTotalCount;

			// Token: 0x0400A5C7 RID: 42439
			[Token(Token = "0x400A5C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_ShowCurrentCount;

			// Token: 0x0400A5C8 RID: 42440
			[Token(Token = "0x400A5C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_IsCountLabelAtCorner;

			// Token: 0x0400A5C9 RID: 42441
			[Token(Token = "0x400A5C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_GetSmallSprite;

			// Token: 0x0400A5CA RID: 42442
			[Token(Token = "0x400A5CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02001AC9 RID: 6857
		[Token(Token = "0x2001AC9")]
		public class UnequipModifierViewData : DIYItemViewData
		{
			// Token: 0x0600AD74 RID: 44404 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600AD74")]
			[Address(RVA = "0x32A0AE0", Offset = "0x329F6E0", VA = "0x1832A0AE0", Slot = "4")]
			public override Sprite GetBigSprite()
			{
				return null;
			}

			// Token: 0x0600AD75 RID: 44405 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600AD75")]
			[Address(RVA = "0x32A0B40", Offset = "0x329F740", VA = "0x1832A0B40", Slot = "22")]
			public override string GetDisplayName()
			{
				return null;
			}

			// Token: 0x0600AD76 RID: 44406 RVA: 0x00042D68 File Offset: 0x00040F68
			[Token(Token = "0x600AD76")]
			[Address(RVA = "0x32A0BA0", Offset = "0x329F7A0", VA = "0x1832A0BA0", Slot = "10")]
			public override bool ShowCount()
			{
				return default(bool);
			}

			// Token: 0x0600AD77 RID: 44407 RVA: 0x00042D80 File Offset: 0x00040F80
			[Token(Token = "0x600AD77")]
			[Address(RVA = "0x32A0C60", Offset = "0x329F860", VA = "0x1832A0C60", Slot = "13")]
			public override bool ShowSubButton()
			{
				return default(bool);
			}

			// Token: 0x0600AD78 RID: 44408 RVA: 0x00042D98 File Offset: 0x00040F98
			[Token(Token = "0x600AD78")]
			[Address(RVA = "0x32A0C00", Offset = "0x329F800", VA = "0x1832A0C00", Slot = "15")]
			public override bool ShowRenameButton()
			{
				return default(bool);
			}

			// Token: 0x0600AD79 RID: 44409 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AD79")]
			[Address(RVA = "0x32A0CC0", Offset = "0x329F8C0", VA = "0x1832A0CC0")]
			public UnequipModifierViewData()
			{
			}

			// Token: 0x0600AD7A RID: 44410 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600AD7A")]
			[Address(RVA = "0x31FF2E0", Offset = "0x31FDEE0", VA = "0x1831FF2E0")]
			private Sprite <>xLuaBaseProxy_GetBigSprite()
			{
				return null;
			}

			// Token: 0x0600AD7B RID: 44411 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600AD7B")]
			[Address(RVA = "0x31FF300", Offset = "0x31FDF00", VA = "0x1831FF300")]
			private string <>xLuaBaseProxy_GetDisplayName()
			{
				return null;
			}

			// Token: 0x0600AD7C RID: 44412 RVA: 0x00042DB0 File Offset: 0x00040FB0
			[Token(Token = "0x600AD7C")]
			[Address(RVA = "0x31FF340", Offset = "0x31FDF40", VA = "0x1831FF340")]
			private bool <>xLuaBaseProxy_ShowCount()
			{
				return default(bool);
			}

			// Token: 0x0600AD7D RID: 44413 RVA: 0x00042DC8 File Offset: 0x00040FC8
			[Token(Token = "0x600AD7D")]
			[Address(RVA = "0x31FF360", Offset = "0x31FDF60", VA = "0x1831FF360")]
			private bool <>xLuaBaseProxy_ShowSubButton()
			{
				return default(bool);
			}

			// Token: 0x0600AD7E RID: 44414 RVA: 0x00042DE0 File Offset: 0x00040FE0
			[Token(Token = "0x600AD7E")]
			[Address(RVA = "0x31FF350", Offset = "0x31FDF50", VA = "0x1831FF350")]
			private bool <>xLuaBaseProxy_ShowRenameButton()
			{
				return default(bool);
			}

			// Token: 0x0400A5CB RID: 42443
			[Token(Token = "0x400A5CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string text;

			// Token: 0x0400A5CC RID: 42444
			[Token(Token = "0x400A5CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public DIYRoomPart roomPart;

			// Token: 0x0400A5CD RID: 42445
			[Token(Token = "0x400A5CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Sprite icon;

			// Token: 0x0400A5CE RID: 42446
			[Token(Token = "0x400A5CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetBigSprite;

			// Token: 0x0400A5CF RID: 42447
			[Token(Token = "0x400A5CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetDisplayName;

			// Token: 0x0400A5D0 RID: 42448
			[Token(Token = "0x400A5D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_ShowCount;

			// Token: 0x0400A5D1 RID: 42449
			[Token(Token = "0x400A5D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_ShowSubButton;

			// Token: 0x0400A5D2 RID: 42450
			[Token(Token = "0x400A5D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_ShowRenameButton;

			// Token: 0x0400A5D3 RID: 42451
			[Token(Token = "0x400A5D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02001ACA RID: 6858
		[Token(Token = "0x2001ACA")]
		public class FurnitureThemeViewData : DIYItemViewData
		{
			// Token: 0x0600AD7F RID: 44415 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600AD7F")]
			[Address(RVA = "0x329C930", Offset = "0x329B530", VA = "0x18329C930", Slot = "4")]
			public override Sprite GetBigSprite()
			{
				return null;
			}

			// Token: 0x0600AD80 RID: 44416 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600AD80")]
			[Address(RVA = "0x329CA10", Offset = "0x329B610", VA = "0x18329CA10", Slot = "22")]
			public override string GetDisplayName()
			{
				return null;
			}

			// Token: 0x0600AD81 RID: 44417 RVA: 0x00042DF8 File Offset: 0x00040FF8
			[Token(Token = "0x600AD81")]
			[Address(RVA = "0x329CBD0", Offset = "0x329B7D0", VA = "0x18329CBD0", Slot = "10")]
			public override bool ShowCount()
			{
				return default(bool);
			}

			// Token: 0x0600AD82 RID: 44418 RVA: 0x00042E10 File Offset: 0x00041010
			[Token(Token = "0x600AD82")]
			[Address(RVA = "0x329CCF0", Offset = "0x329B8F0", VA = "0x18329CCF0", Slot = "12")]
			public override bool ShowTotalCount()
			{
				return default(bool);
			}

			// Token: 0x0600AD83 RID: 44419 RVA: 0x00042E28 File Offset: 0x00041028
			[Token(Token = "0x600AD83")]
			[Address(RVA = "0x329CC30", Offset = "0x329B830", VA = "0x18329CC30", Slot = "11")]
			public override bool ShowCurrentCount()
			{
				return default(bool);
			}

			// Token: 0x0600AD84 RID: 44420 RVA: 0x00042E40 File Offset: 0x00041040
			[Token(Token = "0x600AD84")]
			[Address(RVA = "0x329CC90", Offset = "0x329B890", VA = "0x18329CC90", Slot = "28")]
			public override bool ShowLowerInfoButton()
			{
				return default(bool);
			}

			// Token: 0x0600AD85 RID: 44421 RVA: 0x00042E58 File Offset: 0x00041058
			[Token(Token = "0x600AD85")]
			[Address(RVA = "0x329C9B0", Offset = "0x329B5B0", VA = "0x18329C9B0", Slot = "18")]
			public override int GetComfort()
			{
				return 0;
			}

			// Token: 0x0600AD86 RID: 44422 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AD86")]
			[Address(RVA = "0x329CA90", Offset = "0x329B690", VA = "0x18329CA90", Slot = "19")]
			public override void SetComfort(int comfort)
			{
			}

			// Token: 0x0600AD87 RID: 44423 RVA: 0x00042E70 File Offset: 0x00041070
			[Token(Token = "0x600AD87")]
			[Address(RVA = "0x329CB70", Offset = "0x329B770", VA = "0x18329CB70", Slot = "17")]
			public override bool ShowComfort()
			{
				return default(bool);
			}

			// Token: 0x0600AD88 RID: 44424 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AD88")]
			[Address(RVA = "0x329CB00", Offset = "0x329B700", VA = "0x18329CB00", Slot = "20")]
			public override void SetShowComfort(bool showComfort)
			{
			}

			// Token: 0x17001486 RID: 5254
			// (get) Token: 0x0600AD89 RID: 44425 RVA: 0x00042E88 File Offset: 0x00041088
			[Token(Token = "0x17001486")]
			public override int enableRoomType
			{
				[Token(Token = "0x600AD89")]
				[Address(RVA = "0x329CDF0", Offset = "0x329B9F0", VA = "0x18329CDF0", Slot = "7")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0600AD8A RID: 44426 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AD8A")]
			[Address(RVA = "0x329CD90", Offset = "0x329B990", VA = "0x18329CD90")]
			public FurnitureThemeViewData()
			{
			}

			// Token: 0x0600AD8B RID: 44427 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600AD8B")]
			[Address(RVA = "0x31FF2E0", Offset = "0x31FDEE0", VA = "0x1831FF2E0")]
			private Sprite <>xLuaBaseProxy_GetBigSprite()
			{
				return null;
			}

			// Token: 0x0600AD8C RID: 44428 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600AD8C")]
			[Address(RVA = "0x31FF300", Offset = "0x31FDF00", VA = "0x1831FF300")]
			private string <>xLuaBaseProxy_GetDisplayName()
			{
				return null;
			}

			// Token: 0x0600AD8D RID: 44429 RVA: 0x00042EA0 File Offset: 0x000410A0
			[Token(Token = "0x600AD8D")]
			[Address(RVA = "0x31FF340", Offset = "0x31FDF40", VA = "0x1831FF340")]
			private bool <>xLuaBaseProxy_ShowCount()
			{
				return default(bool);
			}

			// Token: 0x0600AD8E RID: 44430 RVA: 0x00042EB8 File Offset: 0x000410B8
			[Token(Token = "0x600AD8E")]
			[Address(RVA = "0x329C8C0", Offset = "0x329B4C0", VA = "0x18329C8C0")]
			private bool <>xLuaBaseProxy_ShowTotalCount()
			{
				return default(bool);
			}

			// Token: 0x0600AD8F RID: 44431 RVA: 0x00042ED0 File Offset: 0x000410D0
			[Token(Token = "0x600AD8F")]
			[Address(RVA = "0x329C8B0", Offset = "0x329B4B0", VA = "0x18329C8B0")]
			private bool <>xLuaBaseProxy_ShowCurrentCount()
			{
				return default(bool);
			}

			// Token: 0x0600AD90 RID: 44432 RVA: 0x00042EE8 File Offset: 0x000410E8
			[Token(Token = "0x600AD90")]
			[Address(RVA = "0x329CD70", Offset = "0x329B970", VA = "0x18329CD70")]
			private bool <>xLuaBaseProxy_ShowLowerInfoButton()
			{
				return default(bool);
			}

			// Token: 0x0600AD91 RID: 44433 RVA: 0x00042F00 File Offset: 0x00041100
			[Token(Token = "0x600AD91")]
			[Address(RVA = "0x31FF2F0", Offset = "0x31FDEF0", VA = "0x1831FF2F0")]
			private int <>xLuaBaseProxy_GetComfort()
			{
				return 0;
			}

			// Token: 0x0600AD92 RID: 44434 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AD92")]
			[Address(RVA = "0x329CD50", Offset = "0x329B950", VA = "0x18329CD50")]
			private void <>xLuaBaseProxy_SetComfort(int P0)
			{
			}

			// Token: 0x0600AD93 RID: 44435 RVA: 0x00042F18 File Offset: 0x00041118
			[Token(Token = "0x600AD93")]
			[Address(RVA = "0x31FF330", Offset = "0x31FDF30", VA = "0x1831FF330")]
			private bool <>xLuaBaseProxy_ShowComfort()
			{
				return default(bool);
			}

			// Token: 0x0600AD94 RID: 44436 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AD94")]
			[Address(RVA = "0x329CD60", Offset = "0x329B960", VA = "0x18329CD60")]
			private void <>xLuaBaseProxy_SetShowComfort(bool P0)
			{
			}

			// Token: 0x0600AD95 RID: 44437 RVA: 0x00042F30 File Offset: 0x00041130
			[Token(Token = "0x600AD95")]
			[Address(RVA = "0x329CD80", Offset = "0x329B980", VA = "0x18329CD80")]
			private int <>xLuaBaseProxy_get_enableRoomType()
			{
				return 0;
			}

			// Token: 0x0400A5D4 RID: 42452
			[Token(Token = "0x400A5D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public BuildingData.CustomData.ThemeData themeData;

			// Token: 0x0400A5D5 RID: 42453
			[Token(Token = "0x400A5D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private int m_comfort;

			// Token: 0x0400A5D6 RID: 42454
			[Token(Token = "0x400A5D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private bool m_showComfort;

			// Token: 0x0400A5D7 RID: 42455
			[Token(Token = "0x400A5D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetBigSprite;

			// Token: 0x0400A5D8 RID: 42456
			[Token(Token = "0x400A5D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetDisplayName;

			// Token: 0x0400A5D9 RID: 42457
			[Token(Token = "0x400A5D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_ShowCount;

			// Token: 0x0400A5DA RID: 42458
			[Token(Token = "0x400A5DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_ShowTotalCount;

			// Token: 0x0400A5DB RID: 42459
			[Token(Token = "0x400A5DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_ShowCurrentCount;

			// Token: 0x0400A5DC RID: 42460
			[Token(Token = "0x400A5DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_ShowLowerInfoButton;

			// Token: 0x0400A5DD RID: 42461
			[Token(Token = "0x400A5DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_GetComfort;

			// Token: 0x0400A5DE RID: 42462
			[Token(Token = "0x400A5DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_SetComfort;

			// Token: 0x0400A5DF RID: 42463
			[Token(Token = "0x400A5DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_ShowComfort;

			// Token: 0x0400A5E0 RID: 42464
			[Token(Token = "0x400A5E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_SetShowComfort;

			// Token: 0x0400A5E1 RID: 42465
			[Token(Token = "0x400A5E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_get_enableRoomType;

			// Token: 0x0400A5E2 RID: 42466
			[Token(Token = "0x400A5E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02001ACB RID: 6859
		[Token(Token = "0x2001ACB")]
		public enum CameraStateType
		{
			// Token: 0x0400A5E4 RID: 42468
			[Token(Token = "0x400A5E4")]
			NONE,
			// Token: 0x0400A5E5 RID: 42469
			[Token(Token = "0x400A5E5")]
			GENERAL,
			// Token: 0x0400A5E6 RID: 42470
			[Token(Token = "0x400A5E6")]
			FLOOR,
			// Token: 0x0400A5E7 RID: 42471
			[Token(Token = "0x400A5E7")]
			FLOOR_DIR,
			// Token: 0x0400A5E8 RID: 42472
			[Token(Token = "0x400A5E8")]
			WALL,
			// Token: 0x0400A5E9 RID: 42473
			[Token(Token = "0x400A5E9")]
			CEILING,
			// Token: 0x0400A5EA RID: 42474
			[Token(Token = "0x400A5EA")]
			CEILING_DIR,
			// Token: 0x0400A5EB RID: 42475
			[Token(Token = "0x400A5EB")]
			WALL_DIR
		}

		// Token: 0x02001ACC RID: 6860
		[Token(Token = "0x2001ACC")]
		[Serializable]
		public class CameraState
		{
			// Token: 0x0600AD96 RID: 44438 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AD96")]
			[Address(RVA = "0x329B540", Offset = "0x329A140", VA = "0x18329B540")]
			public CameraState()
			{
			}

			// Token: 0x0400A5EC RID: 42476
			[Token(Token = "0x400A5EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DIYPage.CameraStateType type;

			// Token: 0x0400A5ED RID: 42477
			[Token(Token = "0x400A5ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 offset;

			// Token: 0x0400A5EE RID: 42478
			[Token(Token = "0x400A5EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 lookOffset;

			// Token: 0x0400A5EF RID: 42479
			[Token(Token = "0x400A5EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 indicatorOpButtonOffset;

			// Token: 0x0400A5F0 RID: 42480
			[Token(Token = "0x400A5F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3 indicatorDragButtonOffset;

			// Token: 0x0400A5F1 RID: 42481
			[Token(Token = "0x400A5F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Vector3 indicatorSize;

			// Token: 0x0400A5F2 RID: 42482
			[Token(Token = "0x400A5F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public List<FurnitureLocationType> disableInteractTypeList;

			// Token: 0x0400A5F3 RID: 42483
			[Token(Token = "0x400A5F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public List<FurnitureLocationType> hideTypeList;
		}

		// Token: 0x02001ACD RID: 6861
		[Token(Token = "0x2001ACD")]
		[Serializable]
		public class CameraStateConfigs
		{
			// Token: 0x0600AD97 RID: 44439 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AD97")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CameraStateConfigs()
			{
			}

			// Token: 0x0400A5F4 RID: 42484
			[Token(Token = "0x400A5F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<BuildingData.RoomType> roomTypes;

			// Token: 0x0400A5F5 RID: 42485
			[Token(Token = "0x400A5F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public List<DIYPage.CameraState> configs;

			// Token: 0x0400A5F6 RID: 42486
			[Token(Token = "0x400A5F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float ceilingCameraOrthoSize;

			// Token: 0x0400A5F7 RID: 42487
			[Token(Token = "0x400A5F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float minCameraVerticleOffsetBias;

			// Token: 0x0400A5F8 RID: 42488
			[Token(Token = "0x400A5F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float maxCameraVerticleOffsetBias;

			// Token: 0x0400A5F9 RID: 42489
			[Token(Token = "0x400A5F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float minCameraOffsetWeight;

			// Token: 0x0400A5FA RID: 42490
			[Token(Token = "0x400A5FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float maxCameraOffsetWeight;

			// Token: 0x0400A5FB RID: 42491
			[Token(Token = "0x400A5FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float minCameraOffsetBias;

			// Token: 0x0400A5FC RID: 42492
			[Token(Token = "0x400A5FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float maxCameraOffsetBias;

			// Token: 0x0400A5FD RID: 42493
			[Token(Token = "0x400A5FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 captureCameraPosition;
		}

		// Token: 0x02001ACE RID: 6862
		[Token(Token = "0x2001ACE")]
		public class ThemePreset : IDIYPreset
		{
			// Token: 0x17001487 RID: 5255
			// (get) Token: 0x0600AD98 RID: 44440 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001487")]
			public string name
			{
				[Token(Token = "0x600AD98")]
				[Address(RVA = "0x329E290", Offset = "0x329CE90", VA = "0x18329E290", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001488 RID: 5256
			// (get) Token: 0x0600AD99 RID: 44441 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600AD9A RID: 44442 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001488")]
			public string roomType
			{
				[Token(Token = "0x600AD99")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600AD9A")]
				[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17001489 RID: 5257
			// (get) Token: 0x0600AD9B RID: 44443 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600AD9C RID: 44444 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001489")]
			public string floorModifierId
			{
				[Token(Token = "0x600AD9B")]
				[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "6")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600AD9C")]
				[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700148A RID: 5258
			// (get) Token: 0x0600AD9D RID: 44445 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600AD9E RID: 44446 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700148A")]
			public string wallModifierId
			{
				[Token(Token = "0x600AD9D")]
				[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "7")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600AD9E")]
				[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700148B RID: 5259
			// (get) Token: 0x0600AD9F RID: 44447 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700148B")]
			public string thumbnailUrl
			{
				[Token(Token = "0x600AD9F")]
				[Address(RVA = "0x329E2D0", Offset = "0x329CED0", VA = "0x18329E2D0", Slot = "8")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700148C RID: 5260
			// (get) Token: 0x0600ADA0 RID: 44448 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700148C")]
			public IEnumerable<DIYPresetItem> items
			{
				[Token(Token = "0x600ADA0")]
				[Address(RVA = "0x329E210", Offset = "0x329CE10", VA = "0x18329E210", Slot = "9")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600ADA1 RID: 44449 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600ADA1")]
			[Address(RVA = "0x329E180", Offset = "0x329CD80", VA = "0x18329E180")]
			public ThemePreset()
			{
			}

			// Token: 0x0400A601 RID: 42497
			[Token(Token = "0x400A601")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<DIYPresetItem> presetItems;
		}

		// Token: 0x02001AD0 RID: 6864
		[Token(Token = "0x2001AD0")]
		public class UIHandler : IHotfixable
		{
			// Token: 0x0600ADAA RID: 44458 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600ADAA")]
			[Address(RVA = "0x32A0A60", Offset = "0x329F660", VA = "0x1832A0A60")]
			public UIHandler(DIYPage page)
			{
			}

			// Token: 0x0600ADAB RID: 44459 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600ADAB")]
			[Address(RVA = "0x329FEE0", Offset = "0x329EAE0", VA = "0x18329FEE0")]
			public FurnitureMemento GetFurnitureMemento()
			{
				return null;
			}

			// Token: 0x0600ADAC RID: 44460 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600ADAC")]
			[Address(RVA = "0x329FFC0", Offset = "0x329EBC0", VA = "0x18329FFC0")]
			public DIYRoomModifierMemento GetModifierMemento()
			{
				return null;
			}

			// Token: 0x0600ADAD RID: 44461 RVA: 0x00042F78 File Offset: 0x00041178
			[Token(Token = "0x600ADAD")]
			[Address(RVA = "0x32A0220", Offset = "0x329EE20", VA = "0x1832A0220")]
			public int GetRoomIndex()
			{
				return 0;
			}

			// Token: 0x0600ADAE RID: 44462 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600ADAE")]
			[Address(RVA = "0x329FE00", Offset = "0x329EA00", VA = "0x18329FE00")]
			public FurnitureGenreConfig GetFurnGenre()
			{
				return null;
			}

			// Token: 0x0600ADAF RID: 44463 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600ADAF")]
			[Address(RVA = "0x32A02A0", Offset = "0x329EEA0", VA = "0x1832A02A0")]
			public DIYPage.UnequipModifierViewData GetUnequipModifierData()
			{
				return null;
			}

			// Token: 0x0600ADB0 RID: 44464 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600ADB0")]
			[Address(RVA = "0x32A0310", Offset = "0x329EF10", VA = "0x1832A0310")]
			public Sprite GetUnequipModifierSprite()
			{
				return null;
			}

			// Token: 0x0600ADB1 RID: 44465 RVA: 0x00042F90 File Offset: 0x00041190
			[Token(Token = "0x600ADB1")]
			[Address(RVA = "0x32A01B0", Offset = "0x329EDB0", VA = "0x1832A01B0")]
			public int GetRoomComfortLimit()
			{
				return 0;
			}

			// Token: 0x0600ADB2 RID: 44466 RVA: 0x00042FA8 File Offset: 0x000411A8
			[Token(Token = "0x600ADB2")]
			[Address(RVA = "0x32A0750", Offset = "0x329F350", VA = "0x1832A0750")]
			public bool TrySaveDIY()
			{
				return default(bool);
			}

			// Token: 0x0600ADB3 RID: 44467 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600ADB3")]
			[Address(RVA = "0x32A0600", Offset = "0x329F200", VA = "0x1832A0600")]
			public void SetCameraStateCeilDirectly()
			{
			}

			// Token: 0x0600ADB4 RID: 44468 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600ADB4")]
			[Address(RVA = "0x32A0670", Offset = "0x329F270", VA = "0x1832A0670")]
			public void SetCameraStateFloorDirectly()
			{
			}

			// Token: 0x0600ADB5 RID: 44469 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600ADB5")]
			[Address(RVA = "0x32A06E0", Offset = "0x329F2E0", VA = "0x1832A06E0")]
			public void SetCameraStateWallDirectly()
			{
			}

			// Token: 0x0600ADB6 RID: 44470 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600ADB6")]
			[Address(RVA = "0x32A0490", Offset = "0x329F090", VA = "0x1832A0490")]
			public void ResetCameraState()
			{
			}

			// Token: 0x0600ADB7 RID: 44471 RVA: 0x00042FC0 File Offset: 0x000411C0
			[Token(Token = "0x600ADB7")]
			[Address(RVA = "0x32A0030", Offset = "0x329EC30", VA = "0x1832A0030")]
			public DIYPresetPanel.Params GetPresetPanelParams()
			{
				return default(DIYPresetPanel.Params);
			}

			// Token: 0x0600ADB8 RID: 44472 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600ADB8")]
			[Address(RVA = "0x32A07C0", Offset = "0x329F3C0", VA = "0x1832A07C0")]
			public void TrySavePreset(int index, Action<DIYPreset> resHandler)
			{
			}

			// Token: 0x0600ADB9 RID: 44473 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600ADB9")]
			[Address(RVA = "0x32A0930", Offset = "0x329F530", VA = "0x1832A0930")]
			public void TrySavePreset(int index, Texture2D tex, Action<DIYPreset> resHandler)
			{
			}

			// Token: 0x0600ADBA RID: 44474 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600ADBA")]
			[Address(RVA = "0x32A0860", Offset = "0x329F460", VA = "0x1832A0860")]
			public void TrySavePreset(int index, string presetName, Texture2D tex, Action<DIYPreset> resHandler)
			{
			}

			// Token: 0x0600ADBB RID: 44475 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600ADBB")]
			[Address(RVA = "0x32A0380", Offset = "0x329EF80", VA = "0x1832A0380")]
			public void LoadPreset(int index, IDIYPreset preset)
			{
			}

			// Token: 0x0600ADBC RID: 44476 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600ADBC")]
			[Address(RVA = "0x329FC50", Offset = "0x329E850", VA = "0x18329FC50")]
			public void ApplyThemePresetToRoom(string themeId)
			{
			}

			// Token: 0x0600ADBD RID: 44477 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600ADBD")]
			[Address(RVA = "0x32A0140", Offset = "0x329ED40", VA = "0x1832A0140")]
			public Texture2D GetPresetViewTexture()
			{
				return null;
			}

			// Token: 0x0600ADBE RID: 44478 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600ADBE")]
			[Address(RVA = "0x329FD80", Offset = "0x329E980", VA = "0x18329FD80")]
			public void ClearRoomHilightMark()
			{
			}

			// Token: 0x0600ADBF RID: 44479 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600ADBF")]
			[Address(RVA = "0x329FE70", Offset = "0x329EA70", VA = "0x18329FE70")]
			public Furniture.IListener GetFurnitureListener()
			{
				return null;
			}

			// Token: 0x0600ADC0 RID: 44480 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600ADC0")]
			[Address(RVA = "0x329FF50", Offset = "0x329EB50", VA = "0x18329FF50")]
			public DIYRoomModifier.IListener GetModifierListener()
			{
				return null;
			}

			// Token: 0x0600ADC1 RID: 44481 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600ADC1")]
			[Address(RVA = "0x329FBC0", Offset = "0x329E7C0", VA = "0x18329FBC0")]
			public void AddDIYItemToRoom(IDIYItem diyItem)
			{
			}

			// Token: 0x0600ADC2 RID: 44482 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600ADC2")]
			[Address(RVA = "0x32A0570", Offset = "0x329F170", VA = "0x1832A0570")]
			public void SelectSameDIYItem(IDIYItem diyItem)
			{
			}

			// Token: 0x0600ADC3 RID: 44483 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600ADC3")]
			[Address(RVA = "0x32A09E0", Offset = "0x329F5E0", VA = "0x1832A09E0")]
			public void UnequipModifierFromRoom(DIYRoomPart roomPart)
			{
			}

			// Token: 0x0600ADC4 RID: 44484 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600ADC4")]
			[Address(RVA = "0x32A0420", Offset = "0x329F020", VA = "0x1832A0420")]
			public void ResetAllChanges()
			{
			}

			// Token: 0x0600ADC5 RID: 44485 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600ADC5")]
			[Address(RVA = "0x32A0500", Offset = "0x329F100", VA = "0x1832A0500")]
			public void ResetFurnitureCameraState()
			{
			}

			// Token: 0x0600ADC6 RID: 44486 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600ADC6")]
			[Address(RVA = "0x329FCE0", Offset = "0x329E8E0", VA = "0x18329FCE0")]
			public void ClearAllFurnitures()
			{
			}

			// Token: 0x0400A608 RID: 42504
			[Token(Token = "0x400A608")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private DIYPage m_closure;

			// Token: 0x0400A609 RID: 42505
			[Token(Token = "0x400A609")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400A60A RID: 42506
			[Token(Token = "0x400A60A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetFurnitureMemento;

			// Token: 0x0400A60B RID: 42507
			[Token(Token = "0x400A60B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetModifierMemento;

			// Token: 0x0400A60C RID: 42508
			[Token(Token = "0x400A60C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetRoomIndex;

			// Token: 0x0400A60D RID: 42509
			[Token(Token = "0x400A60D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetFurnGenre;

			// Token: 0x0400A60E RID: 42510
			[Token(Token = "0x400A60E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_GetUnequipModifierData;

			// Token: 0x0400A60F RID: 42511
			[Token(Token = "0x400A60F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_GetUnequipModifierSprite;

			// Token: 0x0400A610 RID: 42512
			[Token(Token = "0x400A610")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_GetRoomComfortLimit;

			// Token: 0x0400A611 RID: 42513
			[Token(Token = "0x400A611")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_TrySaveDIY;

			// Token: 0x0400A612 RID: 42514
			[Token(Token = "0x400A612")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_SetCameraStateCeilDirectly;

			// Token: 0x0400A613 RID: 42515
			[Token(Token = "0x400A613")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_SetCameraStateFloorDirectly;

			// Token: 0x0400A614 RID: 42516
			[Token(Token = "0x400A614")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_SetCameraStateWallDirectly;

			// Token: 0x0400A615 RID: 42517
			[Token(Token = "0x400A615")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_ResetCameraState;

			// Token: 0x0400A616 RID: 42518
			[Token(Token = "0x400A616")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_GetPresetPanelParams;

			// Token: 0x0400A617 RID: 42519
			[Token(Token = "0x400A617")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_TrySavePreset;

			// Token: 0x0400A618 RID: 42520
			[Token(Token = "0x400A618")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix1_TrySavePreset;

			// Token: 0x0400A619 RID: 42521
			[Token(Token = "0x400A619")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private static DelegateBridge __Hotfix2_TrySavePreset;

			// Token: 0x0400A61A RID: 42522
			[Token(Token = "0x400A61A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private static DelegateBridge __Hotfix0_LoadPreset;

			// Token: 0x0400A61B RID: 42523
			[Token(Token = "0x400A61B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private static DelegateBridge __Hotfix0_ApplyThemePresetToRoom;

			// Token: 0x0400A61C RID: 42524
			[Token(Token = "0x400A61C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private static DelegateBridge __Hotfix0_GetPresetViewTexture;

			// Token: 0x0400A61D RID: 42525
			[Token(Token = "0x400A61D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private static DelegateBridge __Hotfix0_ClearRoomHilightMark;

			// Token: 0x0400A61E RID: 42526
			[Token(Token = "0x400A61E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private static DelegateBridge __Hotfix0_GetFurnitureListener;

			// Token: 0x0400A61F RID: 42527
			[Token(Token = "0x400A61F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private static DelegateBridge __Hotfix0_GetModifierListener;

			// Token: 0x0400A620 RID: 42528
			[Token(Token = "0x400A620")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private static DelegateBridge __Hotfix0_AddDIYItemToRoom;

			// Token: 0x0400A621 RID: 42529
			[Token(Token = "0x400A621")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private static DelegateBridge __Hotfix0_SelectSameDIYItem;

			// Token: 0x0400A622 RID: 42530
			[Token(Token = "0x400A622")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private static DelegateBridge __Hotfix0_UnequipModifierFromRoom;

			// Token: 0x0400A623 RID: 42531
			[Token(Token = "0x400A623")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			private static DelegateBridge __Hotfix0_ResetAllChanges;

			// Token: 0x0400A624 RID: 42532
			[Token(Token = "0x400A624")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			private static DelegateBridge __Hotfix0_ResetFurnitureCameraState;

			// Token: 0x0400A625 RID: 42533
			[Token(Token = "0x400A625")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			private static DelegateBridge __Hotfix0_ClearAllFurnitures;
		}

		// Token: 0x02001AD1 RID: 6865
		[Token(Token = "0x2001AD1")]
		public class DIYPageSwitchTween : UISwitchTween
		{
			// Token: 0x0600ADC7 RID: 44487 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600ADC7")]
			[Address(RVA = "0x329BCF0", Offset = "0x329A8F0", VA = "0x18329BCF0")]
			public DIYPageSwitchTween(DIYPage page)
			{
			}

			// Token: 0x0600ADC8 RID: 44488 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600ADC8")]
			[Address(RVA = "0x329B8B0", Offset = "0x329A4B0", VA = "0x18329B8B0", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0600ADC9 RID: 44489 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600ADC9")]
			[Address(RVA = "0x329BAC0", Offset = "0x329A6C0", VA = "0x18329BAC0", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0400A626 RID: 42534
			[Token(Token = "0x400A626")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private DIYPage m_closure;

			// Token: 0x0400A627 RID: 42535
			[Token(Token = "0x400A627")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400A628 RID: 42536
			[Token(Token = "0x400A628")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x0400A629 RID: 42537
			[Token(Token = "0x400A629")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;
		}

		// Token: 0x02001AD4 RID: 6868
		[Token(Token = "0x2001AD4")]
		private struct FurniturePositionRecord
		{
			// Token: 0x0600ADD0 RID: 44496 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600ADD0")]
			[Address(RVA = "0x317D1A0", Offset = "0x317BDA0", VA = "0x18317D1A0")]
			public FurniturePositionRecord(DIYRoom.IFurnitureController furniture, int pos0, int pos1, int direction)
			{
			}

			// Token: 0x0400A62C RID: 42540
			[Token(Token = "0x400A62C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public DIYRoom.IFurnitureController furnitureController;

			// Token: 0x0400A62D RID: 42541
			[Token(Token = "0x400A62D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int pos0;

			// Token: 0x0400A62E RID: 42542
			[Token(Token = "0x400A62E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int pos1;

			// Token: 0x0400A62F RID: 42543
			[Token(Token = "0x400A62F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int direction;
		}
	}
}
