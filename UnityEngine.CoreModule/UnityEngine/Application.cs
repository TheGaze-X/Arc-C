using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200004D RID: 77
	[Token(Token = "0x200004D")]
	[NativeHeader("Runtime/Input/GetInput.h")]
	[NativeHeader("Runtime/Application/AdsIdHandler.h")]
	[NativeHeader("Runtime/PreloadManager/LoadSceneOperation.h")]
	[NativeHeader("Runtime/Network/NetworkUtility.h")]
	[NativeHeader("Runtime/Input/InputManager.h")]
	[NativeHeader("Runtime/Input/TargetFrameRate.h")]
	[NativeHeader("Runtime/Logging/LogSystem.h")]
	[NativeHeader("Runtime/Misc/BuildSettings.h")]
	[NativeHeader("Runtime/Utilities/URLUtility.h")]
	[NativeHeader("Runtime/Application/ApplicationInfo.h")]
	[NativeHeader("Runtime/BaseClasses/IsPlaying.h")]
	[NativeHeader("Runtime/Utilities/Argv.h")]
	[NativeHeader("Runtime/Export/Application/Application.bindings.h")]
	[NativeHeader("Runtime/PreloadManager/PreloadManager.h")]
	[NativeHeader("Runtime/Misc/PlayerSettings.h")]
	[NativeHeader("Runtime/File/ApplicationSpecificPersistentDataPath.h")]
	[NativeHeader("Runtime/Misc/SystemInfo.h")]
	[NativeHeader("Runtime/Misc/Player.h")]
	public class Application
	{
		// Token: 0x060000B8 RID: 184
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x591E940", Offset = "0x591D540", VA = "0x18591E940")]
		[FreeFunction("GetInputManager().QuitApplication")]
		[MethodImpl(4096)]
		public static extern void Quit(int exitCode);

		// Token: 0x060000B9 RID: 185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x591E980", Offset = "0x591D580", VA = "0x18591E980")]
		public static void Quit()
		{
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000BA RID: 186
		[Token(Token = "0x1700001B")]
		public static extern bool isPlaying { [Token(Token = "0x60000BA")] [Address(RVA = "0x591F450", Offset = "0x591E050", VA = "0x18591F450")] [FreeFunction("IsWorldPlaying")] [MethodImpl(4096)] get; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000BB RID: 187
		[Token(Token = "0x1700001C")]
		public static extern bool isFocused { [Token(Token = "0x60000BB")] [Address(RVA = "0x591F3B0", Offset = "0x591DFB0", VA = "0x18591F3B0")] [FreeFunction("IsPlayerFocused")] [MethodImpl(4096)] get; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000BC RID: 188
		[Token(Token = "0x1700001D")]
		public static extern bool runInBackground { [Token(Token = "0x60000BC")] [Address(RVA = "0x591F510", Offset = "0x591E110", VA = "0x18591F510")] [FreeFunction("GetPlayerSettingsRunInBackground")] [MethodImpl(4096)] get; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000BD RID: 189
		[Token(Token = "0x1700001E")]
		public static extern bool isBatchMode { [Token(Token = "0x60000BD")] [Address(RVA = "0x591F370", Offset = "0x591DF70", VA = "0x18591F370")] [FreeFunction("::IsBatchmode")] [MethodImpl(4096)] get; }

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000BE RID: 190
		[Token(Token = "0x1700001F")]
		public static extern string dataPath { [Token(Token = "0x60000BE")] [Address(RVA = "0x591F2E0", Offset = "0x591DEE0", VA = "0x18591F2E0")] [FreeFunction("GetAppDataPath")] [MethodImpl(4096)] get; }

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000BF RID: 191
		[Token(Token = "0x17000020")]
		public static extern string streamingAssetsPath { [Token(Token = "0x60000BF")] [Address(RVA = "0x591F540", Offset = "0x591E140", VA = "0x18591F540")] [FreeFunction("GetStreamingAssetsPath", IsThreadSafe = true)] [MethodImpl(4096)] get; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000C0 RID: 192
		[Token(Token = "0x17000021")]
		public static extern string persistentDataPath { [Token(Token = "0x60000C0")] [Address(RVA = "0x591F480", Offset = "0x591E080", VA = "0x18591F480")] [FreeFunction("GetPersistentDataPathApplicationSpecific")] [MethodImpl(4096)] get; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000C1 RID: 193
		[Token(Token = "0x17000022")]
		public static extern string temporaryCachePath { [Token(Token = "0x60000C1")] [Address(RVA = "0x591F5A0", Offset = "0x591E1A0", VA = "0x18591F5A0")] [FreeFunction("GetTemporaryCachePathApplicationSpecific")] [MethodImpl(4096)] get; }

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000C2 RID: 194
		[Token(Token = "0x17000023")]
		public static extern string unityVersion { [Token(Token = "0x60000C2")] [Address(RVA = "0x591F5D0", Offset = "0x591E1D0", VA = "0x18591F5D0")] [FreeFunction("Application_Bindings::GetUnityVersion", IsThreadSafe = true)] [MethodImpl(4096)] get; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000C3 RID: 195
		[Token(Token = "0x17000024")]
		public static extern string version { [Token(Token = "0x60000C3")] [Address(RVA = "0x591F600", Offset = "0x591E200", VA = "0x18591F600")] [FreeFunction("GetApplicationInfo().GetVersion")] [MethodImpl(4096)] get; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000C4 RID: 196
		[Token(Token = "0x17000025")]
		public static extern string identifier { [Token(Token = "0x60000C4")] [Address(RVA = "0x591F310", Offset = "0x591DF10", VA = "0x18591F310")] [FreeFunction("GetApplicationInfo().GetApplicationIdentifier")] [MethodImpl(4096)] get; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000C5 RID: 197
		[Token(Token = "0x17000026")]
		public static extern string productName { [Token(Token = "0x60000C5")] [Address(RVA = "0x591F4E0", Offset = "0x591E0E0", VA = "0x18591F4E0")] [FreeFunction("GetPlayerSettings().GetProductName")] [MethodImpl(4096)] get; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000C6 RID: 198
		[Token(Token = "0x17000027")]
		public static extern string companyName { [Token(Token = "0x60000C6")] [Address(RVA = "0x591F2B0", Offset = "0x591DEB0", VA = "0x18591F2B0")] [FreeFunction("GetPlayerSettings().GetCompanyName")] [MethodImpl(4096)] get; }

		// Token: 0x060000C7 RID: 199
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x591E900", Offset = "0x591D500", VA = "0x18591E900")]
		[FreeFunction("OpenURL")]
		[MethodImpl(4096)]
		public static extern void OpenURL(string url);

		// Token: 0x17000028 RID: 40
		// (set) Token: 0x060000C8 RID: 200
		[Token(Token = "0x17000028")]
		public static extern int targetFrameRate { [Token(Token = "0x60000C8")] [Address(RVA = "0x591FA50", Offset = "0x591E650", VA = "0x18591FA50")] [FreeFunction("SetTargetFrameRate")] [MethodImpl(4096)] set; }

		// Token: 0x060000C9 RID: 201
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x591EE10", Offset = "0x591DA10", VA = "0x18591EE10")]
		[FreeFunction("Application_Bindings::SetLogCallbackDefined")]
		[MethodImpl(4096)]
		private static extern void SetLogCallbackDefined(bool defined);

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000CA RID: 202
		[Token(Token = "0x17000029")]
		public static extern RuntimePlatform platform { [Token(Token = "0x60000CA")] [Address(RVA = "0x591F4B0", Offset = "0x591E0B0", VA = "0x18591F4B0")] [FreeFunction("systeminfo::GetRuntimePlatform", IsThreadSafe = true)] [MethodImpl(4096)] get; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000CB RID: 203 RVA: 0x000024C0 File Offset: 0x000006C0
		[Token(Token = "0x1700002A")]
		public static bool isMobilePlatform
		{
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x591F3E0", Offset = "0x591DFE0", VA = "0x18591F3E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000CC RID: 204
		[Token(Token = "0x1700002B")]
		public static extern SystemLanguage systemLanguage { [Token(Token = "0x60000CC")] [Address(RVA = "0x591F570", Offset = "0x591E170", VA = "0x18591F570")] [FreeFunction("(SystemLanguage)systeminfo::GetSystemLanguage")] [MethodImpl(4096)] get; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000CD RID: 205
		[Token(Token = "0x1700002C")]
		public static extern NetworkReachability internetReachability { [Token(Token = "0x60000CD")] [Address(RVA = "0x591F340", Offset = "0x591DF40", VA = "0x18591F340")] [FreeFunction("GetInternetReachability")] [MethodImpl(4096)] get; }

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x060000CE RID: 206 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060000CF RID: 207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000001")]
		public static event Application.LowMemoryCallback lowMemory
		{
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x591F130", Offset = "0x591DD30", VA = "0x18591F130")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x591F8D0", Offset = "0x591E4D0", VA = "0x18591F8D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x591E540", Offset = "0x591D140", VA = "0x18591E540")]
		[RequiredByNativeCode]
		internal static void CallLowMemory()
		{
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060000D1 RID: 209 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060000D2 RID: 210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000002")]
		public static event Application.LogCallback logMessageReceived
		{
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x591F030", Offset = "0x591DC30", VA = "0x18591F030")]
			add
			{
			}
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x591F7F0", Offset = "0x591E3F0", VA = "0x18591F7F0")]
			remove
			{
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x060000D3 RID: 211 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060000D4 RID: 212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000003")]
		public static event Application.LogCallback logMessageReceivedThreaded
		{
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x591EF30", Offset = "0x591DB30", VA = "0x18591EF30")]
			add
			{
			}
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x591F710", Offset = "0x591E310", VA = "0x18591F710")]
			remove
			{
			}
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x591E480", Offset = "0x591D080", VA = "0x18591E480")]
		[RequiredByNativeCode]
		private static void CallLogCallback(string logString, string stackTrace, LogType type, bool invokedOnMainThread)
		{
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x591E590", Offset = "0x591D190", VA = "0x18591E590")]
		[Obsolete("Application.CaptureScreenshot is obsolete. Use ScreenCapture.CaptureScreenshot instead (UnityUpgradable) -> [UnityEngine] UnityEngine.ScreenCapture.CaptureScreenshot(*)", true)]
		public static void CaptureScreenshot(string filename)
		{
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x060000D7 RID: 215 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060000D8 RID: 216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000004")]
		public static event Action<bool> focusChanged
		{
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x591EE50", Offset = "0x591DA50", VA = "0x18591EE50")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0x591F630", Offset = "0x591E230", VA = "0x18591F630")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x060000D9 RID: 217 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060000DA RID: 218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000005")]
		public static event Action quitting
		{
			[Token(Token = "0x60000D9")]
			[Address(RVA = "0x591F1F0", Offset = "0x591DDF0", VA = "0x18591F1F0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0x591F990", Offset = "0x591E590", VA = "0x18591F990")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060000DB RID: 219 RVA: 0x000024D8 File Offset: 0x000006D8
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x591E690", Offset = "0x591D290", VA = "0x18591E690")]
		[RequiredByNativeCode]
		private static bool Internal_ApplicationWantsToQuit()
		{
			return default(bool);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x591E5F0", Offset = "0x591D1F0", VA = "0x18591E5F0")]
		[RequiredByNativeCode]
		private static void Internal_ApplicationQuit()
		{
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x591E640", Offset = "0x591D240", VA = "0x18591E640")]
		[RequiredByNativeCode]
		private static void Internal_ApplicationUnload()
		{
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x591E8C0", Offset = "0x591D4C0", VA = "0x18591E8C0")]
		[RequiredByNativeCode]
		internal static void InvokeOnBeforeRender()
		{
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x591E860", Offset = "0x591D460", VA = "0x18591E860")]
		[RequiredByNativeCode]
		internal static void InvokeFocusChanged(bool focus)
		{
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x591E800", Offset = "0x591D400", VA = "0x18591E800")]
		[RequiredByNativeCode]
		internal static void InvokeDeepLinkActivated(string url)
		{
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x591EE00", Offset = "0x591DA00", VA = "0x18591EE00")]
		[Obsolete("Application.RegisterLogCallback is deprecated. Use Application.logMessageReceived instead.")]
		public static void RegisterLogCallback(Application.LogCallback handler)
		{
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x591E9B0", Offset = "0x591D5B0", VA = "0x18591E9B0")]
		private static void RegisterLogCallback(Application.LogCallback handler, bool threaded)
		{
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x000024F0 File Offset: 0x000006F0
		[Token(Token = "0x1700002D")]
		public static bool isEditor
		{
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0x591F3A0", Offset = "0x591DFA0", VA = "0x18591F3A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x04000104 RID: 260
		[Token(Token = "0x4000104")]
		[FieldOffset(Offset = "0x8")]
		private static Application.LogCallback s_LogCallbackHandler;

		// Token: 0x04000105 RID: 261
		[Token(Token = "0x4000105")]
		[FieldOffset(Offset = "0x10")]
		private static Application.LogCallback s_LogCallbackHandlerThreaded;

		// Token: 0x04000107 RID: 263
		[Token(Token = "0x4000107")]
		[FieldOffset(Offset = "0x20")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<string> deepLinkActivated;

		// Token: 0x04000108 RID: 264
		[Token(Token = "0x4000108")]
		[FieldOffset(Offset = "0x28")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Func<bool> wantsToQuit;

		// Token: 0x0400010A RID: 266
		[Token(Token = "0x400010A")]
		[FieldOffset(Offset = "0x38")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action unloading;

		// Token: 0x0400010B RID: 267
		[Token(Token = "0x400010B")]
		[FieldOffset(Offset = "0x40")]
		private static Application.LogCallback s_RegisterLogCallbackDeprecated;

		// Token: 0x0200004E RID: 78
		// (Invoke) Token: 0x060000E5 RID: 229
		[Token(Token = "0x200004E")]
		public delegate void LowMemoryCallback();

		// Token: 0x0200004F RID: 79
		// (Invoke) Token: 0x060000E7 RID: 231
		[Token(Token = "0x200004F")]
		public delegate void LogCallback(string condition, string stackTrace, LogType type);
	}
}
