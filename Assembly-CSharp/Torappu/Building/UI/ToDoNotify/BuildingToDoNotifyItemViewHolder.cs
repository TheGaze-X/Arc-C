using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.ToDoNotify
{
	// Token: 0x02001C4E RID: 7246
	[Token(Token = "0x2001C4E")]
	public class BuildingToDoNotifyItemViewHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600B457 RID: 46167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B457")]
		[Address(RVA = "0x32F49A0", Offset = "0x32F35A0", VA = "0x1832F49A0")]
		public void Render(BuildingToDoCategory category, BuildingToDoNotifyItemModel itemModel, bool isSelected, BuildingToDoNotifyView.ItemClickStatusData itemClickStatusData)
		{
		}

		// Token: 0x0600B458 RID: 46168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B458")]
		[Address(RVA = "0x32F4CD0", Offset = "0x32F38D0", VA = "0x1832F4CD0")]
		private void _OnItemAnimEnd()
		{
		}

		// Token: 0x0600B459 RID: 46169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B459")]
		[Address(RVA = "0x32F4D40", Offset = "0x32F3940", VA = "0x1832F4D40")]
		public BuildingToDoNotifyItemViewHolder()
		{
		}

		// Token: 0x0400B005 RID: 45061
		[Token(Token = "0x400B005")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BuildingToDoNotifyItemBase _normalItem;

		// Token: 0x0400B006 RID: 45062
		[Token(Token = "0x400B006")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BuildingToDoNotifyItemBase _workItem;

		// Token: 0x0400B007 RID: 45063
		[Token(Token = "0x400B007")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BuildingToDoNotifyItemBase _restItem;

		// Token: 0x0400B008 RID: 45064
		[Token(Token = "0x400B008")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public Action<BuildingToDoNotifyItemModel> onClicked;

		// Token: 0x0400B009 RID: 45065
		[Token(Token = "0x400B009")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0400B00A RID: 45066
		[Token(Token = "0x400B00A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnItemAnimEnd;

		// Token: 0x0400B00B RID: 45067
		[Token(Token = "0x400B00B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
