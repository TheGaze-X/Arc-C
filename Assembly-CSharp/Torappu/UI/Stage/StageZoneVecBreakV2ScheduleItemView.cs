using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006944 RID: 26948
	[Token(Token = "0x2006944")]
	public class StageZoneVecBreakV2ScheduleItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06026956 RID: 158038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026956")]
		[Address(RVA = "0x21B9420", Offset = "0x21B8020", VA = "0x1821B9420")]
		public void Render(VecBreakV2SchedulePartModel scheduleModel, Color colorActiveBg, Color colorActiveText)
		{
		}

		// Token: 0x06026957 RID: 158039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026957")]
		[Address(RVA = "0x21B9610", Offset = "0x21B8210", VA = "0x1821B9610")]
		public StageZoneVecBreakV2ScheduleItemView()
		{
		}

		// Token: 0x040366E4 RID: 222948
		[Token(Token = "0x40366E4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textNum;

		// Token: 0x040366E5 RID: 222949
		[Token(Token = "0x40366E5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasImage _imgBg;

		// Token: 0x040366E6 RID: 222950
		[Token(Token = "0x40366E6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color _colorIncomingBg;

		// Token: 0x040366E7 RID: 222951
		[Token(Token = "0x40366E7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color _colorIncomingText;

		// Token: 0x040366E8 RID: 222952
		[Token(Token = "0x40366E8")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _colorExpireBg;

		// Token: 0x040366E9 RID: 222953
		[Token(Token = "0x40366E9")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Color _colorExpireText;

		// Token: 0x040366EA RID: 222954
		[Token(Token = "0x40366EA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040366EB RID: 222955
		[Token(Token = "0x40366EB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
