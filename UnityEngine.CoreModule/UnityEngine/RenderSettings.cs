using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000089 RID: 137
	[Token(Token = "0x2000089")]
	[StaticAccessor("GetRenderSettings()", StaticAccessorType.Dot)]
	[NativeHeader("Runtime/Camera/RenderSettings.h")]
	[NativeHeader("Runtime/Graphics/QualitySettingsTypes.h")]
	public sealed class RenderSettings : Object
	{
		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000401 RID: 1025
		[Token(Token = "0x170000FB")]
		[NativeProperty("UseFog")]
		public static extern bool fog { [Token(Token = "0x6000401")] [Address(RVA = "0x593A5E0", Offset = "0x59391E0", VA = "0x18593A5E0")] [MethodImpl(4096)] get; }

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000402 RID: 1026
		[Token(Token = "0x170000FC")]
		[NativeProperty("LinearFogStart")]
		public static extern float fogStartDistance { [Token(Token = "0x6000402")] [Address(RVA = "0x593A5B0", Offset = "0x59391B0", VA = "0x18593A5B0")] [MethodImpl(4096)] get; }

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000403 RID: 1027
		[Token(Token = "0x170000FD")]
		[NativeProperty("LinearFogEnd")]
		public static extern float fogEndDistance { [Token(Token = "0x6000403")] [Address(RVA = "0x593A550", Offset = "0x5939150", VA = "0x18593A550")] [MethodImpl(4096)] get; }

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000404 RID: 1028
		[Token(Token = "0x170000FE")]
		public static extern FogMode fogMode { [Token(Token = "0x6000404")] [Address(RVA = "0x593A580", Offset = "0x5939180", VA = "0x18593A580")] [MethodImpl(4096)] get; }

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000405 RID: 1029 RVA: 0x000031B0 File Offset: 0x000013B0
		[Token(Token = "0x170000FF")]
		public static Color fogColor
		{
			[Token(Token = "0x6000405")]
			[Address(RVA = "0x593A4E0", Offset = "0x59390E0", VA = "0x18593A4E0")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000406 RID: 1030
		[Token(Token = "0x17000100")]
		public static extern float fogDensity { [Token(Token = "0x6000406")] [Address(RVA = "0x593A520", Offset = "0x5939120", VA = "0x18593A520")] [MethodImpl(4096)] get; }

		// Token: 0x06000407 RID: 1031
		[Token(Token = "0x6000407")]
		[Address(RVA = "0x593A4A0", Offset = "0x59390A0", VA = "0x18593A4A0")]
		[MethodImpl(4096)]
		private static extern void get_fogColor_Injected(out Color ret);
	}
}
