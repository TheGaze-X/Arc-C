using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Notification;
using Torappu.UI.Notification;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003ADC RID: 15068
	[Token(Token = "0x2003ADC")]
	public class UINotification : SingletonMonoBehaviour<UINotification>, ISingletonNotAutoCreate
	{
		// Token: 0x06017C0F RID: 97295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017C0F")]
		[Address(RVA = "0x10109A0", Offset = "0x100F5A0", VA = "0x1810109A0", Slot = "4")]
		protected override void OnInit()
		{
		}

		// Token: 0x170038F2 RID: 14578
		// (get) Token: 0x06017C10 RID: 97296 RVA: 0x00097EF0 File Offset: 0x000960F0
		[Token(Token = "0x170038F2")]
		protected int assetGroupId
		{
			[Token(Token = "0x6017C10")]
			[Address(RVA = "0x1011620", Offset = "0x1010220", VA = "0x181011620")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06017C11 RID: 97297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017C11")]
		[Address(RVA = "0x10104B0", Offset = "0x100F0B0", VA = "0x1810104B0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06017C12 RID: 97298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017C12")]
		public T NotifyViewOnlyLoadAsset<T>(string path) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06017C13 RID: 97299 RVA: 0x00097F08 File Offset: 0x00096108
		[Token(Token = "0x6017C13")]
		public static bool AddToast<ViewType, ParamType>(NotifyViewOptions<ViewType, ParamType> options) where ViewType : UINotifyView<ParamType> where ParamType : NotifyViewParam
		{
			return default(bool);
		}

		// Token: 0x06017C14 RID: 97300 RVA: 0x00097F20 File Offset: 0x00096120
		[Token(Token = "0x6017C14")]
		public bool AddRawNotifyView<ViewType, ParamType>(NotifyViewOptions<ViewType, ParamType> options) where ViewType : NotifyView where ParamType : NotifyViewParam
		{
			return default(bool);
		}

		// Token: 0x06017C15 RID: 97301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017C15")]
		[Address(RVA = "0x1010B60", Offset = "0x100F760", VA = "0x181010B60")]
		public static void TextToast(string content, float delay = 0f, bool useDeduplicate = true)
		{
		}

		// Token: 0x06017C16 RID: 97302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017C16")]
		[Address(RVA = "0x1010C70", Offset = "0x100F870", VA = "0x181010C70")]
		public static void TextToast(string content, bool useDeduplicate)
		{
		}

		// Token: 0x06017C17 RID: 97303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017C17")]
		public static void FuncToast<ViewType, ParamType>(ViewType prefab, ParamType param, float delay = 0f) where ViewType : UINotifyView<ParamType> where ParamType : NotifyViewParam
		{
		}

		// Token: 0x06017C18 RID: 97304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017C18")]
		[BlackList]
		public static void DynFuncToast<ViewType, ParamType>(string path, ParamType param, float delay = 0f) where ViewType : UINotifyView<ParamType> where ParamType : NotifyViewParam
		{
		}

		// Token: 0x06017C19 RID: 97305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017C19")]
		[Address(RVA = "0x1010540", Offset = "0x100F140", VA = "0x181010540")]
		public static void LockToast(string text, float delay = 0f)
		{
		}

		// Token: 0x06017C1A RID: 97306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017C1A")]
		[Address(RVA = "0x1011070", Offset = "0x100FC70", VA = "0x181011070")]
		public static void UnlockToast(string text, float delay = 0f)
		{
		}

		// Token: 0x06017C1B RID: 97307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017C1B")]
		[Address(RVA = "0x1010750", Offset = "0x100F350", VA = "0x181010750")]
		public static void MedalToast(List<MedalPerData> medalList, float delay = 0f, float duration = 0f)
		{
		}

		// Token: 0x06017C1C RID: 97308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017C1C")]
		[Address(RVA = "0x1010CF0", Offset = "0x100F8F0", VA = "0x181010CF0")]
		public static void ToastByResponse(IAlertResponse response)
		{
		}

		// Token: 0x06017C1D RID: 97309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017C1D")]
		[Address(RVA = "0x1010F80", Offset = "0x100FB80", VA = "0x181010F80")]
		public static void Toasts(List<string> toasts)
		{
		}

		// Token: 0x06017C1E RID: 97310 RVA: 0x00097F38 File Offset: 0x00096138
		[Token(Token = "0x6017C1E")]
		private bool _AddNotifyView<ViewType, ParamType>(NotifyViewOptions<ViewType, ParamType> options) where ViewType : NotifyView where ParamType : NotifyViewParam
		{
			return default(bool);
		}

		// Token: 0x06017C1F RID: 97311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017C1F")]
		[Address(RVA = "0x10112D0", Offset = "0x100FED0", VA = "0x1810112D0")]
		private void _TextToast(string content, float delay, bool useDeduplicate)
		{
		}

		// Token: 0x06017C20 RID: 97312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017C20")]
		[Address(RVA = "0x1011270", Offset = "0x100FE70", VA = "0x181011270")]
		private static string _BlockTextToast(string content)
		{
			return null;
		}

		// Token: 0x06017C21 RID: 97313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017C21")]
		[Address(RVA = "0x10114E0", Offset = "0x10100E0", VA = "0x1810114E0")]
		private IEnumerator _ToastsCoroutine(List<string> alerts)
		{
			return null;
		}

		// Token: 0x06017C22 RID: 97314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017C22")]
		[Address(RVA = "0x10115B0", Offset = "0x10101B0", VA = "0x1810115B0")]
		public UINotification()
		{
		}

		// Token: 0x0401CAF4 RID: 117492
		[Token(Token = "0x401CAF4")]
		private const float TOAST_BY_RESP_INTERVAL = 0.8f;

		// Token: 0x0401CAF5 RID: 117493
		[Token(Token = "0x401CAF5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private VerticalLayoutGroup _notifySlideLayout;

		// Token: 0x0401CAF6 RID: 117494
		[Token(Token = "0x401CAF6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _notifyFloatLayout;

		// Token: 0x0401CAF7 RID: 117495
		[Token(Token = "0x401CAF7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UINotifyViewHolder _viewHolder;

		// Token: 0x0401CAF8 RID: 117496
		[Token(Token = "0x401CAF8")]
		[FieldOffset(Offset = "0x30")]
		private UINotification.HostImpl m_hostImpl;

		// Token: 0x0401CAF9 RID: 117497
		[Token(Token = "0x401CAF9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0401CAFA RID: 117498
		[Token(Token = "0x401CAFA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_assetGroupId;

		// Token: 0x0401CAFB RID: 117499
		[Token(Token = "0x401CAFB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_FixedUpdate;

		// Token: 0x0401CAFC RID: 117500
		[Token(Token = "0x401CAFC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_NotifyViewOnlyLoadAsset;

		// Token: 0x0401CAFD RID: 117501
		[Token(Token = "0x401CAFD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_AddToast;

		// Token: 0x0401CAFE RID: 117502
		[Token(Token = "0x401CAFE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_AddRawNotifyView;

		// Token: 0x0401CAFF RID: 117503
		[Token(Token = "0x401CAFF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_TextToast;

		// Token: 0x0401CB00 RID: 117504
		[Token(Token = "0x401CB00")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix1_TextToast;

		// Token: 0x0401CB01 RID: 117505
		[Token(Token = "0x401CB01")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_FuncToast;

		// Token: 0x0401CB02 RID: 117506
		[Token(Token = "0x401CB02")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_DynFuncToast;

		// Token: 0x0401CB03 RID: 117507
		[Token(Token = "0x401CB03")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_LockToast;

		// Token: 0x0401CB04 RID: 117508
		[Token(Token = "0x401CB04")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_UnlockToast;

		// Token: 0x0401CB05 RID: 117509
		[Token(Token = "0x401CB05")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_MedalToast;

		// Token: 0x0401CB06 RID: 117510
		[Token(Token = "0x401CB06")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_ToastByResponse;

		// Token: 0x0401CB07 RID: 117511
		[Token(Token = "0x401CB07")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_Toasts;

		// Token: 0x0401CB08 RID: 117512
		[Token(Token = "0x401CB08")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__AddNotifyView;

		// Token: 0x0401CB09 RID: 117513
		[Token(Token = "0x401CB09")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__TextToast;

		// Token: 0x0401CB0A RID: 117514
		[Token(Token = "0x401CB0A")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__BlockTextToast;

		// Token: 0x0401CB0B RID: 117515
		[Token(Token = "0x401CB0B")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__ToastsCoroutine;

		// Token: 0x0401CB0C RID: 117516
		[Token(Token = "0x401CB0C")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003ADD RID: 15069
		[Token(Token = "0x2003ADD")]
		private class HostImpl : NotifyViewHost, AutoUnloadAssets.IHost
		{
			// Token: 0x06017C23 RID: 97315 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017C23")]
			[Address(RVA = "0xFFADE0", Offset = "0xFF99E0", VA = "0x180FFADE0")]
			public HostImpl(UINotification closure)
			{
			}

			// Token: 0x06017C24 RID: 97316 RVA: 0x00097F50 File Offset: 0x00096150
			[Token(Token = "0x6017C24")]
			[Address(RVA = "0xFFAB50", Offset = "0xFF9750", VA = "0x180FFAB50", Slot = "4")]
			protected override long CurrentTicks()
			{
				return 0L;
			}

			// Token: 0x06017C25 RID: 97317 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6017C25")]
			protected override NotifyViewLayouter SelectLayouter<ViewType, ParamType>(NotifyViewOptions<ViewType, ParamType> options)
			{
				return null;
			}

			// Token: 0x06017C26 RID: 97318 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6017C26")]
			[Address(RVA = "0xFFACF0", Offset = "0xFF98F0", VA = "0x180FFACF0", Slot = "6")]
			public override Coroutine StartCoroutine(IEnumerator routine)
			{
				return null;
			}

			// Token: 0x06017C27 RID: 97319 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6017C27")]
			[Address(RVA = "0xFFAC00", Offset = "0xFF9800", VA = "0x180FFAC00", Slot = "7")]
			public override GameObject LoadPrefabFromResource(string resPath)
			{
				return null;
			}

			// Token: 0x06017C28 RID: 97320 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017C28")]
			[Address(RVA = "0xFFAD70", Offset = "0xFF9970", VA = "0x180FFAD70", Slot = "8")]
			protected override void UnloadUnusedPrefabs()
			{
			}

			// Token: 0x06017C29 RID: 97321 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017C29")]
			[Address(RVA = "0xFFAAD0", Offset = "0xFF96D0", VA = "0x180FFAAD0", Slot = "9")]
			public void CollectUsedAssets(ICollection<UnityEngine.Object> usedAssets)
			{
			}

			// Token: 0x0401CB0D RID: 117517
			[Token(Token = "0x401CB0D")]
			[FieldOffset(Offset = "0x28")]
			private UINotification m_closure;

			// Token: 0x0401CB0E RID: 117518
			[Token(Token = "0x401CB0E")]
			[FieldOffset(Offset = "0x30")]
			private UINotificationSlideLayouter m_slideLayouter;

			// Token: 0x0401CB0F RID: 117519
			[Token(Token = "0x401CB0F")]
			[FieldOffset(Offset = "0x38")]
			private NotificationFloatLayouter m_floatLayouter;

			// Token: 0x0401CB10 RID: 117520
			[Token(Token = "0x401CB10")]
			[FieldOffset(Offset = "0x40")]
			private AutoUnloadAssets m_notifyViewPrefabLoader;

			// Token: 0x0401CB11 RID: 117521
			[Token(Token = "0x401CB11")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401CB12 RID: 117522
			[Token(Token = "0x401CB12")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_CurrentTicks;

			// Token: 0x0401CB13 RID: 117523
			[Token(Token = "0x401CB13")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_SelectLayouter;

			// Token: 0x0401CB14 RID: 117524
			[Token(Token = "0x401CB14")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_StartCoroutine;

			// Token: 0x0401CB15 RID: 117525
			[Token(Token = "0x401CB15")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_LoadPrefabFromResource;

			// Token: 0x0401CB16 RID: 117526
			[Token(Token = "0x401CB16")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_UnloadUnusedPrefabs;

			// Token: 0x0401CB17 RID: 117527
			[Token(Token = "0x401CB17")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_CollectUsedAssets;
		}
	}
}
