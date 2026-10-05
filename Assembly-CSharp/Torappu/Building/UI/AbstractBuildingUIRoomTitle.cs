using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI
{
	// Token: 0x02001B35 RID: 6965
	[Token(Token = "0x2001B35")]
	public abstract class AbstractBuildingUIRoomTitle<Property, ViewModel> : DataBinder<Property> where Property : DynamicBindProperty<Property, ViewModel> where ViewModel : IBasicRoomModel
	{
		// Token: 0x0600AF58 RID: 44888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF58")]
		public override void OnValueChanged(Property property)
		{
		}

		// Token: 0x0600AF59 RID: 44889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF59")]
		protected AbstractBuildingUIRoomTitle()
		{
		}

		// Token: 0x0400A8E6 RID: 43238
		[Token(Token = "0x400A8E6")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected Text _textName;

		// Token: 0x0400A8E7 RID: 43239
		[Token(Token = "0x400A8E7")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected BuildingRoomLevelView _roomLevel;

		// Token: 0x0400A8E8 RID: 43240
		[Token(Token = "0x400A8E8")]
		[FieldOffset(Offset = "0x0")]
		private string m_slotIdCache;

		// Token: 0x0400A8E9 RID: 43241
		[Token(Token = "0x400A8E9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0400A8EA RID: 43242
		[Token(Token = "0x400A8EA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
