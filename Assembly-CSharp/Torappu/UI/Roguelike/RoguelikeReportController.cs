using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005376 RID: 21366
	[Token(Token = "0x2005376")]
	public abstract class RoguelikeReportController<TViewModel> : RoguelikeReportControllerBase where TViewModel : RoguelikeEndingFrameViewModel
	{
		// Token: 0x170049DA RID: 18906
		// (get) Token: 0x0601F7DA RID: 128986 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601F7DB RID: 128987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170049DA")]
		private protected TViewModel endingFrameModel
		{
			[Token(Token = "0x601F7DA")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x601F7DB")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601F7DC RID: 128988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F7DC")]
		public sealed override void Init(RoguelikeReportPage page, RoguelikeReportPage.Param param)
		{
		}

		// Token: 0x0601F7DD RID: 128989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F7DD")]
		public sealed override void NotifyClosePage()
		{
		}

		// Token: 0x0601F7DE RID: 128990
		[Token(Token = "0x601F7DE")]
		protected abstract void OnInit();

		// Token: 0x0601F7DF RID: 128991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F7DF")]
		protected virtual void OnClosePage()
		{
		}

		// Token: 0x0601F7E0 RID: 128992 RVA: 0x000B2188 File Offset: 0x000B0388
		[Token(Token = "0x601F7E0")]
		public static bool TryDecompressEnding(string data, out TViewModel endFrame)
		{
			return default(bool);
		}

		// Token: 0x0601F7E1 RID: 128993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F7E1")]
		protected RoguelikeReportController()
		{
		}

		// Token: 0x0402A5F9 RID: 173561
		[Token(Token = "0x402A5F9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_endingFrameModel;

		// Token: 0x0402A5FA RID: 173562
		[Token(Token = "0x402A5FA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_endingFrameModel;

		// Token: 0x0402A5FB RID: 173563
		[Token(Token = "0x402A5FB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402A5FC RID: 173564
		[Token(Token = "0x402A5FC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_NotifyClosePage;

		// Token: 0x0402A5FD RID: 173565
		[Token(Token = "0x402A5FD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnClosePage;

		// Token: 0x0402A5FE RID: 173566
		[Token(Token = "0x402A5FE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_TryDecompressEnding;

		// Token: 0x0402A5FF RID: 173567
		[Token(Token = "0x402A5FF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
