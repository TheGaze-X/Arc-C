using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x02007937 RID: 31031
	[Token(Token = "0x2007937")]
	public class Act1ArcadeBadgeBookUltimateTailView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602B89B RID: 178331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B89B")]
		[Address(RVA = "0x276F620", Offset = "0x276E220", VA = "0x18276F620")]
		public void Render(string actId, Act1ArcadeBadgeBookItemViewModel model)
		{
		}

		// Token: 0x0602B89C RID: 178332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B89C")]
		[Address(RVA = "0x276F870", Offset = "0x276E470", VA = "0x18276F870")]
		public Act1ArcadeBadgeBookUltimateTailView()
		{
		}

		// Token: 0x0403EF61 RID: 257889
		[Token(Token = "0x403EF61")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _nameText;

		// Token: 0x0403EF62 RID: 257890
		[Token(Token = "0x403EF62")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _lockedPanel;

		// Token: 0x0403EF63 RID: 257891
		[Token(Token = "0x403EF63")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _unlockDescText;

		// Token: 0x0403EF64 RID: 257892
		[Token(Token = "0x403EF64")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _unlockHighlightColor;

		// Token: 0x0403EF65 RID: 257893
		[Token(Token = "0x403EF65")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _normalPanel;

		// Token: 0x0403EF66 RID: 257894
		[Token(Token = "0x403EF66")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _usageText;

		// Token: 0x0403EF67 RID: 257895
		[Token(Token = "0x403EF67")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _upgradePanel;

		// Token: 0x0403EF68 RID: 257896
		[Token(Token = "0x403EF68")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _upgradeText;

		// Token: 0x0403EF69 RID: 257897
		[Token(Token = "0x403EF69")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403EF6A RID: 257898
		[Token(Token = "0x403EF6A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
