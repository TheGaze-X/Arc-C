using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003C83 RID: 15491
	[Token(Token = "0x2003C83")]
	public class TuningChatView : DataBinder<TuningChatProperty>
	{
		// Token: 0x0601831C RID: 99100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601831C")]
		[Address(RVA = "0x10B1F20", Offset = "0x10B0B20", VA = "0x1810B1F20", Slot = "7")]
		public override void OnValueChanged(TuningChatProperty property)
		{
		}

		// Token: 0x0601831D RID: 99101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601831D")]
		[Address(RVA = "0x10B2080", Offset = "0x10B0C80", VA = "0x1810B2080")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601831E RID: 99102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601831E")]
		[Address(RVA = "0x10B2500", Offset = "0x10B1100", VA = "0x1810B2500")]
		private void _OnBagTypeSelect(string typeId)
		{
		}

		// Token: 0x0601831F RID: 99103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601831F")]
		[Address(RVA = "0x10B23F0", Offset = "0x10B0FF0", VA = "0x1810B23F0")]
		private void _OnBagProductSelect(string productId)
		{
		}

		// Token: 0x06018320 RID: 99104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018320")]
		[Address(RVA = "0x10B2610", Offset = "0x10B1210", VA = "0x1810B2610")]
		private void _OnOpenTuning()
		{
		}

		// Token: 0x06018321 RID: 99105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018321")]
		[Address(RVA = "0x10B26B0", Offset = "0x10B12B0", VA = "0x1810B26B0")]
		public TuningChatView()
		{
		}

		// Token: 0x0401D745 RID: 120645
		[Token(Token = "0x401D745")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0401D746 RID: 120646
		[Token(Token = "0x401D746")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TuningProductBagPanelView _bagPanelPrefab;

		// Token: 0x0401D747 RID: 120647
		[Token(Token = "0x401D747")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _bagPanelContainer;

		// Token: 0x0401D748 RID: 120648
		[Token(Token = "0x401D748")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAnimationLocation _chatAnim;

		// Token: 0x0401D749 RID: 120649
		[Token(Token = "0x401D749")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isInited;

		// Token: 0x0401D74A RID: 120650
		[Token(Token = "0x401D74A")]
		[FieldOffset(Offset = "0x50")]
		private TuningChatViewModel m_cachedViewModel;

		// Token: 0x0401D74B RID: 120651
		[Token(Token = "0x401D74B")]
		[FieldOffset(Offset = "0x58")]
		private TuningProductBagPanelView m_bagView;

		// Token: 0x0401D74C RID: 120652
		[Token(Token = "0x401D74C")]
		[FieldOffset(Offset = "0x60")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401D74D RID: 120653
		[Token(Token = "0x401D74D")]
		[FieldOffset(Offset = "0x70")]
		private TuningChatView.Adapter m_adapter;

		// Token: 0x0401D74E RID: 120654
		[Token(Token = "0x401D74E")]
		[FieldOffset(Offset = "0x78")]
		private AnimationSwitchTween m_chatAnimTween;

		// Token: 0x0401D74F RID: 120655
		[Token(Token = "0x401D74F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401D750 RID: 120656
		[Token(Token = "0x401D750")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401D751 RID: 120657
		[Token(Token = "0x401D751")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnBagTypeSelect;

		// Token: 0x0401D752 RID: 120658
		[Token(Token = "0x401D752")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnBagProductSelect;

		// Token: 0x0401D753 RID: 120659
		[Token(Token = "0x401D753")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnOpenTuning;

		// Token: 0x0401D754 RID: 120660
		[Token(Token = "0x401D754")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003C84 RID: 15492
		[Token(Token = "0x2003C84")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x06018322 RID: 99106 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018322")]
			[Address(RVA = "0x10A4190", Offset = "0x10A2D90", VA = "0x1810A4190")]
			public Adapter(TuningChatView closure)
			{
			}

			// Token: 0x170039B9 RID: 14777
			// (get) Token: 0x06018323 RID: 99107 RVA: 0x00099A68 File Offset: 0x00097C68
			[Token(Token = "0x170039B9")]
			public override int count
			{
				[Token(Token = "0x6018323")]
				[Address(RVA = "0x10A4310", Offset = "0x10A2F10", VA = "0x1810A4310", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06018324 RID: 99108 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6018324")]
			[Address(RVA = "0x10A3D00", Offset = "0x10A2900", VA = "0x1810A3D00", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0401D755 RID: 120661
			[Token(Token = "0x401D755")]
			[FieldOffset(Offset = "0x20")]
			private TuningChatView m_closure;

			// Token: 0x0401D756 RID: 120662
			[Token(Token = "0x401D756")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401D757 RID: 120663
			[Token(Token = "0x401D757")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401D758 RID: 120664
			[Token(Token = "0x401D758")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
