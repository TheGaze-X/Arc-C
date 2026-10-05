using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.CrossAppShare;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x02007942 RID: 31042
	[Token(Token = "0x2007942")]
	public class Act1ArcadeBadgeBookShareRemakeLayoutElement : CrossAppShareRemakeBaseLayoutElement
	{
		// Token: 0x0602B8EA RID: 178410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B8EA")]
		[Address(RVA = "0x276C710", Offset = "0x276B310", VA = "0x18276C710", Slot = "4")]
		public override void ApplyComponentModels(ICrossAppShareModelCollector modelCollector, ILoadAsset iLoadAsset)
		{
		}

		// Token: 0x0602B8EB RID: 178411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B8EB")]
		[Address(RVA = "0x276C9F0", Offset = "0x276B5F0", VA = "0x18276C9F0")]
		public Act1ArcadeBadgeBookShareRemakeLayoutElement()
		{
		}

		// Token: 0x0403F000 RID: 258048
		[Token(Token = "0x403F000")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _lockedPanel;

		// Token: 0x0403F001 RID: 258049
		[Token(Token = "0x403F001")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _normalPanel;

		// Token: 0x0403F002 RID: 258050
		[Token(Token = "0x403F002")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _iconImage;

		// Token: 0x0403F003 RID: 258051
		[Token(Token = "0x403F003")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _tierImage;

		// Token: 0x0403F004 RID: 258052
		[Token(Token = "0x403F004")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyComponentModels;

		// Token: 0x0403F005 RID: 258053
		[Token(Token = "0x403F005")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
