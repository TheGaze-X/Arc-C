using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020053C1 RID: 21441
	[Token(Token = "0x20053C1")]
	public class RoguelikeScrollReportTitleView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601F8E6 RID: 129254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F8E6")]
		[Address(RVA = "0x194B400", Offset = "0x194A000", VA = "0x18194B400")]
		private void _NotifyToShow(bool useFastMode)
		{
		}

		// Token: 0x0601F8E7 RID: 129255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F8E7")]
		[Address(RVA = "0x194B4B0", Offset = "0x194A0B0", VA = "0x18194B4B0")]
		public RoguelikeScrollReportTitleView()
		{
		}

		// Token: 0x0402A7BD RID: 174013
		[Token(Token = "0x402A7BD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _padding;

		// Token: 0x0402A7BE RID: 174014
		[Token(Token = "0x402A7BE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0402A7BF RID: 174015
		[Token(Token = "0x402A7BF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textActor;

		// Token: 0x0402A7C0 RID: 174016
		[Token(Token = "0x402A7C0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _animEnter;

		// Token: 0x0402A7C1 RID: 174017
		[Token(Token = "0x402A7C1")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Tooltip("Delay used for holder to play next step")]
		private float _enterDuration;

		// Token: 0x0402A7C2 RID: 174018
		[Token(Token = "0x402A7C2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__NotifyToShow;

		// Token: 0x0402A7C3 RID: 174019
		[Token(Token = "0x402A7C3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020053C2 RID: 21442
		[Token(Token = "0x20053C2")]
		public class VirtualView : BasicReportItem<RoguelikeScrollReportTitleView>
		{
			// Token: 0x0601F8E8 RID: 129256 RVA: 0x000B23B0 File Offset: 0x000B05B0
			[Token(Token = "0x601F8E8")]
			[Address(RVA = "0x194E390", Offset = "0x194CF90", VA = "0x18194E390")]
			public float NotifyToShow(bool useFastMode)
			{
				return 0f;
			}

			// Token: 0x0601F8E9 RID: 129257 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F8E9")]
			[Address(RVA = "0x194E8F0", Offset = "0x194D4F0", VA = "0x18194E8F0")]
			public VirtualView(RoguelikeScrollReportTitleView prefab)
			{
			}

			// Token: 0x0601F8EA RID: 129258 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601F8EA")]
			[Address(RVA = "0x194DFB0", Offset = "0x194CBB0", VA = "0x18194DFB0", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x0601F8EB RID: 129259 RVA: 0x000B23C8 File Offset: 0x000B05C8
			[Token(Token = "0x601F8EB")]
			[Address(RVA = "0x194E310", Offset = "0x194CF10", VA = "0x18194E310", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x0601F8EC RID: 129260 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F8EC")]
			[Address(RVA = "0x194E660", Offset = "0x194D260", VA = "0x18194E660", Slot = "14")]
			protected override void OnRenderView(RoguelikeScrollReportTitleView view)
			{
			}

			// Token: 0x0402A7C4 RID: 174020
			[Token(Token = "0x402A7C4")]
			[FieldOffset(Offset = "0x20")]
			private RoguelikeScrollReportTitleView m_prefab;

			// Token: 0x0402A7C5 RID: 174021
			[Token(Token = "0x402A7C5")]
			[FieldOffset(Offset = "0x28")]
			private bool m_isShow;

			// Token: 0x0402A7C6 RID: 174022
			[Token(Token = "0x402A7C6")]
			[FieldOffset(Offset = "0x29")]
			private bool m_isFastMode;

			// Token: 0x0402A7C7 RID: 174023
			[Token(Token = "0x402A7C7")]
			[FieldOffset(Offset = "0x30")]
			public string playerName;

			// Token: 0x0402A7C8 RID: 174024
			[Token(Token = "0x402A7C8")]
			[FieldOffset(Offset = "0x38")]
			public string actorName;

			// Token: 0x0402A7C9 RID: 174025
			[Token(Token = "0x402A7C9")]
			[FieldOffset(Offset = "0x40")]
			public float screenHeight;

			// Token: 0x0402A7CA RID: 174026
			[Token(Token = "0x402A7CA")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_NotifyToShow;

			// Token: 0x0402A7CB RID: 174027
			[Token(Token = "0x402A7CB")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402A7CC RID: 174028
			[Token(Token = "0x402A7CC")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0402A7CD RID: 174029
			[Token(Token = "0x402A7CD")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x0402A7CE RID: 174030
			[Token(Token = "0x402A7CE")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OnRenderView;
		}
	}
}
