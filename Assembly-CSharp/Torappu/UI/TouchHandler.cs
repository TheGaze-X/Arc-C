using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020037CA RID: 14282
	[Token(Token = "0x20037CA")]
	public abstract class TouchHandler : IHotfixable
	{
		// Token: 0x1700362C RID: 13868
		// (get) Token: 0x06016A48 RID: 92744
		[Token(Token = "0x1700362C")]
		protected abstract TouchHandler.CreateTouchType createTouchType { [Token(Token = "0x6016A48")] get; }

		// Token: 0x1700362D RID: 13869
		// (get) Token: 0x06016A49 RID: 92745
		[Token(Token = "0x1700362D")]
		protected abstract int maxTouchCount { [Token(Token = "0x6016A49")] get; }

		// Token: 0x06016A4A RID: 92746
		[Token(Token = "0x6016A4A")]
		protected abstract bool TouchCreateInternal(int pointerId, ValueBundle param);

		// Token: 0x06016A4B RID: 92747
		[Token(Token = "0x6016A4B")]
		protected abstract bool TouchMoveInternal(int pointerId);

		// Token: 0x06016A4C RID: 92748
		[Token(Token = "0x6016A4C")]
		protected abstract bool TouchUpdateInternal(int pointerId);

		// Token: 0x06016A4D RID: 92749
		[Token(Token = "0x6016A4D")]
		protected abstract void TouchClearInternal(int pointerId);

		// Token: 0x06016A4E RID: 92750
		[Token(Token = "0x6016A4E")]
		protected abstract bool TouchSessionCreateInternal();

		// Token: 0x06016A4F RID: 92751
		[Token(Token = "0x6016A4F")]
		protected abstract bool TouchSessionUpdateInternal();

		// Token: 0x06016A50 RID: 92752
		[Token(Token = "0x6016A50")]
		protected abstract void TouchSessionClearInternal();

		// Token: 0x06016A51 RID: 92753
		[Token(Token = "0x6016A51")]
		protected abstract void OnScrollInternal(Vector2 scrollDelta, ValueBundle param);

		// Token: 0x06016A52 RID: 92754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A52")]
		[Address(RVA = "0xF0BE20", Offset = "0xF0AA20", VA = "0x180F0BE20")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06016A53 RID: 92755 RVA: 0x000921A8 File Offset: 0x000903A8
		[Token(Token = "0x6016A53")]
		[Address(RVA = "0xF0BEF0", Offset = "0xF0AAF0", VA = "0x180F0BEF0")]
		private bool _IsValid()
		{
			return default(bool);
		}

		// Token: 0x06016A54 RID: 92756 RVA: 0x000921C0 File Offset: 0x000903C0
		[Token(Token = "0x6016A54")]
		[Address(RVA = "0xF0BC60", Offset = "0xF0A860", VA = "0x180F0BC60")]
		private static bool _GetLocalCursorPoint(int pointerId, RectTransform local, Camera cam, out Vector2 screenPos, out Vector2 localPos)
		{
			return default(bool);
		}

		// Token: 0x06016A55 RID: 92757 RVA: 0x000921D8 File Offset: 0x000903D8
		[Token(Token = "0x6016A55")]
		[Address(RVA = "0xF0C560", Offset = "0xF0B160", VA = "0x180F0C560")]
		private TouchHandler.TouchStatus _TouchStatusCreate(PointerEventData eventData)
		{
			return default(TouchHandler.TouchStatus);
		}

		// Token: 0x06016A56 RID: 92758 RVA: 0x000921F0 File Offset: 0x000903F0
		[Token(Token = "0x6016A56")]
		[Address(RVA = "0xF0C0A0", Offset = "0xF0ACA0", VA = "0x180F0C0A0")]
		private bool _TouchCreate(PointerEventData eventData, ValueBundle param)
		{
			return default(bool);
		}

		// Token: 0x06016A57 RID: 92759 RVA: 0x00092208 File Offset: 0x00090408
		[Token(Token = "0x6016A57")]
		[Address(RVA = "0xF0C3D0", Offset = "0xF0AFD0", VA = "0x180F0C3D0")]
		private bool _TouchMove(PointerEventData eventData)
		{
			return default(bool);
		}

		// Token: 0x06016A58 RID: 92760 RVA: 0x00092220 File Offset: 0x00090420
		[Token(Token = "0x6016A58")]
		[Address(RVA = "0xF0C7A0", Offset = "0xF0B3A0", VA = "0x180F0C7A0")]
		private bool _TouchUpdate(int pointerId)
		{
			return default(bool);
		}

		// Token: 0x06016A59 RID: 92761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A59")]
		[Address(RVA = "0xF0BFC0", Offset = "0xF0ABC0", VA = "0x180F0BFC0")]
		private void _TouchClear(int pointerId)
		{
		}

		// Token: 0x06016A5A RID: 92762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A5A")]
		[Address(RVA = "0xF0BB40", Offset = "0xF0A740", VA = "0x180F0BB40")]
		private void _CreateTouch(PointerEventData eventData, ValueBundle param)
		{
		}

		// Token: 0x06016A5B RID: 92763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A5B")]
		[Address(RVA = "0xF0B600", Offset = "0xF0A200", VA = "0x180F0B600")]
		public void OnPointerDown(PointerEventData eventData, ValueBundle param)
		{
		}

		// Token: 0x06016A5C RID: 92764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A5C")]
		[Address(RVA = "0xF0B3B0", Offset = "0xF09FB0", VA = "0x180F0B3B0")]
		public void OnBeginDrag(PointerEventData eventData, ValueBundle param)
		{
		}

		// Token: 0x06016A5D RID: 92765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A5D")]
		[Address(RVA = "0xF0B6E0", Offset = "0xF0A2E0", VA = "0x180F0B6E0")]
		public void OnScroll(Vector2 scrollDelta, ValueBundle param)
		{
		}

		// Token: 0x06016A5E RID: 92766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A5E")]
		[Address(RVA = "0xF0B960", Offset = "0xF0A560", VA = "0x180F0B960")]
		public void Tick()
		{
		}

		// Token: 0x06016A5F RID: 92767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A5F")]
		[Address(RVA = "0xF0B8D0", Offset = "0xF0A4D0", VA = "0x180F0B8D0")]
		public void SetOptions(TouchHandler.Options options)
		{
		}

		// Token: 0x06016A60 RID: 92768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A60")]
		[Address(RVA = "0xF0B860", Offset = "0xF0A460", VA = "0x180F0B860")]
		public void SetInteractable(bool isInteractable)
		{
		}

		// Token: 0x06016A61 RID: 92769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A61")]
		[Address(RVA = "0xF0C920", Offset = "0xF0B520", VA = "0x180F0C920")]
		protected TouchHandler()
		{
		}

		// Token: 0x0401B4BE RID: 111806
		[Token(Token = "0x401B4BE")]
		[FieldOffset(Offset = "0x10")]
		private Camera m_eventCamera;

		// Token: 0x0401B4BF RID: 111807
		[Token(Token = "0x401B4BF")]
		[FieldOffset(Offset = "0x18")]
		private RectTransform m_eventRectTransform;

		// Token: 0x0401B4C0 RID: 111808
		[Token(Token = "0x401B4C0")]
		[FieldOffset(Offset = "0x20")]
		private TouchHandler.TouchGroup m_touchGroup;

		// Token: 0x0401B4C1 RID: 111809
		[Token(Token = "0x401B4C1")]
		[FieldOffset(Offset = "0x28")]
		private TouchHandler.CreateTouchType m_createTouchType;

		// Token: 0x0401B4C2 RID: 111810
		[Token(Token = "0x401B4C2")]
		[FieldOffset(Offset = "0x2C")]
		private bool m_inited;

		// Token: 0x0401B4C3 RID: 111811
		[Token(Token = "0x401B4C3")]
		[FieldOffset(Offset = "0x2D")]
		private bool m_interactable;

		// Token: 0x0401B4C4 RID: 111812
		[Token(Token = "0x401B4C4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401B4C5 RID: 111813
		[Token(Token = "0x401B4C5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__IsValid;

		// Token: 0x0401B4C6 RID: 111814
		[Token(Token = "0x401B4C6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetLocalCursorPoint;

		// Token: 0x0401B4C7 RID: 111815
		[Token(Token = "0x401B4C7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__TouchStatusCreate;

		// Token: 0x0401B4C8 RID: 111816
		[Token(Token = "0x401B4C8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TouchCreate;

		// Token: 0x0401B4C9 RID: 111817
		[Token(Token = "0x401B4C9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TouchMove;

		// Token: 0x0401B4CA RID: 111818
		[Token(Token = "0x401B4CA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__TouchUpdate;

		// Token: 0x0401B4CB RID: 111819
		[Token(Token = "0x401B4CB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__TouchClear;

		// Token: 0x0401B4CC RID: 111820
		[Token(Token = "0x401B4CC")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CreateTouch;

		// Token: 0x0401B4CD RID: 111821
		[Token(Token = "0x401B4CD")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnPointerDown;

		// Token: 0x0401B4CE RID: 111822
		[Token(Token = "0x401B4CE")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnBeginDrag;

		// Token: 0x0401B4CF RID: 111823
		[Token(Token = "0x401B4CF")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnScroll;

		// Token: 0x0401B4D0 RID: 111824
		[Token(Token = "0x401B4D0")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_Tick;

		// Token: 0x0401B4D1 RID: 111825
		[Token(Token = "0x401B4D1")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_SetOptions;

		// Token: 0x0401B4D2 RID: 111826
		[Token(Token = "0x401B4D2")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_SetInteractable;

		// Token: 0x0401B4D3 RID: 111827
		[Token(Token = "0x401B4D3")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020037CB RID: 14283
		[Token(Token = "0x20037CB")]
		public enum CreateTouchType
		{
			// Token: 0x0401B4D5 RID: 111829
			[Token(Token = "0x401B4D5")]
			CREATE_ON_DRAG_BEGIN,
			// Token: 0x0401B4D6 RID: 111830
			[Token(Token = "0x401B4D6")]
			CREATE_ON_POINTER_DOWN
		}

		// Token: 0x020037CC RID: 14284
		[Token(Token = "0x20037CC")]
		public struct TouchStatus
		{
			// Token: 0x0401B4D7 RID: 111831
			[Token(Token = "0x401B4D7")]
			[FieldOffset(Offset = "0x0")]
			public static readonly TouchHandler.TouchStatus EMPTY;

			// Token: 0x0401B4D8 RID: 111832
			[Token(Token = "0x401B4D8")]
			[FieldOffset(Offset = "0x0")]
			public int pointerId;

			// Token: 0x0401B4D9 RID: 111833
			[Token(Token = "0x401B4D9")]
			[FieldOffset(Offset = "0x4")]
			public bool isTouching;

			// Token: 0x0401B4DA RID: 111834
			[Token(Token = "0x401B4DA")]
			[FieldOffset(Offset = "0x5")]
			public bool isMoving;

			// Token: 0x0401B4DB RID: 111835
			[Token(Token = "0x401B4DB")]
			[FieldOffset(Offset = "0x8")]
			public Vector2 touchStartPos;

			// Token: 0x0401B4DC RID: 111836
			[Token(Token = "0x401B4DC")]
			[FieldOffset(Offset = "0x10")]
			public Vector2 touchCurrPos;

			// Token: 0x0401B4DD RID: 111837
			[Token(Token = "0x401B4DD")]
			[FieldOffset(Offset = "0x18")]
			public Vector2 touchStartScreenPos;

			// Token: 0x0401B4DE RID: 111838
			[Token(Token = "0x401B4DE")]
			[FieldOffset(Offset = "0x20")]
			public Vector2 touchCurrScreenPos;
		}

		// Token: 0x020037CD RID: 14285
		[Token(Token = "0x20037CD")]
		public struct TouchGroup
		{
			// Token: 0x06016A63 RID: 92771 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016A63")]
			[Address(RVA = "0xF0B1F0", Offset = "0xF09DF0", VA = "0x180F0B1F0")]
			public void SetMaxTouchCount(int maxTouchCount)
			{
			}

			// Token: 0x06016A64 RID: 92772 RVA: 0x00092238 File Offset: 0x00090438
			[Token(Token = "0x6016A64")]
			[Address(RVA = "0xF0B0A0", Offset = "0xF09CA0", VA = "0x180F0B0A0")]
			public bool IsTouchCountMax()
			{
				return default(bool);
			}

			// Token: 0x06016A65 RID: 92773 RVA: 0x00092250 File Offset: 0x00090450
			[Token(Token = "0x6016A65")]
			[Address(RVA = "0xF0AE10", Offset = "0xF09A10", VA = "0x180F0AE10")]
			public int GetTouchCount()
			{
				return 0;
			}

			// Token: 0x06016A66 RID: 92774 RVA: 0x00092268 File Offset: 0x00090468
			[Token(Token = "0x6016A66")]
			[Address(RVA = "0xF0ACF0", Offset = "0xF098F0", VA = "0x180F0ACF0")]
			public TouchHandler.TouchStatus GetTouchByIndex(int index)
			{
				return default(TouchHandler.TouchStatus);
			}

			// Token: 0x06016A67 RID: 92775 RVA: 0x00092280 File Offset: 0x00090480
			[Token(Token = "0x6016A67")]
			[Address(RVA = "0xF0AEB0", Offset = "0xF09AB0", VA = "0x180F0AEB0")]
			public TouchHandler.TouchStatus GetTouch(int pointerId)
			{
				return default(TouchHandler.TouchStatus);
			}

			// Token: 0x06016A68 RID: 92776 RVA: 0x00092298 File Offset: 0x00090498
			[Token(Token = "0x6016A68")]
			[Address(RVA = "0xF0B2D0", Offset = "0xF09ED0", VA = "0x180F0B2D0")]
			public bool SetTouch(int pointerId, TouchHandler.TouchStatus touchStatus)
			{
				return default(bool);
			}

			// Token: 0x06016A69 RID: 92777 RVA: 0x000922B0 File Offset: 0x000904B0
			[Token(Token = "0x6016A69")]
			[Address(RVA = "0xF0AFC0", Offset = "0xF09BC0", VA = "0x180F0AFC0")]
			public bool InsertTouch(TouchHandler.TouchStatus touchStatus)
			{
				return default(bool);
			}

			// Token: 0x06016A6A RID: 92778 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016A6A")]
			[Address(RVA = "0xF0B0D0", Offset = "0xF09CD0", VA = "0x180F0B0D0")]
			public void RemoveTouch(int pointerId)
			{
			}

			// Token: 0x0401B4DF RID: 111839
			[Token(Token = "0x401B4DF")]
			[FieldOffset(Offset = "0x0")]
			public TouchHandler.TouchStatus[] touches;
		}

		// Token: 0x020037CE RID: 14286
		[Token(Token = "0x20037CE")]
		public class ScrollWheelComp : IWheelListener, IHotfixable
		{
			// Token: 0x06016A6B RID: 92779 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016A6B")]
			[Address(RVA = "0xF06BE0", Offset = "0xF057E0", VA = "0x180F06BE0")]
			public ScrollWheelComp(Action<Vector2> onScrollTriggered)
			{
			}

			// Token: 0x06016A6C RID: 92780 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016A6C")]
			[Address(RVA = "0xF06AD0", Offset = "0xF056D0", VA = "0x180F06AD0")]
			public void OnScrollTriggered(PointerEventData eventData)
			{
			}

			// Token: 0x06016A6D RID: 92781 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016A6D")]
			[Address(RVA = "0xF06990", Offset = "0xF05590", VA = "0x180F06990")]
			public void BindListener(ScrollWheelHandler handler)
			{
			}

			// Token: 0x06016A6E RID: 92782 RVA: 0x000922C8 File Offset: 0x000904C8
			[Token(Token = "0x6016A6E")]
			[Address(RVA = "0xF06A70", Offset = "0xF05670", VA = "0x180F06A70", Slot = "4")]
			public WheelSorting GetWheelSorting()
			{
				return WheelSorting.BASE;
			}

			// Token: 0x06016A6F RID: 92783 RVA: 0x000922E0 File Offset: 0x000904E0
			[Token(Token = "0x6016A6F")]
			[Address(RVA = "0xF06B50", Offset = "0xF05750", VA = "0x180F06B50", Slot = "5")]
			public Vector2 TreatValue(PointerEventData eventData)
			{
				return default(Vector2);
			}

			// Token: 0x0401B4E0 RID: 111840
			[Token(Token = "0x401B4E0")]
			[FieldOffset(Offset = "0x10")]
			private Action<Vector2> m_onScrollTriggered;

			// Token: 0x0401B4E1 RID: 111841
			[Token(Token = "0x401B4E1")]
			[FieldOffset(Offset = "0x18")]
			private ScrollWheelHandler m_scrollWheelHandler;

			// Token: 0x0401B4E2 RID: 111842
			[Token(Token = "0x401B4E2")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401B4E3 RID: 111843
			[Token(Token = "0x401B4E3")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnScrollTriggered;

			// Token: 0x0401B4E4 RID: 111844
			[Token(Token = "0x401B4E4")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_BindListener;

			// Token: 0x0401B4E5 RID: 111845
			[Token(Token = "0x401B4E5")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetWheelSorting;

			// Token: 0x0401B4E6 RID: 111846
			[Token(Token = "0x401B4E6")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_TreatValue;
		}

		// Token: 0x020037CF RID: 14287
		[Token(Token = "0x20037CF")]
		public struct Options
		{
			// Token: 0x0401B4E7 RID: 111847
			[Token(Token = "0x401B4E7")]
			[FieldOffset(Offset = "0x0")]
			public RectTransform eventRectTransform;

			// Token: 0x0401B4E8 RID: 111848
			[Token(Token = "0x401B4E8")]
			[FieldOffset(Offset = "0x8")]
			public Camera eventCamera;
		}

		// Token: 0x020037D0 RID: 14288
		[Token(Token = "0x20037D0")]
		public abstract class TouchContext : IHotfixable
		{
			// Token: 0x1700362E RID: 13870
			// (get) Token: 0x06016A70 RID: 92784 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06016A71 RID: 92785 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700362E")]
			public TouchHandler touchHandler
			{
				[Token(Token = "0x6016A70")]
				[Address(RVA = "0xF0AC10", Offset = "0xF09810", VA = "0x180F0AC10")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x6016A71")]
				[Address(RVA = "0xF0AC70", Offset = "0xF09870", VA = "0x180F0AC70")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700362F RID: 13871
			// (get) Token: 0x06016A72 RID: 92786 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700362F")]
			protected Camera eventCamera
			{
				[Token(Token = "0x6016A72")]
				[Address(RVA = "0xF0AAB0", Offset = "0xF096B0", VA = "0x180F0AAB0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17003630 RID: 13872
			// (get) Token: 0x06016A73 RID: 92787 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17003630")]
			protected RectTransform eventRectTransform
			{
				[Token(Token = "0x6016A73")]
				[Address(RVA = "0xF0AB60", Offset = "0xF09760", VA = "0x180F0AB60")]
				get
				{
					return null;
				}
			}

			// Token: 0x06016A74 RID: 92788 RVA: 0x000922F8 File Offset: 0x000904F8
			[Token(Token = "0x6016A74")]
			[Address(RVA = "0xF0A9A0", Offset = "0xF095A0", VA = "0x180F0A9A0")]
			protected int GetTouchCount()
			{
				return 0;
			}

			// Token: 0x06016A75 RID: 92789 RVA: 0x00092310 File Offset: 0x00090510
			[Token(Token = "0x6016A75")]
			[Address(RVA = "0xF0A8A0", Offset = "0xF094A0", VA = "0x180F0A8A0")]
			protected TouchHandler.TouchStatus GetTouchByIndex(int index)
			{
				return default(TouchHandler.TouchStatus);
			}

			// Token: 0x17003631 RID: 13873
			// (get) Token: 0x06016A76 RID: 92790
			[Token(Token = "0x17003631")]
			public abstract TouchHandler.CreateTouchType createTouchType { [Token(Token = "0x6016A76")] get; }

			// Token: 0x17003632 RID: 13874
			// (get) Token: 0x06016A77 RID: 92791
			[Token(Token = "0x17003632")]
			public abstract int maxTouchCount { [Token(Token = "0x6016A77")] get; }

			// Token: 0x06016A78 RID: 92792
			[Token(Token = "0x6016A78")]
			public abstract bool TouchCreate(int pointerId, ValueBundle param);

			// Token: 0x06016A79 RID: 92793
			[Token(Token = "0x6016A79")]
			public abstract bool TouchMove(int pointerId);

			// Token: 0x06016A7A RID: 92794
			[Token(Token = "0x6016A7A")]
			public abstract bool TouchUpdate(int pointerId);

			// Token: 0x06016A7B RID: 92795
			[Token(Token = "0x6016A7B")]
			public abstract void TouchClear(int pointerId);

			// Token: 0x06016A7C RID: 92796
			[Token(Token = "0x6016A7C")]
			public abstract bool TouchSessionCreate();

			// Token: 0x06016A7D RID: 92797
			[Token(Token = "0x6016A7D")]
			public abstract bool TouchSessionUpdate();

			// Token: 0x06016A7E RID: 92798
			[Token(Token = "0x6016A7E")]
			public abstract void TouchSessionClear();

			// Token: 0x06016A7F RID: 92799
			[Token(Token = "0x6016A7F")]
			public abstract void OnScrollInternal(Vector2 scrollDelta, ValueBundle param);

			// Token: 0x06016A80 RID: 92800 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016A80")]
			[Address(RVA = "0xF0AA50", Offset = "0xF09650", VA = "0x180F0AA50")]
			protected TouchContext()
			{
			}

			// Token: 0x0401B4EA RID: 111850
			[Token(Token = "0x401B4EA")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_touchHandler;

			// Token: 0x0401B4EB RID: 111851
			[Token(Token = "0x401B4EB")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_touchHandler;

			// Token: 0x0401B4EC RID: 111852
			[Token(Token = "0x401B4EC")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_eventCamera;

			// Token: 0x0401B4ED RID: 111853
			[Token(Token = "0x401B4ED")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_eventRectTransform;

			// Token: 0x0401B4EE RID: 111854
			[Token(Token = "0x401B4EE")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetTouchCount;

			// Token: 0x0401B4EF RID: 111855
			[Token(Token = "0x401B4EF")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_GetTouchByIndex;

			// Token: 0x0401B4F0 RID: 111856
			[Token(Token = "0x401B4F0")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
