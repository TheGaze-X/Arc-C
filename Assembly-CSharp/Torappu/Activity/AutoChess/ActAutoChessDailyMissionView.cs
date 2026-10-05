using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x020070E8 RID: 28904
	[Token(Token = "0x20070E8")]
	public class ActAutoChessDailyMissionView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602916D RID: 168301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602916D")]
		[Address(RVA = "0x247DD30", Offset = "0x247C930", VA = "0x18247DD30")]
		public void Render(ActAutoChessDailyMissionViewModel model)
		{
		}

		// Token: 0x0602916E RID: 168302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602916E")]
		[Address(RVA = "0x247DF20", Offset = "0x247CB20", VA = "0x18247DF20")]
		public ActAutoChessDailyMissionView()
		{
		}

		// Token: 0x0403AA34 RID: 240180
		[Token(Token = "0x403AA34")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textTitle;

		// Token: 0x0403AA35 RID: 240181
		[Token(Token = "0x403AA35")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0403AA36 RID: 240182
		[Token(Token = "0x403AA36")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textValue;

		// Token: 0x0403AA37 RID: 240183
		[Token(Token = "0x403AA37")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textTarget;

		// Token: 0x0403AA38 RID: 240184
		[Token(Token = "0x403AA38")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Slider _slider;

		// Token: 0x0403AA39 RID: 240185
		[Token(Token = "0x403AA39")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403AA3A RID: 240186
		[Token(Token = "0x403AA3A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
