using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.Fragment;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x020056B9 RID: 22201
	[Token(Token = "0x20056B9")]
	public class RL04FragmentItemCard : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004C4B RID: 19531
		// (get) Token: 0x060208FA RID: 133370 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060208FB RID: 133371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004C4B")]
		public ILoadAsset loader
		{
			[Token(Token = "0x60208FA")]
			[Address(RVA = "0x1AB1940", Offset = "0x1AB0540", VA = "0x181AB1940")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60208FB")]
			[Address(RVA = "0x1AB1B40", Offset = "0x1AB0740", VA = "0x181AB1B40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004C4C RID: 19532
		// (get) Token: 0x060208FC RID: 133372 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060208FD RID: 133373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004C4C")]
		public Action<string> onItemClicked
		{
			[Token(Token = "0x60208FC")]
			[Address(RVA = "0x1AB19A0", Offset = "0x1AB05A0", VA = "0x181AB19A0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60208FD")]
			[Address(RVA = "0x1AB1BC0", Offset = "0x1AB07C0", VA = "0x181AB1BC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004C4D RID: 19533
		// (get) Token: 0x060208FE RID: 133374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004C4D")]
		public Graphic graphic
		{
			[Token(Token = "0x60208FE")]
			[Address(RVA = "0x1AB1810", Offset = "0x1AB0410", VA = "0x181AB1810")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004C4E RID: 19534
		// (get) Token: 0x060208FF RID: 133375 RVA: 0x000B6688 File Offset: 0x000B4888
		// (set) Token: 0x06020900 RID: 133376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004C4E")]
		public bool interactable
		{
			[Token(Token = "0x60208FF")]
			[Address(RVA = "0x1AB1870", Offset = "0x1AB0470", VA = "0x181AB1870")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6020900")]
			[Address(RVA = "0x1AB1A60", Offset = "0x1AB0660", VA = "0x181AB1A60")]
			set
			{
			}
		}

		// Token: 0x17004C4F RID: 19535
		// (get) Token: 0x06020901 RID: 133377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004C4F")]
		public UIScaler scaler
		{
			[Token(Token = "0x6020901")]
			[Address(RVA = "0x1AB1A00", Offset = "0x1AB0600", VA = "0x181AB1A00")]
			get
			{
				return null;
			}
		}

		// Token: 0x06020902 RID: 133378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020902")]
		[Address(RVA = "0x1AB11B0", Offset = "0x1AAFDB0", VA = "0x181AB11B0")]
		public void Render(IRoguelikeFragmentItemModel viewModel)
		{
		}

		// Token: 0x06020903 RID: 133379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020903")]
		[Address(RVA = "0x1AB10A0", Offset = "0x1AAFCA0", VA = "0x181AB10A0")]
		public void EventOnItemClicked()
		{
		}

		// Token: 0x06020904 RID: 133380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020904")]
		[Address(RVA = "0x1AB1690", Offset = "0x1AB0290", VA = "0x181AB1690")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06020905 RID: 133381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020905")]
		[Address(RVA = "0x1AB17B0", Offset = "0x1AB03B0", VA = "0x181AB17B0")]
		public RL04FragmentItemCard()
		{
		}

		// Token: 0x0402C1D8 RID: 180696
		[Token(Token = "0x402C1D8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgIcon;

		// Token: 0x0402C1D9 RID: 180697
		[Token(Token = "0x402C1D9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0402C1DA RID: 180698
		[Token(Token = "0x402C1DA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textUsage;

		// Token: 0x0402C1DB RID: 180699
		[Token(Token = "0x402C1DB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0402C1DC RID: 180700
		[Token(Token = "0x402C1DC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textWeight;

		// Token: 0x0402C1DD RID: 180701
		[Token(Token = "0x402C1DD")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0402C1DE RID: 180702
		[Token(Token = "0x402C1DE")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelSelected;

		// Token: 0x0402C1DF RID: 180703
		[Token(Token = "0x402C1DF")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIColorGraphic _graphic;

		// Token: 0x0402C1E0 RID: 180704
		[Token(Token = "0x402C1E0")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIScaler _scaler;

		// Token: 0x0402C1E3 RID: 180707
		[Token(Token = "0x402C1E3")]
		[FieldOffset(Offset = "0x70")]
		private bool m_hasInited;

		// Token: 0x0402C1E4 RID: 180708
		[Token(Token = "0x402C1E4")]
		[FieldOffset(Offset = "0x78")]
		private RL04FragmentItemCard.Adapter m_adapter;

		// Token: 0x0402C1E5 RID: 180709
		[Token(Token = "0x402C1E5")]
		[FieldOffset(Offset = "0x80")]
		private int m_cachedValue;

		// Token: 0x0402C1E6 RID: 180710
		[Token(Token = "0x402C1E6")]
		[FieldOffset(Offset = "0x88")]
		private string m_cachedInstId;

		// Token: 0x0402C1E7 RID: 180711
		[Token(Token = "0x402C1E7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_loader;

		// Token: 0x0402C1E8 RID: 180712
		[Token(Token = "0x402C1E8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_loader;

		// Token: 0x0402C1E9 RID: 180713
		[Token(Token = "0x402C1E9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onItemClicked;

		// Token: 0x0402C1EA RID: 180714
		[Token(Token = "0x402C1EA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onItemClicked;

		// Token: 0x0402C1EB RID: 180715
		[Token(Token = "0x402C1EB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_graphic;

		// Token: 0x0402C1EC RID: 180716
		[Token(Token = "0x402C1EC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_interactable;

		// Token: 0x0402C1ED RID: 180717
		[Token(Token = "0x402C1ED")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_interactable;

		// Token: 0x0402C1EE RID: 180718
		[Token(Token = "0x402C1EE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_scaler;

		// Token: 0x0402C1EF RID: 180719
		[Token(Token = "0x402C1EF")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C1F0 RID: 180720
		[Token(Token = "0x402C1F0")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_EventOnItemClicked;

		// Token: 0x0402C1F1 RID: 180721
		[Token(Token = "0x402C1F1")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402C1F2 RID: 180722
		[Token(Token = "0x402C1F2")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020056BA RID: 22202
		[Token(Token = "0x20056BA")]
		private class Adapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x06020906 RID: 133382 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020906")]
			[Address(RVA = "0x1AA38B0", Offset = "0x1AA24B0", VA = "0x181AA38B0")]
			public Adapter(RL04FragmentItemCard closure)
			{
			}

			// Token: 0x17004C50 RID: 19536
			// (get) Token: 0x06020907 RID: 133383 RVA: 0x000B66A0 File Offset: 0x000B48A0
			[Token(Token = "0x17004C50")]
			public override int count
			{
				[Token(Token = "0x6020907")]
				[Address(RVA = "0x1AA3930", Offset = "0x1AA2530", VA = "0x181AA3930", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06020908 RID: 133384 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6020908")]
			[Address(RVA = "0x1AA3710", Offset = "0x1AA2310", VA = "0x181AA3710", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402C1F3 RID: 180723
			[Token(Token = "0x402C1F3")]
			[FieldOffset(Offset = "0x20")]
			private RL04FragmentItemCard m_closure;

			// Token: 0x0402C1F4 RID: 180724
			[Token(Token = "0x402C1F4")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402C1F5 RID: 180725
			[Token(Token = "0x402C1F5")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402C1F6 RID: 180726
			[Token(Token = "0x402C1F6")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
