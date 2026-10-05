using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D95 RID: 23957
	[Token(Token = "0x2005D95")]
	public class ClimbTowerSquadExpansionSlotItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005203 RID: 20995
		// (get) Token: 0x06022BBA RID: 142266 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022BBB RID: 142267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005203")]
		public Action<bool, string, string> onCharSelect
		{
			[Token(Token = "0x6022BBA")]
			[Address(RVA = "0x1D38BD0", Offset = "0x1D377D0", VA = "0x181D38BD0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6022BBB")]
			[Address(RVA = "0x1D38C30", Offset = "0x1D37830", VA = "0x181D38C30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06022BBC RID: 142268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022BBC")]
		[Address(RVA = "0x1D38090", Offset = "0x1D36C90", VA = "0x181D38090")]
		public void Render(string selectCharId, bool isGroupSelect, bool haveAnySelect, IClimbTowerExpansionSlot slotModel)
		{
		}

		// Token: 0x06022BBD RID: 142269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022BBD")]
		[Address(RVA = "0x1D38740", Offset = "0x1D37340", VA = "0x181D38740")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06022BBE RID: 142270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022BBE")]
		[Address(RVA = "0x1D388D0", Offset = "0x1D374D0", VA = "0x181D388D0")]
		private void _UpdateLayoutElement()
		{
		}

		// Token: 0x06022BBF RID: 142271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022BBF")]
		[Address(RVA = "0x1D38590", Offset = "0x1D37190", VA = "0x181D38590")]
		public void ResetAnim()
		{
		}

		// Token: 0x06022BC0 RID: 142272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022BC0")]
		[Address(RVA = "0x1D37DA0", Offset = "0x1D369A0", VA = "0x181D37DA0")]
		public IEnumerator PlayFallAnim()
		{
			return null;
		}

		// Token: 0x06022BC1 RID: 142273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022BC1")]
		[Address(RVA = "0x1D37CF0", Offset = "0x1D368F0", VA = "0x181D37CF0")]
		public IEnumerator PlayExpandAnim()
		{
			return null;
		}

		// Token: 0x06022BC2 RID: 142274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022BC2")]
		[Address(RVA = "0x1D37E50", Offset = "0x1D36A50", VA = "0x181D37E50")]
		public void RegisterTutorialGo()
		{
		}

		// Token: 0x06022BC3 RID: 142275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022BC3")]
		[Address(RVA = "0x1D38B10", Offset = "0x1D37710", VA = "0x181D38B10")]
		public ClimbTowerSquadExpansionSlotItemView()
		{
		}

		// Token: 0x0402FC04 RID: 195588
		[Token(Token = "0x402FC04")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private LayoutElement _layoutElement;

		// Token: 0x0402FC05 RID: 195589
		[Token(Token = "0x402FC05")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _charItemSpacing;

		// Token: 0x0402FC06 RID: 195590
		[Token(Token = "0x402FC06")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _charList;

		// Token: 0x0402FC07 RID: 195591
		[Token(Token = "0x402FC07")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ClimbTowerSquadExpansionCharItemView _charItemPrefab;

		// Token: 0x0402FC08 RID: 195592
		[Token(Token = "0x402FC08")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAnimationLocation _fallAnim;

		// Token: 0x0402FC09 RID: 195593
		[Token(Token = "0x402FC09")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CanvasGroup _spCanvasGroup;

		// Token: 0x0402FC0A RID: 195594
		[Token(Token = "0x402FC0A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _spPanelTweenDuration;

		// Token: 0x0402FC0B RID: 195595
		[Token(Token = "0x402FC0B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textSpName;

		// Token: 0x0402FC0C RID: 195596
		[Token(Token = "0x402FC0C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIAtlasImage _imageChrPortrait;

		// Token: 0x0402FC0D RID: 195597
		[Token(Token = "0x402FC0D")]
		[FieldOffset(Offset = "0x68")]
		private bool m_isGroupedCharSlot;

		// Token: 0x0402FC0E RID: 195598
		[Token(Token = "0x402FC0E")]
		[FieldOffset(Offset = "0x69")]
		private bool m_isGroupSelect;

		// Token: 0x0402FC0F RID: 195599
		[Token(Token = "0x402FC0F")]
		[FieldOffset(Offset = "0x6A")]
		private bool m_haveAnySelect;

		// Token: 0x0402FC10 RID: 195600
		[Token(Token = "0x402FC10")]
		[FieldOffset(Offset = "0x70")]
		private string m_selectCharId;

		// Token: 0x0402FC11 RID: 195601
		[Token(Token = "0x402FC11")]
		[FieldOffset(Offset = "0x78")]
		private IClimbTowerExpansionSlot m_slotModel;

		// Token: 0x0402FC12 RID: 195602
		[Token(Token = "0x402FC12")]
		[FieldOffset(Offset = "0x80")]
		private ClimbTowerSquadExpansionSlotItemView.Adapter m_adapter;

		// Token: 0x0402FC13 RID: 195603
		[Token(Token = "0x402FC13")]
		[FieldOffset(Offset = "0x88")]
		private List<ClimbTowerSquadExpansionCharItemView> m_charItemList;

		// Token: 0x0402FC14 RID: 195604
		[Token(Token = "0x402FC14")]
		[FieldOffset(Offset = "0x90")]
		private FadeSwitchTween m_fadeTween;

		// Token: 0x0402FC15 RID: 195605
		[Token(Token = "0x402FC15")]
		[FieldOffset(Offset = "0x98")]
		private bool m_hasInited;

		// Token: 0x0402FC16 RID: 195606
		[Token(Token = "0x402FC16")]
		[FieldOffset(Offset = "0xA0")]
		private string m_portraitCache;

		// Token: 0x0402FC18 RID: 195608
		[Token(Token = "0x402FC18")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onCharSelect;

		// Token: 0x0402FC19 RID: 195609
		[Token(Token = "0x402FC19")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onCharSelect;

		// Token: 0x0402FC1A RID: 195610
		[Token(Token = "0x402FC1A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402FC1B RID: 195611
		[Token(Token = "0x402FC1B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402FC1C RID: 195612
		[Token(Token = "0x402FC1C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateLayoutElement;

		// Token: 0x0402FC1D RID: 195613
		[Token(Token = "0x402FC1D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ResetAnim;

		// Token: 0x0402FC1E RID: 195614
		[Token(Token = "0x402FC1E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_PlayFallAnim;

		// Token: 0x0402FC1F RID: 195615
		[Token(Token = "0x402FC1F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_PlayExpandAnim;

		// Token: 0x0402FC20 RID: 195616
		[Token(Token = "0x402FC20")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_RegisterTutorialGo;

		// Token: 0x0402FC21 RID: 195617
		[Token(Token = "0x402FC21")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005D96 RID: 23958
		[Token(Token = "0x2005D96")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x06022BC5 RID: 142277 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022BC5")]
			[Address(RVA = "0x1D314B0", Offset = "0x1D300B0", VA = "0x181D314B0")]
			public Adapter(ClimbTowerSquadExpansionSlotItemView closure)
			{
			}

			// Token: 0x17005204 RID: 20996
			// (get) Token: 0x06022BC6 RID: 142278 RVA: 0x000BE9F8 File Offset: 0x000BCBF8
			[Token(Token = "0x17005204")]
			public override int count
			{
				[Token(Token = "0x6022BC6")]
				[Address(RVA = "0x1D316B0", Offset = "0x1D302B0", VA = "0x181D316B0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06022BC7 RID: 142279 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022BC7")]
			[Address(RVA = "0x1D30500", Offset = "0x1D2F100", VA = "0x181D30500")]
			public void GetCharItemList(List<ClimbTowerSquadExpansionCharItemView> outputList)
			{
			}

			// Token: 0x06022BC8 RID: 142280 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6022BC8")]
			[Address(RVA = "0x1D308E0", Offset = "0x1D2F4E0", VA = "0x181D308E0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06022BC9 RID: 142281 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022BC9")]
			[Address(RVA = "0x1D31290", Offset = "0x1D2FE90", VA = "0x181D31290")]
			private void _RenderCharItemView(ClimbTowerSquadExpansionCharItemView itemView, int position)
			{
			}

			// Token: 0x06022BCA RID: 142282 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022BCA")]
			[Address(RVA = "0x1D30730", Offset = "0x1D2F330", VA = "0x181D30730")]
			public void RegisterTutorialGo()
			{
			}

			// Token: 0x0402FC22 RID: 195618
			[Token(Token = "0x402FC22")]
			private const int TUTORIAL_ITEM_INDEX = 0;

			// Token: 0x0402FC23 RID: 195619
			[Token(Token = "0x402FC23")]
			[FieldOffset(Offset = "0x20")]
			private ClimbTowerSquadExpansionSlotItemView m_closure;

			// Token: 0x0402FC24 RID: 195620
			[Token(Token = "0x402FC24")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402FC25 RID: 195621
			[Token(Token = "0x402FC25")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402FC26 RID: 195622
			[Token(Token = "0x402FC26")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetCharItemList;

			// Token: 0x0402FC27 RID: 195623
			[Token(Token = "0x402FC27")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0402FC28 RID: 195624
			[Token(Token = "0x402FC28")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__RenderCharItemView;

			// Token: 0x0402FC29 RID: 195625
			[Token(Token = "0x402FC29")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_RegisterTutorialGo;
		}
	}
}
