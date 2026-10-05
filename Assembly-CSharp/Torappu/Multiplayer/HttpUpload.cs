using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Networking;

namespace Torappu.Multiplayer
{
	// Token: 0x0200155E RID: 5470
	[Token(Token = "0x200155E")]
	public class HttpUpload
	{
		// Token: 0x06007D0F RID: 32015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D0F")]
		[Address(RVA = "0x2842600", Offset = "0x2841200", VA = "0x182842600")]
		public HttpUpload(params string[] svrUrls)
		{
		}

		// Token: 0x06007D10 RID: 32016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D10")]
		[Address(RVA = "0x2841FA0", Offset = "0x2840BA0", VA = "0x182841FA0")]
		public void Upload(string localPath, string remotePath, Action<bool> complete)
		{
		}

		// Token: 0x06007D11 RID: 32017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D11")]
		[Address(RVA = "0x28422B0", Offset = "0x2840EB0", VA = "0x1828422B0")]
		private void _DoUpload()
		{
		}

		// Token: 0x06007D12 RID: 32018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D12")]
		[Address(RVA = "0x28426A0", Offset = "0x28412A0", VA = "0x1828426A0")]
		private void _handleUploadComplete(AsyncOperation obj)
		{
		}

		// Token: 0x17000EE5 RID: 3813
		// (get) Token: 0x06007D13 RID: 32019 RVA: 0x00037740 File Offset: 0x00035940
		[Token(Token = "0x17000EE5")]
		public float progress
		{
			[Token(Token = "0x6007D13")]
			[Address(RVA = "0x2842800", Offset = "0x2841400", VA = "0x182842800")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000EE6 RID: 3814
		// (get) Token: 0x06007D14 RID: 32020 RVA: 0x00037758 File Offset: 0x00035958
		[Token(Token = "0x17000EE6")]
		public bool isDone
		{
			[Token(Token = "0x6007D14")]
			[Address(RVA = "0x28427E0", Offset = "0x28413E0", VA = "0x1828427E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000EE7 RID: 3815
		// (get) Token: 0x06007D15 RID: 32021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EE7")]
		public string error
		{
			[Token(Token = "0x6007D15")]
			[Address(RVA = "0x2842780", Offset = "0x2841380", VA = "0x182842780")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007D16 RID: 32022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007D16")]
		[Address(RVA = "0x28423D0", Offset = "0x2840FD0", VA = "0x1828423D0")]
		private UnityWebRequestAsyncOperation _PostFileTo(string url)
		{
			return null;
		}

		// Token: 0x06007D17 RID: 32023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D17")]
		[Address(RVA = "0x2842380", Offset = "0x2840F80", VA = "0x182842380")]
		private void _Done(bool suc)
		{
		}

		// Token: 0x04007DC5 RID: 32197
		[Token(Token = "0x4007DC5")]
		[FieldOffset(Offset = "0x10")]
		private string[] m_urls;

		// Token: 0x04007DC6 RID: 32198
		[Token(Token = "0x4007DC6")]
		[FieldOffset(Offset = "0x18")]
		private int m_using;

		// Token: 0x04007DC7 RID: 32199
		[Token(Token = "0x4007DC7")]
		[FieldOffset(Offset = "0x20")]
		private byte[] m_data;

		// Token: 0x04007DC8 RID: 32200
		[Token(Token = "0x4007DC8")]
		[FieldOffset(Offset = "0x28")]
		private string m_toPath;

		// Token: 0x04007DC9 RID: 32201
		[Token(Token = "0x4007DC9")]
		[FieldOffset(Offset = "0x30")]
		private bool m_raw;

		// Token: 0x04007DCA RID: 32202
		[Token(Token = "0x4007DCA")]
		[FieldOffset(Offset = "0x38")]
		private Action<bool> m_complete;

		// Token: 0x04007DCB RID: 32203
		[Token(Token = "0x4007DCB")]
		[FieldOffset(Offset = "0x40")]
		private UnityWebRequestAsyncOperation m_uploading;
	}
}
