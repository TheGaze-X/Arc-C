using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Hypergryph.SDK;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020038A8 RID: 14504
	[Token(Token = "0x20038A8")]
	public class UIWebWindow : IHotfixable
	{
		// Token: 0x06016F26 RID: 93990 RVA: 0x00094158 File Offset: 0x00092358
		[Token(Token = "0x6016F26")]
		[Address(RVA = "0xF6B1A0", Offset = "0xF69DA0", VA = "0x180F6B1A0")]
		public static bool HasActiveWindow()
		{
			return default(bool);
		}

		// Token: 0x06016F27 RID: 93991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016F27")]
		[Address(RVA = "0xF6B630", Offset = "0xF6A230", VA = "0x180F6B630")]
		public static UIWebWindow OpenWindow(UIWebWindow.Options options)
		{
			return null;
		}

		// Token: 0x06016F28 RID: 93992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016F28")]
		[Address(RVA = "0xF6AF10", Offset = "0xF69B10", VA = "0x180F6AF10")]
		public static void BroadcastHasNewContent(string busType, bool updateFromRemote)
		{
		}

		// Token: 0x06016F29 RID: 93993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016F29")]
		[Address(RVA = "0xF6AE40", Offset = "0xF69A40", VA = "0x180F6AE40")]
		public static void AddMsgReceiver(UIWebWindow.MsgReceiver receiver)
		{
		}

		// Token: 0x06016F2A RID: 93994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016F2A")]
		[Address(RVA = "0xF6B960", Offset = "0xF6A560", VA = "0x180F6B960")]
		public static void RemoveMsgReceiver(UIWebWindow.MsgReceiver receiver)
		{
		}

		// Token: 0x06016F2B RID: 93995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016F2B")]
		[Address(RVA = "0xF6B7C0", Offset = "0xF6A3C0", VA = "0x180F6B7C0")]
		public static void Preload(string busType)
		{
		}

		// Token: 0x06016F2C RID: 93996 RVA: 0x00094170 File Offset: 0x00092370
		[Token(Token = "0x6016F2C")]
		[Address(RVA = "0xF6B090", Offset = "0xF69C90", VA = "0x180F6B090")]
		public static bool CheckIfPreloading()
		{
			return default(bool);
		}

		// Token: 0x06016F2D RID: 93997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016F2D")]
		[Address(RVA = "0xF6B430", Offset = "0xF6A030", VA = "0x180F6B430")]
		public static void OpenAdditionalMiniWeb(UIWebWindow.MiniWebOptions options)
		{
		}

		// Token: 0x06016F2E RID: 93998 RVA: 0x00094188 File Offset: 0x00092388
		[Token(Token = "0x6016F2E")]
		[Address(RVA = "0xF6B390", Offset = "0xF69F90", VA = "0x180F6B390")]
		public static bool IsAdditionalMiniWebShowing()
		{
			return default(bool);
		}

		// Token: 0x06016F2F RID: 93999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016F2F")]
		[Address(RVA = "0xF6BB30", Offset = "0xF6A730", VA = "0x180F6BB30")]
		private static void _UpdateWebSDKViewState()
		{
		}

		// Token: 0x06016F30 RID: 94000 RVA: 0x000941A0 File Offset: 0x000923A0
		[Token(Token = "0x6016F30")]
		[Address(RVA = "0xF6B290", Offset = "0xF69E90", VA = "0x180F6B290")]
		public bool IsActive()
		{
			return default(bool);
		}

		// Token: 0x06016F31 RID: 94001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016F31")]
		[Address(RVA = "0xF6B100", Offset = "0xF69D00", VA = "0x180F6B100")]
		public void Close()
		{
		}

		// Token: 0x06016F32 RID: 94002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016F32")]
		[Address(RVA = "0xF6BA20", Offset = "0xF6A620", VA = "0x180F6BA20")]
		public void ToastText(int level, string message)
		{
		}

		// Token: 0x06016F33 RID: 94003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016F33")]
		[Address(RVA = "0xF6BEE0", Offset = "0xF6AAE0", VA = "0x180F6BEE0")]
		private UIWebWindow()
		{
		}

		// Token: 0x0401BB26 RID: 113446
		[Token(Token = "0x401BB26")]
		[FieldOffset(Offset = "0x0")]
		private static UIWebWindow.Core s_core;

		// Token: 0x0401BB27 RID: 113447
		[Token(Token = "0x401BB27")]
		[FieldOffset(Offset = "0x10")]
		private UIWebWindow.Options m_options;

		// Token: 0x0401BB28 RID: 113448
		[Token(Token = "0x401BB28")]
		[FieldOffset(Offset = "0x60")]
		private bool m_isClosing;

		// Token: 0x0401BB29 RID: 113449
		[Token(Token = "0x401BB29")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HasActiveWindow;

		// Token: 0x0401BB2A RID: 113450
		[Token(Token = "0x401BB2A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OpenWindow;

		// Token: 0x0401BB2B RID: 113451
		[Token(Token = "0x401BB2B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_BroadcastHasNewContent;

		// Token: 0x0401BB2C RID: 113452
		[Token(Token = "0x401BB2C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_AddMsgReceiver;

		// Token: 0x0401BB2D RID: 113453
		[Token(Token = "0x401BB2D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RemoveMsgReceiver;

		// Token: 0x0401BB2E RID: 113454
		[Token(Token = "0x401BB2E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Preload;

		// Token: 0x0401BB2F RID: 113455
		[Token(Token = "0x401BB2F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CheckIfPreloading;

		// Token: 0x0401BB30 RID: 113456
		[Token(Token = "0x401BB30")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OpenAdditionalMiniWeb;

		// Token: 0x0401BB31 RID: 113457
		[Token(Token = "0x401BB31")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_IsAdditionalMiniWebShowing;

		// Token: 0x0401BB32 RID: 113458
		[Token(Token = "0x401BB32")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__UpdateWebSDKViewState;

		// Token: 0x0401BB33 RID: 113459
		[Token(Token = "0x401BB33")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_IsActive;

		// Token: 0x0401BB34 RID: 113460
		[Token(Token = "0x401BB34")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_Close;

		// Token: 0x0401BB35 RID: 113461
		[Token(Token = "0x401BB35")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_ToastText;

		// Token: 0x0401BB36 RID: 113462
		[Token(Token = "0x401BB36")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020038A9 RID: 14505
		[Token(Token = "0x20038A9")]
		public enum OpenRet
		{
			// Token: 0x0401BB38 RID: 113464
			[Token(Token = "0x401BB38")]
			SUC,
			// Token: 0x0401BB39 RID: 113465
			[Token(Token = "0x401BB39")]
			LOAD_FAIL,
			// Token: 0x0401BB3A RID: 113466
			[Token(Token = "0x401BB3A")]
			DUPLIATED,
			// Token: 0x0401BB3B RID: 113467
			[Token(Token = "0x401BB3B")]
			UNKNOWN = 999
		}

		// Token: 0x020038AA RID: 14506
		[Token(Token = "0x20038AA")]
		public enum MiniWebRet
		{
			// Token: 0x0401BB3D RID: 113469
			[Token(Token = "0x401BB3D")]
			SUC,
			// Token: 0x0401BB3E RID: 113470
			[Token(Token = "0x401BB3E")]
			INTERNAL_ERR,
			// Token: 0x0401BB3F RID: 113471
			[Token(Token = "0x401BB3F")]
			DUP_INVOKE
		}

		// Token: 0x020038AB RID: 14507
		[Token(Token = "0x20038AB")]
		public enum MiniWebStyle
		{
			// Token: 0x0401BB41 RID: 113473
			[Token(Token = "0x401BB41")]
			DEFAULT
		}

		// Token: 0x020038AC RID: 14508
		[Token(Token = "0x20038AC")]
		public struct Options
		{
			// Token: 0x0401BB42 RID: 113474
			[Token(Token = "0x401BB42")]
			[FieldOffset(Offset = "0x0")]
			public string busType;

			// Token: 0x0401BB43 RID: 113475
			[Token(Token = "0x401BB43")]
			[FieldOffset(Offset = "0x8")]
			public string token;

			// Token: 0x0401BB44 RID: 113476
			[Token(Token = "0x401BB44")]
			[FieldOffset(Offset = "0x10")]
			public string uid;

			// Token: 0x0401BB45 RID: 113477
			[Token(Token = "0x401BB45")]
			[FieldOffset(Offset = "0x18")]
			public Dictionary<string, string> webQuery;

			// Token: 0x0401BB46 RID: 113478
			[Token(Token = "0x401BB46")]
			[FieldOffset(Offset = "0x20")]
			public string urlFragment;

			// Token: 0x0401BB47 RID: 113479
			[Token(Token = "0x401BB47")]
			[FieldOffset(Offset = "0x28")]
			public Dictionary<string, string> urlParam;

			// Token: 0x0401BB48 RID: 113480
			[Token(Token = "0x401BB48")]
			[FieldOffset(Offset = "0x30")]
			public Action onClosed;

			// Token: 0x0401BB49 RID: 113481
			[Token(Token = "0x401BB49")]
			[FieldOffset(Offset = "0x38")]
			public Action onOpenFailed;

			// Token: 0x0401BB4A RID: 113482
			[Token(Token = "0x401BB4A")]
			[FieldOffset(Offset = "0x40")]
			public Action<UIWebScheme> onUrlClick;

			// Token: 0x0401BB4B RID: 113483
			[Token(Token = "0x401BB4B")]
			[FieldOffset(Offset = "0x48")]
			public Action<UIWebWindow.OpenRet> onOpenRet;
		}

		// Token: 0x020038AD RID: 14509
		[Token(Token = "0x20038AD")]
		public class MsgReceiver
		{
			// Token: 0x06016F35 RID: 94005 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016F35")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public MsgReceiver()
			{
			}

			// Token: 0x0401BB4C RID: 113484
			[Token(Token = "0x401BB4C")]
			[FieldOffset(Offset = "0x10")]
			public string busType;

			// Token: 0x0401BB4D RID: 113485
			[Token(Token = "0x401BB4D")]
			[FieldOffset(Offset = "0x18")]
			public Action<bool> onHasNewContent;
		}

		// Token: 0x020038AE RID: 14510
		[Token(Token = "0x20038AE")]
		public struct MiniWebOptions
		{
			// Token: 0x0401BB4E RID: 113486
			[Token(Token = "0x401BB4E")]
			[FieldOffset(Offset = "0x0")]
			public string url;

			// Token: 0x0401BB4F RID: 113487
			[Token(Token = "0x401BB4F")]
			[FieldOffset(Offset = "0x8")]
			public UIWebWindow.MiniWebStyle style;

			// Token: 0x0401BB50 RID: 113488
			[Token(Token = "0x401BB50")]
			[FieldOffset(Offset = "0x10")]
			public string uid;

			// Token: 0x0401BB51 RID: 113489
			[Token(Token = "0x401BB51")]
			[FieldOffset(Offset = "0x18")]
			public string token;

			// Token: 0x0401BB52 RID: 113490
			[Token(Token = "0x401BB52")]
			[FieldOffset(Offset = "0x20")]
			public Action<UIWebWindow.MiniWebRet, int> onFinish;
		}

		// Token: 0x020038AF RID: 14511
		[Token(Token = "0x20038AF")]
		private class MiniWebview
		{
			// Token: 0x06016F36 RID: 94006 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016F36")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public MiniWebview()
			{
			}

			// Token: 0x0401BB53 RID: 113491
			[Token(Token = "0x401BB53")]
			[FieldOffset(Offset = "0x10")]
			public UIWebWindow.MiniWebOptions options;
		}

		// Token: 0x020038B0 RID: 14512
		[Token(Token = "0x20038B0")]
		private class Core : IHotfixable
		{
			// Token: 0x170036D9 RID: 14041
			// (get) Token: 0x06016F37 RID: 94007 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06016F38 RID: 94008 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170036D9")]
			public UIWebWindow activeInst
			{
				[Token(Token = "0x6016F37")]
				[Address(RVA = "0xF58970", Offset = "0xF57570", VA = "0x180F58970")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6016F38")]
				[Address(RVA = "0xF58A80", Offset = "0xF57680", VA = "0x180F58A80")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170036DA RID: 14042
			// (get) Token: 0x06016F39 RID: 94009 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06016F3A RID: 94010 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170036DA")]
			public UIWebWindow.MiniWebview miniWeb
			{
				[Token(Token = "0x6016F39")]
				[Address(RVA = "0xF589D0", Offset = "0xF575D0", VA = "0x180F589D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6016F3A")]
				[Address(RVA = "0xF58B00", Offset = "0xF57700", VA = "0x180F58B00")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06016F3B RID: 94011 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016F3B")]
			[Address(RVA = "0xF56200", Offset = "0xF54E00", VA = "0x180F56200")]
			public void ManualInit(Action actionWhenInited)
			{
			}

			// Token: 0x06016F3C RID: 94012 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6016F3C")]
			[Address(RVA = "0xF55D70", Offset = "0xF54970", VA = "0x180F55D70")]
			public UIWebWindow CreateActiveInst(UIWebWindow.Options options)
			{
				return null;
			}

			// Token: 0x06016F3D RID: 94013 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016F3D")]
			[Address(RVA = "0xF58010", Offset = "0xF56C10", VA = "0x180F58010")]
			private void _InvokeNativeLoadWebView(UIWebWindow.Options options)
			{
			}

			// Token: 0x06016F3E RID: 94014 RVA: 0x000941B8 File Offset: 0x000923B8
			[Token(Token = "0x6016F3E")]
			[Address(RVA = "0xF576A0", Offset = "0xF562A0", VA = "0x180F576A0")]
			private static UserData _CreateUserData(string uid, string token)
			{
				return default(UserData);
			}

			// Token: 0x06016F3F RID: 94015 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016F3F")]
			[Address(RVA = "0xF55A30", Offset = "0xF54630", VA = "0x180F55A30")]
			public void CloseWindow(UIWebWindow window)
			{
			}

			// Token: 0x06016F40 RID: 94016 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016F40")]
			[Address(RVA = "0xF559C0", Offset = "0xF545C0", VA = "0x180F559C0")]
			public void CheckIsNew(string busType)
			{
			}

			// Token: 0x06016F41 RID: 94017 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016F41")]
			[Address(RVA = "0xF55950", Offset = "0xF54550", VA = "0x180F55950")]
			public void CheckIsNewByCache(string busType)
			{
			}

			// Token: 0x06016F42 RID: 94018 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016F42")]
			[Address(RVA = "0xF57200", Offset = "0xF55E00", VA = "0x180F57200")]
			public void ToastInsideWebView(int level, string message)
			{
			}

			// Token: 0x06016F43 RID: 94019 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016F43")]
			[Address(RVA = "0xF56280", Offset = "0xF54E80", VA = "0x180F56280")]
			public void NotifyWebSystemInited()
			{
			}

			// Token: 0x06016F44 RID: 94020 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016F44")]
			[Address(RVA = "0xF570B0", Offset = "0xF55CB0", VA = "0x180F570B0")]
			public void OpenMiniWebview(UIWebWindow.MiniWebOptions options)
			{
			}

			// Token: 0x06016F45 RID: 94021 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016F45")]
			[Address(RVA = "0xF58590", Offset = "0xF57190", VA = "0x180F58590")]
			private void _LoadMiniWebviewImpl(UIWebWindow.MiniWebOptions options)
			{
			}

			// Token: 0x06016F46 RID: 94022 RVA: 0x000941D0 File Offset: 0x000923D0
			[Token(Token = "0x6016F46")]
			[Address(RVA = "0xF575D0", Offset = "0xF561D0", VA = "0x180F575D0")]
			private static MiniWebCustomStyle _CreateMiniWebStyle(UIWebWindow.MiniWebOptions options)
			{
				return default(MiniWebCustomStyle);
			}

			// Token: 0x06016F47 RID: 94023 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016F47")]
			[Address(RVA = "0xF56980", Offset = "0xF55580", VA = "0x180F56980")]
			public void OnWebViewOpen(CallbackMsg msg)
			{
			}

			// Token: 0x06016F48 RID: 94024 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016F48")]
			[Address(RVA = "0xF56400", Offset = "0xF55000", VA = "0x180F56400")]
			public void OnIsNewRet(CallbackMsg msg)
			{
			}

			// Token: 0x06016F49 RID: 94025 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016F49")]
			[Address(RVA = "0xF566B0", Offset = "0xF552B0", VA = "0x180F566B0")]
			public void OnWebViewClose(CallbackMsg msg)
			{
			}

			// Token: 0x06016F4A RID: 94026 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016F4A")]
			[Address(RVA = "0xF56E70", Offset = "0xF55A70", VA = "0x180F56E70")]
			public void OnWebViewUrlClick(CallbackMsg msg)
			{
			}

			// Token: 0x06016F4B RID: 94027 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016F4B")]
			[Address(RVA = "0xF564A0", Offset = "0xF550A0", VA = "0x180F564A0")]
			public void OnMiniWebFinish(CallbackMsg msg)
			{
			}

			// Token: 0x06016F4C RID: 94028 RVA: 0x000941E8 File Offset: 0x000923E8
			[Token(Token = "0x6016F4C")]
			[Address(RVA = "0xF574C0", Offset = "0xF560C0", VA = "0x180F574C0")]
			private static UIWebWindow.OpenRet _ConvertWebOpenRet(int errorCode)
			{
				return UIWebWindow.OpenRet.SUC;
			}

			// Token: 0x06016F4D RID: 94029 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016F4D")]
			[Address(RVA = "0xF58360", Offset = "0xF56F60", VA = "0x180F58360")]
			private void _InvokeWhenInited(Action action)
			{
			}

			// Token: 0x06016F4E RID: 94030 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016F4E")]
			[Address(RVA = "0xF57290", Offset = "0xF55E90", VA = "0x180F57290")]
			private void _BroadcastIsNewRet(string busType, int ret)
			{
			}

			// Token: 0x06016F4F RID: 94031 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6016F4F")]
			[Address(RVA = "0xF57870", Offset = "0xF56470", VA = "0x180F57870")]
			private static string _DescribeOptions(UIWebWindow.Options options)
			{
				return null;
			}

			// Token: 0x06016F50 RID: 94032 RVA: 0x00094200 File Offset: 0x00092400
			[Token(Token = "0x6016F50")]
			[Address(RVA = "0xF587E0", Offset = "0xF573E0", VA = "0x180F587E0")]
			private static int _SafeLength(string value)
			{
				return 0;
			}

			// Token: 0x06016F51 RID: 94033 RVA: 0x00094218 File Offset: 0x00092418
			[Token(Token = "0x6016F51")]
			[Address(RVA = "0xF57550", Offset = "0xF56150", VA = "0x180F57550")]
			private static int _Count(Dictionary<string, string> dict)
			{
				return 0;
			}

			// Token: 0x06016F52 RID: 94034 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6016F52")]
			[Address(RVA = "0xF57F10", Offset = "0xF56B10", VA = "0x180F57F10")]
			private static string _GetDictionaryValue(Dictionary<string, string> dict, string key)
			{
				return null;
			}

			// Token: 0x06016F53 RID: 94035 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016F53")]
			[Address(RVA = "0xF58860", Offset = "0xF57460", VA = "0x180F58860")]
			public Core()
			{
			}

			// Token: 0x0401BB54 RID: 113492
			[Token(Token = "0x401BB54")]
			[FieldOffset(Offset = "0x10")]
			private List<Action> m_waitForInited;

			// Token: 0x0401BB55 RID: 113493
			[Token(Token = "0x401BB55")]
			[FieldOffset(Offset = "0x18")]
			private UIWebWindow.HGWebAdapter m_adapter;

			// Token: 0x0401BB56 RID: 113494
			[Token(Token = "0x401BB56")]
			[FieldOffset(Offset = "0x20")]
			public HashSet<UIWebWindow.MsgReceiver> msgReceivers;

			// Token: 0x0401BB59 RID: 113497
			[Token(Token = "0x401BB59")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_activeInst;

			// Token: 0x0401BB5A RID: 113498
			[Token(Token = "0x401BB5A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_activeInst;

			// Token: 0x0401BB5B RID: 113499
			[Token(Token = "0x401BB5B")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_miniWeb;

			// Token: 0x0401BB5C RID: 113500
			[Token(Token = "0x401BB5C")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_miniWeb;

			// Token: 0x0401BB5D RID: 113501
			[Token(Token = "0x401BB5D")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_ManualInit;

			// Token: 0x0401BB5E RID: 113502
			[Token(Token = "0x401BB5E")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_CreateActiveInst;

			// Token: 0x0401BB5F RID: 113503
			[Token(Token = "0x401BB5F")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0__InvokeNativeLoadWebView;

			// Token: 0x0401BB60 RID: 113504
			[Token(Token = "0x401BB60")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0__CreateUserData;

			// Token: 0x0401BB61 RID: 113505
			[Token(Token = "0x401BB61")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_CloseWindow;

			// Token: 0x0401BB62 RID: 113506
			[Token(Token = "0x401BB62")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_CheckIsNew;

			// Token: 0x0401BB63 RID: 113507
			[Token(Token = "0x401BB63")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_CheckIsNewByCache;

			// Token: 0x0401BB64 RID: 113508
			[Token(Token = "0x401BB64")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_ToastInsideWebView;

			// Token: 0x0401BB65 RID: 113509
			[Token(Token = "0x401BB65")]
			[FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_NotifyWebSystemInited;

			// Token: 0x0401BB66 RID: 113510
			[Token(Token = "0x401BB66")]
			[FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_OpenMiniWebview;

			// Token: 0x0401BB67 RID: 113511
			[Token(Token = "0x401BB67")]
			[FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0__LoadMiniWebviewImpl;

			// Token: 0x0401BB68 RID: 113512
			[Token(Token = "0x401BB68")]
			[FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix0__CreateMiniWebStyle;

			// Token: 0x0401BB69 RID: 113513
			[Token(Token = "0x401BB69")]
			[FieldOffset(Offset = "0x80")]
			private static DelegateBridge __Hotfix0_OnWebViewOpen;

			// Token: 0x0401BB6A RID: 113514
			[Token(Token = "0x401BB6A")]
			[FieldOffset(Offset = "0x88")]
			private static DelegateBridge __Hotfix0_OnIsNewRet;

			// Token: 0x0401BB6B RID: 113515
			[Token(Token = "0x401BB6B")]
			[FieldOffset(Offset = "0x90")]
			private static DelegateBridge __Hotfix0_OnWebViewClose;

			// Token: 0x0401BB6C RID: 113516
			[Token(Token = "0x401BB6C")]
			[FieldOffset(Offset = "0x98")]
			private static DelegateBridge __Hotfix0_OnWebViewUrlClick;

			// Token: 0x0401BB6D RID: 113517
			[Token(Token = "0x401BB6D")]
			[FieldOffset(Offset = "0xA0")]
			private static DelegateBridge __Hotfix0_OnMiniWebFinish;

			// Token: 0x0401BB6E RID: 113518
			[Token(Token = "0x401BB6E")]
			[FieldOffset(Offset = "0xA8")]
			private static DelegateBridge __Hotfix0__ConvertWebOpenRet;

			// Token: 0x0401BB6F RID: 113519
			[Token(Token = "0x401BB6F")]
			[FieldOffset(Offset = "0xB0")]
			private static DelegateBridge __Hotfix0__InvokeWhenInited;

			// Token: 0x0401BB70 RID: 113520
			[Token(Token = "0x401BB70")]
			[FieldOffset(Offset = "0xB8")]
			private static DelegateBridge __Hotfix0__BroadcastIsNewRet;

			// Token: 0x0401BB71 RID: 113521
			[Token(Token = "0x401BB71")]
			[FieldOffset(Offset = "0xC0")]
			private static DelegateBridge __Hotfix0__DescribeOptions;

			// Token: 0x0401BB72 RID: 113522
			[Token(Token = "0x401BB72")]
			[FieldOffset(Offset = "0xC8")]
			private static DelegateBridge __Hotfix0__SafeLength;

			// Token: 0x0401BB73 RID: 113523
			[Token(Token = "0x401BB73")]
			[FieldOffset(Offset = "0xD0")]
			private static DelegateBridge __Hotfix0__Count;

			// Token: 0x0401BB74 RID: 113524
			[Token(Token = "0x401BB74")]
			[FieldOffset(Offset = "0xD8")]
			private static DelegateBridge __Hotfix0__GetDictionaryValue;

			// Token: 0x0401BB75 RID: 113525
			[Token(Token = "0x401BB75")]
			[FieldOffset(Offset = "0xE0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020038B3 RID: 14515
		[Token(Token = "0x20038B3")]
		private class HGWebAdapter : HGUniWebViewMgr.Adapter, IHotfixable
		{
			// Token: 0x06016F58 RID: 94040 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016F58")]
			[Address(RVA = "0xF5A610", Offset = "0xF59210", VA = "0x180F5A610")]
			public HGWebAdapter(UIWebWindow.Core context)
			{
			}

			// Token: 0x06016F59 RID: 94041 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6016F59")]
			[Address(RVA = "0xF59BD0", Offset = "0xF587D0", VA = "0x180F59BD0", Slot = "4")]
			public override string GetSDKEnv()
			{
				return null;
			}

			// Token: 0x06016F5A RID: 94042 RVA: 0x00094230 File Offset: 0x00092430
			[Token(Token = "0x6016F5A")]
			[Address(RVA = "0xF59C30", Offset = "0xF58830", VA = "0x180F59C30", Slot = "6")]
			public override CallbackRet JSONToCallbackRet(string jsonStr)
			{
				return default(CallbackRet);
			}

			// Token: 0x06016F5B RID: 94043 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6016F5B")]
			[Address(RVA = "0xF5A540", Offset = "0xF59140", VA = "0x180F5A540", Slot = "5")]
			public override string UserDataToJSON(UserData userData)
			{
				return null;
			}

			// Token: 0x06016F5C RID: 94044 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6016F5C")]
			[Address(RVA = "0xF5A470", Offset = "0xF59070", VA = "0x180F5A470", Slot = "7")]
			public override string UrlParamsToJson(UrlParams urlParams)
			{
				return null;
			}

			// Token: 0x06016F5D RID: 94045 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6016F5D")]
			[Address(RVA = "0xF59B00", Offset = "0xF58700", VA = "0x180F59B00", Slot = "8")]
			public override string CustomStyleToJson(MiniWebCustomStyle customStyle)
			{
				return null;
			}

			// Token: 0x06016F5E RID: 94046 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016F5E")]
			[Address(RVA = "0xF59D60", Offset = "0xF58960", VA = "0x180F59D60", Slot = "9")]
			public override void OnExtraInfo(CallbackCode code, CallbackMsg msg)
			{
			}

			// Token: 0x06016F5F RID: 94047 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016F5F")]
			[Address(RVA = "0xF5A260", Offset = "0xF58E60", VA = "0x180F5A260", Slot = "10")]
			public override void OnManagerInitFinished()
			{
			}

			// Token: 0x0401BB7A RID: 113530
			[Token(Token = "0x401BB7A")]
			[FieldOffset(Offset = "0x10")]
			private UIWebWindow.Core m_context;

			// Token: 0x0401BB7B RID: 113531
			[Token(Token = "0x401BB7B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401BB7C RID: 113532
			[Token(Token = "0x401BB7C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetSDKEnv;

			// Token: 0x0401BB7D RID: 113533
			[Token(Token = "0x401BB7D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_JSONToCallbackRet;

			// Token: 0x0401BB7E RID: 113534
			[Token(Token = "0x401BB7E")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_UserDataToJSON;

			// Token: 0x0401BB7F RID: 113535
			[Token(Token = "0x401BB7F")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_UrlParamsToJson;

			// Token: 0x0401BB80 RID: 113536
			[Token(Token = "0x401BB80")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_CustomStyleToJson;

			// Token: 0x0401BB81 RID: 113537
			[Token(Token = "0x401BB81")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_OnExtraInfo;

			// Token: 0x0401BB82 RID: 113538
			[Token(Token = "0x401BB82")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_OnManagerInitFinished;
		}
	}
}
