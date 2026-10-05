using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.AVG;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.Dialog
{
	// Token: 0x02002826 RID: 10278
	[Token(Token = "0x2002826")]
	public class DialogSandboxUIPlugin : MonoBehaviour, DialogPanel.IPlugin, IHotfixable
	{
		// Token: 0x060111C7 RID: 70087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60111C7")]
		[Address(RVA = "0x90B0F0", Offset = "0x909CF0", VA = "0x18090B0F0", Slot = "4")]
		public Dictionary<string, BattleStoryTree.Executor> GetExecutors()
		{
			return null;
		}

		// Token: 0x060111C8 RID: 70088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60111C8")]
		[Address(RVA = "0x90BA10", Offset = "0x90A610", VA = "0x18090BA10")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060111C9 RID: 70089 RVA: 0x000696F0 File Offset: 0x000678F0
		[Token(Token = "0x60111C9")]
		[Address(RVA = "0x90B780", Offset = "0x90A380", VA = "0x18090B780")]
		private bool _ExecuteUIOperation(Command command)
		{
			return default(bool);
		}

		// Token: 0x060111CA RID: 70090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60111CA")]
		[Address(RVA = "0x90BBC0", Offset = "0x90A7C0", VA = "0x18090BBC0")]
		private void _UpdateBag(Command command)
		{
		}

		// Token: 0x060111CB RID: 70091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60111CB")]
		[Address(RVA = "0x90B810", Offset = "0x90A410", VA = "0x18090B810")]
		private void _ExecuteUiOperationItem(Command command)
		{
		}

		// Token: 0x060111CC RID: 70092 RVA: 0x00069708 File Offset: 0x00067908
		[Token(Token = "0x60111CC")]
		[Address(RVA = "0x90B530", Offset = "0x90A130", VA = "0x18090B530")]
		private bool _ExecuteHeader(Command command)
		{
			return default(bool);
		}

		// Token: 0x060111CD RID: 70093 RVA: 0x00069720 File Offset: 0x00067920
		[Token(Token = "0x60111CD")]
		[Address(RVA = "0x90B450", Offset = "0x90A050", VA = "0x18090B450")]
		private bool _ExecuteEnd(Command command)
		{
			return default(bool);
		}

		// Token: 0x060111CE RID: 70094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60111CE")]
		[Address(RVA = "0x90BDE0", Offset = "0x90A9E0", VA = "0x18090BDE0")]
		private void _UpdateBag(bool enable)
		{
		}

		// Token: 0x060111CF RID: 70095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60111CF")]
		[Address(RVA = "0x90B2E0", Offset = "0x909EE0", VA = "0x18090B2E0")]
		public void OnBagBtnClicked()
		{
		}

		// Token: 0x060111D0 RID: 70096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60111D0")]
		[Address(RVA = "0x90BF10", Offset = "0x90AB10", VA = "0x18090BF10")]
		public DialogSandboxUIPlugin()
		{
		}

		// Token: 0x040132CB RID: 78539
		[Token(Token = "0x40132CB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private DialogSandboxUIPluginIconPair _iconPrefab;

		// Token: 0x040132CC RID: 78540
		[Token(Token = "0x40132CC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button _bag;

		// Token: 0x040132CD RID: 78541
		[Token(Token = "0x40132CD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _iconRoot;

		// Token: 0x040132CE RID: 78542
		[Token(Token = "0x40132CE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _fadeDuration;

		// Token: 0x040132CF RID: 78543
		[Token(Token = "0x40132CF")]
		[FieldOffset(Offset = "0x38")]
		private DialogSandboxUIPlugin.IconListAdapter m_adapter;

		// Token: 0x040132D0 RID: 78544
		[Token(Token = "0x40132D0")]
		[FieldOffset(Offset = "0x40")]
		private bool m_inited;

		// Token: 0x040132D1 RID: 78545
		[Token(Token = "0x40132D1")]
		[FieldOffset(Offset = "0x48")]
		private List<string> m_iconDatas;

		// Token: 0x040132D2 RID: 78546
		[Token(Token = "0x40132D2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetExecutors;

		// Token: 0x040132D3 RID: 78547
		[Token(Token = "0x40132D3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040132D4 RID: 78548
		[Token(Token = "0x40132D4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ExecuteUIOperation;

		// Token: 0x040132D5 RID: 78549
		[Token(Token = "0x40132D5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateBag;

		// Token: 0x040132D6 RID: 78550
		[Token(Token = "0x40132D6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ExecuteUiOperationItem;

		// Token: 0x040132D7 RID: 78551
		[Token(Token = "0x40132D7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ExecuteHeader;

		// Token: 0x040132D8 RID: 78552
		[Token(Token = "0x40132D8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ExecuteEnd;

		// Token: 0x040132D9 RID: 78553
		[Token(Token = "0x40132D9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix1__UpdateBag;

		// Token: 0x040132DA RID: 78554
		[Token(Token = "0x40132DA")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnBagBtnClicked;

		// Token: 0x040132DB RID: 78555
		[Token(Token = "0x40132DB")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002827 RID: 10279
		[Token(Token = "0x2002827")]
		private class IconListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x170025B9 RID: 9657
			// (get) Token: 0x060111D1 RID: 70097 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060111D2 RID: 70098 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170025B9")]
			public List<string> dataSet
			{
				[Token(Token = "0x60111D1")]
				[Address(RVA = "0x90F5B0", Offset = "0x90E1B0", VA = "0x18090F5B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60111D2")]
				[Address(RVA = "0x90F610", Offset = "0x90E210", VA = "0x18090F610")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170025BA RID: 9658
			// (get) Token: 0x060111D3 RID: 70099 RVA: 0x00069738 File Offset: 0x00067938
			[Token(Token = "0x170025BA")]
			public override int count
			{
				[Token(Token = "0x60111D3")]
				[Address(RVA = "0x90F500", Offset = "0x90E100", VA = "0x18090F500", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060111D4 RID: 70100 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60111D4")]
			[Address(RVA = "0x90F2D0", Offset = "0x90DED0", VA = "0x18090F2D0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x060111D5 RID: 70101 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60111D5")]
			[Address(RVA = "0x90F4A0", Offset = "0x90E0A0", VA = "0x18090F4A0")]
			public IconListAdapter()
			{
			}

			// Token: 0x040132DC RID: 78556
			[Token(Token = "0x40132DC")]
			[FieldOffset(Offset = "0x20")]
			public DialogSandboxUIPluginIconPair prefab;

			// Token: 0x040132DE RID: 78558
			[Token(Token = "0x40132DE")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_dataSet;

			// Token: 0x040132DF RID: 78559
			[Token(Token = "0x40132DF")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_dataSet;

			// Token: 0x040132E0 RID: 78560
			[Token(Token = "0x40132E0")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040132E1 RID: 78561
			[Token(Token = "0x40132E1")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x040132E2 RID: 78562
			[Token(Token = "0x40132E2")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
