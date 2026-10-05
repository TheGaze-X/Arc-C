using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C07 RID: 27655
	[Token(Token = "0x2006C07")]
	public class ArchiveRelicListGroupView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005D32 RID: 23858
		// (get) Token: 0x060277D7 RID: 161751 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060277D8 RID: 161752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005D32")]
		public ArchiveRelicController controller
		{
			[Token(Token = "0x60277D7")]
			[Address(RVA = "0x22AFDE0", Offset = "0x22AE9E0", VA = "0x1822AFDE0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60277D8")]
			[Address(RVA = "0x22AFE40", Offset = "0x22AEA40", VA = "0x1822AFE40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060277D9 RID: 161753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60277D9")]
		[Address(RVA = "0x22AFBF0", Offset = "0x22AE7F0", VA = "0x1822AFBF0")]
		public void _InitIfNot()
		{
		}

		// Token: 0x060277DA RID: 161754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60277DA")]
		[Address(RVA = "0x22AF650", Offset = "0x22AE250", VA = "0x1822AF650")]
		public void Render(ArchiveRelicItemGroupModel groupModel, string selectItemId, bool showAnim)
		{
		}

		// Token: 0x060277DB RID: 161755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60277DB")]
		[Address(RVA = "0x22AFD30", Offset = "0x22AE930", VA = "0x1822AFD30")]
		public ArchiveRelicListGroupView()
		{
		}

		// Token: 0x04037F9A RID: 229274
		[Token(Token = "0x4037F9A")]
		private const int NUM_ITEM_PER_LINE = 5;

		// Token: 0x04037F9B RID: 229275
		[Token(Token = "0x4037F9B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _imgTitle;

		// Token: 0x04037F9C RID: 229276
		[Token(Token = "0x4037F9C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _panelItem;

		// Token: 0x04037F9D RID: 229277
		[Token(Token = "0x4037F9D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textAttainNum;

		// Token: 0x04037F9E RID: 229278
		[Token(Token = "0x4037F9E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ArchiveRelicListItemView _relicItemView;

		// Token: 0x04037F9F RID: 229279
		[Token(Token = "0x4037F9F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelAttainNum;

		// Token: 0x04037FA0 RID: 229280
		[Token(Token = "0x4037FA0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<string> _titleImageName;

		// Token: 0x04037FA1 RID: 229281
		[Token(Token = "0x4037FA1")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAtlasObject _titleImage;

		// Token: 0x04037FA2 RID: 229282
		[Token(Token = "0x4037FA2")]
		[FieldOffset(Offset = "0x50")]
		private bool m_hasInited;

		// Token: 0x04037FA3 RID: 229283
		[Token(Token = "0x4037FA3")]
		[FieldOffset(Offset = "0x58")]
		private List<ArchiveRelicListItemView> m_itemGroup;

		// Token: 0x04037FA5 RID: 229285
		[Token(Token = "0x4037FA5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x04037FA6 RID: 229286
		[Token(Token = "0x4037FA6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x04037FA7 RID: 229287
		[Token(Token = "0x4037FA7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04037FA8 RID: 229288
		[Token(Token = "0x4037FA8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04037FA9 RID: 229289
		[Token(Token = "0x4037FA9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
