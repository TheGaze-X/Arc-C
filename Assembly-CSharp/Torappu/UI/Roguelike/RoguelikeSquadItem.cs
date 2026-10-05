using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005535 RID: 21813
	[Token(Token = "0x2005535")]
	public class RoguelikeSquadItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x06020149 RID: 131401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020149")]
		[Address(RVA = "0x1A3AAA0", Offset = "0x1A396A0", VA = "0x181A3AAA0")]
		public void OnClickPos()
		{
		}

		// Token: 0x0602014A RID: 131402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602014A")]
		[Address(RVA = "0x1A3AEE0", Offset = "0x1A39AE0", VA = "0x181A3AEE0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602014B RID: 131403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602014B")]
		[Address(RVA = "0x1A3AC60", Offset = "0x1A39860", VA = "0x181A3AC60")]
		public void RenderNoChar(bool hasAvailChar)
		{
		}

		// Token: 0x0602014C RID: 131404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602014C")]
		[Address(RVA = "0x1A3ADA0", Offset = "0x1A399A0", VA = "0x181A3ADA0")]
		public void RenderNoPos()
		{
		}

		// Token: 0x0602014D RID: 131405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602014D")]
		[Address(RVA = "0x1A3AB20", Offset = "0x1A39720", VA = "0x181A3AB20")]
		public void RenderChar(RoguelikeCharCardViewModel viewModel)
		{
		}

		// Token: 0x0602014E RID: 131406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602014E")]
		[Address(RVA = "0x1A3AE40", Offset = "0x1A39A40", VA = "0x181A3AE40")]
		public void SetPlugins(List<IRoguelikeCharCardPlugin> plugins, RoguelikeSquadItem.SquadPluginInputs inputs)
		{
		}

		// Token: 0x0602014F RID: 131407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602014F")]
		[Address(RVA = "0x1A3B040", Offset = "0x1A39C40", VA = "0x181A3B040")]
		public RoguelikeSquadItem()
		{
		}

		// Token: 0x0402B529 RID: 177449
		[Token(Token = "0x402B529")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _cardContainer;

		// Token: 0x0402B52A RID: 177450
		[Token(Token = "0x402B52A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RoguelikeCharCommonCharView _charView;

		// Token: 0x0402B52B RID: 177451
		[Token(Token = "0x402B52B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _noCharPart;

		// Token: 0x0402B52C RID: 177452
		[Token(Token = "0x402B52C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _noPosPart;

		// Token: 0x0402B52D RID: 177453
		[Token(Token = "0x402B52D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AnimationWrapper _animationWrapper;

		// Token: 0x0402B52E RID: 177454
		[Token(Token = "0x402B52E")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public int index;

		// Token: 0x0402B52F RID: 177455
		[Token(Token = "0x402B52F")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public UIIntEvent clickChar;

		// Token: 0x0402B530 RID: 177456
		[Token(Token = "0x402B530")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		public UIIntStringEvent clickCharSkill;

		// Token: 0x0402B531 RID: 177457
		[Token(Token = "0x402B531")]
		[FieldOffset(Offset = "0x58")]
		[NonSerialized]
		public UIIntEvent clickPos;

		// Token: 0x0402B532 RID: 177458
		[Token(Token = "0x402B532")]
		[FieldOffset(Offset = "0x60")]
		private RoguelikeCharCommonCharView m_charView;

		// Token: 0x0402B533 RID: 177459
		[Token(Token = "0x402B533")]
		[FieldOffset(Offset = "0x68")]
		private bool m_isInited;

		// Token: 0x0402B534 RID: 177460
		[Token(Token = "0x402B534")]
		[FieldOffset(Offset = "0x70")]
		private List<IRoguelikeCharCardPlugin> m_plugins;

		// Token: 0x0402B535 RID: 177461
		[Token(Token = "0x402B535")]
		[FieldOffset(Offset = "0x78")]
		private string m_topicId;

		// Token: 0x0402B536 RID: 177462
		[Token(Token = "0x402B536")]
		private const string SHINING_ANIM_NAME = "shining_show";

		// Token: 0x0402B537 RID: 177463
		[Token(Token = "0x402B537")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnClickPos;

		// Token: 0x0402B538 RID: 177464
		[Token(Token = "0x402B538")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402B539 RID: 177465
		[Token(Token = "0x402B539")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RenderNoChar;

		// Token: 0x0402B53A RID: 177466
		[Token(Token = "0x402B53A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RenderNoPos;

		// Token: 0x0402B53B RID: 177467
		[Token(Token = "0x402B53B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RenderChar;

		// Token: 0x0402B53C RID: 177468
		[Token(Token = "0x402B53C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SetPlugins;

		// Token: 0x0402B53D RID: 177469
		[Token(Token = "0x402B53D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005536 RID: 21814
		[Token(Token = "0x2005536")]
		public struct SquadPluginInputs
		{
			// Token: 0x0402B53E RID: 177470
			[Token(Token = "0x402B53E")]
			[FieldOffset(Offset = "0x0")]
			public string topicId;
		}
	}
}
