using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020067ED RID: 26605
	[Token(Token = "0x20067ED")]
	public class StageZoneHomeCrisisToDoItem : StageZoneHomeToDoItemPlugin
	{
		// Token: 0x0602621B RID: 156187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602621B")]
		[Address(RVA = "0x213EC80", Offset = "0x213D880", VA = "0x18213EC80", Slot = "6")]
		protected override Sprite LoadMainSprite()
		{
			return null;
		}

		// Token: 0x0602621C RID: 156188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602621C")]
		[Address(RVA = "0x213EDF0", Offset = "0x213D9F0", VA = "0x18213EDF0", Slot = "5")]
		protected override void OnDataUpdated()
		{
		}

		// Token: 0x0602621D RID: 156189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602621D")]
		[Address(RVA = "0x213F060", Offset = "0x213DC60", VA = "0x18213F060")]
		private void _UpdateTrainingInfo()
		{
		}

		// Token: 0x0602621E RID: 156190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602621E")]
		[Address(RVA = "0x213F190", Offset = "0x213DD90", VA = "0x18213F190")]
		public StageZoneHomeCrisisToDoItem()
		{
		}

		// Token: 0x04035B44 RID: 219972
		[Token(Token = "0x4035B44")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textTitle;

		// Token: 0x04035B45 RID: 219973
		[Token(Token = "0x4035B45")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textStageName;

		// Token: 0x04035B46 RID: 219974
		[Token(Token = "0x4035B46")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Sprite _trainingSprite;

		// Token: 0x04035B47 RID: 219975
		[Token(Token = "0x4035B47")]
		[FieldOffset(Offset = "0x40")]
		private ZoneHomeToDoCrisisV2Model m_viewModel;

		// Token: 0x04035B48 RID: 219976
		[Token(Token = "0x4035B48")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadMainSprite;

		// Token: 0x04035B49 RID: 219977
		[Token(Token = "0x4035B49")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDataUpdated;

		// Token: 0x04035B4A RID: 219978
		[Token(Token = "0x4035B4A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateTrainingInfo;

		// Token: 0x04035B4B RID: 219979
		[Token(Token = "0x4035B4B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
