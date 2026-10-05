using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.BattleFinish;
using UnityEngine;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x02005904 RID: 22788
	[Token(Token = "0x2005904")]
	public class CrisisV2BattleFinishView : DynBattleFinishView, IHotfixable
	{
		// Token: 0x06021355 RID: 136021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021355")]
		[Address(RVA = "0x1B8C320", Offset = "0x1B8AF20", VA = "0x181B8C320", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x06021356 RID: 136022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021356")]
		[Address(RVA = "0x1B8DA90", Offset = "0x1B8C690", VA = "0x181B8DA90")]
		private void _OnClose()
		{
		}

		// Token: 0x06021357 RID: 136023 RVA: 0x000B8E18 File Offset: 0x000B7018
		[Token(Token = "0x6021357")]
		[Address(RVA = "0x1B8CF70", Offset = "0x1B8BB70", VA = "0x181B8CF70")]
		private bool _LoadResponseData(CrisisV2SettleViewModel.Param input, out string mapId)
		{
			return default(bool);
		}

		// Token: 0x06021358 RID: 136024 RVA: 0x000B8E30 File Offset: 0x000B7030
		[Token(Token = "0x6021358")]
		[Address(RVA = "0x1B8CCB0", Offset = "0x1B8B8B0", VA = "0x181B8CCB0")]
		private bool _LoadMapData(CrisisV2SettleViewModel.Param input, string mapId)
		{
			return default(bool);
		}

		// Token: 0x06021359 RID: 136025 RVA: 0x000B8E48 File Offset: 0x000B7048
		[Token(Token = "0x6021359")]
		[Address(RVA = "0x1B8D6B0", Offset = "0x1B8C2B0", VA = "0x181B8D6B0")]
		private bool _LoadSquadData(CrisisV2SettleViewModel.Param input)
		{
			return default(bool);
		}

		// Token: 0x0602135A RID: 136026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602135A")]
		[Address(RVA = "0x1B8C8F0", Offset = "0x1B8B4F0", VA = "0x181B8C8F0")]
		private Dictionary<string, CrisisV2CommentData> _GetCommentDict(string _mapId)
		{
			return null;
		}

		// Token: 0x0602135B RID: 136027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602135B")]
		[Address(RVA = "0x1B8C630", Offset = "0x1B8B230", VA = "0x181B8C630")]
		private void _AddDataToTempCommentList(List<string> commentIdList, bool isNewList, Dictionary<string, CrisisV2CommentData> commentDic, ref List<CrisisV2SettleCommentItemViewModel> tempCommentList)
		{
		}

		// Token: 0x0602135C RID: 136028 RVA: 0x000B8E60 File Offset: 0x000B7060
		[Token(Token = "0x602135C")]
		[Address(RVA = "0x1B8C9D0", Offset = "0x1B8B5D0", VA = "0x181B8C9D0")]
		private bool _LoadCommentsByResponse(CrisisV2BattleFinishResponse response, string mapId, ref List<CrisisV2SettleCommentItemViewModel> commentList)
		{
			return default(bool);
		}

		// Token: 0x0602135D RID: 136029 RVA: 0x000B8E78 File Offset: 0x000B7078
		[Token(Token = "0x602135D")]
		[Address(RVA = "0x1B8D260", Offset = "0x1B8BE60", VA = "0x181B8D260")]
		private bool _LoadRuneDataByResponse(CrisisV2BattleFinishResponse response, string mapId, ref List<CrisisV2SettleRuneItemViewModel> runeList)
		{
			return default(bool);
		}

		// Token: 0x0602135E RID: 136030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602135E")]
		[Address(RVA = "0x1B8DAF0", Offset = "0x1B8C6F0", VA = "0x181B8DAF0")]
		public CrisisV2BattleFinishView()
		{
		}

		// Token: 0x0402D3BD RID: 185277
		[Token(Token = "0x402D3BD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CrisisV2SettleView _viewPrefab;

		// Token: 0x0402D3BE RID: 185278
		[Token(Token = "0x402D3BE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _container;

		// Token: 0x0402D3BF RID: 185279
		[Token(Token = "0x402D3BF")]
		[FieldOffset(Offset = "0x30")]
		private CrisisV2SettleView m_settleView;

		// Token: 0x0402D3C0 RID: 185280
		[Token(Token = "0x402D3C0")]
		[FieldOffset(Offset = "0x38")]
		private CrisisV2CacheServerData m_crisisV2ServerData;

		// Token: 0x0402D3C1 RID: 185281
		[Token(Token = "0x402D3C1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0402D3C2 RID: 185282
		[Token(Token = "0x402D3C2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnClose;

		// Token: 0x0402D3C3 RID: 185283
		[Token(Token = "0x402D3C3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadResponseData;

		// Token: 0x0402D3C4 RID: 185284
		[Token(Token = "0x402D3C4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LoadMapData;

		// Token: 0x0402D3C5 RID: 185285
		[Token(Token = "0x402D3C5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__LoadSquadData;

		// Token: 0x0402D3C6 RID: 185286
		[Token(Token = "0x402D3C6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetCommentDict;

		// Token: 0x0402D3C7 RID: 185287
		[Token(Token = "0x402D3C7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__AddDataToTempCommentList;

		// Token: 0x0402D3C8 RID: 185288
		[Token(Token = "0x402D3C8")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__LoadCommentsByResponse;

		// Token: 0x0402D3C9 RID: 185289
		[Token(Token = "0x402D3C9")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__LoadRuneDataByResponse;

		// Token: 0x0402D3CA RID: 185290
		[Token(Token = "0x402D3CA")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
