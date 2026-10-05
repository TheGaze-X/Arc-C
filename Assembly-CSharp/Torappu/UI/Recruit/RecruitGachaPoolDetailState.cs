using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x020046EE RID: 18158
	[Token(Token = "0x20046EE")]
	public class RecruitGachaPoolDetailState : PopupFloatState
	{
		// Token: 0x0601B880 RID: 112768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B880")]
		[Address(RVA = "0x14E02D0", Offset = "0x14DEED0", VA = "0x1814E02D0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601B881 RID: 112769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B881")]
		[Address(RVA = "0x14E0330", Offset = "0x14DEF30", VA = "0x1814E0330")]
		private void InitIfNot()
		{
		}

		// Token: 0x0601B882 RID: 112770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B882")]
		[Address(RVA = "0x14E04F0", Offset = "0x14DF0F0", VA = "0x1814E04F0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601B883 RID: 112771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B883")]
		[Address(RVA = "0x14E08F0", Offset = "0x14DF4F0", VA = "0x1814E08F0")]
		private void SendGetDetailRequest(string gachaPoolId, GachaDetailData.GachaObjGroupType usingGroupType = GachaDetailData.GachaObjGroupType.ALL)
		{
		}

		// Token: 0x0601B884 RID: 112772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B884")]
		[Address(RVA = "0x14E0010", Offset = "0x14DEC10", VA = "0x1814E0010")]
		public void EventOnBtnRecordClick()
		{
		}

		// Token: 0x0601B885 RID: 112773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B885")]
		[Address(RVA = "0x14E0B50", Offset = "0x14DF750", VA = "0x1814E0B50")]
		public RecruitGachaPoolDetailState()
		{
		}

		// Token: 0x0601B886 RID: 112774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B886")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x04023AA9 RID: 146089
		[Token(Token = "0x4023AA9")]
		private const string GACHA_LOG_QUERY_KEY = "pool_id";

		// Token: 0x04023AAA RID: 146090
		[Token(Token = "0x4023AAA")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RecruitGachaPoolDetailStateBean _stateBean;

		// Token: 0x04023AAB RID: 146091
		[Token(Token = "0x4023AAB")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Transform _holderContainer;

		// Token: 0x04023AAC RID: 146092
		[Token(Token = "0x4023AAC")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _btnGachaLogGo;

		// Token: 0x04023AAD RID: 146093
		[Token(Token = "0x4023AAD")]
		[FieldOffset(Offset = "0x88")]
		private RecruitGachaPoolDetailHolder m_holder;

		// Token: 0x04023AAE RID: 146094
		[Token(Token = "0x4023AAE")]
		[FieldOffset(Offset = "0x90")]
		private bool m_isInited;

		// Token: 0x04023AAF RID: 146095
		[Token(Token = "0x4023AAF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04023AB0 RID: 146096
		[Token(Token = "0x4023AB0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitIfNot;

		// Token: 0x04023AB1 RID: 146097
		[Token(Token = "0x4023AB1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04023AB2 RID: 146098
		[Token(Token = "0x4023AB2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SendGetDetailRequest;

		// Token: 0x04023AB3 RID: 146099
		[Token(Token = "0x4023AB3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnBtnRecordClick;

		// Token: 0x04023AB4 RID: 146100
		[Token(Token = "0x4023AB4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
