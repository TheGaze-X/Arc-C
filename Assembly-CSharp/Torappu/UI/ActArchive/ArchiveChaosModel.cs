using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B39 RID: 27449
	[Token(Token = "0x2006B39")]
	public class ArchiveChaosModel : IHotfixable
	{
		// Token: 0x17005CB8 RID: 23736
		// (get) Token: 0x060273CE RID: 160718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005CB8")]
		public List<ChaosItemModel> items
		{
			[Token(Token = "0x60273CE")]
			[Address(RVA = "0x226A950", Offset = "0x2269550", VA = "0x18226A950")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005CB9 RID: 23737
		// (get) Token: 0x060273CF RID: 160719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005CB9")]
		public string selectedItemId
		{
			[Token(Token = "0x60273CF")]
			[Address(RVA = "0x226AC30", Offset = "0x2269830", VA = "0x18226AC30")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005CBA RID: 23738
		// (get) Token: 0x060273D0 RID: 160720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005CBA")]
		public ChaosItemModel selectedItem
		{
			[Token(Token = "0x60273D0")]
			[Address(RVA = "0x226AC90", Offset = "0x2269890", VA = "0x18226AC90")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005CBB RID: 23739
		// (get) Token: 0x060273D1 RID: 160721 RVA: 0x000CDC50 File Offset: 0x000CBE50
		[Token(Token = "0x17005CBB")]
		public bool showSwitchTween
		{
			[Token(Token = "0x60273D1")]
			[Address(RVA = "0x226ACF0", Offset = "0x22698F0", VA = "0x18226ACF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005CBC RID: 23740
		// (get) Token: 0x060273D2 RID: 160722 RVA: 0x000CDC68 File Offset: 0x000CBE68
		[Token(Token = "0x17005CBC")]
		public int newNum
		{
			[Token(Token = "0x60273D2")]
			[Address(RVA = "0x226A9B0", Offset = "0x22695B0", VA = "0x18226A9B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060273D3 RID: 160723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60273D3")]
		[Address(RVA = "0x2269BF0", Offset = "0x22687F0", VA = "0x182269BF0")]
		public void LoadData(string archiveId, RoguelikeArchiveComponentData compData, ActArchiveInfo archiveInfo)
		{
		}

		// Token: 0x060273D4 RID: 160724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60273D4")]
		[Address(RVA = "0x226A420", Offset = "0x2269020", VA = "0x18226A420")]
		public void SelectItem(string id)
		{
		}

		// Token: 0x060273D5 RID: 160725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60273D5")]
		[Address(RVA = "0x226A650", Offset = "0x2269250", VA = "0x18226A650")]
		private string _GetDefaultItemId()
		{
			return null;
		}

		// Token: 0x060273D6 RID: 160726 RVA: 0x000CDC80 File Offset: 0x000CBE80
		[Token(Token = "0x60273D6")]
		[Address(RVA = "0x226A730", Offset = "0x2269330", VA = "0x18226A730")]
		private int _ItemComparison(KeyValuePair<string, ChaosItemModel> x, KeyValuePair<string, ChaosItemModel> y)
		{
			return 0;
		}

		// Token: 0x060273D7 RID: 160727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60273D7")]
		[Address(RVA = "0x226A800", Offset = "0x2269400", VA = "0x18226A800")]
		public ArchiveChaosModel()
		{
		}

		// Token: 0x04037850 RID: 227408
		[Token(Token = "0x4037850")]
		[FieldOffset(Offset = "0x10")]
		private ListDict<string, ChaosItemModel> m_items;

		// Token: 0x04037851 RID: 227409
		[Token(Token = "0x4037851")]
		[FieldOffset(Offset = "0x18")]
		private List<ChaosItemModel> m_itemList;

		// Token: 0x04037852 RID: 227410
		[Token(Token = "0x4037852")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<string, ChaosItemModel> m_childItems;

		// Token: 0x04037853 RID: 227411
		[Token(Token = "0x4037853")]
		[FieldOffset(Offset = "0x28")]
		private string m_selectedItemId;

		// Token: 0x04037854 RID: 227412
		[Token(Token = "0x4037854")]
		[FieldOffset(Offset = "0x30")]
		private ChaosItemModel m_selectedItem;

		// Token: 0x04037855 RID: 227413
		[Token(Token = "0x4037855")]
		[FieldOffset(Offset = "0x38")]
		private bool m_showSwitchTween;

		// Token: 0x04037856 RID: 227414
		[Token(Token = "0x4037856")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_items;

		// Token: 0x04037857 RID: 227415
		[Token(Token = "0x4037857")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_selectedItemId;

		// Token: 0x04037858 RID: 227416
		[Token(Token = "0x4037858")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_selectedItem;

		// Token: 0x04037859 RID: 227417
		[Token(Token = "0x4037859")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_showSwitchTween;

		// Token: 0x0403785A RID: 227418
		[Token(Token = "0x403785A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_newNum;

		// Token: 0x0403785B RID: 227419
		[Token(Token = "0x403785B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403785C RID: 227420
		[Token(Token = "0x403785C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SelectItem;

		// Token: 0x0403785D RID: 227421
		[Token(Token = "0x403785D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GetDefaultItemId;

		// Token: 0x0403785E RID: 227422
		[Token(Token = "0x403785E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ItemComparison;

		// Token: 0x0403785F RID: 227423
		[Token(Token = "0x403785F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
