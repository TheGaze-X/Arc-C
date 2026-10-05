using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.Stage
{
	// Token: 0x020069C4 RID: 27076
	[Token(Token = "0x20069C4")]
	public class StageZoneTabWeeklyPlugin : StageZoneTabView.IPlugin
	{
		// Token: 0x06026BE3 RID: 158691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026BE3")]
		[Address(RVA = "0x21D9DE0", Offset = "0x21D89E0", VA = "0x1821D9DE0", Slot = "4")]
		public override void RefreshTargetImg(StageZoneTabViewModel viewModel, bool isBlack, ref Image pic, out bool needFadeColor)
		{
		}

		// Token: 0x06026BE4 RID: 158692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026BE4")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public StageZoneTabWeeklyPlugin()
		{
		}

		// Token: 0x04036B5C RID: 224092
		[Token(Token = "0x4036B5C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Sprite _activeForceOpenIcon;

		// Token: 0x04036B5D RID: 224093
		[Token(Token = "0x4036B5D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite _unactiveForceOpenIcon;

		// Token: 0x04036B5E RID: 224094
		[Token(Token = "0x4036B5E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _iconImg;

		// Token: 0x04036B5F RID: 224095
		[Token(Token = "0x4036B5F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _commonIconImg;

		// Token: 0x04036B60 RID: 224096
		[Token(Token = "0x4036B60")]
		private const float FIX_DURATION = 0.3f;

		// Token: 0x04036B61 RID: 224097
		[Token(Token = "0x4036B61")]
		[FieldOffset(Offset = "0x38")]
		private Tweener m_cacheTweenerIcon;

		// Token: 0x04036B62 RID: 224098
		[Token(Token = "0x4036B62")]
		[FieldOffset(Offset = "0x40")]
		private Tweener m_cacheTweenerCommon;

		// Token: 0x04036B63 RID: 224099
		[Token(Token = "0x4036B63")]
		private const string BLACK_UNSELECT = "313131CC";

		// Token: 0x04036B64 RID: 224100
		[Token(Token = "0x4036B64")]
		private const string BLACK_SELECT = "ffffff33";

		// Token: 0x04036B65 RID: 224101
		[Token(Token = "0x4036B65")]
		private const string WHITE_UNSELECT = "ffffffCC";
	}
}
