using System;
using Il2CppDummyDll;
using Torappu.UI.CrossAppShare;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x02007944 RID: 31044
	[Token(Token = "0x2007944")]
	public class Act1ArcadeBadgeBookShareStartLayoutElement : CrossAppShareStartBaseLayoutElement
	{
		// Token: 0x0602B8EE RID: 178414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B8EE")]
		[Address(RVA = "0x276CF90", Offset = "0x276BB90", VA = "0x18276CF90", Slot = "4")]
		public override CrossAppShareElementModelCollector GetElementModelCollector()
		{
			return null;
		}

		// Token: 0x0602B8EF RID: 178415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B8EF")]
		[Address(RVA = "0x276D2F0", Offset = "0x276BEF0", VA = "0x18276D2F0")]
		public Act1ArcadeBadgeBookShareStartLayoutElement()
		{
		}

		// Token: 0x0403F010 RID: 258064
		[Token(Token = "0x403F010")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Act1ArcadeBadgeBookItemHeadView _headView;

		// Token: 0x0403F011 RID: 258065
		[Token(Token = "0x403F011")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetElementModelCollector;

		// Token: 0x0403F012 RID: 258066
		[Token(Token = "0x403F012")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
