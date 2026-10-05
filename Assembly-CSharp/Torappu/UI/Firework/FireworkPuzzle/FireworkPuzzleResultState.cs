using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Firework.FireworkPuzzle
{
	// Token: 0x02004E72 RID: 20082
	[Token(Token = "0x2004E72")]
	public class FireworkPuzzleResultState : PopupFadeState
	{
		// Token: 0x0601DF8B RID: 122763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DF8B")]
		[Address(RVA = "0x17ACD70", Offset = "0x17AB970", VA = "0x1817ACD70", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601DF8C RID: 122764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF8C")]
		[Address(RVA = "0x17ACDD0", Offset = "0x17AB9D0", VA = "0x1817ACDD0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601DF8D RID: 122765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF8D")]
		[Address(RVA = "0x17AD7E0", Offset = "0x17AC3E0", VA = "0x1817AD7E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601DF8E RID: 122766 RVA: 0x000AD0E8 File Offset: 0x000AB2E8
		[Token(Token = "0x601DF8E")]
		[Address(RVA = "0x17AD900", Offset = "0x17AC500", VA = "0x1817AD900")]
		private bool _IsUIStable()
		{
			return default(bool);
		}

		// Token: 0x0601DF8F RID: 122767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF8F")]
		[Address(RVA = "0x17AD470", Offset = "0x17AC070", VA = "0x1817AD470")]
		private void _CloseResult()
		{
		}

		// Token: 0x0601DF90 RID: 122768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DF90")]
		[Address(RVA = "0x17AD9C0", Offset = "0x17AC5C0", VA = "0x1817AD9C0")]
		private IEnumerator _ReceiveItemCoroutine(List<RewardItemModel> rewardList)
		{
			return null;
		}

		// Token: 0x0601DF91 RID: 122769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF91")]
		[Address(RVA = "0x17ACD10", Offset = "0x17AB910", VA = "0x1817ACD10")]
		public void EventOnBtnClose()
		{
		}

		// Token: 0x0601DF92 RID: 122770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF92")]
		[Address(RVA = "0x17ADA70", Offset = "0x17AC670", VA = "0x1817ADA70")]
		public FireworkPuzzleResultState()
		{
		}

		// Token: 0x0601DF93 RID: 122771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF93")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x04027CDD RID: 163037
		[Token(Token = "0x4027CDD")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private FireworkPuzzleResultView _view;

		// Token: 0x04027CDE RID: 163038
		[Token(Token = "0x4027CDE")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _backTrans;

		// Token: 0x04027CDF RID: 163039
		[Token(Token = "0x4027CDF")]
		[FieldOffset(Offset = "0x80")]
		private FireworkPuzzleResultStateBean m_stateBean;

		// Token: 0x04027CE0 RID: 163040
		[Token(Token = "0x4027CE0")]
		[FieldOffset(Offset = "0x88")]
		private bool m_hasInited;

		// Token: 0x04027CE1 RID: 163041
		[Token(Token = "0x4027CE1")]
		[FieldOffset(Offset = "0x90")]
		private FireworkPuzzlePage m_page;

		// Token: 0x04027CE2 RID: 163042
		[Token(Token = "0x4027CE2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04027CE3 RID: 163043
		[Token(Token = "0x4027CE3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04027CE4 RID: 163044
		[Token(Token = "0x4027CE4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04027CE5 RID: 163045
		[Token(Token = "0x4027CE5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__IsUIStable;

		// Token: 0x04027CE6 RID: 163046
		[Token(Token = "0x4027CE6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CloseResult;

		// Token: 0x04027CE7 RID: 163047
		[Token(Token = "0x4027CE7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ReceiveItemCoroutine;

		// Token: 0x04027CE8 RID: 163048
		[Token(Token = "0x4027CE8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnBtnClose;

		// Token: 0x04027CE9 RID: 163049
		[Token(Token = "0x4027CE9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
