using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004FCA RID: 20426
	[Token(Token = "0x2004FCA")]
	public class EnemyDuelBetTopBarEmoticonBtn : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601E559 RID: 124249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E559")]
		[Address(RVA = "0x1813A70", Offset = "0x1812670", VA = "0x181813A70")]
		public void Render(EnemyDuelTopBarViewModel viewModel)
		{
		}

		// Token: 0x0601E55A RID: 124250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E55A")]
		[Address(RVA = "0x1813B00", Offset = "0x1812700", VA = "0x181813B00")]
		private void _Refresh()
		{
		}

		// Token: 0x0601E55B RID: 124251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E55B")]
		[Address(RVA = "0x1813CA0", Offset = "0x18128A0", VA = "0x181813CA0")]
		public EnemyDuelBetTopBarEmoticonBtn()
		{
		}

		// Token: 0x04028877 RID: 166007
		[Token(Token = "0x4028877")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _pnlDisabled;

		// Token: 0x04028878 RID: 166008
		[Token(Token = "0x4028878")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _pnlAvailable;

		// Token: 0x04028879 RID: 166009
		[Token(Token = "0x4028879")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgDefaultEmoticonId;

		// Token: 0x0402887A RID: 166010
		[Token(Token = "0x402887A")]
		[FieldOffset(Offset = "0x30")]
		private EnemyDuelTopBarViewModel m_cachedTopBarViewModel;

		// Token: 0x0402887B RID: 166011
		[Token(Token = "0x402887B")]
		[FieldOffset(Offset = "0x38")]
		private string m_cachedEmoticonGroupId;

		// Token: 0x0402887C RID: 166012
		[Token(Token = "0x402887C")]
		[FieldOffset(Offset = "0x40")]
		private string m_cachedEmoticonPicId;

		// Token: 0x0402887D RID: 166013
		[Token(Token = "0x402887D")]
		[FieldOffset(Offset = "0x48")]
		private bool m_inited;

		// Token: 0x0402887E RID: 166014
		[Token(Token = "0x402887E")]
		[FieldOffset(Offset = "0x50")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402887F RID: 166015
		[Token(Token = "0x402887F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04028880 RID: 166016
		[Token(Token = "0x4028880")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__Refresh;

		// Token: 0x04028881 RID: 166017
		[Token(Token = "0x4028881")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
