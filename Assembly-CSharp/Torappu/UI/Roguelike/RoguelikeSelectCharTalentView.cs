using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020054AA RID: 21674
	[Token(Token = "0x20054AA")]
	public class RoguelikeSelectCharTalentView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601FE2E RID: 130606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE2E")]
		[Address(RVA = "0x1A141F0", Offset = "0x1A12DF0", VA = "0x181A141F0")]
		public void RenderOnFirstTime()
		{
		}

		// Token: 0x0601FE2F RID: 130607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE2F")]
		[Address(RVA = "0x1A14870", Offset = "0x1A13470", VA = "0x181A14870")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601FE30 RID: 130608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE30")]
		[Address(RVA = "0x1A142A0", Offset = "0x1A12EA0", VA = "0x181A142A0")]
		public void Render(RoguelikeCharCardViewModel viewModel)
		{
		}

		// Token: 0x0601FE31 RID: 130609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE31")]
		[Address(RVA = "0x1A13D80", Offset = "0x1A12980", VA = "0x181A13D80")]
		public void OnHide()
		{
		}

		// Token: 0x0601FE32 RID: 130610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE32")]
		[Address(RVA = "0x1A13FD0", Offset = "0x1A12BD0", VA = "0x181A13FD0")]
		public void OnShow()
		{
		}

		// Token: 0x0601FE33 RID: 130611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE33")]
		[Address(RVA = "0x1A14980", Offset = "0x1A13580", VA = "0x181A14980")]
		public RoguelikeSelectCharTalentView()
		{
		}

		// Token: 0x0402B00E RID: 176142
		[Token(Token = "0x402B00E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _descText;

		// Token: 0x0402B00F RID: 176143
		[Token(Token = "0x402B00F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0402B010 RID: 176144
		[Token(Token = "0x402B010")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _titlePart;

		// Token: 0x0402B011 RID: 176145
		[Token(Token = "0x402B011")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private LayoutElement _layoutElement;

		// Token: 0x0402B012 RID: 176146
		[Token(Token = "0x402B012")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _hideBtn;

		// Token: 0x0402B013 RID: 176147
		[Token(Token = "0x402B013")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _showBtn;

		// Token: 0x0402B014 RID: 176148
		[Token(Token = "0x402B014")]
		[FieldOffset(Offset = "0x48")]
		private RoguelikeSelectCharTalentView.Adapter m_adapter;

		// Token: 0x0402B015 RID: 176149
		[Token(Token = "0x402B015")]
		[FieldOffset(Offset = "0x50")]
		private bool isHide;

		// Token: 0x0402B016 RID: 176150
		[Token(Token = "0x402B016")]
		[FieldOffset(Offset = "0x58")]
		private Tween m_cacheTween;

		// Token: 0x0402B017 RID: 176151
		[Token(Token = "0x402B017")]
		[FieldOffset(Offset = "0x60")]
		private bool m_isInited;

		// Token: 0x0402B018 RID: 176152
		[Token(Token = "0x402B018")]
		private const float MIN_HEIGHT = 0f;

		// Token: 0x0402B019 RID: 176153
		[Token(Token = "0x402B019")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderOnFirstTime;

		// Token: 0x0402B01A RID: 176154
		[Token(Token = "0x402B01A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402B01B RID: 176155
		[Token(Token = "0x402B01B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402B01C RID: 176156
		[Token(Token = "0x402B01C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnHide;

		// Token: 0x0402B01D RID: 176157
		[Token(Token = "0x402B01D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnShow;

		// Token: 0x0402B01E RID: 176158
		[Token(Token = "0x402B01E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020054AB RID: 21675
		[Token(Token = "0x20054AB")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x17004ABD RID: 19133
			// (get) Token: 0x0601FE3A RID: 130618 RVA: 0x000B3AD8 File Offset: 0x000B1CD8
			[Token(Token = "0x17004ABD")]
			public override int count
			{
				[Token(Token = "0x601FE3A")]
				[Address(RVA = "0x19FE520", Offset = "0x19FD120", VA = "0x1819FE520", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601FE3B RID: 130619 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601FE3B")]
			[Address(RVA = "0x19FE370", Offset = "0x19FCF70", VA = "0x1819FE370", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601FE3C RID: 130620 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601FE3C")]
			[Address(RVA = "0x19FE4C0", Offset = "0x19FD0C0", VA = "0x1819FE4C0")]
			public Adapter()
			{
			}

			// Token: 0x0402B01F RID: 176159
			[Token(Token = "0x402B01F")]
			[FieldOffset(Offset = "0x20")]
			public List<TalentData> talentList;

			// Token: 0x0402B020 RID: 176160
			[Token(Token = "0x402B020")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402B021 RID: 176161
			[Token(Token = "0x402B021")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0402B022 RID: 176162
			[Token(Token = "0x402B022")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
