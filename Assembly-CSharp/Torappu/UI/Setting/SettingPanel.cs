using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.SDK;
using UnityEngine;
using XLua;

namespace Torappu.UI.Setting
{
	// Token: 0x02003FFE RID: 16382
	[Token(Token = "0x2003FFE")]
	public class SettingPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x060195E7 RID: 103911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195E7")]
		[Address(RVA = "0x12254D0", Offset = "0x12240D0", VA = "0x1812254D0")]
		public void Init(InjectSettingFeedbacks sdkConfigs, Action<SettingCategory> onCategoryClicked)
		{
		}

		// Token: 0x060195E8 RID: 103912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195E8")]
		[Address(RVA = "0x1225850", Offset = "0x1224450", VA = "0x181225850")]
		public void SelectCategory(SettingCategory target)
		{
		}

		// Token: 0x060195E9 RID: 103913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195E9")]
		[Address(RVA = "0x1225450", Offset = "0x1224050", VA = "0x181225450")]
		public void EventOnAccountCenterClicked()
		{
		}

		// Token: 0x060195EA RID: 103914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195EA")]
		[Address(RVA = "0x1225A60", Offset = "0x1224660", VA = "0x181225A60")]
		public SettingPanel()
		{
		}

		// Token: 0x0401F8F7 RID: 129271
		[Token(Token = "0x401F8F7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SettingPanel.Item[] _items;

		// Token: 0x0401F8F8 RID: 129272
		[Token(Token = "0x401F8F8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _btnAccountCenter;

		// Token: 0x0401F8F9 RID: 129273
		[Token(Token = "0x401F8F9")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isInited;

		// Token: 0x0401F8FA RID: 129274
		[Token(Token = "0x401F8FA")]
		[FieldOffset(Offset = "0x30")]
		private List<SettingPanel.Item> m_activeItems;

		// Token: 0x0401F8FB RID: 129275
		[Token(Token = "0x401F8FB")]
		[FieldOffset(Offset = "0x38")]
		private Action<SettingCategory> m_onCategoryClicked;

		// Token: 0x0401F8FC RID: 129276
		[Token(Token = "0x401F8FC")]
		[FieldOffset(Offset = "0x40")]
		private Action m_openAccountCenter;

		// Token: 0x0401F8FD RID: 129277
		[Token(Token = "0x401F8FD")]
		[FieldOffset(Offset = "0x48")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401F8FE RID: 129278
		[Token(Token = "0x401F8FE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0401F8FF RID: 129279
		[Token(Token = "0x401F8FF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SelectCategory;

		// Token: 0x0401F900 RID: 129280
		[Token(Token = "0x401F900")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnAccountCenterClicked;

		// Token: 0x0401F901 RID: 129281
		[Token(Token = "0x401F901")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003FFF RID: 16383
		[Token(Token = "0x2003FFF")]
		[Serializable]
		private struct Item
		{
			// Token: 0x0401F902 RID: 129282
			[Token(Token = "0x401F902")]
			[FieldOffset(Offset = "0x0")]
			public SettingCategory category;

			// Token: 0x0401F903 RID: 129283
			[Token(Token = "0x401F903")]
			[FieldOffset(Offset = "0x8")]
			public SettingCategoryItem tab;

			// Token: 0x0401F904 RID: 129284
			[Token(Token = "0x401F904")]
			[FieldOffset(Offset = "0x10")]
			public GameObject content;

			// Token: 0x0401F905 RID: 129285
			[Token(Token = "0x401F905")]
			[FieldOffset(Offset = "0x18")]
			public SettingPlatform settingPlatform;
		}
	}
}
