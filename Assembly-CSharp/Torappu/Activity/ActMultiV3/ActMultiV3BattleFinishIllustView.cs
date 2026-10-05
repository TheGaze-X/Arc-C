using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006EF0 RID: 28400
	[Token(Token = "0x2006EF0")]
	public class ActMultiV3BattleFinishIllustView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060285B3 RID: 165299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60285B3")]
		[Address(RVA = "0x23A8210", Offset = "0x23A6E10", VA = "0x1823A8210")]
		public void Render(CharUISkinStruct secretaryCharSkin)
		{
		}

		// Token: 0x060285B4 RID: 165300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60285B4")]
		[Address(RVA = "0x23A8060", Offset = "0x23A6C60", VA = "0x1823A8060")]
		public void PlayVoice(CharWordShowType charWordShowType)
		{
		}

		// Token: 0x060285B5 RID: 165301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60285B5")]
		[Address(RVA = "0x23A8370", Offset = "0x23A6F70", VA = "0x1823A8370")]
		public ActMultiV3BattleFinishIllustView()
		{
		}

		// Token: 0x040395D3 RID: 234963
		[Token(Token = "0x40395D3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _illustContainer;

		// Token: 0x040395D4 RID: 234964
		[Token(Token = "0x40395D4")]
		[FieldOffset(Offset = "0x20")]
		private CharUISkinStruct m_charSkin;

		// Token: 0x040395D5 RID: 234965
		[Token(Token = "0x40395D5")]
		[FieldOffset(Offset = "0x38")]
		private UICharacterIllust m_illust;

		// Token: 0x040395D6 RID: 234966
		[Token(Token = "0x40395D6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040395D7 RID: 234967
		[Token(Token = "0x40395D7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_PlayVoice;

		// Token: 0x040395D8 RID: 234968
		[Token(Token = "0x40395D8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
