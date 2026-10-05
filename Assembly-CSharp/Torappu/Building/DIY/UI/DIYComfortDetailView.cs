using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x02001976 RID: 6518
	[Token(Token = "0x2001976")]
	public class DIYComfortDetailView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600A3A9 RID: 41897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3A9")]
		[Address(RVA = "0x31D8150", Offset = "0x31D6D50", VA = "0x1831D8150")]
		public void Show()
		{
		}

		// Token: 0x0600A3AA RID: 41898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3AA")]
		[Address(RVA = "0x31D7650", Offset = "0x31D6250", VA = "0x1831D7650")]
		public void Hide()
		{
		}

		// Token: 0x0600A3AB RID: 41899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3AB")]
		[Address(RVA = "0x31D77C0", Offset = "0x31D63C0", VA = "0x1831D77C0")]
		public void Setup(int roomIndex, IFurnitureProvider furnitureProvider, IDIYRoomModifierProvider modifierProvider, int maxComfort, int comfortFurniLimit)
		{
		}

		// Token: 0x0600A3AC RID: 41900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3AC")]
		[Address(RVA = "0x31D8240", Offset = "0x31D6E40", VA = "0x1831D8240")]
		public DIYComfortDetailView()
		{
		}

		// Token: 0x04009A4A RID: 39498
		[Token(Token = "0x4009A4A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private DIYComfortDetailGroupAdapter _furnitureAdapter;

		// Token: 0x04009A4B RID: 39499
		[Token(Token = "0x4009A4B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private DIYComfortDetailGroupAdapter _groupAdapter;

		// Token: 0x04009A4C RID: 39500
		[Token(Token = "0x4009A4C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _furnitureTotalLabel;

		// Token: 0x04009A4D RID: 39501
		[Token(Token = "0x4009A4D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _groupTotalLabel;

		// Token: 0x04009A4E RID: 39502
		[Token(Token = "0x4009A4E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _totalLabel;

		// Token: 0x04009A4F RID: 39503
		[Token(Token = "0x4009A4F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _backgroundImage;

		// Token: 0x04009A50 RID: 39504
		[Token(Token = "0x4009A50")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x04009A51 RID: 39505
		[Token(Token = "0x4009A51")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _fadeDuration;

		// Token: 0x04009A52 RID: 39506
		[Token(Token = "0x4009A52")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _furnitureComfortRuleHintLabel;

		// Token: 0x04009A53 RID: 39507
		[Token(Token = "0x4009A53")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _furnitureComfortRuleHintPanel;

		// Token: 0x04009A54 RID: 39508
		[Token(Token = "0x4009A54")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x04009A55 RID: 39509
		[Token(Token = "0x4009A55")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x04009A56 RID: 39510
		[Token(Token = "0x4009A56")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Setup;

		// Token: 0x04009A57 RID: 39511
		[Token(Token = "0x4009A57")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001977 RID: 6519
		[Token(Token = "0x2001977")]
		public class DIYComfortDetailLine
		{
			// Token: 0x0600A3AE RID: 41902 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A3AE")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DIYComfortDetailLine()
			{
			}

			// Token: 0x04009A58 RID: 39512
			[Token(Token = "0x4009A58")]
			[FieldOffset(Offset = "0x10")]
			public string col0;

			// Token: 0x04009A59 RID: 39513
			[Token(Token = "0x4009A59")]
			[FieldOffset(Offset = "0x18")]
			public string col1;

			// Token: 0x04009A5A RID: 39514
			[Token(Token = "0x4009A5A")]
			[FieldOffset(Offset = "0x20")]
			public string col2;

			// Token: 0x04009A5B RID: 39515
			[Token(Token = "0x4009A5B")]
			[FieldOffset(Offset = "0x28")]
			public bool zeroColor;

			// Token: 0x04009A5C RID: 39516
			[Token(Token = "0x4009A5C")]
			[FieldOffset(Offset = "0x29")]
			public bool highlight;
		}

		// Token: 0x02001978 RID: 6520
		[Token(Token = "0x2001978")]
		public class GroupLineMapItem
		{
			// Token: 0x0600A3AF RID: 41903 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A3AF")]
			[Address(RVA = "0x31E9F50", Offset = "0x31E8B50", VA = "0x1831E9F50")]
			public GroupLineMapItem()
			{
			}

			// Token: 0x04009A5D RID: 39517
			[Token(Token = "0x4009A5D")]
			[FieldOffset(Offset = "0x10")]
			public int curCount;

			// Token: 0x04009A5E RID: 39518
			[Token(Token = "0x4009A5E")]
			[FieldOffset(Offset = "0x14")]
			public int maxCount;

			// Token: 0x04009A5F RID: 39519
			[Token(Token = "0x4009A5F")]
			[FieldOffset(Offset = "0x18")]
			public int comfort;

			// Token: 0x04009A60 RID: 39520
			[Token(Token = "0x4009A60")]
			[FieldOffset(Offset = "0x20")]
			public List<DIYComfortDetailView.DIYComfortDetailLine> subLines;
		}

		// Token: 0x02001979 RID: 6521
		[Token(Token = "0x2001979")]
		private class ComfortLineItemFurniture
		{
			// Token: 0x0600A3B0 RID: 41904 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A3B0")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ComfortLineItemFurniture()
			{
			}

			// Token: 0x04009A61 RID: 39521
			[Token(Token = "0x4009A61")]
			[FieldOffset(Offset = "0x10")]
			public string furnitureId;

			// Token: 0x04009A62 RID: 39522
			[Token(Token = "0x4009A62")]
			[FieldOffset(Offset = "0x18")]
			public string displayName;

			// Token: 0x04009A63 RID: 39523
			[Token(Token = "0x4009A63")]
			[FieldOffset(Offset = "0x20")]
			public int count;

			// Token: 0x04009A64 RID: 39524
			[Token(Token = "0x4009A64")]
			[FieldOffset(Offset = "0x24")]
			public int comfortPer;
		}
	}
}
