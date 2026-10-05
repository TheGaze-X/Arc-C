using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Setting
{
	// Token: 0x02003FE2 RID: 16354
	[Token(Token = "0x2003FE2")]
	public class PCKeySettingViewModel : IHotfixable
	{
		// Token: 0x06019562 RID: 103778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019562")]
		[Address(RVA = "0x11FCB90", Offset = "0x11FB790", VA = "0x1811FCB90")]
		public void LoadData()
		{
		}

		// Token: 0x06019563 RID: 103779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019563")]
		[Address(RVA = "0x11FD7C0", Offset = "0x11FC3C0", VA = "0x1811FD7C0")]
		public void UpdateData()
		{
		}

		// Token: 0x06019564 RID: 103780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019564")]
		[Address(RVA = "0x11FDB50", Offset = "0x11FC750", VA = "0x1811FDB50")]
		public void UpdateSingleFuncData(KeyBoardVirtualButtonConfig config)
		{
		}

		// Token: 0x06019565 RID: 103781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019565")]
		[Address(RVA = "0x11FDF30", Offset = "0x11FCB30", VA = "0x1811FDF30")]
		private void _AddLayoutItemModel()
		{
		}

		// Token: 0x06019566 RID: 103782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019566")]
		[Address(RVA = "0x11FDFA0", Offset = "0x11FCBA0", VA = "0x1811FDFA0")]
		private void _AddNormalLayoutItemList()
		{
		}

		// Token: 0x06019567 RID: 103783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019567")]
		[Address(RVA = "0x11FDCA0", Offset = "0x11FC8A0", VA = "0x1811FDCA0")]
		private void _AddActLayoutItemList()
		{
		}

		// Token: 0x06019568 RID: 103784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019568")]
		[Address(RVA = "0x11FE240", Offset = "0x11FCE40", VA = "0x1811FE240")]
		public PCKeySettingViewModel()
		{
		}

		// Token: 0x0401F81C RID: 129052
		[Token(Token = "0x401F81C")]
		public const int DEFAULT_SEQUENCE_NUM = 0;

		// Token: 0x0401F81D RID: 129053
		[Token(Token = "0x401F81D")]
		[FieldOffset(Offset = "0x10")]
		public List<UISimpleRecycleLayoutItemViewModel> normalList;

		// Token: 0x0401F81E RID: 129054
		[Token(Token = "0x401F81E")]
		[FieldOffset(Offset = "0x18")]
		public List<UISimpleRecycleLayoutItemViewModel> actList;

		// Token: 0x0401F81F RID: 129055
		[Token(Token = "0x401F81F")]
		[FieldOffset(Offset = "0x20")]
		private ListDict<string, PCKeySettingGroupModel> m_normalGroup;

		// Token: 0x0401F820 RID: 129056
		[Token(Token = "0x401F820")]
		[FieldOffset(Offset = "0x28")]
		private ListDict<string, PCKeySettingGroupModel> m_actGroup;

		// Token: 0x0401F821 RID: 129057
		[Token(Token = "0x401F821")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<string, PCKeySettingGroupModel> m_groupDict;

		// Token: 0x0401F822 RID: 129058
		[Token(Token = "0x401F822")]
		[FieldOffset(Offset = "0x38")]
		public KeyBoardVirtualButtonConfig selectedItem;

		// Token: 0x0401F823 RID: 129059
		[Token(Token = "0x401F823")]
		[FieldOffset(Offset = "0x40")]
		public PCKeySettingDisplayBtnItemModel normalBtnDisplayModel;

		// Token: 0x0401F824 RID: 129060
		[Token(Token = "0x401F824")]
		[FieldOffset(Offset = "0x48")]
		public PCKeySettingDisplayBtnItemModel actBtnDisplayModel;

		// Token: 0x0401F825 RID: 129061
		[Token(Token = "0x401F825")]
		[FieldOffset(Offset = "0x50")]
		public bool isNormalTab;

		// Token: 0x0401F826 RID: 129062
		[Token(Token = "0x401F826")]
		[FieldOffset(Offset = "0x54")]
		public int sequenceNum;

		// Token: 0x0401F827 RID: 129063
		[Token(Token = "0x401F827")]
		[FieldOffset(Offset = "0x58")]
		private string m_normalTitle;

		// Token: 0x0401F828 RID: 129064
		[Token(Token = "0x401F828")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401F829 RID: 129065
		[Token(Token = "0x401F829")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x0401F82A RID: 129066
		[Token(Token = "0x401F82A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateSingleFuncData;

		// Token: 0x0401F82B RID: 129067
		[Token(Token = "0x401F82B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__AddLayoutItemModel;

		// Token: 0x0401F82C RID: 129068
		[Token(Token = "0x401F82C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__AddNormalLayoutItemList;

		// Token: 0x0401F82D RID: 129069
		[Token(Token = "0x401F82D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__AddActLayoutItemList;

		// Token: 0x0401F82E RID: 129070
		[Token(Token = "0x401F82E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
