using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Timers;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using Vuplex.WebView;
using YoStar.SDK.Net.Bean;

namespace YoStar.SDK.UI
{
	// Token: 0x020001A3 RID: 419
	[Token(Token = "0x20001A3")]
	public class ReadAgreement
	{
		// Token: 0x06000A2D RID: 2605 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A2D")]
		[Address(RVA = "0x5C7A570", Offset = "0x5C79170", VA = "0x185C7A570")]
		public ReadAgreement()
		{
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A2E")]
		[Address(RVA = "0x5C787E0", Offset = "0x5C773E0", VA = "0x185C787E0")]
		public void InitTypeItemView()
		{
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0x5C79BA0", Offset = "0x5C787A0", VA = "0x185C79BA0")]
		private void SetBgImageActive(AgreementTypeItemPanel item, bool isActive)
		{
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A30")]
		[Address(RVA = "0x5C79950", Offset = "0x5C78550", VA = "0x185C79950")]
		private void OnClickAgreement(AgreementTypeItemPanel agreementTypeItemPanel, string content)
		{
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A31")]
		[Address(RVA = "0x5C78480", Offset = "0x5C77080", VA = "0x185C78480")]
		private Task<AgreementEntity> DownloadAgreements()
		{
			return null;
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A32")]
		[Address(RVA = "0x22F8A70", Offset = "0x22F7670", VA = "0x1822F8A70")]
		public void SetAgreements(string[] agreements)
		{
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A33")]
		[Address(RVA = "0x32FC4B0", Offset = "0x32FB0B0", VA = "0x1832FC4B0")]
		public void SetDisplayMode(int display)
		{
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A34")]
		[Address(RVA = "0x4EEA30", Offset = "0x4ED630", VA = "0x1804EEA30")]
		public void SetTitle(string title)
		{
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A35")]
		[Address(RVA = "0x5C79EC0", Offset = "0x5C78AC0", VA = "0x185C79EC0")]
		public void SetUrl(string url)
		{
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A36")]
		[Address(RVA = "0x5C79DC0", Offset = "0x5C789C0", VA = "0x185C79DC0")]
		public void SetHtml(string html)
		{
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A37")]
		[Address(RVA = "0x1FC11F0", Offset = "0x1FBFDF0", VA = "0x181FC11F0")]
		public void SetPageLoadFailedCallBack(ReadAgreement.ChangeCallback callback)
		{
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A38")]
		[Address(RVA = "0xF93850", Offset = "0xF92450", VA = "0x180F93850")]
		public void SetLoadProgressChangedCallback(ReadAgreement.LoadProgressChangedCallback callback)
		{
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A39")]
		[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
		public void SetJavaScriptMsg(string jsMsg)
		{
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A3A")]
		[Address(RVA = "0x5C775F0", Offset = "0x5C761F0", VA = "0x185C775F0")]
		private void ChangeWebBGColor()
		{
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A3B")]
		[Address(RVA = "0x5C794E0", Offset = "0x5C780E0", VA = "0x185C794E0")]
		public void InvokeJs(string jsonStr)
		{
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0x5C79F20", Offset = "0x5C78B20", VA = "0x185C79F20")]
		public void Show()
		{
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A3D")]
		[Address(RVA = "0x5C78610", Offset = "0x5C77210", VA = "0x185C78610")]
		private void FilterAgreementType(List<AgreementItem> agreements)
		{
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A3E")]
		[Address(RVA = "0x5C78260", Offset = "0x5C76E60", VA = "0x185C78260")]
		private void Destroy()
		{
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A3F")]
		[Address(RVA = "0x5C781E0", Offset = "0x5C76DE0", VA = "0x185C781E0")]
		private void DestroyGameObject(GameObject obj)
		{
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A40")]
		[Address(RVA = "0x5C77860", Offset = "0x5C76460", VA = "0x185C77860")]
		private Canvas CreateCanvas()
		{
			return null;
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A41")]
		[Address(RVA = "0x5C78740", Offset = "0x5C77340", VA = "0x185C78740")]
		public void GoBack()
		{
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A42")]
		[Address(RVA = "0x5C7A040", Offset = "0x5C78C40", VA = "0x185C7A040")]
		private void UpdateCanvasGroup(int alpha)
		{
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A43")]
		[Address(RVA = "0x5C79B30", Offset = "0x5C78730", VA = "0x185C79B30")]
		private void ResizeToolBarBtnSize(Button btn)
		{
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A44")]
		[Address(RVA = "0x5C77B10", Offset = "0x5C76710", VA = "0x185C77B10")]
		private void DealToolBar(GameObject webWrap)
		{
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A45")]
		[Address(RVA = "0x5C77290", Offset = "0x5C75E90", VA = "0x185C77290")]
		private void AddWebViewWrap(Canvas canva)
		{
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A46")]
		[Address(RVA = "0x5C79D50", Offset = "0x5C78950", VA = "0x185C79D50")]
		public void SetDefaultBackground(bool Enabled)
		{
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A47")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public void HideScrollbars(CanvasWebViewPrefab canvasWebView)
		{
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A48")]
		[Address(RVA = "0x5C79CB0", Offset = "0x5C788B0", VA = "0x185C79CB0")]
		public void SetContentMargins()
		{
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A49")]
		[Address(RVA = "0x5C79E20", Offset = "0x5C78A20", VA = "0x185C79E20")]
		private void SetScrollBarStyle(CanvasWebViewPrefab canvasWebView)
		{
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0x5C7A540", Offset = "0x5C79140", VA = "0x185C7A540")]
		private void Whell(CanvasWebViewPrefab canvasWebView)
		{
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A4B")]
		[Address(RVA = "0x5C78570", Offset = "0x5C77170", VA = "0x185C78570")]
		private void EnableContentAutoWrap(CanvasWebViewPrefab canvasWebView)
		{
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A4C")]
		[Address(RVA = "0x5C783E0", Offset = "0x5C76FE0", VA = "0x185C783E0")]
		private void DisableHorizontalScrolling(CanvasWebViewPrefab canvasWebView)
		{
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A4D")]
		[Address(RVA = "0x5C793B0", Offset = "0x5C77FB0", VA = "0x185C793B0")]
		private void InterceptLink(CanvasWebViewPrefab canvasWebView)
		{
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A4E")]
		[Address(RVA = "0x5C792F0", Offset = "0x5C77EF0", VA = "0x185C792F0")]
		private void InitWebView(CanvasWebViewPrefab canvasWebView)
		{
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A4F")]
		[Address(RVA = "0x5C79630", Offset = "0x5C78230", VA = "0x185C79630")]
		private IEnumerator LoadByUrl(string url)
		{
			return null;
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A50")]
		[Address(RVA = "0x5C795A0", Offset = "0x5C781A0", VA = "0x185C795A0")]
		private IEnumerator LoadByHtml(string html)
		{
			return null;
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A51")]
		[Address(RVA = "0x5C77550", Offset = "0x5C76150", VA = "0x185C77550")]
		private void ButtonRefreshTimer_Elapsed(object sender, ElapsedEventArgs eventArgs)
		{
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A52")]
		[Address(RVA = "0x5C77710", Offset = "0x5C76310", VA = "0x185C77710")]
		private void Controls_MessageEmitted(object sender, EventArgs<string> eventArgs)
		{
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A53")]
		[Address(RVA = "0x5C7A0D0", Offset = "0x5C78CD0", VA = "0x185C7A0D0")]
		private void WebView_PageLoadFailed(object sender, EventArgs eventArgs)
		{
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A54")]
		[Address(RVA = "0x5C7A280", Offset = "0x5C78E80", VA = "0x185C7A280")]
		private void WebView_UrlChanged(object sender, UrlChangedEventArgs eventArgs)
		{
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A55")]
		[Address(RVA = "0x5C796C0", Offset = "0x5C782C0", VA = "0x185C796C0")]
		private void LoadProgressChanged(object sender, ProgressChangedEventArgs eventArgs)
		{
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A56")]
		[Address(RVA = "0x5C776D0", Offset = "0x5C762D0", VA = "0x185C776D0")]
		public static void ClearAllData()
		{
		}

		// Token: 0x040006C9 RID: 1737
		[Token(Token = "0x40006C9")]
		[FieldOffset(Offset = "0x10")]
		private Color backageColor;

		// Token: 0x040006CA RID: 1738
		[Token(Token = "0x40006CA")]
		[FieldOffset(Offset = "0x20")]
		private bool hideToolBar;

		// Token: 0x040006CB RID: 1739
		[Token(Token = "0x40006CB")]
		[FieldOffset(Offset = "0x28")]
		private string javaScriptMsg;

		// Token: 0x040006CC RID: 1740
		[Token(Token = "0x40006CC")]
		[FieldOffset(Offset = "0x30")]
		private bool webViewInited;

		// Token: 0x040006CD RID: 1741
		[Token(Token = "0x40006CD")]
		[FieldOffset(Offset = "0x38")]
		private string url;

		// Token: 0x040006CE RID: 1742
		[Token(Token = "0x40006CE")]
		[FieldOffset(Offset = "0x40")]
		private string html;

		// Token: 0x040006CF RID: 1743
		[Token(Token = "0x40006CF")]
		[FieldOffset(Offset = "0x48")]
		private string titleText;

		// Token: 0x040006D0 RID: 1744
		[Token(Token = "0x40006D0")]
		[FieldOffset(Offset = "0x50")]
		private Slider processSlider;

		// Token: 0x040006D1 RID: 1745
		[Token(Token = "0x40006D1")]
		[FieldOffset(Offset = "0x58")]
		private Canvas sdkCanvas;

		// Token: 0x040006D2 RID: 1746
		[Token(Token = "0x40006D2")]
		[FieldOffset(Offset = "0x60")]
		private GameObject webWrap;

		// Token: 0x040006D3 RID: 1747
		[Token(Token = "0x40006D3")]
		[FieldOffset(Offset = "0x68")]
		private GameObject webCanvas;

		// Token: 0x040006D4 RID: 1748
		[Token(Token = "0x40006D4")]
		[FieldOffset(Offset = "0x70")]
		private CanvasWebViewPrefab canvasWebViewPrefab;

		// Token: 0x040006D5 RID: 1749
		[Token(Token = "0x40006D5")]
		[FieldOffset(Offset = "0x78")]
		private CanvasGroup canvasGroup;

		// Token: 0x040006D6 RID: 1750
		[Token(Token = "0x40006D6")]
		[FieldOffset(Offset = "0x80")]
		private Button goBackBtn;

		// Token: 0x040006D7 RID: 1751
		[Token(Token = "0x40006D7")]
		[FieldOffset(Offset = "0x88")]
		private Text title;

		// Token: 0x040006D8 RID: 1752
		[Token(Token = "0x40006D8")]
		[FieldOffset(Offset = "0x90")]
		private ReadAgreement.ChangeCallback pageLoadFailedCallBack;

		// Token: 0x040006D9 RID: 1753
		[Token(Token = "0x40006D9")]
		[FieldOffset(Offset = "0x98")]
		private ReadAgreement.LoadProgressChangedCallback loadProgressChangedCallback;

		// Token: 0x040006DA RID: 1754
		[Token(Token = "0x40006DA")]
		[FieldOffset(Offset = "0xA0")]
		private Timer buttonRefreshTimer;

		// Token: 0x040006DB RID: 1755
		[Token(Token = "0x40006DB")]
		private const string WebViewPrefabResourcePath = "prefab/ReadAgreementPanel";

		// Token: 0x040006DC RID: 1756
		[Token(Token = "0x40006DC")]
		[FieldOffset(Offset = "0xA8")]
		private List<AgreementItem> agreements;

		// Token: 0x040006DD RID: 1757
		[Token(Token = "0x40006DD")]
		[FieldOffset(Offset = "0xB0")]
		private string[] agreementTypes;

		// Token: 0x040006DE RID: 1758
		[Token(Token = "0x40006DE")]
		[FieldOffset(Offset = "0xB8")]
		private int displayMode;

		// Token: 0x040006DF RID: 1759
		[Token(Token = "0x40006DF")]
		[FieldOffset(Offset = "0xC0")]
		private GameObject itemGroupGo;

		// Token: 0x040006E0 RID: 1760
		[Token(Token = "0x40006E0")]
		[FieldOffset(Offset = "0xC8")]
		private List<AgreementTypeItemPanel> typeItemPanelList;

		// Token: 0x020001A4 RID: 420
		// (Invoke) Token: 0x06000A5C RID: 2652
		[Token(Token = "0x20001A4")]
		public delegate void ChangeCallback(ReadAgreement sdkWebView, string msg);

		// Token: 0x020001A5 RID: 421
		// (Invoke) Token: 0x06000A60 RID: 2656
		[Token(Token = "0x20001A5")]
		public delegate void LoadProgressChangedCallback(ReadAgreement sdkWebView, ProgressChangedEventArgs eventArgs);
	}
}
