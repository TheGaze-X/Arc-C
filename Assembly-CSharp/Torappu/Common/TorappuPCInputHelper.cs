using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Resource;
using Torappu.UI;
using UnityEngine;
using UnityEngine.EventSystems;
using XLua;

namespace Torappu.Common
{
	// Token: 0x020016D7 RID: 5847
	[Token(Token = "0x20016D7")]
	public class TorappuPCInputHelper : Singleton<TorappuPCInputHelper>, IPCInputHelper, IDisposable
	{
		// Token: 0x06009413 RID: 37907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009413")]
		[Address(RVA = "0x2B3F400", Offset = "0x2B3E000", VA = "0x182B3F400")]
		private TorappuPCInputHelper()
		{
		}

		// Token: 0x06009414 RID: 37908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009414")]
		[Address(RVA = "0x2B3DCA0", Offset = "0x2B3C8A0", VA = "0x182B3DCA0")]
		public static void Init(bool isInit)
		{
		}

		// Token: 0x06009415 RID: 37909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009415")]
		[Address(RVA = "0x2B3E830", Offset = "0x2B3D430", VA = "0x182B3E830")]
		public static void ResetInputModule(EventSystem eventSystem)
		{
		}

		// Token: 0x06009416 RID: 37910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009416")]
		[Address(RVA = "0x2B3D760", Offset = "0x2B3C360", VA = "0x182B3D760")]
		public void InitModule(bool isInit)
		{
		}

		// Token: 0x06009417 RID: 37911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009417")]
		[Address(RVA = "0x2B3EC50", Offset = "0x2B3D850", VA = "0x182B3EC50")]
		public void UnloadAll()
		{
		}

		// Token: 0x06009418 RID: 37912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009418")]
		[Address(RVA = "0x2B3E5D0", Offset = "0x2B3D1D0", VA = "0x182B3E5D0")]
		public void ReloadAll()
		{
		}

		// Token: 0x06009419 RID: 37913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009419")]
		[Address(RVA = "0x2B3F030", Offset = "0x2B3DC30", VA = "0x182B3F030")]
		private void _ReplaceInputModuleOnEventSystemEnabled(EventSystem eventSystem)
		{
		}

		// Token: 0x0600941A RID: 37914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600941A")]
		[Address(RVA = "0x2B3ED90", Offset = "0x2B3D990", VA = "0x182B3ED90")]
		private void _InitWithEventSystem()
		{
		}

		// Token: 0x0600941B RID: 37915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600941B")]
		[Address(RVA = "0x2B3EF70", Offset = "0x2B3DB70", VA = "0x182B3EF70")]
		private void _RefreshWithInputModule()
		{
		}

		// Token: 0x0600941C RID: 37916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600941C")]
		[Address(RVA = "0x2B3DD30", Offset = "0x2B3C930", VA = "0x182B3DD30", Slot = "4")]
		public void OnProcess()
		{
		}

		// Token: 0x0600941D RID: 37917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600941D")]
		[Address(RVA = "0x2B3E950", Offset = "0x2B3D550", VA = "0x182B3E950")]
		public void TriggerMobileProcess()
		{
		}

		// Token: 0x0600941E RID: 37918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600941E")]
		[Address(RVA = "0x2B3E9B0", Offset = "0x2B3D5B0", VA = "0x182B3E9B0")]
		public void TriggerStandAloneProcess()
		{
		}

		// Token: 0x0600941F RID: 37919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600941F")]
		[Address(RVA = "0x2B3D340", Offset = "0x2B3BF40", VA = "0x182B3D340")]
		public void ClearMouseEvent()
		{
		}

		// Token: 0x06009420 RID: 37920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009420")]
		[Address(RVA = "0x2B3E220", Offset = "0x2B3CE20", VA = "0x182B3E220")]
		public void RegisterMouseEvent(MouseEventType type, Action action)
		{
		}

		// Token: 0x06009421 RID: 37921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009421")]
		[Address(RVA = "0x2B3F320", Offset = "0x2B3DF20", VA = "0x182B3F320")]
		private void _TriggerMouseEvent(MouseEventType type)
		{
		}

		// Token: 0x06009422 RID: 37922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009422")]
		[Address(RVA = "0x2B3F240", Offset = "0x2B3DE40", VA = "0x182B3F240")]
		private void _TriggerKeyProcessOnMobile()
		{
		}

		// Token: 0x06009423 RID: 37923 RVA: 0x00039C90 File Offset: 0x00037E90
		[Token(Token = "0x6009423")]
		[Address(RVA = "0x2B3E190", Offset = "0x2B3CD90", VA = "0x182B3E190", Slot = "5")]
		public int RegisterButton(IPCInputHelper.Input input)
		{
			return 0;
		}

		// Token: 0x06009424 RID: 37924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009424")]
		[Address(RVA = "0x2B3E420", Offset = "0x2B3D020", VA = "0x182B3E420")]
		public void RegisterRaycastRelated(int instId, RectTransform availPart, KeyBoardVirtualButtonEnum buttonEnum, Action<PointerEventData> onKeyPress)
		{
		}

		// Token: 0x06009425 RID: 37925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009425")]
		[Address(RVA = "0x2B3DFE0", Offset = "0x2B3CBE0", VA = "0x182B3DFE0")]
		public void RegisterAlwaysWorkRelated(int instId, KeyBoardVirtualButtonConfig buttonConfig, Action<PointerEventData> onKeyPress, Action<PointerEventData> onKeyRelease, Func<bool> checkAvail)
		{
		}

		// Token: 0x06009426 RID: 37926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009426")]
		[Address(RVA = "0x2B3EAC0", Offset = "0x2B3D6C0", VA = "0x182B3EAC0", Slot = "6")]
		public void UnRegisterInstIdRelatedEntity(int instId)
		{
		}

		// Token: 0x06009427 RID: 37927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009427")]
		[Address(RVA = "0x2B3DE90", Offset = "0x2B3CA90", VA = "0x182B3DE90", Slot = "7")]
		public void OnTouchEventTrigger()
		{
		}

		// Token: 0x06009428 RID: 37928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009428")]
		[Address(RVA = "0x2B3E8C0", Offset = "0x2B3D4C0", VA = "0x182B3E8C0", Slot = "8")]
		public void TriggerFullScreenScrollDelta(PointerEventData eventData)
		{
		}

		// Token: 0x06009429 RID: 37929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009429")]
		[Address(RVA = "0x2B3D3C0", Offset = "0x2B3BFC0", VA = "0x182B3D3C0", Slot = "9")]
		public void Dispose()
		{
		}

		// Token: 0x0600942A RID: 37930 RVA: 0x00039CA8 File Offset: 0x00037EA8
		[Token(Token = "0x600942A")]
		[Address(RVA = "0x2B3D680", Offset = "0x2B3C280", VA = "0x182B3D680")]
		public Vector2 GetNormalizedMousePosition()
		{
			return default(Vector2);
		}

		// Token: 0x040089F8 RID: 35320
		[Token(Token = "0x40089F8")]
		private const int LEFT_BUTTON_CODE = 0;

		// Token: 0x040089F9 RID: 35321
		[Token(Token = "0x40089F9")]
		[FieldOffset(Offset = "0x10")]
		public StandaloneCanvasScaleHelper canvasScaleTool;

		// Token: 0x040089FA RID: 35322
		[Token(Token = "0x40089FA")]
		[FieldOffset(Offset = "0x18")]
		public KeyEntityGroupBase.TorappuKeyBoardLogic keyLogic;

		// Token: 0x040089FB RID: 35323
		[Token(Token = "0x40089FB")]
		[FieldOffset(Offset = "0x20")]
		public PCMouseMgr pcMouseMgrNullable;

		// Token: 0x040089FC RID: 35324
		[Token(Token = "0x40089FC")]
		[FieldOffset(Offset = "0x28")]
		public ResolutionManager resolutionManager;

		// Token: 0x040089FD RID: 35325
		[Token(Token = "0x40089FD")]
		[FieldOffset(Offset = "0x30")]
		private CachedAssetLoader m_selfAssetLoader;

		// Token: 0x040089FE RID: 35326
		[Token(Token = "0x40089FE")]
		[FieldOffset(Offset = "0x38")]
		private TorappuInputModule m_inputModule;

		// Token: 0x040089FF RID: 35327
		[Token(Token = "0x40089FF")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<string, Action> m_mouseEventDict;

		// Token: 0x04008A00 RID: 35328
		[Token(Token = "0x4008A00")]
		[FieldOffset(Offset = "0x48")]
		private TorappuPCInputHelper.TorappuKeyboardTriggerProcessor m_keyboardTriggerProcessor;

		// Token: 0x04008A01 RID: 35329
		[Token(Token = "0x4008A01")]
		[FieldOffset(Offset = "0x50")]
		public Action<PointerEventData> onFullScreenScrollHandler;

		// Token: 0x04008A02 RID: 35330
		[Token(Token = "0x4008A02")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04008A03 RID: 35331
		[Token(Token = "0x4008A03")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04008A04 RID: 35332
		[Token(Token = "0x4008A04")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ResetInputModule;

		// Token: 0x04008A05 RID: 35333
		[Token(Token = "0x4008A05")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_InitModule;

		// Token: 0x04008A06 RID: 35334
		[Token(Token = "0x4008A06")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UnloadAll;

		// Token: 0x04008A07 RID: 35335
		[Token(Token = "0x4008A07")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ReloadAll;

		// Token: 0x04008A08 RID: 35336
		[Token(Token = "0x4008A08")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ReplaceInputModuleOnEventSystemEnabled;

		// Token: 0x04008A09 RID: 35337
		[Token(Token = "0x4008A09")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitWithEventSystem;

		// Token: 0x04008A0A RID: 35338
		[Token(Token = "0x4008A0A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RefreshWithInputModule;

		// Token: 0x04008A0B RID: 35339
		[Token(Token = "0x4008A0B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnProcess;

		// Token: 0x04008A0C RID: 35340
		[Token(Token = "0x4008A0C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_TriggerMobileProcess;

		// Token: 0x04008A0D RID: 35341
		[Token(Token = "0x4008A0D")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_TriggerStandAloneProcess;

		// Token: 0x04008A0E RID: 35342
		[Token(Token = "0x4008A0E")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_ClearMouseEvent;

		// Token: 0x04008A0F RID: 35343
		[Token(Token = "0x4008A0F")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_RegisterMouseEvent;

		// Token: 0x04008A10 RID: 35344
		[Token(Token = "0x4008A10")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__TriggerMouseEvent;

		// Token: 0x04008A11 RID: 35345
		[Token(Token = "0x4008A11")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__TriggerKeyProcessOnMobile;

		// Token: 0x04008A12 RID: 35346
		[Token(Token = "0x4008A12")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_RegisterButton;

		// Token: 0x04008A13 RID: 35347
		[Token(Token = "0x4008A13")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_RegisterRaycastRelated;

		// Token: 0x04008A14 RID: 35348
		[Token(Token = "0x4008A14")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_RegisterAlwaysWorkRelated;

		// Token: 0x04008A15 RID: 35349
		[Token(Token = "0x4008A15")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_UnRegisterInstIdRelatedEntity;

		// Token: 0x04008A16 RID: 35350
		[Token(Token = "0x4008A16")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_OnTouchEventTrigger;

		// Token: 0x04008A17 RID: 35351
		[Token(Token = "0x4008A17")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_TriggerFullScreenScrollDelta;

		// Token: 0x04008A18 RID: 35352
		[Token(Token = "0x4008A18")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_Dispose;

		// Token: 0x04008A19 RID: 35353
		[Token(Token = "0x4008A19")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_GetNormalizedMousePosition;

		// Token: 0x020016D8 RID: 5848
		[Token(Token = "0x20016D8")]
		private class TorappuKeyboardTriggerProcessor : IHotfixable
		{
			// Token: 0x0600942B RID: 37931 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600942B")]
			[Address(RVA = "0x2B3D1B0", Offset = "0x2B3BDB0", VA = "0x182B3D1B0")]
			public TorappuKeyboardTriggerProcessor(TorappuPCInputHelper closure)
			{
			}

			// Token: 0x0600942C RID: 37932 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600942C")]
			[Address(RVA = "0x2B3BEA0", Offset = "0x2B3AAA0", VA = "0x182B3BEA0")]
			public void TriggerKeyProcess()
			{
			}

			// Token: 0x0600942D RID: 37933 RVA: 0x00039CC0 File Offset: 0x00037EC0
			[Token(Token = "0x600942D")]
			[Address(RVA = "0x2B3BB40", Offset = "0x2B3A740", VA = "0x182B3BB40")]
			public int RegisterButton(IPCInputHelper.Input input)
			{
				return 0;
			}

			// Token: 0x0600942E RID: 37934 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600942E")]
			[Address(RVA = "0x2B3BD70", Offset = "0x2B3A970", VA = "0x182B3BD70")]
			public void RegisterRaycastRelated(int instId, RectTransform availPart, KeyBoardVirtualButtonEnum buttonEnum, Action<PointerEventData> onKeyPress)
			{
			}

			// Token: 0x0600942F RID: 37935 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600942F")]
			[Address(RVA = "0x2B3BA10", Offset = "0x2B3A610", VA = "0x182B3BA10")]
			public void RegisterAlwaysWorkRelated(int instId, KeyBoardVirtualButtonConfig buttonConfig, Action<PointerEventData> onKeyPress, Action<PointerEventData> onKeyRelease, Func<bool> checkAvail)
			{
			}

			// Token: 0x06009430 RID: 37936 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009430")]
			[Address(RVA = "0x2B3C680", Offset = "0x2B3B280", VA = "0x182B3C680")]
			public void UnRegisterInstIdRelatedEntity(int instId)
			{
			}

			// Token: 0x06009431 RID: 37937 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009431")]
			[Address(RVA = "0x2B3B900", Offset = "0x2B3A500", VA = "0x182B3B900")]
			public void OnTouchEventTrigger()
			{
			}

			// Token: 0x06009432 RID: 37938 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009432")]
			[Address(RVA = "0x2B3CC80", Offset = "0x2B3B880", VA = "0x182B3CC80")]
			private void _RemoveTargetInstId(int instId, List<TorappuPCInputHelper.TorappuKeyboardTriggerProcessor.KeyBoardButtonEntity> entity)
			{
			}

			// Token: 0x06009433 RID: 37939 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009433")]
			[Address(RVA = "0x2B3CAF0", Offset = "0x2B3B6F0", VA = "0x182B3CAF0")]
			private void _RegisterEntity(TorappuPCInputHelper.TorappuKeyboardTriggerProcessor.KeyBoardButtonEntity entity)
			{
			}

			// Token: 0x06009434 RID: 37940 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009434")]
			[Address(RVA = "0x2B3C490", Offset = "0x2B3B090", VA = "0x182B3C490")]
			public void TriggerVirtualKey(KeyBoardVirtualButtonConfig button, bool isRelease)
			{
			}

			// Token: 0x06009435 RID: 37941 RVA: 0x00039CD8 File Offset: 0x00037ED8
			[Token(Token = "0x6009435")]
			[Address(RVA = "0x2B3CD80", Offset = "0x2B3B980", VA = "0x182B3CD80")]
			private bool _TriggerAvailRaycast(List<TorappuPCInputHelper.TorappuKeyboardTriggerProcessor.KeyBoardButtonEntity> entityList, bool isRelease, ref List<TorappuPCInputHelper.TorappuKeyboardTriggerProcessor.KeyBoardButtonEntity> results)
			{
				return default(bool);
			}

			// Token: 0x06009436 RID: 37942 RVA: 0x00039CF0 File Offset: 0x00037EF0
			[Token(Token = "0x6009436")]
			[Address(RVA = "0x2B3C890", Offset = "0x2B3B490", VA = "0x182B3C890")]
			private bool _CheckTransAvail(RectTransform transform)
			{
				return default(bool);
			}

			// Token: 0x06009437 RID: 37943 RVA: 0x00039D08 File Offset: 0x00037F08
			[Token(Token = "0x6009437")]
			[Address(RVA = "0x2B3C7D0", Offset = "0x2B3B3D0", VA = "0x182B3C7D0")]
			private bool _CheckMouseInTrans(RectTransform transform)
			{
				return default(bool);
			}

			// Token: 0x06009438 RID: 37944 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6009438")]
			[Address(RVA = "0x2B3C960", Offset = "0x2B3B560", VA = "0x182B3C960")]
			private PointerEventData _CreateFakePointEventData()
			{
				return null;
			}

			// Token: 0x04008A1A RID: 35354
			[Token(Token = "0x4008A1A")]
			[FieldOffset(Offset = "0x10")]
			private TorappuPCInputHelper m_closure;

			// Token: 0x04008A1B RID: 35355
			[Token(Token = "0x4008A1B")]
			[FieldOffset(Offset = "0x18")]
			private List<TorappuPCInputHelper.TorappuKeyboardTriggerProcessor.KeyBoardButtonEntity> m_entityList;

			// Token: 0x04008A1C RID: 35356
			[Token(Token = "0x4008A1C")]
			[FieldOffset(Offset = "0x20")]
			private List<KeyBoardVirtualButtonConfig> m_cacheKeyDownList;

			// Token: 0x04008A1D RID: 35357
			[Token(Token = "0x4008A1D")]
			[FieldOffset(Offset = "0x28")]
			private List<TorappuPCInputHelper.TorappuKeyboardTriggerProcessor.KeyBoardButtonEntity> m_targetCacheEntity;

			// Token: 0x04008A1E RID: 35358
			[Token(Token = "0x4008A1E")]
			[FieldOffset(Offset = "0x30")]
			private List<TorappuPCInputHelper.TorappuKeyboardTriggerProcessor.KeyBoardButtonEntity> m_resultCacheEntity;

			// Token: 0x04008A1F RID: 35359
			[Token(Token = "0x4008A1F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04008A20 RID: 35360
			[Token(Token = "0x4008A20")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_TriggerKeyProcess;

			// Token: 0x04008A21 RID: 35361
			[Token(Token = "0x4008A21")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RegisterButton;

			// Token: 0x04008A22 RID: 35362
			[Token(Token = "0x4008A22")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_RegisterRaycastRelated;

			// Token: 0x04008A23 RID: 35363
			[Token(Token = "0x4008A23")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_RegisterAlwaysWorkRelated;

			// Token: 0x04008A24 RID: 35364
			[Token(Token = "0x4008A24")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_UnRegisterInstIdRelatedEntity;

			// Token: 0x04008A25 RID: 35365
			[Token(Token = "0x4008A25")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_OnTouchEventTrigger;

			// Token: 0x04008A26 RID: 35366
			[Token(Token = "0x4008A26")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0__RemoveTargetInstId;

			// Token: 0x04008A27 RID: 35367
			[Token(Token = "0x4008A27")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0__RegisterEntity;

			// Token: 0x04008A28 RID: 35368
			[Token(Token = "0x4008A28")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_TriggerVirtualKey;

			// Token: 0x04008A29 RID: 35369
			[Token(Token = "0x4008A29")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0__TriggerAvailRaycast;

			// Token: 0x04008A2A RID: 35370
			[Token(Token = "0x4008A2A")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0__CheckTransAvail;

			// Token: 0x04008A2B RID: 35371
			[Token(Token = "0x4008A2B")]
			[FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0__CheckMouseInTrans;

			// Token: 0x04008A2C RID: 35372
			[Token(Token = "0x4008A2C")]
			[FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0__CreateFakePointEventData;

			// Token: 0x020016D9 RID: 5849
			[Token(Token = "0x20016D9")]
			public class KeyBoardButtonEntity
			{
				// Token: 0x06009439 RID: 37945 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6009439")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public KeyBoardButtonEntity()
				{
				}

				// Token: 0x04008A2D RID: 35373
				[Token(Token = "0x4008A2D")]
				[FieldOffset(Offset = "0x10")]
				public int instId;

				// Token: 0x04008A2E RID: 35374
				[Token(Token = "0x4008A2E")]
				[FieldOffset(Offset = "0x18")]
				public RectTransform targetTrans;

				// Token: 0x04008A2F RID: 35375
				[Token(Token = "0x4008A2F")]
				[FieldOffset(Offset = "0x20")]
				public RectTransform enableTrans;

				// Token: 0x04008A30 RID: 35376
				[Token(Token = "0x4008A30")]
				[FieldOffset(Offset = "0x28")]
				public KeyBoardVirtualButtonConfig buttonConfig;

				// Token: 0x04008A31 RID: 35377
				[Token(Token = "0x4008A31")]
				[FieldOffset(Offset = "0x30")]
				public Func<bool> checkAvail;

				// Token: 0x04008A32 RID: 35378
				[Token(Token = "0x4008A32")]
				[FieldOffset(Offset = "0x38")]
				public Action<PointerEventData> onKeyPress;

				// Token: 0x04008A33 RID: 35379
				[Token(Token = "0x4008A33")]
				[FieldOffset(Offset = "0x40")]
				public Action<PointerEventData> onKeyRelease;

				// Token: 0x04008A34 RID: 35380
				[Token(Token = "0x4008A34")]
				[FieldOffset(Offset = "0x48")]
				public int canvasSortingLayer;

				// Token: 0x04008A35 RID: 35381
				[Token(Token = "0x4008A35")]
				[FieldOffset(Offset = "0x4C")]
				public int canvasSortingOrder;

				// Token: 0x04008A36 RID: 35382
				[Token(Token = "0x4008A36")]
				[FieldOffset(Offset = "0x50")]
				public int siblingIndex;
			}
		}
	}
}
