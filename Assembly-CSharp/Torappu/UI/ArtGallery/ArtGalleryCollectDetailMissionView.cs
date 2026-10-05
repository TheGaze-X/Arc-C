using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x020065E1 RID: 26081
	[Token(Token = "0x20065E1")]
	public class ArtGalleryCollectDetailMissionView : DataBinder<ArtGalleryCollectDetailMissionProperty>
	{
		// Token: 0x060257D1 RID: 153553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257D1")]
		[Address(RVA = "0x2073490", Offset = "0x2072090", VA = "0x182073490", Slot = "7")]
		public override void OnValueChanged(ArtGalleryCollectDetailMissionProperty property)
		{
		}

		// Token: 0x060257D2 RID: 153554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257D2")]
		[Address(RVA = "0x20737C0", Offset = "0x20723C0", VA = "0x1820737C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060257D3 RID: 153555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257D3")]
		[Address(RVA = "0x20738E0", Offset = "0x20724E0", VA = "0x1820738E0")]
		public ArtGalleryCollectDetailMissionView()
		{
		}

		// Token: 0x040349F6 RID: 215542
		[Token(Token = "0x40349F6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _txtProgress;

		// Token: 0x040349F7 RID: 215543
		[Token(Token = "0x40349F7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _itemList;

		// Token: 0x040349F8 RID: 215544
		[Token(Token = "0x40349F8")]
		[FieldOffset(Offset = "0x30")]
		private bool m_hasInited;

		// Token: 0x040349F9 RID: 215545
		[Token(Token = "0x40349F9")]
		[FieldOffset(Offset = "0x38")]
		private ArtGalleryCollectDetailMissionView.Adapter m_listAdapter;

		// Token: 0x040349FA RID: 215546
		[Token(Token = "0x40349FA")]
		[FieldOffset(Offset = "0x40")]
		private List<ArtGalleryCollectDetailMissionItemViewModel> m_itemViewModelList;

		// Token: 0x040349FB RID: 215547
		[Token(Token = "0x40349FB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040349FC RID: 215548
		[Token(Token = "0x40349FC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040349FD RID: 215549
		[Token(Token = "0x40349FD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020065E2 RID: 26082
		[Token(Token = "0x20065E2")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x060257D4 RID: 153556 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60257D4")]
			[Address(RVA = "0x206F2C0", Offset = "0x206DEC0", VA = "0x18206F2C0")]
			public Adapter(ArtGalleryCollectDetailMissionView closure)
			{
			}

			// Token: 0x1700589A RID: 22682
			// (get) Token: 0x060257D5 RID: 153557 RVA: 0x000C80B8 File Offset: 0x000C62B8
			[Token(Token = "0x1700589A")]
			public override int count
			{
				[Token(Token = "0x60257D5")]
				[Address(RVA = "0x206F490", Offset = "0x206E090", VA = "0x18206F490", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060257D6 RID: 153558 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60257D6")]
			[Address(RVA = "0x206F120", Offset = "0x206DD20", VA = "0x18206F120", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x040349FE RID: 215550
			[Token(Token = "0x40349FE")]
			[FieldOffset(Offset = "0x20")]
			private ArtGalleryCollectDetailMissionView m_closure;

			// Token: 0x040349FF RID: 215551
			[Token(Token = "0x40349FF")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04034A00 RID: 215552
			[Token(Token = "0x4034A00")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04034A01 RID: 215553
			[Token(Token = "0x4034A01")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
