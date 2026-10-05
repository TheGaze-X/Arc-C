using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI.Sandbox
{
	// Token: 0x020033A2 RID: 13218
	[Token(Token = "0x20033A2")]
	public class UIBattleSandboxBagPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003210 RID: 12816
		// (get) Token: 0x0601516A RID: 86378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003210")]
		private GameModeFactory.SandboxGameMode sandboxGameMode
		{
			[Token(Token = "0x601516A")]
			[Address(RVA = "0xD84030", Offset = "0xD82C30", VA = "0x180D84030")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601516B RID: 86379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601516B")]
		[Address(RVA = "0xD83750", Offset = "0xD82350", VA = "0x180D83750")]
		public void Init()
		{
		}

		// Token: 0x0601516C RID: 86380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601516C")]
		[Address(RVA = "0xD83C50", Offset = "0xD82850", VA = "0x180D83C50")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601516D RID: 86381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601516D")]
		[Address(RVA = "0xD837B0", Offset = "0xD823B0", VA = "0x180D837B0")]
		public void OnItemCollect(string itemId, int count)
		{
		}

		// Token: 0x0601516E RID: 86382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601516E")]
		[Address(RVA = "0xD83970", Offset = "0xD82570", VA = "0x180D83970")]
		public void Render(Action callback)
		{
		}

		// Token: 0x0601516F RID: 86383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601516F")]
		[Address(RVA = "0xD836E0", Offset = "0xD822E0", VA = "0x180D836E0")]
		public void CloseBagPanel()
		{
		}

		// Token: 0x06015170 RID: 86384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015170")]
		[Address(RVA = "0xD83FD0", Offset = "0xD82BD0", VA = "0x180D83FD0")]
		public UIBattleSandboxBagPanel()
		{
		}

		// Token: 0x040191B0 RID: 102832
		[Token(Token = "0x40191B0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _resList;

		// Token: 0x040191B1 RID: 102833
		[Token(Token = "0x40191B1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _totalCountList;

		// Token: 0x040191B2 RID: 102834
		[Token(Token = "0x40191B2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _goldText;

		// Token: 0x040191B3 RID: 102835
		[Token(Token = "0x40191B3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _coinText;

		// Token: 0x040191B4 RID: 102836
		[Token(Token = "0x40191B4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _emptyIcon;

		// Token: 0x040191B5 RID: 102837
		[Token(Token = "0x40191B5")]
		[FieldOffset(Offset = "0x40")]
		private GameModeFactory.SandboxGameMode m_gameMode;

		// Token: 0x040191B6 RID: 102838
		[Token(Token = "0x40191B6")]
		[FieldOffset(Offset = "0x48")]
		private UIBattleSandboxBagPanel.SandboxItemListAdapter m_resAdapter;

		// Token: 0x040191B7 RID: 102839
		[Token(Token = "0x40191B7")]
		[FieldOffset(Offset = "0x50")]
		private UIBattleSandboxBagPanel.SandboxSmallItemListAdapter m_totalCountList;

		// Token: 0x040191B8 RID: 102840
		[Token(Token = "0x40191B8")]
		[FieldOffset(Offset = "0x58")]
		private bool m_hasInited;

		// Token: 0x040191B9 RID: 102841
		[Token(Token = "0x40191B9")]
		[FieldOffset(Offset = "0x60")]
		private Action m_callback;

		// Token: 0x040191BA RID: 102842
		[Token(Token = "0x40191BA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_sandboxGameMode;

		// Token: 0x040191BB RID: 102843
		[Token(Token = "0x40191BB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x040191BC RID: 102844
		[Token(Token = "0x40191BC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040191BD RID: 102845
		[Token(Token = "0x40191BD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnItemCollect;

		// Token: 0x040191BE RID: 102846
		[Token(Token = "0x40191BE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040191BF RID: 102847
		[Token(Token = "0x40191BF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CloseBagPanel;

		// Token: 0x040191C0 RID: 102848
		[Token(Token = "0x40191C0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020033A3 RID: 13219
		[Token(Token = "0x20033A3")]
		private class SandboxItemListAdapter : SimpleLayoutAdapter, IComparer<string>
		{
			// Token: 0x06015171 RID: 86385 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015171")]
			[Address(RVA = "0xD82F80", Offset = "0xD81B80", VA = "0x180D82F80")]
			public SandboxItemListAdapter(UIBattleSandboxBagPanel panel)
			{
			}

			// Token: 0x17003211 RID: 12817
			// (get) Token: 0x06015172 RID: 86386 RVA: 0x0008A5E8 File Offset: 0x000887E8
			[Token(Token = "0x17003211")]
			public override int count
			{
				[Token(Token = "0x6015172")]
				[Address(RVA = "0xD83050", Offset = "0xD81C50", VA = "0x180D83050", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06015173 RID: 86387 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6015173")]
			[Address(RVA = "0xD82D40", Offset = "0xD81940", VA = "0x180D82D40", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06015174 RID: 86388 RVA: 0x0008A600 File Offset: 0x00088800
			[Token(Token = "0x6015174")]
			[Address(RVA = "0xD82C20", Offset = "0xD81820", VA = "0x180D82C20", Slot = "9")]
			public int Compare(string lhs, string rhs)
			{
				return 0;
			}

			// Token: 0x040191C1 RID: 102849
			[Token(Token = "0x40191C1")]
			[FieldOffset(Offset = "0x20")]
			private UIBattleSandboxBagPanel m_panel;

			// Token: 0x040191C2 RID: 102850
			[Token(Token = "0x40191C2")]
			[FieldOffset(Offset = "0x28")]
			public readonly List<string> bagResAdditionList;

			// Token: 0x040191C3 RID: 102851
			[Token(Token = "0x40191C3")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040191C4 RID: 102852
			[Token(Token = "0x40191C4")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040191C5 RID: 102853
			[Token(Token = "0x40191C5")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x040191C6 RID: 102854
			[Token(Token = "0x40191C6")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_Compare;
		}

		// Token: 0x020033A4 RID: 13220
		[Token(Token = "0x20033A4")]
		private class SandboxSmallItemListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17003212 RID: 12818
			// (get) Token: 0x06015175 RID: 86389 RVA: 0x0008A618 File Offset: 0x00088818
			[Token(Token = "0x17003212")]
			public override int count
			{
				[Token(Token = "0x6015175")]
				[Address(RVA = "0xD832F0", Offset = "0xD81EF0", VA = "0x180D832F0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06015176 RID: 86390 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6015176")]
			[Address(RVA = "0xD830C0", Offset = "0xD81CC0", VA = "0x180D830C0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06015177 RID: 86391 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015177")]
			[Address(RVA = "0xD83290", Offset = "0xD81E90", VA = "0x180D83290")]
			public SandboxSmallItemListAdapter()
			{
			}

			// Token: 0x040191C7 RID: 102855
			[Token(Token = "0x40191C7")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040191C8 RID: 102856
			[Token(Token = "0x40191C8")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x040191C9 RID: 102857
			[Token(Token = "0x40191C9")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
