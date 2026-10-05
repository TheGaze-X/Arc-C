using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044DD RID: 17629
	[Token(Token = "0x20044DD")]
	public class RoguelikeTopicMonthSquadDetailState : PopupFloatState
	{
		// Token: 0x0601AEB6 RID: 110262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601AEB6")]
		[Address(RVA = "0x1410CB0", Offset = "0x140F8B0", VA = "0x181410CB0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601AEB7 RID: 110263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AEB7")]
		[Address(RVA = "0x1411180", Offset = "0x140FD80", VA = "0x181411180")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601AEB8 RID: 110264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AEB8")]
		[Address(RVA = "0x1410D90", Offset = "0x140F990", VA = "0x181410D90", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601AEB9 RID: 110265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AEB9")]
		[Address(RVA = "0x1410D10", Offset = "0x140F910", VA = "0x181410D10")]
		public void OnBackClick()
		{
		}

		// Token: 0x0601AEBA RID: 110266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AEBA")]
		[Address(RVA = "0x14112A0", Offset = "0x140FEA0", VA = "0x1814112A0")]
		public RoguelikeTopicMonthSquadDetailState()
		{
		}

		// Token: 0x0601AEBB RID: 110267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AEBB")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0402283B RID: 141371
		[Token(Token = "0x402283B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RoguelikeTopicMonthSquadDetailView _monthSquadDetailView;

		// Token: 0x0402283C RID: 141372
		[Token(Token = "0x402283C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _backBtn;

		// Token: 0x0402283D RID: 141373
		[Token(Token = "0x402283D")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isInited;

		// Token: 0x0402283E RID: 141374
		[Token(Token = "0x402283E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402283F RID: 141375
		[Token(Token = "0x402283F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04022840 RID: 141376
		[Token(Token = "0x4022840")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04022841 RID: 141377
		[Token(Token = "0x4022841")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnBackClick;

		// Token: 0x04022842 RID: 141378
		[Token(Token = "0x4022842")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
