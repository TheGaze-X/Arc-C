using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004FB3 RID: 20403
	[Token(Token = "0x2004FB3")]
	public class EnemyDuelMileStoneItemView : TemplateActivityCommonMileStoneItemView
	{
		// Token: 0x0601E505 RID: 124165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E505")]
		[Address(RVA = "0x1806680", Offset = "0x1805280", VA = "0x181806680", Slot = "4")]
		protected override void OnRender()
		{
		}

		// Token: 0x0601E506 RID: 124166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E506")]
		[Address(RVA = "0x18069F0", Offset = "0x18055F0", VA = "0x1818069F0")]
		public EnemyDuelMileStoneItemView()
		{
		}

		// Token: 0x0601E507 RID: 124167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E507")]
		[Address(RVA = "0x15FF010", Offset = "0x15FDC10", VA = "0x1815FF010")]
		private void <>xLuaBaseProxy_OnRender()
		{
		}

		// Token: 0x0402879C RID: 165788
		[Token(Token = "0x402879C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _availStatusGO;

		// Token: 0x0402879D RID: 165789
		[Token(Token = "0x402879D")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _notAvailStatusGO;

		// Token: 0x0402879E RID: 165790
		[Token(Token = "0x402879E")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _lockedStatusGO;

		// Token: 0x0402879F RID: 165791
		[Token(Token = "0x402879F")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text[] _textLevelNumList;

		// Token: 0x040287A0 RID: 165792
		[Token(Token = "0x40287A0")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _objMaskFinished;

		// Token: 0x040287A1 RID: 165793
		[Token(Token = "0x40287A1")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Text _lockedTimeRemainText;

		// Token: 0x040287A2 RID: 165794
		[Token(Token = "0x40287A2")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject _rewardContainer;

		// Token: 0x040287A3 RID: 165795
		[Token(Token = "0x40287A3")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Text[] _rewardTexts;

		// Token: 0x040287A4 RID: 165796
		[Token(Token = "0x40287A4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x040287A5 RID: 165797
		[Token(Token = "0x40287A5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
