using System;
using Il2CppDummyDll;

namespace UnityEngine
{
	// Token: 0x02000044 RID: 68
	[Token(Token = "0x2000044")]
	public enum RuntimePlatform
	{
		// Token: 0x04000089 RID: 137
		[Token(Token = "0x4000089")]
		OSXEditor,
		// Token: 0x0400008A RID: 138
		[Token(Token = "0x400008A")]
		OSXPlayer,
		// Token: 0x0400008B RID: 139
		[Token(Token = "0x400008B")]
		WindowsPlayer,
		// Token: 0x0400008C RID: 140
		[Token(Token = "0x400008C")]
		[Obsolete("WebPlayer export is no longer supported in Unity 5.4+.", true)]
		OSXWebPlayer,
		// Token: 0x0400008D RID: 141
		[Token(Token = "0x400008D")]
		[Obsolete("Dashboard widget on Mac OS X export is no longer supported in Unity 5.4+.", true)]
		OSXDashboardPlayer,
		// Token: 0x0400008E RID: 142
		[Token(Token = "0x400008E")]
		[Obsolete("WebPlayer export is no longer supported in Unity 5.4+.", true)]
		WindowsWebPlayer,
		// Token: 0x0400008F RID: 143
		[Token(Token = "0x400008F")]
		WindowsEditor = 7,
		// Token: 0x04000090 RID: 144
		[Token(Token = "0x4000090")]
		IPhonePlayer,
		// Token: 0x04000091 RID: 145
		[Token(Token = "0x4000091")]
		[Obsolete("Xbox360 export is no longer supported in Unity 5.5+.")]
		XBOX360 = 10,
		// Token: 0x04000092 RID: 146
		[Token(Token = "0x4000092")]
		[Obsolete("PS3 export is no longer supported in Unity >=5.5.")]
		PS3 = 9,
		// Token: 0x04000093 RID: 147
		[Token(Token = "0x4000093")]
		Android = 11,
		// Token: 0x04000094 RID: 148
		[Token(Token = "0x4000094")]
		[Obsolete("NaCl export is no longer supported in Unity 5.0+.")]
		NaCl,
		// Token: 0x04000095 RID: 149
		[Token(Token = "0x4000095")]
		[Obsolete("FlashPlayer export is no longer supported in Unity 5.0+.")]
		FlashPlayer = 15,
		// Token: 0x04000096 RID: 150
		[Token(Token = "0x4000096")]
		LinuxPlayer = 13,
		// Token: 0x04000097 RID: 151
		[Token(Token = "0x4000097")]
		LinuxEditor = 16,
		// Token: 0x04000098 RID: 152
		[Token(Token = "0x4000098")]
		WebGLPlayer,
		// Token: 0x04000099 RID: 153
		[Token(Token = "0x4000099")]
		[Obsolete("Use WSAPlayerX86 instead")]
		MetroPlayerX86,
		// Token: 0x0400009A RID: 154
		[Token(Token = "0x400009A")]
		WSAPlayerX86 = 18,
		// Token: 0x0400009B RID: 155
		[Token(Token = "0x400009B")]
		[Obsolete("Use WSAPlayerX64 instead")]
		MetroPlayerX64,
		// Token: 0x0400009C RID: 156
		[Token(Token = "0x400009C")]
		WSAPlayerX64 = 19,
		// Token: 0x0400009D RID: 157
		[Token(Token = "0x400009D")]
		[Obsolete("Use WSAPlayerARM instead")]
		MetroPlayerARM,
		// Token: 0x0400009E RID: 158
		[Token(Token = "0x400009E")]
		WSAPlayerARM = 20,
		// Token: 0x0400009F RID: 159
		[Token(Token = "0x400009F")]
		[Obsolete("Windows Phone 8 was removed in 5.3")]
		WP8Player,
		// Token: 0x040000A0 RID: 160
		[Token(Token = "0x40000A0")]
		[Obsolete("BlackBerryPlayer export is no longer supported in Unity 5.4+.")]
		BlackBerryPlayer,
		// Token: 0x040000A1 RID: 161
		[Token(Token = "0x40000A1")]
		[Obsolete("TizenPlayer export is no longer supported in Unity 2017.3+.")]
		TizenPlayer,
		// Token: 0x040000A2 RID: 162
		[Token(Token = "0x40000A2")]
		[Obsolete("PSP2 is no longer supported as of Unity 2018.3")]
		PSP2,
		// Token: 0x040000A3 RID: 163
		[Token(Token = "0x40000A3")]
		PS4,
		// Token: 0x040000A4 RID: 164
		[Token(Token = "0x40000A4")]
		[Obsolete("PSM export is no longer supported in Unity >= 5.3")]
		PSM,
		// Token: 0x040000A5 RID: 165
		[Token(Token = "0x40000A5")]
		XboxOne,
		// Token: 0x040000A6 RID: 166
		[Token(Token = "0x40000A6")]
		[Obsolete("SamsungTVPlayer export is no longer supported in Unity 2017.3+.")]
		SamsungTVPlayer,
		// Token: 0x040000A7 RID: 167
		[Token(Token = "0x40000A7")]
		[Obsolete("Wii U is no longer supported in Unity 2018.1+.")]
		WiiU = 30,
		// Token: 0x040000A8 RID: 168
		[Token(Token = "0x40000A8")]
		tvOS,
		// Token: 0x040000A9 RID: 169
		[Token(Token = "0x40000A9")]
		Switch,
		// Token: 0x040000AA RID: 170
		[Token(Token = "0x40000AA")]
		Lumin,
		// Token: 0x040000AB RID: 171
		[Token(Token = "0x40000AB")]
		Stadia,
		// Token: 0x040000AC RID: 172
		[Token(Token = "0x40000AC")]
		CloudRendering,
		// Token: 0x040000AD RID: 173
		[Token(Token = "0x40000AD")]
		[Obsolete("GameCoreScarlett is deprecated, please use GameCoreXboxSeries (UnityUpgradable) -> GameCoreXboxSeries", false)]
		GameCoreScarlett = -1,
		// Token: 0x040000AE RID: 174
		[Token(Token = "0x40000AE")]
		GameCoreXboxSeries = 36,
		// Token: 0x040000AF RID: 175
		[Token(Token = "0x40000AF")]
		GameCoreXboxOne,
		// Token: 0x040000B0 RID: 176
		[Token(Token = "0x40000B0")]
		PS5,
		// Token: 0x040000B1 RID: 177
		[Token(Token = "0x40000B1")]
		EmbeddedLinuxArm64,
		// Token: 0x040000B2 RID: 178
		[Token(Token = "0x40000B2")]
		EmbeddedLinuxArm32,
		// Token: 0x040000B3 RID: 179
		[Token(Token = "0x40000B3")]
		EmbeddedLinuxX64,
		// Token: 0x040000B4 RID: 180
		[Token(Token = "0x40000B4")]
		EmbeddedLinuxX86,
		// Token: 0x040000B5 RID: 181
		[Token(Token = "0x40000B5")]
		LinuxServer,
		// Token: 0x040000B6 RID: 182
		[Token(Token = "0x40000B6")]
		WindowsServer,
		// Token: 0x040000B7 RID: 183
		[Token(Token = "0x40000B7")]
		OSXServer,
		// Token: 0x040000B8 RID: 184
		[Token(Token = "0x40000B8")]
		OpenHarmony
	}
}
