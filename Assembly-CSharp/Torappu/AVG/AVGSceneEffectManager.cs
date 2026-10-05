using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Hypergryph.ToolKits;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.Rendering;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001EF3 RID: 7923
	[Token(Token = "0x2001EF3")]
	public class AVGSceneEffectManager : IHotfixable, IDisposable, PostDisplayGroup.IHost
	{
		// Token: 0x0600C4A9 RID: 50345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4A9")]
		[Address(RVA = "0x3429CF0", Offset = "0x34288F0", VA = "0x183429CF0")]
		public AVGSceneEffectManager(AVGSceneEffectManager.InitOptions initOptions)
		{
		}

		// Token: 0x0600C4AA RID: 50346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4AA")]
		[Address(RVA = "0x34258F0", Offset = "0x34244F0", VA = "0x1834258F0")]
		public void UpdateEffect(AVGSceneEffectManager.EffectConfig config)
		{
		}

		// Token: 0x0600C4AB RID: 50347 RVA: 0x00048168 File Offset: 0x00046368
		[Token(Token = "0x600C4AB")]
		[Address(RVA = "0x3425590", Offset = "0x3424190", VA = "0x183425590")]
		public float GetEffectAmount(string key, string channel)
		{
			return 0f;
		}

		// Token: 0x0600C4AC RID: 50348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C4AC")]
		[Address(RVA = "0x34256A0", Offset = "0x34242A0", VA = "0x1834256A0")]
		public object GetEffectImplConfig(string key)
		{
			return null;
		}

		// Token: 0x0600C4AD RID: 50349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4AD")]
		[Address(RVA = "0x3425780", Offset = "0x3424380", VA = "0x183425780")]
		public void MarkEffectImplConfigDirty(string key)
		{
		}

		// Token: 0x0600C4AE RID: 50350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C4AE")]
		[Address(RVA = "0x3424EC0", Offset = "0x3423AC0", VA = "0x183424EC0")]
		public PostDisplayHandler BindPostDisplay(PostDisplayKey key)
		{
			return null;
		}

		// Token: 0x0600C4AF RID: 50351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4AF")]
		[Address(RVA = "0x3425870", Offset = "0x3424470", VA = "0x183425870")]
		public void NotifyScreenSizeChanged()
		{
		}

		// Token: 0x0600C4B0 RID: 50352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4B0")]
		[Address(RVA = "0x3425300", Offset = "0x3423F00", VA = "0x183425300", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x0600C4B1 RID: 50353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4B1")]
		[Address(RVA = "0x34298A0", Offset = "0x34284A0", VA = "0x1834298A0")]
		private void _UpdateTick(float delta)
		{
		}

		// Token: 0x0600C4B2 RID: 50354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4B2")]
		[Address(RVA = "0x3426AE0", Offset = "0x34256E0", VA = "0x183426AE0")]
		private void _InitEffectImpls()
		{
		}

		// Token: 0x0600C4B3 RID: 50355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4B3")]
		[Address(RVA = "0x34284F0", Offset = "0x34270F0", VA = "0x1834284F0")]
		private void _SetEffectAmount(AVGSceneEffectManager.EffectConfig config)
		{
		}

		// Token: 0x0600C4B4 RID: 50356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4B4")]
		[Address(RVA = "0x3426FB0", Offset = "0x3425BB0", VA = "0x183426FB0")]
		private void _InterruptTweens(string key, List<string> channels)
		{
		}

		// Token: 0x0600C4B5 RID: 50357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4B5")]
		[Address(RVA = "0x3427140", Offset = "0x3425D40", VA = "0x183427140")]
		private void _InvokeCallbackAndRelease(AVGSceneEffectManager.TweenAction tween)
		{
		}

		// Token: 0x0600C4B6 RID: 50358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4B6")]
		[Address(RVA = "0x3428CA0", Offset = "0x34278A0", VA = "0x183428CA0")]
		private void _SetUpdateEnable(bool enable)
		{
		}

		// Token: 0x0600C4B7 RID: 50359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4B7")]
		[Address(RVA = "0x34273B0", Offset = "0x3425FB0", VA = "0x1834273B0")]
		private void _OnAllTweensFinished()
		{
		}

		// Token: 0x0600C4B8 RID: 50360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4B8")]
		[Address(RVA = "0x3429170", Offset = "0x3427D70", VA = "0x183429170")]
		private void _UpdateCommandStatus()
		{
		}

		// Token: 0x0600C4B9 RID: 50361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4B9")]
		[Address(RVA = "0x3425B90", Offset = "0x3424790", VA = "0x183425B90")]
		private void _ClearCommandBuffer()
		{
		}

		// Token: 0x0600C4BA RID: 50362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4BA")]
		[Address(RVA = "0x3428FB0", Offset = "0x3427BB0", VA = "0x183428FB0")]
		private void _UpdateCommandBufferStatus(bool prevActive, bool curActive)
		{
		}

		// Token: 0x0600C4BB RID: 50363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4BB")]
		[Address(RVA = "0x3427530", Offset = "0x3426130", VA = "0x183427530")]
		private void _RebuildCommandBuffer()
		{
		}

		// Token: 0x0600C4BC RID: 50364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C4BC")]
		[Address(RVA = "0x3427230", Offset = "0x3425E30", VA = "0x183427230")]
		private Material _LoadMaterial(string resPath)
		{
			return null;
		}

		// Token: 0x0600C4BD RID: 50365 RVA: 0x00048180 File Offset: 0x00046380
		[Token(Token = "0x600C4BD")]
		[Address(RVA = "0x3428410", Offset = "0x3427010", VA = "0x183428410")]
		private RenderTargetIdentifier _RequireTempRT(string key)
		{
			return default(RenderTargetIdentifier);
		}

		// Token: 0x0600C4BE RID: 50366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4BE")]
		[Address(RVA = "0x34281D0", Offset = "0x3426DD0", VA = "0x1834281D0")]
		private void _ReleaseTempRT(RenderTargetIdentifier rt)
		{
		}

		// Token: 0x0600C4BF RID: 50367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4BF")]
		[Address(RVA = "0x3425A40", Offset = "0x3424640", VA = "0x183425A40")]
		private void _BuiltinBlit(CommandBuffer cmd, RenderTargetIdentifier src, RenderTargetIdentifier dst)
		{
		}

		// Token: 0x0600C4C0 RID: 50368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4C0")]
		[Address(RVA = "0x3428E30", Offset = "0x3427A30", VA = "0x183428E30")]
		private void _TestOnlyBlitToProfileRT(CommandBuffer cmd, RenderTargetIdentifier src)
		{
		}

		// Token: 0x0600C4C1 RID: 50369 RVA: 0x00048198 File Offset: 0x00046398
		[Token(Token = "0x600C4C1")]
		[Address(RVA = "0x3427430", Offset = "0x3426030", VA = "0x183427430")]
		private int _PropertyToID(string key)
		{
			return 0;
		}

		// Token: 0x0600C4C2 RID: 50370 RVA: 0x000481B0 File Offset: 0x000463B0
		[Token(Token = "0x600C4C2")]
		[Address(RVA = "0x3425E60", Offset = "0x3424A60", VA = "0x183425E60")]
		private RenderTextureDescriptor _EnsureSourceDesc()
		{
			return default(RenderTextureDescriptor);
		}

		// Token: 0x0600C4C3 RID: 50371 RVA: 0x000481C8 File Offset: 0x000463C8
		[Token(Token = "0x600C4C3")]
		[Address(RVA = "0x3425C90", Offset = "0x3424890", VA = "0x183425C90")]
		private RenderTextureDescriptor _CreateRTDesc(int downsampleLevel)
		{
			return default(RenderTextureDescriptor);
		}

		// Token: 0x0600C4C4 RID: 50372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C4C4")]
		[Address(RVA = "0x3426400", Offset = "0x3425000", VA = "0x183426400")]
		private AVGSceneEffectManager.RTInfo _GetOrCreateRT(string key)
		{
			return null;
		}

		// Token: 0x0600C4C5 RID: 50373 RVA: 0x000481E0 File Offset: 0x000463E0
		[Token(Token = "0x600C4C5")]
		[Address(RVA = "0x3426A00", Offset = "0x3425600", VA = "0x183426A00")]
		private RenderTargetIdentifier _GetOrCreateScreenDefaultRT()
		{
			return default(RenderTargetIdentifier);
		}

		// Token: 0x0600C4C6 RID: 50374 RVA: 0x000481F8 File Offset: 0x000463F8
		[Token(Token = "0x600C4C6")]
		[Address(RVA = "0x34260D0", Offset = "0x3424CD0", VA = "0x1834260D0")]
		private bool _FindRTSize(RenderTargetIdentifier id, out int width, out int height)
		{
			return default(bool);
		}

		// Token: 0x0600C4C7 RID: 50375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C4C7")]
		[Address(RVA = "0x3425510", Offset = "0x3424110", VA = "0x183425510", Slot = "5")]
		public ILoadAsset GetAssetLoader()
		{
			return null;
		}

		// Token: 0x0400C91E RID: 51486
		[Token(Token = "0x400C91E")]
		public const string KEY_GRAYSCALE = "grayscale";

		// Token: 0x0400C91F RID: 51487
		[Token(Token = "0x400C91F")]
		public const string KEY_FOCUSOUT = "focusout";

		// Token: 0x0400C920 RID: 51488
		[Token(Token = "0x400C920")]
		public const string KEY_CHAOS = "chaos";

		// Token: 0x0400C921 RID: 51489
		[Token(Token = "0x400C921")]
		public const string CH_DEFAULT = "default";

		// Token: 0x0400C922 RID: 51490
		[Token(Token = "0x400C922")]
		public const string RT_DOWNSAMPLE0 = "DS_0";

		// Token: 0x0400C923 RID: 51491
		[Token(Token = "0x400C923")]
		public const string RT_DOWNSAMPLE1 = "DS_1";

		// Token: 0x0400C924 RID: 51492
		[Token(Token = "0x400C924")]
		public const string RT_DOWNSAMPLE2 = "DS_2";

		// Token: 0x0400C925 RID: 51493
		[Token(Token = "0x400C925")]
		public const string RT_SCREEN0 = "SCRN_0";

		// Token: 0x0400C926 RID: 51494
		[Token(Token = "0x400C926")]
		public const string RT_SCREEN1 = "SCRN_1";

		// Token: 0x0400C927 RID: 51495
		[Token(Token = "0x400C927")]
		private const string RT_SCREEN_DFT = "SCRN_DFT";

		// Token: 0x0400C928 RID: 51496
		[Token(Token = "0x400C928")]
		private const int DS_LVL_BLUR = 1;

		// Token: 0x0400C929 RID: 51497
		[Token(Token = "0x400C929")]
		private const int DS_LVL_SCREEN = 0;

		// Token: 0x0400C92A RID: 51498
		[Token(Token = "0x400C92A")]
		private const string CMD_NAME = "AVGSceneEffect";

		// Token: 0x0400C92B RID: 51499
		[Token(Token = "0x400C92B")]
		private const CameraEvent CMD_EVT = CameraEvent.BeforeImageEffects;

		// Token: 0x0400C92C RID: 51500
		[Token(Token = "0x400C92C")]
		[FieldOffset(Offset = "0x10")]
		private readonly RenderTargetIdentifier CAMERA_TARGET;

		// Token: 0x0400C92D RID: 51501
		[Token(Token = "0x400C92D")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string[] EFFECT_ORDER;

		// Token: 0x0400C92E RID: 51502
		[Token(Token = "0x400C92E")]
		[FieldOffset(Offset = "0x38")]
		private AVGSceneEffectManager.InitOptions m_initOptions;

		// Token: 0x0400C92F RID: 51503
		[Token(Token = "0x400C92F")]
		[FieldOffset(Offset = "0x50")]
		private Dictionary<string, AVGSceneEffectManager.EffectImplementation> m_effectImpls;

		// Token: 0x0400C930 RID: 51504
		[Token(Token = "0x400C930")]
		[FieldOffset(Offset = "0x58")]
		private Dictionary<string, List<string>> m_activeChannels;

		// Token: 0x0400C931 RID: 51505
		[Token(Token = "0x400C931")]
		[FieldOffset(Offset = "0x60")]
		private List<string> m_cacheChannels;

		// Token: 0x0400C932 RID: 51506
		[Token(Token = "0x400C932")]
		[FieldOffset(Offset = "0x68")]
		private List<AVGSceneEffectManager.TweenAction> m_activeTweens;

		// Token: 0x0400C933 RID: 51507
		[Token(Token = "0x400C933")]
		[FieldOffset(Offset = "0x70")]
		private LocalGenericPool<AVGSceneEffectManager.TweenAction> m_tweenPool;

		// Token: 0x0400C934 RID: 51508
		[Token(Token = "0x400C934")]
		[FieldOffset(Offset = "0x78")]
		private LocalGenericPool<RefCountCallback> m_callbackPool;

		// Token: 0x0400C935 RID: 51509
		[Token(Token = "0x400C935")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isUpdating;

		// Token: 0x0400C936 RID: 51510
		[Token(Token = "0x400C936")]
		[FieldOffset(Offset = "0x88")]
		private PostDisplayGroup m_postDisplayItems;

		// Token: 0x0400C937 RID: 51511
		[Token(Token = "0x400C937")]
		[FieldOffset(Offset = "0x90")]
		private CommandBuffer m_cmd;

		// Token: 0x0400C938 RID: 51512
		[Token(Token = "0x400C938")]
		[FieldOffset(Offset = "0x98")]
		private List<AVGSceneEffectManager.EffectImplementation> m_activeEffects;

		// Token: 0x0400C939 RID: 51513
		[Token(Token = "0x400C939")]
		[FieldOffset(Offset = "0xA0")]
		private TickFunction m_updateTick;

		// Token: 0x0400C93A RID: 51514
		[Token(Token = "0x400C93A")]
		[FieldOffset(Offset = "0xA8")]
		private List<AVGSceneEffectManager.RTInfo> m_activeRTs;

		// Token: 0x0400C93B RID: 51515
		[Token(Token = "0x400C93B")]
		[FieldOffset(Offset = "0xB0")]
		private LocalGenericPool<AVGSceneEffectManager.RTInfo> m_RTInfoPool;

		// Token: 0x0400C93C RID: 51516
		[Token(Token = "0x400C93C")]
		[FieldOffset(Offset = "0xB8")]
		private Dictionary<string, int> m_propertyToID;

		// Token: 0x0400C93D RID: 51517
		[Token(Token = "0x400C93D")]
		[FieldOffset(Offset = "0xC0")]
		private RenderTextureDescriptor m_sourceDesc;

		// Token: 0x0400C93E RID: 51518
		[Token(Token = "0x400C93E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0400C93F RID: 51519
		[Token(Token = "0x400C93F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateEffect;

		// Token: 0x0400C940 RID: 51520
		[Token(Token = "0x400C940")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetEffectAmount;

		// Token: 0x0400C941 RID: 51521
		[Token(Token = "0x400C941")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetEffectImplConfig;

		// Token: 0x0400C942 RID: 51522
		[Token(Token = "0x400C942")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_MarkEffectImplConfigDirty;

		// Token: 0x0400C943 RID: 51523
		[Token(Token = "0x400C943")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_BindPostDisplay;

		// Token: 0x0400C944 RID: 51524
		[Token(Token = "0x400C944")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_NotifyScreenSizeChanged;

		// Token: 0x0400C945 RID: 51525
		[Token(Token = "0x400C945")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Dispose;

		// Token: 0x0400C946 RID: 51526
		[Token(Token = "0x400C946")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__UpdateTick;

		// Token: 0x0400C947 RID: 51527
		[Token(Token = "0x400C947")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__InitEffectImpls;

		// Token: 0x0400C948 RID: 51528
		[Token(Token = "0x400C948")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__SetEffectAmount;

		// Token: 0x0400C949 RID: 51529
		[Token(Token = "0x400C949")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__InterruptTweens;

		// Token: 0x0400C94A RID: 51530
		[Token(Token = "0x400C94A")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__InvokeCallbackAndRelease;

		// Token: 0x0400C94B RID: 51531
		[Token(Token = "0x400C94B")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__SetUpdateEnable;

		// Token: 0x0400C94C RID: 51532
		[Token(Token = "0x400C94C")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnAllTweensFinished;

		// Token: 0x0400C94D RID: 51533
		[Token(Token = "0x400C94D")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__UpdateCommandStatus;

		// Token: 0x0400C94E RID: 51534
		[Token(Token = "0x400C94E")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__ClearCommandBuffer;

		// Token: 0x0400C94F RID: 51535
		[Token(Token = "0x400C94F")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__UpdateCommandBufferStatus;

		// Token: 0x0400C950 RID: 51536
		[Token(Token = "0x400C950")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__RebuildCommandBuffer;

		// Token: 0x0400C951 RID: 51537
		[Token(Token = "0x400C951")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__LoadMaterial;

		// Token: 0x0400C952 RID: 51538
		[Token(Token = "0x400C952")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__RequireTempRT;

		// Token: 0x0400C953 RID: 51539
		[Token(Token = "0x400C953")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__ReleaseTempRT;

		// Token: 0x0400C954 RID: 51540
		[Token(Token = "0x400C954")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__BuiltinBlit;

		// Token: 0x0400C955 RID: 51541
		[Token(Token = "0x400C955")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__TestOnlyBlitToProfileRT;

		// Token: 0x0400C956 RID: 51542
		[Token(Token = "0x400C956")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__PropertyToID;

		// Token: 0x0400C957 RID: 51543
		[Token(Token = "0x400C957")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__EnsureSourceDesc;

		// Token: 0x0400C958 RID: 51544
		[Token(Token = "0x400C958")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__CreateRTDesc;

		// Token: 0x0400C959 RID: 51545
		[Token(Token = "0x400C959")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__GetOrCreateRT;

		// Token: 0x0400C95A RID: 51546
		[Token(Token = "0x400C95A")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__GetOrCreateScreenDefaultRT;

		// Token: 0x0400C95B RID: 51547
		[Token(Token = "0x400C95B")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__FindRTSize;

		// Token: 0x0400C95C RID: 51548
		[Token(Token = "0x400C95C")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_GetAssetLoader;

		// Token: 0x02001EF4 RID: 7924
		[Token(Token = "0x2001EF4")]
		public struct InitOptions
		{
			// Token: 0x0400C95D RID: 51549
			[Token(Token = "0x400C95D")]
			[FieldOffset(Offset = "0x0")]
			public Camera camera;

			// Token: 0x0400C95E RID: 51550
			[Token(Token = "0x400C95E")]
			[FieldOffset(Offset = "0x8")]
			public ILoadAsset assetLoader;

			// Token: 0x0400C95F RID: 51551
			[Token(Token = "0x400C95F")]
			[FieldOffset(Offset = "0x10")]
			public RenderTexture profileTexture;
		}

		// Token: 0x02001EF5 RID: 7925
		[Token(Token = "0x2001EF5")]
		public struct EffectConfig
		{
			// Token: 0x17001773 RID: 6003
			// (get) Token: 0x0600C4C9 RID: 50377 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600C4CA RID: 50378 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001773")]
			public string channel
			{
				[Token(Token = "0x600C4C9")]
				[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
				[CompilerGenerated]
				private readonly get
				{
					return null;
				}
				[Token(Token = "0x600C4CA")]
				[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17001774 RID: 6004
			// (get) Token: 0x0600C4CB RID: 50379 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600C4CC RID: 50380 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001774")]
			public IList<string> channels
			{
				[Token(Token = "0x600C4CB")]
				[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
				[CompilerGenerated]
				private readonly get
				{
					return null;
				}
				[Token(Token = "0x600C4CC")]
				[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x0600C4CD RID: 50381 RVA: 0x00048210 File Offset: 0x00046410
			[Token(Token = "0x600C4CD")]
			[Address(RVA = "0x342F6C0", Offset = "0x342E2C0", VA = "0x18342F6C0")]
			public bool IsChannelEmpty()
			{
				return default(bool);
			}

			// Token: 0x0600C4CE RID: 50382 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C4CE")]
			[Address(RVA = "0x342F840", Offset = "0x342E440", VA = "0x18342F840")]
			public void PickChannels(List<string> output)
			{
			}

			// Token: 0x0600C4CF RID: 50383 RVA: 0x00048228 File Offset: 0x00046428
			[Token(Token = "0x600C4CF")]
			[Address(RVA = "0x342F7E0", Offset = "0x342E3E0", VA = "0x18342F7E0")]
			public bool NeedTween()
			{
				return default(bool);
			}

			// Token: 0x0600C4D0 RID: 50384 RVA: 0x00048240 File Offset: 0x00046440
			[Token(Token = "0x600C4D0")]
			[Address(RVA = "0x342F710", Offset = "0x342E310", VA = "0x18342F710")]
			public bool IsValid(out string errorInfo)
			{
				return default(bool);
			}

			// Token: 0x0400C960 RID: 51552
			[Token(Token = "0x400C960")]
			[FieldOffset(Offset = "0x0")]
			public string key;

			// Token: 0x0400C961 RID: 51553
			[Token(Token = "0x400C961")]
			[FieldOffset(Offset = "0x8")]
			public float amount;

			// Token: 0x0400C962 RID: 51554
			[Token(Token = "0x400C962")]
			[FieldOffset(Offset = "0xC")]
			public float duration;

			// Token: 0x0400C963 RID: 51555
			[Token(Token = "0x400C963")]
			[FieldOffset(Offset = "0x10")]
			public Action onTweenFinished;

			// Token: 0x0400C964 RID: 51556
			[Token(Token = "0x400C964")]
			[FieldOffset(Offset = "0x18")]
			public object miscParam;
		}

		// Token: 0x02001EF6 RID: 7926
		[Token(Token = "0x2001EF6")]
		public struct ContentViewportScissor : IDisposable, IHotfixable
		{
			// Token: 0x17001775 RID: 6005
			// (get) Token: 0x0600C4D1 RID: 50385 RVA: 0x00048258 File Offset: 0x00046458
			// (set) Token: 0x0600C4D2 RID: 50386 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001775")]
			public bool isValid
			{
				[Token(Token = "0x600C4D1")]
				[Address(RVA = "0x342E830", Offset = "0x342D430", VA = "0x18342E830")]
				[CompilerGenerated]
				readonly get
				{
					return default(bool);
				}
				[Token(Token = "0x600C4D2")]
				[Address(RVA = "0x342E8B0", Offset = "0x342D4B0", VA = "0x18342E8B0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0600C4D3 RID: 50387 RVA: 0x00048270 File Offset: 0x00046470
			[Token(Token = "0x600C4D3")]
			[Address(RVA = "0x342E3B0", Offset = "0x342CFB0", VA = "0x18342E3B0")]
			public static AVGSceneEffectManager.ContentViewportScissor Create(AVGSceneEffectManager mgr, RenderTargetIdentifier target)
			{
				return default(AVGSceneEffectManager.ContentViewportScissor);
			}

			// Token: 0x0600C4D4 RID: 50388 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C4D4")]
			[Address(RVA = "0x342E2F0", Offset = "0x342CEF0", VA = "0x18342E2F0")]
			public void Apply()
			{
			}

			// Token: 0x0600C4D5 RID: 50389 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C4D5")]
			[Address(RVA = "0x342E790", Offset = "0x342D390", VA = "0x18342E790", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x0400C967 RID: 51559
			[Token(Token = "0x400C967")]
			[FieldOffset(Offset = "0x0")]
			private bool m_isApplying;

			// Token: 0x0400C968 RID: 51560
			[Token(Token = "0x400C968")]
			[FieldOffset(Offset = "0x8")]
			private AVGSceneEffectManager m_mgr;

			// Token: 0x0400C969 RID: 51561
			[Token(Token = "0x400C969")]
			[FieldOffset(Offset = "0x10")]
			private Rect m_rect;

			// Token: 0x0400C96B RID: 51563
			[Token(Token = "0x400C96B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_isValid;

			// Token: 0x0400C96C RID: 51564
			[Token(Token = "0x400C96C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_isValid;

			// Token: 0x0400C96D RID: 51565
			[Token(Token = "0x400C96D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_Create;

			// Token: 0x0400C96E RID: 51566
			[Token(Token = "0x400C96E")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_Apply;

			// Token: 0x0400C96F RID: 51567
			[Token(Token = "0x400C96F")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_Dispose;
		}

		// Token: 0x02001EF7 RID: 7927
		[Token(Token = "0x2001EF7")]
		private class TweenAction
		{
			// Token: 0x0600C4D6 RID: 50390 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C4D6")]
			[Address(RVA = "0x3436610", Offset = "0x3435210", VA = "0x183436610")]
			public static void Reset(AVGSceneEffectManager.TweenAction inst)
			{
			}

			// Token: 0x0600C4D7 RID: 50391 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C4D7")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public TweenAction()
			{
			}

			// Token: 0x0400C970 RID: 51568
			[Token(Token = "0x400C970")]
			[FieldOffset(Offset = "0x10")]
			public string key;

			// Token: 0x0400C971 RID: 51569
			[Token(Token = "0x400C971")]
			[FieldOffset(Offset = "0x18")]
			public string channel;

			// Token: 0x0400C972 RID: 51570
			[Token(Token = "0x400C972")]
			[FieldOffset(Offset = "0x20")]
			public TweenUtils.SmoothStep tween;

			// Token: 0x0400C973 RID: 51571
			[Token(Token = "0x400C973")]
			[FieldOffset(Offset = "0x58")]
			public AVGSceneEffectManager.EffectImplementation impl;

			// Token: 0x0400C974 RID: 51572
			[Token(Token = "0x400C974")]
			[FieldOffset(Offset = "0x60")]
			public RefCountCallback callback;

			// Token: 0x0400C975 RID: 51573
			[Token(Token = "0x400C975")]
			[FieldOffset(Offset = "0x68")]
			public bool willActivateChannel;
		}

		// Token: 0x02001EF8 RID: 7928
		[Token(Token = "0x2001EF8")]
		private class RTInfo
		{
			// Token: 0x0600C4D8 RID: 50392 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C4D8")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RTInfo()
			{
			}

			// Token: 0x0400C976 RID: 51574
			[Token(Token = "0x400C976")]
			[FieldOffset(Offset = "0x10")]
			public string key;

			// Token: 0x0400C977 RID: 51575
			[Token(Token = "0x400C977")]
			[FieldOffset(Offset = "0x18")]
			public int refCnt;

			// Token: 0x0400C978 RID: 51576
			[Token(Token = "0x400C978")]
			[FieldOffset(Offset = "0x20")]
			public RenderTargetIdentifier id;

			// Token: 0x0400C979 RID: 51577
			[Token(Token = "0x400C979")]
			[FieldOffset(Offset = "0x48")]
			public RenderTextureDescriptor desc;
		}

		// Token: 0x02001EF9 RID: 7929
		[Token(Token = "0x2001EF9")]
		public abstract class EffectImplementation : IDisposable, IComparable<AVGSceneEffectManager.EffectImplementation>
		{
			// Token: 0x0600C4D9 RID: 50393
			[Token(Token = "0x600C4D9")]
			public abstract void SetAmount(string channel, float amount);

			// Token: 0x0600C4DA RID: 50394
			[Token(Token = "0x600C4DA")]
			public abstract float GetAmount(string channel);

			// Token: 0x0600C4DB RID: 50395
			[Token(Token = "0x600C4DB")]
			public abstract void GetActiveChannels(List<string> channelList);

			// Token: 0x0600C4DC RID: 50396
			[Token(Token = "0x600C4DC")]
			protected abstract void Render(CommandBuffer cmd, RenderTargetIdentifier src, RenderTargetIdentifier dst);

			// Token: 0x0600C4DD RID: 50397 RVA: 0x00048288 File Offset: 0x00046488
			[Token(Token = "0x600C4DD")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "10")]
			public virtual bool RequiresScissor()
			{
				return default(bool);
			}

			// Token: 0x0600C4DE RID: 50398 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C4DE")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "11")]
			public virtual void Dispose()
			{
			}

			// Token: 0x0600C4DF RID: 50399 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600C4DF")]
			[Address(RVA = "0x342FEA0", Offset = "0x342EAA0", VA = "0x18342FEA0")]
			protected Material LoadMaterial(string resPath)
			{
				return null;
			}

			// Token: 0x0600C4E0 RID: 50400 RVA: 0x000482A0 File Offset: 0x000464A0
			[Token(Token = "0x600C4E0")]
			[Address(RVA = "0x342FF20", Offset = "0x342EB20", VA = "0x18342FF20")]
			protected RenderTargetIdentifier RequireTempRT(string id)
			{
				return default(RenderTargetIdentifier);
			}

			// Token: 0x0600C4E1 RID: 50401 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C4E1")]
			[Address(RVA = "0x342FED0", Offset = "0x342EAD0", VA = "0x18342FED0")]
			protected void ReleaseTempRT(RenderTargetIdentifier rt)
			{
			}

			// Token: 0x0600C4E2 RID: 50402 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C4E2")]
			[Address(RVA = "0x342F910", Offset = "0x342E510", VA = "0x18342F910")]
			protected void BuiltinBlit(CommandBuffer cmd, RenderTargetIdentifier src, RenderTargetIdentifier dst)
			{
			}

			// Token: 0x0600C4E3 RID: 50403 RVA: 0x000482B8 File Offset: 0x000464B8
			[Token(Token = "0x600C4E3")]
			[Address(RVA = "0x3430010", Offset = "0x342EC10", VA = "0x183430010")]
			protected AVGSceneEffectManager.ContentViewportScissor Scissor4ContentViewport(RenderTargetIdentifier target)
			{
				return default(AVGSceneEffectManager.ContentViewportScissor);
			}

			// Token: 0x0600C4E4 RID: 50404 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C4E4")]
			[Address(RVA = "0x3430080", Offset = "0x342EC80", VA = "0x183430080")]
			[Conditional("TEST")]
			[Conditional("UNITY_EDITOR")]
			protected void TestOnly_BlitToProfileTexture(CommandBuffer cmd, RenderTargetIdentifier src)
			{
			}

			// Token: 0x17001776 RID: 6006
			// (get) Token: 0x0600C4E5 RID: 50405 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600C4E6 RID: 50406 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001776")]
			public string key
			{
				[Token(Token = "0x600C4E5")]
				[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600C4E6")]
				[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17001777 RID: 6007
			// (get) Token: 0x0600C4E7 RID: 50407 RVA: 0x000482D0 File Offset: 0x000464D0
			// (set) Token: 0x0600C4E8 RID: 50408 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001777")]
			public int sortIndex
			{
				[Token(Token = "0x600C4E7")]
				[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x600C4E8")]
				[Address(RVA = "0x4EAC20", Offset = "0x4E9820", VA = "0x1804EAC20")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17001778 RID: 6008
			// (get) Token: 0x0600C4E9 RID: 50409 RVA: 0x000482E8 File Offset: 0x000464E8
			// (set) Token: 0x0600C4EA RID: 50410 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001778")]
			public bool isRenderDirty
			{
				[Token(Token = "0x600C4E9")]
				[Address(RVA = "0x4EA840", Offset = "0x4E9440", VA = "0x1804EA840")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600C4EA")]
				[Address(RVA = "0x4EA980", Offset = "0x4E9580", VA = "0x1804EA980")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0600C4EB RID: 50411 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C4EB")]
			[Address(RVA = "0x342FEC0", Offset = "0x342EAC0", VA = "0x18342FEC0")]
			public void MarkRenderDirty()
			{
			}

			// Token: 0x0600C4EC RID: 50412 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C4EC")]
			[Address(RVA = "0x342FD90", Offset = "0x342E990", VA = "0x18342FD90")]
			public void Init(string key, int sortIndex, AVGSceneEffectManager ctrl)
			{
			}

			// Token: 0x0600C4ED RID: 50413 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600C4ED")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "12")]
			public virtual object GetConfig()
			{
				return null;
			}

			// Token: 0x0600C4EE RID: 50414 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C4EE")]
			[Address(RVA = "0x342FDE0", Offset = "0x342E9E0", VA = "0x18342FDE0")]
			public void InvokeRender(CommandBuffer cmd, RenderTargetIdentifier src, RenderTargetIdentifier dst)
			{
			}

			// Token: 0x0600C4EF RID: 50415 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600C4EF")]
			[Address(RVA = "0x342F9E0", Offset = "0x342E5E0", VA = "0x18342F9E0")]
			protected Material CreateNewMaterial(string resPath)
			{
				return null;
			}

			// Token: 0x0600C4F0 RID: 50416 RVA: 0x00048300 File Offset: 0x00046500
			[Token(Token = "0x600C4F0")]
			[Address(RVA = "0x342F980", Offset = "0x342E580", VA = "0x18342F980", Slot = "5")]
			public int CompareTo(AVGSceneEffectManager.EffectImplementation other)
			{
				return 0;
			}

			// Token: 0x0600C4F1 RID: 50417 RVA: 0x00048318 File Offset: 0x00046518
			[Token(Token = "0x600C4F1")]
			[Address(RVA = "0x342FC90", Offset = "0x342E890", VA = "0x18342FC90")]
			protected bool GetOrCreateMaterial(string resPath, ref Material mat)
			{
				return default(bool);
			}

			// Token: 0x0600C4F2 RID: 50418 RVA: 0x00048330 File Offset: 0x00046530
			[Token(Token = "0x600C4F2")]
			[Address(RVA = "0x342FB60", Offset = "0x342E760", VA = "0x18342FB60")]
			protected bool GetOrCreateMaterialWithShader(string shaderName, ref Material mat)
			{
				return default(bool);
			}

			// Token: 0x0600C4F3 RID: 50419 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C4F3")]
			[Address(RVA = "0x342FAA0", Offset = "0x342E6A0", VA = "0x18342FAA0")]
			protected static void DestroyMaterial(ref Material mat)
			{
			}

			// Token: 0x0600C4F4 RID: 50420 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C4F4")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			protected EffectImplementation()
			{
			}

			// Token: 0x0400C97A RID: 51578
			[Token(Token = "0x400C97A")]
			[FieldOffset(Offset = "0x10")]
			private AVGSceneEffectManager m_internalCtrl;
		}
	}
}
