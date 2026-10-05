using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RecalRune
{
	// Token: 0x020047C5 RID: 18373
	[Token(Token = "0x20047C5")]
	public class RecalRuneStageRuneTopView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601BD01 RID: 113921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD01")]
		[Address(RVA = "0x15347E0", Offset = "0x15333E0", VA = "0x1815347E0")]
		public void Render(RecalRuneStageRuneViewModel model)
		{
		}

		// Token: 0x0601BD02 RID: 113922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD02")]
		[Address(RVA = "0x15349C0", Offset = "0x15335C0", VA = "0x1815349C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601BD03 RID: 113923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD03")]
		[Address(RVA = "0x1534A60", Offset = "0x1533660", VA = "0x181534A60")]
		public RecalRuneStageRuneTopView()
		{
		}

		// Token: 0x040242F6 RID: 148214
		[Token(Token = "0x40242F6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _stagePicImage;

		// Token: 0x040242F7 RID: 148215
		[Token(Token = "0x40242F7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _stageRecord;

		// Token: 0x040242F8 RID: 148216
		[Token(Token = "0x40242F8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _stageName;

		// Token: 0x040242F9 RID: 148217
		[Token(Token = "0x40242F9")]
		[FieldOffset(Offset = "0x30")]
		private bool m_hasInited;

		// Token: 0x040242FA RID: 148218
		[Token(Token = "0x40242FA")]
		[FieldOffset(Offset = "0x38")]
		private ILoadAsset m_iLoadAsset;

		// Token: 0x040242FB RID: 148219
		[Token(Token = "0x40242FB")]
		[FieldOffset(Offset = "0x40")]
		private string m_cachedStageId;

		// Token: 0x040242FC RID: 148220
		[Token(Token = "0x40242FC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040242FD RID: 148221
		[Token(Token = "0x40242FD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040242FE RID: 148222
		[Token(Token = "0x40242FE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
