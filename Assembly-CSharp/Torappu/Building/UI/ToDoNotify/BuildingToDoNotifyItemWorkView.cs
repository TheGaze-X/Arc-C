using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.ToDoNotify
{
	// Token: 0x02001C58 RID: 7256
	[Token(Token = "0x2001C58")]
	public class BuildingToDoNotifyItemWorkView : BuildingToDoNotifyItemBase
	{
		// Token: 0x0600B483 RID: 46211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B483")]
		[Address(RVA = "0x32F4DA0", Offset = "0x32F39A0", VA = "0x1832F4DA0", Slot = "4")]
		public override void Render(BuildingToDoCategory category, BuildingToDoNotifyItemModel itemModel, bool isSelected, BuildingToDoNotifyView.ItemClickStatusData itemClickStatusData)
		{
		}

		// Token: 0x0600B484 RID: 46212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B484")]
		[Address(RVA = "0x32F4EA0", Offset = "0x32F3AA0", VA = "0x1832F4EA0")]
		public BuildingToDoNotifyItemWorkView()
		{
		}

		// Token: 0x0600B485 RID: 46213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B485")]
		[Address(RVA = "0x32F4400", Offset = "0x32F3000", VA = "0x1832F4400")]
		private void <>xLuaBaseProxy_Render(BuildingToDoCategory P0, BuildingToDoNotifyItemModel P1, bool P2, BuildingToDoNotifyView.ItemClickStatusData P3)
		{
		}

		// Token: 0x0400B04A RID: 45130
		[Token(Token = "0x400B04A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0400B04B RID: 45131
		[Token(Token = "0x400B04B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _panelCount;

		// Token: 0x0400B04C RID: 45132
		[Token(Token = "0x400B04C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0400B04D RID: 45133
		[Token(Token = "0x400B04D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
