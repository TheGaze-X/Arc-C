using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E6B RID: 28267
	[Token(Token = "0x2006E6B")]
	public class ActVecBreakV2SquadBuffDetailItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602839C RID: 164764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602839C")]
		[Address(RVA = "0x2382C80", Offset = "0x2381880", VA = "0x182382C80")]
		public void Render(ActVecBreakV2DefenseStageBuffItemModel model)
		{
		}

		// Token: 0x0602839D RID: 164765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602839D")]
		[Address(RVA = "0x2382BA0", Offset = "0x23817A0", VA = "0x182382BA0")]
		public void EventOnCancelClicked()
		{
		}

		// Token: 0x0602839E RID: 164766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602839E")]
		[Address(RVA = "0x2382DC0", Offset = "0x23819C0", VA = "0x182382DC0")]
		public ActVecBreakV2SquadBuffDetailItem()
		{
		}

		// Token: 0x040392B1 RID: 234161
		[Token(Token = "0x40392B1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _buffIcon;

		// Token: 0x040392B2 RID: 234162
		[Token(Token = "0x40392B2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _buffName;

		// Token: 0x040392B3 RID: 234163
		[Token(Token = "0x40392B3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _buffDesc;

		// Token: 0x040392B4 RID: 234164
		[Token(Token = "0x40392B4")]
		[FieldOffset(Offset = "0x30")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040392B5 RID: 234165
		[Token(Token = "0x40392B5")]
		[FieldOffset(Offset = "0x40")]
		private UIStateFinder m_stateFinder;

		// Token: 0x040392B6 RID: 234166
		[Token(Token = "0x40392B6")]
		[FieldOffset(Offset = "0x50")]
		private string m_buffId;

		// Token: 0x040392B7 RID: 234167
		[Token(Token = "0x40392B7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040392B8 RID: 234168
		[Token(Token = "0x40392B8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnCancelClicked;

		// Token: 0x040392B9 RID: 234169
		[Token(Token = "0x40392B9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
