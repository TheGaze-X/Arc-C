using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace CriWare
{
	// Token: 0x02000112 RID: 274
	[Token(Token = "0x2000112")]
	public static class CriAtomExPlaybackDebug
	{
		// Token: 0x0600080C RID: 2060 RVA: 0x000042D4 File Offset: 0x000024D4
		[Token(Token = "0x600080C")]
		[Address(RVA = "0x36E3070", Offset = "0x36E1C70", VA = "0x1836E3070")]
		public static bool GetParameter(CriAtomExPlayback playback, CriAtomEx.Parameter parameterId, out float value)
		{
			return default(bool);
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x000042EC File Offset: 0x000024EC
		[Token(Token = "0x600080D")]
		[Address(RVA = "0x36E3110", Offset = "0x36E1D10", VA = "0x1836E3110")]
		public static bool GetParameter(CriAtomExPlayback playback, CriAtomEx.Parameter parameterId, out uint value)
		{
			return default(bool);
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x00004304 File Offset: 0x00002504
		[Token(Token = "0x600080E")]
		[Address(RVA = "0x36E2FD0", Offset = "0x36E1BD0", VA = "0x1836E2FD0")]
		public static bool GetParameter(CriAtomExPlayback playback, CriAtomEx.Parameter parameterId, out int value)
		{
			return default(bool);
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x0000431C File Offset: 0x0000251C
		[Token(Token = "0x600080F")]
		[Address(RVA = "0x36E2E80", Offset = "0x36E1A80", VA = "0x1836E2E80")]
		public static bool GetAisacControl(CriAtomExPlayback playback, uint controlId, out float value)
		{
			return default(bool);
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x00004334 File Offset: 0x00002534
		[Token(Token = "0x6000810")]
		[Address(RVA = "0x36E2F20", Offset = "0x36E1B20", VA = "0x1836E2F20")]
		public static bool GetAisacControl(CriAtomExPlayback playback, string controlName, out float value)
		{
			return default(bool);
		}

		// Token: 0x06000811 RID: 2065
		[Token(Token = "0x6000811")]
		[Address(RVA = "0x36E32F0", Offset = "0x36E1EF0", VA = "0x1836E32F0")]
		[PreserveSig]
		private static extern int criAtomExPlayback_GetParameterFloat32(uint id, int parameterId, out float value);

		// Token: 0x06000812 RID: 2066
		[Token(Token = "0x6000812")]
		[Address(RVA = "0x36E3410", Offset = "0x36E2010", VA = "0x1836E3410")]
		[PreserveSig]
		private static extern int criAtomExPlayback_GetParameterUint32(uint id, int parameterId, out uint value);

		// Token: 0x06000813 RID: 2067
		[Token(Token = "0x6000813")]
		[Address(RVA = "0x36E3380", Offset = "0x36E1F80", VA = "0x1836E3380")]
		[PreserveSig]
		private static extern int criAtomExPlayback_GetParameterSint32(uint id, int parameterId, out int value);

		// Token: 0x06000814 RID: 2068
		[Token(Token = "0x6000814")]
		[Address(RVA = "0x36E31B0", Offset = "0x36E1DB0", VA = "0x1836E31B0")]
		[PreserveSig]
		private static extern int criAtomExPlayback_GetAisacControlById(uint id, uint controlId, out float value);

		// Token: 0x06000815 RID: 2069
		[Token(Token = "0x6000815")]
		[Address(RVA = "0x36E3240", Offset = "0x36E1E40", VA = "0x1836E3240")]
		[PreserveSig]
		private static extern int criAtomExPlayback_GetAisacControlByName(uint id, string controlName, out float value);
	}
}
