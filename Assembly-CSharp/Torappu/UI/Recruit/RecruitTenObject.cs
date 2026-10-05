using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x0200476F RID: 18287
	[Token(Token = "0x200476F")]
	public class RecruitTenObject : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601BB07 RID: 113415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BB07")]
		[Address(RVA = "0x151EB30", Offset = "0x151D730", VA = "0x18151EB30")]
		public void ApplyData(GachaResult gachaResult, bool isOdd)
		{
		}

		// Token: 0x0601BB08 RID: 113416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BB08")]
		[Address(RVA = "0x151F230", Offset = "0x151DE30", VA = "0x18151F230")]
		public RecruitTenObject()
		{
		}

		// Token: 0x04023FA8 RID: 147368
		[Token(Token = "0x4023FA8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _portrait;

		// Token: 0x04023FA9 RID: 147369
		[Token(Token = "0x4023FA9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _profession;

		// Token: 0x04023FAA RID: 147370
		[Token(Token = "0x4023FAA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _upState;

		// Token: 0x04023FAB RID: 147371
		[Token(Token = "0x4023FAB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _starImage;

		// Token: 0x04023FAC RID: 147372
		[Token(Token = "0x4023FAC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Collection(6)]
		private Sprite[] _starRaritySprites;

		// Token: 0x04023FAD RID: 147373
		[Token(Token = "0x4023FAD")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Collection(6)]
		private RecruitTenRarityAdapter[] _rarityEffects;

		// Token: 0x04023FAE RID: 147374
		[Token(Token = "0x4023FAE")]
		[FieldOffset(Offset = "0x48")]
		private float m_delta;

		// Token: 0x04023FAF RID: 147375
		[Token(Token = "0x4023FAF")]
		private const int TIMES = 40;

		// Token: 0x04023FB0 RID: 147376
		[Token(Token = "0x4023FB0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x04023FB1 RID: 147377
		[Token(Token = "0x4023FB1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
