using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007809 RID: 30729
	[Token(Token = "0x2007809")]
	public class Act1VHalfIdleTechTreeNodeDetailEffectItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602B1C8 RID: 176584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B1C8")]
		[Address(RVA = "0x26FC860", Offset = "0x26FB460", VA = "0x1826FC860")]
		public void RenderView(Act1VHalfIdleTechTreeData.Effect effData)
		{
		}

		// Token: 0x0602B1C9 RID: 176585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B1C9")]
		[Address(RVA = "0x26FCB90", Offset = "0x26FB790", VA = "0x1826FCB90")]
		private Sprite _FindIcon(string iconName)
		{
			return null;
		}

		// Token: 0x0602B1CA RID: 176586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B1CA")]
		[Address(RVA = "0x26FCCD0", Offset = "0x26FB8D0", VA = "0x1826FCCD0")]
		public Act1VHalfIdleTechTreeNodeDetailEffectItemView()
		{
		}

		// Token: 0x0403E4C5 RID: 255173
		[Token(Token = "0x403E4C5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Sprite[] _iconRes;

		// Token: 0x0403E4C6 RID: 255174
		[Token(Token = "0x403E4C6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _iconImage;

		// Token: 0x0403E4C7 RID: 255175
		[Token(Token = "0x403E4C7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _titleText;

		// Token: 0x0403E4C8 RID: 255176
		[Token(Token = "0x403E4C8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _descText;

		// Token: 0x0403E4C9 RID: 255177
		[Token(Token = "0x403E4C9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x0403E4CA RID: 255178
		[Token(Token = "0x403E4CA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__FindIcon;

		// Token: 0x0403E4CB RID: 255179
		[Token(Token = "0x403E4CB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
