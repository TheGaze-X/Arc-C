using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004039 RID: 16441
	[Token(Token = "0x2004039")]
	public class SandboxV2CharShowSelectLogic : SandboxV2SelectPluginLogic, IHotfixable
	{
		// Token: 0x0601970C RID: 104204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601970C")]
		[Address(RVA = "0x12205A0", Offset = "0x121F1A0", VA = "0x1812205A0", Slot = "10")]
		public void InitShuffleViewModel(SandboxV2ShuffleViewModel shuffleViewModel)
		{
		}

		// Token: 0x0601970D RID: 104205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601970D")]
		[Address(RVA = "0x1220620", Offset = "0x121F220", VA = "0x181220620", Slot = "4")]
		public void OnEnsure(SandboxV2CharListProperty property, Action onEnsure, Action dismissAction)
		{
		}

		// Token: 0x0601970E RID: 104206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601970E")]
		[Address(RVA = "0x12202F0", Offset = "0x121EEF0", VA = "0x1812202F0", Slot = "5")]
		public void HandlerClick(int instId, SandboxV2CharListProperty property)
		{
		}

		// Token: 0x0601970F RID: 104207 RVA: 0x0009E070 File Offset: 0x0009C270
		[Token(Token = "0x601970F")]
		[Address(RVA = "0x12206C0", Offset = "0x121F2C0", VA = "0x1812206C0", Slot = "6")]
		public bool ShuffleChar(SandboxV2CharViewModel viewModel, SandboxV2ShuffleViewModel shuffleViewModel)
		{
			return default(bool);
		}

		// Token: 0x06019710 RID: 104208 RVA: 0x0009E088 File Offset: 0x0009C288
		[Token(Token = "0x6019710")]
		[Address(RVA = "0x1220540", Offset = "0x121F140", VA = "0x181220540", Slot = "7")]
		public bool IfShowIndex()
		{
			return default(bool);
		}

		// Token: 0x06019711 RID: 104209 RVA: 0x0009E0A0 File Offset: 0x0009C2A0
		[Token(Token = "0x6019711")]
		[Address(RVA = "0x12204E0", Offset = "0x121F0E0", VA = "0x1812204E0", Slot = "9")]
		public bool IfFetchPlayerChar()
		{
			return default(bool);
		}

		// Token: 0x06019712 RID: 104210 RVA: 0x0009E0B8 File Offset: 0x0009C2B8
		[Token(Token = "0x6019712")]
		[Address(RVA = "0x12207E0", Offset = "0x121F3E0", VA = "0x1812207E0", Slot = "8")]
		public int SortRule(SandboxV2CharViewModel obj1, SandboxV2CharViewModel obj2)
		{
			return 0;
		}

		// Token: 0x06019713 RID: 104211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019713")]
		[Address(RVA = "0x1220880", Offset = "0x121F480", VA = "0x181220880")]
		public SandboxV2CharShowSelectLogic()
		{
		}

		// Token: 0x0401FB11 RID: 129809
		[Token(Token = "0x401FB11")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitShuffleViewModel;

		// Token: 0x0401FB12 RID: 129810
		[Token(Token = "0x401FB12")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnsure;

		// Token: 0x0401FB13 RID: 129811
		[Token(Token = "0x401FB13")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_HandlerClick;

		// Token: 0x0401FB14 RID: 129812
		[Token(Token = "0x401FB14")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ShuffleChar;

		// Token: 0x0401FB15 RID: 129813
		[Token(Token = "0x401FB15")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_IfShowIndex;

		// Token: 0x0401FB16 RID: 129814
		[Token(Token = "0x401FB16")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_IfFetchPlayerChar;

		// Token: 0x0401FB17 RID: 129815
		[Token(Token = "0x401FB17")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SortRule;

		// Token: 0x0401FB18 RID: 129816
		[Token(Token = "0x401FB18")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
