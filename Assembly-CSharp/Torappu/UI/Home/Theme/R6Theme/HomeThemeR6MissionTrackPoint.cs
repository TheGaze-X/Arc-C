using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home.Theme.R6Theme
{
	// Token: 0x02004C72 RID: 19570
	[Token(Token = "0x2004C72")]
	public class HomeThemeR6MissionTrackPoint : HomeTrackPointItem, IHotfixable
	{
		// Token: 0x0601D59F RID: 120223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D59F")]
		[Address(RVA = "0x16E8810", Offset = "0x16E7410", VA = "0x1816E8810", Slot = "4")]
		public override void Render(ITrackPointModel value)
		{
		}

		// Token: 0x0601D5A0 RID: 120224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5A0")]
		[Address(RVA = "0x16E8960", Offset = "0x16E7560", VA = "0x1816E8960")]
		public HomeThemeR6MissionTrackPoint()
		{
		}

		// Token: 0x040269D5 RID: 158165
		[Token(Token = "0x40269D5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textCount;

		// Token: 0x040269D6 RID: 158166
		[Token(Token = "0x40269D6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040269D7 RID: 158167
		[Token(Token = "0x40269D7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
