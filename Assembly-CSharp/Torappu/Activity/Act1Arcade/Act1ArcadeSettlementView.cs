using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.BattleFinish;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x0200795E RID: 31070
	[Token(Token = "0x200795E")]
	public class Act1ArcadeSettlementView : DynBattleFinishView
	{
		// Token: 0x0602B96E RID: 178542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B96E")]
		[Address(RVA = "0x2784E80", Offset = "0x2783A80", VA = "0x182784E80")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602B96F RID: 178543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B96F")]
		[Address(RVA = "0x2784D50", Offset = "0x2783950", VA = "0x182784D50", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x0602B970 RID: 178544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B970")]
		[Address(RVA = "0x2784DD0", Offset = "0x27839D0", VA = "0x182784DD0", Slot = "7")]
		public override IEnumerator ShowEnterEffectCoroutine()
		{
			return null;
		}

		// Token: 0x0602B971 RID: 178545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B971")]
		[Address(RVA = "0x27851D0", Offset = "0x2783DD0", VA = "0x1827851D0")]
		private void _InternalChangeViewStatus()
		{
		}

		// Token: 0x0602B972 RID: 178546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B972")]
		[Address(RVA = "0x2785470", Offset = "0x2784070", VA = "0x182785470")]
		private void _OnCloseClick()
		{
		}

		// Token: 0x0602B973 RID: 178547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B973")]
		[Address(RVA = "0x27854D0", Offset = "0x27840D0", VA = "0x1827854D0")]
		public Act1ArcadeSettlementView()
		{
		}

		// Token: 0x0602B974 RID: 178548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B974")]
		[Address(RVA = "0x17E4700", Offset = "0x17E3300", VA = "0x1817E4700")]
		private IEnumerator <>xLuaBaseProxy_ShowEnterEffectCoroutine()
		{
			return null;
		}

		// Token: 0x0403F0DB RID: 258267
		[Token(Token = "0x403F0DB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<Act1ArcadeSettlementStatusBaseView> _statusViews;

		// Token: 0x0403F0DC RID: 258268
		[Token(Token = "0x403F0DC")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isInited;

		// Token: 0x0403F0DD RID: 258269
		[Token(Token = "0x403F0DD")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<string, Act1ArcadeSettlementStatusBaseView> m_statusViewDict;

		// Token: 0x0403F0DE RID: 258270
		[Token(Token = "0x403F0DE")]
		[FieldOffset(Offset = "0x38")]
		private Act1ArcadeSettlementStatusBaseView m_currentStatusView;

		// Token: 0x0403F0DF RID: 258271
		[Token(Token = "0x403F0DF")]
		[FieldOffset(Offset = "0x40")]
		private Act1ArcadeSettlementModel m_model;

		// Token: 0x0403F0E0 RID: 258272
		[Token(Token = "0x403F0E0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403F0E1 RID: 258273
		[Token(Token = "0x403F0E1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0403F0E2 RID: 258274
		[Token(Token = "0x403F0E2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ShowEnterEffectCoroutine;

		// Token: 0x0403F0E3 RID: 258275
		[Token(Token = "0x403F0E3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InternalChangeViewStatus;

		// Token: 0x0403F0E4 RID: 258276
		[Token(Token = "0x403F0E4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnCloseClick;

		// Token: 0x0403F0E5 RID: 258277
		[Token(Token = "0x403F0E5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
