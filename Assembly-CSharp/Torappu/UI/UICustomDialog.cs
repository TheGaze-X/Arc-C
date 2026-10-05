using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003A8A RID: 14986
	[Token(Token = "0x2003A8A")]
	public abstract class UICustomDialog<OptionType> : MonoBehaviour, ILoadAsset, IHotfixable
	{
		// Token: 0x170038D9 RID: 14553
		// (get) Token: 0x06017AED RID: 97005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170038D9")]
		public UICustomDialog<OptionType>.Core core
		{
			[Token(Token = "0x6017AED")]
			get
			{
				return null;
			}
		}

		// Token: 0x170038DA RID: 14554
		// (get) Token: 0x06017AEE RID: 97006 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06017AEF RID: 97007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170038DA")]
		private protected OptionType options
		{
			[Token(Token = "0x6017AEE")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6017AEF")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06017AF0 RID: 97008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017AF0")]
		public void ConfirmWithCallback(Action callback)
		{
		}

		// Token: 0x06017AF1 RID: 97009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017AF1")]
		public void ConfirmWithCallback()
		{
		}

		// Token: 0x06017AF2 RID: 97010 RVA: 0x00097AA0 File Offset: 0x00095CA0
		[Token(Token = "0x6017AF2")]
		protected UICustomDialogMgr.CameraWrapper GetHostCamera()
		{
			return default(UICustomDialogMgr.CameraWrapper);
		}

		// Token: 0x06017AF3 RID: 97011 RVA: 0x00097AB8 File Offset: 0x00095CB8
		[Token(Token = "0x6017AF3")]
		protected bool IsDialogActive()
		{
			return default(bool);
		}

		// Token: 0x06017AF4 RID: 97012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017AF4")]
		public T LoadAsset<T>(string path) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06017AF5 RID: 97013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017AF5")]
		public UnityEngine.Object LoadAsset(string path)
		{
			return null;
		}

		// Token: 0x06017AF6 RID: 97014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017AF6")]
		public void UnloadAsset(UnityEngine.Object asset)
		{
		}

		// Token: 0x06017AF7 RID: 97015
		[Token(Token = "0x6017AF7")]
		protected abstract void OnRender(OptionType options);

		// Token: 0x06017AF8 RID: 97016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017AF8")]
		protected virtual void OnInit()
		{
		}

		// Token: 0x06017AF9 RID: 97017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017AF9")]
		protected virtual void BeforeDestroy()
		{
		}

		// Token: 0x06017AFA RID: 97018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017AFA")]
		protected virtual UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x06017AFB RID: 97019 RVA: 0x00097AD0 File Offset: 0x00095CD0
		[Token(Token = "0x6017AFB")]
		protected virtual bool IncludeNotificationCamaraForBlur()
		{
			return default(bool);
		}

		// Token: 0x06017AFC RID: 97020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017AFC")]
		protected virtual UISwitchTween GenerateShowTween()
		{
			return null;
		}

		// Token: 0x06017AFD RID: 97021 RVA: 0x00097AE8 File Offset: 0x00095CE8
		[Token(Token = "0x6017AFD")]
		protected virtual float DefaultShowTweenDuration()
		{
			return 0f;
		}

		// Token: 0x06017AFE RID: 97022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017AFE")]
		protected CanvasGroup EnsureCanvasGroup()
		{
			return null;
		}

		// Token: 0x06017AFF RID: 97023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017AFF")]
		protected UIAssetLoader.Assets EnsureAssets()
		{
			return null;
		}

		// Token: 0x06017B00 RID: 97024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B00")]
		private void _Show()
		{
		}

		// Token: 0x06017B01 RID: 97025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B01")]
		private void _GetHookFindViewableCamerasAction(IList<Camera> cameras)
		{
		}

		// Token: 0x06017B02 RID: 97026 RVA: 0x00097B00 File Offset: 0x00095D00
		[Token(Token = "0x6017B02")]
		private bool _CheckIfShow()
		{
			return default(bool);
		}

		// Token: 0x06017B03 RID: 97027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B03")]
		private void _ConfirmWithCallbackImpl(Action callback)
		{
		}

		// Token: 0x06017B04 RID: 97028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017B04")]
		private IEnumerator _CloseCoroutine()
		{
			return null;
		}

		// Token: 0x06017B05 RID: 97029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B05")]
		private void OnDestroy()
		{
		}

		// Token: 0x06017B06 RID: 97030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B06")]
		protected UICustomDialog()
		{
		}

		// Token: 0x0401C93E RID: 117054
		[Token(Token = "0x401C93E")]
		[FieldOffset(Offset = "0x0")]
		private UIAssetLoader.Assets m_assets;

		// Token: 0x0401C93F RID: 117055
		[Token(Token = "0x401C93F")]
		[FieldOffset(Offset = "0x0")]
		private UISwitchTween m_showTween;

		// Token: 0x0401C940 RID: 117056
		[Token(Token = "0x401C940")]
		[FieldOffset(Offset = "0x0")]
		private bool m_hasRendered;

		// Token: 0x0401C941 RID: 117057
		[Token(Token = "0x401C941")]
		[FieldOffset(Offset = "0x0")]
		private bool m_requestToClose;

		// Token: 0x0401C942 RID: 117058
		[Token(Token = "0x401C942")]
		[FieldOffset(Offset = "0x0")]
		private UICustomDialog<OptionType>.Core m_core;

		// Token: 0x0401C943 RID: 117059
		[Token(Token = "0x401C943")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_core;

		// Token: 0x0401C944 RID: 117060
		[Token(Token = "0x401C944")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_options;

		// Token: 0x0401C945 RID: 117061
		[Token(Token = "0x401C945")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_options;

		// Token: 0x0401C946 RID: 117062
		[Token(Token = "0x401C946")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ConfirmWithCallback;

		// Token: 0x0401C947 RID: 117063
		[Token(Token = "0x401C947")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix1_ConfirmWithCallback;

		// Token: 0x0401C948 RID: 117064
		[Token(Token = "0x401C948")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetHostCamera;

		// Token: 0x0401C949 RID: 117065
		[Token(Token = "0x401C949")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsDialogActive;

		// Token: 0x0401C94A RID: 117066
		[Token(Token = "0x401C94A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadAsset;

		// Token: 0x0401C94B RID: 117067
		[Token(Token = "0x401C94B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix1_LoadAsset;

		// Token: 0x0401C94C RID: 117068
		[Token(Token = "0x401C94C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UnloadAsset;

		// Token: 0x0401C94D RID: 117069
		[Token(Token = "0x401C94D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0401C94E RID: 117070
		[Token(Token = "0x401C94E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_BeforeDestroy;

		// Token: 0x0401C94F RID: 117071
		[Token(Token = "0x401C94F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x0401C950 RID: 117072
		[Token(Token = "0x401C950")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IncludeNotificationCamaraForBlur;

		// Token: 0x0401C951 RID: 117073
		[Token(Token = "0x401C951")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GenerateShowTween;

		// Token: 0x0401C952 RID: 117074
		[Token(Token = "0x401C952")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DefaultShowTweenDuration;

		// Token: 0x0401C953 RID: 117075
		[Token(Token = "0x401C953")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_EnsureCanvasGroup;

		// Token: 0x0401C954 RID: 117076
		[Token(Token = "0x401C954")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_EnsureAssets;

		// Token: 0x0401C955 RID: 117077
		[Token(Token = "0x401C955")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__Show;

		// Token: 0x0401C956 RID: 117078
		[Token(Token = "0x401C956")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__GetHookFindViewableCamerasAction;

		// Token: 0x0401C957 RID: 117079
		[Token(Token = "0x401C957")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__CheckIfShow;

		// Token: 0x0401C958 RID: 117080
		[Token(Token = "0x401C958")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__ConfirmWithCallbackImpl;

		// Token: 0x0401C959 RID: 117081
		[Token(Token = "0x401C959")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__CloseCoroutine;

		// Token: 0x0401C95A RID: 117082
		[Token(Token = "0x401C95A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0401C95B RID: 117083
		[Token(Token = "0x401C95B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003A8B RID: 14987
		[Token(Token = "0x2003A8B")]
		public class Core
		{
			// Token: 0x06017B07 RID: 97031 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017B07")]
			public Core(UICustomDialog<OptionType> self)
			{
			}

			// Token: 0x06017B08 RID: 97032 RVA: 0x00097B18 File Offset: 0x00095D18
			[Token(Token = "0x6017B08")]
			public bool IsRedundentCloseRequest()
			{
				return default(bool);
			}

			// Token: 0x06017B09 RID: 97033 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017B09")]
			public void MgrOnly_TriggerInit(UICustomDialogMgr mgr, int instCode)
			{
			}

			// Token: 0x06017B0A RID: 97034 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017B0A")]
			public void MgrOnly_SetOptionsAndShow(OptionType options)
			{
			}

			// Token: 0x06017B0B RID: 97035 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017B0B")]
			public void DlgOnly_DestroyDialog()
			{
			}

			// Token: 0x06017B0C RID: 97036 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017B0C")]
			public void DlgOnly_StartCloseCoroutine()
			{
			}

			// Token: 0x06017B0D RID: 97037 RVA: 0x00097B30 File Offset: 0x00095D30
			[Token(Token = "0x6017B0D")]
			public UICustomDialogMgr.CameraWrapper DlgOnly_GetHostCamera()
			{
				return default(UICustomDialogMgr.CameraWrapper);
			}

			// Token: 0x06017B0E RID: 97038 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017B0E")]
			public void DlgOnly_GetHookFindViewableCamerasAction(IList<Camera> cameras)
			{
			}

			// Token: 0x06017B0F RID: 97039 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017B0F")]
			private void _CloseCoroutineImpl()
			{
			}

			// Token: 0x0401C95C RID: 117084
			[Token(Token = "0x401C95C")]
			[FieldOffset(Offset = "0x0")]
			private UICustomDialog<OptionType> m_closure;

			// Token: 0x0401C95D RID: 117085
			[Token(Token = "0x401C95D")]
			[FieldOffset(Offset = "0x0")]
			private UICustomDialogMgr m_mgr;

			// Token: 0x0401C95E RID: 117086
			[Token(Token = "0x401C95E")]
			[FieldOffset(Offset = "0x0")]
			private int m_instCode;

			// Token: 0x0401C95F RID: 117087
			[Token(Token = "0x401C95F")]
			[FieldOffset(Offset = "0x0")]
			private UICustomDialog<OptionType>.CloseRequestContext m_closeContext;
		}

		// Token: 0x02003A8C RID: 14988
		[Token(Token = "0x2003A8C")]
		private struct CloseRequestContext : IHotfixable
		{
			// Token: 0x06017B10 RID: 97040 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017B10")]
			public void NotifyRenderFinish()
			{
			}

			// Token: 0x06017B11 RID: 97041 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017B11")]
			public void NotifyConfirmToClose()
			{
			}

			// Token: 0x06017B12 RID: 97042 RVA: 0x00097B48 File Offset: 0x00095D48
			[Token(Token = "0x6017B12")]
			public bool IsRedundentCloseRequest()
			{
				return default(bool);
			}

			// Token: 0x06017B13 RID: 97043 RVA: 0x00097B60 File Offset: 0x00095D60
			[Token(Token = "0x6017B13")]
			public bool IsReadyForCloseCoroutine()
			{
				return default(bool);
			}

			// Token: 0x06017B14 RID: 97044 RVA: 0x00097B78 File Offset: 0x00095D78
			[Token(Token = "0x6017B14")]
			public bool ShouldCloseDialog()
			{
				return default(bool);
			}

			// Token: 0x0401C960 RID: 117088
			[Token(Token = "0x401C960")]
			[FieldOffset(Offset = "0x0")]
			private bool m_isRendered;

			// Token: 0x0401C961 RID: 117089
			[Token(Token = "0x401C961")]
			[FieldOffset(Offset = "0x0")]
			private bool m_requestToClose;

			// Token: 0x0401C962 RID: 117090
			[Token(Token = "0x401C962")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_NotifyRenderFinish;

			// Token: 0x0401C963 RID: 117091
			[Token(Token = "0x401C963")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_NotifyConfirmToClose;

			// Token: 0x0401C964 RID: 117092
			[Token(Token = "0x401C964")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_IsRedundentCloseRequest;

			// Token: 0x0401C965 RID: 117093
			[Token(Token = "0x401C965")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_IsReadyForCloseCoroutine;

			// Token: 0x0401C966 RID: 117094
			[Token(Token = "0x401C966")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_ShouldCloseDialog;
		}
	}
}
