using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.TemplateMission
{
	// Token: 0x02003D92 RID: 15762
	[Token(Token = "0x2003D92")]
	public class TemplateMissionCommonBigRewardWithPicRewardView : TemplateMissionBigRewardView
	{
		// Token: 0x06018849 RID: 100425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018849")]
		[Address(RVA = "0x110B0D0", Offset = "0x1109CD0", VA = "0x18110B0D0", Slot = "8")]
		public override void Init(AbstractTemplateMissionViewController ctrl_, TemplateMissionCustomResHolder customResHolder_)
		{
		}

		// Token: 0x0601884A RID: 100426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601884A")]
		[Address(RVA = "0x110B170", Offset = "0x1109D70", VA = "0x18110B170", Slot = "9")]
		protected override void RenderView()
		{
		}

		// Token: 0x0601884B RID: 100427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601884B")]
		[Address(RVA = "0x110B410", Offset = "0x110A010", VA = "0x18110B410")]
		public TemplateMissionCommonBigRewardWithPicRewardView()
		{
		}

		// Token: 0x0601884C RID: 100428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601884C")]
		[Address(RVA = "0x1109AC0", Offset = "0x11086C0", VA = "0x181109AC0")]
		private void <>xLuaBaseProxy_Init(AbstractTemplateMissionViewController P0, TemplateMissionCustomResHolder P1)
		{
		}

		// Token: 0x0401E0E3 RID: 123107
		[Token(Token = "0x401E0E3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _picImg;

		// Token: 0x0401E0E4 RID: 123108
		[Token(Token = "0x401E0E4")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _offsetContainer;

		// Token: 0x0401E0E5 RID: 123109
		[Token(Token = "0x401E0E5")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TemplateMissionCommonEntryFadeTween _entryTween;

		// Token: 0x0401E0E6 RID: 123110
		[Token(Token = "0x401E0E6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0401E0E7 RID: 123111
		[Token(Token = "0x401E0E7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x0401E0E8 RID: 123112
		[Token(Token = "0x401E0E8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
