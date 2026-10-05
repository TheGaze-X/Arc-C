using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x020065B1 RID: 26033
	[Token(Token = "0x20065B1")]
	public class ArtMagazineLeafBottomBar : MonoBehaviour, IHotfixable
	{
		// Token: 0x060256A9 RID: 153257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60256A9")]
		[Address(RVA = "0x20655F0", Offset = "0x20641F0", VA = "0x1820655F0")]
		public void Render(ArtMagazineLeafViewModelBase leafViewModel)
		{
		}

		// Token: 0x060256AA RID: 153258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60256AA")]
		[Address(RVA = "0x20656C0", Offset = "0x20642C0", VA = "0x1820656C0")]
		public ArtMagazineLeafBottomBar()
		{
		}

		// Token: 0x0403482C RID: 215084
		[Token(Token = "0x403482C")]
		private const string NICKNAME_FORMAT = "Dr.{0}";

		// Token: 0x0403482D RID: 215085
		[Token(Token = "0x403482D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textNickname;

		// Token: 0x0403482E RID: 215086
		[Token(Token = "0x403482E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403482F RID: 215087
		[Token(Token = "0x403482F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
