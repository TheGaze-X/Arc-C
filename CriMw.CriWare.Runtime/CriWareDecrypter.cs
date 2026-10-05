using System;
using System.Runtime.InteropServices;
using AOT;
using Il2CppDummyDll;

namespace CriWare
{
	// Token: 0x020000DF RID: 223
	[Token(Token = "0x20000DF")]
	public static class CriWareDecrypter
	{
		// Token: 0x06000782 RID: 1922 RVA: 0x00004064 File Offset: 0x00002264
		[Token(Token = "0x6000782")]
		[Address(RVA = "0x3704610", Offset = "0x3703210", VA = "0x183704610")]
		public static bool Initialize(CriWareDecrypter.Config config)
		{
			return default(bool);
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x0000407C File Offset: 0x0000227C
		[Token(Token = "0x6000783")]
		[Address(RVA = "0x3704380", Offset = "0x3702F80", VA = "0x183704380")]
		public static bool Initialize(string key, bool enableAtomDecryption, bool enableManaDecryption)
		{
			return default(bool);
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x00004094 File Offset: 0x00002294
		[Token(Token = "0x6000784")]
		[Address(RVA = "0x3704340", Offset = "0x3702F40", VA = "0x183704340")]
		[MonoPInvokeCallback(typeof(CriWareDecrypter.CallbackFromNativeDelegate))]
		private static ulong CallbackFromNative(IntPtr ptr1)
		{
			return 0UL;
		}

		// Token: 0x06000785 RID: 1925
		[Token(Token = "0x6000785")]
		[Address(RVA = "0x3704290", Offset = "0x3702E90", VA = "0x183704290")]
		[PreserveSig]
		public static extern int CRIWARE784C4141(bool enable_atom_decryption, bool enable_mana_decryption, CriWareDecrypter.CallbackFromNativeDelegate func, IntPtr obj);

		// Token: 0x0400040A RID: 1034
		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static ulong temporalStorage;

		// Token: 0x020000E0 RID: 224
		[Token(Token = "0x20000E0")]
		[Serializable]
		public class Config
		{
			// Token: 0x06000786 RID: 1926 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000786")]
			[Address(RVA = "0x36DED60", Offset = "0x36DD960", VA = "0x1836DED60")]
			public Config()
			{
			}

			// Token: 0x0400040B RID: 1035
			[Token(Token = "0x400040B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string key;

			// Token: 0x0400040C RID: 1036
			[Token(Token = "0x400040C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool enableAtomDecryption;

			// Token: 0x0400040D RID: 1037
			[Token(Token = "0x400040D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool enableManaDecryption;
		}

		// Token: 0x020000E1 RID: 225
		// (Invoke) Token: 0x06000788 RID: 1928
		[Token(Token = "0x20000E1")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate ulong CallbackFromNativeDelegate(IntPtr ptr1);
	}
}
