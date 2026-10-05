using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.EnemyHandBook;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x0200775E RID: 30558
	[Token(Token = "0x200775E")]
	public class Act1VHalfIdlePlotEnemyInfoView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170064A6 RID: 25766
		// (get) Token: 0x0602AEB9 RID: 175801 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602AEBA RID: 175802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170064A6")]
		public Action<List<EnemyHandBookEverViewModel>> onEnemyItemClicked
		{
			[Token(Token = "0x602AEB9")]
			[Address(RVA = "0x26B4570", Offset = "0x26B3170", VA = "0x1826B4570")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602AEBA")]
			[Address(RVA = "0x26B45D0", Offset = "0x26B31D0", VA = "0x1826B45D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602AEBB RID: 175803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AEBB")]
		[Address(RVA = "0x26B4230", Offset = "0x26B2E30", VA = "0x1826B4230")]
		public void Render(Act1VHalfidlePlotViewModel viewModel)
		{
		}

		// Token: 0x0602AEBC RID: 175804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AEBC")]
		[Address(RVA = "0x26B4180", Offset = "0x26B2D80", VA = "0x1826B4180")]
		public void EventOnItemClick()
		{
		}

		// Token: 0x0602AEBD RID: 175805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AEBD")]
		[Address(RVA = "0x26B44C0", Offset = "0x26B30C0", VA = "0x1826B44C0")]
		public Act1VHalfIdlePlotEnemyInfoView()
		{
		}

		// Token: 0x0403DE8F RID: 253583
		[Token(Token = "0x403DE8F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _emptyObj;

		// Token: 0x0403DE90 RID: 253584
		[Token(Token = "0x403DE90")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _normalObj;

		// Token: 0x0403DE91 RID: 253585
		[Token(Token = "0x403DE91")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _pnlEnemy;

		// Token: 0x0403DE92 RID: 253586
		[Token(Token = "0x403DE92")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _pnlEnemeyMore;

		// Token: 0x0403DE93 RID: 253587
		[Token(Token = "0x403DE93")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _enemyIcon;

		// Token: 0x0403DE94 RID: 253588
		[Token(Token = "0x403DE94")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _enemyDesc;

		// Token: 0x0403DE95 RID: 253589
		[Token(Token = "0x403DE95")]
		[FieldOffset(Offset = "0x48")]
		private string m_cachedPlotId;

		// Token: 0x0403DE96 RID: 253590
		[Token(Token = "0x403DE96")]
		[FieldOffset(Offset = "0x50")]
		private List<EnemyHandBookEverViewModel> m_cachedEnemyHandbookViewModel;

		// Token: 0x0403DE97 RID: 253591
		[Token(Token = "0x403DE97")]
		[FieldOffset(Offset = "0x58")]
		private UICompDialogFinder m_compDialogFinder;

		// Token: 0x0403DE99 RID: 253593
		[Token(Token = "0x403DE99")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onEnemyItemClicked;

		// Token: 0x0403DE9A RID: 253594
		[Token(Token = "0x403DE9A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onEnemyItemClicked;

		// Token: 0x0403DE9B RID: 253595
		[Token(Token = "0x403DE9B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403DE9C RID: 253596
		[Token(Token = "0x403DE9C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnItemClick;

		// Token: 0x0403DE9D RID: 253597
		[Token(Token = "0x403DE9D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
