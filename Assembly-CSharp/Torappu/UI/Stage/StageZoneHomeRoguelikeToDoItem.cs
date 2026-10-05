using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020067EE RID: 26606
	[Token(Token = "0x20067EE")]
	public class StageZoneHomeRoguelikeToDoItem : StageZoneHomeToDoItemPlugin
	{
		// Token: 0x0602621F RID: 156191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602621F")]
		[Address(RVA = "0x213F230", Offset = "0x213DE30", VA = "0x18213F230", Slot = "6")]
		protected override Sprite LoadMainSprite()
		{
			return null;
		}

		// Token: 0x06026220 RID: 156192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026220")]
		[Address(RVA = "0x213F440", Offset = "0x213E040", VA = "0x18213F440", Slot = "5")]
		protected override void OnDataUpdated()
		{
		}

		// Token: 0x06026221 RID: 156193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026221")]
		[Address(RVA = "0x213F6F0", Offset = "0x213E2F0", VA = "0x18213F6F0")]
		public StageZoneHomeRoguelikeToDoItem()
		{
		}

		// Token: 0x04035B4C RID: 219980
		[Token(Token = "0x4035B4C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textStageName;

		// Token: 0x04035B4D RID: 219981
		[Token(Token = "0x4035B4D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _onBattleGo;

		// Token: 0x04035B4E RID: 219982
		[Token(Token = "0x4035B4E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _pinnedGo;

		// Token: 0x04035B4F RID: 219983
		[Token(Token = "0x4035B4F")]
		[FieldOffset(Offset = "0x40")]
		private ZoneHomeToDoRoguelikeModel m_viewModel;

		// Token: 0x04035B50 RID: 219984
		[Token(Token = "0x4035B50")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadMainSprite;

		// Token: 0x04035B51 RID: 219985
		[Token(Token = "0x4035B51")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDataUpdated;

		// Token: 0x04035B52 RID: 219986
		[Token(Token = "0x4035B52")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
