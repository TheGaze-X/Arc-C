using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YoStar.SDK.Constant;

namespace YoStar.SDK.UI
{
	// Token: 0x02000141 RID: 321
	[Token(Token = "0x2000141")]
	public class ChangeBoundMailboxPanel : BasePanel
	{
		// Token: 0x06000835 RID: 2101 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000835")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
		public override void InitView()
		{
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000836")]
		[Address(RVA = "0x5C43B20", Offset = "0x5C42720", VA = "0x185C43B20")]
		private new void Awake()
		{
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000837")]
		[Address(RVA = "0x5C454A0", Offset = "0x5C440A0", VA = "0x185C454A0", Slot = "9")]
		public override void OnCreate()
		{
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000838")]
		[Address(RVA = "0x5C44FD0", Offset = "0x5C43BD0", VA = "0x185C44FD0")]
		private void DealEmailInputScript()
		{
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000839")]
		[Address(RVA = "0x5C45220", Offset = "0x5C43E20", VA = "0x185C45220")]
		private void OnClick(Button button)
		{
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600083A")]
		[Address(RVA = "0x5C44A90", Offset = "0x5C43690", VA = "0x185C44A90")]
		private void DealData()
		{
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600083B")]
		[Address(RVA = "0x5C44580", Offset = "0x5C43180", VA = "0x185C44580")]
		private void ChangeHistoryState()
		{
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600083C")]
		[Address(RVA = "0x5C450B0", Offset = "0x5C43CB0", VA = "0x185C450B0")]
		private void DeleteListItem()
		{
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600083D")]
		[Address(RVA = "0x5C45C40", Offset = "0x5C44840", VA = "0x185C45C40")]
		private void RefreshListData(List<Dictionary<string, object>> list)
		{
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600083E")]
		[Address(RVA = "0x5C44760", Offset = "0x5C43360", VA = "0x185C44760")]
		private void CreateHistoryItem(List<Dictionary<string, object>> list)
		{
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600083F")]
		[Address(RVA = "0x5C45A80", Offset = "0x5C44680", VA = "0x185C45A80")]
		private void RefreshFirstData(Dictionary<string, object> data)
		{
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000840")]
		[Address(RVA = "0x5C45D60", Offset = "0x5C44960", VA = "0x185C45D60")]
		private void SendCodeAsync()
		{
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000841")]
		[Address(RVA = "0x5C444E0", Offset = "0x5C430E0", VA = "0x185C444E0")]
		private void BindEmail()
		{
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000842")]
		[Address(RVA = "0x5C45180", Offset = "0x5C43D80", VA = "0x185C45180")]
		private void HandleVerifyEmailAction()
		{
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000843")]
		[Address(RVA = "0x5C45E50", Offset = "0x5C44A50", VA = "0x185C45E50")]
		public ChangeBoundMailboxPanel()
		{
		}

		// Token: 0x04000500 RID: 1280
		[Token(Token = "0x4000500")]
		[FieldOffset(Offset = "0x50")]
		private Button closeButton;

		// Token: 0x04000501 RID: 1281
		[Token(Token = "0x4000501")]
		[FieldOffset(Offset = "0x58")]
		private Button nextButton;

		// Token: 0x04000502 RID: 1282
		[Token(Token = "0x4000502")]
		[FieldOffset(Offset = "0x60")]
		private GameObject emailTypeGO;

		// Token: 0x04000503 RID: 1283
		[Token(Token = "0x4000503")]
		[FieldOffset(Offset = "0x68")]
		private Text emailTypeText;

		// Token: 0x04000504 RID: 1284
		[Token(Token = "0x4000504")]
		[FieldOffset(Offset = "0x70")]
		private GameObject emailListGO;

		// Token: 0x04000505 RID: 1285
		[Token(Token = "0x4000505")]
		[FieldOffset(Offset = "0x78")]
		private GameObject scrollViewContent;

		// Token: 0x04000506 RID: 1286
		[Token(Token = "0x4000506")]
		private const string emailListItemPath = "prefab/item/EmailListItem";

		// Token: 0x04000507 RID: 1287
		[Token(Token = "0x4000507")]
		[FieldOffset(Offset = "0x80")]
		private Image arrowImage;

		// Token: 0x04000508 RID: 1288
		[Token(Token = "0x4000508")]
		[FieldOffset(Offset = "0x88")]
		private List<Dictionary<string, object>> listData;

		// Token: 0x04000509 RID: 1289
		[Token(Token = "0x4000509")]
		[FieldOffset(Offset = "0x90")]
		private Dictionary<string, object> selectedData;

		// Token: 0x0400050A RID: 1290
		[Token(Token = "0x400050A")]
		[FieldOffset(Offset = "0x98")]
		private EmailInputPanel emailInputPanel;

		// Token: 0x0400050B RID: 1291
		[Token(Token = "0x400050B")]
		[FieldOffset(Offset = "0xA0")]
		private ModifiedEmail modifiedEmail;

		// Token: 0x0400050C RID: 1292
		[Token(Token = "0x400050C")]
		[FieldOffset(Offset = "0xA8")]
		private Text titleText;

		// Token: 0x0400050D RID: 1293
		[Token(Token = "0x400050D")]
		[FieldOffset(Offset = "0xB0")]
		private Action action;
	}
}
