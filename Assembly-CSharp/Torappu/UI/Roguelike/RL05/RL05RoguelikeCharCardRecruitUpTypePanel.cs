using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x02005605 RID: 22021
	[Token(Token = "0x2005605")]
	public class RL05RoguelikeCharCardRecruitUpTypePanel : RoguelikeCharCardDecoPanelPluginBase
	{
		// Token: 0x17004BB1 RID: 19377
		// (get) Token: 0x06020511 RID: 132369 RVA: 0x000B5578 File Offset: 0x000B3778
		[Token(Token = "0x17004BB1")]
		public override RoguelikeCharCardDecoPanelPluginBase.DecoLayer decoLayer
		{
			[Token(Token = "0x6020511")]
			[Address(RVA = "0x1A6EC10", Offset = "0x1A6D810", VA = "0x181A6EC10", Slot = "4")]
			get
			{
				return RoguelikeCharCardDecoPanelPluginBase.DecoLayer.NONE;
			}
		}

		// Token: 0x06020512 RID: 132370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020512")]
		[Address(RVA = "0x1A6E840", Offset = "0x1A6D440", VA = "0x181A6E840", Slot = "5")]
		public override void Render(string topicId, RoguelikeCharCardDecoPanelPluginBase.RoguelikeCharCardDecoInput decoInput)
		{
		}

		// Token: 0x06020513 RID: 132371 RVA: 0x000B5590 File Offset: 0x000B3790
		[Token(Token = "0x6020513")]
		[Address(RVA = "0x1A6E9A0", Offset = "0x1A6D5A0", VA = "0x181A6E9A0")]
		private bool _NeedOverrideUpText(string topicId, RoguelikeCharCardViewModel charCardViewModel, out string upTypeText, out bool isNeedShowBg)
		{
			return default(bool);
		}

		// Token: 0x06020514 RID: 132372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020514")]
		[Address(RVA = "0x1A6EBB0", Offset = "0x1A6D7B0", VA = "0x181A6EBB0")]
		public RL05RoguelikeCharCardRecruitUpTypePanel()
		{
		}

		// Token: 0x0402BBD7 RID: 179159
		[Token(Token = "0x402BBD7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelRoot;

		// Token: 0x0402BBD8 RID: 179160
		[Token(Token = "0x402BBD8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelGetCandleBg;

		// Token: 0x0402BBD9 RID: 179161
		[Token(Token = "0x402BBD9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textUpType;

		// Token: 0x0402BBDA RID: 179162
		[Token(Token = "0x402BBDA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_decoLayer;

		// Token: 0x0402BBDB RID: 179163
		[Token(Token = "0x402BBDB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402BBDC RID: 179164
		[Token(Token = "0x402BBDC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__NeedOverrideUpText;

		// Token: 0x0402BBDD RID: 179165
		[Token(Token = "0x402BBDD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
