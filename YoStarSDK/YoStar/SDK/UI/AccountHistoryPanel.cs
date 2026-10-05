using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YoStar.SDK.UI
{
	// Token: 0x02000132 RID: 306
	[Token(Token = "0x2000132")]
	public class AccountHistoryPanel : BasePanel
	{
		// Token: 0x060007DF RID: 2015 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
		public override void InitView()
		{
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x5C3C950", Offset = "0x5C3B550", VA = "0x185C3C950")]
		private new void Awake()
		{
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x5C3D4D0", Offset = "0x5C3C0D0", VA = "0x185C3D4D0")]
		private void ChangeHistoryState()
		{
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x5C3DC90", Offset = "0x5C3C890", VA = "0x185C3DC90")]
		private void DeleteListItem()
		{
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x5C3E3D0", Offset = "0x5C3CFD0", VA = "0x185C3E3D0")]
		private void RefreshFirstData(string data)
		{
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x5C3DE30", Offset = "0x5C3CA30", VA = "0x185C3DE30")]
		private void OnClick(Button button)
		{
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x5C3ED40", Offset = "0x5C3D940", VA = "0x185C3ED40")]
		private void Start()
		{
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x5C3E350", Offset = "0x5C3CF50", VA = "0x185C3E350")]
		private void OnEnable()
		{
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x5C3E2D0", Offset = "0x5C3CED0", VA = "0x185C3E2D0")]
		private void OnDisable()
		{
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x5C3E820", Offset = "0x5C3D420", VA = "0x185C3E820")]
		private void RefreshListData(List<string> list)
		{
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x5C3D5F0", Offset = "0x5C3C1F0", VA = "0x185C3D5F0")]
		private void CreateHistoryItem(List<string> list)
		{
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x5C3DB70", Offset = "0x5C3C770", VA = "0x185C3DB70")]
		private void DeleteItem(string data)
		{
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x5C3EAB0", Offset = "0x5C3D6B0", VA = "0x185C3EAB0")]
		private void RequestUserInfo(Dictionary<string, object> deleteData)
		{
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x5C3EB80", Offset = "0x5C3D780", VA = "0x185C3EB80")]
		private void ShowView(string title, string subTitle, string deletedUID)
		{
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x5C3EF40", Offset = "0x5C3DB40", VA = "0x185C3EF40")]
		public AccountHistoryPanel()
		{
		}

		// Token: 0x040004B5 RID: 1205
		[Token(Token = "0x40004B5")]
		[FieldOffset(Offset = "0x50")]
		private Button loginButton;

		// Token: 0x040004B6 RID: 1206
		[Token(Token = "0x40004B6")]
		[FieldOffset(Offset = "0x58")]
		private Button otherButton;

		// Token: 0x040004B7 RID: 1207
		[Token(Token = "0x40004B7")]
		[FieldOffset(Offset = "0x60")]
		private Button closeButton;

		// Token: 0x040004B8 RID: 1208
		[Token(Token = "0x40004B8")]
		[FieldOffset(Offset = "0x68")]
		private Image headerImage;

		// Token: 0x040004B9 RID: 1209
		[Token(Token = "0x40004B9")]
		[FieldOffset(Offset = "0x70")]
		private Image arrowImage;

		// Token: 0x040004BA RID: 1210
		[Token(Token = "0x40004BA")]
		[FieldOffset(Offset = "0x78")]
		private Text nickNameText;

		// Token: 0x040004BB RID: 1211
		[Token(Token = "0x40004BB")]
		[FieldOffset(Offset = "0x80")]
		private Text loginTimeText;

		// Token: 0x040004BC RID: 1212
		[Token(Token = "0x40004BC")]
		[FieldOffset(Offset = "0x88")]
		private GameObject historyGO;

		// Token: 0x040004BD RID: 1213
		[Token(Token = "0x40004BD")]
		[FieldOffset(Offset = "0x90")]
		private GameObject scrollViewContent;

		// Token: 0x040004BE RID: 1214
		[Token(Token = "0x40004BE")]
		private const string accountHistoryItemPath = "prefab/item/AccountHistoryItem";

		// Token: 0x040004BF RID: 1215
		[Token(Token = "0x40004BF")]
		[FieldOffset(Offset = "0x98")]
		private Dictionary<string, object> selectedData;

		// Token: 0x040004C0 RID: 1216
		[Token(Token = "0x40004C0")]
		[FieldOffset(Offset = "0xA0")]
		private List<string> listData;
	}
}
