using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004041 RID: 16449
	[Token(Token = "0x2004041")]
	public class SandboxV2SelectSingleSquadPluginLogic : SandboxV2SelectPluginLogic, IHotfixable
	{
		// Token: 0x0601973D RID: 104253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601973D")]
		[Address(RVA = "0x1240AC0", Offset = "0x123F6C0", VA = "0x181240AC0", Slot = "10")]
		public void InitShuffleViewModel(SandboxV2ShuffleViewModel shuffleViewModel)
		{
		}

		// Token: 0x0601973E RID: 104254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601973E")]
		[Address(RVA = "0x1240B40", Offset = "0x123F740", VA = "0x181240B40", Slot = "4")]
		public void OnEnsure(SandboxV2CharListProperty property, Action onEnsure, Action dismissAction)
		{
		}

		// Token: 0x0601973F RID: 104255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601973F")]
		[Address(RVA = "0x12407F0", Offset = "0x123F3F0", VA = "0x1812407F0", Slot = "5")]
		public void HandlerClick(int instId, SandboxV2CharListProperty property)
		{
		}

		// Token: 0x06019740 RID: 104256 RVA: 0x0009E1F0 File Offset: 0x0009C3F0
		[Token(Token = "0x6019740")]
		[Address(RVA = "0x1240BE0", Offset = "0x123F7E0", VA = "0x181240BE0", Slot = "6")]
		public bool ShuffleChar(SandboxV2CharViewModel viewModel, SandboxV2ShuffleViewModel shuffleViewModel)
		{
			return default(bool);
		}

		// Token: 0x06019741 RID: 104257 RVA: 0x0009E208 File Offset: 0x0009C408
		[Token(Token = "0x6019741")]
		[Address(RVA = "0x1240A60", Offset = "0x123F660", VA = "0x181240A60", Slot = "7")]
		public bool IfShowIndex()
		{
			return default(bool);
		}

		// Token: 0x06019742 RID: 104258 RVA: 0x0009E220 File Offset: 0x0009C420
		[Token(Token = "0x6019742")]
		[Address(RVA = "0x1240A00", Offset = "0x123F600", VA = "0x181240A00", Slot = "9")]
		public bool IfFetchPlayerChar()
		{
			return default(bool);
		}

		// Token: 0x06019743 RID: 104259 RVA: 0x0009E238 File Offset: 0x0009C438
		[Token(Token = "0x6019743")]
		[Address(RVA = "0x1240D00", Offset = "0x123F900", VA = "0x181240D00", Slot = "8")]
		public int SortRule(SandboxV2CharViewModel obj1, SandboxV2CharViewModel obj2)
		{
			return 0;
		}

		// Token: 0x06019744 RID: 104260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019744")]
		[Address(RVA = "0x1241190", Offset = "0x123FD90", VA = "0x181241190")]
		public SandboxV2SelectSingleSquadPluginLogic()
		{
		}

		// Token: 0x0401FB3A RID: 129850
		[Token(Token = "0x401FB3A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitShuffleViewModel;

		// Token: 0x0401FB3B RID: 129851
		[Token(Token = "0x401FB3B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnsure;

		// Token: 0x0401FB3C RID: 129852
		[Token(Token = "0x401FB3C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_HandlerClick;

		// Token: 0x0401FB3D RID: 129853
		[Token(Token = "0x401FB3D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ShuffleChar;

		// Token: 0x0401FB3E RID: 129854
		[Token(Token = "0x401FB3E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_IfShowIndex;

		// Token: 0x0401FB3F RID: 129855
		[Token(Token = "0x401FB3F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_IfFetchPlayerChar;

		// Token: 0x0401FB40 RID: 129856
		[Token(Token = "0x401FB40")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SortRule;

		// Token: 0x0401FB41 RID: 129857
		[Token(Token = "0x401FB41")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
