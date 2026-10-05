using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004FB5 RID: 20405
	[Token(Token = "0x2004FB5")]
	public abstract class AbstractEnemyDuelBetButton : MonoBehaviour, IHotfixable
	{
		// Token: 0x170046EE RID: 18158
		// (get) Token: 0x0601E50B RID: 124171 RVA: 0x000AE270 File Offset: 0x000AC470
		[Token(Token = "0x170046EE")]
		protected EnemyDuelBetSelectStatus selectStatus
		{
			[Token(Token = "0x601E50B")]
			[Address(RVA = "0x17F61C0", Offset = "0x17F4DC0", VA = "0x1817F61C0")]
			get
			{
				return EnemyDuelBetSelectStatus.NONE;
			}
		}

		// Token: 0x170046EF RID: 18159
		// (get) Token: 0x0601E50C RID: 124172 RVA: 0x000AE288 File Offset: 0x000AC488
		[Token(Token = "0x170046EF")]
		protected AbstractEnemyDuelBetButton.ShowType cachedShowType
		{
			[Token(Token = "0x601E50C")]
			[Address(RVA = "0x17F6110", Offset = "0x17F4D10", VA = "0x1817F6110")]
			get
			{
				return AbstractEnemyDuelBetButton.ShowType.NONE;
			}
		}

		// Token: 0x0601E50D RID: 124173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E50D")]
		[Address(RVA = "0x17F5FF0", Offset = "0x17F4BF0", VA = "0x1817F5FF0")]
		public void Render(EnemyDuelBetSelectStatus currSelectStatus, bool isInit)
		{
		}

		// Token: 0x0601E50E RID: 124174
		[Token(Token = "0x601E50E")]
		protected abstract void SetSelected(AbstractEnemyDuelBetButton.ShowType showType, bool isInit);

		// Token: 0x0601E50F RID: 124175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E50F")]
		[Address(RVA = "0x17F60B0", Offset = "0x17F4CB0", VA = "0x1817F60B0")]
		protected AbstractEnemyDuelBetButton()
		{
		}

		// Token: 0x040287B6 RID: 165814
		[Token(Token = "0x40287B6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private EnemyDuelBetSelectStatus _selectStatus;

		// Token: 0x040287B7 RID: 165815
		[Token(Token = "0x40287B7")]
		[FieldOffset(Offset = "0x1C")]
		private AbstractEnemyDuelBetButton.ShowType m_cachedShowType;

		// Token: 0x040287B8 RID: 165816
		[Token(Token = "0x40287B8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectStatus;

		// Token: 0x040287B9 RID: 165817
		[Token(Token = "0x40287B9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_cachedShowType;

		// Token: 0x040287BA RID: 165818
		[Token(Token = "0x40287BA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040287BB RID: 165819
		[Token(Token = "0x40287BB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004FB6 RID: 20406
		[Token(Token = "0x2004FB6")]
		protected enum ShowType
		{
			// Token: 0x040287BD RID: 165821
			[Token(Token = "0x40287BD")]
			NONE,
			// Token: 0x040287BE RID: 165822
			[Token(Token = "0x40287BE")]
			NORMAL,
			// Token: 0x040287BF RID: 165823
			[Token(Token = "0x40287BF")]
			SELECTED,
			// Token: 0x040287C0 RID: 165824
			[Token(Token = "0x40287C0")]
			MASKED
		}
	}
}
