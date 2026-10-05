using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B85 RID: 27525
	[Token(Token = "0x2006B85")]
	public class ArchiveFragmentGroupView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005CE1 RID: 23777
		// (get) Token: 0x0602752F RID: 161071 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06027530 RID: 161072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005CE1")]
		public Action<string> onItemClicked
		{
			[Token(Token = "0x602752F")]
			[Address(RVA = "0x22817F0", Offset = "0x22803F0", VA = "0x1822817F0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6027530")]
			[Address(RVA = "0x2281850", Offset = "0x2280450", VA = "0x182281850")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06027531 RID: 161073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027531")]
		[Address(RVA = "0x2281370", Offset = "0x227FF70", VA = "0x182281370")]
		public void Render(ArchiveFragmentGroupModel model, bool showSwitchAnim, string selectedItemId)
		{
		}

		// Token: 0x06027532 RID: 161074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027532")]
		[Address(RVA = "0x2281620", Offset = "0x2280220", VA = "0x182281620")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06027533 RID: 161075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027533")]
		[Address(RVA = "0x2281740", Offset = "0x2280340", VA = "0x182281740")]
		public ArchiveFragmentGroupView()
		{
		}

		// Token: 0x04037B30 RID: 228144
		[Token(Token = "0x4037B30")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelTitle;

		// Token: 0x04037B31 RID: 228145
		[Token(Token = "0x4037B31")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelFragment;

		// Token: 0x04037B32 RID: 228146
		[Token(Token = "0x4037B32")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _fragmentContent;

		// Token: 0x04037B33 RID: 228147
		[Token(Token = "0x4037B33")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ArchiveFragmentGroupView.TitleConfig[] _titleConfigList;

		// Token: 0x04037B34 RID: 228148
		[Token(Token = "0x4037B34")]
		[FieldOffset(Offset = "0x38")]
		private bool m_hasInited;

		// Token: 0x04037B35 RID: 228149
		[Token(Token = "0x4037B35")]
		[FieldOffset(Offset = "0x40")]
		private ArchiveFragmentGroupView.Adapter m_adapter;

		// Token: 0x04037B36 RID: 228150
		[Token(Token = "0x4037B36")]
		[FieldOffset(Offset = "0x48")]
		private List<FragmentItemModel> m_itemModelList;

		// Token: 0x04037B37 RID: 228151
		[Token(Token = "0x4037B37")]
		[FieldOffset(Offset = "0x50")]
		private bool m_cachedShowSwitchAnim;

		// Token: 0x04037B38 RID: 228152
		[Token(Token = "0x4037B38")]
		[FieldOffset(Offset = "0x58")]
		private string m_cachedSelectedItemId;

		// Token: 0x04037B3A RID: 228154
		[Token(Token = "0x4037B3A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onItemClicked;

		// Token: 0x04037B3B RID: 228155
		[Token(Token = "0x4037B3B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onItemClicked;

		// Token: 0x04037B3C RID: 228156
		[Token(Token = "0x4037B3C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04037B3D RID: 228157
		[Token(Token = "0x4037B3D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04037B3E RID: 228158
		[Token(Token = "0x4037B3E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006B86 RID: 27526
		[Token(Token = "0x2006B86")]
		[Serializable]
		private struct TitleConfig
		{
			// Token: 0x04037B3F RID: 228159
			[Token(Token = "0x4037B3F")]
			[FieldOffset(Offset = "0x0")]
			public RoguelikeFragmentType type;

			// Token: 0x04037B40 RID: 228160
			[Token(Token = "0x4037B40")]
			[FieldOffset(Offset = "0x8")]
			public GameObject titleObj;
		}

		// Token: 0x02006B87 RID: 27527
		[Token(Token = "0x2006B87")]
		private class Adapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x06027534 RID: 161076 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027534")]
			[Address(RVA = "0x2279020", Offset = "0x2277C20", VA = "0x182279020")]
			public Adapter(ArchiveFragmentGroupView closure)
			{
			}

			// Token: 0x17005CE2 RID: 23778
			// (get) Token: 0x06027535 RID: 161077 RVA: 0x000CE0D0 File Offset: 0x000CC2D0
			[Token(Token = "0x17005CE2")]
			public override int count
			{
				[Token(Token = "0x6027535")]
				[Address(RVA = "0x2279110", Offset = "0x2277D10", VA = "0x182279110", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06027536 RID: 161078 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6027536")]
			[Address(RVA = "0x22789F0", Offset = "0x22775F0", VA = "0x1822789F0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04037B41 RID: 228161
			[Token(Token = "0x4037B41")]
			[FieldOffset(Offset = "0x20")]
			private ArchiveFragmentGroupView m_closure;

			// Token: 0x04037B42 RID: 228162
			[Token(Token = "0x4037B42")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04037B43 RID: 228163
			[Token(Token = "0x4037B43")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04037B44 RID: 228164
			[Token(Token = "0x4037B44")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
