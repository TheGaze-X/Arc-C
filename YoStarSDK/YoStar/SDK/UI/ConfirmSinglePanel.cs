using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine.UI;
using Vuplex.WebView;

namespace YoStar.SDK.UI
{
	// Token: 0x0200014A RID: 330
	[Token(Token = "0x200014A")]
	public class ConfirmSinglePanel : BasePanel
	{
		// Token: 0x06000869 RID: 2153 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000869")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
		public override void InitView()
		{
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600086A")]
		[Address(RVA = "0x5C59840", Offset = "0x5C58440", VA = "0x185C59840")]
		public new void Awake()
		{
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600086B")]
		[Address(RVA = "0x5C5A160", Offset = "0x5C58D60", VA = "0x185C5A160")]
		private void InitWebView(CanvasWebViewPrefab canvasWebView)
		{
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600086C")]
		[Address(RVA = "0x5C5AE30", Offset = "0x5C59A30", VA = "0x185C5AE30")]
		private Task OnLoadingCompletedAsync()
		{
			return null;
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600086D")]
		[Address(RVA = "0x5C5A3E0", Offset = "0x5C58FE0", VA = "0x185C5A3E0")]
		private IEnumerator LoadByUrl(string url)
		{
			return null;
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600086E")]
		[Address(RVA = "0x5C5A350", Offset = "0x5C58F50", VA = "0x185C5A350")]
		private IEnumerator LoadByHtml(string html)
		{
			return null;
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600086F")]
		[Address(RVA = "0x5C5A470", Offset = "0x5C59070", VA = "0x185C5A470")]
		private void LoadProgressChanged(object sender, ProgressChangedEventArgs eventArgs)
		{
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000870")]
		[Address(RVA = "0x5C59E30", Offset = "0x5C58A30", VA = "0x185C59E30")]
		private void Controls_MessageEmitted(object sender, EventArgs<string> eventArgs)
		{
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000871")]
		[Address(RVA = "0x5C5AFA0", Offset = "0x5C59BA0", VA = "0x185C5AFA0")]
		private void SetSwipeStyle(CanvasWebViewPrefab canvasWebView)
		{
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000872")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public void HideScrollbars(CanvasWebViewPrefab canvasWebView)
		{
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000873")]
		[Address(RVA = "0x5C5AF00", Offset = "0x5C59B00", VA = "0x185C5AF00")]
		private void SetContentMargins(CanvasWebViewPrefab canvasWebView)
		{
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000874")]
		[Address(RVA = "0x5C5A0C0", Offset = "0x5C58CC0", VA = "0x185C5A0C0")]
		private void EnableContentAutoWrap(CanvasWebViewPrefab canvasWebView)
		{
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000875")]
		[Address(RVA = "0x5C59F80", Offset = "0x5C58B80", VA = "0x185C59F80")]
		private void DisableHorizontalScrolling(CanvasWebViewPrefab canvasWebView)
		{
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000876")]
		[Address(RVA = "0x5C5A220", Offset = "0x5C58E20", VA = "0x185C5A220")]
		private void InterceptLink(CanvasWebViewPrefab canvasWebView)
		{
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000877")]
		[Address(RVA = "0x5C5A550", Offset = "0x5C59150", VA = "0x185C5A550")]
		private void OnClick(Button button)
		{
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000878")]
		[Address(RVA = "0x5C5AA60", Offset = "0x5C59660", VA = "0x185C5AA60", Slot = "9")]
		public override void OnCreate()
		{
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000879")]
		[Address(RVA = "0x5C5A020", Offset = "0x5C58C20", VA = "0x185C5A020")]
		private void DownloadDataAsync()
		{
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600087A")]
		[Address(RVA = "0x5B5830", Offset = "0x5B4430", VA = "0x1805B5830")]
		public ConfirmSinglePanel()
		{
		}

		// Token: 0x04000535 RID: 1333
		[Token(Token = "0x4000535")]
		[FieldOffset(Offset = "0x50")]
		private Button leftButton;

		// Token: 0x04000536 RID: 1334
		[Token(Token = "0x4000536")]
		[FieldOffset(Offset = "0x58")]
		private Button rightButton;

		// Token: 0x04000537 RID: 1335
		[Token(Token = "0x4000537")]
		[FieldOffset(Offset = "0x60")]
		private Text title;

		// Token: 0x04000538 RID: 1336
		[Token(Token = "0x4000538")]
		[FieldOffset(Offset = "0x68")]
		private CanvasWebViewPrefab canvasWebViewPrefab;

		// Token: 0x04000539 RID: 1337
		[Token(Token = "0x4000539")]
		[FieldOffset(Offset = "0x70")]
		private bool webViewInited;

		// Token: 0x0400053A RID: 1338
		[Token(Token = "0x400053A")]
		[FieldOffset(Offset = "0x78")]
		private string agreement;

		// Token: 0x0400053B RID: 1339
		[Token(Token = "0x400053B")]
		[FieldOffset(Offset = "0x80")]
		private Dictionary<string, object> eventParam;
	}
}
