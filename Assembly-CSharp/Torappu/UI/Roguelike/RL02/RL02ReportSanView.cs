using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x0200575D RID: 22365
	[Token(Token = "0x200575D")]
	public class RL02ReportSanView : RL02CommonReportView<RL02EndingFrameSanReportViewModel>
	{
		// Token: 0x06020C29 RID: 134185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020C29")]
		[Address(RVA = "0x1B25FA0", Offset = "0x1B24BA0", VA = "0x181B25FA0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06020C2A RID: 134186 RVA: 0x000B7108 File Offset: 0x000B5308
		[Token(Token = "0x6020C2A")]
		[Address(RVA = "0x1B25D60", Offset = "0x1B24960", VA = "0x181B25D60", Slot = "4")]
		public override RL02ReportController.ReportViewType GetViewType()
		{
			return RL02ReportController.ReportViewType.NONE;
		}

		// Token: 0x06020C2B RID: 134187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020C2B")]
		[Address(RVA = "0x1B25CF0", Offset = "0x1B248F0", VA = "0x181B25CF0", Slot = "7")]
		protected override string GetShowAnimName()
		{
			return null;
		}

		// Token: 0x06020C2C RID: 134188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020C2C")]
		[Address(RVA = "0x1B25DC0", Offset = "0x1B249C0", VA = "0x181B25DC0", Slot = "8")]
		protected override void Render(RL02EndingFrameSanReportViewModel viewModel)
		{
		}

		// Token: 0x06020C2D RID: 134189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020C2D")]
		[Address(RVA = "0x1B261A0", Offset = "0x1B24DA0", VA = "0x181B261A0")]
		public RL02ReportSanView()
		{
		}

		// Token: 0x0402C7AD RID: 182189
		[Token(Token = "0x402C7AD")]
		private const string ENTER_ANIM_NAME = "report_san";

		// Token: 0x0402C7AE RID: 182190
		[Token(Token = "0x402C7AE")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAtlasObject _atlasObject;

		// Token: 0x0402C7AF RID: 182191
		[Token(Token = "0x402C7AF")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RL02ReportSanView.ZoneSanView[] _zoneSanViews;

		// Token: 0x0402C7B0 RID: 182192
		[Token(Token = "0x402C7B0")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RL02ReportSanView.ZoneAtlasConfig[] _zoneAtlasConfigs;

		// Token: 0x0402C7B1 RID: 182193
		[Token(Token = "0x402C7B1")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _sanResultDesc;

		// Token: 0x0402C7B2 RID: 182194
		[Token(Token = "0x402C7B2")]
		[FieldOffset(Offset = "0x78")]
		private bool m_inited;

		// Token: 0x0402C7B3 RID: 182195
		[Token(Token = "0x402C7B3")]
		[FieldOffset(Offset = "0x80")]
		private Dictionary<string, RL02ReportSanView.ZoneAtlasConfig> m_zoneAtlasConfigs;

		// Token: 0x0402C7B4 RID: 182196
		[Token(Token = "0x402C7B4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402C7B5 RID: 182197
		[Token(Token = "0x402C7B5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetViewType;

		// Token: 0x0402C7B6 RID: 182198
		[Token(Token = "0x402C7B6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetShowAnimName;

		// Token: 0x0402C7B7 RID: 182199
		[Token(Token = "0x402C7B7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C7B8 RID: 182200
		[Token(Token = "0x402C7B8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200575E RID: 22366
		[Token(Token = "0x200575E")]
		[Serializable]
		private class ZoneSanView : IHotfixable
		{
			// Token: 0x06020C2E RID: 134190 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020C2E")]
			[Address(RVA = "0x1B2DA10", Offset = "0x1B2C610", VA = "0x181B2DA10")]
			public void Init(RL02ReportSanView closure)
			{
			}

			// Token: 0x06020C2F RID: 134191 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020C2F")]
			[Address(RVA = "0x1B2DAA0", Offset = "0x1B2C6A0", VA = "0x181B2DAA0")]
			public void Render(RL02EndingFrameSanReportViewModel.ZoneSanInfo sanInfo)
			{
			}

			// Token: 0x06020C30 RID: 134192 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020C30")]
			[Address(RVA = "0x1B2DFA0", Offset = "0x1B2CBA0", VA = "0x181B2DFA0")]
			public ZoneSanView()
			{
			}

			// Token: 0x0402C7B9 RID: 182201
			[Token(Token = "0x402C7B9")]
			[FieldOffset(Offset = "0x0")]
			private static Color COLOR_SAN_FULL;

			// Token: 0x0402C7BA RID: 182202
			[Token(Token = "0x402C7BA")]
			[FieldOffset(Offset = "0x10")]
			private static Color COLOR_SAN_EMPTY;

			// Token: 0x0402C7BB RID: 182203
			[Token(Token = "0x402C7BB")]
			[FieldOffset(Offset = "0x20")]
			private static Color COLOR_SAN_TEXT_EMPTY;

			// Token: 0x0402C7BC RID: 182204
			[Token(Token = "0x402C7BC")]
			[FieldOffset(Offset = "0x30")]
			private static Color COLOR_SAN_TEXT_NORMAL;

			// Token: 0x0402C7BD RID: 182205
			[Token(Token = "0x402C7BD")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private GameObject _pnlRoot;

			// Token: 0x0402C7BE RID: 182206
			[Token(Token = "0x402C7BE")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Text _textSan;

			// Token: 0x0402C7BF RID: 182207
			[Token(Token = "0x402C7BF")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Text _textZone;

			// Token: 0x0402C7C0 RID: 182208
			[Token(Token = "0x402C7C0")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private UIAtlasImage _atlasLayerIcon;

			// Token: 0x0402C7C1 RID: 182209
			[Token(Token = "0x402C7C1")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private UIAtlasImage _atlasLayerDot;

			// Token: 0x0402C7C2 RID: 182210
			[Token(Token = "0x402C7C2")]
			[FieldOffset(Offset = "0x38")]
			[SerializeField]
			private UIAtlasImage _imgLight;

			// Token: 0x0402C7C3 RID: 182211
			[Token(Token = "0x402C7C3")]
			[FieldOffset(Offset = "0x40")]
			private RL02ReportSanView m_closure;

			// Token: 0x0402C7C4 RID: 182212
			[Token(Token = "0x402C7C4")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_Init;

			// Token: 0x0402C7C5 RID: 182213
			[Token(Token = "0x402C7C5")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_Render;

			// Token: 0x0402C7C6 RID: 182214
			[Token(Token = "0x402C7C6")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200575F RID: 22367
		[Token(Token = "0x200575F")]
		[Serializable]
		private struct ZoneAtlasConfig
		{
			// Token: 0x0402C7C7 RID: 182215
			[Token(Token = "0x402C7C7")]
			[FieldOffset(Offset = "0x0")]
			public string zoneId;

			// Token: 0x0402C7C8 RID: 182216
			[Token(Token = "0x402C7C8")]
			[FieldOffset(Offset = "0x8")]
			public string zoneLayerIconNum;

			// Token: 0x0402C7C9 RID: 182217
			[Token(Token = "0x402C7C9")]
			[FieldOffset(Offset = "0x10")]
			public string zoneLayerDotNum;
		}
	}
}
