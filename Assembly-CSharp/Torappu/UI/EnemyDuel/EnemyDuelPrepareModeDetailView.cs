using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02005047 RID: 20551
	[Token(Token = "0x2005047")]
	public class EnemyDuelPrepareModeDetailView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601E77E RID: 124798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E77E")]
		[Address(RVA = "0x18277E0", Offset = "0x18263E0", VA = "0x1818277E0")]
		public void Render(ActivityEnemyDuelModeData modeData, bool isInRoom)
		{
		}

		// Token: 0x0601E77F RID: 124799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E77F")]
		[Address(RVA = "0x1827A60", Offset = "0x1826660", VA = "0x181827A60")]
		public EnemyDuelPrepareModeDetailView()
		{
		}

		// Token: 0x04028CDD RID: 167133
		[Token(Token = "0x4028CDD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TwoStateToggle _roomIconToggle;

		// Token: 0x04028CDE RID: 167134
		[Token(Token = "0x4028CDE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _modeNameText;

		// Token: 0x04028CDF RID: 167135
		[Token(Token = "0x4028CDF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _playerCntText;

		// Token: 0x04028CE0 RID: 167136
		[Token(Token = "0x4028CE0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _modeTargetText;

		// Token: 0x04028CE1 RID: 167137
		[Token(Token = "0x4028CE1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _modeDetailText;

		// Token: 0x04028CE2 RID: 167138
		[Token(Token = "0x4028CE2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _modePrefixText;

		// Token: 0x04028CE3 RID: 167139
		[Token(Token = "0x4028CE3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private TwoStateToggle _multiPlayerToggle;

		// Token: 0x04028CE4 RID: 167140
		[Token(Token = "0x4028CE4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04028CE5 RID: 167141
		[Token(Token = "0x4028CE5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
