using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;

namespace Torappu.Building.UI
{
	// Token: 0x02001B3E RID: 6974
	[Token(Token = "0x2001B3E")]
	public abstract class BuildingUIFilterItem<FilterEnum> : MonoBehaviour
	{
		// Token: 0x0600AF74 RID: 44916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF74")]
		public void Render(int filterMask)
		{
		}

		// Token: 0x0600AF75 RID: 44917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF75")]
		public void EventOnToggleClicked()
		{
		}

		// Token: 0x0600AF76 RID: 44918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF76")]
		protected BuildingUIFilterItem()
		{
		}

		// Token: 0x0400A919 RID: 43289
		[Token(Token = "0x400A919")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private TwoStateToggle _toggle;

		// Token: 0x0400A91A RID: 43290
		[Token(Token = "0x400A91A")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private FilterEnum _filterType;

		// Token: 0x0400A91B RID: 43291
		[Token(Token = "0x400A91B")]
		[FieldOffset(Offset = "0x0")]
		private bool m_isInited;

		// Token: 0x0400A91C RID: 43292
		[Token(Token = "0x400A91C")]
		[FieldOffset(Offset = "0x0")]
		private int m_filterTypeInt;

		// Token: 0x0400A91D RID: 43293
		[Token(Token = "0x400A91D")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		public Action<FilterEnum> onFilterClicked;
	}
}
