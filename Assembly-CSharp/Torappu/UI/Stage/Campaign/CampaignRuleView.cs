using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage.Campaign
{
	// Token: 0x02006A4C RID: 27212
	[Token(Token = "0x2006A4C")]
	public class CampaignRuleView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06026E4A RID: 159306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E4A")]
		[Address(RVA = "0x21E98F0", Offset = "0x21E84F0", VA = "0x1821E98F0")]
		public void RenderView(string stageId, CampaignStageType stageType)
		{
		}

		// Token: 0x06026E4B RID: 159307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E4B")]
		[Address(RVA = "0x21E99A0", Offset = "0x21E85A0", VA = "0x1821E99A0")]
		private void _UpdateCodeAndName(string stageId, CampaignStageType stageType)
		{
		}

		// Token: 0x06026E4C RID: 159308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E4C")]
		[Address(RVA = "0x21E9CC0", Offset = "0x21E88C0", VA = "0x1821E9CC0")]
		private void _UpdateLadderList(string stageId, CampaignStageType stageType)
		{
		}

		// Token: 0x06026E4D RID: 159309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E4D")]
		[Address(RVA = "0x21EA1A0", Offset = "0x21E8DA0", VA = "0x1821EA1A0")]
		public CampaignRuleView()
		{
		}

		// Token: 0x04036FFF RID: 225279
		[Token(Token = "0x4036FFF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textCode;

		// Token: 0x04037000 RID: 225280
		[Token(Token = "0x4037000")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textName;

		// Token: 0x04037001 RID: 225281
		[Token(Token = "0x4037001")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textStageType;

		// Token: 0x04037002 RID: 225282
		[Token(Token = "0x4037002")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textTip;

		// Token: 0x04037003 RID: 225283
		[Token(Token = "0x4037003")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CampaignLadderItemView _killCntItem;

		// Token: 0x04037004 RID: 225284
		[Token(Token = "0x4037004")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CampaignLadderItemView _apRetItem;

		// Token: 0x04037005 RID: 225285
		[Token(Token = "0x4037005")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CampaignLadderItemView _goldItem;

		// Token: 0x04037006 RID: 225286
		[Token(Token = "0x4037006")]
		[FieldOffset(Offset = "0x50")]
		private bool m_hasInited;

		// Token: 0x04037007 RID: 225287
		[Token(Token = "0x4037007")]
		[FieldOffset(Offset = "0x58")]
		private LadderItem m_killCntLadder;

		// Token: 0x04037008 RID: 225288
		[Token(Token = "0x4037008")]
		[FieldOffset(Offset = "0x60")]
		private LadderItem m_apRetLadder;

		// Token: 0x04037009 RID: 225289
		[Token(Token = "0x4037009")]
		[FieldOffset(Offset = "0x68")]
		private LadderItem m_diamondGainLadder;

		// Token: 0x0403700A RID: 225290
		[Token(Token = "0x403700A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x0403700B RID: 225291
		[Token(Token = "0x403700B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__UpdateCodeAndName;

		// Token: 0x0403700C RID: 225292
		[Token(Token = "0x403700C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateLadderList;

		// Token: 0x0403700D RID: 225293
		[Token(Token = "0x403700D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
