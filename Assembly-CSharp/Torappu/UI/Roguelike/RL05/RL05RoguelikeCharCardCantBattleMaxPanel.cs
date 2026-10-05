using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x02005603 RID: 22019
	[Token(Token = "0x2005603")]
	public class RL05RoguelikeCharCardCantBattleMaxPanel : RoguelikeCharCardDecoPanelPluginBase
	{
		// Token: 0x17004BAF RID: 19375
		// (get) Token: 0x06020509 RID: 132361 RVA: 0x000B5518 File Offset: 0x000B3718
		[Token(Token = "0x17004BAF")]
		public override RoguelikeCharCardDecoPanelPluginBase.DecoLayer decoLayer
		{
			[Token(Token = "0x6020509")]
			[Address(RVA = "0x1A6DB80", Offset = "0x1A6C780", VA = "0x181A6DB80", Slot = "4")]
			get
			{
				return RoguelikeCharCardDecoPanelPluginBase.DecoLayer.NONE;
			}
		}

		// Token: 0x0602050A RID: 132362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602050A")]
		[Address(RVA = "0x1A6D7D0", Offset = "0x1A6C3D0", VA = "0x181A6D7D0", Slot = "5")]
		public override void Render(string topicId, RoguelikeCharCardDecoPanelPluginBase.RoguelikeCharCardDecoInput decoInput)
		{
		}

		// Token: 0x0602050B RID: 132363 RVA: 0x000B5530 File Offset: 0x000B3730
		[Token(Token = "0x602050B")]
		[Address(RVA = "0x1A6D9F0", Offset = "0x1A6C5F0", VA = "0x181A6D9F0")]
		private bool _CheckIfTroopInstInExpedition(int troopInstId)
		{
			return default(bool);
		}

		// Token: 0x0602050C RID: 132364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602050C")]
		[Address(RVA = "0x1A6DB20", Offset = "0x1A6C720", VA = "0x181A6DB20")]
		public RL05RoguelikeCharCardCantBattleMaxPanel()
		{
		}

		// Token: 0x0402BBCD RID: 179149
		[Token(Token = "0x402BBCD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelRoot;

		// Token: 0x0402BBCE RID: 179150
		[Token(Token = "0x402BBCE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_decoLayer;

		// Token: 0x0402BBCF RID: 179151
		[Token(Token = "0x402BBCF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402BBD0 RID: 179152
		[Token(Token = "0x402BBD0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CheckIfTroopInstInExpedition;

		// Token: 0x0402BBD1 RID: 179153
		[Token(Token = "0x402BBD1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
