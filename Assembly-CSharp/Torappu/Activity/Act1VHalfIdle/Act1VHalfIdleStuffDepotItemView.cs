using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x0200777F RID: 30591
	[Token(Token = "0x200777F")]
	public class Act1VHalfIdleStuffDepotItemView : MonoBehaviour
	{
		// Token: 0x170064BA RID: 25786
		// (get) Token: 0x0602AF72 RID: 175986 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602AF71 RID: 175985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170064BA")]
		public Action<Act1VHalfIdleStuffDepotItemViewModel> onClick
		{
			[Token(Token = "0x602AF72")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602AF71")]
			[Address(RVA = "0x4EEA30", Offset = "0x4ED630", VA = "0x1804EEA30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602AF73 RID: 175987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF73")]
		[Address(RVA = "0x26D4E80", Offset = "0x26D3A80", VA = "0x1826D4E80")]
		public void Render(Act1VHalfIdleStuffDepotItemViewModel data)
		{
		}

		// Token: 0x0602AF74 RID: 175988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF74")]
		[Address(RVA = "0x26D4E60", Offset = "0x26D3A60", VA = "0x1826D4E60")]
		public void EventOnClick()
		{
		}

		// Token: 0x0602AF75 RID: 175989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF75")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public Act1VHalfIdleStuffDepotItemView()
		{
		}

		// Token: 0x0403DFF6 RID: 253942
		[Token(Token = "0x403DFF6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _icon;

		// Token: 0x0403DFF7 RID: 253943
		[Token(Token = "0x403DFF7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _cnt;

		// Token: 0x0403DFF8 RID: 253944
		[Token(Token = "0x403DFF8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIButton _hotspot;

		// Token: 0x0403DFF9 RID: 253945
		[Token(Token = "0x403DFF9")]
		[FieldOffset(Offset = "0x30")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403DFFA RID: 253946
		[Token(Token = "0x403DFFA")]
		[FieldOffset(Offset = "0x40")]
		private Act1VHalfIdleStuffDepotItemViewModel m_cachedModel;
	}
}
