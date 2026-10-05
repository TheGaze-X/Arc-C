using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
	// Token: 0x02000076 RID: 118
	[Token(Token = "0x2000076")]
	[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
	[NativeHeader("Runtime/Graphics/ScreenManager.h")]
	[NativeHeader("Runtime/Graphics/WindowLayout.h")]
	[StaticAccessor("GetScreenManager()", StaticAccessorType.Dot)]
	public sealed class Screen
	{
		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060002D1 RID: 721
		[Token(Token = "0x170000B1")]
		public static extern int width { [Token(Token = "0x60002D1")] [Address(RVA = "0x59402B0", Offset = "0x593EEB0", VA = "0x1859402B0")] [NativeMethod(Name = "GetWidth", IsThreadSafe = true)] [MethodImpl(4096)] get; }

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060002D2 RID: 722
		[Token(Token = "0x170000B2")]
		public static extern int height { [Token(Token = "0x60002D2")] [Address(RVA = "0x5940280", Offset = "0x593EE80", VA = "0x185940280")] [NativeMethod(Name = "GetHeight", IsThreadSafe = true)] [MethodImpl(4096)] get; }

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060002D3 RID: 723
		[Token(Token = "0x170000B3")]
		public static extern float dpi { [Token(Token = "0x60002D3")] [Address(RVA = "0x5940220", Offset = "0x593EE20", VA = "0x185940220")] [NativeName("GetDPI")] [MethodImpl(4096)] get; }

		// Token: 0x060002D4 RID: 724
		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x593FFE0", Offset = "0x593EBE0", VA = "0x18593FFE0")]
		[MethodImpl(4096)]
		private static extern ScreenOrientation GetScreenOrientation();

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060002D5 RID: 725 RVA: 0x00002F88 File Offset: 0x00001188
		[Token(Token = "0x170000B4")]
		public static ScreenOrientation orientation
		{
			[Token(Token = "0x60002D5")]
			[Address(RVA = "0x593FFE0", Offset = "0x593EBE0", VA = "0x18593FFE0")]
			get
			{
				return ScreenOrientation.Unknown;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (set) Token: 0x060002D6 RID: 726
		[Token(Token = "0x170000B5")]
		[NativeProperty("ScreenTimeout")]
		public static extern int sleepTimeout { [Token(Token = "0x60002D6")] [Address(RVA = "0x59402E0", Offset = "0x593EEE0", VA = "0x1859402E0")] [MethodImpl(4096)] set; }

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060002D7 RID: 727 RVA: 0x00002FA0 File Offset: 0x000011A0
		[Token(Token = "0x170000B6")]
		public static Resolution currentResolution
		{
			[Token(Token = "0x60002D7")]
			[Address(RVA = "0x59401E0", Offset = "0x593EDE0", VA = "0x1859401E0")]
			get
			{
				return default(Resolution);
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060002D8 RID: 728
		[Token(Token = "0x170000B7")]
		public static extern bool fullScreen { [Token(Token = "0x60002D8")] [Address(RVA = "0x5940250", Offset = "0x593EE50", VA = "0x185940250")] [NativeName("IsFullscreen")] [MethodImpl(4096)] get; }

		// Token: 0x060002D9 RID: 729
		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x5940010", Offset = "0x593EC10", VA = "0x185940010")]
		[NativeName("RequestResolution")]
		[MethodImpl(4096)]
		public static extern void SetResolution(int width, int height, FullScreenMode fullscreenMode, [DefaultValue("0")] int preferredRefreshRate);

		// Token: 0x060002DA RID: 730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x59400D0", Offset = "0x593ECD0", VA = "0x1859400D0")]
		public static void SetResolution(int width, int height, FullScreenMode fullscreenMode)
		{
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x5940130", Offset = "0x593ED30", VA = "0x185940130")]
		public static void SetResolution(int width, int height, bool fullscreen, [DefaultValue("0")] int preferredRefreshRate)
		{
		}

		// Token: 0x060002DC RID: 732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x5940070", Offset = "0x593EC70", VA = "0x185940070")]
		public static void SetResolution(int width, int height, bool fullscreen)
		{
		}

		// Token: 0x060002DD RID: 733
		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x59401A0", Offset = "0x593EDA0", VA = "0x1859401A0")]
		[MethodImpl(4096)]
		private static extern void get_currentResolution_Injected(out Resolution ret);
	}
}
