using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x020065C8 RID: 26056
	[Token(Token = "0x20065C8")]
	public abstract class ArtMagazineLeafViewModelBase : IHotfixable
	{
		// Token: 0x0602571A RID: 153370 RVA: 0x000C7ED8 File Offset: 0x000C60D8
		[Token(Token = "0x602571A")]
		[Address(RVA = "0x206A560", Offset = "0x2069160", VA = "0x18206A560")]
		private bool _IsItemValid(ArtMagazineLeafElementData leafElementData, ArtMagazineLeafViewModelBase.ItemFilter itemFilter)
		{
			return default(bool);
		}

		// Token: 0x0602571B RID: 153371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602571B")]
		[Address(RVA = "0x2069CE0", Offset = "0x20688E0", VA = "0x182069CE0", Slot = "4")]
		protected virtual ArtMagazineLeafElementViewModel CreateLeafElementViewModel()
		{
			return null;
		}

		// Token: 0x0602571C RID: 153372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602571C")]
		[Address(RVA = "0x2069C10", Offset = "0x2068810", VA = "0x182069C10", Slot = "5")]
		public virtual void Clear()
		{
		}

		// Token: 0x0602571D RID: 153373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602571D")]
		[Address(RVA = "0x2069EB0", Offset = "0x2068AB0", VA = "0x182069EB0", Slot = "6")]
		public virtual void LoadData(ArtMagazineLeafData leafData, string nickName, [Optional] ArtMagazineLeafViewModelBase.ItemFilter itemFilter)
		{
		}

		// Token: 0x0602571E RID: 153374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602571E")]
		[Address(RVA = "0x2069E00", Offset = "0x2068A00", VA = "0x182069E00")]
		public IEnumerable<ArtMagazineLeafItemViewModel> IterAllLeafItems()
		{
			return null;
		}

		// Token: 0x0602571F RID: 153375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602571F")]
		[Address(RVA = "0x20699A0", Offset = "0x20685A0", VA = "0x1820699A0", Slot = "7")]
		public virtual void AddCharSkin(string itemId, ItemType itemType, int tmplId)
		{
		}

		// Token: 0x06025720 RID: 153376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025720")]
		[Address(RVA = "0x2069AD0", Offset = "0x20686D0", VA = "0x182069AD0", Slot = "8")]
		public virtual void AddLeafElement(string itemId, ItemType itemType, int tmplId)
		{
		}

		// Token: 0x06025721 RID: 153377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025721")]
		[Address(RVA = "0x206A3E0", Offset = "0x2068FE0", VA = "0x18206A3E0", Slot = "9")]
		public virtual void RemoveCharSkin(string itemId)
		{
		}

		// Token: 0x06025722 RID: 153378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025722")]
		[Address(RVA = "0x206A4D0", Offset = "0x20690D0", VA = "0x18206A4D0", Slot = "10")]
		public virtual void RemoveLeafElement(string itemId)
		{
		}

		// Token: 0x06025723 RID: 153379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025723")]
		[Address(RVA = "0x206A630", Offset = "0x2069230", VA = "0x18206A630")]
		protected ArtMagazineLeafViewModelBase()
		{
		}

		// Token: 0x040348E0 RID: 215264
		[Token(Token = "0x40348E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string leafId;

		// Token: 0x040348E1 RID: 215265
		[Token(Token = "0x40348E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string leafPresetId;

		// Token: 0x040348E2 RID: 215266
		[Token(Token = "0x40348E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string nickName;

		// Token: 0x040348E3 RID: 215267
		[Token(Token = "0x40348E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ArtMagazineLeafCharViewModel leafChar;

		// Token: 0x040348E4 RID: 215268
		[Token(Token = "0x40348E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ListDict<string, ArtMagazineLeafElementViewModel> leafElementList;

		// Token: 0x040348E5 RID: 215269
		[Token(Token = "0x40348E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int loadDataSeqNum;

		// Token: 0x040348E6 RID: 215270
		[Token(Token = "0x40348E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int charSkinLayoutUpdateSeqNum;

		// Token: 0x040348E7 RID: 215271
		[Token(Token = "0x40348E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool showBottomBar;

		// Token: 0x040348E8 RID: 215272
		[Token(Token = "0x40348E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int m_instCount;

		// Token: 0x040348E9 RID: 215273
		[Token(Token = "0x40348E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__IsItemValid;

		// Token: 0x040348EA RID: 215274
		[Token(Token = "0x40348EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CreateLeafElementViewModel;

		// Token: 0x040348EB RID: 215275
		[Token(Token = "0x40348EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Clear;

		// Token: 0x040348EC RID: 215276
		[Token(Token = "0x40348EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040348ED RID: 215277
		[Token(Token = "0x40348ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_IterAllLeafItems;

		// Token: 0x040348EE RID: 215278
		[Token(Token = "0x40348EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_AddCharSkin;

		// Token: 0x040348EF RID: 215279
		[Token(Token = "0x40348EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_AddLeafElement;

		// Token: 0x040348F0 RID: 215280
		[Token(Token = "0x40348F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_RemoveCharSkin;

		// Token: 0x040348F1 RID: 215281
		[Token(Token = "0x40348F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_RemoveLeafElement;

		// Token: 0x040348F2 RID: 215282
		[Token(Token = "0x40348F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020065C9 RID: 26057
		// (Invoke) Token: 0x06025725 RID: 153381
		[Token(Token = "0x20065C9")]
		public delegate bool ItemFilter(string itemId, ItemType itemType, int tmplId);
	}
}
