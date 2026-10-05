using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CrossAppShare
{
	// Token: 0x020058C1 RID: 22721
	[Token(Token = "0x20058C1")]
	public class CrossAppShareSucNotifyView : UINotifyView<CrossAppShareSucNotifyView.Param>, IFloatNotifyView
	{
		// Token: 0x06021286 RID: 135814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021286")]
		[Address(RVA = "0x1B794C0", Offset = "0x1B780C0", VA = "0x181B794C0", Slot = "9")]
		protected override void Render(CrossAppShareSucNotifyView.Param param)
		{
		}

		// Token: 0x06021287 RID: 135815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021287")]
		[Address(RVA = "0x1B79350", Offset = "0x1B77F50", VA = "0x181B79350", Slot = "10")]
		public UISwitchTween GetSwitchTween()
		{
			return null;
		}

		// Token: 0x06021288 RID: 135816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021288")]
		[Address(RVA = "0x1B795A0", Offset = "0x1B781A0", VA = "0x181B795A0")]
		public CrossAppShareSucNotifyView()
		{
		}

		// Token: 0x0402D288 RID: 184968
		[Token(Token = "0x402D288")]
		private const string CROSS_APP_SHARE_SUC_SIG = "CrossAppShareSucNotify";

		// Token: 0x0402D289 RID: 184969
		[Token(Token = "0x402D289")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textTip;

		// Token: 0x0402D28A RID: 184970
		[Token(Token = "0x402D28A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CanvasGroup _alphaHandler;

		// Token: 0x0402D28B RID: 184971
		[Token(Token = "0x402D28B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Vector2 _showPos;

		// Token: 0x0402D28C RID: 184972
		[Token(Token = "0x402D28C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Vector2 _hidePos;

		// Token: 0x0402D28D RID: 184973
		[Token(Token = "0x402D28D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _toastDuration;

		// Token: 0x0402D28E RID: 184974
		[Token(Token = "0x402D28E")]
		[FieldOffset(Offset = "0x58")]
		private UISwitchTween m_switchTween;

		// Token: 0x0402D28F RID: 184975
		[Token(Token = "0x402D28F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402D290 RID: 184976
		[Token(Token = "0x402D290")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetSwitchTween;

		// Token: 0x0402D291 RID: 184977
		[Token(Token = "0x402D291")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020058C2 RID: 22722
		[Token(Token = "0x20058C2")]
		public class Param : NotifyViewParam
		{
			// Token: 0x06021289 RID: 135817 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6021289")]
			[Address(RVA = "0x1B79EF0", Offset = "0x1B78AF0", VA = "0x181B79EF0", Slot = "4")]
			public override string GenerateSignature()
			{
				return null;
			}

			// Token: 0x0602128A RID: 135818 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602128A")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public Param()
			{
			}

			// Token: 0x0402D292 RID: 184978
			[Token(Token = "0x402D292")]
			[FieldOffset(Offset = "0x10")]
			public string filePath;
		}
	}
}
