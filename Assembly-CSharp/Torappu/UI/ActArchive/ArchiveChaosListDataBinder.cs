using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B34 RID: 27444
	[Token(Token = "0x2006B34")]
	public class ArchiveChaosListDataBinder : DataBinder<ChaosProperty>
	{
		// Token: 0x17005CB5 RID: 23733
		// (get) Token: 0x060273B6 RID: 160694 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060273B7 RID: 160695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005CB5")]
		public ArchiveChaosController controller
		{
			[Token(Token = "0x60273B6")]
			[Address(RVA = "0x22692B0", Offset = "0x2267EB0", VA = "0x1822692B0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60273B7")]
			[Address(RVA = "0x2269320", Offset = "0x2267F20", VA = "0x182269320")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060273B8 RID: 160696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60273B8")]
		[Address(RVA = "0x2268B80", Offset = "0x2267780", VA = "0x182268B80", Slot = "7")]
		public override void OnValueChanged(ChaosProperty property)
		{
		}

		// Token: 0x060273B9 RID: 160697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60273B9")]
		[Address(RVA = "0x2269040", Offset = "0x2267C40", VA = "0x182269040")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060273BA RID: 160698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60273BA")]
		[Address(RVA = "0x2269220", Offset = "0x2267E20", VA = "0x182269220")]
		public ArchiveChaosListDataBinder()
		{
		}

		// Token: 0x04037820 RID: 227360
		[Token(Token = "0x4037820")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color ATTAINED_COLOR;

		// Token: 0x04037821 RID: 227361
		[Token(Token = "0x4037821")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Color UNATTAINED_COLOR;

		// Token: 0x04037822 RID: 227362
		[Token(Token = "0x4037822")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _iconImage;

		// Token: 0x04037823 RID: 227363
		[Token(Token = "0x4037823")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ArchiveChaosSideView _leftSideView;

		// Token: 0x04037824 RID: 227364
		[Token(Token = "0x4037824")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ArchiveChaosSideView _rightSideView;

		// Token: 0x04037825 RID: 227365
		[Token(Token = "0x4037825")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x04037826 RID: 227366
		[Token(Token = "0x4037826")]
		[FieldOffset(Offset = "0x40")]
		private bool m_hasInited;

		// Token: 0x04037827 RID: 227367
		[Token(Token = "0x4037827")]
		[FieldOffset(Offset = "0x48")]
		private ArchiveChaosListDataBinder.Adapter m_adapter;

		// Token: 0x04037828 RID: 227368
		[Token(Token = "0x4037828")]
		[FieldOffset(Offset = "0x50")]
		private List<ChaosItemModel> m_cachedItems;

		// Token: 0x04037829 RID: 227369
		[Token(Token = "0x4037829")]
		[FieldOffset(Offset = "0x58")]
		private string m_cachedSelectedItemId;

		// Token: 0x0403782A RID: 227370
		[Token(Token = "0x403782A")]
		[FieldOffset(Offset = "0x60")]
		private bool m_showSwitchAnim;

		// Token: 0x0403782C RID: 227372
		[Token(Token = "0x403782C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x0403782D RID: 227373
		[Token(Token = "0x403782D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x0403782E RID: 227374
		[Token(Token = "0x403782E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403782F RID: 227375
		[Token(Token = "0x403782F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04037830 RID: 227376
		[Token(Token = "0x4037830")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006B35 RID: 27445
		[Token(Token = "0x2006B35")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x060273BC RID: 160700 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60273BC")]
			[Address(RVA = "0x22624F0", Offset = "0x22610F0", VA = "0x1822624F0")]
			public Adapter(ArchiveChaosListDataBinder closure)
			{
			}

			// Token: 0x17005CB6 RID: 23734
			// (get) Token: 0x060273BD RID: 160701 RVA: 0x000CDC38 File Offset: 0x000CBE38
			[Token(Token = "0x17005CB6")]
			public override int count
			{
				[Token(Token = "0x60273BD")]
				[Address(RVA = "0x2262830", Offset = "0x2261430", VA = "0x182262830", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060273BE RID: 160702 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60273BE")]
			[Address(RVA = "0x2262280", Offset = "0x2260E80", VA = "0x182262280", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04037831 RID: 227377
			[Token(Token = "0x4037831")]
			[FieldOffset(Offset = "0x20")]
			private ArchiveChaosListDataBinder m_closure;

			// Token: 0x04037832 RID: 227378
			[Token(Token = "0x4037832")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04037833 RID: 227379
			[Token(Token = "0x4037833")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04037834 RID: 227380
			[Token(Token = "0x4037834")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
