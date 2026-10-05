using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RecalRune
{
	// Token: 0x0200478A RID: 18314
	[Token(Token = "0x200478A")]
	public class RecalRuneSeasonSelectState : PopupFadeState, IValueMsgReceiver
	{
		// Token: 0x0601BB93 RID: 113555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BB93")]
		[Address(RVA = "0x150CE50", Offset = "0x150BA50", VA = "0x18150CE50", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601BB94 RID: 113556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BB94")]
		[Address(RVA = "0x150D300", Offset = "0x150BF00", VA = "0x18150D300")]
		private void _OnSelectSeason(string seasonId)
		{
		}

		// Token: 0x0601BB95 RID: 113557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BB95")]
		[Address(RVA = "0x150CA20", Offset = "0x150B620", VA = "0x18150CA20", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601BB96 RID: 113558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BB96")]
		[Address(RVA = "0x150CA80", Offset = "0x150B680", VA = "0x18150CA80", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601BB97 RID: 113559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BB97")]
		[Address(RVA = "0x150CF40", Offset = "0x150BB40", VA = "0x18150CF40")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601BB98 RID: 113560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BB98")]
		[Address(RVA = "0x150D040", Offset = "0x150BC40", VA = "0x18150D040")]
		private void _InitShow(int count, int start)
		{
		}

		// Token: 0x0601BB99 RID: 113561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BB99")]
		[Address(RVA = "0x150D660", Offset = "0x150C260", VA = "0x18150D660")]
		private void _PlayEntryAnimation()
		{
		}

		// Token: 0x0601BB9A RID: 113562 RVA: 0x000A5F60 File Offset: 0x000A4160
		[Token(Token = "0x601BB9A")]
		[Address(RVA = "0x150D270", Offset = "0x150BE70", VA = "0x18150D270")]
		private float _ItemShowSyncer(int index)
		{
			return 0f;
		}

		// Token: 0x0601BB9B RID: 113563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BB9B")]
		[Address(RVA = "0x150D770", Offset = "0x150C370", VA = "0x18150D770")]
		public RecalRuneSeasonSelectState()
		{
		}

		// Token: 0x0601BB9E RID: 113566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BB9E")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0402407A RID: 147578
		[Token(Token = "0x402407A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RecalRuneSeasonSelectView _view;

		// Token: 0x0402407B RID: 147579
		[Token(Token = "0x402407B")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float _itemShowOffset;

		// Token: 0x0402407C RID: 147580
		[Token(Token = "0x402407C")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAnimationLocation _entryAnimation;

		// Token: 0x0402407D RID: 147581
		[Token(Token = "0x402407D")]
		[FieldOffset(Offset = "0x90")]
		private readonly RecalRuneSeasonSelectProperty m_property;

		// Token: 0x0402407E RID: 147582
		[Token(Token = "0x402407E")]
		[FieldOffset(Offset = "0x98")]
		private bool m_hasInited;

		// Token: 0x0402407F RID: 147583
		[Token(Token = "0x402407F")]
		[FieldOffset(Offset = "0xA0")]
		private Tween m_entryTween;

		// Token: 0x04024080 RID: 147584
		[Token(Token = "0x4024080")]
		[FieldOffset(Offset = "0xA8")]
		private Tween m_tween;

		// Token: 0x04024081 RID: 147585
		[Token(Token = "0x4024081")]
		[FieldOffset(Offset = "0xB0")]
		private float m_itemShowDuration;

		// Token: 0x04024082 RID: 147586
		[Token(Token = "0x4024082")]
		[FieldOffset(Offset = "0xB4")]
		private float m_totalShowDuration;

		// Token: 0x04024083 RID: 147587
		[Token(Token = "0x4024083")]
		[FieldOffset(Offset = "0xB8")]
		private float m_showPosition;

		// Token: 0x04024084 RID: 147588
		[Token(Token = "0x4024084")]
		[NonSerialized]
		public const int MSG_SELECT_SEASON = 0;

		// Token: 0x04024085 RID: 147589
		[Token(Token = "0x4024085")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04024086 RID: 147590
		[Token(Token = "0x4024086")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnSelectSeason;

		// Token: 0x04024087 RID: 147591
		[Token(Token = "0x4024087")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04024088 RID: 147592
		[Token(Token = "0x4024088")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04024089 RID: 147593
		[Token(Token = "0x4024089")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402408A RID: 147594
		[Token(Token = "0x402408A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitShow;

		// Token: 0x0402408B RID: 147595
		[Token(Token = "0x402408B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__PlayEntryAnimation;

		// Token: 0x0402408C RID: 147596
		[Token(Token = "0x402408C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ItemShowSyncer;

		// Token: 0x0402408D RID: 147597
		[Token(Token = "0x402408D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
