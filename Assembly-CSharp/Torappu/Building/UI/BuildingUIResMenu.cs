using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI
{
	// Token: 0x02001B2C RID: 6956
	[Token(Token = "0x2001B2C")]
	public class BuildingUIResMenu : PageSingleComponent
	{
		// Token: 0x0600AF2A RID: 44842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF2A")]
		[Address(RVA = "0x32981F0", Offset = "0x3296DF0", VA = "0x1832981F0")]
		public void NotifySettleRequest(BuildingUIResMenu.AsyncSettleInfo settleInfo)
		{
		}

		// Token: 0x0600AF2B RID: 44843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF2B")]
		[Address(RVA = "0x3297B60", Offset = "0x3296760", VA = "0x183297B60")]
		public void DoSettleEffectsImmediately(List<BuildingUIResMenu.SyncSettleInfo> settleInfos)
		{
		}

		// Token: 0x0600AF2C RID: 44844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF2C")]
		[Address(RVA = "0x3297F80", Offset = "0x3296B80", VA = "0x183297F80")]
		public void DoSettleEffectsImmediately(BuildingUIResMenu.SyncSettleInfo settleInfo)
		{
		}

		// Token: 0x0600AF2D RID: 44845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF2D")]
		[Address(RVA = "0x3297AC0", Offset = "0x32966C0", VA = "0x183297AC0")]
		public void ClearAllEffects()
		{
		}

		// Token: 0x0600AF2E RID: 44846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF2E")]
		[Address(RVA = "0x32984A0", Offset = "0x32970A0", VA = "0x1832984A0", Slot = "7")]
		protected override void OnStart()
		{
		}

		// Token: 0x0600AF2F RID: 44847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF2F")]
		[Address(RVA = "0x3298360", Offset = "0x3296F60", VA = "0x183298360", Slot = "11")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0600AF30 RID: 44848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF30")]
		[Address(RVA = "0x3298180", Offset = "0x3296D80", VA = "0x183298180")]
		private void FixedUpdate()
		{
		}

		// Token: 0x0600AF31 RID: 44849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF31")]
		[Address(RVA = "0x32988D0", Offset = "0x32974D0", VA = "0x1832988D0")]
		private void _OnPlayerDataChanged(object _)
		{
		}

		// Token: 0x0600AF32 RID: 44850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF32")]
		[Address(RVA = "0x32980E0", Offset = "0x3296CE0", VA = "0x1832980E0")]
		public void EventOnLaborDetailClicked()
		{
		}

		// Token: 0x0600AF33 RID: 44851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF33")]
		[Address(RVA = "0x3298780", Offset = "0x3297380", VA = "0x183298780")]
		private void _LoadData()
		{
		}

		// Token: 0x0600AF34 RID: 44852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF34")]
		[Address(RVA = "0x3298CE0", Offset = "0x32978E0", VA = "0x183298CE0")]
		private void _Render()
		{
		}

		// Token: 0x0600AF35 RID: 44853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF35")]
		[Address(RVA = "0x3299270", Offset = "0x3297E70", VA = "0x183299270")]
		private void _ShowCountEffects(int miscCountOverride = -1)
		{
		}

		// Token: 0x0600AF36 RID: 44854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF36")]
		[Address(RVA = "0x3298E90", Offset = "0x3297A90", VA = "0x183298E90")]
		private void _ShowAsyncSettleNotifications()
		{
		}

		// Token: 0x0600AF37 RID: 44855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF37")]
		[Address(RVA = "0x32994C0", Offset = "0x32980C0", VA = "0x1832994C0")]
		private void _ShowItemFlyEffects(BuildingUIResMenu.FlyEffectType type)
		{
		}

		// Token: 0x0600AF38 RID: 44856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF38")]
		[Address(RVA = "0x32996A0", Offset = "0x32982A0", VA = "0x1832996A0")]
		private void _StartFlyItemEffect(BuildingData.RoomType roomId, ItemType itemType, Vector2 anchorOnScreen)
		{
		}

		// Token: 0x0600AF39 RID: 44857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AF39")]
		[Address(RVA = "0x32986C0", Offset = "0x32972C0", VA = "0x1832986C0")]
		private BuildingUIResItem _GetMenuItemByType(ItemType itemType)
		{
			return null;
		}

		// Token: 0x0600AF3A RID: 44858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF3A")]
		[Address(RVA = "0x3299C40", Offset = "0x3298840", VA = "0x183299C40")]
		private void _TriggerAsyncSettleVoices()
		{
		}

		// Token: 0x0600AF3B RID: 44859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF3B")]
		[Address(RVA = "0x3298B50", Offset = "0x3297750", VA = "0x183298B50")]
		private void _PlaySettleVoices(bool manufactReceived, bool shopReceived)
		{
		}

		// Token: 0x0600AF3C RID: 44860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF3C")]
		[Address(RVA = "0x3299D70", Offset = "0x3298970", VA = "0x183299D70")]
		public BuildingUIResMenu()
		{
		}

		// Token: 0x0600AF3E RID: 44862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF3E")]
		[Address(RVA = "0xF53770", Offset = "0xF52370", VA = "0x180F53770")]
		private void <>xLuaBaseProxy_OnStart()
		{
		}

		// Token: 0x0600AF3F RID: 44863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF3F")]
		[Address(RVA = "0xEDDC40", Offset = "0xEDC840", VA = "0x180EDDC40")]
		private void <>xLuaBaseProxy_OnDestroy()
		{
		}

		// Token: 0x0400A881 RID: 43137
		[Token(Token = "0x400A881")]
		private const float NOTIFY_INTERVAL = 0.5f;

		// Token: 0x0400A882 RID: 43138
		[Token(Token = "0x400A882")]
		private const string FLY_ITEM_OBJECT_NAME = "img_fly_item_icon";

		// Token: 0x0400A883 RID: 43139
		[Token(Token = "0x400A883")]
		private const float FLY_ANIM_FADE_DUR = 0.2f;

		// Token: 0x0400A884 RID: 43140
		[Token(Token = "0x400A884")]
		private const float FLY_ANIM_WAIT_MAX_DUR = 0.4f;

		// Token: 0x0400A885 RID: 43141
		[Token(Token = "0x400A885")]
		private const float FLY_ANIM_DUR = 0.6f;

		// Token: 0x0400A886 RID: 43142
		[Token(Token = "0x400A886")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BuildingUIResItem _itemGold;

		// Token: 0x0400A887 RID: 43143
		[Token(Token = "0x400A887")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BuildingUIResItem _itemElectric;

		// Token: 0x0400A888 RID: 43144
		[Token(Token = "0x400A888")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private BuildingUIResItem _itemLabor;

		// Token: 0x0400A889 RID: 43145
		[Token(Token = "0x400A889")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private BuildingUIResItem _itemDmdShd;

		// Token: 0x0400A88A RID: 43146
		[Token(Token = "0x400A88A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private BuildingUIResItem _itemDiamond;

		// Token: 0x0400A88B RID: 43147
		[Token(Token = "0x400A88B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private BuildingUIResItem _itemSocialPt;

		// Token: 0x0400A88C RID: 43148
		[Token(Token = "0x400A88C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private BuildingUIResItem _itemMiscItems;

		// Token: 0x0400A88D RID: 43149
		[Token(Token = "0x400A88D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Icons")]
		private BuildingUIResMenu.IconConfig _iconManufact;

		// Token: 0x0400A88E RID: 43150
		[Token(Token = "0x400A88E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Icons")]
		private BuildingUIResMenu.IconConfig _iconShop;

		// Token: 0x0400A88F RID: 43151
		[Token(Token = "0x400A88F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Icons")]
		private BuildingUIResMenu.IconConfig _iconSocialPt;

		// Token: 0x0400A890 RID: 43152
		[Token(Token = "0x400A890")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RectTransform _flyIconsContainer;

		// Token: 0x0400A891 RID: 43153
		[Token(Token = "0x400A891")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private BuildingLaborDetailView _laborDetail;

		// Token: 0x0400A892 RID: 43154
		[Token(Token = "0x400A892")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BuildingLaborViewModel m_laborModel;

		// Token: 0x0400A893 RID: 43155
		[Token(Token = "0x400A893")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private BuildingUIResMenu.Status m_overrideStatus;

		// Token: 0x0400A894 RID: 43156
		[Token(Token = "0x400A894")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private BuildingUIResMenu.Status m_curStatus;

		// Token: 0x0400A895 RID: 43157
		[Token(Token = "0x400A895")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private BuildingUIResMenu.Status m_prevStatus;

		// Token: 0x0400A896 RID: 43158
		[Token(Token = "0x400A896")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private List<BuildingUIResMenu.AsyncSettleInfo> m_asyncSettleRequests;

		// Token: 0x0400A897 RID: 43159
		[Token(Token = "0x400A897")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_NotifySettleRequest;

		// Token: 0x0400A898 RID: 43160
		[Token(Token = "0x400A898")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoSettleEffectsImmediately;

		// Token: 0x0400A899 RID: 43161
		[Token(Token = "0x400A899")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix1_DoSettleEffectsImmediately;

		// Token: 0x0400A89A RID: 43162
		[Token(Token = "0x400A89A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ClearAllEffects;

		// Token: 0x0400A89B RID: 43163
		[Token(Token = "0x400A89B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnStart;

		// Token: 0x0400A89C RID: 43164
		[Token(Token = "0x400A89C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400A89D RID: 43165
		[Token(Token = "0x400A89D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_FixedUpdate;

		// Token: 0x0400A89E RID: 43166
		[Token(Token = "0x400A89E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnPlayerDataChanged;

		// Token: 0x0400A89F RID: 43167
		[Token(Token = "0x400A89F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnLaborDetailClicked;

		// Token: 0x0400A8A0 RID: 43168
		[Token(Token = "0x400A8A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__LoadData;

		// Token: 0x0400A8A1 RID: 43169
		[Token(Token = "0x400A8A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0400A8A2 RID: 43170
		[Token(Token = "0x400A8A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ShowCountEffects;

		// Token: 0x0400A8A3 RID: 43171
		[Token(Token = "0x400A8A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__ShowAsyncSettleNotifications;

		// Token: 0x0400A8A4 RID: 43172
		[Token(Token = "0x400A8A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__ShowItemFlyEffects;

		// Token: 0x0400A8A5 RID: 43173
		[Token(Token = "0x400A8A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__StartFlyItemEffect;

		// Token: 0x0400A8A6 RID: 43174
		[Token(Token = "0x400A8A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__GetMenuItemByType;

		// Token: 0x0400A8A7 RID: 43175
		[Token(Token = "0x400A8A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__TriggerAsyncSettleVoices;

		// Token: 0x0400A8A8 RID: 43176
		[Token(Token = "0x400A8A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__PlaySettleVoices;

		// Token: 0x0400A8A9 RID: 43177
		[Token(Token = "0x400A8A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001B2D RID: 6957
		[Token(Token = "0x2001B2D")]
		private enum FlyEffectType
		{
			// Token: 0x0400A8AB RID: 43179
			[Token(Token = "0x400A8AB")]
			NONE,
			// Token: 0x0400A8AC RID: 43180
			[Token(Token = "0x400A8AC")]
			GOLD,
			// Token: 0x0400A8AD RID: 43181
			[Token(Token = "0x400A8AD")]
			DMD_SHD,
			// Token: 0x0400A8AE RID: 43182
			[Token(Token = "0x400A8AE")]
			DIAMOND,
			// Token: 0x0400A8AF RID: 43183
			[Token(Token = "0x400A8AF")]
			SOCIAL_PT,
			// Token: 0x0400A8B0 RID: 43184
			[Token(Token = "0x400A8B0")]
			MISC
		}

		// Token: 0x02001B2E RID: 6958
		[Token(Token = "0x2001B2E")]
		private struct Status
		{
			// Token: 0x170014C0 RID: 5312
			// (get) Token: 0x0600AF40 RID: 44864 RVA: 0x000433F8 File Offset: 0x000415F8
			// (set) Token: 0x0600AF41 RID: 44865 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170014C0")]
			public bool isEmpty
			{
				[Token(Token = "0x600AF40")]
				[Address(RVA = "0xDF9A30", Offset = "0xDF8630", VA = "0x180DF9A30")]
				[CompilerGenerated]
				readonly get
				{
					return default(bool);
				}
				[Token(Token = "0x600AF41")]
				[Address(RVA = "0xFEDED0", Offset = "0xFECAD0", VA = "0x180FEDED0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0600AF42 RID: 44866 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AF42")]
			[Address(RVA = "0x32B0DF0", Offset = "0x32AF9F0", VA = "0x1832B0DF0")]
			public void LoadData([Optional] List<BuildingUIResMenu.AsyncSettleInfo> settleInfos)
			{
			}

			// Token: 0x0400A8B1 RID: 43185
			[Token(Token = "0x400A8B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly BuildingUIResMenu.Status EMTPY;

			// Token: 0x0400A8B3 RID: 43187
			[Token(Token = "0x400A8B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public long gold;

			// Token: 0x0400A8B4 RID: 43188
			[Token(Token = "0x400A8B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int diamond;

			// Token: 0x0400A8B5 RID: 43189
			[Token(Token = "0x400A8B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int dmdShd;

			// Token: 0x0400A8B6 RID: 43190
			[Token(Token = "0x400A8B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int socialPt;

			// Token: 0x0400A8B7 RID: 43191
			[Token(Token = "0x400A8B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int miscItems;
		}

		// Token: 0x02001B2F RID: 6959
		[Token(Token = "0x2001B2F")]
		[Serializable]
		private struct IconConfig
		{
			// Token: 0x0400A8B8 RID: 43192
			[Token(Token = "0x400A8B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Sprite icon;

			// Token: 0x0400A8B9 RID: 43193
			[Token(Token = "0x400A8B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Vector2 size;
		}

		// Token: 0x02001B30 RID: 6960
		[Token(Token = "0x2001B30")]
		public struct SyncSettleInfo
		{
			// Token: 0x0400A8BA RID: 43194
			[Token(Token = "0x400A8BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public BuildingData.RoomType roomId;

			// Token: 0x0400A8BB RID: 43195
			[Token(Token = "0x400A8BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public ItemType itemType;

			// Token: 0x0400A8BC RID: 43196
			[Token(Token = "0x400A8BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Vector2 anchorOnScreen;

			// Token: 0x0400A8BD RID: 43197
			[Token(Token = "0x400A8BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int count;
		}

		// Token: 0x02001B31 RID: 6961
		[Token(Token = "0x2001B31")]
		public struct AsyncSettleInfo
		{
			// Token: 0x0400A8BE RID: 43198
			[Token(Token = "0x400A8BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string slotId;

			// Token: 0x0400A8BF RID: 43199
			[Token(Token = "0x400A8BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public BuildingData.RoomType roomId;

			// Token: 0x0400A8C0 RID: 43200
			[Token(Token = "0x400A8C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector2 anchorOnScreen;

			// Token: 0x0400A8C1 RID: 43201
			[Token(Token = "0x400A8C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string itemId;

			// Token: 0x0400A8C2 RID: 43202
			[Token(Token = "0x400A8C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ItemType itemType;

			// Token: 0x0400A8C3 RID: 43203
			[Token(Token = "0x400A8C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public long count;
		}
	}
}
