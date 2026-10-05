using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.Meeting
{
	// Token: 0x02001D52 RID: 7506
	[Token(Token = "0x2001D52")]
	public class BuildingMusicPlayerItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600B946 RID: 47430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B946")]
		[Address(RVA = "0x33623E0", Offset = "0x3360FE0", VA = "0x1833623E0")]
		public void Render(BuildingMusicItemViewModel viewModel)
		{
		}

		// Token: 0x0600B947 RID: 47431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B947")]
		[Address(RVA = "0x3362270", Offset = "0x3360E70", VA = "0x183362270")]
		public void OnMusicItemClicked()
		{
		}

		// Token: 0x0600B948 RID: 47432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B948")]
		[Address(RVA = "0x3362580", Offset = "0x3361180", VA = "0x183362580")]
		public BuildingMusicPlayerItemView()
		{
		}

		// Token: 0x0400B79D RID: 47005
		[Token(Token = "0x400B79D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _trackPoint;

		// Token: 0x0400B79E RID: 47006
		[Token(Token = "0x400B79E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _playingPanel;

		// Token: 0x0400B79F RID: 47007
		[Token(Token = "0x400B79F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _namePlaying;

		// Token: 0x0400B7A0 RID: 47008
		[Token(Token = "0x400B7A0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _iconLockPlaying;

		// Token: 0x0400B7A1 RID: 47009
		[Token(Token = "0x400B7A1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _iconCurrMusicPlaying;

		// Token: 0x0400B7A2 RID: 47010
		[Token(Token = "0x400B7A2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _defaultPanel;

		// Token: 0x0400B7A3 RID: 47011
		[Token(Token = "0x400B7A3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _name;

		// Token: 0x0400B7A4 RID: 47012
		[Token(Token = "0x400B7A4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _iconLock;

		// Token: 0x0400B7A5 RID: 47013
		[Token(Token = "0x400B7A5")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _iconCurrMusic;

		// Token: 0x0400B7A6 RID: 47014
		[Token(Token = "0x400B7A6")]
		[FieldOffset(Offset = "0x60")]
		private string m_bgmId;

		// Token: 0x0400B7A7 RID: 47015
		[Token(Token = "0x400B7A7")]
		[FieldOffset(Offset = "0x68")]
		private string m_gameMusicId;

		// Token: 0x0400B7A8 RID: 47016
		[Token(Token = "0x400B7A8")]
		[FieldOffset(Offset = "0x70")]
		private bool m_hasInited;

		// Token: 0x0400B7A9 RID: 47017
		[Token(Token = "0x400B7A9")]
		[FieldOffset(Offset = "0x71")]
		private bool m_cachedPlaying;

		// Token: 0x0400B7AA RID: 47018
		[Token(Token = "0x400B7AA")]
		[FieldOffset(Offset = "0x74")]
		private float m_maxNameWidth;

		// Token: 0x0400B7AB RID: 47019
		[Token(Token = "0x400B7AB")]
		[FieldOffset(Offset = "0x78")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0400B7AC RID: 47020
		[Token(Token = "0x400B7AC")]
		[FieldOffset(Offset = "0x88")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0400B7AD RID: 47021
		[Token(Token = "0x400B7AD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0400B7AE RID: 47022
		[Token(Token = "0x400B7AE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnMusicItemClicked;

		// Token: 0x0400B7AF RID: 47023
		[Token(Token = "0x400B7AF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
