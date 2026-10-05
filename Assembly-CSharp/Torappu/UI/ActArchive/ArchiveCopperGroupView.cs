using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B53 RID: 27475
	[Token(Token = "0x2006B53")]
	public class ArchiveCopperGroupView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005CC8 RID: 23752
		// (get) Token: 0x0602743B RID: 160827 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602743C RID: 160828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005CC8")]
		public ArchiveCopperController controller
		{
			[Token(Token = "0x602743B")]
			[Address(RVA = "0x22705D0", Offset = "0x226F1D0", VA = "0x1822705D0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602743C")]
			[Address(RVA = "0x2270630", Offset = "0x226F230", VA = "0x182270630")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602743D RID: 160829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602743D")]
		[Address(RVA = "0x2270160", Offset = "0x226ED60", VA = "0x182270160")]
		public void Render(ArchiveCopperGroupModel model)
		{
		}

		// Token: 0x0602743E RID: 160830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602743E")]
		[Address(RVA = "0x2270400", Offset = "0x226F000", VA = "0x182270400")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602743F RID: 160831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602743F")]
		[Address(RVA = "0x2270520", Offset = "0x226F120", VA = "0x182270520")]
		public ArchiveCopperGroupView()
		{
		}

		// Token: 0x0403793B RID: 227643
		[Token(Token = "0x403793B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelTitle;

		// Token: 0x0403793C RID: 227644
		[Token(Token = "0x403793C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelDefault;

		// Token: 0x0403793D RID: 227645
		[Token(Token = "0x403793D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgTitle;

		// Token: 0x0403793E RID: 227646
		[Token(Token = "0x403793E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SimpleLayoutContent _copperContent;

		// Token: 0x0403793F RID: 227647
		[Token(Token = "0x403793F")]
		[FieldOffset(Offset = "0x38")]
		private bool m_hasInited;

		// Token: 0x04037940 RID: 227648
		[Token(Token = "0x4037940")]
		[FieldOffset(Offset = "0x40")]
		private ArchiveCopperGroupView.Adapter m_adapter;

		// Token: 0x04037941 RID: 227649
		[Token(Token = "0x4037941")]
		[FieldOffset(Offset = "0x48")]
		private List<CopperItemModel> m_itemModelList;

		// Token: 0x04037943 RID: 227651
		[Token(Token = "0x4037943")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x04037944 RID: 227652
		[Token(Token = "0x4037944")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x04037945 RID: 227653
		[Token(Token = "0x4037945")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04037946 RID: 227654
		[Token(Token = "0x4037946")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04037947 RID: 227655
		[Token(Token = "0x4037947")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006B54 RID: 27476
		[Token(Token = "0x2006B54")]
		private class Adapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x06027440 RID: 160832 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027440")]
			[Address(RVA = "0x22625F0", Offset = "0x22611F0", VA = "0x1822625F0")]
			public Adapter(ArchiveCopperGroupView closure)
			{
			}

			// Token: 0x17005CC9 RID: 23753
			// (get) Token: 0x06027441 RID: 160833 RVA: 0x000CDD88 File Offset: 0x000CBF88
			[Token(Token = "0x17005CC9")]
			public override int count
			{
				[Token(Token = "0x6027441")]
				[Address(RVA = "0x22626E0", Offset = "0x22612E0", VA = "0x1822626E0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06027442 RID: 160834 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6027442")]
			[Address(RVA = "0x2262010", Offset = "0x2260C10", VA = "0x182262010", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04037948 RID: 227656
			[Token(Token = "0x4037948")]
			[FieldOffset(Offset = "0x20")]
			private ArchiveCopperGroupView m_closure;

			// Token: 0x04037949 RID: 227657
			[Token(Token = "0x4037949")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403794A RID: 227658
			[Token(Token = "0x403794A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403794B RID: 227659
			[Token(Token = "0x403794B")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
