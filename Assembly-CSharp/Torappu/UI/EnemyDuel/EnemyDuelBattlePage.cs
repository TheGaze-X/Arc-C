using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004FF6 RID: 20470
	[Token(Token = "0x2004FF6")]
	public class EnemyDuelBattlePage : StateEnginePage, IVirtualCameraPage, IValueMsgReceiver, ICompDialogCallBack
	{
		// Token: 0x17004703 RID: 18179
		// (get) Token: 0x0601E625 RID: 124453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004703")]
		public UICompDialogMgr dlgMgr
		{
			[Token(Token = "0x601E625")]
			[Address(RVA = "0x1812B50", Offset = "0x1811750", VA = "0x181812B50")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601E626 RID: 124454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E626")]
		[Address(RVA = "0x1811840", Offset = "0x1810440", VA = "0x181811840", Slot = "30")]
		public void InitVirtualCamera(UIPageCameraProvider provider)
		{
		}

		// Token: 0x0601E627 RID: 124455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E627")]
		[Address(RVA = "0x18116F0", Offset = "0x18102F0", VA = "0x1818116F0", Slot = "31")]
		public void DisposeVirtualCamera()
		{
		}

		// Token: 0x0601E628 RID: 124456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E628")]
		[Address(RVA = "0x1811AB0", Offset = "0x18106B0", VA = "0x181811AB0", Slot = "29")]
		public void LoadAllVirtualCamTypes(ICollection<int> cameraTypes)
		{
		}

		// Token: 0x0601E629 RID: 124457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E629")]
		[Address(RVA = "0x18121A0", Offset = "0x1810DA0", VA = "0x1818121A0")]
		public void ShotBlurRT(UIRenderTextureImage rtImage)
		{
		}

		// Token: 0x0601E62A RID: 124458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E62A")]
		[Address(RVA = "0x1811D50", Offset = "0x1810950", VA = "0x181811D50", Slot = "32")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601E62B RID: 124459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E62B")]
		[Address(RVA = "0x1811770", Offset = "0x1810370", VA = "0x181811770", Slot = "33")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x0601E62C RID: 124460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E62C")]
		[Address(RVA = "0x1811B70", Offset = "0x1810770", VA = "0x181811B70", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x0601E62D RID: 124461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E62D")]
		[Address(RVA = "0x1811F80", Offset = "0x1810B80", VA = "0x181811F80", Slot = "10")]
		protected override void OnStart()
		{
		}

		// Token: 0x0601E62E RID: 124462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E62E")]
		[Address(RVA = "0x1812280", Offset = "0x1810E80", VA = "0x181812280")]
		private LatchUtils.SetWhenBind<UIPageVirtualCamCanvasBinder, UIPageVirtualCamera> _EnsureCameraSetter()
		{
			return null;
		}

		// Token: 0x0601E62F RID: 124463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E62F")]
		[Address(RVA = "0x1812420", Offset = "0x1811020", VA = "0x181812420")]
		private void _GetBlurCameras(IList<Camera> cameras)
		{
		}

		// Token: 0x0601E630 RID: 124464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E630")]
		[Address(RVA = "0x1812970", Offset = "0x1811570", VA = "0x181812970")]
		private void _RegisterBattleEvents()
		{
		}

		// Token: 0x0601E631 RID: 124465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E631")]
		[Address(RVA = "0x1812720", Offset = "0x1811320", VA = "0x181812720")]
		private void _OpenRoomEndDialog(object arg)
		{
		}

		// Token: 0x0601E632 RID: 124466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E632")]
		[Address(RVA = "0x1812630", Offset = "0x1811230", VA = "0x181812630")]
		private void _OnNetStateChanged(object arg)
		{
		}

		// Token: 0x0601E633 RID: 124467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E633")]
		[Address(RVA = "0x1812AF0", Offset = "0x18116F0", VA = "0x181812AF0")]
		public EnemyDuelBattlePage()
		{
		}

		// Token: 0x0601E634 RID: 124468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E634")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x0601E635 RID: 124469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E635")]
		[Address(RVA = "0x1071290", Offset = "0x106FE90", VA = "0x181071290")]
		private void <>xLuaBaseProxy_OnStart()
		{
		}

		// Token: 0x040289ED RID: 166381
		[Token(Token = "0x40289ED")]
		[NonSerialized]
		public const int MSG_GIVE_UP_BTN_CLICKED = 0;

		// Token: 0x040289EE RID: 166382
		[Token(Token = "0x40289EE")]
		[NonSerialized]
		public const int MSG_GIVE_UP = 1;

		// Token: 0x040289EF RID: 166383
		[Token(Token = "0x40289EF")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private EnemyDuelBattlePageVirtualCameraCanvasBinder _canvasBinder;

		// Token: 0x040289F0 RID: 166384
		[Token(Token = "0x40289F0")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private RectTransform _dialogContainer;

		// Token: 0x040289F1 RID: 166385
		[Token(Token = "0x40289F1")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private CanvasGroup _connectDlg;

		// Token: 0x040289F2 RID: 166386
		[Token(Token = "0x40289F2")]
		[FieldOffset(Offset = "0x108")]
		private UIPageVirtualCamera m_virtualCamera;

		// Token: 0x040289F3 RID: 166387
		[Token(Token = "0x40289F3")]
		[FieldOffset(Offset = "0x110")]
		private UIPageVirtualCamera m_blurCamera;

		// Token: 0x040289F4 RID: 166388
		[Token(Token = "0x40289F4")]
		[FieldOffset(Offset = "0x118")]
		private LatchUtils.SetWhenBind<UIPageVirtualCamCanvasBinder, UIPageVirtualCamera> m_cameraSetter;

		// Token: 0x040289F5 RID: 166389
		[Token(Token = "0x40289F5")]
		[FieldOffset(Offset = "0x120")]
		private EnemyDuelBattlePage.BlurCamBinder m_blurCamBinder;

		// Token: 0x040289F6 RID: 166390
		[Token(Token = "0x40289F6")]
		[FieldOffset(Offset = "0x128")]
		private UICompDialogMgr m_dlgMgr;

		// Token: 0x040289F7 RID: 166391
		[Token(Token = "0x40289F7")]
		[FieldOffset(Offset = "0x130")]
		private FadeSwitchTween m_connectDlgTween;

		// Token: 0x040289F8 RID: 166392
		[Token(Token = "0x40289F8")]
		[FieldOffset(Offset = "0x138")]
		private int m_giveUpDlg;

		// Token: 0x040289F9 RID: 166393
		[Token(Token = "0x40289F9")]
		[FieldOffset(Offset = "0x13C")]
		private bool m_isAbnormalEnd;

		// Token: 0x040289FA RID: 166394
		[Token(Token = "0x40289FA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_dlgMgr;

		// Token: 0x040289FB RID: 166395
		[Token(Token = "0x40289FB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitVirtualCamera;

		// Token: 0x040289FC RID: 166396
		[Token(Token = "0x40289FC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DisposeVirtualCamera;

		// Token: 0x040289FD RID: 166397
		[Token(Token = "0x40289FD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadAllVirtualCamTypes;

		// Token: 0x040289FE RID: 166398
		[Token(Token = "0x40289FE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ShotBlurRT;

		// Token: 0x040289FF RID: 166399
		[Token(Token = "0x40289FF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04028A00 RID: 166400
		[Token(Token = "0x4028A00")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x04028A01 RID: 166401
		[Token(Token = "0x4028A01")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x04028A02 RID: 166402
		[Token(Token = "0x4028A02")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnStart;

		// Token: 0x04028A03 RID: 166403
		[Token(Token = "0x4028A03")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__EnsureCameraSetter;

		// Token: 0x04028A04 RID: 166404
		[Token(Token = "0x4028A04")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__GetBlurCameras;

		// Token: 0x04028A05 RID: 166405
		[Token(Token = "0x4028A05")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__RegisterBattleEvents;

		// Token: 0x04028A06 RID: 166406
		[Token(Token = "0x4028A06")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OpenRoomEndDialog;

		// Token: 0x04028A07 RID: 166407
		[Token(Token = "0x4028A07")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnNetStateChanged;

		// Token: 0x04028A08 RID: 166408
		[Token(Token = "0x4028A08")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004FF7 RID: 20471
		[Token(Token = "0x2004FF7")]
		public class Params
		{
			// Token: 0x0601E636 RID: 124470 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E636")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Params()
			{
			}

			// Token: 0x04028A09 RID: 166409
			[Token(Token = "0x4028A09")]
			[FieldOffset(Offset = "0x10")]
			public string actId;
		}

		// Token: 0x02004FF8 RID: 20472
		[Token(Token = "0x2004FF8")]
		public class BlurCamBinder : IPageVirtualCamBinder, IHotfixable
		{
			// Token: 0x17004704 RID: 18180
			// (get) Token: 0x0601E637 RID: 124471 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17004704")]
			public List<Camera> blurCameras
			{
				[Token(Token = "0x601E637")]
				[Address(RVA = "0x180E9B0", Offset = "0x180D5B0", VA = "0x18180E9B0")]
				get
				{
					return null;
				}
			}

			// Token: 0x0601E638 RID: 124472 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E638")]
			[Address(RVA = "0x180E900", Offset = "0x180D500", VA = "0x18180E900")]
			public BlurCamBinder()
			{
			}

			// Token: 0x0601E639 RID: 124473 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E639")]
			[Address(RVA = "0x180E7F0", Offset = "0x180D3F0", VA = "0x18180E7F0", Slot = "4")]
			public void BindCamera(CameraWrapper camera)
			{
			}

			// Token: 0x0601E63A RID: 124474 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E63A")]
			[Address(RVA = "0x180E860", Offset = "0x180D460", VA = "0x18180E860", Slot = "5")]
			public void UnBindCamera()
			{
			}

			// Token: 0x04028A0A RID: 166410
			[Token(Token = "0x4028A0A")]
			[FieldOffset(Offset = "0x10")]
			private List<Camera> m_blurCameras;

			// Token: 0x04028A0B RID: 166411
			[Token(Token = "0x4028A0B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_blurCameras;

			// Token: 0x04028A0C RID: 166412
			[Token(Token = "0x4028A0C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04028A0D RID: 166413
			[Token(Token = "0x4028A0D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_BindCamera;

			// Token: 0x04028A0E RID: 166414
			[Token(Token = "0x4028A0E")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_UnBindCamera;
		}
	}
}
