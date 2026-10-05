using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x02007A0A RID: 31242
	[Token(Token = "0x2007A0A")]
	public class Act13sidePrestigeRewardState : PopupFadeState
	{
		// Token: 0x0602BCA4 RID: 179364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BCA4")]
		[Address(RVA = "0x27BD1C0", Offset = "0x27BBDC0", VA = "0x1827BD1C0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602BCA5 RID: 179365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BCA5")]
		[Address(RVA = "0x27BD220", Offset = "0x27BBE20", VA = "0x1827BD220", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602BCA6 RID: 179366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BCA6")]
		[Address(RVA = "0x27BD4E0", Offset = "0x27BC0E0", VA = "0x1827BD4E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602BCA7 RID: 179367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BCA7")]
		[Address(RVA = "0x27BD6B0", Offset = "0x27BC2B0", VA = "0x1827BD6B0")]
		public Act13sidePrestigeRewardState()
		{
		}

		// Token: 0x0602BCA8 RID: 179368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BCA8")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0403F5B8 RID: 259512
		[Token(Token = "0x403F5B8")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _textOrgName;

		// Token: 0x0403F5B9 RID: 259513
		[Token(Token = "0x403F5B9")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private SimpleLayoutContent _rankList;

		// Token: 0x0403F5BA RID: 259514
		[Token(Token = "0x403F5BA")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _backBtnRt;

		// Token: 0x0403F5BB RID: 259515
		[Token(Token = "0x403F5BB")]
		[FieldOffset(Offset = "0x88")]
		private bool m_hasInited;

		// Token: 0x0403F5BC RID: 259516
		[Token(Token = "0x403F5BC")]
		[FieldOffset(Offset = "0x90")]
		private Act13sidePrestigeRewardStateBean m_stateBean;

		// Token: 0x0403F5BD RID: 259517
		[Token(Token = "0x403F5BD")]
		[FieldOffset(Offset = "0x98")]
		private Act13sidePrestigeRewardState.Adapter m_adapter;

		// Token: 0x0403F5BE RID: 259518
		[Token(Token = "0x403F5BE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403F5BF RID: 259519
		[Token(Token = "0x403F5BF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403F5C0 RID: 259520
		[Token(Token = "0x403F5C0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403F5C1 RID: 259521
		[Token(Token = "0x403F5C1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007A0B RID: 31243
		[Token(Token = "0x2007A0B")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x0602BCA9 RID: 179369 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BCA9")]
			[Address(RVA = "0x27BFAF0", Offset = "0x27BE6F0", VA = "0x1827BFAF0")]
			public Adapter(Act13sidePrestigeRewardState closure)
			{
			}

			// Token: 0x1700669A RID: 26266
			// (get) Token: 0x0602BCAA RID: 179370 RVA: 0x000DD328 File Offset: 0x000DB528
			[Token(Token = "0x1700669A")]
			public override int count
			{
				[Token(Token = "0x602BCAA")]
				[Address(RVA = "0x27BFDD0", Offset = "0x27BE9D0", VA = "0x1827BFDD0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602BCAB RID: 179371 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602BCAB")]
			[Address(RVA = "0x27BF440", Offset = "0x27BE040", VA = "0x1827BF440", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403F5C2 RID: 259522
			[Token(Token = "0x403F5C2")]
			[FieldOffset(Offset = "0x20")]
			private Act13sidePrestigeRewardState m_closure;

			// Token: 0x0403F5C3 RID: 259523
			[Token(Token = "0x403F5C3")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403F5C4 RID: 259524
			[Token(Token = "0x403F5C4")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403F5C5 RID: 259525
			[Token(Token = "0x403F5C5")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
