using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x02007963 RID: 31075
	[Token(Token = "0x2007963")]
	public class Act1ArcadeSettlementIllustView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602B982 RID: 178562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B982")]
		[Address(RVA = "0x27802C0", Offset = "0x277EEC0", VA = "0x1827802C0")]
		public void OnRender(CharUISkinStruct skin, ActArcadeData.Rank rank)
		{
		}

		// Token: 0x0602B983 RID: 178563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B983")]
		[Address(RVA = "0x27804A0", Offset = "0x277F0A0", VA = "0x1827804A0")]
		private void _PlayIllustVoice(CharUISkinStruct skin, ActArcadeData.Rank rank)
		{
		}

		// Token: 0x0602B984 RID: 178564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B984")]
		[Address(RVA = "0x2780720", Offset = "0x277F320", VA = "0x182780720")]
		public Act1ArcadeSettlementIllustView()
		{
		}

		// Token: 0x0403F0F5 RID: 258293
		[Token(Token = "0x403F0F5")]
		[FieldOffset(Offset = "0x18")]
		private UICharacterIllust m_cacheIllust;

		// Token: 0x0403F0F6 RID: 258294
		[Token(Token = "0x403F0F6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0403F0F7 RID: 258295
		[Token(Token = "0x403F0F7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__PlayIllustVoice;

		// Token: 0x0403F0F8 RID: 258296
		[Token(Token = "0x403F0F8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
