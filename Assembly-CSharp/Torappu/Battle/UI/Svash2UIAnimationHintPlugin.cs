using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x0200328E RID: 12942
	[Token(Token = "0x200328E")]
	public class Svash2UIAnimationHintPlugin : CharacterMenuEnterExitHintPlugin
	{
		// Token: 0x060148B4 RID: 84148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148B4")]
		[Address(RVA = "0xCD6240", Offset = "0xCD4E40", VA = "0x180CD6240", Slot = "24")]
		protected override void DoRender(bool isShow)
		{
		}

		// Token: 0x060148B5 RID: 84149 RVA: 0x00087660 File Offset: 0x00085860
		[Token(Token = "0x60148B5")]
		[Address(RVA = "0xCD6400", Offset = "0xCD5000", VA = "0x180CD6400", Slot = "21")]
		protected override bool NeedShow(Deck.Card card)
		{
			return default(bool);
		}

		// Token: 0x060148B6 RID: 84150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148B6")]
		[Address(RVA = "0xCD63A0", Offset = "0xCD4FA0", VA = "0x180CD63A0", Slot = "22")]
		protected override void DoReset()
		{
		}

		// Token: 0x060148B7 RID: 84151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148B7")]
		[Address(RVA = "0xCD6760", Offset = "0xCD5360", VA = "0x180CD6760")]
		private void _DoPlayAnimation()
		{
		}

		// Token: 0x060148B8 RID: 84152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148B8")]
		[Address(RVA = "0xCD6950", Offset = "0xCD5550", VA = "0x180CD6950")]
		private void _DoStopAnimation()
		{
		}

		// Token: 0x060148B9 RID: 84153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148B9")]
		[Address(RVA = "0xCD66B0", Offset = "0xCD52B0", VA = "0x180CD66B0", Slot = "25")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x060148BA RID: 84154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148BA")]
		[Address(RVA = "0xCD6A30", Offset = "0xCD5630", VA = "0x180CD6A30")]
		public Svash2UIAnimationHintPlugin()
		{
		}

		// Token: 0x060148BB RID: 84155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148BB")]
		[Address(RVA = "0xCD6740", Offset = "0xCD5340", VA = "0x180CD6740")]
		private void <>xLuaBaseProxy_DoRender(bool P0)
		{
		}

		// Token: 0x060148BC RID: 84156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148BC")]
		[Address(RVA = "0xCD6750", Offset = "0xCD5350", VA = "0x180CD6750")]
		private void <>xLuaBaseProxy_OnDestroy()
		{
		}

		// Token: 0x040184B1 RID: 99505
		[Token(Token = "0x40184B1")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAnimationLocation _location;

		// Token: 0x040184B2 RID: 99506
		[Token(Token = "0x40184B2")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private string _deckBuffForShow;

		// Token: 0x040184B3 RID: 99507
		[Token(Token = "0x40184B3")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Transform _numTextRoot;

		// Token: 0x040184B4 RID: 99508
		[Token(Token = "0x40184B4")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Text _numText;

		// Token: 0x040184B5 RID: 99509
		[Token(Token = "0x40184B5")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private string _audioSignalOnPlay;

		// Token: 0x040184B6 RID: 99510
		[Token(Token = "0x40184B6")]
		[FieldOffset(Offset = "0xB0")]
		private Tween m_tween;

		// Token: 0x040184B7 RID: 99511
		[Token(Token = "0x40184B7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoRender;

		// Token: 0x040184B8 RID: 99512
		[Token(Token = "0x40184B8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_NeedShow;

		// Token: 0x040184B9 RID: 99513
		[Token(Token = "0x40184B9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DoReset;

		// Token: 0x040184BA RID: 99514
		[Token(Token = "0x40184BA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__DoPlayAnimation;

		// Token: 0x040184BB RID: 99515
		[Token(Token = "0x40184BB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__DoStopAnimation;

		// Token: 0x040184BC RID: 99516
		[Token(Token = "0x40184BC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x040184BD RID: 99517
		[Token(Token = "0x40184BD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
