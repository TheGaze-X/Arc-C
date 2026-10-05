using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Building.BP;
using Torappu.Building.DIY;
using Torappu.Building.UI;
using Torappu.Building.Vault;
using Torappu.GraphicEffect.Reflection;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building
{
	// Token: 0x020017C9 RID: 6089
	[Token(Token = "0x20017C9")]
	public class BuildingController : SingletonMonoBehaviour<BuildingController>, ISingletonNotAutoCreate, IBuildingContext, IHotfixable
	{
		// Token: 0x17001095 RID: 4245
		// (get) Token: 0x060099AC RID: 39340 RVA: 0x0003BB08 File Offset: 0x00039D08
		// (set) Token: 0x060099AD RID: 39341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001095")]
		public bool isToDoNotifyOn
		{
			[Token(Token = "0x60099AC")]
			[Address(RVA = "0x3139B80", Offset = "0x3138780", VA = "0x183139B80")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60099AD")]
			[Address(RVA = "0x313A0E0", Offset = "0x3138CE0", VA = "0x18313A0E0")]
			set
			{
			}
		}

		// Token: 0x17001096 RID: 4246
		// (get) Token: 0x060099AE RID: 39342 RVA: 0x0003BB20 File Offset: 0x00039D20
		[Token(Token = "0x17001096")]
		public bool localTest
		{
			[Token(Token = "0x60099AE")]
			[Address(RVA = "0x3139BE0", Offset = "0x31387E0", VA = "0x183139BE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001097 RID: 4247
		// (get) Token: 0x060099AF RID: 39343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001097")]
		public VaultMode vaultMode
		{
			[Token(Token = "0x60099AF")]
			[Address(RVA = "0x313A080", Offset = "0x3138C80", VA = "0x18313A080")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001098 RID: 4248
		// (get) Token: 0x060099B0 RID: 39344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001098")]
		public BuildingModel model
		{
			[Token(Token = "0x60099B0")]
			[Address(RVA = "0x3139C40", Offset = "0x3138840", VA = "0x183139C40", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001099 RID: 4249
		// (get) Token: 0x060099B1 RID: 39345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001099")]
		public BuildingServiceController service
		{
			[Token(Token = "0x60099B1")]
			[Address(RVA = "0x3139FA0", Offset = "0x3138BA0", VA = "0x183139FA0", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700109A RID: 4250
		// (get) Token: 0x060099B2 RID: 39346 RVA: 0x0003BB38 File Offset: 0x00039D38
		[Token(Token = "0x1700109A")]
		public bool isEmpty
		{
			[Token(Token = "0x60099B2")]
			[Address(RVA = "0x3139AB0", Offset = "0x31386B0", VA = "0x183139AB0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700109B RID: 4251
		// (get) Token: 0x060099B3 RID: 39347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700109B")]
		public BuildingController.Options options
		{
			[Token(Token = "0x60099B3")]
			[Address(RVA = "0x3139D90", Offset = "0x3138990", VA = "0x183139D90")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700109C RID: 4252
		// (get) Token: 0x060099B4 RID: 39348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700109C")]
		public EventPool<BuildingEvent> eventPool
		{
			[Token(Token = "0x60099B4")]
			[Address(RVA = "0x31396E0", Offset = "0x31382E0", VA = "0x1831396E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700109D RID: 4253
		// (get) Token: 0x060099B5 RID: 39349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700109D")]
		private IDIYFeatureComponents diy
		{
			[Token(Token = "0x60099B5")]
			[Address(RVA = "0x31395E0", Offset = "0x31381E0", VA = "0x1831395E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700109E RID: 4254
		// (get) Token: 0x060099B6 RID: 39350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700109E")]
		public IFurnitureDataProvider furnitureDataProvider
		{
			[Token(Token = "0x60099B6")]
			[Address(RVA = "0x3139740", Offset = "0x3138340", VA = "0x183139740")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700109F RID: 4255
		// (get) Token: 0x060099B7 RID: 39351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700109F")]
		public IDIYRoomModifierDataProvider modifierDataProvider
		{
			[Token(Token = "0x60099B7")]
			[Address(RVA = "0x3139CA0", Offset = "0x31388A0", VA = "0x183139CA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010A0 RID: 4256
		// (get) Token: 0x060099B8 RID: 39352 RVA: 0x0003BB50 File Offset: 0x00039D50
		// (set) Token: 0x060099B9 RID: 39353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170010A0")]
		public OperationMode operationMode
		{
			[Token(Token = "0x60099B8")]
			[Address(RVA = "0x3139D30", Offset = "0x3138930", VA = "0x183139D30")]
			get
			{
				return OperationMode.NONE;
			}
			[Token(Token = "0x60099B9")]
			[Address(RVA = "0x313A190", Offset = "0x3138D90", VA = "0x18313A190")]
			set
			{
			}
		}

		// Token: 0x170010A1 RID: 4257
		// (get) Token: 0x060099BA RID: 39354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010A1")]
		public IFurnitureManager furnitureManager
		{
			[Token(Token = "0x60099BA")]
			[Address(RVA = "0x3139860", Offset = "0x3138460", VA = "0x183139860")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010A2 RID: 4258
		// (get) Token: 0x060099BB RID: 39355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010A2")]
		public IDIYRoomModifierManager DIYRoomModifierManager
		{
			[Token(Token = "0x60099BB")]
			[Address(RVA = "0x3139380", Offset = "0x3137F80", VA = "0x183139380")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010A3 RID: 4259
		// (get) Token: 0x060099BC RID: 39356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010A3")]
		public IFurnitureTypeDB furnitureTypeDB
		{
			[Token(Token = "0x60099BC")]
			[Address(RVA = "0x3139A20", Offset = "0x3138620", VA = "0x183139A20")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010A4 RID: 4260
		// (get) Token: 0x060099BD RID: 39357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010A4")]
		public IDIYRoomInfoProvider DIYRoomInfoManager
		{
			[Token(Token = "0x60099BD")]
			[Address(RVA = "0x31392F0", Offset = "0x3137EF0", VA = "0x1831392F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010A5 RID: 4261
		// (get) Token: 0x060099BE RID: 39358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010A5")]
		public IDIYPresetManager DIYPresetManager
		{
			[Token(Token = "0x60099BE")]
			[Address(RVA = "0x3139260", Offset = "0x3137E60", VA = "0x183139260")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010A6 RID: 4262
		// (get) Token: 0x060099BF RID: 39359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010A6")]
		public IDIYShop DIYItemShop
		{
			[Token(Token = "0x60099BF")]
			[Address(RVA = "0x31391D0", Offset = "0x3137DD0", VA = "0x1831391D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010A7 RID: 4263
		// (get) Token: 0x060099C0 RID: 39360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010A7")]
		public IFurnitureStorage furnitureStorage
		{
			[Token(Token = "0x60099C0")]
			[Address(RVA = "0x3139990", Offset = "0x3138590", VA = "0x183139990")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010A8 RID: 4264
		// (get) Token: 0x060099C1 RID: 39361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010A8")]
		public IFurnitureSaver furnitureSaver
		{
			[Token(Token = "0x60099C1")]
			[Address(RVA = "0x3139900", Offset = "0x3138500", VA = "0x183139900")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010A9 RID: 4265
		// (get) Token: 0x060099C2 RID: 39362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010A9")]
		public IFurnitureGroupDataProvider furnitureGroupDataDB
		{
			[Token(Token = "0x60099C2")]
			[Address(RVA = "0x31397D0", Offset = "0x31383D0", VA = "0x1831397D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010AA RID: 4266
		// (get) Token: 0x060099C3 RID: 39363 RVA: 0x0003BB68 File Offset: 0x00039D68
		[Token(Token = "0x170010AA")]
		public bool isModeTransiting
		{
			[Token(Token = "0x60099C3")]
			[Address(RVA = "0x3139B10", Offset = "0x3138710", VA = "0x183139B10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060099C4 RID: 39364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099C4")]
		[Address(RVA = "0x3137E40", Offset = "0x3136A40", VA = "0x183137E40", Slot = "4")]
		protected override void OnInit()
		{
		}

		// Token: 0x170010AB RID: 4267
		// (get) Token: 0x060099C5 RID: 39365 RVA: 0x0003BB80 File Offset: 0x00039D80
		// (set) Token: 0x060099C6 RID: 39366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170010AB")]
		public bool showBuildings
		{
			[Token(Token = "0x60099C5")]
			[Address(RVA = "0x313A000", Offset = "0x3138C00", VA = "0x18313A000")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60099C6")]
			[Address(RVA = "0x313A210", Offset = "0x3138E10", VA = "0x18313A210")]
			set
			{
			}
		}

		// Token: 0x060099C7 RID: 39367 RVA: 0x0003BB98 File Offset: 0x00039D98
		[Token(Token = "0x60099C7")]
		[Address(RVA = "0x3137830", Offset = "0x3136430", VA = "0x183137830")]
		public bool IsModeBlock(IBuildingMode mode)
		{
			return default(bool);
		}

		// Token: 0x060099C8 RID: 39368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099C8")]
		[Address(RVA = "0x31381B0", Offset = "0x3136DB0", VA = "0x1831381B0")]
		public void RMOnly_BlockVaultRaycast(BuildingModeRaycastManager manager, bool isBlock)
		{
		}

		// Token: 0x060099C9 RID: 39369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099C9")]
		[Address(RVA = "0x31380B0", Offset = "0x3136CB0", VA = "0x1831380B0")]
		public void RMOnly_BlockBlueprintRaycast(BuildingModeRaycastManager manager, bool isBlock)
		{
		}

		// Token: 0x060099CA RID: 39370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099CA")]
		[Address(RVA = "0x3136360", Offset = "0x3134F60", VA = "0x183136360")]
		public void BMOnly_BlockBuildingModeRaycast(IBuildingMode buildingMode, bool isBlock)
		{
		}

		// Token: 0x060099CB RID: 39371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099CB")]
		[Address(RVA = "0x3136290", Offset = "0x3134E90", VA = "0x183136290")]
		public void AVGOnly_BlockBuildingModeRaycastForAllModes(RaycastBlockKey key, bool isBlock)
		{
		}

		// Token: 0x060099CC RID: 39372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099CC")]
		[Address(RVA = "0x3136410", Offset = "0x3135010", VA = "0x183136410")]
		public void BlockBuildingRaycast(RaycastBlockKey key, bool isBlock)
		{
		}

		// Token: 0x060099CD RID: 39373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099CD")]
		[Address(RVA = "0x3136F20", Offset = "0x3135B20", VA = "0x183136F20")]
		public void InitBuildingForCurrentPlayer(string layoutId, PlayerBuilding playerBuilding)
		{
		}

		// Token: 0x060099CE RID: 39374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099CE")]
		[Address(RVA = "0x31372B0", Offset = "0x3135EB0", VA = "0x1831372B0")]
		public void InitBuildingForVisit(VisitBuildingResponse response)
		{
		}

		// Token: 0x060099CF RID: 39375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099CF")]
		[Address(RVA = "0x31368D0", Offset = "0x31354D0", VA = "0x1831368D0")]
		public void Display()
		{
		}

		// Token: 0x060099D0 RID: 39376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099D0")]
		[Address(RVA = "0x3137BC0", Offset = "0x31367C0", VA = "0x183137BC0")]
		public void OnBuildingModeChanged()
		{
		}

		// Token: 0x060099D1 RID: 39377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099D1")]
		[Address(RVA = "0x31382B0", Offset = "0x3136EB0", VA = "0x1831382B0")]
		public void ToggleMode()
		{
		}

		// Token: 0x060099D2 RID: 39378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099D2")]
		public void SwitchMode<T>(BuildingStateMachine.TransitionParam param) where T : IBuildingMode
		{
		}

		// Token: 0x060099D3 RID: 39379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60099D3")]
		[Address(RVA = "0x3136E70", Offset = "0x3135A70", VA = "0x183136E70")]
		public Sprite GetBlurBlueprintImage(Shader blurShader)
		{
			return null;
		}

		// Token: 0x060099D4 RID: 39380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60099D4")]
		public T GetState<T>() where T : IBuildingMode
		{
			return null;
		}

		// Token: 0x170010AC RID: 4268
		// (get) Token: 0x060099D5 RID: 39381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010AC")]
		public IBuildingMode curBuildingMode
		{
			[Token(Token = "0x60099D5")]
			[Address(RVA = "0x3139550", Offset = "0x3138150", VA = "0x183139550")]
			get
			{
				return null;
			}
		}

		// Token: 0x060099D6 RID: 39382 RVA: 0x0003BBB0 File Offset: 0x00039DB0
		[Token(Token = "0x60099D6")]
		[Address(RVA = "0x3137F10", Offset = "0x3136B10", VA = "0x183137F10")]
		public int QueryRoomIndex(string roomId)
		{
			return 0;
		}

		// Token: 0x060099D7 RID: 39383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60099D7")]
		[Address(RVA = "0x3137FE0", Offset = "0x3136BE0", VA = "0x183137FE0")]
		public string QueryRoomSlotId(int index)
		{
			return null;
		}

		// Token: 0x170010AD RID: 4269
		// (get) Token: 0x060099D8 RID: 39384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010AD")]
		public Camera buildingCamera
		{
			[Token(Token = "0x60099D8")]
			[Address(RVA = "0x3139420", Offset = "0x3138020", VA = "0x183139420")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010AE RID: 4270
		// (get) Token: 0x060099D9 RID: 39385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010AE")]
		public HGReflectionShaderProfile reflectShaderProfile
		{
			[Token(Token = "0x60099D9")]
			[Address(RVA = "0x3139DF0", Offset = "0x31389F0", VA = "0x183139DF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060099DA RID: 39386 RVA: 0x0003BBC8 File Offset: 0x00039DC8
		[Token(Token = "0x60099DA")]
		[Address(RVA = "0x31378C0", Offset = "0x31364C0", VA = "0x1831378C0")]
		public static bool IsReflectionEnabled()
		{
			return default(bool);
		}

		// Token: 0x060099DB RID: 39387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099DB")]
		[Address(RVA = "0x3137D20", Offset = "0x3136920", VA = "0x183137D20")]
		public void OnBuildingRouted()
		{
		}

		// Token: 0x060099DC RID: 39388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099DC")]
		[Address(RVA = "0x31366D0", Offset = "0x31352D0", VA = "0x1831366D0")]
		public static void ConfigTopMenuRouteEvents(CommonTopMenu topMenu)
		{
		}

		// Token: 0x060099DD RID: 39389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099DD")]
		[Address(RVA = "0x3136C90", Offset = "0x3135890", VA = "0x183136C90")]
		public void FocusRoomInVault(string slotId)
		{
		}

		// Token: 0x060099DE RID: 39390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099DE")]
		[Address(RVA = "0x3137970", Offset = "0x3136570", VA = "0x183137970")]
		public void OnBackFromFuncFurniturePage(BuildingData.FurnitureSubType subType)
		{
		}

		// Token: 0x060099DF RID: 39391 RVA: 0x0003BBE0 File Offset: 0x00039DE0
		[Token(Token = "0x60099DF")]
		[Address(RVA = "0x31364E0", Offset = "0x31350E0", VA = "0x1831364E0")]
		public bool CallbackPrivateDormOwner(string slotId)
		{
			return default(bool);
		}

		// Token: 0x060099E0 RID: 39392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099E0")]
		[Address(RVA = "0x31389D0", Offset = "0x31375D0", VA = "0x1831389D0")]
		private void _InitStateMachineForCurPlayer()
		{
		}

		// Token: 0x060099E1 RID: 39393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099E1")]
		[Address(RVA = "0x3138720", Offset = "0x3137320", VA = "0x183138720")]
		private void _InitBindTools()
		{
		}

		// Token: 0x060099E2 RID: 39394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099E2")]
		[Address(RVA = "0x3138B40", Offset = "0x3137740", VA = "0x183138B40")]
		private void _InitStateMachineForVisiting()
		{
		}

		// Token: 0x060099E3 RID: 39395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099E3")]
		[Address(RVA = "0x3138CB0", Offset = "0x31378B0", VA = "0x183138CB0")]
		private void _LoadDataForCurPlayer(string layoutId, PlayerBuilding playerData)
		{
		}

		// Token: 0x060099E4 RID: 39396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099E4")]
		[Address(RVA = "0x3138E00", Offset = "0x3137A00", VA = "0x183138E00")]
		private void _LoadDataForVisiting(VisitBuildingResponse response)
		{
		}

		// Token: 0x060099E5 RID: 39397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099E5")]
		[Address(RVA = "0x31384E0", Offset = "0x31370E0", VA = "0x1831384E0")]
		private void _ChangeOperationModeInternal(OperationMode newMode)
		{
		}

		// Token: 0x060099E6 RID: 39398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099E6")]
		[Address(RVA = "0x3136A20", Offset = "0x3135620", VA = "0x183136A20")]
		private void FixedUpdate()
		{
		}

		// Token: 0x060099E7 RID: 39399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099E7")]
		[Address(RVA = "0x3138F50", Offset = "0x3137B50", VA = "0x183138F50")]
		public BuildingController()
		{
		}

		// Token: 0x0400902B RID: 36907
		[Token(Token = "0x400902B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BlueprintMode _blueprintMode;

		// Token: 0x0400902C RID: 36908
		[Token(Token = "0x400902C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BuildingArchitecture _architecture;

		// Token: 0x0400902D RID: 36909
		[Token(Token = "0x400902D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private VaultMode _vaultMode;

		// Token: 0x0400902E RID: 36910
		[Token(Token = "0x400902E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private BuildingModuleHolder _moduleHolder;

		// Token: 0x0400902F RID: 36911
		[Token(Token = "0x400902F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _buildingHolder;

		// Token: 0x04009030 RID: 36912
		[Token(Token = "0x4009030")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private BuildingController.Options _options;

		// Token: 0x04009031 RID: 36913
		[Token(Token = "0x4009031")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool _useMock;

		// Token: 0x04009032 RID: 36914
		[Token(Token = "0x4009032")]
		[FieldOffset(Offset = "0x49")]
		[SerializeField]
		private bool _localTest;

		// Token: 0x04009033 RID: 36915
		[Token(Token = "0x4009033")]
		[FieldOffset(Offset = "0x50")]
		private IDIYFeatureComponents m_diy;

		// Token: 0x04009034 RID: 36916
		[Token(Token = "0x4009034")]
		[FieldOffset(Offset = "0x58")]
		private FurnitureManager m_visitFurnitureManager;

		// Token: 0x04009035 RID: 36917
		[Token(Token = "0x4009035")]
		[FieldOffset(Offset = "0x60")]
		private DIYRoomModifierManager m_visitModifierManager;

		// Token: 0x04009036 RID: 36918
		[Token(Token = "0x4009036")]
		[FieldOffset(Offset = "0x68")]
		private OperationMode m_operationMode;

		// Token: 0x04009037 RID: 36919
		[Token(Token = "0x4009037")]
		[FieldOffset(Offset = "0x70")]
		private BuildingModel m_model;

		// Token: 0x04009038 RID: 36920
		[Token(Token = "0x4009038")]
		[FieldOffset(Offset = "0x78")]
		private BuildingStateMachine m_stateMachine;

		// Token: 0x04009039 RID: 36921
		[Token(Token = "0x4009039")]
		[FieldOffset(Offset = "0x80")]
		private EventPool<BuildingEvent> m_eventPool;

		// Token: 0x0400903A RID: 36922
		[Token(Token = "0x400903A")]
		[FieldOffset(Offset = "0x88")]
		private BuildingModeRaycastManager m_raycastBlockMngr;

		// Token: 0x0400903B RID: 36923
		[Token(Token = "0x400903B")]
		[FieldOffset(Offset = "0x90")]
		private BuildingServiceController m_serviceController;

		// Token: 0x0400903C RID: 36924
		[Token(Token = "0x400903C")]
		[FieldOffset(Offset = "0x98")]
		private HGReflectionShaderProfile m_reflectShaderProfile;

		// Token: 0x0400903D RID: 36925
		[Token(Token = "0x400903D")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_isRefectProfileUnavailable;

		// Token: 0x0400903E RID: 36926
		[Token(Token = "0x400903E")]
		[FieldOffset(Offset = "0xA8")]
		private List<IBuildingBindTools> m_bindTools;

		// Token: 0x0400903F RID: 36927
		[Token(Token = "0x400903F")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_isToDoNotifyOn;

		// Token: 0x04009040 RID: 36928
		[Token(Token = "0x4009040")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isToDoNotifyOn;

		// Token: 0x04009041 RID: 36929
		[Token(Token = "0x4009041")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isToDoNotifyOn;

		// Token: 0x04009042 RID: 36930
		[Token(Token = "0x4009042")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_localTest;

		// Token: 0x04009043 RID: 36931
		[Token(Token = "0x4009043")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_vaultMode;

		// Token: 0x04009044 RID: 36932
		[Token(Token = "0x4009044")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_model;

		// Token: 0x04009045 RID: 36933
		[Token(Token = "0x4009045")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_service;

		// Token: 0x04009046 RID: 36934
		[Token(Token = "0x4009046")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_isEmpty;

		// Token: 0x04009047 RID: 36935
		[Token(Token = "0x4009047")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_options;

		// Token: 0x04009048 RID: 36936
		[Token(Token = "0x4009048")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_eventPool;

		// Token: 0x04009049 RID: 36937
		[Token(Token = "0x4009049")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_diy;

		// Token: 0x0400904A RID: 36938
		[Token(Token = "0x400904A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_furnitureDataProvider;

		// Token: 0x0400904B RID: 36939
		[Token(Token = "0x400904B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_modifierDataProvider;

		// Token: 0x0400904C RID: 36940
		[Token(Token = "0x400904C")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_operationMode;

		// Token: 0x0400904D RID: 36941
		[Token(Token = "0x400904D")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_set_operationMode;

		// Token: 0x0400904E RID: 36942
		[Token(Token = "0x400904E")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_furnitureManager;

		// Token: 0x0400904F RID: 36943
		[Token(Token = "0x400904F")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_DIYRoomModifierManager;

		// Token: 0x04009050 RID: 36944
		[Token(Token = "0x4009050")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_furnitureTypeDB;

		// Token: 0x04009051 RID: 36945
		[Token(Token = "0x4009051")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_DIYRoomInfoManager;

		// Token: 0x04009052 RID: 36946
		[Token(Token = "0x4009052")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_DIYPresetManager;

		// Token: 0x04009053 RID: 36947
		[Token(Token = "0x4009053")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_DIYItemShop;

		// Token: 0x04009054 RID: 36948
		[Token(Token = "0x4009054")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_get_furnitureStorage;

		// Token: 0x04009055 RID: 36949
		[Token(Token = "0x4009055")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_get_furnitureSaver;

		// Token: 0x04009056 RID: 36950
		[Token(Token = "0x4009056")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_get_furnitureGroupDataDB;

		// Token: 0x04009057 RID: 36951
		[Token(Token = "0x4009057")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_get_isModeTransiting;

		// Token: 0x04009058 RID: 36952
		[Token(Token = "0x4009058")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04009059 RID: 36953
		[Token(Token = "0x4009059")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_get_showBuildings;

		// Token: 0x0400905A RID: 36954
		[Token(Token = "0x400905A")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_set_showBuildings;

		// Token: 0x0400905B RID: 36955
		[Token(Token = "0x400905B")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_IsModeBlock;

		// Token: 0x0400905C RID: 36956
		[Token(Token = "0x400905C")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_RMOnly_BlockVaultRaycast;

		// Token: 0x0400905D RID: 36957
		[Token(Token = "0x400905D")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_RMOnly_BlockBlueprintRaycast;

		// Token: 0x0400905E RID: 36958
		[Token(Token = "0x400905E")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_BMOnly_BlockBuildingModeRaycast;

		// Token: 0x0400905F RID: 36959
		[Token(Token = "0x400905F")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_AVGOnly_BlockBuildingModeRaycastForAllModes;

		// Token: 0x04009060 RID: 36960
		[Token(Token = "0x4009060")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_BlockBuildingRaycast;

		// Token: 0x04009061 RID: 36961
		[Token(Token = "0x4009061")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_InitBuildingForCurrentPlayer;

		// Token: 0x04009062 RID: 36962
		[Token(Token = "0x4009062")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_InitBuildingForVisit;

		// Token: 0x04009063 RID: 36963
		[Token(Token = "0x4009063")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_Display;

		// Token: 0x04009064 RID: 36964
		[Token(Token = "0x4009064")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_OnBuildingModeChanged;

		// Token: 0x04009065 RID: 36965
		[Token(Token = "0x4009065")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_ToggleMode;

		// Token: 0x04009066 RID: 36966
		[Token(Token = "0x4009066")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_SwitchMode;

		// Token: 0x04009067 RID: 36967
		[Token(Token = "0x4009067")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_GetBlurBlueprintImage;

		// Token: 0x04009068 RID: 36968
		[Token(Token = "0x4009068")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_GetState;

		// Token: 0x04009069 RID: 36969
		[Token(Token = "0x4009069")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_get_curBuildingMode;

		// Token: 0x0400906A RID: 36970
		[Token(Token = "0x400906A")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_QueryRoomIndex;

		// Token: 0x0400906B RID: 36971
		[Token(Token = "0x400906B")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_QueryRoomSlotId;

		// Token: 0x0400906C RID: 36972
		[Token(Token = "0x400906C")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_get_buildingCamera;

		// Token: 0x0400906D RID: 36973
		[Token(Token = "0x400906D")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_get_reflectShaderProfile;

		// Token: 0x0400906E RID: 36974
		[Token(Token = "0x400906E")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_IsReflectionEnabled;

		// Token: 0x0400906F RID: 36975
		[Token(Token = "0x400906F")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0_OnBuildingRouted;

		// Token: 0x04009070 RID: 36976
		[Token(Token = "0x4009070")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0_ConfigTopMenuRouteEvents;

		// Token: 0x04009071 RID: 36977
		[Token(Token = "0x4009071")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_FocusRoomInVault;

		// Token: 0x04009072 RID: 36978
		[Token(Token = "0x4009072")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0_OnBackFromFuncFurniturePage;

		// Token: 0x04009073 RID: 36979
		[Token(Token = "0x4009073")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0_CallbackPrivateDormOwner;

		// Token: 0x04009074 RID: 36980
		[Token(Token = "0x4009074")]
		[FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0__InitStateMachineForCurPlayer;

		// Token: 0x04009075 RID: 36981
		[Token(Token = "0x4009075")]
		[FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0__InitBindTools;

		// Token: 0x04009076 RID: 36982
		[Token(Token = "0x4009076")]
		[FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0__InitStateMachineForVisiting;

		// Token: 0x04009077 RID: 36983
		[Token(Token = "0x4009077")]
		[FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0__LoadDataForCurPlayer;

		// Token: 0x04009078 RID: 36984
		[Token(Token = "0x4009078")]
		[FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0__LoadDataForVisiting;

		// Token: 0x04009079 RID: 36985
		[Token(Token = "0x4009079")]
		[FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0__ChangeOperationModeInternal;

		// Token: 0x0400907A RID: 36986
		[Token(Token = "0x400907A")]
		[FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0_FixedUpdate;

		// Token: 0x0400907B RID: 36987
		[Token(Token = "0x400907B")]
		[FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020017CA RID: 6090
		[Token(Token = "0x20017CA")]
		[Serializable]
		public class Options
		{
			// Token: 0x060099E8 RID: 39400 RVA: 0x0003BBF8 File Offset: 0x00039DF8
			[Token(Token = "0x60099E8")]
			[Address(RVA = "0x31477C0", Offset = "0x31463C0", VA = "0x1831477C0")]
			public BuildingData.LODLEVEL GetLODLevelByValue(int lodValue)
			{
				return BuildingData.LODLEVEL.HIGHEST;
			}

			// Token: 0x060099E9 RID: 39401 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60099E9")]
			[Address(RVA = "0x31478A0", Offset = "0x31464A0", VA = "0x1831478A0")]
			public Options()
			{
			}

			// Token: 0x0400907C RID: 36988
			[Token(Token = "0x400907C")]
			[FieldOffset(Offset = "0x10")]
			public Vector2[] vaultLODLevels;

			// Token: 0x0400907D RID: 36989
			[Token(Token = "0x400907D")]
			[FieldOffset(Offset = "0x18")]
			public bool enableCharacterSleep;
		}
	}
}
