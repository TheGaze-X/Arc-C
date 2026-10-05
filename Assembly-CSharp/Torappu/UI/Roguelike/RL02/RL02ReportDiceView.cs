using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x0200574C RID: 22348
	[Token(Token = "0x200574C")]
	public class RL02ReportDiceView : RL02CommonReportView<RL02EndingFrameDiceReportViewModel>
	{
		// Token: 0x06020BF6 RID: 134134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020BF6")]
		[Address(RVA = "0x1B0A830", Offset = "0x1B09430", VA = "0x181B0A830")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06020BF7 RID: 134135 RVA: 0x000B7060 File Offset: 0x000B5260
		[Token(Token = "0x6020BF7")]
		[Address(RVA = "0x1B0A110", Offset = "0x1B08D10", VA = "0x181B0A110", Slot = "4")]
		public override RL02ReportController.ReportViewType GetViewType()
		{
			return RL02ReportController.ReportViewType.NONE;
		}

		// Token: 0x06020BF8 RID: 134136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020BF8")]
		[Address(RVA = "0x1B0A0A0", Offset = "0x1B08CA0", VA = "0x181B0A0A0", Slot = "7")]
		protected override string GetShowAnimName()
		{
			return null;
		}

		// Token: 0x06020BF9 RID: 134137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020BF9")]
		[Address(RVA = "0x1B0A170", Offset = "0x1B08D70", VA = "0x181B0A170", Slot = "8")]
		protected override void Render(RL02EndingFrameDiceReportViewModel viewModel)
		{
		}

		// Token: 0x06020BFA RID: 134138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020BFA")]
		[Address(RVA = "0x1B0A6D0", Offset = "0x1B092D0", VA = "0x181B0A6D0")]
		private string _FormatTextFromDiceResultInfo(RL02EndingFrameDiceReportViewModel viewModel, RL02EndingFrameDiceReportViewModel.DiceResultInfo resultInfo)
		{
			return null;
		}

		// Token: 0x06020BFB RID: 134139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020BFB")]
		[Address(RVA = "0x1B0AA00", Offset = "0x1B09600", VA = "0x181B0AA00")]
		public RL02ReportDiceView()
		{
		}

		// Token: 0x0402C74A RID: 182090
		[Token(Token = "0x402C74A")]
		private const string ENTER_ANIM_NAME = "report_dice";

		// Token: 0x0402C74B RID: 182091
		[Token(Token = "0x402C74B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAtlasObject _atlasObject;

		// Token: 0x0402C74C RID: 182092
		[Token(Token = "0x402C74C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RL02ReportDiceView.DiceResultItemView[] _resultViews;

		// Token: 0x0402C74D RID: 182093
		[Token(Token = "0x402C74D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RL02ReportDiceView.DiceAtlasConfig[] _atlasConfigs;

		// Token: 0x0402C74E RID: 182094
		[Token(Token = "0x402C74E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _textDiceDesc;

		// Token: 0x0402C74F RID: 182095
		[Token(Token = "0x402C74F")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _textGoodResult;

		// Token: 0x0402C750 RID: 182096
		[Token(Token = "0x402C750")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _textBadResult;

		// Token: 0x0402C751 RID: 182097
		[Token(Token = "0x402C751")]
		[FieldOffset(Offset = "0x88")]
		private bool m_inited;

		// Token: 0x0402C752 RID: 182098
		[Token(Token = "0x402C752")]
		[FieldOffset(Offset = "0x90")]
		private Dictionary<DiceResultClass, RL02ReportDiceView.DiceAtlasConfig> m_diceAtlasConfigs;

		// Token: 0x0402C753 RID: 182099
		[Token(Token = "0x402C753")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402C754 RID: 182100
		[Token(Token = "0x402C754")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetViewType;

		// Token: 0x0402C755 RID: 182101
		[Token(Token = "0x402C755")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetShowAnimName;

		// Token: 0x0402C756 RID: 182102
		[Token(Token = "0x402C756")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C757 RID: 182103
		[Token(Token = "0x402C757")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__FormatTextFromDiceResultInfo;

		// Token: 0x0402C758 RID: 182104
		[Token(Token = "0x402C758")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200574D RID: 22349
		[Token(Token = "0x200574D")]
		[Serializable]
		private class DiceResultItemView : IHotfixable
		{
			// Token: 0x06020BFC RID: 134140 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020BFC")]
			[Address(RVA = "0x1B04060", Offset = "0x1B02C60", VA = "0x181B04060")]
			public void Init(RL02ReportDiceView closure)
			{
			}

			// Token: 0x06020BFD RID: 134141 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020BFD")]
			[Address(RVA = "0x1B040E0", Offset = "0x1B02CE0", VA = "0x181B040E0")]
			public void Render(DiceResultClass resultClass, int count)
			{
			}

			// Token: 0x06020BFE RID: 134142 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020BFE")]
			[Address(RVA = "0x1B04290", Offset = "0x1B02E90", VA = "0x181B04290")]
			public DiceResultItemView()
			{
			}

			// Token: 0x0402C759 RID: 182105
			[Token(Token = "0x402C759")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private Text _textCount;

			// Token: 0x0402C75A RID: 182106
			[Token(Token = "0x402C75A")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private UIAtlasImage _resultImage;

			// Token: 0x0402C75B RID: 182107
			[Token(Token = "0x402C75B")]
			[FieldOffset(Offset = "0x20")]
			private RL02ReportDiceView m_closure;

			// Token: 0x0402C75C RID: 182108
			[Token(Token = "0x402C75C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Init;

			// Token: 0x0402C75D RID: 182109
			[Token(Token = "0x402C75D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Render;

			// Token: 0x0402C75E RID: 182110
			[Token(Token = "0x402C75E")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200574E RID: 22350
		[Token(Token = "0x200574E")]
		[Serializable]
		private struct DiceAtlasConfig
		{
			// Token: 0x0402C75F RID: 182111
			[Token(Token = "0x402C75F")]
			[FieldOffset(Offset = "0x0")]
			public DiceResultClass resultClass;

			// Token: 0x0402C760 RID: 182112
			[Token(Token = "0x402C760")]
			[FieldOffset(Offset = "0x8")]
			public string resultImageName;
		}
	}
}
