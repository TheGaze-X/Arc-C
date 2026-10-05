using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200415A RID: 16730
	[Token(Token = "0x200415A")]
	public class SandboxV2BasementView : DataBinder<SandboxV2DungeonProperty>
	{
		// Token: 0x06019D4E RID: 105806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D4E")]
		[Address(RVA = "0x12A8A20", Offset = "0x12A7620", VA = "0x1812A8A20")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019D4F RID: 105807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D4F")]
		[Address(RVA = "0x12A8770", Offset = "0x12A7370", VA = "0x1812A8770", Slot = "7")]
		public override void OnValueChanged(SandboxV2DungeonProperty property)
		{
		}

		// Token: 0x06019D50 RID: 105808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019D50")]
		[Address(RVA = "0x12A8960", Offset = "0x12A7560", VA = "0x1812A8960")]
		public GameObject TutorialOnly_GetStartBattleGo()
		{
			return null;
		}

		// Token: 0x06019D51 RID: 105809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D51")]
		[Address(RVA = "0x12A8AF0", Offset = "0x12A76F0", VA = "0x1812A8AF0")]
		public SandboxV2BasementView()
		{
		}

		// Token: 0x04020704 RID: 132868
		[Token(Token = "0x4020704")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SandboxV2BasementBuildingDetailView _buildingDetailView;

		// Token: 0x04020705 RID: 132869
		[Token(Token = "0x4020705")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SandboxV2BasementStatusView _basementStatusView;

		// Token: 0x04020706 RID: 132870
		[Token(Token = "0x4020706")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SandboxV2BasementStatusView _portableBasementStatusView;

		// Token: 0x04020707 RID: 132871
		[Token(Token = "0x4020707")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SandboxV2BasementStatusView _outpostStatusView;

		// Token: 0x04020708 RID: 132872
		[Token(Token = "0x4020708")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SandboxV2BasementMonthEntryBtnView _monthEntryBtnView;

		// Token: 0x04020709 RID: 132873
		[Token(Token = "0x4020709")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SandboxV2NodePreviewView _nodePreviewViewPrefab;

		// Token: 0x0402070A RID: 132874
		[Token(Token = "0x402070A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _nodePreviewViewHolder;

		// Token: 0x0402070B RID: 132875
		[Token(Token = "0x402070B")]
		[FieldOffset(Offset = "0x58")]
		private bool m_inited;

		// Token: 0x0402070C RID: 132876
		[Token(Token = "0x402070C")]
		[FieldOffset(Offset = "0x60")]
		private SandboxV2DungeonViewModel.SeqNumChecker m_nodeSelectChecker;

		// Token: 0x0402070D RID: 132877
		[Token(Token = "0x402070D")]
		[FieldOffset(Offset = "0x70")]
		private SandboxV2DungeonViewModel.SeqNumChecker m_dungeonDataChangeChecker;

		// Token: 0x0402070E RID: 132878
		[Token(Token = "0x402070E")]
		[FieldOffset(Offset = "0x80")]
		private SandboxV2NodePreviewView m_nodePreviewView;

		// Token: 0x0402070F RID: 132879
		[Token(Token = "0x402070F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04020710 RID: 132880
		[Token(Token = "0x4020710")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04020711 RID: 132881
		[Token(Token = "0x4020711")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_TutorialOnly_GetStartBattleGo;

		// Token: 0x04020712 RID: 132882
		[Token(Token = "0x4020712")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
