using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace CriWare
{
	// Token: 0x020000C2 RID: 194
	[Token(Token = "0x20000C2")]
	public class CriFsLoadAssetBundleRequest : CriFsRequest
	{
		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000664 RID: 1636 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x06000665 RID: 1637 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000071")]
		public string path
		{
			[Token(Token = "0x6000664")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000665")]
			[Address(RVA = "0x54AEC0", Offset = "0x549AC0", VA = "0x18054AEC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000666 RID: 1638 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x06000667 RID: 1639 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000072")]
		public AssetBundle assetBundle
		{
			[Token(Token = "0x6000666")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000667")]
			[Address(RVA = "0x4EEA30", Offset = "0x4ED630", VA = "0x1804EEA30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000668")]
		[Address(RVA = "0x36F7930", Offset = "0x36F6530", VA = "0x1836F7930")]
		public CriFsLoadAssetBundleRequest(CriFsBinder binder, string path, int readUnitSize)
		{
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000669")]
		[Address(RVA = "0x36F77F0", Offset = "0x36F63F0", VA = "0x1836F77F0", Slot = "8")]
		public override void Update()
		{
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600066A")]
		[Address(RVA = "0x36F7750", Offset = "0x36F6350", VA = "0x1836F7750", Slot = "7")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x04000386 RID: 902
		[Token(Token = "0x4000386")]
		[FieldOffset(Offset = "0x50")]
		private CriFsLoadFileRequest loadFileReq;

		// Token: 0x04000387 RID: 903
		[Token(Token = "0x4000387")]
		[FieldOffset(Offset = "0x58")]
		private AssetBundleCreateRequest assetBundleReq;
	}
}
