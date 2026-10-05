using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace CriWare
{
	// Token: 0x020000FF RID: 255
	[Token(Token = "0x20000FF")]
	public static class CriAtomExDebug
	{
		// Token: 0x060007DF RID: 2015 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x36E0AC0", Offset = "0x36DF6C0", VA = "0x1836E0AC0")]
		public static void GetResourcesInfo(out CriAtomExDebug.ResourcesInfo resourcesInfo)
		{
		}

		// Token: 0x060007E0 RID: 2016
		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x36E0AC0", Offset = "0x36DF6C0", VA = "0x1836E0AC0")]
		[PreserveSig]
		private static extern void criAtomExDebug_GetResourcesInfo(out CriAtomExDebug.ResourcesInfo resourcesInfo);

		// Token: 0x02000100 RID: 256
		[Token(Token = "0x2000100")]
		public struct ResourcesInfo
		{
			// Token: 0x0400049B RID: 1179
			[Token(Token = "0x400049B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public CriAtomEx.ResourceUsage virtualVoiceUsage;

			// Token: 0x0400049C RID: 1180
			[Token(Token = "0x400049C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public CriAtomEx.ResourceUsage sequenceUsage;

			// Token: 0x0400049D RID: 1181
			[Token(Token = "0x400049D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CriAtomEx.ResourceUsage sequenceTrackUsage;

			// Token: 0x0400049E RID: 1182
			[Token(Token = "0x400049E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public CriAtomEx.ResourceUsage sequenceTrackItemUsage;

			// Token: 0x0400049F RID: 1183
			[Token(Token = "0x400049F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CriAtomEx.ResourceUsage parameterBlock;

			// Token: 0x040004A0 RID: 1184
			[Token(Token = "0x40004A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CriAtomEx.ResourceUsage beatSyncInfo;

			// Token: 0x040004A1 RID: 1185
			[Token(Token = "0x40004A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public CriAtomEx.ResourceUsage beatSyncTransitionSetting;

			// Token: 0x040004A2 RID: 1186
			[Token(Token = "0x40004A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public CriAtomEx.ResourceUsage beatSyncJob;
		}
	}
}
