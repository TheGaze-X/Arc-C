using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003C78 RID: 15480
	[Token(Token = "0x2003C78")]
	public class TuningChatResultDialog : UICustomDialog<TuningChatResultDialog.Options>
	{
		// Token: 0x060182D6 RID: 99030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60182D6")]
		[Address(RVA = "0x10AB120", Offset = "0x10A9D20", VA = "0x1810AB120", Slot = "10")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x060182D7 RID: 99031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182D7")]
		[Address(RVA = "0x10AB180", Offset = "0x10A9D80", VA = "0x1810AB180", Slot = "8")]
		protected override void OnInit()
		{
		}

		// Token: 0x060182D8 RID: 99032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182D8")]
		[Address(RVA = "0x10AB2B0", Offset = "0x10A9EB0", VA = "0x1810AB2B0", Slot = "7")]
		protected override void OnRender(TuningChatResultDialog.Options options)
		{
		}

		// Token: 0x060182D9 RID: 99033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60182D9")]
		[Address(RVA = "0x10ABAF0", Offset = "0x10AA6F0", VA = "0x1810ABAF0")]
		private Sprite _LoadAvatar(string avatarId)
		{
			return null;
		}

		// Token: 0x060182DA RID: 99034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182DA")]
		[Address(RVA = "0x10AB090", Offset = "0x10A9C90", VA = "0x1810AB090")]
		public void EventOnConfirm()
		{
		}

		// Token: 0x060182DB RID: 99035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182DB")]
		[Address(RVA = "0x10ABB90", Offset = "0x10AA790", VA = "0x1810ABB90")]
		public TuningChatResultDialog()
		{
		}

		// Token: 0x0401D6C9 RID: 120521
		[Token(Token = "0x401D6C9")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _panelFail;

		// Token: 0x0401D6CA RID: 120522
		[Token(Token = "0x401D6CA")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _panelFailHidden;

		// Token: 0x0401D6CB RID: 120523
		[Token(Token = "0x401D6CB")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _panelSuccNormel;

		// Token: 0x0401D6CC RID: 120524
		[Token(Token = "0x401D6CC")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _panelSuccMajor;

		// Token: 0x0401D6CD RID: 120525
		[Token(Token = "0x401D6CD")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _panelSuccHidden;

		// Token: 0x0401D6CE RID: 120526
		[Token(Token = "0x401D6CE")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _panelNormal;

		// Token: 0x0401D6CF RID: 120527
		[Token(Token = "0x401D6CF")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _panelChar;

		// Token: 0x0401D6D0 RID: 120528
		[Token(Token = "0x401D6D0")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Text _resultUp;

		// Token: 0x0401D6D1 RID: 120529
		[Token(Token = "0x401D6D1")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Text _resultDown;

		// Token: 0x0401D6D2 RID: 120530
		[Token(Token = "0x401D6D2")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Text _resultCharUp;

		// Token: 0x0401D6D3 RID: 120531
		[Token(Token = "0x401D6D3")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Text _resultCharDown;

		// Token: 0x0401D6D4 RID: 120532
		[Token(Token = "0x401D6D4")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Text _titleNormalSuccess;

		// Token: 0x0401D6D5 RID: 120533
		[Token(Token = "0x401D6D5")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Text _titleNormalFail;

		// Token: 0x0401D6D6 RID: 120534
		[Token(Token = "0x401D6D6")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private Text _titleNormalSpecial;

		// Token: 0x0401D6D7 RID: 120535
		[Token(Token = "0x401D6D7")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private Text _titleCharSuccess;

		// Token: 0x0401D6D8 RID: 120536
		[Token(Token = "0x401D6D8")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private Text _titleCharSpecial;

		// Token: 0x0401D6D9 RID: 120537
		[Token(Token = "0x401D6D9")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private Image _avatar;

		// Token: 0x0401D6DA RID: 120538
		[Token(Token = "0x401D6DA")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private Image _avatarHidden;

		// Token: 0x0401D6DB RID: 120539
		[Token(Token = "0x401D6DB")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private UIRenderTextureImage _bkgBlur;

		// Token: 0x0401D6DC RID: 120540
		[Token(Token = "0x401D6DC")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private RectTransform _backRt;

		// Token: 0x0401D6DD RID: 120541
		[Token(Token = "0x401D6DD")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private UIAnimationLocation _normalAnim;

		// Token: 0x0401D6DE RID: 120542
		[Token(Token = "0x401D6DE")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private UIAnimationLocation _charAnim;

		// Token: 0x0401D6DF RID: 120543
		[Token(Token = "0x401D6DF")]
		[FieldOffset(Offset = "0x128")]
		private Tween m_enterTween;

		// Token: 0x0401D6E0 RID: 120544
		[Token(Token = "0x401D6E0")]
		[FieldOffset(Offset = "0x130")]
		private TuningChatResultDialog.Options m_options;

		// Token: 0x0401D6E1 RID: 120545
		[Token(Token = "0x401D6E1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x0401D6E2 RID: 120546
		[Token(Token = "0x401D6E2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0401D6E3 RID: 120547
		[Token(Token = "0x401D6E3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0401D6E4 RID: 120548
		[Token(Token = "0x401D6E4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LoadAvatar;

		// Token: 0x0401D6E5 RID: 120549
		[Token(Token = "0x401D6E5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnConfirm;

		// Token: 0x0401D6E6 RID: 120550
		[Token(Token = "0x401D6E6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003C79 RID: 15481
		[Token(Token = "0x2003C79")]
		public struct Options
		{
			// Token: 0x0401D6E7 RID: 120551
			[Token(Token = "0x401D6E7")]
			[FieldOffset(Offset = "0x0")]
			public Action callback;

			// Token: 0x0401D6E8 RID: 120552
			[Token(Token = "0x401D6E8")]
			[FieldOffset(Offset = "0x8")]
			public Act29SideData.Act29SideInvestType type;

			// Token: 0x0401D6E9 RID: 120553
			[Token(Token = "0x401D6E9")]
			[FieldOffset(Offset = "0xC")]
			public bool isSuccess;

			// Token: 0x0401D6EA RID: 120554
			[Token(Token = "0x401D6EA")]
			[FieldOffset(Offset = "0xD")]
			public bool isHidden;

			// Token: 0x0401D6EB RID: 120555
			[Token(Token = "0x401D6EB")]
			[FieldOffset(Offset = "0xE")]
			public bool useTips;

			// Token: 0x0401D6EC RID: 120556
			[Token(Token = "0x401D6EC")]
			[FieldOffset(Offset = "0x10")]
			public string title;

			// Token: 0x0401D6ED RID: 120557
			[Token(Token = "0x401D6ED")]
			[FieldOffset(Offset = "0x18")]
			public string descUp;

			// Token: 0x0401D6EE RID: 120558
			[Token(Token = "0x401D6EE")]
			[FieldOffset(Offset = "0x20")]
			public string descDown;

			// Token: 0x0401D6EF RID: 120559
			[Token(Token = "0x401D6EF")]
			[FieldOffset(Offset = "0x28")]
			public string investNpcPic;
		}
	}
}
