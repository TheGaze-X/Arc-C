using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x02004586 RID: 17798
	[Token(Token = "0x2004586")]
	public class RoguelikeTopicWebState : UIWebWindowState
	{
		// Token: 0x0601B18E RID: 110990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B18E")]
		[Address(RVA = "0x1440B90", Offset = "0x143F790", VA = "0x181440B90", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601B18F RID: 110991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B18F")]
		[Address(RVA = "0x1440BF0", Offset = "0x143F7F0", VA = "0x181440BF0", Slot = "30")]
		protected override string GetWebWindowType()
		{
			return null;
		}

		// Token: 0x0601B190 RID: 110992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B190")]
		[Address(RVA = "0x1440D80", Offset = "0x143F980", VA = "0x181440D80", Slot = "24")]
		protected override IEnumerator HideCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0601B191 RID: 110993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B191")]
		[Address(RVA = "0x1440EC0", Offset = "0x143FAC0", VA = "0x181440EC0", Slot = "26")]
		protected override void HideImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x0601B192 RID: 110994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B192")]
		[Address(RVA = "0x1440FF0", Offset = "0x143FBF0", VA = "0x181440FF0", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0601B193 RID: 110995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B193")]
		[Address(RVA = "0x1441130", Offset = "0x143FD30", VA = "0x181441130", Slot = "25")]
		protected override void ShowImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x0601B194 RID: 110996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B194")]
		[Address(RVA = "0x1441260", Offset = "0x143FE60", VA = "0x181441260")]
		private void _CleanBlurShot()
		{
		}

		// Token: 0x0601B195 RID: 110997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B195")]
		[Address(RVA = "0x14413C0", Offset = "0x143FFC0", VA = "0x1814413C0")]
		private void _SetupBlurShot()
		{
		}

		// Token: 0x0601B196 RID: 110998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B196")]
		[Address(RVA = "0x1441470", Offset = "0x1440070", VA = "0x181441470")]
		public RoguelikeTopicWebState()
		{
		}

		// Token: 0x0601B197 RID: 110999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B197")]
		[Address(RVA = "0x121A5A0", Offset = "0x12191A0", VA = "0x18121A5A0")]
		private IEnumerator <>xLuaBaseProxy_HideCoroutine(UIPopupState.TransactionContext P0)
		{
			return null;
		}

		// Token: 0x0601B198 RID: 111000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B198")]
		[Address(RVA = "0x121A5D0", Offset = "0x12191D0", VA = "0x18121A5D0")]
		private void <>xLuaBaseProxy_HideImmediately(UIPopupState.TransactionContext P0)
		{
		}

		// Token: 0x0601B199 RID: 111001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B199")]
		[Address(RVA = "0x121A610", Offset = "0x1219210", VA = "0x18121A610")]
		private IEnumerator <>xLuaBaseProxy_ShowCoroutine(UIPopupState.TransactionContext P0)
		{
			return null;
		}

		// Token: 0x0601B19A RID: 111002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B19A")]
		[Address(RVA = "0x121A640", Offset = "0x1219240", VA = "0x18121A640")]
		private void <>xLuaBaseProxy_ShowImmediately(UIPopupState.TransactionContext P0)
		{
		}

		// Token: 0x04022DCD RID: 142797
		[Token(Token = "0x4022DCD")]
		public const float FADE_DURATION = 0.23f;

		// Token: 0x04022DCE RID: 142798
		[Token(Token = "0x4022DCE")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image _blurImage;

		// Token: 0x04022DCF RID: 142799
		[Token(Token = "0x4022DCF")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private CanvasGroup _rootView;

		// Token: 0x04022DD0 RID: 142800
		[Token(Token = "0x4022DD0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04022DD1 RID: 142801
		[Token(Token = "0x4022DD1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetWebWindowType;

		// Token: 0x04022DD2 RID: 142802
		[Token(Token = "0x4022DD2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x04022DD3 RID: 142803
		[Token(Token = "0x4022DD3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_HideImmediately;

		// Token: 0x04022DD4 RID: 142804
		[Token(Token = "0x4022DD4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x04022DD5 RID: 142805
		[Token(Token = "0x4022DD5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ShowImmediately;

		// Token: 0x04022DD6 RID: 142806
		[Token(Token = "0x4022DD6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CleanBlurShot;

		// Token: 0x04022DD7 RID: 142807
		[Token(Token = "0x4022DD7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__SetupBlurShot;

		// Token: 0x04022DD8 RID: 142808
		[Token(Token = "0x4022DD8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
