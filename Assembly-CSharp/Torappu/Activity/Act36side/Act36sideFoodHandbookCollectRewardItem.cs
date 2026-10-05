using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act36side
{
	// Token: 0x02007455 RID: 29781
	[Token(Token = "0x2007455")]
	public class Act36sideFoodHandbookCollectRewardItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602A04F RID: 172111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A04F")]
		[Address(RVA = "0x259B880", Offset = "0x259A480", VA = "0x18259B880")]
		public void Render(int unlockedCount, int totalCount, PlayerActivity.PlayerAct36SideActivity.RewardState state)
		{
		}

		// Token: 0x0602A050 RID: 172112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A050")]
		[Address(RVA = "0x259B7F0", Offset = "0x259A3F0", VA = "0x18259B7F0")]
		public void ClaimReward()
		{
		}

		// Token: 0x0602A051 RID: 172113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A051")]
		[Address(RVA = "0x259BA30", Offset = "0x259A630", VA = "0x18259BA30")]
		public Act36sideFoodHandbookCollectRewardItem()
		{
		}

		// Token: 0x0403C443 RID: 246851
		[Token(Token = "0x403C443")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _unfinishedPanel;

		// Token: 0x0403C444 RID: 246852
		[Token(Token = "0x403C444")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _finishedPanel;

		// Token: 0x0403C445 RID: 246853
		[Token(Token = "0x403C445")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _claimedPanel;

		// Token: 0x0403C446 RID: 246854
		[Token(Token = "0x403C446")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _unlockedCount;

		// Token: 0x0403C447 RID: 246855
		[Token(Token = "0x403C447")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _totalCount;

		// Token: 0x0403C448 RID: 246856
		[Token(Token = "0x403C448")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Slider _unlockedSlider;

		// Token: 0x0403C449 RID: 246857
		[Token(Token = "0x403C449")]
		[FieldOffset(Offset = "0x48")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403C44A RID: 246858
		[Token(Token = "0x403C44A")]
		[FieldOffset(Offset = "0x58")]
		private PlayerActivity.PlayerAct36SideActivity.RewardState m_cachedState;

		// Token: 0x0403C44B RID: 246859
		[Token(Token = "0x403C44B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403C44C RID: 246860
		[Token(Token = "0x403C44C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ClaimReward;

		// Token: 0x0403C44D RID: 246861
		[Token(Token = "0x403C44D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
