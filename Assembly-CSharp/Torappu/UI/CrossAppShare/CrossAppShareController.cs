using System;
using System.Collections;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.SDK;
using UnityEngine;
using XLua;

namespace Torappu.UI.CrossAppShare
{
	// Token: 0x020058D9 RID: 22745
	[Token(Token = "0x20058D9")]
	public class CrossAppShareController : IHotfixable, IDisposable
	{
		// Token: 0x060212AC RID: 135852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60212AC")]
		[Address(RVA = "0x1B720F0", Offset = "0x1B70CF0", VA = "0x181B720F0")]
		public static CrossAppShareController TryRegisterController(CrossAppShareController.InputOption inputOption)
		{
			return null;
		}

		// Token: 0x060212AD RID: 135853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60212AD")]
		[Address(RVA = "0x1B73410", Offset = "0x1B72010", VA = "0x181B73410")]
		private CrossAppShareController()
		{
		}

		// Token: 0x060212AE RID: 135854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60212AE")]
		[Address(RVA = "0x1B72B10", Offset = "0x1B71710", VA = "0x181B72B10")]
		private void _InitMessageCallBack()
		{
		}

		// Token: 0x060212AF RID: 135855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60212AF")]
		[Address(RVA = "0x1B72710", Offset = "0x1B71310", VA = "0x181B72710")]
		private void _DisposeMessageCallBack()
		{
		}

		// Token: 0x060212B0 RID: 135856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60212B0")]
		[Address(RVA = "0x1B71F20", Offset = "0x1B70B20", VA = "0x181B71F20")]
		public void OnInit()
		{
		}

		// Token: 0x060212B1 RID: 135857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60212B1")]
		[Address(RVA = "0x1B71C10", Offset = "0x1B70810", VA = "0x181B71C10", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x060212B2 RID: 135858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60212B2")]
		[Address(RVA = "0x1B71E00", Offset = "0x1B70A00", VA = "0x181B71E00")]
		public IEnumerator GetShotTween()
		{
			return null;
		}

		// Token: 0x17004DDA RID: 19930
		// (get) Token: 0x060212B3 RID: 135859 RVA: 0x000B8C80 File Offset: 0x000B6E80
		// (set) Token: 0x060212B4 RID: 135860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004DDA")]
		public bool isShotting
		{
			[Token(Token = "0x60212B3")]
			[Address(RVA = "0x1B73530", Offset = "0x1B72130", VA = "0x181B73530")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60212B4")]
			[Address(RVA = "0x1B735F0", Offset = "0x1B721F0", VA = "0x181B735F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004DDB RID: 19931
		// (get) Token: 0x060212B5 RID: 135861 RVA: 0x000B8C98 File Offset: 0x000B6E98
		[Token(Token = "0x17004DDB")]
		public bool isAvail
		{
			[Token(Token = "0x60212B5")]
			[Address(RVA = "0x1B734D0", Offset = "0x1B720D0", VA = "0x181B734D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004DDC RID: 19932
		// (get) Token: 0x060212B6 RID: 135862 RVA: 0x000B8CB0 File Offset: 0x000B6EB0
		// (set) Token: 0x060212B7 RID: 135863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004DDC")]
		public bool isWorking
		{
			[Token(Token = "0x60212B6")]
			[Address(RVA = "0x1B73590", Offset = "0x1B72190", VA = "0x181B73590")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60212B7")]
			[Address(RVA = "0x1B73660", Offset = "0x1B72260", VA = "0x181B73660")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004DDD RID: 19933
		// (get) Token: 0x060212B8 RID: 135864 RVA: 0x000B8CC8 File Offset: 0x000B6EC8
		[Token(Token = "0x17004DDD")]
		public CrossAppShareErrorCode errorCode
		{
			[Token(Token = "0x60212B8")]
			[Address(RVA = "0x1B73470", Offset = "0x1B72070", VA = "0x181B73470")]
			get
			{
				return (CrossAppShareErrorCode)0;
			}
		}

		// Token: 0x060212B9 RID: 135865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60212B9")]
		[Address(RVA = "0x1B730C0", Offset = "0x1B71CC0", VA = "0x181B730C0")]
		private IEnumerator _ShotAction()
		{
			return null;
		}

		// Token: 0x060212BA RID: 135866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60212BA")]
		[Address(RVA = "0x1B72F40", Offset = "0x1B71B40", VA = "0x181B72F40")]
		private void _OpenBottomMenuDialog()
		{
		}

		// Token: 0x060212BB RID: 135867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60212BB")]
		[Address(RVA = "0x1B73170", Offset = "0x1B71D70", VA = "0x181B73170")]
		private void _ShowPCSucToast(string path)
		{
		}

		// Token: 0x060212BC RID: 135868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60212BC")]
		[Address(RVA = "0x1B72D30", Offset = "0x1B71930", VA = "0x181B72D30")]
		private void _OnShareCallBackHandler(SDKExtraInfoHandler.ShareCallBackMessage message)
		{
		}

		// Token: 0x060212BD RID: 135869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60212BD")]
		[Address(RVA = "0x1B72BF0", Offset = "0x1B717F0", VA = "0x181B72BF0")]
		private void _InstantiateRemakeController()
		{
		}

		// Token: 0x060212BE RID: 135870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60212BE")]
		[Address(RVA = "0x1B72580", Offset = "0x1B71180", VA = "0x181B72580")]
		private void _AdjustRenderCanvasAndCamera(Vector2 sizeDelta)
		{
		}

		// Token: 0x060212BF RID: 135871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60212BF")]
		[Address(RVA = "0x1B72790", Offset = "0x1B71390", VA = "0x181B72790")]
		private void _DoRemake(ICrossAppShareModelCollector modelCollector, ILoadAsset iLoadAsset, ICrossAppShareRemakeAdditionBaseModel additionModel)
		{
		}

		// Token: 0x060212C0 RID: 135872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60212C0")]
		[Address(RVA = "0x1B72990", Offset = "0x1B71590", VA = "0x181B72990")]
		private IEnumerator _DoShot(Vector2 shotRTResolution)
		{
			return null;
		}

		// Token: 0x060212C1 RID: 135873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60212C1")]
		[Address(RVA = "0x1B72660", Offset = "0x1B71260", VA = "0x181B72660")]
		private void _DisplayShot(Vector2 shotCanvasSize)
		{
		}

		// Token: 0x060212C2 RID: 135874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60212C2")]
		[Address(RVA = "0x1B72A70", Offset = "0x1B71670", VA = "0x181B72A70")]
		private string _GetShotImgPath()
		{
			return null;
		}

		// Token: 0x0402D2E4 RID: 185060
		[Token(Token = "0x402D2E4")]
		private const float MAX_SHARE_SIZE_MB = 5f;

		// Token: 0x0402D2E5 RID: 185061
		[Token(Token = "0x402D2E5")]
		private const float TOAST_DURATION = 2f;

		// Token: 0x0402D2E6 RID: 185062
		[Token(Token = "0x402D2E6")]
		[FieldOffset(Offset = "0x0")]
		private static CrossAppShareController m_controller;

		// Token: 0x0402D2E7 RID: 185063
		[Token(Token = "0x402D2E7")]
		private const string IMG_PATH = "img_share.png";

		// Token: 0x0402D2E8 RID: 185064
		[Token(Token = "0x402D2E8")]
		[FieldOffset(Offset = "0x10")]
		private CrossAppShareController.InputOption m_cachedInputOption;

		// Token: 0x0402D2E9 RID: 185065
		[Token(Token = "0x402D2E9")]
		[FieldOffset(Offset = "0x80")]
		private Coroutine m_shotCoroutine;

		// Token: 0x0402D2EA RID: 185066
		[Token(Token = "0x402D2EA")]
		[FieldOffset(Offset = "0x88")]
		private IEnumerator m_shotTween;

		// Token: 0x0402D2EB RID: 185067
		[Token(Token = "0x402D2EB")]
		[FieldOffset(Offset = "0x90")]
		private Tween m_flashInTween;

		// Token: 0x0402D2EC RID: 185068
		[Token(Token = "0x402D2EC")]
		[FieldOffset(Offset = "0x98")]
		private Tween m_flashOutTween;

		// Token: 0x0402D2ED RID: 185069
		[Token(Token = "0x402D2ED")]
		[FieldOffset(Offset = "0xA0")]
		private Tween m_displayEffectTween;

		// Token: 0x0402D2EE RID: 185070
		[Token(Token = "0x402D2EE")]
		[FieldOffset(Offset = "0xA8")]
		private CrossAppShareRemakeController m_remakeController;

		// Token: 0x0402D2EF RID: 185071
		[Token(Token = "0x402D2EF")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_isAvail;

		// Token: 0x0402D2F0 RID: 185072
		[Token(Token = "0x402D2F0")]
		[FieldOffset(Offset = "0xB4")]
		private CrossAppShareErrorCode m_errorCode;

		// Token: 0x0402D2F3 RID: 185075
		[Token(Token = "0x402D2F3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_TryRegisterController;

		// Token: 0x0402D2F4 RID: 185076
		[Token(Token = "0x402D2F4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0402D2F5 RID: 185077
		[Token(Token = "0x402D2F5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitMessageCallBack;

		// Token: 0x0402D2F6 RID: 185078
		[Token(Token = "0x402D2F6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__DisposeMessageCallBack;

		// Token: 0x0402D2F7 RID: 185079
		[Token(Token = "0x402D2F7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0402D2F8 RID: 185080
		[Token(Token = "0x402D2F8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Dispose;

		// Token: 0x0402D2F9 RID: 185081
		[Token(Token = "0x402D2F9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetShotTween;

		// Token: 0x0402D2FA RID: 185082
		[Token(Token = "0x402D2FA")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_isShotting;

		// Token: 0x0402D2FB RID: 185083
		[Token(Token = "0x402D2FB")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_isShotting;

		// Token: 0x0402D2FC RID: 185084
		[Token(Token = "0x402D2FC")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_isAvail;

		// Token: 0x0402D2FD RID: 185085
		[Token(Token = "0x402D2FD")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_isWorking;

		// Token: 0x0402D2FE RID: 185086
		[Token(Token = "0x402D2FE")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_set_isWorking;

		// Token: 0x0402D2FF RID: 185087
		[Token(Token = "0x402D2FF")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_errorCode;

		// Token: 0x0402D300 RID: 185088
		[Token(Token = "0x402D300")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__ShotAction;

		// Token: 0x0402D301 RID: 185089
		[Token(Token = "0x402D301")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OpenBottomMenuDialog;

		// Token: 0x0402D302 RID: 185090
		[Token(Token = "0x402D302")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__ShowPCSucToast;

		// Token: 0x0402D303 RID: 185091
		[Token(Token = "0x402D303")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__OnShareCallBackHandler;

		// Token: 0x0402D304 RID: 185092
		[Token(Token = "0x402D304")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__InstantiateRemakeController;

		// Token: 0x0402D305 RID: 185093
		[Token(Token = "0x402D305")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__AdjustRenderCanvasAndCamera;

		// Token: 0x0402D306 RID: 185094
		[Token(Token = "0x402D306")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__DoRemake;

		// Token: 0x0402D307 RID: 185095
		[Token(Token = "0x402D307")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__DoShot;

		// Token: 0x0402D308 RID: 185096
		[Token(Token = "0x402D308")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__DisplayShot;

		// Token: 0x0402D309 RID: 185097
		[Token(Token = "0x402D309")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__GetShotImgPath;

		// Token: 0x020058DA RID: 22746
		[Token(Token = "0x20058DA")]
		public struct InputOption
		{
			// Token: 0x060212C5 RID: 135877 RVA: 0x000B8CE0 File Offset: 0x000B6EE0
			[Token(Token = "0x60212C5")]
			[Address(RVA = "0x1B79D50", Offset = "0x1B78950", VA = "0x181B79D50")]
			public bool IllegalDetection(out CrossAppShareErrorCode errorCode)
			{
				return default(bool);
			}

			// Token: 0x0402D30A RID: 185098
			[Token(Token = "0x402D30A")]
			[FieldOffset(Offset = "0x0")]
			public CrossAppShareRemakeController remakePrefab;

			// Token: 0x0402D30B RID: 185099
			[Token(Token = "0x402D30B")]
			[FieldOffset(Offset = "0x8")]
			public ICrossAppShareModelCollector modelCollector;

			// Token: 0x0402D30C RID: 185100
			[Token(Token = "0x402D30C")]
			[FieldOffset(Offset = "0x10")]
			public ICrossAppShareRemakeAdditionBaseModel additionModel;

			// Token: 0x0402D30D RID: 185101
			[Token(Token = "0x402D30D")]
			[FieldOffset(Offset = "0x18")]
			public RectTransform remakeContent;

			// Token: 0x0402D30E RID: 185102
			[Token(Token = "0x402D30E")]
			[FieldOffset(Offset = "0x20")]
			public Canvas remakeCanvas;

			// Token: 0x0402D30F RID: 185103
			[Token(Token = "0x402D30F")]
			[FieldOffset(Offset = "0x28")]
			public Camera remakeCamera;

			// Token: 0x0402D310 RID: 185104
			[Token(Token = "0x402D310")]
			[FieldOffset(Offset = "0x30")]
			public IEnumerator flashInCoro;

			// Token: 0x0402D311 RID: 185105
			[Token(Token = "0x402D311")]
			[FieldOffset(Offset = "0x38")]
			public IEnumerator flashOutCoro;

			// Token: 0x0402D312 RID: 185106
			[Token(Token = "0x402D312")]
			[FieldOffset(Offset = "0x40")]
			public CrossAppShareDisplayEffects.EffectType effectType;

			// Token: 0x0402D313 RID: 185107
			[Token(Token = "0x402D313")]
			[FieldOffset(Offset = "0x48")]
			public Action onCancelShare;

			// Token: 0x0402D314 RID: 185108
			[Token(Token = "0x402D314")]
			[FieldOffset(Offset = "0x50")]
			public Action<string, Action> onShareFinish;

			// Token: 0x0402D315 RID: 185109
			[Token(Token = "0x402D315")]
			[FieldOffset(Offset = "0x58")]
			public string shareConditionId;

			// Token: 0x0402D316 RID: 185110
			[Token(Token = "0x402D316")]
			[FieldOffset(Offset = "0x60")]
			public ILoadAsset iLoadAsset;

			// Token: 0x0402D317 RID: 185111
			[Token(Token = "0x402D317")]
			[FieldOffset(Offset = "0x68")]
			public UICompDialogMgr dialogMgr;
		}
	}
}
