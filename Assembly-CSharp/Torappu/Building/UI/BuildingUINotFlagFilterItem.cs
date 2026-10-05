using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;

namespace Torappu.Building.UI
{
	// Token: 0x02001B3F RID: 6975
	[Token(Token = "0x2001B3F")]
	public class BuildingUINotFlagFilterItem<FilterEnum> : MonoBehaviour where FilterEnum : struct
	{
		// Token: 0x170014D0 RID: 5328
		// (get) Token: 0x0600AF77 RID: 44919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014D0")]
		protected FilterEnum filterType
		{
			[Token(Token = "0x600AF77")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600AF78 RID: 44920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF78")]
		public virtual void Render(FilterEnum filterEnum)
		{
		}

		// Token: 0x0600AF79 RID: 44921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF79")]
		public void EventOnToggleClicked()
		{
		}

		// Token: 0x0600AF7A RID: 44922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF7A")]
		public BuildingUINotFlagFilterItem()
		{
		}

		// Token: 0x0400A91E RID: 43294
		[Token(Token = "0x400A91E")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private TwoStateToggle _toggle;

		// Token: 0x0400A91F RID: 43295
		[Token(Token = "0x400A91F")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private FilterEnum _filterType;

		// Token: 0x0400A920 RID: 43296
		[Token(Token = "0x400A920")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		public Action<FilterEnum> onFilterClicked;
	}
}
