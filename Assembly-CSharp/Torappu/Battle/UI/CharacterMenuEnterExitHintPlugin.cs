using System;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x0200328D RID: 12941
	[Token(Token = "0x200328D")]
	public abstract class CharacterMenuEnterExitHintPlugin : UIPluginTalent.UnitTalentUIPlugin, UICard.IUICardPlugin, IReusableObject, IReusable, IPtrObject
	{
		// Token: 0x1700309D RID: 12445
		// (get) Token: 0x0601489E RID: 84126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700309D")]
		public string pluginId
		{
			[Token(Token = "0x601489E")]
			[Address(RVA = "0xCCCC80", Offset = "0xCCB880", VA = "0x180CCCC80", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700309E RID: 12446
		// (get) Token: 0x0601489F RID: 84127 RVA: 0x00087648 File Offset: 0x00085848
		[Token(Token = "0x1700309E")]
		public virtual UICard.UICardMountPoint mountPoint
		{
			[Token(Token = "0x601489F")]
			[Address(RVA = "0xCCCBC0", Offset = "0xCCB7C0", VA = "0x180CCCBC0", Slot = "20")]
			get
			{
				return UICard.UICardMountPoint.DEFAULT_PLUGIN_ROOT;
			}
		}

		// Token: 0x1700309F RID: 12447
		// (get) Token: 0x060148A0 RID: 84128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700309F")]
		protected new Character owner
		{
			[Token(Token = "0x60148A0")]
			[Address(RVA = "0xCCCC20", Offset = "0xCCB820", VA = "0x180CCCC20")]
			get
			{
				return null;
			}
		}

		// Token: 0x060148A1 RID: 84129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60148A1")]
		[Address(RVA = "0xCCC010", Offset = "0xCCAC10", VA = "0x180CCC010", Slot = "18")]
		public MonoBehaviour GetRootMono()
		{
			return null;
		}

		// Token: 0x060148A2 RID: 84130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148A2")]
		[Address(RVA = "0xCCC420", Offset = "0xCCB020", VA = "0x180CCC420", Slot = "15")]
		public void OnRender(UICard card)
		{
		}

		// Token: 0x060148A3 RID: 84131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148A3")]
		[Address(RVA = "0xCCB720", Offset = "0xCCA320", VA = "0x180CCB720", Slot = "9")]
		protected override void DoAttach(Unit owner, UIPluginTalent talent)
		{
		}

		// Token: 0x060148A4 RID: 84132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148A4")]
		[Address(RVA = "0xCCBCE0", Offset = "0xCCA8E0", VA = "0x180CCBCE0", Slot = "10")]
		protected override void DoDetach()
		{
		}

		// Token: 0x060148A5 RID: 84133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148A5")]
		[Address(RVA = "0xCCC8E0", Offset = "0xCCB4E0", VA = "0x180CCC8E0")]
		private void _OnCharacterMenuEnter(object character)
		{
		}

		// Token: 0x060148A6 RID: 84134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148A6")]
		[Address(RVA = "0xCCC6A0", Offset = "0xCCB2A0", VA = "0x180CCC6A0")]
		private void _OnCardMenuEnter(object cardObj)
		{
		}

		// Token: 0x060148A7 RID: 84135
		[Token(Token = "0x60148A7")]
		protected abstract bool NeedShow(Deck.Card card);

		// Token: 0x060148A8 RID: 84136
		[Token(Token = "0x60148A8")]
		protected abstract void DoReset();

		// Token: 0x060148A9 RID: 84137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148A9")]
		[Address(RVA = "0xCCCA60", Offset = "0xCCB660", VA = "0x180CCCA60")]
		private void _OnCharacterMenuExit(object character)
		{
		}

		// Token: 0x060148AA RID: 84138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148AA")]
		[Address(RVA = "0xCCC860", Offset = "0xCCB460", VA = "0x180CCC860")]
		private void _OnCardMenuExit(object cardObj)
		{
		}

		// Token: 0x060148AB RID: 84139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148AB")]
		[Address(RVA = "0xCCCAE0", Offset = "0xCCB6E0", VA = "0x180CCCAE0")]
		private void _Reset()
		{
		}

		// Token: 0x060148AC RID: 84140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148AC")]
		[Address(RVA = "0xCCC3B0", Offset = "0xCCAFB0", VA = "0x180CCC3B0", Slot = "8")]
		public override void OnRecycle()
		{
		}

		// Token: 0x060148AD RID: 84141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148AD")]
		[Address(RVA = "0xCCC320", Offset = "0xCCAF20", VA = "0x180CCC320", Slot = "23")]
		public virtual void OnInit(UICard uiCard, Unit owner, UIPluginTalent talent)
		{
		}

		// Token: 0x060148AE RID: 84142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148AE")]
		[Address(RVA = "0xCCBF80", Offset = "0xCCAB80", VA = "0x180CCBF80", Slot = "24")]
		protected virtual void DoRender(bool isShow)
		{
		}

		// Token: 0x060148AF RID: 84143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148AF")]
		[Address(RVA = "0xCCC070", Offset = "0xCCAC70", VA = "0x180CCC070", Slot = "25")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x060148B0 RID: 84144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148B0")]
		[Address(RVA = "0xCCCB60", Offset = "0xCCB760", VA = "0x180CCCB60")]
		protected CharacterMenuEnterExitHintPlugin()
		{
		}

		// Token: 0x060148B1 RID: 84145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148B1")]
		[Address(RVA = "0xCC3AD0", Offset = "0xCC26D0", VA = "0x180CC3AD0")]
		private void <>xLuaBaseProxy_DoAttach(Unit P0, UIPluginTalent P1)
		{
		}

		// Token: 0x060148B2 RID: 84146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148B2")]
		[Address(RVA = "0xCCC680", Offset = "0xCCB280", VA = "0x180CCC680")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x060148B3 RID: 84147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148B3")]
		[Address(RVA = "0xCCC690", Offset = "0xCCB290", VA = "0x180CCC690")]
		private void <>xLuaBaseProxy_OnRecycle()
		{
		}

		// Token: 0x04018492 RID: 99474
		[Token(Token = "0x4018492")]
		private const string PLUGIN_FORMAT_PARTTERN = "CharacterMenuEnterExitHintPlugin_{0}_{1}";

		// Token: 0x04018493 RID: 99475
		[Token(Token = "0x4018493")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _root;

		// Token: 0x04018494 RID: 99476
		[Token(Token = "0x4018494")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string _pluginIdSuffix;

		// Token: 0x04018495 RID: 99477
		[Token(Token = "0x4018495")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UICard.UICardMountPoint _mountPoint;

		// Token: 0x04018496 RID: 99478
		[Token(Token = "0x4018496")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _defaultTransData;

		// Token: 0x04018497 RID: 99479
		[Token(Token = "0x4018497")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool _enableCardShow;

		// Token: 0x04018498 RID: 99480
		[Token(Token = "0x4018498")]
		[FieldOffset(Offset = "0x51")]
		private bool m_isInMenuState;

		// Token: 0x04018499 RID: 99481
		[Token(Token = "0x4018499")]
		[FieldOffset(Offset = "0x52")]
		private bool m_isDisplayed;

		// Token: 0x0401849A RID: 99482
		[Token(Token = "0x401849A")]
		[FieldOffset(Offset = "0x54")]
		private uint m_hostCardUid;

		// Token: 0x0401849B RID: 99483
		[Token(Token = "0x401849B")]
		[FieldOffset(Offset = "0x58")]
		private uint m_tokenCardUid;

		// Token: 0x0401849C RID: 99484
		[Token(Token = "0x401849C")]
		[FieldOffset(Offset = "0x60")]
		private string m_pluginId;

		// Token: 0x0401849D RID: 99485
		[Token(Token = "0x401849D")]
		[FieldOffset(Offset = "0x68")]
		private bool m_inited;

		// Token: 0x0401849E RID: 99486
		[Token(Token = "0x401849E")]
		[FieldOffset(Offset = "0x70")]
		private UICard m_cardAttached;

		// Token: 0x0401849F RID: 99487
		[Token(Token = "0x401849F")]
		[FieldOffset(Offset = "0x78")]
		private Character m_character;

		// Token: 0x040184A0 RID: 99488
		[Token(Token = "0x40184A0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_pluginId;

		// Token: 0x040184A1 RID: 99489
		[Token(Token = "0x40184A1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_mountPoint;

		// Token: 0x040184A2 RID: 99490
		[Token(Token = "0x40184A2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_owner;

		// Token: 0x040184A3 RID: 99491
		[Token(Token = "0x40184A3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetRootMono;

		// Token: 0x040184A4 RID: 99492
		[Token(Token = "0x40184A4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x040184A5 RID: 99493
		[Token(Token = "0x40184A5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x040184A6 RID: 99494
		[Token(Token = "0x40184A6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x040184A7 RID: 99495
		[Token(Token = "0x40184A7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnCharacterMenuEnter;

		// Token: 0x040184A8 RID: 99496
		[Token(Token = "0x40184A8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnCardMenuEnter;

		// Token: 0x040184A9 RID: 99497
		[Token(Token = "0x40184A9")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnCharacterMenuExit;

		// Token: 0x040184AA RID: 99498
		[Token(Token = "0x40184AA")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnCardMenuExit;

		// Token: 0x040184AB RID: 99499
		[Token(Token = "0x40184AB")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__Reset;

		// Token: 0x040184AC RID: 99500
		[Token(Token = "0x40184AC")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnRecycle;

		// Token: 0x040184AD RID: 99501
		[Token(Token = "0x40184AD")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040184AE RID: 99502
		[Token(Token = "0x40184AE")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_DoRender;

		// Token: 0x040184AF RID: 99503
		[Token(Token = "0x40184AF")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x040184B0 RID: 99504
		[Token(Token = "0x40184B0")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
