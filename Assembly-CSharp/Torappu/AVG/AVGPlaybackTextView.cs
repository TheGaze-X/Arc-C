using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001F5D RID: 8029
	[Token(Token = "0x2001F5D")]
	public class AVGPlaybackTextView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600C79A RID: 51098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C79A")]
		[Address(RVA = "0x347EC60", Offset = "0x347D860", VA = "0x18347EC60")]
		private void _Render(AVGPlaybackTextView.Options options)
		{
		}

		// Token: 0x0600C79B RID: 51099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C79B")]
		[Address(RVA = "0x347EAD0", Offset = "0x347D6D0", VA = "0x18347EAD0")]
		private void _RenderDecision(string content, int optionIdx)
		{
		}

		// Token: 0x0600C79C RID: 51100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C79C")]
		[Address(RVA = "0x347E9D0", Offset = "0x347D5D0", VA = "0x18347E9D0")]
		private AVGPlaybackTextView.SizeCalculator _GetSizeCalculator()
		{
			return null;
		}

		// Token: 0x0600C79D RID: 51101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C79D")]
		[Address(RVA = "0x347E720", Offset = "0x347D320", VA = "0x18347E720")]
		private static string _ConvertDialogToDecision(string dialogContent, int optIndex)
		{
			return null;
		}

		// Token: 0x0600C79E RID: 51102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C79E")]
		[Address(RVA = "0x347EFA0", Offset = "0x347DBA0", VA = "0x18347EFA0")]
		public AVGPlaybackTextView()
		{
		}

		// Token: 0x0400CD9B RID: 52635
		[Token(Token = "0x400CD9B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _name;

		// Token: 0x0400CD9C RID: 52636
		[Token(Token = "0x400CD9C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _content;

		// Token: 0x0400CD9D RID: 52637
		[Token(Token = "0x400CD9D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _current;

		// Token: 0x0400CD9E RID: 52638
		[Token(Token = "0x400CD9E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _options;

		// Token: 0x0400CD9F RID: 52639
		[Token(Token = "0x400CD9F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image[] _optionsChosen;

		// Token: 0x0400CDA0 RID: 52640
		[Token(Token = "0x400CDA0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _contentPadding;

		// Token: 0x0400CDA1 RID: 52641
		[Token(Token = "0x400CDA1")]
		[FieldOffset(Offset = "0x48")]
		private AVGPlaybackTextView.SizeCalculator m_sizeCalculator;

		// Token: 0x0400CDA2 RID: 52642
		[Token(Token = "0x400CDA2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0400CDA3 RID: 52643
		[Token(Token = "0x400CDA3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderDecision;

		// Token: 0x0400CDA4 RID: 52644
		[Token(Token = "0x400CDA4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetSizeCalculator;

		// Token: 0x0400CDA5 RID: 52645
		[Token(Token = "0x400CDA5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ConvertDialogToDecision;

		// Token: 0x0400CDA6 RID: 52646
		[Token(Token = "0x400CDA6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001F5E RID: 8030
		[Token(Token = "0x2001F5E")]
		public struct Options
		{
			// Token: 0x0400CDA7 RID: 52647
			[Token(Token = "0x400CDA7")]
			[FieldOffset(Offset = "0x0")]
			public AVGPlaybackTextView prefab;

			// Token: 0x0400CDA8 RID: 52648
			[Token(Token = "0x400CDA8")]
			[FieldOffset(Offset = "0x8")]
			public string dialogName;

			// Token: 0x0400CDA9 RID: 52649
			[Token(Token = "0x400CDA9")]
			[FieldOffset(Offset = "0x10")]
			public string dialogContent;

			// Token: 0x0400CDAA RID: 52650
			[Token(Token = "0x400CDAA")]
			[FieldOffset(Offset = "0x18")]
			public bool isDecision;

			// Token: 0x0400CDAB RID: 52651
			[Token(Token = "0x400CDAB")]
			[FieldOffset(Offset = "0x1C")]
			public int decisionIndex;

			// Token: 0x0400CDAC RID: 52652
			[Token(Token = "0x400CDAC")]
			[FieldOffset(Offset = "0x20")]
			public string decisionContent;

			// Token: 0x0400CDAD RID: 52653
			[Token(Token = "0x400CDAD")]
			[FieldOffset(Offset = "0x28")]
			public bool isCurrent;
		}

		// Token: 0x02001F5F RID: 8031
		[Token(Token = "0x2001F5F")]
		public class VirtualView : UIRecycleLayoutAdapter.VirtualView<AVGPlaybackTextView>
		{
			// Token: 0x0600C79F RID: 51103 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C79F")]
			[Address(RVA = "0x349D2B0", Offset = "0x349BEB0", VA = "0x18349D2B0")]
			public VirtualView(AVGPlaybackTextView.Options options)
			{
			}

			// Token: 0x0600C7A0 RID: 51104 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600C7A0")]
			[Address(RVA = "0x349C370", Offset = "0x349AF70", VA = "0x18349C370", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x0600C7A1 RID: 51105 RVA: 0x00048BA0 File Offset: 0x00046DA0
			[Token(Token = "0x600C7A1")]
			[Address(RVA = "0x349C3E0", Offset = "0x349AFE0", VA = "0x18349C3E0", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x0600C7A2 RID: 51106 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C7A2")]
			[Address(RVA = "0x349C980", Offset = "0x349B580", VA = "0x18349C980", Slot = "10")]
			protected override void OnViewAttached()
			{
			}

			// Token: 0x0600C7A3 RID: 51107 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C7A3")]
			[Address(RVA = "0x349CB50", Offset = "0x349B750", VA = "0x18349CB50", Slot = "11")]
			protected override void OnViewDetached()
			{
			}

			// Token: 0x0600C7A4 RID: 51108 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C7A4")]
			[Address(RVA = "0x349CF30", Offset = "0x349BB30", VA = "0x18349CF30")]
			public void SetPlaybackOption(int optIndex)
			{
			}

			// Token: 0x0600C7A5 RID: 51109 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C7A5")]
			[Address(RVA = "0x349CE20", Offset = "0x349BA20", VA = "0x18349CE20")]
			public void SetPlaybackCurrent(bool isCurrent)
			{
			}

			// Token: 0x0600C7A6 RID: 51110 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C7A6")]
			[Address(RVA = "0x349CCF0", Offset = "0x349B8F0", VA = "0x18349CCF0")]
			public void SetPlaybackContent(string content)
			{
			}

			// Token: 0x0400CDAE RID: 52654
			[Token(Token = "0x400CDAE")]
			[FieldOffset(Offset = "0x20")]
			private AVGPlaybackTextView.Options m_options;

			// Token: 0x0400CDAF RID: 52655
			[Token(Token = "0x400CDAF")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400CDB0 RID: 52656
			[Token(Token = "0x400CDB0")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0400CDB1 RID: 52657
			[Token(Token = "0x400CDB1")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x0400CDB2 RID: 52658
			[Token(Token = "0x400CDB2")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnViewAttached;

			// Token: 0x0400CDB3 RID: 52659
			[Token(Token = "0x400CDB3")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OnViewDetached;

			// Token: 0x0400CDB4 RID: 52660
			[Token(Token = "0x400CDB4")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_SetPlaybackOption;

			// Token: 0x0400CDB5 RID: 52661
			[Token(Token = "0x400CDB5")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_SetPlaybackCurrent;

			// Token: 0x0400CDB6 RID: 52662
			[Token(Token = "0x400CDB6")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_SetPlaybackContent;
		}

		// Token: 0x02001F60 RID: 8032
		[Token(Token = "0x2001F60")]
		private class SizeCalculator : IHotfixable
		{
			// Token: 0x0600C7A7 RID: 51111 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C7A7")]
			[Address(RVA = "0x3498E50", Offset = "0x3497A50", VA = "0x183498E50")]
			public SizeCalculator(AVGPlaybackTextView prefab)
			{
			}

			// Token: 0x0600C7A8 RID: 51112 RVA: 0x00048BB8 File Offset: 0x00046DB8
			[Token(Token = "0x600C7A8")]
			[Address(RVA = "0x3498BE0", Offset = "0x34977E0", VA = "0x183498BE0")]
			public float CalcSize(string name, string msg)
			{
				return 0f;
			}

			// Token: 0x0400CDB7 RID: 52663
			[Token(Token = "0x400CDB7")]
			[FieldOffset(Offset = "0x10")]
			private TextGenerator m_textGenerator;

			// Token: 0x0400CDB8 RID: 52664
			[Token(Token = "0x400CDB8")]
			[FieldOffset(Offset = "0x18")]
			private TextGenerationSettings m_nameSettings;

			// Token: 0x0400CDB9 RID: 52665
			[Token(Token = "0x400CDB9")]
			[FieldOffset(Offset = "0x78")]
			private TextGenerationSettings m_msgSettings;

			// Token: 0x0400CDBA RID: 52666
			[Token(Token = "0x400CDBA")]
			[FieldOffset(Offset = "0xD8")]
			private AVGPlaybackTextView m_prefab;

			// Token: 0x0400CDBB RID: 52667
			[Token(Token = "0x400CDBB")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400CDBC RID: 52668
			[Token(Token = "0x400CDBC")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_CalcSize;
		}
	}
}
