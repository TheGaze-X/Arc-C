using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B76 RID: 23414
	[Token(Token = "0x2005B76")]
	public class SocialGetState : PopupFloatState
	{
		// Token: 0x06021FD6 RID: 139222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021FD6")]
		[Address(RVA = "0x1C823A0", Offset = "0x1C80FA0", VA = "0x181C823A0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06021FD7 RID: 139223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021FD7")]
		[Address(RVA = "0x1C82400", Offset = "0x1C81000", VA = "0x181C82400", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06021FD8 RID: 139224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021FD8")]
		[Address(RVA = "0x1C82720", Offset = "0x1C81320", VA = "0x181C82720")]
		public SocialGetState()
		{
		}

		// Token: 0x06021FD9 RID: 139225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021FD9")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0402E96B RID: 190827
		[Token(Token = "0x402E96B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ShopSocialStateBean _stateBean;

		// Token: 0x0402E96C RID: 190828
		[Token(Token = "0x402E96C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _dormText;

		// Token: 0x0402E96D RID: 190829
		[Token(Token = "0x402E96D")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _assistText;

		// Token: 0x0402E96E RID: 190830
		[Token(Token = "0x402E96E")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private SocialGetCrisisV2View _getCrisisV2View;

		// Token: 0x0402E96F RID: 190831
		[Token(Token = "0x402E96F")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Image[] _imgSocialPtList;

		// Token: 0x0402E970 RID: 190832
		[Token(Token = "0x402E970")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402E971 RID: 190833
		[Token(Token = "0x402E971")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402E972 RID: 190834
		[Token(Token = "0x402E972")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
