using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200264C RID: 9804
	[Token(Token = "0x200264C")]
	public class DialogPlaybackTextView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601005F RID: 65631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601005F")]
		[Address(RVA = "0x77B8E0", Offset = "0x77A4E0", VA = "0x18077B8E0")]
		private void _Render(DialogPlaybackTextView.Options options)
		{
		}

		// Token: 0x06010060 RID: 65632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010060")]
		[Address(RVA = "0x77B750", Offset = "0x77A350", VA = "0x18077B750")]
		private void _RenderDecision(string content, int optionIdx)
		{
		}

		// Token: 0x06010061 RID: 65633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6010061")]
		[Address(RVA = "0x77B640", Offset = "0x77A240", VA = "0x18077B640")]
		public DialogPlaybackTextView.SizeCalculator _GetSizeCalculator()
		{
			return null;
		}

		// Token: 0x06010062 RID: 65634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6010062")]
		[Address(RVA = "0x77B390", Offset = "0x779F90", VA = "0x18077B390")]
		private static string _ConvertDialogToDecision(string dialogContent, int optIndex)
		{
			return null;
		}

		// Token: 0x06010063 RID: 65635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010063")]
		[Address(RVA = "0x77BC20", Offset = "0x77A820", VA = "0x18077BC20")]
		public DialogPlaybackTextView()
		{
		}

		// Token: 0x04011D17 RID: 72983
		[Token(Token = "0x4011D17")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _name;

		// Token: 0x04011D18 RID: 72984
		[Token(Token = "0x4011D18")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _content;

		// Token: 0x04011D19 RID: 72985
		[Token(Token = "0x4011D19")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _current;

		// Token: 0x04011D1A RID: 72986
		[Token(Token = "0x4011D1A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _options;

		// Token: 0x04011D1B RID: 72987
		[Token(Token = "0x4011D1B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAtlasImage[] _optionsChosen;

		// Token: 0x04011D1C RID: 72988
		[Token(Token = "0x4011D1C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _contentPadding;

		// Token: 0x04011D1D RID: 72989
		[Token(Token = "0x4011D1D")]
		[FieldOffset(Offset = "0x48")]
		private DialogPlaybackTextView.SizeCalculator m_sizeCalculator;

		// Token: 0x04011D1E RID: 72990
		[Token(Token = "0x4011D1E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x04011D1F RID: 72991
		[Token(Token = "0x4011D1F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderDecision;

		// Token: 0x04011D20 RID: 72992
		[Token(Token = "0x4011D20")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetSizeCalculator;

		// Token: 0x04011D21 RID: 72993
		[Token(Token = "0x4011D21")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ConvertDialogToDecision;

		// Token: 0x04011D22 RID: 72994
		[Token(Token = "0x4011D22")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200264D RID: 9805
		[Token(Token = "0x200264D")]
		public struct Options
		{
			// Token: 0x04011D23 RID: 72995
			[Token(Token = "0x4011D23")]
			[FieldOffset(Offset = "0x0")]
			public DialogPlaybackTextView prefab;

			// Token: 0x04011D24 RID: 72996
			[Token(Token = "0x4011D24")]
			[FieldOffset(Offset = "0x8")]
			public string dialogName;

			// Token: 0x04011D25 RID: 72997
			[Token(Token = "0x4011D25")]
			[FieldOffset(Offset = "0x10")]
			public string dialogContent;

			// Token: 0x04011D26 RID: 72998
			[Token(Token = "0x4011D26")]
			[FieldOffset(Offset = "0x18")]
			public bool isDecision;

			// Token: 0x04011D27 RID: 72999
			[Token(Token = "0x4011D27")]
			[FieldOffset(Offset = "0x1C")]
			public int decisionIndex;

			// Token: 0x04011D28 RID: 73000
			[Token(Token = "0x4011D28")]
			[FieldOffset(Offset = "0x20")]
			public string decisionContent;

			// Token: 0x04011D29 RID: 73001
			[Token(Token = "0x4011D29")]
			[FieldOffset(Offset = "0x28")]
			public bool isCurrent;
		}

		// Token: 0x0200264E RID: 9806
		[Token(Token = "0x200264E")]
		public class VirtualView : UIRecycleLayoutAdapter.VirtualView<DialogPlaybackTextView>
		{
			// Token: 0x06010064 RID: 65636 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010064")]
			[Address(RVA = "0x789AE0", Offset = "0x7886E0", VA = "0x180789AE0")]
			public VirtualView(DialogPlaybackTextView.Options options)
			{
			}

			// Token: 0x06010065 RID: 65637 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010065")]
			[Address(RVA = "0x789480", Offset = "0x788080", VA = "0x180789480", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x06010066 RID: 65638 RVA: 0x000618F0 File Offset: 0x0005FAF0
			[Token(Token = "0x6010066")]
			[Address(RVA = "0x7894F0", Offset = "0x7880F0", VA = "0x1807894F0", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x06010067 RID: 65639 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010067")]
			[Address(RVA = "0x7898C0", Offset = "0x7884C0", VA = "0x1807898C0", Slot = "10")]
			protected override void OnViewAttached()
			{
			}

			// Token: 0x06010068 RID: 65640 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010068")]
			[Address(RVA = "0x789970", Offset = "0x788570", VA = "0x180789970", Slot = "11")]
			protected override void OnViewDetached()
			{
			}

			// Token: 0x06010069 RID: 65641 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010069")]
			[Address(RVA = "0x7899D0", Offset = "0x7885D0", VA = "0x1807899D0")]
			public void SetPlaybackCurrent(bool isCurrent)
			{
			}

			// Token: 0x04011D2A RID: 73002
			[Token(Token = "0x4011D2A")]
			[FieldOffset(Offset = "0x20")]
			private DialogPlaybackTextView.Options m_options;

			// Token: 0x04011D2B RID: 73003
			[Token(Token = "0x4011D2B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04011D2C RID: 73004
			[Token(Token = "0x4011D2C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x04011D2D RID: 73005
			[Token(Token = "0x4011D2D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x04011D2E RID: 73006
			[Token(Token = "0x4011D2E")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnViewAttached;

			// Token: 0x04011D2F RID: 73007
			[Token(Token = "0x4011D2F")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OnViewDetached;

			// Token: 0x04011D30 RID: 73008
			[Token(Token = "0x4011D30")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_SetPlaybackCurrent;
		}

		// Token: 0x0200264F RID: 9807
		[Token(Token = "0x200264F")]
		public class SizeCalculator : IHotfixable
		{
			// Token: 0x0601006A RID: 65642 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601006A")]
			[Address(RVA = "0x784A40", Offset = "0x783640", VA = "0x180784A40")]
			public SizeCalculator(DialogPlaybackTextView prefab)
			{
			}

			// Token: 0x0601006B RID: 65643 RVA: 0x00061908 File Offset: 0x0005FB08
			[Token(Token = "0x601006B")]
			[Address(RVA = "0x7847D0", Offset = "0x7833D0", VA = "0x1807847D0")]
			public float CalcSize(string name, string msg)
			{
				return 0f;
			}

			// Token: 0x04011D31 RID: 73009
			[Token(Token = "0x4011D31")]
			[FieldOffset(Offset = "0x10")]
			private TextGenerator m_textGenerator;

			// Token: 0x04011D32 RID: 73010
			[Token(Token = "0x4011D32")]
			[FieldOffset(Offset = "0x18")]
			private TextGenerationSettings m_nameSettings;

			// Token: 0x04011D33 RID: 73011
			[Token(Token = "0x4011D33")]
			[FieldOffset(Offset = "0x78")]
			private TextGenerationSettings m_msgSettings;

			// Token: 0x04011D34 RID: 73012
			[Token(Token = "0x4011D34")]
			[FieldOffset(Offset = "0xD8")]
			private DialogPlaybackTextView m_prefab;

			// Token: 0x04011D35 RID: 73013
			[Token(Token = "0x4011D35")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04011D36 RID: 73014
			[Token(Token = "0x4011D36")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_CalcSize;
		}
	}
}
