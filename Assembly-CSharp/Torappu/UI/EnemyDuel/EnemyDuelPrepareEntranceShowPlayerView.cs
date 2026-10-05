using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x0200502D RID: 20525
	[Token(Token = "0x200502D")]
	public class EnemyDuelPrepareEntranceShowPlayerView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601E71E RID: 124702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E71E")]
		[Address(RVA = "0x18259C0", Offset = "0x18245C0", VA = "0x1818259C0")]
		public void Render(EnemyDuelPrepareEntranceShowPlayerViewModel viewModel, string actId, ILoadAsset loadAsset)
		{
		}

		// Token: 0x0601E71F RID: 124703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E71F")]
		[Address(RVA = "0x1825B80", Offset = "0x1824780", VA = "0x181825B80")]
		public EnemyDuelPrepareEntranceShowPlayerView()
		{
		}

		// Token: 0x04028BE8 RID: 166888
		[Token(Token = "0x4028BE8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _emptyObj;

		// Token: 0x04028BE9 RID: 166889
		[Token(Token = "0x4028BE9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _assitBgObj;

		// Token: 0x04028BEA RID: 166890
		[Token(Token = "0x4028BEA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _avatarImage;

		// Token: 0x04028BEB RID: 166891
		[Token(Token = "0x4028BEB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04028BEC RID: 166892
		[Token(Token = "0x4028BEC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
