using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace CriWare
{
	// Token: 0x020000C8 RID: 200
	[Token(Token = "0x20000C8")]
	public static class CriFsUtility
	{
		// Token: 0x06000683 RID: 1667 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000683")]
		[Address(RVA = "0x36FC100", Offset = "0x36FAD00", VA = "0x1836FC100")]
		public static CriFsLoadFileRequest LoadFile(string path, int readUnitSize = 1048576)
		{
			return null;
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000684")]
		[Address(RVA = "0x36FC040", Offset = "0x36FAC40", VA = "0x1836FC040")]
		public static CriFsLoadFileRequest LoadFile(string path, CriFsRequest.DoneDelegate doneDelegate, int readUnitSize = 1048576)
		{
			return null;
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000685")]
		[Address(RVA = "0x36FC0A0", Offset = "0x36FACA0", VA = "0x1836FC0A0")]
		public static CriFsLoadFileRequest LoadFile(CriFsBinder binder, string path, int readUnitSize = 1048576)
		{
			return null;
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000686")]
		[Address(RVA = "0x36FBEE0", Offset = "0x36FAAE0", VA = "0x1836FBEE0")]
		public static CriFsLoadAssetBundleRequest LoadAssetBundle(string path, int readUnitSize = 1048576)
		{
			return null;
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000687")]
		[Address(RVA = "0x36FBD70", Offset = "0x36FA970", VA = "0x1836FBD70")]
		public static CriFsLoadAssetBundleRequest LoadAssetBundle(CriFsBinder binder, string path, int readUnitSize = 1048576)
		{
			return null;
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000688")]
		[Address(RVA = "0x36FBCB0", Offset = "0x36FA8B0", VA = "0x1836FBCB0")]
		public static CriFsInstallRequest Install(string srcPath, string dstPath)
		{
			return null;
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000689")]
		[Address(RVA = "0x36FBBF0", Offset = "0x36FA7F0", VA = "0x1836FBBF0")]
		public static CriFsInstallRequest Install(string srcPath, string dstPath, CriFsRequest.DoneDelegate doneDeleagate)
		{
			return null;
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600068A")]
		[Address(RVA = "0x36FBC50", Offset = "0x36FA850", VA = "0x1836FBC50")]
		public static CriFsInstallRequest Install(CriFsBinder srcBinder, string srcPath, string dstPath)
		{
			return null;
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600068B")]
		[Address(RVA = "0x36FBD00", Offset = "0x36FA900", VA = "0x1836FBD00")]
		public static CriFsInstallRequest Install(CriFsBinder srcBinder, string srcPath, string dstPath, CriFsRequest.DoneDelegate doneDeleagate)
		{
			return null;
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600068C")]
		[Address(RVA = "0x36FC310", Offset = "0x36FAF10", VA = "0x1836FC310")]
		public static CriFsInstallRequest WebInstall(string srcPath, string dstPath, CriFsRequest.DoneDelegate doneDeleagate)
		{
			return null;
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600068D")]
		[Address(RVA = "0x36FB6F0", Offset = "0x36FA2F0", VA = "0x1836FB6F0")]
		public static CriFsBindRequest BindCpk(CriFsBinder targetBinder, string srcPath)
		{
			return null;
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600068E")]
		[Address(RVA = "0x36FB7C0", Offset = "0x36FA3C0", VA = "0x1836FB7C0")]
		public static CriFsBindRequest BindCpk(CriFsBinder targetBinder, CriFsBinder srcBinder, string srcPath)
		{
			return null;
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600068F")]
		[Address(RVA = "0x36FB8A0", Offset = "0x36FA4A0", VA = "0x1836FB8A0")]
		public static CriFsBindRequest BindDirectory(CriFsBinder targetBinder, string srcPath)
		{
			return null;
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000690")]
		[Address(RVA = "0x36FB8F0", Offset = "0x36FA4F0", VA = "0x1836FB8F0")]
		public static CriFsBindRequest BindDirectory(CriFsBinder targetBinder, CriFsBinder srcBinder, string srcPath)
		{
			return null;
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000691")]
		[Address(RVA = "0x36FB9B0", Offset = "0x36FA5B0", VA = "0x1836FB9B0")]
		public static CriFsBindRequest BindFile(CriFsBinder targetBinder, string srcPath)
		{
			return null;
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000692")]
		[Address(RVA = "0x36FB950", Offset = "0x36FA550", VA = "0x1836FB950")]
		public static CriFsBindRequest BindFile(CriFsBinder targetBinder, CriFsBinder srcBinder, string srcPath)
		{
			return null;
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000693")]
		[Address(RVA = "0x36FC280", Offset = "0x36FAE80", VA = "0x1836FC280")]
		public static void SetUserAgentString(string userAgentString)
		{
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000694")]
		[Address(RVA = "0x36FC1E0", Offset = "0x36FADE0", VA = "0x1836FC1E0")]
		public static void SetProxyServer(string proxyPath, ushort proxyPort)
		{
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000695")]
		[Address(RVA = "0x36FC150", Offset = "0x36FAD50", VA = "0x1836FC150")]
		public static void SetPathSeparator(string filter)
		{
		}

		// Token: 0x06000696 RID: 1686
		[Token(Token = "0x6000696")]
		[Address(RVA = "0x36FBB50", Offset = "0x36FA750", VA = "0x1836FBB50")]
		[PreserveSig]
		private static extern bool CRIWAREBD435512(string userAgentString);

		// Token: 0x06000697 RID: 1687
		[Token(Token = "0x6000697")]
		[Address(RVA = "0x36FBA00", Offset = "0x36FA600", VA = "0x1836FBA00")]
		[PreserveSig]
		private static extern bool CRIWARE25339C14(string proxyPath, ushort proxyPort);

		// Token: 0x06000698 RID: 1688
		[Token(Token = "0x6000698")]
		[Address(RVA = "0x36FBAB0", Offset = "0x36FA6B0", VA = "0x1836FBAB0")]
		[PreserveSig]
		private static extern bool CRIWARE4086AEC2(string filter);

		// Token: 0x04000395 RID: 917
		[Token(Token = "0x4000395")]
		public const int DefaultReadUnitSize = 1048576;
	}
}
