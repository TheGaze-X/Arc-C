using System;
using System.Runtime.InteropServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003784 RID: 14212
	[Token(Token = "0x2003784")]
	public class DragAndPinchWithTargetContext : DragAndPinchContext
	{
		// Token: 0x17003600 RID: 13824
		// (get) Token: 0x060168DE RID: 92382 RVA: 0x00091B18 File Offset: 0x0008FD18
		[Token(Token = "0x17003600")]
		public override int maxTouchCount
		{
			[Token(Token = "0x60168DE")]
			[Address(RVA = "0xEF64F0", Offset = "0xEF50F0", VA = "0x180EF64F0", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003601 RID: 13825
		// (get) Token: 0x060168DF RID: 92383 RVA: 0x00091B30 File Offset: 0x0008FD30
		[Token(Token = "0x17003601")]
		public override TouchHandler.CreateTouchType createTouchType
		{
			[Token(Token = "0x60168DF")]
			[Address(RVA = "0xEF6370", Offset = "0xEF4F70", VA = "0x180EF6370", Slot = "4")]
			get
			{
				return TouchHandler.CreateTouchType.CREATE_ON_DRAG_BEGIN;
			}
		}

		// Token: 0x17003602 RID: 13826
		// (get) Token: 0x060168E0 RID: 92384 RVA: 0x00091B48 File Offset: 0x0008FD48
		[Token(Token = "0x17003602")]
		public bool isInteracting
		{
			[Token(Token = "0x60168E0")]
			[Address(RVA = "0xEF6490", Offset = "0xEF5090", VA = "0x180EF6490")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003603 RID: 13827
		// (get) Token: 0x060168E1 RID: 92385 RVA: 0x00091B60 File Offset: 0x0008FD60
		[Token(Token = "0x17003603")]
		public bool isDraggingOrPinching
		{
			[Token(Token = "0x60168E1")]
			[Address(RVA = "0xEF63D0", Offset = "0xEF4FD0", VA = "0x180EF63D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060168E2 RID: 92386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60168E2")]
		[Address(RVA = "0xEF4950", Offset = "0xEF3550", VA = "0x180EF4950")]
		public void Init(DragAndPinchWithTargetContext.InitOptions options)
		{
		}

		// Token: 0x060168E3 RID: 92387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60168E3")]
		[Address(RVA = "0xEF5170", Offset = "0xEF3D70", VA = "0x180EF5170")]
		public void SetTarget(DragAndPinchWithTargetContext.TargetOptions options)
		{
		}

		// Token: 0x060168E4 RID: 92388 RVA: 0x00091B78 File Offset: 0x0008FD78
		[Token(Token = "0x60168E4")]
		[Address(RVA = "0xEF5320", Offset = "0xEF3F20", VA = "0x180EF5320", Slot = "14")]
		protected sealed override bool TouchSessionCreateInternal()
		{
			return default(bool);
		}

		// Token: 0x060168E5 RID: 92389 RVA: 0x00091B90 File Offset: 0x0008FD90
		[Token(Token = "0x60168E5")]
		[Address(RVA = "0xEF53D0", Offset = "0xEF3FD0", VA = "0x180EF53D0", Slot = "15")]
		protected sealed override bool TouchSessionUpdateInternal()
		{
			return default(bool);
		}

		// Token: 0x060168E6 RID: 92390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60168E6")]
		[Address(RVA = "0xEF5250", Offset = "0xEF3E50", VA = "0x180EF5250", Slot = "16")]
		protected sealed override void TouchSessionClearInternal()
		{
		}

		// Token: 0x060168E7 RID: 92391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60168E7")]
		[Address(RVA = "0xEF5460", Offset = "0xEF4060", VA = "0x180EF5460")]
		private void _CheckAndTriggerBounceBack()
		{
		}

		// Token: 0x060168E8 RID: 92392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60168E8")]
		[Address(RVA = "0xEF6180", Offset = "0xEF4D80", VA = "0x180EF6180")]
		private void _TriggerLastDragOrPinchStopped()
		{
		}

		// Token: 0x060168E9 RID: 92393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60168E9")]
		[Address(RVA = "0xEF5EF0", Offset = "0xEF4AF0", VA = "0x180EF5EF0")]
		private void _OnDragStart(DragAndPinchContext.DraggingStatus draggingStatus)
		{
		}

		// Token: 0x060168EA RID: 92394 RVA: 0x00091BA8 File Offset: 0x0008FDA8
		[Token(Token = "0x60168EA")]
		[Address(RVA = "0xEF45E0", Offset = "0xEF31E0", VA = "0x180EF45E0", Slot = "17")]
		protected sealed override bool DragStartInternal(DragAndPinchContext.DraggingStatus draggingStatus)
		{
			return default(bool);
		}

		// Token: 0x060168EB RID: 92395 RVA: 0x00091BC0 File Offset: 0x0008FDC0
		[Token(Token = "0x60168EB")]
		[Address(RVA = "0xEF4740", Offset = "0xEF3340", VA = "0x180EF4740", Slot = "18")]
		protected sealed override bool DragUpdateInternal(DragAndPinchContext.DraggingStatus draggingStatus)
		{
			return default(bool);
		}

		// Token: 0x060168EC RID: 92396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60168EC")]
		[Address(RVA = "0xEF4550", Offset = "0xEF3150", VA = "0x180EF4550", Slot = "19")]
		protected sealed override void DragClearInternal()
		{
		}

		// Token: 0x060168ED RID: 92397 RVA: 0x00091BD8 File Offset: 0x0008FDD8
		[Token(Token = "0x60168ED")]
		[Address(RVA = "0xEF4E00", Offset = "0xEF3A00", VA = "0x180EF4E00", Slot = "20")]
		protected sealed override bool PinchStartInternal(DragAndPinchContext.PinchingStatus pinchingStatus)
		{
			return default(bool);
		}

		// Token: 0x060168EE RID: 92398 RVA: 0x00091BF0 File Offset: 0x0008FDF0
		[Token(Token = "0x60168EE")]
		[Address(RVA = "0xEF4EB0", Offset = "0xEF3AB0", VA = "0x180EF4EB0", Slot = "21")]
		protected sealed override bool PinchUpdateInternal(DragAndPinchContext.PinchingStatus pinchingStatus)
		{
			return default(bool);
		}

		// Token: 0x060168EF RID: 92399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60168EF")]
		[Address(RVA = "0xEF4D70", Offset = "0xEF3970", VA = "0x180EF4D70", Slot = "22")]
		protected sealed override void PinchClearInternal()
		{
		}

		// Token: 0x060168F0 RID: 92400 RVA: 0x00091C08 File Offset: 0x0008FE08
		[Token(Token = "0x60168F0")]
		[Address(RVA = "0xEF5BC0", Offset = "0xEF47C0", VA = "0x180EF5BC0")]
		private bool _CheckNeedBounceBack(Vector2 anchoredPosition, float scale, out Vector2 targetAnchoredPosition, out float targetScale)
		{
			return default(bool);
		}

		// Token: 0x060168F1 RID: 92401 RVA: 0x00091C20 File Offset: 0x0008FE20
		[Token(Token = "0x60168F1")]
		[Address(RVA = "0xEF5DA0", Offset = "0xEF49A0", VA = "0x180EF5DA0")]
		private bool _IsSessionValid()
		{
			return default(bool);
		}

		// Token: 0x060168F2 RID: 92402 RVA: 0x00091C38 File Offset: 0x0008FE38
		[Token(Token = "0x60168F2")]
		[Address(RVA = "0xEF5E30", Offset = "0xEF4A30", VA = "0x180EF5E30")]
		private bool _IsTargetValid()
		{
			return default(bool);
		}

		// Token: 0x060168F3 RID: 92403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60168F3")]
		[Address(RVA = "0xEF60F0", Offset = "0xEF4CF0", VA = "0x180EF60F0")]
		private void _OnPotentialDragOrPinchRecognized()
		{
		}

		// Token: 0x060168F4 RID: 92404 RVA: 0x00091C50 File Offset: 0x0008FE50
		[Token(Token = "0x60168F4")]
		[Address(RVA = "0xEF5A00", Offset = "0xEF4600", VA = "0x180EF5A00")]
		private bool _CheckDragOrPinchStartAndConsume([Optional] Action callback)
		{
			return default(bool);
		}

		// Token: 0x060168F5 RID: 92405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60168F5")]
		[Address(RVA = "0xEF5FE0", Offset = "0xEF4BE0", VA = "0x180EF5FE0")]
		private void _OnFirstDragOrPinchStarted()
		{
		}

		// Token: 0x060168F6 RID: 92406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60168F6")]
		[Address(RVA = "0xEF4C50", Offset = "0xEF3850", VA = "0x180EF4C50", Slot = "23")]
		protected virtual void OnPotentialDragOrPinchRecognized()
		{
		}

		// Token: 0x060168F7 RID: 92407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60168F7")]
		[Address(RVA = "0xEF4B90", Offset = "0xEF3790", VA = "0x180EF4B90", Slot = "24")]
		protected virtual void OnFirstDragOrPinchStarted()
		{
		}

		// Token: 0x060168F8 RID: 92408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60168F8")]
		[Address(RVA = "0xEF4BF0", Offset = "0xEF37F0", VA = "0x180EF4BF0", Slot = "25")]
		protected virtual void OnLastDragOrPinchStopped()
		{
		}

		// Token: 0x060168F9 RID: 92409 RVA: 0x00091C68 File Offset: 0x0008FE68
		[Token(Token = "0x60168F9")]
		[Address(RVA = "0xEF4CB0", Offset = "0xEF38B0", VA = "0x180EF4CB0", Slot = "26")]
		protected virtual bool OnTouchSessionCreate()
		{
			return default(bool);
		}

		// Token: 0x060168FA RID: 92410 RVA: 0x00091C80 File Offset: 0x0008FE80
		[Token(Token = "0x60168FA")]
		[Address(RVA = "0xEF4D10", Offset = "0xEF3910", VA = "0x180EF4D10", Slot = "27")]
		protected virtual bool OnTouchSessionUpdate()
		{
			return default(bool);
		}

		// Token: 0x060168FB RID: 92411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60168FB")]
		[Address(RVA = "0xEF6260", Offset = "0xEF4E60", VA = "0x180EF6260")]
		public DragAndPinchWithTargetContext()
		{
		}

		// Token: 0x060168FC RID: 92412 RVA: 0x00091C98 File Offset: 0x0008FE98
		[Token(Token = "0x60168FC")]
		[Address(RVA = "0xEF3A90", Offset = "0xEF2690", VA = "0x180EF3A90")]
		private bool <>xLuaBaseProxy_TouchSessionCreateInternal()
		{
			return default(bool);
		}

		// Token: 0x060168FD RID: 92413 RVA: 0x00091CB0 File Offset: 0x0008FEB0
		[Token(Token = "0x60168FD")]
		[Address(RVA = "0xEF3B90", Offset = "0xEF2790", VA = "0x180EF3B90")]
		private bool <>xLuaBaseProxy_TouchSessionUpdateInternal()
		{
			return default(bool);
		}

		// Token: 0x060168FE RID: 92414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60168FE")]
		[Address(RVA = "0xEF39A0", Offset = "0xEF25A0", VA = "0x180EF39A0")]
		private void <>xLuaBaseProxy_TouchSessionClearInternal()
		{
		}

		// Token: 0x060168FF RID: 92415 RVA: 0x00091CC8 File Offset: 0x0008FEC8
		[Token(Token = "0x60168FF")]
		[Address(RVA = "0xEF30F0", Offset = "0xEF1CF0", VA = "0x180EF30F0")]
		private bool <>xLuaBaseProxy_DragStartInternal(DragAndPinchContext.DraggingStatus P0)
		{
			return default(bool);
		}

		// Token: 0x06016900 RID: 92416 RVA: 0x00091CE0 File Offset: 0x0008FEE0
		[Token(Token = "0x6016900")]
		[Address(RVA = "0xEF3170", Offset = "0xEF1D70", VA = "0x180EF3170")]
		private bool <>xLuaBaseProxy_DragUpdateInternal(DragAndPinchContext.DraggingStatus P0)
		{
			return default(bool);
		}

		// Token: 0x06016901 RID: 92417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016901")]
		[Address(RVA = "0xEF3090", Offset = "0xEF1C90", VA = "0x180EF3090")]
		private void <>xLuaBaseProxy_DragClearInternal()
		{
		}

		// Token: 0x06016902 RID: 92418 RVA: 0x00091CF8 File Offset: 0x0008FEF8
		[Token(Token = "0x6016902")]
		[Address(RVA = "0xEF3650", Offset = "0xEF2250", VA = "0x180EF3650")]
		private bool <>xLuaBaseProxy_PinchStartInternal(DragAndPinchContext.PinchingStatus P0)
		{
			return default(bool);
		}

		// Token: 0x06016903 RID: 92419 RVA: 0x00091D10 File Offset: 0x0008FF10
		[Token(Token = "0x6016903")]
		[Address(RVA = "0xEF36C0", Offset = "0xEF22C0", VA = "0x180EF36C0")]
		private bool <>xLuaBaseProxy_PinchUpdateInternal(DragAndPinchContext.PinchingStatus P0)
		{
			return default(bool);
		}

		// Token: 0x06016904 RID: 92420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016904")]
		[Address(RVA = "0xEF35F0", Offset = "0xEF21F0", VA = "0x180EF35F0")]
		private void <>xLuaBaseProxy_PinchClearInternal()
		{
		}

		// Token: 0x0401B2E9 RID: 111337
		[Token(Token = "0x401B2E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private DragAndPinchWithTargetContext.InitOptions m_initOptions;

		// Token: 0x0401B2EA RID: 111338
		[Token(Token = "0x401B2EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private DragAndPinchWithTargetContext.TargetOptions m_latestTargetOptions;

		// Token: 0x0401B2EB RID: 111339
		[Token(Token = "0x401B2EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private DragAndPinchWithTargetContext.SessionStatus m_currSessionStatus;

		// Token: 0x0401B2EC RID: 111340
		[Token(Token = "0x401B2EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private DragAndPinchWithTargetContext.IBoundaryHandler m_boundaryHandler;

		// Token: 0x0401B2ED RID: 111341
		[Token(Token = "0x401B2ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Tween m_bouncingTween;

		// Token: 0x0401B2EE RID: 111342
		[Token(Token = "0x401B2EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_maxTouchCount;

		// Token: 0x0401B2EF RID: 111343
		[Token(Token = "0x401B2EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_createTouchType;

		// Token: 0x0401B2F0 RID: 111344
		[Token(Token = "0x401B2F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isInteracting;

		// Token: 0x0401B2F1 RID: 111345
		[Token(Token = "0x401B2F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_isDraggingOrPinching;

		// Token: 0x0401B2F2 RID: 111346
		[Token(Token = "0x401B2F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0401B2F3 RID: 111347
		[Token(Token = "0x401B2F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SetTarget;

		// Token: 0x0401B2F4 RID: 111348
		[Token(Token = "0x401B2F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_TouchSessionCreateInternal;

		// Token: 0x0401B2F5 RID: 111349
		[Token(Token = "0x401B2F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_TouchSessionUpdateInternal;

		// Token: 0x0401B2F6 RID: 111350
		[Token(Token = "0x401B2F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_TouchSessionClearInternal;

		// Token: 0x0401B2F7 RID: 111351
		[Token(Token = "0x401B2F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CheckAndTriggerBounceBack;

		// Token: 0x0401B2F8 RID: 111352
		[Token(Token = "0x401B2F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__TriggerLastDragOrPinchStopped;

		// Token: 0x0401B2F9 RID: 111353
		[Token(Token = "0x401B2F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnDragStart;

		// Token: 0x0401B2FA RID: 111354
		[Token(Token = "0x401B2FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_DragStartInternal;

		// Token: 0x0401B2FB RID: 111355
		[Token(Token = "0x401B2FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_DragUpdateInternal;

		// Token: 0x0401B2FC RID: 111356
		[Token(Token = "0x401B2FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_DragClearInternal;

		// Token: 0x0401B2FD RID: 111357
		[Token(Token = "0x401B2FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_PinchStartInternal;

		// Token: 0x0401B2FE RID: 111358
		[Token(Token = "0x401B2FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_PinchUpdateInternal;

		// Token: 0x0401B2FF RID: 111359
		[Token(Token = "0x401B2FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_PinchClearInternal;

		// Token: 0x0401B300 RID: 111360
		[Token(Token = "0x401B300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__CheckNeedBounceBack;

		// Token: 0x0401B301 RID: 111361
		[Token(Token = "0x401B301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__IsSessionValid;

		// Token: 0x0401B302 RID: 111362
		[Token(Token = "0x401B302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__IsTargetValid;

		// Token: 0x0401B303 RID: 111363
		[Token(Token = "0x401B303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__OnPotentialDragOrPinchRecognized;

		// Token: 0x0401B304 RID: 111364
		[Token(Token = "0x401B304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__CheckDragOrPinchStartAndConsume;

		// Token: 0x0401B305 RID: 111365
		[Token(Token = "0x401B305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__OnFirstDragOrPinchStarted;

		// Token: 0x0401B306 RID: 111366
		[Token(Token = "0x401B306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_OnPotentialDragOrPinchRecognized;

		// Token: 0x0401B307 RID: 111367
		[Token(Token = "0x401B307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_OnFirstDragOrPinchStarted;

		// Token: 0x0401B308 RID: 111368
		[Token(Token = "0x401B308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_OnLastDragOrPinchStopped;

		// Token: 0x0401B309 RID: 111369
		[Token(Token = "0x401B309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_OnTouchSessionCreate;

		// Token: 0x0401B30A RID: 111370
		[Token(Token = "0x401B30A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_OnTouchSessionUpdate;

		// Token: 0x0401B30B RID: 111371
		[Token(Token = "0x401B30B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003785 RID: 14213
		[Token(Token = "0x2003785")]
		private enum DragOrPinchStatus
		{
			// Token: 0x0401B30D RID: 111373
			[Token(Token = "0x401B30D")]
			NONE,
			// Token: 0x0401B30E RID: 111374
			[Token(Token = "0x401B30E")]
			POTENTIAL_DRAG_OR_PINCH_RECOGNIZED,
			// Token: 0x0401B30F RID: 111375
			[Token(Token = "0x401B30F")]
			DRAG_OR_PINCH_STARTED,
			// Token: 0x0401B310 RID: 111376
			[Token(Token = "0x401B310")]
			BOUNCING_BACK
		}

		// Token: 0x02003786 RID: 14214
		[Token(Token = "0x2003786")]
		public enum BoundaryType
		{
			// Token: 0x0401B312 RID: 111378
			[Token(Token = "0x401B312")]
			NONE,
			// Token: 0x0401B313 RID: 111379
			[Token(Token = "0x401B313")]
			BOUNDARY_AS_CONTAINER,
			// Token: 0x0401B314 RID: 111380
			[Token(Token = "0x401B314")]
			BOUNDARY_AS_VIEWPORT
		}

		// Token: 0x02003787 RID: 14215
		[Token(Token = "0x2003787")]
		private struct SessionStatus
		{
			// Token: 0x0401B315 RID: 111381
			[Token(Token = "0x401B315")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly DragAndPinchWithTargetContext.SessionStatus EMPTY;

			// Token: 0x0401B316 RID: 111382
			[Token(Token = "0x401B316")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public DragAndPinchWithTargetContext.DragOrPinchStatus status;

			// Token: 0x0401B317 RID: 111383
			[Token(Token = "0x401B317")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public bool dragOrPinchStartInvoked;

			// Token: 0x0401B318 RID: 111384
			[Token(Token = "0x401B318")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Vector2 dragStartPos;

			// Token: 0x0401B319 RID: 111385
			[Token(Token = "0x401B319")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector2 targetDragStartPos;

			// Token: 0x0401B31A RID: 111386
			[Token(Token = "0x401B31A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string currSessionTargetKey;

			// Token: 0x0401B31B RID: 111387
			[Token(Token = "0x401B31B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DragAndPinchWithTargetContext.IDragAndPinchTarget currSessionTarget;

			// Token: 0x0401B31C RID: 111388
			[Token(Token = "0x401B31C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float currSessionMinScale;

			// Token: 0x0401B31D RID: 111389
			[Token(Token = "0x401B31D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float currSessionMaxScale;
		}

		// Token: 0x02003788 RID: 14216
		[Token(Token = "0x2003788")]
		public struct InitOptions
		{
			// Token: 0x0401B31E RID: 111390
			[Token(Token = "0x401B31E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly DragAndPinchWithTargetContext.InitOptions DEFAULT;

			// Token: 0x0401B31F RID: 111391
			[Token(Token = "0x401B31F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RectTransform containerRect;

			// Token: 0x0401B320 RID: 111392
			[Token(Token = "0x401B320")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public RectTransform boundaryRect;

			// Token: 0x0401B321 RID: 111393
			[Token(Token = "0x401B321")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DragAndPinchWithTargetContext.BoundaryType boundaryType;

			// Token: 0x0401B322 RID: 111394
			[Token(Token = "0x401B322")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public DragAndPinchContext.ScrollOptions scrollOptions;

			// Token: 0x0401B323 RID: 111395
			[Token(Token = "0x401B323")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool enableBouncingBack;

			// Token: 0x0401B324 RID: 111396
			[Token(Token = "0x401B324")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float bounceBackDuration;

			// Token: 0x0401B325 RID: 111397
			[Token(Token = "0x401B325")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Ease bounceBackEase;

			// Token: 0x0401B326 RID: 111398
			[Token(Token = "0x401B326")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float bounceBoundaryMargin;

			// Token: 0x0401B327 RID: 111399
			[Token(Token = "0x401B327")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float bounceScaleRatio;
		}

		// Token: 0x02003789 RID: 14217
		[Token(Token = "0x2003789")]
		public struct TargetOptions
		{
			// Token: 0x0401B328 RID: 111400
			[Token(Token = "0x401B328")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly DragAndPinchWithTargetContext.TargetOptions EMPTY;

			// Token: 0x0401B329 RID: 111401
			[Token(Token = "0x401B329")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float minScale;

			// Token: 0x0401B32A RID: 111402
			[Token(Token = "0x401B32A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float maxScale;

			// Token: 0x0401B32B RID: 111403
			[Token(Token = "0x401B32B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public DragAndPinchWithTargetContext.IDragAndPinchTarget target;
		}

		// Token: 0x0200378A RID: 14218
		[Token(Token = "0x200378A")]
		public interface IDragAndPinchTarget
		{
			// Token: 0x17003604 RID: 13828
			// (get) Token: 0x06016908 RID: 92424
			[Token(Token = "0x17003604")]
			Vector2 standardSizeDelta { [Token(Token = "0x6016908")] get; }

			// Token: 0x17003605 RID: 13829
			// (get) Token: 0x06016909 RID: 92425
			// (set) Token: 0x0601690A RID: 92426
			[Token(Token = "0x17003605")]
			Vector2 anchoredPosition { [Token(Token = "0x6016909")] get; [Token(Token = "0x601690A")] set; }

			// Token: 0x17003606 RID: 13830
			// (get) Token: 0x0601690B RID: 92427
			// (set) Token: 0x0601690C RID: 92428
			[Token(Token = "0x17003606")]
			float scale { [Token(Token = "0x601690B")] get; [Token(Token = "0x601690C")] set; }

			// Token: 0x17003607 RID: 13831
			// (get) Token: 0x0601690D RID: 92429
			[Token(Token = "0x17003607")]
			string key { [Token(Token = "0x601690D")] get; }
		}

		// Token: 0x0200378B RID: 14219
		[Token(Token = "0x200378B")]
		private interface IBoundaryHandler : IHotfixable
		{
			// Token: 0x0601690E RID: 92430
			[Token(Token = "0x601690E")]
			Vector2 ClampTargetAnchoredPos(Vector2 anchoredPosition);

			// Token: 0x0601690F RID: 92431
			[Token(Token = "0x601690F")]
			float ClampTargetScale(float scale);

			// Token: 0x06016910 RID: 92432
			[Token(Token = "0x6016910")]
			bool CheckNeedBounceBack(Vector2 anchoredPosition, float scale, out Vector2 targetAnchoredPosition, out float targetScale);
		}

		// Token: 0x0200378C RID: 14220
		[Token(Token = "0x200378C")]
		private class BoundaryAsContainerHandler : DragAndPinchWithTargetContext.IBoundaryHandler, IHotfixable
		{
			// Token: 0x06016911 RID: 92433 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016911")]
			[Address(RVA = "0xEF14F0", Offset = "0xEF00F0", VA = "0x180EF14F0")]
			public BoundaryAsContainerHandler(DragAndPinchWithTargetContext closure)
			{
			}

			// Token: 0x06016912 RID: 92434 RVA: 0x00091D28 File Offset: 0x0008FF28
			[Token(Token = "0x6016912")]
			[Address(RVA = "0xEF1000", Offset = "0xEEFC00", VA = "0x180EF1000", Slot = "4")]
			public Vector2 ClampTargetAnchoredPos(Vector2 anchoredPosition)
			{
				return default(Vector2);
			}

			// Token: 0x06016913 RID: 92435 RVA: 0x00091D40 File Offset: 0x0008FF40
			[Token(Token = "0x6016913")]
			[Address(RVA = "0xEF1370", Offset = "0xEEFF70", VA = "0x180EF1370", Slot = "5")]
			public float ClampTargetScale(float scale)
			{
				return 0f;
			}

			// Token: 0x06016914 RID: 92436 RVA: 0x00091D58 File Offset: 0x0008FF58
			[Token(Token = "0x6016914")]
			[Address(RVA = "0xEF0BD0", Offset = "0xEEF7D0", VA = "0x180EF0BD0", Slot = "6")]
			public bool CheckNeedBounceBack(Vector2 anchoredPosition, float scale, out Vector2 targetAnchoredPosition, out float targetScale)
			{
				return default(bool);
			}

			// Token: 0x0401B32C RID: 111404
			[Token(Token = "0x401B32C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private DragAndPinchWithTargetContext m_closure;

			// Token: 0x0401B32D RID: 111405
			[Token(Token = "0x401B32D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401B32E RID: 111406
			[Token(Token = "0x401B32E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ClampTargetAnchoredPos;

			// Token: 0x0401B32F RID: 111407
			[Token(Token = "0x401B32F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_ClampTargetScale;

			// Token: 0x0401B330 RID: 111408
			[Token(Token = "0x401B330")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_CheckNeedBounceBack;
		}

		// Token: 0x0200378D RID: 14221
		[Token(Token = "0x200378D")]
		private class BoundaryAsViewportHandler : DragAndPinchWithTargetContext.IBoundaryHandler, IHotfixable
		{
			// Token: 0x06016915 RID: 92437 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016915")]
			[Address(RVA = "0xEF1F20", Offset = "0xEF0B20", VA = "0x180EF1F20")]
			public BoundaryAsViewportHandler(DragAndPinchWithTargetContext closure)
			{
			}

			// Token: 0x06016916 RID: 92438 RVA: 0x00091D70 File Offset: 0x0008FF70
			[Token(Token = "0x6016916")]
			[Address(RVA = "0xEF19E0", Offset = "0xEF05E0", VA = "0x180EF19E0", Slot = "4")]
			public Vector2 ClampTargetAnchoredPos(Vector2 anchoredPosition)
			{
				return default(Vector2);
			}

			// Token: 0x06016917 RID: 92439 RVA: 0x00091D88 File Offset: 0x0008FF88
			[Token(Token = "0x6016917")]
			[Address(RVA = "0xEF1DA0", Offset = "0xEF09A0", VA = "0x180EF1DA0", Slot = "5")]
			public float ClampTargetScale(float scale)
			{
				return 0f;
			}

			// Token: 0x06016918 RID: 92440 RVA: 0x00091DA0 File Offset: 0x0008FFA0
			[Token(Token = "0x6016918")]
			[Address(RVA = "0xEF1570", Offset = "0xEF0170", VA = "0x180EF1570", Slot = "6")]
			public bool CheckNeedBounceBack(Vector2 anchoredPosition, float scale, out Vector2 targetAnchoredPosition, out float targetScale)
			{
				return default(bool);
			}

			// Token: 0x0401B331 RID: 111409
			[Token(Token = "0x401B331")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private DragAndPinchWithTargetContext m_closure;

			// Token: 0x0401B332 RID: 111410
			[Token(Token = "0x401B332")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401B333 RID: 111411
			[Token(Token = "0x401B333")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ClampTargetAnchoredPos;

			// Token: 0x0401B334 RID: 111412
			[Token(Token = "0x401B334")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_ClampTargetScale;

			// Token: 0x0401B335 RID: 111413
			[Token(Token = "0x401B335")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_CheckNeedBounceBack;
		}
	}
}
