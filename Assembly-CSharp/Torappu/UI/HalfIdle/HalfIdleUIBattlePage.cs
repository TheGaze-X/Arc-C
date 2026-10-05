using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.HalfIdle
{
	// Token: 0x02006752 RID: 26450
	[Token(Token = "0x2006752")]
	public class HalfIdleUIBattlePage : StateEnginePage, IVirtualCameraPage, IDialogMgrHolder
	{
		// Token: 0x170059D5 RID: 22997
		// (get) Token: 0x06025F50 RID: 155472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170059D5")]
		public UICompDialogMgr dlgMgr
		{
			[Token(Token = "0x6025F50")]
			[Address(RVA = "0x20F72D0", Offset = "0x20F5ED0", VA = "0x1820F72D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170059D6 RID: 22998
		// (get) Token: 0x06025F51 RID: 155473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170059D6")]
		public string actId
		{
			[Token(Token = "0x6025F51")]
			[Address(RVA = "0x20F7200", Offset = "0x20F5E00", VA = "0x1820F7200")]
			get
			{
				return null;
			}
		}

		// Token: 0x06025F52 RID: 155474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F52")]
		[Address(RVA = "0x20F6BE0", Offset = "0x20F57E0", VA = "0x1820F6BE0", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x06025F53 RID: 155475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025F53")]
		[Address(RVA = "0x20F7090", Offset = "0x20F5C90", VA = "0x1820F7090")]
		private LatchUtils.SetWhenBind<UIPageVirtualCamBlurCompBinder, List<UIPageVirtualCamera>> _EnsureDlgCameraCollector()
		{
			return null;
		}

		// Token: 0x06025F54 RID: 155476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F54")]
		[Address(RVA = "0x20F6DA0", Offset = "0x20F59A0", VA = "0x1820F6DA0")]
		private void _ConstructCompDlgMgr(UIPageVirtualCamBlurCompBinder binder, List<UIPageVirtualCamera> virtualCameras)
		{
		}

		// Token: 0x06025F55 RID: 155477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025F55")]
		[Address(RVA = "0x20F6EF0", Offset = "0x20F5AF0", VA = "0x1820F6EF0")]
		private LatchUtils.SetWhenBind<UIPageVirtualCamCanvasBinder, UIPageVirtualCamera> _EnsureCameraSetter()
		{
			return null;
		}

		// Token: 0x06025F56 RID: 155478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025F56")]
		[Address(RVA = "0x20F6830", Offset = "0x20F5430", VA = "0x1820F6830", Slot = "32")]
		public UICompDialogMgr GetDialogMgr()
		{
			return null;
		}

		// Token: 0x06025F57 RID: 155479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F57")]
		[Address(RVA = "0x20F6890", Offset = "0x20F5490", VA = "0x1820F6890")]
		public void HideDialogsImmediately()
		{
		}

		// Token: 0x06025F58 RID: 155480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F58")]
		[Address(RVA = "0x20F6B20", Offset = "0x20F5720", VA = "0x1820F6B20", Slot = "29")]
		public void LoadAllVirtualCamTypes(ICollection<int> cameraTypes)
		{
		}

		// Token: 0x06025F59 RID: 155481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F59")]
		[Address(RVA = "0x20F6910", Offset = "0x20F5510", VA = "0x1820F6910", Slot = "30")]
		public void InitVirtualCamera(UIPageCameraProvider provider)
		{
		}

		// Token: 0x06025F5A RID: 155482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F5A")]
		[Address(RVA = "0x20F67B0", Offset = "0x20F53B0", VA = "0x1820F67B0", Slot = "31")]
		public void DisposeVirtualCamera()
		{
		}

		// Token: 0x06025F5B RID: 155483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F5B")]
		[Address(RVA = "0x20F71A0", Offset = "0x20F5DA0", VA = "0x1820F71A0")]
		public HalfIdleUIBattlePage()
		{
		}

		// Token: 0x06025F5C RID: 155484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F5C")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x04035640 RID: 218688
		[Token(Token = "0x4035640")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private RectTransform _dialogContainer;

		// Token: 0x04035641 RID: 218689
		[Token(Token = "0x4035641")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private HalfIdleBattlePageVirtualCameraCanvasBinder _canvasBinder;

		// Token: 0x04035642 RID: 218690
		[Token(Token = "0x4035642")]
		[FieldOffset(Offset = "0x100")]
		private UICompDialogMgr m_dlgMgr;

		// Token: 0x04035643 RID: 218691
		[Token(Token = "0x4035643")]
		[FieldOffset(Offset = "0x108")]
		private UIPageVirtualCamera m_blurCameraPerspectiveLower;

		// Token: 0x04035644 RID: 218692
		[Token(Token = "0x4035644")]
		[FieldOffset(Offset = "0x110")]
		private UIPageVirtualCamera m_virtualCamera;

		// Token: 0x04035645 RID: 218693
		[Token(Token = "0x4035645")]
		[FieldOffset(Offset = "0x118")]
		private LatchUtils.SetWhenBind<UIPageVirtualCamCanvasBinder, UIPageVirtualCamera> m_cameraSetter;

		// Token: 0x04035646 RID: 218694
		[Token(Token = "0x4035646")]
		[FieldOffset(Offset = "0x120")]
		private HalfIdleUIBattlePage.Params m_param;

		// Token: 0x04035647 RID: 218695
		[Token(Token = "0x4035647")]
		[FieldOffset(Offset = "0x128")]
		private DataBundle m_savedInst;

		// Token: 0x04035648 RID: 218696
		[Token(Token = "0x4035648")]
		[FieldOffset(Offset = "0x130")]
		private LatchUtils.SetWhenBind<UIPageVirtualCamBlurCompBinder, List<UIPageVirtualCamera>> m_dlgCameraCollecter;

		// Token: 0x04035649 RID: 218697
		[Token(Token = "0x4035649")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_dlgMgr;

		// Token: 0x0403564A RID: 218698
		[Token(Token = "0x403564A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_actId;

		// Token: 0x0403564B RID: 218699
		[Token(Token = "0x403564B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0403564C RID: 218700
		[Token(Token = "0x403564C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__EnsureDlgCameraCollector;

		// Token: 0x0403564D RID: 218701
		[Token(Token = "0x403564D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ConstructCompDlgMgr;

		// Token: 0x0403564E RID: 218702
		[Token(Token = "0x403564E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__EnsureCameraSetter;

		// Token: 0x0403564F RID: 218703
		[Token(Token = "0x403564F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetDialogMgr;

		// Token: 0x04035650 RID: 218704
		[Token(Token = "0x4035650")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_HideDialogsImmediately;

		// Token: 0x04035651 RID: 218705
		[Token(Token = "0x4035651")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_LoadAllVirtualCamTypes;

		// Token: 0x04035652 RID: 218706
		[Token(Token = "0x4035652")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_InitVirtualCamera;

		// Token: 0x04035653 RID: 218707
		[Token(Token = "0x4035653")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_DisposeVirtualCamera;

		// Token: 0x04035654 RID: 218708
		[Token(Token = "0x4035654")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006753 RID: 26451
		[Token(Token = "0x2006753")]
		public class Params
		{
			// Token: 0x06025F5D RID: 155485 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025F5D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Params()
			{
			}

			// Token: 0x04035655 RID: 218709
			[Token(Token = "0x4035655")]
			[FieldOffset(Offset = "0x10")]
			public string actId;
		}
	}
}
