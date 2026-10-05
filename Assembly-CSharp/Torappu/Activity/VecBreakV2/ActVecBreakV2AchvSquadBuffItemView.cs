using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006DCC RID: 28108
	[Token(Token = "0x2006DCC")]
	public class ActVecBreakV2AchvSquadBuffItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06028063 RID: 163939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028063")]
		[Address(RVA = "0x2349210", Offset = "0x2347E10", VA = "0x182349210")]
		public void Render(ActVecBreakV2AchvSquadBuffModel buffModel)
		{
		}

		// Token: 0x06028064 RID: 163940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028064")]
		[Address(RVA = "0x23493A0", Offset = "0x2347FA0", VA = "0x1823493A0")]
		public ActVecBreakV2AchvSquadBuffItemView()
		{
		}

		// Token: 0x04038BF9 RID: 232441
		[Token(Token = "0x4038BF9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _normalPartGO;

		// Token: 0x04038BFA RID: 232442
		[Token(Token = "0x4038BFA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _emptyPartGO;

		// Token: 0x04038BFB RID: 232443
		[Token(Token = "0x4038BFB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgBuffIcon;

		// Token: 0x04038BFC RID: 232444
		[Token(Token = "0x4038BFC")]
		[FieldOffset(Offset = "0x30")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04038BFD RID: 232445
		[Token(Token = "0x4038BFD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04038BFE RID: 232446
		[Token(Token = "0x4038BFE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
