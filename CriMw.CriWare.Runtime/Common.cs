using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace CriWare
{
	// Token: 0x020000DD RID: 221
	[Token(Token = "0x20000DD")]
	public class Common
	{
		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000772 RID: 1906 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x17000098")]
		public static string streamingAssetsPath
		{
			[Token(Token = "0x6000772")]
			[Address(RVA = "0x36DE9F0", Offset = "0x36DD5F0", VA = "0x1836DE9F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000773 RID: 1907 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x17000099")]
		public static string installTargetPath
		{
			[Token(Token = "0x6000773")]
			[Address(RVA = "0x36DE840", Offset = "0x36DD440", VA = "0x1836DE840")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000774 RID: 1908 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x1700009A")]
		public static string installCachePath
		{
			[Token(Token = "0x6000774")]
			[Address(RVA = "0x36DE820", Offset = "0x36DD420", VA = "0x1836DE820")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x00003FA4 File Offset: 0x000021A4
		[Token(Token = "0x6000775")]
		[Address(RVA = "0x36DE720", Offset = "0x36DD320", VA = "0x1836DE720")]
		public static bool IsStreamingAssetsPath(string path)
		{
			return default(bool);
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000776 RID: 1910 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x1700009B")]
		public static GameObject managerObject
		{
			[Token(Token = "0x6000776")]
			[Address(RVA = "0x36DE850", Offset = "0x36DD450", VA = "0x1836DE850")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000777")]
		[Address(RVA = "0x36DE6F0", Offset = "0x36DD2F0", VA = "0x1836DE6F0")]
		public static string GetScriptVersionString()
		{
			return null;
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x00003FBC File Offset: 0x000021BC
		[Token(Token = "0x6000778")]
		[Address(RVA = "0x36DE3C0", Offset = "0x36DCFC0", VA = "0x1836DE3C0")]
		public static int GetBinaryVersionNumber()
		{
			return 0;
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x00003FD4 File Offset: 0x000021D4
		[Token(Token = "0x6000779")]
		[Address(RVA = "0x36DE6E0", Offset = "0x36DD2E0", VA = "0x1836DE6E0")]
		public static int GetRequiredBinaryVersionNumber()
		{
			return 0;
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x00003FEC File Offset: 0x000021EC
		[Token(Token = "0x600077A")]
		[Address(RVA = "0x36DE430", Offset = "0x36DD030", VA = "0x1836DE430")]
		public static bool CheckBinaryVersionCompatibility()
		{
			return default(bool);
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x00004004 File Offset: 0x00002204
		[Token(Token = "0x600077B")]
		[Address(RVA = "0x36DE5A0", Offset = "0x36DD1A0", VA = "0x1836DE5A0")]
		public static uint GetFsMemoryUsage()
		{
			return 0U;
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x0000401C File Offset: 0x0000221C
		[Token(Token = "0x600077C")]
		[Address(RVA = "0x36DE560", Offset = "0x36DD160", VA = "0x1836DE560")]
		public static uint GetAtomMemoryUsage()
		{
			return 0U;
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x00004034 File Offset: 0x00002234
		[Token(Token = "0x600077D")]
		[Address(RVA = "0x36DE640", Offset = "0x36DD240", VA = "0x1836DE640")]
		public static uint GetManaMemoryUsage()
		{
			return 0U;
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x0000404C File Offset: 0x0000224C
		[Token(Token = "0x600077E")]
		[Address(RVA = "0x36DE500", Offset = "0x36DD100", VA = "0x1836DE500")]
		public static Common.CpuUsage GetAtomCpuUsage()
		{
			return default(Common.CpuUsage);
		}

		// Token: 0x0600077F RID: 1919
		[Token(Token = "0x600077F")]
		[Address(RVA = "0x36DE3C0", Offset = "0x36DCFC0", VA = "0x1836DE3C0")]
		[PreserveSig]
		public static extern int CRIWAREC6309446();

		// Token: 0x06000780 RID: 1920
		[Token(Token = "0x6000780")]
		[Address(RVA = "0x36DE7A0", Offset = "0x36DD3A0", VA = "0x1836DE7A0")]
		[PreserveSig]
		public static extern void criWareUnity_SetRenderingEventOffsetForMana(int offset);

		// Token: 0x06000781 RID: 1921 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000781")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Common()
		{
		}

		// Token: 0x04000400 RID: 1024
		[Token(Token = "0x4000400")]
		private const string scriptVersionString = "2.44.49";

		// Token: 0x04000401 RID: 1025
		[Token(Token = "0x4000401")]
		public const bool supportsCriFsInstaller = true;

		// Token: 0x04000402 RID: 1026
		[Token(Token = "0x4000402")]
		public const bool supportsCriFsWebInstaller = true;

		// Token: 0x04000403 RID: 1027
		[Token(Token = "0x4000403")]
		public const string pluginName = "cri_ware_unity";

		// Token: 0x04000404 RID: 1028
		[Token(Token = "0x4000404")]
		public const CallingConvention pluginCallingConvention = CallingConvention.Cdecl;

		// Token: 0x04000405 RID: 1029
		[Token(Token = "0x4000405")]
		public const string engineName = "Unity";

		// Token: 0x04000406 RID: 1030
		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static GameObject _managerObject;

		// Token: 0x020000DE RID: 222
		[Token(Token = "0x20000DE")]
		public struct CpuUsage
		{
			// Token: 0x04000407 RID: 1031
			[Token(Token = "0x4000407")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float last;

			// Token: 0x04000408 RID: 1032
			[Token(Token = "0x4000408")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float average;

			// Token: 0x04000409 RID: 1033
			[Token(Token = "0x4000409")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float peak;
		}
	}
}
