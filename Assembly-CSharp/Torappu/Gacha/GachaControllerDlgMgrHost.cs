using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Gacha
{
	// Token: 0x02001656 RID: 5718
	[Token(Token = "0x2001656")]
	public class GachaControllerDlgMgrHost : MonoBehaviour, IHotfixable, ICompDialogCallBack
	{
		// Token: 0x060081CA RID: 33226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081CA")]
		[Address(RVA = "0x2AFB0D0", Offset = "0x2AF9CD0", VA = "0x182AFB0D0")]
		protected void OnDestroy()
		{
		}

		// Token: 0x060081CB RID: 33227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081CB")]
		[Address(RVA = "0x2AFB1E0", Offset = "0x2AF9DE0", VA = "0x182AFB1E0")]
		public void ShowDisplaySkin(GachaControllerDlgMgrHost.InputParam param)
		{
		}

		// Token: 0x060081CC RID: 33228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081CC")]
		[Address(RVA = "0x2AFB160", Offset = "0x2AF9D60", VA = "0x182AFB160")]
		public void SetListener(GachaControllerDlgMgrHost.Listener listener)
		{
		}

		// Token: 0x060081CD RID: 33229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60081CD")]
		[Address(RVA = "0x2AFAEF0", Offset = "0x2AF9AF0", VA = "0x182AFAEF0")]
		public Coroutine CoroutineWithHost(IEnumerator routine)
		{
			return null;
		}

		// Token: 0x060081CE RID: 33230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60081CE")]
		[Address(RVA = "0x2AFAD20", Offset = "0x2AF9920", VA = "0x182AFAD20")]
		public UIPageAssetGroup AchieveAssetGroup(Component component)
		{
			return null;
		}

		// Token: 0x060081CF RID: 33231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081CF")]
		[Address(RVA = "0x2AFAFA0", Offset = "0x2AF9BA0", VA = "0x182AFAFA0", Slot = "4")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x060081D0 RID: 33232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081D0")]
		[Address(RVA = "0x2AFB570", Offset = "0x2AFA170", VA = "0x182AFB570")]
		private void _BuildDlgMgr()
		{
		}

		// Token: 0x060081D1 RID: 33233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081D1")]
		[Address(RVA = "0x2AFB730", Offset = "0x2AFA330", VA = "0x182AFB730")]
		private void _StopAllCore()
		{
		}

		// Token: 0x060081D2 RID: 33234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081D2")]
		[Address(RVA = "0x2AFB6A0", Offset = "0x2AFA2A0", VA = "0x182AFB6A0")]
		private void _ClearAndCallback()
		{
		}

		// Token: 0x060081D3 RID: 33235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081D3")]
		[Address(RVA = "0x2AFB8C0", Offset = "0x2AFA4C0", VA = "0x182AFB8C0")]
		public GachaControllerDlgMgrHost()
		{
		}

		// Token: 0x040083C8 RID: 33736
		[Token(Token = "0x40083C8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _dlgContainer;

		// Token: 0x040083C9 RID: 33737
		[Token(Token = "0x40083C9")]
		[FieldOffset(Offset = "0x20")]
		private List<Coroutine> m_coroutines;

		// Token: 0x040083CA RID: 33738
		[Token(Token = "0x40083CA")]
		[FieldOffset(Offset = "0x28")]
		private GachaControllerDlgMgrHost.HostAssetGroupHelper m_hostAssetGroupHelper;

		// Token: 0x040083CB RID: 33739
		[Token(Token = "0x40083CB")]
		[FieldOffset(Offset = "0x30")]
		private GachaControllerDlgMgrHost.Listener m_listener;

		// Token: 0x040083CC RID: 33740
		[Token(Token = "0x40083CC")]
		[FieldOffset(Offset = "0x38")]
		private UICompDialogMgr m_dialogMgr;

		// Token: 0x040083CD RID: 33741
		[Token(Token = "0x40083CD")]
		[FieldOffset(Offset = "0x40")]
		private int m_dlgInstId;

		// Token: 0x040083CE RID: 33742
		[Token(Token = "0x40083CE")]
		[FieldOffset(Offset = "0x48")]
		private Action m_endCallback;

		// Token: 0x040083CF RID: 33743
		[Token(Token = "0x40083CF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x040083D0 RID: 33744
		[Token(Token = "0x40083D0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ShowDisplaySkin;

		// Token: 0x040083D1 RID: 33745
		[Token(Token = "0x40083D1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetListener;

		// Token: 0x040083D2 RID: 33746
		[Token(Token = "0x40083D2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CoroutineWithHost;

		// Token: 0x040083D3 RID: 33747
		[Token(Token = "0x40083D3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_AchieveAssetGroup;

		// Token: 0x040083D4 RID: 33748
		[Token(Token = "0x40083D4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x040083D5 RID: 33749
		[Token(Token = "0x40083D5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__BuildDlgMgr;

		// Token: 0x040083D6 RID: 33750
		[Token(Token = "0x40083D6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__StopAllCore;

		// Token: 0x040083D7 RID: 33751
		[Token(Token = "0x40083D7")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ClearAndCallback;

		// Token: 0x040083D8 RID: 33752
		[Token(Token = "0x40083D8")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001657 RID: 5719
		[Token(Token = "0x2001657")]
		public struct InputParam
		{
			// Token: 0x040083D9 RID: 33753
			[Token(Token = "0x40083D9")]
			[FieldOffset(Offset = "0x0")]
			public GachaController.Input input;

			// Token: 0x040083DA RID: 33754
			[Token(Token = "0x40083DA")]
			[FieldOffset(Offset = "0x60")]
			public Action endCb;
		}

		// Token: 0x02001658 RID: 5720
		[Token(Token = "0x2001658")]
		public class Listener : IHotfixable
		{
			// Token: 0x060081D5 RID: 33237 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60081D5")]
			[Address(RVA = "0x2B08BD0", Offset = "0x2B077D0", VA = "0x182B08BD0")]
			public Listener()
			{
			}

			// Token: 0x040083DB RID: 33755
			[Token(Token = "0x40083DB")]
			[FieldOffset(Offset = "0x10")]
			public Action onResume;

			// Token: 0x040083DC RID: 33756
			[Token(Token = "0x40083DC")]
			[FieldOffset(Offset = "0x18")]
			public Action onDestroy;

			// Token: 0x040083DD RID: 33757
			[Token(Token = "0x40083DD")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02001659 RID: 5721
		[Token(Token = "0x2001659")]
		private class DlgMgrHost : UICompDialogMgr.MgrHost
		{
			// Token: 0x060081D6 RID: 33238 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60081D6")]
			[Address(RVA = "0x2AFA240", Offset = "0x2AF8E40", VA = "0x182AFA240")]
			public DlgMgrHost(GachaControllerDlgMgrHost closure)
			{
			}

			// Token: 0x060081D7 RID: 33239 RVA: 0x00038B68 File Offset: 0x00036D68
			[Token(Token = "0x60081D7")]
			[Address(RVA = "0x2AFA0D0", Offset = "0x2AF8CD0", VA = "0x182AFA0D0", Slot = "4")]
			public override bool Validate()
			{
				return default(bool);
			}

			// Token: 0x060081D8 RID: 33240 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60081D8")]
			[Address(RVA = "0x2AF9FD0", Offset = "0x2AF8BD0", VA = "0x182AF9FD0", Slot = "5")]
			public override void SetOnHostClosedCallback(Action onHostClosed)
			{
			}

			// Token: 0x060081D9 RID: 33241 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60081D9")]
			[Address(RVA = "0x2AFA050", Offset = "0x2AF8C50", VA = "0x182AFA050", Slot = "6")]
			public override void SetOnHostResumedCallback(Action onHostResumed)
			{
			}

			// Token: 0x060081DA RID: 33242 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60081DA")]
			[Address(RVA = "0x2AF9DE0", Offset = "0x2AF89E0", VA = "0x182AF9DE0", Slot = "7")]
			public override ILoadAsset CreateAssetGroupForDialog(UICompDialogMgr.DialogBase dialog)
			{
				return null;
			}

			// Token: 0x060081DB RID: 33243 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60081DB")]
			[Address(RVA = "0x2AF9E60", Offset = "0x2AF8A60", VA = "0x182AF9E60", Slot = "8")]
			public override void DisposeAssetGroupOfDialog(UICompDialogMgr.DialogBase dialog)
			{
			}

			// Token: 0x060081DC RID: 33244 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60081DC")]
			[Address(RVA = "0x2AF9D60", Offset = "0x2AF8960", VA = "0x182AF9D60", Slot = "9")]
			public override ILoadAsset CreateAssetGroupForContainer(Transform container)
			{
				return null;
			}

			// Token: 0x060081DD RID: 33245 RVA: 0x00038B80 File Offset: 0x00036D80
			[Token(Token = "0x60081DD")]
			[Address(RVA = "0x2AF9BC0", Offset = "0x2AF87C0", VA = "0x182AF9BC0", Slot = "10")]
			public override bool CheckIfValidCallback(Transform callbackTransform)
			{
				return default(bool);
			}

			// Token: 0x060081DE RID: 33246 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60081DE")]
			[Address(RVA = "0x2AF9C50", Offset = "0x2AF8850", VA = "0x182AF9C50", Slot = "11")]
			public override Coroutine CoroutineWithHost(IEnumerator routine)
			{
				return null;
			}

			// Token: 0x060081DF RID: 33247 RVA: 0x00038B98 File Offset: 0x00036D98
			[Token(Token = "0x60081DF")]
			[Address(RVA = "0x2AF9F50", Offset = "0x2AF8B50", VA = "0x182AF9F50", Slot = "12")]
			public override bool IsUIStable()
			{
				return default(bool);
			}

			// Token: 0x060081E0 RID: 33248 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60081E0")]
			[Address(RVA = "0x2AFA1D0", Offset = "0x2AF8DD0", VA = "0x182AFA1D0")]
			private void _OnHostResumed()
			{
			}

			// Token: 0x060081E1 RID: 33249 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60081E1")]
			[Address(RVA = "0x2AFA160", Offset = "0x2AF8D60", VA = "0x182AFA160")]
			private void _OnHostClosed()
			{
			}

			// Token: 0x040083DE RID: 33758
			[Token(Token = "0x40083DE")]
			[FieldOffset(Offset = "0x10")]
			private GachaControllerDlgMgrHost m_closure;

			// Token: 0x040083DF RID: 33759
			[Token(Token = "0x40083DF")]
			[FieldOffset(Offset = "0x18")]
			private Action m_onHostClosed;

			// Token: 0x040083E0 RID: 33760
			[Token(Token = "0x40083E0")]
			[FieldOffset(Offset = "0x20")]
			private Action m_onHostResumed;

			// Token: 0x040083E1 RID: 33761
			[Token(Token = "0x40083E1")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040083E2 RID: 33762
			[Token(Token = "0x40083E2")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Validate;

			// Token: 0x040083E3 RID: 33763
			[Token(Token = "0x40083E3")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_SetOnHostClosedCallback;

			// Token: 0x040083E4 RID: 33764
			[Token(Token = "0x40083E4")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_SetOnHostResumedCallback;

			// Token: 0x040083E5 RID: 33765
			[Token(Token = "0x40083E5")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_CreateAssetGroupForDialog;

			// Token: 0x040083E6 RID: 33766
			[Token(Token = "0x40083E6")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_DisposeAssetGroupOfDialog;

			// Token: 0x040083E7 RID: 33767
			[Token(Token = "0x40083E7")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_CreateAssetGroupForContainer;

			// Token: 0x040083E8 RID: 33768
			[Token(Token = "0x40083E8")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_CheckIfValidCallback;

			// Token: 0x040083E9 RID: 33769
			[Token(Token = "0x40083E9")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_CoroutineWithHost;

			// Token: 0x040083EA RID: 33770
			[Token(Token = "0x40083EA")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_IsUIStable;

			// Token: 0x040083EB RID: 33771
			[Token(Token = "0x40083EB")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0__OnHostResumed;

			// Token: 0x040083EC RID: 33772
			[Token(Token = "0x40083EC")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0__OnHostClosed;
		}

		// Token: 0x0200165A RID: 5722
		[Token(Token = "0x200165A")]
		private class HostAssetGroupHelper : IHotfixable
		{
			// Token: 0x060081E2 RID: 33250 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60081E2")]
			[Address(RVA = "0x2B084C0", Offset = "0x2B070C0", VA = "0x182B084C0")]
			public UIPageAssetGroup AchieveAssetGroup(int assetGroupId)
			{
				return null;
			}

			// Token: 0x060081E3 RID: 33251 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60081E3")]
			[Address(RVA = "0x2B085D0", Offset = "0x2B071D0", VA = "0x182B085D0")]
			public void ClearAllAssets()
			{
			}

			// Token: 0x060081E4 RID: 33252 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60081E4")]
			[Address(RVA = "0x2B08780", Offset = "0x2B07380", VA = "0x182B08780")]
			public HostAssetGroupHelper()
			{
			}

			// Token: 0x040083ED RID: 33773
			[Token(Token = "0x40083ED")]
			[FieldOffset(Offset = "0x10")]
			private ListDict<int, UIPageAssetGroup> m_assetGroups;

			// Token: 0x040083EE RID: 33774
			[Token(Token = "0x40083EE")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_AchieveAssetGroup;

			// Token: 0x040083EF RID: 33775
			[Token(Token = "0x40083EF")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ClearAllAssets;

			// Token: 0x040083F0 RID: 33776
			[Token(Token = "0x40083F0")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
