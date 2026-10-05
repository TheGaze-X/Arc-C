using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI
{
	// Token: 0x02001AF0 RID: 6896
	[Token(Token = "0x2001AF0")]
	public class BuildingCharCtrlRoomTitleView : AbstractBuildingUIRoomTitle<CommonBasicRoomViewProperty, CommonBasicRoomViewModel>
	{
		// Token: 0x0600AE4F RID: 44623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE4F")]
		[Address(RVA = "0x328DFD0", Offset = "0x328CBD0", VA = "0x18328DFD0", Slot = "7")]
		public override void OnValueChanged(CommonBasicRoomViewProperty property)
		{
		}

		// Token: 0x0600AE50 RID: 44624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE50")]
		[Address(RVA = "0x328E1F0", Offset = "0x328CDF0", VA = "0x18328E1F0")]
		private void _RenderInVisitMode()
		{
		}

		// Token: 0x0600AE51 RID: 44625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE51")]
		[Address(RVA = "0x328E460", Offset = "0x328D060", VA = "0x18328E460")]
		private void _RenderNormalRoomTitle(BasicRoomInfoModel basicInfo)
		{
		}

		// Token: 0x0600AE52 RID: 44626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE52")]
		[Address(RVA = "0x328E8D0", Offset = "0x328D4D0", VA = "0x18328E8D0")]
		public BuildingCharCtrlRoomTitleView()
		{
		}

		// Token: 0x0400A6D4 RID: 42708
		[Token(Token = "0x400A6D4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<BuildingCharCtrlRoomTitleView.RoomConfig> _extraRoomConfigs;

		// Token: 0x0400A6D5 RID: 42709
		[Token(Token = "0x400A6D5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelDefault;

		// Token: 0x0400A6D6 RID: 42710
		[Token(Token = "0x400A6D6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelNormal;

		// Token: 0x0400A6D7 RID: 42711
		[Token(Token = "0x400A6D7")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _imgRoomIcon;

		// Token: 0x0400A6D8 RID: 42712
		[Token(Token = "0x400A6D8")]
		[FieldOffset(Offset = "0x58")]
		private string m_cachedSlotId;

		// Token: 0x0400A6D9 RID: 42713
		[Token(Token = "0x400A6D9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0400A6DA RID: 42714
		[Token(Token = "0x400A6DA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderInVisitMode;

		// Token: 0x0400A6DB RID: 42715
		[Token(Token = "0x400A6DB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderNormalRoomTitle;

		// Token: 0x0400A6DC RID: 42716
		[Token(Token = "0x400A6DC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001AF1 RID: 6897
		[Token(Token = "0x2001AF1")]
		[Serializable]
		private class RoomConfig
		{
			// Token: 0x0600AE53 RID: 44627 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AE53")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RoomConfig()
			{
			}

			// Token: 0x0400A6DD RID: 42717
			[Token(Token = "0x400A6DD")]
			[FieldOffset(Offset = "0x10")]
			public BuildingData.RoomType roomType;

			// Token: 0x0400A6DE RID: 42718
			[Token(Token = "0x400A6DE")]
			[FieldOffset(Offset = "0x18")]
			public Sprite icon;

			// Token: 0x0400A6DF RID: 42719
			[Token(Token = "0x400A6DF")]
			[FieldOffset(Offset = "0x20")]
			public Vector2 overrideSize;

			// Token: 0x0400A6E0 RID: 42720
			[Token(Token = "0x400A6E0")]
			[FieldOffset(Offset = "0x28")]
			public bool hideLevel;
		}
	}
}
