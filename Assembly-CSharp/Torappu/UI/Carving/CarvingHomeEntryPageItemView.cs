using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x02006025 RID: 24613
	[Token(Token = "0x2006025")]
	public class CarvingHomeEntryPageItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06023982 RID: 145794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023982")]
		[Address(RVA = "0x1E3B210", Offset = "0x1E39E10", VA = "0x181E3B210")]
		public void Render(CarvingChallengeStatus status, bool isFocus)
		{
		}

		// Token: 0x06023983 RID: 145795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023983")]
		[Address(RVA = "0x1E3B350", Offset = "0x1E39F50", VA = "0x181E3B350")]
		public CarvingHomeEntryPageItemView()
		{
		}

		// Token: 0x04031468 RID: 201832
		[Token(Token = "0x4031468")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelUnselected;

		// Token: 0x04031469 RID: 201833
		[Token(Token = "0x4031469")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelSelected;

		// Token: 0x0403146A RID: 201834
		[Token(Token = "0x403146A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CarvingHomeEntryPageItemView.Config[] _configList;

		// Token: 0x0403146B RID: 201835
		[Token(Token = "0x403146B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403146C RID: 201836
		[Token(Token = "0x403146C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006026 RID: 24614
		[Token(Token = "0x2006026")]
		[Serializable]
		private struct Config
		{
			// Token: 0x0403146D RID: 201837
			[Token(Token = "0x403146D")]
			[FieldOffset(Offset = "0x0")]
			public CarvingChallengeStatus status;

			// Token: 0x0403146E RID: 201838
			[Token(Token = "0x403146E")]
			[FieldOffset(Offset = "0x8")]
			public GameObject dotGameObject;
		}
	}
}
