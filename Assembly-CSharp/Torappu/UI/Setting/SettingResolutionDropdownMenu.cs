using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Setting;
using XLua;

namespace Torappu.UI.Setting
{
	// Token: 0x02003FEF RID: 16367
	[Token(Token = "0x2003FEF")]
	public class SettingResolutionDropdownMenu : SettingDropdownMenu
	{
		// Token: 0x060195AF RID: 103855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195AF")]
		[Address(RVA = "0x1225DC0", Offset = "0x12249C0", VA = "0x181225DC0", Slot = "9")]
		protected override void InitOptions(List<ICommonDropdownModel> optionList)
		{
		}

		// Token: 0x060195B0 RID: 103856 RVA: 0x0009DCC8 File Offset: 0x0009BEC8
		[Token(Token = "0x60195B0")]
		[Address(RVA = "0x1226320", Offset = "0x1224F20", VA = "0x181226320")]
		private int _GetDefaultOptionIndex()
		{
			return 0;
		}

		// Token: 0x060195B1 RID: 103857 RVA: 0x0009DCE0 File Offset: 0x0009BEE0
		[Token(Token = "0x60195B1")]
		[Address(RVA = "0x1225B10", Offset = "0x1224710", VA = "0x181225B10", Slot = "10")]
		protected override int GetSelectedOptionIndex()
		{
			return 0;
		}

		// Token: 0x060195B2 RID: 103858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195B2")]
		[Address(RVA = "0x12260E0", Offset = "0x1224CE0", VA = "0x1812260E0", Slot = "11")]
		protected override void OnValueChanged(int selectedIdx)
		{
		}

		// Token: 0x060195B3 RID: 103859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195B3")]
		[Address(RVA = "0x1226480", Offset = "0x1225080", VA = "0x181226480")]
		public SettingResolutionDropdownMenu()
		{
		}

		// Token: 0x0401F8A2 RID: 129186
		[Token(Token = "0x401F8A2")]
		[FieldOffset(Offset = "0x78")]
		private List<SettingResolutionDropdownMenu.ResolutionSettingOption> m_modelList;

		// Token: 0x0401F8A3 RID: 129187
		[Token(Token = "0x401F8A3")]
		[FieldOffset(Offset = "0x80")]
		private SettingManager.ResolutionSetting m_value;

		// Token: 0x0401F8A4 RID: 129188
		[Token(Token = "0x401F8A4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitOptions;

		// Token: 0x0401F8A5 RID: 129189
		[Token(Token = "0x401F8A5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetDefaultOptionIndex;

		// Token: 0x0401F8A6 RID: 129190
		[Token(Token = "0x401F8A6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetSelectedOptionIndex;

		// Token: 0x0401F8A7 RID: 129191
		[Token(Token = "0x401F8A7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401F8A8 RID: 129192
		[Token(Token = "0x401F8A8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003FF0 RID: 16368
		[Token(Token = "0x2003FF0")]
		public class ResolutionSettingOption : ICommonDropdownModel, IHotfixable, IComparable<SettingResolutionDropdownMenu.ResolutionSettingOption>
		{
			// Token: 0x060195B5 RID: 103861 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60195B5")]
			[Address(RVA = "0x1213F70", Offset = "0x1212B70", VA = "0x181213F70")]
			public ResolutionSettingOption(ResolutionSettingItemData itemData)
			{
			}

			// Token: 0x060195B6 RID: 103862 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60195B6")]
			[Address(RVA = "0x1213D90", Offset = "0x1212990", VA = "0x181213D90", Slot = "4")]
			public string GetDesc()
			{
				return null;
			}

			// Token: 0x060195B7 RID: 103863 RVA: 0x0009DD10 File Offset: 0x0009BF10
			[Token(Token = "0x60195B7")]
			[Address(RVA = "0x1213E60", Offset = "0x1212A60", VA = "0x181213E60", Slot = "5")]
			public int GetIndex()
			{
				return 0;
			}

			// Token: 0x060195B8 RID: 103864 RVA: 0x0009DD28 File Offset: 0x0009BF28
			[Token(Token = "0x60195B8")]
			[Address(RVA = "0x1213CC0", Offset = "0x12128C0", VA = "0x181213CC0", Slot = "6")]
			public int CompareTo(SettingResolutionDropdownMenu.ResolutionSettingOption other)
			{
				return 0;
			}

			// Token: 0x060195B9 RID: 103865 RVA: 0x0009DD40 File Offset: 0x0009BF40
			[Token(Token = "0x60195B9")]
			[Address(RVA = "0x1213DF0", Offset = "0x12129F0", VA = "0x181213DF0")]
			private int GetGroupPriority()
			{
				return 0;
			}

			// Token: 0x060195BA RID: 103866 RVA: 0x0009DD58 File Offset: 0x0009BF58
			[Token(Token = "0x60195BA")]
			[Address(RVA = "0x1213EC0", Offset = "0x1212AC0", VA = "0x181213EC0")]
			public bool IsSameOption(SettingManager.ResolutionSetting setting)
			{
				return default(bool);
			}

			// Token: 0x0401F8A9 RID: 129193
			[Token(Token = "0x401F8A9")]
			[FieldOffset(Offset = "0x10")]
			public int index;

			// Token: 0x0401F8AA RID: 129194
			[Token(Token = "0x401F8AA")]
			[FieldOffset(Offset = "0x14")]
			public int width;

			// Token: 0x0401F8AB RID: 129195
			[Token(Token = "0x401F8AB")]
			[FieldOffset(Offset = "0x18")]
			public int height;

			// Token: 0x0401F8AC RID: 129196
			[Token(Token = "0x401F8AC")]
			[FieldOffset(Offset = "0x1C")]
			public bool isFullScreen;

			// Token: 0x0401F8AD RID: 129197
			[Token(Token = "0x401F8AD")]
			[FieldOffset(Offset = "0x1D")]
			public bool isBorderless;

			// Token: 0x0401F8AE RID: 129198
			[Token(Token = "0x401F8AE")]
			[FieldOffset(Offset = "0x20")]
			public string optionName;

			// Token: 0x0401F8AF RID: 129199
			[Token(Token = "0x401F8AF")]
			[FieldOffset(Offset = "0x28")]
			private int m_sortId;

			// Token: 0x0401F8B0 RID: 129200
			[Token(Token = "0x401F8B0")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401F8B1 RID: 129201
			[Token(Token = "0x401F8B1")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetDesc;

			// Token: 0x0401F8B2 RID: 129202
			[Token(Token = "0x401F8B2")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetIndex;

			// Token: 0x0401F8B3 RID: 129203
			[Token(Token = "0x401F8B3")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_CompareTo;

			// Token: 0x0401F8B4 RID: 129204
			[Token(Token = "0x401F8B4")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetGroupPriority;

			// Token: 0x0401F8B5 RID: 129205
			[Token(Token = "0x401F8B5")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_IsSameOption;
		}
	}
}
