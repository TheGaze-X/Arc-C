using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess.CharSelect
{
	// Token: 0x020063B6 RID: 25526
	[Token(Token = "0x20063B6")]
	public class AutoChessCharSelectDetailBondView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170056E1 RID: 22241
		// (get) Token: 0x06024CD3 RID: 150739 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024CD4 RID: 150740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170056E1")]
		public ILoadAsset loader
		{
			[Token(Token = "0x6024CD3")]
			[Address(RVA = "0x1F9BCF0", Offset = "0x1F9A8F0", VA = "0x181F9BCF0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6024CD4")]
			[Address(RVA = "0x1F9BD50", Offset = "0x1F9A950", VA = "0x181F9BD50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06024CD5 RID: 150741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024CD5")]
		[Address(RVA = "0x1F9BAF0", Offset = "0x1F9A6F0", VA = "0x181F9BAF0")]
		public void Render(AutoChessShopCharChessBondModel model)
		{
		}

		// Token: 0x06024CD6 RID: 150742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024CD6")]
		[Address(RVA = "0x1F9BC90", Offset = "0x1F9A890", VA = "0x181F9BC90")]
		public AutoChessCharSelectDetailBondView()
		{
		}

		// Token: 0x04033713 RID: 210707
		[Token(Token = "0x4033713")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _iconImage;

		// Token: 0x04033714 RID: 210708
		[Token(Token = "0x4033714")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _nameText;

		// Token: 0x04033715 RID: 210709
		[Token(Token = "0x4033715")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _descText;

		// Token: 0x04033717 RID: 210711
		[Token(Token = "0x4033717")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_loader;

		// Token: 0x04033718 RID: 210712
		[Token(Token = "0x4033718")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_loader;

		// Token: 0x04033719 RID: 210713
		[Token(Token = "0x4033719")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403371A RID: 210714
		[Token(Token = "0x403371A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
