using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;

namespace Torappu.Building.UI
{
	// Token: 0x02001B40 RID: 6976
	[Token(Token = "0x2001B40")]
	public abstract class BuildingUISortItem<SortEnum> : MonoBehaviour where SortEnum : IComparable
	{
		// Token: 0x170014D1 RID: 5329
		// (get) Token: 0x0600AF7B RID: 44923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014D1")]
		public SortEnum sortType
		{
			[Token(Token = "0x600AF7B")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600AF7C RID: 44924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF7C")]
		public void Render(SortEnum sortType, bool isInverse)
		{
		}

		// Token: 0x0600AF7D RID: 44925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF7D")]
		public void EventOnToggleClicked()
		{
		}

		// Token: 0x0600AF7E RID: 44926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF7E")]
		protected BuildingUISortItem()
		{
		}

		// Token: 0x0400A921 RID: 43297
		[Token(Token = "0x400A921")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private ThreeStateToggle _toggle;

		// Token: 0x0400A922 RID: 43298
		[Token(Token = "0x400A922")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private SortEnum _sortType;

		// Token: 0x0400A923 RID: 43299
		[Token(Token = "0x400A923")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		public Action<SortEnum> onSortClicked;

		// Token: 0x0400A924 RID: 43300
		[Token(Token = "0x400A924")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		public bool isShow;
	}
}
