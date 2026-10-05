using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004F8F RID: 20367
	[Token(Token = "0x2004F8F")]
	public class EnemyDuelEntryAnnounceView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601E490 RID: 124048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E490")]
		[Address(RVA = "0x17FBCC0", Offset = "0x17FA8C0", VA = "0x1817FBCC0")]
		public void Render(EnemyDuelEntryViewModel viewModel)
		{
		}

		// Token: 0x0601E491 RID: 124049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E491")]
		[Address(RVA = "0x17FBDC0", Offset = "0x17FA9C0", VA = "0x1817FBDC0")]
		public EnemyDuelEntryAnnounceView()
		{
		}

		// Token: 0x040286AE RID: 165550
		[Token(Token = "0x40286AE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelNew;

		// Token: 0x040286AF RID: 165551
		[Token(Token = "0x40286AF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _text;

		// Token: 0x040286B0 RID: 165552
		[Token(Token = "0x40286B0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040286B1 RID: 165553
		[Token(Token = "0x40286B1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
