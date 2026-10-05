using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002594 RID: 9620
	[Token(Token = "0x2002594")]
	public class BattleUIBridge : SingletonWithMonoHost<BattleUIBridge, BattleController>, IDisposable
	{
		// Token: 0x0600F7FF RID: 63487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F7FF")]
		[Address(RVA = "0x6F14A0", Offset = "0x6F00A0", VA = "0x1806F14A0")]
		private BattleUIBridge()
		{
		}

		// Token: 0x0600F800 RID: 63488 RVA: 0x0005CE08 File Offset: 0x0005B008
		[Token(Token = "0x600F800")]
		public bool ShowCustomDialog<DialogType, OptionType>(UICustomDialogMgr.DynDialogParam dialogParam, OptionType options) where DialogType : UICustomDialog<OptionType>
		{
			return default(bool);
		}

		// Token: 0x0600F801 RID: 63489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F801")]
		[Address(RVA = "0x6F0970", Offset = "0x6EF570", VA = "0x1806F0970")]
		public void _OpenActivityPage(object arg)
		{
		}

		// Token: 0x0600F802 RID: 63490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F802")]
		[Address(RVA = "0x6F06D0", Offset = "0x6EF2D0", VA = "0x1806F06D0")]
		private void _OnInitCallback(object obj)
		{
		}

		// Token: 0x0600F803 RID: 63491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F803")]
		[Address(RVA = "0x6F1300", Offset = "0x6EFF00", VA = "0x1806F1300")]
		private void _SetupPageCtrlIfExist()
		{
		}

		// Token: 0x0600F804 RID: 63492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F804")]
		[Address(RVA = "0x6F1250", Offset = "0x6EFE50", VA = "0x1806F1250")]
		private IEnumerator _SetUpWhenUICameraControllerReady()
		{
			return null;
		}

		// Token: 0x0600F805 RID: 63493 RVA: 0x0005CE20 File Offset: 0x0005B020
		[Token(Token = "0x600F805")]
		[Address(RVA = "0x6F0420", Offset = "0x6EF020", VA = "0x1806F0420")]
		private bool _IsCameraLoading()
		{
			return default(bool);
		}

		// Token: 0x0600F806 RID: 63494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F806")]
		[Address(RVA = "0x6F0C70", Offset = "0x6EF870", VA = "0x1806F0C70")]
		private void _SetUpPageCtrlImpl()
		{
		}

		// Token: 0x0600F807 RID: 63495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F807")]
		[Address(RVA = "0x6F0740", Offset = "0x6EF340", VA = "0x1806F0740")]
		private void _OnOpenUIPage(object obj)
		{
		}

		// Token: 0x0600F808 RID: 63496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F808")]
		[Address(RVA = "0x6F0B50", Offset = "0x6EF750", VA = "0x1806F0B50")]
		private void _OpenPage(string key, UIPageOption param)
		{
		}

		// Token: 0x0600F809 RID: 63497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F809")]
		[Address(RVA = "0x6F05B0", Offset = "0x6EF1B0", VA = "0x1806F05B0")]
		private void _OnBattleCtrlDispose(object arg)
		{
		}

		// Token: 0x0600F80A RID: 63498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F80A")]
		[Address(RVA = "0x6F03C0", Offset = "0x6EEFC0", VA = "0x1806F03C0", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x0401139E RID: 70558
		[Token(Token = "0x401139E")]
		[FieldOffset(Offset = "0x10")]
		private bool m_inited;

		// Token: 0x0401139F RID: 70559
		[Token(Token = "0x401139F")]
		[FieldOffset(Offset = "0x18")]
		private Coroutine m_ctrlSetUpWaitCoroutine;

		// Token: 0x040113A0 RID: 70560
		[Token(Token = "0x40113A0")]
		[FieldOffset(Offset = "0x20")]
		private BattleUIBridge.PagePluginCtrl m_pagePluginCtrl;

		// Token: 0x040113A1 RID: 70561
		[Token(Token = "0x40113A1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040113A2 RID: 70562
		[Token(Token = "0x40113A2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ShowCustomDialog;

		// Token: 0x040113A3 RID: 70563
		[Token(Token = "0x40113A3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OpenActivityPage;

		// Token: 0x040113A4 RID: 70564
		[Token(Token = "0x40113A4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnInitCallback;

		// Token: 0x040113A5 RID: 70565
		[Token(Token = "0x40113A5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SetupPageCtrlIfExist;

		// Token: 0x040113A6 RID: 70566
		[Token(Token = "0x40113A6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SetUpWhenUICameraControllerReady;

		// Token: 0x040113A7 RID: 70567
		[Token(Token = "0x40113A7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__IsCameraLoading;

		// Token: 0x040113A8 RID: 70568
		[Token(Token = "0x40113A8")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__SetUpPageCtrlImpl;

		// Token: 0x040113A9 RID: 70569
		[Token(Token = "0x40113A9")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnOpenUIPage;

		// Token: 0x040113AA RID: 70570
		[Token(Token = "0x40113AA")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OpenPage;

		// Token: 0x040113AB RID: 70571
		[Token(Token = "0x40113AB")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnBattleCtrlDispose;

		// Token: 0x040113AC RID: 70572
		[Token(Token = "0x40113AC")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_Dispose;

		// Token: 0x02002595 RID: 9621
		[Token(Token = "0x2002595")]
		public class BattleActPageParam
		{
			// Token: 0x0600F80B RID: 63499 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F80B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public BattleActPageParam()
			{
			}

			// Token: 0x040113AD RID: 70573
			[Token(Token = "0x40113AD")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x040113AE RID: 70574
			[Token(Token = "0x40113AE")]
			[FieldOffset(Offset = "0x18")]
			public string pageName;

			// Token: 0x040113AF RID: 70575
			[Token(Token = "0x40113AF")]
			[FieldOffset(Offset = "0x20")]
			public UIPageOption option;
		}

		// Token: 0x02002596 RID: 9622
		[Token(Token = "0x2002596")]
		public interface IPauseBattlePage
		{
		}

		// Token: 0x02002597 RID: 9623
		[Token(Token = "0x2002597")]
		private class PagePlugin : UIPage.Plugin
		{
			// Token: 0x0600F80C RID: 63500 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F80C")]
			[Address(RVA = "0x713290", Offset = "0x711E90", VA = "0x180713290")]
			public PagePlugin(BattleUIBridge.PagePluginCtrl host, UIPage page)
			{
			}

			// Token: 0x0600F80D RID: 63501 RVA: 0x0005CE38 File Offset: 0x0005B038
			[Token(Token = "0x600F80D")]
			[Address(RVA = "0x712F80", Offset = "0x711B80", VA = "0x180712F80", Slot = "7")]
			public override bool OverrideStart(Action onStart)
			{
				return default(bool);
			}

			// Token: 0x0600F80E RID: 63502 RVA: 0x0005CE50 File Offset: 0x0005B050
			[Token(Token = "0x600F80E")]
			[Address(RVA = "0x712FF0", Offset = "0x711BF0", VA = "0x180712FF0", Slot = "8")]
			public override bool OverrideStop(Action onStop)
			{
				return default(bool);
			}

			// Token: 0x0600F80F RID: 63503 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F80F")]
			[Address(RVA = "0x713060", Offset = "0x711C60", VA = "0x180713060")]
			private void _PauseStateFromPage(UIPageTransType transType, bool needPause)
			{
			}

			// Token: 0x0600F810 RID: 63504 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F810")]
			[Address(RVA = "0x713160", Offset = "0x711D60", VA = "0x180713160")]
			private void _SetActivePerspectiveCamFromPage(bool active)
			{
			}

			// Token: 0x0600F811 RID: 63505 RVA: 0x0005CE68 File Offset: 0x0005B068
			[Token(Token = "0x600F811")]
			[Address(RVA = "0x712C80", Offset = "0x711880", VA = "0x180712C80", Slot = "5")]
			public override bool OverrideCreate(Action<DataBundle> onCreate, DataBundle savedInst)
			{
				return default(bool);
			}

			// Token: 0x0600F812 RID: 63506 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F812")]
			[Address(RVA = "0x712B40", Offset = "0x711740", VA = "0x180712B40", Slot = "11")]
			public override void OnDestroy()
			{
			}

			// Token: 0x040113B0 RID: 70576
			[Token(Token = "0x40113B0")]
			[FieldOffset(Offset = "0x18")]
			private int m_instId;

			// Token: 0x040113B1 RID: 70577
			[Token(Token = "0x40113B1")]
			[FieldOffset(Offset = "0x20")]
			private string m_name;

			// Token: 0x040113B2 RID: 70578
			[Token(Token = "0x40113B2")]
			[FieldOffset(Offset = "0x28")]
			private BattleUIBridge.PagePluginCtrl m_host;

			// Token: 0x040113B3 RID: 70579
			[Token(Token = "0x40113B3")]
			[FieldOffset(Offset = "0x30")]
			private bool m_hasPerspectiveCam;
		}

		// Token: 0x02002598 RID: 9624
		[Token(Token = "0x2002598")]
		private class PagePluginCtrl : UIPageController.PluginController
		{
			// Token: 0x17002085 RID: 8325
			// (get) Token: 0x0600F813 RID: 63507 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600F814 RID: 63508 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17002085")]
			public UIPageCameraProvider camProvider
			{
				[Token(Token = "0x600F813")]
				[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
				get
				{
					return null;
				}
				[Token(Token = "0x600F814")]
				[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
				set
				{
				}
			}

			// Token: 0x0600F815 RID: 63509 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F815")]
			[Address(RVA = "0x7128B0", Offset = "0x7114B0", VA = "0x1807128B0")]
			public void UpdatePauseStateFromPage(string pageName, bool needPause)
			{
			}

			// Token: 0x0600F816 RID: 63510 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F816")]
			[Address(RVA = "0x712950", Offset = "0x711550", VA = "0x180712950")]
			public void UpdatePerspectiveCamFromPage(int instId, bool active)
			{
			}

			// Token: 0x0600F817 RID: 63511 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F817")]
			[Address(RVA = "0x7126B0", Offset = "0x7112B0", VA = "0x1807126B0")]
			public void AddVirtualCamPage(IVirtualCameraPage page)
			{
			}

			// Token: 0x0600F818 RID: 63512 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F818")]
			[Address(RVA = "0x712810", Offset = "0x711410", VA = "0x180712810")]
			public void RemoveVirtualCamPage(IVirtualCameraPage page)
			{
			}

			// Token: 0x0600F819 RID: 63513 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F819")]
			[Address(RVA = "0x712760", Offset = "0x711360", VA = "0x180712760")]
			public void DisposePageVirtualCameras()
			{
			}

			// Token: 0x0600F81A RID: 63514 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F81A")]
			[Address(RVA = "0x712600", Offset = "0x711200", VA = "0x180712600", Slot = "4")]
			protected override void AddPlugin(UIPage page, Action<UIPage, UIPage.Plugin> pluginSetter)
			{
			}

			// Token: 0x0600F81B RID: 63515 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F81B")]
			[Address(RVA = "0x712A80", Offset = "0x711680", VA = "0x180712A80")]
			public PagePluginCtrl()
			{
			}

			// Token: 0x040113B4 RID: 70580
			[Token(Token = "0x40113B4")]
			[FieldOffset(Offset = "0x10")]
			private HashSet<int> m_perspectiveCamUsedPageInstIds;

			// Token: 0x040113B5 RID: 70581
			[Token(Token = "0x40113B5")]
			[FieldOffset(Offset = "0x18")]
			private EnableStateWithKey m_pauseByPage;

			// Token: 0x040113B6 RID: 70582
			[Token(Token = "0x40113B6")]
			[FieldOffset(Offset = "0x20")]
			private UIPageCameraProvider m_cameraProvider;

			// Token: 0x040113B7 RID: 70583
			[Token(Token = "0x40113B7")]
			[FieldOffset(Offset = "0x28")]
			private List<IVirtualCameraPage> m_virtualCameraPages;
		}
	}
}
