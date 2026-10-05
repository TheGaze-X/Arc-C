using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200403B RID: 16443
	[Token(Token = "0x200403B")]
	public class SandboxV2SelectExpeditionPluginLogic : SandboxV2SelectPluginLogic, IHotfixable
	{
		// Token: 0x0601971C RID: 104220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601971C")]
		[Address(RVA = "0x1221B40", Offset = "0x1220740", VA = "0x181221B40", Slot = "10")]
		public void InitShuffleViewModel(SandboxV2ShuffleViewModel shuffleViewModel)
		{
		}

		// Token: 0x0601971D RID: 104221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601971D")]
		[Address(RVA = "0x1222330", Offset = "0x1220F30", VA = "0x181222330")]
		private void _HandleExpeditionService(string topicId, SandboxV2AdminCharSelectStateBean.ExpeditionOption expeditionOption, List<int> charInstIds, Action onEnsure)
		{
		}

		// Token: 0x0601971E RID: 104222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601971E")]
		[Address(RVA = "0x12229B0", Offset = "0x12215B0", VA = "0x1812229B0")]
		private void _OpenSecondaryPage(string topicId)
		{
		}

		// Token: 0x0601971F RID: 104223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601971F")]
		[Address(RVA = "0x1222680", Offset = "0x1221280", VA = "0x181222680")]
		private void _OpenDialog(string topicId)
		{
		}

		// Token: 0x06019720 RID: 104224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019720")]
		[Address(RVA = "0x1221BC0", Offset = "0x12207C0", VA = "0x181221BC0", Slot = "4")]
		public void OnEnsure(SandboxV2CharListProperty property, Action onEnsure, Action dismissAction)
		{
		}

		// Token: 0x06019721 RID: 104225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019721")]
		[Address(RVA = "0x1221830", Offset = "0x1220430", VA = "0x181221830", Slot = "5")]
		public void HandlerClick(int instId, SandboxV2CharListProperty property)
		{
		}

		// Token: 0x06019722 RID: 104226 RVA: 0x0009E130 File Offset: 0x0009C330
		[Token(Token = "0x6019722")]
		[Address(RVA = "0x1221E40", Offset = "0x1220A40", VA = "0x181221E40", Slot = "6")]
		public bool ShuffleChar(SandboxV2CharViewModel viewModel, SandboxV2ShuffleViewModel shuffleViewModel)
		{
			return default(bool);
		}

		// Token: 0x06019723 RID: 104227 RVA: 0x0009E148 File Offset: 0x0009C348
		[Token(Token = "0x6019723")]
		[Address(RVA = "0x1221AE0", Offset = "0x12206E0", VA = "0x181221AE0", Slot = "7")]
		public bool IfShowIndex()
		{
			return default(bool);
		}

		// Token: 0x06019724 RID: 104228 RVA: 0x0009E160 File Offset: 0x0009C360
		[Token(Token = "0x6019724")]
		[Address(RVA = "0x1221A80", Offset = "0x1220680", VA = "0x181221A80", Slot = "9")]
		public bool IfFetchPlayerChar()
		{
			return default(bool);
		}

		// Token: 0x06019725 RID: 104229 RVA: 0x0009E178 File Offset: 0x0009C378
		[Token(Token = "0x6019725")]
		[Address(RVA = "0x1221F10", Offset = "0x1220B10", VA = "0x181221F10", Slot = "8")]
		public int SortRule(SandboxV2CharViewModel obj1, SandboxV2CharViewModel obj2)
		{
			return 0;
		}

		// Token: 0x06019726 RID: 104230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019726")]
		[Address(RVA = "0x1222BC0", Offset = "0x12217C0", VA = "0x181222BC0")]
		public SandboxV2SelectExpeditionPluginLogic()
		{
		}

		// Token: 0x0401FB21 RID: 129825
		[Token(Token = "0x401FB21")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitShuffleViewModel;

		// Token: 0x0401FB22 RID: 129826
		[Token(Token = "0x401FB22")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__HandleExpeditionService;

		// Token: 0x0401FB23 RID: 129827
		[Token(Token = "0x401FB23")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OpenSecondaryPage;

		// Token: 0x0401FB24 RID: 129828
		[Token(Token = "0x401FB24")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OpenDialog;

		// Token: 0x0401FB25 RID: 129829
		[Token(Token = "0x401FB25")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnEnsure;

		// Token: 0x0401FB26 RID: 129830
		[Token(Token = "0x401FB26")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_HandlerClick;

		// Token: 0x0401FB27 RID: 129831
		[Token(Token = "0x401FB27")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ShuffleChar;

		// Token: 0x0401FB28 RID: 129832
		[Token(Token = "0x401FB28")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_IfShowIndex;

		// Token: 0x0401FB29 RID: 129833
		[Token(Token = "0x401FB29")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_IfFetchPlayerChar;

		// Token: 0x0401FB2A RID: 129834
		[Token(Token = "0x401FB2A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_SortRule;

		// Token: 0x0401FB2B RID: 129835
		[Token(Token = "0x401FB2B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
