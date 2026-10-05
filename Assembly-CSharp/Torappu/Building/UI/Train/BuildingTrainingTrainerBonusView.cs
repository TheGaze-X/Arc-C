using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.Train
{
	// Token: 0x02001C14 RID: 7188
	[Token(Token = "0x2001C14")]
	public class BuildingTrainingTrainerBonusView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600B33D RID: 45885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B33D")]
		[Address(RVA = "0x32E18E0", Offset = "0x32E04E0", VA = "0x1832E18E0")]
		public void Render(int currentCount, int totalCount)
		{
		}

		// Token: 0x0600B33E RID: 45886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B33E")]
		[Address(RVA = "0x32E1AB0", Offset = "0x32E06B0", VA = "0x1832E1AB0")]
		public BuildingTrainingTrainerBonusView()
		{
		}

		// Token: 0x0400AE7A RID: 44666
		[Token(Token = "0x400AE7A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _txtCount;

		// Token: 0x0400AE7B RID: 44667
		[Token(Token = "0x400AE7B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Graphic _graphicIcon;

		// Token: 0x0400AE7C RID: 44668
		[Token(Token = "0x400AE7C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelFull;

		// Token: 0x0400AE7D RID: 44669
		[Token(Token = "0x400AE7D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgCircle;

		// Token: 0x0400AE7E RID: 44670
		[Token(Token = "0x400AE7E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color _colorNormal;

		// Token: 0x0400AE7F RID: 44671
		[Token(Token = "0x400AE7F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _colorFull;

		// Token: 0x0400AE80 RID: 44672
		[Token(Token = "0x400AE80")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0400AE81 RID: 44673
		[Token(Token = "0x400AE81")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
