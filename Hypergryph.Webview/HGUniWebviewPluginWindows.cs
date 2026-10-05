using System;
using System.Runtime.InteropServices;
using System.Threading;
using AOT;
using Il2CppDummyDll;

namespace Hypergryph.SDK
{
	// Token: 0x0200000F RID: 15
	[Token(Token = "0x200000F")]
	public class HGUniWebviewPluginWindows : IUniWebview
	{
		// Token: 0x06000040 RID: 64
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x4A2F970", Offset = "0x4A2E570", VA = "0x184A2F970")]
		[PreserveSig]
		private static extern void WebPortalSDK_Open(string target, string urlParams, HGUniWebviewPluginWindows.OpenCallback callback, HGUniWebviewPluginWindows.EventListener eventListener);

		// Token: 0x06000041 RID: 65
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x4A2F900", Offset = "0x4A2E500", VA = "0x184A2F900")]
		[PreserveSig]
		private static extern void WebPortalSDK_Close();

		// Token: 0x06000042 RID: 66
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x4A2FA50", Offset = "0x4A2E650", VA = "0x184A2FA50")]
		[PreserveSig]
		private static extern void WebPortalSDK_RegisterSchemeJumpListener(HGUniWebviewPluginWindows.SchemeJumpCallback callback);

		// Token: 0x06000043 RID: 67
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x4A2FAE0", Offset = "0x4A2E6E0", VA = "0x184A2FAE0")]
		[PreserveSig]
		private static extern void WebPortalSDK_ShowWebToast(int level, string msg);

		// Token: 0x06000044 RID: 68
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x4A2F3A0", Offset = "0x4A2DFA0", VA = "0x184A2F3A0")]
		[PreserveSig]
		private static extern void MiniWebViewSDKLoad(string url, string styleConfig, HGUniWebviewPluginWindows.ExtraInfoCallback callback);

		// Token: 0x06000045 RID: 69 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x4A2F470", Offset = "0x4A2E070", VA = "0x184A2F470")]
		[MonoPInvokeCallback(typeof(HGUniWebviewPluginWindows.OpenCallback))]
		public static void OpenCallBack(string jsonData)
		{
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x4A2EF30", Offset = "0x4A2DB30", VA = "0x184A2EF30")]
		[MonoPInvokeCallback(typeof(HGUniWebviewPluginWindows.EventListener))]
		public static void EventListenerCallback(string jsonData)
		{
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x4A2F630", Offset = "0x4A2E230", VA = "0x184A2F630")]
		[MonoPInvokeCallback(typeof(HGUniWebviewPluginWindows.SchemeJumpCallback))]
		public static void SchemeJumpCallBack(string jsonData)
		{
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x4A2F0E0", Offset = "0x4A2DCE0", VA = "0x184A2F0E0")]
		[MonoPInvokeCallback(typeof(HGUniWebviewPluginWindows.ExtraInfoCallback))]
		public static void ExtraInfoCallBack(string jsonData)
		{
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x4A2F7F0", Offset = "0x4A2E3F0", VA = "0x184A2F7F0")]
		public static void SendMessage(string jsonData)
		{
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x4A2FB80", Offset = "0x4A2E780", VA = "0x184A2FB80")]
		public HGUniWebviewPluginWindows()
		{
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x4A2F290", Offset = "0x4A2DE90", VA = "0x184A2F290", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "4")]
		public void init(string env)
		{
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
		public void startWebSupport()
		{
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
		public void stopWebSupport()
		{
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "7")]
		public void isNew(string type)
		{
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "8")]
		public void isNew(string type, string urlParams)
		{
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "9")]
		public void isNewByCache(string type)
		{
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x4A30320", Offset = "0x4A2EF20", VA = "0x184A30320", Slot = "10")]
		public void loadWebview(string type, string userData)
		{
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x4A30450", Offset = "0x4A2F050", VA = "0x184A30450", Slot = "11")]
		public void loadWebview(string type, string userData, string urlParams)
		{
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x4A2FEC0", Offset = "0x4A2EAC0", VA = "0x184A2FEC0", Slot = "12")]
		public void closeWebview()
		{
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x4A30840", Offset = "0x4A2F440", VA = "0x184A30840", Slot = "13")]
		public void toastInsideWebview(int level, string message)
		{
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "14")]
		public void preloadWebview(string type)
		{
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000020B8 File Offset: 0x000002B8
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "15")]
		public bool checkPreloadStatus()
		{
			return default(bool);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x4A2FF80", Offset = "0x4A2EB80", VA = "0x184A2FF80", Slot = "16")]
		public void loadMiniWebview(string url, string userData, string customStyle)
		{
		}

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static SynchronizationContext mainThreadContext;

		// Token: 0x02000010 RID: 16
		// (Invoke) Token: 0x0600005A RID: 90
		[Token(Token = "0x2000010")]
		public delegate void OpenCallback(string jsonData);

		// Token: 0x02000011 RID: 17
		// (Invoke) Token: 0x0600005E RID: 94
		[Token(Token = "0x2000011")]
		public delegate void EventListener(string jsonData);

		// Token: 0x02000012 RID: 18
		// (Invoke) Token: 0x06000062 RID: 98
		[Token(Token = "0x2000012")]
		public delegate void SchemeJumpCallback(string jsonData);

		// Token: 0x02000013 RID: 19
		// (Invoke) Token: 0x06000066 RID: 102
		[Token(Token = "0x2000013")]
		public delegate void ExtraInfoCallback(string jsonData);

		// Token: 0x02000014 RID: 20
		[Token(Token = "0x2000014")]
		public struct OpenCallbackRet
		{
			// Token: 0x04000029 RID: 41
			[Token(Token = "0x4000029")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int code;

			// Token: 0x0400002A RID: 42
			[Token(Token = "0x400002A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int errorCode;
		}

		// Token: 0x02000015 RID: 21
		[Token(Token = "0x2000015")]
		public struct EventListenerRet
		{
			// Token: 0x0400002B RID: 43
			[Token(Token = "0x400002B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int eventCode;
		}

		// Token: 0x02000016 RID: 22
		[Token(Token = "0x2000016")]
		public struct SchemeJumpCallbackRet
		{
			// Token: 0x0400002C RID: 44
			[Token(Token = "0x400002C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string url;
		}

		// Token: 0x02000017 RID: 23
		[Token(Token = "0x2000017")]
		public struct InnerCallBackRet
		{
			// Token: 0x0400002D RID: 45
			[Token(Token = "0x400002D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int code;

			// Token: 0x0400002E RID: 46
			[Token(Token = "0x400002E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string msg;
		}
	}
}
