using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x0200585D RID: 22621
	[Token(Token = "0x200585D")]
	public class RL03TotemBuffBottomViewModel : IHotfixable
	{
		// Token: 0x17004D80 RID: 19840
		// (get) Token: 0x060210A3 RID: 135331 RVA: 0x000B8488 File Offset: 0x000B6688
		[Token(Token = "0x17004D80")]
		public bool showBottomView
		{
			[Token(Token = "0x60210A3")]
			[Address(RVA = "0x1B61980", Offset = "0x1B60580", VA = "0x181B61980")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004D81 RID: 19841
		// (get) Token: 0x060210A4 RID: 135332 RVA: 0x000B84A0 File Offset: 0x000B66A0
		[Token(Token = "0x17004D81")]
		public bool locationTotemValid
		{
			[Token(Token = "0x60210A4")]
			[Address(RVA = "0x1B61900", Offset = "0x1B60500", VA = "0x181B61900")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004D82 RID: 19842
		// (get) Token: 0x060210A5 RID: 135333 RVA: 0x000B84B8 File Offset: 0x000B66B8
		[Token(Token = "0x17004D82")]
		public bool effectTotemValid
		{
			[Token(Token = "0x60210A5")]
			[Address(RVA = "0x1B61770", Offset = "0x1B60370", VA = "0x181B61770")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004D83 RID: 19843
		// (get) Token: 0x060210A6 RID: 135334 RVA: 0x000B84D0 File Offset: 0x000B66D0
		[Token(Token = "0x17004D83")]
		public bool isSelectBossTotem
		{
			[Token(Token = "0x60210A6")]
			[Address(RVA = "0x1B617F0", Offset = "0x1B603F0", VA = "0x181B617F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004D84 RID: 19844
		// (get) Token: 0x060210A7 RID: 135335 RVA: 0x000B84E8 File Offset: 0x000B66E8
		[Token(Token = "0x17004D84")]
		public RoguelikeTotemColorType locationTotemColorType
		{
			[Token(Token = "0x60210A7")]
			[Address(RVA = "0x1B61880", Offset = "0x1B60480", VA = "0x181B61880")]
			get
			{
				return RoguelikeTotemColorType.NONE;
			}
		}

		// Token: 0x17004D85 RID: 19845
		// (get) Token: 0x060210A8 RID: 135336 RVA: 0x000B8500 File Offset: 0x000B6700
		[Token(Token = "0x17004D85")]
		public RoguelikeTotemColorType effectTotemColorType
		{
			[Token(Token = "0x60210A8")]
			[Address(RVA = "0x1B616F0", Offset = "0x1B602F0", VA = "0x181B616F0")]
			get
			{
				return RoguelikeTotemColorType.NONE;
			}
		}

		// Token: 0x060210A9 RID: 135337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60210A9")]
		[Address(RVA = "0x1B614D0", Offset = "0x1B600D0", VA = "0x181B614D0")]
		public void LoadData(string topicId, TotemViewShowType showType)
		{
		}

		// Token: 0x060210AA RID: 135338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60210AA")]
		[Address(RVA = "0x1B615E0", Offset = "0x1B601E0", VA = "0x181B615E0")]
		public void UpdateWholeBottomData(RL03TotemViewModel locationTotemViewModel, RL03TotemViewModel effectTotemViewModel, bool hasNodeSelected)
		{
		}

		// Token: 0x060210AB RID: 135339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60210AB")]
		[Address(RVA = "0x1B61570", Offset = "0x1B60170", VA = "0x181B61570")]
		public void UpdateMapNodeData(bool hasNodeSelected)
		{
		}

		// Token: 0x060210AC RID: 135340 RVA: 0x000B8518 File Offset: 0x000B6718
		[Token(Token = "0x60210AC")]
		[Address(RVA = "0x1B61440", Offset = "0x1B60040", VA = "0x181B61440")]
		public bool CheckIfTotemResonance()
		{
			return default(bool);
		}

		// Token: 0x060210AD RID: 135341 RVA: 0x000B8530 File Offset: 0x000B6730
		[Token(Token = "0x60210AD")]
		[Address(RVA = "0x1B613D0", Offset = "0x1B5FFD0", VA = "0x181B613D0")]
		public bool CheckIfSelectTotemValid()
		{
			return default(bool);
		}

		// Token: 0x060210AE RID: 135342 RVA: 0x000B8548 File Offset: 0x000B6748
		[Token(Token = "0x60210AE")]
		[Address(RVA = "0x1B61350", Offset = "0x1B5FF50", VA = "0x181B61350")]
		public bool CheckIfConfirmValid()
		{
			return default(bool);
		}

		// Token: 0x060210AF RID: 135343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60210AF")]
		[Address(RVA = "0x1B61690", Offset = "0x1B60290", VA = "0x181B61690")]
		public RL03TotemBuffBottomViewModel()
		{
		}

		// Token: 0x0402CF31 RID: 184113
		[Token(Token = "0x402CF31")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x0402CF32 RID: 184114
		[Token(Token = "0x402CF32")]
		[FieldOffset(Offset = "0x18")]
		public RL03TotemViewModel locationTotemViewModel;

		// Token: 0x0402CF33 RID: 184115
		[Token(Token = "0x402CF33")]
		[FieldOffset(Offset = "0x20")]
		public RL03TotemViewModel effectTotemViewModel;

		// Token: 0x0402CF34 RID: 184116
		[Token(Token = "0x402CF34")]
		[FieldOffset(Offset = "0x28")]
		public bool haveSelectNodes;

		// Token: 0x0402CF35 RID: 184117
		[Token(Token = "0x402CF35")]
		[FieldOffset(Offset = "0x2C")]
		private TotemViewShowType m_showType;

		// Token: 0x0402CF36 RID: 184118
		[Token(Token = "0x402CF36")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_showBottomView;

		// Token: 0x0402CF37 RID: 184119
		[Token(Token = "0x402CF37")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_locationTotemValid;

		// Token: 0x0402CF38 RID: 184120
		[Token(Token = "0x402CF38")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_effectTotemValid;

		// Token: 0x0402CF39 RID: 184121
		[Token(Token = "0x402CF39")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_isSelectBossTotem;

		// Token: 0x0402CF3A RID: 184122
		[Token(Token = "0x402CF3A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_locationTotemColorType;

		// Token: 0x0402CF3B RID: 184123
		[Token(Token = "0x402CF3B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_effectTotemColorType;

		// Token: 0x0402CF3C RID: 184124
		[Token(Token = "0x402CF3C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402CF3D RID: 184125
		[Token(Token = "0x402CF3D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_UpdateWholeBottomData;

		// Token: 0x0402CF3E RID: 184126
		[Token(Token = "0x402CF3E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_UpdateMapNodeData;

		// Token: 0x0402CF3F RID: 184127
		[Token(Token = "0x402CF3F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CheckIfTotemResonance;

		// Token: 0x0402CF40 RID: 184128
		[Token(Token = "0x402CF40")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_CheckIfSelectTotemValid;

		// Token: 0x0402CF41 RID: 184129
		[Token(Token = "0x402CF41")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_CheckIfConfirmValid;

		// Token: 0x0402CF42 RID: 184130
		[Token(Token = "0x402CF42")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
