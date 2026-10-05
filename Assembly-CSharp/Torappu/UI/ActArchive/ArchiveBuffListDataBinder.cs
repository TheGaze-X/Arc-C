using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B13 RID: 27411
	[Token(Token = "0x2006B13")]
	public class ArchiveBuffListDataBinder : DataBinder<BuffProperty>
	{
		// Token: 0x17005C9F RID: 23711
		// (get) Token: 0x06027316 RID: 160534 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06027317 RID: 160535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005C9F")]
		public ActArchiveController controller
		{
			[Token(Token = "0x6027316")]
			[Address(RVA = "0x2257120", Offset = "0x2255D20", VA = "0x182257120")]
			private get
			{
				return null;
			}
			[Token(Token = "0x6027317")]
			[Address(RVA = "0x2257180", Offset = "0x2255D80", VA = "0x182257180")]
			set
			{
			}
		}

		// Token: 0x06027318 RID: 160536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027318")]
		[Address(RVA = "0x2256C10", Offset = "0x2255810", VA = "0x182256C10", Slot = "7")]
		public override void OnValueChanged(BuffProperty property)
		{
		}

		// Token: 0x06027319 RID: 160537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027319")]
		[Address(RVA = "0x2256ED0", Offset = "0x2255AD0", VA = "0x182256ED0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602731A RID: 160538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602731A")]
		[Address(RVA = "0x22570B0", Offset = "0x2255CB0", VA = "0x1822570B0")]
		public ArchiveBuffListDataBinder()
		{
		}

		// Token: 0x04037711 RID: 227089
		[Token(Token = "0x4037711")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _icon;

		// Token: 0x04037712 RID: 227090
		[Token(Token = "0x4037712")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _iconBack;

		// Token: 0x04037713 RID: 227091
		[Token(Token = "0x4037713")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _name;

		// Token: 0x04037714 RID: 227092
		[Token(Token = "0x4037714")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _usage;

		// Token: 0x04037715 RID: 227093
		[Token(Token = "0x4037715")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _desc;

		// Token: 0x04037716 RID: 227094
		[Token(Token = "0x4037716")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SimpleLayoutContent _groupContent;

		// Token: 0x04037717 RID: 227095
		[Token(Token = "0x4037717")]
		[FieldOffset(Offset = "0x50")]
		private ActArchiveController m_controller;

		// Token: 0x04037718 RID: 227096
		[Token(Token = "0x4037718")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isInited;

		// Token: 0x04037719 RID: 227097
		[Token(Token = "0x4037719")]
		[FieldOffset(Offset = "0x60")]
		private ArchiveBuffListDataBinder.ArchiveBuffGroupAdapter m_adapter;

		// Token: 0x0403771A RID: 227098
		[Token(Token = "0x403771A")]
		[FieldOffset(Offset = "0x68")]
		protected BuffProxy m_proxy;

		// Token: 0x0403771B RID: 227099
		[Token(Token = "0x403771B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x0403771C RID: 227100
		[Token(Token = "0x403771C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x0403771D RID: 227101
		[Token(Token = "0x403771D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403771E RID: 227102
		[Token(Token = "0x403771E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403771F RID: 227103
		[Token(Token = "0x403771F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006B14 RID: 27412
		[Token(Token = "0x2006B14")]
		public class ArchiveBuffGroupAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0602731B RID: 160539 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602731B")]
			[Address(RVA = "0x2256B10", Offset = "0x2255710", VA = "0x182256B10")]
			public ArchiveBuffGroupAdapter(ArchiveBuffListDataBinder closure)
			{
			}

			// Token: 0x17005CA0 RID: 23712
			// (get) Token: 0x0602731C RID: 160540 RVA: 0x000CDA10 File Offset: 0x000CBC10
			[Token(Token = "0x17005CA0")]
			public override int count
			{
				[Token(Token = "0x602731C")]
				[Address(RVA = "0x2256B90", Offset = "0x2255790", VA = "0x182256B90", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602731D RID: 160541 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602731D")]
			[Address(RVA = "0x2256820", Offset = "0x2255420", VA = "0x182256820", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04037720 RID: 227104
			[Token(Token = "0x4037720")]
			[FieldOffset(Offset = "0x20")]
			private ArchiveBuffListDataBinder m_closure;

			// Token: 0x04037721 RID: 227105
			[Token(Token = "0x4037721")]
			[FieldOffset(Offset = "0x28")]
			public ArchiveBuffModel viewModel;

			// Token: 0x04037722 RID: 227106
			[Token(Token = "0x4037722")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04037723 RID: 227107
			[Token(Token = "0x4037723")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04037724 RID: 227108
			[Token(Token = "0x4037724")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
