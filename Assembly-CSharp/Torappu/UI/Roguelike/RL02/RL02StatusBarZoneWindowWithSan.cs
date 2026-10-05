using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x02005798 RID: 22424
	[Token(Token = "0x2005798")]
	public class RL02StatusBarZoneWindowWithSan : RoguelikeMenuWindow<RL02ZoneWithSanViewModel>
	{
		// Token: 0x17004CE6 RID: 19686
		// (get) Token: 0x06020CD6 RID: 134358 RVA: 0x000B75B8 File Offset: 0x000B57B8
		[Token(Token = "0x17004CE6")]
		public override RoguelikeMenuType selectType
		{
			[Token(Token = "0x6020CD6")]
			[Address(RVA = "0x1B2A350", Offset = "0x1B28F50", VA = "0x181B2A350", Slot = "4")]
			get
			{
				return RoguelikeMenuType.INIT_SQUAD;
			}
		}

		// Token: 0x06020CD7 RID: 134359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020CD7")]
		[Address(RVA = "0x1B29C40", Offset = "0x1B28840", VA = "0x181B29C40", Slot = "9")]
		protected override UISwitchTween GetSwitchTween()
		{
			return null;
		}

		// Token: 0x06020CD8 RID: 134360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020CD8")]
		[Address(RVA = "0x1B29DC0", Offset = "0x1B289C0", VA = "0x181B29DC0", Slot = "10")]
		public override void Render(RL02ZoneWithSanViewModel viewModel)
		{
		}

		// Token: 0x06020CD9 RID: 134361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020CD9")]
		[Address(RVA = "0x1B2A2C0", Offset = "0x1B28EC0", VA = "0x181B2A2C0")]
		public RL02StatusBarZoneWindowWithSan()
		{
		}

		// Token: 0x06020CDB RID: 134363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020CDB")]
		[Address(RVA = "0x19153C0", Offset = "0x1913FC0", VA = "0x1819153C0")]
		private UISwitchTween <>xLuaBaseProxy_GetSwitchTween()
		{
			return null;
		}

		// Token: 0x0402C91C RID: 182556
		[Token(Token = "0x402C91C")]
		[FieldOffset(Offset = "0x0")]
		private new static Vector2 WINDOW_HIDE_POS;

		// Token: 0x0402C91D RID: 182557
		[Token(Token = "0x402C91D")]
		[FieldOffset(Offset = "0x8")]
		private new static Vector2 WINDOW_SHOW_POS;

		// Token: 0x0402C91E RID: 182558
		[Token(Token = "0x402C91E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textSan;

		// Token: 0x0402C91F RID: 182559
		[Token(Token = "0x402C91F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textSanDesc;

		// Token: 0x0402C920 RID: 182560
		[Token(Token = "0x402C920")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelSan;

		// Token: 0x0402C921 RID: 182561
		[Token(Token = "0x402C921")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelLine;

		// Token: 0x0402C922 RID: 182562
		[Token(Token = "0x402C922")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelVariationTitle;

		// Token: 0x0402C923 RID: 182563
		[Token(Token = "0x402C923")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RL02StatusBarZoneWindowWithSan.VariationItem[] _variationItems;

		// Token: 0x0402C924 RID: 182564
		[Token(Token = "0x402C924")]
		[FieldOffset(Offset = "0x58")]
		private RL02ZoneWithSanViewModel m_cachedModel;

		// Token: 0x0402C925 RID: 182565
		[Token(Token = "0x402C925")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_selectType;

		// Token: 0x0402C926 RID: 182566
		[Token(Token = "0x402C926")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetSwitchTween;

		// Token: 0x0402C927 RID: 182567
		[Token(Token = "0x402C927")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C928 RID: 182568
		[Token(Token = "0x402C928")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005799 RID: 22425
		[Token(Token = "0x2005799")]
		[Serializable]
		private class VariationItem : IHotfixable
		{
			// Token: 0x06020CDC RID: 134364 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020CDC")]
			[Address(RVA = "0x1B2C590", Offset = "0x1B2B190", VA = "0x181B2C590")]
			public void Render(string topicId, RoguelikeVariationModel model)
			{
			}

			// Token: 0x06020CDD RID: 134365 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020CDD")]
			[Address(RVA = "0x1B2C8B0", Offset = "0x1B2B4B0", VA = "0x181B2C8B0")]
			public VariationItem()
			{
			}

			// Token: 0x0402C929 RID: 182569
			[Token(Token = "0x402C929")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private GameObject _panelVariation;

			// Token: 0x0402C92A RID: 182570
			[Token(Token = "0x402C92A")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Image _imageVariation;

			// Token: 0x0402C92B RID: 182571
			[Token(Token = "0x402C92B")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Text _textName;

			// Token: 0x0402C92C RID: 182572
			[Token(Token = "0x402C92C")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private Text _textEffect;

			// Token: 0x0402C92D RID: 182573
			[Token(Token = "0x402C92D")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private Text _textDesc;

			// Token: 0x0402C92E RID: 182574
			[Token(Token = "0x402C92E")]
			[FieldOffset(Offset = "0x38")]
			private string m_cachedVariationId;

			// Token: 0x0402C92F RID: 182575
			[Token(Token = "0x402C92F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Render;

			// Token: 0x0402C930 RID: 182576
			[Token(Token = "0x402C930")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
