using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020053CA RID: 21450
	[Token(Token = "0x20053CA")]
	public class RoguelikeRewardSelectStateBean : IStateBean, IHotfixable
	{
		// Token: 0x170049F0 RID: 18928
		// (get) Token: 0x0601F90E RID: 129294 RVA: 0x000B2440 File Offset: 0x000B0640
		// (set) Token: 0x0601F90F RID: 129295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170049F0")]
		public bool isForMapPreview
		{
			[Token(Token = "0x601F90E")]
			[Address(RVA = "0x1941520", Offset = "0x1940120", VA = "0x181941520")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601F90F")]
			[Address(RVA = "0x1941580", Offset = "0x1940180", VA = "0x181941580")]
			set
			{
			}
		}

		// Token: 0x0601F910 RID: 129296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F910")]
		[Address(RVA = "0x1941210", Offset = "0x193FE10", VA = "0x181941210")]
		private void CheckBtnHideForItemsForPreview()
		{
		}

		// Token: 0x0601F911 RID: 129297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F911")]
		[Address(RVA = "0x19414C0", Offset = "0x19400C0", VA = "0x1819414C0")]
		public RoguelikeRewardSelectStateBean()
		{
		}

		// Token: 0x0402A7F7 RID: 174071
		[Token(Token = "0x402A7F7")]
		[FieldOffset(Offset = "0x10")]
		public RoguelikeRewardItemViewModel viewModel;

		// Token: 0x0402A7F8 RID: 174072
		[Token(Token = "0x402A7F8")]
		[FieldOffset(Offset = "0x18")]
		public string topicId;

		// Token: 0x0402A7F9 RID: 174073
		[Token(Token = "0x402A7F9")]
		[FieldOffset(Offset = "0x20")]
		public bool showSeparator;

		// Token: 0x0402A7FA RID: 174074
		[Token(Token = "0x402A7FA")]
		[FieldOffset(Offset = "0x21")]
		private bool _isForMapPreview;

		// Token: 0x0402A7FB RID: 174075
		[Token(Token = "0x402A7FB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isForMapPreview;

		// Token: 0x0402A7FC RID: 174076
		[Token(Token = "0x402A7FC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isForMapPreview;

		// Token: 0x0402A7FD RID: 174077
		[Token(Token = "0x402A7FD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckBtnHideForItemsForPreview;

		// Token: 0x0402A7FE RID: 174078
		[Token(Token = "0x402A7FE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
