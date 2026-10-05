using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x02007365 RID: 29541
	[Token(Token = "0x2007365")]
	public class Act42D0EffectBottomView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029C60 RID: 171104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029C60")]
		[Address(RVA = "0x2557B10", Offset = "0x2556710", VA = "0x182557B10")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06029C61 RID: 171105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029C61")]
		[Address(RVA = "0x25573B0", Offset = "0x2555FB0", VA = "0x1825573B0")]
		public void Render(Act42D0EffectViewModel viewModel)
		{
		}

		// Token: 0x06029C62 RID: 171106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029C62")]
		[Address(RVA = "0x2557250", Offset = "0x2555E50", VA = "0x182557250")]
		public void OnCloseEffect()
		{
		}

		// Token: 0x06029C63 RID: 171107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029C63")]
		[Address(RVA = "0x2557300", Offset = "0x2555F00", VA = "0x182557300")]
		public void OnStartBattle()
		{
		}

		// Token: 0x06029C64 RID: 171108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029C64")]
		[Address(RVA = "0x2557CF0", Offset = "0x25568F0", VA = "0x182557CF0")]
		public Act42D0EffectBottomView()
		{
		}

		// Token: 0x0403BCD8 RID: 244952
		[Token(Token = "0x403BCD8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _energyMaxPerfect;

		// Token: 0x0403BCD9 RID: 244953
		[Token(Token = "0x403BCD9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _energy;

		// Token: 0x0403BCDA RID: 244954
		[Token(Token = "0x403BCDA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _energyMax;

		// Token: 0x0403BCDB RID: 244955
		[Token(Token = "0x403BCDB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelPerfect;

		// Token: 0x0403BCDC RID: 244956
		[Token(Token = "0x403BCDC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelElse;

		// Token: 0x0403BCDD RID: 244957
		[Token(Token = "0x403BCDD")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _rating;

		// Token: 0x0403BCDE RID: 244958
		[Token(Token = "0x403BCDE")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelNormal;

		// Token: 0x0403BCDF RID: 244959
		[Token(Token = "0x403BCDF")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelHard;

		// Token: 0x0403BCE0 RID: 244960
		[Token(Token = "0x403BCE0")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private List<CanvasGroup> _canvasGroups;

		// Token: 0x0403BCE1 RID: 244961
		[Token(Token = "0x403BCE1")]
		[FieldOffset(Offset = "0x60")]
		private bool m_isInited;

		// Token: 0x0403BCE2 RID: 244962
		[Token(Token = "0x403BCE2")]
		[FieldOffset(Offset = "0x68")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403BCE3 RID: 244963
		[Token(Token = "0x403BCE3")]
		[FieldOffset(Offset = "0x78")]
		private List<FadeSwitchTween> m_fadeSwitchTweens;

		// Token: 0x0403BCE4 RID: 244964
		[Token(Token = "0x403BCE4")]
		[FieldOffset(Offset = "0x80")]
		private int m_cachedSequenceNum;

		// Token: 0x0403BCE5 RID: 244965
		[Token(Token = "0x403BCE5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403BCE6 RID: 244966
		[Token(Token = "0x403BCE6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403BCE7 RID: 244967
		[Token(Token = "0x403BCE7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCloseEffect;

		// Token: 0x0403BCE8 RID: 244968
		[Token(Token = "0x403BCE8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnStartBattle;

		// Token: 0x0403BCE9 RID: 244969
		[Token(Token = "0x403BCE9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
