using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.UniEquipArchive
{
	// Token: 0x02003BF5 RID: 15349
	[Token(Token = "0x2003BF5")]
	public class UniEquipArchiveModuleCollectionSortView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018027 RID: 98343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018027")]
		[Address(RVA = "0x10838F0", Offset = "0x10824F0", VA = "0x1810838F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018028 RID: 98344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018028")]
		[Address(RVA = "0x10836F0", Offset = "0x10822F0", VA = "0x1810836F0")]
		public void Render(UniEquipSortType sortType, string filterTypeName, string filterTypeBriefName)
		{
		}

		// Token: 0x06018029 RID: 98345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018029")]
		[Address(RVA = "0x1083990", Offset = "0x1082590", VA = "0x181083990")]
		private void _OnSortTypeClick(UniEquipSortType sortType)
		{
		}

		// Token: 0x0601802A RID: 98346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601802A")]
		[Address(RVA = "0x10834D0", Offset = "0x10820D0", VA = "0x1810834D0")]
		public void OnLevelDownClick()
		{
		}

		// Token: 0x0601802B RID: 98347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601802B")]
		[Address(RVA = "0x1083530", Offset = "0x1082130", VA = "0x181083530")]
		public void OnLevelUpClick()
		{
		}

		// Token: 0x0601802C RID: 98348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601802C")]
		[Address(RVA = "0x1083630", Offset = "0x1082230", VA = "0x181083630")]
		public void OnUpdateTimeDownClick()
		{
		}

		// Token: 0x0601802D RID: 98349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601802D")]
		[Address(RVA = "0x1083690", Offset = "0x1082290", VA = "0x181083690")]
		public void OnUpdateTimeUpClick()
		{
		}

		// Token: 0x0601802E RID: 98350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601802E")]
		[Address(RVA = "0x1083590", Offset = "0x1082190", VA = "0x181083590")]
		public void OnTypeFilterClick()
		{
		}

		// Token: 0x0601802F RID: 98351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601802F")]
		[Address(RVA = "0x1083A90", Offset = "0x1082690", VA = "0x181083A90")]
		public UniEquipArchiveModuleCollectionSortView()
		{
		}

		// Token: 0x0401D19D RID: 119197
		[Token(Token = "0x401D19D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UniEquipArchiveModuleCollectionSortView.UniEquipArchiveSortItem _levelSort;

		// Token: 0x0401D19E RID: 119198
		[Token(Token = "0x401D19E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UniEquipArchiveModuleCollectionSortView.UniEquipArchiveSortItem _updateTimeSort;

		// Token: 0x0401D19F RID: 119199
		[Token(Token = "0x401D19F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _txtFilterType;

		// Token: 0x0401D1A0 RID: 119200
		[Token(Token = "0x401D1A0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgFilterType;

		// Token: 0x0401D1A1 RID: 119201
		[Token(Token = "0x401D1A1")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isInited;

		// Token: 0x0401D1A2 RID: 119202
		[Token(Token = "0x401D1A2")]
		[FieldOffset(Offset = "0x40")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401D1A3 RID: 119203
		[Token(Token = "0x401D1A3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401D1A4 RID: 119204
		[Token(Token = "0x401D1A4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401D1A5 RID: 119205
		[Token(Token = "0x401D1A5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnSortTypeClick;

		// Token: 0x0401D1A6 RID: 119206
		[Token(Token = "0x401D1A6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnLevelDownClick;

		// Token: 0x0401D1A7 RID: 119207
		[Token(Token = "0x401D1A7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnLevelUpClick;

		// Token: 0x0401D1A8 RID: 119208
		[Token(Token = "0x401D1A8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnUpdateTimeDownClick;

		// Token: 0x0401D1A9 RID: 119209
		[Token(Token = "0x401D1A9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnUpdateTimeUpClick;

		// Token: 0x0401D1AA RID: 119210
		[Token(Token = "0x401D1AA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnTypeFilterClick;

		// Token: 0x0401D1AB RID: 119211
		[Token(Token = "0x401D1AB")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003BF6 RID: 15350
		[Token(Token = "0x2003BF6")]
		[Serializable]
		private class UniEquipArchiveSortItem : IHotfixable
		{
			// Token: 0x06018030 RID: 98352 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018030")]
			[Address(RVA = "0x1085FD0", Offset = "0x1084BD0", VA = "0x181085FD0")]
			public void Init(UniEquipSortType typeUp, UniEquipSortType typeDown)
			{
			}

			// Token: 0x06018031 RID: 98353 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018031")]
			[Address(RVA = "0x1086060", Offset = "0x1084C60", VA = "0x181086060")]
			public void Render(UniEquipSortType sortType)
			{
			}

			// Token: 0x06018032 RID: 98354 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018032")]
			[Address(RVA = "0x1086130", Offset = "0x1084D30", VA = "0x181086130")]
			public UniEquipArchiveSortItem()
			{
			}

			// Token: 0x0401D1AC RID: 119212
			[Token(Token = "0x401D1AC")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private GameObject _panelDisable;

			// Token: 0x0401D1AD RID: 119213
			[Token(Token = "0x401D1AD")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private GameObject _panelUp;

			// Token: 0x0401D1AE RID: 119214
			[Token(Token = "0x401D1AE")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private GameObject _panelDown;

			// Token: 0x0401D1AF RID: 119215
			[Token(Token = "0x401D1AF")]
			[FieldOffset(Offset = "0x28")]
			private UniEquipSortType m_sortTypeUp;

			// Token: 0x0401D1B0 RID: 119216
			[Token(Token = "0x401D1B0")]
			[FieldOffset(Offset = "0x2C")]
			private UniEquipSortType m_sortTypeDown;

			// Token: 0x0401D1B1 RID: 119217
			[Token(Token = "0x401D1B1")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Init;

			// Token: 0x0401D1B2 RID: 119218
			[Token(Token = "0x401D1B2")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Render;

			// Token: 0x0401D1B3 RID: 119219
			[Token(Token = "0x401D1B3")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
