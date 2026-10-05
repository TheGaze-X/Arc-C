using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003ACC RID: 15052
	[Token(Token = "0x2003ACC")]
	public class ItemRepoItemPackContentView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06017BD8 RID: 97240 RVA: 0x00097DD0 File Offset: 0x00095FD0
		[Token(Token = "0x6017BD8")]
		[Address(RVA = "0xFFCFC0", Offset = "0xFFBBC0", VA = "0x180FFCFC0")]
		public bool UpdateItemPackContent(UIItemViewModel itemModel)
		{
			return default(bool);
		}

		// Token: 0x06017BD9 RID: 97241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017BD9")]
		[Address(RVA = "0xFFD1A0", Offset = "0xFFBDA0", VA = "0x180FFD1A0")]
		public ItemRepoItemPackContentView()
		{
		}

		// Token: 0x0401CAA0 RID: 117408
		[Token(Token = "0x401CAA0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _itemPackContentLayout;

		// Token: 0x0401CAA1 RID: 117409
		[Token(Token = "0x401CAA1")]
		[FieldOffset(Offset = "0x20")]
		private ItemRepoItemPackContentView.Adapter m_adapter;

		// Token: 0x0401CAA2 RID: 117410
		[Token(Token = "0x401CAA2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateItemPackContent;

		// Token: 0x0401CAA3 RID: 117411
		[Token(Token = "0x401CAA3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003ACD RID: 15053
		[Token(Token = "0x2003ACD")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x170038EF RID: 14575
			// (get) Token: 0x06017BDA RID: 97242 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06017BDB RID: 97243 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170038EF")]
			public List<ItemBundle> list
			{
				[Token(Token = "0x6017BDA")]
				[Address(RVA = "0xFF9A40", Offset = "0xFF8640", VA = "0x180FF9A40")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x6017BDB")]
				[Address(RVA = "0xFF9AA0", Offset = "0xFF86A0", VA = "0x180FF9AA0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170038F0 RID: 14576
			// (get) Token: 0x06017BDC RID: 97244 RVA: 0x00097DE8 File Offset: 0x00095FE8
			[Token(Token = "0x170038F0")]
			public override int count
			{
				[Token(Token = "0x6017BDC")]
				[Address(RVA = "0xFF9980", Offset = "0xFF8580", VA = "0x180FF9980", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06017BDD RID: 97245 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6017BDD")]
			[Address(RVA = "0xFF96F0", Offset = "0xFF82F0", VA = "0x180FF96F0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06017BDE RID: 97246 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017BDE")]
			[Address(RVA = "0xFF9920", Offset = "0xFF8520", VA = "0x180FF9920")]
			public Adapter()
			{
			}

			// Token: 0x0401CAA5 RID: 117413
			[Token(Token = "0x401CAA5")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_list;

			// Token: 0x0401CAA6 RID: 117414
			[Token(Token = "0x401CAA6")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_list;

			// Token: 0x0401CAA7 RID: 117415
			[Token(Token = "0x401CAA7")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401CAA8 RID: 117416
			[Token(Token = "0x401CAA8")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0401CAA9 RID: 117417
			[Token(Token = "0x401CAA9")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
