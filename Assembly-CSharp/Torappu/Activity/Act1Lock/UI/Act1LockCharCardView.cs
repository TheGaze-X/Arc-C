using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1Lock.UI
{
	// Token: 0x0200789F RID: 30879
	[Token(Token = "0x200789F")]
	public class Act1LockCharCardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602B4A2 RID: 177314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B4A2")]
		[Address(RVA = "0x2708170", Offset = "0x2706D70", VA = "0x182708170")]
		public void Clear()
		{
		}

		// Token: 0x0602B4A3 RID: 177315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B4A3")]
		[Address(RVA = "0x27081F0", Offset = "0x2706DF0", VA = "0x1827081F0")]
		public void FillNo()
		{
		}

		// Token: 0x0602B4A4 RID: 177316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B4A4")]
		[Address(RVA = "0x27082D0", Offset = "0x2706ED0", VA = "0x1827082D0")]
		public void Fill(CharacterCardViewModel cardViewModel)
		{
		}

		// Token: 0x0602B4A5 RID: 177317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B4A5")]
		[Address(RVA = "0x27086B0", Offset = "0x27072B0", VA = "0x1827086B0")]
		public Act1LockCharCardView()
		{
		}

		// Token: 0x0403E912 RID: 256274
		[Token(Token = "0x403E912")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _portrait;

		// Token: 0x0403E913 RID: 256275
		[Token(Token = "0x403E913")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _levelTxt;

		// Token: 0x0403E914 RID: 256276
		[Token(Token = "0x403E914")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _evolveImg;

		// Token: 0x0403E915 RID: 256277
		[Token(Token = "0x403E915")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _potentialImg;

		// Token: 0x0403E916 RID: 256278
		[Token(Token = "0x403E916")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Sprite[] _rarityBackSprite;

		// Token: 0x0403E917 RID: 256279
		[Token(Token = "0x403E917")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _rarityBackImg;

		// Token: 0x0403E918 RID: 256280
		[Token(Token = "0x403E918")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _professionImg;

		// Token: 0x0403E919 RID: 256281
		[Token(Token = "0x403E919")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _noPart;

		// Token: 0x0403E91A RID: 256282
		[Token(Token = "0x403E91A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _availPart;

		// Token: 0x0403E91B RID: 256283
		[Token(Token = "0x403E91B")]
		[FieldOffset(Offset = "0x60")]
		private string m_portrait;

		// Token: 0x0403E91C RID: 256284
		[Token(Token = "0x403E91C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Clear;

		// Token: 0x0403E91D RID: 256285
		[Token(Token = "0x403E91D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_FillNo;

		// Token: 0x0403E91E RID: 256286
		[Token(Token = "0x403E91E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Fill;

		// Token: 0x0403E91F RID: 256287
		[Token(Token = "0x403E91F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
