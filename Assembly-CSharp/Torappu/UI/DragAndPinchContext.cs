using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200377A RID: 14202
	[Token(Token = "0x200377A")]
	public abstract class DragAndPinchContext : TouchHandler.TouchContext
	{
		// Token: 0x170035FD RID: 13821
		// (get) Token: 0x060168AA RID: 92330 RVA: 0x00091920 File Offset: 0x0008FB20
		[Token(Token = "0x170035FD")]
		protected DragAndPinchContext.HandlerType currHandlerType
		{
			[Token(Token = "0x60168AA")]
			[Address(RVA = "0xEF4400", Offset = "0xEF3000", VA = "0x180EF4400")]
			get
			{
				return DragAndPinchContext.HandlerType.NONE;
			}
		}

		// Token: 0x060168AB RID: 92331 RVA: 0x00091938 File Offset: 0x0008FB38
		[Token(Token = "0x60168AB")]
		[Address(RVA = "0xEF4070", Offset = "0xEF2C70", VA = "0x180EF4070")]
		private bool _IsSessionValid()
		{
			return default(bool);
		}

		// Token: 0x060168AC RID: 92332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60168AC")]
		[Address(RVA = "0xEF3D00", Offset = "0xEF2900", VA = "0x180EF3D00")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060168AD RID: 92333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60168AD")]
		[Address(RVA = "0xEF41F0", Offset = "0xEF2DF0", VA = "0x180EF41F0")]
		private void _SetHandler(DragAndPinchContext.HandlerType handlerType)
		{
		}

		// Token: 0x060168AE RID: 92334 RVA: 0x00091950 File Offset: 0x0008FB50
		[Token(Token = "0x60168AE")]
		[Address(RVA = "0xEF3AF0", Offset = "0xEF26F0", VA = "0x180EF3AF0", Slot = "10")]
		public sealed override bool TouchSessionCreate()
		{
			return default(bool);
		}

		// Token: 0x060168AF RID: 92335 RVA: 0x00091968 File Offset: 0x0008FB68
		[Token(Token = "0x60168AF")]
		[Address(RVA = "0xEF3BF0", Offset = "0xEF27F0", VA = "0x180EF3BF0", Slot = "11")]
		public sealed override bool TouchSessionUpdate()
		{
			return default(bool);
		}

		// Token: 0x060168B0 RID: 92336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60168B0")]
		[Address(RVA = "0xEF3A00", Offset = "0xEF2600", VA = "0x180EF3A00", Slot = "12")]
		public sealed override void TouchSessionClear()
		{
		}

		// Token: 0x060168B1 RID: 92337 RVA: 0x00091980 File Offset: 0x0008FB80
		[Token(Token = "0x60168B1")]
		[Address(RVA = "0xEF3830", Offset = "0xEF2430", VA = "0x180EF3830", Slot = "6")]
		public sealed override bool TouchCreate(int pointerId, ValueBundle param)
		{
			return default(bool);
		}

		// Token: 0x060168B2 RID: 92338 RVA: 0x00091998 File Offset: 0x0008FB98
		[Token(Token = "0x60168B2")]
		[Address(RVA = "0xEF3900", Offset = "0xEF2500", VA = "0x180EF3900", Slot = "7")]
		public sealed override bool TouchMove(int pointerId)
		{
			return default(bool);
		}

		// Token: 0x060168B3 RID: 92339 RVA: 0x000919B0 File Offset: 0x0008FBB0
		[Token(Token = "0x60168B3")]
		[Address(RVA = "0xEF3C90", Offset = "0xEF2890", VA = "0x180EF3C90", Slot = "8")]
		public sealed override bool TouchUpdate(int pointerId)
		{
			return default(bool);
		}

		// Token: 0x060168B4 RID: 92340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60168B4")]
		[Address(RVA = "0xEF37C0", Offset = "0xEF23C0", VA = "0x180EF37C0", Slot = "9")]
		public sealed override void TouchClear(int pointerId)
		{
		}

		// Token: 0x060168B5 RID: 92341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60168B5")]
		[Address(RVA = "0xEF40E0", Offset = "0xEF2CE0", VA = "0x180EF40E0")]
		private void _RefreshCurrHandler()
		{
		}

		// Token: 0x060168B6 RID: 92342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60168B6")]
		[Address(RVA = "0xEF3730", Offset = "0xEF2330", VA = "0x180EF3730")]
		protected void SetScrollOptions(DragAndPinchContext.ScrollOptions options)
		{
		}

		// Token: 0x060168B7 RID: 92343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60168B7")]
		[Address(RVA = "0xEF31F0", Offset = "0xEF1DF0", VA = "0x180EF31F0", Slot = "13")]
		public sealed override void OnScrollInternal(Vector2 scrollDelta, ValueBundle param)
		{
		}

		// Token: 0x060168B8 RID: 92344 RVA: 0x000919C8 File Offset: 0x0008FBC8
		[Token(Token = "0x60168B8")]
		[Address(RVA = "0xEF3A90", Offset = "0xEF2690", VA = "0x180EF3A90", Slot = "14")]
		protected virtual bool TouchSessionCreateInternal()
		{
			return default(bool);
		}

		// Token: 0x060168B9 RID: 92345 RVA: 0x000919E0 File Offset: 0x0008FBE0
		[Token(Token = "0x60168B9")]
		[Address(RVA = "0xEF3B90", Offset = "0xEF2790", VA = "0x180EF3B90", Slot = "15")]
		protected virtual bool TouchSessionUpdateInternal()
		{
			return default(bool);
		}

		// Token: 0x060168BA RID: 92346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60168BA")]
		[Address(RVA = "0xEF39A0", Offset = "0xEF25A0", VA = "0x180EF39A0", Slot = "16")]
		protected virtual void TouchSessionClearInternal()
		{
		}

		// Token: 0x060168BB RID: 92347 RVA: 0x000919F8 File Offset: 0x0008FBF8
		[Token(Token = "0x60168BB")]
		[Address(RVA = "0xEF30F0", Offset = "0xEF1CF0", VA = "0x180EF30F0", Slot = "17")]
		protected virtual bool DragStartInternal(DragAndPinchContext.DraggingStatus draggingStatus)
		{
			return default(bool);
		}

		// Token: 0x060168BC RID: 92348 RVA: 0x00091A10 File Offset: 0x0008FC10
		[Token(Token = "0x60168BC")]
		[Address(RVA = "0xEF3170", Offset = "0xEF1D70", VA = "0x180EF3170", Slot = "18")]
		protected virtual bool DragUpdateInternal(DragAndPinchContext.DraggingStatus draggingStatus)
		{
			return default(bool);
		}

		// Token: 0x060168BD RID: 92349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60168BD")]
		[Address(RVA = "0xEF3090", Offset = "0xEF1C90", VA = "0x180EF3090", Slot = "19")]
		protected virtual void DragClearInternal()
		{
		}

		// Token: 0x060168BE RID: 92350 RVA: 0x00091A28 File Offset: 0x0008FC28
		[Token(Token = "0x60168BE")]
		[Address(RVA = "0xEF3650", Offset = "0xEF2250", VA = "0x180EF3650", Slot = "20")]
		protected virtual bool PinchStartInternal(DragAndPinchContext.PinchingStatus pinchingStatus)
		{
			return default(bool);
		}

		// Token: 0x060168BF RID: 92351 RVA: 0x00091A40 File Offset: 0x0008FC40
		[Token(Token = "0x60168BF")]
		[Address(RVA = "0xEF36C0", Offset = "0xEF22C0", VA = "0x180EF36C0", Slot = "21")]
		protected virtual bool PinchUpdateInternal(DragAndPinchContext.PinchingStatus pinchingStatus)
		{
			return default(bool);
		}

		// Token: 0x060168C0 RID: 92352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60168C0")]
		[Address(RVA = "0xEF35F0", Offset = "0xEF21F0", VA = "0x180EF35F0", Slot = "22")]
		protected virtual void PinchClearInternal()
		{
		}

		// Token: 0x060168C1 RID: 92353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60168C1")]
		[Address(RVA = "0xEF4390", Offset = "0xEF2F90", VA = "0x180EF4390")]
		protected DragAndPinchContext()
		{
		}

		// Token: 0x0401B298 RID: 111256
		[Token(Token = "0x401B298")]
		[FieldOffset(Offset = "0x18")]
		private bool m_inited;

		// Token: 0x0401B299 RID: 111257
		[Token(Token = "0x401B299")]
		[FieldOffset(Offset = "0x20")]
		private DragAndPinchContext.Handler m_currHandler;

		// Token: 0x0401B29A RID: 111258
		[Token(Token = "0x401B29A")]
		[FieldOffset(Offset = "0x28")]
		private DragAndPinchContext.StayingHandler m_stayingHandler;

		// Token: 0x0401B29B RID: 111259
		[Token(Token = "0x401B29B")]
		[FieldOffset(Offset = "0x30")]
		private DragAndPinchContext.DraggingHandler m_draggingHandler;

		// Token: 0x0401B29C RID: 111260
		[Token(Token = "0x401B29C")]
		[FieldOffset(Offset = "0x38")]
		private DragAndPinchContext.PinchingHandler m_pinchingHandler;

		// Token: 0x0401B29D RID: 111261
		[Token(Token = "0x401B29D")]
		private const float SCROLL_START_DISTANCE = 1f;

		// Token: 0x0401B29E RID: 111262
		[Token(Token = "0x401B29E")]
		[FieldOffset(Offset = "0x40")]
		private float m_currDistance;

		// Token: 0x0401B29F RID: 111263
		[Token(Token = "0x401B29F")]
		[FieldOffset(Offset = "0x44")]
		private float m_targetDistance;

		// Token: 0x0401B2A0 RID: 111264
		[Token(Token = "0x401B2A0")]
		[FieldOffset(Offset = "0x48")]
		private DragAndPinchContext.ScrollOptions m_scrollOptions;

		// Token: 0x0401B2A1 RID: 111265
		[Token(Token = "0x401B2A1")]
		[FieldOffset(Offset = "0x58")]
		private Tween m_scrollTween;

		// Token: 0x0401B2A2 RID: 111266
		[Token(Token = "0x401B2A2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_currHandlerType;

		// Token: 0x0401B2A3 RID: 111267
		[Token(Token = "0x401B2A3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__IsSessionValid;

		// Token: 0x0401B2A4 RID: 111268
		[Token(Token = "0x401B2A4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401B2A5 RID: 111269
		[Token(Token = "0x401B2A5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SetHandler;

		// Token: 0x0401B2A6 RID: 111270
		[Token(Token = "0x401B2A6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_TouchSessionCreate;

		// Token: 0x0401B2A7 RID: 111271
		[Token(Token = "0x401B2A7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_TouchSessionUpdate;

		// Token: 0x0401B2A8 RID: 111272
		[Token(Token = "0x401B2A8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_TouchSessionClear;

		// Token: 0x0401B2A9 RID: 111273
		[Token(Token = "0x401B2A9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_TouchCreate;

		// Token: 0x0401B2AA RID: 111274
		[Token(Token = "0x401B2AA")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_TouchMove;

		// Token: 0x0401B2AB RID: 111275
		[Token(Token = "0x401B2AB")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_TouchUpdate;

		// Token: 0x0401B2AC RID: 111276
		[Token(Token = "0x401B2AC")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_TouchClear;

		// Token: 0x0401B2AD RID: 111277
		[Token(Token = "0x401B2AD")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__RefreshCurrHandler;

		// Token: 0x0401B2AE RID: 111278
		[Token(Token = "0x401B2AE")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_SetScrollOptions;

		// Token: 0x0401B2AF RID: 111279
		[Token(Token = "0x401B2AF")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnScrollInternal;

		// Token: 0x0401B2B0 RID: 111280
		[Token(Token = "0x401B2B0")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_TouchSessionCreateInternal;

		// Token: 0x0401B2B1 RID: 111281
		[Token(Token = "0x401B2B1")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_TouchSessionUpdateInternal;

		// Token: 0x0401B2B2 RID: 111282
		[Token(Token = "0x401B2B2")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_TouchSessionClearInternal;

		// Token: 0x0401B2B3 RID: 111283
		[Token(Token = "0x401B2B3")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_DragStartInternal;

		// Token: 0x0401B2B4 RID: 111284
		[Token(Token = "0x401B2B4")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_DragUpdateInternal;

		// Token: 0x0401B2B5 RID: 111285
		[Token(Token = "0x401B2B5")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_DragClearInternal;

		// Token: 0x0401B2B6 RID: 111286
		[Token(Token = "0x401B2B6")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_PinchStartInternal;

		// Token: 0x0401B2B7 RID: 111287
		[Token(Token = "0x401B2B7")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_PinchUpdateInternal;

		// Token: 0x0401B2B8 RID: 111288
		[Token(Token = "0x401B2B8")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_PinchClearInternal;

		// Token: 0x0401B2B9 RID: 111289
		[Token(Token = "0x401B2B9")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200377B RID: 14203
		[Token(Token = "0x200377B")]
		protected enum HandlerType
		{
			// Token: 0x0401B2BB RID: 111291
			[Token(Token = "0x401B2BB")]
			NONE,
			// Token: 0x0401B2BC RID: 111292
			[Token(Token = "0x401B2BC")]
			STAYING,
			// Token: 0x0401B2BD RID: 111293
			[Token(Token = "0x401B2BD")]
			DRAGGING,
			// Token: 0x0401B2BE RID: 111294
			[Token(Token = "0x401B2BE")]
			PINCHING
		}

		// Token: 0x0200377C RID: 14204
		[Token(Token = "0x200377C")]
		private abstract class Handler : IHotfixable
		{
			// Token: 0x170035FE RID: 13822
			// (get) Token: 0x060168C2 RID: 92354 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060168C3 RID: 92355 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170035FE")]
			private protected DragAndPinchContext closure
			{
				[Token(Token = "0x60168C2")]
				[Address(RVA = "0xEF8A00", Offset = "0xEF7600", VA = "0x180EF8A00")]
				[CompilerGenerated]
				protected get
				{
					return null;
				}
				[Token(Token = "0x60168C3")]
				[Address(RVA = "0xEF8B10", Offset = "0xEF7710", VA = "0x180EF8B10")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170035FF RID: 13823
			// (get) Token: 0x060168C4 RID: 92356 RVA: 0x00091A58 File Offset: 0x0008FC58
			// (set) Token: 0x060168C5 RID: 92357 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170035FF")]
			public DragAndPinchContext.HandlerType handlerType
			{
				[Token(Token = "0x60168C4")]
				[Address(RVA = "0xEF8A60", Offset = "0xEF7660", VA = "0x180EF8A60")]
				[CompilerGenerated]
				get
				{
					return DragAndPinchContext.HandlerType.NONE;
				}
				[Token(Token = "0x60168C5")]
				[Address(RVA = "0xEF8B90", Offset = "0xEF7790", VA = "0x180EF8B90")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x060168C6 RID: 92358 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60168C6")]
			[Address(RVA = "0xEF8830", Offset = "0xEF7430", VA = "0x180EF8830")]
			protected Handler(DragAndPinchContext closure, DragAndPinchContext.HandlerType handlerType)
			{
			}

			// Token: 0x060168C7 RID: 92359
			[Token(Token = "0x60168C7")]
			public abstract bool OnEnter(DragAndPinchContext.HandlerType lastHandlerType);

			// Token: 0x060168C8 RID: 92360
			[Token(Token = "0x60168C8")]
			public abstract bool OnUpdate();

			// Token: 0x060168C9 RID: 92361
			[Token(Token = "0x60168C9")]
			public abstract void OnExit();

			// Token: 0x0401B2C1 RID: 111297
			[Token(Token = "0x401B2C1")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_closure;

			// Token: 0x0401B2C2 RID: 111298
			[Token(Token = "0x401B2C2")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_closure;

			// Token: 0x0401B2C3 RID: 111299
			[Token(Token = "0x401B2C3")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_handlerType;

			// Token: 0x0401B2C4 RID: 111300
			[Token(Token = "0x401B2C4")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_handlerType;

			// Token: 0x0401B2C5 RID: 111301
			[Token(Token = "0x401B2C5")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200377D RID: 14205
		[Token(Token = "0x200377D")]
		private class StayingHandler : DragAndPinchContext.Handler
		{
			// Token: 0x060168CA RID: 92362 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60168CA")]
			[Address(RVA = "0xEFC960", Offset = "0xEFB560", VA = "0x180EFC960")]
			public StayingHandler(DragAndPinchContext closure, DragAndPinchContext.HandlerType handlerType)
			{
			}

			// Token: 0x060168CB RID: 92363 RVA: 0x00091A70 File Offset: 0x0008FC70
			[Token(Token = "0x60168CB")]
			[Address(RVA = "0xEFC6B0", Offset = "0xEFB2B0", VA = "0x180EFC6B0", Slot = "4")]
			public override bool OnEnter(DragAndPinchContext.HandlerType lastHandlerType)
			{
				return default(bool);
			}

			// Token: 0x060168CC RID: 92364 RVA: 0x00091A88 File Offset: 0x0008FC88
			[Token(Token = "0x60168CC")]
			[Address(RVA = "0xEFC880", Offset = "0xEFB480", VA = "0x180EFC880", Slot = "5")]
			public override bool OnUpdate()
			{
				return default(bool);
			}

			// Token: 0x060168CD RID: 92365 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60168CD")]
			[Address(RVA = "0xEFC820", Offset = "0xEFB420", VA = "0x180EFC820", Slot = "6")]
			public override void OnExit()
			{
			}

			// Token: 0x0401B2C6 RID: 111302
			[Token(Token = "0x401B2C6")]
			[FieldOffset(Offset = "0x20")]
			private int m_pointerId;

			// Token: 0x0401B2C7 RID: 111303
			[Token(Token = "0x401B2C7")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401B2C8 RID: 111304
			[Token(Token = "0x401B2C8")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnEnter;

			// Token: 0x0401B2C9 RID: 111305
			[Token(Token = "0x401B2C9")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OnUpdate;

			// Token: 0x0401B2CA RID: 111306
			[Token(Token = "0x401B2CA")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnExit;
		}

		// Token: 0x0200377E RID: 14206
		[Token(Token = "0x200377E")]
		public struct DraggingStatus
		{
			// Token: 0x0401B2CB RID: 111307
			[Token(Token = "0x401B2CB")]
			[FieldOffset(Offset = "0x0")]
			public static readonly DragAndPinchContext.DraggingStatus EMPTY;

			// Token: 0x0401B2CC RID: 111308
			[Token(Token = "0x401B2CC")]
			[FieldOffset(Offset = "0x0")]
			public Vector2 dragStartPos;

			// Token: 0x0401B2CD RID: 111309
			[Token(Token = "0x401B2CD")]
			[FieldOffset(Offset = "0x8")]
			public Vector2 dragCurrPos;

			// Token: 0x0401B2CE RID: 111310
			[Token(Token = "0x401B2CE")]
			[FieldOffset(Offset = "0x10")]
			public Vector2 dragStartScreenPos;

			// Token: 0x0401B2CF RID: 111311
			[Token(Token = "0x401B2CF")]
			[FieldOffset(Offset = "0x18")]
			public Vector2 dragCurrScreenPos;
		}

		// Token: 0x0200377F RID: 14207
		[Token(Token = "0x200377F")]
		private class DraggingHandler : DragAndPinchContext.Handler
		{
			// Token: 0x060168CF RID: 92367 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60168CF")]
			[Address(RVA = "0xEF6FE0", Offset = "0xEF5BE0", VA = "0x180EF6FE0")]
			public DraggingHandler(DragAndPinchContext closure, DragAndPinchContext.HandlerType handlerType)
			{
			}

			// Token: 0x060168D0 RID: 92368 RVA: 0x00091AA0 File Offset: 0x0008FCA0
			[Token(Token = "0x60168D0")]
			[Address(RVA = "0xEF6760", Offset = "0xEF5360", VA = "0x180EF6760", Slot = "4")]
			public override bool OnEnter(DragAndPinchContext.HandlerType lastHandlerType)
			{
				return default(bool);
			}

			// Token: 0x060168D1 RID: 92369 RVA: 0x00091AB8 File Offset: 0x0008FCB8
			[Token(Token = "0x60168D1")]
			[Address(RVA = "0xEF6CE0", Offset = "0xEF58E0", VA = "0x180EF6CE0", Slot = "5")]
			public override bool OnUpdate()
			{
				return default(bool);
			}

			// Token: 0x060168D2 RID: 92370 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60168D2")]
			[Address(RVA = "0xEF6B90", Offset = "0xEF5790", VA = "0x180EF6B90", Slot = "6")]
			public override void OnExit()
			{
			}

			// Token: 0x0401B2D0 RID: 111312
			[Token(Token = "0x401B2D0")]
			private const float OFFSET_DECREASE_SPEED = 0.16666667f;

			// Token: 0x0401B2D1 RID: 111313
			[Token(Token = "0x401B2D1")]
			[FieldOffset(Offset = "0x20")]
			private int m_pointerId;

			// Token: 0x0401B2D2 RID: 111314
			[Token(Token = "0x401B2D2")]
			[FieldOffset(Offset = "0x24")]
			private int m_tickCountSinceDragStart;

			// Token: 0x0401B2D3 RID: 111315
			[Token(Token = "0x401B2D3")]
			[FieldOffset(Offset = "0x28")]
			private Vector2 m_dragStartScreenOffset;

			// Token: 0x0401B2D4 RID: 111316
			[Token(Token = "0x401B2D4")]
			[FieldOffset(Offset = "0x30")]
			private DragAndPinchContext.DraggingStatus m_draggingStatus;

			// Token: 0x0401B2D5 RID: 111317
			[Token(Token = "0x401B2D5")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401B2D6 RID: 111318
			[Token(Token = "0x401B2D6")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnEnter;

			// Token: 0x0401B2D7 RID: 111319
			[Token(Token = "0x401B2D7")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OnUpdate;

			// Token: 0x0401B2D8 RID: 111320
			[Token(Token = "0x401B2D8")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnExit;
		}

		// Token: 0x02003780 RID: 14208
		[Token(Token = "0x2003780")]
		public struct PinchingStatus
		{
			// Token: 0x0401B2D9 RID: 111321
			[Token(Token = "0x401B2D9")]
			[FieldOffset(Offset = "0x0")]
			public static readonly DragAndPinchContext.PinchingStatus EMPTY;

			// Token: 0x0401B2DA RID: 111322
			[Token(Token = "0x401B2DA")]
			[FieldOffset(Offset = "0x0")]
			public float pinchLastDistance;

			// Token: 0x0401B2DB RID: 111323
			[Token(Token = "0x401B2DB")]
			[FieldOffset(Offset = "0x4")]
			public float pinchCurrDistance;
		}

		// Token: 0x02003781 RID: 14209
		[Token(Token = "0x2003781")]
		private class PinchingHandler : DragAndPinchContext.Handler
		{
			// Token: 0x060168D4 RID: 92372 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60168D4")]
			[Address(RVA = "0xEFB370", Offset = "0xEF9F70", VA = "0x180EFB370")]
			public PinchingHandler(DragAndPinchContext closure, DragAndPinchContext.HandlerType handlerType)
			{
			}

			// Token: 0x060168D5 RID: 92373 RVA: 0x00091AD0 File Offset: 0x0008FCD0
			[Token(Token = "0x60168D5")]
			[Address(RVA = "0xEFADC0", Offset = "0xEF99C0", VA = "0x180EFADC0", Slot = "4")]
			public override bool OnEnter(DragAndPinchContext.HandlerType lastHandlerType)
			{
				return default(bool);
			}

			// Token: 0x060168D6 RID: 92374 RVA: 0x00091AE8 File Offset: 0x0008FCE8
			[Token(Token = "0x60168D6")]
			[Address(RVA = "0xEFB160", Offset = "0xEF9D60", VA = "0x180EFB160", Slot = "5")]
			public override bool OnUpdate()
			{
				return default(bool);
			}

			// Token: 0x060168D7 RID: 92375 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60168D7")]
			[Address(RVA = "0xEFB040", Offset = "0xEF9C40", VA = "0x180EFB040", Slot = "6")]
			public override void OnExit()
			{
			}

			// Token: 0x0401B2DC RID: 111324
			[Token(Token = "0x401B2DC")]
			[FieldOffset(Offset = "0x20")]
			private int m_pointerId0;

			// Token: 0x0401B2DD RID: 111325
			[Token(Token = "0x401B2DD")]
			[FieldOffset(Offset = "0x24")]
			private int m_pointerId1;

			// Token: 0x0401B2DE RID: 111326
			[Token(Token = "0x401B2DE")]
			[FieldOffset(Offset = "0x28")]
			private DragAndPinchContext.PinchingStatus m_pinchingStatus;

			// Token: 0x0401B2DF RID: 111327
			[Token(Token = "0x401B2DF")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401B2E0 RID: 111328
			[Token(Token = "0x401B2E0")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnEnter;

			// Token: 0x0401B2E1 RID: 111329
			[Token(Token = "0x401B2E1")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OnUpdate;

			// Token: 0x0401B2E2 RID: 111330
			[Token(Token = "0x401B2E2")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnExit;
		}

		// Token: 0x02003782 RID: 14210
		[Token(Token = "0x2003782")]
		public struct ScrollOptions
		{
			// Token: 0x0401B2E3 RID: 111331
			[Token(Token = "0x401B2E3")]
			[FieldOffset(Offset = "0x0")]
			public static readonly DragAndPinchContext.ScrollOptions DEFAULT;

			// Token: 0x0401B2E4 RID: 111332
			[Token(Token = "0x401B2E4")]
			[FieldOffset(Offset = "0x0")]
			public float scrollSensitivity;

			// Token: 0x0401B2E5 RID: 111333
			[Token(Token = "0x401B2E5")]
			[FieldOffset(Offset = "0x4")]
			public Ease scrollTweenEase;

			// Token: 0x0401B2E6 RID: 111334
			[Token(Token = "0x401B2E6")]
			[FieldOffset(Offset = "0x8")]
			public float scrollTweenDuration;
		}
	}
}
