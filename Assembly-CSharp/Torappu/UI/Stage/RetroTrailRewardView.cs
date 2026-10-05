using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006807 RID: 26631
	[Token(Token = "0x2006807")]
	public class RetroTrailRewardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602628C RID: 156300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602628C")]
		[Address(RVA = "0x21333E0", Offset = "0x2131FE0", VA = "0x1821333E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602628D RID: 156301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602628D")]
		[Address(RVA = "0x2132EE0", Offset = "0x2131AE0", VA = "0x182132EE0")]
		public void Render(SideStoryViewModel storyViewModel, UICharacterIllustLoader illustLoader)
		{
		}

		// Token: 0x0602628E RID: 156302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602628E")]
		[Address(RVA = "0x2133570", Offset = "0x2132170", VA = "0x182133570")]
		private void _LoadRetroBackImage(string retroId, string charId, UICharacterIllustLoader illustLoader)
		{
		}

		// Token: 0x0602628F RID: 156303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602628F")]
		[Address(RVA = "0x2133940", Offset = "0x2132540", VA = "0x182133940")]
		public RetroTrailRewardView()
		{
		}

		// Token: 0x04035BF8 RID: 220152
		[Token(Token = "0x4035BF8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _backImage;

		// Token: 0x04035BF9 RID: 220153
		[Token(Token = "0x4035BF9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x04035BFA RID: 220154
		[Token(Token = "0x4035BFA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _backImg;

		// Token: 0x04035BFB RID: 220155
		[Token(Token = "0x4035BFB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _titleImg;

		// Token: 0x04035BFC RID: 220156
		[Token(Token = "0x4035BFC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _portraitCont;

		// Token: 0x04035BFD RID: 220157
		[Token(Token = "0x4035BFD")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _illustContainer;

		// Token: 0x04035BFE RID: 220158
		[Token(Token = "0x4035BFE")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _potentialImg;

		// Token: 0x04035BFF RID: 220159
		[Token(Token = "0x4035BFF")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _currentStar;

		// Token: 0x04035C00 RID: 220160
		[Token(Token = "0x4035C00")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _maxStar;

		// Token: 0x04035C01 RID: 220161
		[Token(Token = "0x4035C01")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIStringEvent _onClickEvent;

		// Token: 0x04035C02 RID: 220162
		[Token(Token = "0x4035C02")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _rarityImg;

		// Token: 0x04035C03 RID: 220163
		[Token(Token = "0x4035C03")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image _professionImg;

		// Token: 0x04035C04 RID: 220164
		[Token(Token = "0x4035C04")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _charName;

		// Token: 0x04035C05 RID: 220165
		[Token(Token = "0x4035C05")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private TwoStateToggle _toggleCharFullPotential;

		// Token: 0x04035C06 RID: 220166
		[Token(Token = "0x4035C06")]
		[FieldOffset(Offset = "0x88")]
		private RetroTrailRewardView.Adapter m_adatper;

		// Token: 0x04035C07 RID: 220167
		[Token(Token = "0x4035C07")]
		[FieldOffset(Offset = "0x90")]
		private bool m_isInited;

		// Token: 0x04035C08 RID: 220168
		[Token(Token = "0x4035C08")]
		[FieldOffset(Offset = "0x98")]
		private UICharacterIllust m_illust;

		// Token: 0x04035C09 RID: 220169
		[Token(Token = "0x4035C09")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04035C0A RID: 220170
		[Token(Token = "0x4035C0A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04035C0B RID: 220171
		[Token(Token = "0x4035C0B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadRetroBackImage;

		// Token: 0x04035C0C RID: 220172
		[Token(Token = "0x4035C0C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006808 RID: 26632
		[Token(Token = "0x2006808")]
		public class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x17005A39 RID: 23097
			// (get) Token: 0x06026290 RID: 156304 RVA: 0x000CA350 File Offset: 0x000C8550
			[Token(Token = "0x17005A39")]
			public override int count
			{
				[Token(Token = "0x6026290")]
				[Address(RVA = "0x2130C30", Offset = "0x212F830", VA = "0x182130C30", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06026291 RID: 156305 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6026291")]
			[Address(RVA = "0x21306F0", Offset = "0x212F2F0", VA = "0x1821306F0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06026292 RID: 156306 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026292")]
			[Address(RVA = "0x2130B00", Offset = "0x212F700", VA = "0x182130B00")]
			public Adapter()
			{
			}

			// Token: 0x04035C0D RID: 220173
			[Token(Token = "0x4035C0D")]
			[FieldOffset(Offset = "0x20")]
			public Color themeColor;

			// Token: 0x04035C0E RID: 220174
			[Token(Token = "0x4035C0E")]
			[FieldOffset(Offset = "0x30")]
			public List<SideStoryTrailViewModel> trailViewModelList;

			// Token: 0x04035C0F RID: 220175
			[Token(Token = "0x4035C0F")]
			[FieldOffset(Offset = "0x38")]
			public UIStringEvent onClickEvent;

			// Token: 0x04035C10 RID: 220176
			[Token(Token = "0x4035C10")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04035C11 RID: 220177
			[Token(Token = "0x4035C11")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04035C12 RID: 220178
			[Token(Token = "0x4035C12")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
