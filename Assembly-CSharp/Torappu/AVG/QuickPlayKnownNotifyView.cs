using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001EE2 RID: 7906
	[Token(Token = "0x2001EE2")]
	public class QuickPlayKnownNotifyView : UINotifyView<QuickPlayKnownNotifyView.Param>, IFloatNotifyView
	{
		// Token: 0x0600C43B RID: 50235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C43B")]
		[Address(RVA = "0x34310C0", Offset = "0x342FCC0", VA = "0x1834310C0", Slot = "9")]
		protected override void Render(QuickPlayKnownNotifyView.Param param)
		{
		}

		// Token: 0x0600C43C RID: 50236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C43C")]
		[Address(RVA = "0x3430EA0", Offset = "0x342FAA0", VA = "0x183430EA0")]
		public void OnReadToastClick()
		{
		}

		// Token: 0x0600C43D RID: 50237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C43D")]
		[Address(RVA = "0x3430D30", Offset = "0x342F930", VA = "0x183430D30", Slot = "10")]
		public UISwitchTween GetSwitchTween()
		{
			return null;
		}

		// Token: 0x0600C43E RID: 50238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C43E")]
		[Address(RVA = "0x34311F0", Offset = "0x342FDF0", VA = "0x1834311F0")]
		public QuickPlayKnownNotifyView()
		{
		}

		// Token: 0x0400C8C2 RID: 51394
		[Token(Token = "0x400C8C2")]
		private const string QUICK_PLAY_TOAST_SIG = "QuickPlayKnownNotifyView";

		// Token: 0x0400C8C3 RID: 51395
		[Token(Token = "0x400C8C3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _text;

		// Token: 0x0400C8C4 RID: 51396
		[Token(Token = "0x400C8C4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _btnText;

		// Token: 0x0400C8C5 RID: 51397
		[Token(Token = "0x400C8C5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _knownBtn;

		// Token: 0x0400C8C6 RID: 51398
		[Token(Token = "0x400C8C6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CanvasGroup _alphaHandler;

		// Token: 0x0400C8C7 RID: 51399
		[Token(Token = "0x400C8C7")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Vector2 _showPos;

		// Token: 0x0400C8C8 RID: 51400
		[Token(Token = "0x400C8C8")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Vector2 _hidePos;

		// Token: 0x0400C8C9 RID: 51401
		[Token(Token = "0x400C8C9")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _toastDuration;

		// Token: 0x0400C8CA RID: 51402
		[Token(Token = "0x400C8CA")]
		[FieldOffset(Offset = "0x68")]
		private UISwitchTween m_switchTween;

		// Token: 0x0400C8CB RID: 51403
		[Token(Token = "0x400C8CB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0400C8CC RID: 51404
		[Token(Token = "0x400C8CC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnReadToastClick;

		// Token: 0x0400C8CD RID: 51405
		[Token(Token = "0x400C8CD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetSwitchTween;

		// Token: 0x0400C8CE RID: 51406
		[Token(Token = "0x400C8CE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001EE3 RID: 7907
		[Token(Token = "0x2001EE3")]
		public class Param : NotifyViewParam
		{
			// Token: 0x0600C43F RID: 50239 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600C43F")]
			[Address(RVA = "0x3430250", Offset = "0x342EE50", VA = "0x183430250", Slot = "4")]
			public override string GenerateSignature()
			{
				return null;
			}

			// Token: 0x0600C440 RID: 50240 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C440")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public Param()
			{
			}

			// Token: 0x0400C8CF RID: 51407
			[Token(Token = "0x400C8CF")]
			[FieldOffset(Offset = "0x10")]
			public string text;

			// Token: 0x0400C8D0 RID: 51408
			[Token(Token = "0x400C8D0")]
			[FieldOffset(Offset = "0x18")]
			public bool isShowBtn;

			// Token: 0x0400C8D1 RID: 51409
			[Token(Token = "0x400C8D1")]
			[FieldOffset(Offset = "0x20")]
			public string btnText;
		}
	}
}
