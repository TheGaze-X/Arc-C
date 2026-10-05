using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004074 RID: 16500
	[Token(Token = "0x2004074")]
	public abstract class SandboxV2AdminMainListItemViewBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003CCC RID: 15564
		// (get) Token: 0x0601985C RID: 104540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003CCC")]
		protected SandboxV2ItemCard itemCard
		{
			[Token(Token = "0x601985C")]
			[Address(RVA = "0x122FED0", Offset = "0x122EAD0", VA = "0x18122FED0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003CCD RID: 15565
		// (get) Token: 0x0601985D RID: 104541 RVA: 0x0009E6E8 File Offset: 0x0009C8E8
		[Token(Token = "0x17003CCD")]
		protected float itemScale
		{
			[Token(Token = "0x601985D")]
			[Address(RVA = "0x122FF30", Offset = "0x122EB30", VA = "0x18122FF30")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17003CCE RID: 15566
		// (get) Token: 0x0601985E RID: 104542 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601985F RID: 104543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003CCE")]
		public Action<int> itemSelectEvent
		{
			[Token(Token = "0x601985E")]
			[Address(RVA = "0x122FF90", Offset = "0x122EB90", VA = "0x18122FF90")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601985F")]
			[Address(RVA = "0x122FFF0", Offset = "0x122EBF0", VA = "0x18122FFF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06019860 RID: 104544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019860")]
		[Address(RVA = "0x122FA50", Offset = "0x122E650", VA = "0x18122FA50")]
		protected void Render(int position, SandboxV2AdminMainListItemModel model)
		{
		}

		// Token: 0x06019861 RID: 104545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019861")]
		[Address(RVA = "0x122F940", Offset = "0x122E540", VA = "0x18122F940")]
		public void OnItemSelectEvent()
		{
		}

		// Token: 0x06019862 RID: 104546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019862")]
		[Address(RVA = "0x122FC70", Offset = "0x122E870", VA = "0x18122FC70")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019863 RID: 104547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019863")]
		[Address(RVA = "0x122FE70", Offset = "0x122EA70", VA = "0x18122FE70")]
		protected SandboxV2AdminMainListItemViewBase()
		{
		}

		// Token: 0x0401FCFB RID: 130299
		[Token(Token = "0x401FCFB")]
		private const int STOCK_LIMIT_COUNT = 999;

		// Token: 0x0401FCFC RID: 130300
		[Token(Token = "0x401FCFC")]
		private const string STOCK_LIMIT_STRING = "999+";

		// Token: 0x0401FCFD RID: 130301
		[Token(Token = "0x401FCFD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SandboxV2ItemCard _itemCardPrefab;

		// Token: 0x0401FCFE RID: 130302
		[Token(Token = "0x401FCFE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _itemCardHolder;

		// Token: 0x0401FCFF RID: 130303
		[Token(Token = "0x401FCFF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _itemCardScale;

		// Token: 0x0401FD00 RID: 130304
		[Token(Token = "0x401FD00")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _stockText;

		// Token: 0x0401FD01 RID: 130305
		[Token(Token = "0x401FD01")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _nameText;

		// Token: 0x0401FD02 RID: 130306
		[Token(Token = "0x401FD02")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _usageText;

		// Token: 0x0401FD03 RID: 130307
		[Token(Token = "0x401FD03")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _newPanel;

		// Token: 0x0401FD04 RID: 130308
		[Token(Token = "0x401FD04")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SimpleLayoutContent _materialContent;

		// Token: 0x0401FD05 RID: 130309
		[Token(Token = "0x401FD05")]
		[FieldOffset(Offset = "0x58")]
		private bool m_hasInited;

		// Token: 0x0401FD06 RID: 130310
		[Token(Token = "0x401FD06")]
		[FieldOffset(Offset = "0x60")]
		private SandboxV2ItemCard m_itemCard;

		// Token: 0x0401FD07 RID: 130311
		[Token(Token = "0x401FD07")]
		[FieldOffset(Offset = "0x68")]
		private SandboxV2AdminMainListItemViewBase.Adapter m_adapter;

		// Token: 0x0401FD08 RID: 130312
		[Token(Token = "0x401FD08")]
		[FieldOffset(Offset = "0x70")]
		private string m_cachedTopicId;

		// Token: 0x0401FD09 RID: 130313
		[Token(Token = "0x401FD09")]
		[FieldOffset(Offset = "0x78")]
		private int m_cachedPosition;

		// Token: 0x0401FD0A RID: 130314
		[Token(Token = "0x401FD0A")]
		[FieldOffset(Offset = "0x80")]
		private List<SandboxV2AdminMainMaterialModel> m_cachedMaterials;

		// Token: 0x0401FD0C RID: 130316
		[Token(Token = "0x401FD0C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_itemCard;

		// Token: 0x0401FD0D RID: 130317
		[Token(Token = "0x401FD0D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_itemScale;

		// Token: 0x0401FD0E RID: 130318
		[Token(Token = "0x401FD0E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_itemSelectEvent;

		// Token: 0x0401FD0F RID: 130319
		[Token(Token = "0x401FD0F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_itemSelectEvent;

		// Token: 0x0401FD10 RID: 130320
		[Token(Token = "0x401FD10")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401FD11 RID: 130321
		[Token(Token = "0x401FD11")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnItemSelectEvent;

		// Token: 0x0401FD12 RID: 130322
		[Token(Token = "0x401FD12")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401FD13 RID: 130323
		[Token(Token = "0x401FD13")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004075 RID: 16501
		[Token(Token = "0x2004075")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x17003CCF RID: 15567
			// (get) Token: 0x06019864 RID: 104548 RVA: 0x0009E700 File Offset: 0x0009C900
			[Token(Token = "0x17003CCF")]
			public override int count
			{
				[Token(Token = "0x6019864")]
				[Address(RVA = "0x122A020", Offset = "0x1228C20", VA = "0x18122A020", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06019865 RID: 104549 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019865")]
			[Address(RVA = "0x1229FA0", Offset = "0x1228BA0", VA = "0x181229FA0")]
			public Adapter(SandboxV2AdminMainListItemViewBase closure)
			{
			}

			// Token: 0x06019866 RID: 104550 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6019866")]
			[Address(RVA = "0x1229DF0", Offset = "0x12289F0", VA = "0x181229DF0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0401FD14 RID: 130324
			[Token(Token = "0x401FD14")]
			[FieldOffset(Offset = "0x20")]
			private SandboxV2AdminMainListItemViewBase m_closure;

			// Token: 0x0401FD15 RID: 130325
			[Token(Token = "0x401FD15")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401FD16 RID: 130326
			[Token(Token = "0x401FD16")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401FD17 RID: 130327
			[Token(Token = "0x401FD17")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
