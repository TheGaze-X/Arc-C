using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x0200669A RID: 26266
	[Token(Token = "0x200669A")]
	public class HandBookInfoStageView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06025BA7 RID: 154535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BA7")]
		[Address(RVA = "0x20A7540", Offset = "0x20A6140", VA = "0x1820A7540")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06025BA8 RID: 154536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BA8")]
		[Address(RVA = "0x20A71D0", Offset = "0x20A5DD0", VA = "0x1820A71D0")]
		public void Render(HandBookStageViewModel stage)
		{
		}

		// Token: 0x06025BA9 RID: 154537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BA9")]
		[Address(RVA = "0x20A74D0", Offset = "0x20A60D0", VA = "0x1820A74D0")]
		public void Show()
		{
		}

		// Token: 0x06025BAA RID: 154538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BAA")]
		[Address(RVA = "0x20A7160", Offset = "0x20A5D60", VA = "0x1820A7160")]
		public void Hide()
		{
		}

		// Token: 0x06025BAB RID: 154539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BAB")]
		[Address(RVA = "0x20A7720", Offset = "0x20A6320", VA = "0x1820A7720")]
		public HandBookInfoStageView()
		{
		}

		// Token: 0x04035033 RID: 217139
		[Token(Token = "0x4035033")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _unlockContent;

		// Token: 0x04035034 RID: 217140
		[Token(Token = "0x4035034")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _itemContent;

		// Token: 0x04035035 RID: 217141
		[Token(Token = "0x4035035")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIBlurFloatPanel _blurFloatPanel;

		// Token: 0x04035036 RID: 217142
		[Token(Token = "0x4035036")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _scale;

		// Token: 0x04035037 RID: 217143
		[Token(Token = "0x4035037")]
		[FieldOffset(Offset = "0x38")]
		private HandbookRewardAdapter m_rewardAdapter;

		// Token: 0x04035038 RID: 217144
		[Token(Token = "0x4035038")]
		[FieldOffset(Offset = "0x40")]
		private HandbookUnlockAdapter m_unlockAdapter;

		// Token: 0x04035039 RID: 217145
		[Token(Token = "0x4035039")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isInited;

		// Token: 0x0403503A RID: 217146
		[Token(Token = "0x403503A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403503B RID: 217147
		[Token(Token = "0x403503B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403503C RID: 217148
		[Token(Token = "0x403503C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x0403503D RID: 217149
		[Token(Token = "0x403503D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x0403503E RID: 217150
		[Token(Token = "0x403503E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
