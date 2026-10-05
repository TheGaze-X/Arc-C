using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.Stage
{
	// Token: 0x020068F4 RID: 26868
	[Token(Token = "0x20068F4")]
	public class ZoneRecordBtnContentView : MonoBehaviour
	{
		// Token: 0x060267D2 RID: 157650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60267D2")]
		[Address(RVA = "0x21A4F60", Offset = "0x21A3B60", VA = "0x1821A4F60")]
		public void Render(string zoneId, ZoneRewardBuffViewModel buffViewModel)
		{
		}

		// Token: 0x060267D3 RID: 157651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60267D3")]
		[Address(RVA = "0x21A4EA0", Offset = "0x21A3AA0", VA = "0x1821A4EA0")]
		public void ClickZoneRecordBtn()
		{
		}

		// Token: 0x060267D4 RID: 157652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60267D4")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public ZoneRecordBtnContentView()
		{
		}

		// Token: 0x040363A0 RID: 222112
		[Token(Token = "0x40363A0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ZoneRecordRewardBuffPlugin _rewardBuffPlugin;

		// Token: 0x040363A1 RID: 222113
		[Token(Token = "0x40363A1")]
		[FieldOffset(Offset = "0x20")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040363A2 RID: 222114
		[Token(Token = "0x40363A2")]
		[FieldOffset(Offset = "0x30")]
		private string m_cachedZoneId;
	}
}
