using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.GameCity.Battle.UI
{
	// Token: 0x02007908 RID: 30984
	[Token(Token = "0x2007908")]
	public class GameCityInfoShowPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602B770 RID: 178032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B770")]
		[Address(RVA = "0x275AE90", Offset = "0x2759A90", VA = "0x18275AE90")]
		public void OnInit()
		{
		}

		// Token: 0x0602B771 RID: 178033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B771")]
		[Address(RVA = "0x275B2E0", Offset = "0x2759EE0", VA = "0x18275B2E0")]
		public GameCityInfoShowPanel()
		{
		}

		// Token: 0x0403ED74 RID: 257396
		[Token(Token = "0x403ED74")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _subModeTitle;

		// Token: 0x0403ED75 RID: 257397
		[Token(Token = "0x403ED75")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _scoreInfoText;

		// Token: 0x0403ED76 RID: 257398
		[Token(Token = "0x403ED76")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<RectTransform> _subModeIcons;

		// Token: 0x0403ED77 RID: 257399
		[Token(Token = "0x403ED77")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		public AnimationWrapper uiWrapper;

		// Token: 0x0403ED78 RID: 257400
		[Token(Token = "0x403ED78")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0403ED79 RID: 257401
		[Token(Token = "0x403ED79")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
