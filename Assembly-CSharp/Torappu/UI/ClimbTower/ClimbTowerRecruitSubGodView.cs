using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D55 RID: 23893
	[Token(Token = "0x2005D55")]
	public class ClimbTowerRecruitSubGodView : DataBinder<ClimbTowerRecruitSubGodProp>
	{
		// Token: 0x17005181 RID: 20865
		// (get) Token: 0x06022994 RID: 141716 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022995 RID: 141717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005181")]
		public Action<string> onItemSelected
		{
			[Token(Token = "0x6022994")]
			[Address(RVA = "0x1D1F160", Offset = "0x1D1DD60", VA = "0x181D1F160")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6022995")]
			[Address(RVA = "0x1D1F1C0", Offset = "0x1D1DDC0", VA = "0x181D1F1C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06022996 RID: 141718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022996")]
		[Address(RVA = "0x1D1EA90", Offset = "0x1D1D690", VA = "0x181D1EA90", Slot = "7")]
		public override void OnValueChanged(ClimbTowerRecruitSubGodProp property)
		{
		}

		// Token: 0x06022997 RID: 141719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022997")]
		[Address(RVA = "0x1D1EF20", Offset = "0x1D1DB20", VA = "0x181D1EF20")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06022998 RID: 141720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022998")]
		[Address(RVA = "0x1D1F0F0", Offset = "0x1D1DCF0", VA = "0x181D1F0F0")]
		public ClimbTowerRecruitSubGodView()
		{
		}

		// Token: 0x0402F8E6 RID: 194790
		[Token(Token = "0x402F8E6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textTowerInfo;

		// Token: 0x0402F8E7 RID: 194791
		[Token(Token = "0x402F8E7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textMainCardInfo;

		// Token: 0x0402F8E8 RID: 194792
		[Token(Token = "0x402F8E8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SimpleLayoutContent _subCardList;

		// Token: 0x0402F8E9 RID: 194793
		[Token(Token = "0x402F8E9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAnimationLocation _animBtnConfirm;

		// Token: 0x0402F8EA RID: 194794
		[Token(Token = "0x402F8EA")]
		[FieldOffset(Offset = "0x48")]
		private bool m_hasInited;

		// Token: 0x0402F8EB RID: 194795
		[Token(Token = "0x402F8EB")]
		[FieldOffset(Offset = "0x50")]
		private ClimbTowerRecruitSubGodView.Adapter m_adapter;

		// Token: 0x0402F8EC RID: 194796
		[Token(Token = "0x402F8EC")]
		[FieldOffset(Offset = "0x58")]
		private AnimationSwitchTween m_btnConfirmTween;

		// Token: 0x0402F8ED RID: 194797
		[Token(Token = "0x402F8ED")]
		[FieldOffset(Offset = "0x60")]
		private ClimbTowerRecruitSubGodModel m_recruitModel;

		// Token: 0x0402F8EF RID: 194799
		[Token(Token = "0x402F8EF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onItemSelected;

		// Token: 0x0402F8F0 RID: 194800
		[Token(Token = "0x402F8F0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onItemSelected;

		// Token: 0x0402F8F1 RID: 194801
		[Token(Token = "0x402F8F1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402F8F2 RID: 194802
		[Token(Token = "0x402F8F2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402F8F3 RID: 194803
		[Token(Token = "0x402F8F3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005D56 RID: 23894
		[Token(Token = "0x2005D56")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x06022999 RID: 141721 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022999")]
			[Address(RVA = "0x1D15F10", Offset = "0x1D14B10", VA = "0x181D15F10")]
			public Adapter(ClimbTowerRecruitSubGodView closure)
			{
			}

			// Token: 0x17005182 RID: 20866
			// (get) Token: 0x0602299A RID: 141722 RVA: 0x000BE008 File Offset: 0x000BC208
			[Token(Token = "0x17005182")]
			public override int count
			{
				[Token(Token = "0x602299A")]
				[Address(RVA = "0x1D16090", Offset = "0x1D14C90", VA = "0x181D16090", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602299B RID: 141723 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602299B")]
			[Address(RVA = "0x1D155D0", Offset = "0x1D141D0", VA = "0x181D155D0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402F8F4 RID: 194804
			[Token(Token = "0x402F8F4")]
			[FieldOffset(Offset = "0x20")]
			private ClimbTowerRecruitSubGodView m_closure;

			// Token: 0x0402F8F5 RID: 194805
			[Token(Token = "0x402F8F5")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402F8F6 RID: 194806
			[Token(Token = "0x402F8F6")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402F8F7 RID: 194807
			[Token(Token = "0x402F8F7")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
