using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001F66 RID: 8038
	[Token(Token = "0x2001F66")]
	public class AVGReaderModeTextView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600C7C0 RID: 51136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C7C0")]
		[Address(RVA = "0x348E130", Offset = "0x348CD30", VA = "0x18348E130")]
		private void _Render(AVGReaderModeTextView.Options options, [Optional] Action<int> onClickDecision)
		{
		}

		// Token: 0x0600C7C1 RID: 51137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C7C1")]
		[Address(RVA = "0x348DA20", Offset = "0x348C620", VA = "0x18348DA20")]
		private void _HideAllArrows()
		{
		}

		// Token: 0x0600C7C2 RID: 51138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C7C2")]
		[Address(RVA = "0x348DAE0", Offset = "0x348C6E0", VA = "0x18348DAE0")]
		private void _RenderDecisionArrow(int selectIdx)
		{
		}

		// Token: 0x0600C7C3 RID: 51139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C7C3")]
		[Address(RVA = "0x348DBC0", Offset = "0x348C7C0", VA = "0x18348DBC0")]
		private void _RenderDecision(string content, int optionIdx, string originalDialogContent, int fontsize)
		{
		}

		// Token: 0x0600C7C4 RID: 51140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C7C4")]
		[Address(RVA = "0x348E010", Offset = "0x348CC10", VA = "0x18348E010")]
		private void _RenderEndtip()
		{
		}

		// Token: 0x0600C7C5 RID: 51141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C7C5")]
		[Address(RVA = "0x348D8C0", Offset = "0x348C4C0", VA = "0x18348D8C0")]
		private AVGReaderModeTextView.SizeCalculator _GetSizeCalculator()
		{
			return null;
		}

		// Token: 0x0600C7C6 RID: 51142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C7C6")]
		[Address(RVA = "0x348D610", Offset = "0x348C210", VA = "0x18348D610")]
		private static string _ConvertDialogToDecision(string dialogContent, int optIndex)
		{
			return null;
		}

		// Token: 0x0600C7C7 RID: 51143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C7C7")]
		[Address(RVA = "0x348E8F0", Offset = "0x348D4F0", VA = "0x18348E8F0")]
		public AVGReaderModeTextView()
		{
		}

		// Token: 0x0400CDDF RID: 52703
		[Token(Token = "0x400CDDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _name;

		// Token: 0x0400CDE0 RID: 52704
		[Token(Token = "0x400CDE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _content;

		// Token: 0x0400CDE1 RID: 52705
		[Token(Token = "0x400CDE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _current;

		// Token: 0x0400CDE2 RID: 52706
		[Token(Token = "0x400CDE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _options;

		// Token: 0x0400CDE3 RID: 52707
		[Token(Token = "0x400CDE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AVGReaderModeDecisionItemView[] _decisionItemViews;

		// Token: 0x0400CDE4 RID: 52708
		[Token(Token = "0x400CDE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _contentPadding;

		// Token: 0x0400CDE5 RID: 52709
		[Token(Token = "0x400CDE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _textObj;

		// Token: 0x0400CDE6 RID: 52710
		[Token(Token = "0x400CDE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _endtipObj;

		// Token: 0x0400CDE7 RID: 52711
		[Token(Token = "0x400CDE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject[] _decisionArrows;

		// Token: 0x0400CDE8 RID: 52712
		[Token(Token = "0x400CDE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AVGReaderModeTextView.SizeCalculator m_sizeCalculator;

		// Token: 0x0400CDE9 RID: 52713
		[Token(Token = "0x400CDE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Action<int> m_onOptionSelectedCallback;

		// Token: 0x0400CDEA RID: 52714
		[Token(Token = "0x400CDEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private string m_currentDialogContent;

		// Token: 0x0400CDEB RID: 52715
		[Token(Token = "0x400CDEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0400CDEC RID: 52716
		[Token(Token = "0x400CDEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__HideAllArrows;

		// Token: 0x0400CDED RID: 52717
		[Token(Token = "0x400CDED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderDecisionArrow;

		// Token: 0x0400CDEE RID: 52718
		[Token(Token = "0x400CDEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderDecision;

		// Token: 0x0400CDEF RID: 52719
		[Token(Token = "0x400CDEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderEndtip;

		// Token: 0x0400CDF0 RID: 52720
		[Token(Token = "0x400CDF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetSizeCalculator;

		// Token: 0x0400CDF1 RID: 52721
		[Token(Token = "0x400CDF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ConvertDialogToDecision;

		// Token: 0x0400CDF2 RID: 52722
		[Token(Token = "0x400CDF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001F67 RID: 8039
		[Token(Token = "0x2001F67")]
		public struct Options
		{
			// Token: 0x0400CDF3 RID: 52723
			[Token(Token = "0x400CDF3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public AVGReaderModeTextView prefab;

			// Token: 0x0400CDF4 RID: 52724
			[Token(Token = "0x400CDF4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string dialogName;

			// Token: 0x0400CDF5 RID: 52725
			[Token(Token = "0x400CDF5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string dialogContent;

			// Token: 0x0400CDF6 RID: 52726
			[Token(Token = "0x400CDF6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool isDecision;

			// Token: 0x0400CDF7 RID: 52727
			[Token(Token = "0x400CDF7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int decisionIndex;

			// Token: 0x0400CDF8 RID: 52728
			[Token(Token = "0x400CDF8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string decisionContent;

			// Token: 0x0400CDF9 RID: 52729
			[Token(Token = "0x400CDF9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool isCurrent;

			// Token: 0x0400CDFA RID: 52730
			[Token(Token = "0x400CDFA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			public bool isEndtip;

			// Token: 0x0400CDFB RID: 52731
			[Token(Token = "0x400CDFB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public int fontSize;

			// Token: 0x0400CDFC RID: 52732
			[Token(Token = "0x400CDFC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int lineSpace;
		}

		// Token: 0x02001F68 RID: 8040
		[Token(Token = "0x2001F68")]
		public class VirtualView : UIRecycleLayoutAdapter.VirtualView<AVGReaderModeTextView>, UIRecycleLayoutAdapter.ICustomSpacing
		{
			// Token: 0x0600C7C8 RID: 51144 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C7C8")]
			[Address(RVA = "0x349D3C0", Offset = "0x349BFC0", VA = "0x18349D3C0")]
			public VirtualView(AVGReaderModeTextView.Options options, [Optional] Action<int> onClickDecision)
			{
			}

			// Token: 0x0600C7C9 RID: 51145 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600C7C9")]
			[Address(RVA = "0x349C300", Offset = "0x349AF00", VA = "0x18349C300", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x0600C7CA RID: 51146 RVA: 0x00048BE8 File Offset: 0x00046DE8
			[Token(Token = "0x600C7CA")]
			[Address(RVA = "0x349C6E0", Offset = "0x349B2E0", VA = "0x18349C6E0", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x0600C7CB RID: 51147 RVA: 0x00048C00 File Offset: 0x00046E00
			[Token(Token = "0x600C7CB")]
			[Address(RVA = "0x349C2A0", Offset = "0x349AEA0", VA = "0x18349C2A0", Slot = "14")]
			public float GetCustomSpacing()
			{
				return 0f;
			}

			// Token: 0x0600C7CC RID: 51148 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C7CC")]
			[Address(RVA = "0x349CA30", Offset = "0x349B630", VA = "0x18349CA30", Slot = "10")]
			protected override void OnViewAttached()
			{
			}

			// Token: 0x0600C7CD RID: 51149 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C7CD")]
			[Address(RVA = "0x349CAF0", Offset = "0x349B6F0", VA = "0x18349CAF0", Slot = "11")]
			protected override void OnViewDetached()
			{
			}

			// Token: 0x0600C7CE RID: 51150 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C7CE")]
			[Address(RVA = "0x349CBB0", Offset = "0x349B7B0", VA = "0x18349CBB0")]
			public void SetDecisionOption(int optIndex)
			{
			}

			// Token: 0x0600C7CF RID: 51151 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C7CF")]
			[Address(RVA = "0x349D190", Offset = "0x349BD90", VA = "0x18349D190")]
			public void SetReaderCurrent(bool isCurrent)
			{
			}

			// Token: 0x0600C7D0 RID: 51152 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C7D0")]
			[Address(RVA = "0x349D060", Offset = "0x349BC60", VA = "0x18349D060")]
			public void SetReaderContent(string content)
			{
			}

			// Token: 0x0400CDFD RID: 52733
			[Token(Token = "0x400CDFD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private AVGReaderModeTextView.Options m_options;

			// Token: 0x0400CDFE RID: 52734
			[Token(Token = "0x400CDFE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Action<int> m_onClickDecision;

			// Token: 0x0400CDFF RID: 52735
			[Token(Token = "0x400CDFF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400CE00 RID: 52736
			[Token(Token = "0x400CE00")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0400CE01 RID: 52737
			[Token(Token = "0x400CE01")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x0400CE02 RID: 52738
			[Token(Token = "0x400CE02")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetCustomSpacing;

			// Token: 0x0400CE03 RID: 52739
			[Token(Token = "0x400CE03")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OnViewAttached;

			// Token: 0x0400CE04 RID: 52740
			[Token(Token = "0x400CE04")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_OnViewDetached;

			// Token: 0x0400CE05 RID: 52741
			[Token(Token = "0x400CE05")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_SetDecisionOption;

			// Token: 0x0400CE06 RID: 52742
			[Token(Token = "0x400CE06")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_SetReaderCurrent;

			// Token: 0x0400CE07 RID: 52743
			[Token(Token = "0x400CE07")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_SetReaderContent;
		}

		// Token: 0x02001F69 RID: 8041
		[Token(Token = "0x2001F69")]
		private class SizeCalculator : IHotfixable
		{
			// Token: 0x0600C7D1 RID: 51153 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C7D1")]
			[Address(RVA = "0x3498ED0", Offset = "0x3497AD0", VA = "0x183498ED0")]
			public SizeCalculator(AVGReaderModeTextView prefab)
			{
			}

			// Token: 0x0600C7D2 RID: 51154 RVA: 0x00048C18 File Offset: 0x00046E18
			[Token(Token = "0x600C7D2")]
			[Address(RVA = "0x3498780", Offset = "0x3497380", VA = "0x183498780")]
			public float CalcSize(string name, string msg, bool isDecision = false, int decisionOptionCount = 0, int fontSize = 0)
			{
				return 0f;
			}

			// Token: 0x0400CE08 RID: 52744
			[Token(Token = "0x400CE08")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private TextGenerator m_textGenerator;

			// Token: 0x0400CE09 RID: 52745
			[Token(Token = "0x400CE09")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private TextGenerationSettings m_nameSettings;

			// Token: 0x0400CE0A RID: 52746
			[Token(Token = "0x400CE0A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private TextGenerationSettings m_msgSettings;

			// Token: 0x0400CE0B RID: 52747
			[Token(Token = "0x400CE0B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			private AVGReaderModeTextView m_prefab;

			// Token: 0x0400CE0C RID: 52748
			[Token(Token = "0x400CE0C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400CE0D RID: 52749
			[Token(Token = "0x400CE0D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_CalcSize;
		}
	}
}
