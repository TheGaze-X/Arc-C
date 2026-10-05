using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CrossAppShare
{
	// Token: 0x020058BF RID: 22719
	[Token(Token = "0x20058BF")]
	internal class CrossAppShareBottomMenuDialog : UICompDialog<CrossAppShareBottomMenuDialog.Input>, IHotfixable
	{
		// Token: 0x0602127E RID: 135806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602127E")]
		[Address(RVA = "0x1B71380", Offset = "0x1B6FF80", VA = "0x181B71380", Slot = "18")]
		protected override void OnRender(CrossAppShareBottomMenuDialog.Input input)
		{
		}

		// Token: 0x0602127F RID: 135807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602127F")]
		[Address(RVA = "0x1B71180", Offset = "0x1B6FD80", VA = "0x181B71180")]
		public void EventOnBtnClicked()
		{
		}

		// Token: 0x06021280 RID: 135808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021280")]
		[Address(RVA = "0x1B710B0", Offset = "0x1B6FCB0", VA = "0x181B710B0")]
		public void EventOnBackClicked()
		{
		}

		// Token: 0x06021281 RID: 135809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021281")]
		[Address(RVA = "0x1B71870", Offset = "0x1B70470", VA = "0x181B71870")]
		private void _TrySaveScreenShot()
		{
		}

		// Token: 0x06021282 RID: 135810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021282")]
		[Address(RVA = "0x1B715E0", Offset = "0x1B701E0", VA = "0x181B715E0")]
		private static string _GetScreenShotPath(long ts)
		{
			return null;
		}

		// Token: 0x06021283 RID: 135811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021283")]
		[Address(RVA = "0x1B717A0", Offset = "0x1B703A0", VA = "0x181B717A0")]
		private static string _GetTargetDir()
		{
			return null;
		}

		// Token: 0x06021284 RID: 135812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021284")]
		[Address(RVA = "0x1B719C0", Offset = "0x1B705C0", VA = "0x181B719C0")]
		public CrossAppShareBottomMenuDialog()
		{
		}

		// Token: 0x0402D27B RID: 184955
		[Token(Token = "0x402D27B")]
		private const string SCREEN_SHOT_PATH = "Arknights_Screenshots/{0}";

		// Token: 0x0402D27C RID: 184956
		[Token(Token = "0x402D27C")]
		private const string FILE_NAME_FORMAT = "{0}.png";

		// Token: 0x0402D27D RID: 184957
		[Token(Token = "0x402D27D")]
		[FieldOffset(Offset = "0x70")]
		private CrossAppShareBottomMenuDialog.Input m_cachedInput;

		// Token: 0x0402D27E RID: 184958
		[Token(Token = "0x402D27E")]
		[FieldOffset(Offset = "0x78")]
		private string m_destPath;

		// Token: 0x0402D27F RID: 184959
		[Token(Token = "0x402D27F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0402D280 RID: 184960
		[Token(Token = "0x402D280")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnBtnClicked;

		// Token: 0x0402D281 RID: 184961
		[Token(Token = "0x402D281")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnBackClicked;

		// Token: 0x0402D282 RID: 184962
		[Token(Token = "0x402D282")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__TrySaveScreenShot;

		// Token: 0x0402D283 RID: 184963
		[Token(Token = "0x402D283")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetScreenShotPath;

		// Token: 0x0402D284 RID: 184964
		[Token(Token = "0x402D284")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetTargetDir;

		// Token: 0x0402D285 RID: 184965
		[Token(Token = "0x402D285")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020058C0 RID: 22720
		[Token(Token = "0x20058C0")]
		public class Input
		{
			// Token: 0x06021285 RID: 135813 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021285")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0402D286 RID: 184966
			[Token(Token = "0x402D286")]
			[FieldOffset(Offset = "0x10")]
			public string imgPath;

			// Token: 0x0402D287 RID: 184967
			[Token(Token = "0x402D287")]
			[FieldOffset(Offset = "0x18")]
			public Action onCancelShare;
		}
	}
}
