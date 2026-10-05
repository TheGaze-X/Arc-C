using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Setting
{
	// Token: 0x02003FFA RID: 16378
	[Token(Token = "0x2003FFA")]
	public class SettingCategoryItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x060195D6 RID: 103894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195D6")]
		[Address(RVA = "0x1223CE0", Offset = "0x12228E0", VA = "0x181223CE0")]
		public void Init(SettingCategory category, Action<SettingCategory> onClicked)
		{
		}

		// Token: 0x060195D7 RID: 103895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195D7")]
		[Address(RVA = "0x1223BD0", Offset = "0x12227D0", VA = "0x181223BD0")]
		public void ApplyState(bool isSelected)
		{
		}

		// Token: 0x060195D8 RID: 103896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195D8")]
		[Address(RVA = "0x1223DF0", Offset = "0x12229F0", VA = "0x181223DF0")]
		private void Start()
		{
		}

		// Token: 0x060195D9 RID: 103897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195D9")]
		[Address(RVA = "0x1223EC0", Offset = "0x1222AC0", VA = "0x181223EC0")]
		private void _OnClick()
		{
		}

		// Token: 0x060195DA RID: 103898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195DA")]
		[Address(RVA = "0x1223F30", Offset = "0x1222B30", VA = "0x181223F30")]
		public SettingCategoryItem()
		{
		}

		// Token: 0x0401F8DD RID: 129245
		[Token(Token = "0x401F8DD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TwoStateToggle _toggle;

		// Token: 0x0401F8DE RID: 129246
		[Token(Token = "0x401F8DE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button _button;

		// Token: 0x0401F8DF RID: 129247
		[Token(Token = "0x401F8DF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SettingCategoryPlugin _plugin;

		// Token: 0x0401F8E0 RID: 129248
		[Token(Token = "0x401F8E0")]
		[FieldOffset(Offset = "0x30")]
		private Action<SettingCategory> m_onClicked;

		// Token: 0x0401F8E1 RID: 129249
		[Token(Token = "0x401F8E1")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isSelected;

		// Token: 0x0401F8E2 RID: 129250
		[Token(Token = "0x401F8E2")]
		[FieldOffset(Offset = "0x3C")]
		private SettingCategory m_category;

		// Token: 0x0401F8E3 RID: 129251
		[Token(Token = "0x401F8E3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0401F8E4 RID: 129252
		[Token(Token = "0x401F8E4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ApplyState;

		// Token: 0x0401F8E5 RID: 129253
		[Token(Token = "0x401F8E5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0401F8E6 RID: 129254
		[Token(Token = "0x401F8E6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnClick;

		// Token: 0x0401F8E7 RID: 129255
		[Token(Token = "0x401F8E7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
