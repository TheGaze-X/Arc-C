using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D13 RID: 23827
	[Token(Token = "0x2005D13")]
	public class ClimbTowerEndingCharacterCardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06022817 RID: 141335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022817")]
		[Address(RVA = "0x1CFE300", Offset = "0x1CFCF00", VA = "0x181CFE300")]
		public void Render(ClimbTowerEndCharacterViewModel viewModel)
		{
		}

		// Token: 0x06022818 RID: 141336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022818")]
		[Address(RVA = "0x1CFE4C0", Offset = "0x1CFD0C0", VA = "0x181CFE4C0")]
		public ClimbTowerEndingCharacterCardView()
		{
		}

		// Token: 0x0402F6C2 RID: 194242
		[Token(Token = "0x402F6C2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TwoStateToggle _toggleCardItem;

		// Token: 0x0402F6C3 RID: 194243
		[Token(Token = "0x402F6C3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasImage _imagePortrait;

		// Token: 0x0402F6C4 RID: 194244
		[Token(Token = "0x402F6C4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgEvolvePhase;

		// Token: 0x0402F6C5 RID: 194245
		[Token(Token = "0x402F6C5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _imgNpc;

		// Token: 0x0402F6C6 RID: 194246
		[Token(Token = "0x402F6C6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _imgFriend;

		// Token: 0x0402F6C7 RID: 194247
		[Token(Token = "0x402F6C7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402F6C8 RID: 194248
		[Token(Token = "0x402F6C8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
