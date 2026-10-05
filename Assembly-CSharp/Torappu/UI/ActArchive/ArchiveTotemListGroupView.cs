using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C47 RID: 27719
	[Token(Token = "0x2006C47")]
	public class ArchiveTotemListGroupView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005D7B RID: 23931
		// (get) Token: 0x06027915 RID: 162069 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06027916 RID: 162070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005D7B")]
		public ArchiveTotemController controller
		{
			[Token(Token = "0x6027915")]
			[Address(RVA = "0x22C22D0", Offset = "0x22C0ED0", VA = "0x1822C22D0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6027916")]
			[Address(RVA = "0x22C2330", Offset = "0x22C0F30", VA = "0x1822C2330")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06027917 RID: 162071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027917")]
		[Address(RVA = "0x22C1EC0", Offset = "0x22C0AC0", VA = "0x1822C1EC0")]
		public void Render(ArchiveTotemGroupModel model, string selectedItem, bool showSwitchAnim)
		{
		}

		// Token: 0x06027918 RID: 162072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027918")]
		[Address(RVA = "0x22C2150", Offset = "0x22C0D50", VA = "0x1822C2150")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06027919 RID: 162073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027919")]
		[Address(RVA = "0x22C2270", Offset = "0x22C0E70", VA = "0x1822C2270")]
		public ArchiveTotemListGroupView()
		{
		}

		// Token: 0x040381BF RID: 229823
		[Token(Token = "0x40381BF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<ArchiveTotemListGroupView.FlagPanel> _flagPanels;

		// Token: 0x040381C0 RID: 229824
		[Token(Token = "0x40381C0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _itemContent;

		// Token: 0x040381C1 RID: 229825
		[Token(Token = "0x40381C1")]
		[FieldOffset(Offset = "0x28")]
		private bool m_hasInited;

		// Token: 0x040381C2 RID: 229826
		[Token(Token = "0x40381C2")]
		[FieldOffset(Offset = "0x30")]
		private ArchiveTotemListGroupView.Adapter m_adapter;

		// Token: 0x040381C3 RID: 229827
		[Token(Token = "0x40381C3")]
		[FieldOffset(Offset = "0x38")]
		private List<TotemItemModel> m_cachedItems;

		// Token: 0x040381C4 RID: 229828
		[Token(Token = "0x40381C4")]
		[FieldOffset(Offset = "0x40")]
		private string m_selectedItem;

		// Token: 0x040381C5 RID: 229829
		[Token(Token = "0x40381C5")]
		[FieldOffset(Offset = "0x48")]
		private bool m_showSwitchAnim;

		// Token: 0x040381C7 RID: 229831
		[Token(Token = "0x40381C7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x040381C8 RID: 229832
		[Token(Token = "0x40381C8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x040381C9 RID: 229833
		[Token(Token = "0x40381C9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040381CA RID: 229834
		[Token(Token = "0x40381CA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040381CB RID: 229835
		[Token(Token = "0x40381CB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006C48 RID: 27720
		[Token(Token = "0x2006C48")]
		[Serializable]
		public struct FlagPanel
		{
			// Token: 0x040381CC RID: 229836
			[Token(Token = "0x40381CC")]
			[FieldOffset(Offset = "0x0")]
			public ActArchiveTotemType flag;

			// Token: 0x040381CD RID: 229837
			[Token(Token = "0x40381CD")]
			[FieldOffset(Offset = "0x8")]
			public GameObject panel;
		}

		// Token: 0x02006C49 RID: 27721
		[Token(Token = "0x2006C49")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x0602791A RID: 162074 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602791A")]
			[Address(RVA = "0x22BFBA0", Offset = "0x22BE7A0", VA = "0x1822BFBA0")]
			public Adapter(ArchiveTotemListGroupView closure)
			{
			}

			// Token: 0x17005D7C RID: 23932
			// (get) Token: 0x0602791B RID: 162075 RVA: 0x000CEB80 File Offset: 0x000CCD80
			[Token(Token = "0x17005D7C")]
			public override int count
			{
				[Token(Token = "0x602791B")]
				[Address(RVA = "0x22BFC20", Offset = "0x22BE820", VA = "0x1822BFC20", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602791C RID: 162076 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602791C")]
			[Address(RVA = "0x22BF910", Offset = "0x22BE510", VA = "0x1822BF910", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x040381CE RID: 229838
			[Token(Token = "0x40381CE")]
			[FieldOffset(Offset = "0x20")]
			private ArchiveTotemListGroupView m_closure;

			// Token: 0x040381CF RID: 229839
			[Token(Token = "0x40381CF")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040381D0 RID: 229840
			[Token(Token = "0x40381D0")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040381D1 RID: 229841
			[Token(Token = "0x40381D1")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
