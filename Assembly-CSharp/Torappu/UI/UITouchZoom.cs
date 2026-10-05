using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003A3A RID: 14906
	[Token(Token = "0x2003A3A")]
	public class UITouchZoom : MonoBehaviour, ITimeWatcher, IHotfixable, IWheelListener, IScrollNormalizedPosition
	{
		// Token: 0x0601786C RID: 96364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601786C")]
		[Address(RVA = "0xFD6E40", Offset = "0xFD5A40", VA = "0x180FD6E40")]
		private void _InitIfNot()
		{
		}

		// Token: 0x17003860 RID: 14432
		// (get) Token: 0x0601786D RID: 96365 RVA: 0x00096F30 File Offset: 0x00095130
		// (set) Token: 0x0601786E RID: 96366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003860")]
		[Inspect(InspectorLevel.Debug)]
		public float scale
		{
			[Token(Token = "0x601786D")]
			[Address(RVA = "0xFD7670", Offset = "0xFD6270", VA = "0x180FD7670")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x601786E")]
			[Address(RVA = "0xFD78C0", Offset = "0xFD64C0", VA = "0x180FD78C0")]
			set
			{
			}
		}

		// Token: 0x17003861 RID: 14433
		// (set) Token: 0x0601786F RID: 96367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003861")]
		public bool dirtyLock
		{
			[Token(Token = "0x601786F")]
			[Address(RVA = "0xFD76D0", Offset = "0xFD62D0", VA = "0x180FD76D0")]
			set
			{
			}
		}

		// Token: 0x17003862 RID: 14434
		// (set) Token: 0x06017870 RID: 96368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003862")]
		public Action<float> onScaleChanged
		{
			[Token(Token = "0x6017870")]
			[Address(RVA = "0xFD7740", Offset = "0xFD6340", VA = "0x180FD7740")]
			set
			{
			}
		}

		// Token: 0x17003863 RID: 14435
		// (set) Token: 0x06017871 RID: 96369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003863")]
		public Action<float> onScaleStart
		{
			[Token(Token = "0x6017871")]
			[Address(RVA = "0xFD7840", Offset = "0xFD6440", VA = "0x180FD7840")]
			set
			{
			}
		}

		// Token: 0x17003864 RID: 14436
		// (set) Token: 0x06017872 RID: 96370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003864")]
		public Action<float> onScaleEnd
		{
			[Token(Token = "0x6017872")]
			[Address(RVA = "0xFD77C0", Offset = "0xFD63C0", VA = "0x180FD77C0")]
			set
			{
			}
		}

		// Token: 0x17003865 RID: 14437
		// (get) Token: 0x06017873 RID: 96371 RVA: 0x00096F48 File Offset: 0x00095148
		[Token(Token = "0x17003865")]
		public Vector2 position
		{
			[Token(Token = "0x6017873")]
			[Address(RVA = "0xFD7590", Offset = "0xFD6190", VA = "0x180FD7590", Slot = "7")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x06017874 RID: 96372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017874")]
		[Address(RVA = "0xFD6B00", Offset = "0xFD5700", VA = "0x180FD6B00")]
		private void Start()
		{
		}

		// Token: 0x06017875 RID: 96373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017875")]
		[Address(RVA = "0xFD69E0", Offset = "0xFD55E0", VA = "0x180FD69E0")]
		protected void OnEnable()
		{
		}

		// Token: 0x06017876 RID: 96374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017876")]
		[Address(RVA = "0xFD6980", Offset = "0xFD5580", VA = "0x180FD6980")]
		protected void OnDisable()
		{
		}

		// Token: 0x06017877 RID: 96375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017877")]
		[Address(RVA = "0xFD6CE0", Offset = "0xFD58E0", VA = "0x180FD6CE0", Slot = "4")]
		public void UpdateTime(float deltaTime)
		{
		}

		// Token: 0x06017878 RID: 96376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017878")]
		[Address(RVA = "0xFD6A60", Offset = "0xFD5660", VA = "0x180FD6A60")]
		public void SetScaleRange(float minScale, float maxScale)
		{
		}

		// Token: 0x06017879 RID: 96377 RVA: 0x00096F60 File Offset: 0x00095160
		[Token(Token = "0x6017879")]
		[Address(RVA = "0xFD6890", Offset = "0xFD5490", VA = "0x180FD6890")]
		public float ClampScale(float scale)
		{
			return 0f;
		}

		// Token: 0x0601787A RID: 96378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601787A")]
		[Address(RVA = "0xFD7130", Offset = "0xFD5D30", VA = "0x180FD7130")]
		private void _Resume()
		{
		}

		// Token: 0x0601787B RID: 96379 RVA: 0x00096F78 File Offset: 0x00095178
		[Token(Token = "0x601787B")]
		[Address(RVA = "0xFD7280", Offset = "0xFD5E80", VA = "0x180FD7280")]
		private bool _UpdateZoomDistance()
		{
			return default(bool);
		}

		// Token: 0x0601787C RID: 96380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601787C")]
		[Address(RVA = "0xFD7090", Offset = "0xFD5C90", VA = "0x180FD7090")]
		private void _OnScaler(float distance)
		{
		}

		// Token: 0x0601787D RID: 96381 RVA: 0x00096F90 File Offset: 0x00095190
		[Token(Token = "0x601787D")]
		[Address(RVA = "0xFD7190", Offset = "0xFD5D90", VA = "0x180FD7190")]
		private bool _UpdateScrollZoomDistance(out float distance)
		{
			return default(bool);
		}

		// Token: 0x0601787E RID: 96382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601787E")]
		[Address(RVA = "0xFD6710", Offset = "0xFD5310", VA = "0x180FD6710")]
		public void BindListener(ScrollWheelHandler handler)
		{
		}

		// Token: 0x0601787F RID: 96383 RVA: 0x00096FA8 File Offset: 0x000951A8
		[Token(Token = "0x601787F")]
		[Address(RVA = "0xFD6920", Offset = "0xFD5520", VA = "0x180FD6920", Slot = "5")]
		public WheelSorting GetWheelSorting()
		{
			return WheelSorting.BASE;
		}

		// Token: 0x06017880 RID: 96384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017880")]
		[Address(RVA = "0xFD6C50", Offset = "0xFD5850", VA = "0x180FD6C50")]
		public void TriggerListener(Vector2 scrollDelta)
		{
		}

		// Token: 0x06017881 RID: 96385 RVA: 0x00096FC0 File Offset: 0x000951C0
		[Token(Token = "0x6017881")]
		[Address(RVA = "0xFD6BC0", Offset = "0xFD57C0", VA = "0x180FD6BC0", Slot = "6")]
		public Vector2 TreatValue(PointerEventData eventData)
		{
			return default(Vector2);
		}

		// Token: 0x06017882 RID: 96386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017882")]
		[Address(RVA = "0xFD7510", Offset = "0xFD6110", VA = "0x180FD7510")]
		public UITouchZoom()
		{
		}

		// Token: 0x0401C687 RID: 116359
		[Token(Token = "0x401C687")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Tooltip("How many pixels should be dragged when scale value changes 1.0")]
		private int _pixelsPerScale;

		// Token: 0x0401C688 RID: 116360
		[Token(Token = "0x401C688")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[Range(0f, 5f)]
		private float _minScale;

		// Token: 0x0401C689 RID: 116361
		[Token(Token = "0x401C689")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Range(0f, 5f)]
		private float _maxScale;

		// Token: 0x0401C68A RID: 116362
		[Token(Token = "0x401C68A")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Tooltip("To give the result a delta scale, such as +1.0f, -0.5f")]
		private float _deltaScale;

		// Token: 0x0401C68B RID: 116363
		[Token(Token = "0x401C68B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Component _scrollRect;

		// Token: 0x0401C68C RID: 116364
		[Token(Token = "0x401C68C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _scaleFactor;

		// Token: 0x0401C68D RID: 116365
		[Token(Token = "0x401C68D")]
		[FieldOffset(Offset = "0x38")]
		private Action<float> m_onScaleChanged;

		// Token: 0x0401C68E RID: 116366
		[Token(Token = "0x401C68E")]
		[FieldOffset(Offset = "0x40")]
		private Action<float> m_onScaleStart;

		// Token: 0x0401C68F RID: 116367
		[Token(Token = "0x401C68F")]
		[FieldOffset(Offset = "0x48")]
		private Action<float> m_onScaleEnd;

		// Token: 0x0401C690 RID: 116368
		[Token(Token = "0x401C690")]
		[FieldOffset(Offset = "0x50")]
		private float m_scale;

		// Token: 0x0401C691 RID: 116369
		[Token(Token = "0x401C691")]
		[FieldOffset(Offset = "0x54")]
		private bool m_dirtyLock;

		// Token: 0x0401C692 RID: 116370
		[Token(Token = "0x401C692")]
		[FieldOffset(Offset = "0x55")]
		private bool m_isStarted;

		// Token: 0x0401C693 RID: 116371
		[Token(Token = "0x401C693")]
		[FieldOffset(Offset = "0x58")]
		[Inspect(InspectorLevel.Debug)]
		[ReadOnly]
		private float m_minScale;

		// Token: 0x0401C694 RID: 116372
		[Token(Token = "0x401C694")]
		[FieldOffset(Offset = "0x5C")]
		[Inspect(InspectorLevel.Debug)]
		[ReadOnly]
		private float m_maxScale;

		// Token: 0x0401C695 RID: 116373
		[Token(Token = "0x401C695")]
		[FieldOffset(Offset = "0x60")]
		private bool m_isInited;

		// Token: 0x0401C696 RID: 116374
		[Token(Token = "0x401C696")]
		[FieldOffset(Offset = "0x61")]
		private bool m_zoomingLastFrame;

		// Token: 0x0401C697 RID: 116375
		[Token(Token = "0x401C697")]
		[FieldOffset(Offset = "0x64")]
		private float m_distanceLastFrame;

		// Token: 0x0401C698 RID: 116376
		[Token(Token = "0x401C698")]
		[FieldOffset(Offset = "0x68")]
		private float m_scaleLastFrame;

		// Token: 0x0401C699 RID: 116377
		[Token(Token = "0x401C699")]
		[FieldOffset(Offset = "0x6C")]
		private float m_lastWheelDelta;

		// Token: 0x0401C69A RID: 116378
		[Token(Token = "0x401C69A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401C69B RID: 116379
		[Token(Token = "0x401C69B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_scale;

		// Token: 0x0401C69C RID: 116380
		[Token(Token = "0x401C69C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_scale;

		// Token: 0x0401C69D RID: 116381
		[Token(Token = "0x401C69D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_dirtyLock;

		// Token: 0x0401C69E RID: 116382
		[Token(Token = "0x401C69E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_onScaleChanged;

		// Token: 0x0401C69F RID: 116383
		[Token(Token = "0x401C69F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_onScaleStart;

		// Token: 0x0401C6A0 RID: 116384
		[Token(Token = "0x401C6A0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_onScaleEnd;

		// Token: 0x0401C6A1 RID: 116385
		[Token(Token = "0x401C6A1")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_position;

		// Token: 0x0401C6A2 RID: 116386
		[Token(Token = "0x401C6A2")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0401C6A3 RID: 116387
		[Token(Token = "0x401C6A3")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0401C6A4 RID: 116388
		[Token(Token = "0x401C6A4")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0401C6A5 RID: 116389
		[Token(Token = "0x401C6A5")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_UpdateTime;

		// Token: 0x0401C6A6 RID: 116390
		[Token(Token = "0x401C6A6")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_SetScaleRange;

		// Token: 0x0401C6A7 RID: 116391
		[Token(Token = "0x401C6A7")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_ClampScale;

		// Token: 0x0401C6A8 RID: 116392
		[Token(Token = "0x401C6A8")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__Resume;

		// Token: 0x0401C6A9 RID: 116393
		[Token(Token = "0x401C6A9")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__UpdateZoomDistance;

		// Token: 0x0401C6AA RID: 116394
		[Token(Token = "0x401C6AA")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OnScaler;

		// Token: 0x0401C6AB RID: 116395
		[Token(Token = "0x401C6AB")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__UpdateScrollZoomDistance;

		// Token: 0x0401C6AC RID: 116396
		[Token(Token = "0x401C6AC")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_BindListener;

		// Token: 0x0401C6AD RID: 116397
		[Token(Token = "0x401C6AD")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_GetWheelSorting;

		// Token: 0x0401C6AE RID: 116398
		[Token(Token = "0x401C6AE")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_TriggerListener;

		// Token: 0x0401C6AF RID: 116399
		[Token(Token = "0x401C6AF")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_TreatValue;

		// Token: 0x0401C6B0 RID: 116400
		[Token(Token = "0x401C6B0")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
