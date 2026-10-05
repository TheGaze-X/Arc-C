using System;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x0200329A RID: 12954
	[Token(Token = "0x200329A")]
	public class UICardIconWithNumHintPlugin : UIPluginTalent.UnitTalentUIPlugin, UICard.IUICardPlugin, IReusableObject, IReusable, IPtrObject
	{
		// Token: 0x170030AA RID: 12458
		// (get) Token: 0x0601490E RID: 84238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170030AA")]
		public string pluginId
		{
			[Token(Token = "0x601490E")]
			[Address(RVA = "0xCDA050", Offset = "0xCD8C50", VA = "0x180CDA050", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x170030AB RID: 12459
		// (get) Token: 0x0601490F RID: 84239 RVA: 0x00087768 File Offset: 0x00085968
		[Token(Token = "0x170030AB")]
		public uint sourcInstId
		{
			[Token(Token = "0x601490F")]
			[Address(RVA = "0xCDA0B0", Offset = "0xCD8CB0", VA = "0x180CDA0B0", Slot = "12")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06014910 RID: 84240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014910")]
		[Address(RVA = "0xCD92A0", Offset = "0xCD7EA0", VA = "0x180CD92A0", Slot = "16")]
		public void OnInit(UICard uiCard)
		{
		}

		// Token: 0x06014911 RID: 84241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014911")]
		[Address(RVA = "0xCD9BC0", Offset = "0xCD87C0", VA = "0x180CD9BC0")]
		private void _Init(Func<Deck.Card, int> numGetter, Func<Deck.Card, bool> needShow, string iconId, uint sourceInstanceId)
		{
		}

		// Token: 0x06014912 RID: 84242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014912")]
		[Address(RVA = "0xCD9410", Offset = "0xCD8010", VA = "0x180CD9410", Slot = "15")]
		public void OnRender(UICard card)
		{
		}

		// Token: 0x06014913 RID: 84243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6014913")]
		[Address(RVA = "0xCD9240", Offset = "0xCD7E40", VA = "0x180CD9240", Slot = "18")]
		public MonoBehaviour GetRootMono()
		{
			return null;
		}

		// Token: 0x06014914 RID: 84244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014914")]
		[Address(RVA = "0xCD8B40", Offset = "0xCD7740", VA = "0x180CD8B40", Slot = "9")]
		protected override void DoAttach(Unit owner, UIPluginTalent talent)
		{
		}

		// Token: 0x06014915 RID: 84245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014915")]
		[Address(RVA = "0xCD90A0", Offset = "0xCD7CA0", VA = "0x180CD90A0", Slot = "10")]
		protected override void DoDetach()
		{
		}

		// Token: 0x06014916 RID: 84246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014916")]
		[Address(RVA = "0xCD93A0", Offset = "0xCD7FA0", VA = "0x180CD93A0", Slot = "8")]
		public override void OnRecycle()
		{
		}

		// Token: 0x06014917 RID: 84247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014917")]
		[Address(RVA = "0xCD9D30", Offset = "0xCD8930", VA = "0x180CD9D30")]
		private void _OnCharacterMenuEnter(object character)
		{
		}

		// Token: 0x06014918 RID: 84248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014918")]
		[Address(RVA = "0xCD9E70", Offset = "0xCD8A70", VA = "0x180CD9E70")]
		private void _OnCharacterMenuExit(object character)
		{
		}

		// Token: 0x06014919 RID: 84249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014919")]
		[Address(RVA = "0xCD9770", Offset = "0xCD8370", VA = "0x180CD9770")]
		private void _DoRender(bool isShow)
		{
		}

		// Token: 0x0601491A RID: 84250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601491A")]
		[Address(RVA = "0xCD9EF0", Offset = "0xCD8AF0", VA = "0x180CD9EF0")]
		private void _Reset()
		{
		}

		// Token: 0x0601491B RID: 84251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601491B")]
		[Address(RVA = "0xCD9610", Offset = "0xCD8210", VA = "0x180CD9610")]
		private void _DoPlayAnimation()
		{
		}

		// Token: 0x0601491C RID: 84252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601491C")]
		[Address(RVA = "0xCD9AF0", Offset = "0xCD86F0", VA = "0x180CD9AF0")]
		private void _DoStopAnimation()
		{
		}

		// Token: 0x0601491D RID: 84253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601491D")]
		[Address(RVA = "0xCD9FE0", Offset = "0xCD8BE0", VA = "0x180CD9FE0")]
		public UICardIconWithNumHintPlugin()
		{
		}

		// Token: 0x0601491E RID: 84254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601491E")]
		[Address(RVA = "0xCC3AD0", Offset = "0xCC26D0", VA = "0x180CC3AD0")]
		private void <>xLuaBaseProxy_DoAttach(Unit P0, UIPluginTalent P1)
		{
		}

		// Token: 0x0601491F RID: 84255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601491F")]
		[Address(RVA = "0xCCC680", Offset = "0xCCB280", VA = "0x180CCC680")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x06014920 RID: 84256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014920")]
		[Address(RVA = "0xCCC690", Offset = "0xCCB290", VA = "0x180CCC690")]
		private void <>xLuaBaseProxy_OnRecycle()
		{
		}

		// Token: 0x0401854E RID: 99662
		[Token(Token = "0x401854E")]
		private const string PLUGIN_FORMAT_PARTTERN = "UICardIconWithNumHintPlugin_{0}";

		// Token: 0x0401854F RID: 99663
		[Token(Token = "0x401854F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _root;

		// Token: 0x04018550 RID: 99664
		[Token(Token = "0x4018550")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _icon;

		// Token: 0x04018551 RID: 99665
		[Token(Token = "0x4018551")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _numRoot;

		// Token: 0x04018552 RID: 99666
		[Token(Token = "0x4018552")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _numText;

		// Token: 0x04018553 RID: 99667
		[Token(Token = "0x4018553")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _bgEffectTransform;

		// Token: 0x04018554 RID: 99668
		[Token(Token = "0x4018554")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private AnimationWrapper _addAnimationWrapper;

		// Token: 0x04018555 RID: 99669
		[Token(Token = "0x4018555")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private string _animName;

		// Token: 0x04018556 RID: 99670
		[Token(Token = "0x4018556")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RectTransform _defaultTransData;

		// Token: 0x04018557 RID: 99671
		[Token(Token = "0x4018557")]
		[FieldOffset(Offset = "0x70")]
		private bool m_isInMenuState;

		// Token: 0x04018558 RID: 99672
		[Token(Token = "0x4018558")]
		[FieldOffset(Offset = "0x71")]
		private bool m_isDisplayed;

		// Token: 0x04018559 RID: 99673
		[Token(Token = "0x4018559")]
		[FieldOffset(Offset = "0x78")]
		private string m_pluginId;

		// Token: 0x0401855A RID: 99674
		[Token(Token = "0x401855A")]
		[FieldOffset(Offset = "0x80")]
		private int m_lastNum;

		// Token: 0x0401855B RID: 99675
		[Token(Token = "0x401855B")]
		[FieldOffset(Offset = "0x88")]
		private Func<Deck.Card, int> m_numGetter;

		// Token: 0x0401855C RID: 99676
		[Token(Token = "0x401855C")]
		[FieldOffset(Offset = "0x90")]
		private Func<Deck.Card, bool> m_needShow;

		// Token: 0x0401855D RID: 99677
		[Token(Token = "0x401855D")]
		[FieldOffset(Offset = "0x98")]
		private UICard m_cardAttached;

		// Token: 0x0401855E RID: 99678
		[Token(Token = "0x401855E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_pluginId;

		// Token: 0x0401855F RID: 99679
		[Token(Token = "0x401855F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_sourcInstId;

		// Token: 0x04018560 RID: 99680
		[Token(Token = "0x4018560")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04018561 RID: 99681
		[Token(Token = "0x4018561")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__Init;

		// Token: 0x04018562 RID: 99682
		[Token(Token = "0x4018562")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04018563 RID: 99683
		[Token(Token = "0x4018563")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetRootMono;

		// Token: 0x04018564 RID: 99684
		[Token(Token = "0x4018564")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04018565 RID: 99685
		[Token(Token = "0x4018565")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x04018566 RID: 99686
		[Token(Token = "0x4018566")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnRecycle;

		// Token: 0x04018567 RID: 99687
		[Token(Token = "0x4018567")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnCharacterMenuEnter;

		// Token: 0x04018568 RID: 99688
		[Token(Token = "0x4018568")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnCharacterMenuExit;

		// Token: 0x04018569 RID: 99689
		[Token(Token = "0x4018569")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__DoRender;

		// Token: 0x0401856A RID: 99690
		[Token(Token = "0x401856A")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__Reset;

		// Token: 0x0401856B RID: 99691
		[Token(Token = "0x401856B")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__DoPlayAnimation;

		// Token: 0x0401856C RID: 99692
		[Token(Token = "0x401856C")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__DoStopAnimation;

		// Token: 0x0401856D RID: 99693
		[Token(Token = "0x401856D")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
