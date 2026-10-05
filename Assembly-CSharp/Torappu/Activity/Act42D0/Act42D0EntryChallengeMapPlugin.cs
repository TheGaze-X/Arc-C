using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x02007387 RID: 29575
	[Token(Token = "0x2007387")]
	public class Act42D0EntryChallengeMapPlugin : TemplateActivityCommonPlugin
	{
		// Token: 0x06029CF9 RID: 171257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029CF9")]
		[Address(RVA = "0x255EB30", Offset = "0x255D730", VA = "0x18255EB30", Slot = "5")]
		public override void OnViewModelRefresh(TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x06029CFA RID: 171258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029CFA")]
		[Address(RVA = "0x255EE20", Offset = "0x255DA20", VA = "0x18255EE20")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06029CFB RID: 171259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029CFB")]
		[Address(RVA = "0x255E940", Offset = "0x255D540", VA = "0x18255E940")]
		public void OnChallengeClick()
		{
		}

		// Token: 0x06029CFC RID: 171260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029CFC")]
		[Address(RVA = "0x255EF00", Offset = "0x255DB00", VA = "0x18255EF00")]
		public Act42D0EntryChallengeMapPlugin()
		{
		}

		// Token: 0x0403BDF5 RID: 245237
		[Token(Token = "0x403BDF5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _objAllClear;

		// Token: 0x0403BDF6 RID: 245238
		[Token(Token = "0x403BDF6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UICommonTrackPoint _objTrackPoint;

		// Token: 0x0403BDF7 RID: 245239
		[Token(Token = "0x403BDF7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _objClosed;

		// Token: 0x0403BDF8 RID: 245240
		[Token(Token = "0x403BDF8")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isInited;

		// Token: 0x0403BDF9 RID: 245241
		[Token(Token = "0x403BDF9")]
		[FieldOffset(Offset = "0x48")]
		private TrackPointViewProperty m_challengeTrackPointProperty;

		// Token: 0x0403BDFA RID: 245242
		[Token(Token = "0x403BDFA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x0403BDFB RID: 245243
		[Token(Token = "0x403BDFB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403BDFC RID: 245244
		[Token(Token = "0x403BDFC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnChallengeClick;

		// Token: 0x0403BDFD RID: 245245
		[Token(Token = "0x403BDFD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
