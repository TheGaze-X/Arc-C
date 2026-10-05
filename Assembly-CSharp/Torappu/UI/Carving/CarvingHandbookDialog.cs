using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x0200601B RID: 24603
	[Token(Token = "0x200601B")]
	public class CarvingHandbookDialog : UICompDialog<CarvingHandbookDialog.Options>, IHotfixable
	{
		// Token: 0x0602395D RID: 145757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602395D")]
		[Address(RVA = "0x1E38D60", Offset = "0x1E37960", VA = "0x181E38D60", Slot = "18")]
		protected override void OnRender(CarvingHandbookDialog.Options input)
		{
		}

		// Token: 0x0602395E RID: 145758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602395E")]
		[Address(RVA = "0x1E38D00", Offset = "0x1E37900", VA = "0x181E38D00", Slot = "15")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0602395F RID: 145759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602395F")]
		[Address(RVA = "0x1E38FA0", Offset = "0x1E37BA0", VA = "0x181E38FA0")]
		private void _EventOnEnterAnimFinished()
		{
		}

		// Token: 0x06023960 RID: 145760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023960")]
		[Address(RVA = "0x1E39000", Offset = "0x1E37C00", VA = "0x181E39000")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06023961 RID: 145761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023961")]
		[Address(RVA = "0x1E38C30", Offset = "0x1E37830", VA = "0x181E38C30")]
		public void EventOnBackClicked()
		{
		}

		// Token: 0x06023962 RID: 145762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023962")]
		[Address(RVA = "0x1E39120", Offset = "0x1E37D20", VA = "0x181E39120")]
		public CarvingHandbookDialog()
		{
		}

		// Token: 0x06023963 RID: 145763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023963")]
		[Address(RVA = "0xE613B0", Offset = "0xE5FFB0", VA = "0x180E613B0")]
		private UIRenderTextureImage <>xLuaBaseProxy_GetBlurTarget()
		{
			return null;
		}

		// Token: 0x04031403 RID: 201731
		[Token(Token = "0x4031403")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _rectBack;

		// Token: 0x04031404 RID: 201732
		[Token(Token = "0x4031404")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIRenderTextureImage _blurBg;

		// Token: 0x04031405 RID: 201733
		[Token(Token = "0x4031405")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _darkenImgObj;

		// Token: 0x04031406 RID: 201734
		[Token(Token = "0x4031406")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x04031407 RID: 201735
		[Token(Token = "0x4031407")]
		[FieldOffset(Offset = "0x98")]
		private bool m_hasInited;

		// Token: 0x04031408 RID: 201736
		[Token(Token = "0x4031408")]
		[FieldOffset(Offset = "0x99")]
		private bool m_hasAnimFinished;

		// Token: 0x04031409 RID: 201737
		[Token(Token = "0x4031409")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0403140A RID: 201738
		[Token(Token = "0x403140A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x0403140B RID: 201739
		[Token(Token = "0x403140B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__EventOnEnterAnimFinished;

		// Token: 0x0403140C RID: 201740
		[Token(Token = "0x403140C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403140D RID: 201741
		[Token(Token = "0x403140D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnBackClicked;

		// Token: 0x0403140E RID: 201742
		[Token(Token = "0x403140E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200601C RID: 24604
		[Token(Token = "0x200601C")]
		public class Options
		{
			// Token: 0x06023964 RID: 145764 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023964")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Options()
			{
			}

			// Token: 0x0403140F RID: 201743
			[Token(Token = "0x403140F")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x04031410 RID: 201744
			[Token(Token = "0x4031410")]
			[FieldOffset(Offset = "0x18")]
			public bool isNeedDarken;
		}
	}
}
