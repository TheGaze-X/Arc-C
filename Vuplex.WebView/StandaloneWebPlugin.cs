using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Vuplex.WebView
{
	// Token: 0x02000063 RID: 99
	[Token(Token = "0x2000063")]
	public class StandaloneWebPlugin : MonoBehaviour
	{
		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600025A RID: 602 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700003B")]
		public ICookieManager CookieManager
		{
			[Token(Token = "0x600025A")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025B")]
		[Address(RVA = "0x5BBB060", Offset = "0x5BB9C60", VA = "0x185BBB060", Slot = "5")]
		public void ClearAllData()
		{
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025C")]
		[Address(RVA = "0x5BBB190", Offset = "0x5BB9D90", VA = "0x185BBB190", Slot = "6")]
		public void CreateMaterial(Action<Material> callback)
		{
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025D")]
		[Address(RVA = "0x5BBB1D0", Offset = "0x5BB9DD0", VA = "0x185BBB1D0", Slot = "7")]
		public void EnableRemoteDebugging()
		{
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025E")]
		[Address(RVA = "0x5BBB220", Offset = "0x5BB9E20", VA = "0x185BBB220", Slot = "8")]
		public void SetAutoplayEnabled(bool enabled)
		{
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025F")]
		[Address(RVA = "0x5BBB330", Offset = "0x5BB9F30", VA = "0x185BBB330", Slot = "9")]
		public void SetCameraAndMicrophoneEnabled(bool enabled)
		{
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000260")]
		[Address(RVA = "0x5BBB380", Offset = "0x5BB9F80", VA = "0x185BBB380", Slot = "10")]
		public void SetIgnoreCertificateErrors(bool ignore)
		{
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000261")]
		[Address(RVA = "0x5BBB490", Offset = "0x5BBA090", VA = "0x185BBB490", Slot = "11")]
		public void SetStorageEnabled(bool enabled)
		{
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000262")]
		[Address(RVA = "0x5BBB5A0", Offset = "0x5BBA1A0", VA = "0x185BBB5A0", Slot = "12")]
		public void SetUserAgent(bool mobile)
		{
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000263")]
		[Address(RVA = "0x5BBB680", Offset = "0x5BBA280", VA = "0x185BBB680", Slot = "13")]
		public void SetUserAgent(string userAgent)
		{
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000264")]
		[Address(RVA = "0x5BBB770", Offset = "0x5BBA370", VA = "0x185BBB770")]
		private void Start()
		{
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000265")]
		[Address(RVA = "0x5BBB870", Offset = "0x5BBA470", VA = "0x185BBB870")]
		public StandaloneWebPlugin()
		{
		}
	}
}
