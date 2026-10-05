using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004F92 RID: 20370
	[Token(Token = "0x2004F92")]
	public class EnemyDuelEntryMatchButtonView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601E497 RID: 124055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E497")]
		[Address(RVA = "0x17FC950", Offset = "0x17FB550", VA = "0x1817FC950")]
		public void Render(EnemyDuelEntryViewModel viewModel)
		{
		}

		// Token: 0x0601E498 RID: 124056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E498")]
		[Address(RVA = "0x17FCA20", Offset = "0x17FB620", VA = "0x1817FCA20")]
		public EnemyDuelEntryMatchButtonView()
		{
		}

		// Token: 0x040286C0 RID: 165568
		[Token(Token = "0x40286C0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelOnEnd;

		// Token: 0x040286C1 RID: 165569
		[Token(Token = "0x40286C1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelTrack;

		// Token: 0x040286C2 RID: 165570
		[Token(Token = "0x40286C2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelCircle;

		// Token: 0x040286C3 RID: 165571
		[Token(Token = "0x40286C3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _hotspot;

		// Token: 0x040286C4 RID: 165572
		[Token(Token = "0x40286C4")]
		[FieldOffset(Offset = "0x38")]
		private UIStateFinder m_stateFinder;

		// Token: 0x040286C5 RID: 165573
		[Token(Token = "0x40286C5")]
		[FieldOffset(Offset = "0x48")]
		private EnemyDuelEntryViewModel m_cachedModel;

		// Token: 0x040286C6 RID: 165574
		[Token(Token = "0x40286C6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040286C7 RID: 165575
		[Token(Token = "0x40286C7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
