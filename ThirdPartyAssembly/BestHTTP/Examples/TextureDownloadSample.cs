using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BestHTTP.Examples
{
	// Token: 0x02000566 RID: 1382
	[Token(Token = "0x2000566")]
	public sealed class TextureDownloadSample : MonoBehaviour
	{
		// Token: 0x06002DBF RID: 11711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DBF")]
		[Address(RVA = "0x53F5E20", Offset = "0x53F4A20", VA = "0x1853F5E20")]
		private void Awake()
		{
		}

		// Token: 0x06002DC0 RID: 11712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DC0")]
		[Address(RVA = "0x53F6420", Offset = "0x53F5020", VA = "0x1853F6420")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002DC1 RID: 11713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DC1")]
		[Address(RVA = "0x53F6470", Offset = "0x53F5070", VA = "0x1853F6470")]
		private void OnGUI()
		{
		}

		// Token: 0x06002DC2 RID: 11714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DC2")]
		[Address(RVA = "0x53F5F40", Offset = "0x53F4B40", VA = "0x1853F5F40")]
		private void DownloadImages()
		{
		}

		// Token: 0x06002DC3 RID: 11715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DC3")]
		[Address(RVA = "0x53F6170", Offset = "0x53F4D70", VA = "0x1853F6170")]
		private void ImageDownloaded(HTTPRequest req, HTTPResponse resp)
		{
		}

		// Token: 0x06002DC4 RID: 11716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DC4")]
		[Address(RVA = "0x53F6980", Offset = "0x53F5580", VA = "0x1853F6980")]
		public TextureDownloadSample()
		{
		}

		// Token: 0x040019B1 RID: 6577
		[Token(Token = "0x40019B1")]
		private const string BaseURL = "https://besthttp.azurewebsites.net/Content/";

		// Token: 0x040019B2 RID: 6578
		[Token(Token = "0x40019B2")]
		[FieldOffset(Offset = "0x18")]
		private string[] Images;

		// Token: 0x040019B3 RID: 6579
		[Token(Token = "0x40019B3")]
		[FieldOffset(Offset = "0x20")]
		private Texture2D[] Textures;

		// Token: 0x040019B4 RID: 6580
		[Token(Token = "0x40019B4")]
		[FieldOffset(Offset = "0x28")]
		private bool allDownloadedFromLocalCache;

		// Token: 0x040019B5 RID: 6581
		[Token(Token = "0x40019B5")]
		[FieldOffset(Offset = "0x2C")]
		private int finishedCount;

		// Token: 0x040019B6 RID: 6582
		[Token(Token = "0x40019B6")]
		[FieldOffset(Offset = "0x30")]
		private Vector2 scrollPos;
	}
}
