using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Scripting;

namespace CriWare
{
	// Token: 0x02000002 RID: 2
	[Token(Token = "0x2000002")]
	public static class CriManaVp9
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70")]
		[Preserve]
		public static bool SupportCurrentPlatform()
		{
			return default(bool);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x371E7D0", Offset = "0x371D3D0", VA = "0x18371E7D0")]
		[Preserve]
		public static void SetupVp9Decoder()
		{
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x371E740", Offset = "0x371D340", VA = "0x18371E740")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void RegisterVp9DecoderSetup()
		{
		}

		// Token: 0x06000004 RID: 4
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x371EDD0", Offset = "0x371D9D0", VA = "0x18371EDD0")]
		[PreserveSig]
		private static extern IntPtr criWareUnity_GetAllocateFunc();

		// Token: 0x06000005 RID: 5
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x371EE40", Offset = "0x371DA40", VA = "0x18371EE40")]
		[PreserveSig]
		private static extern IntPtr criWareUnity_GetDeallocateFunc();

		// Token: 0x06000006 RID: 6
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x371EB40", Offset = "0x371D740", VA = "0x18371EB40")]
		[PreserveSig]
		private static extern IntPtr criManaUnity_GetAllocatorManager();

		// Token: 0x06000007 RID: 7
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x371EBB0", Offset = "0x371D7B0", VA = "0x18371EBB0")]
		[PreserveSig]
		private static extern void criMvPly_AttachCodecInterface(int codec_type, IntPtr codec_if, IntPtr codecalpha_if);

		// Token: 0x06000008 RID: 8
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x371ED30", Offset = "0x371D930", VA = "0x18371ED30")]
		[PreserveSig]
		private static extern void criVvp9_SetUserAllocator(IntPtr alloc_func, IntPtr free_func, IntPtr usr_obj);

		// Token: 0x06000009 RID: 9
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x371ECC0", Offset = "0x371D8C0", VA = "0x18371ECC0")]
		[PreserveSig]
		private static extern IntPtr criVvp9_GetInterface();

		// Token: 0x0600000A RID: 10
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x371EC50", Offset = "0x371D850", VA = "0x18371EC50")]
		[PreserveSig]
		private static extern IntPtr criVvp9_GetAlphaInterface();

		// Token: 0x04000001 RID: 1
		[Token(Token = "0x4000001")]
		private const string scriptVersionString = "1.01.14";

		// Token: 0x04000002 RID: 2
		[Token(Token = "0x4000002")]
		public const string cri_mana_vp9_name = "cri_mana_vpx";
	}
}
