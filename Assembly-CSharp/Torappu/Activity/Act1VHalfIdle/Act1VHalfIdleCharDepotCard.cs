using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007740 RID: 30528
	[Token(Token = "0x2007740")]
	public class Act1VHalfIdleCharDepotCard : MonoBehaviour, IHotfixable
	{
		// Token: 0x17006493 RID: 25747
		// (get) Token: 0x0602AE30 RID: 175664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006493")]
		public UIColorGraphic colorGraphic
		{
			[Token(Token = "0x602AE30")]
			[Address(RVA = "0x26AB790", Offset = "0x26AA390", VA = "0x1826AB790")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602AE31 RID: 175665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE31")]
		[Address(RVA = "0x26AB580", Offset = "0x26AA180", VA = "0x1826AB580")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602AE32 RID: 175666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE32")]
		[Address(RVA = "0x26AB110", Offset = "0x26A9D10", VA = "0x1826AB110")]
		public void RenderCard(Act1VHalfIdleCharDepotCard.Options input)
		{
		}

		// Token: 0x0602AE33 RID: 175667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE33")]
		[Address(RVA = "0x26AAFA0", Offset = "0x26A9BA0", VA = "0x1826AAFA0")]
		public void EventOnClickCard()
		{
		}

		// Token: 0x0602AE34 RID: 175668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE34")]
		[Address(RVA = "0x26AB070", Offset = "0x26A9C70", VA = "0x1826AB070")]
		public void RegisterTutorialGO()
		{
		}

		// Token: 0x0602AE35 RID: 175669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE35")]
		[Address(RVA = "0x26AB720", Offset = "0x26AA320", VA = "0x1826AB720")]
		public Act1VHalfIdleCharDepotCard()
		{
		}

		// Token: 0x0403DD57 RID: 253271
		[Token(Token = "0x403DD57")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _cardViewRoot;

		// Token: 0x0403DD58 RID: 253272
		[Token(Token = "0x403DD58")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIColorGraphic _colorGraphic;

		// Token: 0x0403DD59 RID: 253273
		[Token(Token = "0x403DD59")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Act1VHalfIdleCharDepotCard.CardDecoConfig[] _cardTypeConfigs;

		// Token: 0x0403DD5A RID: 253274
		[Token(Token = "0x403DD5A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CommonCharCardView _cardRes;

		// Token: 0x0403DD5B RID: 253275
		[Token(Token = "0x403DD5B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _pnlTrackpoint;

		// Token: 0x0403DD5C RID: 253276
		[Token(Token = "0x403DD5C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _btnDepotCharCardGO;

		// Token: 0x0403DD5D RID: 253277
		[Token(Token = "0x403DD5D")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public Action<Act1VHalfIdleCharDepotCard.Options> onClick;

		// Token: 0x0403DD5E RID: 253278
		[Token(Token = "0x403DD5E")]
		[FieldOffset(Offset = "0x50")]
		private CommonCharCardView m_cachedCard;

		// Token: 0x0403DD5F RID: 253279
		[Token(Token = "0x403DD5F")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isInited;

		// Token: 0x0403DD60 RID: 253280
		[Token(Token = "0x403DD60")]
		[FieldOffset(Offset = "0x5C")]
		private int m_cachedIndex;

		// Token: 0x0403DD61 RID: 253281
		[Token(Token = "0x403DD61")]
		[FieldOffset(Offset = "0x60")]
		private Act1VHalfIdleCharViewModel m_cachedMember;

		// Token: 0x0403DD62 RID: 253282
		[Token(Token = "0x403DD62")]
		[FieldOffset(Offset = "0x68")]
		private string m_cachedActId;

		// Token: 0x0403DD63 RID: 253283
		[Token(Token = "0x403DD63")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_colorGraphic;

		// Token: 0x0403DD64 RID: 253284
		[Token(Token = "0x403DD64")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403DD65 RID: 253285
		[Token(Token = "0x403DD65")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RenderCard;

		// Token: 0x0403DD66 RID: 253286
		[Token(Token = "0x403DD66")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnClickCard;

		// Token: 0x0403DD67 RID: 253287
		[Token(Token = "0x403DD67")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RegisterTutorialGO;

		// Token: 0x0403DD68 RID: 253288
		[Token(Token = "0x403DD68")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007741 RID: 30529
		[Token(Token = "0x2007741")]
		[Serializable]
		public struct CardDecoConfig
		{
			// Token: 0x17006494 RID: 25748
			// (get) Token: 0x0602AE36 RID: 175670 RVA: 0x000DA568 File Offset: 0x000D8768
			[Token(Token = "0x17006494")]
			public bool isEmpty
			{
				[Token(Token = "0x602AE36")]
				[Address(RVA = "0x26C25B0", Offset = "0x26C11B0", VA = "0x1826C25B0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17006495 RID: 25749
			// (get) Token: 0x0602AE37 RID: 175671 RVA: 0x000DA580 File Offset: 0x000D8780
			[Token(Token = "0x17006495")]
			public Act1VHalfIdleCharViewModel.Act1VHalfIdleCharType charType
			{
				[Token(Token = "0x602AE37")]
				[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260")]
				get
				{
					return Act1VHalfIdleCharViewModel.Act1VHalfIdleCharType.COMMON;
				}
			}

			// Token: 0x17006496 RID: 25750
			// (get) Token: 0x0602AE38 RID: 175672 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17006496")]
			public GameObject panel
			{
				[Token(Token = "0x602AE38")]
				[Address(RVA = "0xE93E60", Offset = "0xE92A60", VA = "0x180E93E60")]
				get
				{
					return null;
				}
			}

			// Token: 0x0403DD69 RID: 253289
			[Token(Token = "0x403DD69")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			private Act1VHalfIdleCharViewModel.Act1VHalfIdleCharType _charType;

			// Token: 0x0403DD6A RID: 253290
			[Token(Token = "0x403DD6A")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			private GameObject _panel;
		}

		// Token: 0x02007742 RID: 30530
		[Token(Token = "0x2007742")]
		public struct Options
		{
			// Token: 0x17006497 RID: 25751
			// (get) Token: 0x0602AE39 RID: 175673 RVA: 0x000DA598 File Offset: 0x000D8798
			[Token(Token = "0x17006497")]
			public bool isEmpty
			{
				[Token(Token = "0x602AE39")]
				[Address(RVA = "0x26C2720", Offset = "0x26C1320", VA = "0x1826C2720")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0403DD6B RID: 253291
			[Token(Token = "0x403DD6B")]
			[FieldOffset(Offset = "0x0")]
			public int index;

			// Token: 0x0403DD6C RID: 253292
			[Token(Token = "0x403DD6C")]
			[FieldOffset(Offset = "0x8")]
			public string actId;

			// Token: 0x0403DD6D RID: 253293
			[Token(Token = "0x403DD6D")]
			[FieldOffset(Offset = "0x10")]
			public Act1VHalfIdleCharViewModel member;
		}
	}
}
