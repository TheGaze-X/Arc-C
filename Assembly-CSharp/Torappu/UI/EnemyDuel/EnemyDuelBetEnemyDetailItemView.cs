using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004FB8 RID: 20408
	[Token(Token = "0x2004FB8")]
	public class EnemyDuelBetEnemyDetailItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601E513 RID: 124179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E513")]
		[Address(RVA = "0x17F8380", Offset = "0x17F6F80", VA = "0x1817F8380")]
		public void Render(EnemyDuelBetEnemyViewModel enemyViewModel, int index)
		{
		}

		// Token: 0x0601E514 RID: 124180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E514")]
		[Address(RVA = "0x17F8520", Offset = "0x17F7120", VA = "0x1817F8520")]
		public EnemyDuelBetEnemyDetailItemView()
		{
		}

		// Token: 0x040287C9 RID: 165833
		[Token(Token = "0x40287C9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x040287CA RID: 165834
		[Token(Token = "0x40287CA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _pnlBkgDeco;

		// Token: 0x040287CB RID: 165835
		[Token(Token = "0x40287CB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040287CC RID: 165836
		[Token(Token = "0x40287CC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
