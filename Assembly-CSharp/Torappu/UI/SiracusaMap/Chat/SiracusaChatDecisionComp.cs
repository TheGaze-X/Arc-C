using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.AVG;
using Torappu.UI.ChatBox;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SiracusaMap.Chat
{
	// Token: 0x02003FAC RID: 16300
	[Token(Token = "0x2003FAC")]
	public class SiracusaChatDecisionComp : SiracusaChatSwitchableComp
	{
		// Token: 0x06019488 RID: 103560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019488")]
		[Address(RVA = "0x1207D50", Offset = "0x1206950", VA = "0x181207D50")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019489 RID: 103561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019489")]
		[Address(RVA = "0x1207FC0", Offset = "0x1206BC0", VA = "0x181207FC0")]
		private void _RenderForDecisions(SiracusaChatDecisionComp.OptionRenderOptions[] options)
		{
		}

		// Token: 0x0601948A RID: 103562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601948A")]
		[Address(RVA = "0x1207EE0", Offset = "0x1206AE0", VA = "0x181207EE0")]
		private void _RenderForDecided(string content)
		{
		}

		// Token: 0x0601948B RID: 103563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601948B")]
		[Address(RVA = "0x1207E60", Offset = "0x1206A60", VA = "0x181207E60")]
		private void _MakeDecision(int index)
		{
		}

		// Token: 0x0601948C RID: 103564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601948C")]
		[Address(RVA = "0x12080D0", Offset = "0x1206CD0", VA = "0x1812080D0")]
		public SiracusaChatDecisionComp()
		{
		}

		// Token: 0x0401F655 RID: 128597
		[Token(Token = "0x401F655")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _textPadding;

		// Token: 0x0401F656 RID: 128598
		[Token(Token = "0x401F656")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float _transTime;

		// Token: 0x0401F657 RID: 128599
		[Token(Token = "0x401F657")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private VerticalLayoutGroup _innerLayout;

		// Token: 0x0401F658 RID: 128600
		[Token(Token = "0x401F658")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SiracusaChatDecisionItem _itemPrefab;

		// Token: 0x0401F659 RID: 128601
		[Token(Token = "0x401F659")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0401F65A RID: 128602
		[Token(Token = "0x401F65A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _decisionResult;

		// Token: 0x0401F65B RID: 128603
		[Token(Token = "0x401F65B")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private CanvasGroup _decisionGroup;

		// Token: 0x0401F65C RID: 128604
		[Token(Token = "0x401F65C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CanvasGroup _resultGroup;

		// Token: 0x0401F65D RID: 128605
		[Token(Token = "0x401F65D")]
		[FieldOffset(Offset = "0x78")]
		private bool m_isInited;

		// Token: 0x0401F65E RID: 128606
		[Token(Token = "0x401F65E")]
		[FieldOffset(Offset = "0x80")]
		private SiracusaChatDecisionComp.SiracusaDecisionAdapter m_adapter;

		// Token: 0x0401F65F RID: 128607
		[Token(Token = "0x401F65F")]
		[FieldOffset(Offset = "0x88")]
		private SiracusaChatDecisionComp.OptionRenderOptions[] m_cachedDecisions;

		// Token: 0x0401F660 RID: 128608
		[Token(Token = "0x401F660")]
		[FieldOffset(Offset = "0x90")]
		private Action<int> m_onDecisionMade;

		// Token: 0x0401F661 RID: 128609
		[Token(Token = "0x401F661")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401F662 RID: 128610
		[Token(Token = "0x401F662")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderForDecisions;

		// Token: 0x0401F663 RID: 128611
		[Token(Token = "0x401F663")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderForDecided;

		// Token: 0x0401F664 RID: 128612
		[Token(Token = "0x401F664")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__MakeDecision;

		// Token: 0x0401F665 RID: 128613
		[Token(Token = "0x401F665")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003FAD RID: 16301
		[Token(Token = "0x2003FAD")]
		public class ViewModel
		{
			// Token: 0x0601948D RID: 103565 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601948D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewModel()
			{
			}

			// Token: 0x0401F666 RID: 128614
			[Token(Token = "0x401F666")]
			[FieldOffset(Offset = "0x10")]
			public SiracusaChatDecisionComp prefab;

			// Token: 0x0401F667 RID: 128615
			[Token(Token = "0x401F667")]
			[FieldOffset(Offset = "0x18")]
			public SiracusaChatDecisionComp.OptionModel[] options;

			// Token: 0x0401F668 RID: 128616
			[Token(Token = "0x401F668")]
			[FieldOffset(Offset = "0x20")]
			public bool isSelected;

			// Token: 0x0401F669 RID: 128617
			[Token(Token = "0x401F669")]
			[FieldOffset(Offset = "0x24")]
			public int selectedIndex;
		}

		// Token: 0x02003FAE RID: 16302
		[Token(Token = "0x2003FAE")]
		public class OptionModel
		{
			// Token: 0x0601948E RID: 103566 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601948E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public OptionModel()
			{
			}

			// Token: 0x0401F66A RID: 128618
			[Token(Token = "0x401F66A")]
			[FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x0401F66B RID: 128619
			[Token(Token = "0x401F66B")]
			[FieldOffset(Offset = "0x18")]
			public string content;

			// Token: 0x0401F66C RID: 128620
			[Token(Token = "0x401F66C")]
			[FieldOffset(Offset = "0x20")]
			public string script;

			// Token: 0x0401F66D RID: 128621
			[Token(Token = "0x401F66D")]
			[FieldOffset(Offset = "0x28")]
			public string result;

			// Token: 0x0401F66E RID: 128622
			[Token(Token = "0x401F66E")]
			[FieldOffset(Offset = "0x30")]
			public bool needCommentLike;

			// Token: 0x0401F66F RID: 128623
			[Token(Token = "0x401F66F")]
			[FieldOffset(Offset = "0x38")]
			public string requiredCardId;

			// Token: 0x0401F670 RID: 128624
			[Token(Token = "0x401F670")]
			[FieldOffset(Offset = "0x40")]
			public bool selectable;
		}

		// Token: 0x02003FAF RID: 16303
		[Token(Token = "0x2003FAF")]
		private struct OptionRenderOptions
		{
			// Token: 0x0401F671 RID: 128625
			[Token(Token = "0x401F671")]
			[FieldOffset(Offset = "0x0")]
			public string content;

			// Token: 0x0401F672 RID: 128626
			[Token(Token = "0x401F672")]
			[FieldOffset(Offset = "0x8")]
			public bool selectable;
		}

		// Token: 0x02003FB0 RID: 16304
		[Token(Token = "0x2003FB0")]
		public class VirtualView : AVGChatVirtualView<SiracusaChatDecisionComp>
		{
			// Token: 0x17003C6E RID: 15470
			// (get) Token: 0x0601948F RID: 103567 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06019490 RID: 103568 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003C6E")]
			public Action<bool> showSkipButton
			{
				[Token(Token = "0x601948F")]
				[Address(RVA = "0x1212490", Offset = "0x1211090", VA = "0x181212490")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x6019490")]
				[Address(RVA = "0x12125F0", Offset = "0x12111F0", VA = "0x1812125F0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17003C6F RID: 15471
			// (get) Token: 0x06019491 RID: 103569 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06019492 RID: 103570 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003C6F")]
			public Action<string> optionSelectEvent
			{
				[Token(Token = "0x6019491")]
				[Address(RVA = "0x1212430", Offset = "0x1211030", VA = "0x181212430")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x6019492")]
				[Address(RVA = "0x1212570", Offset = "0x1211170", VA = "0x181212570")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06019493 RID: 103571 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019493")]
			[Address(RVA = "0x1212160", Offset = "0x1210D60", VA = "0x181212160")]
			public VirtualView(SiracusaChatDecisionComp.ViewModel model)
			{
			}

			// Token: 0x06019494 RID: 103572 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6019494")]
			[Address(RVA = "0x120FA60", Offset = "0x120E660", VA = "0x18120FA60", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x06019495 RID: 103573 RVA: 0x0009D968 File Offset: 0x0009BB68
			[Token(Token = "0x6019495")]
			[Address(RVA = "0x1210220", Offset = "0x120EE20", VA = "0x181210220", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x06019496 RID: 103574 RVA: 0x0009D980 File Offset: 0x0009BB80
			[Token(Token = "0x6019496")]
			[Address(RVA = "0x120F890", Offset = "0x120E490", VA = "0x18120F890", Slot = "19")]
			public override PlayConfig BeforePlaying()
			{
				return default(PlayConfig);
			}

			// Token: 0x06019497 RID: 103575 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019497")]
			[Address(RVA = "0x1210A40", Offset = "0x120F640", VA = "0x181210A40", Slot = "22")]
			protected override void OnUpdateView(SiracusaChatDecisionComp view)
			{
			}

			// Token: 0x06019498 RID: 103576 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019498")]
			[Address(RVA = "0x12105A0", Offset = "0x120F1A0", VA = "0x1812105A0", Slot = "20")]
			protected override void HideViewContent(SiracusaChatDecisionComp view)
			{
			}

			// Token: 0x06019499 RID: 103577 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6019499")]
			[Address(RVA = "0x1211020", Offset = "0x120FC20", VA = "0x181211020", Slot = "21")]
			protected override IEnumerator PlayViewContent(SiracusaChatDecisionComp view)
			{
				return null;
			}

			// Token: 0x0601949A RID: 103578 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601949A")]
			[Address(RVA = "0x1211540", Offset = "0x1210140", VA = "0x181211540", Slot = "23")]
			protected override void ShowAsLog(SiracusaChatDecisionComp view)
			{
			}

			// Token: 0x0601949B RID: 103579 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601949B")]
			[Address(RVA = "0x1211B90", Offset = "0x1210790", VA = "0x181211B90")]
			private void _InitIfNot()
			{
			}

			// Token: 0x0601949C RID: 103580 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601949C")]
			[Address(RVA = "0x1211F80", Offset = "0x1210B80", VA = "0x181211F80")]
			private void _OptionSelected(int index)
			{
			}

			// Token: 0x0401F673 RID: 128627
			[Token(Token = "0x401F673")]
			[FieldOffset(Offset = "0x28")]
			private readonly SiracusaChatDecisionComp.ViewModel m_model;

			// Token: 0x0401F674 RID: 128628
			[Token(Token = "0x401F674")]
			[FieldOffset(Offset = "0x30")]
			private bool m_isInited;

			// Token: 0x0401F675 RID: 128629
			[Token(Token = "0x401F675")]
			[FieldOffset(Offset = "0x38")]
			private SiracusaChatDecisionComp.PreferSizeCalculator m_sizeCalculator;

			// Token: 0x0401F676 RID: 128630
			[Token(Token = "0x401F676")]
			[FieldOffset(Offset = "0x40")]
			private string[] m_decisionContent;

			// Token: 0x0401F677 RID: 128631
			[Token(Token = "0x401F677")]
			[FieldOffset(Offset = "0x48")]
			private float m_cachedSize;

			// Token: 0x0401F67A RID: 128634
			[Token(Token = "0x401F67A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_showSkipButton;

			// Token: 0x0401F67B RID: 128635
			[Token(Token = "0x401F67B")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_showSkipButton;

			// Token: 0x0401F67C RID: 128636
			[Token(Token = "0x401F67C")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_optionSelectEvent;

			// Token: 0x0401F67D RID: 128637
			[Token(Token = "0x401F67D")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_optionSelectEvent;

			// Token: 0x0401F67E RID: 128638
			[Token(Token = "0x401F67E")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401F67F RID: 128639
			[Token(Token = "0x401F67F")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0401F680 RID: 128640
			[Token(Token = "0x401F680")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x0401F681 RID: 128641
			[Token(Token = "0x401F681")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_BeforePlaying;

			// Token: 0x0401F682 RID: 128642
			[Token(Token = "0x401F682")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_OnUpdateView;

			// Token: 0x0401F683 RID: 128643
			[Token(Token = "0x401F683")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_HideViewContent;

			// Token: 0x0401F684 RID: 128644
			[Token(Token = "0x401F684")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_PlayViewContent;

			// Token: 0x0401F685 RID: 128645
			[Token(Token = "0x401F685")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_ShowAsLog;

			// Token: 0x0401F686 RID: 128646
			[Token(Token = "0x401F686")]
			[FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0__InitIfNot;

			// Token: 0x0401F687 RID: 128647
			[Token(Token = "0x401F687")]
			[FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0__OptionSelected;
		}

		// Token: 0x02003FB4 RID: 16308
		[Token(Token = "0x2003FB4")]
		private class SiracusaDecisionAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17003C72 RID: 15474
			// (get) Token: 0x060194A7 RID: 103591 RVA: 0x0009D9B0 File Offset: 0x0009BBB0
			[Token(Token = "0x17003C72")]
			public override int count
			{
				[Token(Token = "0x60194A7")]
				[Address(RVA = "0x1209390", Offset = "0x1207F90", VA = "0x181209390", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060194A8 RID: 103592 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60194A8")]
			[Address(RVA = "0x1209310", Offset = "0x1207F10", VA = "0x181209310")]
			public SiracusaDecisionAdapter(SiracusaChatDecisionComp view)
			{
			}

			// Token: 0x060194A9 RID: 103593 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60194A9")]
			[Address(RVA = "0x1208FF0", Offset = "0x1207BF0", VA = "0x181208FF0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0401F696 RID: 128662
			[Token(Token = "0x401F696")]
			[FieldOffset(Offset = "0x20")]
			private readonly SiracusaChatDecisionComp m_view;

			// Token: 0x0401F697 RID: 128663
			[Token(Token = "0x401F697")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401F698 RID: 128664
			[Token(Token = "0x401F698")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401F699 RID: 128665
			[Token(Token = "0x401F699")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x02003FB5 RID: 16309
		[Token(Token = "0x2003FB5")]
		private class PreferSizeCalculator : IHotfixable
		{
			// Token: 0x060194AA RID: 103594 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60194AA")]
			[Address(RVA = "0x11FFBB0", Offset = "0x11FE7B0", VA = "0x1811FFBB0")]
			public PreferSizeCalculator(SiracusaChatDecisionComp view)
			{
			}

			// Token: 0x060194AB RID: 103595 RVA: 0x0009D9C8 File Offset: 0x0009BBC8
			[Token(Token = "0x60194AB")]
			[Address(RVA = "0x11FF2D0", Offset = "0x11FDED0", VA = "0x1811FF2D0")]
			public float CalcSize(params string[] contents)
			{
				return 0f;
			}

			// Token: 0x0401F69A RID: 128666
			[Token(Token = "0x401F69A")]
			[FieldOffset(Offset = "0x10")]
			private TextGenerator m_textGenerator;

			// Token: 0x0401F69B RID: 128667
			[Token(Token = "0x401F69B")]
			[FieldOffset(Offset = "0x18")]
			private TextGenerationSettings m_textSettings;

			// Token: 0x0401F69C RID: 128668
			[Token(Token = "0x401F69C")]
			[FieldOffset(Offset = "0x78")]
			private float m_textPadding;

			// Token: 0x0401F69D RID: 128669
			[Token(Token = "0x401F69D")]
			[FieldOffset(Offset = "0x7C")]
			private float m_layoutSpacing;

			// Token: 0x0401F69E RID: 128670
			[Token(Token = "0x401F69E")]
			[FieldOffset(Offset = "0x80")]
			private float m_layoutPadding;

			// Token: 0x0401F69F RID: 128671
			[Token(Token = "0x401F69F")]
			[FieldOffset(Offset = "0x88")]
			private SiracusaChatDecisionComp m_view;

			// Token: 0x0401F6A0 RID: 128672
			[Token(Token = "0x401F6A0")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401F6A1 RID: 128673
			[Token(Token = "0x401F6A1")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_CalcSize;
		}
	}
}
