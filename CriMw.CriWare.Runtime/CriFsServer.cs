using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace CriWare
{
	// Token: 0x020000CA RID: 202
	[Token(Token = "0x20000CA")]
	public class CriFsServer : CriMonoBehaviour
	{
		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060006AB RID: 1707 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x17000079")]
		public static CriFsServer instance
		{
			[Token(Token = "0x60006AB")]
			[Address(RVA = "0x36FB5D0", Offset = "0x36FA1D0", VA = "0x1836FB5D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060006AC RID: 1708 RVA: 0x00003C14 File Offset: 0x00001E14
		// (set) Token: 0x060006AD RID: 1709 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700007A")]
		public int installBufferSize
		{
			[Token(Token = "0x60006AC")]
			[Address(RVA = "0xC91700", Offset = "0xC90300", VA = "0x180C91700")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60006AD")]
			[Address(RVA = "0xF82EE0", Offset = "0xF81AE0", VA = "0x180F82EE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x36FAB50", Offset = "0x36F9750", VA = "0x1836FAB50")]
		public static void CreateInstance()
		{
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x36FAE60", Offset = "0x36F9A60", VA = "0x1836FAE60")]
		public static void DestroyInstance()
		{
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x36FA6D0", Offset = "0x36F92D0", VA = "0x1836FA6D0")]
		private void Awake()
		{
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x36FB330", Offset = "0x36F9F30", VA = "0x1836FB330")]
		private void OnDestroy()
		{
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x36FAC40", Offset = "0x36F9840", VA = "0x1836FAC40", Slot = "6")]
		public override void CriInternalUpdate()
		{
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "7")]
		public override void CriInternalLateUpdate()
		{
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x36FA670", Offset = "0x36F9270", VA = "0x1836FA670")]
		public void AddRequest(CriFsRequest request)
		{
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x36FB130", Offset = "0x36F9D30", VA = "0x1836FB130")]
		public CriFsLoadFileRequest LoadFile(CriFsBinder binder, string path, CriFsRequest.DoneDelegate doneDelegate, int readUnitSize)
		{
			return null;
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x36FAFD0", Offset = "0x36F9BD0", VA = "0x1836FAFD0")]
		public CriFsLoadAssetBundleRequest LoadAssetBundle(CriFsBinder binder, string path, int readUnitSize)
		{
			return null;
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x36FAF00", Offset = "0x36F9B00", VA = "0x1836FAF00")]
		public CriFsInstallRequest Install(CriFsBinder srcBinder, string srcPath, string dstPath, CriFsRequest.DoneDelegate doneDelegate)
		{
			return null;
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x36FB4E0", Offset = "0x36FA0E0", VA = "0x1836FB4E0")]
		public CriFsInstallRequest WebInstall(string srcPath, string dstPath, CriFsRequest.DoneDelegate doneDelegate)
		{
			return null;
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x36FA870", Offset = "0x36F9470", VA = "0x1836FA870")]
		public CriFsBindRequest BindCpk(CriFsBinder targetBinder, CriFsBinder srcBinder, string path)
		{
			return null;
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x36FA940", Offset = "0x36F9540", VA = "0x1836FA940")]
		public CriFsBindRequest BindDirectory(CriFsBinder targetBinder, CriFsBinder srcBinder, string path)
		{
			return null;
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x36FAA10", Offset = "0x36F9610", VA = "0x1836FAA10")]
		public CriFsBindRequest BindFile(CriFsBinder targetBinder, CriFsBinder srcBinder, string path)
		{
			return null;
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x36FB5A0", Offset = "0x36FA1A0", VA = "0x1836FB5A0")]
		public CriFsServer()
		{
		}

		// Token: 0x0400039A RID: 922
		[Token(Token = "0x400039A")]
		[FieldOffset(Offset = "0x0")]
		private static CriFsServer _instance;

		// Token: 0x0400039B RID: 923
		[Token(Token = "0x400039B")]
		[FieldOffset(Offset = "0x28")]
		private List<CriFsRequest> requestList;
	}
}
