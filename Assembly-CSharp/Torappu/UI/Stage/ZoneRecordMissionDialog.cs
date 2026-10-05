using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020069EC RID: 27116
	[Token(Token = "0x20069EC")]
	public class ZoneRecordMissionDialog : UICustomDialog<ZoneRecordMissionDialog.Options>
	{
		// Token: 0x06026C77 RID: 158839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C77")]
		[Address(RVA = "0x21E0610", Offset = "0x21DF210", VA = "0x1821E0610", Slot = "8")]
		protected override void OnInit()
		{
		}

		// Token: 0x06026C78 RID: 158840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C78")]
		[Address(RVA = "0x21E0730", Offset = "0x21DF330", VA = "0x1821E0730", Slot = "7")]
		protected override void OnRender(ZoneRecordMissionDialog.Options options)
		{
		}

		// Token: 0x06026C79 RID: 158841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026C79")]
		[Address(RVA = "0x21E05B0", Offset = "0x21DF1B0", VA = "0x1821E05B0", Slot = "10")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x06026C7A RID: 158842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C7A")]
		[Address(RVA = "0x21E0540", Offset = "0x21DF140", VA = "0x1821E0540")]
		public void EventOnConfirm()
		{
		}

		// Token: 0x06026C7B RID: 158843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C7B")]
		[Address(RVA = "0x21E07D0", Offset = "0x21DF3D0", VA = "0x1821E07D0")]
		public ZoneRecordMissionDialog()
		{
		}

		// Token: 0x04036C93 RID: 224403
		[Token(Token = "0x4036C93")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIRenderTextureImage _blurBg;

		// Token: 0x04036C94 RID: 224404
		[Token(Token = "0x4036C94")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _missionDesc;

		// Token: 0x04036C95 RID: 224405
		[Token(Token = "0x4036C95")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _backRt;

		// Token: 0x04036C96 RID: 224406
		[Token(Token = "0x4036C96")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04036C97 RID: 224407
		[Token(Token = "0x4036C97")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04036C98 RID: 224408
		[Token(Token = "0x4036C98")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x04036C99 RID: 224409
		[Token(Token = "0x4036C99")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnConfirm;

		// Token: 0x04036C9A RID: 224410
		[Token(Token = "0x4036C9A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020069ED RID: 27117
		[Token(Token = "0x20069ED")]
		public struct Options
		{
			// Token: 0x04036C9B RID: 224411
			[Token(Token = "0x4036C9B")]
			[FieldOffset(Offset = "0x0")]
			public string desc;
		}
	}
}
