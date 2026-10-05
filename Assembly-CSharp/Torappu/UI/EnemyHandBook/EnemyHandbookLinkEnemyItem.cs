using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.EnemyHandBook
{
	// Token: 0x02004F30 RID: 20272
	[Token(Token = "0x2004F30")]
	public class EnemyHandbookLinkEnemyItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601E328 RID: 123688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E328")]
		[Address(RVA = "0x17EF080", Offset = "0x17EDC80", VA = "0x1817EF080")]
		public void Render(EnemyHandBookEverViewModel.LinkEnemy linkEnemy)
		{
		}

		// Token: 0x0601E329 RID: 123689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E329")]
		[Address(RVA = "0x17EEFF0", Offset = "0x17EDBF0", VA = "0x1817EEFF0")]
		public void OnJumpToLinkEnemy()
		{
		}

		// Token: 0x0601E32A RID: 123690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E32A")]
		[Address(RVA = "0x17EF1A0", Offset = "0x17EDDA0", VA = "0x1817EF1A0")]
		public EnemyHandbookLinkEnemyItem()
		{
		}

		// Token: 0x040283D4 RID: 164820
		[Token(Token = "0x40283D4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _lockedState;

		// Token: 0x040283D5 RID: 164821
		[Token(Token = "0x40283D5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _availState;

		// Token: 0x040283D6 RID: 164822
		[Token(Token = "0x40283D6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _enemyName;

		// Token: 0x040283D7 RID: 164823
		[Token(Token = "0x40283D7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _enemyImg;

		// Token: 0x040283D8 RID: 164824
		[Token(Token = "0x40283D8")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		public UIStringEvent onJumpToLinkEnemy;

		// Token: 0x040283D9 RID: 164825
		[Token(Token = "0x40283D9")]
		[FieldOffset(Offset = "0x40")]
		private EnemyHandBookEverViewModel.LinkEnemy m_cacheViewModel;

		// Token: 0x040283DA RID: 164826
		[Token(Token = "0x40283DA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040283DB RID: 164827
		[Token(Token = "0x40283DB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnJumpToLinkEnemy;

		// Token: 0x040283DC RID: 164828
		[Token(Token = "0x40283DC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
