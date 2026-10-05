using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001F72 RID: 8050
	[Token(Token = "0x2001F72")]
	public class AVGTutorialDialog : MonoBehaviour, IHotfixable
	{
		// Token: 0x170017AA RID: 6058
		// (get) Token: 0x0600C80A RID: 51210 RVA: 0x00048CA8 File Offset: 0x00046EA8
		[Token(Token = "0x170017AA")]
		public bool IsTyping
		{
			[Token(Token = "0x600C80A")]
			[Address(RVA = "0x3493800", Offset = "0x3492400", VA = "0x183493800")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600C80B RID: 51211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C80B")]
		[Address(RVA = "0x3493400", Offset = "0x3492000", VA = "0x183493400")]
		public void OnReset()
		{
		}

		// Token: 0x0600C80C RID: 51212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C80C")]
		[Address(RVA = "0x34934B0", Offset = "0x34920B0", VA = "0x1834934B0")]
		public void Show(Command command, Sprite head)
		{
		}

		// Token: 0x0600C80D RID: 51213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C80D")]
		[Address(RVA = "0x34932C0", Offset = "0x3491EC0", VA = "0x1834932C0")]
		public void ForceEnd()
		{
		}

		// Token: 0x0600C80E RID: 51214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C80E")]
		[Address(RVA = "0x3493330", Offset = "0x3491F30", VA = "0x183493330")]
		public void Hide()
		{
		}

		// Token: 0x0600C80F RID: 51215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C80F")]
		[Address(RVA = "0x3493240", Offset = "0x3491E40", VA = "0x183493240")]
		private void Awake()
		{
		}

		// Token: 0x0600C810 RID: 51216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C810")]
		[Address(RVA = "0x3493790", Offset = "0x3492390", VA = "0x183493790")]
		public AVGTutorialDialog()
		{
		}

		// Token: 0x0400CE67 RID: 52839
		[Token(Token = "0x400CE67")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AVGTypeWriterText _typeWriter;

		// Token: 0x0400CE68 RID: 52840
		[Token(Token = "0x400CE68")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _headImage;

		// Token: 0x0400CE69 RID: 52841
		[Token(Token = "0x400CE69")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _defaultFadeTime;

		// Token: 0x0400CE6A RID: 52842
		[Token(Token = "0x400CE6A")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Vector2 _defaultPos;

		// Token: 0x0400CE6B RID: 52843
		[Token(Token = "0x400CE6B")]
		[FieldOffset(Offset = "0x38")]
		private CanvasGroup m_group;

		// Token: 0x0400CE6C RID: 52844
		[Token(Token = "0x400CE6C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_IsTyping;

		// Token: 0x0400CE6D RID: 52845
		[Token(Token = "0x400CE6D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x0400CE6E RID: 52846
		[Token(Token = "0x400CE6E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x0400CE6F RID: 52847
		[Token(Token = "0x400CE6F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ForceEnd;

		// Token: 0x0400CE70 RID: 52848
		[Token(Token = "0x400CE70")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x0400CE71 RID: 52849
		[Token(Token = "0x400CE71")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0400CE72 RID: 52850
		[Token(Token = "0x400CE72")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
