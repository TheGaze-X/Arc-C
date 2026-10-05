using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x020073AB RID: 29611
	[Token(Token = "0x20073AB")]
	public class Act42D0RewardTitleItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029D9F RID: 171423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D9F")]
		[Address(RVA = "0x2574D30", Offset = "0x2573930", VA = "0x182574D30")]
		public void Render(string actId, string iconId)
		{
		}

		// Token: 0x06029DA0 RID: 171424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029DA0")]
		[Address(RVA = "0x2574E80", Offset = "0x2573A80", VA = "0x182574E80")]
		public Act42D0RewardTitleItemView()
		{
		}

		// Token: 0x0403BF93 RID: 245651
		[Token(Token = "0x403BF93")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _ratingIcon;

		// Token: 0x0403BF94 RID: 245652
		[Token(Token = "0x403BF94")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelNoInfo;

		// Token: 0x0403BF95 RID: 245653
		[Token(Token = "0x403BF95")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelInfo;

		// Token: 0x0403BF96 RID: 245654
		[Token(Token = "0x403BF96")]
		[FieldOffset(Offset = "0x30")]
		private string m_cachedIconId;

		// Token: 0x0403BF97 RID: 245655
		[Token(Token = "0x403BF97")]
		[FieldOffset(Offset = "0x38")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403BF98 RID: 245656
		[Token(Token = "0x403BF98")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403BF99 RID: 245657
		[Token(Token = "0x403BF99")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
