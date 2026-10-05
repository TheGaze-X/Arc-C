using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x02006015 RID: 24597
	[Token(Token = "0x2006015")]
	public class CarvingConfirmDialogInPage : UICompDialog<CarvingConfirmDialogInPage.Option>
	{
		// Token: 0x06023938 RID: 145720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023938")]
		[Address(RVA = "0x1E37250", Offset = "0x1E35E50", VA = "0x181E37250")]
		public void OnCancelBtnClicked()
		{
		}

		// Token: 0x06023939 RID: 145721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023939")]
		[Address(RVA = "0x1E37330", Offset = "0x1E35F30", VA = "0x181E37330")]
		public void OnConfirmBtnClicked()
		{
		}

		// Token: 0x0602393A RID: 145722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602393A")]
		[Address(RVA = "0x1E374A0", Offset = "0x1E360A0", VA = "0x181E374A0", Slot = "18")]
		protected override void OnRender(CarvingConfirmDialogInPage.Option options)
		{
		}

		// Token: 0x0602393B RID: 145723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602393B")]
		[Address(RVA = "0x1E37410", Offset = "0x1E36010", VA = "0x181E37410", Slot = "11")]
		protected override void OnDestroySubClass()
		{
		}

		// Token: 0x0602393C RID: 145724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602393C")]
		[Address(RVA = "0x1E371F0", Offset = "0x1E35DF0", VA = "0x181E371F0", Slot = "15")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0602393D RID: 145725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602393D")]
		[Address(RVA = "0x1E37830", Offset = "0x1E36430", VA = "0x181E37830")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602393E RID: 145726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602393E")]
		[Address(RVA = "0x1E37A70", Offset = "0x1E36670", VA = "0x181E37A70")]
		private void _Render(CarvingConfirmDialogInPage.Option options)
		{
		}

		// Token: 0x0602393F RID: 145727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602393F")]
		[Address(RVA = "0x1E37940", Offset = "0x1E36540", VA = "0x181E37940")]
		private void _OnBackPressed()
		{
		}

		// Token: 0x06023940 RID: 145728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023940")]
		[Address(RVA = "0x1E376D0", Offset = "0x1E362D0", VA = "0x181E376D0")]
		private void _GenerateEnterAnim()
		{
		}

		// Token: 0x06023941 RID: 145729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023941")]
		[Address(RVA = "0x1E37D00", Offset = "0x1E36900", VA = "0x181E37D00")]
		public CarvingConfirmDialogInPage()
		{
		}

		// Token: 0x06023942 RID: 145730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023942")]
		[Address(RVA = "0x1E376C0", Offset = "0x1E362C0", VA = "0x181E376C0")]
		private void <>xLuaBaseProxy_OnDestroySubClass()
		{
		}

		// Token: 0x06023943 RID: 145731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023943")]
		[Address(RVA = "0xE613B0", Offset = "0xE5FFB0", VA = "0x180E613B0")]
		private UIRenderTextureImage <>xLuaBaseProxy_GetBlurTarget()
		{
			return null;
		}

		// Token: 0x040313C2 RID: 201666
		[Token(Token = "0x40313C2")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x040313C3 RID: 201667
		[Token(Token = "0x40313C3")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIRenderTextureImage _blurBg;

		// Token: 0x040313C4 RID: 201668
		[Token(Token = "0x40313C4")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RectTransform _backRt;

		// Token: 0x040313C5 RID: 201669
		[Token(Token = "0x40313C5")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _descText;

		// Token: 0x040313C6 RID: 201670
		[Token(Token = "0x40313C6")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text _cancelText;

		// Token: 0x040313C7 RID: 201671
		[Token(Token = "0x40313C7")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Text _confirmText;

		// Token: 0x040313C8 RID: 201672
		[Token(Token = "0x40313C8")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private TwoStateToggle _confirmBgToggle;

		// Token: 0x040313C9 RID: 201673
		[Token(Token = "0x40313C9")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_isInited;

		// Token: 0x040313CA RID: 201674
		[Token(Token = "0x40313CA")]
		[FieldOffset(Offset = "0xB8")]
		private Tween m_enterAnim;

		// Token: 0x040313CB RID: 201675
		[Token(Token = "0x40313CB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCancelBtnClicked;

		// Token: 0x040313CC RID: 201676
		[Token(Token = "0x40313CC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnConfirmBtnClicked;

		// Token: 0x040313CD RID: 201677
		[Token(Token = "0x40313CD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x040313CE RID: 201678
		[Token(Token = "0x40313CE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDestroySubClass;

		// Token: 0x040313CF RID: 201679
		[Token(Token = "0x40313CF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x040313D0 RID: 201680
		[Token(Token = "0x40313D0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040313D1 RID: 201681
		[Token(Token = "0x40313D1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x040313D2 RID: 201682
		[Token(Token = "0x40313D2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnBackPressed;

		// Token: 0x040313D3 RID: 201683
		[Token(Token = "0x40313D3")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GenerateEnterAnim;

		// Token: 0x040313D4 RID: 201684
		[Token(Token = "0x40313D4")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006016 RID: 24598
		[Token(Token = "0x2006016")]
		public class Option : IHotfixable
		{
			// Token: 0x06023944 RID: 145732 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023944")]
			[Address(RVA = "0x1E3EE70", Offset = "0x1E3DA70", VA = "0x181E3EE70")]
			public Option()
			{
			}

			// Token: 0x040313D5 RID: 201685
			[Token(Token = "0x40313D5")]
			[FieldOffset(Offset = "0x10")]
			public string descStr;

			// Token: 0x040313D6 RID: 201686
			[Token(Token = "0x40313D6")]
			[FieldOffset(Offset = "0x18")]
			public string cancelStr;

			// Token: 0x040313D7 RID: 201687
			[Token(Token = "0x40313D7")]
			[FieldOffset(Offset = "0x20")]
			public string confirmStr;

			// Token: 0x040313D8 RID: 201688
			[Token(Token = "0x40313D8")]
			[FieldOffset(Offset = "0x28")]
			public CarvingConfirmDialogType dialogType;

			// Token: 0x040313D9 RID: 201689
			[Token(Token = "0x40313D9")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
