using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using Vuplex.WebView.Internal;

namespace Vuplex.WebView
{
	// Token: 0x02000039 RID: 57
	[Token(Token = "0x2000039")]
	public class MockWebPlugin : IWebPlugin
	{
		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000185 RID: 389 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000028")]
		public ICookieManager CookieManager
		{
			[Token(Token = "0x6000185")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000186 RID: 390 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000029")]
		public static MockWebPlugin Instance
		{
			[Token(Token = "0x6000186")]
			[Address(RVA = "0x5BB6390", Offset = "0x5BB4F90", VA = "0x185BB6390")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000187 RID: 391 RVA: 0x00002340 File Offset: 0x00000540
		[Token(Token = "0x1700002A")]
		public WebPluginType Type
		{
			[Token(Token = "0x6000187")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return WebPluginType.Android;
			}
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000188")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
		public void ClearAllData()
		{
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000189")]
		[Address(RVA = "0x5BB5FA0", Offset = "0x5BB4BA0", VA = "0x185BB5FA0", Slot = "7")]
		public void CreateMaterial(Action<Material> callback)
		{
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600018A")]
		[Address(RVA = "0x5BB6250", Offset = "0x5BB4E50", VA = "0x185BB6250", Slot = "16")]
		public virtual IWebView CreateWebView()
		{
			return null;
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018B")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "9")]
		public void EnableRemoteDebugging()
		{
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018C")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "10")]
		public void SetAutoplayEnabled(bool enabled)
		{
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018D")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "11")]
		public void SetCameraAndMicrophoneEnabled(bool enabled)
		{
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018E")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "12")]
		public void SetIgnoreCertificateErrors(bool ignore)
		{
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018F")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "13")]
		public void SetStorageEnabled(bool enabled)
		{
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000190")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "14")]
		public void SetUserAgent(bool mobile)
		{
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000191")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "15")]
		public void SetUserAgent(string userAgent)
		{
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000192")]
		[Address(RVA = "0x5BB62D0", Offset = "0x5BB4ED0", VA = "0x185BB62D0")]
		public MockWebPlugin()
		{
		}

		// Token: 0x040000A8 RID: 168
		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x0")]
		private static MockWebPlugin _instance;
	}
}
