using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act45Side
{
	// Token: 0x020072D3 RID: 29395
	[Token(Token = "0x20072D3")]
	public class Act45SideCharUnlockDialog : UICompDialog<Act45SideCharUnlockDialog.Input>
	{
		// Token: 0x060299A9 RID: 170409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60299A9")]
		[Address(RVA = "0x24F1B00", Offset = "0x24F0700", VA = "0x1824F1B00")]
		public void EventOnConfirmCharClicked()
		{
		}

		// Token: 0x060299AA RID: 170410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60299AA")]
		[Address(RVA = "0x24F1B60", Offset = "0x24F0760", VA = "0x1824F1B60", Slot = "18")]
		protected override void OnRender(Act45SideCharUnlockDialog.Input input)
		{
		}

		// Token: 0x060299AB RID: 170411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60299AB")]
		[Address(RVA = "0x24F2420", Offset = "0x24F1020", VA = "0x1824F2420")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060299AC RID: 170412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60299AC")]
		[Address(RVA = "0x24F2030", Offset = "0x24F0C30", VA = "0x1824F2030")]
		private void _ConfirmChars()
		{
		}

		// Token: 0x060299AD RID: 170413 RVA: 0x000D6020 File Offset: 0x000D4220
		[Token(Token = "0x60299AD")]
		[Address(RVA = "0x24F22A0", Offset = "0x24F0EA0", VA = "0x1824F22A0")]
		private bool _EnsureHasNewChar()
		{
			return default(bool);
		}

		// Token: 0x060299AE RID: 170414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60299AE")]
		[Address(RVA = "0x24F1E60", Offset = "0x24F0A60", VA = "0x1824F1E60")]
		private void _PlayHideAnim()
		{
		}

		// Token: 0x060299AF RID: 170415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60299AF")]
		[Address(RVA = "0x24F2620", Offset = "0x24F1220", VA = "0x1824F2620")]
		public Act45SideCharUnlockDialog()
		{
		}

		// Token: 0x0403B808 RID: 243720
		[Token(Token = "0x403B808")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0403B809 RID: 243721
		[Token(Token = "0x403B809")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private SimpleLayoutContent _cardContent;

		// Token: 0x0403B80A RID: 243722
		[Token(Token = "0x403B80A")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _unlockText;

		// Token: 0x0403B80B RID: 243723
		[Token(Token = "0x403B80B")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private float _cardAnimTimeInterval;

		// Token: 0x0403B80C RID: 243724
		[Token(Token = "0x403B80C")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private float _fadeDuration;

		// Token: 0x0403B80D RID: 243725
		[Token(Token = "0x403B80D")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIAnimationLocation _entryAnim;

		// Token: 0x0403B80E RID: 243726
		[Token(Token = "0x403B80E")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_isInited;

		// Token: 0x0403B80F RID: 243727
		[Token(Token = "0x403B80F")]
		[FieldOffset(Offset = "0xA8")]
		private string m_cachedActId;

		// Token: 0x0403B810 RID: 243728
		[Token(Token = "0x403B810")]
		[FieldOffset(Offset = "0xB0")]
		private Act45SideCharUnlockDialog.CardAdapter m_adapter;

		// Token: 0x0403B811 RID: 243729
		[Token(Token = "0x403B811")]
		[FieldOffset(Offset = "0xB8")]
		private Act45SideCharUnlockViewModel m_cachedModel;

		// Token: 0x0403B812 RID: 243730
		[Token(Token = "0x403B812")]
		[FieldOffset(Offset = "0xC0")]
		private Tween m_entryTween;

		// Token: 0x0403B813 RID: 243731
		[Token(Token = "0x403B813")]
		[FieldOffset(Offset = "0xC8")]
		private Tween m_fadeTween;

		// Token: 0x0403B814 RID: 243732
		[Token(Token = "0x403B814")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_EventOnConfirmCharClicked;

		// Token: 0x0403B815 RID: 243733
		[Token(Token = "0x403B815")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0403B816 RID: 243734
		[Token(Token = "0x403B816")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403B817 RID: 243735
		[Token(Token = "0x403B817")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ConfirmChars;

		// Token: 0x0403B818 RID: 243736
		[Token(Token = "0x403B818")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__EnsureHasNewChar;

		// Token: 0x0403B819 RID: 243737
		[Token(Token = "0x403B819")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__PlayHideAnim;

		// Token: 0x0403B81A RID: 243738
		[Token(Token = "0x403B81A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020072D4 RID: 29396
		[Token(Token = "0x20072D4")]
		public class Input
		{
			// Token: 0x060299B2 RID: 170418 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60299B2")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0403B81B RID: 243739
			[Token(Token = "0x403B81B")]
			[FieldOffset(Offset = "0x10")]
			public string actId;
		}

		// Token: 0x020072D5 RID: 29397
		[Token(Token = "0x20072D5")]
		private class CardAdapter : SimpleLayoutAdapter
		{
			// Token: 0x1700625E RID: 25182
			// (get) Token: 0x060299B3 RID: 170419 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060299B4 RID: 170420 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700625E")]
			public ILoadAsset assetLoader
			{
				[Token(Token = "0x60299B3")]
				[Address(RVA = "0x2501870", Offset = "0x2500470", VA = "0x182501870")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x60299B4")]
				[Address(RVA = "0x2501A10", Offset = "0x2500610", VA = "0x182501A10")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700625F RID: 25183
			// (get) Token: 0x060299B5 RID: 170421 RVA: 0x000D6038 File Offset: 0x000D4238
			// (set) Token: 0x060299B6 RID: 170422 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700625F")]
			public float animTimeInterval
			{
				[Token(Token = "0x60299B5")]
				[Address(RVA = "0x2501810", Offset = "0x2500410", VA = "0x182501810")]
				[CompilerGenerated]
				private get
				{
					return 0f;
				}
				[Token(Token = "0x60299B6")]
				[Address(RVA = "0x25019A0", Offset = "0x25005A0", VA = "0x1825019A0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x060299B7 RID: 170423 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60299B7")]
			[Address(RVA = "0x2501790", Offset = "0x2500390", VA = "0x182501790")]
			public CardAdapter(Act45SideCharUnlockDialog closure)
			{
			}

			// Token: 0x17006260 RID: 25184
			// (get) Token: 0x060299B8 RID: 170424 RVA: 0x000D6050 File Offset: 0x000D4250
			[Token(Token = "0x17006260")]
			public override int count
			{
				[Token(Token = "0x60299B8")]
				[Address(RVA = "0x25018D0", Offset = "0x25004D0", VA = "0x1825018D0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060299B9 RID: 170425 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60299B9")]
			[Address(RVA = "0x25013E0", Offset = "0x24FFFE0", VA = "0x1825013E0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403B81E RID: 243742
			[Token(Token = "0x403B81E")]
			[FieldOffset(Offset = "0x30")]
			private Act45SideCharUnlockDialog m_closure;

			// Token: 0x0403B81F RID: 243743
			[Token(Token = "0x403B81F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_assetLoader;

			// Token: 0x0403B820 RID: 243744
			[Token(Token = "0x403B820")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_assetLoader;

			// Token: 0x0403B821 RID: 243745
			[Token(Token = "0x403B821")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_animTimeInterval;

			// Token: 0x0403B822 RID: 243746
			[Token(Token = "0x403B822")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_animTimeInterval;

			// Token: 0x0403B823 RID: 243747
			[Token(Token = "0x403B823")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403B824 RID: 243748
			[Token(Token = "0x403B824")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403B825 RID: 243749
			[Token(Token = "0x403B825")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
