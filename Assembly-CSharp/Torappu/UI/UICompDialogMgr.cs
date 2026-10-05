using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Hypergryph.ToolKits;
using Il2CppDummyDll;
using Torappu.Gacha;
using Torappu.UI.CoreComp;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003A54 RID: 14932
	[Token(Token = "0x2003A54")]
	public class UICompDialogMgr : IHotfixable, AutoUnloadAssets.IHost
	{
		// Token: 0x0601799F RID: 96671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601799F")]
		[Address(RVA = "0xFF23D0", Offset = "0xFF0FD0", VA = "0x180FF23D0")]
		public static UICompDialogMgr Build(UICompDialogMgr.MgrBuilder mgrBuilder, UnityEngine.Object hostObj)
		{
			return null;
		}

		// Token: 0x060179A0 RID: 96672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60179A0")]
		[Address(RVA = "0xFF21A0", Offset = "0xFF0DA0", VA = "0x180FF21A0")]
		public static UICompDialogMgr BuildWithStandaloneState(UICompDialogMgr.MgrBuilder mgrBuilder, State state)
		{
			return null;
		}

		// Token: 0x060179A1 RID: 96673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60179A1")]
		[Address(RVA = "0xFF3470", Offset = "0xFF2070", VA = "0x180FF3470")]
		private static UICompDialogMgr _BuildImpl(UICompDialogMgr.MgrBuilder mgrBuilder, UICompDialogMgr.MgrHost host)
		{
			return null;
		}

		// Token: 0x060179A2 RID: 96674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60179A2")]
		[Address(RVA = "0xFF2A30", Offset = "0xFF1630", VA = "0x180FF2A30", Slot = "4")]
		public void CollectUsedAssets(ICollection<UnityEngine.Object> usedAssets)
		{
		}

		// Token: 0x060179A3 RID: 96675 RVA: 0x000975F0 File Offset: 0x000957F0
		[Token(Token = "0x60179A3")]
		public bool OpenDialog<Dialog, Input>(UICompBuilder<Dialog, Input> builder, out int instId, bool fastMode = false) where Dialog : UICompDialog<Input> where Input : class
		{
			return default(bool);
		}

		// Token: 0x060179A4 RID: 96676 RVA: 0x00097608 File Offset: 0x00095808
		[Token(Token = "0x60179A4")]
		[Address(RVA = "0xFF3260", Offset = "0xFF1E60", VA = "0x180FF3260")]
		public bool NonGeneric_OpenDialog(UICompDialogMgr.CompBaseBuilder builder, Type dialogType, out int instId, bool fastMode)
		{
			return default(bool);
		}

		// Token: 0x060179A5 RID: 96677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60179A5")]
		[Address(RVA = "0xFF2900", Offset = "0xFF1500", VA = "0x180FF2900")]
		public void CloseAllDialog()
		{
		}

		// Token: 0x060179A6 RID: 96678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60179A6")]
		[Address(RVA = "0xFF28A0", Offset = "0xFF14A0", VA = "0x180FF28A0")]
		public void ClearAllDialog()
		{
		}

		// Token: 0x060179A7 RID: 96679 RVA: 0x00097620 File Offset: 0x00095820
		[Token(Token = "0x60179A7")]
		[Address(RVA = "0xFF2760", Offset = "0xFF1360", VA = "0x180FF2760")]
		public bool CheckIfDialogOpen(int inst)
		{
			return default(bool);
		}

		// Token: 0x060179A8 RID: 96680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60179A8")]
		[Address(RVA = "0xFF2BF0", Offset = "0xFF17F0", VA = "0x180FF2BF0")]
		public void DialogOnly_OnDialogConfirm(int instId, ValueBundle value)
		{
		}

		// Token: 0x060179A9 RID: 96681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60179A9")]
		[Address(RVA = "0xFF4C70", Offset = "0xFF3870", VA = "0x180FF4C70")]
		private void _OnDialogClose(UICompDialogMgr.DialogCloseParam param)
		{
		}

		// Token: 0x060179AA RID: 96682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60179AA")]
		[Address(RVA = "0xFF49D0", Offset = "0xFF35D0", VA = "0x180FF49D0")]
		private IEnumerator _HideSingleDialogCoroutine(UICompDialogMgr.DialogBase dialog, UICompDialogMgr.DialogCloseParam param)
		{
			return null;
		}

		// Token: 0x060179AB RID: 96683 RVA: 0x00097638 File Offset: 0x00095838
		[Token(Token = "0x60179AB")]
		[Address(RVA = "0xFF4370", Offset = "0xFF2F70", VA = "0x180FF4370")]
		private static GenericPool<List<CustomYieldInstruction>>.Ref _HandleDialogCallback(UICompDialogMgr.DialogCloseParam param)
		{
			return default(GenericPool<List<CustomYieldInstruction>>.Ref);
		}

		// Token: 0x060179AC RID: 96684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60179AC")]
		[Address(RVA = "0xFF4820", Offset = "0xFF3420", VA = "0x180FF4820")]
		private IEnumerator _HideDialogCoroutine(UICompDialogMgr.DialogWrapper wrapper, UICompDialogMgr.DialogCloseParam param)
		{
			return null;
		}

		// Token: 0x060179AD RID: 96685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60179AD")]
		[Address(RVA = "0xFF4770", Offset = "0xFF3370", VA = "0x180FF4770")]
		private IEnumerator _HideAllDialogCoroutine()
		{
			return null;
		}

		// Token: 0x060179AE RID: 96686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60179AE")]
		[Address(RVA = "0xFF2E60", Offset = "0xFF1A60", VA = "0x180FF2E60")]
		public void GetViewAbleCameras(IList<Camera> cameras)
		{
		}

		// Token: 0x060179AF RID: 96687 RVA: 0x00097650 File Offset: 0x00095850
		[Token(Token = "0x60179AF")]
		[Address(RVA = "0xFF27F0", Offset = "0xFF13F0", VA = "0x180FF27F0")]
		public bool CheckIfValidCallback(Transform transform)
		{
			return default(bool);
		}

		// Token: 0x060179B0 RID: 96688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60179B0")]
		[Address(RVA = "0xFF4120", Offset = "0xFF2D20", VA = "0x180FF4120")]
		private List<Camera> _GetViewAbleCameras(IList<Camera> cameras, Camera rootCamera)
		{
			return null;
		}

		// Token: 0x060179B1 RID: 96689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60179B1")]
		[Address(RVA = "0xFF3A90", Offset = "0xFF2690", VA = "0x180FF3A90")]
		private UICompDialogMgr.DialogBase _CreateAndRegisterDialogInst(string resPath, Type dialogType, out bool isExistingInst)
		{
			return null;
		}

		// Token: 0x060179B2 RID: 96690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60179B2")]
		[Address(RVA = "0xFF38D0", Offset = "0xFF24D0", VA = "0x180FF38D0")]
		private void _ClearAllDialog()
		{
		}

		// Token: 0x060179B3 RID: 96691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60179B3")]
		[Address(RVA = "0xFF50A0", Offset = "0xFF3CA0", VA = "0x180FF50A0")]
		private void _ResumeAllDialog()
		{
		}

		// Token: 0x060179B4 RID: 96692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60179B4")]
		[Address(RVA = "0xFF4FE0", Offset = "0xFF3BE0", VA = "0x180FF4FE0")]
		private void _OnHostClosed()
		{
		}

		// Token: 0x060179B5 RID: 96693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60179B5")]
		[Address(RVA = "0xFF5040", Offset = "0xFF3C40", VA = "0x180FF5040")]
		private void _OnHostResumed()
		{
		}

		// Token: 0x060179B6 RID: 96694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60179B6")]
		[Address(RVA = "0xFF4B80", Offset = "0xFF3780", VA = "0x180FF4B80")]
		private void _ManagedDestroyDialog(UICompDialogMgr.DialogBase dialog)
		{
		}

		// Token: 0x060179B7 RID: 96695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60179B7")]
		private void _BindDialogCallbackImpl<CallbackHandler>(CallbackHandler handler, int instId) where CallbackHandler : Component, ICompDialogCallBack
		{
		}

		// Token: 0x060179B8 RID: 96696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60179B8")]
		public void BindStateCallBack<CallBackHandler>(CallBackHandler handler, int instId) where CallBackHandler : State, ICompDialogCallBack
		{
		}

		// Token: 0x060179B9 RID: 96697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60179B9")]
		public void BindPageComponentCallBack<CallBackHandler>(CallBackHandler handler, int instId) where CallBackHandler : PageComponent, ICompDialogCallBack
		{
		}

		// Token: 0x060179BA RID: 96698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60179BA")]
		public void BindPageCallBack<CallBackHandler>(CallBackHandler handler, int instId) where CallBackHandler : UIPage, ICompDialogCallBack
		{
		}

		// Token: 0x060179BB RID: 96699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60179BB")]
		public void BindDialogCallBack<CallBackHandler>(CallBackHandler handler, int instId) where CallBackHandler : UICompDialogMgr.DialogBase, ICompDialogCallBack
		{
		}

		// Token: 0x060179BC RID: 96700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60179BC")]
		public void BindGachaDlgMgrHostCallBack<CallBackHandler>(CallBackHandler handler, int instId) where CallBackHandler : GachaControllerDlgMgrHost, ICompDialogCallBack
		{
		}

		// Token: 0x060179BD RID: 96701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60179BD")]
		public void BindAllCallBack<CallBackHandler>(CallBackHandler handler) where CallBackHandler : ICompDialogCallBack
		{
		}

		// Token: 0x060179BE RID: 96702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60179BE")]
		public void BindDialogDestroyedCallBack<CallBackHandler>(CallBackHandler handler) where CallBackHandler : ICompDialogDestroyedCallback
		{
		}

		// Token: 0x060179BF RID: 96703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60179BF")]
		public void UnbindCallBack<CallBackHandler>(CallBackHandler handler) where CallBackHandler : ICompDialogCallBack
		{
		}

		// Token: 0x060179C0 RID: 96704 RVA: 0x00097668 File Offset: 0x00095868
		[Token(Token = "0x60179C0")]
		[Address(RVA = "0xFF3020", Offset = "0xFF1C20", VA = "0x180FF3020")]
		public bool IsUIStable()
		{
			return default(bool);
		}

		// Token: 0x060179C1 RID: 96705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60179C1")]
		[Address(RVA = "0xFF5240", Offset = "0xFF3E40", VA = "0x180FF5240")]
		public UICompDialogMgr()
		{
		}

		// Token: 0x0401C7BF RID: 116671
		[Token(Token = "0x401C7BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private ListDict<int, UICompDialogMgr.DialogWrapper> m_dialogDict;

		// Token: 0x0401C7C0 RID: 116672
		[Token(Token = "0x401C7C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<ICompDialogCallBack> m_allCallBackList;

		// Token: 0x0401C7C1 RID: 116673
		[Token(Token = "0x401C7C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ICompDialogDestroyedCallback m_dialogDestroyedCallBack;

		// Token: 0x0401C7C2 RID: 116674
		[Token(Token = "0x401C7C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform m_container;

		// Token: 0x0401C7C3 RID: 116675
		[Token(Token = "0x401C7C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Canvas m_canvas;

		// Token: 0x0401C7C4 RID: 116676
		[Token(Token = "0x401C7C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Camera m_camera;

		// Token: 0x0401C7C5 RID: 116677
		[Token(Token = "0x401C7C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<Camera> m_viewableCameras;

		// Token: 0x0401C7C6 RID: 116678
		[Token(Token = "0x401C7C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private UICompDialogMgr.MgrHost m_host;

		// Token: 0x0401C7C7 RID: 116679
		[Token(Token = "0x401C7C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private AutoUnloadAssets m_dialogLoader;

		// Token: 0x0401C7C8 RID: 116680
		[Token(Token = "0x401C7C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<int> m_hidingDialogInsts;

		// Token: 0x0401C7C9 RID: 116681
		[Token(Token = "0x401C7C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Build;

		// Token: 0x0401C7CA RID: 116682
		[Token(Token = "0x401C7CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_BuildWithStandaloneState;

		// Token: 0x0401C7CB RID: 116683
		[Token(Token = "0x401C7CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__BuildImpl;

		// Token: 0x0401C7CC RID: 116684
		[Token(Token = "0x401C7CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CollectUsedAssets;

		// Token: 0x0401C7CD RID: 116685
		[Token(Token = "0x401C7CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OpenDialog;

		// Token: 0x0401C7CE RID: 116686
		[Token(Token = "0x401C7CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_NonGeneric_OpenDialog;

		// Token: 0x0401C7CF RID: 116687
		[Token(Token = "0x401C7CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CloseAllDialog;

		// Token: 0x0401C7D0 RID: 116688
		[Token(Token = "0x401C7D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ClearAllDialog;

		// Token: 0x0401C7D1 RID: 116689
		[Token(Token = "0x401C7D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CheckIfDialogOpen;

		// Token: 0x0401C7D2 RID: 116690
		[Token(Token = "0x401C7D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_DialogOnly_OnDialogConfirm;

		// Token: 0x0401C7D3 RID: 116691
		[Token(Token = "0x401C7D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnDialogClose;

		// Token: 0x0401C7D4 RID: 116692
		[Token(Token = "0x401C7D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__HideSingleDialogCoroutine;

		// Token: 0x0401C7D5 RID: 116693
		[Token(Token = "0x401C7D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__HandleDialogCallback;

		// Token: 0x0401C7D6 RID: 116694
		[Token(Token = "0x401C7D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__HideDialogCoroutine;

		// Token: 0x0401C7D7 RID: 116695
		[Token(Token = "0x401C7D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__HideAllDialogCoroutine;

		// Token: 0x0401C7D8 RID: 116696
		[Token(Token = "0x401C7D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GetViewAbleCameras;

		// Token: 0x0401C7D9 RID: 116697
		[Token(Token = "0x401C7D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_CheckIfValidCallback;

		// Token: 0x0401C7DA RID: 116698
		[Token(Token = "0x401C7DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__GetViewAbleCameras;

		// Token: 0x0401C7DB RID: 116699
		[Token(Token = "0x401C7DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__CreateAndRegisterDialogInst;

		// Token: 0x0401C7DC RID: 116700
		[Token(Token = "0x401C7DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__ClearAllDialog;

		// Token: 0x0401C7DD RID: 116701
		[Token(Token = "0x401C7DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__ResumeAllDialog;

		// Token: 0x0401C7DE RID: 116702
		[Token(Token = "0x401C7DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__OnHostClosed;

		// Token: 0x0401C7DF RID: 116703
		[Token(Token = "0x401C7DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__OnHostResumed;

		// Token: 0x0401C7E0 RID: 116704
		[Token(Token = "0x401C7E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__ManagedDestroyDialog;

		// Token: 0x0401C7E1 RID: 116705
		[Token(Token = "0x401C7E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__BindDialogCallbackImpl;

		// Token: 0x0401C7E2 RID: 116706
		[Token(Token = "0x401C7E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_BindStateCallBack;

		// Token: 0x0401C7E3 RID: 116707
		[Token(Token = "0x401C7E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_BindPageComponentCallBack;

		// Token: 0x0401C7E4 RID: 116708
		[Token(Token = "0x401C7E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_BindPageCallBack;

		// Token: 0x0401C7E5 RID: 116709
		[Token(Token = "0x401C7E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_BindDialogCallBack;

		// Token: 0x0401C7E6 RID: 116710
		[Token(Token = "0x401C7E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_BindGachaDlgMgrHostCallBack;

		// Token: 0x0401C7E7 RID: 116711
		[Token(Token = "0x401C7E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_BindAllCallBack;

		// Token: 0x0401C7E8 RID: 116712
		[Token(Token = "0x401C7E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_BindDialogDestroyedCallBack;

		// Token: 0x0401C7E9 RID: 116713
		[Token(Token = "0x401C7E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_UnbindCallBack;

		// Token: 0x0401C7EA RID: 116714
		[Token(Token = "0x401C7EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_IsUIStable;

		// Token: 0x0401C7EB RID: 116715
		[Token(Token = "0x401C7EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003A55 RID: 14933
		[Token(Token = "0x2003A55")]
		public abstract class DialogBase : MonoBehaviour, ILoadAsset, IHotfixable
		{
			// Token: 0x170038B5 RID: 14517
			// (get) Token: 0x060179C2 RID: 96706 RVA: 0x00097680 File Offset: 0x00095880
			// (set) Token: 0x060179C3 RID: 96707 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170038B5")]
			public int instId
			{
				[Token(Token = "0x60179C2")]
				[Address(RVA = "0xFE8EE0", Offset = "0xFE7AE0", VA = "0x180FE8EE0")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x60179C3")]
				[Address(RVA = "0xFE9000", Offset = "0xFE7C00", VA = "0x180FE9000")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170038B6 RID: 14518
			// (get) Token: 0x060179C4 RID: 96708 RVA: 0x00097698 File Offset: 0x00095898
			// (set) Token: 0x060179C5 RID: 96709 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170038B6")]
			public bool isAboutToClose
			{
				[Token(Token = "0x60179C4")]
				[Address(RVA = "0xFE8F40", Offset = "0xFE7B40", VA = "0x180FE8F40")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60179C5")]
				[Address(RVA = "0xFE9070", Offset = "0xFE7C70", VA = "0x180FE9070")]
				set
				{
				}
			}

			// Token: 0x170038B7 RID: 14519
			// (get) Token: 0x060179C6 RID: 96710 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060179C7 RID: 96711 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170038B7")]
			private protected UICompDialogMgr uiCompDialogMgr
			{
				[Token(Token = "0x60179C6")]
				[Address(RVA = "0xFE8FA0", Offset = "0xFE7BA0", VA = "0x180FE8FA0")]
				[CompilerGenerated]
				protected get
				{
					return null;
				}
				[Token(Token = "0x60179C7")]
				[Address(RVA = "0xFE90E0", Offset = "0xFE7CE0", VA = "0x180FE90E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x060179C8 RID: 96712 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60179C8")]
			[Address(RVA = "0xFE88D0", Offset = "0xFE74D0", VA = "0x180FE88D0")]
			private ILoadAsset _EnsureLoadAsset()
			{
				return null;
			}

			// Token: 0x060179C9 RID: 96713 RVA: 0x000976B0 File Offset: 0x000958B0
			[Token(Token = "0x60179C9")]
			[Address(RVA = "0xFE7350", Offset = "0xFE5F50", VA = "0x180FE7350", Slot = "7")]
			public virtual bool AllowDuplicateInst()
			{
				return default(bool);
			}

			// Token: 0x060179CA RID: 96714 RVA: 0x000976C8 File Offset: 0x000958C8
			[Token(Token = "0x60179CA")]
			[Address(RVA = "0xFE7E90", Offset = "0xFE6A90", VA = "0x180FE7E90", Slot = "8")]
			protected virtual bool IgnoreTimeScale()
			{
				return default(bool);
			}

			// Token: 0x060179CB RID: 96715 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60179CB")]
			[Address(RVA = "0xFE84D0", Offset = "0xFE70D0", VA = "0x180FE84D0", Slot = "9")]
			protected virtual void OnInit()
			{
			}

			// Token: 0x060179CC RID: 96716 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60179CC")]
			[Address(RVA = "0xFE8470", Offset = "0xFE7070", VA = "0x180FE8470", Slot = "10")]
			protected virtual void OnFinishShowTransition()
			{
			}

			// Token: 0x060179CD RID: 96717 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60179CD")]
			[Address(RVA = "0xFE8300", Offset = "0xFE6F00", VA = "0x180FE8300", Slot = "11")]
			protected virtual void OnDestroySubClass()
			{
			}

			// Token: 0x060179CE RID: 96718 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60179CE")]
			[Address(RVA = "0xFE8530", Offset = "0xFE7130", VA = "0x180FE8530", Slot = "12")]
			protected virtual void OnResume()
			{
			}

			// Token: 0x060179CF RID: 96719 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60179CF")]
			[Address(RVA = "0xFE73B0", Offset = "0xFE5FB0", VA = "0x180FE73B0", Slot = "13")]
			protected virtual void BeforeHide()
			{
			}

			// Token: 0x060179D0 RID: 96720 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60179D0")]
			[Address(RVA = "0xFE7C60", Offset = "0xFE6860", VA = "0x180FE7C60", Slot = "14")]
			public virtual UISwitchTween GenerateShowTween()
			{
				return null;
			}

			// Token: 0x060179D1 RID: 96721 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60179D1")]
			[Address(RVA = "0xFE7E30", Offset = "0xFE6A30", VA = "0x180FE7E30", Slot = "15")]
			protected virtual UIRenderTextureImage GetBlurTarget()
			{
				return null;
			}

			// Token: 0x060179D2 RID: 96722
			[Token(Token = "0x60179D2")]
			protected abstract void OnSetInput(object input);

			// Token: 0x060179D3 RID: 96723 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60179D3")]
			[Address(RVA = "0xFE82A0", Offset = "0xFE6EA0", VA = "0x180FE82A0", Slot = "17")]
			protected virtual void OnBecomeVisible()
			{
			}

			// Token: 0x060179D4 RID: 96724 RVA: 0x000976E0 File Offset: 0x000958E0
			[Token(Token = "0x60179D4")]
			[Address(RVA = "0xFE7FF0", Offset = "0xFE6BF0", VA = "0x180FE7FF0")]
			public bool IsUIStable()
			{
				return default(bool);
			}

			// Token: 0x060179D5 RID: 96725 RVA: 0x000976F8 File Offset: 0x000958F8
			[Token(Token = "0x60179D5")]
			[Address(RVA = "0xFE7EF0", Offset = "0xFE6AF0", VA = "0x180FE7EF0")]
			public bool IsTransiting()
			{
				return default(bool);
			}

			// Token: 0x060179D6 RID: 96726 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60179D6")]
			[Address(RVA = "0xFE85B0", Offset = "0xFE71B0", VA = "0x180FE85B0")]
			public void SetListener(UICompDialogMgr.DialogBase.Listener listener)
			{
			}

			// Token: 0x060179D7 RID: 96727 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60179D7")]
			[Address(RVA = "0xFE7500", Offset = "0xFE6100", VA = "0x180FE7500")]
			public void DialogMgrOnly_Init(int instId, UICompDialogMgr dialogMgr)
			{
			}

			// Token: 0x060179D8 RID: 96728 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60179D8")]
			[Address(RVA = "0xFE7A80", Offset = "0xFE6680", VA = "0x180FE7A80")]
			public void DialogMgrOnly_TriggerResume()
			{
			}

			// Token: 0x060179D9 RID: 96729 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60179D9")]
			[Address(RVA = "0xFE7410", Offset = "0xFE6010", VA = "0x180FE7410")]
			public ILoadAsset DialogMgrOnly_GetCurrentAssetGroup()
			{
				return null;
			}

			// Token: 0x060179DA RID: 96730 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60179DA")]
			[Address(RVA = "0xFE7B00", Offset = "0xFE6700", VA = "0x180FE7B00")]
			public IEnumerator DialogMgrOnly_YieldHide()
			{
				return null;
			}

			// Token: 0x060179DB RID: 96731 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60179DB")]
			[Address(RVA = "0xFE7470", Offset = "0xFE6070", VA = "0x180FE7470")]
			public UICompDialogMgr DialogMgrOnly_GetDialogMgr()
			{
				return null;
			}

			// Token: 0x060179DC RID: 96732 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60179DC")]
			[Address(RVA = "0xFE8630", Offset = "0xFE7230", VA = "0x180FE8630")]
			protected void SetStableLock(int signal)
			{
			}

			// Token: 0x060179DD RID: 96733 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60179DD")]
			[Address(RVA = "0xFE8850", Offset = "0xFE7450", VA = "0x180FE8850")]
			protected void UnsetStableLock(int signal)
			{
			}

			// Token: 0x060179DE RID: 96734 RVA: 0x00097710 File Offset: 0x00095910
			[Token(Token = "0x60179DE")]
			[Address(RVA = "0xFE8C40", Offset = "0xFE7840", VA = "0x180FE8C40")]
			private bool _IsTransiting()
			{
				return default(bool);
			}

			// Token: 0x060179DF RID: 96735 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60179DF")]
			[Address(RVA = "0xFE89E0", Offset = "0xFE75E0", VA = "0x180FE89E0")]
			private void _GetViewableCameras(IList<Camera> camera)
			{
			}

			// Token: 0x060179E0 RID: 96736 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60179E0")]
			[Address(RVA = "0xFE8D40", Offset = "0xFE7940", VA = "0x180FE8D40")]
			private void _TrySetBlurImg()
			{
			}

			// Token: 0x060179E1 RID: 96737 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60179E1")]
			[Address(RVA = "0xFE76A0", Offset = "0xFE62A0", VA = "0x180FE76A0")]
			public void DialogMgrOnly_SetDialogOpen(bool fastMode = false)
			{
			}

			// Token: 0x060179E2 RID: 96738 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60179E2")]
			[Address(RVA = "0xFE79F0", Offset = "0xFE65F0", VA = "0x180FE79F0")]
			public void DialogMgrOnly_SetInput(object input)
			{
			}

			// Token: 0x060179E3 RID: 96739 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60179E3")]
			[Address(RVA = "0xFE8360", Offset = "0xFE6F60", VA = "0x180FE8360")]
			protected void OnDestroy()
			{
			}

			// Token: 0x060179E4 RID: 96740 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60179E4")]
			public T LoadAsset<T>(string path) where T : UnityEngine.Object
			{
				return null;
			}

			// Token: 0x060179E5 RID: 96741 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60179E5")]
			[Address(RVA = "0xFE8210", Offset = "0xFE6E10", VA = "0x180FE8210", Slot = "5")]
			public UnityEngine.Object LoadAsset(string path)
			{
				return null;
			}

			// Token: 0x060179E6 RID: 96742 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60179E6")]
			[Address(RVA = "0xFE86B0", Offset = "0xFE72B0", VA = "0x180FE86B0", Slot = "6")]
			public void UnloadAsset(UnityEngine.Object asset)
			{
			}

			// Token: 0x060179E7 RID: 96743 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60179E7")]
			[Address(RVA = "0xFE7BB0", Offset = "0xFE67B0", VA = "0x180FE7BB0")]
			public AutoReleasableGroup EnsureReleasables()
			{
				return null;
			}

			// Token: 0x060179E8 RID: 96744 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60179E8")]
			[Address(RVA = "0xFE8E80", Offset = "0xFE7A80", VA = "0x180FE8E80")]
			protected DialogBase()
			{
			}

			// Token: 0x0401C7EC RID: 116716
			[Token(Token = "0x401C7EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private ILoadAsset m_assetGroup;

			// Token: 0x0401C7ED RID: 116717
			[Token(Token = "0x401C7ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UISwitchTween m_showTween;

			// Token: 0x0401C7EE RID: 116718
			[Token(Token = "0x401C7EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UICoreCompStore<UICompDialogMgr.DialogBase> m_coreCompBinder;

			// Token: 0x0401C7EF RID: 116719
			[Token(Token = "0x401C7EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private bool m_isAboutToClose;

			// Token: 0x0401C7F0 RID: 116720
			[Token(Token = "0x401C7F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private int m_stableLock;

			// Token: 0x0401C7F1 RID: 116721
			[Token(Token = "0x401C7F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UICompDialogMgr.DialogBase.Listener m_listener;

			// Token: 0x0401C7F2 RID: 116722
			[Token(Token = "0x401C7F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private AutoReleasableGroup m_autoReleasableGroup;

			// Token: 0x0401C7F5 RID: 116725
			[Token(Token = "0x401C7F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_instId;

			// Token: 0x0401C7F6 RID: 116726
			[Token(Token = "0x401C7F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_instId;

			// Token: 0x0401C7F7 RID: 116727
			[Token(Token = "0x401C7F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_isAboutToClose;

			// Token: 0x0401C7F8 RID: 116728
			[Token(Token = "0x401C7F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_isAboutToClose;

			// Token: 0x0401C7F9 RID: 116729
			[Token(Token = "0x401C7F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_uiCompDialogMgr;

			// Token: 0x0401C7FA RID: 116730
			[Token(Token = "0x401C7FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_set_uiCompDialogMgr;

			// Token: 0x0401C7FB RID: 116731
			[Token(Token = "0x401C7FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0__EnsureLoadAsset;

			// Token: 0x0401C7FC RID: 116732
			[Token(Token = "0x401C7FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_AllowDuplicateInst;

			// Token: 0x0401C7FD RID: 116733
			[Token(Token = "0x401C7FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_IgnoreTimeScale;

			// Token: 0x0401C7FE RID: 116734
			[Token(Token = "0x401C7FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_OnInit;

			// Token: 0x0401C7FF RID: 116735
			[Token(Token = "0x401C7FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_OnFinishShowTransition;

			// Token: 0x0401C800 RID: 116736
			[Token(Token = "0x401C800")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_OnDestroySubClass;

			// Token: 0x0401C801 RID: 116737
			[Token(Token = "0x401C801")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_OnResume;

			// Token: 0x0401C802 RID: 116738
			[Token(Token = "0x401C802")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_BeforeHide;

			// Token: 0x0401C803 RID: 116739
			[Token(Token = "0x401C803")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_GenerateShowTween;

			// Token: 0x0401C804 RID: 116740
			[Token(Token = "0x401C804")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix0_GetBlurTarget;

			// Token: 0x0401C805 RID: 116741
			[Token(Token = "0x401C805")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private static DelegateBridge __Hotfix0_OnBecomeVisible;

			// Token: 0x0401C806 RID: 116742
			[Token(Token = "0x401C806")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private static DelegateBridge __Hotfix0_IsUIStable;

			// Token: 0x0401C807 RID: 116743
			[Token(Token = "0x401C807")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private static DelegateBridge __Hotfix0_IsTransiting;

			// Token: 0x0401C808 RID: 116744
			[Token(Token = "0x401C808")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private static DelegateBridge __Hotfix0_SetListener;

			// Token: 0x0401C809 RID: 116745
			[Token(Token = "0x401C809")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private static DelegateBridge __Hotfix0_DialogMgrOnly_Init;

			// Token: 0x0401C80A RID: 116746
			[Token(Token = "0x401C80A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private static DelegateBridge __Hotfix0_DialogMgrOnly_TriggerResume;

			// Token: 0x0401C80B RID: 116747
			[Token(Token = "0x401C80B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private static DelegateBridge __Hotfix0_DialogMgrOnly_GetCurrentAssetGroup;

			// Token: 0x0401C80C RID: 116748
			[Token(Token = "0x401C80C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private static DelegateBridge __Hotfix0_DialogMgrOnly_YieldHide;

			// Token: 0x0401C80D RID: 116749
			[Token(Token = "0x401C80D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private static DelegateBridge __Hotfix0_DialogMgrOnly_GetDialogMgr;

			// Token: 0x0401C80E RID: 116750
			[Token(Token = "0x401C80E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private static DelegateBridge __Hotfix0_SetStableLock;

			// Token: 0x0401C80F RID: 116751
			[Token(Token = "0x401C80F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			private static DelegateBridge __Hotfix0_UnsetStableLock;

			// Token: 0x0401C810 RID: 116752
			[Token(Token = "0x401C810")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			private static DelegateBridge __Hotfix0__IsTransiting;

			// Token: 0x0401C811 RID: 116753
			[Token(Token = "0x401C811")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			private static DelegateBridge __Hotfix0__GetViewableCameras;

			// Token: 0x0401C812 RID: 116754
			[Token(Token = "0x401C812")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private static DelegateBridge __Hotfix0__TrySetBlurImg;

			// Token: 0x0401C813 RID: 116755
			[Token(Token = "0x401C813")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			private static DelegateBridge __Hotfix0_DialogMgrOnly_SetDialogOpen;

			// Token: 0x0401C814 RID: 116756
			[Token(Token = "0x401C814")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private static DelegateBridge __Hotfix0_DialogMgrOnly_SetInput;

			// Token: 0x0401C815 RID: 116757
			[Token(Token = "0x401C815")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
			private static DelegateBridge __Hotfix0_OnDestroy;

			// Token: 0x0401C816 RID: 116758
			[Token(Token = "0x401C816")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			private static DelegateBridge __Hotfix0_LoadAsset;

			// Token: 0x0401C817 RID: 116759
			[Token(Token = "0x401C817")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
			private static DelegateBridge __Hotfix1_LoadAsset;

			// Token: 0x0401C818 RID: 116760
			[Token(Token = "0x401C818")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			private static DelegateBridge __Hotfix0_UnloadAsset;

			// Token: 0x0401C819 RID: 116761
			[Token(Token = "0x401C819")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			private static DelegateBridge __Hotfix0_EnsureReleasables;

			// Token: 0x0401C81A RID: 116762
			[Token(Token = "0x401C81A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x02003A56 RID: 14934
			[Token(Token = "0x2003A56")]
			public interface IServiceHandler : IHotfixable
			{
				// Token: 0x170038B8 RID: 14520
				// (get) Token: 0x060179E9 RID: 96745
				[Token(Token = "0x170038B8")]
				UICompDialogMgr.DialogBase dialog { [Token(Token = "0x60179E9")] get; }

				// Token: 0x170038B9 RID: 14521
				// (get) Token: 0x060179EA RID: 96746
				[Token(Token = "0x170038B9")]
				string serviceCode { [Token(Token = "0x60179EA")] get; }

				// Token: 0x060179EB RID: 96747
				[Token(Token = "0x60179EB")]
				void SendRequest(ValueBundle param);
			}

			// Token: 0x02003A57 RID: 14935
			[Token(Token = "0x2003A57")]
			public abstract class ServiceHandler<TRequest, TResponse> : UICompDialogMgr.DialogBase.IServiceHandler, IHotfixable where TResponse : PlayerDeltaResponse
			{
				// Token: 0x060179EC RID: 96748
				[Token(Token = "0x60179EC")]
				protected abstract TRequest GetRequest(ValueBundle param);

				// Token: 0x060179ED RID: 96749
				[Token(Token = "0x60179ED")]
				protected abstract void OnServiceSuccess(TResponse response);

				// Token: 0x170038BA RID: 14522
				// (get) Token: 0x060179EE RID: 96750
				[Token(Token = "0x170038BA")]
				protected abstract int serviceLockSignal { [Token(Token = "0x60179EE")] get; }

				// Token: 0x170038BB RID: 14523
				// (get) Token: 0x060179EF RID: 96751
				[Token(Token = "0x170038BB")]
				public abstract string serviceCode { [Token(Token = "0x60179EF")] get; }

				// Token: 0x170038BC RID: 14524
				// (get) Token: 0x060179F0 RID: 96752 RVA: 0x00097728 File Offset: 0x00095928
				[Token(Token = "0x170038BC")]
				protected virtual UISender.LoadMaskType loadMaskType
				{
					[Token(Token = "0x60179F0")]
					get
					{
						return UISender.LoadMaskType.POP_FLOAT;
					}
				}

				// Token: 0x170038BD RID: 14525
				// (get) Token: 0x060179F1 RID: 96753 RVA: 0x00002050 File Offset: 0x00000250
				// (set) Token: 0x060179F2 RID: 96754 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x170038BD")]
				public UICompDialogMgr.DialogBase dialog
				{
					[Token(Token = "0x60179F1")]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[Token(Token = "0x60179F2")]
					[CompilerGenerated]
					protected set
					{
					}
				}

				// Token: 0x060179F3 RID: 96755 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60179F3")]
				public void SendRequest(ValueBundle param)
				{
				}

				// Token: 0x060179F4 RID: 96756 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60179F4")]
				private void _HandleServiceSucDelegate(TResponse response)
				{
				}

				// Token: 0x060179F5 RID: 96757 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60179F5")]
				private void _HandleServiceFinalDelegate()
				{
				}

				// Token: 0x060179F6 RID: 96758 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60179F6")]
				protected ServiceHandler()
				{
				}

				// Token: 0x0401C81B RID: 116763
				[Token(Token = "0x401C81B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private Action<TResponse> m_serviceSucDelegate;

				// Token: 0x0401C81C RID: 116764
				[Token(Token = "0x401C81C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private Action m_serviceFinalDelegate;

				// Token: 0x0401C81E RID: 116766
				[Token(Token = "0x401C81E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_get_loadMaskType;

				// Token: 0x0401C81F RID: 116767
				[Token(Token = "0x401C81F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_get_dialog;

				// Token: 0x0401C820 RID: 116768
				[Token(Token = "0x401C820")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_set_dialog;

				// Token: 0x0401C821 RID: 116769
				[Token(Token = "0x401C821")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_SendRequest;

				// Token: 0x0401C822 RID: 116770
				[Token(Token = "0x401C822")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0__HandleServiceSucDelegate;

				// Token: 0x0401C823 RID: 116771
				[Token(Token = "0x401C823")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0__HandleServiceFinalDelegate;

				// Token: 0x0401C824 RID: 116772
				[Token(Token = "0x401C824")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}

			// Token: 0x02003A58 RID: 14936
			[Token(Token = "0x2003A58")]
			public class Listener : IHotfixable
			{
				// Token: 0x060179F7 RID: 96759 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60179F7")]
				[Address(RVA = "0xFEA6D0", Offset = "0xFE92D0", VA = "0x180FEA6D0")]
				public Listener()
				{
				}

				// Token: 0x0401C825 RID: 116773
				[Token(Token = "0x401C825")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public Action onResume;

				// Token: 0x0401C826 RID: 116774
				[Token(Token = "0x401C826")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public Action onDestroy;

				// Token: 0x0401C827 RID: 116775
				[Token(Token = "0x401C827")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}
		}

		// Token: 0x02003A5A RID: 14938
		[Token(Token = "0x2003A5A")]
		private struct DialogCloseParam
		{
			// Token: 0x0401C82B RID: 116779
			[Token(Token = "0x401C82B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ICompDialogCallBack callback;

			// Token: 0x0401C82C RID: 116780
			[Token(Token = "0x401C82C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int instId;

			// Token: 0x0401C82D RID: 116781
			[Token(Token = "0x401C82D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ValueBundle value;

			// Token: 0x0401C82E RID: 116782
			[Token(Token = "0x401C82E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public List<ICompDialogCallBack> allCallbackList;

			// Token: 0x0401C82F RID: 116783
			[Token(Token = "0x401C82F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly UICompDialogMgr.DialogCloseParam EMPTY;
		}

		// Token: 0x02003A5B RID: 14939
		[Token(Token = "0x2003A5B")]
		private class DialogWrapper : IHotfixable
		{
			// Token: 0x170038C0 RID: 14528
			// (get) Token: 0x060179FF RID: 96767 RVA: 0x00097758 File Offset: 0x00095958
			// (set) Token: 0x06017A00 RID: 96768 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170038C0")]
			public bool isAboutToClose
			{
				[Token(Token = "0x60179FF")]
				[Address(RVA = "0xFE9300", Offset = "0xFE7F00", VA = "0x180FE9300")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6017A00")]
				[Address(RVA = "0xFE9370", Offset = "0xFE7F70", VA = "0x180FE9370")]
				set
				{
				}
			}

			// Token: 0x06017A01 RID: 96769 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017A01")]
			[Address(RVA = "0xFE92A0", Offset = "0xFE7EA0", VA = "0x180FE92A0")]
			public DialogWrapper()
			{
			}

			// Token: 0x0401C830 RID: 116784
			[Token(Token = "0x401C830")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private bool m_isAboutToClose;

			// Token: 0x0401C831 RID: 116785
			[Token(Token = "0x401C831")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			private bool m_isExited;

			// Token: 0x0401C832 RID: 116786
			[Token(Token = "0x401C832")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GameObject prefab;

			// Token: 0x0401C833 RID: 116787
			[Token(Token = "0x401C833")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UICompDialogMgr.DialogBase dialog;

			// Token: 0x0401C834 RID: 116788
			[Token(Token = "0x401C834")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Component callback;

			// Token: 0x0401C835 RID: 116789
			[Token(Token = "0x401C835")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_isAboutToClose;

			// Token: 0x0401C836 RID: 116790
			[Token(Token = "0x401C836")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_isAboutToClose;

			// Token: 0x0401C837 RID: 116791
			[Token(Token = "0x401C837")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003A5C RID: 14940
		[Token(Token = "0x2003A5C")]
		public struct MgrBuilder : IHotfixable
		{
			// Token: 0x06017A02 RID: 96770 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017A02")]
			[Address(RVA = "0xFEB8A0", Offset = "0xFEA4A0", VA = "0x180FEB8A0")]
			public MgrBuilder(Transform i_container, [Optional] UICompDialogMgr.MgrBuilder.LoadMgrHostDelegate func)
			{
			}

			// Token: 0x06017A03 RID: 96771 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017A03")]
			[Address(RVA = "0xFEB7D0", Offset = "0xFEA3D0", VA = "0x180FEB7D0")]
			public MgrBuilder(Transform i_container, List<Camera> viewCameras, [Optional] UICompDialogMgr.MgrBuilder.LoadMgrHostDelegate func)
			{
			}

			// Token: 0x0401C838 RID: 116792
			[Token(Token = "0x401C838")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Transform container;

			// Token: 0x0401C839 RID: 116793
			[Token(Token = "0x401C839")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public List<Camera> viewableCameras;

			// Token: 0x0401C83A RID: 116794
			[Token(Token = "0x401C83A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UICompDialogMgr.MgrBuilder.LoadMgrHostDelegate loadMgrHostDelegate;

			// Token: 0x0401C83B RID: 116795
			[Token(Token = "0x401C83B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401C83C RID: 116796
			[Token(Token = "0x401C83C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix1_ctor;

			// Token: 0x02003A5D RID: 14941
			// (Invoke) Token: 0x06017A05 RID: 96773
			[Token(Token = "0x2003A5D")]
			public delegate UICompDialogMgr.MgrHost LoadMgrHostDelegate();
		}

		// Token: 0x02003A5E RID: 14942
		[Token(Token = "0x2003A5E")]
		public abstract class CompBaseBuilder : IHotfixable
		{
			// Token: 0x06017A08 RID: 96776
			[Token(Token = "0x6017A08")]
			public abstract object GetInput();

			// Token: 0x06017A09 RID: 96777 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017A09")]
			[Address(RVA = "0xFE2B70", Offset = "0xFE1770", VA = "0x180FE2B70")]
			protected CompBaseBuilder()
			{
			}

			// Token: 0x0401C83D RID: 116797
			[Token(Token = "0x401C83D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string resPath;

			// Token: 0x0401C83E RID: 116798
			[Token(Token = "0x401C83E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003A5F RID: 14943
		[Token(Token = "0x2003A5F")]
		public abstract class MgrHost : IHotfixable
		{
			// Token: 0x06017A0A RID: 96778
			[Token(Token = "0x6017A0A")]
			public abstract bool Validate();

			// Token: 0x06017A0B RID: 96779
			[Token(Token = "0x6017A0B")]
			public abstract void SetOnHostClosedCallback(Action onHostClosed);

			// Token: 0x06017A0C RID: 96780
			[Token(Token = "0x6017A0C")]
			public abstract void SetOnHostResumedCallback(Action onHostResumed);

			// Token: 0x06017A0D RID: 96781
			[Token(Token = "0x6017A0D")]
			public abstract ILoadAsset CreateAssetGroupForDialog(UICompDialogMgr.DialogBase dialog);

			// Token: 0x06017A0E RID: 96782
			[Token(Token = "0x6017A0E")]
			public abstract void DisposeAssetGroupOfDialog(UICompDialogMgr.DialogBase dialog);

			// Token: 0x06017A0F RID: 96783
			[Token(Token = "0x6017A0F")]
			public abstract ILoadAsset CreateAssetGroupForContainer(Transform container);

			// Token: 0x06017A10 RID: 96784
			[Token(Token = "0x6017A10")]
			public abstract bool CheckIfValidCallback(Transform callbackTransform);

			// Token: 0x06017A11 RID: 96785
			[Token(Token = "0x6017A11")]
			public abstract Coroutine CoroutineWithHost(IEnumerator routine);

			// Token: 0x06017A12 RID: 96786
			[Token(Token = "0x6017A12")]
			public abstract bool IsUIStable();

			// Token: 0x06017A13 RID: 96787 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017A13")]
			[Address(RVA = "0xFEDE40", Offset = "0xFECA40", VA = "0x180FEDE40")]
			protected MgrHost()
			{
			}

			// Token: 0x0401C83F RID: 116799
			[Token(Token = "0x401C83F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003A60 RID: 14944
		[Token(Token = "0x2003A60")]
		private class MgrHostWithPage : UICompDialogMgr.MgrHost
		{
			// Token: 0x06017A14 RID: 96788 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017A14")]
			[Address(RVA = "0xFEC9D0", Offset = "0xFEB5D0", VA = "0x180FEC9D0")]
			public MgrHostWithPage(UIPage page)
			{
			}

			// Token: 0x06017A15 RID: 96789 RVA: 0x00097770 File Offset: 0x00095970
			[Token(Token = "0x6017A15")]
			[Address(RVA = "0xFEC860", Offset = "0xFEB460", VA = "0x180FEC860", Slot = "4")]
			public override bool Validate()
			{
				return default(bool);
			}

			// Token: 0x06017A16 RID: 96790 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6017A16")]
			[Address(RVA = "0xFEC4E0", Offset = "0xFEB0E0", VA = "0x180FEC4E0", Slot = "7")]
			public override ILoadAsset CreateAssetGroupForDialog(UICompDialogMgr.DialogBase dialog)
			{
				return null;
			}

			// Token: 0x06017A17 RID: 96791 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6017A17")]
			[Address(RVA = "0xFEC460", Offset = "0xFEB060", VA = "0x180FEC460", Slot = "9")]
			public override ILoadAsset CreateAssetGroupForContainer(Transform container)
			{
				return null;
			}

			// Token: 0x06017A18 RID: 96792 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017A18")]
			[Address(RVA = "0xFEC560", Offset = "0xFEB160", VA = "0x180FEC560", Slot = "8")]
			public override void DisposeAssetGroupOfDialog(UICompDialogMgr.DialogBase dialog)
			{
			}

			// Token: 0x06017A19 RID: 96793 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017A19")]
			[Address(RVA = "0xFEC760", Offset = "0xFEB360", VA = "0x180FEC760", Slot = "5")]
			public override void SetOnHostClosedCallback(Action onHostClosed)
			{
			}

			// Token: 0x06017A1A RID: 96794 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017A1A")]
			[Address(RVA = "0xFEC7E0", Offset = "0xFEB3E0", VA = "0x180FEC7E0", Slot = "6")]
			public override void SetOnHostResumedCallback(Action onHostResumed)
			{
			}

			// Token: 0x06017A1B RID: 96795 RVA: 0x00097788 File Offset: 0x00095988
			[Token(Token = "0x6017A1B")]
			[Address(RVA = "0xFEC340", Offset = "0xFEAF40", VA = "0x180FEC340", Slot = "10")]
			public override bool CheckIfValidCallback(Transform callbackTransform)
			{
				return default(bool);
			}

			// Token: 0x06017A1C RID: 96796 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6017A1C")]
			[Address(RVA = "0xFEC3E0", Offset = "0xFEAFE0", VA = "0x180FEC3E0", Slot = "11")]
			public override Coroutine CoroutineWithHost(IEnumerator routine)
			{
				return null;
			}

			// Token: 0x06017A1D RID: 96797 RVA: 0x000977A0 File Offset: 0x000959A0
			[Token(Token = "0x6017A1D")]
			[Address(RVA = "0xFEC690", Offset = "0xFEB290", VA = "0x180FEC690", Slot = "12")]
			public override bool IsUIStable()
			{
				return default(bool);
			}

			// Token: 0x06017A1E RID: 96798 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017A1E")]
			[Address(RVA = "0xFEC960", Offset = "0xFEB560", VA = "0x180FEC960")]
			private void _OnHostResumed()
			{
			}

			// Token: 0x06017A1F RID: 96799 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017A1F")]
			[Address(RVA = "0xFEC8F0", Offset = "0xFEB4F0", VA = "0x180FEC8F0")]
			private void _OnHostClosed()
			{
			}

			// Token: 0x0401C840 RID: 116800
			[Token(Token = "0x401C840")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private UIPageListener m_listener;

			// Token: 0x0401C841 RID: 116801
			[Token(Token = "0x401C841")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private UIPage m_page;

			// Token: 0x0401C842 RID: 116802
			[Token(Token = "0x401C842")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Action m_onHostClosed;

			// Token: 0x0401C843 RID: 116803
			[Token(Token = "0x401C843")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Action m_onHostResumed;

			// Token: 0x0401C844 RID: 116804
			[Token(Token = "0x401C844")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401C845 RID: 116805
			[Token(Token = "0x401C845")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Validate;

			// Token: 0x0401C846 RID: 116806
			[Token(Token = "0x401C846")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_CreateAssetGroupForDialog;

			// Token: 0x0401C847 RID: 116807
			[Token(Token = "0x401C847")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_CreateAssetGroupForContainer;

			// Token: 0x0401C848 RID: 116808
			[Token(Token = "0x401C848")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_DisposeAssetGroupOfDialog;

			// Token: 0x0401C849 RID: 116809
			[Token(Token = "0x401C849")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_SetOnHostClosedCallback;

			// Token: 0x0401C84A RID: 116810
			[Token(Token = "0x401C84A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_SetOnHostResumedCallback;

			// Token: 0x0401C84B RID: 116811
			[Token(Token = "0x401C84B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_CheckIfValidCallback;

			// Token: 0x0401C84C RID: 116812
			[Token(Token = "0x401C84C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_CoroutineWithHost;

			// Token: 0x0401C84D RID: 116813
			[Token(Token = "0x401C84D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_IsUIStable;

			// Token: 0x0401C84E RID: 116814
			[Token(Token = "0x401C84E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0__OnHostResumed;

			// Token: 0x0401C84F RID: 116815
			[Token(Token = "0x401C84F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0__OnHostClosed;
		}

		// Token: 0x02003A61 RID: 14945
		[Token(Token = "0x2003A61")]
		private class MgrHostWithState : UICompDialogMgr.MgrHost
		{
			// Token: 0x06017A20 RID: 96800 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017A20")]
			[Address(RVA = "0xFED980", Offset = "0xFEC580", VA = "0x180FED980")]
			public MgrHostWithState(State state)
			{
			}

			// Token: 0x06017A21 RID: 96801 RVA: 0x000977B8 File Offset: 0x000959B8
			[Token(Token = "0x6017A21")]
			[Address(RVA = "0xFED4B0", Offset = "0xFEC0B0", VA = "0x180FED4B0", Slot = "4")]
			public override bool Validate()
			{
				return default(bool);
			}

			// Token: 0x06017A22 RID: 96802 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017A22")]
			[Address(RVA = "0xFED880", Offset = "0xFEC480", VA = "0x180FED880")]
			private void _OnHostResume(Type stateType, bool isBack, StateEngine.OnStateChangeListener.Additions additions)
			{
			}

			// Token: 0x06017A23 RID: 96803 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017A23")]
			[Address(RVA = "0xFED810", Offset = "0xFEC410", VA = "0x180FED810")]
			private void _OnHostClosed()
			{
			}

			// Token: 0x06017A24 RID: 96804 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017A24")]
			[Address(RVA = "0xFED710", Offset = "0xFEC310", VA = "0x180FED710")]
			private void _OnHostClosedFromStateEngine(Type stateType, StateEngine.OnStateChangeListener.Additions additions)
			{
			}

			// Token: 0x06017A25 RID: 96805 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017A25")]
			[Address(RVA = "0xFED570", Offset = "0xFEC170", VA = "0x180FED570")]
			private void _DisposeAllAssetGroups()
			{
			}

			// Token: 0x06017A26 RID: 96806 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6017A26")]
			[Address(RVA = "0xFECF10", Offset = "0xFEBB10", VA = "0x180FECF10", Slot = "7")]
			public override ILoadAsset CreateAssetGroupForDialog(UICompDialogMgr.DialogBase dialog)
			{
				return null;
			}

			// Token: 0x06017A27 RID: 96807 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6017A27")]
			[Address(RVA = "0xFECD70", Offset = "0xFEB970", VA = "0x180FECD70", Slot = "9")]
			public override ILoadAsset CreateAssetGroupForContainer(Transform container)
			{
				return null;
			}

			// Token: 0x06017A28 RID: 96808 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017A28")]
			[Address(RVA = "0xFED0B0", Offset = "0xFEBCB0", VA = "0x180FED0B0", Slot = "8")]
			public override void DisposeAssetGroupOfDialog(UICompDialogMgr.DialogBase dialog)
			{
			}

			// Token: 0x06017A29 RID: 96809 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017A29")]
			[Address(RVA = "0xFED3B0", Offset = "0xFEBFB0", VA = "0x180FED3B0", Slot = "5")]
			public override void SetOnHostClosedCallback(Action onHostClosed)
			{
			}

			// Token: 0x06017A2A RID: 96810 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017A2A")]
			[Address(RVA = "0xFED430", Offset = "0xFEC030", VA = "0x180FED430", Slot = "6")]
			public override void SetOnHostResumedCallback(Action onHostResumed)
			{
			}

			// Token: 0x06017A2B RID: 96811 RVA: 0x000977D0 File Offset: 0x000959D0
			[Token(Token = "0x6017A2B")]
			[Address(RVA = "0xFECBD0", Offset = "0xFEB7D0", VA = "0x180FECBD0", Slot = "10")]
			public override bool CheckIfValidCallback(Transform callbackTransform)
			{
				return default(bool);
			}

			// Token: 0x06017A2C RID: 96812 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6017A2C")]
			[Address(RVA = "0xFECC70", Offset = "0xFEB870", VA = "0x180FECC70", Slot = "11")]
			public override Coroutine CoroutineWithHost(IEnumerator routine)
			{
				return null;
			}

			// Token: 0x06017A2D RID: 96813 RVA: 0x000977E8 File Offset: 0x000959E8
			[Token(Token = "0x6017A2D")]
			[Address(RVA = "0xFED250", Offset = "0xFEBE50", VA = "0x180FED250", Slot = "12")]
			public override bool IsUIStable()
			{
				return default(bool);
			}

			// Token: 0x0401C850 RID: 116816
			[Token(Token = "0x401C850")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private StateEngine.OnStateChangeListener m_stateEngineListener;

			// Token: 0x0401C851 RID: 116817
			[Token(Token = "0x401C851")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private UIPageListener m_pageListener;

			// Token: 0x0401C852 RID: 116818
			[Token(Token = "0x401C852")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UIPage m_page;

			// Token: 0x0401C853 RID: 116819
			[Token(Token = "0x401C853")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private State m_state;

			// Token: 0x0401C854 RID: 116820
			[Token(Token = "0x401C854")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private StateEngine m_stateEngine;

			// Token: 0x0401C855 RID: 116821
			[Token(Token = "0x401C855")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Action m_onHostResumed;

			// Token: 0x0401C856 RID: 116822
			[Token(Token = "0x401C856")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Action m_onHostClosed;

			// Token: 0x0401C857 RID: 116823
			[Token(Token = "0x401C857")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Dictionary<int, UIAssetLoader.Assets> m_assetGroups;

			// Token: 0x0401C858 RID: 116824
			[Token(Token = "0x401C858")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401C859 RID: 116825
			[Token(Token = "0x401C859")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Validate;

			// Token: 0x0401C85A RID: 116826
			[Token(Token = "0x401C85A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0__OnHostResume;

			// Token: 0x0401C85B RID: 116827
			[Token(Token = "0x401C85B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__OnHostClosed;

			// Token: 0x0401C85C RID: 116828
			[Token(Token = "0x401C85C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__OnHostClosedFromStateEngine;

			// Token: 0x0401C85D RID: 116829
			[Token(Token = "0x401C85D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0__DisposeAllAssetGroups;

			// Token: 0x0401C85E RID: 116830
			[Token(Token = "0x401C85E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_CreateAssetGroupForDialog;

			// Token: 0x0401C85F RID: 116831
			[Token(Token = "0x401C85F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_CreateAssetGroupForContainer;

			// Token: 0x0401C860 RID: 116832
			[Token(Token = "0x401C860")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_DisposeAssetGroupOfDialog;

			// Token: 0x0401C861 RID: 116833
			[Token(Token = "0x401C861")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_SetOnHostClosedCallback;

			// Token: 0x0401C862 RID: 116834
			[Token(Token = "0x401C862")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_SetOnHostResumedCallback;

			// Token: 0x0401C863 RID: 116835
			[Token(Token = "0x401C863")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_CheckIfValidCallback;

			// Token: 0x0401C864 RID: 116836
			[Token(Token = "0x401C864")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_CoroutineWithHost;

			// Token: 0x0401C865 RID: 116837
			[Token(Token = "0x401C865")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_IsUIStable;
		}

		// Token: 0x02003A62 RID: 14946
		[Token(Token = "0x2003A62")]
		private class MgrHostWithCompDialog : UICompDialogMgr.MgrHost
		{
			// Token: 0x06017A2E RID: 96814 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017A2E")]
			[Address(RVA = "0xFEC040", Offset = "0xFEAC40", VA = "0x180FEC040")]
			public MgrHostWithCompDialog(UICompDialogMgr.DialogBase dialog)
			{
			}

			// Token: 0x06017A2F RID: 96815 RVA: 0x00097800 File Offset: 0x00095A00
			[Token(Token = "0x6017A2F")]
			[Address(RVA = "0xFEBEB0", Offset = "0xFEAAB0", VA = "0x180FEBEB0", Slot = "4")]
			public override bool Validate()
			{
				return default(bool);
			}

			// Token: 0x06017A30 RID: 96816 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6017A30")]
			[Address(RVA = "0xFEBB70", Offset = "0xFEA770", VA = "0x180FEBB70", Slot = "7")]
			public override ILoadAsset CreateAssetGroupForDialog(UICompDialogMgr.DialogBase dialog)
			{
				return null;
			}

			// Token: 0x06017A31 RID: 96817 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6017A31")]
			[Address(RVA = "0xFEBAD0", Offset = "0xFEA6D0", VA = "0x180FEBAD0", Slot = "9")]
			public override ILoadAsset CreateAssetGroupForContainer(Transform container)
			{
				return null;
			}

			// Token: 0x06017A32 RID: 96818 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017A32")]
			[Address(RVA = "0xFEBC10", Offset = "0xFEA810", VA = "0x180FEBC10", Slot = "8")]
			public override void DisposeAssetGroupOfDialog(UICompDialogMgr.DialogBase dialog)
			{
			}

			// Token: 0x06017A33 RID: 96819 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017A33")]
			[Address(RVA = "0xFEBDB0", Offset = "0xFEA9B0", VA = "0x180FEBDB0", Slot = "5")]
			public override void SetOnHostClosedCallback(Action onHostClosed)
			{
			}

			// Token: 0x06017A34 RID: 96820 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017A34")]
			[Address(RVA = "0xFEBE30", Offset = "0xFEAA30", VA = "0x180FEBE30", Slot = "6")]
			public override void SetOnHostResumedCallback(Action onHostResumed)
			{
			}

			// Token: 0x06017A35 RID: 96821 RVA: 0x00097818 File Offset: 0x00095A18
			[Token(Token = "0x6017A35")]
			[Address(RVA = "0xFEB960", Offset = "0xFEA560", VA = "0x180FEB960", Slot = "10")]
			public override bool CheckIfValidCallback(Transform callbackTransform)
			{
				return default(bool);
			}

			// Token: 0x06017A36 RID: 96822 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6017A36")]
			[Address(RVA = "0xFEBA30", Offset = "0xFEA630", VA = "0x180FEBA30", Slot = "11")]
			public override Coroutine CoroutineWithHost(IEnumerator routine)
			{
				return null;
			}

			// Token: 0x06017A37 RID: 96823 RVA: 0x00097830 File Offset: 0x00095A30
			[Token(Token = "0x6017A37")]
			[Address(RVA = "0xFEBD40", Offset = "0xFEA940", VA = "0x180FEBD40", Slot = "12")]
			public override bool IsUIStable()
			{
				return default(bool);
			}

			// Token: 0x06017A38 RID: 96824 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017A38")]
			[Address(RVA = "0xFEBFD0", Offset = "0xFEABD0", VA = "0x180FEBFD0")]
			private void _OnHostResumed()
			{
			}

			// Token: 0x06017A39 RID: 96825 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017A39")]
			[Address(RVA = "0xFEBF60", Offset = "0xFEAB60", VA = "0x180FEBF60")]
			private void _OnHostClosed()
			{
			}

			// Token: 0x0401C866 RID: 116838
			[Token(Token = "0x401C866")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private UICompDialogMgr.DialogBase m_hostDialog;

			// Token: 0x0401C867 RID: 116839
			[Token(Token = "0x401C867")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private UICompDialogMgr.MgrHost m_host;

			// Token: 0x0401C868 RID: 116840
			[Token(Token = "0x401C868")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UICompDialogMgr.DialogBase.Listener m_listener;

			// Token: 0x0401C869 RID: 116841
			[Token(Token = "0x401C869")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Action m_onHostResumed;

			// Token: 0x0401C86A RID: 116842
			[Token(Token = "0x401C86A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Action m_onHostClosed;

			// Token: 0x0401C86B RID: 116843
			[Token(Token = "0x401C86B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401C86C RID: 116844
			[Token(Token = "0x401C86C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Validate;

			// Token: 0x0401C86D RID: 116845
			[Token(Token = "0x401C86D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_CreateAssetGroupForDialog;

			// Token: 0x0401C86E RID: 116846
			[Token(Token = "0x401C86E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_CreateAssetGroupForContainer;

			// Token: 0x0401C86F RID: 116847
			[Token(Token = "0x401C86F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_DisposeAssetGroupOfDialog;

			// Token: 0x0401C870 RID: 116848
			[Token(Token = "0x401C870")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_SetOnHostClosedCallback;

			// Token: 0x0401C871 RID: 116849
			[Token(Token = "0x401C871")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_SetOnHostResumedCallback;

			// Token: 0x0401C872 RID: 116850
			[Token(Token = "0x401C872")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_CheckIfValidCallback;

			// Token: 0x0401C873 RID: 116851
			[Token(Token = "0x401C873")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_CoroutineWithHost;

			// Token: 0x0401C874 RID: 116852
			[Token(Token = "0x401C874")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_IsUIStable;

			// Token: 0x0401C875 RID: 116853
			[Token(Token = "0x401C875")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0__OnHostResumed;

			// Token: 0x0401C876 RID: 116854
			[Token(Token = "0x401C876")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0__OnHostClosed;
		}
	}
}
