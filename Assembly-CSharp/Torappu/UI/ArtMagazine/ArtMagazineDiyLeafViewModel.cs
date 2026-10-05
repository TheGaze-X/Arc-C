using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x02006558 RID: 25944
	[Token(Token = "0x2006558")]
	public class ArtMagazineDiyLeafViewModel : ArtMagazineLeafViewModelBase
	{
		// Token: 0x060254DF RID: 152799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60254DF")]
		[Address(RVA = "0x204EDD0", Offset = "0x204D9D0", VA = "0x18204EDD0", Slot = "4")]
		protected override ArtMagazineLeafElementViewModel CreateLeafElementViewModel()
		{
			return null;
		}

		// Token: 0x060254E0 RID: 152800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60254E0")]
		[Address(RVA = "0x204EEE0", Offset = "0x204DAE0", VA = "0x18204EEE0", Slot = "6")]
		public override void LoadData(ArtMagazineLeafData leafData, string nickName, [Optional] ArtMagazineLeafViewModelBase.ItemFilter itemFilter)
		{
		}

		// Token: 0x060254E1 RID: 152801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60254E1")]
		[Address(RVA = "0x204ED50", Offset = "0x204D950", VA = "0x18204ED50", Slot = "5")]
		public override void Clear()
		{
		}

		// Token: 0x060254E2 RID: 152802 RVA: 0x000C76E0 File Offset: 0x000C58E0
		[Token(Token = "0x60254E2")]
		[Address(RVA = "0x204F400", Offset = "0x204E000", VA = "0x18204F400")]
		public bool SetEditingLeafElement(string leafElementId, bool isEditingDuringTouch = false)
		{
			return default(bool);
		}

		// Token: 0x060254E3 RID: 152803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60254E3")]
		[Address(RVA = "0x204EC40", Offset = "0x204D840", VA = "0x18204EC40")]
		public void ClearEditingLeafElement()
		{
		}

		// Token: 0x060254E4 RID: 152804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60254E4")]
		[Address(RVA = "0x204EE50", Offset = "0x204DA50", VA = "0x18204EE50")]
		public ArtMagazineLeafElementViewModel GetEditingLeafElementViewModel()
		{
			return null;
		}

		// Token: 0x060254E5 RID: 152805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60254E5")]
		[Address(RVA = "0x204EAC0", Offset = "0x204D6C0", VA = "0x18204EAC0", Slot = "8")]
		public override void AddLeafElement(string itemId, ItemType itemType, int tmplId)
		{
		}

		// Token: 0x060254E6 RID: 152806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60254E6")]
		[Address(RVA = "0x204F2E0", Offset = "0x204DEE0", VA = "0x18204F2E0", Slot = "10")]
		public override void RemoveLeafElement(string itemId)
		{
		}

		// Token: 0x060254E7 RID: 152807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60254E7")]
		[Address(RVA = "0x204E8C0", Offset = "0x204D4C0", VA = "0x18204E8C0", Slot = "7")]
		public override void AddCharSkin(string itemId, ItemType itemType, int tmplId)
		{
		}

		// Token: 0x060254E8 RID: 152808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60254E8")]
		[Address(RVA = "0x204F580", Offset = "0x204E180", VA = "0x18204F580")]
		public void UpdateLeafViewDisplayOptions(ArtMagazineDiyPage.LeafViewDisplayOptions displayOptions)
		{
		}

		// Token: 0x060254E9 RID: 152809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60254E9")]
		[Address(RVA = "0x204ECD0", Offset = "0x204D8D0", VA = "0x18204ECD0")]
		public void ClearIllustLayoutCache()
		{
		}

		// Token: 0x060254EA RID: 152810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60254EA")]
		[Address(RVA = "0x204F150", Offset = "0x204DD50", VA = "0x18204F150")]
		public void RecordSkinLayoutInfo(ArtMagazineDiyLeafViewModel.SkinLayoutData info)
		{
		}

		// Token: 0x060254EB RID: 152811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60254EB")]
		[Address(RVA = "0x204F380", Offset = "0x204DF80", VA = "0x18204F380")]
		public void ResetCurrCharSkin()
		{
		}

		// Token: 0x060254EC RID: 152812 RVA: 0x000C76F8 File Offset: 0x000C58F8
		[Token(Token = "0x60254EC")]
		[Address(RVA = "0x204F620", Offset = "0x204E220", VA = "0x18204F620")]
		private bool _TryGetCacheIllustInfo(string itemId, int tmplId, out ArtMagazineDiyLeafViewModel.SkinLayoutInfo info)
		{
			return default(bool);
		}

		// Token: 0x060254ED RID: 152813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60254ED")]
		[Address(RVA = "0x204F720", Offset = "0x204E320", VA = "0x18204F720")]
		private void _UpdateLeafCharModel(Vector2 pos, float normalizeSize, bool useDftSize)
		{
		}

		// Token: 0x060254EE RID: 152814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60254EE")]
		[Address(RVA = "0x204F800", Offset = "0x204E400", VA = "0x18204F800")]
		public ArtMagazineDiyLeafViewModel()
		{
		}

		// Token: 0x060254EF RID: 152815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60254EF")]
		[Address(RVA = "0x204F550", Offset = "0x204E150", VA = "0x18204F550")]
		private ArtMagazineLeafElementViewModel <>xLuaBaseProxy_CreateLeafElementViewModel()
		{
			return null;
		}

		// Token: 0x060254F0 RID: 152816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60254F0")]
		[Address(RVA = "0x204F560", Offset = "0x204E160", VA = "0x18204F560")]
		private void <>xLuaBaseProxy_LoadData(ArtMagazineLeafData P0, string P1, ArtMagazineLeafViewModelBase.ItemFilter P2)
		{
		}

		// Token: 0x060254F1 RID: 152817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60254F1")]
		[Address(RVA = "0x204F540", Offset = "0x204E140", VA = "0x18204F540")]
		private void <>xLuaBaseProxy_Clear()
		{
		}

		// Token: 0x060254F2 RID: 152818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60254F2")]
		[Address(RVA = "0x204F530", Offset = "0x204E130", VA = "0x18204F530")]
		private void <>xLuaBaseProxy_AddLeafElement(string P0, ItemType P1, int P2)
		{
		}

		// Token: 0x060254F3 RID: 152819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60254F3")]
		[Address(RVA = "0x204F570", Offset = "0x204E170", VA = "0x18204F570")]
		private void <>xLuaBaseProxy_RemoveLeafElement(string P0)
		{
		}

		// Token: 0x060254F4 RID: 152820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60254F4")]
		[Address(RVA = "0x204F520", Offset = "0x204E120", VA = "0x18204F520")]
		private void <>xLuaBaseProxy_AddCharSkin(string P0, ItemType P1, int P2)
		{
		}

		// Token: 0x04034576 RID: 214390
		[Token(Token = "0x4034576")]
		private const string UNIQUE_SKIN_ID_FORMAT = "{0}_{1}";

		// Token: 0x04034577 RID: 214391
		[Token(Token = "0x4034577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool charIllustInteractable;

		// Token: 0x04034578 RID: 214392
		[Token(Token = "0x4034578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		public bool leafElementInteractable;

		// Token: 0x04034579 RID: 214393
		[Token(Token = "0x4034579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string editingLeafElementId;

		// Token: 0x0403457A RID: 214394
		[Token(Token = "0x403457A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool isEditingDuringTouch;

		// Token: 0x0403457B RID: 214395
		[Token(Token = "0x403457B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public int editingUpdateSeqNum;

		// Token: 0x0403457C RID: 214396
		[Token(Token = "0x403457C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int m_orderCount;

		// Token: 0x0403457D RID: 214397
		[Token(Token = "0x403457D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Dictionary<string, ArtMagazineDiyLeafViewModel.SkinLayoutInfo> m_cacheIllusts;

		// Token: 0x0403457E RID: 214398
		[Token(Token = "0x403457E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector2 m_defaultAnchorPos;

		// Token: 0x0403457F RID: 214399
		[Token(Token = "0x403457F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float m_defaultScale;

		// Token: 0x04034580 RID: 214400
		[Token(Token = "0x4034580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreateLeafElementViewModel;

		// Token: 0x04034581 RID: 214401
		[Token(Token = "0x4034581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04034582 RID: 214402
		[Token(Token = "0x4034582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Clear;

		// Token: 0x04034583 RID: 214403
		[Token(Token = "0x4034583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetEditingLeafElement;

		// Token: 0x04034584 RID: 214404
		[Token(Token = "0x4034584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ClearEditingLeafElement;

		// Token: 0x04034585 RID: 214405
		[Token(Token = "0x4034585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetEditingLeafElementViewModel;

		// Token: 0x04034586 RID: 214406
		[Token(Token = "0x4034586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_AddLeafElement;

		// Token: 0x04034587 RID: 214407
		[Token(Token = "0x4034587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_RemoveLeafElement;

		// Token: 0x04034588 RID: 214408
		[Token(Token = "0x4034588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_AddCharSkin;

		// Token: 0x04034589 RID: 214409
		[Token(Token = "0x4034589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_UpdateLeafViewDisplayOptions;

		// Token: 0x0403458A RID: 214410
		[Token(Token = "0x403458A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_ClearIllustLayoutCache;

		// Token: 0x0403458B RID: 214411
		[Token(Token = "0x403458B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_RecordSkinLayoutInfo;

		// Token: 0x0403458C RID: 214412
		[Token(Token = "0x403458C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_ResetCurrCharSkin;

		// Token: 0x0403458D RID: 214413
		[Token(Token = "0x403458D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__TryGetCacheIllustInfo;

		// Token: 0x0403458E RID: 214414
		[Token(Token = "0x403458E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__UpdateLeafCharModel;

		// Token: 0x0403458F RID: 214415
		[Token(Token = "0x403458F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006559 RID: 25945
		[Token(Token = "0x2006559")]
		public class SkinLayoutData : IHotfixable
		{
			// Token: 0x060254F5 RID: 152821 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60254F5")]
			[Address(RVA = "0x2055BC0", Offset = "0x20547C0", VA = "0x182055BC0")]
			public SkinLayoutData()
			{
			}

			// Token: 0x04034590 RID: 214416
			[Token(Token = "0x4034590")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string skinId;

			// Token: 0x04034591 RID: 214417
			[Token(Token = "0x4034591")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int templateId;

			// Token: 0x04034592 RID: 214418
			[Token(Token = "0x4034592")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public ArtMagazineDiyLeafViewModel.SkinLayoutInfo layoutInfo;

			// Token: 0x04034593 RID: 214419
			[Token(Token = "0x4034593")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200655A RID: 25946
		[Token(Token = "0x200655A")]
		public struct SkinLayoutInfo
		{
			// Token: 0x04034594 RID: 214420
			[Token(Token = "0x4034594")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float normalizedSize;

			// Token: 0x04034595 RID: 214421
			[Token(Token = "0x4034595")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public Vector2 anchorPos;
		}
	}
}
