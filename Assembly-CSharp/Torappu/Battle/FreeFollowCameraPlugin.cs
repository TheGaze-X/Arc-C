using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020021B0 RID: 8624
	[Token(Token = "0x20021B0")]
	public class FreeFollowCameraPlugin : DraggableCameraPlugin
	{
		// Token: 0x17001A29 RID: 6697
		// (get) Token: 0x0600D746 RID: 55110 RVA: 0x0004DE20 File Offset: 0x0004C020
		// (set) Token: 0x0600D747 RID: 55111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001A29")]
		public bool isFollowing
		{
			[Token(Token = "0x600D746")]
			[Address(RVA = "0x35D86C0", Offset = "0x35D72C0", VA = "0x1835D86C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600D747")]
			[Address(RVA = "0x35D8780", Offset = "0x35D7380", VA = "0x1835D8780")]
			set
			{
			}
		}

		// Token: 0x17001A2A RID: 6698
		// (get) Token: 0x0600D748 RID: 55112 RVA: 0x0004DE38 File Offset: 0x0004C038
		[Token(Token = "0x17001A2A")]
		public bool isZoomIn
		{
			[Token(Token = "0x600D748")]
			[Address(RVA = "0x35D8720", Offset = "0x35D7320", VA = "0x1835D8720")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600D749 RID: 55113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D749")]
		[Address(RVA = "0x35D7900", Offset = "0x35D6500", VA = "0x1835D7900")]
		public void SetTarget(Entity target)
		{
		}

		// Token: 0x0600D74A RID: 55114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D74A")]
		[Address(RVA = "0x35D7C70", Offset = "0x35D6870", VA = "0x1835D7C70")]
		public void ZoomIn(float duration, float zoomInFactor)
		{
		}

		// Token: 0x0600D74B RID: 55115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D74B")]
		[Address(RVA = "0x35D7810", Offset = "0x35D6410", VA = "0x1835D7810")]
		public void ResetZoom(float duration)
		{
		}

		// Token: 0x0600D74C RID: 55116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D74C")]
		[Address(RVA = "0x35D7A60", Offset = "0x35D6660", VA = "0x1835D7A60")]
		public void ShakeCamera(Vector2 dir)
		{
		}

		// Token: 0x0600D74D RID: 55117 RVA: 0x0004DE50 File Offset: 0x0004C050
		[Token(Token = "0x600D74D")]
		[Address(RVA = "0x35D7BA0", Offset = "0x35D67A0", VA = "0x1835D7BA0", Slot = "10")]
		public override bool TrySetCameraPosition(CameraController.CameraPosition cameraPos, bool tween = true)
		{
			return default(bool);
		}

		// Token: 0x0600D74E RID: 55118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D74E")]
		[Address(RVA = "0x35D7F00", Offset = "0x35D6B00", VA = "0x1835D7F00", Slot = "13")]
		protected override void _InitIfNot()
		{
		}

		// Token: 0x0600D74F RID: 55119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D74F")]
		[Address(RVA = "0x35D8060", Offset = "0x35D6C60", VA = "0x1835D8060", Slot = "15")]
		protected override void _UpdateCamera()
		{
		}

		// Token: 0x0600D750 RID: 55120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D750")]
		[Address(RVA = "0x35D76D0", Offset = "0x35D62D0", VA = "0x1835D76D0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x0600D751 RID: 55121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D751")]
		[Address(RVA = "0x35D7FE0", Offset = "0x35D6BE0", VA = "0x1835D7FE0", Slot = "14")]
		protected override void _OnBeginDrag(object arg)
		{
		}

		// Token: 0x0600D752 RID: 55122 RVA: 0x0004DE68 File Offset: 0x0004C068
		[Token(Token = "0x600D752")]
		[Address(RVA = "0x35D7740", Offset = "0x35D6340", VA = "0x1835D7740", Slot = "17")]
		protected override bool IsDragValidState()
		{
			return default(bool);
		}

		// Token: 0x0600D753 RID: 55123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D753")]
		[Address(RVA = "0x35D8240", Offset = "0x35D6E40", VA = "0x1835D8240")]
		private void _UpdateFollowCamera()
		{
		}

		// Token: 0x0600D754 RID: 55124 RVA: 0x0004DE80 File Offset: 0x0004C080
		[Token(Token = "0x600D754")]
		[Address(RVA = "0x35D7DA0", Offset = "0x35D69A0", VA = "0x1835D7DA0")]
		private Vector3 _GetLerpFollowCameraPosition(Vector3 curCameraPos, Vector3 targetPos)
		{
			return default(Vector3);
		}

		// Token: 0x0600D755 RID: 55125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D755")]
		[Address(RVA = "0x35D8620", Offset = "0x35D7220", VA = "0x1835D8620")]
		public FreeFollowCameraPlugin()
		{
		}

		// Token: 0x0600D756 RID: 55126 RVA: 0x0004DE98 File Offset: 0x0004C098
		[Token(Token = "0x600D756")]
		[Address(RVA = "0x962010", Offset = "0x960C10", VA = "0x180962010")]
		private bool <>xLuaBaseProxy_TrySetCameraPosition(CameraController.CameraPosition P0, bool P1)
		{
			return default(bool);
		}

		// Token: 0x0600D757 RID: 55127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D757")]
		[Address(RVA = "0x7E4F30", Offset = "0x7E3B30", VA = "0x1807E4F30")]
		private void <>xLuaBaseProxy__InitIfNot()
		{
		}

		// Token: 0x0600D758 RID: 55128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D758")]
		[Address(RVA = "0x35D6AF0", Offset = "0x35D56F0", VA = "0x1835D6AF0")]
		private void <>xLuaBaseProxy__UpdateCamera()
		{
		}

		// Token: 0x0600D759 RID: 55129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D759")]
		[Address(RVA = "0x7E4F40", Offset = "0x7E3B40", VA = "0x1807E4F40")]
		private void <>xLuaBaseProxy__OnBeginDrag(object P0)
		{
		}

		// Token: 0x0600D75A RID: 55130 RVA: 0x0004DEB0 File Offset: 0x0004C0B0
		[Token(Token = "0x600D75A")]
		[Address(RVA = "0x35D7C60", Offset = "0x35D6860", VA = "0x1835D7C60")]
		private bool <>xLuaBaseProxy_IsDragValidState()
		{
			return default(bool);
		}

		// Token: 0x0400E7BE RID: 59326
		[Token(Token = "0x400E7BE")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Follow Camera")]
		private float _followFactor;

		// Token: 0x0400E7BF RID: 59327
		[Token(Token = "0x400E7BF")]
		[FieldOffset(Offset = "0xC4")]
		[SerializeField]
		[Group("Follow Camera")]
		private float _zoomResetDuration;

		// Token: 0x0400E7C0 RID: 59328
		[Token(Token = "0x400E7C0")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Follow Camera")]
		private float _zoomInScaleFactor;

		// Token: 0x0400E7C1 RID: 59329
		[Token(Token = "0x400E7C1")]
		[FieldOffset(Offset = "0xCC")]
		[SerializeField]
		[Group("Follow Camera")]
		private float _shakeDuration;

		// Token: 0x0400E7C2 RID: 59330
		[Token(Token = "0x400E7C2")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("Follow Camera")]
		private float _shakeStrengthFactor;

		// Token: 0x0400E7C3 RID: 59331
		[Token(Token = "0x400E7C3")]
		[FieldOffset(Offset = "0xD4")]
		[SerializeField]
		[Group("Follow Camera")]
		private int _shakeVibrato;

		// Token: 0x0400E7C4 RID: 59332
		[Token(Token = "0x400E7C4")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("Follow Camera")]
		private float _shakeRandomness;

		// Token: 0x0400E7C5 RID: 59333
		[Token(Token = "0x400E7C5")]
		[FieldOffset(Offset = "0xDC")]
		[SerializeField]
		[Group("Follow Camera")]
		private bool _disableSideBy;

		// Token: 0x0400E7C6 RID: 59334
		[Token(Token = "0x400E7C6")]
		[FieldOffset(Offset = "0xE0")]
		private ObjectPtr<Entity> m_target;

		// Token: 0x0400E7C7 RID: 59335
		[Token(Token = "0x400E7C7")]
		[FieldOffset(Offset = "0xF0")]
		private bool m_isFollowing;

		// Token: 0x0400E7C8 RID: 59336
		[Token(Token = "0x400E7C8")]
		[FieldOffset(Offset = "0xF1")]
		private bool m_isZoomIn;

		// Token: 0x0400E7C9 RID: 59337
		[Token(Token = "0x400E7C9")]
		[FieldOffset(Offset = "0xF4")]
		private float m_followFactor;

		// Token: 0x0400E7CA RID: 59338
		[Token(Token = "0x400E7CA")]
		[FieldOffset(Offset = "0xF8")]
		private float m_cameraOriginScale;

		// Token: 0x0400E7CB RID: 59339
		[Token(Token = "0x400E7CB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isFollowing;

		// Token: 0x0400E7CC RID: 59340
		[Token(Token = "0x400E7CC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isFollowing;

		// Token: 0x0400E7CD RID: 59341
		[Token(Token = "0x400E7CD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isZoomIn;

		// Token: 0x0400E7CE RID: 59342
		[Token(Token = "0x400E7CE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetTarget;

		// Token: 0x0400E7CF RID: 59343
		[Token(Token = "0x400E7CF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ZoomIn;

		// Token: 0x0400E7D0 RID: 59344
		[Token(Token = "0x400E7D0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ResetZoom;

		// Token: 0x0400E7D1 RID: 59345
		[Token(Token = "0x400E7D1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ShakeCamera;

		// Token: 0x0400E7D2 RID: 59346
		[Token(Token = "0x400E7D2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_TrySetCameraPosition;

		// Token: 0x0400E7D3 RID: 59347
		[Token(Token = "0x400E7D3")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0400E7D4 RID: 59348
		[Token(Token = "0x400E7D4")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__UpdateCamera;

		// Token: 0x0400E7D5 RID: 59349
		[Token(Token = "0x400E7D5")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_FixedUpdate;

		// Token: 0x0400E7D6 RID: 59350
		[Token(Token = "0x400E7D6")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnBeginDrag;

		// Token: 0x0400E7D7 RID: 59351
		[Token(Token = "0x400E7D7")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_IsDragValidState;

		// Token: 0x0400E7D8 RID: 59352
		[Token(Token = "0x400E7D8")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__UpdateFollowCamera;

		// Token: 0x0400E7D9 RID: 59353
		[Token(Token = "0x400E7D9")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__GetLerpFollowCameraPosition;

		// Token: 0x0400E7DA RID: 59354
		[Token(Token = "0x400E7DA")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
