using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.UniEquipArchive
{
	// Token: 0x02003BE8 RID: 15336
	[Token(Token = "0x2003BE8")]
	public class UniEquipArchiveCharacterSortView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06017FF3 RID: 98291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017FF3")]
		[Address(RVA = "0x1077EC0", Offset = "0x1076AC0", VA = "0x181077EC0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06017FF4 RID: 98292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017FF4")]
		[Address(RVA = "0x1077D00", Offset = "0x1076900", VA = "0x181077D00")]
		public void Render(UniEquipArchiveCharacterSortViewModel viewModel)
		{
		}

		// Token: 0x06017FF5 RID: 98293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017FF5")]
		[Address(RVA = "0x10780D0", Offset = "0x1076CD0", VA = "0x1810780D0")]
		private void _OnStarMarkToggle(TwoStateToggle.State state)
		{
		}

		// Token: 0x06017FF6 RID: 98294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017FF6")]
		[Address(RVA = "0x1077FD0", Offset = "0x1076BD0", VA = "0x181077FD0")]
		private void _OnSortTypeClick(CharacterSortType sortType)
		{
		}

		// Token: 0x06017FF7 RID: 98295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017FF7")]
		[Address(RVA = "0x1077B80", Offset = "0x1076780", VA = "0x181077B80")]
		public void OnLevelDownClick()
		{
		}

		// Token: 0x06017FF8 RID: 98296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017FF8")]
		[Address(RVA = "0x1077BE0", Offset = "0x10767E0", VA = "0x181077BE0")]
		public void OnLevelUpClick()
		{
		}

		// Token: 0x06017FF9 RID: 98297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017FF9")]
		[Address(RVA = "0x1077C40", Offset = "0x1076840", VA = "0x181077C40")]
		public void OnRarityDownClick()
		{
		}

		// Token: 0x06017FFA RID: 98298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017FFA")]
		[Address(RVA = "0x1077CA0", Offset = "0x10768A0", VA = "0x181077CA0")]
		public void OnRarityUpClick()
		{
		}

		// Token: 0x06017FFB RID: 98299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017FFB")]
		[Address(RVA = "0x10781D0", Offset = "0x1076DD0", VA = "0x1810781D0")]
		public UniEquipArchiveCharacterSortView()
		{
		}

		// Token: 0x0401D103 RID: 119043
		[Token(Token = "0x401D103")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TwoStateToggle _starMark;

		// Token: 0x0401D104 RID: 119044
		[Token(Token = "0x401D104")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UniEquipArchiveCharacterSortView.SortItem _levelSort;

		// Token: 0x0401D105 RID: 119045
		[Token(Token = "0x401D105")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UniEquipArchiveCharacterSortView.SortItem _raritySort;

		// Token: 0x0401D106 RID: 119046
		[Token(Token = "0x401D106")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isInited;

		// Token: 0x0401D107 RID: 119047
		[Token(Token = "0x401D107")]
		[FieldOffset(Offset = "0x38")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401D108 RID: 119048
		[Token(Token = "0x401D108")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401D109 RID: 119049
		[Token(Token = "0x401D109")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401D10A RID: 119050
		[Token(Token = "0x401D10A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnStarMarkToggle;

		// Token: 0x0401D10B RID: 119051
		[Token(Token = "0x401D10B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnSortTypeClick;

		// Token: 0x0401D10C RID: 119052
		[Token(Token = "0x401D10C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnLevelDownClick;

		// Token: 0x0401D10D RID: 119053
		[Token(Token = "0x401D10D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnLevelUpClick;

		// Token: 0x0401D10E RID: 119054
		[Token(Token = "0x401D10E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnRarityDownClick;

		// Token: 0x0401D10F RID: 119055
		[Token(Token = "0x401D10F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnRarityUpClick;

		// Token: 0x0401D110 RID: 119056
		[Token(Token = "0x401D110")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003BE9 RID: 15337
		[Token(Token = "0x2003BE9")]
		[Serializable]
		private class SortItem : IHotfixable
		{
			// Token: 0x06017FFC RID: 98300 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017FFC")]
			[Address(RVA = "0x1077120", Offset = "0x1075D20", VA = "0x181077120")]
			public void Init(CharacterSortType typeUp, CharacterSortType typeDown)
			{
			}

			// Token: 0x06017FFD RID: 98301 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017FFD")]
			[Address(RVA = "0x10771B0", Offset = "0x1075DB0", VA = "0x1810771B0")]
			public void Render(UniEquipArchiveCharacterSortViewModel viewModel)
			{
			}

			// Token: 0x06017FFE RID: 98302 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017FFE")]
			[Address(RVA = "0x1077280", Offset = "0x1075E80", VA = "0x181077280")]
			public SortItem()
			{
			}

			// Token: 0x0401D111 RID: 119057
			[Token(Token = "0x401D111")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private GameObject _panelDisable;

			// Token: 0x0401D112 RID: 119058
			[Token(Token = "0x401D112")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private GameObject _panelUp;

			// Token: 0x0401D113 RID: 119059
			[Token(Token = "0x401D113")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private GameObject _panelDown;

			// Token: 0x0401D114 RID: 119060
			[Token(Token = "0x401D114")]
			[FieldOffset(Offset = "0x28")]
			private CharacterSortType m_sortTypeUp;

			// Token: 0x0401D115 RID: 119061
			[Token(Token = "0x401D115")]
			[FieldOffset(Offset = "0x2C")]
			private CharacterSortType m_sortTypeDown;

			// Token: 0x0401D116 RID: 119062
			[Token(Token = "0x401D116")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Init;

			// Token: 0x0401D117 RID: 119063
			[Token(Token = "0x401D117")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Render;

			// Token: 0x0401D118 RID: 119064
			[Token(Token = "0x401D118")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
