using System;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	// Token: 0x02000253 RID: 595
	[Token(Token = "0x2000253")]
	[UsedByNativeCode]
	public enum GraphicsDeviceType
	{
		// Token: 0x040006C6 RID: 1734
		[Token(Token = "0x40006C6")]
		[Obsolete("OpenGL2 is no longer supported in Unity 5.5+")]
		OpenGL2,
		// Token: 0x040006C7 RID: 1735
		[Token(Token = "0x40006C7")]
		[Obsolete("Direct3D 9 is no longer supported in Unity 2017.2+")]
		Direct3D9,
		// Token: 0x040006C8 RID: 1736
		[Token(Token = "0x40006C8")]
		Direct3D11,
		// Token: 0x040006C9 RID: 1737
		[Token(Token = "0x40006C9")]
		[Obsolete("PS3 is no longer supported in Unity 5.5+")]
		PlayStation3,
		// Token: 0x040006CA RID: 1738
		[Token(Token = "0x40006CA")]
		Null,
		// Token: 0x040006CB RID: 1739
		[Token(Token = "0x40006CB")]
		[Obsolete("Xbox360 is no longer supported in Unity 5.5+")]
		Xbox360 = 6,
		// Token: 0x040006CC RID: 1740
		[Token(Token = "0x40006CC")]
		OpenGLES2 = 8,
		// Token: 0x040006CD RID: 1741
		[Token(Token = "0x40006CD")]
		OpenGLES3 = 11,
		// Token: 0x040006CE RID: 1742
		[Token(Token = "0x40006CE")]
		[Obsolete("PVita is no longer supported as of Unity 2018")]
		PlayStationVita,
		// Token: 0x040006CF RID: 1743
		[Token(Token = "0x40006CF")]
		PlayStation4,
		// Token: 0x040006D0 RID: 1744
		[Token(Token = "0x40006D0")]
		XboxOne,
		// Token: 0x040006D1 RID: 1745
		[Token(Token = "0x40006D1")]
		[Obsolete("PlayStationMobile is no longer supported in Unity 5.3+")]
		PlayStationMobile,
		// Token: 0x040006D2 RID: 1746
		[Token(Token = "0x40006D2")]
		Metal,
		// Token: 0x040006D3 RID: 1747
		[Token(Token = "0x40006D3")]
		OpenGLCore,
		// Token: 0x040006D4 RID: 1748
		[Token(Token = "0x40006D4")]
		Direct3D12,
		// Token: 0x040006D5 RID: 1749
		[Token(Token = "0x40006D5")]
		[Obsolete("Nintendo 3DS support is unavailable since 2018.1")]
		N3DS,
		// Token: 0x040006D6 RID: 1750
		[Token(Token = "0x40006D6")]
		Vulkan = 21,
		// Token: 0x040006D7 RID: 1751
		[Token(Token = "0x40006D7")]
		Switch,
		// Token: 0x040006D8 RID: 1752
		[Token(Token = "0x40006D8")]
		XboxOneD3D12,
		// Token: 0x040006D9 RID: 1753
		[Token(Token = "0x40006D9")]
		GameCoreXboxOne,
		// Token: 0x040006DA RID: 1754
		[Token(Token = "0x40006DA")]
		[Obsolete("GameCoreScarlett is deprecated, please use GameCoreXboxSeries (UnityUpgradable) -> GameCoreXboxSeries", false)]
		GameCoreScarlett = -1,
		// Token: 0x040006DB RID: 1755
		[Token(Token = "0x40006DB")]
		GameCoreXboxSeries = 25,
		// Token: 0x040006DC RID: 1756
		[Token(Token = "0x40006DC")]
		PlayStation5,
		// Token: 0x040006DD RID: 1757
		[Token(Token = "0x40006DD")]
		PlayStation5NGGC
	}
}
