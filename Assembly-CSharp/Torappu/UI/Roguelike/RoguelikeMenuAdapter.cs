using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005339 RID: 21305
	[Token(Token = "0x2005339")]
	public class RoguelikeMenuAdapter : IHotfixable
	{
		// Token: 0x170049A5 RID: 18853
		// (get) Token: 0x0601F6B8 RID: 128696 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601F6B9 RID: 128697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170049A5")]
		public Type adapterType
		{
			[Token(Token = "0x601F6B8")]
			[Address(RVA = "0x1925B70", Offset = "0x1924770", VA = "0x181925B70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601F6B9")]
			[Address(RVA = "0x1925CF0", Offset = "0x19248F0", VA = "0x181925CF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170049A6 RID: 18854
		// (get) Token: 0x0601F6BA RID: 128698 RVA: 0x000B1DC8 File Offset: 0x000AFFC8
		[Token(Token = "0x170049A6")]
		public virtual bool showBottomBar
		{
			[Token(Token = "0x601F6BA")]
			[Address(RVA = "0x1921500", Offset = "0x1920100", VA = "0x181921500", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170049A7 RID: 18855
		// (get) Token: 0x0601F6BB RID: 128699 RVA: 0x000B1DE0 File Offset: 0x000AFFE0
		[Token(Token = "0x170049A7")]
		public virtual bool showStatusBar
		{
			[Token(Token = "0x601F6BB")]
			[Address(RVA = "0x1921560", Offset = "0x1920160", VA = "0x181921560", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170049A8 RID: 18856
		// (get) Token: 0x0601F6BC RID: 128700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170049A8")]
		public virtual RoguelikeMenuButtonPluginBase buttonPrefab
		{
			[Token(Token = "0x601F6BC")]
			[Address(RVA = "0x1925C30", Offset = "0x1924830", VA = "0x181925C30", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x170049A9 RID: 18857
		// (get) Token: 0x0601F6BD RID: 128701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170049A9")]
		public virtual RoguelikeMenuButtonPluginBase.Input buttonInput
		{
			[Token(Token = "0x601F6BD")]
			[Address(RVA = "0x1925BD0", Offset = "0x19247D0", VA = "0x181925BD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x170049AA RID: 18858
		// (get) Token: 0x0601F6BE RID: 128702 RVA: 0x000B1DF8 File Offset: 0x000AFFF8
		[Token(Token = "0x170049AA")]
		public virtual RoguelikeMenuCharObjectStatus charMenuObjectStatus
		{
			[Token(Token = "0x601F6BE")]
			[Address(RVA = "0x19214A0", Offset = "0x19200A0", VA = "0x1819214A0", Slot = "8")]
			get
			{
				return RoguelikeMenuCharObjectStatus.HIDE;
			}
		}

		// Token: 0x170049AB RID: 18859
		// (get) Token: 0x0601F6BF RID: 128703 RVA: 0x000B1E10 File Offset: 0x000B0010
		[Token(Token = "0x170049AB")]
		public virtual RoguelikeMenuSquadObjectStatus squadMenuObjectStatus
		{
			[Token(Token = "0x601F6BF")]
			[Address(RVA = "0x19215C0", Offset = "0x19201C0", VA = "0x1819215C0", Slot = "9")]
			get
			{
				return RoguelikeMenuSquadObjectStatus.NORMAL;
			}
		}

		// Token: 0x170049AC RID: 18860
		// (get) Token: 0x0601F6C0 RID: 128704 RVA: 0x000B1E28 File Offset: 0x000B0028
		[Token(Token = "0x170049AC")]
		public virtual RoguelikeMenuTotemObjectStatus totemMenuObjectStatus
		{
			[Token(Token = "0x601F6C0")]
			[Address(RVA = "0x1925C90", Offset = "0x1924890", VA = "0x181925C90", Slot = "10")]
			get
			{
				return RoguelikeMenuTotemObjectStatus.NORMAL;
			}
		}

		// Token: 0x0601F6C1 RID: 128705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F6C1")]
		[Address(RVA = "0x1925A90", Offset = "0x1924690", VA = "0x181925A90")]
		public void NotifyAdapterChanged(bool fastMode)
		{
		}

		// Token: 0x0601F6C2 RID: 128706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F6C2")]
		[Address(RVA = "0x1925B10", Offset = "0x1924710", VA = "0x181925B10")]
		public RoguelikeMenuAdapter()
		{
		}

		// Token: 0x0402A432 RID: 173106
		[Token(Token = "0x402A432")]
		[FieldOffset(Offset = "0x18")]
		public Action<bool> observer;

		// Token: 0x0402A433 RID: 173107
		[Token(Token = "0x402A433")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_adapterType;

		// Token: 0x0402A434 RID: 173108
		[Token(Token = "0x402A434")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_adapterType;

		// Token: 0x0402A435 RID: 173109
		[Token(Token = "0x402A435")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_showBottomBar;

		// Token: 0x0402A436 RID: 173110
		[Token(Token = "0x402A436")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_showStatusBar;

		// Token: 0x0402A437 RID: 173111
		[Token(Token = "0x402A437")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_buttonPrefab;

		// Token: 0x0402A438 RID: 173112
		[Token(Token = "0x402A438")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_buttonInput;

		// Token: 0x0402A439 RID: 173113
		[Token(Token = "0x402A439")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_charMenuObjectStatus;

		// Token: 0x0402A43A RID: 173114
		[Token(Token = "0x402A43A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_squadMenuObjectStatus;

		// Token: 0x0402A43B RID: 173115
		[Token(Token = "0x402A43B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_totemMenuObjectStatus;

		// Token: 0x0402A43C RID: 173116
		[Token(Token = "0x402A43C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_NotifyAdapterChanged;

		// Token: 0x0402A43D RID: 173117
		[Token(Token = "0x402A43D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
