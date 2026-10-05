using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200403A RID: 16442
	[Token(Token = "0x200403A")]
	public class SandboxV2SelectMultiSquadPluginLogic : SandboxV2SelectPluginLogic, IHotfixable
	{
		// Token: 0x06019714 RID: 104212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019714")]
		[Address(RVA = "0x1222F40", Offset = "0x1221B40", VA = "0x181222F40", Slot = "10")]
		public void InitShuffleViewModel(SandboxV2ShuffleViewModel shuffleViewModel)
		{
		}

		// Token: 0x06019715 RID: 104213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019715")]
		[Address(RVA = "0x1222FC0", Offset = "0x1221BC0", VA = "0x181222FC0", Slot = "4")]
		public void OnEnsure(SandboxV2CharListProperty property, Action onEnsure, Action dismissAction)
		{
		}

		// Token: 0x06019716 RID: 104214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019716")]
		[Address(RVA = "0x1222C20", Offset = "0x1221820", VA = "0x181222C20", Slot = "5")]
		public void HandlerClick(int instId, SandboxV2CharListProperty property)
		{
		}

		// Token: 0x06019717 RID: 104215 RVA: 0x0009E0D0 File Offset: 0x0009C2D0
		[Token(Token = "0x6019717")]
		[Address(RVA = "0x1223060", Offset = "0x1221C60", VA = "0x181223060", Slot = "6")]
		public bool ShuffleChar(SandboxV2CharViewModel viewModel, SandboxV2ShuffleViewModel shuffleViewModel)
		{
			return default(bool);
		}

		// Token: 0x06019718 RID: 104216 RVA: 0x0009E0E8 File Offset: 0x0009C2E8
		[Token(Token = "0x6019718")]
		[Address(RVA = "0x1222EE0", Offset = "0x1221AE0", VA = "0x181222EE0", Slot = "7")]
		public bool IfShowIndex()
		{
			return default(bool);
		}

		// Token: 0x06019719 RID: 104217 RVA: 0x0009E100 File Offset: 0x0009C300
		[Token(Token = "0x6019719")]
		[Address(RVA = "0x1222E80", Offset = "0x1221A80", VA = "0x181222E80", Slot = "9")]
		public bool IfFetchPlayerChar()
		{
			return default(bool);
		}

		// Token: 0x0601971A RID: 104218 RVA: 0x0009E118 File Offset: 0x0009C318
		[Token(Token = "0x601971A")]
		[Address(RVA = "0x1223180", Offset = "0x1221D80", VA = "0x181223180", Slot = "8")]
		public int SortRule(SandboxV2CharViewModel obj1, SandboxV2CharViewModel obj2)
		{
			return 0;
		}

		// Token: 0x0601971B RID: 104219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601971B")]
		[Address(RVA = "0x1223630", Offset = "0x1222230", VA = "0x181223630")]
		public SandboxV2SelectMultiSquadPluginLogic()
		{
		}

		// Token: 0x0401FB19 RID: 129817
		[Token(Token = "0x401FB19")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitShuffleViewModel;

		// Token: 0x0401FB1A RID: 129818
		[Token(Token = "0x401FB1A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnsure;

		// Token: 0x0401FB1B RID: 129819
		[Token(Token = "0x401FB1B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_HandlerClick;

		// Token: 0x0401FB1C RID: 129820
		[Token(Token = "0x401FB1C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ShuffleChar;

		// Token: 0x0401FB1D RID: 129821
		[Token(Token = "0x401FB1D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_IfShowIndex;

		// Token: 0x0401FB1E RID: 129822
		[Token(Token = "0x401FB1E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_IfFetchPlayerChar;

		// Token: 0x0401FB1F RID: 129823
		[Token(Token = "0x401FB1F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SortRule;

		// Token: 0x0401FB20 RID: 129824
		[Token(Token = "0x401FB20")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
