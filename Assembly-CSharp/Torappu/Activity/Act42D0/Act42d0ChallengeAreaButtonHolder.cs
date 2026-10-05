using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x02007398 RID: 29592
	[Token(Token = "0x2007398")]
	public class Act42d0ChallengeAreaButtonHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029D49 RID: 171337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D49")]
		[Address(RVA = "0x257A0E0", Offset = "0x2578CE0", VA = "0x18257A0E0")]
		public void Render(Act42D0ChallengeStageViewModel viewModel, bool isSelected)
		{
		}

		// Token: 0x170062CC RID: 25292
		// (get) Token: 0x06029D4A RID: 171338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170062CC")]
		public string stageId
		{
			[Token(Token = "0x6029D4A")]
			[Address(RVA = "0x257A540", Offset = "0x2579140", VA = "0x18257A540")]
			get
			{
				return null;
			}
		}

		// Token: 0x06029D4B RID: 171339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D4B")]
		[Address(RVA = "0x257A360", Offset = "0x2578F60", VA = "0x18257A360")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06029D4C RID: 171340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D4C")]
		[Address(RVA = "0x257A4E0", Offset = "0x25790E0", VA = "0x18257A4E0")]
		public Act42d0ChallengeAreaButtonHolder()
		{
		}

		// Token: 0x0403BEA8 RID: 245416
		[Token(Token = "0x403BEA8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _buttonContainer;

		// Token: 0x0403BEA9 RID: 245417
		[Token(Token = "0x403BEA9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Act42d0ChallengeAreaButton _btnPrefab;

		// Token: 0x0403BEAA RID: 245418
		[Token(Token = "0x403BEAA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _stageId;

		// Token: 0x0403BEAB RID: 245419
		[Token(Token = "0x403BEAB")]
		[FieldOffset(Offset = "0x30")]
		private Act42d0ChallengeAreaButton m_cachedBtn;

		// Token: 0x0403BEAC RID: 245420
		[Token(Token = "0x403BEAC")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isInited;

		// Token: 0x0403BEAD RID: 245421
		[Token(Token = "0x403BEAD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403BEAE RID: 245422
		[Token(Token = "0x403BEAE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_stageId;

		// Token: 0x0403BEAF RID: 245423
		[Token(Token = "0x403BEAF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403BEB0 RID: 245424
		[Token(Token = "0x403BEB0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
