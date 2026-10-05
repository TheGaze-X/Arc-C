using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005326 RID: 21286
	[Token(Token = "0x2005326")]
	public class RoguelikeMenuRelicWindowItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601F66C RID: 128620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F66C")]
		[Address(RVA = "0x19144E0", Offset = "0x19130E0", VA = "0x1819144E0")]
		public void EventOnClicked()
		{
		}

		// Token: 0x0601F66D RID: 128621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F66D")]
		[Address(RVA = "0x1914920", Offset = "0x1913520", VA = "0x181914920")]
		public void Render(IRoguelikeRelicViewModel viewModel)
		{
		}

		// Token: 0x0601F66E RID: 128622 RVA: 0x000B1CF0 File Offset: 0x000AFEF0
		[Token(Token = "0x601F66E")]
		[Address(RVA = "0x1914CD0", Offset = "0x19138D0", VA = "0x181914CD0")]
		private RoguelikeMenuRelicWindowItemView.Panel _GetPanelTypeFromRelicItemType(RoguelikeMenuRelicItemType relicItemType)
		{
			return RoguelikeMenuRelicWindowItemView.Panel.NONE;
		}

		// Token: 0x0601F66F RID: 128623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F66F")]
		[Address(RVA = "0x1914DE0", Offset = "0x19139E0", VA = "0x181914DE0")]
		public RoguelikeMenuRelicWindowItemView()
		{
		}

		// Token: 0x0402A387 RID: 172935
		[Token(Token = "0x402A387")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _relicPanel;

		// Token: 0x0402A388 RID: 172936
		[Token(Token = "0x402A388")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _trapPanel;

		// Token: 0x0402A389 RID: 172937
		[Token(Token = "0x402A389")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _exploreToolPanel;

		// Token: 0x0402A38A RID: 172938
		[Token(Token = "0x402A38A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RoguelikeMenuRelicWindowItemView.RelicPart _relicPart;

		// Token: 0x0402A38B RID: 172939
		[Token(Token = "0x402A38B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RoguelikeMenuRelicWindowItemView.TrapPart _trapPart;

		// Token: 0x0402A38C RID: 172940
		[Token(Token = "0x402A38C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RoguelikeMenuRelicWindowItemView.ExploreToolPart _exploreToolPart;

		// Token: 0x0402A38D RID: 172941
		[Token(Token = "0x402A38D")]
		[FieldOffset(Offset = "0x48")]
		private RoguelikeMenuRelicWindowItemView.Panel m_cachedCurrPanel;

		// Token: 0x0402A38E RID: 172942
		[Token(Token = "0x402A38E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_EventOnClicked;

		// Token: 0x0402A38F RID: 172943
		[Token(Token = "0x402A38F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402A390 RID: 172944
		[Token(Token = "0x402A390")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetPanelTypeFromRelicItemType;

		// Token: 0x0402A391 RID: 172945
		[Token(Token = "0x402A391")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005327 RID: 21287
		[Token(Token = "0x2005327")]
		private enum Panel
		{
			// Token: 0x0402A393 RID: 172947
			[Token(Token = "0x402A393")]
			NONE,
			// Token: 0x0402A394 RID: 172948
			[Token(Token = "0x402A394")]
			RELIC,
			// Token: 0x0402A395 RID: 172949
			[Token(Token = "0x402A395")]
			TRAP,
			// Token: 0x0402A396 RID: 172950
			[Token(Token = "0x402A396")]
			EXPLORE_TOOL
		}

		// Token: 0x02005328 RID: 21288
		[Token(Token = "0x2005328")]
		[Serializable]
		private class RelicPart : IHotfixable
		{
			// Token: 0x0601F670 RID: 128624 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F670")]
			[Address(RVA = "0x190EBF0", Offset = "0x190D7F0", VA = "0x18190EBF0")]
			public void Render(RoguelikeRelicViewModel viewModel)
			{
			}

			// Token: 0x0601F671 RID: 128625 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F671")]
			[Address(RVA = "0x190E9F0", Offset = "0x190D5F0", VA = "0x18190E9F0")]
			public void EventOnClicked()
			{
			}

			// Token: 0x0601F672 RID: 128626 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F672")]
			[Address(RVA = "0x190EE60", Offset = "0x190DA60", VA = "0x18190EE60")]
			public RelicPart()
			{
			}

			// Token: 0x0402A397 RID: 172951
			[Token(Token = "0x402A397")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private Image _imageIcon;

			// Token: 0x0402A398 RID: 172952
			[Token(Token = "0x402A398")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Text _textName;

			// Token: 0x0402A399 RID: 172953
			[Token(Token = "0x402A399")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Text _textUsage;

			// Token: 0x0402A39A RID: 172954
			[Token(Token = "0x402A39A")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private GameObject _iconUsed;

			// Token: 0x0402A39B RID: 172955
			[Token(Token = "0x402A39B")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private GameObject _layerPart;

			// Token: 0x0402A39C RID: 172956
			[Token(Token = "0x402A39C")]
			[FieldOffset(Offset = "0x38")]
			[SerializeField]
			private Text _textLayer;

			// Token: 0x0402A39D RID: 172957
			[Token(Token = "0x402A39D")]
			[FieldOffset(Offset = "0x40")]
			private string m_cachedRelicId;

			// Token: 0x0402A39E RID: 172958
			[Token(Token = "0x402A39E")]
			[FieldOffset(Offset = "0x48")]
			private RoguelikeRelicViewModel m_cachedRelicModel;

			// Token: 0x0402A39F RID: 172959
			[Token(Token = "0x402A39F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Render;

			// Token: 0x0402A3A0 RID: 172960
			[Token(Token = "0x402A3A0")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_EventOnClicked;

			// Token: 0x0402A3A1 RID: 172961
			[Token(Token = "0x402A3A1")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02005329 RID: 21289
		[Token(Token = "0x2005329")]
		[Serializable]
		private class TrapPart : IHotfixable
		{
			// Token: 0x0601F673 RID: 128627 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F673")]
			[Address(RVA = "0x1920490", Offset = "0x191F090", VA = "0x181920490")]
			public void Render(RoguelikeTrapViewModel viewModel)
			{
			}

			// Token: 0x0601F674 RID: 128628 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F674")]
			[Address(RVA = "0x19202A0", Offset = "0x191EEA0", VA = "0x1819202A0")]
			public void EventOnClicked()
			{
			}

			// Token: 0x0601F675 RID: 128629 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F675")]
			[Address(RVA = "0x1920670", Offset = "0x191F270", VA = "0x181920670")]
			public TrapPart()
			{
			}

			// Token: 0x0402A3A2 RID: 172962
			[Token(Token = "0x402A3A2")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private Image _imageIcon;

			// Token: 0x0402A3A3 RID: 172963
			[Token(Token = "0x402A3A3")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Text _textName;

			// Token: 0x0402A3A4 RID: 172964
			[Token(Token = "0x402A3A4")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Text _textUsage;

			// Token: 0x0402A3A5 RID: 172965
			[Token(Token = "0x402A3A5")]
			[FieldOffset(Offset = "0x28")]
			private string m_cachedTrapId;

			// Token: 0x0402A3A6 RID: 172966
			[Token(Token = "0x402A3A6")]
			[FieldOffset(Offset = "0x30")]
			private RoguelikeTrapViewModel m_cachedTrapModel;

			// Token: 0x0402A3A7 RID: 172967
			[Token(Token = "0x402A3A7")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Render;

			// Token: 0x0402A3A8 RID: 172968
			[Token(Token = "0x402A3A8")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_EventOnClicked;

			// Token: 0x0402A3A9 RID: 172969
			[Token(Token = "0x402A3A9")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200532A RID: 21290
		[Token(Token = "0x200532A")]
		[Serializable]
		private class ExploreToolPart : IHotfixable
		{
			// Token: 0x0601F676 RID: 128630 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F676")]
			[Address(RVA = "0x190C020", Offset = "0x190AC20", VA = "0x18190C020")]
			public void Render(RoguelikeExploreToolViewModel viewModel)
			{
			}

			// Token: 0x0601F677 RID: 128631 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F677")]
			[Address(RVA = "0x190BE30", Offset = "0x190AA30", VA = "0x18190BE30")]
			public void EventOnClicked()
			{
			}

			// Token: 0x0601F678 RID: 128632 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F678")]
			[Address(RVA = "0x190C200", Offset = "0x190AE00", VA = "0x18190C200")]
			public ExploreToolPart()
			{
			}

			// Token: 0x0402A3AA RID: 172970
			[Token(Token = "0x402A3AA")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private Image _imageIcon;

			// Token: 0x0402A3AB RID: 172971
			[Token(Token = "0x402A3AB")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Text _textName;

			// Token: 0x0402A3AC RID: 172972
			[Token(Token = "0x402A3AC")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Text _textUsage;

			// Token: 0x0402A3AD RID: 172973
			[Token(Token = "0x402A3AD")]
			[FieldOffset(Offset = "0x28")]
			private string m_cachedExploreToolId;

			// Token: 0x0402A3AE RID: 172974
			[Token(Token = "0x402A3AE")]
			[FieldOffset(Offset = "0x30")]
			private RoguelikeExploreToolViewModel m_cachedExploreToolModel;

			// Token: 0x0402A3AF RID: 172975
			[Token(Token = "0x402A3AF")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Render;

			// Token: 0x0402A3B0 RID: 172976
			[Token(Token = "0x402A3B0")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_EventOnClicked;

			// Token: 0x0402A3B1 RID: 172977
			[Token(Token = "0x402A3B1")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
