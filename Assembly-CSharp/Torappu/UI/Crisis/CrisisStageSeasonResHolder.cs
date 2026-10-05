using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Crisis
{
	// Token: 0x02005A08 RID: 23048
	[Token(Token = "0x2005A08")]
	public class CrisisStageSeasonResHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602194C RID: 137548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602194C")]
		[Address(RVA = "0x1C0C420", Offset = "0x1C0B020", VA = "0x181C0C420")]
		public CrisisStageSeasonWidget GetEntryWidget()
		{
			return null;
		}

		// Token: 0x0602194D RID: 137549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602194D")]
		[Address(RVA = "0x1C0C600", Offset = "0x1C0B200", VA = "0x181C0C600")]
		public CrisisStageSeasonWidget GetTrainingWidget()
		{
			return null;
		}

		// Token: 0x0602194E RID: 137550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602194E")]
		[Address(RVA = "0x1C0C5A0", Offset = "0x1C0B1A0", VA = "0x181C0C5A0")]
		public Sprite GetShopTitle()
		{
			return null;
		}

		// Token: 0x0602194F RID: 137551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602194F")]
		[Address(RVA = "0x1C0C540", Offset = "0x1C0B140", VA = "0x181C0C540")]
		public Sprite GetShopEntry()
		{
			return null;
		}

		// Token: 0x06021950 RID: 137552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021950")]
		[Address(RVA = "0x1C0C4E0", Offset = "0x1C0B0E0", VA = "0x181C0C4E0")]
		public Sprite GetSeasonIcon()
		{
			return null;
		}

		// Token: 0x06021951 RID: 137553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021951")]
		[Address(RVA = "0x1C0C480", Offset = "0x1C0B080", VA = "0x181C0C480")]
		public Sprite GetMedalIcon()
		{
			return null;
		}

		// Token: 0x06021952 RID: 137554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021952")]
		[Address(RVA = "0x1C0C660", Offset = "0x1C0B260", VA = "0x181C0C660")]
		public CrisisStageSeasonResHolder()
		{
		}

		// Token: 0x0402DE3C RID: 187964
		[Token(Token = "0x402DE3C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CrisisStageSeasonWidget _entryWidget;

		// Token: 0x0402DE3D RID: 187965
		[Token(Token = "0x402DE3D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CrisisStageSeasonWidget _trainingWidget;

		// Token: 0x0402DE3E RID: 187966
		[Token(Token = "0x402DE3E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Sprite _shopTitle;

		// Token: 0x0402DE3F RID: 187967
		[Token(Token = "0x402DE3F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Sprite _shopEntry;

		// Token: 0x0402DE40 RID: 187968
		[Token(Token = "0x402DE40")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Sprite _seasonIcon;

		// Token: 0x0402DE41 RID: 187969
		[Token(Token = "0x402DE41")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Sprite _medalBtn;

		// Token: 0x0402DE42 RID: 187970
		[Token(Token = "0x402DE42")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetEntryWidget;

		// Token: 0x0402DE43 RID: 187971
		[Token(Token = "0x402DE43")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetTrainingWidget;

		// Token: 0x0402DE44 RID: 187972
		[Token(Token = "0x402DE44")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetShopTitle;

		// Token: 0x0402DE45 RID: 187973
		[Token(Token = "0x402DE45")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetShopEntry;

		// Token: 0x0402DE46 RID: 187974
		[Token(Token = "0x402DE46")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetSeasonIcon;

		// Token: 0x0402DE47 RID: 187975
		[Token(Token = "0x402DE47")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetMedalIcon;

		// Token: 0x0402DE48 RID: 187976
		[Token(Token = "0x402DE48")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
