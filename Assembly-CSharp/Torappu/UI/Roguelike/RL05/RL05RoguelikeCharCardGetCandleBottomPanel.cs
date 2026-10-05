using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x02005604 RID: 22020
	[Token(Token = "0x2005604")]
	public class RL05RoguelikeCharCardGetCandleBottomPanel : RoguelikeCharCardDecoPanelPluginBase
	{
		// Token: 0x17004BB0 RID: 19376
		// (get) Token: 0x0602050D RID: 132365 RVA: 0x000B5548 File Offset: 0x000B3748
		[Token(Token = "0x17004BB0")]
		public override RoguelikeCharCardDecoPanelPluginBase.DecoLayer decoLayer
		{
			[Token(Token = "0x602050D")]
			[Address(RVA = "0x1A6E7E0", Offset = "0x1A6D3E0", VA = "0x181A6E7E0", Slot = "4")]
			get
			{
				return RoguelikeCharCardDecoPanelPluginBase.DecoLayer.NONE;
			}
		}

		// Token: 0x0602050E RID: 132366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602050E")]
		[Address(RVA = "0x1A6E590", Offset = "0x1A6D190", VA = "0x181A6E590", Slot = "5")]
		public override void Render(string topicId, RoguelikeCharCardDecoPanelPluginBase.RoguelikeCharCardDecoInput decoInput)
		{
		}

		// Token: 0x0602050F RID: 132367 RVA: 0x000B5560 File Offset: 0x000B3760
		[Token(Token = "0x602050F")]
		[Address(RVA = "0x1A6E6C0", Offset = "0x1A6D2C0", VA = "0x181A6E6C0")]
		private bool _CheckPanelCanShow(string topicId, RoguelikeCharCardViewModel charCardViewModel)
		{
			return default(bool);
		}

		// Token: 0x06020510 RID: 132368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020510")]
		[Address(RVA = "0x1A6E780", Offset = "0x1A6D380", VA = "0x181A6E780")]
		public RL05RoguelikeCharCardGetCandleBottomPanel()
		{
		}

		// Token: 0x0402BBD2 RID: 179154
		[Token(Token = "0x402BBD2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelRoot;

		// Token: 0x0402BBD3 RID: 179155
		[Token(Token = "0x402BBD3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_decoLayer;

		// Token: 0x0402BBD4 RID: 179156
		[Token(Token = "0x402BBD4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402BBD5 RID: 179157
		[Token(Token = "0x402BBD5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CheckPanelCanShow;

		// Token: 0x0402BBD6 RID: 179158
		[Token(Token = "0x402BBD6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
